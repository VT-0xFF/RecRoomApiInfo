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
public struct FJKMMDGJDMP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode KCMJAPCDOBM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly FJKMMDGJDMP MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct ECMDPPDFOFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public EPCBEODPNAD KBONFFBNGBI;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly ECMDPPDFOFE MHJMHHILEFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IFFFADIBFPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FCCMCIAIKGI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum EPCBEODPNAD
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
public struct OKEDIOBOGJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct KOFHIOLGLCL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity AHDACGEMPDI;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LIMAOAHMJOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity EGNCPOLPGCD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly LIMAOAHMJOO MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HFJMFHIFLBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity JBBMOMLGMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly HFJMFHIFLBI MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FEMFPADICHP : HPFKDEBDLEN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KCHDKMDKNCF AHFGFNJIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KCHDKMDKNCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JFFECEJLOAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3 ECHGAJNMCCL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MAFGCCBPBJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PBHOODNGHLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 HLDBEIJOEKL;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly PBHOODNGHLK MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BBILNIAGPLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public quaternion BLAJLNBBJPO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly BBILNIAGPLE MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NOOMLOHPIEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 DCMFFMCPDHB;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly NOOMLOHPIEM MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KNEBMMEMGHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float NOCBBNJBDEN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly KNEBMMEMGHJ MHJMHHILEFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OFJOCIBKOJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MEBJCHLDFGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float GPPOEDICKIJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly MEBJCHLDFGI MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OCOFPOPPNAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float3 OMOKNEBIHJG;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EIHGKIDJAPF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CGACPKIAMLK FBGDMAMAKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly EIHGKIDJAPF MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GMNEGDPBFCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public CGACPKIAMLK IEDCEKMBMFC;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly GMNEGDPBFCH MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CBLONAMFFKG : HPFKDEBDLEN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public KCHDKMDKNCF AHFGFNJIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KCHDKMDKNCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BILEFBHPKPL : HPFKDEBDLEN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public KCHDKMDKNCF AHFGFNJIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KCHDKMDKNCF);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EEGOMMAPMJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JNHMAEJCMIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LGIPAKFBION : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JACOBCGAONE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public RigidbodyConstraints EPIHGOPBDJF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly JACOBCGAONE MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HPKJBLGBIPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float JCBIJBJMIEK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly HPKJBLGBIPH MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HDDAJOBALNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float JCCKBBGLGIH;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly HDDAJOBALNM MHJMHHILEFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct IKCIHJLEEJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DJLBJNLBEBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int FNPGFDAENNA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly DJLBJNLBEBH MHJMHHILEFG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x80ACC0", Offset = "0x8096C0", VA = "0x18080ACC0")]
	public static DJLBJNLBEBH MFJMDPBHOLK(int NKJMIDIDBOE)
	{
		return default(DJLBJNLBEBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GPBPKFKPCMK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Rigidbody DBADIFDDPED;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A7B0", Offset = "0x5F191B0", VA = "0x185F1A7B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public GPBPKFKPCMK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct OJCKCPHBHJL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DPPDDMOPGCK : HPFKDEBDLEN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public KCHDKMDKNCF AHFGFNJIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KCHDKMDKNCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct MFHICEBPMBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float LBKAOOHPAAE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly MFHICEBPMBB MHJMHHILEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct AHFFEELGGGD : HPFKDEBDLEN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KCHDKMDKNCF AHFGFNJIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KCHDKMDKNCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class AAKDENDAOFK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object OLALLIGPPOD;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A0A0", Offset = "0x5F18AA0", VA = "0x185F1A0A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public AAKDENDAOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OICJKNHKLFL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public object LKNPONBMLEA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F1B3C0", Offset = "0x5F19DC0", VA = "0x185F1B3C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public OICJKNHKLFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum CGACPKIAMLK
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum AGMKNMDKBEI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GNFFCDBPNKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJAHEMMCGJO(EPCBEODPNAD MBLJJEDHFIJ, EPCBEODPNAD AIHDKFPKDOC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIFPIGHEFKC();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NEKFJCAOBKP();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBNFCHHDLDE(bool IBEPDLDJDDF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JHHAGLFMHGM();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KGJHHHPJCHM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public GNFFCDBPNKD PIPEHEAFEAI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1ABE0", Offset = "0x5F195E0", VA = "0x185F1ABE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public KGJHHHPJCHM()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[InternalBufferCapacity(8)]
	[AEGODFPPHJA(1)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, LOEAICEFKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3295650", Offset = "0x3294050", VA = "0x183295650", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[AEGODFPPHJA(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[FEEAOJNJCBD(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[FEEAOJNJCBD(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x20CB660", Offset = "0x20CA060", VA = "0x1820CB660")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A170", Offset = "0x5F18B70", VA = "0x185F1A170")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[AEGODFPPHJA(1)]
	public struct AuthoredParentData : IComponentData, LOEAICEFKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[FEEAOJNJCBD(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A1A0", Offset = "0x5F18BA0", VA = "0x185F1A1A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DGLJGKMGIBN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct EBOBIFNOFII : ISystemStateComponentData, IComponentData, LOEAICEFKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity OBKNMKIHHJO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity JJOCMFPMKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JAMNNEDJPAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct PHJKBFECKLM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int GGLJLEEFAFM;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KCNKLPEBKJE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GCHandle JNOFDBGOEGB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[BPCNCBPADKO(1)]
	[AEGODFPPHJA(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[FEEAOJNJCBD(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[FEEAOJNJCBD(2)]
		public SerializableGuid graphId;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
[EOMDGAJGDFJ(0, 15)]
public enum JKGKMKNCGCK
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
[EOMDGAJGDFJ(0, 2)]
public enum ILFCAHPCFIC
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
	[FDHMHIPEABO("Container", 0)]
	[AEGODFPPHJA(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[FEEAOJNJCBD(1)]
		[PEJOHPJKFEE(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[NOBIKILNGLB]
		[FEEAOJNJCBD(2)]
		[PEJOHPJKFEE(0)]
		public ILFCAHPCFIC collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[NOBIKILNGLB]
		[FEEAOJNJCBD(3)]
		[PEJOHPJKFEE(0)]
		public JKGKMKNCGCK collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[NOBIKILNGLB]
		[PEJOHPJKFEE(0)]
		[FEEAOJNJCBD(4)]
		public IGENPKOHOMC grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[NOBIKILNGLB]
		[FEEAOJNJCBD(5)]
		[PEJOHPJKFEE(0)]
		public FDGBKKGPILE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[NOBIKILNGLB]
		[FEEAOJNJCBD(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A210", Offset = "0x5F18C10", VA = "0x185F1A210", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Flags]
[EOMDGAJGDFJ(0, 16071)]
public enum FDGBKKGPILE
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
[EOMDGAJGDFJ(0, 1)]
public enum IGENPKOHOMC
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
[BPCNCBPADKO(1)]
public struct JCABKIINGOJ : IComparable<JCABKIINGOJ>, IEquatable<JCABKIINGOJ>, BIJJBGJKJCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[JLADIJPIHKH(1)]
	public uint KINJFJKADFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[JLADIJPIHKH(2)]
	public uint MFMFPGIBKIJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private uint BAOPNLGJLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A860", Offset = "0x5F19260", VA = "0x185F1A860")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AB90", Offset = "0x5F19590", VA = "0x185F1AB90")]
	public JCABKIINGOJ(int KINJFJKADFC, int LLJPFEFMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AB90", Offset = "0x5F19590", VA = "0x185F1AB90")]
	public JCABKIINGOJ(uint KINJFJKADFC, uint LLJPFEFMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AA00", Offset = "0x5F19400", VA = "0x185F1AA00")]
	private static uint MMMPADCOAJG(uint LDIEPFCHCFG, uint KCHCODPDAGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A870", Offset = "0x5F19270", VA = "0x185F1A870", Slot = "4")]
	public int CompareTo(JCABKIINGOJ BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A8B0", Offset = "0x5F192B0", VA = "0x185F1A8B0", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AAB0", Offset = "0x5F194B0", VA = "0x185F1AAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A890", Offset = "0x5F19290", VA = "0x185F1A890", Slot = "5")]
	public bool Equals(JCABKIINGOJ BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A9B0", Offset = "0x5F193B0", VA = "0x185F1A9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AA30", Offset = "0x5F19430", VA = "0x185F1AA30", Slot = "6")]
	public void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A940", Offset = "0x5F19340", VA = "0x185F1A940", Slot = "7")]
	public void GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x25E96F0", Offset = "0x25E80F0", VA = "0x1825E96F0")]
	public static bool MOBCKBANPBO(JCABKIINGOJ KNOBMILOMGN, JCABKIINGOJ FJNJPMOOBMK)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[BPCNCBPADKO(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[JLADIJPIHKH(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[JLADIJPIHKH(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[JLADIJPIHKH(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[JLADIJPIHKH(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[BPCNCBPADKO(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, BIJJBGJKJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[JLADIJPIHKH(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB93020", Offset = "0xB91A20", VA = "0x180B93020")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB93020", Offset = "0xB91A20", VA = "0x180B93020")]
		public static SerializableGuid MFJMDPBHOLK(Guid CAPPBFKKCMA)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B760", Offset = "0x5F1A160", VA = "0x185F1B760", Slot = "4")]
		public bool Equals(SerializableGuid BPKBHFMGOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B740", Offset = "0x5F1A140", VA = "0x185F1B740", Slot = "5")]
		public int CompareTo(SerializableGuid BPKBHFMGOOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B870", Offset = "0x5F1A270", VA = "0x185F1B870", Slot = "6")]
		public void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B7F0", Offset = "0x5F1A1F0", VA = "0x185F1B7F0", Slot = "7")]
		public void GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B970", Offset = "0x5F1A370", VA = "0x185F1B970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[AEGODFPPHJA(1)]
	[ABEPJCHAMNC("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[AEGODFPPHJA(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[FEEAOJNJCBD(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[FEEAOJNJCBD(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[EOMDGAJGDFJ(0, 4)]
public enum ANCPEPLHJEH
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
	[AEGODFPPHJA(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[FEEAOJNJCBD(1)]
		public ANCPEPLHJEH gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[AEGODFPPHJA(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[FEEAOJNJCBD(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[FEEAOJNJCBD(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[FEEAOJNJCBD(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[AEGODFPPHJA(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[FEEAOJNJCBD(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[FEEAOJNJCBD(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[FEEAOJNJCBD(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[FEEAOJNJCBD(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[FEEAOJNJCBD(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[AEGODFPPHJA(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[FEEAOJNJCBD(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[FEEAOJNJCBD(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[FEEAOJNJCBD(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[InternalBufferCapacity(8)]
	[AEGODFPPHJA(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, LOEAICEFKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3295650", Offset = "0x3294050", VA = "0x183295650", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[AEGODFPPHJA(1)]
	public struct ParentData : IComponentData, LOEAICEFKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[FEEAOJNJCBD(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct PBCNGDCKPOL : ISystemStateComponentData, IComponentData, LOEAICEFKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity OBKNMKIHHJO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Entity JJOCMFPMKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0")]
	public PBCNGDCKPOL(Entity EGNCPOLPGCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	public static PBCNGDCKPOL MFJMDPBHOLK(Entity EBOGCLNNJGN)
	{
		return default(PBCNGDCKPOL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct JCBNCCOCPAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LOEAICEFKPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity DOCCAFEJPOE
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
	[AEGODFPPHJA(1)]
	[FDHMHIPEABO("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[FEEAOJNJCBD(1)]
		[PEJOHPJKFEE(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[PEJOHPJKFEE(0)]
		[FEEAOJNJCBD(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[FEEAOJNJCBD(3)]
		[PEJOHPJKFEE(0)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[FDHMHIPEABO("Light", 0)]
	[AEGODFPPHJA(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[PEJOHPJKFEE(0)]
		[FEEAOJNJCBD(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AEGODFPPHJA(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public uint networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B480", Offset = "0x5F19E80", VA = "0x185F1B480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[EOMDGAJGDFJ(0, 4)]
public enum OGICMKKEDKM
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
public struct PKDNKOEBNEI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CLFDNHAPOFL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int GGLJLEEFAFM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MAAKMNIDCOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MCFDCLHJELN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AEGODFPPHJA(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[FEEAOJNJCBD(1)]
		public JKHCLAMJDBM flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[FEEAOJNJCBD(2)]
		public LPABPOIMJLI scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class DOBFAMENKAP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A460", Offset = "0x5F18E60", VA = "0x185F1A460")]
	public static JKHCLAMJDBM MJIKPLNABDE(this JKHCLAMJDBM ALIOHCFALJN, FFMAPKOAMBM JMHNKLGJEJK)
	{
		return default(JKHCLAMJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A490", Offset = "0x5F18E90", VA = "0x185F1A490")]
	public static JKHCLAMJDBM OMBMHDCIFDM(this JKHCLAMJDBM ALIOHCFALJN, FFMAPKOAMBM JMHNKLGJEJK)
	{
		return default(JKHCLAMJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A470", Offset = "0x5F18E70", VA = "0x185F1A470")]
	public static JKHCLAMJDBM NLKBLCELEBP(this JKHCLAMJDBM ALIOHCFALJN, FFMAPKOAMBM JMHNKLGJEJK, bool IKDLNNIHFIK)
	{
		return default(JKHCLAMJDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A440", Offset = "0x5F18E40", VA = "0x185F1A440")]
	public static bool EPNBIAGEOLL(this JKHCLAMJDBM ALIOHCFALJN, FFMAPKOAMBM JMHNKLGJEJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum FFMAPKOAMBM
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
[EOMDGAJGDFJ(0, 16383)]
public enum JKHCLAMJDBM
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
[BPCNCBPADKO(1)]
public struct LPABPOIMJLI : BIJJBGJKJCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[JLADIJPIHKH(1)]
	public bool GCNBMKKLBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[JLADIJPIHKH(2)]
	public float3 KEKBPLANDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[JLADIJPIHKH(3)]
	public float3 EJAGICNACLC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AE60", Offset = "0x5F19860", VA = "0x185F1AE60", Slot = "5")]
	public void GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5F1AF60", Offset = "0x5F19960", VA = "0x185F1AF60", Slot = "4")]
	public void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[BPCNCBPADKO(1)]
public struct DDOKJFHMAIJ : BIJJBGJKJCO, IEquatable<DDOKJFHMAIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[JLADIJPIHKH(1)]
	public int ENFGKNDHLNI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x760940", Offset = "0x75F340", VA = "0x180760940")]
	public DDOKJFHMAIJ(int ENFGKNDHLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A3A0", Offset = "0x5F18DA0", VA = "0x185F1A3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A2F0", Offset = "0x5F18CF0", VA = "0x185F1A2F0", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F56E0", Offset = "0x7F40E0", VA = "0x1807F56E0", Slot = "6")]
	public bool Equals(DDOKJFHMAIJ BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x13C9320", Offset = "0x13C7D20", VA = "0x1813C9320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A370", Offset = "0x5F18D70", VA = "0x185F1A370", Slot = "5")]
	public void GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A410", Offset = "0x5F18E10", VA = "0x185F1A410", Slot = "4")]
	public void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[AEGODFPPHJA(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[FEEAOJNJCBD(1)]
		public DDOKJFHMAIJ customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[EOMDGAJGDFJ(0, 1)]
public enum GCNDNEEMOEB
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
	[AEGODFPPHJA(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[FEEAOJNJCBD(1)]
		public GCNDNEEMOEB propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct JMFBOPABKJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct IFDHHBMOHMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct FPLDHACHBKA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct ODLGOPBPJFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public FixedString32 KKJOOAJGLJI;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[LLOBOEAEPHK]
public struct MHBHJDOFLLH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Entity HJLNDBMKNHI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	public static MHBHJDOFLLH MFJMDPBHOLK(Entity NKJMIDIDBOE)
	{
		return default(MHBHJDOFLLH);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[AEGODFPPHJA(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[FEEAOJNJCBD(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct MEDOIICOLPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Entity EBOGCLNNJGN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	public static MEDOIICOLPL MFJMDPBHOLK(Entity EBOGCLNNJGN)
	{
		return default(MEDOIICOLPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct BLLLCIEGDNM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Entity IFAMAIHGCAO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	public static BLLLCIEGDNM MFJMDPBHOLK(Entity EBOGCLNNJGN)
	{
		return default(BLLLCIEGDNM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct NOFHDMDDAGG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[FDHMHIPEABO("Physics", 0)]
	[AEGODFPPHJA(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[FEEAOJNJCBD(1)]
		[PEJOHPJKFEE(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[AEGODFPPHJA(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[FEEAOJNJCBD(1)]
		public BKPIKMGJOND shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[EOMDGAJGDFJ(-1, 18)]
public enum BKPIKMGJOND
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
	[AEGODFPPHJA(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[Flags]
		[EOMDGAJGDFJ(0, 7)]
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
		[FEEAOJNJCBD(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5F1B9C0", Offset = "0x5F1A3C0", VA = "0x185F1B9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5F1BA40", Offset = "0x5F1A440", VA = "0x185F1BA40")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[EOMDGAJGDFJ(0, 2)]
public enum NGMMOLHJJBP
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
	[AEGODFPPHJA(1)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[FEEAOJNJCBD(1)]
		public NGMMOLHJJBP shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[AEGODFPPHJA(1)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[FEEAOJNJCBD(1)]
		public JCABKIINGOJ order;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[AEGODFPPHJA(1)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[FEEAOJNJCBD(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[AEGODFPPHJA(1)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[FEEAOJNJCBD(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly SplinePointPositionData Default;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1B655C0", Offset = "0x1B63FC0", VA = "0x181B655C0")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[AEGODFPPHJA(1)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[FEEAOJNJCBD(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly SplinePointRotationData Default;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xB93020", Offset = "0xB91A20", VA = "0x180B93020")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[AEGODFPPHJA(1)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[FEEAOJNJCBD(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly SplinePointScaleData Default;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1B655C0", Offset = "0x1B63FC0", VA = "0x181B655C0")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[BPCNCBPADKO(1)]
public struct GCLBIIKJJEE : BIJJBGJKJCO
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	[EOMDGAJGDFJ(0, 7)]
	public enum IHNNPNEJEOC
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
	[JLADIJPIHKH(1)]
	public float LLKJPDMMGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[JLADIJPIHKH(2)]
	public int NGNODADMGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[JLADIJPIHKH(3)]
	public IHNNPNEJEOC ALIOHCFALJN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MJJFOPPPLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A610", Offset = "0x5F19010", VA = "0x185F1A610")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A570", Offset = "0x5F18F70", VA = "0x185F1A570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ICNBOODANLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A690", Offset = "0x5F19090", VA = "0x185F1A690")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A5F0", Offset = "0x5F18FF0", VA = "0x185F1A5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MILKNFKFIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A4F0", Offset = "0x5F18EF0", VA = "0x185F1A4F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A710", Offset = "0x5F19110", VA = "0x185F1A710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A590", Offset = "0x5F18F90", VA = "0x185F1A590", Slot = "5")]
	public void GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A730", Offset = "0x5F19130", VA = "0x185F1A730", Slot = "4")]
	public void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[AEGODFPPHJA(1)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[FEEAOJNJCBD(1)]
		public GCLBIIKJJEE parameters;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct CJIPMCCEGEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct CCANBIDJKAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct KAIENCMBDKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct PKLPBNBNIMP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct AGGNCOEOONL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal struct OPNEPPJNNID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct OJPLNADDPII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal struct FCBBHHNPDPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NJDKNDKMJKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct FIJDIIMIEJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct COIIMFKNMKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct DIPFEOHPCFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct PEAGDKPLJNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct KDHEFILJHEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct CLJJNHOBFPB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[AEGODFPPHJA(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[FEEAOJNJCBD(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[FEEAOJNJCBD(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[FEEAOJNJCBD(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[AEGODFPPHJA(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[FEEAOJNJCBD(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[FEEAOJNJCBD(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[FEEAOJNJCBD(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[FEEAOJNJCBD(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[FEEAOJNJCBD(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[FEEAOJNJCBD(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[FEEAOJNJCBD(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[FEEAOJNJCBD(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[FEEAOJNJCBD(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[FEEAOJNJCBD(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[FEEAOJNJCBD(11)]
		public CEJBCBPODIN mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[FEEAOJNJCBD(12)]
		public CDLPOBAGKNH myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[FEEAOJNJCBD(13)]
		public EDEPEIDALML myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[FEEAOJNJCBD(14)]
		public CLGMEOCEPLK myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[FEEAOJNJCBD(15)]
		public HEBJBHCDODC myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[FEEAOJNJCBD(16)]
		public AIDDCIJHNAI myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[FEEAOJNJCBD(17)]
		public DPGGHBHLPAO myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[FEEAOJNJCBD(18)]
		public BHLHFCPAMDO myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[FEEAOJNJCBD(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[FEEAOJNJCBD(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[FEEAOJNJCBD(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[FEEAOJNJCBD(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum CEJBCBPODIN : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum CDLPOBAGKNH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum EDEPEIDALML : short
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum CLGMEOCEPLK : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum HEBJBHCDODC
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum AIDDCIJHNAI : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum DPGGHBHLPAO : long
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum BHLHFCPAMDO : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[AEGODFPPHJA(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[AEGODFPPHJA(1)]
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
	[AEGODFPPHJA(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class DOKNMJINKJI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct OLLAGCKINDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector3 HGJDMLEIMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public List<SerializableGuid> LJKCPJBIDEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class ELOJNGJPAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ELOJNGJPAPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public DOKNMJINKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[LLOBOEAEPHK]
public struct BHCNLPDDHAD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public TimeData NCBNMINDEOC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB93020", Offset = "0xB91A20", VA = "0x180B93020")]
	public static BHCNLPDDHAD MFJMDPBHOLK(TimeData NKJMIDIDBOE)
	{
		return default(BHCNLPDDHAD);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[AEGODFPPHJA(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[FEEAOJNJCBD(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[AEGODFPPHJA(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[FEEAOJNJCBD(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[FEEAOJNJCBD(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x20CB660", Offset = "0x20CA060", VA = "0x1820CB660")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A170", Offset = "0x5F18B70", VA = "0x185F1A170")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A170", Offset = "0x5F18B70", VA = "0x185F1A170")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[AEGODFPPHJA(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[AEGODFPPHJA(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5F1B210", Offset = "0x5F19C10", VA = "0x185F1B210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[AEGODFPPHJA(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[FEEAOJNJCBD(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct GDMHKLDPMGF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int CAGGNMEPKPN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NENMOOINMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A7A0", Offset = "0x5F191A0", VA = "0x185F1A7A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5F1A790", Offset = "0x5F19190", VA = "0x185F1A790")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[AEGODFPPHJA(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[FEEAOJNJCBD(1)]
		public NMAFJHEKMBP transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[FEEAOJNJCBD(2)]
		public OFAPOEJMFCG transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
[EOMDGAJGDFJ(0, 1)]
public enum NMAFJHEKMBP
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
[EOMDGAJGDFJ(-2, 2)]
public enum OFAPOEJMFCG
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
	[AEGODFPPHJA(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[AEGODFPPHJA(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x5F1BC80", Offset = "0x5F1A680", VA = "0x185F1BC80")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[AEGODFPPHJA(1)]
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
[EOMDGAJGDFJ(1000, 8001)]
public enum MIJMGOMOBGM
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
internal enum BIHOFIKCJNA
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
internal static class GMDBFNICGAM
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[AEGODFPPHJA(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[FEEAOJNJCBD(1)]
		public MIJMGOMOBGM prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class PBGPBGMJIPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5F1B5B0", Offset = "0x5F19FB0", VA = "0x185F1B5B0")]
	public static bool CHLOMNGLOJB(this MIJMGOMOBGM NFMPIOLJBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5F1B5D0", Offset = "0x5F19FD0", VA = "0x185F1B5D0")]
	public static string CKGMOMNGAHE(this MIJMGOMOBGM NFMPIOLJBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5F1B650", Offset = "0x5F1A050", VA = "0x185F1B650")]
	public static HIODIHGJCID FAEOMGJODAI(this MIJMGOMOBGM PKKAOLKCAGJ)
	{
		return default(HIODIHGJCID);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5F1B670", Offset = "0x5F1A070", VA = "0x185F1B670")]
	internal static BIHOFIKCJNA GOKBLFPHKKM(this HIODIHGJCID AEAPJCBPBCE)
	{
		return default(BIHOFIKCJNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5F1B680", Offset = "0x5F1A080", VA = "0x185F1B680")]
	internal static BIHOFIKCJNA GOKBLFPHKKM(this MIJMGOMOBGM PKKAOLKCAGJ)
	{
		return default(BIHOFIKCJNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[EOMDGAJGDFJ(0, 9)]
public enum HIODIHGJCID
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
	[AEGODFPPHJA(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[FEEAOJNJCBD(1)]
		public HIODIHGJCID objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class EMPJFDIKPPL
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5F1A4E0", Offset = "0x5F18EE0", VA = "0x185F1A4E0")]
	public static bool MKCIOOOJADF(this HIODIHGJCID AEAPJCBPBCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[EOMDGAJGDFJ(int.MinValue, int.MaxValue)]
public enum EJGOAPJGGFC
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
[EOMDGAJGDFJ(-1, 31)]
public enum NHNAPNGACGD
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
	[FDHMHIPEABO("Visual", 0)]
	[AEGODFPPHJA(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[PEJOHPJKFEE(0)]
		[FEEAOJNJCBD(1)]
		public EJGOAPJGGFC color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[PEJOHPJKFEE(0)]
		[FEEAOJNJCBD(2)]
		public NHNAPNGACGD material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[FEEAOJNJCBD(3)]
		[PEJOHPJKFEE(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[PEJOHPJKFEE(0)]
		[FEEAOJNJCBD(4)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Preserve]
	internal class _RRAssemblyIndex : ODIDKPKCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5F1BFD0", Offset = "0x5F1A9D0", VA = "0x185F1BFD0", Slot = "4")]
		public sealed override void HGKEFMKAFGI()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
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

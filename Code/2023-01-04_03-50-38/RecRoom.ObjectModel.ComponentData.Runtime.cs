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
public struct BEOMCNDBABI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode GLJJHEIKMAM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly BEOMCNDBABI BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct LFPLFABEMLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public MIAPNMCOIGB BDKJAMHDLJO;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly LFPLFABEMLD BKIMHMJINMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KDPJDLMNPNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FPBCBBLOJEH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MIAPNMCOIGB
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
public struct MCLOEHHLJKN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct NJBNPFLEFGJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity JKAAFIAPPME;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EEKJGOKANMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity JFCNGAACNEO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly EEKJGOKANMJ BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ADDJCCKFHCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity NMIIAOIKHMI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly ADDJCCKFHCD BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KIENNDGKOGI : IOPHLCGDAFI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NFHBINEABBA DHGMGGCIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NFHBINEABBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IPOPMGCDGEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3 KPGDKBFNDAL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PIMBJAPMLGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BDDCJEIFIDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 KJIEGLIKLHL;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly BDDCJEIFIDD BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NJGHEGKBKPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public quaternion EJINEGINNLI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly NJGHEGKBKPH BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AJKOOCLDDHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 HEDDCKELFBB;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly AJKOOCLDDHB BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OHCOBJGMPIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float BGFEOHOAHKK;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly OHCOBJGMPIO BKIMHMJINMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KNNAAGKAJBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JLACMOJILHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float BHCIOEAMLID;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly JLACMOJILHG BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IDJEKKEIBLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float3 ICIKHPLKJNF;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct INFLIFCCAKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public OMABPCEAJCN DJKGDJKALKK;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly INFLIFCCAKE BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ILCGMNFONOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OMABPCEAJCN MCOPONNDFBP;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly ILCGMNFONOG BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PNHOCDBNAFH : IOPHLCGDAFI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NFHBINEABBA DHGMGGCIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NFHBINEABBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OGNEGHIJMEK : IOPHLCGDAFI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NFHBINEABBA DHGMGGCIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NFHBINEABBA);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FKHADAEHFHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JMFOOGFFDON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HPFMJADOJDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HMOAHJDIMEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public RigidbodyConstraints DMPHDKHPPGP;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly HMOAHJDIMEK BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JALIELKDDCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float KCCFOKBJFJI;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JALIELKDDCG BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct KLHKPGFHFFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float OGMFBNAEINO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly KLHKPGFHFFJ BKIMHMJINMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OFFGLDGBFHG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MMNIFIBEANE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int APKPLOMBJIG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MMNIFIBEANE BKIMHMJINMC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85B260", Offset = "0x85A660", VA = "0x18085B260")]
	public static MMNIFIBEANE GFKKOGBEPBN(int IGDJJEECDAF)
	{
		return default(MMNIFIBEANE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HKGPBJKMFMM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Rigidbody GAOHKMMENID;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD33F0", Offset = "0x5FD27F0", VA = "0x185FD33F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HKGPBJKMFMM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DKMPOOPPFCI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct MMAIEBALOMC : IOPHLCGDAFI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NFHBINEABBA DHGMGGCIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NFHBINEABBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ELMIDHDPAFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float AOMKBDHPMLB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly ELMIDHDPAFB BKIMHMJINMC;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PNJBFKJOGII : IOPHLCGDAFI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NFHBINEABBA DHGMGGCIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NFHBINEABBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EECKNDNHKHG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object FBNDOODEJLI;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FD32E0", Offset = "0x5FD26E0", VA = "0x185FD32E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public EECKNDNHKHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class DGNAFEJJABO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public object OAAHOOPBHGH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3260", Offset = "0x5FD2660", VA = "0x185FD3260", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DGNAFEJJABO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum OMABPCEAJCN
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum CCMIJJFALNJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface AEGKIDLHAJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPKIGBCDIBA(MIAPNMCOIGB PHCIBHAPAEA, MIAPNMCOIGB HOINOFOELCN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJNNDCJLJLB();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPOBMHJAKNH();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNBPEOADCFI(bool FBMIBFGCBCA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool APDEHGHLOMF();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class IKNDGBJJHFO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public AEGKIDLHAJA MMOIMNLDAKA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3770", Offset = "0x5FD2B70", VA = "0x185FD3770", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public IKNDGBJJHFO()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[InternalBufferCapacity(8)]
	[ACKDJMINIIN(1)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, AHLBNOBKMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2B70", Offset = "0x3AA1F70", VA = "0x183AA2B70", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[ACKDJMINIIN(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[BIDMPIFJMII(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[BIDMPIFJMII(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1D58990", Offset = "0x1D57D90", VA = "0x181D58990")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FD30E0", Offset = "0x5FD24E0", VA = "0x185FD30E0")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[ACKDJMINIIN(1)]
	public struct AuthoredParentData : IComponentData, AHLBNOBKMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[BIDMPIFJMII(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3110", Offset = "0x5FD2510", VA = "0x185FD3110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct CIDNBOMPPID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct GGMLJPFLIIC : ISystemStateComponentData, IComponentData, AHLBNOBKMEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity CDHMINDDOBA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity EHPPBOKPOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CCLMCGBEGOP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JGJAGGLADEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int DLDPNOCIKPH;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct LMEPNBDHMGG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GCHandle CCFPKCMMMMD;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[MMIGFCOGCLE(1)]
	[ACKDJMINIIN(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[BIDMPIFJMII(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[BIDMPIFJMII(2)]
		public SerializableGuid graphId;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
[PNFDMOGCCGE(0, 15)]
public enum CNPEKHKAAAD
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
[PNFDMOGCCGE(0, 2)]
public enum JGHNHCEHAOO
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
	[EIIPILMMOGB("Container", 0)]
	[ACKDJMINIIN(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[BIDMPIFJMII(1)]
		[MFCJLHOBBJO(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[GKKGDBFFBEN]
		[BIDMPIFJMII(2)]
		[MFCJLHOBBJO(0)]
		public JGHNHCEHAOO collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[GKKGDBFFBEN]
		[BIDMPIFJMII(3)]
		[MFCJLHOBBJO(0)]
		public CNPEKHKAAAD collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[GKKGDBFFBEN]
		[MFCJLHOBBJO(0)]
		[BIDMPIFJMII(4)]
		public BCDCCAOLIGM grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[GKKGDBFFBEN]
		[BIDMPIFJMII(5)]
		[MFCJLHOBBJO(0)]
		public MADLJMCJGDI flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[GKKGDBFFBEN]
		[BIDMPIFJMII(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3180", Offset = "0x5FD2580", VA = "0x185FD3180", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Flags]
[PNFDMOGCCGE(0, 16071)]
public enum MADLJMCJGDI
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
[PNFDMOGCCGE(0, 1)]
public enum BCDCCAOLIGM
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
[MMIGFCOGCLE(1)]
public struct KIGIIBLDHCO : IComparable<KIGIIBLDHCO>, IEquatable<KIGIIBLDHCO>, PIFGLOGIBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[HLADOKEGGAA(1)]
	public uint KOPEIDCPOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[HLADOKEGGAA(2)]
	public uint NOJBJBCCPGN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private uint PDDBINAFHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD38B0", Offset = "0x5FD2CB0", VA = "0x185FD38B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3B90", Offset = "0x5FD2F90", VA = "0x185FD3B90")]
	public KIGIIBLDHCO(int KOPEIDCPOLO, int CLJPFKEGMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3B90", Offset = "0x5FD2F90", VA = "0x185FD3B90")]
	public KIGIIBLDHCO(uint KOPEIDCPOLO, uint CLJPFKEGMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3880", Offset = "0x5FD2C80", VA = "0x185FD3880")]
	private static uint DABEIEJMJJI(uint GHJDMBPGMHF, uint IKDBBHHKFLJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3860", Offset = "0x5FD2C60", VA = "0x185FD3860", Slot = "4")]
	public int CompareTo(KIGIIBLDHCO EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FD38E0", Offset = "0x5FD2CE0", VA = "0x185FD38E0", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3AB0", Offset = "0x5FD2EB0", VA = "0x185FD3AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FD38C0", Offset = "0x5FD2CC0", VA = "0x185FD38C0", Slot = "5")]
	public bool Equals(KIGIIBLDHCO EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FD39F0", Offset = "0x5FD2DF0", VA = "0x185FD39F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3970", Offset = "0x5FD2D70", VA = "0x185FD3970", Slot = "6")]
	public void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3A40", Offset = "0x5FD2E40", VA = "0x185FD3A40", Slot = "7")]
	public void LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xD9DDE0", Offset = "0xD9D1E0", VA = "0x180D9DDE0")]
	public static bool LPAHFDMKICD(KIGIIBLDHCO HOHNFHDFLIK, KIGIIBLDHCO IBLJPHDNENC)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[MMIGFCOGCLE(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[HLADOKEGGAA(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[HLADOKEGGAA(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[HLADOKEGGAA(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[HLADOKEGGAA(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[MMIGFCOGCLE(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, PIFGLOGIBDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[HLADOKEGGAA(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCE87A0", Offset = "0xCE7BA0", VA = "0x180CE87A0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCE87A0", Offset = "0xCE7BA0", VA = "0x180CE87A0")]
		public static SerializableGuid GFKKOGBEPBN(Guid NOCBJPFIBOM)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4740", Offset = "0x5FD3B40", VA = "0x185FD4740", Slot = "4")]
		public bool Equals(SerializableGuid EPJIAIAEMFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4720", Offset = "0x5FD3B20", VA = "0x185FD4720", Slot = "5")]
		public int CompareTo(SerializableGuid EPJIAIAEMFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD47D0", Offset = "0x5FD3BD0", VA = "0x185FD47D0", Slot = "6")]
		public void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD48D0", Offset = "0x5FD3CD0", VA = "0x185FD48D0", Slot = "7")]
		public void LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4950", Offset = "0x5FD3D50", VA = "0x185FD4950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ACKDJMINIIN(1)]
	[KLHHOGKMJMK("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[ACKDJMINIIN(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[BIDMPIFJMII(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[BIDMPIFJMII(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[PNFDMOGCCGE(0, 4)]
public enum HJJKLCIJMGP
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
	[ACKDJMINIIN(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[BIDMPIFJMII(1)]
		public HJJKLCIJMGP gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[ACKDJMINIIN(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[BIDMPIFJMII(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[BIDMPIFJMII(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[BIDMPIFJMII(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ACKDJMINIIN(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[BIDMPIFJMII(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[BIDMPIFJMII(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[BIDMPIFJMII(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[BIDMPIFJMII(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[BIDMPIFJMII(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[ACKDJMINIIN(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[BIDMPIFJMII(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[BIDMPIFJMII(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[BIDMPIFJMII(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[InternalBufferCapacity(8)]
	[ACKDJMINIIN(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, AHLBNOBKMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3AA2B70", Offset = "0x3AA1F70", VA = "0x183AA2B70", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[ACKDJMINIIN(1)]
	public struct ParentData : IComponentData, AHLBNOBKMEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[BIDMPIFJMII(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct HDBNINAKBDA : ISystemStateComponentData, IComponentData, AHLBNOBKMEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity CDHMINDDOBA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Entity EHPPBOKPOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0")]
	public HDBNINAKBDA(Entity JFCNGAACNEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static HDBNINAKBDA GFKKOGBEPBN(Entity NOADJCMIKEF)
	{
		return default(HDBNINAKBDA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct GFMHMCIIHKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface AHLBNOBKMEI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity BIMHONKFKHO
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
	[ACKDJMINIIN(1)]
	[EIIPILMMOGB("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[BIDMPIFJMII(1)]
		[MFCJLHOBBJO(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[MFCJLHOBBJO(0)]
		[BIDMPIFJMII(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[BIDMPIFJMII(3)]
		[MFCJLHOBBJO(0)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[EIIPILMMOGB("Light", 0)]
	[ACKDJMINIIN(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[MFCJLHOBBJO(0)]
		[BIDMPIFJMII(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[ACKDJMINIIN(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public uint networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4310", Offset = "0x5FD3710", VA = "0x185FD4310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[PNFDMOGCCGE(0, 4)]
public enum PIOLKCCKCDL
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
public struct MJGOJPDCEKO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NMCIDAOFNHM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int DLDPNOCIKPH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct GAACNPIGOBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JBBJMJJDODD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[ACKDJMINIIN(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[BIDMPIFJMII(1)]
		public CIGJLJKPPOC flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[BIDMPIFJMII(2)]
		public IEFMMFJBABB scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FCHFLOOFDCK
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3390", Offset = "0x5FD2790", VA = "0x185FD3390")]
	public static CIGJLJKPPOC AKBMAMDKLNI(this CIGJLJKPPOC AOFGAGALOCP, MLAOFEGKEOP DLKKHAHFEJL)
	{
		return default(CIGJLJKPPOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FD33C0", Offset = "0x5FD27C0", VA = "0x185FD33C0")]
	public static CIGJLJKPPOC GKDAOIMBAHJ(this CIGJLJKPPOC AOFGAGALOCP, MLAOFEGKEOP DLKKHAHFEJL)
	{
		return default(CIGJLJKPPOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FD33A0", Offset = "0x5FD27A0", VA = "0x185FD33A0")]
	public static CIGJLJKPPOC DEFNPJOIBPL(this CIGJLJKPPOC AOFGAGALOCP, MLAOFEGKEOP DLKKHAHFEJL, bool JNPACPCGCHA)
	{
		return default(CIGJLJKPPOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FD33D0", Offset = "0x5FD27D0", VA = "0x185FD33D0")]
	public static bool LOKMHJGAOAP(this CIGJLJKPPOC AOFGAGALOCP, MLAOFEGKEOP DLKKHAHFEJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum MLAOFEGKEOP
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
[PNFDMOGCCGE(0, 16383)]
public enum CIGJLJKPPOC
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
[MMIGFCOGCLE(1)]
public struct IEFMMFJBABB : PIFGLOGIBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[HLADOKEGGAA(1)]
	public bool NCFLAPIBDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[HLADOKEGGAA(2)]
	public float3 CHCIGCBGGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[HLADOKEGGAA(3)]
	public float3 GPPOCDDIGAG;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3670", Offset = "0x5FD2A70", VA = "0x185FD3670", Slot = "5")]
	public void LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3550", Offset = "0x5FD2950", VA = "0x185FD3550", Slot = "4")]
	public void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MMIGFCOGCLE(1)]
public struct MDIMEGHCOPE : PIFGLOGIBDL, IEquatable<MDIMEGHCOPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[HLADOKEGGAA(1)]
	public int KDFBMFGPICB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x729D90", Offset = "0x729190", VA = "0x180729D90")]
	public MDIMEGHCOPE(int KDFBMFGPICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3F90", Offset = "0x5FD3390", VA = "0x185FD3F90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3EE0", Offset = "0x5FD32E0", VA = "0x185FD3EE0", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8596A0", Offset = "0x858AA0", VA = "0x1808596A0", Slot = "6")]
	public bool Equals(MDIMEGHCOPE EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D7EF30", Offset = "0x1D7E330", VA = "0x181D7EF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4000", Offset = "0x5FD3400", VA = "0x185FD4000", Slot = "5")]
	public void LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3F60", Offset = "0x5FD3360", VA = "0x185FD3F60", Slot = "4")]
	public void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[ACKDJMINIIN(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[BIDMPIFJMII(1)]
		public MDIMEGHCOPE customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[PNFDMOGCCGE(0, 1)]
public enum FIAJBPIHAJA
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
	[ACKDJMINIIN(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[BIDMPIFJMII(1)]
		public FIAJBPIHAJA propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct EBJEIHACJOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct EHHJCBHBLPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HEGMFDFLCAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct MLHCJKCJHEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public FixedString32 DHKKANIEGMN;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[GAHPPMOGEEA]
public struct JGFDNBPEHAI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Entity MJJNOEJBKMP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static JGFDNBPEHAI GFKKOGBEPBN(Entity IGDJJEECDAF)
	{
		return default(JGFDNBPEHAI);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[ACKDJMINIIN(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[BIDMPIFJMII(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct EPAEDEHOOHH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Entity NOADJCMIKEF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static EPAEDEHOOHH GFKKOGBEPBN(Entity NOADJCMIKEF)
	{
		return default(EPAEDEHOOHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct PCICBBKOMMG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Entity KJAKOGELGDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static PCICBBKOMMG GFKKOGBEPBN(Entity NOADJCMIKEF)
	{
		return default(PCICBBKOMMG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct AJAENABKMLD : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[EIIPILMMOGB("Physics", 0)]
	[ACKDJMINIIN(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[BIDMPIFJMII(1)]
		[MFCJLHOBBJO(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[ACKDJMINIIN(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[BIDMPIFJMII(1)]
		public EOLBHDKIGHE shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[PNFDMOGCCGE(-1, 18)]
public enum EOLBHDKIGHE
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
	[ACKDJMINIIN(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[Flags]
		[PNFDMOGCCGE(0, 7)]
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
		[BIDMPIFJMII(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5FD49A0", Offset = "0x5FD3DA0", VA = "0x185FD49A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5FD4A20", Offset = "0x5FD3E20", VA = "0x185FD4A20")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[PNFDMOGCCGE(0, 2)]
public enum FBMAHLMFGDJ
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
	[ACKDJMINIIN(1)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[BIDMPIFJMII(1)]
		public FBMAHLMFGDJ shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[ACKDJMINIIN(1)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[BIDMPIFJMII(1)]
		public KIGIIBLDHCO order;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[ACKDJMINIIN(1)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[BIDMPIFJMII(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ACKDJMINIIN(1)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[BIDMPIFJMII(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly SplinePointPositionData Default;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1D58BB0", Offset = "0x1D57FB0", VA = "0x181D58BB0")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ACKDJMINIIN(1)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[BIDMPIFJMII(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly SplinePointRotationData Default;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xCE87A0", Offset = "0xCE7BA0", VA = "0x180CE87A0")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[ACKDJMINIIN(1)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[BIDMPIFJMII(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly SplinePointScaleData Default;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1D58BB0", Offset = "0x1D57FB0", VA = "0x181D58BB0")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[MMIGFCOGCLE(1)]
public struct PHLLHMEAHLO : PIFGLOGIBDL
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	[PNFDMOGCCGE(0, 7)]
	public enum PGEAEPONDAJ
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
	[HLADOKEGGAA(1)]
	public float FBOFKGFEAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[HLADOKEGGAA(2)]
	public int JBBAMJMAHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[HLADOKEGGAA(3)]
	public PGEAEPONDAJ AOFGAGALOCP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool IKMAKFGBCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4440", Offset = "0x5FD3840", VA = "0x185FD4440")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5FD44C0", Offset = "0x5FD38C0", VA = "0x185FD44C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BMJLMMODHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4560", Offset = "0x5FD3960", VA = "0x185FD4560")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4640", Offset = "0x5FD3A40", VA = "0x185FD4640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JKDLFMOAPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4660", Offset = "0x5FD3A60", VA = "0x185FD4660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4540", Offset = "0x5FD3940", VA = "0x185FD4540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD45E0", Offset = "0x5FD39E0", VA = "0x185FD45E0", Slot = "5")]
	public void LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD44E0", Offset = "0x5FD38E0", VA = "0x185FD44E0", Slot = "4")]
	public void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[ACKDJMINIIN(1)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[BIDMPIFJMII(1)]
		public PHLLHMEAHLO parameters;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct LGBIEFPNCGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct MLBJDABKHAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct JBGJPBPNPGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct AFPDBIKGHFH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct GLAGPLJCNKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal struct DGGAMMEPGOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct BDHGEFLBJJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal struct FMFNDGEBABF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct LOJIBFMHBLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct IEPOELFCOJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct CJFPANOEHDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct DOFAMPHKCDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct PKIBKLAKMPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct AAGMGFKDIMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct BOAHGLAMEPD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[ACKDJMINIIN(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[BIDMPIFJMII(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[BIDMPIFJMII(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[BIDMPIFJMII(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[ACKDJMINIIN(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[BIDMPIFJMII(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[BIDMPIFJMII(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[BIDMPIFJMII(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[BIDMPIFJMII(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[BIDMPIFJMII(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[BIDMPIFJMII(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[BIDMPIFJMII(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[BIDMPIFJMII(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[BIDMPIFJMII(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[BIDMPIFJMII(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[BIDMPIFJMII(11)]
		public LKANMGGGPLK mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[BIDMPIFJMII(12)]
		public IAFIMJEDJAN myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[BIDMPIFJMII(13)]
		public HLFPDCNBLAD myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[BIDMPIFJMII(14)]
		public JIJNPFFCIAD myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[BIDMPIFJMII(15)]
		public KDIJDHFGNLH myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[BIDMPIFJMII(16)]
		public KLOEKJBHKMM myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[BIDMPIFJMII(17)]
		public CHMGPOCABNE myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[BIDMPIFJMII(18)]
		public OOMGCKGECLD myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[BIDMPIFJMII(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[BIDMPIFJMII(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[BIDMPIFJMII(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[BIDMPIFJMII(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum LKANMGGGPLK : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum IAFIMJEDJAN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum HLFPDCNBLAD : short
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum JIJNPFFCIAD : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum KDIJDHFGNLH
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum KLOEKJBHKMM : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum CHMGPOCABNE : long
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum OOMGCKGECLD : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[ACKDJMINIIN(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[ACKDJMINIIN(1)]
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
	[ACKDJMINIIN(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class BLGALPAMLPN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct IPCMHCCCFGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector3 GMJMFICFENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public List<SerializableGuid> NNLPOGDKDLJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class CMPNAICJODF
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public CMPNAICJODF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public BLGALPAMLPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[GAHPPMOGEEA]
public struct PBIAODMALKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public TimeData PMEEKMNFEBL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xCE87A0", Offset = "0xCE7BA0", VA = "0x180CE87A0")]
	public static PBIAODMALKJ GFKKOGBEPBN(TimeData IGDJJEECDAF)
	{
		return default(PBIAODMALKJ);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[ACKDJMINIIN(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[BIDMPIFJMII(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[ACKDJMINIIN(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[BIDMPIFJMII(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[BIDMPIFJMII(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1D58990", Offset = "0x1D57D90", VA = "0x181D58990")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD30E0", Offset = "0x5FD24E0", VA = "0x185FD30E0")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD30E0", Offset = "0x5FD24E0", VA = "0x185FD30E0")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[ACKDJMINIIN(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[ACKDJMINIIN(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3DB0", Offset = "0x5FD31B0", VA = "0x185FD3DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[ACKDJMINIIN(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[BIDMPIFJMII(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct OBMFMEFEIJG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int JGDMLKACAAN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HMJKJGLHFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4270", Offset = "0x5FD3670", VA = "0x185FD4270")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4260", Offset = "0x5FD3660", VA = "0x185FD4260")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[ACKDJMINIIN(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[BIDMPIFJMII(1)]
		public CKMEOINJDHG transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[BIDMPIFJMII(2)]
		public HBDKFCDAEBB transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
[PNFDMOGCCGE(0, 1)]
public enum CKMEOINJDHG
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
[PNFDMOGCCGE(-2, 2)]
public enum HBDKFCDAEBB
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
	[ACKDJMINIIN(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ACKDJMINIIN(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x5FD4C60", Offset = "0x5FD4060", VA = "0x185FD4C60")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ACKDJMINIIN(1)]
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
[PNFDMOGCCGE(1000, 8001)]
public enum APCEPJKMKDM
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
internal enum HAMEKKHBNAB
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
internal static class NIPHMEOCIMB
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[ACKDJMINIIN(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[BIDMPIFJMII(1)]
		public APCEPJKMKDM prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class IBKPFNEPNCO
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3490", Offset = "0x5FD2890", VA = "0x185FD3490")]
	public static bool HKJBIEHDLNC(this APCEPJKMKDM FPPBLNEEHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD34B0", Offset = "0x5FD28B0", VA = "0x185FD34B0")]
	public static string MFMANLMDEJJ(this APCEPJKMKDM FPPBLNEEHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3530", Offset = "0x5FD2930", VA = "0x185FD3530")]
	public static HKAODOKOPPA NOCAFGOMHOE(this APCEPJKMKDM BKEDDPMCLJC)
	{
		return default(HKAODOKOPPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3480", Offset = "0x5FD2880", VA = "0x185FD3480")]
	internal static HAMEKKHBNAB DDCKPOODCKN(this HKAODOKOPPA JLLPODBHOLB)
	{
		return default(HAMEKKHBNAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3460", Offset = "0x5FD2860", VA = "0x185FD3460")]
	internal static HAMEKKHBNAB DDCKPOODCKN(this APCEPJKMKDM BKEDDPMCLJC)
	{
		return default(HAMEKKHBNAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[PNFDMOGCCGE(0, 9)]
public enum HKAODOKOPPA
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
	[ACKDJMINIIN(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[BIDMPIFJMII(1)]
		public HKAODOKOPPA objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class EBFDMEDCPKI
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD32D0", Offset = "0x5FD26D0", VA = "0x185FD32D0")]
	public static bool OKBOIHHMJPC(this HKAODOKOPPA JLLPODBHOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[PNFDMOGCCGE(int.MinValue, int.MaxValue)]
public enum GGJMEDAMMEO
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
[PNFDMOGCCGE(-1, 31)]
public enum LEKKHDHAMCL
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
	[EIIPILMMOGB("Visual", 0)]
	[ACKDJMINIIN(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[MFCJLHOBBJO(0)]
		[BIDMPIFJMII(1)]
		public GGJMEDAMMEO color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[MFCJLHOBBJO(0)]
		[BIDMPIFJMII(2)]
		public LEKKHDHAMCL material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[BIDMPIFJMII(3)]
		[MFCJLHOBBJO(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[MFCJLHOBBJO(0)]
		[BIDMPIFJMII(4)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Preserve]
	internal class _RRAssemblyIndex : JAMCEJDIEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4FB0", Offset = "0x5FD43B0", VA = "0x185FD4FB0", Slot = "4")]
		public sealed override void PJNICPDDEAL()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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

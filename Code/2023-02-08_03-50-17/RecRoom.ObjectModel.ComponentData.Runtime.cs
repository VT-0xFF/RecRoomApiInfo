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
public struct IKOFFAILOGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode CPPALNILFDB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly IKOFFAILOGM JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct DHBDIIJBNKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public BEKBBDPNCLI AOFCDCOLHDM;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly DHBDIIJBNKD JLGGJMINNJN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LBCBHEIANAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GNNODPOPGKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BEKBBDPNCLI
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
public struct PHFNOJKALJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct NEJLBHDPDBI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity JJJNIHBIILJ;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ODKPEHAEIDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity KICGHGEEADG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly ODKPEHAEIDM JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EGGIGAHMPEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity OJIIPOMCHKP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly EGGIGAHMPEM JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FAKMBACIFKP : KMKIHICBCMB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IHMDJLDFGCF LGKCKOMJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IHMDJLDFGCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BJGAGJKIDLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3 OKAOIPEMNGH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PGDELPEEKCH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NAIBJJMOLPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 CONMONEDOJH;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly NAIBJJMOLPL JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GFGHNANMCOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public quaternion GIIFDANDIBH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly GFGHNANMCOD JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ACJHHPPCKGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 IMHHNLGFJLP;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly ACJHHPPCKGJ JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PLECNOKKDEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float KKILIKCFODB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly PLECNOKKDEM JLGGJMINNJN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OMIOHMMCJLK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PHALODJIGFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float LABLKFBHOHH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly PHALODJIGFI JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FOJOIILJCFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float3 BPMCMGJBHFP;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct IBPJGBBBIOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NNIOOPPGOBD FOJDCDLDNDG;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static readonly IBPJGBBBIOB JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PKHJGEFKNMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NNIOOPPGOBD FOHNBCAEBEC;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static readonly PKHJGEFKNMC JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PGGKNDBLPKI : KMKIHICBCMB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IHMDJLDFGCF LGKCKOMJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IHMDJLDFGCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BKPDLKFCJIL : KMKIHICBCMB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IHMDJLDFGCF LGKCKOMJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IHMDJLDFGCF);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IEKHJNNOCIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct ALFGODKBDJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CLMINLGJCMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ILPBFHPOANL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public RigidbodyConstraints HMBMGENIJNC;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly ILPBFHPOANL JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NMDNJOGBDOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float KHFINBCMHON;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly NMDNJOGBDOF JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct AJBEKJIPBAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float OIPPOBPBMMN;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly AJBEKJIPBAO JLGGJMINNJN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CDMPBAKHPCM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NEADGFMENIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int GCDCFGMENGD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly NEADGFMENIJ JLGGJMINNJN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA60", Offset = "0x6EE860", VA = "0x1806EFA60")]
	public static NEADGFMENIJ LJJFBFNEMCH(int DPJGMDFEIDL)
	{
		return default(NEADGFMENIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OBGLDDKNKPG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Rigidbody EEJCJBEHHGD;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20A4C20", Offset = "0x20A3A20", VA = "0x1820A4C20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public OBGLDDKNKPG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BPAJICIMOEJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HIODNGJLJON : KMKIHICBCMB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IHMDJLDFGCF LGKCKOMJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IHMDJLDFGCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct EECLPKJHEMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public float KHCACPCMGLL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly EECLPKJHEMM JLGGJMINNJN;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JFPIGCHENNN : KMKIHICBCMB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IHMDJLDFGCF LGKCKOMJDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IHMDJLDFGCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FNDHNEEOALB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public object MCPOGBKCCJK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x20A3EF0", Offset = "0x20A2CF0", VA = "0x1820A3EF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public FNDHNEEOALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JGDJNGJLACO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public object GCMJMGJPNLL;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20A43C0", Offset = "0x20A31C0", VA = "0x1820A43C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public JGDJNGJLACO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum NNIOOPPGOBD
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum HDCNNOKEHCC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BNKCFHLNIJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCCDALNBPJA(BEKBBDPNCLI CLCPFJKOPEE, BEKBBDPNCLI HEODPPKGDHM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHONMNBIAJC();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKIHDAHALFK();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHGMLIJIDIH(bool AJEIDOOEPDK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MAIEAAPOBOE();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HEJHEFBDFMM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public BNKCFHLNIJK MMBJJCIPHLE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x20A4340", Offset = "0x20A3140", VA = "0x1820A4340", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public HEJHEFBDFMM()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[InternalBufferCapacity(8)]
	[FIOLLCFEOFH(1)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, ADKCGMMLOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xDFD7F0", Offset = "0xDFC5F0", VA = "0x180DFD7F0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[FIOLLCFEOFH(1)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[EPNLOHPPMHG(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[EPNLOHPPMHG(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static AuthoredLocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1E8B940", Offset = "0x1E8A740", VA = "0x181E8B940")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x20A3BA0", Offset = "0x20A29A0", VA = "0x1820A3BA0")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[FIOLLCFEOFH(1)]
	public struct AuthoredParentData : IComponentData, ADKCGMMLOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[EPNLOHPPMHG(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x20A3BD0", Offset = "0x20A29D0", VA = "0x1820A3BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct CFLEFLGBCIN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct APCABMHFOCF : ISystemStateComponentData, IComponentData, ADKCGMMLOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity BEGCLPIMHBH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity BNOJKNKLBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KNLMJFGPLPM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct ILLOKJDLMAE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int BBBGEOBCIIP;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BDBJIBNPIPB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public GCHandle NBNIMBLGJFP;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[KCHEFGEOPEH(1)]
	[FIOLLCFEOFH(1)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[EPNLOHPPMHG(1)]
		public SerializableGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[EPNLOHPPMHG(2)]
		public SerializableGuid graphId;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[Flags]
[GJOBOFFAOFN(0, 15)]
public enum IBJBLABMBPG
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
[GJOBOFFAOFN(0, 2)]
public enum EFPNLCOPLIF
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
	[KEOEEIKLOKB("Container", 0)]
	[FIOLLCFEOFH(1)]
	public struct ContainerData : IComponentData, IEquatable<ContainerData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[EPNLOHPPMHG(1)]
		[ENACCFJMDFH(0)]
		public FixedString64 name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[DHJMOMAIKFP]
		[EPNLOHPPMHG(2)]
		[ENACCFJMDFH(0)]
		public EFPNLCOPLIF collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[DHJMOMAIKFP]
		[EPNLOHPPMHG(3)]
		[ENACCFJMDFH(0)]
		public IBJBLABMBPG collidesWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[DHJMOMAIKFP]
		[ENACCFJMDFH(0)]
		[EPNLOHPPMHG(4)]
		public CKDODOICOHG grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[DHJMOMAIKFP]
		[EPNLOHPPMHG(5)]
		[ENACCFJMDFH(0)]
		public NLDEMLNMJPF flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[DHJMOMAIKFP]
		[EPNLOHPPMHG(6)]
		public float mass;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x20A3D30", Offset = "0x20A2B30", VA = "0x1820A3D30", Slot = "4")]
		public bool Equals(ContainerData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[Flags]
[GJOBOFFAOFN(0, 16071)]
public enum NLDEMLNMJPF
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
[GJOBOFFAOFN(0, 1)]
public enum CKDODOICOHG
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
[KCHEFGEOPEH(1)]
public struct GLDCJKBKNEC : IComparable<GLDCJKBKNEC>, IEquatable<GLDCJKBKNEC>, JMHCOOOCIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[OKNHEDHDJHC(1)]
	public uint IFIGLPMKBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[OKNHEDHDJHC(2)]
	public uint AGLEIKDAAAA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private uint ECFFMMLCMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x20A3FE0", Offset = "0x20A2DE0", VA = "0x1820A3FE0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20A42F0", Offset = "0x20A30F0", VA = "0x1820A42F0")]
	public GLDCJKBKNEC(int IFIGLPMKBFK, int BBPJKKOOFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x20A42F0", Offset = "0x20A30F0", VA = "0x1820A42F0")]
	public GLDCJKBKNEC(uint IFIGLPMKBFK, uint BBPJKKOOFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20A4170", Offset = "0x20A2F70", VA = "0x1820A4170")]
	private static uint IFCDLLMIOFC(uint EFBCPNIKEHB, uint BFLEMGIJKLG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20A3FC0", Offset = "0x20A2DC0", VA = "0x1820A3FC0", Slot = "4")]
	public int CompareTo(GLDCJKBKNEC BNIMMCIKNIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x20A3FF0", Offset = "0x20A2DF0", VA = "0x1820A3FF0", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x20A4210", Offset = "0x20A3010", VA = "0x1820A4210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x20A4080", Offset = "0x20A2E80", VA = "0x1820A4080", Slot = "5")]
	public bool Equals(GLDCJKBKNEC BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x20A40A0", Offset = "0x20A2EA0", VA = "0x1820A40A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x20A40F0", Offset = "0x20A2EF0", VA = "0x1820A40F0", Slot = "6")]
	public void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20A41A0", Offset = "0x20A2FA0", VA = "0x1820A41A0", Slot = "7")]
	public void IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x16ED010", Offset = "0x16EBE10", VA = "0x1816ED010")]
	public static bool EKDLGPJCFAN(GLDCJKBKNEC NIABGHNJMBG, GLDCJKBKNEC KMEJCCGACHJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[KCHEFGEOPEH(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[OKNHEDHDJHC(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[OKNHEDHDJHC(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[OKNHEDHDJHC(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[OKNHEDHDJHC(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[KCHEFGEOPEH(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, JMHCOOOCIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[OKNHEDHDJHC(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8FC810", Offset = "0x8FB610", VA = "0x1808FC810")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8FC810", Offset = "0x8FB610", VA = "0x1808FC810")]
		public static SerializableGuid LJJFBFNEMCH(Guid KFIPLDEPOPC)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x20A5200", Offset = "0x20A4000", VA = "0x1820A5200", Slot = "4")]
		public bool Equals(SerializableGuid BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x20A51E0", Offset = "0x20A3FE0", VA = "0x1820A51E0", Slot = "5")]
		public int CompareTo(SerializableGuid BNIMMCIKNIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x20A5290", Offset = "0x20A4090", VA = "0x1820A5290", Slot = "6")]
		public void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x20A5390", Offset = "0x20A4190", VA = "0x1820A5390", Slot = "7")]
		public void IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x20A5410", Offset = "0x20A4210", VA = "0x1820A5410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[FIOLLCFEOFH(1)]
	[CNLPFFJCHPM("RecRoom.ObjectModel.Systems.SerializedEmbodiedTag")]
	public struct SerializedEmbodiedData : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[FIOLLCFEOFH(1)]
	public struct ClampData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[EPNLOHPPMHG(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[EPNLOHPPMHG(2)]
		public bool isClamped;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[GJOBOFFAOFN(0, 4)]
public enum GGPGKEMMOBN
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
	[FIOLLCFEOFH(1)]
	public struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[EPNLOHPPMHG(1)]
		public GGPGKEMMOBN gizmoType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[FIOLLCFEOFH(1)]
	public struct LookAtData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[EPNLOHPPMHG(1)]
		public Entity target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[EPNLOHPPMHG(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[EPNLOHPPMHG(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[FIOLLCFEOFH(1)]
	public struct PistonData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[EPNLOHPPMHG(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[EPNLOHPPMHG(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[EPNLOHPPMHG(3)]
		public float progress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[EPNLOHPPMHG(4)]
		public float min;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[EPNLOHPPMHG(5)]
		public float max;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[FIOLLCFEOFH(1)]
	public struct RotatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[EPNLOHPPMHG(1)]
		public bool direction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[EPNLOHPPMHG(2)]
		public bool isRunning;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[EPNLOHPPMHG(3)]
		public float speed;
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[InternalBufferCapacity(8)]
	[FIOLLCFEOFH(1)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, ADKCGMMLOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDFD7F0", Offset = "0xDFC5F0", VA = "0x180DFD7F0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[FIOLLCFEOFH(1)]
	public struct ParentData : IComponentData, ADKCGMMLOFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[EPNLOHPPMHG(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct OIFDFEHPCHJ : ISystemStateComponentData, IComponentData, ADKCGMMLOFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity BEGCLPIMHBH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Entity BNOJKNKLBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA50", Offset = "0x7AD850", VA = "0x1807AEA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x743E50", Offset = "0x742C50", VA = "0x180743E50")]
	public OIFDFEHPCHJ(Entity KICGHGEEADG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	public static OIFDFEHPCHJ LJJFBFNEMCH(Entity DNMNICOEECM)
	{
		return default(OIFDFEHPCHJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct HJOGCCLLHPA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ADKCGMMLOFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity LKLOOGFOKLO
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
	[FIOLLCFEOFH(1)]
	[KEOEEIKLOKB("Light", 0)]
	public struct LightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[EPNLOHPPMHG(1)]
		[ENACCFJMDFH(0)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[ENACCFJMDFH(0)]
		[EPNLOHPPMHG(2)]
		public float intensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[EPNLOHPPMHG(3)]
		[ENACCFJMDFH(0)]
		public float range;
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[KEOEEIKLOKB("Light", 0)]
	[FIOLLCFEOFH(1)]
	public struct SpotlightData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[ENACCFJMDFH(0)]
		[EPNLOHPPMHG(1)]
		public float angle;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[FIOLLCFEOFH(1)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public uint networkIdBits;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x20A4DD0", Offset = "0x20A3BD0", VA = "0x1820A4DD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[GJOBOFFAOFN(0, 4)]
public enum BJBEFIGOOBO
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
public struct BOCHNCFDMIK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NBNDEEAIBIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int BBBGEOBCIIP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PLEKNIIJMDG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FOFFCLGGJFM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[FIOLLCFEOFH(1)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[EPNLOHPPMHG(1)]
		public DLJMPGFIIEK flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[EPNLOHPPMHG(2)]
		public PILPHCHDGNO scaleRestriction;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly ObjectPolicyData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class EELPIHNMBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x20A3E90", Offset = "0x20A2C90", VA = "0x1820A3E90")]
	public static DLJMPGFIIEK EKGLGHAFJEH(this DLJMPGFIIEK POLNGKBPPLK, CMHAGNNAIBK JCFDILFMPGE)
	{
		return default(DLJMPGFIIEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x20A3EE0", Offset = "0x20A2CE0", VA = "0x1820A3EE0")]
	public static DLJMPGFIIEK PPEAGPDBOCM(this DLJMPGFIIEK POLNGKBPPLK, CMHAGNNAIBK JCFDILFMPGE)
	{
		return default(DLJMPGFIIEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20A3EC0", Offset = "0x20A2CC0", VA = "0x1820A3EC0")]
	public static DLJMPGFIIEK IPINOOGMPKN(this DLJMPGFIIEK POLNGKBPPLK, CMHAGNNAIBK JCFDILFMPGE, bool HPIJJNABPKN)
	{
		return default(DLJMPGFIIEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20A3EA0", Offset = "0x20A2CA0", VA = "0x1820A3EA0")]
	public static bool GKOJECGAMJJ(this DLJMPGFIIEK POLNGKBPPLK, CMHAGNNAIBK JCFDILFMPGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum CMHAGNNAIBK
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
[GJOBOFFAOFN(0, 16383)]
public enum DLJMPGFIIEK
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
[KCHEFGEOPEH(1)]
public struct PILPHCHDGNO : JMHCOOOCIFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[OKNHEDHDJHC(1)]
	public bool BBEGNBBGFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[OKNHEDHDJHC(2)]
	public float3 KCGIDHBCIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[OKNHEDHDJHC(3)]
	public float3 MNKOGHIHIBL;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20A5060", Offset = "0x20A3E60", VA = "0x1820A5060", Slot = "5")]
	public void IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20A4F40", Offset = "0x20A3D40", VA = "0x1820A4F40", Slot = "4")]
	public void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[KCHEFGEOPEH(1)]
public struct CPNMDNJEGCI : JMHCOOOCIFG, IEquatable<CPNMDNJEGCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[OKNHEDHDJHC(1)]
	public int FCIFBDBBENJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40")]
	public CPNMDNJEGCI(int FCIFBDBBENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x20A3C60", Offset = "0x20A2A60", VA = "0x1820A3C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x20A3BE0", Offset = "0x20A29E0", VA = "0x1820A3BE0", Slot = "0")]
	public override bool Equals(object LOPIEGGIDMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFA10", Offset = "0x6EE810", VA = "0x1806EFA10", Slot = "6")]
	public bool Equals(CPNMDNJEGCI BNIMMCIKNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x17FA500", Offset = "0x17F9300", VA = "0x1817FA500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x20A3D00", Offset = "0x20A2B00", VA = "0x1820A3D00", Slot = "5")]
	public void IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20A3CD0", Offset = "0x20A2AD0", VA = "0x1820A3CD0", Slot = "4")]
	public void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[FIOLLCFEOFH(1)]
	public struct CustomPropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[EPNLOHPPMHG(1)]
		public CPNMDNJEGCI customPropId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public GCHandle instance;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[GJOBOFFAOFN(0, 1)]
public enum BLKFEPCNHBN
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
	[FIOLLCFEOFH(1)]
	public struct PropData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[EPNLOHPPMHG(1)]
		public BLKFEPCNHBN propType;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct GCAFLGCHNNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct ACKHLMDGKJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KNNHIDFKBKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct DFKMNGHOCOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public FixedString32 CCEKFDNIAPD;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[FFOOHLLCIMF]
public struct GJMAMPMGONA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Entity LICHDNGOEKH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	public static GJMAMPMGONA LJJFBFNEMCH(Entity DPJGMDFEIDL)
	{
		return default(GJMAMPMGONA);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[FIOLLCFEOFH(1)]
	public struct PlayerScopeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[EPNLOHPPMHG(1)]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct DMDFIALAIKC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Entity DNMNICOEECM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	public static DMDFIALAIKC LJJFBFNEMCH(Entity DNMNICOEECM)
	{
		return default(DMDFIALAIKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct JJEKFFAFCJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Entity NPDFOCENMBD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70")]
	public static JJEKFFAFCJL LJJFBFNEMCH(Entity DNMNICOEECM)
	{
		return default(JJEKFFAFCJL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct OMBFJGIDJNK : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[KEOEEIKLOKB("Physics", 0)]
	[FIOLLCFEOFH(1)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[EPNLOHPPMHG(1)]
		[ENACCFJMDFH(0)]
		public float density;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public static readonly PhysicsMaterialData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[FIOLLCFEOFH(1)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[EPNLOHPPMHG(1)]
		public MKFEGIBJCLL shapeType;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[GJOBOFFAOFN(-1, 18)]
public enum MKFEGIBJCLL
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
	[FIOLLCFEOFH(1)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[Flags]
		[GJOBOFFAOFN(0, 7)]
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
		[EPNLOHPPMHG(1)]
		public Flags flags;

		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public static readonly ShapeConfigData Default;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DynamicUVProjection
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x20A5460", Offset = "0x20A4260", VA = "0x1820A5460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NewBendLogic
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x20A54E0", Offset = "0x20A42E0", VA = "0x1820A54E0")]
			get
			{
				return default(bool);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[GJOBOFFAOFN(0, 2)]
public enum KHLOLCMOGEO
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
	[FIOLLCFEOFH(1)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[EPNLOHPPMHG(1)]
		public KHLOLCMOGEO shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[FIOLLCFEOFH(1)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[EPNLOHPPMHG(1)]
		public GLDCJKBKNEC order;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[FIOLLCFEOFH(1)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[EPNLOHPPMHG(1)]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[FIOLLCFEOFH(1)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[EPNLOHPPMHG(1)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public static readonly SplinePointPositionData Default;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B60", Offset = "0x9F3960", VA = "0x1809F4B60")]
		public static implicit operator SplinePointPositionData(float3 value)
		{
			return default(SplinePointPositionData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[FIOLLCFEOFH(1)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[EPNLOHPPMHG(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public static readonly SplinePointRotationData Default;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8FC810", Offset = "0x8FB610", VA = "0x1808FC810")]
		public static implicit operator SplinePointRotationData(quaternion value)
		{
			return default(SplinePointRotationData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[FIOLLCFEOFH(1)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[EPNLOHPPMHG(1)]
		public float3 localScale;

		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public static readonly SplinePointScaleData Default;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B60", Offset = "0x9F3960", VA = "0x1809F4B60")]
		public static implicit operator SplinePointScaleData(float3 value)
		{
			return default(SplinePointScaleData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[KCHEFGEOPEH(1)]
public struct JMNGIMIFOKO : JMHCOOOCIFG
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Flags]
	[GJOBOFFAOFN(0, 7)]
	public enum IKHEMHIJHCC
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
	[OKNHEDHDJHC(1)]
	public float HDJPGEJFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[OKNHEDHDJHC(2)]
	public int OKAHEOAINAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[OKNHEDHDJHC(3)]
	public IKHEMHIJHCC POLNGKBPPLK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool DHKGKMANMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x20A4490", Offset = "0x20A3290", VA = "0x1820A4490")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x20A4470", Offset = "0x20A3270", VA = "0x1820A4470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HJFLLDHNBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x20A4650", Offset = "0x20A3450", VA = "0x1820A4650")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x20A4430", Offset = "0x20A3230", VA = "0x1820A4430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BLFJJHGMMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x20A4510", Offset = "0x20A3310", VA = "0x1820A4510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x20A4450", Offset = "0x20A3250", VA = "0x1820A4450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x20A45F0", Offset = "0x20A33F0", VA = "0x1820A45F0", Slot = "5")]
	public void IMPOKOFCPDO(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x20A4590", Offset = "0x20A3390", VA = "0x1820A4590", Slot = "4")]
	public void HGGLACGHMAP(FNGPCDCOHDD MGAEFPBCPOK)
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[FIOLLCFEOFH(1)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[EPNLOHPPMHG(1)]
		public JMNGIMIFOKO parameters;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct NOBHLAMOJON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct CPHJLEHNBPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct OJIOEIJIJDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct KNHHKPFKBEL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct INNALLIBLJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal struct IIBKFGOMJBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct POPLDEDDJMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal struct BGLFMKBDIOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct IIEDGKNEEGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PGCEKEDDDGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct FOCHEFJIBIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct MMGELADPHMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct CAFIGCDNDGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct NLBDCJPHCHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct CODKBIKHPNM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[FIOLLCFEOFH(1)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[EPNLOHPPMHG(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[EPNLOHPPMHG(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[EPNLOHPPMHG(3)]
		public bool optimizedCollidersEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly OMShapeContainerData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[FIOLLCFEOFH(1)]
	public struct TestNativeComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[EPNLOHPPMHG(1)]
		public bool myBool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[EPNLOHPPMHG(2)]
		public byte myByte;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[EPNLOHPPMHG(3)]
		public short myShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[EPNLOHPPMHG(4)]
		public ushort myUShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[EPNLOHPPMHG(5)]
		public int myInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[EPNLOHPPMHG(6)]
		public uint myUInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[EPNLOHPPMHG(7)]
		public long myLong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[EPNLOHPPMHG(8)]
		public ulong myULong;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[EPNLOHPPMHG(9)]
		public float myFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[EPNLOHPPMHG(10)]
		public double myDouble;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[EPNLOHPPMHG(11)]
		public PICMHFOKCDE mySByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[EPNLOHPPMHG(12)]
		public AHIHCFCBMPP myByteEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[EPNLOHPPMHG(13)]
		public LMHEIPJDNLH myShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[EPNLOHPPMHG(14)]
		public IECGPAEIIHN myUShortEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[EPNLOHPPMHG(15)]
		public EGHFKBHGOLE myIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[EPNLOHPPMHG(16)]
		public FFHIGIHGLEN myUIntEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[EPNLOHPPMHG(17)]
		public EHOCKGMDENP myLongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[EPNLOHPPMHG(18)]
		public MLJEDOOPLGH myULongEnum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[EPNLOHPPMHG(20)]
		public Quaternion myQuat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[EPNLOHPPMHG(22)]
		public Vector3 myVec3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[EPNLOHPPMHG(23)]
		public Vector4 myVec4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[EPNLOHPPMHG(40)]
		public Entity myEntity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum PICMHFOKCDE : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum AHIHCFCBMPP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum LMHEIPJDNLH : short
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum IECGPAEIIHN : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum EGHFKBHGOLE
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum FFHIGIHGLEN : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum EHOCKGMDENP : long
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum MLJEDOOPLGH : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[FIOLLCFEOFH(1)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public SerializableGuid myGuid;
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[FIOLLCFEOFH(1)]
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
	[FIOLLCFEOFH(1)]
	public class TestNonSerializedManagedData : IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public TestNonSerializedManagedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class MGIIHNJMMLA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public struct FGLIMNIFFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public Vector3 PLGPJLHDKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public List<SerializableGuid> DMHNAFGGCBD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class MFHNHJJAFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public MFHNHJJAFML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public MGIIHNJMMLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[FFOOHLLCIMF]
public struct IKCICAKMNGI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public TimeData CAKJEKBKLMM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8FC810", Offset = "0x8FB610", VA = "0x1808FC810")]
	public static IKCICAKMNGI LJJFBFNEMCH(TimeData DPJGMDFEIDL)
	{
		return default(IKCICAKMNGI);
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[FIOLLCFEOFH(1)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[EPNLOHPPMHG(1)]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly LocalDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[FIOLLCFEOFH(1)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[EPNLOHPPMHG(1)]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[EPNLOHPPMHG(2)]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static LocalPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E8B940", Offset = "0x1E8A740", VA = "0x181E8B940")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x20A3BA0", Offset = "0x20A29A0", VA = "0x1820A3BA0")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x20A3BA0", Offset = "0x20A29A0", VA = "0x1820A3BA0")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[FIOLLCFEOFH(1)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[FIOLLCFEOFH(1)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly LocalToWorldData Default;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x20A4860", Offset = "0x20A3660", VA = "0x1820A4860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[FIOLLCFEOFH(1)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[EPNLOHPPMHG(1)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly LocalUniformScaleData Default;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct MCGBBJFAABK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int OJGPJCHJEJE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int DJIEOHJNDEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20A4990", Offset = "0x20A3790", VA = "0x1820A4990")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20A49A0", Offset = "0x20A37A0", VA = "0x1820A49A0")]
		set
		{
		}
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[FIOLLCFEOFH(1)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[EPNLOHPPMHG(1)]
		public CMOLAOEILGF transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[EPNLOHPPMHG(2)]
		public AJHMKPNKNEB transformPriority;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
[GJOBOFFAOFN(0, 1)]
public enum CMOLAOEILGF
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
[GJOBOFFAOFN(-2, 2)]
public enum AJHMKPNKNEB
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
	[FIOLLCFEOFH(1)]
	public struct WorldDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float3 worldDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly WorldDeformableScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[FIOLLCFEOFH(1)]
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
		[Cpp2IlInjected.Address(RVA = "0x20A5720", Offset = "0x20A4520", VA = "0x1820A5720")]
		public float3 TransformPoint(float3 point)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[FIOLLCFEOFH(1)]
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
[GJOBOFFAOFN(1000, 8001)]
public enum FIMAOKHBMMB
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
internal enum MOIPCLFKLFK
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
internal static class KFENMHHDCHJ
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[FIOLLCFEOFH(1)]
	public struct RRObjectPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[EPNLOHPPMHG(1)]
		public FIMAOKHBMMB prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class OGFKCMFFDKN
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x20A4D60", Offset = "0x20A3B60", VA = "0x1820A4D60")]
	public static bool MJCFKOHBBFL(this FIMAOKHBMMB LAKBKKJKBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x20A4C90", Offset = "0x20A3A90", VA = "0x1820A4C90")]
	public static string AONPELGKKEK(this FIMAOKHBMMB LAKBKKJKBPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x20A4D10", Offset = "0x20A3B10", VA = "0x1820A4D10")]
	public static CKIGPKJBBEE GHDBNJKOJMG(this FIMAOKHBMMB JPILKLCBOKG)
	{
		return default(CKIGPKJBBEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20A4D50", Offset = "0x20A3B50", VA = "0x1820A4D50")]
	internal static MOIPCLFKLFK MIKMPENOEMI(this CKIGPKJBBEE KMCHKBKKAOM)
	{
		return default(MOIPCLFKLFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x20A4D30", Offset = "0x20A3B30", VA = "0x1820A4D30")]
	internal static MOIPCLFKLFK MIKMPENOEMI(this FIMAOKHBMMB JPILKLCBOKG)
	{
		return default(MOIPCLFKLFK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[GJOBOFFAOFN(0, 9)]
public enum CKIGPKJBBEE
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
	[FIOLLCFEOFH(1)]
	public struct RRObjectTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[EPNLOHPPMHG(1)]
		public CKIGPKJBBEE objectType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public static class JDADLLAIKEI
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20A43B0", Offset = "0x20A31B0", VA = "0x1820A43B0")]
	public static bool FGPHIMPFBNN(this CKIGPKJBBEE KMCHKBKKAOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[GJOBOFFAOFN(int.MinValue, int.MaxValue)]
public enum GKODILJCEOK
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
[GJOBOFFAOFN(-1, 31)]
public enum LMMINPFLLCN
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
	[KEOEEIKLOKB("Visual", 0)]
	[FIOLLCFEOFH(1)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[ENACCFJMDFH(0)]
		[EPNLOHPPMHG(1)]
		public GKODILJCEOK color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[ENACCFJMDFH(0)]
		[EPNLOHPPMHG(2)]
		public LMMINPFLLCN material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[EPNLOHPPMHG(3)]
		[ENACCFJMDFH(0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[ENACCFJMDFH(0)]
		[EPNLOHPPMHG(4)]
		public Vector3 uvOffset;
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[Preserve]
	internal class _RRAssemblyIndex : IFFEHGABMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x20A5A70", Offset = "0x20A4870", VA = "0x1820A5A70", Slot = "4")]
		public sealed override void EAJHEFOPBGE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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

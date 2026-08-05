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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KHGDEONGNBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode INGGHCFOCCH;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GMAPLHCNHPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public JPJFGPKMKAE MMAGJLGHFCA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly LDLBEPLBNFE<GMAPLHCNHPH> IJJIHHKLCNA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PMJKDFFKKJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct CDNDHGBHNIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JPJFGPKMKAE
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
public struct FKJEGGNNHAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct GLGFHPHOIOL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity HOGAMINFHLD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JLAJCAAGHAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity HHNAEDAPOHF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NMINDGOHKBG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OGEEIDKKIIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity NMHGPHBIAIB;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DMFNHAEBOFC : DAFMOBCOHOG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AEPOLAMFMAE OGHDKGLEDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(AEPOLAMFMAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IDNHMMEMGJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 EOKFFGBPJAB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KPCADKNIIIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JCIIJANEHKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 JJIOHFBKFND;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly LDLBEPLBNFE<LGAPIAAEMMJ> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LGAPIAAEMMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 JJIOHFBKFND;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly LDLBEPLBNFE<LGAPIAAEMMJ> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BDBJHAOCPJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 KHHAMNEHLND;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ODONEAIFPKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 AIOIBEFJDAB;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FFPKNGKFFPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float CJEAPKMKFJB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly LDLBEPLBNFE<FFPKNGKFFPL> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PEMJPEPPEMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float EEDDDIIPBKM;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly LDLBEPLBNFE<PEMJPEPPEMJ> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MIMDANGPLKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 JBJNMKNAMLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MFJLOCJLJEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NLLCDEONLOL NJHFANHKNGN;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NHJLKEKODGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NLLCDEONLOL GDPJHHONJDA;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CKCAEDJHFBA]
public struct CAEGAEOCBKG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity BMHPCOMOJJA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DLKALLMMFBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KENKLIENMND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JAJPLBEBILO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PDANPKNONGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints IDMEOBBKOGF;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NKFHGAGJEBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float NFNLCFMFAPC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly LDLBEPLBNFE<NKFHGAGJEBN> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IACNAJKFFID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float PNEOPFBAHPF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct EFGAELJMDCG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NAGOLACGMAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int IDGNGFDGGIG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD68740", Offset = "0xD67340", VA = "0x180D68740")]
	public static NAGOLACGMAH JLFJLFEACJM(int GCPEEAODAIB)
	{
		return default(NAGOLACGMAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DBKLFDKCIJF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody IDJLKFJMEJJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9330", Offset = "0x5EC7F30", VA = "0x185EC9330", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public DBKLFDKCIJF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KLODHMJCCBG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct AKHMPODCNHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 NHOJBJMMDJB;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FLJJHLPDFMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 OAAOAKNCDMA;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct EIECNGCBICG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float CMPFMDFNDAD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly LDLBEPLBNFE<EIECNGCBICG> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LLLNFHELPHI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object BLMIBNLAFNN;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEFC0", Offset = "0x5ECDBC0", VA = "0x185ECEFC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public LLLNFHELPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PHDMJFINLNC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object KHOCHDJAMPD;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0180", Offset = "0x5ECED80", VA = "0x185ED0180", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PHDMJFINLNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum NLLCDEONLOL
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum AKKMOBBIBLF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JNJNNIGHFML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODONBGLIOKM(JPJFGPKMKAE NLGHKNJEOOP, JPJFGPKMKAE BOKAPIHJLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFLLOCINJAK();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJHDMLMEGLI();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDAAJBODNFO(bool BLKPFDLAGAP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ICICGGFALMK();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJMMAJFPCEI();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KMDOAJKGDBA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public JNJNNIGHFML CCNKOACLDBA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE990", Offset = "0x5ECD590", VA = "0x185ECE990", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public KMDOAJKGDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class GCIILOIMMCG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(BELHNPEKEED nameHash, DBEDBICAADA stableTypeHash, Type type)> KKPNMDADLCD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(BELHNPEKEED nameHash, DBEDBICAADA stableTypeHash, Type type)> CMFFBEPOPME;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(BELHNPEKEED previousNameHash, DBEDBICAADA previousStableTypeHash, Type currentTypeName)> MPAHPEPBIIP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct NOBIAGINECC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, IEJAKIBCFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8C70", Offset = "0x5EC7870", VA = "0x185EC8C70", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct HOPLOGNPPIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[LMDHGOIBJJM(1)]
	public quaternion HFJOJGBHICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[LMDHGOIBJJM(2)]
	public float3 MNANBFFJBMF;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly LDLBEPLBNFE<HOPLOGNPPIO> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A23CB0", Offset = "0x3A228B0", VA = "0x183A23CB0")]
	public HOPLOGNPPIO(quaternion HFJOJGBHICN, float3 MNANBFFJBMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC50", Offset = "0x5ECC850", VA = "0x185ECDC50")]
	public static HOPLOGNPPIO JLFJLFEACJM(RigidTransform JICLEEIHEKF)
	{
		return default(HOPLOGNPPIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DICAPOMHCJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct MHKLJNGGDIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[LMDHGOIBJJM(1)]
	public float IGICPJJPDGI;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly LDLBEPLBNFE<MHKLJNGGDIA> IJJIHHKLCNA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[PKMKAHHGDOI]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, IEJAKIBCFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[LMDHGOIBJJM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8C80", Offset = "0x5EC7880", VA = "0x185EC8C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct CPPGBLOKLHE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, IEJAKIBCFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct IFJDKNKNHMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct OIFOABPPOJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[LMDHGOIBJJM(1)]
	public SerializableGuid GKCGMEKGHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[LMDHGOIBJJM(2)]
	public SerializableGuid EJECECMPMDH;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct FGLEHACFPMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity LAKNPEOOHBL;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct CAADMCFLPHC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity LAKNPEOOHBL;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[JIMFKCEGMCE("Container", 0)]
public struct BBDHELFDMLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(1)]
	public GFHGKAJKFGM IEAFBJIJOBL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LDLBEPLBNFE<BBDHELFDMLF> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[EJCCOCAMOMI(0, 127)]
public enum GFHGKAJKFGM
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
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MBCBDBOKMFA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum LIPMAJDIBHM
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

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum BKFLNMIOBIL
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
	[Cpp2IlInjected.Address(RVA = "0x5ECF140", Offset = "0x5ECDD40", VA = "0x185ECF140")]
	public static (LIPMAJDIBHM, BKFLNMIOBIL) DACHPJGFNOO(this GFHGKAJKFGM JIKAOCCHNGJ)
	{
		return default((LIPMAJDIBHM, BKFLNMIOBIL));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[JIMFKCEGMCE("Container", 0)]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[PKMKAHHGDOI]
public struct LJIHNCJGCKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[LMDHGOIBJJM(1)]
	[KIAJPGKOKPB(0)]
	public ABALNHFPMDH IMGAOHEHAKJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly LDLBEPLBNFE<LJIHNCJGCKC> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[EJCCOCAMOMI(0, 2)]
public enum ABALNHFPMDH
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
[Cpp2IlInjected.Token(Token = "0x2000042")]
[JIMFKCEGMCE("Container", 0)]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct HGLIHEDEENK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(1)]
	public JPEPEFFLGDM PAICBJIFGBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
[EJCCOCAMOMI(0, 15943)]
public enum JPEPEFFLGDM
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
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct EEDDILJDPEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct LPMBMPHFFAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct EDDPKCMAOKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LOMJKAHPEHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct NJKOOFHMFPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct AFAHGINENGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct CBIEPNFHOAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct BICAHNMKDOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HLMNIMHFKFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[JIMFKCEGMCE("Container", 0)]
[PKMKAHHGDOI]
public struct LLBCPDOKJJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[LMDHGOIBJJM(1)]
	[KIAJPGKOKPB(0)]
	public float KAHEGMOFBDB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[PKMKAHHGDOI]
[JIMFKCEGMCE("Container", 0)]
public struct PHNPNLBBOIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[LMDHGOIBJJM(1)]
	[KIAJPGKOKPB(0)]
	public FixedString64Bytes JEICAPDKHKI;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct LBPFALJNOND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<MDGODGEJEGN> DMKHMLIHBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<Entity> PNMCCHBLGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JobHandle JJFOCCDGDHO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EJCLNBICOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC40", Offset = "0x5ECD840", VA = "0x185ECEC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEAD0", Offset = "0x5ECD6D0", VA = "0x185ECEAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x437E360", Offset = "0x437CF60", VA = "0x18437E360")]
	public LBPFALJNOND(NativeList<MDGODGEJEGN> DMKHMLIHBGI, NativeList<Entity> PNMCCHBLGHM, JobHandle JJFOCCDGDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEB20", Offset = "0x5ECD720", VA = "0x185ECEB20")]
	public (Entity, NativeSlice<Entity>) LBONMHJKPKE(int JBCJBAEMMMK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEA70", Offset = "0x5ECD670", VA = "0x185ECEA70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MDGODGEJEGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity NMHGPHBIAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int IAKOFEGDGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NBJKCBMEDIG;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface IMGODINOIFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBJJGDODHCM(bool KOLAFCPOOIC);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[JIMFKCEGMCE("Container", 0)]
[PKMKAHHGDOI]
public struct OEHNDBMLCBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(1)]
	public CPFOCDODPOM EOJMFJJGBIL;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[EJCCOCAMOMI(0, 1)]
public enum CPFOCDODPOM
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
[Cpp2IlInjected.Token(Token = "0x2000054")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
[JIMFKCEGMCE("Container", 0)]
public struct EDNNMILBNFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(1)]
	public FANFPFCHADK JDBALFGPGDD;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly LDLBEPLBNFE<EDNNMILBNFD> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[EJCCOCAMOMI(0, 2)]
public enum FANFPFCHADK
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[OIINJIJKLNA(1)]
public struct ACJOHOEJBGA : IComparable<ACJOHOEJBGA>, IEquatable<ACJOHOEJBGA>, MNPAKPLALJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[JAFDBIELMAO(1)]
	public uint NIPEKHLNHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[JAFDBIELMAO(2)]
	public uint KGEGJACFBPG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint BKOOBJNGJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8500", Offset = "0x5EC7100", VA = "0x185EC8500")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8740", Offset = "0x5EC7340", VA = "0x185EC8740")]
	public ACJOHOEJBGA(int NIPEKHLNHAM, int CCNBLJEHMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8740", Offset = "0x5EC7340", VA = "0x185EC8740")]
	public ACJOHOEJBGA(uint NIPEKHLNHAM, uint CCNBLJEHMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8510", Offset = "0x5EC7110", VA = "0x185EC8510")]
	public ACJOHOEJBGA NMJILHDEICJ(int IAKOFEGDGBF = 1)
	{
		return default(ACJOHOEJBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EC85F0", Offset = "0x5EC71F0", VA = "0x185EC85F0")]
	public ACJOHOEJBGA PCHHHOGIDHJ(int IAKOFEGDGBF = 1)
	{
		return default(ACJOHOEJBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EC82E0", Offset = "0x5EC6EE0", VA = "0x185EC82E0")]
	public static ACJOHOEJBGA DKNCKBCOKGC(ACJOHOEJBGA CNJMMNBENNL, ACJOHOEJBGA PLPCDFMLHIL)
	{
		return default(ACJOHOEJBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8360", Offset = "0x5EC6F60", VA = "0x185EC8360")]
	private static uint EPPAACKONIJ(uint FLGIINLNNEM, uint KNDAEONALIC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC82C0", Offset = "0x5EC6EC0", VA = "0x185EC82C0", Slot = "4")]
	public int CompareTo(ACJOHOEJBGA LLMHBOEDHFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC83B0", Offset = "0x5EC6FB0", VA = "0x185EC83B0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8660", Offset = "0x5EC7260", VA = "0x185EC8660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8390", Offset = "0x5EC6F90", VA = "0x185EC8390", Slot = "5")]
	public bool Equals(ACJOHOEJBGA LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8440", Offset = "0x5EC7040", VA = "0x185EC8440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8580", Offset = "0x5EC7180", VA = "0x185EC8580", Slot = "6")]
	public void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8490", Offset = "0x5EC7090", VA = "0x185EC8490", Slot = "7")]
	public void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2611980", Offset = "0x2610580", VA = "0x182611980")]
	public static bool JONBIHPGCCI(ACJOHOEJBGA CNJMMNBENNL, ACJOHOEJBGA PLPCDFMLHIL)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[OIINJIJKLNA(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[JAFDBIELMAO(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[JAFDBIELMAO(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[JAFDBIELMAO(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[JAFDBIELMAO(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[OIINJIJKLNA(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, MNPAKPLALJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[JAFDBIELMAO(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		public static SerializableGuid JLFJLFEACJM(Guid OGCEPACDHOE)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1150", Offset = "0x5ECFD50", VA = "0x185ED1150", Slot = "4")]
		public bool Equals(SerializableGuid LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1130", Offset = "0x5ECFD30", VA = "0x185ED1130", Slot = "5")]
		public int CompareTo(SerializableGuid LLMHBOEDHFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1200", Offset = "0x5ECFE00", VA = "0x185ED1200", Slot = "6")]
		public void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1180", Offset = "0x5ECFD80", VA = "0x185ED1180", Slot = "7")]
		public void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5ED12C0", Offset = "0x5ECFEC0", VA = "0x185ED12C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct LDGBEOPKAHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct LNMNGADKLPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct PFKFJMEHANK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
[PKMKAHHGDOI]
public struct PIAJKLDPDKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[LMDHGOIBJJM(1)]
	public Entity LJAABCGBANE;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[InternalBufferCapacity(17)]
public struct GKFOHKJBIBH : IBufferElementData, IEquatable<GKFOHKJBIBH>, IEJAKIBCFNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Entity HOGAMINFHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public int MBHEOBIOBGA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity DGBHEABCEPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD340", Offset = "0x5ECBF40", VA = "0x185ECD340", Slot = "4")]
	public bool Equals(GKFOHKJBIBH LLMHBOEDHFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
public struct DEBCGKLJFGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[LMDHGOIBJJM(1)]
	public int MBHEOBIOBGA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct LLEFAMELGFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
public struct ACCGJKJCKHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[LMDHGOIBJJM(1)]
	public Entity FMHELLDDDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[LMDHGOIBJJM(2)]
	public uint IEGBAKFGIPG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId FPPPDDNDCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1CDC940", Offset = "0x1CDB540", VA = "0x181CDC940")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1D018D0", Offset = "0x1D004D0", VA = "0x181D018D0")]
	public ACCGJKJCKHM(Entity FMHELLDDDCN, EntityBundlePartId DGNMOAFBBAB)
	{
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85B580", Offset = "0x85A180", VA = "0x18085B580")]
		internal EntityBundlePartId(uint HLINMGJJNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85B650", Offset = "0x85A250", VA = "0x18085B650")]
		internal uint EONFELDMDKM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7EC780", Offset = "0x7EB380", VA = "0x1807EC780", Slot = "4")]
		public bool Equals(EntityBundlePartId LLMHBOEDHFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9C00", Offset = "0x5EC8800", VA = "0x185EC9C00", Slot = "0")]
		public override bool Equals(object IIFJCGIHMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x877E30", Offset = "0x876A30", VA = "0x180877E30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1709750", Offset = "0x1708350", VA = "0x181709750")]
		public static bool JONBIHPGCCI(EntityBundlePartId FLGIINLNNEM, EntityBundlePartId KNDAEONALIC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct LKEGIDMPBOB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity DFNHOAIOPIK;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct HAOCJHFBPKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[LMDHGOIBJJM(1)]
	public Entity JIGKIEPHJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[LMDHGOIBJJM(2)]
	public bool DFBGLEAEBNK;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct LGGBKJCBDMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[LMDHGOIBJJM(1)]
	public DHFEEPEILLB AFPOCPOJPMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[EJCCOCAMOMI(0, 4)]
public enum DHFEEPEILLB
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
[PKMKAHHGDOI]
public struct GIJOHAPFDEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[LMDHGOIBJJM(1)]
	public Entity JIGKIEPHJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[LMDHGOIBJJM(2)]
	public bool LGHNFDAEKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[LMDHGOIBJJM(3)]
	public float NFLDOCFLJPE;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[PKMKAHHGDOI]
public struct FBGDKBMNOEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[LMDHGOIBJJM(1)]
	public bool DIFJPIHEJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[LMDHGOIBJJM(2)]
	public bool LGHNFDAEKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[LMDHGOIBJJM(3)]
	public float MLKKAHKGKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[LMDHGOIBJJM(4)]
	public float LEGCGEBFEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[LMDHGOIBJJM(5)]
	public float NHPFEEAIFCM;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct GCFMNDBEFDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[LMDHGOIBJJM(1)]
	public bool DIFJPIHEJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[LMDHGOIBJJM(2)]
	public bool LGHNFDAEKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[LMDHGOIBJJM(3)]
	public float NFLDOCFLJPE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, IEJAKIBCFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8C70", Offset = "0x5EC7870", VA = "0x185EC8C70", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[PKMKAHHGDOI]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, IEJAKIBCFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[LMDHGOIBJJM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, IEJAKIBCFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DB510", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x170F410", Offset = "0x170E010", VA = "0x18170F410")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LEIBBLJGCOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface IEJAKIBCFNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity BEKOPPEPOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct EDNKCOGLPJE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly bool LNBKOGHJAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public uint NGJDNKEJIBF;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	private static bool PKNMDIJALGO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
[PKMKAHHGDOI]
[JIMFKCEGMCE("Light", 0)]
public struct IJNKAFMIGBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[LMDHGOIBJJM(1)]
	[KIAJPGKOKPB(0)]
	public bool CDMIKOHKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[LMDHGOIBJJM(2)]
	[KIAJPGKOKPB(0)]
	public float AJDCCLPIMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(3)]
	public float ADDDGLKAEAB;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[JIMFKCEGMCE("Light", 0)]
[PKMKAHHGDOI]
public struct DKPFOBHMOMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[LMDHGOIBJJM(1)]
	[KIAJPGKOKPB(0)]
	public float NHBCKDCMEMC;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.TypeVersion(2)]
public struct POAHFCIEDHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public uint BKNNLLIHNOL;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5ED02B0", Offset = "0x5ECEEB0", VA = "0x185ED02B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[PKMKAHHGDOI]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[JAFDBIELMAO(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct MPDNBCCDEBN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int JMFEJOLNILE;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct OIEJGGANKEK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public GCHandle LPKJLAEIMOL;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[EJCCOCAMOMI(0, 4)]
public enum ABNGCMNINCD
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MKMKFKHFMEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JEBEAEIHALL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public int JMFEJOLNILE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct AABILFPLAFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct AHGGHBKKHHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DMMCMFJOAJL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[JIMFKCEGMCE("Object", 0)]
[PKMKAHHGDOI]
[TypeManager.TypeVersion(3)]
public struct KEECBCHACBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[LMDHGOIBJJM(2)]
	public DJEALNCOMGE LEFMDKLHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[LMDHGOIBJJM(3)]
	[KIAJPGKOKPB(0)]
	public BOCEJMGJIJI NDKLIKPIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(4)]
	public HAEEMLMCOBG POIAFGGHCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[JAFDBIELMAO(5)]
	public FBPNMEOLHLH PAICBJIFGBJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static readonly LDLBEPLBNFE<KEECBCHACBH> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class OICCLPDGMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFDA0", Offset = "0x5ECE9A0", VA = "0x185ECFDA0")]
	public static void INLCAGHFLDH(this FBPNMEOLHLH PAICBJIFGBJ, DIKHKFBIDHP NEDCEJHAEFB, bool LPOCOBOKBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFDD0", Offset = "0x5ECE9D0", VA = "0x185ECFDD0")]
	public static bool JBCHHPIONPM(this FBPNMEOLHLH PAICBJIFGBJ, DIKHKFBIDHP NEDCEJHAEFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFDF0", Offset = "0x5ECE9F0", VA = "0x185ECFDF0")]
	public static FBPNMEOLHLH JMPBHIEMANI(this DIKHKFBIDHP NEDCEJHAEFB)
	{
		return default(FBPNMEOLHLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFD80", Offset = "0x5ECE980", VA = "0x185ECFD80")]
	public static void INLCAGHFLDH(this BOCEJMGJIJI PAICBJIFGBJ, BOCEJMGJIJI PELFNJFDMPH, bool LPOCOBOKBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE5E0", Offset = "0x5DED1E0", VA = "0x185DEE5E0")]
	public static bool JBCHHPIONPM(this BOCEJMGJIJI PAICBJIFGBJ, BOCEJMGJIJI NEDCEJHAEFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum DIKHKFBIDHP
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[EJCCOCAMOMI(0, 16383)]
[Flags]
public enum FBPNMEOLHLH
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[EJCCOCAMOMI(0, 3)]
[Flags]
public enum BOCEJMGJIJI
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	MAX = 3
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[EJCCOCAMOMI(0, 4)]
[GHPHKELDAEL]
public enum HAEEMLMCOBG
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class GHPHKELDAEL : OKMJFPLFEIL
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD270", Offset = "0x5ECBE70", VA = "0x185ECD270", Slot = "7")]
	public override string JJDHKAOFKGE(string DACFGCGDCAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC380", Offset = "0x3CFAF80", VA = "0x183CFC380")]
	public GHPHKELDAEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[OIINJIJKLNA(1)]
public struct DJEALNCOMGE : MNPAKPLALJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[JAFDBIELMAO(1)]
	public bool CDMIKOHKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[JAFDBIELMAO(2)]
	public float3 PPIFLNDHMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[JAFDBIELMAO(3)]
	public float3 HBMPKHCJOFD;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static readonly LDLBEPLBNFE<DJEALNCOMGE> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9420", Offset = "0x5EC8020", VA = "0x185EC9420", Slot = "5")]
	public void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9490", Offset = "0x5EC8090", VA = "0x185EC9490", Slot = "4")]
	public void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct DHLJNJENLOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct BELLBNALANM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct BHILMLFNHOE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct HIBHKOEJEAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public FixedString32Bytes JEICAPDKHKI;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[CKCAEDJHFBA]
public struct PIDCEHFAMMH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Entity LLAJBOAGJHA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static PIDCEHFAMMH JLFJLFEACJM(Entity GCPEEAODAIB)
	{
		return default(PIDCEHFAMMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
[PKMKAHHGDOI]
public struct PDJOCLODBPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[LMDHGOIBJJM(1)]
	public Entity BDJKACIDCKJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static PDJOCLODBPE JLFJLFEACJM(Entity BMHPCOMOJJA)
	{
		return default(PDJOCLODBPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct IKAOMOHPIPM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Entity BMHPCOMOJJA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static IKAOMOHPIPM JLFJLFEACJM(Entity BMHPCOMOJJA)
	{
		return default(IKAOMOHPIPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct GGDCOIINADH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Entity JNPLLOELGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Entity KOIDCJBBLKP;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal struct LBNDKGHJBJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Entity DOGAAEIJNIC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static LBNDKGHJBJL JLFJLFEACJM(Entity BMHPCOMOJJA)
	{
		return default(LBNDKGHJBJL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal struct IEBCDFCEBFM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[EJCCOCAMOMI(0, 2)]
public enum KLIBJIMJNHI
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[JIMFKCEGMCE("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[PKMKAHHGDOI]
public struct BPEIFGMEMNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[LMDHGOIBJJM(1)]
	[KIAJPGKOKPB(0)]
	public float HACAJCKENNA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly LDLBEPLBNFE<BPEIFGMEMNG> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
[PKMKAHHGDOI]
public struct GFCJEHHAAEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[LMDHGOIBJJM(1)]
	public DGEEPCMBCIA PNCHAPFAAIG;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[EJCCOCAMOMI(-1, 38)]
public enum DGEEPCMBCIA
{
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
[PKMKAHHGDOI]
public struct MIDHFOFIIGO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[EJCCOCAMOMI(0, 7)]
	[Flags]
	public enum POGNHNHFAGB
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[LMDHGOIBJJM(1)]
	public POGNHNHFAGB PAICBJIFGBJ;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static readonly LDLBEPLBNFE<MIDHFOFIIGO> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OAIMENANDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF690", Offset = "0x5ECE290", VA = "0x185ECF690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HPIHNNFPMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF6A0", Offset = "0x5ECE2A0", VA = "0x185ECF6A0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
[PKMKAHHGDOI]
public struct DPCMIFDHGEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[LMDHGOIBJJM(1)]
	public KLIBJIMJNHI PNCHAPFAAIG;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct AJJCCJLDAMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public uint DLBBNPMBKBG;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[OIINJIJKLNA(1)]
public struct EDNJPEBBPFN : MNPAKPLALJI
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[Flags]
	[EJCCOCAMOMI(0, 7)]
	public enum PKCJFLAOOBE
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[JAFDBIELMAO(1)]
	public float FOGEDAMHJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[JAFDBIELMAO(2)]
	public int EGIEJPNCCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[JAFDBIELMAO(3)]
	public PKCJFLAOOBE PAICBJIFGBJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JHCFDFEJCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9A60", Offset = "0x5EC8660", VA = "0x185EC9A60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC99E0", Offset = "0x5EC85E0", VA = "0x185EC99E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EFNNBMPPIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC99D0", Offset = "0x5EC85D0", VA = "0x185EC99D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC99B0", Offset = "0x5EC85B0", VA = "0x185EC99B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JPBLLIKLDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9930", Offset = "0x5EC8530", VA = "0x185EC9930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9990", Offset = "0x5EC8590", VA = "0x185EC9990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9940", Offset = "0x5EC8540", VA = "0x185EC9940", Slot = "5")]
	public void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9A00", Offset = "0x5EC8600", VA = "0x185EC9A00", Slot = "4")]
	public void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[CKCAEDJHFBA]
internal struct KPFENBNCALE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Entity PBBBKLGPJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public int DCGGFHOCGGH;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct ALHENOIDKPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[LMDHGOIBJJM(1)]
	public ACJOHOEJBGA HDJFIBIFIHN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x848D40", Offset = "0x847940", VA = "0x180848D40")]
	public static ALHENOIDKPP JLFJLFEACJM(ACJOHOEJBGA GCPEEAODAIB)
	{
		return default(ALHENOIDKPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[PKMKAHHGDOI]
public struct HKHMHNFFAID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[LMDHGOIBJJM(1)]
	public Entity OGLIKAGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal struct JPEAMMHMCDD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Entity OGLIKAGGMMP;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[PKMKAHHGDOI]
public struct BBMCHGLLAGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[LMDHGOIBJJM(1)]
	public float3 MNANBFFJBMF;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static readonly LDLBEPLBNFE<BBMCHGLLAGF> IJJIHHKLCNA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2021DA0", Offset = "0x20209A0", VA = "0x182021DA0")]
	public static BBMCHGLLAGF JLFJLFEACJM(float3 GCPEEAODAIB)
	{
		return default(BBMCHGLLAGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
[PKMKAHHGDOI]
public struct IAFHCNBAABP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[LMDHGOIBJJM(1)]
	public quaternion HFJOJGBHICN;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static readonly LDLBEPLBNFE<IAFHCNBAABP> IJJIHHKLCNA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
	public static IAFHCNBAABP JLFJLFEACJM(quaternion GCPEEAODAIB)
	{
		return default(IAFHCNBAABP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct NOBNDHMNENE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[LMDHGOIBJJM(1)]
	public float3 FCPAMILEHFO;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly LDLBEPLBNFE<NOBNDHMNENE> IJJIHHKLCNA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2021DA0", Offset = "0x20209A0", VA = "0x182021DA0")]
	public static NOBNDHMNENE JLFJLFEACJM(float3 GCPEEAODAIB)
	{
		return default(NOBNDHMNENE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct PICLDLOOFBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[LMDHGOIBJJM(1)]
	public EDNJPEBBPFN OCFPIAIMFIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct EOOCPBJIJHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct KGKCMPHDMDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public uint NGJDNKEJIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public int EFCMFFFKCMN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA0F810", Offset = "0xA0E410", VA = "0x180A0F810")]
	public KGKCMPHDMDO(uint CJIHILILCLE, int DEHLALHLEBF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct KEDHMCKHMOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct HMIIBKPNOHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct MJKLFMMOMFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct OIGKHJHPNJL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct GCPHHPBIGCL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct KPHCEJBNEEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct FFEJFIHOCGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct PFEEBJDKKLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct BEANAFECLHH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct CACPDGFLALE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct ILOGAGLCMPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct ADHCNDFKFJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal struct ELHPBCFFNHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct IKKDPLBBCMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct BAJPEKABKOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
[PKMKAHHGDOI]
public struct CGBMPGFKEME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[LMDHGOIBJJM(1)]
	public FixedList32Bytes<int> NIIGEFKBMIC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct NBOOPILLAFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct JANBKIBOOJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct OGBCLAPPAOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct DDHCNPOAIJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct BEKHLDBEIAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct PHDGOJMGNKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct GECFHAKIPPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct CLCBNFAKMOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[CKCAEDJHFBA]
public struct GMAGKEJBBHP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public FixedString32Bytes DONFKHJMCEA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct NNONNJEFIKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct EHPHCBLDPBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct HPKFDOGOAAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct JIFMBFACBHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[JAFDBIELMAO(1)]
	public OMFMNPOCIPG DLBBNPMBKBG;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly LDLBEPLBNFE<JIFMBFACBHL> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum OMFMNPOCIPG : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct KMHHBHNENFF : IComponentData, IComparable<KMHHBHNENFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int KIBCEKJDKNE;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1719350", Offset = "0x1717F50", VA = "0x181719350", Slot = "4")]
	public int CompareTo(KMHHBHNENFF LLMHBOEDHFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct IMHLLPDILEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[LMDHGOIBJJM(2)]
	public bool DKFAPAKLMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[LMDHGOIBJJM(3)]
	public bool KLLICFNPBFP;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public static readonly LDLBEPLBNFE<IMHLLPDILEI> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[PKMKAHHGDOI]
public struct PLIPAPDEGCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[LMDHGOIBJJM(1)]
	public bool IPDBEHOFANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[LMDHGOIBJJM(2)]
	public byte PINGGMDEFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[LMDHGOIBJJM(3)]
	public short HKGDGLEMPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[LMDHGOIBJJM(4)]
	public ushort KNHCMEGKGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[LMDHGOIBJJM(5)]
	public int DBLHBAMBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[LMDHGOIBJJM(6)]
	public uint HAMMFNGJBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[LMDHGOIBJJM(7)]
	public long MBCIGBNJAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[LMDHGOIBJJM(8)]
	public ulong HCLPLPCMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[LMDHGOIBJJM(9)]
	public float LPAHOMLHELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[LMDHGOIBJJM(10)]
	public double APPOEKIPOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[LMDHGOIBJJM(11)]
	public GGFAKALICKO HFJIENNNPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[LMDHGOIBJJM(12)]
	public DAIMELFMIEH IADKDDGLELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[LMDHGOIBJJM(13)]
	public ALKCPJLJOCD IFICHIOHHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[LMDHGOIBJJM(14)]
	public HOIENMENMNG JAGOEAHJPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[LMDHGOIBJJM(15)]
	public CJFMDCFPBPG KNOPADGBBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[LMDHGOIBJJM(16)]
	public ONGIAPNNLDI LAGNCNBAJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[LMDHGOIBJJM(17)]
	public LEEGLNOCPFJ NKDKDKBMBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[LMDHGOIBJJM(18)]
	public BFJPECNDIEC LICNCNBDAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[LMDHGOIBJJM(20)]
	public Quaternion GGFDGKFFBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[LMDHGOIBJJM(22)]
	public Vector3 OPHPNMKCMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[LMDHGOIBJJM(23)]
	public Vector4 AMCDOAFJIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[LMDHGOIBJJM(40)]
	public Entity FGMBILLALBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum GGFAKALICKO : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public enum DAIMELFMIEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum ALKCPJLJOCD : short
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum HOIENMENMNG : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum CJFMDCFPBPG
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum ONGIAPNNLDI : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum LEEGLNOCPFJ : long
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum BFJPECNDIEC : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[PKMKAHHGDOI]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[PKMKAHHGDOI]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class FOLAPKAAEHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public int KCGANELMDLB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public int OHHOAPLOOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public GameObject LCHNDEILNAI;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public FOLAPKAAEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class PGOOAKHAEDC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public struct HKDJLJBDBMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Vector3 AMDLPCJONCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<SerializableGuid> KCAHLNMGGGB;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class FELGBNNNPFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public HKDJLJBDBMJ ANLIJAAEFCK;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FELGBNNNPFK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public SerializableGuid CIHFIIEKLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public List<int> LPAJDAJAHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public List<HKDJLJBDBMJ> LJKCMDFGKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public List<FELGBNNNPFK> LJJKHBLANDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public GameObject LCHNDEILNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Light APBMJPMNFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Collider JANMHBBPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public string LHIGBDDBEDF;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public PGOOAKHAEDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct KNHFOLIGHGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[LMDHGOIBJJM(1)]
	public float3 DNBNCBIKLDM;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public static readonly LDLBEPLBNFE<KNHFOLIGHGN> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
[PKMKAHHGDOI]
public struct MHOAPHDHNOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[LMDHGOIBJJM(1)]
	public quaternion HFJOJGBHICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[LMDHGOIBJJM(2)]
	public float3 MNANBFFJBMF;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly LDLBEPLBNFE<MHOAPHDHNOD> IJJIHHKLCNA;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3A23CB0", Offset = "0x3A228B0", VA = "0x183A23CB0")]
	public MHOAPHDHNOD(quaternion HFJOJGBHICN, float3 MNANBFFJBMF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC50", Offset = "0x5ECC850", VA = "0x185ECDC50")]
	public static RigidTransform JLFJLFEACJM(MHOAPHDHNOD IMCKNCPDIFP)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC50", Offset = "0x5ECC850", VA = "0x185ECDC50")]
	public static MHOAPHDHNOD JLFJLFEACJM(RigidTransform JICLEEIHEKF)
	{
		return default(MHOAPHDHNOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class BMJJNODEEJB
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct KMCIHOJDCLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float4x4 OMIALMKPIKC;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly LDLBEPLBNFE<KMCIHOJDCLG> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public struct BANIJNNMHIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float4x4 NBIONLPNBED;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static readonly LDLBEPLBNFE<BANIJNNMHIA> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct BMDHCLDOKMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	[LMDHGOIBJJM(1)]
	public float IGICPJJPDGI;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static readonly LDLBEPLBNFE<BMDHCLDOKMD> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct EFJGFDJBEFF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int KLNFACINDDK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int DCGGFHOCGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9B90", Offset = "0x5EC8790", VA = "0x185EC9B90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9B80", Offset = "0x5EC8780", VA = "0x185EC9B80")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[PKMKAHHGDOI]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct EDDDKHLKCIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[LMDHGOIBJJM(1)]
	public HNOMGJKMKNG OGIPBOOOJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[LMDHGOIBJJM(2)]
	public OBGBIKKOBLI ELDMJJNKGOA;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[EJCCOCAMOMI(0, 1)]
[Flags]
public enum HNOMGJKMKNG
{
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[EJCCOCAMOMI(-2, 2)]
public enum OBGBIKKOBLI
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public struct CEGPOMGBJDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public float3 BLBCLBFPHNL;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static readonly LDLBEPLBNFE<CEGPOMGBJDL> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct HDAEEMOLGEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public float3 CFCLFCDKKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public quaternion HFKFMHAMLPE;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly LDLBEPLBNFE<HDAEEMOLGEG> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class NLOGLCGJIPG
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public struct NPBGJCJLLOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public float HACAFPJKLGH;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static readonly LDLBEPLBNFE<NPBGJCJLLOP> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[EJCCOCAMOMI(1000, 8000)]
public enum LGFPBEODEOP
{
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class GDBCAHNAPNG
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal enum BKPDOBOEFMC
{
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	UNUSED = 0,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal static class GANJHPBCOBG
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[EJCCOCAMOMI(0, 9)]
public enum LHIDJJOMBAL
{
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	UNUSED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class IGOICDLMHEB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDF20", Offset = "0x5ECCB20", VA = "0x185ECDF20")]
	public static bool FHOPEHLCDHK(this LHIDJJOMBAL FCEKIPAFNIB)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[PKMKAHHGDOI]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public LGFPBEODEOP prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class HEJNGPDNPIF
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD5C0", Offset = "0x5ECC1C0", VA = "0x185ECD5C0")]
	public static LHIDJJOMBAL GFIJEKLIJIJ(this LGFPBEODEOP LMBLGMDMJHB)
	{
		return default(LHIDJJOMBAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[EJCCOCAMOMI(int.MinValue, int.MaxValue)]
public enum HPOFGPIKEKI
{
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[EJCCOCAMOMI(-1, 31)]
public enum AEEGCPHNDCI
{
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[PKMKAHHGDOI]
[JIMFKCEGMCE("Visual", 0)]
public struct DFFGNAJMCBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(1)]
	public HPOFGPIKEKI EFLLOODPMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(2)]
	public AEEGCPHNDCI ELHBBBNEEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	[LMDHGOIBJJM(3)]
	[KIAJPGKOKPB(0)]
	public float KFGMOBNNEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(4)]
	public Vector3 ANNJABPPGBG;
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[DIINGMIDHHG]
[CPCBKBLAPOL(2613756846563002039uL, 6372660366488563574uL)]
[JIMFKCEGMCE("Container", 0)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct HLCFLJGFBNF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(1)]
	public LAKALBBNACN PDCCHFLHMHM;
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[Flags]
[EJCCOCAMOMI(0, 15)]
public enum LAKALBBNACN
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[DIINGMIDHHG]
[CPCBKBLAPOL(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct NOHNBAKHIND : IComponentData, IEquatable<NOHNBAKHIND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[LMDHGOIBJJM(1)]
	public FixedString64Bytes JEICAPDKHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[LMDHGOIBJJM(2)]
	public ABALNHFPMDH IMGAOHEHAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[LMDHGOIBJJM(3)]
	public LAKALBBNACN PDCCHFLHMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[LMDHGOIBJJM(4)]
	public CPFOCDODPOM EOJMFJJGBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[LMDHGOIBJJM(5)]
	public JPEPEFFLGDM PAICBJIFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[LMDHGOIBJJM(6)]
	public float KAHEGMOFBDB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFBD0", Offset = "0x5ECE7D0", VA = "0x185ECFBD0", Slot = "4")]
	public bool Equals(NOHNBAKHIND LLMHBOEDHFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[CPCBKBLAPOL(1213445203937950283uL, 119653618660684511uL)]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[DIINGMIDHHG]
public struct PEHPPPMPKAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[LMDHGOIBJJM(1)]
	public LNPIMFFONEJ HDPBLKCBIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public GCHandle BJMIJNLECJK;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[OIINJIJKLNA(1)]
public struct LNPIMFFONEJ : MNPAKPLALJI, IEquatable<LNPIMFFONEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[JAFDBIELMAO(1)]
	public int HLINMGJJNHD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF0B0", Offset = "0x5ECDCB0", VA = "0x185ECF0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF030", Offset = "0x5ECDC30", VA = "0x185ECF030", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7EC780", Offset = "0x7EB380", VA = "0x1807EC780", Slot = "6")]
	public bool Equals(LNPIMFFONEJ LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x17193E0", Offset = "0x1717FE0", VA = "0x1817193E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF110", Offset = "0x5ECDD10", VA = "0x185ECF110", Slot = "5")]
	public void JFKFFNFOIMD(KHBFNJIKOPG BIBCAMINPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF130", Offset = "0x5ECDD30", VA = "0x185ECF130", Slot = "4")]
	public void OIIEHDKDHEB(MBDOKFPFEPO BNGNOICJJGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[DIINGMIDHHG]
[CPCBKBLAPOL(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
public struct KOJFHNLMGKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private uint BPGECBFIBBB;
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[CPCBKBLAPOL(9898405628982320166uL, 2023375009558162791uL)]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[DIINGMIDHHG]
public struct PDNJCLMBDDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[LMDHGOIBJJM(1)]
	public FBPNMEOLHLH PAICBJIFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[LMDHGOIBJJM(2)]
	public DJEALNCOMGE LEFMDKLHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[LMDHGOIBJJM(3)]
	[KIAJPGKOKPB(0)]
	public bool FDEAAKAFIPA;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly LDLBEPLBNFE<PDNJCLMBDDK> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[DIINGMIDHHG]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[CPCBKBLAPOL(9807788745867066359uL, 15168486114979071194uL)]
public struct LCMOOFJIIEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[LMDHGOIBJJM(1)]
	public FBPNMEOLHLH PAICBJIFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[LMDHGOIBJJM(2)]
	public DJEALNCOMGE LEFMDKLHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[LMDHGOIBJJM(3)]
	[KIAJPGKOKPB(0)]
	public bool FDEAAKAFIPA;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly LDLBEPLBNFE<LCMOOFJIIEN> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[DIINGMIDHHG]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[CPCBKBLAPOL(4470189027631723570uL, 5922380073816386711uL)]
public struct IFINDBAPFKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[JAFDBIELMAO(1)]
	public FBPNMEOLHLH PAICBJIFGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[LMDHGOIBJJM(2)]
	public DJEALNCOMGE LEFMDKLHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[LMDHGOIBJJM(3)]
	[KIAJPGKOKPB(0)]
	public BOCEJMGJIJI NDKLIKPIFPC;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly LDLBEPLBNFE<IFINDBAPFKH> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[CPCBKBLAPOL(12226092714547765037uL, 15970362445488810630uL)]
[DIINGMIDHHG]
public struct MEJCPHMGHJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[LMDHGOIBJJM(2)]
	public DJEALNCOMGE LEFMDKLHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[KIAJPGKOKPB(0)]
	[LMDHGOIBJJM(3)]
	public BOCEJMGJIJI NDKLIKPIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[JAFDBIELMAO(4)]
	public FBPNMEOLHLH PAICBJIFGBJ;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly LDLBEPLBNFE<MEJCPHMGHJD> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
[CPCBKBLAPOL(3318727941304405759uL, 6047901070934821887uL)]
[DIINGMIDHHG]
public struct HOICPHCLLKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public int IDPCPEOPFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[LMDHGOIBJJM(2)]
	public bool DKFAPAKLMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[LMDHGOIBJJM(3)]
	public bool KLLICFNPBFP;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly LDLBEPLBNFE<HOICPHCLLKB> IJJIHHKLCNA;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[CPCBKBLAPOL(5861057081882613294uL, 13746475565109640919uL)]
[DIINGMIDHHG]
public struct NGOLNGGJDOC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[EJCCOCAMOMI(0, 1)]
	public enum NLFCHAKDIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		Custom = 1,
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		MAX = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	[LMDHGOIBJJM(1)]
	public NLFCHAKDIAJ FFPGKKBDIAJ;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[DIINGMIDHHG]
[CPCBKBLAPOL(14327281633525910712uL, 2559857777606771911uL)]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
public struct ECHPNMABDHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	[LMDHGOIBJJM(1)]
	public LGFPBEODEOP LMBLGMDMJHB;
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[DIINGMIDHHG]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[CPCBKBLAPOL(15725208981563603541uL, 17017036095303668770uL)]
public struct LLGOGCKLNAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	[LMDHGOIBJJM(1)]
	public LGFPBEODEOP LMBLGMDMJHB;
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[DIINGMIDHHG]
[CPCBKBLAPOL(1029043735688538310uL, 14256247939851101839uL)]
public struct JCPLDIBDOMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public LHIDJJOMBAL FCEKIPAFNIB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[DIINGMIDHHG]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[CPCBKBLAPOL(17667479821163689808uL, 11946378475791123970uL)]
public struct HCHHCBCOMEA : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : ELKGCLAEHBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED12D0", Offset = "0x5ECFED0", VA = "0x185ED12D0", Slot = "4")]
		public sealed override void EHGOPJFPBAN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class DODKENMNIOJ : ContainerPropertyBag<DBKLFDKCIJF>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class HAADDPIMNBN : Property<DBKLFDKCIJF, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD430", Offset = "0x5ECC030", VA = "0x185ECD430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD3F0", Offset = "0x5ECBFF0", VA = "0x185ECD3F0")]
		public HAADDPIMNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9C80", Offset = "0x5EC8880", VA = "0x185EC9C80", Slot = "14")]
		public override Rigidbody GetValue(DBKLFDKCIJF PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9CA0", Offset = "0x5EC88A0", VA = "0x185EC9CA0", Slot = "15")]
		public override void SetValue(DBKLFDKCIJF PCOJMOHPOND, Rigidbody GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9630", Offset = "0x5EC8230", VA = "0x185EC9630")]
	public DODKENMNIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class OICHEEFCDMN : ContainerPropertyBag<LLLNFHELPHI>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class OBEIFEEIEBE : Property<LLLNFHELPHI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5ECFD50", Offset = "0x5ECE950", VA = "0x185ECFD50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFD10", Offset = "0x5ECE910", VA = "0x185ECFD10")]
		public OBEIFEEIEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9C80", Offset = "0x5EC8880", VA = "0x185EC9C80", Slot = "14")]
		public override object GetValue(LLLNFHELPHI PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9CA0", Offset = "0x5EC88A0", VA = "0x185EC9CA0", Slot = "15")]
		public override void SetValue(LLLNFHELPHI PCOJMOHPOND, object GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE00", Offset = "0x5ECEA00", VA = "0x185ECFE00")]
	public OICHEEFCDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class MPDDMKLFCED : ContainerPropertyBag<PHDMJFINLNC>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class MNEEOMMMMNA : Property<PHDMJFINLNC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF740", Offset = "0x5ECE340", VA = "0x185ECF740", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF700", Offset = "0x5ECE300", VA = "0x185ECF700")]
		public MNEEOMMMMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9C80", Offset = "0x5EC8880", VA = "0x185EC9C80", Slot = "14")]
		public override object GetValue(PHDMJFINLNC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9CA0", Offset = "0x5EC88A0", VA = "0x185EC9CA0", Slot = "15")]
		public override void SetValue(PHDMJFINLNC PCOJMOHPOND, object GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF770", Offset = "0x5ECE370", VA = "0x185ECF770")]
	public MPDDMKLFCED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class EDJBBHCFBJL : ContainerPropertyBag<KMDOAJKGDBA>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class FEKNIKNCAED : Property<KMDOAJKGDBA, JNJNNIGHFML>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9D10", Offset = "0x5EC8910", VA = "0x185EC9D10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9CD0", Offset = "0x5EC88D0", VA = "0x185EC9CD0")]
		public FEKNIKNCAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9C80", Offset = "0x5EC8880", VA = "0x185EC9C80", Slot = "14")]
		public override JNJNNIGHFML GetValue(KMDOAJKGDBA PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9CA0", Offset = "0x5EC88A0", VA = "0x185EC9CA0", Slot = "15")]
		public override void SetValue(KMDOAJKGDBA PCOJMOHPOND, JNJNNIGHFML GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9850", Offset = "0x5EC8450", VA = "0x185EC9850")]
	public EDJBBHCFBJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class BHHIPIDGFOM : ContainerPropertyBag<FOLAPKAAEHH>
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class DMLCINKFKHB : Property<FOLAPKAAEHH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9600", Offset = "0x5EC8200", VA = "0x185EC9600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC95C0", Offset = "0x5EC81C0", VA = "0x185EC95C0")]
		public DMLCINKFKHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9580", Offset = "0x5EC8180", VA = "0x185EC9580", Slot = "14")]
		public override int GetValue(FOLAPKAAEHH PCOJMOHPOND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC95A0", Offset = "0x5EC81A0", VA = "0x185EC95A0", Slot = "15")]
		public override void SetValue(FOLAPKAAEHH PCOJMOHPOND, int GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class MDCPLNCKLOG : Property<FOLAPKAAEHH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF460", Offset = "0x5ECE060", VA = "0x185ECF460", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF420", Offset = "0x5ECE020", VA = "0x185ECF420")]
		public MDCPLNCKLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF3E0", Offset = "0x5ECDFE0", VA = "0x185ECF3E0", Slot = "14")]
		public override int GetValue(FOLAPKAAEHH PCOJMOHPOND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF400", Offset = "0x5ECE000", VA = "0x185ECF400", Slot = "15")]
		public override void SetValue(FOLAPKAAEHH PCOJMOHPOND, int GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class EECBIEBCDIN : Property<FOLAPKAAEHH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9B50", Offset = "0x5EC8750", VA = "0x185EC9B50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9B10", Offset = "0x5EC8710", VA = "0x185EC9B10")]
		public EECBIEBCDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9AC0", Offset = "0x5EC86C0", VA = "0x185EC9AC0", Slot = "14")]
		public override GameObject GetValue(FOLAPKAAEHH PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9AE0", Offset = "0x5EC86E0", VA = "0x185EC9AE0", Slot = "15")]
		public override void SetValue(FOLAPKAAEHH PCOJMOHPOND, GameObject GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8E40", Offset = "0x5EC7A40", VA = "0x185EC8E40")]
	public BHHIPIDGFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class APMIHDMHOBM : ContainerPropertyBag<PGOOAKHAEDC>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class PHGIDODLPLF : Property<PGOOAKHAEDC, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5ED0280", Offset = "0x5ECEE80", VA = "0x185ED0280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0240", Offset = "0x5ECEE40", VA = "0x185ED0240")]
		public PHGIDODLPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5ED01F0", Offset = "0x5ECEDF0", VA = "0x185ED01F0", Slot = "14")]
		public override SerializableGuid GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0220", Offset = "0x5ECEE20", VA = "0x185ED0220", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, SerializableGuid GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class BNGMCCHFIPH : Property<PGOOAKHAEDC, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5EC90D0", Offset = "0x5EC7CD0", VA = "0x185EC90D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9090", Offset = "0x5EC7C90", VA = "0x185EC9090")]
		public BNGMCCHFIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9040", Offset = "0x5EC7C40", VA = "0x185EC9040", Slot = "14")]
		public override List<int> GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9060", Offset = "0x5EC7C60", VA = "0x185EC9060", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, List<int> GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class FJONKJLPBLO : Property<PGOOAKHAEDC, List<PGOOAKHAEDC.HKDJLJBDBMJ>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9F60", Offset = "0x5EC8B60", VA = "0x185EC9F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9F20", Offset = "0x5EC8B20", VA = "0x185EC9F20")]
		public FJONKJLPBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9ED0", Offset = "0x5EC8AD0", VA = "0x185EC9ED0", Slot = "14")]
		public override List<PGOOAKHAEDC.HKDJLJBDBMJ> GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9EF0", Offset = "0x5EC8AF0", VA = "0x185EC9EF0", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, List<PGOOAKHAEDC.HKDJLJBDBMJ> GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class HPNMIGNHEEK : Property<PGOOAKHAEDC, List<PGOOAKHAEDC.FELGBNNNPFK>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5ECDD80", Offset = "0x5ECC980", VA = "0x185ECDD80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDD40", Offset = "0x5ECC940", VA = "0x185ECDD40")]
		public HPNMIGNHEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDCF0", Offset = "0x5ECC8F0", VA = "0x185ECDCF0", Slot = "14")]
		public override List<PGOOAKHAEDC.FELGBNNNPFK> GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDD10", Offset = "0x5ECC910", VA = "0x185ECDD10", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, List<PGOOAKHAEDC.FELGBNNNPFK> GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class KBLCOEFDLMD : Property<PGOOAKHAEDC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE470", Offset = "0x5ECD070", VA = "0x185ECE470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE430", Offset = "0x5ECD030", VA = "0x185ECE430")]
		public KBLCOEFDLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE3E0", Offset = "0x5ECCFE0", VA = "0x185ECE3E0", Slot = "14")]
		public override GameObject GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE400", Offset = "0x5ECD000", VA = "0x185ECE400", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, GameObject GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class PPMHEGNGMKC : Property<PGOOAKHAEDC, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5ED03D0", Offset = "0x5ECEFD0", VA = "0x185ED03D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0390", Offset = "0x5ECEF90", VA = "0x185ED0390")]
		public PPMHEGNGMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0340", Offset = "0x5ECEF40", VA = "0x185ED0340", Slot = "14")]
		public override Light GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0360", Offset = "0x5ECEF60", VA = "0x185ED0360", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, Light GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class AJFHEGMKNBH : Property<PGOOAKHAEDC, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8820", Offset = "0x5EC7420", VA = "0x185EC8820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EC87E0", Offset = "0x5EC73E0", VA = "0x185EC87E0")]
		public AJFHEGMKNBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8790", Offset = "0x5EC7390", VA = "0x185EC8790", Slot = "14")]
		public override Collider GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC87B0", Offset = "0x5EC73B0", VA = "0x185EC87B0", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, Collider GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class KDIEDAMFALN : Property<PGOOAKHAEDC, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE530", Offset = "0x5ECD130", VA = "0x185ECE530", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE4F0", Offset = "0x5ECD0F0", VA = "0x185ECE4F0")]
		public KDIEDAMFALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE4A0", Offset = "0x5ECD0A0", VA = "0x185ECE4A0", Slot = "14")]
		public override string GetValue(PGOOAKHAEDC PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE4C0", Offset = "0x5ECD0C0", VA = "0x185ECE4C0", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC PCOJMOHPOND, string GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8850", Offset = "0x5EC7450", VA = "0x185EC8850")]
	public APMIHDMHOBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class HLPPHHFBNIC : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class FENOMGJNIMK : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9E40", Offset = "0x5EC8A40", VA = "0x185EC9E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9D50", Offset = "0x5EC8950", VA = "0x185EC9D50")]
		public FENOMGJNIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xE05190", Offset = "0xE03D90", VA = "0x180E05190", Slot = "14")]
		public override Data128 GetValue(SerializableGuid PCOJMOHPOND)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9D40", Offset = "0x5EC8940", VA = "0x185EC9D40", Slot = "15")]
		public override void SetValue(SerializableGuid PCOJMOHPOND, Data128 GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDA60", Offset = "0x5ECC660", VA = "0x185ECDA60")]
	public HLPPHHFBNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class HGJHBFAFINF : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	private class JLOABPICIGJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE210", Offset = "0x5ECCE10", VA = "0x185ECE210", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE120", Offset = "0x5ECCD20", VA = "0x185ECE120")]
		public JLOABPICIGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12CDF40", Offset = "0x12CCB40", VA = "0x1812CDF40", Slot = "14")]
		public override int GetValue(Data128 PCOJMOHPOND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE110", Offset = "0x5ECCD10", VA = "0x185ECE110", Slot = "15")]
		public override void SetValue(Data128 PCOJMOHPOND, int GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class PDEEAPAFGPB : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5ECFFF0", Offset = "0x5ECEBF0", VA = "0x185ECFFF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFF00", Offset = "0x5ECEB00", VA = "0x185ECFF00")]
		public PDEEAPAFGPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFEE0", Offset = "0x5ECEAE0", VA = "0x185ECFEE0", Slot = "14")]
		public override int GetValue(Data128 PCOJMOHPOND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFEF0", Offset = "0x5ECEAF0", VA = "0x185ECFEF0", Slot = "15")]
		public override void SetValue(Data128 PCOJMOHPOND, int GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	private class MBGEOEGFAMO : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF3B0", Offset = "0x5ECDFB0", VA = "0x185ECF3B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF2C0", Offset = "0x5ECDEC0", VA = "0x185ECF2C0")]
		public MBGEOEGFAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x159FC60", Offset = "0x159E860", VA = "0x18159FC60", Slot = "14")]
		public override int GetValue(Data128 PCOJMOHPOND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF2B0", Offset = "0x5ECDEB0", VA = "0x185ECF2B0", Slot = "15")]
		public override void SetValue(Data128 PCOJMOHPOND, int GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class EDIKKEHAEIG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9820", Offset = "0x5EC8420", VA = "0x185EC9820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9730", Offset = "0x5EC8330", VA = "0x185EC9730")]
		public EDIKKEHAEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9710", Offset = "0x5EC8310", VA = "0x185EC9710", Slot = "14")]
		public override int GetValue(Data128 PCOJMOHPOND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9720", Offset = "0x5EC8320", VA = "0x185EC9720", Slot = "15")]
		public override void SetValue(Data128 PCOJMOHPOND, int GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD5E0", Offset = "0x5ECC1E0", VA = "0x185ECD5E0")]
	public HGJHBFAFINF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class NLLCFPOCOLL : ContainerPropertyBag<PGOOAKHAEDC.HKDJLJBDBMJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	private class LJICAJDPFOJ : Property<PGOOAKHAEDC.HKDJLJBDBMJ, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEF30", Offset = "0x5ECDB30", VA = "0x185ECEF30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEEF0", Offset = "0x5ECDAF0", VA = "0x185ECEEF0")]
		public LJICAJDPFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8E8DB0", Offset = "0x8E79B0", VA = "0x1808E8DB0", Slot = "14")]
		public override Vector3 GetValue(PGOOAKHAEDC.HKDJLJBDBMJ PCOJMOHPOND)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEED0", Offset = "0x5ECDAD0", VA = "0x185ECEED0", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC.HKDJLJBDBMJ PCOJMOHPOND, Vector3 GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class KFOHOBBOIGJ : Property<PGOOAKHAEDC.HKDJLJBDBMJ, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE6C0", Offset = "0x5ECD2C0", VA = "0x185ECE6C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE680", Offset = "0x5ECD280", VA = "0x185ECE680")]
		public KFOHOBBOIGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE660", Offset = "0x5ECD260", VA = "0x185ECE660", Slot = "14")]
		public override List<SerializableGuid> GetValue(PGOOAKHAEDC.HKDJLJBDBMJ PCOJMOHPOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE670", Offset = "0x5ECD270", VA = "0x185ECE670", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC.HKDJLJBDBMJ PCOJMOHPOND, List<SerializableGuid> GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF920", Offset = "0x5ECE520", VA = "0x185ECF920")]
	public NLLCFPOCOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class JPPPOJGPKJJ : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class CCDALJBLIHJ : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9250", Offset = "0x5EC7E50", VA = "0x185EC9250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9210", Offset = "0x5EC7E10", VA = "0x185EC9210")]
		public CCDALJBLIHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5EC91F0", Offset = "0x5EC7DF0", VA = "0x185EC91F0", Slot = "14")]
		public override float GetValue(Vector3 PCOJMOHPOND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9200", Offset = "0x5EC7E00", VA = "0x185EC9200", Slot = "15")]
		public override void SetValue(Vector3 PCOJMOHPOND, float GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	private class BOKFGLGLPEF : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9160", Offset = "0x5EC7D60", VA = "0x185EC9160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9120", Offset = "0x5EC7D20", VA = "0x185EC9120")]
		public BOKFGLGLPEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9100", Offset = "0x5EC7D00", VA = "0x185EC9100", Slot = "14")]
		public override float GetValue(Vector3 PCOJMOHPOND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9110", Offset = "0x5EC7D10", VA = "0x185EC9110", Slot = "15")]
		public override void SetValue(Vector3 PCOJMOHPOND, float GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	private class DGAOIPFGMBM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC93F0", Offset = "0x5EC7FF0", VA = "0x185EC93F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5EC93B0", Offset = "0x5EC7FB0", VA = "0x185EC93B0")]
		public DGAOIPFGMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1985680", Offset = "0x1984280", VA = "0x181985680", Slot = "14")]
		public override float GetValue(Vector3 PCOJMOHPOND)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5EC93A0", Offset = "0x5EC7FA0", VA = "0x185EC93A0", Slot = "15")]
		public override void SetValue(Vector3 PCOJMOHPOND, float GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE240", Offset = "0x5ECCE40", VA = "0x185ECE240")]
	public JPPPOJGPKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class NMCBAJJLADB : ContainerPropertyBag<PGOOAKHAEDC.FELGBNNNPFK>
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class KHKICPMEJGJ : Property<PGOOAKHAEDC.FELGBNNNPFK, PGOOAKHAEDC.HKDJLJBDBMJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE7A0", Offset = "0x5ECD3A0", VA = "0x185ECE7A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE760", Offset = "0x5ECD360", VA = "0x185ECE760")]
		public KHKICPMEJGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE6F0", Offset = "0x5ECD2F0", VA = "0x185ECE6F0", Slot = "14")]
		public override PGOOAKHAEDC.HKDJLJBDBMJ GetValue(PGOOAKHAEDC.FELGBNNNPFK PCOJMOHPOND)
		{
			return default(PGOOAKHAEDC.HKDJLJBDBMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE720", Offset = "0x5ECD320", VA = "0x185ECE720", Slot = "15")]
		public override void SetValue(PGOOAKHAEDC.FELGBNNNPFK PCOJMOHPOND, PGOOAKHAEDC.HKDJLJBDBMJ GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFA80", Offset = "0x5ECE680", VA = "0x185ECFA80")]
	public NMCBAJJLADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class KJJODLJOLOD : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	private class MPMIIPJBHID : Property<RRObjectPrefabV2Data, LGFPBEODEOP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string ODBDFCEODFK
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF890", Offset = "0x5ECE490", VA = "0x185ECF890", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool GNNIBHGIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF850", Offset = "0x5ECE450", VA = "0x185ECF850")]
		public MPMIIPJBHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x12CDF40", Offset = "0x12CCB40", VA = "0x1812CDF40", Slot = "14")]
		public override LGFPBEODEOP GetValue(RRObjectPrefabV2Data PCOJMOHPOND)
		{
			return default(LGFPBEODEOP);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE110", Offset = "0x5ECCD10", VA = "0x185ECE110", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data PCOJMOHPOND, LGFPBEODEOP GCPEEAODAIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE7D0", Offset = "0x5ECD3D0", VA = "0x185ECE7D0")]
	public KJJODLJOLOD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0400", Offset = "0x5ECF000", VA = "0x185ED0400")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
public class CNCAHEHIFIE
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CNCAHEHIFIE()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
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

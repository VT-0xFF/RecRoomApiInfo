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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DAGIHEPBFHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode GCHDPOLENDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FNELLBMCOOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public DAIDGMABGPE EOMIFHBNKJD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly KEBFNKMCAKC<FNELLBMCOOE> MHFKJLABGMI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BBLFOHECPNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct JNCMJIMGHKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DAIDGMABGPE
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
public struct DJMPDJPKFPM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct BEKNPHBHJBK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity EFKEIDIJBGE;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PMPILKMECOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity OBIIIBPBMLD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HNCJAFKNELA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CMIGNGCNIDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity DIPDOFGLHFF;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LNKBKLBMHDC : DJIOGJPHJOM, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FPIBBIDFIDM KGJMPBAPLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FPIBBIDFIDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HNFOIEAKOCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 HMLDCLIHLHH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KIKLJMJEGBJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GDJOAMFKKIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 IKDLKPGINHP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly KEBFNKMCAKC<FDKCAGPLHHM> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FDKCAGPLHHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 IKDLKPGINHP;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly KEBFNKMCAKC<FDKCAGPLHHM> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LELKNLFLLOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 DHLKGGPEHKD;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MHDKDBLBEIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 MHHEBIIMFDM;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LNLNBIAGGLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float OPBLIAMHGHD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly KEBFNKMCAKC<LNLNBIAGGLL> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EOBIIEGEJIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float FELOCIBFPFA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly KEBFNKMCAKC<EOBIIEGEJIN> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GOBDJGDMCGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 DIDJMHLGDCH;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NPNEHFJKAKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public LKCJDGFAJNM CKKKGDFOKIB;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MNLKGBFNMKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public LKCJDGFAJNM GJLDKDPFGON;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[MFABNNCMDKF]
public struct IPNAJMNNPDP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity KCMPKMKBCOO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OJPDNOOCNLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NHAOEMODNMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PKLACLKIDFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct NKAKFJLDAJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints FMPNKBADMFO;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GBPCDEIDBCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float FNLHMFOPCIN;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly KEBFNKMCAKC<GBPCDEIDBCN> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BPABMPEPOFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float KHKHCHJFFEJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct MPNIIBIOIBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct COKLEICCMMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int EOHLJFOADON;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBB96B0", Offset = "0xBB7EB0", VA = "0x180BB96B0")]
	public static COKLEICCMMM FEBAGKLNOCP(int FKKGMPDEPMA)
	{
		return default(COKLEICCMMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GCEMKGJHNFP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody KFJMODPJOOA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8CC00", Offset = "0x5D8B400", VA = "0x185D8CC00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GCEMKGJHNFP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct NDELIBHKMFG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct OBHMBEPGOLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float KDFFCAGNMFJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KEBFNKMCAKC<OBHMBEPGOLI> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MFPOHOLMIKN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public object AAIIKDLLLOM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E300", Offset = "0x5D8CB00", VA = "0x185D8E300", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MFPOHOLMIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JPDPNIHGEAK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public object BEBPJAKPJJB;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D910", Offset = "0x5D8C110", VA = "0x185D8D910", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JPDPNIHGEAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum LKCJDGFAJNM
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum ABDACCGDOPN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BOFNPIGFHNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKELIJOCCBI(DAIDGMABGPE ANBIOJLLMHI, DAIDGMABGPE BMJMPKJOAMG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POACJFGBJCP();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBOEGFAMJOD();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMKNBNPGODE(bool IIBPGCHKBGC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BLINNJBNGEM();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLCCGEOBJNC();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OPGPAICAOKH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public BOFNPIGFHNE IAJPLGNCOLL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F0C0", Offset = "0x5D8D8C0", VA = "0x185D8F0C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OPGPAICAOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DINFBOPJCHP
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly List<(MEFHJGEEAGN nameHash, GBADJBPMIOO stableTypeHash, Type type)> LHIHKIENFIM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly List<(MEFHJGEEAGN nameHash, GBADJBPMIOO stableTypeHash, Type type)> LDCPAOHABNF;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(MEFHJGEEAGN previousNameHash, GBADJBPMIOO previousStableTypeHash, Type currentTypeName)> ANAMCNCJINH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NEEEBDOLANE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, AMBALLNBDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D874C0", Offset = "0x5D85CC0", VA = "0x185D874C0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct CEFKKAMGNJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CDCNELCOJEP(1)]
	public quaternion KCMFIPCJPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[CDCNELCOJEP(2)]
	public float3 ALAOAMBMFBH;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly KEBFNKMCAKC<CEFKKAMGNJB> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38FF440", Offset = "0x38FDC40", VA = "0x1838FF440")]
	public CEFKKAMGNJB(quaternion KCMFIPCJPAM, float3 ALAOAMBMFBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D87B90", Offset = "0x5D86390", VA = "0x185D87B90")]
	public static CEFKKAMGNJB FEBAGKLNOCP(RigidTransform DPGPLOPHPMH)
	{
		return default(CEFKKAMGNJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FIHCAHHLIDM
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[HBEMHKGPDKE]
public struct DEMCMLIOGEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[CDCNELCOJEP(1)]
	public float KJDBOBHCLDP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly KEBFNKMCAKC<DEMCMLIOGEO> MHFKJLABGMI;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[HBEMHKGPDKE]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, AMBALLNBDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[CDCNELCOJEP(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D874D0", Offset = "0x5D85CD0", VA = "0x185D874D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CELHHNGFGFD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, AMBALLNBDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LDGEBBEDFKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct DANOOFAEPGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[CDCNELCOJEP(1)]
	public SerializableGuid AACPINCHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[CDCNELCOJEP(2)]
	public SerializableGuid HGPLGELHGLG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KMJAKLDPLLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity KLOCLKDIBIH;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BEMNNEKFNPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity KLOCLKDIBIH;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[MOPEJKIOMJP("Container", 0)]
[HBEMHKGPDKE]
public struct BGBBDBFDLLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public NDKHHGHCMFD FBIMFNEOECE;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly KEBFNKMCAKC<BGBBDBFDLLI> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[OEMGKINDOBH(0, 127)]
public enum NDKHHGHCMFD
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FMLDPNGGHBE
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum NMEIDDDFAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum EMPNIBCOAHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BFB0", Offset = "0x5D8A7B0", VA = "0x185D8BFB0")]
	public static (NMEIDDDFAGJ, EMPNIBCOAHM) AAFOFNNNBII(this NDKHHGHCMFD FIIIJAPNPGF)
	{
		return default((NMEIDDDFAGJ, EMPNIBCOAHM));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[MOPEJKIOMJP("Container", 0)]
public struct CNJKOAPMJNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public CNINNPBJFPB KBNMHOACJLB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly KEBFNKMCAKC<CNJKOAPMJNK> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[OEMGKINDOBH(0, 2)]
public enum CNINNPBJFPB
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[MOPEJKIOMJP("Container", 0)]
public struct GNAOGINMILN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public KNOJIPBKONK ODJEHGDEAEP;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[Flags]
[OEMGKINDOBH(0, 15943)]
public enum KNOJIPBKONK
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct KHCKOMBAFIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BACJHPLNFCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct MMEPKKCFCEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct CJIALKDAFOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct ECMFEGKKOCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct EKIGCPHDCDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct KCKNGDEOONG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct ODCEFGCIHIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct PADCGPFNLFC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[HBEMHKGPDKE]
[MOPEJKIOMJP("Container", 0)]
public struct JOEMNDMGJBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public float FABLLLKKOKH;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[HBEMHKGPDKE]
[MOPEJKIOMJP("Container", 0)]
public struct JJJFNEHPICI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(1)]
	public FixedString64Bytes HNHMJGCODBA;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct MABNELIJHEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<DMGBFHKMEFD> JABEPOLDBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<Entity> PBAPIFFCMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private JobHandle EKJLKMKCKOI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HLNECFAPNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E150", Offset = "0x5D8C950", VA = "0x185D8E150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E100", Offset = "0x5D8C900", VA = "0x185D8E100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4271870", Offset = "0x4270070", VA = "0x184271870")]
	public MABNELIJHEC(NativeList<DMGBFHKMEFD> JABEPOLDBEF, NativeList<Entity> PBAPIFFCMCF, JobHandle EKJLKMKCKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DF80", Offset = "0x5D8C780", VA = "0x185D8DF80")]
	public (Entity, NativeSlice<Entity>) AFAFOBHKHMJ(int DKLECPOCCOI)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E0A0", Offset = "0x5D8C8A0", VA = "0x185D8E0A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DMGBFHKMEFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity DIPDOFGLHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int GDMKPCJDDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int HPFMIMMLOKB;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface JLFJIKPKDGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBPLOAJGKLD(bool NAFHMPNGMIE);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[HBEMHKGPDKE]
[MOPEJKIOMJP("Container", 0)]
public struct IDPGDBMAALG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public FHPAIIGGDOF CCNCIMBIOKP;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[OEMGKINDOBH(0, 1)]
public enum FHPAIIGGDOF
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[GBCFEFFJPIG(1)]
public struct FBHABIOPBAB : IComparable<FBHABIOPBAB>, IEquatable<FBHABIOPBAB>, AHHAJJLHJMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[KOECINADPMO(1)]
	public uint DFEHOIMNGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[KOECINADPMO(2)]
	public uint DCLIIBELIDG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint FBEEIJICAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D8BAA0", Offset = "0x5D8A2A0", VA = "0x185D8BAA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BDE0", Offset = "0x5D8A5E0", VA = "0x185D8BDE0")]
	public FBHABIOPBAB(int DFEHOIMNGNJ, int ODDEBJJDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BDE0", Offset = "0x5D8A5E0", VA = "0x185D8BDE0")]
	public FBHABIOPBAB(uint DFEHOIMNGNJ, uint ODDEBJJDLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BC20", Offset = "0x5D8A420", VA = "0x185D8BC20")]
	public FBHABIOPBAB KNDOEKILBNN(int GDMKPCJDDGD = 1)
	{
		return default(FBHABIOPBAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BBB0", Offset = "0x5D8A3B0", VA = "0x185D8BBB0")]
	public FBHABIOPBAB IOLPBIFJOID(int GDMKPCJDDGD = 1)
	{
		return default(FBHABIOPBAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BB00", Offset = "0x5D8A300", VA = "0x185D8BB00")]
	public static FBHABIOPBAB IJHGDDBLAKO(FBHABIOPBAB PEEDIPGMMHL, FBHABIOPBAB PEFIBHOJLKB)
	{
		return default(FBHABIOPBAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BB80", Offset = "0x5D8A380", VA = "0x185D8BB80")]
	private static uint IMHLJLGLMFN(uint EOFAJFKEBLN, uint DNOEGKBPKDC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B9D0", Offset = "0x5D8A1D0", VA = "0x185D8B9D0", Slot = "4")]
	public int CompareTo(FBHABIOPBAB IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BA10", Offset = "0x5D8A210", VA = "0x185D8BA10", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BD00", Offset = "0x5D8A500", VA = "0x185D8BD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B9F0", Offset = "0x5D8A1F0", VA = "0x185D8B9F0", Slot = "5")]
	public bool Equals(FBHABIOPBAB IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BAB0", Offset = "0x5D8A2B0", VA = "0x185D8BAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B960", Offset = "0x5D8A160", VA = "0x185D8B960", Slot = "6")]
	public void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BC90", Offset = "0x5D8A490", VA = "0x185D8BC90", Slot = "7")]
	public void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x21832E0", Offset = "0x2181AE0", VA = "0x1821832E0")]
	public static bool BIBGNMIHGGC(FBHABIOPBAB PEEDIPGMMHL, FBHABIOPBAB PEFIBHOJLKB)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[GBCFEFFJPIG(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[KOECINADPMO(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[KOECINADPMO(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[KOECINADPMO(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[KOECINADPMO(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[GBCFEFFJPIG(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, AHHAJJLHJMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[KOECINADPMO(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
		public static SerializableGuid FEBAGKLNOCP(Guid OJPOLEONBAO)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D90420", Offset = "0x5D8EC20", VA = "0x185D90420", Slot = "4")]
		public bool Equals(SerializableGuid IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D90400", Offset = "0x5D8EC00", VA = "0x185D90400", Slot = "5")]
		public int CompareTo(SerializableGuid IFHFGCDLDEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D90340", Offset = "0x5D8EB40", VA = "0x185D90340", Slot = "6")]
		public void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5D90450", Offset = "0x5D8EC50", VA = "0x185D90450", Slot = "7")]
		public void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D904D0", Offset = "0x5D8ECD0", VA = "0x185D904D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
[HBEMHKGPDKE]
public struct HKAOOKBJIOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct IPBEPCOEBJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[CDCNELCOJEP(1)]
	public Entity KMJKCJJHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[CDCNELCOJEP(2)]
	public bool EBDMPFELEKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct IMGHELGILNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[CDCNELCOJEP(1)]
	public EIHFFOLKDOE OOJLAGHIAAD;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[OEMGKINDOBH(0, 4)]
public enum EIHFFOLKDOE
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct FFJGBKNHLEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CDCNELCOJEP(1)]
	public Entity KMJKCJJHEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[CDCNELCOJEP(2)]
	public bool CMGADKMNLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[CDCNELCOJEP(3)]
	public float LIPABBOLIPK;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct MBDIBJKGKFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[CDCNELCOJEP(1)]
	public bool GJMNPFFBJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[CDCNELCOJEP(2)]
	public bool CMGADKMNLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[CDCNELCOJEP(3)]
	public float HCHEOAHOBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[CDCNELCOJEP(4)]
	public float NBPDHCAMINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CDCNELCOJEP(5)]
	public float JEGKJPODFLL;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[HBEMHKGPDKE]
public struct JLDMHKMDHMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[CDCNELCOJEP(1)]
	public bool GJMNPFFBJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[CDCNELCOJEP(2)]
	public bool CMGADKMNLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[CDCNELCOJEP(3)]
	public float LIPABBOLIPK;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, AMBALLNBDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D874C0", Offset = "0x5D85CC0", VA = "0x185D874C0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[HBEMHKGPDKE]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, AMBALLNBDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[CDCNELCOJEP(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, AMBALLNBDNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct CCENDLCIJHN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface AMBALLNBDNE
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Entity KOKGOFCOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct IMFMNFGIJAG<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly bool ODGHFELEPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public uint CLBHMHKOFFD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	private static bool JMEEOPFHHNB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
[HBEMHKGPDKE]
[MOPEJKIOMJP("Light", 0)]
public struct LJFGHFJHAJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public bool PLMDMDMKAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(2)]
	public float HDOHOEHGLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[CDCNELCOJEP(3)]
	[IKBDMIPEDBA(0)]
	public float PIGGPAHNFPO;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[MOPEJKIOMJP("Light", 0)]
public struct FHEOMFCFBHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public float CPAELKALGFF;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.TypeVersion(2)]
public struct KEHHIJFCONH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public uint NOFENGOPCCN;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DA50", Offset = "0x5D8C250", VA = "0x185D8DA50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[HBEMHKGPDKE]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[KOECINADPMO(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct PFDPMNJGABK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public int DMAJKGMCJKP;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct CKFFMKFJMKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public GCHandle OLHKNKIPBDN;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[OEMGKINDOBH(0, 4)]
public enum KEOABDEKGML
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
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct OFDGBECOLFM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct OPKPEJBNAFG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int DMAJKGMCJKP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JCIPIPEDOIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct OBAKCAHNDEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct POEKPNADFNC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.TypeVersion(3)]
[MOPEJKIOMJP("Object", 0)]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
public struct KIOFMNKMPGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[CDCNELCOJEP(2)]
	public CILCGBJKBGK FIABDKMLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[CDCNELCOJEP(3)]
	[IKBDMIPEDBA(0)]
	public HLFHIIFMHNG MPIDHBDACOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[CDCNELCOJEP(5)]
	[IKBDMIPEDBA(0)]
	public BGPHAFDEIFJ NOOKKDFFDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[KOECINADPMO(4)]
	public PLDHCOKKDOL ODJEHGDEAEP;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public static readonly KEBFNKMCAKC<KIOFMNKMPGD> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class DJDDONCMMHO
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B450", Offset = "0x5D89C50", VA = "0x185D8B450")]
	public static void NLGFMFNDGBJ(this PLDHCOKKDOL ODJEHGDEAEP, PPKJDIJDEDE FNGNCNDDAMN, bool FLGOMPMGFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B400", Offset = "0x5D89C00", VA = "0x185D8B400")]
	public static bool BJAPJHOONOK(this PLDHCOKKDOL ODJEHGDEAEP, PPKJDIJDEDE FNGNCNDDAMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B420", Offset = "0x5D89C20", VA = "0x185D8B420")]
	public static PLDHCOKKDOL ENKLPMBLEGK(this PPKJDIJDEDE FNGNCNDDAMN)
	{
		return default(PLDHCOKKDOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B430", Offset = "0x5D89C30", VA = "0x185D8B430")]
	public static void NLGFMFNDGBJ(this HLFHIIFMHNG ODJEHGDEAEP, HLFHIIFMHNG HBIOBOOAGLC, bool FLGOMPMGFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CB2A60", Offset = "0x5CB1260", VA = "0x185CB2A60")]
	public static bool BJAPJHOONOK(this HLFHIIFMHNG ODJEHGDEAEP, HLFHIIFMHNG FNGNCNDDAMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public enum PPKJDIJDEDE
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
[Cpp2IlInjected.Token(Token = "0x2000071")]
[OEMGKINDOBH(0, 16383)]
[Flags]
public enum PLDHCOKKDOL
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
[Cpp2IlInjected.Token(Token = "0x2000072")]
[OEMGKINDOBH(0, 3)]
[Flags]
public enum HLFHIIFMHNG
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
[Cpp2IlInjected.Token(Token = "0x2000073")]
[KCLEICGKFIF]
[OEMGKINDOBH(0, 4)]
public enum BGPHAFDEIFJ
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
[Cpp2IlInjected.Token(Token = "0x2000074")]
public class KCLEICGKFIF : LFPEGEGCACF
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D980", Offset = "0x5D8C180", VA = "0x185D8D980", Slot = "7")]
	public override string OIDLIBPKLAB(string OKPFOPOABKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public KCLEICGKFIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[GBCFEFFJPIG(1)]
public struct CILCGBJKBGK : AHHAJJLHJMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[KOECINADPMO(1)]
	public bool PLMDMDMKAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[KOECINADPMO(2)]
	public float3 LPJLPEBHHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[KOECINADPMO(3)]
	public float3 CGFHOPKJHOD;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly KEBFNKMCAKC<CILCGBJKBGK> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5D87E90", Offset = "0x5D86690", VA = "0x185D87E90", Slot = "5")]
	public void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D87E40", Offset = "0x5D86640", VA = "0x185D87E40", Slot = "4")]
	public void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct NEKGBPHIGFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct POCMEIIBNNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct FBCMAIHHMLB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct DKDKACEGBAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public FixedString32Bytes HNHMJGCODBA;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[MFABNNCMDKF]
public struct LFLFCMHEHHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Entity AGEHAEDLOFL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static LFLFCMHEHHB FEBAGKLNOCP(Entity FKKGMPDEPMA)
	{
		return default(LFLFCMHEHHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct IOLPKCCBJJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[CDCNELCOJEP(1)]
	public Entity EANAEGJOBFB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static IOLPKCCBJJP FEBAGKLNOCP(Entity KCMPKMKBCOO)
	{
		return default(IOLPKCCBJJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal struct KIFGGDMCCIB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Entity KCMPKMKBCOO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static KIFGGDMCCIB FEBAGKLNOCP(Entity KCMPKMKBCOO)
	{
		return default(KIFGGDMCCIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct DPCCNEKCNGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Entity BBFAGBBMPNK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static DPCCNEKCNGB FEBAGKLNOCP(Entity KCMPKMKBCOO)
	{
		return default(DPCCNEKCNGB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal struct GCLAPCACMOI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[OEMGKINDOBH(0, 2)]
public enum BIHNEDFGEBE
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
[Cpp2IlInjected.Token(Token = "0x2000080")]
[HBEMHKGPDKE]
[MOPEJKIOMJP("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct HFIACICKMAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public float CAPADMGDPJD;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static readonly KEBFNKMCAKC<HFIACICKMAP> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct IEJIMBDOILN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[CDCNELCOJEP(1)]
	public IHOKJCEFOEN JNLDJKGHMNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[OEMGKINDOBH(-1, 38)]
public enum IHOKJCEFOEN
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
[HBEMHKGPDKE]
public struct OHFPPOCJLKE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[OEMGKINDOBH(0, 7)]
	[Flags]
	public enum PEBOPDIJPGP
	{
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[CDCNELCOJEP(1)]
	public PEBOPDIJPGP ODJEHGDEAEP;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static readonly KEBFNKMCAKC<OHFPPOCJLKE> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool GNMEGBKLFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8ED70", Offset = "0x5D8D570", VA = "0x185D8ED70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PNDPGHCGEHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8ED80", Offset = "0x5D8D580", VA = "0x185D8ED80")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct NMPMDOOIBIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[CDCNELCOJEP(1)]
	public BIHNEDFGEBE JNLDJKGHMNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[GBCFEFFJPIG(1)]
public struct MFLINDAOODE : AHHAJJLHJMC
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[OEMGKINDOBH(0, 7)]
	[Flags]
	public enum POFODJFLJFC
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[KOECINADPMO(1)]
	public float DGDCOJHPPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[KOECINADPMO(2)]
	public int OPDPCOMGHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[KOECINADPMO(3)]
	public POFODJFLJFC ODJEHGDEAEP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool FLPNKJIHNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E240", Offset = "0x5D8CA40", VA = "0x185D8E240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E220", Offset = "0x5D8CA20", VA = "0x185D8E220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OLHAHJKIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E260", Offset = "0x5D8CA60", VA = "0x185D8E260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E270", Offset = "0x5D8CA70", VA = "0x185D8E270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BPGOHFGPBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E250", Offset = "0x5D8CA50", VA = "0x185D8E250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E290", Offset = "0x5D8CA90", VA = "0x185D8E290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E2B0", Offset = "0x5D8CAB0", VA = "0x185D8E2B0", Slot = "5")]
	public void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E1C0", Offset = "0x5D8C9C0", VA = "0x185D8E1C0", Slot = "4")]
	public void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[MFABNNCMDKF]
internal struct EOFKHAOHLOD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Entity BDHANMOFOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public int LFEFGCGCIAG;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[HBEMHKGPDKE]
public struct OLPFDHBGHHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[CDCNELCOJEP(1)]
	public FBHABIOPBAB BJCDBDOLBBO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static OLPFDHBGHHP FEBAGKLNOCP(FBHABIOPBAB FKKGMPDEPMA)
	{
		return default(OLPFDHBGHHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct AABJHPEEABP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[CDCNELCOJEP(1)]
	public Entity JBJEFMHIIMG;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal struct PEOJNKFONGL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Entity JBJEFMHIIMG;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[HBEMHKGPDKE]
public struct DFMOOBPAIKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[CDCNELCOJEP(1)]
	public float3 ALAOAMBMFBH;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly KEBFNKMCAKC<DFMOOBPAIKI> MHFKJLABGMI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A960", Offset = "0x1F09160", VA = "0x181F0A960")]
	public static DFMOOBPAIKI FEBAGKLNOCP(float3 FKKGMPDEPMA)
	{
		return default(DFMOOBPAIKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
[HBEMHKGPDKE]
public struct IIALCOKOIDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[CDCNELCOJEP(1)]
	public quaternion KCMFIPCJPAM;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly KEBFNKMCAKC<IIALCOKOIDL> MHFKJLABGMI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
	public static IIALCOKOIDL FEBAGKLNOCP(quaternion FKKGMPDEPMA)
	{
		return default(IIALCOKOIDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct GLIEJDBHEBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[CDCNELCOJEP(1)]
	public float3 HFFOOPIIHBH;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static readonly KEBFNKMCAKC<GLIEJDBHEBG> MHFKJLABGMI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1F0A960", Offset = "0x1F09160", VA = "0x181F0A960")]
	public static GLIEJDBHEBG FEBAGKLNOCP(float3 FKKGMPDEPMA)
	{
		return default(GLIEJDBHEBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
[HBEMHKGPDKE]
public struct CIADMAIBJCK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[CDCNELCOJEP(1)]
	public MFLINDAOODE GCMLNHCMFKE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct LCNNGFMLDLK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct ADFAAGPOMMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public uint CLBHMHKOFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int GLBDOJGNFGK;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x979D20", Offset = "0x978520", VA = "0x180979D20")]
	public ADFAAGPOMMJ(uint BCGMLAIEAGD, int DCHJMJJHAJD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct INGLJCGKDOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct CFBEBHDJIHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct EPICMHKEBGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct CLKEMIAJMNG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct HIAFKFOPJIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct HMLMFIDCLLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct KNABGIIEPON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MNJNHNEKGLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal struct JHLBBBMOKFD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct JPEDDLELHEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct EMKCNBLNGHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct NDALEFHGHAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal struct JJGNNLIBDAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct HIIIPKKGNPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct IIFJJKODJDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct ADALBOCEMMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct CIOLLJLEMAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct ONIAJNBIOKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal struct PGNBHDCNJNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct BDOIBELPBMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct OLMOCNNBCCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal struct KHFBOOCMKIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal struct KLGBBPJDEKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
[HBEMHKGPDKE]
public struct FLMMJMPOKOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[KOECINADPMO(1)]
	public HJHHOAIIMCD IFOEKNINMPE;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static readonly KEBFNKMCAKC<FLMMJMPOKOE> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public enum HJHHOAIIMCD : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct ENMKBBNLMMB : IComponentData, IComparable<ENMKBBNLMMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public int JPAKAOANAJB;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1629C80", Offset = "0x1628480", VA = "0x181629C80", Slot = "4")]
	public int CompareTo(ENMKBBNLMMB IFHFGCDLDEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct AKKHNLKGCGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[CDCNELCOJEP(2)]
	public bool ENACAPICPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[CDCNELCOJEP(3)]
	public bool HBIFGJDIHDE;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly KEBFNKMCAKC<AKKHNLKGCGO> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct PAOFLPLOLDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[CDCNELCOJEP(1)]
	public bool GEDAGIKPNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[CDCNELCOJEP(2)]
	public byte IDMJLHICNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[CDCNELCOJEP(3)]
	public short EFHJMLNCBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[CDCNELCOJEP(4)]
	public ushort KDOAIJKJHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[CDCNELCOJEP(5)]
	public int MEAMAHCBFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[CDCNELCOJEP(6)]
	public uint ICEOJJKNGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[CDCNELCOJEP(7)]
	public long EJALHFEDPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[CDCNELCOJEP(8)]
	public ulong OPLJPEBEAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[CDCNELCOJEP(9)]
	public float JFDOCHPALLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[CDCNELCOJEP(10)]
	public double KCOGIHJGHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[CDCNELCOJEP(11)]
	public EPEPNMNHOCD HNHIDEJGKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[CDCNELCOJEP(12)]
	public BOFGDFLHMIC FFIHGNKIGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[CDCNELCOJEP(13)]
	public HHLOEGAAAAN OECIEODHBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[CDCNELCOJEP(14)]
	public NJNNPBHGECE FDPEFMMFNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[CDCNELCOJEP(15)]
	public IKKNMMCAINN LGMKJCOMPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[CDCNELCOJEP(16)]
	public GCODGLGFDNF ENHDPMEJGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[CDCNELCOJEP(17)]
	public OEGEMMLAOKP CDNAMDKPABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[CDCNELCOJEP(18)]
	public JFGNEEOHFPO HOPMPINLKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[CDCNELCOJEP(20)]
	public Quaternion OFGFGNGKJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[CDCNELCOJEP(22)]
	public Vector3 EJNJHDAOOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[CDCNELCOJEP(23)]
	public Vector4 ODPGAEKAECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[CDCNELCOJEP(40)]
	public Entity DACKAFMBLEG;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum EPEPNMNHOCD : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum BOFGDFLHMIC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum HHLOEGAAAAN : short
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum NJNNPBHGECE : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum IKKNMMCAINN
{
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum GCODGLGFDNF : uint
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum OEGEMMLAOKP : long
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum JFGNEEOHFPO : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[HBEMHKGPDKE]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[HBEMHKGPDKE]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class JHKCLAMJEPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int KDMODAMJKPD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public int CLIHIMOBEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public GameObject GOGHJGCCDJI;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JHKCLAMJEPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class EKGGGKBPNKF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public struct BOBKGOBHAAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector3 CEFILENFKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public List<SerializableGuid> BAAOAKCOGFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class BIHPLLLLNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public BOBKGOBHAAE NJBNEFOAGBE;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BIHPLLLLNKP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public SerializableGuid PFKCGJDPFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public List<int> OGCKIPNMNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public List<BOBKGOBHAAE> EIGNDJFLGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public List<BIHPLLLLNKP> GDCLHLCLFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public GameObject GOGHJGCCDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Light MNFHOJPLIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Collider ICCDLLEGOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public string IGCNDLAEOGK;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EKGGGKBPNKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct CLPIGHNAAHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[CDCNELCOJEP(1)]
	public float3 ECBCFODGMBH;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public static readonly KEBFNKMCAKC<CLPIGHNAAHL> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct OAEOJOGLFPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[CDCNELCOJEP(1)]
	public quaternion KCMFIPCJPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[CDCNELCOJEP(2)]
	public float3 ALAOAMBMFBH;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public static readonly KEBFNKMCAKC<OAEOJOGLFPE> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x38FF440", Offset = "0x38FDC40", VA = "0x1838FF440")]
	public OAEOJOGLFPE(quaternion KCMFIPCJPAM, float3 ALAOAMBMFBH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D87B90", Offset = "0x5D86390", VA = "0x185D87B90")]
	public static RigidTransform FEBAGKLNOCP(OAEOJOGLFPE EAEMGOJMJDJ)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D87B90", Offset = "0x5D86390", VA = "0x185D87B90")]
	public static OAEOJOGLFPE FEBAGKLNOCP(RigidTransform DPGPLOPHPMH)
	{
		return default(OAEOJOGLFPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public static class NKHNNPALECJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct BDJLHGAHJBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public float4x4 KAOEHHLLHMN;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public static readonly KEBFNKMCAKC<BDJLHGAHJBG> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public struct BCAHBAGLDKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public float4x4 NNJGENDBEIL;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly KEBFNKMCAKC<BCAHBAGLDKB> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
[HBEMHKGPDKE]
public struct JLCBOGGNFCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[CDCNELCOJEP(1)]
	public float KJDBOBHCLDP;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public static readonly KEBFNKMCAKC<JLCBOGGNFCI> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct MLHMPIHECII : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int MMDENFNFPNL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LFEFGCGCIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E5A0", Offset = "0x5D8CDA0", VA = "0x185D8E5A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E590", Offset = "0x5D8CD90", VA = "0x185D8E590")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[HBEMHKGPDKE]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct MPDLMEFKAMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[CDCNELCOJEP(1)]
	public CJBMKJKLABL KDDABLKNHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[CDCNELCOJEP(2)]
	public KKHIJKIPHFF BAHCNLAJDPJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[OEMGKINDOBH(0, 1)]
[Flags]
public enum CJBMKJKLABL
{
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[OEMGKINDOBH(-2, 2)]
public enum KKHIJKIPHFF
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct DFNEPJFFJAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float3 AKFPELJFPKL;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly KEBFNKMCAKC<DFNEPJFFJAA> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public struct HDPLCCLBLHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float3 MCLBBPPAHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public quaternion OHMBDAJNEIJ;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static readonly KEBFNKMCAKC<HDPLCCLBLHA> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D000", Offset = "0x5D8B800", VA = "0x185D8D000")]
	public float3 AKLEALAIJPD(float3 ELJFMFLOMJI)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public static class FPALMBBLHCK
{
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct MILHEFEKDGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float JBDNONPCDAA;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly KEBFNKMCAKC<MILHEFEKDGC> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[OEMGKINDOBH(1000, 8000)]
public enum ILMCDCGEOPC
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	UNUSED = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public static class JILLBPJLECN
{
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal enum ODAKKGNNOGC
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	UNUSED = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class MGCNEKGJNAH
{
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[OEMGKINDOBH(0, 9)]
public enum ELNNHIPONMC
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	UNUSED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public static class AFOLHFLHPFM
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D87320", Offset = "0x5D85B20", VA = "0x185D87320")]
	public static bool BHKDLCNJIAK(this ELNNHIPONMC MMOMICKMHHO)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[HBEMHKGPDKE]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public ILMCDCGEOPC prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class BOGODPDKPNI
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D87930", Offset = "0x5D86130", VA = "0x185D87930")]
	public static bool LEIAAKLMFKE(this ILMCDCGEOPC GFGNPBCFEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D87890", Offset = "0x5D86090", VA = "0x185D87890")]
	public static string FPDJOFILLOG(this ILMCDCGEOPC GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D87910", Offset = "0x5D86110", VA = "0x185D87910")]
	public static ELNNHIPONMC IHGKOMFMEME(this ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(ELNNHIPONMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D87900", Offset = "0x5D86100", VA = "0x185D87900")]
	internal static ODAKKGNNOGC HOFFOCJGCIH(this ELNNHIPONMC MMOMICKMHHO)
	{
		return default(ODAKKGNNOGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D878E0", Offset = "0x5D860E0", VA = "0x185D878E0")]
	internal static ODAKKGNNOGC HOFFOCJGCIH(this ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(ODAKKGNNOGC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class GBIBIACPBHG
{
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly Dictionary<ILMCDCGEOPC, string> BLGEAGENDOI;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C320", Offset = "0x5D8AB20", VA = "0x185D8C320")]
	public static string DCNIHCOMEFP(this ILMCDCGEOPC GFGNPBCFEMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[OEMGKINDOBH(int.MinValue, int.MaxValue)]
public enum NHFOOLDCGFB
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[OEMGKINDOBH(-1, 31)]
public enum MILIFHCIBBK
{
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[HBEMHKGPDKE]
[MOPEJKIOMJP("Visual", 0)]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
public struct IKILAGMPOPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	[CDCNELCOJEP(1)]
	[IKBDMIPEDBA(0)]
	public NHFOOLDCGFB MOJKBHCPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(2)]
	public MILIFHCIBBK JGLFCCBLACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	[CDCNELCOJEP(3)]
	[IKBDMIPEDBA(0)]
	public float IMLDEPNDAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(4)]
	public Vector3 OLEHLGAMMBE;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[IJEGCABFMGF(2613756846563002039uL, 6372660366488563574uL)]
[MOPEJKIOMJP("Container", 0)]
[DPGJMFCMLOK]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct NACJNBIICPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(1)]
	public FHBPJCHFHPL GNJOLFDHLFM;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[OEMGKINDOBH(0, 15)]
[Flags]
public enum FHBPJCHFHPL
{
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[DPGJMFCMLOK]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[IJEGCABFMGF(9804513251708000208uL, 10903582988135044631uL)]
public struct CCOAFMNIHKD : IComponentData, IEquatable<CCOAFMNIHKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	[CDCNELCOJEP(1)]
	public FixedString64Bytes HNHMJGCODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	[CDCNELCOJEP(2)]
	public CNINNPBJFPB KBNMHOACJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[CDCNELCOJEP(3)]
	public FHBPJCHFHPL GNJOLFDHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[CDCNELCOJEP(4)]
	public FHPAIIGGDOF CCNCIMBIOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	[CDCNELCOJEP(5)]
	public KNOJIPBKONK ODJEHGDEAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	[CDCNELCOJEP(6)]
	public float FABLLLKKOKH;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D87AB0", Offset = "0x5D862B0", VA = "0x185D87AB0", Slot = "4")]
	public bool Equals(CCOAFMNIHKD IFHFGCDLDEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[DPGJMFCMLOK]
[IJEGCABFMGF(1213445203937950283uL, 119653618660684511uL)]
public struct NHBJEHAHCJB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[GBCFEFFJPIG(1)]
	public struct PJNLKOBDGKE : AHHAJJLHJMC, IEquatable<PJNLKOBDGKE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		[KOECINADPMO(1)]
		public int NENKFFLNHCE;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F420", Offset = "0x5D8DC20", VA = "0x185D8F420", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F3A0", Offset = "0x5D8DBA0", VA = "0x185D8F3A0", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1620720", Offset = "0x161EF20", VA = "0x181620720", Slot = "6")]
		public bool Equals(PJNLKOBDGKE IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1629D10", Offset = "0x1628510", VA = "0x181629D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F480", Offset = "0x5D8DC80", VA = "0x185D8F480", Slot = "5")]
		public void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F390", Offset = "0x5D8DB90", VA = "0x185D8F390", Slot = "4")]
		public void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	[CDCNELCOJEP(1)]
	public PJNLKOBDGKE HBFPKFKCJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public GCHandle IALEADLNNLH;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[IJEGCABFMGF(218523523639012570uL, 15191719635551116065uL)]
[DPGJMFCMLOK]
public struct LOHMDFEBEBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private uint MFAKEJCKICA;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[DPGJMFCMLOK]
[IJEGCABFMGF(9898405628982320166uL, 2023375009558162791uL)]
public struct GFCMPHJECKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[CDCNELCOJEP(1)]
	public PLDHCOKKDOL ODJEHGDEAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[CDCNELCOJEP(2)]
	public CILCGBJKBGK FIABDKMLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(3)]
	public bool GBOHGBCKGHL;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly KEBFNKMCAKC<GFCMPHJECKE> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[IJEGCABFMGF(9807788745867066359uL, 15168486114979071194uL)]
[DPGJMFCMLOK]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct NKBPNEBHCEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[CDCNELCOJEP(1)]
	public PLDHCOKKDOL ODJEHGDEAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[CDCNELCOJEP(2)]
	public CILCGBJKBGK FIABDKMLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(3)]
	public bool GBOHGBCKGHL;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly KEBFNKMCAKC<NKBPNEBHCEI> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[IJEGCABFMGF(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[DPGJMFCMLOK]
public struct AAKHHKEJOEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[KOECINADPMO(1)]
	public PLDHCOKKDOL ODJEHGDEAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[CDCNELCOJEP(2)]
	public CILCGBJKBGK FIABDKMLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[IKBDMIPEDBA(0)]
	[CDCNELCOJEP(3)]
	public HLFHIIFMHNG MPIDHBDACOL;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly KEBFNKMCAKC<AAKHHKEJOEL> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[IJEGCABFMGF(12226092714547765037uL, 15970362445488810630uL)]
[DPGJMFCMLOK]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct HPDJAAGOJNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[CDCNELCOJEP(2)]
	public CILCGBJKBGK FIABDKMLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[CDCNELCOJEP(3)]
	[IKBDMIPEDBA(0)]
	public HLFHIIFMHNG MPIDHBDACOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[KOECINADPMO(4)]
	public PLDHCOKKDOL ODJEHGDEAEP;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly KEBFNKMCAKC<HPDJAAGOJNI> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
[DPGJMFCMLOK]
[IJEGCABFMGF(3318727941304405759uL, 6047901070934821887uL)]
public struct GGIDAABBPCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public int FJANKJHPEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CDCNELCOJEP(2)]
	public bool ENACAPICPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[CDCNELCOJEP(3)]
	public bool HBIFGJDIHDE;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly KEBFNKMCAKC<GGIDAABBPCO> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[IJEGCABFMGF(5861057081882613294uL, 13746475565109640919uL)]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[DPGJMFCMLOK]
public struct LCJIBLIBCJC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[OEMGKINDOBH(0, 1)]
	public enum GMMADDPHMGE
	{
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		Custom = 1,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		MAX = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[CDCNELCOJEP(1)]
	public GMMADDPHMGE GHHLJIMOCFD;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[DPGJMFCMLOK]
[IJEGCABFMGF(14327281633525910712uL, 2559857777606771911uL)]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
public struct FNMKCECIFBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[CDCNELCOJEP(1)]
	public ILMCDCGEOPC CCAOKKILBOM;
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[DPGJMFCMLOK]
[IJEGCABFMGF(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct EEMKJLIKBGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[CDCNELCOJEP(1)]
	public ILMCDCGEOPC CCAOKKILBOM;
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[DPGJMFCMLOK]
[IJEGCABFMGF(1029043735688538310uL, 14256247939851101839uL)]
public struct JCLNFGHKBJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public ELNNHIPONMC MMOMICKMHHO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[DPGJMFCMLOK]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[IJEGCABFMGF(17667479821163689808uL, 11946378475791123970uL)]
public struct HEOFBMBFCOL : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DPPANEPAGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D904E0", Offset = "0x5D8ECE0", VA = "0x185D904E0", Slot = "4")]
		public sealed override void MCAEHMIINDF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class LHMNPGEGBBH : ContainerPropertyBag<GCEMKGJHNFP>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class BJEMHOEOKKD : Property<GCEMKGJHNFP, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5D87780", Offset = "0x5D85F80", VA = "0x185D87780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D87740", Offset = "0x5D85F40", VA = "0x185D87740")]
		public BJEMHOEOKKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D876F0", Offset = "0x5D85EF0", VA = "0x185D876F0", Slot = "14")]
		public override Rigidbody GetValue(GCEMKGJHNFP OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D87710", Offset = "0x5D85F10", VA = "0x185D87710", Slot = "15")]
		public override void SetValue(GCEMKGJHNFP OKPDFALIJHE, Rigidbody FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DE40", Offset = "0x5D8C640", VA = "0x185D8DE40")]
	public LHMNPGEGBBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class PPCDIFABFIA : ContainerPropertyBag<MFPOHOLMIKN>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class PHEJIKKFNFG : Property<MFPOHOLMIKN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F1E0", Offset = "0x5D8D9E0", VA = "0x185D8F1E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F1A0", Offset = "0x5D8D9A0", VA = "0x185D8F1A0")]
		public PHEJIKKFNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D876F0", Offset = "0x5D85EF0", VA = "0x185D876F0", Slot = "14")]
		public override object GetValue(MFPOHOLMIKN OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D87710", Offset = "0x5D85F10", VA = "0x185D87710", Slot = "15")]
		public override void SetValue(MFPOHOLMIKN OKPDFALIJHE, object FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D8F530", Offset = "0x5D8DD30", VA = "0x185D8F530")]
	public PPCDIFABFIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
internal class JBLPGHKLGID : ContainerPropertyBag<JPDPNIHGEAK>
{
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class EGHJHDBENMN : Property<JPDPNIHGEAK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B840", Offset = "0x5D8A040", VA = "0x185D8B840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B800", Offset = "0x5D8A000", VA = "0x185D8B800")]
		public EGHJHDBENMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D876F0", Offset = "0x5D85EF0", VA = "0x185D876F0", Slot = "14")]
		public override object GetValue(JPDPNIHGEAK OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D87710", Offset = "0x5D85F10", VA = "0x185D87710", Slot = "15")]
		public override void SetValue(JPDPNIHGEAK OKPDFALIJHE, object FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D750", Offset = "0x5D8BF50", VA = "0x185D8D750")]
	public JBLPGHKLGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class MGCKPCEFPPE : ContainerPropertyBag<OPGPAICAOKH>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class PGHMLENMOFN : Property<OPGPAICAOKH, BOFNPIGFHNE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F170", Offset = "0x5D8D970", VA = "0x185D8F170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F130", Offset = "0x5D8D930", VA = "0x185D8F130")]
		public PGHMLENMOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D876F0", Offset = "0x5D85EF0", VA = "0x185D876F0", Slot = "14")]
		public override BOFNPIGFHNE GetValue(OPGPAICAOKH OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D87710", Offset = "0x5D85F10", VA = "0x185D87710", Slot = "15")]
		public override void SetValue(OPGPAICAOKH OKPDFALIJHE, BOFNPIGFHNE FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E370", Offset = "0x5D8CB70", VA = "0x185D8E370")]
	public MGCKPCEFPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class LCCODKGMDON : ContainerPropertyBag<JHKCLAMJEPC>
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class HPGHDKGNMFA : Property<JHKCLAMJEPC, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D6A0", Offset = "0x5D8BEA0", VA = "0x185D8D6A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D660", Offset = "0x5D8BE60", VA = "0x185D8D660")]
		public HPGHDKGNMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D620", Offset = "0x5D8BE20", VA = "0x185D8D620", Slot = "14")]
		public override int GetValue(JHKCLAMJEPC OKPDFALIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D640", Offset = "0x5D8BE40", VA = "0x185D8D640", Slot = "15")]
		public override void SetValue(JHKCLAMJEPC OKPDFALIJHE, int FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class NDKHJJDNBLM : Property<JHKCLAMJEPC, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5D8E630", Offset = "0x5D8CE30", VA = "0x185D8E630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E5F0", Offset = "0x5D8CDF0", VA = "0x185D8E5F0")]
		public NDKHJJDNBLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E5B0", Offset = "0x5D8CDB0", VA = "0x185D8E5B0", Slot = "14")]
		public override int GetValue(JHKCLAMJEPC OKPDFALIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E5D0", Offset = "0x5D8CDD0", VA = "0x185D8E5D0", Slot = "15")]
		public override void SetValue(JHKCLAMJEPC OKPDFALIJHE, int FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class HEMGOOLEGBC : Property<JHKCLAMJEPC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D380", Offset = "0x5D8BB80", VA = "0x185D8D380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D340", Offset = "0x5D8BB40", VA = "0x185D8D340")]
		public HEMGOOLEGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D2F0", Offset = "0x5D8BAF0", VA = "0x185D8D2F0", Slot = "14")]
		public override GameObject GetValue(JHKCLAMJEPC OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D310", Offset = "0x5D8BB10", VA = "0x185D8D310", Slot = "15")]
		public override void SetValue(JHKCLAMJEPC OKPDFALIJHE, GameObject FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DCA0", Offset = "0x5D8C4A0", VA = "0x185D8DCA0")]
	public LCCODKGMDON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal class ADHABKIPPCK : ContainerPropertyBag<EKGGGKBPNKF>
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class KPOHECNFLKM : Property<EKGGGKBPNKF, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5D8DC70", Offset = "0x5D8C470", VA = "0x185D8DC70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DC30", Offset = "0x5D8C430", VA = "0x185D8DC30")]
		public KPOHECNFLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DBE0", Offset = "0x5D8C3E0", VA = "0x185D8DBE0", Slot = "14")]
		public override SerializableGuid GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D8DC10", Offset = "0x5D8C410", VA = "0x185D8DC10", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, SerializableGuid FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class EFFFBBAKHDC : Property<EKGGGKBPNKF, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B7D0", Offset = "0x5D89FD0", VA = "0x185D8B7D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B790", Offset = "0x5D89F90", VA = "0x185D8B790")]
		public EFFFBBAKHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B740", Offset = "0x5D89F40", VA = "0x185D8B740", Slot = "14")]
		public override List<int> GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B760", Offset = "0x5D89F60", VA = "0x185D8B760", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, List<int> FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class PJJEMKMHLMG : Property<EKGGGKBPNKF, List<EKGGGKBPNKF.BOBKGOBHAAE>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F360", Offset = "0x5D8DB60", VA = "0x185D8F360", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F320", Offset = "0x5D8DB20", VA = "0x185D8F320")]
		public PJJEMKMHLMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F2D0", Offset = "0x5D8DAD0", VA = "0x185D8F2D0", Slot = "14")]
		public override List<EKGGGKBPNKF.BOBKGOBHAAE> GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F2F0", Offset = "0x5D8DAF0", VA = "0x185D8F2F0", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, List<EKGGGKBPNKF.BOBKGOBHAAE> FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class DCGGOILPLGN : Property<EKGGGKBPNKF, List<EKGGGKBPNKF.BIHPLLLLNKP>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5D88100", Offset = "0x5D86900", VA = "0x185D88100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D880C0", Offset = "0x5D868C0", VA = "0x185D880C0")]
		public DCGGOILPLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D88070", Offset = "0x5D86870", VA = "0x185D88070", Slot = "14")]
		public override List<EKGGGKBPNKF.BIHPLLLLNKP> GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D88090", Offset = "0x5D86890", VA = "0x185D88090", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, List<EKGGGKBPNKF.BIHPLLLLNKP> FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class PIBCBJCKBND : Property<EKGGGKBPNKF, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F2A0", Offset = "0x5D8DAA0", VA = "0x185D8F2A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F260", Offset = "0x5D8DA60", VA = "0x185D8F260")]
		public PIBCBJCKBND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F210", Offset = "0x5D8DA10", VA = "0x185D8F210", Slot = "14")]
		public override GameObject GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F230", Offset = "0x5D8DA30", VA = "0x185D8F230", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, GameObject FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class OPDHFOFFPAA : Property<EKGGGKBPNKF, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F090", Offset = "0x5D8D890", VA = "0x185D8F090", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F050", Offset = "0x5D8D850", VA = "0x185D8F050")]
		public OPDHFOFFPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F000", Offset = "0x5D8D800", VA = "0x185D8F000", Slot = "14")]
		public override Light GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F020", Offset = "0x5D8D820", VA = "0x185D8F020", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, Light FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class CICFDKOJADP : Property<EKGGGKBPNKF, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5D87E10", Offset = "0x5D86610", VA = "0x185D87E10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D87DD0", Offset = "0x5D865D0", VA = "0x185D87DD0")]
		public CICFDKOJADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D87D80", Offset = "0x5D86580", VA = "0x185D87D80", Slot = "14")]
		public override Collider GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D87DA0", Offset = "0x5D865A0", VA = "0x185D87DA0", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, Collider FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class CGAAMAIFCCJ : Property<EKGGGKBPNKF, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5D87CC0", Offset = "0x5D864C0", VA = "0x185D87CC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D87C80", Offset = "0x5D86480", VA = "0x185D87C80")]
		public CGAAMAIFCCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D87C30", Offset = "0x5D86430", VA = "0x185D87C30", Slot = "14")]
		public override string GetValue(EKGGGKBPNKF OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D87C50", Offset = "0x5D86450", VA = "0x185D87C50", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF OKPDFALIJHE, string FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D86F00", Offset = "0x5D85700", VA = "0x185D86F00")]
	public ADHABKIPPCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class ECIEGNMHMBB : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class HGHGGAPOMFJ : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D510", Offset = "0x5D8BD10", VA = "0x185D8D510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D420", Offset = "0x5D8BC20", VA = "0x185D8D420")]
		public HGHGGAPOMFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD6A330", Offset = "0xD68B30", VA = "0x180D6A330", Slot = "14")]
		public override Data128 GetValue(SerializableGuid OKPDFALIJHE)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D410", Offset = "0x5D8BC10", VA = "0x185D8D410", Slot = "15")]
		public override void SetValue(SerializableGuid OKPDFALIJHE, Data128 FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D8B5C0", Offset = "0x5D89DC0", VA = "0x185D8B5C0")]
	public ECIEGNMHMBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class OEENPKAIPGK : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class DIMDIHLMDPI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5D883C0", Offset = "0x5D86BC0", VA = "0x185D883C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D882D0", Offset = "0x5D86AD0", VA = "0x185D882D0")]
		public DIMDIHLMDPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0", Slot = "14")]
		public override int GetValue(Data128 OKPDFALIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D882C0", Offset = "0x5D86AC0", VA = "0x185D882C0", Slot = "15")]
		public override void SetValue(Data128 OKPDFALIJHE, int FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class EAFJGKFIIEJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B590", Offset = "0x5D89D90", VA = "0x185D8B590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B4A0", Offset = "0x5D89CA0", VA = "0x185D8B4A0")]
		public EAFJGKFIIEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B480", Offset = "0x5D89C80", VA = "0x185D8B480", Slot = "14")]
		public override int GetValue(Data128 OKPDFALIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B490", Offset = "0x5D89C90", VA = "0x185D8B490", Slot = "15")]
		public override void SetValue(Data128 OKPDFALIJHE, int FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class AKCCJINFIIK : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5D87430", Offset = "0x5D85C30", VA = "0x185D87430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D87340", Offset = "0x5D85B40", VA = "0x185D87340")]
		public AKCCJINFIIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x14AF570", Offset = "0x14ADD70", VA = "0x1814AF570", Slot = "14")]
		public override int GetValue(Data128 OKPDFALIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D87330", Offset = "0x5D85B30", VA = "0x185D87330", Slot = "15")]
		public override void SetValue(Data128 OKPDFALIJHE, int FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class ONOGOLIJOIF : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D8EFD0", Offset = "0x5D8D7D0", VA = "0x185D8EFD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EEE0", Offset = "0x5D8D6E0", VA = "0x185D8EEE0")]
		public ONOGOLIJOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EEC0", Offset = "0x5D8D6C0", VA = "0x185D8EEC0", Slot = "14")]
		public override int GetValue(Data128 OKPDFALIJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EED0", Offset = "0x5D8D6D0", VA = "0x185D8EED0", Slot = "15")]
		public override void SetValue(Data128 OKPDFALIJHE, int FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E8F0", Offset = "0x5D8D0F0", VA = "0x185D8E8F0")]
	public OEENPKAIPGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class CBGJGMMCAKO : ContainerPropertyBag<EKGGGKBPNKF.BOBKGOBHAAE>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class EMPDLLBLKLH : Property<EKGGGKBPNKF.BOBKGOBHAAE, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5D8B8D0", Offset = "0x5D8A0D0", VA = "0x185D8B8D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B890", Offset = "0x5D8A090", VA = "0x185D8B890")]
		public EMPDLLBLKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85B9B0", Offset = "0x85A1B0", VA = "0x18085B9B0", Slot = "14")]
		public override Vector3 GetValue(EKGGGKBPNKF.BOBKGOBHAAE OKPDFALIJHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D8B870", Offset = "0x5D8A070", VA = "0x185D8B870", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF.BOBKGOBHAAE OKPDFALIJHE, Vector3 FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class PMPFAKLEFAD : Property<EKGGGKBPNKF.BOBKGOBHAAE, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5D8F500", Offset = "0x5D8DD00", VA = "0x185D8F500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F4C0", Offset = "0x5D8DCC0", VA = "0x185D8F4C0")]
		public PMPFAKLEFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F4A0", Offset = "0x5D8DCA0", VA = "0x185D8F4A0", Slot = "14")]
		public override List<SerializableGuid> GetValue(EKGGGKBPNKF.BOBKGOBHAAE OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F4B0", Offset = "0x5D8DCB0", VA = "0x185D8F4B0", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF.BOBKGOBHAAE OKPDFALIJHE, List<SerializableGuid> FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D87950", Offset = "0x5D86150", VA = "0x185D87950")]
	public CBGJGMMCAKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class FNOOENGAHDE : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class CHKAOJIJDMF : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5D87D50", Offset = "0x5D86550", VA = "0x185D87D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D87D10", Offset = "0x5D86510", VA = "0x185D87D10")]
		public CHKAOJIJDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D87CF0", Offset = "0x5D864F0", VA = "0x185D87CF0", Slot = "14")]
		public override float GetValue(Vector3 OKPDFALIJHE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D87D00", Offset = "0x5D86500", VA = "0x185D87D00", Slot = "15")]
		public override void SetValue(Vector3 OKPDFALIJHE, float FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class GDKKKAHMCPM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5D8CDF0", Offset = "0x5D8B5F0", VA = "0x185D8CDF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5D8CDB0", Offset = "0x5D8B5B0", VA = "0x185D8CDB0")]
		public GDKKKAHMCPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5D8CD90", Offset = "0x5D8B590", VA = "0x185D8CD90", Slot = "14")]
		public override float GetValue(Vector3 OKPDFALIJHE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D8CDA0", Offset = "0x5D8B5A0", VA = "0x185D8CDA0", Slot = "15")]
		public override void SetValue(Vector3 OKPDFALIJHE, float FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class JPDLEIHDNJM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5D8D8E0", Offset = "0x5D8C0E0", VA = "0x185D8D8E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D8A0", Offset = "0x5D8C0A0", VA = "0x185D8D8A0")]
		public JPDLEIHDNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1892F50", Offset = "0x1891750", VA = "0x181892F50", Slot = "14")]
		public override float GetValue(Vector3 OKPDFALIJHE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D890", Offset = "0x5D8C090", VA = "0x185D8D890", Slot = "15")]
		public override void SetValue(Vector3 OKPDFALIJHE, float FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8C180", Offset = "0x5D8A980", VA = "0x185D8C180")]
	public FNOOENGAHDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal class MGNBHCLAGPC : ContainerPropertyBag<EKGGGKBPNKF.BIHPLLLLNKP>
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class OICIHCODOGP : Property<EKGGGKBPNKF.BIHPLLLLNKP, EKGGGKBPNKF.BOBKGOBHAAE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5D8EE90", Offset = "0x5D8D690", VA = "0x185D8EE90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EE50", Offset = "0x5D8D650", VA = "0x185D8EE50")]
		public OICIHCODOGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EDE0", Offset = "0x5D8D5E0", VA = "0x185D8EDE0", Slot = "14")]
		public override EKGGGKBPNKF.BOBKGOBHAAE GetValue(EKGGGKBPNKF.BIHPLLLLNKP OKPDFALIJHE)
		{
			return default(EKGGGKBPNKF.BOBKGOBHAAE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D8EE10", Offset = "0x5D8D610", VA = "0x185D8EE10", Slot = "15")]
		public override void SetValue(EKGGGKBPNKF.BIHPLLLLNKP OKPDFALIJHE, EKGGGKBPNKF.BOBKGOBHAAE FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D8E450", Offset = "0x5D8CC50", VA = "0x185D8E450")]
	public MGNBHCLAGPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
internal class BNMJBEPHLDM : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class NPPNMMOJICE : Property<RRObjectPrefabV2Data, ILMCDCGEOPC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5D8E7A0", Offset = "0x5D8CFA0", VA = "0x185D8E7A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5D8E760", Offset = "0x5D8CF60", VA = "0x185D8E760")]
		public NPPNMMOJICE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0", Slot = "14")]
		public override ILMCDCGEOPC GetValue(RRObjectPrefabV2Data OKPDFALIJHE)
		{
			return default(ILMCDCGEOPC);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5D882C0", Offset = "0x5D86AC0", VA = "0x185D882C0", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data OKPDFALIJHE, ILMCDCGEOPC FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D877B0", Offset = "0x5D85FB0", VA = "0x185D877B0")]
	public BNMJBEPHLDM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D8F610", Offset = "0x5D8DE10", VA = "0x185D8F610")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000110")]
public class CAANBFNPALO
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CAANBFNPALO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
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

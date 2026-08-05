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
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LLBGDOHCCCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode HNCEGKMGOEK;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LLPOMLFGOEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public HGBHPKGMBNJ CGHGALAHDAL;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly POBBGCLCMEE<LLPOMLFGOEL> DBFALPAOJDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OLMBPFNEJEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FFPDDAPKMCH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum HGBHPKGMBNJ
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
public struct BHMKLFHLIFI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct FKMJMHEBDCE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity KDABCDIIADN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct INFLHBGLBLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity AOGBEAODJPP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EPDJMGPODFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OIHADBDPDNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity MMKDJDGOBEM;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GFILAFONOFD : NDBCLHEPJHC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PKIIINKKDDE ADFHOLCJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PKIIINKKDDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NBMGNEKMDLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 BDBCDGNNFOM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OKAONDPJLGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PGDMGFOFGEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 OCCHNJMAINK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly POBBGCLCMEE<GKMGKEIKPFE> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GKMGKEIKPFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 OCCHNJMAINK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly POBBGCLCMEE<GKMGKEIKPFE> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BIFPLBMMADL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 JLBIHCMLCIG;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HLABIIFIICP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 AGJDCKNKNKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JGHCGDPJKKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float GKDFCNKOKMO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly POBBGCLCMEE<JGHCGDPJKKC> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FJINCEMPLKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float HNMBCLBOOOO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly POBBGCLCMEE<FJINCEMPLKC> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IHOKBNCFNHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 ODGCLHEKOBC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct OFINGOEKHBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public MDABCJFKJMP MAEMLLLMPFG;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NJMBLFHKINE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public MDABCJFKJMP AKNPHFCNMHE;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BIJFMACBMIC]
public struct PHFOAJCNCBE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity HJECHGCECJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KKLFPBGFPNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GKJEKJMOMIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PDBKFOGDAFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GCJJCIMABIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints FMFBOFLOPDE;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CPMFICKBMFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float CGFEPGJDOEN;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly POBBGCLCMEE<CPMFICKBMFG> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MDAICACKPMP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float MFBBEFCCLBM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct OKGKEOAMEEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CFPLDFHNEEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int FICAPJCBEPB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD85170", Offset = "0xD84570", VA = "0x180D85170")]
	public static CFPLDFHNEEC OOICJOKLJBF(int PAHKKNONPEO)
	{
		return default(CFPLDFHNEEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FACHMDNGODM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody PKDFFNNLBIJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60D54D0", Offset = "0x60D48D0", VA = "0x1860D54D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public FACHMDNGODM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct FOOOEGMACPI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct ABCCPPGIAKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 PEAINEKGLBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OMMANBPCOGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 MADKEMKIPKF;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BPHAKHHMPHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float DKOFALKOKMF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly POBBGCLCMEE<BPHAKHHMPHC> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DLDKGIFOGIA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object LLNFPAODBKC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60D4B70", Offset = "0x60D3F70", VA = "0x1860D4B70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public DLDKGIFOGIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PCGFABJKIFN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object EJAMENPLLCP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60D84F0", Offset = "0x60D78F0", VA = "0x1860D84F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public PCGFABJKIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum MDABCJFKJMP
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum PLAOLPDBAPK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BNGOJKAKFNA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIOMLEMGMML(HGBHPKGMBNJ GHNMBFBCDGF, HGBHPKGMBNJ JNBGDEOKOLP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AICNDOAKJIK();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HILOHFHPDDG();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMAAJAMFNHI(bool PJKPPHMJKBC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FEDLGLDNBIF();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCJHJAIDPIP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LBNBKBCHNMJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public BNGOJKAKFNA NKMFBALAIPO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60D70E0", Offset = "0x60D64E0", VA = "0x1860D70E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public LBNBKBCHNMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ACCABMGEMDB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(MONODIOLHJL nameHash, JCHDDMHEBNK stableTypeHash, Type type)> PHLBPIOBPDD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(MONODIOLHJL nameHash, JCHDDMHEBNK stableTypeHash, Type type)> BLKDEBMBDFL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(MONODIOLHJL previousNameHash, JCHDDMHEBNK previousStableTypeHash, Type currentTypeName)> MELDGCGEGOE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PHFPCKNFHND : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, GJOEPGILIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60D41B0", Offset = "0x60D35B0", VA = "0x1860D41B0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct FNEHBFKFCOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[HCPBIKEEKFM(1)]
	public quaternion MCGHOJEKKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[HCPBIKEEKFM(2)]
	public float3 OHOMLOMNFJE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly POBBGCLCMEE<FNEHBFKFCOD> DBFALPAOJDK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBAB0", Offset = "0x3BEAEB0", VA = "0x183BEBAB0")]
	public FNEHBFKFCOD(quaternion MCGHOJEKKGM, float3 OHOMLOMNFJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60D4480", Offset = "0x60D3880", VA = "0x1860D4480")]
	public static FNEHBFKFCOD OOICJOKLJBF(RigidTransform HMNNNGKLFCN)
	{
		return default(FNEHBFKFCOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class JIGOKFJODHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct FJFFABGDHDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[HCPBIKEEKFM(1)]
	public float ADOIKFCFGFK;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly POBBGCLCMEE<FJFFABGDHDC> DBFALPAOJDK;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[GNCHOPEHLPN]
	public struct AuthoredParentData : IComponentData, GJOEPGILIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[HCPBIKEEKFM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60D41C0", Offset = "0x60D35C0", VA = "0x1860D41C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct MDPLAIGOIKP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, GJOEPGILIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JCKCAEHOILO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct OLFMBCDEMFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[HCPBIKEEKFM(1)]
	public SerializableGuid CEPBGHOOFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[HCPBIKEEKFM(2)]
	public SerializableGuid GILNCNDAFEF;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
[GNCHOPEHLPN]
public struct KPIIJDBADNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[HCPBIKEEKFM(1)]
	[FormerlySerializedAs("Active")]
	public bool FGKEMBDNNLD;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly POBBGCLCMEE<KPIIJDBADNC> DBFALPAOJDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[KGEHPLMKFAN]
public struct ADFJABAHFBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
[GNCHOPEHLPN]
public struct AHFPGOBIBBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[HCPBIKEEKFM(1)]
	public Entity IHBICACMLAI;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct HKFKDIBOCPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity LHFHCKMHMLM;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct OOCHJLBDEMP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity LHFHCKMHMLM;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[PJJDKHPADGA("Container", 0)]
public struct MAJLCMEODJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(1)]
	public MFHODNHFMAH EFOOPEHGLFO;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly POBBGCLCMEE<MAJLCMEODJO> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[PDBHIIHDDCE(0, 127)]
public enum MFHODNHFMAH
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OIGOHJDBAML
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum NPCMPHMICKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum FEJLCMCCDPD
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60D7E40", Offset = "0x60D7240", VA = "0x1860D7E40")]
	public static (NPCMPHMICKN, FEJLCMCCDPD) FEBEPCCNODC(this MFHODNHFMAH FBFOMBJELAK)
	{
		return default((NPCMPHMICKN, FEJLCMCCDPD));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[PJJDKHPADGA("Container", 0)]
public struct ODEFCDIEEBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[HCPBIKEEKFM(1)]
	[PKIFEKBFKJN(0)]
	public JPOBBOPPCMD LCBCLBJNMJB;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly POBBGCLCMEE<ODEFCDIEEBO> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[PDBHIIHDDCE(0, 2)]
public enum JPOBBOPPCMD
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[PJJDKHPADGA("Container", 0)]
public struct FNEFJMGMHAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[HCPBIKEEKFM(1)]
	[PKIFEKBFKJN(0)]
	public KNNICLABCMC FFHMOEDLCNG;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[PDBHIIHDDCE(0, 15943)]
[Flags]
public enum KNNICLABCMC
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MIKGJLNDBNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct PELANNLGOIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct CDFICPMALLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct MIPOLPKAACP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct POHFFDIGPOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct ABGIPFLNAOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct NBALMOHIPJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CCPMMIGHKAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct IAKNBNGNKLC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[PJJDKHPADGA("Container", 0)]
[GNCHOPEHLPN]
public struct GFOODJCBLKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(1)]
	public float BCBFAGMOJDD;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[PJJDKHPADGA("Container", 0)]
public struct AKGLIKMDOOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(1)]
	public FixedString64Bytes ADLKEGECLOG;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct OJCPBFBBKCN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<LLPHDKMHGIC> OMOFINJPJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<Entity> BPCHOFHBPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JobHandle JCIHDGOOBEB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CMNIMAPIALA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60D8180", Offset = "0x60D7580", VA = "0x1860D8180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60D8130", Offset = "0x60D7530", VA = "0x1860D8130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x454E560", Offset = "0x454D960", VA = "0x18454E560")]
	public OJCPBFBBKCN(NativeList<LLPHDKMHGIC> OMOFINJPJEO, NativeList<Entity> BPCHOFHBPCL, JobHandle JCIHDGOOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60D7FB0", Offset = "0x60D73B0", VA = "0x1860D7FB0")]
	public (Entity, NativeSlice<Entity>) DHPGBJBGEKP(int AMJKHBKANHA)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60D80D0", Offset = "0x60D74D0", VA = "0x1860D80D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct LLPHDKMHGIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity MMKDJDGOBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int EIJFICIEABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int OGHJPGGPGJL;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface FFIODFGLPHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLFFKEAHBFG(bool CBHDPJJELAC);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[PJJDKHPADGA("Container", 0)]
[GNCHOPEHLPN]
public struct DAPAAOEDGGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[HCPBIKEEKFM(1)]
	[PKIFEKBFKJN(0)]
	public HGBAIHOMHBA PCIEKIABOCN;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[PDBHIIHDDCE(0, 1)]
public enum HGBAIHOMHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[PJJDKHPADGA("Container", 0)]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
public struct GLKCEEPKPIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(1)]
	public HOPFAKKCKLB CLDLDPLIKOJ;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly POBBGCLCMEE<GLKCEEPKPIG> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[PDBHIIHDDCE(0, 2)]
public enum HOPFAKKCKLB
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	NavMeshGenerator = 0,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	NavMeshIgnored = 1,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	NavMeshBlocker = 2,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[KIEEGDOPPKK(1)]
public struct APIHIBIIMFN : IComparable<APIHIBIIMFN>, IEquatable<APIHIBIIMFN>, BBACAAOCDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[FBPMDLKJMJH(1)]
	public uint LNCIOKDFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[FBPMDLKJMJH(2)]
	public uint ONFILBMOKCD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint CCPKPPDACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60D3F80", Offset = "0x60D3380", VA = "0x1860D3F80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60D4160", Offset = "0x60D3560", VA = "0x1860D4160")]
	public APIHIBIIMFN(int LNCIOKDFAHJ, int LBBKLLNKNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60D4160", Offset = "0x60D3560", VA = "0x1860D4160")]
	public APIHIBIIMFN(uint LNCIOKDFAHJ, uint LBBKLLNKNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60D3E50", Offset = "0x60D3250", VA = "0x1860D3E50")]
	public APIHIBIIMFN GFBLKFJPGBM(int EIJFICIEABK = 1)
	{
		return default(APIHIBIIMFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60D3F90", Offset = "0x60D3390", VA = "0x1860D3F90")]
	public APIHIBIIMFN KALJLGBCJFP(int EIJFICIEABK = 1)
	{
		return default(APIHIBIIMFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60D4000", Offset = "0x60D3400", VA = "0x1860D4000")]
	public static APIHIBIIMFN NIHHJMPFNIK(APIHIBIIMFN NAJACJFDALM, APIHIBIIMFN AKBGGCAJIBJ)
	{
		return default(APIHIBIIMFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60D3D70", Offset = "0x60D3170", VA = "0x1860D3D70")]
	private static uint EBNMAKBOLMK(uint OJBODDLNJNK, uint BLEBDLHLENH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60D3D50", Offset = "0x60D3150", VA = "0x1860D3D50", Slot = "4")]
	public int CompareTo(APIHIBIIMFN JLCJEDAFKJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60D3DC0", Offset = "0x60D31C0", VA = "0x1860D3DC0", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60D4080", Offset = "0x60D3480", VA = "0x1860D4080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60D3DA0", Offset = "0x60D31A0", VA = "0x1860D3DA0", Slot = "5")]
	public bool Equals(APIHIBIIMFN JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60D3F30", Offset = "0x60D3330", VA = "0x1860D3F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60D3EC0", Offset = "0x60D32C0", VA = "0x1860D3EC0", Slot = "6")]
	public void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60D3CE0", Offset = "0x60D30E0", VA = "0x1860D3CE0", Slot = "7")]
	public void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25D15A0", Offset = "0x25D09A0", VA = "0x1825D15A0")]
	public static bool AODPLFIFGHC(APIHIBIIMFN NAJACJFDALM, APIHIBIIMFN AKBGGCAJIBJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[KIEEGDOPPKK(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[FBPMDLKJMJH(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[FBPMDLKJMJH(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[FBPMDLKJMJH(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[FBPMDLKJMJH(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[KIEEGDOPPKK(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, BBACAAOCDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[FBPMDLKJMJH(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
		public static SerializableGuid OOICJOKLJBF(Guid EFNPBHMDENF)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60D9770", Offset = "0x60D8B70", VA = "0x1860D9770", Slot = "4")]
		public bool Equals(SerializableGuid JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60D9750", Offset = "0x60D8B50", VA = "0x1860D9750", Slot = "5")]
		public int CompareTo(SerializableGuid JLCJEDAFKJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60D97A0", Offset = "0x60D8BA0", VA = "0x1860D97A0", Slot = "6")]
		public void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60D96D0", Offset = "0x60D8AD0", VA = "0x1860D96D0", Slot = "7")]
		public void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60D9860", Offset = "0x60D8C60", VA = "0x1860D9860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct NGBIFPCADLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct NMKABGFKILA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct HGIKPCKEIHB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
public struct ABFKEDIKKPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[HCPBIKEEKFM(1)]
	public Entity ICFKMDOGHDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[InternalBufferCapacity(17)]
public struct FNOCKENCFON : IBufferElementData, IEquatable<FNOCKENCFON>, GJOEPGILIGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Entity KDABCDIIADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public int CFIHNMNHMPH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity PMPGDLJBMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60D5900", Offset = "0x60D4D00", VA = "0x1860D5900", Slot = "4")]
	public bool Equals(FNOCKENCFON JLCJEDAFKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
public struct PIOMHBLNFBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[HCPBIKEEKFM(1)]
	public int CFIHNMNHMPH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct MIFEMCHJNKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
[GNCHOPEHLPN]
public struct OBBCOACMKAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[HCPBIKEEKFM(1)]
	public Entity CGPOOAIDKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[HCPBIKEEKFM(2)]
	public uint CCCJFPLOAFI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId FGNIOGFNMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1D31860", Offset = "0x1D30C60", VA = "0x181D31860")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1D55830", Offset = "0x1D54C30", VA = "0x181D55830")]
	public OBBCOACMKAH(Entity CGPOOAIDKLC, EntityBundlePartId PCNHPFGGNGM)
	{
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600")]
		internal EntityBundlePartId(uint NONJEEALACK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		internal uint JKIDCNMJDDP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x818E50", Offset = "0x818250", VA = "0x180818E50", Slot = "4")]
		public bool Equals(EntityBundlePartId JLCJEDAFKJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60D5450", Offset = "0x60D4850", VA = "0x1860D5450", Slot = "0")]
		public override bool Equals(object DFFBALIDCLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A3210", Offset = "0x8A2610", VA = "0x1808A3210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x175BF00", Offset = "0x175B300", VA = "0x18175BF00")]
		public static bool AODPLFIFGHC(EntityBundlePartId OJBODDLNJNK, EntityBundlePartId BLEBDLHLENH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HBAHHEPILPM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Entity ABMCHLHGEAP;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
[GNCHOPEHLPN]
public struct MONNDIKLJMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[HCPBIKEEKFM(1)]
	public Entity GOOANMNBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[HCPBIKEEKFM(2)]
	public bool ODBKFBOEKLM;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct ADPMLNCLKGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[HCPBIKEEKFM(1)]
	public BGFMDLJFDEO KKGPBFHNKFK;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[PDBHIIHDDCE(0, 4)]
public enum BGFMDLJFDEO
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
[GNCHOPEHLPN]
public struct EOAIKKBDJDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[HCPBIKEEKFM(1)]
	public Entity GOOANMNBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[HCPBIKEEKFM(2)]
	public bool PCNKOFFOIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[HCPBIKEEKFM(3)]
	public float GMHMKLOBINO;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[GNCHOPEHLPN]
public struct HACPOEAFELB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[HCPBIKEEKFM(1)]
	public bool PLJNLCOFMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[HCPBIKEEKFM(2)]
	public bool PCNKOFFOIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[HCPBIKEEKFM(3)]
	public float MJLMFKDAGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[HCPBIKEEKFM(4)]
	public float BMPNIIEFPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[HCPBIKEEKFM(5)]
	public float NNAEFEPNKEA;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct OEGKCCACLHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[HCPBIKEEKFM(1)]
	public bool PLJNLCOFMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[HCPBIKEEKFM(2)]
	public bool PCNKOFFOIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[HCPBIKEEKFM(3)]
	public float GMHMKLOBINO;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, GJOEPGILIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60D41B0", Offset = "0x60D35B0", VA = "0x1860D41B0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[GNCHOPEHLPN]
	public struct ParentData : IComponentData, GJOEPGILIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[HCPBIKEEKFM(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, GJOEPGILIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7FA360", Offset = "0x7F9760", VA = "0x1807FA360", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1761D00", Offset = "0x1761100", VA = "0x181761D00")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct MMIAOJAEHBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface GJOEPGILIGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity GCHEOLAIPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FAODFGEJLFP<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly bool FOPNCONIKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public uint OHGOJEFHPNF;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	private static bool AAJMHNAMACO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[GNCHOPEHLPN]
[PJJDKHPADGA("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct LLCADJOLPJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(1)]
	public bool MKECFCAPOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(2)]
	public float MECICNHJBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(3)]
	public float FDKIOAEOHPH;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PJJDKHPADGA("Light", 0)]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
public struct ODBNDDHFNFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[HCPBIKEEKFM(1)]
	[PKIFEKBFKJN(0)]
	public float LEODGELIJFI;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.TypeVersion(2)]
public struct NHIFMOPPLHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public uint ILIIBFGNOCN;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60D7950", Offset = "0x60D6D50", VA = "0x1860D7950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[GNCHOPEHLPN]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[FBPMDLKJMJH(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct ELDOBNPPMKE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public int CJNODJFMPAD;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct DHINHHFEKPG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public GCHandle JENDCGLDCCA;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[PDBHIIHDDCE(0, 4)]
public enum PBPIMJIGODB
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct BKAOFJGKNPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct FFEAPPBOKJP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public int CJNODJFMPAD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct KJMKLHINGDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct LHJEAFHMCHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct BCIOLPNAFCB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[PJJDKHPADGA("Object", 0)]
[TypeManager.TypeVersion(3)]
public struct LOLJFGFNDKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[HCPBIKEEKFM(2)]
	public BHDDKHKFLNE ONPGMKGOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(3)]
	public OMFPHENPPEJ AMFOCNHNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[HCPBIKEEKFM(4)]
	[PKIFEKBFKJN(0)]
	public HHMMEMDOIJK NKEGMIAPKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[FBPMDLKJMJH(5)]
	public OEAJEICLIAO FFHMOEDLCNG;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly POBBGCLCMEE<LOLJFGFNDKI> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class LNJHNIOFOKM
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60D7400", Offset = "0x60D6800", VA = "0x1860D7400")]
	public static void NIEAIDPCAEB(this OEAJEICLIAO FFHMOEDLCNG, OKJDBOEONLF BLJFPFKLJAA, bool PLPLMBNMHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60D73C0", Offset = "0x60D67C0", VA = "0x1860D73C0")]
	public static bool FNBPAAOFAON(this OEAJEICLIAO FFHMOEDLCNG, OKJDBOEONLF BLJFPFKLJAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60D7430", Offset = "0x60D6830", VA = "0x1860D7430")]
	public static OEAJEICLIAO OMIINFEINNN(this OKJDBOEONLF BLJFPFKLJAA)
	{
		return default(OEAJEICLIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60D73E0", Offset = "0x60D67E0", VA = "0x1860D73E0")]
	public static void NIEAIDPCAEB(this OMFPHENPPEJ FFHMOEDLCNG, OMFPHENPPEJ EEEKFDACBJK, bool PLPLMBNMHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE8C0", Offset = "0x5FEDCC0", VA = "0x185FEE8C0")]
	public static bool FNBPAAOFAON(this OMFPHENPPEJ FFHMOEDLCNG, OMFPHENPPEJ BLJFPFKLJAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum OKJDBOEONLF
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[PDBHIIHDDCE(0, 16383)]
[Flags]
public enum OEAJEICLIAO
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[Flags]
[PDBHIIHDDCE(0, 3)]
public enum OMFPHENPPEJ
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	MAX = 3
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[PDBHIIHDDCE(0, 4)]
[OLLLNMNONLN]
public enum HHMMEMDOIJK
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OLLLNMNONLN : ONFEEJJLMPN
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60D8260", Offset = "0x60D7660", VA = "0x1860D8260", Slot = "7")]
	public override string FFILKOANIAP(string ADBOOOJIIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E250", Offset = "0x1E6D650", VA = "0x181E6E250")]
	public OLLLNMNONLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[KIEEGDOPPKK(1)]
public struct BHDDKHKFLNE : BBACAAOCDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[FBPMDLKJMJH(1)]
	public bool MKECFCAPOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[FBPMDLKJMJH(2)]
	public float3 HDHGNAHNJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[FBPMDLKJMJH(3)]
	public float3 GHLHIHEPBMH;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly POBBGCLCMEE<BHDDKHKFLNE> DBFALPAOJDK;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60D4320", Offset = "0x60D3720", VA = "0x1860D4320", Slot = "5")]
	public void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60D4390", Offset = "0x60D3790", VA = "0x1860D4390", Slot = "4")]
	public void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct MENNLACIGNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct IJJAMJMNKLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct IFOMMLHCIGP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GFKHODNBJOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public FixedString32Bytes ADLKEGECLOG;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BIJFMACBMIC]
public struct JIOBKGCLPHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Entity ONBCIIKFKKK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static JIOBKGCLPHB OOICJOKLJBF(Entity PAHKKNONPEO)
	{
		return default(JIOBKGCLPHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
[GNCHOPEHLPN]
public struct GPBOOKJGCCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[HCPBIKEEKFM(1)]
	public Entity OPPJGMEMCIH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static GPBOOKJGCCH OOICJOKLJBF(Entity HJECHGCECJI)
	{
		return default(GPBOOKJGCCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal struct IEEHCKHLEKP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Entity HJECHGCECJI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static IEEHCKHLEKP OOICJOKLJBF(Entity HJECHGCECJI)
	{
		return default(IEEHCKHLEKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct KFIACHFNAAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Entity MNNLFGJKFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Entity FPBBCLHJPKL;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal struct FNJJOOOGOID : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Entity LONLNFHEMPH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static FNJJOOOGOID OOICJOKLJBF(Entity HJECHGCECJI)
	{
		return default(FNJJOOOGOID);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal struct HCBNNFEOGMO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[PDBHIIHDDCE(0, 2)]
public enum BFLKFOAJFNF
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PJJDKHPADGA("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[GNCHOPEHLPN]
public struct FCGJIGDNHDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(1)]
	public float GIJGEGNPDGC;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static readonly POBBGCLCMEE<FCGJIGDNHDN> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct OMBOAAHMCEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[HCPBIKEEKFM(1)]
	public IBKDJMDJCHE NGEIDHPCIOD;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[PDBHIIHDDCE(-1, 38)]
public enum IBKDJMDJCHE
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct IOIDOAIABDM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[PDBHIIHDDCE(0, 7)]
	[Flags]
	public enum FPPJHIKPGPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[HCPBIKEEKFM(1)]
	public FPPJHIKPGPD FFHMOEDLCNG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static readonly POBBGCLCMEE<IOIDOAIABDM> DBFALPAOJDK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool BIBCKAMHCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60D6A00", Offset = "0x60D5E00", VA = "0x1860D6A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EIICPKPIMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60D6A10", Offset = "0x60D5E10", VA = "0x1860D6A10")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct CKFBIODPOAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[HCPBIKEEKFM(1)]
	public BFLKFOAJFNF NGEIDHPCIOD;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct DGKKHMEIOAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public uint IEOKPDEFBIP;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[KIEEGDOPPKK(1)]
public struct MKCNMENAIME : BBACAAOCDGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[PDBHIIHDDCE(0, 7)]
	[Flags]
	public enum CFBGIIDJOOC
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[FBPMDLKJMJH(1)]
	public float EDJELOBAAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[FBPMDLKJMJH(2)]
	public int MIFDKEBJAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[FBPMDLKJMJH(3)]
	public CFBGIIDJOOC FFHMOEDLCNG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool LLFPMEGPLCK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60D78D0", Offset = "0x60D6CD0", VA = "0x1860D78D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60D78E0", Offset = "0x60D6CE0", VA = "0x1860D78E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MBCMJEGBNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60D7940", Offset = "0x60D6D40", VA = "0x1860D7940")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60D7920", Offset = "0x60D6D20", VA = "0x1860D7920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool FCHIBEFCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60D7860", Offset = "0x60D6C60", VA = "0x1860D7860")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60D7900", Offset = "0x60D6D00", VA = "0x1860D7900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60D7810", Offset = "0x60D6C10", VA = "0x1860D7810", Slot = "5")]
	public void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60D7870", Offset = "0x60D6C70", VA = "0x1860D7870", Slot = "4")]
	public void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[BIJFMACBMIC]
internal struct POKIMLFBCEO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Entity JCKPABHJLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public int FGBBDGJMFEH;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[GNCHOPEHLPN]
public struct MDHBMKNAGEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[HCPBIKEEKFM(1)]
	public APIHIBIIMFN LMLIBHOIDLP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static MDHBMKNAGEC OOICJOKLJBF(APIHIBIIMFN PAHKKNONPEO)
	{
		return default(MDHBMKNAGEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[GNCHOPEHLPN]
public struct GEHBMKODLAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[HCPBIKEEKFM(1)]
	public Entity GKPBJKGCCAF;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct BELPNPPMMDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Entity GKPBJKGCCAF;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[GNCHOPEHLPN]
public struct AIIJLKCBJJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[HCPBIKEEKFM(1)]
	public float3 OHOMLOMNFJE;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static readonly POBBGCLCMEE<AIIJLKCBJJP> DBFALPAOJDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x212E390", Offset = "0x212D790", VA = "0x18212E390")]
	public static AIIJLKCBJJP OOICJOKLJBF(float3 PAHKKNONPEO)
	{
		return default(AIIJLKCBJJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct OPNCOEPJHKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[HCPBIKEEKFM(1)]
	public quaternion MCGHOJEKKGM;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static readonly POBBGCLCMEE<OPNCOEPJHKN> DBFALPAOJDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
	public static OPNCOEPJHKN OOICJOKLJBF(quaternion PAHKKNONPEO)
	{
		return default(OPNCOEPJHKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct FMICKBCFCFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[HCPBIKEEKFM(1)]
	public float3 PJGOPMOLDOF;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public static readonly POBBGCLCMEE<FMICKBCFCFJ> DBFALPAOJDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x212E390", Offset = "0x212D790", VA = "0x18212E390")]
	public static FMICKBCFCFJ OOICJOKLJBF(float3 PAHKKNONPEO)
	{
		return default(FMICKBCFCFJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
[GNCHOPEHLPN]
public struct LPONOILPDFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[HCPBIKEEKFM(1)]
	public MKCNMENAIME LALAKJLPIGH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct OAICPPLEEEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct HFEBFPNJJAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public uint OHGOJEFHPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int DBKMMPEGMMF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA31A30", Offset = "0xA30E30", VA = "0x180A31A30")]
	public HFEBFPNJJAM(uint GAJFJJPOMNG, int GAPIOJJNDNN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct BGJELMPNIMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct JJHDIDPHFFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct DFKIGJOEIIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct HLEGEPBDIKE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct DLNHAOCJOOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct IFFNIEHAKKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct FMIHDKJOMDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct KJMILEHIFHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct AJEIFDHIBIK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct JCFAFGNNECA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal struct IPACGNGKDPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal struct HLOEBKLPDBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal struct LDJGEOOKLHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct BCKLGGILHNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct OPMMFJADOMF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct GJCLIANELCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[HCPBIKEEKFM(1)]
	public FixedList32Bytes<int> AMNFAGJAFEP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct JAJODOMANPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct KPFKFMNNELL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct NKIJLCJKLLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct LBCEJMGEKBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct CGFGJFNFEFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct NHHGGHOLFCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct KKFNCHNJEFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct FJCPMILOIKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[BIJFMACBMIC]
public struct APKCKJNACOH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public FixedString32Bytes GJDNBMNMHIJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct BIFMBKOPAPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct HENKMPOHFBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct JMJDBHIJENP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct MHECLPFAFFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[FBPMDLKJMJH(1)]
	public GGHCNCEGBOO IEOKPDEFBIP;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public static readonly POBBGCLCMEE<MHECLPFAFFH> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public enum GGHCNCEGBOO : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct ECLJIALKPNA : IComponentData, IComparable<ECLJIALKPNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public int JFHGDOOAGGO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x176B410", Offset = "0x176A810", VA = "0x18176B410", Slot = "4")]
	public int CompareTo(ECLJIALKPNA JLCJEDAFKJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct PCFIHCKNFAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[HCPBIKEEKFM(2)]
	public bool OMODAHAFKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[HCPBIKEEKFM(3)]
	public bool HAGHLLMIACF;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public static readonly POBBGCLCMEE<PCFIHCKNFAO> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[GNCHOPEHLPN]
public struct ANALDJPMMEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[HCPBIKEEKFM(1)]
	public bool GKOKHDICIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[HCPBIKEEKFM(2)]
	public byte AEMLEJEIDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[HCPBIKEEKFM(3)]
	public short JAKNFHPIJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[HCPBIKEEKFM(4)]
	public ushort ABKFCCHPIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[HCPBIKEEKFM(5)]
	public int MAECMDAABCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[HCPBIKEEKFM(6)]
	public uint MBEBKBOJMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[HCPBIKEEKFM(7)]
	public long LNDJJEDHDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[HCPBIKEEKFM(8)]
	public ulong IFPMCCIFMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[HCPBIKEEKFM(9)]
	public float PGKHKOBFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[HCPBIKEEKFM(10)]
	public double GHFFJICLGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[HCPBIKEEKFM(11)]
	public HIKMKMLIOON JDFOFIHOGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[HCPBIKEEKFM(12)]
	public OELBDEFIENO LEGLKPAPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[HCPBIKEEKFM(13)]
	public DINLPAOCDFI OFHPDLBAAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[HCPBIKEEKFM(14)]
	public NNAENDGMKJA OLNGMFDGLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[HCPBIKEEKFM(15)]
	public BOJBAOKCJCN JDBNMHAFJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[HCPBIKEEKFM(16)]
	public KDJJIMCBKEE CJMOGKMPHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[HCPBIKEEKFM(17)]
	public NKMENBFIEPH JHKCBKDEGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[HCPBIKEEKFM(18)]
	public GBBLNKKGBBG HFIAOAGGJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[HCPBIKEEKFM(20)]
	public Quaternion NMBEBPCIBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[HCPBIKEEKFM(22)]
	public Vector3 LDJPILBJDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[HCPBIKEEKFM(23)]
	public Vector4 CJNEKOMLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[HCPBIKEEKFM(40)]
	public Entity HMKAAOOONLL;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum HIKMKMLIOON : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum OELBDEFIENO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum DINLPAOCDFI : short
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum NNAENDGMKJA : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum BOJBAOKCJCN
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public enum KDJJIMCBKEE : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum NKMENBFIEPH : long
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum GBBLNKKGBBG : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	[GNCHOPEHLPN]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[GNCHOPEHLPN]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class FPFLHMHAAME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public int PKBBOCAODJK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public int POMLGPJEBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public GameObject IFGJJHCIEPA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public FPFLHMHAAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class LIOFKEBOEFF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public struct PADPJOMPKCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Vector3 GKGMFALNJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<SerializableGuid> IBOIOJDJBCO;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class DMHFOALKABN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public PADPJOMPKCJ GEFBBFAIADO;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public DMHFOALKABN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public SerializableGuid IJIDDEPICGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public List<int> JFEFLEKFKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public List<PADPJOMPKCJ> AOKCBODIGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public List<DMHFOALKABN> APENDBJCGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public GameObject IFGJJHCIEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Light HPAPMLBHDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Collider OHBBEBBKENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public string KPBJOEGDCLD;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public LIOFKEBOEFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[GNCHOPEHLPN]
public struct IKKOHAKLMKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[HCPBIKEEKFM(1)]
	public float3 NAJOFECDMFO;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly POBBGCLCMEE<IKKOHAKLMKN> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct BILHMCLGJPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[HCPBIKEEKFM(1)]
	public quaternion MCGHOJEKKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[HCPBIKEEKFM(2)]
	public float3 OHOMLOMNFJE;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly POBBGCLCMEE<BILHMCLGJPN> DBFALPAOJDK;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBAB0", Offset = "0x3BEAEB0", VA = "0x183BEBAB0")]
	public BILHMCLGJPN(quaternion MCGHOJEKKGM, float3 OHOMLOMNFJE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60D4480", Offset = "0x60D3880", VA = "0x1860D4480")]
	public static RigidTransform OOICJOKLJBF(BILHMCLGJPN APKONKEKPEJ)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60D4480", Offset = "0x60D3880", VA = "0x1860D4480")]
	public static BILHMCLGJPN OOICJOKLJBF(RigidTransform HMNNNGKLFCN)
	{
		return default(BILHMCLGJPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class IHONINDOIOA
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct ONGPDMGEAKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float4x4 HFCNJDPAPHC;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static readonly POBBGCLCMEE<ONGPDMGEAKP> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public struct EMBPHKNKNKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float4x4 JKLNLJAJGND;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly POBBGCLCMEE<EMBPHKNKNKF> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct FAGNGGEAAIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[HCPBIKEEKFM(1)]
	public float ADOIKFCFGFK;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public static readonly POBBGCLCMEE<FAGNGGEAAIH> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct DLGBCPMIADN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int OICOLNFPIFH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int FGBBDGJMFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60D4BF0", Offset = "0x60D3FF0", VA = "0x1860D4BF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60D4BE0", Offset = "0x60D3FE0", VA = "0x1860D4BE0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[GNCHOPEHLPN]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct PJEBBMPONNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[HCPBIKEEKFM(1)]
	public ANNGLMFJFJI EJOBLADLCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[HCPBIKEEKFM(2)]
	public OHAONIIDBLA KDAIFLIEMNP;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[PDBHIIHDDCE(0, 1)]
[Flags]
public enum ANNGLMFJFJI
{
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[PDBHIIHDDCE(-2, 2)]
public enum OHAONIIDBLA
{
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public struct KOLFBMKOLMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public float3 AAOBPPJPCOB;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly POBBGCLCMEE<KOLFBMKOLMN> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct MFGFKEBFGBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public float3 BCGGHPIMKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public quaternion GIJALKLADPN;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static readonly POBBGCLCMEE<MFGFKEBFGBB> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class KHJLOBONIBD
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct KBBPCOLKEHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public float BLFBMDBCEBD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly POBBGCLCMEE<KBBPCOLKEHB> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[PDBHIIHDDCE(1000, 8000)]
public enum GEIFGNPODDN
{
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	GameObject_Replicator = 7014,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public static class OGONIEEGKDL
{
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal enum ODKGOEGGCIF
{
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	UNUSED = 0,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal static class PHHANLMCMPP
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[PDBHIIHDDCE(0, 9)]
public enum OEEGCNHLDOI
{
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	UNUSED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class APFMBEBIEFM
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60D3CD0", Offset = "0x60D30D0", VA = "0x1860D3CD0")]
	public static bool NFCIIGIHCFN(this OEEGCNHLDOI GDPBKNGFHDD)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[GNCHOPEHLPN]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public GEIFGNPODDN prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class JDGCKCIPFIO
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x60D6A70", Offset = "0x60D5E70", VA = "0x1860D6A70")]
	public static OEEGCNHLDOI BOKDDGDLKPP(this GEIFGNPODDN LDBFOCMCGPO)
	{
		return default(OEEGCNHLDOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[PDBHIIHDDCE(int.MinValue, int.MaxValue)]
public enum CDPNNMCPMDK
{
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[PDBHIIHDDCE(-1, 31)]
public enum GECCKCHIAEK
{
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[GNCHOPEHLPN]
[PJJDKHPADGA("Visual", 0)]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
public struct DNHOAOIPOBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[HCPBIKEEKFM(1)]
	[PKIFEKBFKJN(0)]
	public CDPNNMCPMDK JKOGDMNIBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(2)]
	public GECCKCHIAEK DELNJNDMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(3)]
	public float MCCCMMHNMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(4)]
	public Vector3 HAIPCMBMAJH;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[OMGBLFMOCFH(2613756846563002039uL, 6372660366488563574uL)]
[PJJDKHPADGA("Container", 0)]
[OOPBMNIOKFK]
public struct NJBBIJOGGDA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[HCPBIKEEKFM(1)]
	[PKIFEKBFKJN(0)]
	public KNJCHOOEIOH GBOBEMOGCPB;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[Flags]
[PDBHIIHDDCE(0, 15)]
public enum KNJCHOOEIOH
{
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[OOPBMNIOKFK]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[OMGBLFMOCFH(9804513251708000208uL, 10903582988135044631uL)]
public struct IAOHCCFDHFF : IComponentData, IEquatable<IAOHCCFDHFF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[HCPBIKEEKFM(1)]
	public FixedString64Bytes ADLKEGECLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[HCPBIKEEKFM(2)]
	public JPOBBOPPCMD LCBCLBJNMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[HCPBIKEEKFM(3)]
	public KNJCHOOEIOH GBOBEMOGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[HCPBIKEEKFM(4)]
	public HGBAIHOMHBA PCIEKIABOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[HCPBIKEEKFM(5)]
	public KNNICLABCMC FFHMOEDLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[HCPBIKEEKFM(6)]
	public float BCBFAGMOJDD;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60D63A0", Offset = "0x60D57A0", VA = "0x1860D63A0", Slot = "4")]
	public bool Equals(IAOHCCFDHFF JLCJEDAFKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[OMGBLFMOCFH(1213445203937950283uL, 119653618660684511uL)]
[OOPBMNIOKFK]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct LKHGDGGHPEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[HCPBIKEEKFM(1)]
	public NIHGNGEENAD IOJHBFANEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public GCHandle JDMDDMDPEKF;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[KIEEGDOPPKK(1)]
public struct NIHGNGEENAD : BBACAAOCDGJ, IEquatable<NIHGNGEENAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[FBPMDLKJMJH(1)]
	public int NONJEEALACK;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60D7A90", Offset = "0x60D6E90", VA = "0x1860D7A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x60D7A00", Offset = "0x60D6E00", VA = "0x1860D7A00", Slot = "0")]
	public override bool Equals(object DFFBALIDCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x818E50", Offset = "0x818250", VA = "0x180818E50", Slot = "6")]
	public bool Equals(NIHGNGEENAD JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x176B4A0", Offset = "0x176A8A0", VA = "0x18176B4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x60D79E0", Offset = "0x60D6DE0", VA = "0x1860D79E0", Slot = "5")]
	public void BOEOGBDBLGM(FDAPLEOACLI MAACBPKBLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x60D7A80", Offset = "0x60D6E80", VA = "0x1860D7A80", Slot = "4")]
	public void GOGJDIDOEDD(CIFLEGMAKNF FJHMPBLBMAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[OMGBLFMOCFH(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[OOPBMNIOKFK]
public struct ADHIGNNAKJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private uint BAIFHJCFGFN;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[OOPBMNIOKFK]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[OMGBLFMOCFH(9898405628982320166uL, 2023375009558162791uL)]
public struct EFBIJACPGNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[HCPBIKEEKFM(1)]
	public OEAJEICLIAO FFHMOEDLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[HCPBIKEEKFM(2)]
	public BHDDKHKFLNE ONPGMKGOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[HCPBIKEEKFM(3)]
	[PKIFEKBFKJN(0)]
	public bool JCANNPMLHBO;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly POBBGCLCMEE<EFBIJACPGNK> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[OOPBMNIOKFK]
[OMGBLFMOCFH(9807788745867066359uL, 15168486114979071194uL)]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct ELFIBDCPDAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[HCPBIKEEKFM(1)]
	public OEAJEICLIAO FFHMOEDLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[HCPBIKEEKFM(2)]
	public BHDDKHKFLNE ONPGMKGOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[HCPBIKEEKFM(3)]
	[PKIFEKBFKJN(0)]
	public bool JCANNPMLHBO;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly POBBGCLCMEE<ELFIBDCPDAB> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[OMGBLFMOCFH(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[OOPBMNIOKFK]
public struct HJIPDFPCGDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[FBPMDLKJMJH(1)]
	public OEAJEICLIAO FFHMOEDLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[HCPBIKEEKFM(2)]
	public BHDDKHKFLNE ONPGMKGOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[PKIFEKBFKJN(0)]
	[HCPBIKEEKFM(3)]
	public OMFPHENPPEJ AMFOCNHNGJO;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly POBBGCLCMEE<HJIPDFPCGDE> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[OMGBLFMOCFH(12226092714547765037uL, 15970362445488810630uL)]
[OOPBMNIOKFK]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct DJOGHOIKOEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	[HCPBIKEEKFM(2)]
	public BHDDKHKFLNE ONPGMKGOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[HCPBIKEEKFM(3)]
	[PKIFEKBFKJN(0)]
	public OMFPHENPPEJ AMFOCNHNGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[FBPMDLKJMJH(4)]
	public OEAJEICLIAO FFHMOEDLCNG;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly POBBGCLCMEE<DJOGHOIKOEN> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[OOPBMNIOKFK]
[OMGBLFMOCFH(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct KOJKLIKKNGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public int CLPOALFOKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	[HCPBIKEEKFM(2)]
	public bool OMODAHAFKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	[HCPBIKEEKFM(3)]
	public bool HAGHLLMIACF;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly POBBGCLCMEE<KOJKLIKKNGO> DBFALPAOJDK;
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[OMGBLFMOCFH(5861057081882613294uL, 13746475565109640919uL)]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[OOPBMNIOKFK]
public struct IIECPJPMFOC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[PDBHIIHDDCE(0, 1)]
	public enum LGNFDPLJIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		Custom = 1,
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		MAX = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	[HCPBIKEEKFM(1)]
	public LGNFDPLJIIJ FKPHHFDDHND;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[OMGBLFMOCFH(14327281633525910712uL, 2559857777606771911uL)]
[OOPBMNIOKFK]
public struct FEOACILMNMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	[HCPBIKEEKFM(1)]
	public GEIFGNPODDN LDBFOCMCGPO;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[OOPBMNIOKFK]
[OMGBLFMOCFH(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct GEAFCDNGMMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	[HCPBIKEEKFM(1)]
	public GEIFGNPODDN LDBFOCMCGPO;
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[OOPBMNIOKFK]
[OMGBLFMOCFH(1029043735688538310uL, 14256247939851101839uL)]
public struct NEPFLNIMAAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public OEEGCNHLDOI GDPBKNGFHDD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[OMGBLFMOCFH(17667479821163689808uL, 11946378475791123970uL)]
[OOPBMNIOKFK]
public struct GGIJAHAHEBB : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : NNKBGHGFICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x60D9870", Offset = "0x60D8C70", VA = "0x1860D9870", Slot = "4")]
		public sealed override void DLOPFENNDEP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class NIKNMKMNKLC : ContainerPropertyBag<FACHMDNGODM>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class OJKOJKMLADN : Property<FACHMDNGODM, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x60D8230", Offset = "0x60D7630", VA = "0x1860D8230", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x60D81F0", Offset = "0x60D75F0", VA = "0x1860D81F0")]
		public OJKOJKMLADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x60D55A0", Offset = "0x60D49A0", VA = "0x1860D55A0", Slot = "14")]
		public override Rigidbody GetValue(FACHMDNGODM MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x60D55C0", Offset = "0x60D49C0", VA = "0x1860D55C0", Slot = "15")]
		public override void SetValue(FACHMDNGODM MKEGOGNADMP, Rigidbody PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x60D7AF0", Offset = "0x60D6EF0", VA = "0x1860D7AF0")]
	public NIKNMKMNKLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class EONALMGGFGE : ContainerPropertyBag<DLDKGIFOGIA>
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class HHGFBJPMNJE : Property<DLDKGIFOGIA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x60D6110", Offset = "0x60D5510", VA = "0x1860D6110", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x60D60D0", Offset = "0x60D54D0", VA = "0x1860D60D0")]
		public HHGFBJPMNJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60D55A0", Offset = "0x60D49A0", VA = "0x1860D55A0", Slot = "14")]
		public override object GetValue(DLDKGIFOGIA MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60D55C0", Offset = "0x60D49C0", VA = "0x1860D55C0", Slot = "15")]
		public override void SetValue(DLDKGIFOGIA MKEGOGNADMP, object PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x60D5370", Offset = "0x60D4770", VA = "0x1860D5370")]
	public EONALMGGFGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal class KPBADBHBFLO : ContainerPropertyBag<PCGFABJKIFN>
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class FBKPEMMHKKF : Property<PCGFABJKIFN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x60D5630", Offset = "0x60D4A30", VA = "0x1860D5630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x60D55F0", Offset = "0x60D49F0", VA = "0x1860D55F0")]
		public FBKPEMMHKKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x60D55A0", Offset = "0x60D49A0", VA = "0x1860D55A0", Slot = "14")]
		public override object GetValue(PCGFABJKIFN MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60D55C0", Offset = "0x60D49C0", VA = "0x1860D55C0", Slot = "15")]
		public override void SetValue(PCGFABJKIFN MKEGOGNADMP, object PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x60D6E10", Offset = "0x60D6210", VA = "0x1860D6E10")]
	public KPBADBHBFLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class LJMNFIEMEAJ : ContainerPropertyBag<LBNBKBCHNMJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class HKLBIDEPBNJ : Property<LBNBKBCHNMJ, BNGOJKAKFNA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x60D62E0", Offset = "0x60D56E0", VA = "0x1860D62E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60D62A0", Offset = "0x60D56A0", VA = "0x1860D62A0")]
		public HKLBIDEPBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x60D55A0", Offset = "0x60D49A0", VA = "0x1860D55A0", Slot = "14")]
		public override BNGOJKAKFNA GetValue(LBNBKBCHNMJ MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x60D55C0", Offset = "0x60D49C0", VA = "0x1860D55C0", Slot = "15")]
		public override void SetValue(LBNBKBCHNMJ MKEGOGNADMP, BNGOJKAKFNA PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x60D7280", Offset = "0x60D6680", VA = "0x1860D7280")]
	public LJMNFIEMEAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal class PFFMHEBJHJP : ContainerPropertyBag<FPFLHMHAAME>
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class EGPHEJBDKJH : Property<FPFLHMHAAME, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x60D4EE0", Offset = "0x60D42E0", VA = "0x1860D4EE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x60D4EA0", Offset = "0x60D42A0", VA = "0x1860D4EA0")]
		public EGPHEJBDKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60D4E60", Offset = "0x60D4260", VA = "0x1860D4E60", Slot = "14")]
		public override int GetValue(FPFLHMHAAME MKEGOGNADMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60D4E80", Offset = "0x60D4280", VA = "0x1860D4E80", Slot = "15")]
		public override void SetValue(FPFLHMHAAME MKEGOGNADMP, int PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class CJEFGIPNBMH : Property<FPFLHMHAAME, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x60D4880", Offset = "0x60D3C80", VA = "0x1860D4880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x60D4840", Offset = "0x60D3C40", VA = "0x1860D4840")]
		public CJEFGIPNBMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x60D4800", Offset = "0x60D3C00", VA = "0x1860D4800", Slot = "14")]
		public override int GetValue(FPFLHMHAAME MKEGOGNADMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x60D4820", Offset = "0x60D3C20", VA = "0x1860D4820", Slot = "15")]
		public override void SetValue(FPFLHMHAAME MKEGOGNADMP, int PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class MJGMPIPFBMN : Property<FPFLHMHAAME, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x60D77E0", Offset = "0x60D6BE0", VA = "0x1860D77E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60D77A0", Offset = "0x60D6BA0", VA = "0x1860D77A0")]
		public MJGMPIPFBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x60D7750", Offset = "0x60D6B50", VA = "0x1860D7750", Slot = "14")]
		public override GameObject GetValue(FPFLHMHAAME MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x60D7770", Offset = "0x60D6B70", VA = "0x1860D7770", Slot = "15")]
		public override void SetValue(FPFLHMHAAME MKEGOGNADMP, GameObject PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x60D8560", Offset = "0x60D7960", VA = "0x1860D8560")]
	public PFFMHEBJHJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class GLGPCCFJJKE : ContainerPropertyBag<LIOFKEBOEFF>
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class PPDKCGIDOIB : Property<LIOFKEBOEFF, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x60D8970", Offset = "0x60D7D70", VA = "0x1860D8970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x60D8930", Offset = "0x60D7D30", VA = "0x1860D8930")]
		public PPDKCGIDOIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60D88E0", Offset = "0x60D7CE0", VA = "0x1860D88E0", Slot = "14")]
		public override SerializableGuid GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60D8910", Offset = "0x60D7D10", VA = "0x1860D8910", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, SerializableGuid PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class PMEOFJPIBPG : Property<LIOFKEBOEFF, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x60D88B0", Offset = "0x60D7CB0", VA = "0x1860D88B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60D8870", Offset = "0x60D7C70", VA = "0x1860D8870")]
		public PMEOFJPIBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60D8820", Offset = "0x60D7C20", VA = "0x1860D8820", Slot = "14")]
		public override List<int> GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60D8840", Offset = "0x60D7C40", VA = "0x1860D8840", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, List<int> PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class CLFLJCAAOLP : Property<LIOFKEBOEFF, List<LIOFKEBOEFF.PADPJOMPKCJ>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x60D4940", Offset = "0x60D3D40", VA = "0x1860D4940", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60D4900", Offset = "0x60D3D00", VA = "0x1860D4900")]
		public CLFLJCAAOLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x60D48B0", Offset = "0x60D3CB0", VA = "0x1860D48B0", Slot = "14")]
		public override List<LIOFKEBOEFF.PADPJOMPKCJ> GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60D48D0", Offset = "0x60D3CD0", VA = "0x1860D48D0", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, List<LIOFKEBOEFF.PADPJOMPKCJ> PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class BLOKGEFBEKG : Property<LIOFKEBOEFF, List<LIOFKEBOEFF.DMHFOALKABN>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x60D4770", Offset = "0x60D3B70", VA = "0x1860D4770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60D4730", Offset = "0x60D3B30", VA = "0x1860D4730")]
		public BLOKGEFBEKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60D46E0", Offset = "0x60D3AE0", VA = "0x1860D46E0", Slot = "14")]
		public override List<LIOFKEBOEFF.DMHFOALKABN> GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60D4700", Offset = "0x60D3B00", VA = "0x1860D4700", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, List<LIOFKEBOEFF.DMHFOALKABN> PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class GHGMFGLPDJK : Property<LIOFKEBOEFF, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x60D59E0", Offset = "0x60D4DE0", VA = "0x1860D59E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60D59A0", Offset = "0x60D4DA0", VA = "0x1860D59A0")]
		public GHGMFGLPDJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60D5950", Offset = "0x60D4D50", VA = "0x1860D5950", Slot = "14")]
		public override GameObject GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60D5970", Offset = "0x60D4D70", VA = "0x1860D5970", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, GameObject PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private class JJMEADAOBFM : Property<LIOFKEBOEFF, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x60D6B80", Offset = "0x60D5F80", VA = "0x1860D6B80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60D6B40", Offset = "0x60D5F40", VA = "0x1860D6B40")]
		public JJMEADAOBFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60D6AF0", Offset = "0x60D5EF0", VA = "0x1860D6AF0", Slot = "14")]
		public override Light GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60D6B10", Offset = "0x60D5F10", VA = "0x1860D6B10", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, Light PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class DFJFNANKJDK : Property<LIOFKEBOEFF, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x60D4A60", Offset = "0x60D3E60", VA = "0x1860D4A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x60D4A20", Offset = "0x60D3E20", VA = "0x1860D4A20")]
		public DFJFNANKJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x60D49D0", Offset = "0x60D3DD0", VA = "0x1860D49D0", Slot = "14")]
		public override Collider GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x60D49F0", Offset = "0x60D3DF0", VA = "0x1860D49F0", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, Collider PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	private class BGEJNNLHDNA : Property<LIOFKEBOEFF, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x60D42F0", Offset = "0x60D36F0", VA = "0x1860D42F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x60D42B0", Offset = "0x60D36B0", VA = "0x1860D42B0")]
		public BGEJNNLHDNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x60D4260", Offset = "0x60D3660", VA = "0x1860D4260", Slot = "14")]
		public override string GetValue(LIOFKEBOEFF MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60D4280", Offset = "0x60D3680", VA = "0x1860D4280", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF MKEGOGNADMP, string PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x60D5C60", Offset = "0x60D5060", VA = "0x1860D5C60")]
	public GLGPCCFJJKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal class BJNBNHGPBAK : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class OEJHJEMPJNL : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x60D7E10", Offset = "0x60D7210", VA = "0x1860D7E10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x60D7D20", Offset = "0x60D7120", VA = "0x1860D7D20")]
		public OEJHJEMPJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xE443C0", Offset = "0xE437C0", VA = "0x180E443C0", Slot = "14")]
		public override Data128 GetValue(SerializableGuid MKEGOGNADMP)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60D7D10", Offset = "0x60D7110", VA = "0x1860D7D10", Slot = "15")]
		public override void SetValue(SerializableGuid MKEGOGNADMP, Data128 PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60D4560", Offset = "0x60D3960", VA = "0x1860D4560")]
	public BJNBNHGPBAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class IOHEMABCEFM : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class GKGHHHLDCKN : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x60D5B10", Offset = "0x60D4F10", VA = "0x1860D5B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x60D5A20", Offset = "0x60D4E20", VA = "0x1860D5A20")]
		public GKGHHHLDCKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70", Slot = "14")]
		public override int GetValue(Data128 MKEGOGNADMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x60D5A10", Offset = "0x60D4E10", VA = "0x1860D5A10", Slot = "15")]
		public override void SetValue(Data128 MKEGOGNADMP, int PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	private class EOFPGAEJDGI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x60D5340", Offset = "0x60D4740", VA = "0x1860D5340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x60D5250", Offset = "0x60D4650", VA = "0x1860D5250")]
		public EOFPGAEJDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x60D5230", Offset = "0x60D4630", VA = "0x1860D5230", Slot = "14")]
		public override int GetValue(Data128 MKEGOGNADMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x60D5240", Offset = "0x60D4640", VA = "0x1860D5240", Slot = "15")]
		public override void SetValue(Data128 MKEGOGNADMP, int PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	private class LJEONLNEHGH : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x60D7250", Offset = "0x60D6650", VA = "0x1860D7250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x60D7160", Offset = "0x60D6560", VA = "0x1860D7160")]
		public LJEONLNEHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x15E3E40", Offset = "0x15E3240", VA = "0x1815E3E40", Slot = "14")]
		public override int GetValue(Data128 MKEGOGNADMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60D7150", Offset = "0x60D6550", VA = "0x1860D7150", Slot = "15")]
		public override void SetValue(Data128 MKEGOGNADMP, int PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class EOELEKPGPDP : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x60D5200", Offset = "0x60D4600", VA = "0x1860D5200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x60D5110", Offset = "0x60D4510", VA = "0x1860D5110")]
		public EOELEKPGPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x60D50F0", Offset = "0x60D44F0", VA = "0x1860D50F0", Slot = "14")]
		public override int GetValue(Data128 MKEGOGNADMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x60D5100", Offset = "0x60D4500", VA = "0x1860D5100", Slot = "15")]
		public override void SetValue(Data128 MKEGOGNADMP, int PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60D6580", Offset = "0x60D5980", VA = "0x1860D6580")]
	public IOHEMABCEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class AFIELCIBOAG : ContainerPropertyBag<LIOFKEBOEFF.PADPJOMPKCJ>
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class BGDJNPACNHD : Property<LIOFKEBOEFF.PADPJOMPKCJ, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x60D4230", Offset = "0x60D3630", VA = "0x1860D4230", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x60D41F0", Offset = "0x60D35F0", VA = "0x1860D41F0")]
		public BGDJNPACNHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x924BE0", Offset = "0x923FE0", VA = "0x180924BE0", Slot = "14")]
		public override Vector3 GetValue(LIOFKEBOEFF.PADPJOMPKCJ MKEGOGNADMP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60D41D0", Offset = "0x60D35D0", VA = "0x1860D41D0", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF.PADPJOMPKCJ MKEGOGNADMP, Vector3 PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	private class IEEKPPNNILI : Property<LIOFKEBOEFF.PADPJOMPKCJ, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x60D64E0", Offset = "0x60D58E0", VA = "0x1860D64E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x60D64A0", Offset = "0x60D58A0", VA = "0x1860D64A0")]
		public IEEKPPNNILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x60D6480", Offset = "0x60D5880", VA = "0x1860D6480", Slot = "14")]
		public override List<SerializableGuid> GetValue(LIOFKEBOEFF.PADPJOMPKCJ MKEGOGNADMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x60D6490", Offset = "0x60D5890", VA = "0x1860D6490", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF.PADPJOMPKCJ MKEGOGNADMP, List<SerializableGuid> PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60D3AF0", Offset = "0x60D2EF0", VA = "0x1860D3AF0")]
	public AFIELCIBOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class KPHBFOPLCMP : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	private class FEKBIMODJKP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x60D5720", Offset = "0x60D4B20", VA = "0x1860D5720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x60D56E0", Offset = "0x60D4AE0", VA = "0x1860D56E0")]
		public FEKBIMODJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60D56C0", Offset = "0x60D4AC0", VA = "0x1860D56C0", Slot = "14")]
		public override float GetValue(Vector3 MKEGOGNADMP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x60D56D0", Offset = "0x60D4AD0", VA = "0x1860D56D0", Slot = "15")]
		public override void SetValue(Vector3 MKEGOGNADMP, float PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class IAEPKLKKHFA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x60D6370", Offset = "0x60D5770", VA = "0x1860D6370", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x60D6330", Offset = "0x60D5730", VA = "0x1860D6330")]
		public IAEPKLKKHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x60D6310", Offset = "0x60D5710", VA = "0x1860D6310", Slot = "14")]
		public override float GetValue(Vector3 MKEGOGNADMP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x60D6320", Offset = "0x60D5720", VA = "0x1860D6320", Slot = "15")]
		public override void SetValue(Vector3 MKEGOGNADMP, float PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	private class EBONADCHKNL : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x60D4C50", Offset = "0x60D4050", VA = "0x1860D4C50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60D4C10", Offset = "0x60D4010", VA = "0x1860D4C10")]
		public EBONADCHKNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x19DD2C0", Offset = "0x19DC6C0", VA = "0x1819DD2C0", Slot = "14")]
		public override float GetValue(Vector3 MKEGOGNADMP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60D4C00", Offset = "0x60D4000", VA = "0x1860D4C00", Slot = "15")]
		public override void SetValue(Vector3 MKEGOGNADMP, float PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60D6EF0", Offset = "0x60D62F0", VA = "0x1860D6EF0")]
	public KPHBFOPLCMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class NPJNFMNIAGE : ContainerPropertyBag<LIOFKEBOEFF.DMHFOALKABN>
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	private class EFIDLMBIEIA : Property<LIOFKEBOEFF.DMHFOALKABN, LIOFKEBOEFF.PADPJOMPKCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x60D4E30", Offset = "0x60D4230", VA = "0x1860D4E30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x60D4DF0", Offset = "0x60D41F0", VA = "0x1860D4DF0")]
		public EFIDLMBIEIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x60D4D80", Offset = "0x60D4180", VA = "0x1860D4D80", Slot = "14")]
		public override LIOFKEBOEFF.PADPJOMPKCJ GetValue(LIOFKEBOEFF.DMHFOALKABN MKEGOGNADMP)
		{
			return default(LIOFKEBOEFF.PADPJOMPKCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x60D4DB0", Offset = "0x60D41B0", VA = "0x1860D4DB0", Slot = "15")]
		public override void SetValue(LIOFKEBOEFF.DMHFOALKABN MKEGOGNADMP, LIOFKEBOEFF.PADPJOMPKCJ PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x60D7BD0", Offset = "0x60D6FD0", VA = "0x1860D7BD0")]
	public NPJNFMNIAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal class KBLDPHIPBND : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	private class HJFFCIPFCCB : Property<RRObjectPrefabV2Data, GEIFGNPODDN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x60D6180", Offset = "0x60D5580", VA = "0x1860D6180", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool JMFGLNFGMFO
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x60D6140", Offset = "0x60D5540", VA = "0x1860D6140")]
		public HJFFCIPFCCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70", Slot = "14")]
		public override GEIFGNPODDN GetValue(RRObjectPrefabV2Data MKEGOGNADMP)
		{
			return default(GEIFGNPODDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x60D5A10", Offset = "0x60D4E10", VA = "0x1860D5A10", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data MKEGOGNADMP, GEIFGNPODDN PAHKKNONPEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x60D6C10", Offset = "0x60D6010", VA = "0x1860D6C10")]
	public KBLDPHIPBND()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x60D89A0", Offset = "0x60D7DA0", VA = "0x1860D89A0")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000126")]
public class MCHCGHGHNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MCHCGHGHNGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
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

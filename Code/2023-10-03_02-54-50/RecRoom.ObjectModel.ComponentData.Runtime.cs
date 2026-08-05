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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ADIGDOFHONJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode HNOACIAMBBB;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BNDFFDNBBCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public DFNOPHHBCLE KGHBCPBMLOD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly NDKLJGAGIKF<BNDFFDNBBCD> LMLHJGLFPJN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NCNEKGGDAOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EGKNCGOOAOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DFNOPHHBCLE
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
public struct OOHCPGCCANF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct EKHOCFLAJJO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity JDEFHCADEPK;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GCALHFAMCBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity KLGMOMIJPLM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GLAAIIHIAAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OOBFKGFEPMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity KLOAHFNCDKG;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IDIPJOFPLOJ : AGEJPMDBIMB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AOCFLIIJOIB CJHFLCNLACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(AOCFLIIJOIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HDLCBJFLAAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 NOKBJMMLANM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CECOBENMGIA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DMEPFANBBMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 OLILOFHPDPA;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NDKLJGAGIKF<FEBEEHEJHDP> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FEBEEHEJHDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 OLILOFHPDPA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly NDKLJGAGIKF<FEBEEHEJHDP> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CKFMNOKCJGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 LKCIMMKBPEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct PIAMOIBOFOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 KMINKGDFAJL;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CNDCPCFNPFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float MKLPEDLEGOE;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly NDKLJGAGIKF<CNDCPCFNPFM> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LPIJHFCLHDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float HBHHLMLPMKB;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly NDKLJGAGIKF<LPIJHFCLHDO> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OODPJIBGAPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 LONCGKEIHPG;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ABEOHNPCFAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public JEFEPIIEDML MHHPDFGAFLP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KJJHAAMFAKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JEFEPIIEDML MDPCKKIDFMA;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[HNDKOFBMDMB]
public struct PBFALPBCGND : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity MFFDEAINOPL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EOAPNGJPOPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PMILCHGDFCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LJFOOGEDKDB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct NHDEONJHFBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints EGOAAHMADAG;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EIKBIBBLPHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float FBILAPHGBFA;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly NDKLJGAGIKF<EIKBIBBLPHB> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CKMOKPFKJJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float EJBPAALJJOP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct BKMPMPDDIPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CEEJDKPEGDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int NBIFBGBILPE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBCE930", Offset = "0xBCD130", VA = "0x180BCE930")]
	public static CEEJDKPEGDG DAOGIJOJDNF(int IFKKLLBODIE)
	{
		return default(CEEJDKPEGDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HAMLHHEGOON : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody BCBKDKMIJHH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D503D0", Offset = "0x5D4EBD0", VA = "0x185D503D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HAMLHHEGOON()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HABNFDGKIHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IEDMNFBKPNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float FIJNHCMDOOO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly NDKLJGAGIKF<IEDMNFBKPNC> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FMKEEFPBCIF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public object PPIEGGHNEBD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D500E0", Offset = "0x5D4E8E0", VA = "0x185D500E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public FMKEEFPBCIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OPCNJIGGOOH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public object EJIDLMDMDGE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D564F0", Offset = "0x5D54CF0", VA = "0x185D564F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OPCNJIGGOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum JEFEPIIEDML
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum ACDLKJGOCEB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface APEBMOKBFMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMHLBAMKDBN(DFNOPHHBCLE CAKBDEGHLHG, DFNOPHHBCLE EKIOMDGDLDO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNGPJAHLMBE();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGGJMKCAEKK();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMMIKAOLEAA(bool DNFBHLJKIJE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KDNHPIACOBM();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GDOIBKOAKHI();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class IOOHIOGOJHA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public APEBMOKBFMO FHIIMPGGGLP;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D51590", Offset = "0x5D4FD90", VA = "0x185D51590", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IOOHIOGOJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JJBFDJDGGLK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly List<(KIBODBGDLMG nameHash, BKGNILJGMHF stableTypeHash, Type type)> AFJLMDPLIHC;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly List<(KIBODBGDLMG nameHash, BKGNILJGMHF stableTypeHash, Type type)> GDEKKIGOGKJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(KIBODBGDLMG previousNameHash, BKGNILJGMHF previousStableTypeHash, Type currentTypeName)> DNNEFFGPPJD;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, AIOGGNIJOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7A0", Offset = "0x5D4CFA0", VA = "0x185D4E7A0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
[HECCNGEMKIC]
public struct JOPODPIMFPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[OLEJBDNAHEC(1)]
	public quaternion LAEFAMPNPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[OLEJBDNAHEC(2)]
	public float3 CINCGMPJHMP;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly NDKLJGAGIKF<JOPODPIMFPC> LMLHJGLFPJN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x396EAA0", Offset = "0x396D2A0", VA = "0x18396EAA0")]
	public JOPODPIMFPC(quaternion LAEFAMPNPGA, float3 CINCGMPJHMP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F7B0", Offset = "0x5D4DFB0", VA = "0x185D4F7B0")]
	public static JOPODPIMFPC DAOGIJOJDNF(RigidTransform IFJLAEGOCNL)
	{
		return default(JOPODPIMFPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class EEBHCFLOAPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[HECCNGEMKIC]
public struct MNPDEFCLMAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[OLEJBDNAHEC(1)]
	public float MAJLENJGEMK;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly NDKLJGAGIKF<MNPDEFCLMAK> LMLHJGLFPJN;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[HECCNGEMKIC]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, AIOGGNIJOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[OLEJBDNAHEC(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7B0", Offset = "0x5D4CFB0", VA = "0x185D4E7B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GFKCCIGOOEN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, AIOGGNIJOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NDABGKCOOFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct AHDHIINBLLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[OLEJBDNAHEC(1)]
	public SerializableGuid PCPOCGCMPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[OLEJBDNAHEC(2)]
	public SerializableGuid GHAIFMOEMBF;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BDPMFBNFKFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity GLMBMLEJLIG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct ACIMGEPDKEI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity GLMBMLEJLIG;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DIDBKAFHJLB("Container", 0)]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
public struct LACAENCLGLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(1)]
	public IDGPFAGGINB NDPFDICGPIF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly NDKLJGAGIKF<LACAENCLGLJ> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BOEEAKCEOPG(0, 127)]
public enum IDGPFAGGINB
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
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CBDCMHBHJBG
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public enum KLCJNOHJDDI
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

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum FHPMOAJOEAL
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
	[Cpp2IlInjected.Address(RVA = "0x5D4EE80", Offset = "0x5D4D680", VA = "0x185D4EE80")]
	public static (KLCJNOHJDDI, FHPMOAJOEAL) JKJNKIHKHHL(this IDGPFAGGINB HAGBNKDONGH)
	{
		return default((KLCJNOHJDDI, FHPMOAJOEAL));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DIDBKAFHJLB("Container", 0)]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[HECCNGEMKIC]
public struct KALGBBEFMCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[OLEJBDNAHEC(1)]
	[POAGKDHMDOP(0)]
	public MKPMEJLHKCN ICDEBAKBONF;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NDKLJGAGIKF<KALGBBEFMCC> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[BOEEAKCEOPG(0, 2)]
public enum MKPMEJLHKCN
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
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DIDBKAFHJLB("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[HECCNGEMKIC]
public struct DGGKHCFPFHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[OLEJBDNAHEC(1)]
	[POAGKDHMDOP(0)]
	public FKFBMKLOGHG PPFELFEMNEO;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Flags]
[BOEEAKCEOPG(0, 15943)]
public enum FKFBMKLOGHG
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
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct INEBHCPEGPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct OLONNKHHNFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct EAAFBAKILOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct CEEONAHOKOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct COAJKOENODK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct EHFHLPAFEDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct OCIKBEMMPAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct DBGAIPEOFPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct KGKNMAEGOPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[DIDBKAFHJLB("Container", 0)]
[HECCNGEMKIC]
public struct PIDLLINPIJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[OLEJBDNAHEC(1)]
	[POAGKDHMDOP(0)]
	public float NHPMKDGJKEJ;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DIDBKAFHJLB("Container", 0)]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
public struct EFKLAGIBIOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(1)]
	public FixedString64Bytes BOBHOMKFHJB;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct BKNKPPEAGMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<DJFIOIPLCGP> BELHJIJANEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<Entity> NEJOAMJACDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private JobHandle LOGMOOGMKPB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GABGEKOCFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EA70", Offset = "0x5D4D270", VA = "0x185D4EA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EA20", Offset = "0x5D4D220", VA = "0x185D4EA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x433A9B0", Offset = "0x43391B0", VA = "0x18433A9B0")]
	public BKNKPPEAGMA(NativeList<DJFIOIPLCGP> BELHJIJANEK, NativeList<Entity> NEJOAMJACDP, JobHandle LOGMOOGMKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EB40", Offset = "0x5D4D340", VA = "0x185D4EB40")]
	public (Entity, NativeSlice<Entity>) HIKFKGDFODG(int PBGHCEIGALN)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EAE0", Offset = "0x5D4D2E0", VA = "0x185D4EAE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct DJFIOIPLCGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity KLOAHFNCDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int INDDJJFOAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int OOHKMCMOCLB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DHMCMFMECFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHGEBDAJNIA(bool ABIBFNBAHGD);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DIDBKAFHJLB("Container", 0)]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
public struct OJLNKKEBBOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(1)]
	public DAJKNGKKKDO KLLMOGJEDLD;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[BOEEAKCEOPG(0, 1)]
public enum DAJKNGKKKDO
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
[Cpp2IlInjected.Token(Token = "0x2000051")]
[MPAFAIDLMNH(1)]
public struct OBANPEKKDOK : IComparable<OBANPEKKDOK>, IEquatable<OBANPEKKDOK>, MPANBJGAAIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[KMMLCDMFOJN(1)]
	public uint KACCHOMNNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[KMMLCDMFOJN(2)]
	public uint AHIOOKDOBJH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint DADJALNFPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D55C10", Offset = "0x5D54410", VA = "0x185D55C10")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D56090", Offset = "0x5D54890", VA = "0x185D56090")]
	public OBANPEKKDOK(int KACCHOMNNFI, int MAEILDEJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D56090", Offset = "0x5D54890", VA = "0x185D56090")]
	public OBANPEKKDOK(uint KACCHOMNNFI, uint MAEILDEJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D55E60", Offset = "0x5D54660", VA = "0x185D55E60")]
	public OBANPEKKDOK JIHMKCIFJLO(int INDDJJFOAAH = 1)
	{
		return default(OBANPEKKDOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D55ED0", Offset = "0x5D546D0", VA = "0x185D55ED0")]
	public OBANPEKKDOK JKHJJEJNIED(int INDDJJFOAAH = 1)
	{
		return default(OBANPEKKDOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D55DE0", Offset = "0x5D545E0", VA = "0x185D55DE0")]
	public static OBANPEKKDOK HNPKNFBLBOE(OBANPEKKDOK MANEBEMOKEE, OBANPEKKDOK HOCFNIKGEJF)
	{
		return default(OBANPEKKDOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D55C40", Offset = "0x5D54440", VA = "0x185D55C40")]
	private static uint DENIJBHLCEP(uint FABNAGLLOKN, uint FCOICCIGANJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D55C20", Offset = "0x5D54420", VA = "0x185D55C20", Slot = "4")]
	public int CompareTo(OBANPEKKDOK GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D55C70", Offset = "0x5D54470", VA = "0x185D55C70", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D55FB0", Offset = "0x5D547B0", VA = "0x185D55FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D55D00", Offset = "0x5D54500", VA = "0x185D55D00", Slot = "5")]
	public bool Equals(OBANPEKKDOK GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D55D90", Offset = "0x5D54590", VA = "0x185D55D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D55F40", Offset = "0x5D54740", VA = "0x185D55F40", Slot = "6")]
	public void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D55D20", Offset = "0x5D54520", VA = "0x185D55D20", Slot = "7")]
	public void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x22308C0", Offset = "0x222F0C0", VA = "0x1822308C0")]
	public static bool PEFPHNLEPOM(OBANPEKKDOK MANEBEMOKEE, OBANPEKKDOK HOCFNIKGEJF)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[MPAFAIDLMNH(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[KMMLCDMFOJN(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[KMMLCDMFOJN(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[KMMLCDMFOJN(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[KMMLCDMFOJN(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[MPAFAIDLMNH(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, MPANBJGAAIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[KMMLCDMFOJN(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public static SerializableGuid DAOGIJOJDNF(Guid ACBJLDAEBBN)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BC0", Offset = "0x5D563C0", VA = "0x185D57BC0", Slot = "4")]
		public bool Equals(SerializableGuid GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BA0", Offset = "0x5D563A0", VA = "0x185D57BA0", Slot = "5")]
		public int CompareTo(SerializableGuid GHNNCJBDHKF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D57C70", Offset = "0x5D56470", VA = "0x185D57C70", Slot = "6")]
		public void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5D57BF0", Offset = "0x5D563F0", VA = "0x185D57BF0", Slot = "7")]
		public void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D57D30", Offset = "0x5D56530", VA = "0x185D57D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
[HECCNGEMKIC]
public struct CAECOJCHBDA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct CBLLAOHDFJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[OLEJBDNAHEC(1)]
	public Entity HBMBMELELPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[OLEJBDNAHEC(2)]
	public bool JGCDAINEPGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
[HECCNGEMKIC]
public struct KLJELOLKBCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[OLEJBDNAHEC(1)]
	public IGNLKLNFGNN NOIAGANOPLL;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BOEEAKCEOPG(0, 4)]
public enum IGNLKLNFGNN
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
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
[HECCNGEMKIC]
public struct LPLEILGJPOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[OLEJBDNAHEC(1)]
	public Entity HBMBMELELPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[OLEJBDNAHEC(2)]
	public bool CAHLOIBNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[OLEJBDNAHEC(3)]
	public float OMCAPCMGDOP;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[HECCNGEMKIC]
public struct IGBMEPCGFBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[OLEJBDNAHEC(1)]
	public bool CFFFGOJOPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[OLEJBDNAHEC(2)]
	public bool CAHLOIBNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[OLEJBDNAHEC(3)]
	public float OHGIGMABAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[OLEJBDNAHEC(4)]
	public float OIBFHHMDNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[OLEJBDNAHEC(5)]
	public float PFCKGDLJEGO;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct LJDLOFJDLPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[OLEJBDNAHEC(1)]
	public bool CFFFGOJOPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[OLEJBDNAHEC(2)]
	public bool CAHLOIBNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[OLEJBDNAHEC(3)]
	public float OMCAPCMGDOP;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, AIOGGNIJOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7A0", Offset = "0x5D4CFA0", VA = "0x185D4E7A0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[HECCNGEMKIC]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, AIOGGNIJOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[OLEJBDNAHEC(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, AIOGGNIJOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct PAOOJBEFDMI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface AIOGGNIJOCI
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Entity DKHAEHLCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct INEBGHBLHLO<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static readonly bool NLJMBAJEDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public uint MCFGKIICECH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	private static bool MMOCFBPCFGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
[HECCNGEMKIC]
[DIDBKAFHJLB("Light", 0)]
public struct GEFCNBBEBDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(1)]
	public bool ICGNKEDIKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(2)]
	public float CLHMCLCPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[OLEJBDNAHEC(3)]
	[POAGKDHMDOP(0)]
	public float FCJNLPFLEOK;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[HECCNGEMKIC]
[DIDBKAFHJLB("Light", 0)]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
public struct ILPDHGDOIBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[OLEJBDNAHEC(1)]
	[POAGKDHMDOP(0)]
	public float CJACNGNLACF;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.TypeVersion(2)]
public struct PDCKJJIIJLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public uint LKAMMHGCBOL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D566A0", Offset = "0x5D54EA0", VA = "0x185D566A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[HECCNGEMKIC]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[KMMLCDMFOJN(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct DBNNJCPEJLD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public int AJEJCPPFLLB;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MFPKLNCMNOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public GCHandle DGPMJJPGHOD;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BOEEAKCEOPG(0, 4)]
public enum KNMKONHBHPP
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
public struct MAENMMCDCDI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct IMCIPIEJJCB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int AJEJCPPFLLB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct JECGJNKNOAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct CGOBDCNFDCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GJNPBLECJMD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[HECCNGEMKIC]
[DIDBKAFHJLB("Object", 0)]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[TypeManager.TypeVersion(3)]
public struct OCPFLEPNLDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[OLEJBDNAHEC(2)]
	public MOOLPKGIFCP KCJHKHAEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[OLEJBDNAHEC(3)]
	[POAGKDHMDOP(0)]
	public ANBGLIGJGHH OBCLCDPCIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(5)]
	public MGGMMJMNCIF MGMIBBJCOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[KMMLCDMFOJN(4)]
	public CBGIBPDHIAB PPFELFEMNEO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public static readonly NDKLJGAGIKF<OCPFLEPNLDH> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class JDDOHCIKOKG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D516E0", Offset = "0x5D4FEE0", VA = "0x185D516E0")]
	public static void ABNCEPDOIJI(this CBGIBPDHIAB PPFELFEMNEO, EPPPDPOLJMF BCDPMBAEKKB, bool JOHPJDFABPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D51720", Offset = "0x5D4FF20", VA = "0x185D51720")]
	public static bool LMIFJLNNLCP(this CBGIBPDHIAB PPFELFEMNEO, EPPPDPOLJMF BCDPMBAEKKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D51710", Offset = "0x5D4FF10", VA = "0x185D51710")]
	public static CBGIBPDHIAB BOHGNJHPEOO(this EPPPDPOLJMF BCDPMBAEKKB)
	{
		return default(CBGIBPDHIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D516C0", Offset = "0x5D4FEC0", VA = "0x185D516C0")]
	public static void ABNCEPDOIJI(this ANBGLIGJGHH PPFELFEMNEO, ANBGLIGJGHH BDGFIKIEHCP, bool JOHPJDFABPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5C78240", Offset = "0x5C76A40", VA = "0x185C78240")]
	public static bool LMIFJLNNLCP(this ANBGLIGJGHH PPFELFEMNEO, ANBGLIGJGHH BCDPMBAEKKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public enum EPPPDPOLJMF
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
[BOEEAKCEOPG(0, 16383)]
[Flags]
public enum CBGIBPDHIAB
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
[BOEEAKCEOPG(0, 3)]
[Flags]
public enum ANBGLIGJGHH
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
[BOEEAKCEOPG(0, 4)]
[HACKGCLNBCK]
public enum MGGMMJMNCIF
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
public class HACKGCLNBCK : GDCPDFHJCNB
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D50300", Offset = "0x5D4EB00", VA = "0x185D50300", Slot = "7")]
	public override string FKHKJNCPLEN(string CGJOJNFDJBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public HACKGCLNBCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[MPAFAIDLMNH(1)]
public struct MOOLPKGIFCP : MPANBJGAAIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	[KMMLCDMFOJN(1)]
	public bool ICGNKEDIKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	[KMMLCDMFOJN(2)]
	public float3 DMDPONFAFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[KMMLCDMFOJN(3)]
	public float3 NIHDKDGOLIE;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public static readonly NDKLJGAGIKF<MOOLPKGIFCP> LMLHJGLFPJN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5D556E0", Offset = "0x5D53EE0", VA = "0x185D556E0", Slot = "5")]
	public void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D55750", Offset = "0x5D53F50", VA = "0x185D55750", Slot = "4")]
	public void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct LDKKCKMEIHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct FHHNNJABNLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct IEMPKHEAJNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct BPEGDGOFKMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public FixedString32Bytes BOBHOMKFHJB;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[HNDKOFBMDMB]
public struct CJPIOKGGHAM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Entity NJBFIEAFGFF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static CJPIOKGGHAM DAOGIJOJDNF(Entity IFKKLLBODIE)
	{
		return default(CJPIOKGGHAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
[HECCNGEMKIC]
public struct KCCGLNLKGEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[OLEJBDNAHEC(1)]
	public Entity LIONGCCKOFE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static KCCGLNLKGEL DAOGIJOJDNF(Entity MFFDEAINOPL)
	{
		return default(KCCGLNLKGEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct KDJGMGHCCEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Entity MFFDEAINOPL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static KDJGMGHCCEG DAOGIJOJDNF(Entity MFFDEAINOPL)
	{
		return default(KDJGMGHCCEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
internal struct PJJMGHMIMMI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Entity JFIBAOBIHBA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static PJJMGHMIMMI DAOGIJOJDNF(Entity MFFDEAINOPL)
	{
		return default(PJJMGHMIMMI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
internal struct BNAJNPLELMH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[BOEEAKCEOPG(0, 2)]
public enum IJCEPGAJEMC
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
[Cpp2IlInjected.Token(Token = "0x200007F")]
[HECCNGEMKIC]
[DIDBKAFHJLB("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct BJCLJCIABOJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[OLEJBDNAHEC(1)]
	[POAGKDHMDOP(0)]
	public float CHMBNJGIDLG;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static readonly NDKLJGAGIKF<BJCLJCIABOJ> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
[HECCNGEMKIC]
public struct HFHNHKEAOML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[OLEJBDNAHEC(1)]
	public DFMGIJCAPCL CFOIOJGOMCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[BOEEAKCEOPG(-1, 38)]
public enum DFMGIJCAPCL
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
[Cpp2IlInjected.Token(Token = "0x2000082")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct NIBGBNOGEJK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[Flags]
	[BOEEAKCEOPG(0, 7)]
	public enum AINLCGKGFIG
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
	[OLEJBDNAHEC(1)]
	public AINLCGKGFIG PPFELFEMNEO;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static readonly NDKLJGAGIKF<NIBGBNOGEJK> LMLHJGLFPJN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MGPMPIOANJL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D55A60", Offset = "0x5D54260", VA = "0x185D55A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LHFKAJFFDBK
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5D55A70", Offset = "0x5D54270", VA = "0x185D55A70")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct JEDOMDNBLKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[OLEJBDNAHEC(1)]
	public IJCEPGAJEMC CFOIOJGOMCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[MPAFAIDLMNH(1)]
public struct BHBLOOFPBII : MPANBJGAAIE
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[Flags]
	[BOEEAKCEOPG(0, 7)]
	public enum JJJFOAMHEMP
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
	[KMMLCDMFOJN(1)]
	public float OPKMOFPHPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[KMMLCDMFOJN(2)]
	public int FIMHHDCJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[KMMLCDMFOJN(3)]
	public JJJFOAMHEMP PPFELFEMNEO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ADNJIGPOAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E900", Offset = "0x5D4D100", VA = "0x185D4E900")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E9A0", Offset = "0x5D4D1A0", VA = "0x185D4E9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EMDMJFJIBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E910", Offset = "0x5D4D110", VA = "0x185D4E910")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E8E0", Offset = "0x5D4D0E0", VA = "0x185D4E8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool HOCJIPCBGLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E880", Offset = "0x5D4D080", VA = "0x185D4E880")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E980", Offset = "0x5D4D180", VA = "0x185D4E980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E890", Offset = "0x5D4D090", VA = "0x185D4E890", Slot = "5")]
	public void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E920", Offset = "0x5D4D120", VA = "0x185D4E920", Slot = "4")]
	public void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[HNDKOFBMDMB]
internal struct BCBKIBEKOLB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Entity BNFENHFMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public int ADMJKDLHPCI;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[HECCNGEMKIC]
public struct GFMNKPOPEDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[OLEJBDNAHEC(1)]
	public OBANPEKKDOK AKHAMFLNNCP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static GFMNKPOPEDJ DAOGIJOJDNF(OBANPEKKDOK IFKKLLBODIE)
	{
		return default(GFMNKPOPEDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct KFEMMDMNKPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[OLEJBDNAHEC(1)]
	public Entity CPJMAEMAJBC;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal struct OFNMDFMFFDD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Entity CPJMAEMAJBC;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct HHICHINIONL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[OLEJBDNAHEC(1)]
	public float3 CINCGMPJHMP;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly NDKLJGAGIKF<HHICHINIONL> LMLHJGLFPJN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7800", Offset = "0x1EF6000", VA = "0x181EF7800")]
	public static HHICHINIONL DAOGIJOJDNF(float3 IFKKLLBODIE)
	{
		return default(HHICHINIONL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
[HECCNGEMKIC]
public struct ABALHOBJHFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[OLEJBDNAHEC(1)]
	public quaternion LAEFAMPNPGA;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public static readonly NDKLJGAGIKF<ABALHOBJHFB> LMLHJGLFPJN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
	public static ABALHOBJHFB DAOGIJOJDNF(quaternion IFKKLLBODIE)
	{
		return default(ABALHOBJHFB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct LNBJNLHDKEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[OLEJBDNAHEC(1)]
	public float3 HJFHFDDPJCF;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public static readonly NDKLJGAGIKF<LNBJNLHDKEI> LMLHJGLFPJN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7800", Offset = "0x1EF6000", VA = "0x181EF7800")]
	public static LNBJNLHDKEI DAOGIJOJDNF(float3 IFKKLLBODIE)
	{
		return default(LNBJNLHDKEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
[HECCNGEMKIC]
public struct EMEKAFKHOIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[OLEJBDNAHEC(1)]
	public BHBLOOFPBII HIKDFDIFDNM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct HHEBCBPIENG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct EJMDHGCCAIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public uint MCFGKIICECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public int NCBGCBBGPGD;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x978550", Offset = "0x976D50", VA = "0x180978550")]
	public EJMDHGCCAIO(uint GGBHIHJCNHB, int NAJMEJHJKNO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct OCKOFAJFIIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct KHDHKLNEPND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct BIHBBACLKHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct GHOJGMELLCB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct HCBJEACLEKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct EFJJBLEGEEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct IGIDHFJMFBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct INIKAIBJCLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
internal struct CFHNANMKDCI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct FMHLDAJNHJO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal struct FMEOOIAHHNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct GGOOCLMNPJO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct ANFPNJJGGOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct IEEBLIFAOOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct CGPMMADFPGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct CMDEFHONFKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct OFCADHHDENG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct ALNGPPODCGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal struct LGJADBGHKHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct FCHKDKPAOKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct JDMBKMIENGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal struct BLJPEOHBLJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal struct EOBJNPFKBPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct KOAHPBGCJNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[KMMLCDMFOJN(1)]
	public PFHIKJINKDG OJAHFIICKFC;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static readonly NDKLJGAGIKF<KOAHPBGCJNE> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public enum PFHIKJINKDG : uint
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct IDEKPLNFBNE : IComponentData, IComparable<IDEKPLNFBNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public int CFEEAEFBAJP;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x161C8C0", Offset = "0x161B0C0", VA = "0x18161C8C0", Slot = "4")]
	public int CompareTo(IDEKPLNFBNE GHNNCJBDHKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[HECCNGEMKIC]
public struct MIOJLMEFCJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[OLEJBDNAHEC(2)]
	public bool EOJHODDJIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[OLEJBDNAHEC(3)]
	public bool GAAHLLKDMCI;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly NDKLJGAGIKF<MIOJLMEFCJI> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[HECCNGEMKIC]
public struct BMEILCMKHOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[OLEJBDNAHEC(1)]
	public bool BKLDODPPELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[OLEJBDNAHEC(2)]
	public byte HIJHGEIDDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[OLEJBDNAHEC(3)]
	public short ADIKJGEDPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[OLEJBDNAHEC(4)]
	public ushort MONKPHFIFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[OLEJBDNAHEC(5)]
	public int MLJFPIBOOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[OLEJBDNAHEC(6)]
	public uint LLBPMHHEKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[OLEJBDNAHEC(7)]
	public long OKKGDNGBNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[OLEJBDNAHEC(8)]
	public ulong HAGHJCHCNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[OLEJBDNAHEC(9)]
	public float JCMFBHJCOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[OLEJBDNAHEC(10)]
	public double EOMCOBCIBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[OLEJBDNAHEC(11)]
	public ACBIOGMEBBC APHMEMGEOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[OLEJBDNAHEC(12)]
	public ICLHIPIMIIE KEFAMIBHMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[OLEJBDNAHEC(13)]
	public OMBEIBEBFGP FBIEFLDHEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[OLEJBDNAHEC(14)]
	public HDIMIEMPGOL LBIKKCDAKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[OLEJBDNAHEC(15)]
	public BKMFCKEBFNJ GCLPOBBJOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[OLEJBDNAHEC(16)]
	public MEJKLJGLBGK OKBLPDKKJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[OLEJBDNAHEC(17)]
	public FPFKDPONJFO OIOABMGNHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[OLEJBDNAHEC(18)]
	public HECPBNEPBCL OMENDBJDMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[OLEJBDNAHEC(20)]
	public Quaternion MGLGLHHHIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[OLEJBDNAHEC(22)]
	public Vector3 GKFKGGNHENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[OLEJBDNAHEC(23)]
	public Vector4 DJLCFFENLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[OLEJBDNAHEC(40)]
	public Entity LHLCPKNIJOE;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public enum ACBIOGMEBBC : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum ICLHIPIMIIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum OMBEIBEBFGP : short
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public enum HDIMIEMPGOL : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum BKMFCKEBFNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum MEJKLJGLBGK : uint
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum FPFKDPONJFO : long
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum HECPBNEPBCL : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	[HECCNGEMKIC]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	[HECCNGEMKIC]
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
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class BPFKIKLLKIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int BGGDIKOMABC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public int DGFDHHOIGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public GameObject AAAOHJGLLEG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BPFKIKLLKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class EBMOMEFBDHI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public struct AAAKDCKOBLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector3 HMBPIBICAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public List<SerializableGuid> DFLMLDNLHOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class BMALMAHEBEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public AAAKDCKOBLA KJENOBPLJIO;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BMALMAHEBEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public SerializableGuid EDPNIIBPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public List<int> HAONMNMJGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public List<AAAKDCKOBLA> CJMNHOLCMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public List<BMALMAHEBEB> NFMEMEBGPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public GameObject AAAOHJGLLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Light DILDNBCMPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Collider AFMGELLDLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public string EENFCALJNDB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public EBMOMEFBDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct NGEJJJHGHFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[OLEJBDNAHEC(1)]
	public float3 HBBPPBMKDEK;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public static readonly NDKLJGAGIKF<NGEJJJHGHFP> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
[HECCNGEMKIC]
public struct EBOGGEGJLCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[OLEJBDNAHEC(1)]
	public quaternion LAEFAMPNPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	[OLEJBDNAHEC(2)]
	public float3 CINCGMPJHMP;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public static readonly NDKLJGAGIKF<EBOGGEGJLCM> LMLHJGLFPJN;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x396EAA0", Offset = "0x396D2A0", VA = "0x18396EAA0")]
	public EBOGGEGJLCM(quaternion LAEFAMPNPGA, float3 CINCGMPJHMP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F7B0", Offset = "0x5D4DFB0", VA = "0x185D4F7B0")]
	public static RigidTransform DAOGIJOJDNF(EBOGGEGJLCM AECGBIELJCP)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F7B0", Offset = "0x5D4DFB0", VA = "0x185D4F7B0")]
	public static EBOGGEGJLCM DAOGIJOJDNF(RigidTransform IFJLAEGOCNL)
	{
		return default(EBOGGEGJLCM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class HBAFIGMCJMO
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public struct NKDFIDPGKJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public float4x4 IKBNPIHEHFL;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public static readonly NDKLJGAGIKF<NKDFIDPGKJD> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct LMGGABKGAOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public float4x4 JBBMMCAIOID;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly NDKLJGAGIKF<LMGGABKGAOO> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct GJGBGBOCFHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[OLEJBDNAHEC(1)]
	public float MAJLENJGEMK;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public static readonly NDKLJGAGIKF<GJGBGBOCFHG> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct GNDAAOKLOHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int JGEPKDKBCOI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ADMJKDLHPCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D502F0", Offset = "0x5D4EAF0", VA = "0x185D502F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D502E0", Offset = "0x5D4EAE0", VA = "0x185D502E0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[HECCNGEMKIC]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct ODFBOGLDGEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[OLEJBDNAHEC(1)]
	public AGNHPKIPNNK PJKAGMENCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[OLEJBDNAHEC(2)]
	public PLFFMIIPOHA OCMIJDDFGLG;
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[BOEEAKCEOPG(0, 1)]
[Flags]
public enum AGNHPKIPNNK
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
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[BOEEAKCEOPG(-2, 2)]
public enum PLFFMIIPOHA
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
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct ILDJIOANNPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float3 LAIPFLKJGHH;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly NDKLJGAGIKF<ILDJIOANNPB> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct HDHEDGENDAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float3 OBAACBLACLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public quaternion AHLHKGGFBGH;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static readonly NDKLJGAGIKF<HDHEDGENDAL> LMLHJGLFPJN;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D50DC0", Offset = "0x5D4F5C0", VA = "0x185D50DC0")]
	public float3 DJIHKBNILGE(float3 BFCEGFNGHJA)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class JCPELDAMMPM
{
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct NJFKOEEMFDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float NCGDDONCOJI;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly NDKLJGAGIKF<NJFKOEEMFDB> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[BOEEAKCEOPG(1000, 8000)]
public enum KNBFLDNEILM
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
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public static class EOMFDBKKLKC
{
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal enum NNHPHPECPHH
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
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal static class ELGDDBMCKFA
{
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[BOEEAKCEOPG(0, 9)]
public enum GALEJKINAHP
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
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class NAGIIMEEHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D55840", Offset = "0x5D54040", VA = "0x185D55840")]
	public static bool GDMJCBNAFEM(this GALEJKINAHP AJNPDAOMCIO)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	[HECCNGEMKIC]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public KNBFLDNEILM prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class MMFDDIILMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D555C0", Offset = "0x5D53DC0", VA = "0x185D555C0")]
	public static bool MBJPLBKGCLI(this KNBFLDNEILM BJKOKHNAAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D555E0", Offset = "0x5D53DE0", VA = "0x185D555E0")]
	public static string NEHKJOKMJGP(this KNBFLDNEILM BJKOKHNAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D55630", Offset = "0x5D53E30", VA = "0x185D55630")]
	public static GALEJKINAHP NJLDOJCCPCF(this KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(GALEJKINAHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D55650", Offset = "0x5D53E50", VA = "0x185D55650")]
	internal static NNHPHPECPHH OOCPCDDPEFF(this GALEJKINAHP AJNPDAOMCIO)
	{
		return default(NNHPHPECPHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D55660", Offset = "0x5D53E60", VA = "0x185D55660")]
	internal static NNHPHPECPHH OOCPCDDPEFF(this KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(NNHPHPECPHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public static class HBALFNOFNPB
{
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private static readonly Dictionary<KNBFLDNEILM, string> IANHFGBEFFN;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D504D0", Offset = "0x5D4ECD0", VA = "0x185D504D0")]
	public static string FHOFJMKHDEG(this KNBFLDNEILM BJKOKHNAAID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[BOEEAKCEOPG(int.MinValue, int.MaxValue)]
public enum DGNJHIEONCC
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
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[BOEEAKCEOPG(-1, 31)]
public enum JBMDKADPDLM
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
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[HECCNGEMKIC]
[DIDBKAFHJLB("Visual", 0)]
public struct GJFENHOJJBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	[OLEJBDNAHEC(1)]
	[POAGKDHMDOP(0)]
	public DGNJHIEONCC JFJPGCGPBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(2)]
	public JBMDKADPDLM LGHJCFHBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(3)]
	public float ALLJFNOBLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	[OLEJBDNAHEC(4)]
	[POAGKDHMDOP(0)]
	public Vector3 ADJMHBADAOI;
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DIDBKAFHJLB("Container", 0)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[KBHOCGJHIDN(2613756846563002039uL, 6372660366488563574uL)]
[NMKBPLCCMNH]
public struct MFJHFIDGGMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	[OLEJBDNAHEC(1)]
	[POAGKDHMDOP(0)]
	public LDAOJKGJIGN KPLGKPHKMAN;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[Flags]
[BOEEAKCEOPG(0, 15)]
public enum LDAOJKGJIGN
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
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[KBHOCGJHIDN(9804513251708000208uL, 10903582988135044631uL)]
[NMKBPLCCMNH]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct NCAJKPBGCJM : IComponentData, IEquatable<NCAJKPBGCJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	[OLEJBDNAHEC(1)]
	public FixedString64Bytes BOBHOMKFHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	[OLEJBDNAHEC(2)]
	public MKPMEJLHKCN ICDEBAKBONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[OLEJBDNAHEC(3)]
	public LDAOJKGJIGN KPLGKPHKMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[OLEJBDNAHEC(4)]
	public DAJKNGKKKDO KLLMOGJEDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	[OLEJBDNAHEC(5)]
	public FKFBMKLOGHG PPFELFEMNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	[OLEJBDNAHEC(6)]
	public float NHPMKDGJKEJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D55850", Offset = "0x5D54050", VA = "0x185D55850", Slot = "4")]
	public bool Equals(NCAJKPBGCJM GHNNCJBDHKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[KBHOCGJHIDN(1213445203937950283uL, 119653618660684511uL)]
[NMKBPLCCMNH]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct NIJEEEKANFM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[MPAFAIDLMNH(1)]
	public struct MAGFGMLJDGM : MPANBJGAAIE, IEquatable<MAGFGMLJDGM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		[KMMLCDMFOJN(1)]
		public int LJHGKCLAIHG;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D552B0", Offset = "0x5D53AB0", VA = "0x185D552B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D55210", Offset = "0x5D53A10", VA = "0x185D55210", Slot = "0")]
		public override bool Equals(object ELOCHLKHPBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x160F1B0", Offset = "0x160D9B0", VA = "0x18160F1B0", Slot = "6")]
		public bool Equals(MAGFGMLJDGM GHNNCJBDHKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x161C950", Offset = "0x161B150", VA = "0x18161C950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D55290", Offset = "0x5D53A90", VA = "0x185D55290", Slot = "5")]
		public void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D55310", Offset = "0x5D53B10", VA = "0x185D55310", Slot = "4")]
		public void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	[OLEJBDNAHEC(1)]
	public MAGFGMLJDGM KCBOBCGPIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public GCHandle AOCDGMDEJCJ;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[NMKBPLCCMNH]
[KBHOCGJHIDN(218523523639012570uL, 15191719635551116065uL)]
public struct KKGKOHGCBAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private uint EKELHGABAOE;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[NMKBPLCCMNH]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[KBHOCGJHIDN(9898405628982320166uL, 2023375009558162791uL)]
public struct FCLEDNNGGHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[OLEJBDNAHEC(1)]
	public CBGIBPDHIAB PPFELFEMNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[OLEJBDNAHEC(2)]
	public MOOLPKGIFCP KCJHKHAEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(3)]
	public bool LIHPEJEJDPH;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly NDKLJGAGIKF<FCLEDNNGGHE> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[KBHOCGJHIDN(9807788745867066359uL, 15168486114979071194uL)]
[NMKBPLCCMNH]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct BNEAPCHKGLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[OLEJBDNAHEC(1)]
	public CBGIBPDHIAB PPFELFEMNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[OLEJBDNAHEC(2)]
	public MOOLPKGIFCP KCJHKHAEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[POAGKDHMDOP(0)]
	[OLEJBDNAHEC(3)]
	public bool LIHPEJEJDPH;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly NDKLJGAGIKF<BNEAPCHKGLI> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[KBHOCGJHIDN(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[NMKBPLCCMNH]
public struct KDKBMODOHMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[KMMLCDMFOJN(1)]
	public CBGIBPDHIAB PPFELFEMNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[OLEJBDNAHEC(2)]
	public MOOLPKGIFCP KCJHKHAEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[OLEJBDNAHEC(3)]
	[POAGKDHMDOP(0)]
	public ANBGLIGJGHH OBCLCDPCIFI;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly NDKLJGAGIKF<KDKBMODOHMM> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[NMKBPLCCMNH]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[KBHOCGJHIDN(12226092714547765037uL, 15970362445488810630uL)]
public struct PDIICNMBAPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[OLEJBDNAHEC(2)]
	public MOOLPKGIFCP KCJHKHAEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[OLEJBDNAHEC(3)]
	[POAGKDHMDOP(0)]
	public ANBGLIGJGHH OBCLCDPCIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[KMMLCDMFOJN(4)]
	public CBGIBPDHIAB PPFELFEMNEO;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly NDKLJGAGIKF<PDIICNMBAPL> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[NMKBPLCCMNH]
[KBHOCGJHIDN(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct HBFFLHDCODL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public int FHFOIPGMBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[OLEJBDNAHEC(2)]
	public bool EOJHODDJIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[OLEJBDNAHEC(3)]
	public bool GAAHLLKDMCI;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly NDKLJGAGIKF<HBFFLHDCODL> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[NMKBPLCCMNH]
[KBHOCGJHIDN(5861057081882613294uL, 13746475565109640919uL)]
public struct DFPENOAIKFA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[BOEEAKCEOPG(0, 1)]
	public enum IKOEAOCPAEK
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
	[OLEJBDNAHEC(1)]
	public IKOEAOCPAEK PBHAHKKOCHG;
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[KBHOCGJHIDN(14327281633525910712uL, 2559857777606771911uL)]
[NMKBPLCCMNH]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
public struct IFENFPOMENO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[OLEJBDNAHEC(1)]
	public KNBFLDNEILM FGDLEJGCDOG;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[KBHOCGJHIDN(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[NMKBPLCCMNH]
public struct DKDOAGNPCEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[OLEJBDNAHEC(1)]
	public KNBFLDNEILM FGDLEJGCDOG;
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[KBHOCGJHIDN(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[NMKBPLCCMNH]
public struct BBINBHKLFFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public GALEJKINAHP AJNPDAOMCIO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[NMKBPLCCMNH]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[KBHOCGJHIDN(17667479821163689808uL, 11946378475791123970uL)]
public struct BBFNDHODNEC : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : FNNEAFKGECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D57D40", Offset = "0x5D56540", VA = "0x185D57D40", Slot = "4")]
		public sealed override void MGHEMDEKAOB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal class EJBOFCOJNLP : ContainerPropertyBag<HAMLHHEGOON>
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	private class IJAFEEIHFFI : Property<HAMLHHEGOON, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5D513F0", Offset = "0x5D4FBF0", VA = "0x185D513F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D513B0", Offset = "0x5D4FBB0", VA = "0x185D513B0")]
		public IJAFEEIHFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7C0", Offset = "0x5D4CFC0", VA = "0x185D4E7C0", Slot = "14")]
		public override Rigidbody GetValue(HAMLHHEGOON DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7E0", Offset = "0x5D4CFE0", VA = "0x185D4E7E0", Slot = "15")]
		public override void SetValue(HAMLHHEGOON DJDFFLPPHHA, Rigidbody IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FBD0", Offset = "0x5D4E3D0", VA = "0x185D4FBD0")]
	public EJBOFCOJNLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
internal class HHIEGHDBINN : ContainerPropertyBag<FMKEEFPBCIF>
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	private class BBDNGKMCBGM : Property<FMKEEFPBCIF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5D4E850", Offset = "0x5D4D050", VA = "0x185D4E850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E810", Offset = "0x5D4D010", VA = "0x185D4E810")]
		public BBDNGKMCBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7C0", Offset = "0x5D4CFC0", VA = "0x185D4E7C0", Slot = "14")]
		public override object GetValue(FMKEEFPBCIF DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7E0", Offset = "0x5D4CFE0", VA = "0x185D4E7E0", Slot = "15")]
		public override void SetValue(FMKEEFPBCIF DJDFFLPPHHA, object IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5D51130", Offset = "0x5D4F930", VA = "0x185D51130")]
	public HHIEGHDBINN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
internal class OLMJDLNMJAN : ContainerPropertyBag<OPCNJIGGOOH>
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class FMADLDEKJLJ : Property<OPCNJIGGOOH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5D500B0", Offset = "0x5D4E8B0", VA = "0x185D500B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D50070", Offset = "0x5D4E870", VA = "0x185D50070")]
		public FMADLDEKJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7C0", Offset = "0x5D4CFC0", VA = "0x185D4E7C0", Slot = "14")]
		public override object GetValue(OPCNJIGGOOH DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7E0", Offset = "0x5D4CFE0", VA = "0x185D4E7E0", Slot = "15")]
		public override void SetValue(OPCNJIGGOOH DJDFFLPPHHA, object IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D563A0", Offset = "0x5D54BA0", VA = "0x185D563A0")]
	public OLMJDLNMJAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class ODFOAECFNOM : ContainerPropertyBag<IOOHIOGOJHA>
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	private class OPCBKIANLCE : Property<IOOHIOGOJHA, APEBMOKBFMO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x5D564C0", Offset = "0x5D54CC0", VA = "0x185D564C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D56480", Offset = "0x5D54C80", VA = "0x185D56480")]
		public OPCBKIANLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7C0", Offset = "0x5D4CFC0", VA = "0x185D4E7C0", Slot = "14")]
		public override APEBMOKBFMO GetValue(IOOHIOGOJHA DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7E0", Offset = "0x5D4CFE0", VA = "0x185D4E7E0", Slot = "15")]
		public override void SetValue(IOOHIOGOJHA DJDFFLPPHHA, APEBMOKBFMO IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D561E0", Offset = "0x5D549E0", VA = "0x185D561E0")]
	public ODFOAECFNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class ELAAHHDJGDI : ContainerPropertyBag<BPFKIKLLKIB>
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class IHOHJLLPMIC : Property<BPFKIKLLKIB, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5D51380", Offset = "0x5D4FB80", VA = "0x185D51380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D51340", Offset = "0x5D4FB40", VA = "0x185D51340")]
		public IHOHJLLPMIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D51300", Offset = "0x5D4FB00", VA = "0x185D51300", Slot = "14")]
		public override int GetValue(BPFKIKLLKIB DJDFFLPPHHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D51320", Offset = "0x5D4FB20", VA = "0x185D51320", Slot = "15")]
		public override void SetValue(BPFKIKLLKIB DJDFFLPPHHA, int IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class ADLOKNPNPKO : Property<BPFKIKLLKIB, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5D4E770", Offset = "0x5D4CF70", VA = "0x185D4E770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E730", Offset = "0x5D4CF30", VA = "0x185D4E730")]
		public ADLOKNPNPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E6F0", Offset = "0x5D4CEF0", VA = "0x185D4E6F0", Slot = "14")]
		public override int GetValue(BPFKIKLLKIB DJDFFLPPHHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E710", Offset = "0x5D4CF10", VA = "0x185D4E710", Slot = "15")]
		public override void SetValue(BPFKIKLLKIB DJDFFLPPHHA, int IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class MJJAHAGMFEN : Property<BPFKIKLLKIB, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5D554D0", Offset = "0x5D53CD0", VA = "0x185D554D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D55490", Offset = "0x5D53C90", VA = "0x185D55490")]
		public MJJAHAGMFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D55440", Offset = "0x5D53C40", VA = "0x185D55440", Slot = "14")]
		public override GameObject GetValue(BPFKIKLLKIB DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D55460", Offset = "0x5D53C60", VA = "0x185D55460", Slot = "15")]
		public override void SetValue(BPFKIKLLKIB DJDFFLPPHHA, GameObject IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D4FCB0", Offset = "0x5D4E4B0", VA = "0x185D4FCB0")]
	public ELAAHHDJGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal class PIKPECEANCK : ContainerPropertyBag<EBMOMEFBDHI>
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class NEAJENGJKHH : Property<EBMOMEFBDHI, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5D559C0", Offset = "0x5D541C0", VA = "0x185D559C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D55980", Offset = "0x5D54180", VA = "0x185D55980")]
		public NEAJENGJKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D55930", Offset = "0x5D54130", VA = "0x185D55930", Slot = "14")]
		public override SerializableGuid GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D55960", Offset = "0x5D54160", VA = "0x185D55960", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, SerializableGuid IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class IMMFNCAAMNE : Property<EBMOMEFBDHI, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5D51560", Offset = "0x5D4FD60", VA = "0x185D51560", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D51520", Offset = "0x5D4FD20", VA = "0x185D51520")]
		public IMMFNCAAMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D514D0", Offset = "0x5D4FCD0", VA = "0x185D514D0", Slot = "14")]
		public override List<int> GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D514F0", Offset = "0x5D4FCF0", VA = "0x185D514F0", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, List<int> IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class PAKNEEMDGCJ : Property<EBMOMEFBDHI, List<EBMOMEFBDHI.AAAKDCKOBLA>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5D56670", Offset = "0x5D54E70", VA = "0x185D56670", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D56630", Offset = "0x5D54E30", VA = "0x185D56630")]
		public PAKNEEMDGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D565E0", Offset = "0x5D54DE0", VA = "0x185D565E0", Slot = "14")]
		public override List<EBMOMEFBDHI.AAAKDCKOBLA> GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D56600", Offset = "0x5D54E00", VA = "0x185D56600", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, List<EBMOMEFBDHI.AAAKDCKOBLA> IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	private class MEJJFIBDKMO : Property<EBMOMEFBDHI, List<EBMOMEFBDHI.BMALMAHEBEB>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5D553B0", Offset = "0x5D53BB0", VA = "0x185D553B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D55370", Offset = "0x5D53B70", VA = "0x185D55370")]
		public MEJJFIBDKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D55320", Offset = "0x5D53B20", VA = "0x185D55320", Slot = "14")]
		public override List<EBMOMEFBDHI.BMALMAHEBEB> GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D55340", Offset = "0x5D53B40", VA = "0x185D55340", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, List<EBMOMEFBDHI.BMALMAHEBEB> IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class GIKBMLDOJKL : Property<EBMOMEFBDHI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5D50250", Offset = "0x5D4EA50", VA = "0x185D50250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D50210", Offset = "0x5D4EA10", VA = "0x185D50210")]
		public GIKBMLDOJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D501C0", Offset = "0x5D4E9C0", VA = "0x185D501C0", Slot = "14")]
		public override GameObject GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D501E0", Offset = "0x5D4E9E0", VA = "0x185D501E0", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, GameObject IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class JABNECNMFGG : Property<EBMOMEFBDHI, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5D51690", Offset = "0x5D4FE90", VA = "0x185D51690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D51650", Offset = "0x5D4FE50", VA = "0x185D51650")]
		public JABNECNMFGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D51600", Offset = "0x5D4FE00", VA = "0x185D51600", Slot = "14")]
		public override Light GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D51620", Offset = "0x5D4FE20", VA = "0x185D51620", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, Light IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class BPJODEMDJIF : Property<EBMOMEFBDHI, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5D4EE50", Offset = "0x5D4D650", VA = "0x185D4EE50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EE10", Offset = "0x5D4D610", VA = "0x185D4EE10")]
		public BPJODEMDJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EDC0", Offset = "0x5D4D5C0", VA = "0x185D4EDC0", Slot = "14")]
		public override Collider GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EDE0", Offset = "0x5D4D5E0", VA = "0x185D4EDE0", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, Collider IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class MKGGMGMPOAO : Property<EBMOMEFBDHI, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5D55590", Offset = "0x5D53D90", VA = "0x185D55590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D55550", Offset = "0x5D53D50", VA = "0x185D55550")]
		public MKGGMGMPOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D55500", Offset = "0x5D53D00", VA = "0x185D55500", Slot = "14")]
		public override string GetValue(EBMOMEFBDHI DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D55520", Offset = "0x5D53D20", VA = "0x185D55520", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI DJDFFLPPHHA, string IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D56810", Offset = "0x5D55010", VA = "0x185D56810")]
	public PIKPECEANCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
internal class LLGCPAPEGPO : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class LBBJCDIIPLI : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x5D54EB0", Offset = "0x5D536B0", VA = "0x185D54EB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D54DC0", Offset = "0x5D535C0", VA = "0x185D54DC0")]
		public LBBJCDIIPLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "14")]
		public override Data128 GetValue(SerializableGuid DJDFFLPPHHA)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D54DB0", Offset = "0x5D535B0", VA = "0x185D54DB0", Slot = "15")]
		public override void SetValue(SerializableGuid DJDFFLPPHHA, Data128 IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D54EE0", Offset = "0x5D536E0", VA = "0x185D54EE0")]
	public LLGCPAPEGPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class DBHFABJIGBJ : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class DKAFICIKEJI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5D4F660", Offset = "0x5D4DE60", VA = "0x185D4F660", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F570", Offset = "0x5D4DD70", VA = "0x185D4F570")]
		public DKAFICIKEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x11FE650", Offset = "0x11FCE50", VA = "0x1811FE650", Slot = "14")]
		public override int GetValue(Data128 DJDFFLPPHHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F560", Offset = "0x5D4DD60", VA = "0x185D4F560", Slot = "15")]
		public override void SetValue(Data128 DJDFFLPPHHA, int IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class KOGFIPOGCFL : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5D54C00", Offset = "0x5D53400", VA = "0x185D54C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D54B10", Offset = "0x5D53310", VA = "0x185D54B10")]
		public KOGFIPOGCFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D54AF0", Offset = "0x5D532F0", VA = "0x185D54AF0", Slot = "14")]
		public override int GetValue(Data128 DJDFFLPPHHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D54B00", Offset = "0x5D53300", VA = "0x185D54B00", Slot = "15")]
		public override void SetValue(Data128 DJDFFLPPHHA, int IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class LAAOGNDLCJP : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5D54D30", Offset = "0x5D53530", VA = "0x185D54D30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D54C40", Offset = "0x5D53440", VA = "0x185D54C40")]
		public LAAOGNDLCJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x14AFA60", Offset = "0x14AE260", VA = "0x1814AFA60", Slot = "14")]
		public override int GetValue(Data128 DJDFFLPPHHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D54C30", Offset = "0x5D53430", VA = "0x185D54C30", Slot = "15")]
		public override void SetValue(Data128 DJDFFLPPHHA, int IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class EIILNOCCBKM : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5D4FB40", Offset = "0x5D4E340", VA = "0x185D4FB40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FA50", Offset = "0x5D4E250", VA = "0x185D4FA50")]
		public EIILNOCCBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FA30", Offset = "0x5D4E230", VA = "0x185D4FA30", Slot = "14")]
		public override int GetValue(Data128 DJDFFLPPHHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D4FA40", Offset = "0x5D4E240", VA = "0x185D4FA40", Slot = "15")]
		public override void SetValue(Data128 DJDFFLPPHHA, int IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F0E0", Offset = "0x5D4D8E0", VA = "0x185D4F0E0")]
	public DBHFABJIGBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class PKODEIFLCLH : ContainerPropertyBag<EBMOMEFBDHI.AAAKDCKOBLA>
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class HAPCEBGOFNN : Property<EBMOMEFBDHI.AAAKDCKOBLA, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5D504A0", Offset = "0x5D4ECA0", VA = "0x185D504A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5D50460", Offset = "0x5D4EC60", VA = "0x185D50460")]
		public HAPCEBGOFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80", Slot = "14")]
		public override Vector3 GetValue(EBMOMEFBDHI.AAAKDCKOBLA DJDFFLPPHHA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D50440", Offset = "0x5D4EC40", VA = "0x185D50440", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI.AAAKDCKOBLA DJDFFLPPHHA, Vector3 IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class KKJLDBCKEBI : Property<EBMOMEFBDHI.AAAKDCKOBLA, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5D54A60", Offset = "0x5D53260", VA = "0x185D54A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D54A20", Offset = "0x5D53220", VA = "0x185D54A20")]
		public KKJLDBCKEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D54A00", Offset = "0x5D53200", VA = "0x185D54A00", Slot = "14")]
		public override List<SerializableGuid> GetValue(EBMOMEFBDHI.AAAKDCKOBLA DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D54A10", Offset = "0x5D53210", VA = "0x185D54A10", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI.AAAKDCKOBLA DJDFFLPPHHA, List<SerializableGuid> IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D56C30", Offset = "0x5D55430", VA = "0x185D56C30")]
	public PKODEIFLCLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal class EEEIPLBOCJL : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class IBOMAFDPKNO : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5D51270", Offset = "0x5D4FA70", VA = "0x185D51270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5D51230", Offset = "0x5D4FA30", VA = "0x185D51230")]
		public IBOMAFDPKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D51210", Offset = "0x5D4FA10", VA = "0x185D51210", Slot = "14")]
		public override float GetValue(Vector3 DJDFFLPPHHA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D51220", Offset = "0x5D4FA20", VA = "0x185D51220", Slot = "15")]
		public override void SetValue(Vector3 DJDFFLPPHHA, float IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class CHLIJDBIHKP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5D4F050", Offset = "0x5D4D850", VA = "0x185D4F050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F010", Offset = "0x5D4D810", VA = "0x185D4F010")]
		public CHLIJDBIHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5D4EFF0", Offset = "0x5D4D7F0", VA = "0x185D4EFF0", Slot = "14")]
		public override float GetValue(Vector3 DJDFFLPPHHA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F000", Offset = "0x5D4D800", VA = "0x185D4F000", Slot = "15")]
		public override void SetValue(Vector3 DJDFFLPPHHA, float IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class OPOMHKILLCE : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5D565B0", Offset = "0x5D54DB0", VA = "0x185D565B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5D56570", Offset = "0x5D54D70", VA = "0x185D56570")]
		public OPOMHKILLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x18A1C10", Offset = "0x18A0410", VA = "0x1818A1C10", Slot = "14")]
		public override float GetValue(Vector3 DJDFFLPPHHA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5D56560", Offset = "0x5D54D60", VA = "0x185D56560", Slot = "15")]
		public override void SetValue(Vector3 DJDFFLPPHHA, float IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D4F890", Offset = "0x5D4E090", VA = "0x185D4F890")]
	public EEEIPLBOCJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class PNEAFEADOEL : ContainerPropertyBag<EBMOMEFBDHI.BMALMAHEBEB>
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class JNDCLBMOIAL : Property<EBMOMEFBDHI.BMALMAHEBEB, EBMOMEFBDHI.AAAKDCKOBLA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x5D54800", Offset = "0x5D53000", VA = "0x185D54800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5D547C0", Offset = "0x5D52FC0", VA = "0x185D547C0")]
		public JNDCLBMOIAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5D54750", Offset = "0x5D52F50", VA = "0x185D54750", Slot = "14")]
		public override EBMOMEFBDHI.AAAKDCKOBLA GetValue(EBMOMEFBDHI.BMALMAHEBEB DJDFFLPPHHA)
		{
			return default(EBMOMEFBDHI.AAAKDCKOBLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D54780", Offset = "0x5D52F80", VA = "0x185D54780", Slot = "15")]
		public override void SetValue(EBMOMEFBDHI.BMALMAHEBEB DJDFFLPPHHA, EBMOMEFBDHI.AAAKDCKOBLA IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D56D90", Offset = "0x5D55590", VA = "0x185D56D90")]
	public PNEAFEADOEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal class OGMIAABNPAD : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class GAEHPKJIIPL : Property<RRObjectPrefabV2Data, KNBFLDNEILM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x5D50190", Offset = "0x5D4E990", VA = "0x185D50190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5D50150", Offset = "0x5D4E950", VA = "0x185D50150")]
		public GAEHPKJIIPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x11FE650", Offset = "0x11FCE50", VA = "0x1811FE650", Slot = "14")]
		public override KNBFLDNEILM GetValue(RRObjectPrefabV2Data DJDFFLPPHHA)
		{
			return default(KNBFLDNEILM);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4F560", Offset = "0x5D4DD60", VA = "0x185D4F560", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data DJDFFLPPHHA, KNBFLDNEILM IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D562C0", Offset = "0x5D54AC0", VA = "0x185D562C0")]
	public OGMIAABNPAD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D56E70", Offset = "0x5D55670", VA = "0x185D56E70")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200010F")]
public class OBJMCPPPHHO
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OBJMCPPPHHO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
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

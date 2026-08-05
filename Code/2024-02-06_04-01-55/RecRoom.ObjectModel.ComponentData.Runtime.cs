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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ELJKILOALLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode FHOKCJADINN;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FBIHCMCODHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public DLKBDHLDNGO KELDEPJAPBB;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly GPCAJMICMLG<FBIHCMCODHB> JPDBNDFGACM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EGNJLJBMGOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NLIOJAOIHFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DLKBDHLDNGO
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
public struct FHNPDIFKFAD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct PGEHAAMOIBG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity PBEFJCLMEAP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OIOPJIJPCHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity EMDODFFCGEF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IJNHBKBKKMD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CBPJLNODNBL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity DHHBNGOGOPD;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IJBIFELIAKH : KHLOJJPFJNP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DBPFIKIDBDF CDMKGGCMLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(DBPFIKIDBDF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OCNFNDOEOAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 DLHCFNKIEFE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OPJEFIANKPJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EJIFGBFBBBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 PDEPNANBMPF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly GPCAJMICMLG<OHKJAHBPACE> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OHKJAHBPACE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 PDEPNANBMPF;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly GPCAJMICMLG<OHKJAHBPACE> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DKHEEMNNMAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 IAOGDKKDMJG;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FDPKMOJOPKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 JCEJEIOGNBH;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NPGMFKMIFLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float GGOOOEHNFLO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GPCAJMICMLG<NPGMFKMIFLF> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IOMPDNHCHNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float FIBNFPBKLOB;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly GPCAJMICMLG<IOMPDNHCHNC> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PIKBBMJENHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 CGLGBHHNCJG;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KEEKAMNGODJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PKGDKKKFHAD DEAMFKGMENA;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MGEIGHGHHBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public PKGDKKKFHAD KHPIMLCBKAL;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[LMKLBCDHAEC]
public struct FAMCJCLLOCD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity JPDMAMIIECO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LEJHNBLPOPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct JEFIHAPEHAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GNHHPGMKENN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct ELBPDGLLJLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints PBJBHPLLHKA;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NPKDMLFICNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float CFIGLOMJFEO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly GPCAJMICMLG<NPKDMLFICNP> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IMPJEKKGKAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float GKFPPGKMBKH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct KEOPEGGDJEP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct ACOKODFAOIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int HPLPIDOFMCA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFCDF0", VA = "0x180BFD9F0")]
	public static ACOKODFAOIO JPANIEAALPM(int ANJCCKHBJJO)
	{
		return default(ACOKODFAOIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FFHKIAMBJFK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody APJBIKHBABA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x614AEC0", Offset = "0x614A2C0", VA = "0x18614AEC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public FFHKIAMBJFK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IEIJKNCDGIN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JNIHHEBFLIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 HIEIGGIPFIC;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JBPEDIHNMCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 KDGFADJDBBB;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BONAKFHJBBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float DDLAOJAMPLO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly GPCAJMICMLG<BONAKFHJBBF> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HCLGGNACIOF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object APCLBKLJJDK;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x614B670", Offset = "0x614AA70", VA = "0x18614B670", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public HCLGGNACIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KJDMGPPKIEL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object BOOMBHALJPC;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x614CC80", Offset = "0x614C080", VA = "0x18614CC80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public KJDMGPPKIEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum PKGDKKKFHAD
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum GOOCPGCLLJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FNEPNDPKACM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGLLDENDAAM(DLKBDHLDNGO HCGCEJELFOB, DLKBDHLDNGO HDDDKPPGHOG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFCNNBCJCFO();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBHDAEBEHDI();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFBIOGKFJLO(bool CPAENGEGPEJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MFOJLCOFOPE();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFNNPCMAEMF();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HJFAHHOPNHI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FNEPNDPKACM GIODDPOBLIG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x614B830", Offset = "0x614AC30", VA = "0x18614B830", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public HJFAHHOPNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FEAENPOJNDP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(MKAAPPADLOF nameHash, BOJFCNCMMAN stableTypeHash, Type type)> DKELOCGPKCJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(MKAAPPADLOF nameHash, BOJFCNCMMAN stableTypeHash, Type type)> GEHKBPDGDOM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(MKAAPPADLOF previousNameHash, BOJFCNCMMAN previousStableTypeHash, Type currentTypeName)> EBKJAFAMEKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct NMCEMCCOGGJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, JJONOBHBJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6146A20", Offset = "0x6145E20", VA = "0x186146A20", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct AEHKBIIINLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[MBMAPNBFCAA(1)]
	public quaternion BHCBAPBJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[MBMAPNBFCAA(2)]
	public float3 IPLJDJCHMDC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly GPCAJMICMLG<AEHKBIIINLM> JPDBNDFGACM;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B50940", Offset = "0x3B4FD40", VA = "0x183B50940")]
	public AEHKBIIINLM(quaternion BHCBAPBJJED, float3 IPLJDJCHMDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6146680", Offset = "0x6145A80", VA = "0x186146680")]
	public static AEHKBIIINLM JPANIEAALPM(RigidTransform NKFPICCPEJK)
	{
		return default(AEHKBIIINLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KMJIBNEEBFP
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[NAPFDDDHKLF]
public struct ICKDEOMEFNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[MBMAPNBFCAA(1)]
	public float EIGJFJNPCGJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly GPCAJMICMLG<ICKDEOMEFNJ> JPDBNDFGACM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[NAPFDDDHKLF]
	public struct AuthoredParentData : IComponentData, JJONOBHBJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[MBMAPNBFCAA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6146A30", Offset = "0x6145E30", VA = "0x186146A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct PHOKOCMOGMB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, JJONOBHBJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LEDBPGGOLNF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct OKBAJODIAOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[MBMAPNBFCAA(1)]
	public SerializableGuid MADPFKENMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[MBMAPNBFCAA(2)]
	public SerializableGuid NGLJABNBABA;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
public struct BCINOCJLAKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[FormerlySerializedAs("Active")]
	[MBMAPNBFCAA(1)]
	public bool NAPMNDMEGPA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly GPCAJMICMLG<BCINOCJLAKL> JPDBNDFGACM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct ADIFAGNOMFE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
[NAPFDDDHKLF]
public struct NGELBFOEAAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[MBMAPNBFCAA(1)]
	public Entity GJFOJMEJMBP;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FJMHIMFIJDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity LIAEAGIFHBN;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MCDOCBBGHML : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity LIAEAGIFHBN;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[PGMCMBNNEAM("Container", 0)]
public struct BJFCIMKKJDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[MBMAPNBFCAA(1)]
	[FBGGJDOGPLF(0)]
	public OBAOFNGLGAB DEBBKMAMIAM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GPCAJMICMLG<BJFCIMKKJDG> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[LDCACMBKHKM(0, 127)]
public enum OBAOFNGLGAB
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
public static class IFADCAGBPJM
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum LIDCPIEAINL
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
	public enum IPDKBFJHNBP
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
	[Cpp2IlInjected.Address(RVA = "0x614C220", Offset = "0x614B620", VA = "0x18614C220")]
	public static (LIDCPIEAINL, IPDKBFJHNBP) JGHJDNGDCDO(this OBAOFNGLGAB EDCBCPMMAFP)
	{
		return default((LIDCPIEAINL, IPDKBFJHNBP));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[NAPFDDDHKLF]
[PGMCMBNNEAM("Container", 0)]
public struct PKABIIOENLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public PKHEKFLKJFO GGFNCOICJPJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly GPCAJMICMLG<PKABIIOENLD> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[LDCACMBKHKM(0, 2)]
public enum PKHEKFLKJFO
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
[PGMCMBNNEAM("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[NAPFDDDHKLF]
public struct IDMEHFNEIOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public IHKKOAMIJFG LOHMBFEAOHE;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[LDCACMBKHKM(0, 15943)]
[Flags]
public enum IHKKOAMIJFG
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
public struct FGPNBCNPKEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct CCJCLFMLOAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct MIHBJKNDAKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct JBGNACEEFJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct FILILINODHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct PLGJEAFDPPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct GPGMENIMPLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct FPKEEOLIJLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct BLJKPMFEJOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[NAPFDDDHKLF]
[PGMCMBNNEAM("Container", 0)]
public struct BMFLDFEIEKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public float JMPLEBOLKFE;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[NAPFDDDHKLF]
[PGMCMBNNEAM("Container", 0)]
public struct OFPPHDNFDEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[MBMAPNBFCAA(1)]
	[FBGGJDOGPLF(0)]
	public FixedString64Bytes GFBABMFGHOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct PKEONHGMECA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<MPBIKJFAHCE> FAMHOPCNFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<Entity> ELHBCKJKPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JobHandle POBBNOHNBCI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JENMABEOJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x614E450", Offset = "0x614D850", VA = "0x18614E450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x614E400", Offset = "0x614D800", VA = "0x18614E400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x45A7C00", Offset = "0x45A7000", VA = "0x1845A7C00")]
	public PKEONHGMECA(NativeList<MPBIKJFAHCE> FAMHOPCNFHI, NativeList<Entity> ELHBCKJKPLB, JobHandle POBBNOHNBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x614E2E0", Offset = "0x614D6E0", VA = "0x18614E2E0")]
	public (Entity, NativeSlice<Entity>) FIFPAFDHDDN(int FPJGJJLGENP)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x614E280", Offset = "0x614D680", VA = "0x18614E280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct MPBIKJFAHCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity DHHBNGOGOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int JNLHAMBBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int FLCGLAMBOBC;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface PEJKEFFMFHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEPKEPGACCM(bool LAOINGICCCO);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[PGMCMBNNEAM("Container", 0)]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
public struct FBBMFDAJKIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public EEEFPBMLPEF MCHOIMDAELF;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LDCACMBKHKM(0, 1)]
public enum EEEFPBMLPEF
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
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
[PGMCMBNNEAM("Container", 0)]
public struct IIAMKEJBAEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public EOCLBPNGFMP BJKONNALFDI;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly GPCAJMICMLG<IIAMKEJBAEI> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[LDCACMBKHKM(0, 2)]
public enum EOCLBPNGFMP
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
[FFJBIHNJGNK(1)]
public struct LEBFLHDALFO : IComparable<LEBFLHDALFO>, IEquatable<LEBFLHDALFO>, POPBFOOPFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[FILMDEIPIMG(1)]
	public uint EJIJHHFCMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[FILMDEIPIMG(2)]
	public uint GLCFMBJCJOB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint PBIOJOIEANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x614CE60", Offset = "0x614C260", VA = "0x18614CE60")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x614D170", Offset = "0x614C570", VA = "0x18614D170")]
	public LEBFLHDALFO(int EJIJHHFCMCD, int PKJGEMLCJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x614D170", Offset = "0x614C570", VA = "0x18614D170")]
	public LEBFLHDALFO(uint EJIJHHFCMCD, uint PKJGEMLCJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x614CDF0", Offset = "0x614C1F0", VA = "0x18614CDF0")]
	public LEBFLHDALFO GLDHPACGOEP(int JNLHAMBBADE = 1)
	{
		return default(LEBFLHDALFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x614D020", Offset = "0x614C420", VA = "0x18614D020")]
	public LEBFLHDALFO PDBEDKHFPJO(int JNLHAMBBADE = 1)
	{
		return default(LEBFLHDALFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x614CFA0", Offset = "0x614C3A0", VA = "0x18614CFA0")]
	public static LEBFLHDALFO JNACDJJJPLD(LEBFLHDALFO BGDKODNOBOD, LEBFLHDALFO APAKCINIMJJ)
	{
		return default(LEBFLHDALFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x614CCF0", Offset = "0x614C0F0", VA = "0x18614CCF0")]
	private static uint BEBFFIIBFFF(uint KHCOFGFJDMP, uint NFAPJGNODPK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x614CD20", Offset = "0x614C120", VA = "0x18614CD20", Slot = "4")]
	public int CompareTo(LEBFLHDALFO KMJGEHGGFFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x614CD60", Offset = "0x614C160", VA = "0x18614CD60", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x614D090", Offset = "0x614C490", VA = "0x18614D090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x614CD40", Offset = "0x614C140", VA = "0x18614CD40", Slot = "5")]
	public bool Equals(LEBFLHDALFO KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x614CE70", Offset = "0x614C270", VA = "0x18614CE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x614CEC0", Offset = "0x614C2C0", VA = "0x18614CEC0", Slot = "6")]
	public void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x614CF30", Offset = "0x614C330", VA = "0x18614CF30", Slot = "7")]
	public void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27BC390", Offset = "0x27BB790", VA = "0x1827BC390")]
	public static bool HOHCACPHFGD(LEBFLHDALFO BGDKODNOBOD, LEBFLHDALFO APAKCINIMJJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[FFJBIHNJGNK(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[FILMDEIPIMG(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[FILMDEIPIMG(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[FILMDEIPIMG(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[FILMDEIPIMG(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[FFJBIHNJGNK(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, POPBFOOPFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[FILMDEIPIMG(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
		public static SerializableGuid JPANIEAALPM(Guid LHLNCEHJAOH)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x614F380", Offset = "0x614E780", VA = "0x18614F380", Slot = "4")]
		public bool Equals(SerializableGuid KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x614F360", Offset = "0x614E760", VA = "0x18614F360", Slot = "5")]
		public int CompareTo(SerializableGuid KMJGEHGGFFC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x614F3B0", Offset = "0x614E7B0", VA = "0x18614F3B0", Slot = "6")]
		public void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x614F470", Offset = "0x614E870", VA = "0x18614F470", Slot = "7")]
		public void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x614F4F0", Offset = "0x614E8F0", VA = "0x18614F4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct PAJHFEJMNEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct KLLKACFACCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct AEFMBCMGJDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
public struct FPKAFMDEGPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[MBMAPNBFCAA(1)]
	public Entity NNNCDAOFHHD;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[InternalBufferCapacity(17)]
public struct HDCPAJPIJIB : IBufferElementData, IEquatable<HDCPAJPIJIB>, JJONOBHBJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Entity PBEFJCLMEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public int MAMLOLDGGEI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity BAPJHEDHBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x614B6E0", Offset = "0x614AAE0", VA = "0x18614B6E0", Slot = "4")]
	public bool Equals(HDCPAJPIJIB KMJGEHGGFFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
public struct EOOEBCOMPLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[MBMAPNBFCAA(1)]
	public int MAMLOLDGGEI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
[NAPFDDDHKLF]
public struct NBFHKOFFAHC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
[NAPFDDDHKLF]
public struct EJEBMJJACOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[MBMAPNBFCAA(1)]
	public Entity PKAMMDKGKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[MBMAPNBFCAA(2)]
	public uint ABAHJPMCKJG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId GMLPJMFMFND
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1D39FD0", Offset = "0x1D393D0", VA = "0x181D39FD0")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1D7D6F0", Offset = "0x1D7CAF0", VA = "0x181D7D6F0")]
	public EJEBMJJACOP(Entity PKAMMDKGKCE, EntityBundlePartId IDEOBKOKMOJ)
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
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		internal EntityBundlePartId(uint FNOGEAGAPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		internal uint CKKNJEPCGGP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x818880", Offset = "0x817C80", VA = "0x180818880", Slot = "4")]
		public bool Equals(EntityBundlePartId KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6147950", Offset = "0x6146D50", VA = "0x186147950", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x89D2C0", Offset = "0x89C6C0", VA = "0x18089D2C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x174DD70", Offset = "0x174D170", VA = "0x18174DD70")]
		public static bool HOHCACPHFGD(EntityBundlePartId KHCOFGFJDMP, EntityBundlePartId NFAPJGNODPK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct GGCCNFOEAMG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Entity AMEGBAFFINN;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct MFOPNGOCGDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[MBMAPNBFCAA(1)]
	public Entity JILDGEDOLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[MBMAPNBFCAA(2)]
	public bool GKBJMGHADGD;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
[NAPFDDDHKLF]
public struct FIPOICNHJPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[MBMAPNBFCAA(1)]
	public OOMKEKLGDOP BCFPDKAMGPE;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[LDCACMBKHKM(0, 4)]
public enum OOMKEKLGDOP
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
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct BGMPPOHPBPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[MBMAPNBFCAA(1)]
	public Entity JILDGEDOLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[MBMAPNBFCAA(2)]
	public bool EKHPFALDKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[MBMAPNBFCAA(3)]
	public float NFAHKEDOMHO;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct OGOCOGNMMKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[MBMAPNBFCAA(1)]
	public bool PNADBCDBNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[MBMAPNBFCAA(2)]
	public bool EKHPFALDKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[MBMAPNBFCAA(3)]
	public float PNIKIAKEFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[MBMAPNBFCAA(4)]
	public float MOPJGAAPLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[MBMAPNBFCAA(5)]
	public float MFCGJJICHPO;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[NAPFDDDHKLF]
public struct GEDLDNCLGAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[MBMAPNBFCAA(1)]
	public bool PNADBCDBNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[MBMAPNBFCAA(2)]
	public bool EKHPFALDKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[MBMAPNBFCAA(3)]
	public float NFAHKEDOMHO;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, JJONOBHBJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6146A20", Offset = "0x6145E20", VA = "0x186146A20", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[NAPFDDDHKLF]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, JJONOBHBJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[MBMAPNBFCAA(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, JJONOBHBJLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1754060", Offset = "0x1753460", VA = "0x181754060")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct JANNJBBMBDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface JJONOBHBJLB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity IMLMEICIAKH
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
public struct OJJPMABLNLM<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly bool OPNBALCMBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public uint FJFJHLBLLMK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	private static bool AGKIOABLKBP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[NAPFDDDHKLF]
[PGMCMBNNEAM("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct KAPJOOOPOIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[MBMAPNBFCAA(1)]
	[FBGGJDOGPLF(0)]
	public bool FAEFLPADKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(2)]
	public float LLBNPEAHNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(3)]
	public float LMCPEPEFDGI;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PGMCMBNNEAM("Light", 0)]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[NAPFDDDHKLF]
public struct IEPCPBDJNNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public float PLOJBCNBNML;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.TypeVersion(2)]
public struct LLIHPMAEGFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public uint PJOLKLIFPIK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x614D460", Offset = "0x614C860", VA = "0x18614D460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[NAPFDDDHKLF]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[FILMDEIPIMG(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct EKMCIIHLNFA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public int DMKONMKKPBH;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct KKDNHFGFGBK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public GCHandle DJEKJKHMFJO;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[LDCACMBKHKM(0, 4)]
public enum FGEJPMIBJCP
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
public struct BJHLJNACPIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct ALKCPMENCPP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public int DMKONMKKPBH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct NGMHBHMAFOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct CODMPOPIIAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct EIJJAABCJDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[TypeManager.TypeVersion(3)]
[NAPFDDDHKLF]
[PGMCMBNNEAM("Object", 0)]
public struct AMJGJLABMED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[MBMAPNBFCAA(2)]
	public FGLPENNKNIC NKIENGMJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[MBMAPNBFCAA(3)]
	[FBGGJDOGPLF(0)]
	public MHFGPABNDNL GBBFOBONPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(4)]
	public GDIOOMEIOJG LHBLMHEALGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[FILMDEIPIMG(5)]
	public NIEMKJEGNBG LOHMBFEAOHE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly GPCAJMICMLG<AMJGJLABMED> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class HODPELMOOBN
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x614BEB0", Offset = "0x614B2B0", VA = "0x18614BEB0")]
	public static void ENHGLNPEFHG(this NIEMKJEGNBG LOHMBFEAOHE, FEJJMBJFONO MBEDKBGCLNK, bool AKOFKNDDBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x614BE80", Offset = "0x614B280", VA = "0x18614BE80")]
	public static bool AGKEMPPENIA(this NIEMKJEGNBG LOHMBFEAOHE, FEJJMBJFONO MBEDKBGCLNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x614BEA0", Offset = "0x614B2A0", VA = "0x18614BEA0")]
	public static NIEMKJEGNBG ECGPPMFJLMH(this FEJJMBJFONO MBEDKBGCLNK)
	{
		return default(NIEMKJEGNBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x614BEE0", Offset = "0x614B2E0", VA = "0x18614BEE0")]
	public static void ENHGLNPEFHG(this MHFGPABNDNL LOHMBFEAOHE, MHFGPABNDNL MKKNEKCALEF, bool AKOFKNDDBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x605EA50", Offset = "0x605DE50", VA = "0x18605EA50")]
	public static bool AGKEMPPENIA(this MHFGPABNDNL LOHMBFEAOHE, MHFGPABNDNL MBEDKBGCLNK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum FEJJMBJFONO
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
[Flags]
[LDCACMBKHKM(0, 16383)]
public enum NIEMKJEGNBG
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
[LDCACMBKHKM(0, 3)]
[Flags]
public enum MHFGPABNDNL
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
[LDCACMBKHKM(0, 4)]
[JNJMIEEFNKP]
public enum GDIOOMEIOJG
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
public class JNJMIEEFNKP : JELHNABDLNM
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x614CBB0", Offset = "0x614BFB0", VA = "0x18614CBB0", Slot = "7")]
	public override string MECCLMMNDHG(string DBNNOOCLLFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2A40", Offset = "0x1EC1E40", VA = "0x181EC2A40")]
	public JNJMIEEFNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[FFJBIHNJGNK(1)]
public struct FGLPENNKNIC : POPBFOOPFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[FILMDEIPIMG(1)]
	public bool FAEFLPADKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[FILMDEIPIMG(2)]
	public float3 JJMNLMPDEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[FILMDEIPIMG(3)]
	public float3 NNBGBDGPKLE;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly GPCAJMICMLG<FGLPENNKNIC> JPDBNDFGACM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x614AF80", Offset = "0x614A380", VA = "0x18614AF80", Slot = "5")]
	public void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x614AF30", Offset = "0x614A330", VA = "0x18614AF30", Slot = "4")]
	public void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct GOHFOKBPLDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MPECBKFMKHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct BBNGPAPLGBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct OPNECBCEOFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public FixedString32Bytes GFBABMFGHOJ;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[LMKLBCDHAEC]
public struct CBOBKKPFLPM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Entity BHBDGFHBFAK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static CBOBKKPFLPM JPANIEAALPM(Entity ANJCCKHBJJO)
	{
		return default(CBOBKKPFLPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct AIOIPPFKEOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[MBMAPNBFCAA(1)]
	public Entity PPNJHGDHGLH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static AIOIPPFKEOM JPANIEAALPM(Entity JPDMAMIIECO)
	{
		return default(AIOIPPFKEOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal struct FMHFMLPEOHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Entity JPDMAMIIECO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static FMHFMLPEOHJ JPANIEAALPM(Entity JPDMAMIIECO)
	{
		return default(FMHFMLPEOHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct GMNIFDGKMIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Entity FCJJHOKMFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Entity NBPAJEFDHKH;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal struct IGNEFLMIDNC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Entity NCKINEOEKHJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static IGNEFLMIDNC JPANIEAALPM(Entity JPDMAMIIECO)
	{
		return default(IGNEFLMIDNC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal struct DFJFFMOJHPC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[LDCACMBKHKM(0, 2)]
public enum MOHLMHCIFIA
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
[PGMCMBNNEAM("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[NAPFDDDHKLF]
public struct PJGNEIOKHIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public float MABJDKFBDCN;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static readonly GPCAJMICMLG<PJGNEIOKHIF> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct HEMKIOMHMDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[MBMAPNBFCAA(1)]
	public JGGHLKICFJK OADPNHFKDPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[LDCACMBKHKM(-1, 38)]
public enum JGGHLKICFJK
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
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct EHGOBIJGDME : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[Flags]
	[LDCACMBKHKM(0, 7)]
	public enum LPPDOANOCNF
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
	[MBMAPNBFCAA(1)]
	public LPPDOANOCNF LOHMBFEAOHE;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static readonly GPCAJMICMLG<EHGOBIJGDME> JPDBNDFGACM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NFMMKJFOGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x61476E0", Offset = "0x6146AE0", VA = "0x1861476E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OBEPNLNPJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x61476F0", Offset = "0x6146AF0", VA = "0x1861476F0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct HADDNNABJFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[MBMAPNBFCAA(1)]
	public MOHLMHCIFIA OADPNHFKDPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct BDDOFONIIJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public uint MCCNLGBAILL;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[FFJBIHNJGNK(1)]
public struct GPHGMGDDHEA : POPBFOOPFKL
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[Flags]
	[LDCACMBKHKM(0, 7)]
	public enum DFBNEHDCEHB
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
	[FILMDEIPIMG(1)]
	public float IBDHMICCHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[FILMDEIPIMG(2)]
	public int MNLEHBPGOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[FILMDEIPIMG(3)]
	public DFBNEHDCEHB LOHMBFEAOHE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BELKIBIPAIB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x614B420", Offset = "0x614A820", VA = "0x18614B420")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x614B450", Offset = "0x614A850", VA = "0x18614B450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DLEJJGKLBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x614B410", Offset = "0x614A810", VA = "0x18614B410")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x614B530", Offset = "0x614A930", VA = "0x18614B530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NDCHPGOHGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x614B520", Offset = "0x614A920", VA = "0x18614B520")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x614B430", Offset = "0x614A830", VA = "0x18614B430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x614B4D0", Offset = "0x614A8D0", VA = "0x18614B4D0", Slot = "5")]
	public void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x614B470", Offset = "0x614A870", VA = "0x18614B470", Slot = "4")]
	public void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[LMKLBCDHAEC]
internal struct AKKEKEHOCJI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Entity GMPKJHIFGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public int AHDNEIKOMIB;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[NAPFDDDHKLF]
public struct LJBPJMECGNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[MBMAPNBFCAA(1)]
	public LEBFLHDALFO IJFOHGHPAJM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x86E470", Offset = "0x86D870", VA = "0x18086E470")]
	public static LJBPJMECGNA JPANIEAALPM(LEBFLHDALFO ANJCCKHBJJO)
	{
		return default(LJBPJMECGNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[NAPFDDDHKLF]
public struct HBCLNCPCKMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[MBMAPNBFCAA(1)]
	public Entity HKJODEDAPCK;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct HIJPPMIAFFO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Entity HKJODEDAPCK;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[NAPFDDDHKLF]
public struct IBEAFPHBIFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[MBMAPNBFCAA(1)]
	public float3 IPLJDJCHMDC;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static readonly GPCAJMICMLG<IBEAFPHBIFN> JPDBNDFGACM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E942F0", Offset = "0x1E936F0", VA = "0x181E942F0")]
	public static IBEAFPHBIFN JPANIEAALPM(float3 ANJCCKHBJJO)
	{
		return default(IBEAFPHBIFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct BKDEPAFPBAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[MBMAPNBFCAA(1)]
	public quaternion BHCBAPBJJED;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static readonly GPCAJMICMLG<BKDEPAFPBAL> JPDBNDFGACM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700")]
	public static BKDEPAFPBAL JPANIEAALPM(quaternion ANJCCKHBJJO)
	{
		return default(BKDEPAFPBAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
[NAPFDDDHKLF]
public struct POCGDNCDMMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[MBMAPNBFCAA(1)]
	public float3 GCDKBPGJENI;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public static readonly GPCAJMICMLG<POCGDNCDMMF> JPDBNDFGACM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1E942F0", Offset = "0x1E936F0", VA = "0x181E942F0")]
	public static POCGDNCDMMF JPANIEAALPM(float3 ANJCCKHBJJO)
	{
		return default(POCGDNCDMMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
[NAPFDDDHKLF]
public struct HBBDLDFCKJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[MBMAPNBFCAA(1)]
	public GPHGMGDDHEA HKMEMMHNFBF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct IOIHLGADFOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct LOOEJNBBLDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public uint FJFJHLBLLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int FCNNJIJCMHJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA43A60", Offset = "0xA42E60", VA = "0x180A43A60")]
	public LOOEJNBBLDG(uint CCGPJDCIHLI, int DBFMBMCFNGP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct NPKFCEDIODJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct JGHELGLAIJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct MDLFNMFDCEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct KONCGNGFKND : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct NPJCJOGELEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct HJPPBDHGLIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct EHLLMACILJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct FILPKOGAPGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct NFCNMLINOGE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct NNPIOLOBPEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal struct IGKNAJBALPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal struct EHMHMDFDMLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal struct JOHNHNKFGPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct KJCIIHAMBGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct OFFPHGLJNOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct MLEKFFOCIAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[MBMAPNBFCAA(1)]
	public FixedList32Bytes<int> JIPOHLKKMIP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct JHINPOPDNCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct HOLEJKOMCFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct FCECNHKLEEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct EKAODGLOAMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct FBHIDKFFILM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct NMNKGGFOAOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct JIHKLGFNOFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct FIPIBBIGNBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[LMKLBCDHAEC]
public struct GLEPGEJHLLI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public FixedString32Bytes LALDDLOBIGN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct NIFJFGBODPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct GLIJPGGPEPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct CCFMLONGKDK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
[NAPFDDDHKLF]
public struct MOMCIPMHOKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[FILMDEIPIMG(1)]
	public LPNKPDLBGFP MCCNLGBAILL;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public static readonly GPCAJMICMLG<MOMCIPMHOKP> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public enum LPNKPDLBGFP : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct HOJMDGJDIEE : IComponentData, IComparable<HOJMDGJDIEE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public int FMLDPJEBBON;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x175E4A0", Offset = "0x175D8A0", VA = "0x18175E4A0", Slot = "4")]
	public int CompareTo(HOJMDGJDIEE KMJGEHGGFFC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[NAPFDDDHKLF]
[TypeManager.TypeVersion(2)]
public struct ECLNIJNEPOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[MBMAPNBFCAA(2)]
	public bool PNJJIFPEAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[MBMAPNBFCAA(3)]
	public bool PDJKDDJAIPC;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public static readonly GPCAJMICMLG<ECLNIJNEPOP> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[NAPFDDDHKLF]
public struct CFMHOEOCLDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[MBMAPNBFCAA(1)]
	public bool EMFFPFFDFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[MBMAPNBFCAA(2)]
	public byte AKIDLNOMCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[MBMAPNBFCAA(3)]
	public short MCMKMILPBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[MBMAPNBFCAA(4)]
	public ushort AFIHHDAFACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[MBMAPNBFCAA(5)]
	public int FKMOPHFNFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[MBMAPNBFCAA(6)]
	public uint OEKIALIACKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[MBMAPNBFCAA(7)]
	public long PAPADNLLNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[MBMAPNBFCAA(8)]
	public ulong LCJAHCFAHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[MBMAPNBFCAA(9)]
	public float ICPNDGGEPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[MBMAPNBFCAA(10)]
	public double DINECJBOAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[MBMAPNBFCAA(11)]
	public HCHFLHJLDKB HJNDMGPBMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[MBMAPNBFCAA(12)]
	public MPNFKCHFLOH DPDODOCIDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[MBMAPNBFCAA(13)]
	public ICNEAKGMPMC GNCMDGJMEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[MBMAPNBFCAA(14)]
	public NFBJIBBEGPG EBDJADMJNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[MBMAPNBFCAA(15)]
	public IOMCFEPAAEM LLOPJFPINEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[MBMAPNBFCAA(16)]
	public FGAMFKCIJNK HDJHMIHFMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[MBMAPNBFCAA(17)]
	public NPBKNLEMABC GHPBCINKBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[MBMAPNBFCAA(18)]
	public EJJPCHHMOEM GDJKIMKPGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[MBMAPNBFCAA(20)]
	public Quaternion GPKHOIGBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[MBMAPNBFCAA(22)]
	public Vector3 OOEFKMEBKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[MBMAPNBFCAA(23)]
	public Vector4 MHMFAGFBGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[MBMAPNBFCAA(40)]
	public Entity NMDPLCFGIOB;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum HCHFLHJLDKB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum MPNFKCHFLOH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum ICNEAKGMPMC : short
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum NFBJIBBEGPG : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum IOMCFEPAAEM
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public enum FGAMFKCIJNK : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum NPBKNLEMABC : long
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum EJJPCHHMOEM : ulong
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
	[NAPFDDDHKLF]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	[NAPFDDDHKLF]
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
public class EKLNENPFOOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public int PKHNCMEKMEL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public int IMPBINMBDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public GameObject ILLDLCGIGNA;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public EKLNENPFOOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class DIIBOEIJCGG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public struct IAOAKJDBCKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Vector3 ONAPEDEOACI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<SerializableGuid> KEENJBOJKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class KKMGIICHKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public IAOAKJDBCKJ IFNAOMBBIJB;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public KKMGIICHKIP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public SerializableGuid ADHOBAMANLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public List<int> HJMFOEEIKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public List<IAOAKJDBCKJ> OGNLNCBIKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public List<KKMGIICHKIP> KLCJALAPGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public GameObject ILLDLCGIGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Light LMJCPHNNNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Collider AILIANBMFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public string DEOEMLBDBEJ;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public DIIBOEIJCGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[NAPFDDDHKLF]
public struct HBBMNNHBBPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[MBMAPNBFCAA(1)]
	public float3 MFBKLBNKNFD;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly GPCAJMICMLG<HBBMNNHBBPG> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[NAPFDDDHKLF]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct JINFNLHFNOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[MBMAPNBFCAA(1)]
	public quaternion BHCBAPBJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[MBMAPNBFCAA(2)]
	public float3 IPLJDJCHMDC;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly GPCAJMICMLG<JINFNLHFNOC> JPDBNDFGACM;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B50940", Offset = "0x3B4FD40", VA = "0x183B50940")]
	public JINFNLHFNOC(quaternion BHCBAPBJJED, float3 IPLJDJCHMDC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6146680", Offset = "0x6145A80", VA = "0x186146680")]
	public static RigidTransform JPANIEAALPM(JINFNLHFNOC KFPDFFKBKFC)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6146680", Offset = "0x6145A80", VA = "0x186146680")]
	public static JINFNLHFNOC JPANIEAALPM(RigidTransform NKFPICCPEJK)
	{
		return default(JINFNLHFNOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class LEAFKFGGJHP
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct DFNDKOBEJKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float4x4 KHOOMBFEECF;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static readonly GPCAJMICMLG<DFNDKOBEJKG> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public struct FKICLALKEMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float4x4 FAKNLJFMEDI;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly GPCAJMICMLG<FKICLALKEMB> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
[NAPFDDDHKLF]
public struct GELIOIPCBAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[MBMAPNBFCAA(1)]
	public float EIGJFJNPCGJ;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public static readonly GPCAJMICMLG<GELIOIPCBAM> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct AAFBKBEPEDL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int LIDMBMDIDDI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int AHDNEIKOMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6146500", Offset = "0x6145900", VA = "0x186146500")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6146510", Offset = "0x6145910", VA = "0x186146510")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
[NAPFDDDHKLF]
public struct LJPEPCGNBOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[MBMAPNBFCAA(1)]
	public GHHNLIOPKLC MIJFEHKIOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[MBMAPNBFCAA(2)]
	public HJPMLFNJMJG LKLHAJDIMBP;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[Flags]
[LDCACMBKHKM(0, 1)]
public enum GHHNLIOPKLC
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
[LDCACMBKHKM(-2, 2)]
public enum HJPMLFNJMJG
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
public struct JGIJDBOCJLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public float3 INAPJABFHEB;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly GPCAJMICMLG<JGIJDBOCJLN> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct HLAHGGJMHJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public float3 BEBKKMFGLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public quaternion IKFFGJBHBIC;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static readonly GPCAJMICMLG<HLAHGGJMHJC> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class EINIIGMCGHK
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct AOKLINBNBAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public float DHKGEOJHDJJ;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly GPCAJMICMLG<AOKLINBNBAE> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[LDCACMBKHKM(1000, 8000)]
public enum GLDOCFALIAD
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
public static class ELCHHIFJKJB
{
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal enum FOHBJNBMBED
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
internal static class IBPNHPEHFNA
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[LDCACMBKHKM(0, 9)]
public enum CPHIGBBODAJ
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
public static class FOJCDCFMDBO
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x614B170", Offset = "0x614A570", VA = "0x18614B170")]
	public static bool BGOMFGLKCNK(this CPHIGBBODAJ JAKBBONNAFM)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[NAPFDDDHKLF]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public GLDOCFALIAD prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class OFAGIFINMOJ
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x614DD90", Offset = "0x614D190", VA = "0x18614DD90")]
	public static CPHIGBBODAJ JIKMEJJMJNA(this GLDOCFALIAD APPOBJLFBKD)
	{
		return default(CPHIGBBODAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[LDCACMBKHKM(int.MinValue, int.MaxValue)]
public enum OJGEFPMKAAH
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
[LDCACMBKHKM(-1, 31)]
public enum BGGEFIEDCNC
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
[PGMCMBNNEAM("Visual", 0)]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[NAPFDDDHKLF]
public struct NJHDHPOCKAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[MBMAPNBFCAA(1)]
	[FBGGJDOGPLF(0)]
	public OJGEFPMKAAH MNHFMCFPMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[MBMAPNBFCAA(2)]
	[FBGGJDOGPLF(0)]
	public BGGEFIEDCNC LNKFECCMIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(3)]
	public float FIOMOOEIHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[MBMAPNBFCAA(4)]
	[FBGGJDOGPLF(0)]
	public Vector3 OJKNJCHGGJM;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[PLDCPMNMEEM]
[PGMCMBNNEAM("Container", 0)]
[ABNHEGMNHPJ(2613756846563002039uL, 6372660366488563574uL)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct PJDKKBILOGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(1)]
	public MAIJCIDHINC FJJOAHAALIB;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[LDCACMBKHKM(0, 15)]
[Flags]
public enum MAIJCIDHINC
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
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[PLDCPMNMEEM]
[ABNHEGMNHPJ(9804513251708000208uL, 10903582988135044631uL)]
public struct DCCHJMFCBBK : IComponentData, IEquatable<DCCHJMFCBBK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[MBMAPNBFCAA(1)]
	public FixedString64Bytes GFBABMFGHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[MBMAPNBFCAA(2)]
	public PKHEKFLKJFO GGFNCOICJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[MBMAPNBFCAA(3)]
	public MAIJCIDHINC FJJOAHAALIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[MBMAPNBFCAA(4)]
	public EEEFPBMLPEF MCHOIMDAELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[MBMAPNBFCAA(5)]
	public IHKKOAMIJFG LOHMBFEAOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[MBMAPNBFCAA(6)]
	public float JMPLEBOLKFE;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6147100", Offset = "0x6146500", VA = "0x186147100", Slot = "4")]
	public bool Equals(DCCHJMFCBBK KMJGEHGGFFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[ABNHEGMNHPJ(1213445203937950283uL, 119653618660684511uL)]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[PLDCPMNMEEM]
public struct NPLDDACFDMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[MBMAPNBFCAA(1)]
	public EALPODHBBIE JGGCKNKCDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public GCHandle EANIAGEJDFL;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[FFJBIHNJGNK(1)]
public struct EALPODHBBIE : POPBFOOPFKL, IEquatable<EALPODHBBIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[FILMDEIPIMG(1)]
	public int FNOGEAGAPLC;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61475F0", Offset = "0x61469F0", VA = "0x1861475F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6147570", Offset = "0x6146970", VA = "0x186147570", Slot = "0")]
	public override bool Equals(object BHPOPDOKECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x818880", Offset = "0x817C80", VA = "0x180818880", Slot = "6")]
	public bool Equals(EALPODHBBIE KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x175E530", Offset = "0x175D930", VA = "0x18175E530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6147660", Offset = "0x6146A60", VA = "0x186147660", Slot = "5")]
	public void JCEFODEMOAF(BEMFMJIIFFM EMDFNBPIKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6147650", Offset = "0x6146A50", VA = "0x186147650", Slot = "4")]
	public void ILCGODJBNBA(PKCECONMEHL MGAHLAJFBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[ABNHEGMNHPJ(218523523639012570uL, 15191719635551116065uL)]
[PLDCPMNMEEM]
public struct LDAMLKHHNEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private uint FLAOGJGHLPF;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[ABNHEGMNHPJ(9898405628982320166uL, 2023375009558162791uL)]
[PLDCPMNMEEM]
public struct HGAAAGPHDBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[MBMAPNBFCAA(1)]
	public NIEMKJEGNBG LOHMBFEAOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[MBMAPNBFCAA(2)]
	public FGLPENNKNIC NKIENGMJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[MBMAPNBFCAA(3)]
	[FBGGJDOGPLF(0)]
	public bool NBINCPJKGDP;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly GPCAJMICMLG<HGAAAGPHDBN> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[ABNHEGMNHPJ(9807788745867066359uL, 15168486114979071194uL)]
[PLDCPMNMEEM]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct IDDJAJMDALK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[MBMAPNBFCAA(1)]
	public NIEMKJEGNBG LOHMBFEAOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[MBMAPNBFCAA(2)]
	public FGLPENNKNIC NKIENGMJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[MBMAPNBFCAA(3)]
	[FBGGJDOGPLF(0)]
	public bool NBINCPJKGDP;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly GPCAJMICMLG<IDDJAJMDALK> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[ABNHEGMNHPJ(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[PLDCPMNMEEM]
public struct DBDNEJHIMGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[FILMDEIPIMG(1)]
	public NIEMKJEGNBG LOHMBFEAOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[MBMAPNBFCAA(2)]
	public FGLPENNKNIC NKIENGMJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[FBGGJDOGPLF(0)]
	[MBMAPNBFCAA(3)]
	public MHFGPABNDNL GBBFOBONPFJ;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly GPCAJMICMLG<DBDNEJHIMGM> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[PLDCPMNMEEM]
[ABNHEGMNHPJ(12226092714547765037uL, 15970362445488810630uL)]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct PJBJNHENCFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	[MBMAPNBFCAA(2)]
	public FGLPENNKNIC NKIENGMJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[MBMAPNBFCAA(3)]
	[FBGGJDOGPLF(0)]
	public MHFGPABNDNL GBBFOBONPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[FILMDEIPIMG(4)]
	public NIEMKJEGNBG LOHMBFEAOHE;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly GPCAJMICMLG<PJBJNHENCFI> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[ABNHEGMNHPJ(3318727941304405759uL, 6047901070934821887uL)]
[PLDCPMNMEEM]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct MLENICNHEPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public int BKCGIABJOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	[MBMAPNBFCAA(2)]
	public bool PNJJIFPEAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	[MBMAPNBFCAA(3)]
	public bool PDJKDDJAIPC;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly GPCAJMICMLG<MLENICNHEPO> JPDBNDFGACM;
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[ABNHEGMNHPJ(5861057081882613294uL, 13746475565109640919uL)]
[PLDCPMNMEEM]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct CABMIIGIKHN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[LDCACMBKHKM(0, 1)]
	public enum MJGHNEDDEBF
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
	[MBMAPNBFCAA(1)]
	public MJGHNEDDEBF LIHCDCBEKEM;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[ABNHEGMNHPJ(14327281633525910712uL, 2559857777606771911uL)]
[PLDCPMNMEEM]
public struct IJMGBIHIPLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	[MBMAPNBFCAA(1)]
	public GLDOCFALIAD APPOBJLFBKD;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[ABNHEGMNHPJ(15725208981563603541uL, 17017036095303668770uL)]
[PLDCPMNMEEM]
public struct JKPNJFKAACF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	[MBMAPNBFCAA(1)]
	public GLDOCFALIAD APPOBJLFBKD;
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[PLDCPMNMEEM]
[ABNHEGMNHPJ(1029043735688538310uL, 14256247939851101839uL)]
public struct OHGMLBFBCCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public CPHIGBBODAJ JAKBBONNAFM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[ABNHEGMNHPJ(17667479821163689808uL, 11946378475791123970uL)]
[PLDCPMNMEEM]
public struct IEPOHMADHMI : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DMCHAMHPJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x614F500", Offset = "0x614E900", VA = "0x18614F500", Slot = "4")]
		public sealed override void LMMLJHCJAPL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class EMNFEFAOJHA : ContainerPropertyBag<FFHKIAMBJFK>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class FDJJNJPFJCH : Property<FFHKIAMBJFK, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6147A70", Offset = "0x6146E70", VA = "0x186147A70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6147A30", Offset = "0x6146E30", VA = "0x186147A30")]
		public FDJJNJPFJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6146820", Offset = "0x6145C20", VA = "0x186146820", Slot = "14")]
		public override Rigidbody GetValue(FFHKIAMBJFK BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6146840", Offset = "0x6145C40", VA = "0x186146840", Slot = "15")]
		public override void SetValue(FFHKIAMBJFK BHGHMPIHGBP, Rigidbody ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6147870", Offset = "0x6146C70", VA = "0x186147870")]
	public EMNFEFAOJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class BDMANIBCCGA : ContainerPropertyBag<HCLGGNACIOF>
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class MLMGLILPPCB : Property<HCLGGNACIOF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x614D870", Offset = "0x614CC70", VA = "0x18614D870", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x614D830", Offset = "0x614CC30", VA = "0x18614D830")]
		public MLMGLILPPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6146820", Offset = "0x6145C20", VA = "0x186146820", Slot = "14")]
		public override object GetValue(HCLGGNACIOF BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6146840", Offset = "0x6145C40", VA = "0x186146840", Slot = "15")]
		public override void SetValue(HCLGGNACIOF BHGHMPIHGBP, object ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6146C80", Offset = "0x6146080", VA = "0x186146C80")]
	public BDMANIBCCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal class LELJKKPCLJF : ContainerPropertyBag<KJDMGPPKIEL>
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class PMIOFDJKBFP : Property<KJDMGPPKIEL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x614E500", Offset = "0x614D900", VA = "0x18614E500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x614E4C0", Offset = "0x614D8C0", VA = "0x18614E4C0")]
		public PMIOFDJKBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6146820", Offset = "0x6145C20", VA = "0x186146820", Slot = "14")]
		public override object GetValue(KJDMGPPKIEL BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6146840", Offset = "0x6145C40", VA = "0x186146840", Slot = "15")]
		public override void SetValue(KJDMGPPKIEL BHGHMPIHGBP, object ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x614D1C0", Offset = "0x614C5C0", VA = "0x18614D1C0")]
	public LELJKKPCLJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class GBCIIPEBCHP : ContainerPropertyBag<HJFAHHOPNHI>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class AMMFBKOJECO : Property<HJFAHHOPNHI, FNEPNDPKACM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x61468B0", Offset = "0x6145CB0", VA = "0x1861468B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6146870", Offset = "0x6145C70", VA = "0x186146870")]
		public AMMFBKOJECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6146820", Offset = "0x6145C20", VA = "0x186146820", Slot = "14")]
		public override FNEPNDPKACM GetValue(HJFAHHOPNHI BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6146840", Offset = "0x6145C40", VA = "0x186146840", Slot = "15")]
		public override void SetValue(HJFAHHOPNHI BHGHMPIHGBP, FNEPNDPKACM ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x614B180", Offset = "0x614A580", VA = "0x18614B180")]
	public GBCIIPEBCHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal class AADECLEOJDM : ContainerPropertyBag<EKLNENPFOOM>
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class IKLFAKLFDAP : Property<EKLNENPFOOM, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x614C460", Offset = "0x614B860", VA = "0x18614C460", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x614C420", Offset = "0x614B820", VA = "0x18614C420")]
		public IKLFAKLFDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x614C3E0", Offset = "0x614B7E0", VA = "0x18614C3E0", Slot = "14")]
		public override int GetValue(EKLNENPFOOM BHGHMPIHGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x614C400", Offset = "0x614B800", VA = "0x18614C400", Slot = "15")]
		public override void SetValue(EKLNENPFOOM BHGHMPIHGBP, int ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class HCCGDKKHFMN : Property<EKLNENPFOOM, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x614B640", Offset = "0x614AA40", VA = "0x18614B640", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x614B600", Offset = "0x614AA00", VA = "0x18614B600")]
		public HCCGDKKHFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x614B5C0", Offset = "0x614A9C0", VA = "0x18614B5C0", Slot = "14")]
		public override int GetValue(EKLNENPFOOM BHGHMPIHGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x614B5E0", Offset = "0x614A9E0", VA = "0x18614B5E0", Slot = "15")]
		public override void SetValue(EKLNENPFOOM BHGHMPIHGBP, int ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class BOKDJBLBBAP : Property<EKLNENPFOOM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6146F80", Offset = "0x6146380", VA = "0x186146F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6146F40", Offset = "0x6146340", VA = "0x186146F40")]
		public BOKDJBLBBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6146EF0", Offset = "0x61462F0", VA = "0x186146EF0", Slot = "14")]
		public override GameObject GetValue(EKLNENPFOOM BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6146F10", Offset = "0x6146310", VA = "0x186146F10", Slot = "15")]
		public override void SetValue(EKLNENPFOOM BHGHMPIHGBP, GameObject ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6146360", Offset = "0x6145760", VA = "0x186146360")]
	public AADECLEOJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class JCFALMCKCCP : ContainerPropertyBag<DIIBOEIJCGG>
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class OIMJNHPOAPK : Property<DIIBOEIJCGG, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x614DF60", Offset = "0x614D360", VA = "0x18614DF60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x614DF20", Offset = "0x614D320", VA = "0x18614DF20")]
		public OIMJNHPOAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x614DED0", Offset = "0x614D2D0", VA = "0x18614DED0", Slot = "14")]
		public override SerializableGuid GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x614DF00", Offset = "0x614D300", VA = "0x18614DF00", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, SerializableGuid ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class GFDPMANLBFJ : Property<DIIBOEIJCGG, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x614B3E0", Offset = "0x614A7E0", VA = "0x18614B3E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x614B3A0", Offset = "0x614A7A0", VA = "0x18614B3A0")]
		public GFDPMANLBFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x614B350", Offset = "0x614A750", VA = "0x18614B350", Slot = "14")]
		public override List<int> GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x614B370", Offset = "0x614A770", VA = "0x18614B370", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, List<int> ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class DJHLIOENEJB : Property<DIIBOEIJCGG, List<DIIBOEIJCGG.IAOAKJDBCKJ>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6147480", Offset = "0x6146880", VA = "0x186147480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6147440", Offset = "0x6146840", VA = "0x186147440")]
		public DJHLIOENEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61473F0", Offset = "0x61467F0", VA = "0x1861473F0", Slot = "14")]
		public override List<DIIBOEIJCGG.IAOAKJDBCKJ> GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6147410", Offset = "0x6146810", VA = "0x186147410", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, List<DIIBOEIJCGG.IAOAKJDBCKJ> ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class EAIBHPMMIHH : Property<DIIBOEIJCGG, List<DIIBOEIJCGG.KKMGIICHKIP>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6147540", Offset = "0x6146940", VA = "0x186147540", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6147500", Offset = "0x6146900", VA = "0x186147500")]
		public EAIBHPMMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x61474B0", Offset = "0x61468B0", VA = "0x1861474B0", Slot = "14")]
		public override List<DIIBOEIJCGG.KKMGIICHKIP> GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61474D0", Offset = "0x61468D0", VA = "0x1861474D0", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, List<DIIBOEIJCGG.KKMGIICHKIP> ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class OABLAENLHBN : Property<DIIBOEIJCGG, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x614DBC0", Offset = "0x614CFC0", VA = "0x18614DBC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x614DB80", Offset = "0x614CF80", VA = "0x18614DB80")]
		public OABLAENLHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x614DB30", Offset = "0x614CF30", VA = "0x18614DB30", Slot = "14")]
		public override GameObject GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x614DB50", Offset = "0x614CF50", VA = "0x18614DB50", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, GameObject ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private class BJJADPLLIPI : Property<DIIBOEIJCGG, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6146E40", Offset = "0x6146240", VA = "0x186146E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6146E00", Offset = "0x6146200", VA = "0x186146E00")]
		public BJJADPLLIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6146DB0", Offset = "0x61461B0", VA = "0x186146DB0", Slot = "14")]
		public override Light GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6146DD0", Offset = "0x61461D0", VA = "0x186146DD0", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, Light ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class BADKPHFDADG : Property<DIIBOEIJCGG, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6146C00", Offset = "0x6146000", VA = "0x186146C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6146BC0", Offset = "0x6145FC0", VA = "0x186146BC0")]
		public BADKPHFDADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6146B70", Offset = "0x6145F70", VA = "0x186146B70", Slot = "14")]
		public override Collider GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6146B90", Offset = "0x6145F90", VA = "0x186146B90", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, Collider ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	private class OLJDJMDCILH : Property<DIIBOEIJCGG, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x614E020", Offset = "0x614D420", VA = "0x18614E020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x614DFE0", Offset = "0x614D3E0", VA = "0x18614DFE0")]
		public OLJDJMDCILH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x614DF90", Offset = "0x614D390", VA = "0x18614DF90", Slot = "14")]
		public override string GetValue(DIIBOEIJCGG BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x614DFB0", Offset = "0x614D3B0", VA = "0x18614DFB0", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG BHGHMPIHGBP, string ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x614C620", Offset = "0x614BA20", VA = "0x18614C620")]
	public JCFALMCKCCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal class LLJNDOOJJFP : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class DFMIAKGABCN : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x61472E0", Offset = "0x61466E0", VA = "0x1861472E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x61471F0", Offset = "0x61465F0", VA = "0x1861471F0")]
		public DFMIAKGABCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xE524F0", Offset = "0xE518F0", VA = "0x180E524F0", Slot = "14")]
		public override Data128 GetValue(SerializableGuid BHGHMPIHGBP)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x61471E0", Offset = "0x61465E0", VA = "0x1861471E0", Slot = "15")]
		public override void SetValue(SerializableGuid BHGHMPIHGBP, Data128 ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x614D4F0", Offset = "0x614C8F0", VA = "0x18614D4F0")]
	public LLJNDOOJJFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class HKCCFINBACB : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class BABFEANNKFE : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6146B40", Offset = "0x6145F40", VA = "0x186146B40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6146A50", Offset = "0x6145E50", VA = "0x186146A50")]
		public BABFEANNKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60", Slot = "14")]
		public override int GetValue(Data128 BHGHMPIHGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6146A40", Offset = "0x6145E40", VA = "0x186146A40", Slot = "15")]
		public override void SetValue(Data128 BHGHMPIHGBP, int ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	private class LIJMMGCJJJL : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x614D430", Offset = "0x614C830", VA = "0x18614D430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x614D340", Offset = "0x614C740", VA = "0x18614D340")]
		public LIJMMGCJJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x614D320", Offset = "0x614C720", VA = "0x18614D320", Slot = "14")]
		public override int GetValue(Data128 BHGHMPIHGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x614D330", Offset = "0x614C730", VA = "0x18614D330", Slot = "15")]
		public override void SetValue(Data128 BHGHMPIHGBP, int ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	private class IKLFHAJAMEL : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x614C590", Offset = "0x614B990", VA = "0x18614C590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x614C4A0", Offset = "0x614B8A0", VA = "0x18614C4A0")]
		public IKLFHAJAMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x15EF140", Offset = "0x15EE540", VA = "0x1815EF140", Slot = "14")]
		public override int GetValue(Data128 BHGHMPIHGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x614C490", Offset = "0x614B890", VA = "0x18614C490", Slot = "15")]
		public override void SetValue(Data128 BHGHMPIHGBP, int ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class HPPPMJCAAOD : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x614C010", Offset = "0x614B410", VA = "0x18614C010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x614BF20", Offset = "0x614B320", VA = "0x18614BF20")]
		public HPPPMJCAAOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x614BF00", Offset = "0x614B300", VA = "0x18614BF00", Slot = "14")]
		public override int GetValue(Data128 BHGHMPIHGBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x614BF10", Offset = "0x614B310", VA = "0x18614BF10", Slot = "15")]
		public override void SetValue(Data128 BHGHMPIHGBP, int ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x614B8A0", Offset = "0x614ACA0", VA = "0x18614B8A0")]
	public HKCCFINBACB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class AEEDLPPHNOM : ContainerPropertyBag<DIIBOEIJCGG.IAOAKJDBCKJ>
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class NGFAKFACJBN : Property<DIIBOEIJCGG.IAOAKJDBCKJ, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x614DA40", Offset = "0x614CE40", VA = "0x18614DA40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x614DA00", Offset = "0x614CE00", VA = "0x18614DA00")]
		public NGFAKFACJBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x926950", Offset = "0x925D50", VA = "0x180926950", Slot = "14")]
		public override Vector3 GetValue(DIIBOEIJCGG.IAOAKJDBCKJ BHGHMPIHGBP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x614D9E0", Offset = "0x614CDE0", VA = "0x18614D9E0", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG.IAOAKJDBCKJ BHGHMPIHGBP, Vector3 ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	private class PPKLHNABPFG : Property<DIIBOEIJCGG.IAOAKJDBCKJ, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x614E600", Offset = "0x614DA00", VA = "0x18614E600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x614E5C0", Offset = "0x614D9C0", VA = "0x18614E5C0")]
		public PPKLHNABPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x614E5A0", Offset = "0x614D9A0", VA = "0x18614E5A0", Slot = "14")]
		public override List<SerializableGuid> GetValue(DIIBOEIJCGG.IAOAKJDBCKJ BHGHMPIHGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x614E5B0", Offset = "0x614D9B0", VA = "0x18614E5B0", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG.IAOAKJDBCKJ BHGHMPIHGBP, List<SerializableGuid> ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6146520", Offset = "0x6145920", VA = "0x186146520")]
	public AEEDLPPHNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class ODHGNEEIAHM : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	private class GBCJJCOIFOJ : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x614B2C0", Offset = "0x614A6C0", VA = "0x18614B2C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x614B280", Offset = "0x614A680", VA = "0x18614B280")]
		public GBCJJCOIFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x614B260", Offset = "0x614A660", VA = "0x18614B260", Slot = "14")]
		public override float GetValue(Vector3 BHGHMPIHGBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x614B270", Offset = "0x614A670", VA = "0x18614B270", Slot = "15")]
		public override void SetValue(Vector3 BHGHMPIHGBP, float ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class PDMNFOJLNLB : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x614E0B0", Offset = "0x614D4B0", VA = "0x18614E0B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x614E070", Offset = "0x614D470", VA = "0x18614E070")]
		public PDMNFOJLNLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x614E050", Offset = "0x614D450", VA = "0x18614E050", Slot = "14")]
		public override float GetValue(Vector3 BHGHMPIHGBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x614E060", Offset = "0x614D460", VA = "0x18614E060", Slot = "15")]
		public override void SetValue(Vector3 BHGHMPIHGBP, float ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	private class LIJBCKBPFJE : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x614D2F0", Offset = "0x614C6F0", VA = "0x18614D2F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x614D2B0", Offset = "0x614C6B0", VA = "0x18614D2B0")]
		public LIJBCKBPFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x19CC860", Offset = "0x19CBC60", VA = "0x1819CC860", Slot = "14")]
		public override float GetValue(Vector3 BHGHMPIHGBP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x614D2A0", Offset = "0x614C6A0", VA = "0x18614D2A0", Slot = "15")]
		public override void SetValue(Vector3 BHGHMPIHGBP, float ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x614DBF0", Offset = "0x614CFF0", VA = "0x18614DBF0")]
	public ODHGNEEIAHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class AOGOEHGGDMH : ContainerPropertyBag<DIIBOEIJCGG.KKMGIICHKIP>
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	private class NAGGICCBCNB : Property<DIIBOEIJCGG.KKMGIICHKIP, DIIBOEIJCGG.IAOAKJDBCKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x614D9B0", Offset = "0x614CDB0", VA = "0x18614D9B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x614D970", Offset = "0x614CD70", VA = "0x18614D970")]
		public NAGGICCBCNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x614D900", Offset = "0x614CD00", VA = "0x18614D900", Slot = "14")]
		public override DIIBOEIJCGG.IAOAKJDBCKJ GetValue(DIIBOEIJCGG.KKMGIICHKIP BHGHMPIHGBP)
		{
			return default(DIIBOEIJCGG.IAOAKJDBCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x614D930", Offset = "0x614CD30", VA = "0x18614D930", Slot = "15")]
		public override void SetValue(DIIBOEIJCGG.KKMGIICHKIP BHGHMPIHGBP, DIIBOEIJCGG.IAOAKJDBCKJ ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x61468E0", Offset = "0x6145CE0", VA = "0x1861468E0")]
	public AOGOEHGGDMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal class MHNOKBIBJHL : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	private class LPHAGGAIJBE : Property<RRObjectPrefabV2Data, GLDOCFALIAD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string GAOODFEKINE
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x614D6B0", Offset = "0x614CAB0", VA = "0x18614D6B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool DKAJDONKALI
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x614D670", Offset = "0x614CA70", VA = "0x18614D670")]
		public LPHAGGAIJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1303C60", Offset = "0x1303060", VA = "0x181303C60", Slot = "14")]
		public override GLDOCFALIAD GetValue(RRObjectPrefabV2Data BHGHMPIHGBP)
		{
			return default(GLDOCFALIAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6146A40", Offset = "0x6145E40", VA = "0x186146A40", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data BHGHMPIHGBP, GLDOCFALIAD ANJCCKHBJJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x614D6E0", Offset = "0x614CAE0", VA = "0x18614D6E0")]
	public MHNOKBIBJHL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x614E630", Offset = "0x614DA30", VA = "0x18614E630")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000126")]
public class CEDJFJLKOPL
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public CEDJFJLKOPL()
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

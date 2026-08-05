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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OLINADMBDBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode HKBIKBAHJPD;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EHOHLBECMJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public GEKKOKFDLIA ABMLEBFPDMM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly OAKAMBGJFHE<EHOHLBECMJB> DOPLKALBEDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JBKDGMBCMJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KOJNACENDBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum GEKKOKFDLIA
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
public struct HMJKJIAGJHM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct OJJHJAEKMGI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity FGPIOJPMPGE;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MCADECFJDAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity GEFCENNBDFI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JFCBIIEPBIL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct INFBCHMCINB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity BPBPHOELENB;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DIGJILHDNIE : FEPAHLENIMG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HCHIKDMPJJN CCIAFJEOACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HCHIKDMPJJN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MHJHOFMMIFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 KNEHKMIGBEF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OHEHFHMGAEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HGOPLLHGLAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 FKBADOLPHED;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly OAKAMBGJFHE<GAHCPFGMBEG> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GAHCPFGMBEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 FKBADOLPHED;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly OAKAMBGJFHE<GAHCPFGMBEG> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PNBGONJNLIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 NFBJNPLBBOP;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ICFLLJPOMLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 PJKOKPDJONH;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct LLBNGHJOHEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float BEINDBAIEHO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly OAKAMBGJFHE<LLBNGHJOHEN> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MEIBFKALOKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float GJCKFBFCEDJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OAKAMBGJFHE<MEIBFKALOKD> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PNAKFONLOHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 HOBIHMABMJO;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AOAKJDNOILM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public GDIMELFCBCC OFDNEFJDBAK;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LLEJKHNIKEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public GDIMELFCBCC FMBMDFCEKPM;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[APKEIEGEMCF]
public struct GAJKKJOCNFL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity NIELJJHKFLG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct OOMDEOBHCDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PEPLCEMPOKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PIHEKPCNFLK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DEJLPJMDLII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints OAINGMHFFCF;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GCCDINAHLFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float NBEEAPGALPG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly OAKAMBGJFHE<GCCDINAHLFI> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PEBDALMOAPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float CEPBIIEHIDE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct MCJJJNBHOKO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct HOHDKDILEEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int ECOIEDEBLJK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD816E0", Offset = "0xD804E0", VA = "0x180D816E0")]
	public static HOHDKDILEEB GMMJAEFOFKB(int MBDKMNBCLGF)
	{
		return default(HOHDKDILEEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class EBINCHGKKLK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody BPHKIOCOHDN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6093E60", Offset = "0x6092C60", VA = "0x186093E60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public EBINCHGKKLK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HNPPFADENPB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PLFCMNMPPLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 LAKKBNDDMCC;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IEADAEJBPDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 IBOAKNMBPHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JIKHNPGDOEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float MEDEIFJCMFA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OAKAMBGJFHE<JIKHNPGDOEC> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class MECMLOLGMOL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object OEDHKJIPMED;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6096C70", Offset = "0x6095A70", VA = "0x186096C70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public MECMLOLGMOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BIJBPBBMCON : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object OMKEFCPCOJN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6093490", Offset = "0x6092290", VA = "0x186093490", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public BIJBPBBMCON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum GDIMELFCBCC
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum PAFONDGDNMK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FHGIILMILDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHIMCGHOPEJ(GEKKOKFDLIA HKNGEMLKFBK, GEKKOKFDLIA JCBPPFJLBAJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONHLENKOBIN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOIAJCKKGHC();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNKCDBMJHEO(bool JNJHHJMDGIF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FANBEMKGHGH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBPNHEIFIEH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MJANNLCIABH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FHGIILMILDH CFNCOPDHFCO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6096E80", Offset = "0x6095C80", VA = "0x186096E80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public MJANNLCIABH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NDOKIFEEPJC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(ELHGKOIMEJD nameHash, BMDKPLCDMOG stableTypeHash, Type type)> CGANMNAMKIN;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(ELHGKOIMEJD nameHash, BMDKPLCDMOG stableTypeHash, Type type)> FPGJBOILFMM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(ELHGKOIMEJD previousNameHash, BMDKPLCDMOG previousStableTypeHash, Type currentTypeName)> MIPHBIIADBH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DEDMOFCPGHH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, LPPOAJGDOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60931C0", Offset = "0x6091FC0", VA = "0x1860931C0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct FGGMNOBKNFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[AKOJJKEJPDD(1)]
	public quaternion JNABFDAOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[AKOJJKEJPDD(2)]
	public float3 DDAFDAEAOPI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly OAKAMBGJFHE<FGGMNOBKNFI> DOPLKALBEDL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3B23C80", Offset = "0x3B22A80", VA = "0x183B23C80")]
	public FGGMNOBKNFI(quaternion JNABFDAOKDD, float3 DDAFDAEAOPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60936D0", Offset = "0x60924D0", VA = "0x1860936D0")]
	public static FGGMNOBKNFI GMMJAEFOFKB(RigidTransform FNPBNOAIEIP)
	{
		return default(FGGMNOBKNFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KGNDCJGOOLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct CGMKPGFNKDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[AKOJJKEJPDD(1)]
	public float MBKOAAMAHKF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly OAKAMBGJFHE<CGMKPGFNKDD> DOPLKALBEDL;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[JAOMOHMLJEA]
	public struct AuthoredParentData : IComponentData, LPPOAJGDOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[AKOJJKEJPDD(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60931D0", Offset = "0x6091FD0", VA = "0x1860931D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LBOLKCAMBLO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, LPPOAJGDOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BLKNCINBKNF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct ICEEMJOHCCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[AKOJJKEJPDD(1)]
	public SerializableGuid BLDAGMAKLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[AKOJJKEJPDD(2)]
	public SerializableGuid PNHDNAFHEFC;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
[JAOMOHMLJEA]
public struct LFKBJFABMOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[AKOJJKEJPDD(1)]
	[FormerlySerializedAs("Active")]
	public bool ICFPGIIEFOD;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly OAKAMBGJFHE<LFKBJFABMOI> DOPLKALBEDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[MJAGPOMJBFC]
public struct EEHEANHGAJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
[JAOMOHMLJEA]
public struct POOGPJNONGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[AKOJJKEJPDD(1)]
	public Entity GJEBDDJFNAN;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct IFHDGFJLIMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity ODLLKEBBMOP;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MGLKHFMFLAG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity ODLLKEBBMOP;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[MHCHIFJPMNF("Container", 0)]
public struct PKDDFEOIAIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(1)]
	public POMJLFNCLHB INCHFIDCBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly OAKAMBGJFHE<PKDDFEOIAIP> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[JBIFGDDKOKM(0, 127)]
public enum POMJLFNCLHB
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
public static class KAHLFCPFMOP
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum GMOOMHPGJNE
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
	public enum EIEIDELPJHJ
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
	[Cpp2IlInjected.Address(RVA = "0x6095EA0", Offset = "0x6094CA0", VA = "0x186095EA0")]
	public static (GMOOMHPGJNE, EIEIDELPJHJ) CEBMMBFFMIA(this POMJLFNCLHB FKKNNJMCCMP)
	{
		return default((GMOOMHPGJNE, EIEIDELPJHJ));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[MHCHIFJPMNF("Container", 0)]
public struct JCLINMHLKKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[AKOJJKEJPDD(1)]
	[NNLPEHDJBMB(0)]
	public NJGFIAALGBM EFDIHJGANAJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly OAKAMBGJFHE<JCLINMHLKKK> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[JBIFGDDKOKM(0, 2)]
public enum NJGFIAALGBM
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
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[MHCHIFJPMNF("Container", 0)]
public struct KNBCLGCBLOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[AKOJJKEJPDD(1)]
	[NNLPEHDJBMB(0)]
	public FCMJAOPMBPK KNKCDADLMEC;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[JBIFGDDKOKM(0, 15943)]
[Flags]
public enum FCMJAOPMBPK
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
public struct JLNFFLILPFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct CDGINPCFKPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct LHAGMFNIIGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BKDNLGMFBAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct NGIECFIBAKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HEHAHDKPABI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct IPDOAMEKOEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct JPNHOPAFIKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct ENAMACIGDCB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[MHCHIFJPMNF("Container", 0)]
[JAOMOHMLJEA]
public struct PAICHDHPMLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(1)]
	public float BHBLGLMNKMG;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[MHCHIFJPMNF("Container", 0)]
public struct NNOOLCGKHOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(1)]
	public FixedString64Bytes AOAIBMOPKPE;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct DHDHOCFIGIL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<LGBONKEBBOH> NEFHAKFKCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<Entity> OFDKAENBAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JobHandle NDHGJDFCLHE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HOCHOFNDPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6093D40", Offset = "0x6092B40", VA = "0x186093D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6093B70", Offset = "0x6092970", VA = "0x186093B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x450D6E0", Offset = "0x450C4E0", VA = "0x18450D6E0")]
	public DHDHOCFIGIL(NativeList<LGBONKEBBOH> NEFHAKFKCKA, NativeList<Entity> OFDKAENBAEI, JobHandle NDHGJDFCLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6093C20", Offset = "0x6092A20", VA = "0x186093C20")]
	public (Entity, NativeSlice<Entity>) KNKCFDHHAOB(int HBLLIHHIKIO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6093BC0", Offset = "0x60929C0", VA = "0x186093BC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct LGBONKEBBOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity BPBPHOELENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int PNNJJHFFONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int GENFKPIGLNJ;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface EEDDEBDHHAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKBOGOIHMCK(bool NBPHNIJOAFC);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[MHCHIFJPMNF("Container", 0)]
[JAOMOHMLJEA]
public struct DHGFPMBPNJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[AKOJJKEJPDD(1)]
	[NNLPEHDJBMB(0)]
	public BLIIFIOFLGE CKNIJMPMFLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[JBIFGDDKOKM(0, 1)]
public enum BLIIFIOFLGE
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
[MHCHIFJPMNF("Container", 0)]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
public struct OJPLHBNEDJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(1)]
	public OPIIAAKNDFD LBCAAICAFPD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly OAKAMBGJFHE<OJPLHBNEDJC> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[JBIFGDDKOKM(0, 2)]
public enum OPIIAAKNDFD
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
[EFLJIGFAEAE(1)]
public struct IHHDCPGDMMB : IComparable<IHHDCPGDMMB>, IEquatable<IHHDCPGDMMB>, BCHCDDNCGIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[JENIHFOLKGA(1)]
	public uint CGOABLHGLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[JENIHFOLKGA(2)]
	public uint ADIACKFDFIG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint MBHPAICHAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6095430", Offset = "0x6094230", VA = "0x186095430")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60957E0", Offset = "0x60945E0", VA = "0x1860957E0")]
	public IHHDCPGDMMB(int CGOABLHGLHA, int ILPBCLMLKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60957E0", Offset = "0x60945E0", VA = "0x1860957E0")]
	public IHHDCPGDMMB(uint CGOABLHGLHA, uint ILPBCLMLKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6095620", Offset = "0x6094420", VA = "0x186095620")]
	public IHHDCPGDMMB NNKFJICGKAA(int PNNJJHFFONP = 1)
	{
		return default(IHHDCPGDMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60955B0", Offset = "0x60943B0", VA = "0x1860955B0")]
	public IHHDCPGDMMB NFAPFMOCMLO(int PNNJJHFFONP = 1)
	{
		return default(IHHDCPGDMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6095530", Offset = "0x6094330", VA = "0x186095530")]
	public static IHHDCPGDMMB NDADNKDEFPH(IHHDCPGDMMB PDAKJJLHJDL, IHHDCPGDMMB KKCNPIHMPJA)
	{
		return default(IHHDCPGDMMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6095500", Offset = "0x6094300", VA = "0x186095500")]
	private static uint LMBBINIFAEA(uint OIPELOMOKGO, uint BJNEJGMGENI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6095360", Offset = "0x6094160", VA = "0x186095360", Slot = "4")]
	public int CompareTo(IHHDCPGDMMB GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60953A0", Offset = "0x60941A0", VA = "0x1860953A0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6095700", Offset = "0x6094500", VA = "0x186095700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6095380", Offset = "0x6094180", VA = "0x186095380", Slot = "5")]
	public bool Equals(IHHDCPGDMMB GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6095440", Offset = "0x6094240", VA = "0x186095440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6095690", Offset = "0x6094490", VA = "0x186095690", Slot = "6")]
	public void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6095490", Offset = "0x6094290", VA = "0x186095490", Slot = "7")]
	public void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x26A6230", Offset = "0x26A5030", VA = "0x1826A6230")]
	public static bool KFENMBPPCHH(IHHDCPGDMMB PDAKJJLHJDL, IHHDCPGDMMB KKCNPIHMPJA)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[EFLJIGFAEAE(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[JENIHFOLKGA(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[JENIHFOLKGA(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[JENIHFOLKGA(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[JENIHFOLKGA(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[EFLJIGFAEAE(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, BCHCDDNCGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[JENIHFOLKGA(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public static SerializableGuid GMMJAEFOFKB(Guid FILMEIPENDI)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x609C010", Offset = "0x609AE10", VA = "0x18609C010", Slot = "4")]
		public bool Equals(SerializableGuid GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializableGuid GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x609C0C0", Offset = "0x609AEC0", VA = "0x18609C0C0", Slot = "6")]
		public void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x609C040", Offset = "0x609AE40", VA = "0x18609C040", Slot = "7")]
		public void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x609C180", Offset = "0x609AF80", VA = "0x18609C180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct ALNHEBGLKAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct OCAJAGCOFOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct ECFBKODFCMA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
public struct JBPLNJCMAIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[AKOJJKEJPDD(1)]
	public Entity FCCFLKEEJDM;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[InternalBufferCapacity(17)]
public struct EGIJAAMPDJO : IBufferElementData, IEquatable<EGIJAAMPDJO>, LPPOAJGDOHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Entity FGPIOJPMPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public int DIOKINNJLKH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity JBEMJNIPDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6093EF0", Offset = "0x6092CF0", VA = "0x186093EF0", Slot = "4")]
	public bool Equals(EGIJAAMPDJO GDMGBCDFBAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
public struct HOBDDIFLBPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[AKOJJKEJPDD(1)]
	public int DIOKINNJLKH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct DICGJLHKGJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
[JAOMOHMLJEA]
public struct BGGPHLGLHDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[AKOJJKEJPDD(1)]
	public Entity HIAJGDEFCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[AKOJJKEJPDD(2)]
	public uint GFNPNPKEECG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId OKEBICICCOL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A110", Offset = "0x1D28F10", VA = "0x181D2A110")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1D49AC0", Offset = "0x1D488C0", VA = "0x181D49AC0")]
	public BGGPHLGLHDM(Entity HIAJGDEFCKG, EntityBundlePartId FGNDMFABKMC)
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
		[Cpp2IlInjected.Address(RVA = "0x885850", Offset = "0x884650", VA = "0x180885850")]
		internal EntityBundlePartId(uint JDEPDKNELPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810")]
		internal uint OGPIMBNPFDM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x80F5F0", Offset = "0x80E3F0", VA = "0x18080F5F0", Slot = "4")]
		public bool Equals(EntityBundlePartId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6094280", Offset = "0x6093080", VA = "0x186094280", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A9AC0", Offset = "0x8A88C0", VA = "0x1808A9AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x175A3A0", Offset = "0x17591A0", VA = "0x18175A3A0")]
		public static bool KFENMBPPCHH(EntityBundlePartId OIPELOMOKGO, EntityBundlePartId BJNEJGMGENI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BAAOAJAHBEL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Entity ELIJMOPPEJI;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
[JAOMOHMLJEA]
public struct BDPOFNFNMLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[AKOJJKEJPDD(1)]
	public Entity KEENMLGJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[AKOJJKEJPDD(2)]
	public bool KBHPKOBHECP;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct FJFMDIIMAKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[AKOJJKEJPDD(1)]
	public GBPNGFCFBBI IBKGIMACGDC;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[JBIFGDDKOKM(0, 4)]
public enum GBPNGFCFBBI
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
[JAOMOHMLJEA]
public struct NNIHFNKOANM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[AKOJJKEJPDD(1)]
	public Entity KEENMLGJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[AKOJJKEJPDD(2)]
	public bool IKDGDNNLPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[AKOJJKEJPDD(3)]
	public float IEAJOMOODAH;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[JAOMOHMLJEA]
public struct DDMDDGMJOEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[AKOJJKEJPDD(1)]
	public bool MIEHBOELEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[AKOJJKEJPDD(2)]
	public bool IKDGDNNLPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[AKOJJKEJPDD(3)]
	public float ADGPIGNCHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[AKOJJKEJPDD(4)]
	public float HKABGMNKJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[AKOJJKEJPDD(5)]
	public float HAAKINALKIC;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct MCGKBEBOBFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[AKOJJKEJPDD(1)]
	public bool MIEHBOELEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[AKOJJKEJPDD(2)]
	public bool IKDGDNNLPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[AKOJJKEJPDD(3)]
	public float IEAJOMOODAH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, LPPOAJGDOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60931C0", Offset = "0x6091FC0", VA = "0x1860931C0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[JAOMOHMLJEA]
	public struct ParentData : IComponentData, LPPOAJGDOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[AKOJJKEJPDD(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, LPPOAJGDOHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KHCMMFDGAMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface LPPOAJGDOHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity OHKCBJOFAGA
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
public struct ELKLOGEEPKA<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly bool NKGKIMMPNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public uint LCLNLDAGICB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	private static bool EALGDCKIFLG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[JAOMOHMLJEA]
[MHCHIFJPMNF("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct BADJMCNHMGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(1)]
	public bool PDBPIJFLAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(2)]
	public float KOKICMADJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(3)]
	public float APNOCEFBELF;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[MHCHIFJPMNF("Light", 0)]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
public struct CLPNNMOOIJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[AKOJJKEJPDD(1)]
	[NNLPEHDJBMB(0)]
	public float HOFFCOLMAPL;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.TypeVersion(2)]
public struct LFMDDCDDIEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public uint FBFEBHMHNLG;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6096580", Offset = "0x6095380", VA = "0x186096580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[JAOMOHMLJEA]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[JENIHFOLKGA(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct HIJBPHBHKCG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public int MHNCHJAAALC;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct PFIGAGMMHPO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public GCHandle OFBOMJPBPAP;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[JBIFGDDKOKM(0, 4)]
public enum LHMNBECEJMM
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
public struct OOLMPPKFGCL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EAGGDPFEKPG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public int MHNCHJAAALC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EFJMKFGOAFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct NPBLCJEJENM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct AFBLHAMBCNF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[MHCHIFJPMNF("Object", 0)]
[TypeManager.TypeVersion(3)]
public struct LNNHOGJIKBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[AKOJJKEJPDD(2)]
	public MAJCNGCEJND CDMOGCAIPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(3)]
	public MKFBFFODLEF IFNOBDCLCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[AKOJJKEJPDD(4)]
	[NNLPEHDJBMB(0)]
	public NGIFBLAIGLA BBACOMICNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[JENIHFOLKGA(5)]
	public CAAHMGGJHLL KNKCDADLMEC;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly OAKAMBGJFHE<LNNHOGJIKBN> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class EIOAMDOMLMP
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6093FD0", Offset = "0x6092DD0", VA = "0x186093FD0")]
	public static void COLNBMOOCNM(this CAAHMGGJHLL KNKCDADLMEC, IOIAFJHJDBG CPFDFDGFPIP, bool PIDMEIKGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6094000", Offset = "0x6092E00", VA = "0x186094000")]
	public static bool EMPFIHNEBHL(this CAAHMGGJHLL KNKCDADLMEC, IOIAFJHJDBG CPFDFDGFPIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6093FA0", Offset = "0x6092DA0", VA = "0x186093FA0")]
	public static CAAHMGGJHLL BDBEBKGKPFM(this IOIAFJHJDBG CPFDFDGFPIP)
	{
		return default(CAAHMGGJHLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6093FB0", Offset = "0x6092DB0", VA = "0x186093FB0")]
	public static void COLNBMOOCNM(this MKFBFFODLEF KNKCDADLMEC, MKFBFFODLEF GONLMBEAEJC, bool PIDMEIKGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE110", Offset = "0x5FACF10", VA = "0x185FAE110")]
	public static bool EMPFIHNEBHL(this MKFBFFODLEF KNKCDADLMEC, MKFBFFODLEF CPFDFDGFPIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum IOIAFJHJDBG
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
[JBIFGDDKOKM(0, 16383)]
[Flags]
public enum CAAHMGGJHLL
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
[JBIFGDDKOKM(0, 3)]
public enum MKFBFFODLEF
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
[JBIFGDDKOKM(0, 4)]
[AIJLKKAOIFG]
public enum NGIFBLAIGLA
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
public class AIJLKKAOIFG : BLCGFLBNPHB
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60930F0", Offset = "0x6091EF0", VA = "0x1860930F0", Slot = "7")]
	public override string DHMFLLFAIHD(string ECHPJMAFKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E61330", Offset = "0x1E60130", VA = "0x181E61330")]
	public AIJLKKAOIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[EFLJIGFAEAE(1)]
public struct MAJCNGCEJND : BCHCDDNCGIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[JENIHFOLKGA(1)]
	public bool PDBPIJFLAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[JENIHFOLKGA(2)]
	public float3 IGLCNJMPBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[JENIHFOLKGA(3)]
	public float3 NMEJEDPNJLD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly OAKAMBGJFHE<MAJCNGCEJND> DOPLKALBEDL;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6096830", Offset = "0x6095630", VA = "0x186096830", Slot = "5")]
	public void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60968A0", Offset = "0x60956A0", VA = "0x1860968A0", Slot = "4")]
	public void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct IFPCIBMLHBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct LLAJMHGBAKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LDPBNOAHBJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct JGCCKPMLOJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public FixedString32Bytes AOAIBMOPKPE;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[APKEIEGEMCF]
public struct NNGOMLNLILM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Entity JCMAKMKHHNL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static NNGOMLNLILM GMMJAEFOFKB(Entity MBDKMNBCLGF)
	{
		return default(NNGOMLNLILM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
[JAOMOHMLJEA]
public struct GNNCGPCCIHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[AKOJJKEJPDD(1)]
	public Entity FLABHAFGKBP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static GNNCGPCCIHK GMMJAEFOFKB(Entity NIELJJHKFLG)
	{
		return default(GNNCGPCCIHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal struct MCGIPIIKGLP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Entity NIELJJHKFLG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static MCGIPIIKGLP GMMJAEFOFKB(Entity NIELJJHKFLG)
	{
		return default(MCGIPIIKGLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct LPKOBMHCFBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Entity LEMIPGELIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Entity MDLBLPJLBGP;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal struct ICMFIOMCHDB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Entity BJGCDJCJANE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static ICMFIOMCHDB GMMJAEFOFKB(Entity NIELJJHKFLG)
	{
		return default(ICMFIOMCHDB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal struct EOFJAMGOLOO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[JBIFGDDKOKM(0, 2)]
public enum EAGODDLBLHI
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
[MHCHIFJPMNF("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[JAOMOHMLJEA]
public struct MMGCOIBGFIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(1)]
	public float GCOMPCFHINA;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static readonly OAKAMBGJFHE<MMGCOIBGFIA> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct EPPDFCIEHKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[AKOJJKEJPDD(1)]
	public HEGAFJHKMAG BCPIOKPDJPH;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[JBIFGDDKOKM(-1, 38)]
public enum HEGAFJHKMAG
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
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct ELPFFKDFFHL : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[JBIFGDDKOKM(0, 7)]
	[Flags]
	public enum OGCMGEAPNHJ
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
	[AKOJJKEJPDD(1)]
	public OGCMGEAPNHJ KNKCDADLMEC;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static readonly OAKAMBGJFHE<ELPFFKDFFHL> DOPLKALBEDL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PPFAJMCEAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6094190", Offset = "0x6092F90", VA = "0x186094190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JDPMJKCFEHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6094180", Offset = "0x6092F80", VA = "0x186094180")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct HJAOKMLEHCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[AKOJJKEJPDD(1)]
	public EAGODDLBLHI BCPIOKPDJPH;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct EDJEDMJNIJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public uint ECDEHLGBDJN;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[EFLJIGFAEAE(1)]
public struct MBKDCMJGJAM : BCHCDDNCGIN
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[JBIFGDDKOKM(0, 7)]
	[Flags]
	public enum IJMFMPNAJAH
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
	[JENIHFOLKGA(1)]
	public float HOPBEJNDKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[JENIHFOLKGA(2)]
	public int INCOANPOOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[JENIHFOLKGA(3)]
	public IJMFMPNAJAH KNKCDADLMEC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BMDBEANMJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6096A90", Offset = "0x6095890", VA = "0x186096A90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6096AB0", Offset = "0x60958B0", VA = "0x186096AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DJNLPNGFLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6096A80", Offset = "0x6095880", VA = "0x186096A80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6096A60", Offset = "0x6095860", VA = "0x186096A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MCBDNDMHBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6096AA0", Offset = "0x60958A0", VA = "0x186096AA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60969F0", Offset = "0x60957F0", VA = "0x1860969F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6096A10", Offset = "0x6095810", VA = "0x186096A10", Slot = "5")]
	public void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6096AD0", Offset = "0x60958D0", VA = "0x186096AD0", Slot = "4")]
	public void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[APKEIEGEMCF]
internal struct KPMDMMGFKDM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Entity LCBONOEHIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public int HPLKFBKKIBG;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[JAOMOHMLJEA]
public struct NIDOHPNGOLA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[AKOJJKEJPDD(1)]
	public IHHDCPGDMMB MNPIGEMLOBF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static NIDOHPNGOLA GMMJAEFOFKB(IHHDCPGDMMB MBDKMNBCLGF)
	{
		return default(NIDOHPNGOLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[JAOMOHMLJEA]
public struct LEKOAKBCJCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[AKOJJKEJPDD(1)]
	public Entity AMEOMAMAPGA;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct CNMLMBLNGKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Entity AMEOMAMAPGA;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[JAOMOHMLJEA]
public struct COOANMGKPMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[AKOJJKEJPDD(1)]
	public float3 DDAFDAEAOPI;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static readonly OAKAMBGJFHE<COOANMGKPMD> DOPLKALBEDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2113F00", Offset = "0x2112D00", VA = "0x182113F00")]
	public static COOANMGKPMD GMMJAEFOFKB(float3 MBDKMNBCLGF)
	{
		return default(COOANMGKPMD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct NFDGGNNPPBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[AKOJJKEJPDD(1)]
	public quaternion JNABFDAOKDD;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static readonly OAKAMBGJFHE<NFDGGNNPPBC> DOPLKALBEDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
	public static NFDGGNNPPBC GMMJAEFOFKB(quaternion MBDKMNBCLGF)
	{
		return default(NFDGGNNPPBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct NKPBKDAGBGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[AKOJJKEJPDD(1)]
	public float3 ILKLAIGFMCJ;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public static readonly OAKAMBGJFHE<NKPBKDAGBGE> DOPLKALBEDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2113F00", Offset = "0x2112D00", VA = "0x182113F00")]
	public static NKPBKDAGBGE GMMJAEFOFKB(float3 MBDKMNBCLGF)
	{
		return default(NKPBKDAGBGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
[JAOMOHMLJEA]
public struct HCGFCGKNAJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[AKOJJKEJPDD(1)]
	public MBKDCMJGJAM JMFMJMCAPBJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct ENODBCOAEIF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct FAOPAGEJIJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public uint LCLNLDAGICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int NNCAPJLJNPH;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA34EB0", Offset = "0xA33CB0", VA = "0x180A34EB0")]
	public FAOPAGEJIJJ(uint DJAFGMKGLPG, int FDNADAHEOLP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct FJMAJCKHHDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct KNJGDKHBALC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct MDBCCOGAGIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct PDAOEJBHMHG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct ODICHNPNHLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct CKFKDFECNDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct NBHHNAAKAHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct HPOHFOHFFFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct HHFKJKPNGDH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct KEHJANIINOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal struct PCEFHEHENKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal struct ECJOOFLDKDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal struct ICOBODDNENG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct HFPPPBGOOPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct ONAAMMFJAAM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct CAOOOPNGHEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[AKOJJKEJPDD(1)]
	public FixedList32Bytes<int> EGBBFBHNHDM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct CKNLBGBGDMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct HNLEOIBPNGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct GAHJLFIMONP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct BLGPFNPGPAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct JDAECDICGCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct BAJOGCDDBKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct AEDAIIAGGIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct GMPAJHFKJNB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[APKEIEGEMCF]
public struct CHKMHKNLLNN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public FixedString32Bytes NFDAMLOEIEA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct HPKFEOGAOFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct KDGACIBOGPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct CGPJDEGFFAO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct GCLAPBJLFJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[JENIHFOLKGA(1)]
	public HCJGEKMLEPJ ECDEHLGBDJN;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public static readonly OAKAMBGJFHE<GCLAPBJLFJG> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public enum HCJGEKMLEPJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct MBDPPPABAIB : IComponentData, IComparable<MBDPPPABAIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public int DIACJGNIHLF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1769CE0", Offset = "0x1768AE0", VA = "0x181769CE0", Slot = "4")]
	public int CompareTo(MBDPPPABAIB GDMGBCDFBAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct MBGBNPFEDGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[AKOJJKEJPDD(2)]
	public bool CGPCHIKJDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[AKOJJKEJPDD(3)]
	public bool DLNPGNMFHAO;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public static readonly OAKAMBGJFHE<MBGBNPFEDGP> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[JAOMOHMLJEA]
public struct ANJKICECIPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[AKOJJKEJPDD(1)]
	public bool CNCIDFGHNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[AKOJJKEJPDD(2)]
	public byte HIINJLHEKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[AKOJJKEJPDD(3)]
	public short IKPAECBIHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[AKOJJKEJPDD(4)]
	public ushort ABCANGKAOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[AKOJJKEJPDD(5)]
	public int IDCLCAJDIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[AKOJJKEJPDD(6)]
	public uint BGEBNLLOFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[AKOJJKEJPDD(7)]
	public long GGPLLAFIAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[AKOJJKEJPDD(8)]
	public ulong CMJFBNPEPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[AKOJJKEJPDD(9)]
	public float EOEBPKOCGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[AKOJJKEJPDD(10)]
	public double EODHGFBCHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[AKOJJKEJPDD(11)]
	public CJOOAECGNLI FCPLLJAGICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[AKOJJKEJPDD(12)]
	public OJPKECCECEL OAFLIDPBIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[AKOJJKEJPDD(13)]
	public DJOLHFGOGPF KJHCNACMNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[AKOJJKEJPDD(14)]
	public HKAFAJIIMOC MLAEDBBIDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[AKOJJKEJPDD(15)]
	public HOBDGLDACFJ HKJHEIJECMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[AKOJJKEJPDD(16)]
	public CIBDBKAPCLB DEOOINKCMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[AKOJJKEJPDD(17)]
	public PKFLFCMHPNL CJDPINAIEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[AKOJJKEJPDD(18)]
	public JNMIPGCCDHE IIJEPDJMFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[AKOJJKEJPDD(20)]
	public Quaternion BNMNOFLKIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[AKOJJKEJPDD(22)]
	public Vector3 GOPMLBPNELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[AKOJJKEJPDD(23)]
	public Vector4 POBDKHJNAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[AKOJJKEJPDD(40)]
	public Entity GPCLCJIBKHB;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum CJOOAECGNLI : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum OJPKECCECEL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum DJOLHFGOGPF : short
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum HKAFAJIIMOC : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum HOBDGLDACFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public enum CIBDBKAPCLB : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum PKFLFCMHPNL : long
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum JNMIPGCCDHE : ulong
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
	[JAOMOHMLJEA]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[JAOMOHMLJEA]
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
public class NABCIGCHFFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public int MEFCHKNPKLC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public int BAGEGOCICOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public GameObject FAIKIGMIEFB;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public NABCIGCHFFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class CCACOEJGNLJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public struct LHKAGIOFNBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Vector3 PIMKONJJKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<SerializableGuid> BLEKHCFHBHN;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class MFIKAHFMGLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public LHKAGIOFNBO HJOLBPAJOLL;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MFIKAHFMGLP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public SerializableGuid KDOIKELMPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public List<int> ELBPHOCBNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public List<LHKAGIOFNBO> BGDMKDDFKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public List<MFIKAHFMGLP> MBEIIMGGKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public GameObject FAIKIGMIEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Light GIDJEHGFHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Collider AJPMBIIODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public string HEBHFJCDDHK;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public CCACOEJGNLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[JAOMOHMLJEA]
public struct JPOJFBEKHJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[AKOJJKEJPDD(1)]
	public float3 NIBDPPBKKDI;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly OAKAMBGJFHE<JPOJFBEKHJC> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct BPHGEEHJHEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[AKOJJKEJPDD(1)]
	public quaternion JNABFDAOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[AKOJJKEJPDD(2)]
	public float3 DDAFDAEAOPI;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly OAKAMBGJFHE<BPHGEEHJHEO> DOPLKALBEDL;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3B23C80", Offset = "0x3B22A80", VA = "0x183B23C80")]
	public BPHGEEHJHEO(quaternion JNABFDAOKDD, float3 DDAFDAEAOPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x60936D0", Offset = "0x60924D0", VA = "0x1860936D0")]
	public static RigidTransform GMMJAEFOFKB(BPHGEEHJHEO GPNGCMCKHGN)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60936D0", Offset = "0x60924D0", VA = "0x1860936D0")]
	public static BPHGEEHJHEO GMMJAEFOFKB(RigidTransform FNPBNOAIEIP)
	{
		return default(BPHGEEHJHEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class JOEBIKOACJH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct ODPMKNGDBDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float4x4 GMEFNDLEJAL;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static readonly OAKAMBGJFHE<ODPMKNGDBDP> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public struct KIGBJLNBHGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float4x4 BKMDPFLEGLL;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly OAKAMBGJFHE<KIGBJLNBHGJ> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct JKDKOEAPPFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[AKOJJKEJPDD(1)]
	public float MBKOAAMAHKF;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public static readonly OAKAMBGJFHE<JKDKOEAPPFN> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct AIHOAGHFPAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int CMDFJOIHMAF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HPLKFBKKIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60930D0", Offset = "0x6091ED0", VA = "0x1860930D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60930E0", Offset = "0x6091EE0", VA = "0x1860930E0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[JAOMOHMLJEA]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct HGKCGNHBIII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[AKOJJKEJPDD(1)]
	public GJJCDKEPNOL AGPMFDHMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[AKOJJKEJPDD(2)]
	public LBFDLLMAEPK GLHODOGILFC;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[JBIFGDDKOKM(0, 1)]
[Flags]
public enum GJJCDKEPNOL
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
[JBIFGDDKOKM(-2, 2)]
public enum LBFDLLMAEPK
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
public struct MFJBAOCPCGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public float3 KKIOBFGIDAP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly OAKAMBGJFHE<MFJBAOCPCGH> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct KNELPNFOHOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public float3 MHFADBEELBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public quaternion NJBEEEBFFMP;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static readonly OAKAMBGJFHE<KNELPNFOHOI> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class OIFEBMGHLFO
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct CKPAFPHBCCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public float GIHCOKFFCGD;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly OAKAMBGJFHE<CKPAFPHBCCM> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[JBIFGDDKOKM(1000, 8000)]
public enum AILCPGEEFDG
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
public static class IDGFDABALBI
{
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal enum COCAEHGOFDE
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
internal static class KGPCPIAMPBM
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[JBIFGDDKOKM(0, 9)]
public enum LEONPEKFPMG
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
public static class PDLGFHHFFGL
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x609AD40", Offset = "0x6099B40", VA = "0x18609AD40")]
	public static bool BGCILCLIMAF(this LEONPEKFPMG CBBCBHMDHCL)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[JAOMOHMLJEA]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AILCPGEEFDG prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class EDHGDMAMNEJ
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6093ED0", Offset = "0x6092CD0", VA = "0x186093ED0")]
	public static LEONPEKFPMG FGJHGECCOLG(this AILCPGEEFDG GHLJMGMIJJK)
	{
		return default(LEONPEKFPMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[JBIFGDDKOKM(int.MinValue, int.MaxValue)]
public enum HLKLKCCAAHD
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
[JBIFGDDKOKM(-1, 31)]
public enum LCLGFCCFGKM
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
[JAOMOHMLJEA]
[MHCHIFJPMNF("Visual", 0)]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
public struct AGGJAOONHBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[AKOJJKEJPDD(1)]
	[NNLPEHDJBMB(0)]
	public HLKLKCCAAHD PIPDACHFJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(2)]
	public LCLGFCCFGKM ELKLKFMLCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(3)]
	public float COKLKNNDCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(4)]
	public Vector3 FLDOBKCJHDF;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[PPAOGIPHJFC(2613756846563002039uL, 6372660366488563574uL)]
[MHCHIFJPMNF("Container", 0)]
[IJDEKFPGEPI]
public struct HNKNAINOLMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[AKOJJKEJPDD(1)]
	[NNLPEHDJBMB(0)]
	public AKLCBGHKJFC CEKKDCJIEML;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[Flags]
[JBIFGDDKOKM(0, 15)]
public enum AKLCBGHKJFC
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
[IJDEKFPGEPI]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[PPAOGIPHJFC(9804513251708000208uL, 10903582988135044631uL)]
public struct BMGAMEFFNHM : IComponentData, IEquatable<BMGAMEFFNHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[AKOJJKEJPDD(1)]
	public FixedString64Bytes AOAIBMOPKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[AKOJJKEJPDD(2)]
	public NJGFIAALGBM EFDIHJGANAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[AKOJJKEJPDD(3)]
	public AKLCBGHKJFC CEKKDCJIEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[AKOJJKEJPDD(4)]
	public BLIIFIOFLGE CKNIJMPMFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[AKOJJKEJPDD(5)]
	public FCMJAOPMBPK KNKCDADLMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[AKOJJKEJPDD(6)]
	public float BHBLGLMNKMG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60935F0", Offset = "0x60923F0", VA = "0x1860935F0", Slot = "4")]
	public bool Equals(BMGAMEFFNHM GDMGBCDFBAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[PPAOGIPHJFC(1213445203937950283uL, 119653618660684511uL)]
[IJDEKFPGEPI]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct IGOLPBPBJKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[AKOJJKEJPDD(1)]
	public FADGALDLNHL BHMLBGJMDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public GCHandle PICGAENFGAG;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[EFLJIGFAEAE(1)]
public struct FADGALDLNHL : BCHCDDNCGIN, IEquatable<FADGALDLNHL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[JENIHFOLKGA(1)]
	public int JDEPDKNELPP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6094380", Offset = "0x6093180", VA = "0x186094380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6094300", Offset = "0x6093100", VA = "0x186094300", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80F5F0", Offset = "0x80E3F0", VA = "0x18080F5F0", Slot = "6")]
	public bool Equals(FADGALDLNHL GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1769D70", Offset = "0x1768B70", VA = "0x181769D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x60943E0", Offset = "0x60931E0", VA = "0x1860943E0", Slot = "5")]
	public void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6094400", Offset = "0x6093200", VA = "0x186094400", Slot = "4")]
	public void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[PPAOGIPHJFC(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[IJDEKFPGEPI]
public struct LAPCHEMILBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private uint BOMOHIJNMOA;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[IJDEKFPGEPI]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[PPAOGIPHJFC(9898405628982320166uL, 2023375009558162791uL)]
public struct PMOIJMBBACP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[AKOJJKEJPDD(1)]
	public CAAHMGGJHLL KNKCDADLMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[AKOJJKEJPDD(2)]
	public MAJCNGCEJND CDMOGCAIPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[AKOJJKEJPDD(3)]
	[NNLPEHDJBMB(0)]
	public bool EHBOEAHEMCO;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly OAKAMBGJFHE<PMOIJMBBACP> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[IJDEKFPGEPI]
[PPAOGIPHJFC(9807788745867066359uL, 15168486114979071194uL)]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct OFEDODAFJHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[AKOJJKEJPDD(1)]
	public CAAHMGGJHLL KNKCDADLMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[AKOJJKEJPDD(2)]
	public MAJCNGCEJND CDMOGCAIPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[AKOJJKEJPDD(3)]
	[NNLPEHDJBMB(0)]
	public bool EHBOEAHEMCO;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly OAKAMBGJFHE<OFEDODAFJHL> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[PPAOGIPHJFC(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[IJDEKFPGEPI]
public struct BLMJHMPDBBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[JENIHFOLKGA(1)]
	public CAAHMGGJHLL KNKCDADLMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[AKOJJKEJPDD(2)]
	public MAJCNGCEJND CDMOGCAIPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[NNLPEHDJBMB(0)]
	[AKOJJKEJPDD(3)]
	public MKFBFFODLEF IFNOBDCLCHE;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly OAKAMBGJFHE<BLMJHMPDBBI> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[PPAOGIPHJFC(12226092714547765037uL, 15970362445488810630uL)]
[IJDEKFPGEPI]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct CJIKDCPNPNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	[AKOJJKEJPDD(2)]
	public MAJCNGCEJND CDMOGCAIPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[AKOJJKEJPDD(3)]
	[NNLPEHDJBMB(0)]
	public MKFBFFODLEF IFNOBDCLCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[JENIHFOLKGA(4)]
	public CAAHMGGJHLL KNKCDADLMEC;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly OAKAMBGJFHE<CJIKDCPNPNM> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[IJDEKFPGEPI]
[PPAOGIPHJFC(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct PDIGEOHDOMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public int KPAOMMBEJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	[AKOJJKEJPDD(2)]
	public bool CGPCHIKJDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	[AKOJJKEJPDD(3)]
	public bool DLNPGNMFHAO;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly OAKAMBGJFHE<PDIGEOHDOMA> DOPLKALBEDL;
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[PPAOGIPHJFC(5861057081882613294uL, 13746475565109640919uL)]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[IJDEKFPGEPI]
public struct IIAFIHCDOJC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[JBIFGDDKOKM(0, 1)]
	public enum KHFJGNDMNPE
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
	[AKOJJKEJPDD(1)]
	public KHFJGNDMNPE FIELFBKDDDJ;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[PPAOGIPHJFC(14327281633525910712uL, 2559857777606771911uL)]
[IJDEKFPGEPI]
public struct AJNMMKMIIAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	[AKOJJKEJPDD(1)]
	public AILCPGEEFDG GHLJMGMIJJK;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[IJDEKFPGEPI]
[PPAOGIPHJFC(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct GDAJOIOCJIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	[AKOJJKEJPDD(1)]
	public AILCPGEEFDG GHLJMGMIJJK;
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[IJDEKFPGEPI]
[PPAOGIPHJFC(1029043735688538310uL, 14256247939851101839uL)]
public struct AEKLMALECOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public LEONPEKFPMG CBBCBHMDHCL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[PPAOGIPHJFC(17667479821163689808uL, 11946378475791123970uL)]
[IJDEKFPGEPI]
public struct DIEEHCPBOJM : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : GCOJLFMNBGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x609C190", Offset = "0x609AF90", VA = "0x18609C190", Slot = "4")]
		public sealed override void JJAGLGCGGEG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class HLEBJBICNCP : ContainerPropertyBag<EBINCHGKKLK>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class FPLKFJBFAEC : Property<EBINCHGKKLK, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6094700", Offset = "0x6093500", VA = "0x186094700", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x60946C0", Offset = "0x60934C0", VA = "0x1860946C0")]
		public FPLKFJBFAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6094550", Offset = "0x6093350", VA = "0x186094550", Slot = "14")]
		public override Rigidbody GetValue(EBINCHGKKLK KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6094570", Offset = "0x6093370", VA = "0x186094570", Slot = "15")]
		public override void SetValue(EBINCHGKKLK KDNLDLIFDLH, Rigidbody MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6095280", Offset = "0x6094080", VA = "0x186095280")]
	public HLEBJBICNCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class OGCFADDJNBH : ContainerPropertyBag<MECMLOLGMOL>
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class FKJHCNCIHHI : Property<MECMLOLGMOL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x60945E0", Offset = "0x60933E0", VA = "0x1860945E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x60945A0", Offset = "0x60933A0", VA = "0x1860945A0")]
		public FKJHCNCIHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6094550", Offset = "0x6093350", VA = "0x186094550", Slot = "14")]
		public override object GetValue(MECMLOLGMOL KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6094570", Offset = "0x6093370", VA = "0x186094570", Slot = "15")]
		public override void SetValue(MECMLOLGMOL KDNLDLIFDLH, object MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x609ABA0", Offset = "0x60999A0", VA = "0x18609ABA0")]
	public OGCFADDJNBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal class GEKBAIPGHDF : ContainerPropertyBag<BIJBPBBMCON>
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class KEACGNKCIDC : Property<BIJBPBBMCON, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6096050", Offset = "0x6094E50", VA = "0x186096050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6096010", Offset = "0x6094E10", VA = "0x186096010")]
		public KEACGNKCIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6094550", Offset = "0x6093350", VA = "0x186094550", Slot = "14")]
		public override object GetValue(BIJBPBBMCON KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6094570", Offset = "0x6093370", VA = "0x186094570", Slot = "15")]
		public override void SetValue(BIJBPBBMCON KDNLDLIFDLH, object MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x60949A0", Offset = "0x60937A0", VA = "0x1860949A0")]
	public GEKBAIPGHDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class JPJOHOHDACC : ContainerPropertyBag<MJANNLCIABH>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class NILEFJAEFME : Property<MJANNLCIABH, FHGIILMILDH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x609A6E0", Offset = "0x60994E0", VA = "0x18609A6E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x609A6A0", Offset = "0x60994A0", VA = "0x18609A6A0")]
		public NILEFJAEFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6094550", Offset = "0x6093350", VA = "0x186094550", Slot = "14")]
		public override FHGIILMILDH GetValue(MJANNLCIABH KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6094570", Offset = "0x6093370", VA = "0x186094570", Slot = "15")]
		public override void SetValue(MJANNLCIABH KDNLDLIFDLH, FHGIILMILDH MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6095D50", Offset = "0x6094B50", VA = "0x186095D50")]
	public JPJOHOHDACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal class JIHEFEBKMNF : ContainerPropertyBag<NABCIGCHFFA>
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class FOAPMFPILMI : Property<NABCIGCHFFA, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6094690", Offset = "0x6093490", VA = "0x186094690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6094650", Offset = "0x6093450", VA = "0x186094650")]
		public FOAPMFPILMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6094610", Offset = "0x6093410", VA = "0x186094610", Slot = "14")]
		public override int GetValue(NABCIGCHFFA KDNLDLIFDLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6094630", Offset = "0x6093430", VA = "0x186094630", Slot = "15")]
		public override void SetValue(NABCIGCHFFA KDNLDLIFDLH, int MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class EAPADMANHMO : Property<NABCIGCHFFA, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6093E30", Offset = "0x6092C30", VA = "0x186093E30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6093DF0", Offset = "0x6092BF0", VA = "0x186093DF0")]
		public EAPADMANHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6093DB0", Offset = "0x6092BB0", VA = "0x186093DB0", Slot = "14")]
		public override int GetValue(NABCIGCHFFA KDNLDLIFDLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6093DD0", Offset = "0x6092BD0", VA = "0x186093DD0", Slot = "15")]
		public override void SetValue(NABCIGCHFFA KDNLDLIFDLH, int MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class FJJFCPKBKAG : Property<NABCIGCHFFA, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6094520", Offset = "0x6093320", VA = "0x186094520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60944E0", Offset = "0x60932E0", VA = "0x1860944E0")]
		public FJJFCPKBKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6094490", Offset = "0x6093290", VA = "0x186094490", Slot = "14")]
		public override GameObject GetValue(NABCIGCHFFA KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x60944B0", Offset = "0x60932B0", VA = "0x1860944B0", Slot = "15")]
		public override void SetValue(NABCIGCHFFA KDNLDLIFDLH, GameObject MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6095950", Offset = "0x6094750", VA = "0x186095950")]
	public JIHEFEBKMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class PKOAMCNAGPB : ContainerPropertyBag<CCACOEJGNLJ>
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class JEEKJDFANOL : Property<CCACOEJGNLJ, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6095920", Offset = "0x6094720", VA = "0x186095920", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x60958E0", Offset = "0x60946E0", VA = "0x1860958E0")]
		public JEEKJDFANOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6095890", Offset = "0x6094690", VA = "0x186095890", Slot = "14")]
		public override SerializableGuid GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60958C0", Offset = "0x60946C0", VA = "0x1860958C0", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, SerializableGuid MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class NMLMDLPHGND : Property<CCACOEJGNLJ, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x609A810", Offset = "0x6099610", VA = "0x18609A810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x609A7D0", Offset = "0x60995D0", VA = "0x18609A7D0")]
		public NMLMDLPHGND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x609A780", Offset = "0x6099580", VA = "0x18609A780", Slot = "14")]
		public override List<int> GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x609A7A0", Offset = "0x60995A0", VA = "0x18609A7A0", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, List<int> MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class GFJLLHILFLK : Property<CCACOEJGNLJ, List<CCACOEJGNLJ.LHKAGIOFNBO>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6094B10", Offset = "0x6093910", VA = "0x186094B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6094AD0", Offset = "0x60938D0", VA = "0x186094AD0")]
		public GFJLLHILFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6094A80", Offset = "0x6093880", VA = "0x186094A80", Slot = "14")]
		public override List<CCACOEJGNLJ.LHKAGIOFNBO> GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6094AA0", Offset = "0x60938A0", VA = "0x186094AA0", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, List<CCACOEJGNLJ.LHKAGIOFNBO> MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class OFPBKMOKELB : Property<CCACOEJGNLJ, List<CCACOEJGNLJ.MFIKAHFMGLP>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x609AB70", Offset = "0x6099970", VA = "0x18609AB70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x609AB30", Offset = "0x6099930", VA = "0x18609AB30")]
		public OFPBKMOKELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x609AAE0", Offset = "0x60998E0", VA = "0x18609AAE0", Slot = "14")]
		public override List<CCACOEJGNLJ.MFIKAHFMGLP> GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x609AB00", Offset = "0x6099900", VA = "0x18609AB00", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, List<CCACOEJGNLJ.MFIKAHFMGLP> MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class NOJCBCOCECE : Property<CCACOEJGNLJ, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x609A8D0", Offset = "0x60996D0", VA = "0x18609A8D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x609A890", Offset = "0x6099690", VA = "0x18609A890")]
		public NOJCBCOCECE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x609A840", Offset = "0x6099640", VA = "0x18609A840", Slot = "14")]
		public override GameObject GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x609A860", Offset = "0x6099660", VA = "0x18609A860", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, GameObject MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private class KLPEFCNKDKH : Property<CCACOEJGNLJ, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x60961F0", Offset = "0x6094FF0", VA = "0x1860961F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60961B0", Offset = "0x6094FB0", VA = "0x1860961B0")]
		public KLPEFCNKDKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6096160", Offset = "0x6094F60", VA = "0x186096160", Slot = "14")]
		public override Light GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6096180", Offset = "0x6094F80", VA = "0x186096180", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, Light MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class GKGEFIODABK : Property<CCACOEJGNLJ, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6095050", Offset = "0x6093E50", VA = "0x186095050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6095010", Offset = "0x6093E10", VA = "0x186095010")]
		public GKGEFIODABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6094FC0", Offset = "0x6093DC0", VA = "0x186094FC0", Slot = "14")]
		public override Collider GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6094FE0", Offset = "0x6093DE0", VA = "0x186094FE0", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, Collider MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	private class LGANCEGKPFI : Property<CCACOEJGNLJ, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x60966A0", Offset = "0x60954A0", VA = "0x1860966A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6096660", Offset = "0x6095460", VA = "0x186096660")]
		public LGANCEGKPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6096610", Offset = "0x6095410", VA = "0x186096610", Slot = "14")]
		public override string GetValue(CCACOEJGNLJ KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6096630", Offset = "0x6095430", VA = "0x186096630", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ KDNLDLIFDLH, string MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x609ADA0", Offset = "0x6099BA0", VA = "0x18609ADA0")]
	public PKOAMCNAGPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal class BGOJCCIEKCC : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class LEODNAFBAIA : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6096500", Offset = "0x6095300", VA = "0x186096500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6096410", Offset = "0x6095210", VA = "0x186096410")]
		public LEODNAFBAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "14")]
		public override Data128 GetValue(SerializableGuid KDNLDLIFDLH)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6096400", Offset = "0x6095200", VA = "0x186096400", Slot = "15")]
		public override void SetValue(SerializableGuid KDNLDLIFDLH, Data128 MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6093310", Offset = "0x6092110", VA = "0x186093310")]
	public BGOJCCIEKCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class GIKNGGNAGFJ : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class DANNOFHNJPF : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6093B40", Offset = "0x6092940", VA = "0x186093B40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6093A50", Offset = "0x6092850", VA = "0x186093A50")]
		public DANNOFHNJPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x13155F0", Offset = "0x13143F0", VA = "0x1813155F0", Slot = "14")]
		public override int GetValue(Data128 KDNLDLIFDLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6093810", Offset = "0x6092610", VA = "0x186093810", Slot = "15")]
		public override void SetValue(Data128 KDNLDLIFDLH, int MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	private class NADGGCAMLML : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x60970F0", Offset = "0x6095EF0", VA = "0x1860970F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6097000", Offset = "0x6095E00", VA = "0x186097000")]
		public NADGGCAMLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6096FE0", Offset = "0x6095DE0", VA = "0x186096FE0", Slot = "14")]
		public override int GetValue(Data128 KDNLDLIFDLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6096FF0", Offset = "0x6095DF0", VA = "0x186096FF0", Slot = "15")]
		public override void SetValue(Data128 KDNLDLIFDLH, int MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	private class BDDKECOMIOO : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x60932E0", Offset = "0x60920E0", VA = "0x1860932E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x60931F0", Offset = "0x6091FF0", VA = "0x1860931F0")]
		public BDDKECOMIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x15DE730", Offset = "0x15DD530", VA = "0x1815DE730", Slot = "14")]
		public override int GetValue(Data128 KDNLDLIFDLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60931E0", Offset = "0x6091FE0", VA = "0x1860931E0", Slot = "15")]
		public override void SetValue(Data128 KDNLDLIFDLH, int MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class MBNDILOGAIO : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6096C40", Offset = "0x6095A40", VA = "0x186096C40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6096B50", Offset = "0x6095950", VA = "0x186096B50")]
		public MBNDILOGAIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6096B30", Offset = "0x6095930", VA = "0x186096B30", Slot = "14")]
		public override int GetValue(Data128 KDNLDLIFDLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6096B40", Offset = "0x6095940", VA = "0x186096B40", Slot = "15")]
		public override void SetValue(Data128 KDNLDLIFDLH, int MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6094B40", Offset = "0x6093940", VA = "0x186094B40")]
	public GIKNGGNAGFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class EJNEDIMBPEN : ContainerPropertyBag<CCACOEJGNLJ.LHKAGIOFNBO>
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class MJHLEKHDJOE : Property<CCACOEJGNLJ.LHKAGIOFNBO, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x6096F50", Offset = "0x6095D50", VA = "0x186096F50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6096F10", Offset = "0x6095D10", VA = "0x186096F10")]
		public MJHLEKHDJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x921C80", Offset = "0x920A80", VA = "0x180921C80", Slot = "14")]
		public override Vector3 GetValue(CCACOEJGNLJ.LHKAGIOFNBO KDNLDLIFDLH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6096EF0", Offset = "0x6095CF0", VA = "0x186096EF0", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ.LHKAGIOFNBO KDNLDLIFDLH, Vector3 MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	private class MIEPGAMKPMP : Property<CCACOEJGNLJ.LHKAGIOFNBO, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6096E50", Offset = "0x6095C50", VA = "0x186096E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6096E10", Offset = "0x6095C10", VA = "0x186096E10")]
		public MIEPGAMKPMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6096DF0", Offset = "0x6095BF0", VA = "0x186096DF0", Slot = "14")]
		public override List<SerializableGuid> GetValue(CCACOEJGNLJ.LHKAGIOFNBO KDNLDLIFDLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6096E00", Offset = "0x6095C00", VA = "0x186096E00", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ.LHKAGIOFNBO KDNLDLIFDLH, List<SerializableGuid> MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6094020", Offset = "0x6092E20", VA = "0x186094020")]
	public EJNEDIMBPEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class JMKABCEOHBA : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	private class GDFFFFHGCBJ : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6094970", Offset = "0x6093770", VA = "0x186094970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6094930", Offset = "0x6093730", VA = "0x186094930")]
		public GDFFFFHGCBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6094910", Offset = "0x6093710", VA = "0x186094910", Slot = "14")]
		public override float GetValue(Vector3 KDNLDLIFDLH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6094920", Offset = "0x6093720", VA = "0x186094920", Slot = "15")]
		public override void SetValue(Vector3 KDNLDLIFDLH, float MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class EOCDOLLGFFI : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6094250", Offset = "0x6093050", VA = "0x186094250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6094210", Offset = "0x6093010", VA = "0x186094210")]
		public EOCDOLLGFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x60941F0", Offset = "0x6092FF0", VA = "0x1860941F0", Slot = "14")]
		public override float GetValue(Vector3 KDNLDLIFDLH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6094200", Offset = "0x6093000", VA = "0x186094200", Slot = "15")]
		public override void SetValue(Vector3 KDNLDLIFDLH, float MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	private class LEJAAIOPDCM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x60963D0", Offset = "0x60951D0", VA = "0x1860963D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6096390", Offset = "0x6095190", VA = "0x186096390")]
		public LEJAAIOPDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x19D78F0", Offset = "0x19D66F0", VA = "0x1819D78F0", Slot = "14")]
		public override float GetValue(Vector3 KDNLDLIFDLH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6096380", Offset = "0x6095180", VA = "0x186096380", Slot = "15")]
		public override void SetValue(Vector3 KDNLDLIFDLH, float MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6095BB0", Offset = "0x60949B0", VA = "0x186095BB0")]
	public JMKABCEOHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class NIBIKECJMIL : ContainerPropertyBag<CCACOEJGNLJ.MFIKAHFMGLP>
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	private class AAIGAFFBIDG : Property<CCACOEJGNLJ.MFIKAHFMGLP, CCACOEJGNLJ.LHKAGIOFNBO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x60930A0", Offset = "0x6091EA0", VA = "0x1860930A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6093060", Offset = "0x6091E60", VA = "0x186093060")]
		public AAIGAFFBIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6092FF0", Offset = "0x6091DF0", VA = "0x186092FF0", Slot = "14")]
		public override CCACOEJGNLJ.LHKAGIOFNBO GetValue(CCACOEJGNLJ.MFIKAHFMGLP KDNLDLIFDLH)
		{
			return default(CCACOEJGNLJ.LHKAGIOFNBO);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6093020", Offset = "0x6091E20", VA = "0x186093020", Slot = "15")]
		public override void SetValue(CCACOEJGNLJ.MFIKAHFMGLP KDNLDLIFDLH, CCACOEJGNLJ.LHKAGIOFNBO MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x609A5C0", Offset = "0x60993C0", VA = "0x18609A5C0")]
	public NIBIKECJMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal class GPPIGEHDLCD : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	private class CHMOHNFAOHF : Property<RRObjectPrefabV2Data, AILCPGEEFDG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string BAAGNNPAEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x6093860", Offset = "0x6092660", VA = "0x186093860", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool CEHPCHNOICL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6093820", Offset = "0x6092620", VA = "0x186093820")]
		public CHMOHNFAOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x13155F0", Offset = "0x13143F0", VA = "0x1813155F0", Slot = "14")]
		public override AILCPGEEFDG GetValue(RRObjectPrefabV2Data KDNLDLIFDLH)
		{
			return default(AILCPGEEFDG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6093810", Offset = "0x6092610", VA = "0x186093810", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data KDNLDLIFDLH, AILCPGEEFDG MBDKMNBCLGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6095080", Offset = "0x6093E80", VA = "0x186095080")]
	public GPPIGEHDLCD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x609B2C0", Offset = "0x609A0C0", VA = "0x18609B2C0")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000126")]
public class LBMBDANPICH
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public LBMBDANPICH()
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

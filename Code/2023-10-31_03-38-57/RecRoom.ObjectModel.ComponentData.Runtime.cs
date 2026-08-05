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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PEEANCJNEFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode MIEPGEKOHHC;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FJGDDBCFBEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public AKBGEPMPOEB HAABAOBBLFC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly DLFNBFPKEBB<FJGDDBCFBEF> BDJLOIHNJNG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DHPMAHLFKEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DLILCDPMCKK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AKBGEPMPOEB
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
public struct BCLMMIMBGOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct DDCCHIBJAJH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity JHAODPLJNCN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EBGLOKMLEEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity EBFCMPBKGBM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DEAMMBNLFOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LNIEJGLPFGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity OGEFIHKILIO;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LPMBPIFGCLI : MKCCIJEBDNJ, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CJHIPCBDNGG OPKIADLJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(CJHIPCBDNGG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CKAFIIEMFNH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 JCMGECPCAMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FDOMAENBEGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KMEHJKKAJAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 KOCDIBFJMBC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly DLFNBFPKEBB<GHNHPHEJBHC> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GHNHPHEJBHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 KOCDIBFJMBC;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly DLFNBFPKEBB<GHNHPHEJBHC> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EPNKMIAIFKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 OMIFCEPAJEL;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FEEFALEIPKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 MKEMNFNIHMB;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EMPKFJEFBIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float KKLADGIKIBL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly DLFNBFPKEBB<EMPKFJEFBIJ> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IPDFFKBKNAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float HHMIADFKJAI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly DLFNBFPKEBB<IPDFFKBKNAP> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PFBPNOMONDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 FPKHOCOFJCF;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PKJBKBEDOFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NCDNMOIPOGI LBALPLBNKBN;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DNHMLCMEAHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NCDNMOIPOGI JJIGKEKLMNN;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[JDEFKFOMDEI]
public struct GLHLEHPAIKC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity FILKDLNBIJH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GDKIMAMJPEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FOEDAHNFGCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct COLDFFLIDGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct KGNLIKNKOFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints GKGKDAIJEED;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NNJNCFGPHCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float GNFCIEFCAMO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly DLFNBFPKEBB<NNJNCFGPHCH> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JIOBDPNNBHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float MAGMOODPFMF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct JBOPJCJKEOE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BHOOAFFHGFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int DJINFINAIND;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBC9740", Offset = "0xBC8B40", VA = "0x180BC9740")]
	public static BHOOAFFHGFP BNPEICKPPJA(int EOHMJBFGDPD)
	{
		return default(BHOOAFFHGFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KKBOPBPDFDH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody IMHHODKMCIF;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D35490", Offset = "0x5D34890", VA = "0x185D35490", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KKBOPBPDFDH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct BBFKOLJIMCA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BDKAHCGHDPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 BADJPOOCLHC;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct GPMHBAIFKEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 GKMPFMKFGID;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct AMOBANHBLFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float NFPAKGGOIFM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DLFNBFPKEBB<AMOBANHBLFP> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OBLCBMBAPLL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object LICGDGCIIAO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D36860", Offset = "0x5D35C60", VA = "0x185D36860", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OBLCBMBAPLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class KKDHDHJHHGM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object DCOFLDCLIFB;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D35500", Offset = "0x5D34900", VA = "0x185D35500", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KKDHDHJHHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum NCDNMOIPOGI
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum CEAJINAKHIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CMHAFMKPEIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APDEAFCKNDE(AKBGEPMPOEB MMFHEIEDPEL, AKBGEPMPOEB FIFGGNDENCP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOPOMNEKBAN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLCLFKGFNGB();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPEOPDBIOFK(bool JOAAGNJLPGK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IDNBMLHGDPE();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOMDHNAMCAE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IJMHKDPIKCB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public CMHAFMKPEIJ IKPFKOANACL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D345E0", Offset = "0x5D339E0", VA = "0x185D345E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IJMHKDPIKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class IADDCEKFKJM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(CBJELEJDOHN nameHash, AIPJMJJAMPA stableTypeHash, Type type)> PEDCFPCDOMB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(CBJELEJDOHN nameHash, AIPJMJJAMPA stableTypeHash, Type type)> PLBLICDMNHI;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(CBJELEJDOHN previousNameHash, AIPJMJJAMPA previousStableTypeHash, Type currentTypeName)> NGNIENIKCMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct BGGGHLMDFGB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, OLCDGJMALOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F760", Offset = "0x5D2EB60", VA = "0x185D2F760", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
[OEADGNLJPMD]
public struct CBFFFGCNAML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[EAFCOINKCNB(1)]
	public quaternion CMOGOLPKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[EAFCOINKCNB(2)]
	public float3 DPHLBKLFIPE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly DLFNBFPKEBB<CBFFFGCNAML> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x395D090", Offset = "0x395C490", VA = "0x18395D090")]
	public CBFFFGCNAML(quaternion CMOGOLPKHJO, float3 DPHLBKLFIPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FA10", Offset = "0x5D2EE10", VA = "0x185D2FA10")]
	public static CBFFFGCNAML BNPEICKPPJA(RigidTransform DPJEBGDEPHK)
	{
		return default(CBFFFGCNAML);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PGCGBBINDFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[OEADGNLJPMD]
public struct FAICCAODHCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[EAFCOINKCNB(1)]
	public float BKLOJAMMHDA;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly DLFNBFPKEBB<FAICCAODHCD> BDJLOIHNJNG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[OEADGNLJPMD]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, OLCDGJMALOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[EAFCOINKCNB(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F770", Offset = "0x5D2EB70", VA = "0x185D2F770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GLODEBGBJAN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, OLCDGJMALOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct CGHIPAHLAOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct DGGFBJPDOBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[EAFCOINKCNB(1)]
	public SerializableGuid EKIGMNBCJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[EAFCOINKCNB(2)]
	public SerializableGuid PDHLDIFODOP;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
[OEADGNLJPMD]
public struct MEBFJJJGPPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[EAFCOINKCNB(1)]
	public Entity DCLLGDLJCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[EAFCOINKCNB(2)]
	public uint IMPIMKLFLDN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EntityBundlePartId PDKOPJKDKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1C782F0", Offset = "0x1C776F0", VA = "0x181C782F0")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1C7AC30", Offset = "0x1C7A030", VA = "0x181C7AC30")]
	public MEBFJJJGPPA(Entity DCLLGDLJCDH, EntityBundlePartId BLLBKIFLMHN)
	{
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAC0", Offset = "0x7DEEC0", VA = "0x1807DFAC0")]
		internal EntityBundlePartId(uint PIKCMFPLBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		internal uint LNOLHBDGCMH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1642020", VA = "0x181642C20", Slot = "4")]
		public bool Equals(EntityBundlePartId LJIBJAOOGGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D306D0", Offset = "0x5D2FAD0", VA = "0x185D306D0", Slot = "0")]
		public override bool Equals(object BAFDGKKJJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E8640", Offset = "0x7E7A40", VA = "0x1807E8640", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1642C40", Offset = "0x1642040", VA = "0x181642C40")]
		public static bool MEMFAJGIIAO(EntityBundlePartId IFAOGMEBPFN, EntityBundlePartId DNPBOPMFFFF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct MPHIBPINOKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity JHBOBCNAFFD;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PLNNOOGNGHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity JHBOBCNAFFD;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[OEADGNLJPMD]
[CKOCBJPEPBI("Container", 0)]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
public struct IOIOGBEHOCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(1)]
	public JHONAEGJBJL GOJIBFLGAID;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly DLFNBFPKEBB<IOIOGBEHOCO> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[BBCLLCJPNBE(0, 127)]
public enum JHONAEGJBJL
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
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OHEBLBBJELJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum PKNCJBPGLJA
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

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum HOHGGNDNEAE
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

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D369F0", Offset = "0x5D35DF0", VA = "0x185D369F0")]
	public static (PKNCJBPGLJA, HOHGGNDNEAE) PJEOCLJBGJK(this JHONAEGJBJL ALDHADGKGIB)
	{
		return default((PKNCJBPGLJA, HOHGGNDNEAE));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[CKOCBJPEPBI("Container", 0)]
public struct DLIOHLHECNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(1)]
	public BIPCOEBMACL FPIGOHGCHMA;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly DLFNBFPKEBB<DLIOHLHECNO> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BBCLLCJPNBE(0, 2)]
public enum BIPCOEBMACL
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
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[OEADGNLJPMD]
[CKOCBJPEPBI("Container", 0)]
public struct BBFODHJCEHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(1)]
	public FCEMCBKNAEB JGMEFAHDHAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BBCLLCJPNBE(0, 15943)]
[Flags]
public enum FCEMCBKNAEB
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
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct HJMLJBOBMEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AOMJAJNCHOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct FLFFPIBJKCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct KBCJHCAHGAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct CEKCPHOOMIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct BCAAMEGJJOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct GBPNJDCILBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct HPHCJHHNKHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct MIFCOLDNHIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[CKOCBJPEPBI("Container", 0)]
public struct MHKHPPLBBIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[EAFCOINKCNB(1)]
	[GLDLDEEEPFJ(0)]
	public float EIEGGECHILO;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[CKOCBJPEPBI("Container", 0)]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[OEADGNLJPMD]
public struct PBEMIJCGNON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[EAFCOINKCNB(1)]
	[GLDLDEEEPFJ(0)]
	public FixedString64Bytes LFAIHEECJFK;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct ALICEELGBJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<HOGGGGKFFCP> BJEJBGEKBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<Entity> IMOHCKCFKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JobHandle IJAGDFPAFEE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ONBNDEEHGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F500", Offset = "0x5D2E900", VA = "0x185D2F500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F330", Offset = "0x5D2E730", VA = "0x185D2F330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42B80C0", Offset = "0x42B74C0", VA = "0x1842B80C0")]
	public ALICEELGBJJ(NativeList<HOGGGGKFFCP> BJEJBGEKBMB, NativeList<Entity> IMOHCKCFKFC, JobHandle IJAGDFPAFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F380", Offset = "0x5D2E780", VA = "0x185D2F380")]
	public (Entity, NativeSlice<Entity>) CPECIFLFMEE(int KEFLNPGBJEJ)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F4A0", Offset = "0x5D2E8A0", VA = "0x185D2F4A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct HOGGGGKFFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity OGEFIHKILIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int APBJNEFOGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int KIHHOMBMMEI;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface EMBPHMDELIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLLCJPLLBFC(bool LECAJJLHOIG);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[CKOCBJPEPBI("Container", 0)]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[OEADGNLJPMD]
public struct DBFKJOHGBKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[EAFCOINKCNB(1)]
	[GLDLDEEEPFJ(0)]
	public IFIHINKEGCP FIFEEDMNCEE;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[BBCLLCJPNBE(0, 1)]
public enum IFIHINKEGCP
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
[Cpp2IlInjected.Token(Token = "0x2000056")]
[EAOLIPGCLNN(1)]
public struct NHDPLENDLGL : IComparable<NHDPLENDLGL>, IEquatable<NHDPLENDLGL>, OGIDOOLIEGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[GKICOLMAKAA(1)]
	public uint KNKPLPKMGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[GKICOLMAKAA(2)]
	public uint FCLFGAIEPKE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private uint FCOCPKFBBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D36190", Offset = "0x5D35590", VA = "0x185D36190")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D36360", Offset = "0x5D35760", VA = "0x185D36360")]
	public NHDPLENDLGL(int KNKPLPKMGPP, int HPGEABFBBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D36360", Offset = "0x5D35760", VA = "0x185D36360")]
	public NHDPLENDLGL(uint KNKPLPKMGPP, uint HPGEABFBBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D360A0", Offset = "0x5D354A0", VA = "0x185D360A0")]
	public NHDPLENDLGL FBAGJNCGKJM(int APBJNEFOGOC = 1)
	{
		return default(NHDPLENDLGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D35EE0", Offset = "0x5D352E0", VA = "0x185D35EE0")]
	public NHDPLENDLGL AHNHIHJLPCM(int APBJNEFOGOC = 1)
	{
		return default(NHDPLENDLGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D35F70", Offset = "0x5D35370", VA = "0x185D35F70")]
	public static NHDPLENDLGL EKPMDGDKNHN(NHDPLENDLGL GFPOLPOKADD, NHDPLENDLGL PBBDJDKAOCN)
	{
		return default(NHDPLENDLGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D36160", Offset = "0x5D35560", VA = "0x185D36160")]
	private static uint MPFOEOAPIKI(uint IFAOGMEBPFN, uint DNPBOPMFFFF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D35F50", Offset = "0x5D35350", VA = "0x185D35F50", Slot = "4")]
	public int CompareTo(NHDPLENDLGL LJIBJAOOGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D36010", Offset = "0x5D35410", VA = "0x185D36010", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D36280", Offset = "0x5D35680", VA = "0x185D36280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D35FF0", Offset = "0x5D353F0", VA = "0x185D35FF0", Slot = "5")]
	public bool Equals(NHDPLENDLGL LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D36110", Offset = "0x5D35510", VA = "0x185D36110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D36210", Offset = "0x5D35610", VA = "0x185D36210", Slot = "6")]
	public void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D361A0", Offset = "0x5D355A0", VA = "0x185D361A0", Slot = "7")]
	public void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2252080", Offset = "0x2251480", VA = "0x182252080")]
	public static bool MEMFAJGIIAO(NHDPLENDLGL GFPOLPOKADD, NHDPLENDLGL PBBDJDKAOCN)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[EAOLIPGCLNN(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[GKICOLMAKAA(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[GKICOLMAKAA(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[GKICOLMAKAA(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[GKICOLMAKAA(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[EAOLIPGCLNN(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, OGIDOOLIEGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[GKICOLMAKAA(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
		public static SerializableGuid BNPEICKPPJA(Guid OGGNLGCIGBJ)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D37DA0", Offset = "0x5D371A0", VA = "0x185D37DA0", Slot = "4")]
		public bool Equals(SerializableGuid LJIBJAOOGGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5D37D80", Offset = "0x5D37180", VA = "0x185D37D80", Slot = "5")]
		public int CompareTo(SerializableGuid LJIBJAOOGGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5D37E50", Offset = "0x5D37250", VA = "0x185D37E50", Slot = "6")]
		public void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D37DD0", Offset = "0x5D371D0", VA = "0x185D37DD0", Slot = "7")]
		public void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D37F10", Offset = "0x5D37310", VA = "0x185D37F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct ODLBCNBKLEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
[OEADGNLJPMD]
public struct FHMCFEBGANG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[EAFCOINKCNB(1)]
	public Entity BGICHGONLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[EAFCOINKCNB(2)]
	public bool JGHAPCHIFLD;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
[OEADGNLJPMD]
public struct KFKDNOCAOEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[EAFCOINKCNB(1)]
	public GHDMILHLBBK LGHDHDPCOIG;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[BBCLLCJPNBE(0, 4)]
public enum GHDMILHLBBK
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
[OEADGNLJPMD]
public struct BADEEAEDENA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[EAFCOINKCNB(1)]
	public Entity BGICHGONLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[EAFCOINKCNB(2)]
	public bool PBMCBNAOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[EAFCOINKCNB(3)]
	public float GMIIIMIFGHC;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[OEADGNLJPMD]
public struct MJAKFHFNJEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[EAFCOINKCNB(1)]
	public bool PIOPMIBANBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[EAFCOINKCNB(2)]
	public bool PBMCBNAOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[EAFCOINKCNB(3)]
	public float CMCKBKMFKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[EAFCOINKCNB(4)]
	public float HMHBFKEMPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[EAFCOINKCNB(5)]
	public float NJNDGGPGGKK;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[OEADGNLJPMD]
public struct LBDAMFDPGBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[EAFCOINKCNB(1)]
	public bool PIOPMIBANBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[EAFCOINKCNB(2)]
	public bool PBMCBNAOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[EAFCOINKCNB(3)]
	public float GMIIIMIFGHC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, OLCDGJMALOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F760", Offset = "0x5D2EB60", VA = "0x185D2F760", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[OEADGNLJPMD]
	public struct ParentData : IComponentData, OLCDGJMALOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[EAFCOINKCNB(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, OLCDGJMALOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct DCOJIDIDKGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface OLCDGJMALOC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity PEHFADPIEPE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct KFLILHFHKKP<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly bool AAMDFDDBPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public uint KHLDPDIMBPE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	private static bool BEKOMLINAGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[CKOCBJPEPBI("Light", 0)]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct ALDMEINGNEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[EAFCOINKCNB(1)]
	[GLDLDEEEPFJ(0)]
	public bool EGKJFJONNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(2)]
	public float EKCNCLPMOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[EAFCOINKCNB(3)]
	[GLDLDEEEPFJ(0)]
	public float EFAHGHGDOIA;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[CKOCBJPEPBI("Light", 0)]
public struct ENDDAGNOCGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(1)]
	public float CLEHJAAPBMC;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.TypeVersion(2)]
public struct HBJCJBGLHOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public uint FPLNGIHHGKJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D30EB0", Offset = "0x5D302B0", VA = "0x185D30EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[OEADGNLJPMD]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[GKICOLMAKAA(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct PNOEDJOJCME : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int LIECGMMBAAI;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct GBDDNKFEMOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public GCHandle HDECHENMLKH;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BBCLLCJPNBE(0, 4)]
public enum PAOGJPOGFAD
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct OHBBDBDGALJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct BHKGFHOHFDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int LIECGMMBAAI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CNDLDHPPAAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct KODCNMFIIGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct JMOFHAEKBFF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.TypeVersion(3)]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[OEADGNLJPMD]
[CKOCBJPEPBI("Object", 0)]
public struct LGKPPDFBNFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[EAFCOINKCNB(2)]
	public EEMFPAGDLGB PGJPNLHGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[EAFCOINKCNB(3)]
	[GLDLDEEEPFJ(0)]
	public BFOJEBGGLIC CNBJDGMCJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[EAFCOINKCNB(4)]
	[GLDLDEEEPFJ(0)]
	public HIKIIHDHHAA MCKACALLEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[GKICOLMAKAA(5)]
	public JOMIKKMFJHF JGMEFAHDHAJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static readonly DLFNBFPKEBB<LGKPPDFBNFO> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class HHDMGMLMHMA
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D30FC0", Offset = "0x5D303C0", VA = "0x185D30FC0")]
	public static void GMFKOPHMECD(this JOMIKKMFJHF JGMEFAHDHAJ, JPPEPEIKMNE DIEMEDAILAN, bool MBDDGEBPNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D31010", Offset = "0x5D30410", VA = "0x185D31010")]
	public static bool OFPEPDEFDJF(this JOMIKKMFJHF JGMEFAHDHAJ, JPPEPEIKMNE DIEMEDAILAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D30FB0", Offset = "0x5D303B0", VA = "0x185D30FB0")]
	public static JOMIKKMFJHF GCBKPIGHAJI(this JPPEPEIKMNE DIEMEDAILAN)
	{
		return default(JOMIKKMFJHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D30FF0", Offset = "0x5D303F0", VA = "0x185D30FF0")]
	public static void GMFKOPHMECD(this BFOJEBGGLIC JGMEFAHDHAJ, BFOJEBGGLIC MIIJFFOGLNG, bool MBDDGEBPNPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5C588C0", Offset = "0x5C57CC0", VA = "0x185C588C0")]
	public static bool OFPEPDEFDJF(this BFOJEBGGLIC JGMEFAHDHAJ, BFOJEBGGLIC DIEMEDAILAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public enum JPPEPEIKMNE
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
[Cpp2IlInjected.Token(Token = "0x2000075")]
[BBCLLCJPNBE(0, 16383)]
[Flags]
public enum JOMIKKMFJHF
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
[Cpp2IlInjected.Token(Token = "0x2000076")]
[Flags]
[BBCLLCJPNBE(0, 3)]
public enum BFOJEBGGLIC
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
[Cpp2IlInjected.Token(Token = "0x2000077")]
[BBCLLCJPNBE(0, 4)]
[KCACGGILPCC]
public enum HIKIIHDHHAA
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class KCACGGILPCC : EPBPGIPGEFM
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D35310", Offset = "0x5D34710", VA = "0x185D35310", Slot = "7")]
	public override string DBILEHAJOGJ(string EMGLDFIGDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public KCACGGILPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[EAOLIPGCLNN(1)]
public struct EEMFPAGDLGB : OGIDOOLIEGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[GKICOLMAKAA(1)]
	public bool EGKJFJONNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[GKICOLMAKAA(2)]
	public float3 LPFKMEDDGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[GKICOLMAKAA(3)]
	public float3 PBDKBJCKEMP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly DLFNBFPKEBB<EEMFPAGDLGB> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D302F0", Offset = "0x5D2F6F0", VA = "0x185D302F0", Slot = "5")]
	public void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5D30360", Offset = "0x5D2F760", VA = "0x185D30360", Slot = "4")]
	public void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DKOLGLGGMAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PHFNHBJKDIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct CEOKEGPFLNP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LNPBJGDMCGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public FixedString32Bytes LFAIHEECJFK;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[JDEFKFOMDEI]
public struct JJMAEHNEFOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Entity PMDINEBDLOA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static JJMAEHNEFOE BNPEICKPPJA(Entity EOHMJBFGDPD)
	{
		return default(JJMAEHNEFOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct FGLGILPNDDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[EAFCOINKCNB(1)]
	public Entity JAEEGGOEDOO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static FGLGILPNDDB BNPEICKPPJA(Entity FILKDLNBIJH)
	{
		return default(FGLGILPNDDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct CDCJJIOLPNI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Entity FILKDLNBIJH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static CDCJJIOLPNI BNPEICKPPJA(Entity FILKDLNBIJH)
	{
		return default(CDCJJIOLPNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct ELOFBKFAKLG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Entity MDEFHIPOHNI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static ELOFBKFAKLG BNPEICKPPJA(Entity FILKDLNBIJH)
	{
		return default(ELOFBKFAKLG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct CNBLDMFJJHH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[BBCLLCJPNBE(0, 2)]
public enum JKKGODIJMHG
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[CKOCBJPEPBI("Physics", 0)]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct AICPABOPBAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[EAFCOINKCNB(1)]
	[GLDLDEEEPFJ(0)]
	public float LPDCNOGMOJN;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static readonly DLFNBFPKEBB<AICPABOPBAK> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
[OEADGNLJPMD]
public struct DCKEAFDNEPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[EAFCOINKCNB(1)]
	public AFADFPDANEE PDALIFDBDDN;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[BBCLLCJPNBE(-1, 38)]
public enum AFADFPDANEE
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct EKEKCBCPHMC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Flags]
	[BBCLLCJPNBE(0, 7)]
	public enum MGEELPGJGMM
	{
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	[EAFCOINKCNB(1)]
	public MGEELPGJGMM JGMEFAHDHAJ;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static readonly DLFNBFPKEBB<EKEKCBCPHMC> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OGIAJKLBENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D30580", Offset = "0x5D2F980", VA = "0x185D30580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MDDDIKMNPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D30570", Offset = "0x5D2F970", VA = "0x185D30570")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
[OEADGNLJPMD]
public struct KFHHEMBCNNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[EAFCOINKCNB(1)]
	public JKKGODIJMHG PDALIFDBDDN;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct HNBJNBHMKKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public uint FOIKACEEEGH;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[EAOLIPGCLNN(1)]
public struct MHNILHILJOG : OGIDOOLIEGA
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Flags]
	[BBCLLCJPNBE(0, 7)]
	public enum PFHJJIELJID
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[GKICOLMAKAA(1)]
	public float HGJPIIONBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[GKICOLMAKAA(2)]
	public int OGMMMBCAMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[GKICOLMAKAA(3)]
	public PFHJJIELJID JGMEFAHDHAJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool JPHALICKLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C40", Offset = "0x5D35040", VA = "0x185D35C40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C20", Offset = "0x5D35020", VA = "0x185D35C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool DBPLFLOCDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C10", Offset = "0x5D35010", VA = "0x185D35C10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C50", Offset = "0x5D35050", VA = "0x185D35C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HDALLMNCIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C00", Offset = "0x5D35000", VA = "0x185D35C00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C70", Offset = "0x5D35070", VA = "0x185D35C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D35C90", Offset = "0x5D35090", VA = "0x185D35C90", Slot = "5")]
	public void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D35CE0", Offset = "0x5D350E0", VA = "0x185D35CE0", Slot = "4")]
	public void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[JDEFKFOMDEI]
internal struct LLIEPMNOEAM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Entity MMJOMPMOBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public int APOENOPNHBG;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct BOPAAHHJEPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[EAFCOINKCNB(1)]
	public NHDPLENDLGL KKPFCFMEHIH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA2A8A0", Offset = "0xA29CA0", VA = "0x180A2A8A0")]
	public static BOPAAHHJEPL BNPEICKPPJA(NHDPLENDLGL EOHMJBFGDPD)
	{
		return default(BOPAAHHJEPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct KNEGODHIADI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[EAFCOINKCNB(1)]
	public Entity ACICFHDBOLC;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal struct MOIMCOAIDGF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Entity ACICFHDBOLC;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct PJMACGKKJMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[EAFCOINKCNB(1)]
	public float3 DPHLBKLFIPE;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static readonly DLFNBFPKEBB<PJMACGKKJMM> BDJLOIHNJNG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F38730", Offset = "0x1F37B30", VA = "0x181F38730")]
	public static PJMACGKKJMM BNPEICKPPJA(float3 EOHMJBFGDPD)
	{
		return default(PJMACGKKJMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct OJMAOAMNKDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[EAFCOINKCNB(1)]
	public quaternion CMOGOLPKHJO;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly DLFNBFPKEBB<OJMAOAMNKDE> BDJLOIHNJNG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
	public static OJMAOAMNKDE BNPEICKPPJA(quaternion EOHMJBFGDPD)
	{
		return default(OJMAOAMNKDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct ELJOMKLCEJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[EAFCOINKCNB(1)]
	public float3 JHIDGCOCDIJ;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static readonly DLFNBFPKEBB<ELJOMKLCEJJ> BDJLOIHNJNG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F38730", Offset = "0x1F37B30", VA = "0x181F38730")]
	public static ELJOMKLCEJJ BNPEICKPPJA(float3 EOHMJBFGDPD)
	{
		return default(ELJOMKLCEJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct HAKHPKNGODK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[EAFCOINKCNB(1)]
	public MHNILHILJOG ILKHBODBFFI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct IFPBDJOGLMN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct LBGJAPKKMKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public uint KHLDPDIMBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public int GMBKDOECKND;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
	public LBGJAPKKMKF(uint DKNGGGIDEED, int CLNKBDMHLND)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct JMJMACHPNHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct BFJJKEGCPLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HLOMEPPLPLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GOBHHHGNKIK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct EMHELICGGNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct MHGPLEECJKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct JGGHMPIJGCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct GEMJFPKLADF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct HIFCCAJNGEG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct HPBCCLEJEKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal struct BILCEHINPJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct CDJGMMOMENA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal struct GJPEIMHNPHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct GPHNCCNKNKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct LJJHCMNMAJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct EAMDAMACEOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[EAFCOINKCNB(1)]
	public FixedList32Bytes<int> JEBHMNBHGHL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct AMAFHGBKNDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct GFAMNOLMEPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct CNLNGNKOOAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct LBHKCPKDDON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct NAEIOPGNPMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct NPOIHMBLLJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct EJJIPCOLCPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[JDEFKFOMDEI]
public struct LPJAIKEGMMI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public FixedString32Bytes EIDCNFCDMOH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal struct PKIOJJKJEPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal struct GHPBBENLLOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
[OEADGNLJPMD]
public struct ECKAGPNLGGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[GKICOLMAKAA(1)]
	public IIOKGAAOGMJ FOIKACEEEGH;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly DLFNBFPKEBB<ECKAGPNLGGF> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum IIOKGAAOGMJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct JOIAEFPGOBP : IComponentData, IComparable<JOIAEFPGOBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public int EOALOCGAIPN;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x16507C0", Offset = "0x164FBC0", VA = "0x1816507C0", Slot = "4")]
	public int CompareTo(JOIAEFPGOBP LJIBJAOOGGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[OEADGNLJPMD]
public struct EFKEOBLLPPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[EAFCOINKCNB(2)]
	public bool IGHMPJNDKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[EAFCOINKCNB(3)]
	public bool HMBJKDLHGJI;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly DLFNBFPKEBB<EFKEOBLLPPM> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct HIJLLALBDMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[EAFCOINKCNB(1)]
	public bool IFKLNFPGJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[EAFCOINKCNB(2)]
	public byte BDLGAIKNMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[EAFCOINKCNB(3)]
	public short BOIICLKOHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[EAFCOINKCNB(4)]
	public ushort AKOEMOJGAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[EAFCOINKCNB(5)]
	public int LMKHILDNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[EAFCOINKCNB(6)]
	public uint EDCBGAIDOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[EAFCOINKCNB(7)]
	public long PBOFNHDHGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[EAFCOINKCNB(8)]
	public ulong AMBMHOKOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[EAFCOINKCNB(9)]
	public float ELIJDFNCALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[EAFCOINKCNB(10)]
	public double FMNICMPIHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[EAFCOINKCNB(11)]
	public CCINGFHPKPO BLLMDLOPCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[EAFCOINKCNB(12)]
	public PMKMNBABNIE IHFHDEIPGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[EAFCOINKCNB(13)]
	public HMHKELLBNPJ NNOEDBIKANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[EAFCOINKCNB(14)]
	public INLGDGMOPPH EPOFEJBEIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[EAFCOINKCNB(15)]
	public KPONBEPCLHF HKNELLEDELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[EAFCOINKCNB(16)]
	public FMIBNGKJAMC OLPHPDOJLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[EAFCOINKCNB(17)]
	public NJPDNFBFFOG EMAKHKBICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[EAFCOINKCNB(18)]
	public AOMEAPLPHCJ IEBDJNFOKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[EAFCOINKCNB(20)]
	public Quaternion BLHPEBKJOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[EAFCOINKCNB(22)]
	public Vector3 NOEBPPGDBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[EAFCOINKCNB(23)]
	public Vector4 OIMPLHJBLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[EAFCOINKCNB(40)]
	public Entity KABKGMMJEJL;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum CCINGFHPKPO : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum PMKMNBABNIE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public enum HMHKELLBNPJ : short
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum INLGDGMOPPH : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public enum KPONBEPCLHF
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public enum FMIBNGKJAMC : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum NJPDNFBFFOG : long
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public enum AOMEAPLPHCJ : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[OEADGNLJPMD]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	[OEADGNLJPMD]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class LOFHLCLGFPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public int EGFEGIMIICO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public int NLFIAIBOHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public GameObject IPAGFDLNMDK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LOFHLCLGFPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class BNMPNJCCHMM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public struct LJMOCDECFIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public Vector3 CEIBPEPNCLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<SerializableGuid> GPEGEENICNG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class JPHFLGPKGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public LJMOCDECFIE AHACPDLPCNO;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public JPHFLGPKGFF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public SerializableGuid EIPJNFICNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<int> JODBFIKPAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<LJMOCDECFIE> EHAMLIAGCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public List<JPHFLGPKGFF> ECABBNLIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public GameObject IPAGFDLNMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Light IINAANHOCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Collider LIMGOFLBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public string IPLGJBIICMP;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BNMPNJCCHMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[OEADGNLJPMD]
public struct HGJKNBGMLIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[EAFCOINKCNB(1)]
	public float3 FPKNMDJJPAD;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public static readonly DLFNBFPKEBB<HGJKNBGMLIB> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
[OEADGNLJPMD]
public struct FBGNNPLAHMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[EAFCOINKCNB(1)]
	public quaternion CMOGOLPKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[EAFCOINKCNB(2)]
	public float3 DPHLBKLFIPE;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public static readonly DLFNBFPKEBB<FBGNNPLAHMM> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x395D090", Offset = "0x395C490", VA = "0x18395D090")]
	public FBGNNPLAHMM(quaternion CMOGOLPKHJO, float3 DPHLBKLFIPE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FA10", Offset = "0x5D2EE10", VA = "0x185D2FA10")]
	public static RigidTransform BNPEICKPPJA(FBGNNPLAHMM BEFABMKPPPI)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FA10", Offset = "0x5D2EE10", VA = "0x185D2FA10")]
	public static FBGNNPLAHMM BNPEICKPPJA(RigidTransform DPJEBGDEPHK)
	{
		return default(FBGNNPLAHMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class NGCBJNPHKNC
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public struct PCKBDGFINJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public float4x4 AEEDOICFMJB;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public static readonly DLFNBFPKEBB<PCKBDGFINJN> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct CCKLCDOFFMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public float4x4 HADNJFPICLN;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static readonly DLFNBFPKEBB<CCKLCDOFFMI> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
[OEADGNLJPMD]
public struct OFGGBPENFAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	[EAFCOINKCNB(1)]
	public float BKLOJAMMHDA;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static readonly DLFNBFPKEBB<OFGGBPENFAD> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct EAKLOIPPEOD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int HIPNIPIBGNH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int APOENOPNHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FF70", Offset = "0x5D2F370", VA = "0x185D2FF70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FF60", Offset = "0x5D2F360", VA = "0x185D2FF60")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
[OEADGNLJPMD]
public struct JDDMPOFKADN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	[EAFCOINKCNB(1)]
	public JMGDPNFAMBF CCLOFGGKKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	[EAFCOINKCNB(2)]
	public EGLAJBDHBMG DNMFLMMMBCJ;
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[BBCLLCJPNBE(0, 1)]
[Flags]
public enum JMGDPNFAMBF
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[BBCLLCJPNBE(-2, 2)]
public enum EGLAJBDHBMG
{
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public struct MHHAAGLKIGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public float3 OGHOBGEPGEA;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly DLFNBFPKEBB<MHHAAGLKIGL> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct JBAAHJBHFEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public float3 LPAPEIIOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public quaternion KBKHJHIFKGI;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static readonly DLFNBFPKEBB<JBAAHJBHFEM> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class ACKDFFDDGEA
{
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct COEKCHNJJDA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public float NDECIHNNPAJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static readonly DLFNBFPKEBB<COEKCHNJJDA> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[BBCLLCJPNBE(1000, 8000)]
public enum JMFEOGDEHDH
{
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	UNUSED = 5000,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class KMCPAOPGOLJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal enum KHJPMHGOHHI
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	UNUSED = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal static class LKAGHEMONGA
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[BBCLLCJPNBE(0, 9)]
public enum NGBPNMOBPJE
{
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	UNUSED = 5,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public static class DCBKEAHFCAF
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FD50", Offset = "0x5D2F150", VA = "0x185D2FD50")]
	public static bool FIEPDBPEAEO(this NGBPNMOBPJE AFPOIHKNAGM)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[OEADGNLJPMD]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public JMFEOGDEHDH prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class EKLPCBLHFML
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D305E0", Offset = "0x5D2F9E0", VA = "0x185D305E0")]
	public static NGBPNMOBPJE MMNDAFMFLJH(this JMFEOGDEHDH INONPCNKMNK)
	{
		return default(NGBPNMOBPJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[BBCLLCJPNBE(int.MinValue, int.MaxValue)]
public enum CHMJHOOAACL
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[BBCLLCJPNBE(-1, 31)]
public enum LMFHKGGHMJL
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[CKOCBJPEPBI("Visual", 0)]
[OEADGNLJPMD]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
public struct LNFDBGMEMIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(1)]
	public CHMJHOOAACL DJDNAMFLFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	[EAFCOINKCNB(2)]
	[GLDLDEEEPFJ(0)]
	public LMFHKGGHMJL JGKNCBCEPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(3)]
	public float PGLBFGACPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(4)]
	public Vector3 OLPAPDEPMCE;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[CKOCBJPEPBI("Container", 0)]
[PJLJHHODDLC(2613756846563002039uL, 6372660366488563574uL)]
[EMOCIGDCOJG]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct MPAECIFNADO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	[EAFCOINKCNB(1)]
	[GLDLDEEEPFJ(0)]
	public FNKFPJGMGGL ACMONGEKJCP;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[BBCLLCJPNBE(0, 15)]
[Flags]
public enum FNKFPJGMGGL
{
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[EMOCIGDCOJG]
[PJLJHHODDLC(9804513251708000208uL, 10903582988135044631uL)]
public struct PNCLLHBKFPF : IComponentData, IEquatable<PNCLLHBKFPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[EAFCOINKCNB(1)]
	public FixedString64Bytes LFAIHEECJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[EAFCOINKCNB(2)]
	public BIPCOEBMACL FPIGOHGCHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[EAFCOINKCNB(3)]
	public FNKFPJGMGGL ACMONGEKJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	[EAFCOINKCNB(4)]
	public IFIHINKEGCP FIFEEDMNCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[EAFCOINKCNB(5)]
	public FCEMCBKNAEB JGMEFAHDHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[EAFCOINKCNB(6)]
	public float EIEGGECHILO;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D36E90", Offset = "0x5D36290", VA = "0x185D36E90", Slot = "4")]
	public bool Equals(PNCLLHBKFPF LJIBJAOOGGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[EMOCIGDCOJG]
[PJLJHHODDLC(1213445203937950283uL, 119653618660684511uL)]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct KHHMLBHPLAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[EAFCOINKCNB(1)]
	public GCIKDHJILOJ EIFDNGIJIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public GCHandle LDFPHDMIKMC;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[EAOLIPGCLNN(1)]
public struct GCIKDHJILOJ : OGIDOOLIEGA, IEquatable<GCIKDHJILOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[GKICOLMAKAA(1)]
	public int PIKCMFPLBNL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D30C40", Offset = "0x5D30040", VA = "0x185D30C40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D30BC0", Offset = "0x5D2FFC0", VA = "0x185D30BC0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1642020", VA = "0x181642C20", Slot = "6")]
	public bool Equals(GCIKDHJILOJ LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1650850", Offset = "0x164FC50", VA = "0x181650850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D30CA0", Offset = "0x5D300A0", VA = "0x185D30CA0", Slot = "5")]
	public void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D30CC0", Offset = "0x5D300C0", VA = "0x185D30CC0", Slot = "4")]
	public void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[EMOCIGDCOJG]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[PJLJHHODDLC(218523523639012570uL, 15191719635551116065uL)]
public struct BHJDMCBEKLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private uint CGCKBCFBHAH;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[PJLJHHODDLC(9898405628982320166uL, 2023375009558162791uL)]
[EMOCIGDCOJG]
public struct KLBFFBBOKEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[EAFCOINKCNB(1)]
	public JOMIKKMFJHF JGMEFAHDHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[EAFCOINKCNB(2)]
	public EEMFPAGDLGB PGJPNLHGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(3)]
	public bool MPFJHKPHBJD;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly DLFNBFPKEBB<KLBFFBBOKEF> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[EMOCIGDCOJG]
[PJLJHHODDLC(9807788745867066359uL, 15168486114979071194uL)]
public struct ANDJGNGIEHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[EAFCOINKCNB(1)]
	public JOMIKKMFJHF JGMEFAHDHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[EAFCOINKCNB(2)]
	public EEMFPAGDLGB PGJPNLHGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[GLDLDEEEPFJ(0)]
	[EAFCOINKCNB(3)]
	public bool MPFJHKPHBJD;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly DLFNBFPKEBB<ANDJGNGIEHJ> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[EMOCIGDCOJG]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[PJLJHHODDLC(4470189027631723570uL, 5922380073816386711uL)]
public struct HJPDGJAGHLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[GKICOLMAKAA(1)]
	public JOMIKKMFJHF JGMEFAHDHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[EAFCOINKCNB(2)]
	public EEMFPAGDLGB PGJPNLHGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[EAFCOINKCNB(3)]
	[GLDLDEEEPFJ(0)]
	public BFOJEBGGLIC CNBJDGMCJGO;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly DLFNBFPKEBB<HJPDGJAGHLL> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[PJLJHHODDLC(12226092714547765037uL, 15970362445488810630uL)]
[EMOCIGDCOJG]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct DBOENDEMDLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[EAFCOINKCNB(2)]
	public EEMFPAGDLGB PGJPNLHGGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[EAFCOINKCNB(3)]
	[GLDLDEEEPFJ(0)]
	public BFOJEBGGLIC CNBJDGMCJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[GKICOLMAKAA(4)]
	public JOMIKKMFJHF JGMEFAHDHAJ;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly DLFNBFPKEBB<DBOENDEMDLM> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[EMOCIGDCOJG]
[PJLJHHODDLC(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct ABLLDDHOOFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public int FNFJOJBNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[EAFCOINKCNB(2)]
	public bool IGHMPJNDKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[EAFCOINKCNB(3)]
	public bool HMBJKDLHGJI;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly DLFNBFPKEBB<ABLLDDHOOFD> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[EMOCIGDCOJG]
[PJLJHHODDLC(5861057081882613294uL, 13746475565109640919uL)]
public struct OCOAGDFBMFC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[BBCLLCJPNBE(0, 1)]
	public enum POKBNOFJENK
	{
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		Custom = 1,
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		MAX = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[EAFCOINKCNB(1)]
	public POKBNOFJENK MLEMLMCLDHJ;
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[EMOCIGDCOJG]
[PJLJHHODDLC(14327281633525910712uL, 2559857777606771911uL)]
public struct BLKLCJEOPIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[EAFCOINKCNB(1)]
	public JMFEOGDEHDH INONPCNKMNK;
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[PJLJHHODDLC(15725208981563603541uL, 17017036095303668770uL)]
[EMOCIGDCOJG]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct IIAJEDFLLEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[EAFCOINKCNB(1)]
	public JMFEOGDEHDH INONPCNKMNK;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[PJLJHHODDLC(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[EMOCIGDCOJG]
public struct GEIBNMAPOBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public NGBPNMOBPJE AFPOIHKNAGM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[EMOCIGDCOJG]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[PJLJHHODDLC(17667479821163689808uL, 11946378475791123970uL)]
public struct KODBLLFOPAK : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : BAFBLMKEIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D37F20", Offset = "0x5D37320", VA = "0x185D37F20", Slot = "4")]
		public sealed override void LIPDHMGDINI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class JKAJOIDNCFG : ContainerPropertyBag<KKBOPBPDFDH>
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class FILDLNGJPCL : Property<KKBOPBPDFDH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x5D309F0", Offset = "0x5D2FDF0", VA = "0x185D309F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D309B0", Offset = "0x5D2FDB0", VA = "0x185D309B0")]
		public FILDLNGJPCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F210", Offset = "0x5D2E610", VA = "0x185D2F210", Slot = "14")]
		public override Rigidbody GetValue(KKBOPBPDFDH KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F230", Offset = "0x5D2E630", VA = "0x185D2F230", Slot = "15")]
		public override void SetValue(KKBOPBPDFDH KBPJCNHNBHJ, Rigidbody EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D34E10", Offset = "0x5D34210", VA = "0x185D34E10")]
	public JKAJOIDNCFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class IADGPMAMAAO : ContainerPropertyBag<OBLCBMBAPLL>
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class DMLLLIKCLIK : Property<OBLCBMBAPLL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5D2FF30", Offset = "0x5D2F330", VA = "0x185D2FF30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FEF0", Offset = "0x5D2F2F0", VA = "0x185D2FEF0")]
		public DMLLLIKCLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F210", Offset = "0x5D2E610", VA = "0x185D2F210", Slot = "14")]
		public override object GetValue(OBLCBMBAPLL KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F230", Offset = "0x5D2E630", VA = "0x185D2F230", Slot = "15")]
		public override void SetValue(OBLCBMBAPLL KBPJCNHNBHJ, object EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D342F0", Offset = "0x5D336F0", VA = "0x185D342F0")]
	public IADGPMAMAAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal class IBOCEAIPIKL : ContainerPropertyBag<KKDHDHJHHGM>
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class PKHCEBMJGDF : Property<KKDHDHJHHGM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5D36E60", Offset = "0x5D36260", VA = "0x185D36E60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D36E20", Offset = "0x5D36220", VA = "0x185D36E20")]
		public PKHCEBMJGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F210", Offset = "0x5D2E610", VA = "0x185D2F210", Slot = "14")]
		public override object GetValue(KKDHDHJHHGM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F230", Offset = "0x5D2E630", VA = "0x185D2F230", Slot = "15")]
		public override void SetValue(KKDHDHJHHGM KBPJCNHNBHJ, object EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D34440", Offset = "0x5D33840", VA = "0x185D34440")]
	public IBOCEAIPIKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal class EDDGHEOJGCJ : ContainerPropertyBag<IJMHKDPIKCB>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class AGIDMNLNFAM : Property<IJMHKDPIKCB, CMHAFMKPEIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F2A0", Offset = "0x5D2E6A0", VA = "0x185D2F2A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F260", Offset = "0x5D2E660", VA = "0x185D2F260")]
		public AGIDMNLNFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F210", Offset = "0x5D2E610", VA = "0x185D2F210", Slot = "14")]
		public override CMHAFMKPEIJ GetValue(IJMHKDPIKCB KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F230", Offset = "0x5D2E630", VA = "0x185D2F230", Slot = "15")]
		public override void SetValue(IJMHKDPIKCB KBPJCNHNBHJ, CMHAFMKPEIJ EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FFE0", Offset = "0x5D2F3E0", VA = "0x185D2FFE0")]
	public EDDGHEOJGCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class NCLILCOAHOE : ContainerPropertyBag<LOFHLCLGFPE>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class KEAACFFGAPP : Property<LOFHLCLGFPE, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5D35460", Offset = "0x5D34860", VA = "0x185D35460", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D35420", Offset = "0x5D34820", VA = "0x185D35420")]
		public KEAACFFGAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D353E0", Offset = "0x5D347E0", VA = "0x185D353E0", Slot = "14")]
		public override int GetValue(LOFHLCLGFPE KBPJCNHNBHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D35400", Offset = "0x5D34800", VA = "0x185D35400", Slot = "15")]
		public override void SetValue(LOFHLCLGFPE KBPJCNHNBHJ, int EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class FDGPBKAEDEJ : Property<LOFHLCLGFPE, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5D308F0", Offset = "0x5D2FCF0", VA = "0x185D308F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D308B0", Offset = "0x5D2FCB0", VA = "0x185D308B0")]
		public FDGPBKAEDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D30870", Offset = "0x5D2FC70", VA = "0x185D30870", Slot = "14")]
		public override int GetValue(LOFHLCLGFPE KBPJCNHNBHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5D30890", Offset = "0x5D2FC90", VA = "0x185D30890", Slot = "15")]
		public override void SetValue(LOFHLCLGFPE KBPJCNHNBHJ, int EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class EGJPHBOAONO : Property<LOFHLCLGFPE, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5D30540", Offset = "0x5D2F940", VA = "0x185D30540", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D30500", Offset = "0x5D2F900", VA = "0x185D30500")]
		public EGJPHBOAONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D304B0", Offset = "0x5D2F8B0", VA = "0x185D304B0", Slot = "14")]
		public override GameObject GetValue(LOFHLCLGFPE KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D304D0", Offset = "0x5D2F8D0", VA = "0x185D304D0", Slot = "15")]
		public override void SetValue(LOFHLCLGFPE KBPJCNHNBHJ, GameObject EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D35D40", Offset = "0x5D35140", VA = "0x185D35D40")]
	public NCLILCOAHOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class JNCJHHACNNO : ContainerPropertyBag<BNMPNJCCHMM>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class NHJOAHONKKH : Property<BNMPNJCCHMM, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5D36500", Offset = "0x5D35900", VA = "0x185D36500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D364C0", Offset = "0x5D358C0", VA = "0x185D364C0")]
		public NHJOAHONKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D36470", Offset = "0x5D35870", VA = "0x185D36470", Slot = "14")]
		public override SerializableGuid GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D364A0", Offset = "0x5D358A0", VA = "0x185D364A0", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, SerializableGuid EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class NHIMOLKBMEP : Property<BNMPNJCCHMM, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5D36440", Offset = "0x5D35840", VA = "0x185D36440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D36400", Offset = "0x5D35800", VA = "0x185D36400")]
		public NHIMOLKBMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D363B0", Offset = "0x5D357B0", VA = "0x185D363B0", Slot = "14")]
		public override List<int> GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D363D0", Offset = "0x5D357D0", VA = "0x185D363D0", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, List<int> EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class OAOPPPFAOMN : Property<BNMPNJCCHMM, List<BNMPNJCCHMM.LJMOCDECFIE>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5D36830", Offset = "0x5D35C30", VA = "0x185D36830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D367F0", Offset = "0x5D35BF0", VA = "0x185D367F0")]
		public OAOPPPFAOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D367A0", Offset = "0x5D35BA0", VA = "0x185D367A0", Slot = "14")]
		public override List<BNMPNJCCHMM.LJMOCDECFIE> GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D367C0", Offset = "0x5D35BC0", VA = "0x185D367C0", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, List<BNMPNJCCHMM.LJMOCDECFIE> EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class GIAJOABGIBC : Property<BNMPNJCCHMM, List<BNMPNJCCHMM.JPHFLGPKGFF>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5D30E80", Offset = "0x5D30280", VA = "0x185D30E80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D30E40", Offset = "0x5D30240", VA = "0x185D30E40")]
		public GIAJOABGIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DF0", Offset = "0x5D301F0", VA = "0x185D30DF0", Slot = "14")]
		public override List<BNMPNJCCHMM.JPHFLGPKGFF> GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D30E10", Offset = "0x5D30210", VA = "0x185D30E10", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, List<BNMPNJCCHMM.JPHFLGPKGFF> EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class OGAPEKECGBH : Property<BNMPNJCCHMM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5D369C0", Offset = "0x5D35DC0", VA = "0x185D369C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D36980", Offset = "0x5D35D80", VA = "0x185D36980")]
		public OGAPEKECGBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D36930", Offset = "0x5D35D30", VA = "0x185D36930", Slot = "14")]
		public override GameObject GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D36950", Offset = "0x5D35D50", VA = "0x185D36950", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, GameObject EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class IIJMCKPKDJO : Property<BNMPNJCCHMM, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x5D345B0", Offset = "0x5D339B0", VA = "0x185D345B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D34570", Offset = "0x5D33970", VA = "0x185D34570")]
		public IIJMCKPKDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D34520", Offset = "0x5D33920", VA = "0x185D34520", Slot = "14")]
		public override Light GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D34540", Offset = "0x5D33940", VA = "0x185D34540", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, Light EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class NNENDJHIHNH : Property<BNMPNJCCHMM, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x5D36710", Offset = "0x5D35B10", VA = "0x185D36710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D366D0", Offset = "0x5D35AD0", VA = "0x185D366D0")]
		public NNENDJHIHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D36680", Offset = "0x5D35A80", VA = "0x185D36680", Slot = "14")]
		public override Collider GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D366A0", Offset = "0x5D35AA0", VA = "0x185D366A0", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, Collider EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class NKPLGHNJIGO : Property<BNMPNJCCHMM, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5D36650", Offset = "0x5D35A50", VA = "0x185D36650", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D36610", Offset = "0x5D35A10", VA = "0x185D36610")]
		public NKPLGHNJIGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D365C0", Offset = "0x5D359C0", VA = "0x185D365C0", Slot = "14")]
		public override string GetValue(BNMPNJCCHMM KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D365E0", Offset = "0x5D359E0", VA = "0x185D365E0", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM KBPJCNHNBHJ, string EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D34EF0", Offset = "0x5D342F0", VA = "0x185D34EF0")]
	public JNCJHHACNNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class MDLLJEMDHFI : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class JHCAGBCCIBN : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5D34960", Offset = "0x5D33D60", VA = "0x185D34960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5D34870", Offset = "0x5D33C70", VA = "0x185D34870")]
		public JHCAGBCCIBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xD82230", Offset = "0xD81630", VA = "0x180D82230", Slot = "14")]
		public override Data128 GetValue(SerializableGuid KBPJCNHNBHJ)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D34860", Offset = "0x5D33C60", VA = "0x185D34860", Slot = "15")]
		public override void SetValue(SerializableGuid KBPJCNHNBHJ, Data128 EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D359D0", Offset = "0x5D34DD0", VA = "0x185D359D0")]
	public MDLLJEMDHFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal class JIOOBEDFIKD : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class DEFBPFHDDEJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x5D2FE60", Offset = "0x5D2F260", VA = "0x185D2FE60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FD70", Offset = "0x5D2F170", VA = "0x185D2FD70")]
		public DEFBPFHDDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x12203C0", Offset = "0x121F7C0", VA = "0x1812203C0", Slot = "14")]
		public override int GetValue(Data128 KBPJCNHNBHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FD60", Offset = "0x5D2F160", VA = "0x185D2FD60", Slot = "15")]
		public override void SetValue(Data128 KBPJCNHNBHJ, int EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class KNDANDAIBNJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5D358A0", Offset = "0x5D34CA0", VA = "0x185D358A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D357B0", Offset = "0x5D34BB0", VA = "0x185D357B0")]
		public KNDANDAIBNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D35790", Offset = "0x5D34B90", VA = "0x185D35790", Slot = "14")]
		public override int GetValue(Data128 KBPJCNHNBHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D357A0", Offset = "0x5D34BA0", VA = "0x185D357A0", Slot = "15")]
		public override void SetValue(Data128 KBPJCNHNBHJ, int EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class BHLCJJNLCPG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F9E0", Offset = "0x5D2EDE0", VA = "0x185D2F9E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F8F0", Offset = "0x5D2ECF0", VA = "0x185D2F8F0")]
		public BHLCJJNLCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x14EFA60", Offset = "0x14EEE60", VA = "0x1814EFA60", Slot = "14")]
		public override int GetValue(Data128 KBPJCNHNBHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F8E0", Offset = "0x5D2ECE0", VA = "0x185D2F8E0", Slot = "15")]
		public override void SetValue(Data128 KBPJCNHNBHJ, int EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class FMIPDBEFKGI : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5D30B90", Offset = "0x5D2FF90", VA = "0x185D30B90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D30AA0", Offset = "0x5D2FEA0", VA = "0x185D30AA0")]
		public FMIPDBEFKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D30A80", Offset = "0x5D2FE80", VA = "0x185D30A80", Slot = "14")]
		public override int GetValue(Data128 KBPJCNHNBHJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D30A90", Offset = "0x5D2FE90", VA = "0x185D30A90", Slot = "15")]
		public override void SetValue(Data128 KBPJCNHNBHJ, int EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D34990", Offset = "0x5D33D90", VA = "0x185D34990")]
	public JIOOBEDFIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal class BAGJCMJOJJH : ContainerPropertyBag<BNMPNJCCHMM.LJMOCDECFIE>
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class NHLGKLCHOPO : Property<BNMPNJCCHMM.LJMOCDECFIE, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5D36590", Offset = "0x5D35990", VA = "0x185D36590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5D36550", Offset = "0x5D35950", VA = "0x185D36550")]
		public NHLGKLCHOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x861290", Offset = "0x860690", VA = "0x180861290", Slot = "14")]
		public override Vector3 GetValue(BNMPNJCCHMM.LJMOCDECFIE KBPJCNHNBHJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D36530", Offset = "0x5D35930", VA = "0x185D36530", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM.LJMOCDECFIE KBPJCNHNBHJ, Vector3 EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class ANEMLGINMPO : Property<BNMPNJCCHMM.LJMOCDECFIE, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5D2F730", Offset = "0x5D2EB30", VA = "0x185D2F730", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F6F0", Offset = "0x5D2EAF0", VA = "0x185D2F6F0")]
		public ANEMLGINMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F6D0", Offset = "0x5D2EAD0", VA = "0x185D2F6D0", Slot = "14")]
		public override List<SerializableGuid> GetValue(BNMPNJCCHMM.LJMOCDECFIE KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F6E0", Offset = "0x5D2EAE0", VA = "0x185D2F6E0", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM.LJMOCDECFIE KBPJCNHNBHJ, List<SerializableGuid> EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F780", Offset = "0x5D2EB80", VA = "0x185D2F780")]
	public BAGJCMJOJJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class EDJPGCCIOKG : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class EEAPNGOJFHL : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5D302C0", Offset = "0x5D2F6C0", VA = "0x185D302C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D30280", Offset = "0x5D2F680", VA = "0x185D30280")]
		public EEAPNGOJFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D30260", Offset = "0x5D2F660", VA = "0x185D30260", Slot = "14")]
		public override float GetValue(Vector3 KBPJCNHNBHJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5D30270", Offset = "0x5D2F670", VA = "0x185D30270", Slot = "15")]
		public override void SetValue(Vector3 KBPJCNHNBHJ, float EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private class FGDPAODIJBK : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x5D30980", Offset = "0x5D2FD80", VA = "0x185D30980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5D30940", Offset = "0x5D2FD40", VA = "0x185D30940")]
		public FGDPAODIJBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D30920", Offset = "0x5D2FD20", VA = "0x185D30920", Slot = "14")]
		public override float GetValue(Vector3 KBPJCNHNBHJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5D30930", Offset = "0x5D2FD30", VA = "0x185D30930", Slot = "15")]
		public override void SetValue(Vector3 KBPJCNHNBHJ, float EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class CGHNLCFLDJP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x5D2FBE0", Offset = "0x5D2EFE0", VA = "0x185D2FBE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FBA0", Offset = "0x5D2EFA0", VA = "0x185D2FBA0")]
		public CGHNLCFLDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x18BB1A0", Offset = "0x18BA5A0", VA = "0x1818BB1A0", Slot = "14")]
		public override float GetValue(Vector3 KBPJCNHNBHJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FB90", Offset = "0x5D2EF90", VA = "0x185D2FB90", Slot = "15")]
		public override void SetValue(Vector3 KBPJCNHNBHJ, float EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D300C0", Offset = "0x5D2F4C0", VA = "0x185D300C0")]
	public EDJPGCCIOKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class PNFPEHIGBJE : ContainerPropertyBag<BNMPNJCCHMM.JPHFLGPKGFF>
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	private class ONLPPNHEFMM : Property<BNMPNJCCHMM.JPHFLGPKGFF, BNMPNJCCHMM.LJMOCDECFIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x5D36C90", Offset = "0x5D36090", VA = "0x185D36C90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5D36C50", Offset = "0x5D36050", VA = "0x185D36C50")]
		public ONLPPNHEFMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D36BE0", Offset = "0x5D35FE0", VA = "0x185D36BE0", Slot = "14")]
		public override BNMPNJCCHMM.LJMOCDECFIE GetValue(BNMPNJCCHMM.JPHFLGPKGFF KBPJCNHNBHJ)
		{
			return default(BNMPNJCCHMM.LJMOCDECFIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5D36C10", Offset = "0x5D36010", VA = "0x185D36C10", Slot = "15")]
		public override void SetValue(BNMPNJCCHMM.JPHFLGPKGFF KBPJCNHNBHJ, BNMPNJCCHMM.LJMOCDECFIE EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D36F70", Offset = "0x5D36370", VA = "0x185D36F70")]
	public PNFPEHIGBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal class HJMONAEDAJG : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	private class IBIDOFOIJMH : Property<RRObjectPrefabV2Data, JMFEOGDEHDH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5D34410", Offset = "0x5D33810", VA = "0x185D34410", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5D343D0", Offset = "0x5D337D0", VA = "0x185D343D0")]
		public IBIDOFOIJMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x12203C0", Offset = "0x121F7C0", VA = "0x1812203C0", Slot = "14")]
		public override JMFEOGDEHDH GetValue(RRObjectPrefabV2Data KBPJCNHNBHJ)
		{
			return default(JMFEOGDEHDH);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FD60", Offset = "0x5D2F160", VA = "0x185D2FD60", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data KBPJCNHNBHJ, JMFEOGDEHDH EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5D31030", Offset = "0x5D30430", VA = "0x185D31030")]
	public HJMONAEDAJG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5D37050", Offset = "0x5D36450", VA = "0x185D37050")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
public class GJFEHICIKAF
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GJFEHICIKAF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
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

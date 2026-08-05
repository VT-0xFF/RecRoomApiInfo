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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ABEFMOEBDDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode CBEDPDEPCMK;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KMINAECGCCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public KIANNNNHAKO PNICCOJIBJK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly OJJNOMGEOOK<KMINAECGCCD> LHECNHAABJO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AFIEGKCMINH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PNLOIFIDEJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KIANNNNHAKO
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
public struct ECCNKAGEGPN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct PILCOIPOCDM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity AHNPOOGMEAC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BPCCADMCDGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity ECLIMLPEPIL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KHJJFAPBPAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BEOMNEDAKFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity AFFGDBELLLE;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FFKAGFAFDMG : EDGPEACGGBN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FANDAOKFPNJ BLAMBJHHNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FANDAOKFPNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CHKHKBJJOEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 KGMLOJABECL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FCFNLCOJEID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PAGHCOKLMJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 GPDJMCLJAKN;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly OJJNOMGEOOK<PIKGLFFAFHE> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PIKGLFFAFHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 GPDJMCLJAKN;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly OJJNOMGEOOK<PIKGLFFAFHE> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OLFJCEJLJDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 KBGMJMHPIPB;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LIJNBJHHKCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 MJPNIJNOHKF;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BDIBCKGNFCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float HJDBJMKEHOP;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly OJJNOMGEOOK<BDIBCKGNFCG> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DOMJDEBEJJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float EIIHKNLMHNL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OJJNOMGEOOK<DOMJDEBEJJN> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct DNEDNJCNGCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 MHPKAMFOODK;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IIODDIACKNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public DJMAOELABKD ICBKLKBBNOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LKBJCNIKLDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public DJMAOELABKD NCLKNMNHMHM;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[CIJBEMIPNHF]
public struct CJLJPBBFPIM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity HPMKKHPHJEE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CGJIKDPFDDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GFEGDNCPJJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IJMMKCEGEIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MAKECCFKFDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints IODIGGIIFOH;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NNEMKHFLMHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float ANFOAPMCLNA;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly OJJNOMGEOOK<NNEMKHFLMHN> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct APOFNNDBOKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float NNEGLBPLAIO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct PKLIDHOENEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BPCOILAAHDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int CBMPDPEGGNA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD68A90", Offset = "0xD67E90", VA = "0x180D68A90")]
	public static BPCOILAAHDM GOCBKKMEEIH(int NMENOOMOOJP)
	{
		return default(BPCOILAAHDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DGKHAENCEFL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody FFEOMAPAFKC;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8560", Offset = "0x5EC7960", VA = "0x185EC8560", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DGKHAENCEFL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct DPBICOJHEBK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JOJCACJJKIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 ANBOFBNCNAD;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AMGAEJBMDAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 JFJFCLDIDKG;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PIHCOOMIAEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float INANJMNFKNG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OJJNOMGEOOK<PIHCOOMIAEL> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KMJNIJDBCDM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object INKKBIONILJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE720", Offset = "0x5ECDB20", VA = "0x185ECE720", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public KMJNIJDBCDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HIBLOFCFGAN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object MNLDEKMPAOH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCDD0", Offset = "0x5ECC1D0", VA = "0x185ECCDD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public HIBLOFCFGAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum DJMAOELABKD
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum CBIDEAIHNIC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PHLGGGDOEBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIKAJPDDMMN(KIANNNNHAKO HINODNBJLFA, KIANNNNHAKO HBJELDNKGOL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALMANPAPPNE();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPFOFLGGIPD();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NIEKNBHPEIL(bool LJMHPFKDFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KMLMCFOBAND();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKGIDKPNLNK();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JGLGAEDFFID : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public PHLGGGDOEBJ MJAGLFPFKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE060", Offset = "0x5ECD460", VA = "0x185ECE060", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public JGLGAEDFFID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FPPAOKFLKDP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(AJJBIJDODPO nameHash, OFOAMNPIOOF stableTypeHash, Type type)> HCAKECEBAOE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(AJJBIJDODPO nameHash, OFOAMNPIOOF stableTypeHash, Type type)> NFBGJNBOJHD;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(AJJBIJDODPO previousNameHash, OFOAMNPIOOF previousStableTypeHash, Type currentTypeName)> EHHEOLJIIJO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct JJIIANKIBBD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, AFHIABNFJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7E00", Offset = "0x5EC7200", VA = "0x185EC7E00", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct JPIHHPKAODI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[BNFIOJFMILL(1)]
	public quaternion MKPFBAOBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[BNFIOJFMILL(2)]
	public float3 GOPGKDKAOFI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly OJJNOMGEOOK<JPIHHPKAODI> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A643C0", Offset = "0x3A637C0", VA = "0x183A643C0")]
	public JPIHHPKAODI(quaternion MKPFBAOBFNN, float3 GOPGKDKAOFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD670", Offset = "0x5ECCA70", VA = "0x185ECD670")]
	public static JPIHHPKAODI GOCBKKMEEIH(RigidTransform CABEKLGKCHI)
	{
		return default(JPIHHPKAODI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EKPJNEBNEID
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct MNCFOKOEIJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[BNFIOJFMILL(1)]
	public float CBMHIKLPFDJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly OJJNOMGEOOK<MNCFOKOEIJJ> LHECNHAABJO;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[EEMCNPNJBMC]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, AFHIABNFJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[BNFIOJFMILL(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7E10", Offset = "0x5EC7210", VA = "0x185EC7E10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct EEKHIAIBPLC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, AFHIABNFJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FOIDHEFDLID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct EMPFNJPBCMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[BNFIOJFMILL(1)]
	public SerializableGuid OLLLMHFOLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[BNFIOJFMILL(2)]
	public SerializableGuid KNOGOHBGIDL;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OMOAJOODHFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity DNOGIMENFHA;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IECKGLBFOJO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity DNOGIMENFHA;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[CDIJPCPMCOP("Container", 0)]
public struct FFGELGJFGFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(1)]
	public JPCEBDMPCNI JKCEOLGNNEL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OJJNOMGEOOK<FFGELGJFGFG> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[NENIHMGKIGF(0, 127)]
public enum JPCEBDMPCNI
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
public static class AIICPAJHIKK
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum BKKLOIINIHD
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
	public enum DHMOFGICPBD
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
	[Cpp2IlInjected.Address(RVA = "0x5EC7AD0", Offset = "0x5EC6ED0", VA = "0x185EC7AD0")]
	public static (BKKLOIINIHD, DHMOFGICPBD) OHJIBAJNOOA(this JPCEBDMPCNI KLIMLCKINGF)
	{
		return default((BKKLOIINIHD, DHMOFGICPBD));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[CDIJPCPMCOP("Container", 0)]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[EEMCNPNJBMC]
public struct DCICMAEPLBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[BNFIOJFMILL(1)]
	[GDFHIBCENFG(0)]
	public MMMOMNIDAFI JHANKJFICBI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly OJJNOMGEOOK<DCICMAEPLBF> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[NENIHMGKIGF(0, 2)]
public enum MMMOMNIDAFI
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
[CDIJPCPMCOP("Container", 0)]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct KOJFPNNLLOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(1)]
	public DNLCPCPMCIL HHCBDCNLNLG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
[NENIHMGKIGF(0, 15943)]
public enum DNLCPCPMCIL
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
public struct FJIHBGNDLNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct FHNOMJJNCDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MLNEKMKCOGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MHKHKPGHFOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct CNNAIMJHOPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct GBCKHKPCIIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct LLLIEOGKILI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GDKFDGFBJAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct EJCMCGMNEDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[CDIJPCPMCOP("Container", 0)]
[EEMCNPNJBMC]
public struct ACEMGECLAOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[BNFIOJFMILL(1)]
	[GDFHIBCENFG(0)]
	public float MCBMFOOILNE;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[EEMCNPNJBMC]
[CDIJPCPMCOP("Container", 0)]
public struct GDOAPHCEAOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[BNFIOJFMILL(1)]
	[GDFHIBCENFG(0)]
	public FixedString64Bytes MDFAJJKMBAI;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct EHAMIJINKHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<DMCBNAIKJCM> CNABGOKDHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<Entity> OJNBGJGMNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JobHandle ALPBNEDDHKE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HNAOJEOBKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8F80", Offset = "0x5EC8380", VA = "0x185EC8F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AEFHJLMLIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8F30", Offset = "0x5EC8330", VA = "0x185EC8F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43E3C80", Offset = "0x43E3080", VA = "0x1843E3C80")]
	public EHAMIJINKHM(NativeList<DMCBNAIKJCM> CNABGOKDHDG, NativeList<Entity> OJNBGJGMNPG, JobHandle ALPBNEDDHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9050", Offset = "0x5EC8450", VA = "0x185EC9050")]
	public (Entity, NativeSlice<Entity>) NNFGAOFDCGL(int JNJOJJJELGE)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8FF0", Offset = "0x5EC83F0", VA = "0x185EC8FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DMCBNAIKJCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity AFFGDBELLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int ELJAGIMMLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int HKIFHAEDDHO;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface MPCFBJNJKEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPJHJFKIGIC(bool MBCGCAIPEKB);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[CDIJPCPMCOP("Container", 0)]
[EEMCNPNJBMC]
public struct OJBKHMLNMCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(1)]
	public CEFABOIAHDK HDOGCKKCCGL;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[NENIHMGKIGF(0, 1)]
public enum CEFABOIAHDK
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
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
[CDIJPCPMCOP("Container", 0)]
public struct OLKPEFCBOMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(1)]
	public FHFKFHOCDAK BLGJGLHNDMD;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly OJJNOMGEOOK<OLKPEFCBOMF> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[NENIHMGKIGF(0, 2)]
public enum FHFKFHOCDAK
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
[CJCELKJNLGJ(1)]
public struct JDBLALGPDKM : IComparable<JDBLALGPDKM>, IEquatable<JDBLALGPDKM>, COHLAOIPMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[HLNDJCJKEJL(1)]
	public uint MEIOPAFFMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[HLNDJCJKEJL(2)]
	public uint LBDPODOPHKC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint NMDLGGINADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD8B0", Offset = "0x5ECCCB0", VA = "0x185ECD8B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD30", Offset = "0x5ECD130", VA = "0x185ECDD30")]
	public JDBLALGPDKM(int MEIOPAFFMDD, int HLJKABMGAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD30", Offset = "0x5ECD130", VA = "0x185ECDD30")]
	public JDBLALGPDKM(uint MEIOPAFFMDD, uint HLJKABMGAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD950", Offset = "0x5ECCD50", VA = "0x185ECD950")]
	public JDBLALGPDKM DOLJACEHDAJ(int ELJAGIMMLLH = 1)
	{
		return default(JDBLALGPDKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDAC0", Offset = "0x5ECCEC0", VA = "0x185ECDAC0")]
	public JDBLALGPDKM IIPAFJDHEDI(int ELJAGIMMLLH = 1)
	{
		return default(JDBLALGPDKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDBA0", Offset = "0x5ECCFA0", VA = "0x185ECDBA0")]
	public static JDBLALGPDKM KFACJOALKKK(JDBLALGPDKM OJKFAPKLEMA, JDBLALGPDKM BBHLJNIGCPB)
	{
		return default(JDBLALGPDKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC20", Offset = "0x5ECD020", VA = "0x185ECDC20")]
	private static uint OMIEEHFKDHJ(uint JMHOJIPAIMC, uint MLKGDIFPGGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD930", Offset = "0x5ECCD30", VA = "0x185ECD930", Slot = "4")]
	public int CompareTo(JDBLALGPDKM LFMLAKDHEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD9E0", Offset = "0x5ECCDE0", VA = "0x185ECD9E0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC50", Offset = "0x5ECD050", VA = "0x185ECDC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD9C0", Offset = "0x5ECCDC0", VA = "0x185ECD9C0", Slot = "5")]
	public bool Equals(JDBLALGPDKM LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDA70", Offset = "0x5ECCE70", VA = "0x185ECDA70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD8C0", Offset = "0x5ECCCC0", VA = "0x185ECD8C0", Slot = "6")]
	public void ALIOEPOJFBC(JDMKDHMCHPP EKCFHKIKCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDB30", Offset = "0x5ECCF30", VA = "0x185ECDB30", Slot = "7")]
	public void JKMDPBEAKHM(JMIJDPNPCJG PCDAGGPDBLK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x264FEB0", Offset = "0x264F2B0", VA = "0x18264FEB0")]
	public static bool FCHDBNDMOOD(JDBLALGPDKM OJKFAPKLEMA, JDBLALGPDKM BBHLJNIGCPB)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CJCELKJNLGJ(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[HLNDJCJKEJL(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[HLNDJCJKEJL(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[HLNDJCJKEJL(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[HLNDJCJKEJL(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CJCELKJNLGJ(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, COHLAOIPMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[HLNDJCJKEJL(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
		public static SerializableGuid GOCBKKMEEIH(Guid GJKCBNEBGAL)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A20", Offset = "0x5ECFE20", VA = "0x185ED0A20", Slot = "4")]
		public bool Equals(SerializableGuid LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A00", Offset = "0x5ECFE00", VA = "0x185ED0A00", Slot = "5")]
		public int CompareTo(SerializableGuid LFMLAKDHEFO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0940", Offset = "0x5ECFD40", VA = "0x185ED0940", Slot = "6")]
		public void ALIOEPOJFBC(JDMKDHMCHPP EKCFHKIKCOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0A50", Offset = "0x5ECFE50", VA = "0x185ED0A50", Slot = "7")]
		public void JKMDPBEAKHM(JMIJDPNPCJG PCDAGGPDBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0AD0", Offset = "0x5ECFED0", VA = "0x185ED0AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct IJGEPPMOPLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct DFIMDBGJEEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct IJECFFPJKDC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
[EEMCNPNJBMC]
public struct PAMGLPHIOON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[BNFIOJFMILL(1)]
	public Entity CFMDKCJOABD;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[InternalBufferCapacity(17)]
public struct MCMFMGLAGEN : IBufferElementData, IEquatable<MCMFMGLAGEN>, AFHIABNFJOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Entity AHNPOOGMEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public int MGEINFOKGIA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity GPNLJJAIPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEDD0", Offset = "0x5ECE1D0", VA = "0x185ECEDD0", Slot = "4")]
	public bool Equals(MCMFMGLAGEN LFMLAKDHEFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
public struct CMFAACMGNBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[BNFIOJFMILL(1)]
	public int MGEINFOKGIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct IMCCMONICHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
public struct LJCLJHMMBDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[BNFIOJFMILL(1)]
	public Entity KKAKNDBLLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[BNFIOJFMILL(2)]
	public uint NFOHMDMJLKI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId GMIJFBOCNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1CDD080", Offset = "0x1CDC480", VA = "0x181CDD080")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD4A0", Offset = "0x1CFC8A0", VA = "0x181CFD4A0")]
	public LJCLJHMMBDI(Entity KKAKNDBLLDK, EntityBundlePartId NEAGLJGJAAD)
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
		[Cpp2IlInjected.Address(RVA = "0x869FC0", Offset = "0x8693C0", VA = "0x180869FC0")]
		internal EntityBundlePartId(uint EPDCALNHKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86A0B0", Offset = "0x8694B0", VA = "0x18086A0B0")]
		internal uint CMCFPBDLGHO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7E8FE0", Offset = "0x7E83E0", VA = "0x1807E8FE0", Slot = "4")]
		public bool Equals(EntityBundlePartId LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9400", Offset = "0x5EC8800", VA = "0x185EC9400", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x871A20", Offset = "0x870E20", VA = "0x180871A20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x170C980", Offset = "0x170BD80", VA = "0x18170C980")]
		public static bool FCHDBNDMOOD(EntityBundlePartId JMHOJIPAIMC, EntityBundlePartId MLKGDIFPGGI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct NEJPPKFBPFE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity NCJAELPNNCK;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct DBCGFBPMHOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[BNFIOJFMILL(1)]
	public Entity OPJDDCOPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[BNFIOJFMILL(2)]
	public bool GDCNFDKMPBD;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct BENCDFJGMJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[BNFIOJFMILL(1)]
	public LLEGBOFNJJJ MECBMPEIKPG;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[NENIHMGKIGF(0, 4)]
public enum LLEGBOFNJJJ
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
[EEMCNPNJBMC]
public struct KEIFPLEMHEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[BNFIOJFMILL(1)]
	public Entity OPJDDCOPPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[BNFIOJFMILL(2)]
	public bool AGHHJFKHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[BNFIOJFMILL(3)]
	public float EFBGDMAODKA;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[EEMCNPNJBMC]
public struct JFCCINBMMKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[BNFIOJFMILL(1)]
	public bool MOLHDBHIKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[BNFIOJFMILL(2)]
	public bool AGHHJFKHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[BNFIOJFMILL(3)]
	public float IFNEGJEKLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[BNFIOJFMILL(4)]
	public float COIHINIONGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[BNFIOJFMILL(5)]
	public float COOPJHPKDNO;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct AEMAKNHFAFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[BNFIOJFMILL(1)]
	public bool MOLHDBHIKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[BNFIOJFMILL(2)]
	public bool AGHHJFKHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[BNFIOJFMILL(3)]
	public float EFBGDMAODKA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, AFHIABNFJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7E00", Offset = "0x5EC7200", VA = "0x185EC7E00", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[EEMCNPNJBMC]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, AFHIABNFJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[BNFIOJFMILL(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, AFHIABNFJOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7DC910", Offset = "0x7DBD10", VA = "0x1807DC910", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1715E00", Offset = "0x1715200", VA = "0x181715E00")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct AHEFHHDLOPL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface AFHIABNFJOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity FOMAIONOBKH
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
public struct PKHJHHJLLCB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly bool ECMFHABJICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public uint GIBJOEIDFKE;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	private static bool EGMDNKNCBPE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
[EEMCNPNJBMC]
[CDIJPCPMCOP("Light", 0)]
public struct BPFMBPMPGCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[BNFIOJFMILL(1)]
	[GDFHIBCENFG(0)]
	public bool BFEPOIFAJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[BNFIOJFMILL(2)]
	[GDFHIBCENFG(0)]
	public float NDGHPHIFGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(3)]
	public float KPDNJGBDHCF;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[CDIJPCPMCOP("Light", 0)]
[EEMCNPNJBMC]
public struct LLLGLJLCDAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[BNFIOJFMILL(1)]
	[GDFHIBCENFG(0)]
	public float NNAELBLOPIP;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.TypeVersion(2)]
public struct JNEGBMBNKAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public uint FFIJCCFIOEJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE230", Offset = "0x5ECD630", VA = "0x185ECE230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[EEMCNPNJBMC]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[HLNDJCJKEJL(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct AKHPCJHJPCK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int IALHMHAHPIN;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct GNBACIHPEFG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public GCHandle CFKAOCIODHK;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[NENIHMGKIGF(0, 4)]
public enum FKEKGNHMBCB
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
public struct APCNLIMOAKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JKGONJKDNFE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public int IALHMHAHPIN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct FPKEGCHPJII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct LNIJMFMDIDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct JLAIMMPODIK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[CDIJPCPMCOP("Object", 0)]
[EEMCNPNJBMC]
[TypeManager.TypeVersion(3)]
public struct DJGFNENDCML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[BNFIOJFMILL(2)]
	public JKHJOEEKDCH FAEPKDJIIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[BNFIOJFMILL(3)]
	[GDFHIBCENFG(0)]
	public FMNADDKGANE LOMEDHEICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(4)]
	public LAHIEFBDFLK GJBMAMIDHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[HLNDJCJKEJL(5)]
	public KNLJHLBKJJO HHCBDCNLNLG;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static readonly OJJNOMGEOOK<DJGFNENDCML> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class IAPKEMFOMGM
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD130", Offset = "0x5ECC530", VA = "0x185ECD130")]
	public static void HPDCNGOHBJP(this KNLJHLBKJJO HHCBDCNLNLG, BGOPJICLMEH IIJGAKPPJCC, bool FMGHHHNFHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD110", Offset = "0x5ECC510", VA = "0x185ECD110")]
	public static bool GLPONHPHHFG(this KNLJHLBKJJO HHCBDCNLNLG, BGOPJICLMEH IIJGAKPPJCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD100", Offset = "0x5ECC500", VA = "0x185ECD100")]
	public static KNLJHLBKJJO BPDHOGHFOPI(this BGOPJICLMEH IIJGAKPPJCC)
	{
		return default(KNLJHLBKJJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD160", Offset = "0x5ECC560", VA = "0x185ECD160")]
	public static void HPDCNGOHBJP(this FMNADDKGANE HHCBDCNLNLG, FMNADDKGANE EPHAFPGCGBK, bool FMGHHHNFHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5690", Offset = "0x5DF4A90", VA = "0x185DF5690")]
	public static bool GLPONHPHHFG(this FMNADDKGANE HHCBDCNLNLG, FMNADDKGANE IIJGAKPPJCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum BGOPJICLMEH
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
[NENIHMGKIGF(0, 16383)]
[Flags]
public enum KNLJHLBKJJO
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
[NENIHMGKIGF(0, 3)]
[Flags]
public enum FMNADDKGANE
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
[NENIHMGKIGF(0, 4)]
[IAPHGCOBIHC]
public enum LAHIEFBDFLK
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
public class IAPHGCOBIHC : OHDDOIODODA
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD030", Offset = "0x5ECC430", VA = "0x185ECD030", Slot = "7")]
	public override string CDGLHMLMIMK(string PNHGPNJINIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3464A10", Offset = "0x3463E10", VA = "0x183464A10")]
	public IAPHGCOBIHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[CJCELKJNLGJ(1)]
public struct JKHJOEEKDCH : COHLAOIPMMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[HLNDJCJKEJL(1)]
	public bool BFEPOIFAJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[HLNDJCJKEJL(2)]
	public float3 NJBJPHHFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[HLNDJCJKEJL(3)]
	public float3 ENCJKLMHEMK;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static readonly OJJNOMGEOOK<JKHJOEEKDCH> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE120", Offset = "0x5ECD520", VA = "0x185ECE120", Slot = "5")]
	public void JKMDPBEAKHM(JMIJDPNPCJG PCDAGGPDBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE0D0", Offset = "0x5ECD4D0", VA = "0x185ECE0D0", Slot = "4")]
	public void ALIOEPOJFBC(JDMKDHMCHPP EKCFHKIKCOP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct FNOGPMNEHMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct CBMJIHKKJFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct HLDAOJGFHMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct FKCLABFBIPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public FixedString32Bytes MDFAJJKMBAI;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[CIJBEMIPNHF]
public struct CCDOHGNGCED : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Entity CBOHDHCKOLN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static CCDOHGNGCED GOCBKKMEEIH(Entity NMENOOMOOJP)
	{
		return default(CCDOHGNGCED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
[EEMCNPNJBMC]
public struct MKGDJJEHMBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[BNFIOJFMILL(1)]
	public Entity IEKGDINBALF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static MKGDJJEHMBN GOCBKKMEEIH(Entity HPMKKHPHJEE)
	{
		return default(MKGDJJEHMBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct GEBKFIEBILB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Entity HPMKKHPHJEE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static GEBKFIEBILB GOCBKKMEEIH(Entity HPMKKHPHJEE)
	{
		return default(GEBKFIEBILB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct FMCNCNHPDPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Entity BKDNNDLMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Entity BCDPMNOHEDK;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal struct JMIBNIKBGOL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Entity FCBNHLMCGMD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static JMIBNIKBGOL GOCBKKMEEIH(Entity HPMKKHPHJEE)
	{
		return default(JMIBNIKBGOL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal struct LEAGCMKPFFI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[NENIHMGKIGF(0, 2)]
public enum NJLLEKJBEOG
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
[CDIJPCPMCOP("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[EEMCNPNJBMC]
public struct HAPIKNLGAJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[BNFIOJFMILL(1)]
	[GDFHIBCENFG(0)]
	public float DFBJBNKLEHA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly OJJNOMGEOOK<HAPIKNLGAJO> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
[EEMCNPNJBMC]
public struct LOLDGCILNKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[BNFIOJFMILL(1)]
	public LHAFCPFJILF OBABGNILAPA;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[NENIHMGKIGF(-1, 38)]
public enum LHAFCPFJILF
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
[EEMCNPNJBMC]
public struct HHDDILGMPPN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[NENIHMGKIGF(0, 7)]
	[Flags]
	public enum BDNHGCFLJAH
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
	[BNFIOJFMILL(1)]
	public BDNHGCFLJAH HHCBDCNLNLG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static readonly OJJNOMGEOOK<HHDDILGMPPN> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool BNGMCFBDLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCD60", Offset = "0x5ECC160", VA = "0x185ECCD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FMOHMKMAKDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCD70", Offset = "0x5ECC170", VA = "0x185ECCD70")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
[EEMCNPNJBMC]
public struct GJACMGMADNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[BNFIOJFMILL(1)]
	public NJLLEKJBEOG OBABGNILAPA;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct NABFHGMOHDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public uint AJLAIKHEKDH;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[CJCELKJNLGJ(1)]
public struct BPLCIGNNFCK : COHLAOIPMMG
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[Flags]
	[NENIHMGKIGF(0, 7)]
	public enum DECNJMNNPDF
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
	[HLNDJCJKEJL(1)]
	public float OALADMNOCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[HLNDJCJKEJL(2)]
	public int AGIBEBLMHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[HLNDJCJKEJL(3)]
	public DECNJMNNPDF HHCBDCNLNLG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool CHJOHGCFHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC81B0", Offset = "0x5EC75B0", VA = "0x185EC81B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8190", Offset = "0x5EC7590", VA = "0x185EC8190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BIIGCMPHDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC81C0", Offset = "0x5EC75C0", VA = "0x185EC81C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC81D0", Offset = "0x5EC75D0", VA = "0x185EC81D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EGIKHCNJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8130", Offset = "0x5EC7530", VA = "0x185EC8130")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8110", Offset = "0x5EC7510", VA = "0x185EC8110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8140", Offset = "0x5EC7540", VA = "0x185EC8140", Slot = "5")]
	public void JKMDPBEAKHM(JMIJDPNPCJG PCDAGGPDBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC80B0", Offset = "0x5EC74B0", VA = "0x185EC80B0", Slot = "4")]
	public void ALIOEPOJFBC(JDMKDHMCHPP EKCFHKIKCOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[CIJBEMIPNHF]
internal struct DINGLOABGLI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Entity OPNNHKKHMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public int DIENMHDGFGP;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct ACGALBBFBDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[BNFIOJFMILL(1)]
	public JDBLALGPDKM KNKCFCGHKPC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x848FA0", Offset = "0x8483A0", VA = "0x180848FA0")]
	public static ACGALBBFBDE GOCBKKMEEIH(JDBLALGPDKM NMENOOMOOJP)
	{
		return default(ACGALBBFBDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[EEMCNPNJBMC]
public struct KEPOANMCOIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[BNFIOJFMILL(1)]
	public Entity MBPFKPLBDHN;
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal struct JGLJPEJKMLE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Entity MBPFKPLBDHN;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[EEMCNPNJBMC]
public struct INFINFHPFKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[BNFIOJFMILL(1)]
	public float3 GOPGKDKAOFI;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static readonly OJJNOMGEOOK<INFINFHPFKI> LHECNHAABJO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x201EB90", Offset = "0x201DF90", VA = "0x18201EB90")]
	public static INFINFHPFKI GOCBKKMEEIH(float3 NMENOOMOOJP)
	{
		return default(INFINFHPFKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
[EEMCNPNJBMC]
public struct OFLGLKKHHOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[BNFIOJFMILL(1)]
	public quaternion MKPFBAOBFNN;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static readonly OJJNOMGEOOK<OFLGLKKHHOL> LHECNHAABJO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7DC920", Offset = "0x7DBD20", VA = "0x1807DC920")]
	public static OFLGLKKHHOL GOCBKKMEEIH(quaternion NMENOOMOOJP)
	{
		return default(OFLGLKKHHOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct GOFINALGALH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[BNFIOJFMILL(1)]
	public float3 BGDGJCLFMND;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly OJJNOMGEOOK<GOFINALGALH> LHECNHAABJO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x201EB90", Offset = "0x201DF90", VA = "0x18201EB90")]
	public static GOFINALGALH GOCBKKMEEIH(float3 NMENOOMOOJP)
	{
		return default(GOFINALGALH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct LGLONILAGMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[BNFIOJFMILL(1)]
	public BPLCIGNNFCK NNBNMFFCBEB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct BOLJPIONLLD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct MLBEBEAJPLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public uint GIBJOEIDFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public int IJFMOKDPHGG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA0EFA0", Offset = "0xA0E3A0", VA = "0x180A0EFA0")]
	public MLBEBEAJPLI(uint HPELJJLLKNN, int LHOOLOPOKEC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct GBAPHBFCHAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct LPHGEPBOKFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct FPCJCBDFMCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct CBKODJHBOJG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct NELHGGJCLHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct DJODKDCBDLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct EGOJHPCODLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct FIIIFADGPHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct BDDBDHBIAHP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct LDGLLKFHCKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct GMCECIGOONJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct KHKIJOHDKOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal struct PPPNBMHAJFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct EOBCHBIMJHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct IBLIMIBKMHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
[EEMCNPNJBMC]
public struct LFHBACBPPOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[BNFIOJFMILL(1)]
	public FixedList32Bytes<int> LNBDKAJPBGK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct AKLEFHAOCDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct LPNAJAFPHIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct BEBJKKGAKPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct LGMLLANPAFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct ALAILNIMGLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct CNAOKKDACLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct MAGOPDKGLHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct IPMMHNDGOEA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[CIJBEMIPNHF]
public struct BHDNBCKDCJN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public FixedString32Bytes OFDCEGNDFKK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct HNGGHCINFLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct MHBIMKBIIKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct MGLKBIKIFOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct PNKBPECMJFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[HLNDJCJKEJL(1)]
	public AEFKPCMBAAK AJLAIKHEKDH;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly OJJNOMGEOOK<PNKBPECMJFC> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum AEFKPCMBAAK : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct HACAHFKDENF : IComponentData, IComparable<HACAHFKDENF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int CLAJOMLHBHP;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1718990", Offset = "0x1717D90", VA = "0x181718990", Slot = "4")]
	public int CompareTo(HACAHFKDENF LFMLAKDHEFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct OGDBBMKNKGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[BNFIOJFMILL(2)]
	public bool KEBPDKPNKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[BNFIOJFMILL(3)]
	public bool GPFADEAPAMB;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public static readonly OJJNOMGEOOK<OGDBBMKNKGP> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[EEMCNPNJBMC]
public struct IIDMAIPHOAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[BNFIOJFMILL(1)]
	public bool NECJADJFPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[BNFIOJFMILL(2)]
	public byte IOFJFEKDODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[BNFIOJFMILL(3)]
	public short LEJFIFHDEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[BNFIOJFMILL(4)]
	public ushort EHEFGLMCMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[BNFIOJFMILL(5)]
	public int ILNCCEJFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[BNFIOJFMILL(6)]
	public uint FJMLOFPMBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[BNFIOJFMILL(7)]
	public long JNNLBCMEFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[BNFIOJFMILL(8)]
	public ulong APNMJJAEJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[BNFIOJFMILL(9)]
	public float COJELHPLJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[BNFIOJFMILL(10)]
	public double FPKFPKNMAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[BNFIOJFMILL(11)]
	public GCCPKAKHNIO PCDFLIDBLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[BNFIOJFMILL(12)]
	public NMNOMJCIAFL DIAMMMNHNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[BNFIOJFMILL(13)]
	public BEPBMKDDPIM EMPHDBOLDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[BNFIOJFMILL(14)]
	public LOBMHPLKJKP AKABNOHPLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[BNFIOJFMILL(15)]
	public BGKJONKMOJA CMNHEDHAGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[BNFIOJFMILL(16)]
	public KMAHIGKNPOG NJLGCNGIIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[BNFIOJFMILL(17)]
	public PEGEAPKOOHM JNOGPFIABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[BNFIOJFMILL(18)]
	public JNEPMOENJMC AFEKHDPPBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[BNFIOJFMILL(20)]
	public Quaternion POHCNCNAGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[BNFIOJFMILL(22)]
	public Vector3 PJHNMIDCNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[BNFIOJFMILL(23)]
	public Vector4 LILCDMPBCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[BNFIOJFMILL(40)]
	public Entity LFMEFCHMMFE;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum GCCPKAKHNIO : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public enum NMNOMJCIAFL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum BEPBMKDDPIM : short
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum LOBMHPLKJKP : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum BGKJONKMOJA
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum KMAHIGKNPOG : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum PEGEAPKOOHM : long
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum JNEPMOENJMC : ulong
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
	[EEMCNPNJBMC]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[EEMCNPNJBMC]
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
public class PCBELIBAEHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public int HMABDLODHOL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public int EIHKMJAGNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public GameObject PLLPJJEOIKJ;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public PCBELIBAEHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class PMCGEJLGBNH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public struct IDOBAKLCOHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Vector3 FJDLNFNMFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<SerializableGuid> OCDBAHNCFFD;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class DFGMBKBNFEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public IDOBAKLCOHB KGHBOIPBPAD;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public DFGMBKBNFEK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public SerializableGuid MJMOLLKPCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public List<int> NKLAOACPKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public List<IDOBAKLCOHB> KELOLHBOONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public List<DFGMBKBNFEK> KNMKMHOBDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public GameObject PLLPJJEOIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Light BOMLMDNNCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Collider BIJOEIBHHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public string ENHBCOMKOIK;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public PMCGEJLGBNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct POPFHKGIGLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[BNFIOJFMILL(1)]
	public float3 LKNBMEHCBJE;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public static readonly OJJNOMGEOOK<POPFHKGIGLC> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
[EEMCNPNJBMC]
public struct IMHIGHMNOLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[BNFIOJFMILL(1)]
	public quaternion MKPFBAOBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[BNFIOJFMILL(2)]
	public float3 GOPGKDKAOFI;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly OJJNOMGEOOK<IMHIGHMNOLM> LHECNHAABJO;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3A643C0", Offset = "0x3A637C0", VA = "0x183A643C0")]
	public IMHIGHMNOLM(quaternion MKPFBAOBFNN, float3 GOPGKDKAOFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD670", Offset = "0x5ECCA70", VA = "0x185ECD670")]
	public static RigidTransform GOCBKKMEEIH(IMHIGHMNOLM DOJGOKCPDLA)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD670", Offset = "0x5ECCA70", VA = "0x185ECD670")]
	public static IMHIGHMNOLM GOCBKKMEEIH(RigidTransform CABEKLGKCHI)
	{
		return default(IMHIGHMNOLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class HHPBEJCCDDO
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct KDLOFCBCMJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float4x4 GIHABPGOIIE;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly OJJNOMGEOOK<KDLOFCBCMJL> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public struct AKNMFMEGEGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float4x4 KIKGIFIBGIN;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static readonly OJJNOMGEOOK<AKNMFMEGEGK> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct GHGLOLNKEJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	[BNFIOJFMILL(1)]
	public float CBMHIKLPFDJ;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static readonly OJJNOMGEOOK<GHGLOLNKEJD> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct JGGNOOLIEAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int CNDPKPDCBHH;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int DIENMHDGFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE050", Offset = "0x5ECD450", VA = "0x185ECE050")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE040", Offset = "0x5ECD440", VA = "0x185ECE040")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[EEMCNPNJBMC]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct BOINGKKGOKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[BNFIOJFMILL(1)]
	public CNPOBDKKBNA NHLHGMMLIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[BNFIOJFMILL(2)]
	public IKMIKHFDLMH BADMACDDONP;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[NENIHMGKIGF(0, 1)]
[Flags]
public enum CNPOBDKKBNA
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
[NENIHMGKIGF(-2, 2)]
public enum IKMIKHFDLMH
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
public struct HCGANAMADPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public float3 OCHCBMHBKEL;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static readonly OJJNOMGEOOK<HCGANAMADPK> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct DPELJNFKDIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public float3 JCADPOBEOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public quaternion KCLDFAAPKAB;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly OJJNOMGEOOK<DPELJNFKDIP> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class NGEHBPMHAIM
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public struct LLCKPOIHBKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public float KNILDJAOMJN;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static readonly OJJNOMGEOOK<LLCKPOIHBKE> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[NENIHMGKIGF(1000, 8000)]
public enum EGBCNJNDDPI
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
public static class DGGLFOFKEJL
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal enum KKFFEMMNBCD
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
internal static class OGBBAFPIHHG
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[NENIHMGKIGF(0, 9)]
public enum BLPMFEIOFFG
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
public static class EKCLLMHJHGA
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9250", Offset = "0x5EC8650", VA = "0x185EC9250")]
	public static bool KDPNMNCJICB(this BLPMFEIOFFG GNKGOPHBDBE)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[EEMCNPNJBMC]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public EGBCNJNDDPI prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class PAHCCFLDINN
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF8B0", Offset = "0x5ECECB0", VA = "0x185ECF8B0")]
	public static BLPMFEIOFFG JNBJMBGKJOJ(this EGBCNJNDDPI PINNOPCPBKC)
	{
		return default(BLPMFEIOFFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[NENIHMGKIGF(int.MinValue, int.MaxValue)]
public enum FAOCGIGHNBJ
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
[NENIHMGKIGF(-1, 31)]
public enum OCOKOOIDGNA
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
[EEMCNPNJBMC]
[CDIJPCPMCOP("Visual", 0)]
public struct NAEACPDOKOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(1)]
	public FAOCGIGHNBJ DDJLPLIEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(2)]
	public OCOKOOIDGNA OLONCOMGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	[BNFIOJFMILL(3)]
	[GDFHIBCENFG(0)]
	public float IPBNNOPMDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(4)]
	public Vector3 PHOLFMGKCKG;
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[BILPLCBOBEP]
[HIOOEBENKHJ(2613756846563002039uL, 6372660366488563574uL)]
[CDIJPCPMCOP("Container", 0)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct BNEMIONGDJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(1)]
	public NHGFDLDJIPN MEBJKEBHPEK;
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[Flags]
[NENIHMGKIGF(0, 15)]
public enum NHGFDLDJIPN
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
[BILPLCBOBEP]
[HIOOEBENKHJ(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct LPHJHKLNHNE : IComponentData, IEquatable<LPHJHKLNHNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[BNFIOJFMILL(1)]
	public FixedString64Bytes MDFAJJKMBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[BNFIOJFMILL(2)]
	public MMMOMNIDAFI JHANKJFICBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[BNFIOJFMILL(3)]
	public NHGFDLDJIPN MEBJKEBHPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[BNFIOJFMILL(4)]
	public CEFABOIAHDK HDOGCKKCCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[BNFIOJFMILL(5)]
	public DNLCPCPMCIL HHCBDCNLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[BNFIOJFMILL(6)]
	public float MCBMFOOILNE;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECECF0", Offset = "0x5ECE0F0", VA = "0x185ECECF0", Slot = "4")]
	public bool Equals(LPHJHKLNHNE LFMLAKDHEFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[HIOOEBENKHJ(1213445203937950283uL, 119653618660684511uL)]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[BILPLCBOBEP]
public struct MKOMNMBBGPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[BNFIOJFMILL(1)]
	public HIPJFKBDJDK PGLBHHCPLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public GCHandle OJEBKBIJNNG;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[CJCELKJNLGJ(1)]
public struct HIPJFKBDJDK : COHLAOIPMMG, IEquatable<HIPJFKBDJDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[HLNDJCJKEJL(1)]
	public int EPDCALNHKAP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCED0", Offset = "0x5ECC2D0", VA = "0x185ECCED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE50", Offset = "0x5ECC250", VA = "0x185ECCE50", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E8FE0", Offset = "0x7E83E0", VA = "0x1807E8FE0", Slot = "6")]
	public bool Equals(HIPJFKBDJDK LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1718A20", Offset = "0x1717E20", VA = "0x181718A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCF30", Offset = "0x5ECC330", VA = "0x185ECCF30", Slot = "5")]
	public void JKMDPBEAKHM(JMIJDPNPCJG PCDAGGPDBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE40", Offset = "0x5ECC240", VA = "0x185ECCE40", Slot = "4")]
	public void ALIOEPOJFBC(JDMKDHMCHPP EKCFHKIKCOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[BILPLCBOBEP]
[HIOOEBENKHJ(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
public struct EFBEIOHLDFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private uint CNMFEPHHHNB;
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[HIOOEBENKHJ(9898405628982320166uL, 2023375009558162791uL)]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[BILPLCBOBEP]
public struct CPACOMGDGHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[BNFIOJFMILL(1)]
	public KNLJHLBKJJO HHCBDCNLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[BNFIOJFMILL(2)]
	public JKHJOEEKDCH FAEPKDJIIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[BNFIOJFMILL(3)]
	[GDFHIBCENFG(0)]
	public bool IIAFDEAMKOJ;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly OJJNOMGEOOK<CPACOMGDGHN> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[BILPLCBOBEP]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[HIOOEBENKHJ(9807788745867066359uL, 15168486114979071194uL)]
public struct OKDJIHHNJEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[BNFIOJFMILL(1)]
	public KNLJHLBKJJO HHCBDCNLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[BNFIOJFMILL(2)]
	public JKHJOEEKDCH FAEPKDJIIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[BNFIOJFMILL(3)]
	[GDFHIBCENFG(0)]
	public bool IIAFDEAMKOJ;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly OJJNOMGEOOK<OKDJIHHNJEI> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[BILPLCBOBEP]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[HIOOEBENKHJ(4470189027631723570uL, 5922380073816386711uL)]
public struct PPIKOABFHPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[HLNDJCJKEJL(1)]
	public KNLJHLBKJJO HHCBDCNLNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[BNFIOJFMILL(2)]
	public JKHJOEEKDCH FAEPKDJIIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[BNFIOJFMILL(3)]
	[GDFHIBCENFG(0)]
	public FMNADDKGANE LOMEDHEICEG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly OJJNOMGEOOK<PPIKOABFHPP> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[HIOOEBENKHJ(12226092714547765037uL, 15970362445488810630uL)]
[BILPLCBOBEP]
public struct JBGOMGLDEBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[BNFIOJFMILL(2)]
	public JKHJOEEKDCH FAEPKDJIIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[GDFHIBCENFG(0)]
	[BNFIOJFMILL(3)]
	public FMNADDKGANE LOMEDHEICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[HLNDJCJKEJL(4)]
	public KNLJHLBKJJO HHCBDCNLNLG;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly OJJNOMGEOOK<JBGOMGLDEBH> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
[HIOOEBENKHJ(3318727941304405759uL, 6047901070934821887uL)]
[BILPLCBOBEP]
public struct CAJFFFNNPJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public int EPNDHEFGGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[BNFIOJFMILL(2)]
	public bool KEBPDKPNKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[BNFIOJFMILL(3)]
	public bool GPFADEAPAMB;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly OJJNOMGEOOK<CAJFFFNNPJM> LHECNHAABJO;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[HIOOEBENKHJ(5861057081882613294uL, 13746475565109640919uL)]
[BILPLCBOBEP]
public struct EJLFABIBHKE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[NENIHMGKIGF(0, 1)]
	public enum KNJIJLEPHKI
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
	[BNFIOJFMILL(1)]
	public KNJIJLEPHKI BDHEGDKIDCH;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[BILPLCBOBEP]
[HIOOEBENKHJ(14327281633525910712uL, 2559857777606771911uL)]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
public struct FKOOGBDHJDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	[BNFIOJFMILL(1)]
	public EGBCNJNDDPI PINNOPCPBKC;
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[BILPLCBOBEP]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[HIOOEBENKHJ(15725208981563603541uL, 17017036095303668770uL)]
public struct EJDJICBBJHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	[BNFIOJFMILL(1)]
	public EGBCNJNDDPI PINNOPCPBKC;
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[BILPLCBOBEP]
[HIOOEBENKHJ(1029043735688538310uL, 14256247939851101839uL)]
public struct KICIEEADLEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public BLPMFEIOFFG GNKGOPHBDBE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[BILPLCBOBEP]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[HIOOEBENKHJ(17667479821163689808uL, 11946378475791123970uL)]
public struct ABNIPBALKLK : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : FMCDNLLKPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0AE0", Offset = "0x5ECFEE0", VA = "0x185ED0AE0", Slot = "4")]
		public sealed override void AEKJAFLFNHL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class KDFKLCDPIIP : ContainerPropertyBag<DGKHAENCEFL>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class HBNKGJNCILG : Property<DGKHAENCEFL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCC80", Offset = "0x5ECC080", VA = "0x185ECCC80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC40", Offset = "0x5ECC040", VA = "0x185ECCC40")]
		public HBNKGJNCILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCBF0", Offset = "0x5ECBFF0", VA = "0x185ECCBF0", Slot = "14")]
		public override Rigidbody GetValue(DGKHAENCEFL KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC10", Offset = "0x5ECC010", VA = "0x185ECCC10", Slot = "15")]
		public override void SetValue(DGKHAENCEFL KIMBONFFHDC, Rigidbody NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE3B0", Offset = "0x5ECD7B0", VA = "0x185ECE3B0")]
	public KDFKLCDPIIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class EJCHNPBOEBI : ContainerPropertyBag<KMJNIJDBCDM>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class KDAHPJJOKLC : Property<KMJNIJDBCDM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE380", Offset = "0x5ECD780", VA = "0x185ECE380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE340", Offset = "0x5ECD740", VA = "0x185ECE340")]
		public KDAHPJJOKLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCBF0", Offset = "0x5ECBFF0", VA = "0x185ECCBF0", Slot = "14")]
		public override object GetValue(KMJNIJDBCDM KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC10", Offset = "0x5ECC010", VA = "0x185ECCC10", Slot = "15")]
		public override void SetValue(KMJNIJDBCDM KIMBONFFHDC, object NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9170", Offset = "0x5EC8570", VA = "0x185EC9170")]
	public EJCHNPBOEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class CMLLEKJIFDH : ContainerPropertyBag<HIBLOFCFGAN>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class OPHLILOJHEH : Property<HIBLOFCFGAN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF760", Offset = "0x5ECEB60", VA = "0x185ECF760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF720", Offset = "0x5ECEB20", VA = "0x185ECF720")]
		public OPHLILOJHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCBF0", Offset = "0x5ECBFF0", VA = "0x185ECCBF0", Slot = "14")]
		public override object GetValue(HIBLOFCFGAN KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC10", Offset = "0x5ECC010", VA = "0x185ECCC10", Slot = "15")]
		public override void SetValue(HIBLOFCFGAN KIMBONFFHDC, object NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8320", Offset = "0x5EC7720", VA = "0x185EC8320")]
	public CMLLEKJIFDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class FGODPHCCPLE : ContainerPropertyBag<JGLGAEDFFID>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class MODLELFJBMM : Property<JGLGAEDFFID, PHLGGGDOEBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEFF0", Offset = "0x5ECE3F0", VA = "0x185ECEFF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEFB0", Offset = "0x5ECE3B0", VA = "0x185ECEFB0")]
		public MODLELFJBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCBF0", Offset = "0x5ECBFF0", VA = "0x185ECCBF0", Slot = "14")]
		public override PHLGGGDOEBJ GetValue(JGLGAEDFFID KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC10", Offset = "0x5ECC010", VA = "0x185ECCC10", Slot = "15")]
		public override void SetValue(JGLGAEDFFID KIMBONFFHDC, PHLGGGDOEBJ NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC94D0", Offset = "0x5EC88D0", VA = "0x185EC94D0")]
	public FGODPHCCPLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class JDMPDJDLHIP : ContainerPropertyBag<PCBELIBAEHH>
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class IBBNPDOECLF : Property<PCBELIBAEHH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD200", Offset = "0x5ECC600", VA = "0x185ECD200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD1C0", Offset = "0x5ECC5C0", VA = "0x185ECD1C0")]
		public IBBNPDOECLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD180", Offset = "0x5ECC580", VA = "0x185ECD180", Slot = "14")]
		public override int GetValue(PCBELIBAEHH KIMBONFFHDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD1A0", Offset = "0x5ECC5A0", VA = "0x185ECD1A0", Slot = "15")]
		public override void SetValue(PCBELIBAEHH KIMBONFFHDC, int NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class HADBOABAGMC : Property<PCBELIBAEHH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCB60", Offset = "0x5ECBF60", VA = "0x185ECCB60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCB20", Offset = "0x5ECBF20", VA = "0x185ECCB20")]
		public HADBOABAGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCAE0", Offset = "0x5ECBEE0", VA = "0x185ECCAE0", Slot = "14")]
		public override int GetValue(PCBELIBAEHH KIMBONFFHDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCB00", Offset = "0x5ECBF00", VA = "0x185ECCB00", Slot = "15")]
		public override void SetValue(PCBELIBAEHH KIMBONFFHDC, int NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class GMGKFPLKNFH : Property<PCBELIBAEHH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCA40", Offset = "0x5ECBE40", VA = "0x185ECCA40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCA00", Offset = "0x5ECBE00", VA = "0x185ECCA00")]
		public GMGKFPLKNFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC9B0", Offset = "0x5ECBDB0", VA = "0x185ECC9B0", Slot = "14")]
		public override GameObject GetValue(PCBELIBAEHH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC9D0", Offset = "0x5ECBDD0", VA = "0x185ECC9D0", Slot = "15")]
		public override void SetValue(PCBELIBAEHH KIMBONFFHDC, GameObject NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDE10", Offset = "0x5ECD210", VA = "0x185ECDE10")]
	public JDMPDJDLHIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class KMOHPCKEEMC : ContainerPropertyBag<PMCGEJLGBNH>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class ILFMCBHCELM : Property<PMCGEJLGBNH, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD640", Offset = "0x5ECCA40", VA = "0x185ECD640", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD600", Offset = "0x5ECCA00", VA = "0x185ECD600")]
		public ILFMCBHCELM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD5B0", Offset = "0x5ECC9B0", VA = "0x185ECD5B0", Slot = "14")]
		public override SerializableGuid GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD5E0", Offset = "0x5ECC9E0", VA = "0x185ECD5E0", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, SerializableGuid NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class CDICGPLAMOO : Property<PMCGEJLGBNH, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5EC82F0", Offset = "0x5EC76F0", VA = "0x185EC82F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC82B0", Offset = "0x5EC76B0", VA = "0x185EC82B0")]
		public CDICGPLAMOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8260", Offset = "0x5EC7660", VA = "0x185EC8260", Slot = "14")]
		public override List<int> GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8280", Offset = "0x5EC7680", VA = "0x185EC8280", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, List<int> NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class KEJCKJAEOJO : Property<PMCGEJLGBNH, List<PMCGEJLGBNH.IDOBAKLCOHB>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE600", Offset = "0x5ECDA00", VA = "0x185ECE600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE5C0", Offset = "0x5ECD9C0", VA = "0x185ECE5C0")]
		public KEJCKJAEOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE570", Offset = "0x5ECD970", VA = "0x185ECE570", Slot = "14")]
		public override List<PMCGEJLGBNH.IDOBAKLCOHB> GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE590", Offset = "0x5ECD990", VA = "0x185ECE590", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, List<PMCGEJLGBNH.IDOBAKLCOHB> NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class GAOMOMMOEJH : Property<PMCGEJLGBNH, List<PMCGEJLGBNH.DFGMBKBNFEK>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5ECC920", Offset = "0x5ECBD20", VA = "0x185ECC920", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC8E0", Offset = "0x5ECBCE0", VA = "0x185ECC8E0")]
		public GAOMOMMOEJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC890", Offset = "0x5ECBC90", VA = "0x185ECC890", Slot = "14")]
		public override List<PMCGEJLGBNH.DFGMBKBNFEK> GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC8B0", Offset = "0x5ECBCB0", VA = "0x185ECC8B0", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, List<PMCGEJLGBNH.DFGMBKBNFEK> NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class ICHLKCINADN : Property<PMCGEJLGBNH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD2C0", Offset = "0x5ECC6C0", VA = "0x185ECD2C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD280", Offset = "0x5ECC680", VA = "0x185ECD280")]
		public ICHLKCINADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD230", Offset = "0x5ECC630", VA = "0x185ECD230", Slot = "14")]
		public override GameObject GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD250", Offset = "0x5ECC650", VA = "0x185ECD250", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, GameObject NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class OBIFLJMJLKL : Property<PMCGEJLGBNH, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF230", Offset = "0x5ECE630", VA = "0x185ECF230", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF1F0", Offset = "0x5ECE5F0", VA = "0x185ECF1F0")]
		public OBIFLJMJLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF1A0", Offset = "0x5ECE5A0", VA = "0x185ECF1A0", Slot = "14")]
		public override Light GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF1C0", Offset = "0x5ECE5C0", VA = "0x185ECF1C0", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, Light NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class OOPLDLBKLCH : Property<PMCGEJLGBNH, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF6F0", Offset = "0x5ECEAF0", VA = "0x185ECF6F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF6B0", Offset = "0x5ECEAB0", VA = "0x185ECF6B0")]
		public OOPLDLBKLCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF660", Offset = "0x5ECEA60", VA = "0x185ECF660", Slot = "14")]
		public override Collider GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF680", Offset = "0x5ECEA80", VA = "0x185ECF680", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, Collider NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class EGDHDPPJEDF : Property<PMCGEJLGBNH, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8F00", Offset = "0x5EC8300", VA = "0x185EC8F00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8EC0", Offset = "0x5EC82C0", VA = "0x185EC8EC0")]
		public EGDHDPPJEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8E70", Offset = "0x5EC8270", VA = "0x185EC8E70", Slot = "14")]
		public override string GetValue(PMCGEJLGBNH KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8E90", Offset = "0x5EC8290", VA = "0x185EC8E90", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH KIMBONFFHDC, string NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE790", Offset = "0x5ECDB90", VA = "0x185ECE790")]
	public KMOHPCKEEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class IDHGIJLNMLD : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class BGJFOLMLLGH : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7F80", Offset = "0x5EC7380", VA = "0x185EC7F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7E90", Offset = "0x5EC7290", VA = "0x185EC7E90")]
		public BGJFOLMLLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xE05570", Offset = "0xE04970", VA = "0x180E05570", Slot = "14")]
		public override Data128 GetValue(SerializableGuid KIMBONFFHDC)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7E80", Offset = "0x5EC7280", VA = "0x185EC7E80", Slot = "15")]
		public override void SetValue(SerializableGuid KIMBONFFHDC, Data128 NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD2F0", Offset = "0x5ECC6F0", VA = "0x185ECD2F0")]
	public IDHGIJLNMLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class DJMOBNFFDAF : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	private class OBEKCNHGIOA : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF170", Offset = "0x5ECE570", VA = "0x185ECF170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF080", Offset = "0x5ECE480", VA = "0x185ECF080")]
		public OBEKCNHGIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12CDF00", Offset = "0x12CD300", VA = "0x1812CDF00", Slot = "14")]
		public override int GetValue(Data128 KIMBONFFHDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8030", Offset = "0x5EC7430", VA = "0x185EC8030", Slot = "15")]
		public override void SetValue(Data128 KIMBONFFHDC, int NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class IJCAAKBEOFC : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD580", Offset = "0x5ECC980", VA = "0x185ECD580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD490", Offset = "0x5ECC890", VA = "0x185ECD490")]
		public IJCAAKBEOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD470", Offset = "0x5ECC870", VA = "0x185ECD470", Slot = "14")]
		public override int GetValue(Data128 KIMBONFFHDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD480", Offset = "0x5ECC880", VA = "0x185ECD480", Slot = "15")]
		public override void SetValue(Data128 KIMBONFFHDC, int NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	private class MKNPIPMDMDK : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEF20", Offset = "0x5ECE320", VA = "0x185ECEF20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEE30", Offset = "0x5ECE230", VA = "0x185ECEE30")]
		public MKNPIPMDMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x159F570", Offset = "0x159E970", VA = "0x18159F570", Slot = "14")]
		public override int GetValue(Data128 KIMBONFFHDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEE20", Offset = "0x5ECE220", VA = "0x185ECEE20", Slot = "15")]
		public override void SetValue(Data128 KIMBONFFHDC, int NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class OMMMMAFEDLN : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF5A0", Offset = "0x5ECE9A0", VA = "0x185ECF5A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF4B0", Offset = "0x5ECE8B0", VA = "0x185ECF4B0")]
		public OMMMMAFEDLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF490", Offset = "0x5ECE890", VA = "0x185ECF490", Slot = "14")]
		public override int GetValue(Data128 KIMBONFFHDC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF4A0", Offset = "0x5ECE8A0", VA = "0x185ECF4A0", Slot = "15")]
		public override void SetValue(Data128 KIMBONFFHDC, int NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5EC86D0", Offset = "0x5EC7AD0", VA = "0x185EC86D0")]
	public DJMOBNFFDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class EBFEDJAGFMP : ContainerPropertyBag<PMCGEJLGBNH.IDOBAKLCOHB>
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	private class KKMEKEKLDFO : Property<PMCGEJLGBNH.IDOBAKLCOHB, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE690", Offset = "0x5ECDA90", VA = "0x185ECE690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE650", Offset = "0x5ECDA50", VA = "0x185ECE650")]
		public KKMEKEKLDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8EB580", Offset = "0x8EA980", VA = "0x1808EB580", Slot = "14")]
		public override Vector3 GetValue(PMCGEJLGBNH.IDOBAKLCOHB KIMBONFFHDC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE630", Offset = "0x5ECDA30", VA = "0x185ECE630", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH.IDOBAKLCOHB KIMBONFFHDC, Vector3 NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class JGAEJAMJJDB : Property<PMCGEJLGBNH.IDOBAKLCOHB, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE010", Offset = "0x5ECD410", VA = "0x185ECE010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDFD0", Offset = "0x5ECD3D0", VA = "0x185ECDFD0")]
		public JGAEJAMJJDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDFB0", Offset = "0x5ECD3B0", VA = "0x185ECDFB0", Slot = "14")]
		public override List<SerializableGuid> GetValue(PMCGEJLGBNH.IDOBAKLCOHB KIMBONFFHDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDFC0", Offset = "0x5ECD3C0", VA = "0x185ECDFC0", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH.IDOBAKLCOHB KIMBONFFHDC, List<SerializableGuid> NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8D10", Offset = "0x5EC8110", VA = "0x185EC8D10")]
	public EBFEDJAGFMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class EKDJOFBFHMF : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class JDGFFDKOLOP : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5ECDDE0", Offset = "0x5ECD1E0", VA = "0x185ECDDE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDDA0", Offset = "0x5ECD1A0", VA = "0x185ECDDA0")]
		public JDGFFDKOLOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDD80", Offset = "0x5ECD180", VA = "0x185ECDD80", Slot = "14")]
		public override float GetValue(Vector3 KIMBONFFHDC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDD90", Offset = "0x5ECD190", VA = "0x185ECDD90", Slot = "15")]
		public override void SetValue(Vector3 KIMBONFFHDC, float NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	private class ONDMCIPACJD : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF630", Offset = "0x5ECEA30", VA = "0x185ECF630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF5F0", Offset = "0x5ECE9F0", VA = "0x185ECF5F0")]
		public ONDMCIPACJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF5D0", Offset = "0x5ECE9D0", VA = "0x185ECF5D0", Slot = "14")]
		public override float GetValue(Vector3 KIMBONFFHDC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF5E0", Offset = "0x5ECE9E0", VA = "0x185ECF5E0", Slot = "15")]
		public override void SetValue(Vector3 KIMBONFFHDC, float NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	private class BICLPGPJDEK : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8000", Offset = "0x5EC7400", VA = "0x185EC8000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7FC0", Offset = "0x5EC73C0", VA = "0x185EC7FC0")]
		public BICLPGPJDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1984FE0", Offset = "0x19843E0", VA = "0x181984FE0", Slot = "14")]
		public override float GetValue(Vector3 KIMBONFFHDC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7FB0", Offset = "0x5EC73B0", VA = "0x185EC7FB0", Slot = "15")]
		public override void SetValue(Vector3 KIMBONFFHDC, float NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9260", Offset = "0x5EC8660", VA = "0x185EC9260")]
	public EKDJOFBFHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class AOOOBHIFEPJ : ContainerPropertyBag<PMCGEJLGBNH.DFGMBKBNFEK>
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class KOPGDMIFCBA : Property<PMCGEJLGBNH.DFGMBKBNFEK, PMCGEJLGBNH.IDOBAKLCOHB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC60", Offset = "0x5ECE060", VA = "0x185ECEC60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC20", Offset = "0x5ECE020", VA = "0x185ECEC20")]
		public KOPGDMIFCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEBB0", Offset = "0x5ECDFB0", VA = "0x185ECEBB0", Slot = "14")]
		public override PMCGEJLGBNH.IDOBAKLCOHB GetValue(PMCGEJLGBNH.DFGMBKBNFEK KIMBONFFHDC)
		{
			return default(PMCGEJLGBNH.IDOBAKLCOHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEBE0", Offset = "0x5ECDFE0", VA = "0x185ECEBE0", Slot = "15")]
		public override void SetValue(PMCGEJLGBNH.DFGMBKBNFEK KIMBONFFHDC, PMCGEJLGBNH.IDOBAKLCOHB NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7D20", Offset = "0x5EC7120", VA = "0x185EC7D20")]
	public AOOOBHIFEPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class HJHEMEPOCHI : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	private class BKLIOOLPHHO : Property<RRObjectPrefabV2Data, EGBCNJNDDPI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string MFBMONNEDKC
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8080", Offset = "0x5EC7480", VA = "0x185EC8080", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool AHEALAJHHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8040", Offset = "0x5EC7440", VA = "0x185EC8040")]
		public BKLIOOLPHHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x12CDF00", Offset = "0x12CD300", VA = "0x1812CDF00", Slot = "14")]
		public override EGBCNJNDDPI GetValue(RRObjectPrefabV2Data KIMBONFFHDC)
		{
			return default(EGBCNJNDDPI);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8030", Offset = "0x5EC7430", VA = "0x185EC8030", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data KIMBONFFHDC, EGBCNJNDDPI NMENOOMOOJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCF50", Offset = "0x5ECC350", VA = "0x185ECCF50")]
	public HJHEMEPOCHI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFC10", Offset = "0x5ECF010", VA = "0x185ECFC10")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
public class DADPLEAPLGN
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public DADPLEAPLGN()
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

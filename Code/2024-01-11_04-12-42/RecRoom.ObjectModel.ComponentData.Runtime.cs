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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PEFHEHJPCOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode LLIHIKHEDEI;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KGOLHGPHLHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public AMJAHPDIMMI BNLCNCBFKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly JMPBNDCKNOF<KGOLHGPHLHK> MBNAEHMDPIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IAFFGLOHDFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PIFLIGCPJMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AMJAHPDIMMI
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
public struct JPIGDKNNMPD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct MENONEAJGLO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity PMJGAJHPHFJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JLNFCBMGPHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity CDMOGOKIPKH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LAPGFIPGBIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ICOLPMFPNJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity AJBLHMMPNNM;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct CBPPHEIPLCN : OLBCKPMBJDB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NNEJFNDGFNI BMMHOLPJNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NNEJFNDGFNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BBFBCJFHDBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 GOOIGCPCPLD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OFMFOMCACHL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LIDJGCIAFEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 KCGNANNGOOC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JMPBNDCKNOF<EAJPDGLIIOC> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EAJPDGLIIOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 KCGNANNGOOC;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly JMPBNDCKNOF<EAJPDGLIIOC> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ABLMFKMCFIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 OLCKGINIGDD;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FDMOAGDAMBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 ONHKMLJFEOA;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PEIOIKLONLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float KCDFKPDMHFB;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JMPBNDCKNOF<PEIOIKLONLN> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OLHOPNJDLBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float AKKPMFIOHPD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly JMPBNDCKNOF<OLHOPNJDLBI> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BPOIIPFNOEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 OMGECHBBEOA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct AFPBLFIMBEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EMJNKAFCANP KBHGDJPPDJK;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LFFIOAFENDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EMJNKAFCANP BOEECLOFBNF;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[EBKFCBKAIMD]
public struct IEOMGCCAGBM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity MJDHOBNEHKO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ABOGLDICICM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct PMGCKMKBCCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LGPBAKADGDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct OHLLENHIAMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints IGMMJGKAHGN;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct HFOKLNNEEDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float KHENEOLNGLG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly JMPBNDCKNOF<HFOKLNNEEDK> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MBGNGPAMFFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float FDEPLLIFNMD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct ANBJEHLOMII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct EGHJAAFDNHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int OEJGGLDEEHL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD82DD0", Offset = "0xD817D0", VA = "0x180D82DD0")]
	public static EGHJAAFDNHK LODPGCNHAMK(int BEEGCHJLJFC)
	{
		return default(EGHJAAFDNHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BFGBICMPDKD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody BHAECPFLHOI;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6091E70", Offset = "0x6090870", VA = "0x186091E70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public BFGBICMPDKD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct NAGIDNEMOPL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CDKELLOCJKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 PABPMGJGOIN;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DALFGHKKNMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 FEGCMBDOBNF;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct CJDOKFHJMMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float LKPPAMHBCFA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JMPBNDCKNOF<CJDOKFHJMMM> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GFOOIBOFDIB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object HBJIENMJBPG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6097170", Offset = "0x6095B70", VA = "0x186097170", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public GFOOIBOFDIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CGIGMKJHMBC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object LFIKKDOOENI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6092340", Offset = "0x6090D40", VA = "0x186092340", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public CGIGMKJHMBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum EMJNKAFCANP
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum DJEILIGJBKK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JMMLFPJJFBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFPEOOFLIFH(AMJAHPDIMMI BGBCAFIGCEH, AMJAHPDIMMI KOFBLEFJMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDHCGJPMJMN();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBLONGEJIDH();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMEAMGDDHBF(bool ABJMBKAGLDC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BPCLOPGCELP();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDHGOALDPBF();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HCJPFGILNPA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public JMMLFPJJFBD AHDIBKIEEBF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6097550", Offset = "0x6095F50", VA = "0x186097550", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public HCJPFGILNPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FJLJKAJCCGD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(LLDGLKMGPFO nameHash, JBMOFCOGNOB stableTypeHash, Type type)> EDEAMELINBJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(LLDGLKMGPFO nameHash, JBMOFCOGNOB stableTypeHash, Type type)> KNNDEADICKH;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(LLDGLKMGPFO previousNameHash, JBMOFCOGNOB previousStableTypeHash, Type currentTypeName)> GFCOHHDJKEG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct GNBDDMOBPHI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, KGPHCFEPIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6091C20", Offset = "0x6090620", VA = "0x186091C20", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct MAGNIFHFPFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[MHODKKGKOHE(1)]
	public quaternion HDEHMDBACJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[MHODKKGKOHE(2)]
	public float3 LAKIBICOBFE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly JMPBNDCKNOF<MAGNIFHFPFA> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4BE0", Offset = "0x3BB35E0", VA = "0x183BB4BE0")]
	public MAGNIFHFPFA(quaternion HDEHMDBACJH, float3 LAKIBICOBFE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6091EE0", Offset = "0x60908E0", VA = "0x186091EE0")]
	public static MAGNIFHFPFA LODPGCNHAMK(RigidTransform BBLLGBDKAGE)
	{
		return default(MAGNIFHFPFA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MEKHNHNGHPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct PDMAPJNNPAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[MHODKKGKOHE(1)]
	public float HKAHBEBLFID;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly JMPBNDCKNOF<PDMAPJNNPAK> MBNAEHMDPIA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	[KEFMCNPKALD]
	public struct AuthoredParentData : IComponentData, KGPHCFEPIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[MHODKKGKOHE(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6091C30", Offset = "0x6090630", VA = "0x186091C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct DIFDJOMNEDK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, KGPHCFEPIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LDJNOPEDJJM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct LNMCMIIMCAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[MHODKKGKOHE(1)]
	public SerializableGuid HBBHIHHDOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[MHODKKGKOHE(2)]
	public SerializableGuid NEFDNKINHCD;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(780699438743496039uL)]
[KEFMCNPKALD]
public struct ABNJMANFHMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[MHODKKGKOHE(1)]
	[FormerlySerializedAs("Active")]
	public bool IFLHKNDBIIB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly JMPBNDCKNOF<ABNJMANFHMD> MBNAEHMDPIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[MPAGFGLMKCM]
public struct FNMBLAAMDBN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
[KEFMCNPKALD]
public struct GDPGDPEJEMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[MHODKKGKOHE(1)]
	public Entity DMGNBGDJEMF;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PHAFGGDGMGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity KODNJNBLKNC;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct LHEJANPKOKO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity KODNJNBLKNC;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[INAHGLFHGGO("Container", 0)]
public struct DIDPCDIMOFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(1)]
	public OEEPKAKDDFH ADNNINFEIDP;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly JMPBNDCKNOF<DIDPCDIMOFM> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[LAOCFNICPGL(0, 127)]
public enum OEEPKAKDDFH
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
public static class IBJNKOPFLAF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum CHNMABMGDLM
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
	public enum PCNKDBMPDJM
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
	[Cpp2IlInjected.Address(RVA = "0x6097910", Offset = "0x6096310", VA = "0x186097910")]
	public static (CHNMABMGDLM, PCNKDBMPDJM) MMFLHBBCBKE(this OEEPKAKDDFH KBMDALJGEFL)
	{
		return default((CHNMABMGDLM, PCNKDBMPDJM));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[INAHGLFHGGO("Container", 0)]
public struct NNIBPBIIDIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[MHODKKGKOHE(1)]
	[HMBPLLNFAIN(0)]
	public HHIDNHLGHBP POFOAAKGEHC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly JMPBNDCKNOF<NNIBPBIIDIA> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[LAOCFNICPGL(0, 2)]
public enum HHIDNHLGHBP
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
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
[INAHGLFHGGO("Container", 0)]
public struct KIBOBGLIFOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[MHODKKGKOHE(1)]
	[HMBPLLNFAIN(0)]
	public LFHMKKMAAEK KPJDDJOANKE;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[LAOCFNICPGL(0, 15943)]
[Flags]
public enum LFHMKKMAAEK
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
public struct ANIFJOPKBOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct MABCGIACFHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct GAMBEOCDHIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct GICAKIAOMLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct EJIEECJPJHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct PCHLIBCCNKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct BCFCBIADFBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct CIOKNJOGHKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct JMCPLDNEPIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[INAHGLFHGGO("Container", 0)]
[KEFMCNPKALD]
public struct IJAHDCKNHPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(1)]
	public float ILAFIEOKEON;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[INAHGLFHGGO("Container", 0)]
public struct DLOFCPHIMJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(1)]
	public FixedString64Bytes CDHDOGOGPME;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct JFCNBCEOKAB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<JILINAKHBCE> ACNBDHODIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<Entity> EOEGKKLMLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JobHandle MPIOAGHMLJG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CLEDPFONKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6097F00", Offset = "0x6096900", VA = "0x186097F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6097F70", Offset = "0x6096970", VA = "0x186097F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4564F90", Offset = "0x4563990", VA = "0x184564F90")]
	public JFCNBCEOKAB(NativeList<JILINAKHBCE> ACNBDHODIBJ, NativeList<Entity> EOEGKKLMLHJ, JobHandle MPIOAGHMLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6097DE0", Offset = "0x60967E0", VA = "0x186097DE0")]
	public (Entity, NativeSlice<Entity>) GJIDJOPENLB(int HLIHAMMEEIJ)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6097D80", Offset = "0x6096780", VA = "0x186097D80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JILINAKHBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity AJBLHMMPNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int IACEHNBBCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int FJADIACPEIM;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface IGKHPMCINIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADHADJDCDEL(bool FFMELGMPAIA);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[INAHGLFHGGO("Container", 0)]
[KEFMCNPKALD]
public struct OPCJDNKBHMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[MHODKKGKOHE(1)]
	[HMBPLLNFAIN(0)]
	public INFCHKFHJDC GHFEDJGEOAA;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LAOCFNICPGL(0, 1)]
public enum INFCHKFHJDC
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
[INAHGLFHGGO("Container", 0)]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
public struct AIJHPCEPEJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(1)]
	public NICINFGALBA DBADKKDMFAJ;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly JMPBNDCKNOF<AIJHPCEPEJP> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[LAOCFNICPGL(0, 2)]
public enum NICINFGALBA
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
[JANKINADJFI(1)]
public struct EEDNLDFABNC : IComparable<EEDNLDFABNC>, IEquatable<EEDNLDFABNC>, CCAIAFIJCPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[LMGGMAHKKHI(1)]
	public uint KLPJPODNJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[LMGGMAHKKHI(2)]
	public uint FIOOJPAGGMB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint KCKJBDIODEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6093330", Offset = "0x6091D30", VA = "0x186093330")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6093720", Offset = "0x6092120", VA = "0x186093720")]
	public EEDNLDFABNC(int KLPJPODNJDD, int LMDJCKMOOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6093720", Offset = "0x6092120", VA = "0x186093720")]
	public EEDNLDFABNC(uint KLPJPODNJDD, uint LMDJCKMOOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60934C0", Offset = "0x6091EC0", VA = "0x1860934C0")]
	public EEDNLDFABNC HJAEJEOPMBF(int IACEHNBBCDL = 1)
	{
		return default(EEDNLDFABNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6093560", Offset = "0x6091F60", VA = "0x186093560")]
	public EEDNLDFABNC IJJGDBJBCIE(int IACEHNBBCDL = 1)
	{
		return default(EEDNLDFABNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60933F0", Offset = "0x6091DF0", VA = "0x1860933F0")]
	public static EEDNLDFABNC GHLGPHDGOPI(EEDNLDFABNC GHGBJDGFDKJ, EEDNLDFABNC PHPPILHFFME)
	{
		return default(EEDNLDFABNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6093530", Offset = "0x6091F30", VA = "0x186093530")]
	private static uint ICKIFCMPDMM(uint PJHMDOOMOBI, uint OIKFNBPLIOK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60932A0", Offset = "0x6091CA0", VA = "0x1860932A0", Slot = "4")]
	public int CompareTo(EEDNLDFABNC CGDFJMJIABO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6093360", Offset = "0x6091D60", VA = "0x186093360", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6093640", Offset = "0x6092040", VA = "0x186093640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6093340", Offset = "0x6091D40", VA = "0x186093340", Slot = "5")]
	public bool Equals(EEDNLDFABNC CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6093470", Offset = "0x6091E70", VA = "0x186093470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60935D0", Offset = "0x6091FD0", VA = "0x1860935D0", Slot = "6")]
	public void JLKDILEIJOC(EGNBIPNLKLC HAMBOEKDHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60932C0", Offset = "0x6091CC0", VA = "0x1860932C0", Slot = "7")]
	public void DCJJDHFPDEL(HIJMOAHPPLN HPEAJCENMCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x23C01B0", Offset = "0x23BEBB0", VA = "0x1823C01B0")]
	public static bool JGKBBKJJNFA(EEDNLDFABNC GHGBJDGFDKJ, EEDNLDFABNC PHPPILHFFME)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[JANKINADJFI(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[LMGGMAHKKHI(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[LMGGMAHKKHI(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[LMGGMAHKKHI(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[LMGGMAHKKHI(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[JANKINADJFI(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, CCAIAFIJCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[LMGGMAHKKHI(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public static SerializableGuid LODPGCNHAMK(Guid DMMBGEACBPP)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x609A860", Offset = "0x6099260", VA = "0x18609A860", Slot = "4")]
		public bool Equals(SerializableGuid CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializableGuid CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x609A890", Offset = "0x6099290", VA = "0x18609A890", Slot = "6")]
		public void JLKDILEIJOC(EGNBIPNLKLC HAMBOEKDHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x609A7E0", Offset = "0x60991E0", VA = "0x18609A7E0", Slot = "7")]
		public void DCJJDHFPDEL(HIJMOAHPPLN HPEAJCENMCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x609A950", Offset = "0x6099350", VA = "0x18609A950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct CLECDGFBKIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct PAICCNMOGMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct AHNIFCAIGOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
public struct JDPNMPKCJPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[MHODKKGKOHE(1)]
	public Entity EOOLNHNODOB;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[InternalBufferCapacity(17)]
public struct HGPMFMPDCJF : IBufferElementData, IEquatable<HGPMFMPDCJF>, KGPHCFEPIHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Entity PMJGAJHPHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public int IBLNMNGCMFK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity NIJDEJJIOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6097800", Offset = "0x6096200", VA = "0x186097800", Slot = "4")]
	public bool Equals(HGPMFMPDCJF CGDFJMJIABO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
public struct OBILAPCFBOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[MHODKKGKOHE(1)]
	public int IBLNMNGCMFK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct PEPHFJFDOFK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
[KEFMCNPKALD]
public struct IIIKCGDLDKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[MHODKKGKOHE(1)]
	public Entity OLAMMKFDBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[MHODKKGKOHE(2)]
	public uint MGJHDHNFIBC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId PPIAGOJCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A090", Offset = "0x1D28A90", VA = "0x181D2A090")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1D49BB0", Offset = "0x1D485B0", VA = "0x181D49BB0")]
	public IIIKCGDLDKG(Entity OLAMMKFDBEM, EntityBundlePartId BFHPEHKODJC)
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
		[Cpp2IlInjected.Address(RVA = "0x8986D0", Offset = "0x8970D0", VA = "0x1808986D0")]
		internal EntityBundlePartId(uint KABOEEEDCAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8986C0", Offset = "0x8970C0", VA = "0x1808986C0")]
		internal uint OBKIFGEAKNH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8135B0", Offset = "0x811FB0", VA = "0x1808135B0", Slot = "4")]
		public bool Equals(EntityBundlePartId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6093980", Offset = "0x6092380", VA = "0x186093980", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8A0350", Offset = "0x89ED50", VA = "0x1808A0350", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1757570", Offset = "0x1755F70", VA = "0x181757570")]
		public static bool JGKBBKJJNFA(EntityBundlePartId PJHMDOOMOBI, EntityBundlePartId OIKFNBPLIOK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HGEOJKNPILB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Entity LIPMFFDMFJB;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
[KEFMCNPKALD]
public struct LPMFCGLLOCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[MHODKKGKOHE(1)]
	public Entity DMFBOAFMPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[MHODKKGKOHE(2)]
	public bool HMNEPDENNLG;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct EJMCGLAJBOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[MHODKKGKOHE(1)]
	public GCCAMLAFJEL JELFLBPLNPE;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[LAOCFNICPGL(0, 4)]
public enum GCCAMLAFJEL
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
[KEFMCNPKALD]
public struct BJGBNFGPJJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[MHODKKGKOHE(1)]
	public Entity DMFBOAFMPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[MHODKKGKOHE(2)]
	public bool MMBBHDHDFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[MHODKKGKOHE(3)]
	public float PKOENDFCPAK;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[KEFMCNPKALD]
public struct HKANKMHIBEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[MHODKKGKOHE(1)]
	public bool NEGLEJJNHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[MHODKKGKOHE(2)]
	public bool MMBBHDHDFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[MHODKKGKOHE(3)]
	public float BLPAGNELGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[MHODKKGKOHE(4)]
	public float NHJJBILLIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[MHODKKGKOHE(5)]
	public float GPOGCNJCGJN;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct JGMNFACMLAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[MHODKKGKOHE(1)]
	public bool NEGLEJJNHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[MHODKKGKOHE(2)]
	public bool MMBBHDHDFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[MHODKKGKOHE(3)]
	public float PKOENDFCPAK;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, KGPHCFEPIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6091C20", Offset = "0x6090620", VA = "0x186091C20", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[KEFMCNPKALD]
	public struct ParentData : IComponentData, KGPHCFEPIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[MHODKKGKOHE(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, KGPHCFEPIHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1760B70", Offset = "0x175F570", VA = "0x181760B70")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct JBIKOJBJNOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface KGPHCFEPIHA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity DOAGACNALME
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
public struct MCHCGBLGKMD<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly bool DAJJFGPBCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public uint HPGMBJGOJOL;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	private static bool DMMOJJHFJLH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[KEFMCNPKALD]
[INAHGLFHGGO("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct AHJHHDIJPIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(1)]
	public bool GJMLPIHBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(2)]
	public float IPBBIPKDEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(3)]
	public float JIDMDIPLJHA;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[INAHGLFHGGO("Light", 0)]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
public struct DLLECFOFPMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[MHODKKGKOHE(1)]
	[HMBPLLNFAIN(0)]
	public float PJNLNHMNPFI;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.TypeVersion(2)]
public struct LBBCPACFJJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public uint BBGJABFDACB;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6098480", Offset = "0x6096E80", VA = "0x186098480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[KEFMCNPKALD]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[LMGGMAHKKHI(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct DJAMLOHDHNC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public int GFJEGIBCBHA;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GHFMGCNDONB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public GCHandle IJJMKEOBIEM;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[LAOCFNICPGL(0, 4)]
public enum JLHKFECOJKN
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
public struct HCBIENBAEGK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NOLBKNKCHAE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public int GFJEGIBCBHA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PAOHCLDKNJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct MIJFDLFNBIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct FEGOFBCADAN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[INAHGLFHGGO("Object", 0)]
[TypeManager.TypeVersion(3)]
public struct HFLKMMEPHBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[MHODKKGKOHE(2)]
	public DNJMDNMJIFB OJJFHIHKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(3)]
	public ILNGCJCMJLG CKACMJMNDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	[MHODKKGKOHE(4)]
	[HMBPLLNFAIN(0)]
	public GOJABHENPPC COOFPAJJKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[LMGGMAHKKHI(5)]
	public KCPFFIABALL KPJDDJOANKE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly JMPBNDCKNOF<HFLKMMEPHBF> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class OCLEDDDJIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6098FC0", Offset = "0x60979C0", VA = "0x186098FC0")]
	public static void OGNHOBPFCBA(this KCPFFIABALL KPJDDJOANKE, AGALEOLDIMG ODHDDCBOGKE, bool DIGMNOMJFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6098F80", Offset = "0x6097980", VA = "0x186098F80")]
	public static bool CMMJMEDNBFL(this KCPFFIABALL KPJDDJOANKE, AGALEOLDIMG ODHDDCBOGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6098F70", Offset = "0x6097970", VA = "0x186098F70")]
	public static KCPFFIABALL CMKJBEBHMNH(this AGALEOLDIMG ODHDDCBOGKE)
	{
		return default(KCPFFIABALL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6098FA0", Offset = "0x60979A0", VA = "0x186098FA0")]
	public static void OGNHOBPFCBA(this ILNGCJCMJLG KPJDDJOANKE, ILNGCJCMJLG HKOOLHHLEMM, bool DIGMNOMJFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0DD0", Offset = "0x5FAF7D0", VA = "0x185FB0DD0")]
	public static bool CMMJMEDNBFL(this ILNGCJCMJLG KPJDDJOANKE, ILNGCJCMJLG ODHDDCBOGKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum AGALEOLDIMG
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
[LAOCFNICPGL(0, 16383)]
[Flags]
public enum KCPFFIABALL
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
[LAOCFNICPGL(0, 3)]
public enum ILNGCJCMJLG
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
[LAOCFNICPGL(0, 4)]
[NGKCMCIGEHF]
public enum GOJABHENPPC
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
public class NGKCMCIGEHF : NNOBCICEKOF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6098CB0", Offset = "0x60976B0", VA = "0x186098CB0", Slot = "7")]
	public override string POMDKIGIFKL(string IPDIFFOOAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E65BD0", Offset = "0x1E645D0", VA = "0x181E65BD0")]
	public NGKCMCIGEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[JANKINADJFI(1)]
public struct DNJMDNMJIFB : CCAIAFIJCPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[LMGGMAHKKHI(1)]
	public bool GJMLPIHBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[LMGGMAHKKHI(2)]
	public float3 JJJKALODOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[LMGGMAHKKHI(3)]
	public float3 PHGDPHDHLDN;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly JMPBNDCKNOF<DNJMDNMJIFB> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6092C00", Offset = "0x6091600", VA = "0x186092C00", Slot = "5")]
	public void DCJJDHFPDEL(HIJMOAHPPLN HPEAJCENMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6092C70", Offset = "0x6091670", VA = "0x186092C70", Slot = "4")]
	public void JLKDILEIJOC(EGNBIPNLKLC HAMBOEKDHKF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct FHBHGLDFHFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct DMEHHKLDKPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct ALPIMPHJBCD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GKPAFOHOEHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public FixedString32Bytes CDHDOGOGPME;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[EBKFCBKAIMD]
public struct IFCHNAOLBKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Entity CNGLJAGLGEC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static IFCHNAOLBKD LODPGCNHAMK(Entity BEEGCHJLJFC)
	{
		return default(IFCHNAOLBKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
[KEFMCNPKALD]
public struct KFMDHECOIJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[MHODKKGKOHE(1)]
	public Entity DNOMADACKIK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static KFMDHECOIJI LODPGCNHAMK(Entity MJDHOBNEHKO)
	{
		return default(KFMDHECOIJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal struct MGKIEDEKEFC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Entity MJDHOBNEHKO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static MGKIEDEKEFC LODPGCNHAMK(Entity MJDHOBNEHKO)
	{
		return default(MGKIEDEKEFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct JHJLPPNHBAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Entity PLDGEBEOHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Entity NJJNEBAGCEP;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal struct OFGIAFGIKJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Entity EAPGBBBEFHE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static OFGIAFGIKJN LODPGCNHAMK(Entity MJDHOBNEHKO)
	{
		return default(OFGIAFGIKJN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal struct FGHDGBHBOFC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[LAOCFNICPGL(0, 2)]
public enum LJMMJPCHKOG
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
[INAHGLFHGGO("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[KEFMCNPKALD]
public struct ACAACBFPMJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(1)]
	public float NDNFCGDOIEE;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static readonly JMPBNDCKNOF<ACAACBFPMJP> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct JBJFIJNDPPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[MHODKKGKOHE(1)]
	public FJBOEPNNDLB JGPFPBPPHHA;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[LAOCFNICPGL(-1, 38)]
public enum FJBOEPNNDLB
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
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct KHAJMFLPFCG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[LAOCFNICPGL(0, 7)]
	[Flags]
	public enum IAIPCJDIIDJ
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
	[MHODKKGKOHE(1)]
	public IAIPCJDIIDJ KPJDDJOANKE;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public static readonly JMPBNDCKNOF<KHAJMFLPFCG> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NGFCHBGDKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60983A0", Offset = "0x6096DA0", VA = "0x1860983A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool FMFANEMJGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x60983B0", Offset = "0x6096DB0", VA = "0x1860983B0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct LJPOJKNJIAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[MHODKKGKOHE(1)]
	public LJMMJPCHKOG JGPFPBPPHHA;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct FEHIOBKANOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public uint BKOLDLDNEOO;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[JANKINADJFI(1)]
public struct IFLEAPEACFJ : CCAIAFIJCPA
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[LAOCFNICPGL(0, 7)]
	[Flags]
	public enum MLAEJLPBEFP
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
	[LMGGMAHKKHI(1)]
	public float BALDHOKPDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[LMGGMAHKKHI(2)]
	public int HMCCFHLIDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[LMGGMAHKKHI(3)]
	public MLAEJLPBEFP KPJDDJOANKE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JCCIKLNDGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6097BE0", Offset = "0x60965E0", VA = "0x186097BE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6097B60", Offset = "0x6096560", VA = "0x186097B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AOMEJJFCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6097C50", Offset = "0x6096650", VA = "0x186097C50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6097C60", Offset = "0x6096660", VA = "0x186097C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool KOJOLDHLGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6097BD0", Offset = "0x60965D0", VA = "0x186097BD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6097C80", Offset = "0x6096680", VA = "0x186097C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6097B80", Offset = "0x6096580", VA = "0x186097B80", Slot = "5")]
	public void DCJJDHFPDEL(HIJMOAHPPLN HPEAJCENMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6097BF0", Offset = "0x60965F0", VA = "0x186097BF0", Slot = "4")]
	public void JLKDILEIJOC(EGNBIPNLKLC HAMBOEKDHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[EBKFCBKAIMD]
internal struct LMEAMJIJEEO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Entity EHJNCHHPGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public int BNALCEABILL;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[KEFMCNPKALD]
public struct HIFDBKNFKFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[MHODKKGKOHE(1)]
	public EEDNLDFABNC GPMGFHLOLMB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0")]
	public static HIFDBKNFKFG LODPGCNHAMK(EEDNLDFABNC BEEGCHJLJFC)
	{
		return default(HIFDBKNFKFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[KEFMCNPKALD]
public struct ADADODHCJGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[MHODKKGKOHE(1)]
	public Entity AOFJEMCOLNP;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct DHKJNOAFHED : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Entity AOFJEMCOLNP;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[KEFMCNPKALD]
public struct NLIHDEONEPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[MHODKKGKOHE(1)]
	public float3 LAKIBICOBFE;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static readonly JMPBNDCKNOF<NLIHDEONEPM> MBNAEHMDPIA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2108E60", Offset = "0x2107860", VA = "0x182108E60")]
	public static NLIHDEONEPM LODPGCNHAMK(float3 BEEGCHJLJFC)
	{
		return default(NLIHDEONEPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct MMNANONOIIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[MHODKKGKOHE(1)]
	public quaternion HDEHMDBACJH;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public static readonly JMPBNDCKNOF<MMNANONOIIO> MBNAEHMDPIA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
	public static MMNANONOIIO LODPGCNHAMK(quaternion BEEGCHJLJFC)
	{
		return default(MMNANONOIIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct KJOPBKCIEGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[MHODKKGKOHE(1)]
	public float3 JDDHGIKMDNE;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public static readonly JMPBNDCKNOF<KJOPBKCIEGL> MBNAEHMDPIA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2108E60", Offset = "0x2107860", VA = "0x182108E60")]
	public static KJOPBKCIEGL LODPGCNHAMK(float3 BEEGCHJLJFC)
	{
		return default(KJOPBKCIEGL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
[KEFMCNPKALD]
public struct JPLGFIOKCGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[MHODKKGKOHE(1)]
	public IFLEAPEACFJ FLHMGGNKGKC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct KHCKJJGKBKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct DOHFIJLMCNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public uint HPGMBJGOJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public int NPMFPMDDHMF;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA40560", Offset = "0xA3EF60", VA = "0x180A40560")]
	public DOHFIJLMCNO(uint HHFFPBHLMMB, int AHABHKLLPAN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct JCJOOCFPBIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct DHMOKIMCABP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct CPABHDEHABD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct HAMEOCLGDBD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct MOHKPCAODAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct FPJMFKJENBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct ILIDBPJJIDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct NIBDNICCDOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct BHBMBAOAIIB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct DGEEGEGAPJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal struct LHPOBABBEDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal struct BCODCCBALOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal struct IBHKPPLDKLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct JJNIDIEIFIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct GCCIJHENJGL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct ELOBBLPHNMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[MHODKKGKOHE(1)]
	public FixedList32Bytes<int> IMAGIKLFDJJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct EFIHLKLIPDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct DHIOGIPNCAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct DBPPEPNGMBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct GMGNJABPHJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal struct EKGAMABOMKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct KLJAKGPCGDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct HPEKDFEKHHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct LDEICNKKBJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[EBKFCBKAIMD]
public struct KHJJJICINID : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public FixedString32Bytes LJDFOGEIBJG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct PHDCODCLFLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
internal struct ABBHKKJCLNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct DCHDNIIALNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct PMADABNIPKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[LMGGMAHKKHI(1)]
	public FKDGFAOHHPN BKOLDLDNEOO;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public static readonly JMPBNDCKNOF<PMADABNIPKK> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public enum FKDGFAOHHPN : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct KBACPLKFPLJ : IComponentData, IComparable<KBACPLKFPLJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public int KGNNPGEKGOP;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x17645F0", Offset = "0x1762FF0", VA = "0x1817645F0", Slot = "4")]
	public int CompareTo(KBACPLKFPLJ CGDFJMJIABO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct FCIPDNJFGDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[MHODKKGKOHE(2)]
	public bool KKOCENECFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[MHODKKGKOHE(3)]
	public bool DEBFJMMFAGG;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public static readonly JMPBNDCKNOF<FCIPDNJFGDF> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[KEFMCNPKALD]
public struct CGAOMBEKHFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[MHODKKGKOHE(1)]
	public bool PLPNLGCAAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[MHODKKGKOHE(2)]
	public byte DKAKMNEMONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[MHODKKGKOHE(3)]
	public short HFPHEDIMBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[MHODKKGKOHE(4)]
	public ushort PMDDDBLIHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[MHODKKGKOHE(5)]
	public int DNBHKLGGPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[MHODKKGKOHE(6)]
	public uint GHNFONJBBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[MHODKKGKOHE(7)]
	public long IMPEPPKDPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[MHODKKGKOHE(8)]
	public ulong BFONDGKCPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[MHODKKGKOHE(9)]
	public float NELBNDMKIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[MHODKKGKOHE(10)]
	public double KNJOIKFDOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[MHODKKGKOHE(11)]
	public CALJKDKDBFG FKELEJDMMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[MHODKKGKOHE(12)]
	public DODDCDNABDP OJGFPEMJDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[MHODKKGKOHE(13)]
	public OJPLBAEKLCO BGOFOEOMFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[MHODKKGKOHE(14)]
	public OLKPCIJGAHE MJMKBEIOJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[MHODKKGKOHE(15)]
	public JILLCLAPNKI HDDHDJEPLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[MHODKKGKOHE(16)]
	public PKOGBEKPHGJ KMMFFPHGFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[MHODKKGKOHE(17)]
	public PNMFHAHHENJ MJKJLBODKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[MHODKKGKOHE(18)]
	public KNLOIOOCAOD HOHHJNKJKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[MHODKKGKOHE(20)]
	public Quaternion LDIMIGLPDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[MHODKKGKOHE(22)]
	public Vector3 KMPJALKOPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[MHODKKGKOHE(23)]
	public Vector4 OKFOIDJFDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[MHODKKGKOHE(40)]
	public Entity COOLBANKIOJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum CALJKDKDBFG : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum DODDCDNABDP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum OJPLBAEKLCO : short
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum OLKPCIJGAHE : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum JILLCLAPNKI
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public enum PKOGBEKPHGJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum PNMFHAHHENJ : long
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum KNLOIOOCAOD : ulong
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
	[KEFMCNPKALD]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[KEFMCNPKALD]
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
public class JPJNKJBMMOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public int HANEBMPJCCB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public int MDFCJMKEMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public GameObject PKKHAEKNIBL;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JPJNKJBMMOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public class BLJLGDPDJOJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public struct PCPNOIEGBOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Vector3 EPOPJNFAGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<SerializableGuid> ABIHPHJOAPF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class LNFOGHJHEHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public PCPNOIEGBOI OANOCLHLEIH;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public LNFOGHJHEHM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public SerializableGuid LECOOPOCECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public List<int> NIGKPPOFJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public List<PCPNOIEGBOI> BFLKJPEDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public List<LNFOGHJHEHM> IFFHGFJOENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public GameObject PKKHAEKNIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Light KLIGHAHGAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Collider BLBJIPJCMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public string FGLFEJFCPMN;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public BLJLGDPDJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[KEFMCNPKALD]
public struct GIDCLBJNNIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[MHODKKGKOHE(1)]
	public float3 CAFILJPJEPG;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly JMPBNDCKNOF<GIDCLBJNNIG> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct BKJNMENNDGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[MHODKKGKOHE(1)]
	public quaternion HDEHMDBACJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[MHODKKGKOHE(2)]
	public float3 LAKIBICOBFE;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly JMPBNDCKNOF<BKJNMENNDGN> MBNAEHMDPIA;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4BE0", Offset = "0x3BB35E0", VA = "0x183BB4BE0")]
	public BKJNMENNDGN(quaternion HDEHMDBACJH, float3 LAKIBICOBFE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6091EE0", Offset = "0x60908E0", VA = "0x186091EE0")]
	public static RigidTransform LODPGCNHAMK(BKJNMENNDGN GDFHNEJCGJM)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6091EE0", Offset = "0x60908E0", VA = "0x186091EE0")]
	public static BKJNMENNDGN LODPGCNHAMK(RigidTransform BBLLGBDKAGE)
	{
		return default(BKJNMENNDGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public static class GJMFJDJPAHK
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct HDAIJNOGAHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float4x4 FMGLBFCKJKF;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public static readonly JMPBNDCKNOF<HDAIJNOGAHK> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public struct KGNDEGGEFGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float4x4 AFBMHLIKDAM;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly JMPBNDCKNOF<KGNDEGGEFGB> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct LDIJCFIMKMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[MHODKKGKOHE(1)]
	public float HKAHBEBLFID;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public static readonly JMPBNDCKNOF<LDIJCFIMKMH> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct ILOMMBBHCLB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int OAGGAPPBJNC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BNALCEABILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6097CB0", Offset = "0x60966B0", VA = "0x186097CB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6097CA0", Offset = "0x60966A0", VA = "0x186097CA0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[KEFMCNPKALD]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct FEPBFKNLLNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	[MHODKKGKOHE(1)]
	public JEHKBFGJFJK JHABCDPIINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[MHODKKGKOHE(2)]
	public HOGJGOKOMGJ KKENHINAKIA;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[LAOCFNICPGL(0, 1)]
[Flags]
public enum JEHKBFGJFJK
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
[LAOCFNICPGL(-2, 2)]
public enum HOGJGOKOMGJ
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
public struct PIDCNBHDIPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public float3 GCOOIJGAKFC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly JMPBNDCKNOF<PIDCNBHDIPD> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public struct DJMPDEKFHBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public float3 CJONGNPPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public quaternion KPKKBKKOGOG;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static readonly JMPBNDCKNOF<DJMPDEKFHBD> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class FGMPADIFAKC
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct MDKFLFGIGJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public float FCNFEHAMILA;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly JMPBNDCKNOF<MDKFLFGIGJP> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[LAOCFNICPGL(1000, 8000)]
public enum BPNENPIPGEM
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
public static class MABMKEBLDMG
{
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal enum DKKNMAOAIGD
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
internal static class HKKFPMLEGKH
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[LAOCFNICPGL(0, 9)]
public enum DPMAOMPONMF
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
public static class NLKNNAIGCLO
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6098F00", Offset = "0x6097900", VA = "0x186098F00")]
	public static bool OPGIJNGOMDI(this DPMAOMPONMF MIBCNPGIFKE)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[KEFMCNPKALD]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public BPNENPIPGEM prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class OOLBAOCHMEB
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x60995B0", Offset = "0x6097FB0", VA = "0x1860995B0")]
	public static DPMAOMPONMF KLIKABBJLCO(this BPNENPIPGEM NEHEFLNJNAI)
	{
		return default(DPMAOMPONMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[LAOCFNICPGL(int.MinValue, int.MaxValue)]
public enum NKOCAHGNOAH
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
[LAOCFNICPGL(-1, 31)]
public enum JABAHFHGDHA
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
[KEFMCNPKALD]
[INAHGLFHGGO("Visual", 0)]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
public struct CDCDNLPGLKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[MHODKKGKOHE(1)]
	[HMBPLLNFAIN(0)]
	public NKOCAHGNOAH GJNHDHNOICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(2)]
	public JABAHFHGDHA HEPAJJIBPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(3)]
	public float CEBLOHPIDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(4)]
	public Vector3 CFELEAFMDHH;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[AAKDKDEGEDI(2613756846563002039uL, 6372660366488563574uL)]
[INAHGLFHGGO("Container", 0)]
[HOGNNOAPMKF]
public struct DKPJMHEAEKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[MHODKKGKOHE(1)]
	[HMBPLLNFAIN(0)]
	public MFFELHCAOFC BJKAMOIEGFM;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[Flags]
[LAOCFNICPGL(0, 15)]
public enum MFFELHCAOFC
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
[HOGNNOAPMKF]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[AAKDKDEGEDI(9804513251708000208uL, 10903582988135044631uL)]
public struct JMGOHAGNBBM : IComponentData, IEquatable<JMGOHAGNBBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[MHODKKGKOHE(1)]
	public FixedString64Bytes CDHDOGOGPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[MHODKKGKOHE(2)]
	public HHIDNHLGHBP POFOAAKGEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[MHODKKGKOHE(3)]
	public MFFELHCAOFC BJKAMOIEGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[MHODKKGKOHE(4)]
	public INFCHKFHJDC GHFEDJGEOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[MHODKKGKOHE(5)]
	public LFHMKKMAAEK KPJDDJOANKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[MHODKKGKOHE(6)]
	public float ILAFIEOKEON;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6098050", Offset = "0x6096A50", VA = "0x186098050", Slot = "4")]
	public bool Equals(JMGOHAGNBBM CGDFJMJIABO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[AAKDKDEGEDI(1213445203937950283uL, 119653618660684511uL)]
[HOGNNOAPMKF]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct AOKIMLDCIFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[MHODKKGKOHE(1)]
	public FIDMIAMDCGL OEDHDPMLKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public GCHandle BDFKMGIHPBP;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[JANKINADJFI(1)]
public struct FIDMIAMDCGL : CCAIAFIJCPA, IEquatable<FIDMIAMDCGL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[LMGGMAHKKHI(1)]
	public int KABOEEEDCAB;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6093B00", Offset = "0x6092500", VA = "0x186093B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6093A80", Offset = "0x6092480", VA = "0x186093A80", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8135B0", Offset = "0x811FB0", VA = "0x1808135B0", Slot = "6")]
	public bool Equals(FIDMIAMDCGL CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1764680", Offset = "0x1763080", VA = "0x181764680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6093A60", Offset = "0x6092460", VA = "0x186093A60", Slot = "5")]
	public void DCJJDHFPDEL(HIJMOAHPPLN HPEAJCENMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6093B60", Offset = "0x6092560", VA = "0x186093B60", Slot = "4")]
	public void JLKDILEIJOC(EGNBIPNLKLC HAMBOEKDHKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[AAKDKDEGEDI(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[HOGNNOAPMKF]
public struct FMHDMPELJFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	private uint GGNGBFDNCLE;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[HOGNNOAPMKF]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[AAKDKDEGEDI(9898405628982320166uL, 2023375009558162791uL)]
public struct NLJHBMPENGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[MHODKKGKOHE(1)]
	public KCPFFIABALL KPJDDJOANKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[MHODKKGKOHE(2)]
	public DNJMDNMJIFB OJJFHIHKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[MHODKKGKOHE(3)]
	[HMBPLLNFAIN(0)]
	public bool BBLHACAHACH;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly JMPBNDCKNOF<NLJHBMPENGH> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[HOGNNOAPMKF]
[AAKDKDEGEDI(9807788745867066359uL, 15168486114979071194uL)]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct FNNEMLHIMLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[MHODKKGKOHE(1)]
	public KCPFFIABALL KPJDDJOANKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[MHODKKGKOHE(2)]
	public DNJMDNMJIFB OJJFHIHKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[MHODKKGKOHE(3)]
	[HMBPLLNFAIN(0)]
	public bool BBLHACAHACH;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly JMPBNDCKNOF<FNNEMLHIMLJ> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[AAKDKDEGEDI(4470189027631723570uL, 5922380073816386711uL)]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[HOGNNOAPMKF]
public struct LBHAEJPFELD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[LMGGMAHKKHI(1)]
	public KCPFFIABALL KPJDDJOANKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[MHODKKGKOHE(2)]
	public DNJMDNMJIFB OJJFHIHKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[HMBPLLNFAIN(0)]
	[MHODKKGKOHE(3)]
	public ILNGCJCMJLG CKACMJMNDLB;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly JMPBNDCKNOF<LBHAEJPFELD> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[AAKDKDEGEDI(12226092714547765037uL, 15970362445488810630uL)]
[HOGNNOAPMKF]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct DCGFGLEBLJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	[MHODKKGKOHE(2)]
	public DNJMDNMJIFB OJJFHIHKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[MHODKKGKOHE(3)]
	[HMBPLLNFAIN(0)]
	public ILNGCJCMJLG CKACMJMNDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[LMGGMAHKKHI(4)]
	public KCPFFIABALL KPJDDJOANKE;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly JMPBNDCKNOF<DCGFGLEBLJJ> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[HOGNNOAPMKF]
[AAKDKDEGEDI(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct PPNGJJLNEMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public int MCNLAHAKFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	[MHODKKGKOHE(2)]
	public bool KKOCENECFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	[MHODKKGKOHE(3)]
	public bool DEBFJMMFAGG;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	public static readonly JMPBNDCKNOF<PPNGJJLNEMF> MBNAEHMDPIA;
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[AAKDKDEGEDI(5861057081882613294uL, 13746475565109640919uL)]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[HOGNNOAPMKF]
public struct POFLFGNAIHG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[LAOCFNICPGL(0, 1)]
	public enum DKJGFELLIAC
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
	[MHODKKGKOHE(1)]
	public DKJGFELLIAC NOGJIIIAAPA;
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[AAKDKDEGEDI(14327281633525910712uL, 2559857777606771911uL)]
[HOGNNOAPMKF]
public struct EICBDHCGJKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	[MHODKKGKOHE(1)]
	public BPNENPIPGEM NEHEFLNJNAI;
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
[HOGNNOAPMKF]
[AAKDKDEGEDI(15725208981563603541uL, 17017036095303668770uL)]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct FOHJNKLEKBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	[MHODKKGKOHE(1)]
	public BPNENPIPGEM NEHEFLNJNAI;
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[HOGNNOAPMKF]
[AAKDKDEGEDI(1029043735688538310uL, 14256247939851101839uL)]
public struct BGJLAPLOCBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public DPMAOMPONMF MIBCNPGIFKE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[AAKDKDEGEDI(17667479821163689808uL, 11946378475791123970uL)]
[HOGNNOAPMKF]
public struct BIPENIJBAOE : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : ELEICGBPLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x609A960", Offset = "0x6099360", VA = "0x18609A960", Slot = "4")]
		public sealed override void JAADIKPNOBC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class EKBPPJGOBLP : ContainerPropertyBag<BFGBICMPDKD>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class JPMBKBEKLCJ : Property<BFGBICMPDKD, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6098170", Offset = "0x6096B70", VA = "0x186098170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6098130", Offset = "0x6096B30", VA = "0x186098130")]
		public JPMBKBEKLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6091FC0", Offset = "0x60909C0", VA = "0x186091FC0", Slot = "14")]
		public override Rigidbody GetValue(BFGBICMPDKD DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6091FE0", Offset = "0x60909E0", VA = "0x186091FE0", Slot = "15")]
		public override void SetValue(BFGBICMPDKD DFLLKHNKNDA, Rigidbody BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6093830", Offset = "0x6092230", VA = "0x186093830")]
	public EKBPPJGOBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal class PCMNKNJJAPK : ContainerPropertyBag<GFOOIBOFDIB>
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class EMPMCIMKIIB : Property<GFOOIBOFDIB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6093950", Offset = "0x6092350", VA = "0x186093950", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6093910", Offset = "0x6092310", VA = "0x186093910")]
		public EMPMCIMKIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6091FC0", Offset = "0x60909C0", VA = "0x186091FC0", Slot = "14")]
		public override object GetValue(GFOOIBOFDIB DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6091FE0", Offset = "0x60909E0", VA = "0x186091FE0", Slot = "15")]
		public override void SetValue(GFOOIBOFDIB DFLLKHNKNDA, object BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x60995D0", Offset = "0x6097FD0", VA = "0x1860995D0")]
	public PCMNKNJJAPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
internal class ODKGOGKPEAC : ContainerPropertyBag<CGIGMKJHMBC>
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class BLKEKNBGBEF : Property<CGIGMKJHMBC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6092050", Offset = "0x6090A50", VA = "0x186092050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6092010", Offset = "0x6090A10", VA = "0x186092010")]
		public BLKEKNBGBEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6091FC0", Offset = "0x60909C0", VA = "0x186091FC0", Slot = "14")]
		public override object GetValue(CGIGMKJHMBC DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6091FE0", Offset = "0x60909E0", VA = "0x186091FE0", Slot = "15")]
		public override void SetValue(CGIGMKJHMBC DFLLKHNKNDA, object BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6098FF0", Offset = "0x60979F0", VA = "0x186098FF0")]
	public ODKGOGKPEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class FJEMFJEELMN : ContainerPropertyBag<HCJPFGILNPA>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class MIGPAIGALKD : Property<HCJPFGILNPA, JMMLFPJJFBD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x60989F0", Offset = "0x60973F0", VA = "0x1860989F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60989B0", Offset = "0x60973B0", VA = "0x1860989B0")]
		public MIGPAIGALKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6091FC0", Offset = "0x60909C0", VA = "0x186091FC0", Slot = "14")]
		public override JMMLFPJJFBD GetValue(HCJPFGILNPA DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6091FE0", Offset = "0x60909E0", VA = "0x186091FE0", Slot = "15")]
		public override void SetValue(HCJPFGILNPA DFLLKHNKNDA, JMMLFPJJFBD BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6093B70", Offset = "0x6092570", VA = "0x186093B70")]
	public FJEMFJEELMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal class ANEGELPJMPA : ContainerPropertyBag<JPJNKJBMMOA>
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class NGBHANCOMNK : Property<JPJNKJBMMOA, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6098C80", Offset = "0x6097680", VA = "0x186098C80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6098C40", Offset = "0x6097640", VA = "0x186098C40")]
		public NGBHANCOMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6098C00", Offset = "0x6097600", VA = "0x186098C00", Slot = "14")]
		public override int GetValue(JPJNKJBMMOA DFLLKHNKNDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6098C20", Offset = "0x6097620", VA = "0x186098C20", Slot = "15")]
		public override void SetValue(JPJNKJBMMOA DFLLKHNKNDA, int BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class AENBGHENLBL : Property<JPJNKJBMMOA, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6091980", Offset = "0x6090380", VA = "0x186091980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6091940", Offset = "0x6090340", VA = "0x186091940")]
		public AENBGHENLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6091900", Offset = "0x6090300", VA = "0x186091900", Slot = "14")]
		public override int GetValue(JPJNKJBMMOA DFLLKHNKNDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6091920", Offset = "0x6090320", VA = "0x186091920", Slot = "15")]
		public override void SetValue(JPJNKJBMMOA DFLLKHNKNDA, int BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class CNKHEJEJBAN : Property<JPJNKJBMMOA, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x60924A0", Offset = "0x6090EA0", VA = "0x1860924A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6092460", Offset = "0x6090E60", VA = "0x186092460")]
		public CNKHEJEJBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6092410", Offset = "0x6090E10", VA = "0x186092410", Slot = "14")]
		public override GameObject GetValue(JPJNKJBMMOA DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6092430", Offset = "0x6090E30", VA = "0x186092430", Slot = "15")]
		public override void SetValue(JPJNKJBMMOA DFLLKHNKNDA, GameObject BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6091A80", Offset = "0x6090480", VA = "0x186091A80")]
	public ANEGELPJMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class EDBDGBIOJGK : ContainerPropertyBag<BLJLGDPDJOJ>
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class COCBAIOOCHH : Property<BLJLGDPDJOJ, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6092560", Offset = "0x6090F60", VA = "0x186092560", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6092520", Offset = "0x6090F20", VA = "0x186092520")]
		public COCBAIOOCHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60924D0", Offset = "0x6090ED0", VA = "0x1860924D0", Slot = "14")]
		public override SerializableGuid GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6092500", Offset = "0x6090F00", VA = "0x186092500", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, SerializableGuid BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class DFCFIDEPONK : Property<BLJLGDPDJOJ, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x60928F0", Offset = "0x60912F0", VA = "0x1860928F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60928B0", Offset = "0x60912B0", VA = "0x1860928B0")]
		public DFCFIDEPONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6092860", Offset = "0x6091260", VA = "0x186092860", Slot = "14")]
		public override List<int> GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6092880", Offset = "0x6091280", VA = "0x186092880", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, List<int> BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class COFKHIIPKKD : Property<BLJLGDPDJOJ, List<BLJLGDPDJOJ.PCPNOIEGBOI>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6092620", Offset = "0x6091020", VA = "0x186092620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60925E0", Offset = "0x6090FE0", VA = "0x1860925E0")]
		public COFKHIIPKKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6092590", Offset = "0x6090F90", VA = "0x186092590", Slot = "14")]
		public override List<BLJLGDPDJOJ.PCPNOIEGBOI> GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60925B0", Offset = "0x6090FB0", VA = "0x1860925B0", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, List<BLJLGDPDJOJ.PCPNOIEGBOI> BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class EEHLGPFBDFP : Property<BLJLGDPDJOJ, List<BLJLGDPDJOJ.LNFOGHJHEHM>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6093800", Offset = "0x6092200", VA = "0x186093800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60937C0", Offset = "0x60921C0", VA = "0x1860937C0")]
		public EEHLGPFBDFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6093770", Offset = "0x6092170", VA = "0x186093770", Slot = "14")]
		public override List<BLJLGDPDJOJ.LNFOGHJHEHM> GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6093790", Offset = "0x6092190", VA = "0x186093790", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, List<BLJLGDPDJOJ.LNFOGHJHEHM> BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class HKONKBCEJCK : Property<BLJLGDPDJOJ, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x60978E0", Offset = "0x60962E0", VA = "0x1860978E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60978A0", Offset = "0x60962A0", VA = "0x1860978A0")]
		public HKONKBCEJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6097850", Offset = "0x6096250", VA = "0x186097850", Slot = "14")]
		public override GameObject GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6097870", Offset = "0x6096270", VA = "0x186097870", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, GameObject BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private class KAIBKPNMDED : Property<BLJLGDPDJOJ, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6098230", Offset = "0x6096C30", VA = "0x186098230", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60981F0", Offset = "0x6096BF0", VA = "0x1860981F0")]
		public KAIBKPNMDED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60981A0", Offset = "0x6096BA0", VA = "0x1860981A0", Slot = "14")]
		public override Light GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60981C0", Offset = "0x6096BC0", VA = "0x1860981C0", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, Light BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class BFEMBCBNLKC : Property<BLJLGDPDJOJ, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6091E40", Offset = "0x6090840", VA = "0x186091E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6091E00", Offset = "0x6090800", VA = "0x186091E00")]
		public BFEMBCBNLKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6091DB0", Offset = "0x60907B0", VA = "0x186091DB0", Slot = "14")]
		public override Collider GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6091DD0", Offset = "0x60907D0", VA = "0x186091DD0", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, Collider BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	private class JDIKNJONIAP : Property<BLJLGDPDJOJ, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6097D50", Offset = "0x6096750", VA = "0x186097D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6097D10", Offset = "0x6096710", VA = "0x186097D10")]
		public JDIKNJONIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6097CC0", Offset = "0x60966C0", VA = "0x186097CC0", Slot = "14")]
		public override string GetValue(BLJLGDPDJOJ DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6097CE0", Offset = "0x60966E0", VA = "0x186097CE0", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ DFLLKHNKNDA, string BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6092E80", Offset = "0x6091880", VA = "0x186092E80")]
	public EDBDGBIOJGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal class CCDNDHCKBDD : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class DBIGIKDFDNM : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6092750", Offset = "0x6091150", VA = "0x186092750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6092660", Offset = "0x6091060", VA = "0x186092660")]
		public DBIGIKDFDNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "14")]
		public override Data128 GetValue(SerializableGuid DFLLKHNKNDA)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6092650", Offset = "0x6091050", VA = "0x186092650", Slot = "15")]
		public override void SetValue(SerializableGuid DFLLKHNKNDA, Data128 BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60921C0", Offset = "0x6090BC0", VA = "0x1860921C0")]
	public CCDNDHCKBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class ODOPBKOBDDE : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class DFHOLPKJDIB : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6092A20", Offset = "0x6091420", VA = "0x186092A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6092930", Offset = "0x6091330", VA = "0x186092930")]
		public DFHOLPKJDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1316650", Offset = "0x1315050", VA = "0x181316650", Slot = "14")]
		public override int GetValue(Data128 DFLLKHNKNDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6092920", Offset = "0x6091320", VA = "0x186092920", Slot = "15")]
		public override void SetValue(Data128 DFLLKHNKNDA, int BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	private class BNEEJBMFNBG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6092190", Offset = "0x6090B90", VA = "0x186092190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x60920A0", Offset = "0x6090AA0", VA = "0x1860920A0")]
		public BNEEJBMFNBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6092080", Offset = "0x6090A80", VA = "0x186092080", Slot = "14")]
		public override int GetValue(Data128 DFLLKHNKNDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6092090", Offset = "0x6090A90", VA = "0x186092090", Slot = "15")]
		public override void SetValue(Data128 DFLLKHNKNDA, int BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	private class HACCCGKLEPD : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x6097520", Offset = "0x6095F20", VA = "0x186097520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6097430", Offset = "0x6095E30", VA = "0x186097430")]
		public HACCCGKLEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x15DFE40", Offset = "0x15DE840", VA = "0x1815DFE40", Slot = "14")]
		public override int GetValue(Data128 DFLLKHNKNDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6097420", Offset = "0x6095E20", VA = "0x186097420", Slot = "15")]
		public override void SetValue(Data128 DFLLKHNKNDA, int BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class GIHILCAFNKJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6097360", Offset = "0x6095D60", VA = "0x186097360", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6097270", Offset = "0x6095C70", VA = "0x186097270")]
		public GIHILCAFNKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6097250", Offset = "0x6095C50", VA = "0x186097250", Slot = "14")]
		public override int GetValue(Data128 DFLLKHNKNDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6097260", Offset = "0x6095C60", VA = "0x186097260", Slot = "15")]
		public override void SetValue(Data128 DFLLKHNKNDA, int BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60990D0", Offset = "0x6097AD0", VA = "0x1860990D0")]
	public ODOPBKOBDDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class NBPOMFLDNLE : ContainerPropertyBag<BLJLGDPDJOJ.PCPNOIEGBOI>
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class BDGOGONKJBP : Property<BLJLGDPDJOJ.PCPNOIEGBOI, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x6091D80", Offset = "0x6090780", VA = "0x186091D80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6091D40", Offset = "0x6090740", VA = "0x186091D40")]
		public BDGOGONKJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x923030", Offset = "0x921A30", VA = "0x180923030", Slot = "14")]
		public override Vector3 GetValue(BLJLGDPDJOJ.PCPNOIEGBOI DFLLKHNKNDA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6091D20", Offset = "0x6090720", VA = "0x186091D20", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ.PCPNOIEGBOI DFLLKHNKNDA, Vector3 BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	private class ABIJOBCMJOH : Property<BLJLGDPDJOJ.PCPNOIEGBOI, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6091820", Offset = "0x6090220", VA = "0x186091820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x60917E0", Offset = "0x60901E0", VA = "0x1860917E0")]
		public ABIJOBCMJOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x60917C0", Offset = "0x60901C0", VA = "0x1860917C0", Slot = "14")]
		public override List<SerializableGuid> GetValue(BLJLGDPDJOJ.PCPNOIEGBOI DFLLKHNKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x60917D0", Offset = "0x60901D0", VA = "0x1860917D0", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ.PCPNOIEGBOI DFLLKHNKNDA, List<SerializableGuid> BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6098AA0", Offset = "0x60974A0", VA = "0x186098AA0")]
	public NBPOMFLDNLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal class PDHFHIHECKO : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	private class GJGBKJBKJNC : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x60973F0", Offset = "0x6095DF0", VA = "0x1860973F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x60973B0", Offset = "0x6095DB0", VA = "0x1860973B0")]
		public GJGBKJBKJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6097390", Offset = "0x6095D90", VA = "0x186097390", Slot = "14")]
		public override float GetValue(Vector3 DFLLKHNKNDA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x60973A0", Offset = "0x6095DA0", VA = "0x1860973A0", Slot = "15")]
		public override void SetValue(Vector3 DFLLKHNKNDA, float BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class JHPEBBOEOKC : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6098020", Offset = "0x6096A20", VA = "0x186098020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6097FE0", Offset = "0x60969E0", VA = "0x186097FE0")]
		public JHPEBBOEOKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6097FC0", Offset = "0x60969C0", VA = "0x186097FC0", Slot = "14")]
		public override float GetValue(Vector3 DFLLKHNKNDA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6097FD0", Offset = "0x60969D0", VA = "0x186097FD0", Slot = "15")]
		public override void SetValue(Vector3 DFLLKHNKNDA, float BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000120")]
	private class AHPLEBIKJCH : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x6091A00", Offset = "0x6090400", VA = "0x186091A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60919C0", Offset = "0x60903C0", VA = "0x1860919C0")]
		public AHPLEBIKJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x19D7380", Offset = "0x19D5D80", VA = "0x1819D7380", Slot = "14")]
		public override float GetValue(Vector3 DFLLKHNKNDA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60919B0", Offset = "0x60903B0", VA = "0x1860919B0", Slot = "15")]
		public override void SetValue(Vector3 DFLLKHNKNDA, float BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60996B0", Offset = "0x60980B0", VA = "0x1860996B0")]
	public PDHFHIHECKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal class IBKOENDPHDB : ContainerPropertyBag<BLJLGDPDJOJ.LNFOGHJHEHM>
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	private class BCEBHOEEKKC : Property<BLJLGDPDJOJ.LNFOGHJHEHM, BLJLGDPDJOJ.PCPNOIEGBOI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x6091CF0", Offset = "0x60906F0", VA = "0x186091CF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6091CB0", Offset = "0x60906B0", VA = "0x186091CB0")]
		public BCEBHOEEKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6091C40", Offset = "0x6090640", VA = "0x186091C40", Slot = "14")]
		public override BLJLGDPDJOJ.PCPNOIEGBOI GetValue(BLJLGDPDJOJ.LNFOGHJHEHM DFLLKHNKNDA)
		{
			return default(BLJLGDPDJOJ.PCPNOIEGBOI);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6091C70", Offset = "0x6090670", VA = "0x186091C70", Slot = "15")]
		public override void SetValue(BLJLGDPDJOJ.LNFOGHJHEHM DFLLKHNKNDA, BLJLGDPDJOJ.PCPNOIEGBOI BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6097A80", Offset = "0x6096480", VA = "0x186097A80")]
	public IBKOENDPHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
internal class MCOINMEDLED : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	private class LJFBIGCLCHO : Property<RRObjectPrefabV2Data, BPNENPIPGEM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string JHMJHFOLNND
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x60987C0", Offset = "0x60971C0", VA = "0x1860987C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool KNBLDDIDMLI
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6098780", Offset = "0x6097180", VA = "0x186098780")]
		public LJFBIGCLCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1316650", Offset = "0x1315050", VA = "0x181316650", Slot = "14")]
		public override BPNENPIPGEM GetValue(RRObjectPrefabV2Data DFLLKHNKNDA)
		{
			return default(BPNENPIPGEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6092920", Offset = "0x6091320", VA = "0x186092920", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data DFLLKHNKNDA, BPNENPIPGEM BEEGCHJLJFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6098870", Offset = "0x6097270", VA = "0x186098870")]
	public MCOINMEDLED()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6099A90", Offset = "0x6098490", VA = "0x186099A90")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000126")]
public class PMMLLLCENIK
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PMMLLLCENIK()
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

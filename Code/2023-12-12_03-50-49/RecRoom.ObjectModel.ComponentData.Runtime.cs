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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FLLNLNFFCJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode OPHJLIHPEPH;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IFAPDJCAOAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PFMKCMICBGB HIPFFMLMPFH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly OMBEAALPPEP<IFAPDJCAOAO> FCIJPOCPFGE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NPACIMGDNPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DOGFJKMCNOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PFMKCMICBGB
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
public struct LCHNCLFIBDF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct HHGDEHMLAIN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity EAAFIBGEEGL;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BEKGCGNNFNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity DEINPDMGBDC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AFFJLALJCJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MPJIDKKNJIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity PHEKGOFMNOB;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OADBNMJKMAI : OABGDCCOBIJ, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OFKCFJLEMKK JIMMKGIMCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(OFKCFJLEMKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct AOKBLBFBMMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 CCHPLFLDCPF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GHHHLGJNFJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MIMGFIFBEFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 DLLPAIDEDPP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly OMBEAALPPEP<BPCDFICLELG> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BPCDFICLELG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 DLLPAIDEDPP;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly OMBEAALPPEP<BPCDFICLELG> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OCCKIPOOPPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 CFNEEFOGBGP;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct PKLPLFOLGNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 DKMBNNDPPKD;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HBBMJOKOPLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float JDMCFOCNDJO;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly OMBEAALPPEP<HBBMJOKOPLI> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KFGEFMIJGKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float BBMGMEMIHFO;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OMBEAALPPEP<KFGEFMIJGKM> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GKCBBLCKNDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 KLKINIFJLNC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ENLHHHAIOOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public GGAPDDJFBMN GABMNKCDOJF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JKFMFPLKFEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public GGAPDDJFBMN LCFDPKDPFEM;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[KHMGNMMLFME]
public struct AJEBBBHHMEP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity EIJPPJGEAJM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KKABADKHKGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HLMDPMFKMBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FJDILPNEMKI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct AFCHLDFEKLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints AFFGAPEFNCA;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PJPKLCKHPJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float KCPEJLPPPHJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly OMBEAALPPEP<PJPKLCKHPJN> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CMDHMPABCFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float DGIEADHACBB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LOPOAMBJPHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NNFHBKLHGAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int PAGLOHHJKLN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static NNFHBKLHGAH DBFFIFAHFFL(int DOLICEBFIPF)
	{
		return default(NNFHBKLHGAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KIEMMHBAPOJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody EKEIFPIAPLM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9B50", Offset = "0x5EC8350", VA = "0x185EC9B50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KIEMMHBAPOJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HAHJFMGPGKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IAECNPFIPEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 FGDMIAMGAFN;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AHBFLNCKDHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 GNMILCCIALP;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KDBODDLFPKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float CGIIPEMHFIN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OMBEAALPPEP<KDBODDLFPKB> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JNOOLCMLGCC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object BAFEGDIFEBI;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC92D0", Offset = "0x5EC7AD0", VA = "0x185EC92D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JNOOLCMLGCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class INFCPOGJHFA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object KHKJCCOBOCA;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8990", Offset = "0x5EC7190", VA = "0x185EC8990", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public INFCPOGJHFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum GGAPDDJFBMN
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum BPHGBOIEMNK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BKONHFHHNPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIGMOAFANAD(PFMKCMICBGB PHOGCBLPLDJ, PFMKCMICBGB EPMBKIEBGGH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLLMKNBNJPB();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BINLDMHLKMF();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFPAJDBOAJK(bool EGEEOFOOENC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OCDFBPGODKE();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLLDJKAJBLM();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NJKBOAGICID : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public BKONHFHHNPH MCDIEBIFEIC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD610", Offset = "0x5ECBE10", VA = "0x185ECD610", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public NJKBOAGICID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LMMPJLCMDKH
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(PGCEKIOAHGF nameHash, MHMPMCNAPHK stableTypeHash, Type type)> FHEHFFCNFKL;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(PGCEKIOAHGF nameHash, MHMPMCNAPHK stableTypeHash, Type type)> NFFILBMDPHF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(PGCEKIOAHGF previousNameHash, MHMPMCNAPHK previousStableTypeHash, Type currentTypeName)> NEKMOKLNAMM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct PAFEAFOBAFF : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, JPHOKBHOMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6C20", Offset = "0x5EC5420", VA = "0x185EC6C20", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct BPIFPMGOJDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ELNCCGELHMI(1)]
	public quaternion AOABADNNGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ELNCCGELHMI(2)]
	public float3 ENHKIKKDBOC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly OMBEAALPPEP<BPIFPMGOJDE> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x39CE1A0", Offset = "0x39CC9A0", VA = "0x1839CE1A0")]
	public BPIFPMGOJDE(quaternion AOABADNNGMN, float3 ENHKIKKDBOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6FC0", Offset = "0x5EC57C0", VA = "0x185EC6FC0")]
	public static BPIFPMGOJDE DBFFIFAHFFL(RigidTransform EHPMOHOPBBK)
	{
		return default(BPIFPMGOJDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GLKHKFBLJJH
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct HCEEIGKOKJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ELNCCGELHMI(1)]
	public float PCHJELNHBAN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly OMBEAALPPEP<HCEEIGKOKJG> FCIJPOCPFGE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[OAEODNDKOKK]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, JPHOKBHOMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ELNCCGELHMI(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6C30", Offset = "0x5EC5430", VA = "0x185EC6C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct EAJFCBCJGJG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, JPHOKBHOMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KBNPPDDNECA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct ACCJEOOPKOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ELNCCGELHMI(1)]
	public SerializableGuid IEJCDLJALPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ELNCCGELHMI(2)]
	public SerializableGuid BDNPJKGJPHN;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct LLAKJEPFPJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity GNCFOMAOFPL;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct FOHJJCMMEKE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity GNCFOMAOFPL;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[AOHGLJIDCDK("Container", 0)]
public struct LLLLBMBEANF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(1)]
	public EHHNKCGNLDK CMIEPKAPOJP;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OMBEAALPPEP<LLLLBMBEANF> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[IOCPGOHMEEP(0, 127)]
public enum EHHNKCGNLDK
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
public static class EDNNOLKDCLB
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum IFFOCELGBFG
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
	public enum JDOELNCBAKN
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
	[Cpp2IlInjected.Address(RVA = "0x5EC7710", Offset = "0x5EC5F10", VA = "0x185EC7710")]
	public static (IFFOCELGBFG, JDOELNCBAKN) GOFJHNFFLNG(this EHHNKCGNLDK LPAJNKEBPGN)
	{
		return default((IFFOCELGBFG, JDOELNCBAKN));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[AOHGLJIDCDK("Container", 0)]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[OAEODNDKOKK]
public struct KFIKFFMAHPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ELNCCGELHMI(1)]
	[NHKJGEIIFPH(0)]
	public KEOFIHPFFDL DMJCNNACDLD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly OMBEAALPPEP<KFIKFFMAHPC> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[IOCPGOHMEEP(0, 2)]
public enum KEOFIHPFFDL
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
[AOHGLJIDCDK("Container", 0)]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct PJLOKAAGMKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(1)]
	public NJCCEBHKLID DKHKGJCPEFO;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
[IOCPGOHMEEP(0, 15943)]
public enum NJCCEBHKLID
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
public struct DJFEMJDCLEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct IPNNNPENFBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct LMLFHKHKNHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct ENMDLDFDEHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct HALOGNGOBJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct DLMGGIHDFEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct NHBEKJNIGKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct BCCPOPLCPHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct BLADGGDJNMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[AOHGLJIDCDK("Container", 0)]
[OAEODNDKOKK]
public struct CJCABKDJLGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[ELNCCGELHMI(1)]
	[NHKJGEIIFPH(0)]
	public float DKBLLJFFMEK;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[OAEODNDKOKK]
[AOHGLJIDCDK("Container", 0)]
public struct KEGANPJALBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[ELNCCGELHMI(1)]
	[NHKJGEIIFPH(0)]
	public FixedString64Bytes PMDCAPIFBIP;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PCLEHDDGJMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<CMJIEDNOGGE> GHHEFBMOBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<Entity> DNJIJPGICDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JobHandle JPBBNPJNGBC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CCNAENOMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDE50", Offset = "0x5ECC650", VA = "0x185ECDE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDEC0", Offset = "0x5ECC6C0", VA = "0x185ECDEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43E7AF0", Offset = "0x43E62F0", VA = "0x1843E7AF0")]
	public PCLEHDDGJMO(NativeList<CMJIEDNOGGE> GHHEFBMOBID, NativeList<Entity> DNJIJPGICDB, JobHandle JPBBNPJNGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD30", Offset = "0x5ECC530", VA = "0x185ECDD30")]
	public (Entity, NativeSlice<Entity>) GNJHIOOAOKF(int BOCONGADANC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDCD0", Offset = "0x5ECC4D0", VA = "0x185ECDCD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct CMJIEDNOGGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity PHEKGOFMNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int IJJNAEFKMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int BONCBNKGOGN;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface ILDFPLGPFLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADNNLLICBJI(bool EKNKDBJHIOC);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[AOHGLJIDCDK("Container", 0)]
[OAEODNDKOKK]
public struct BCIKCCBOGEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(1)]
	public PICOLMPIMHA AFKBEHFOBOM;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[IOCPGOHMEEP(0, 1)]
public enum PICOLMPIMHA
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
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
[AOHGLJIDCDK("Container", 0)]
public struct IIOCCEIDHPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(1)]
	public NJOFGMOPKCA OHCNCEPLFHK;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly OMBEAALPPEP<IIOCCEIDHPB> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[IOCPGOHMEEP(0, 2)]
public enum NJOFGMOPKCA
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
[JGEHNKHNILJ(1)]
public struct JKFHLDMIFKL : IComparable<JKFHLDMIFKL>, IEquatable<JKFHLDMIFKL>, OHCAPAOIPLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[DIBBDPBJJPP(1)]
	public uint ACCGIOKDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[DIBBDPBJJPP(2)]
	public uint PJGJJFDDIFC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint ELBJNDDENMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8F80", Offset = "0x5EC7780", VA = "0x185EC8F80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EC90E0", Offset = "0x5EC78E0", VA = "0x185EC90E0")]
	public JKFHLDMIFKL(int ACCGIOKDMAO, int CPJDAAHKAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EC90E0", Offset = "0x5EC78E0", VA = "0x185EC90E0")]
	public JKFHLDMIFKL(uint ACCGIOKDMAO, uint CPJDAAHKAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8F10", Offset = "0x5EC7710", VA = "0x185EC8F10")]
	public JKFHLDMIFKL KGPCFLGDLKF(int IJJNAEFKMHG = 1)
	{
		return default(JKFHLDMIFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8F90", Offset = "0x5EC7790", VA = "0x185EC8F90")]
	public JKFHLDMIFKL OMOCPNBJLDG(int IJJNAEFKMHG = 1)
	{
		return default(JKFHLDMIFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8DA0", Offset = "0x5EC75A0", VA = "0x185EC8DA0")]
	public static JKFHLDMIFKL GAGCJPKCBDJ(JKFHLDMIFKL PCIGCGBJFLC, JKFHLDMIFKL FLACNDCEKPB)
	{
		return default(JKFHLDMIFKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8E20", Offset = "0x5EC7620", VA = "0x185EC8E20")]
	private static uint GOPCPAKJAPD(uint GIFKCLLLICD, uint KIOLHHMPBGL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8CD0", Offset = "0x5EC74D0", VA = "0x185EC8CD0", Slot = "4")]
	public int CompareTo(JKFHLDMIFKL FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8D10", Offset = "0x5EC7510", VA = "0x185EC8D10", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9000", Offset = "0x5EC7800", VA = "0x185EC9000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8CF0", Offset = "0x5EC74F0", VA = "0x185EC8CF0", Slot = "5")]
	public bool Equals(JKFHLDMIFKL FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8E50", Offset = "0x5EC7650", VA = "0x185EC8E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8EA0", Offset = "0x5EC76A0", VA = "0x185EC8EA0", Slot = "6")]
	public void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8C60", Offset = "0x5EC7460", VA = "0x185EC8C60", Slot = "7")]
	public void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25558C0", Offset = "0x25540C0", VA = "0x1825558C0")]
	public static bool FMFPLPMCDAE(JKFHLDMIFKL PCIGCGBJFLC, JKFHLDMIFKL FLACNDCEKPB)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[JGEHNKHNILJ(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[DIBBDPBJJPP(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[DIBBDPBJJPP(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[DIBBDPBJJPP(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[DIBBDPBJJPP(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[JGEHNKHNILJ(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, OHCAPAOIPLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[DIBBDPBJJPP(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
		public static SerializableGuid DBFFIFAHFFL(Guid CLGOKAHLILM)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF630", Offset = "0x5ECDE30", VA = "0x185ECF630", Slot = "4")]
		public bool Equals(SerializableGuid FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF610", Offset = "0x5ECDE10", VA = "0x185ECF610", Slot = "5")]
		public int CompareTo(SerializableGuid FPJCFKAMJHL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF660", Offset = "0x5ECDE60", VA = "0x185ECF660", Slot = "6")]
		public void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF590", Offset = "0x5ECDD90", VA = "0x185ECF590", Slot = "7")]
		public void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF720", Offset = "0x5ECDF20", VA = "0x185ECF720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct NCNCPHIPPDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct NHHIEFIKPMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct CJIHAFLBNBJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
[OAEODNDKOKK]
public struct MECFOEDCBJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[ELNCCGELHMI(1)]
	public Entity BKLPGPJDJDG;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[InternalBufferCapacity(17)]
public struct GOGGLGKCINC : IBufferElementData, IEquatable<GOGGLGKCINC>, JPHOKBHOMOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Entity EAAFIBGEEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public int GJAKBABJHOH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity MFJICAOPJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8170", Offset = "0x5EC6970", VA = "0x185EC8170", Slot = "4")]
	public bool Equals(GOGGLGKCINC FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
public struct AMMNGNIOBKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ELNCCGELHMI(1)]
	public int GJAKBABJHOH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct MOLHJOOLBAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
public struct KMGBLPKLJGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ELNCCGELHMI(1)]
	public Entity HDELNBPMPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ELNCCGELHMI(2)]
	public uint JKMLKLGMFKL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId BKFCPMKFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1CDE7A0", Offset = "0x1CDCFA0", VA = "0x181CDE7A0")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCF70", Offset = "0x1CFB770", VA = "0x181CFCF70")]
	public KMGBLPKLJGC(Entity HDELNBPMPCL, EntityBundlePartId EAHLKAOKEJG)
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
		[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
		internal EntityBundlePartId(uint MBMFHFDDILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		internal uint CDFFFHJEDBH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7DDFC0", Offset = "0x7DC7C0", VA = "0x1807DDFC0", Slot = "4")]
		public bool Equals(EntityBundlePartId FPJCFKAMJHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7880", Offset = "0x5EC6080", VA = "0x185EC7880", Slot = "0")]
		public override bool Equals(object BEKFGDCEJDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8743C0", Offset = "0x872BC0", VA = "0x1808743C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x170D6A0", Offset = "0x170BEA0", VA = "0x18170D6A0")]
		public static bool FMFPLPMCDAE(EntityBundlePartId GIFKCLLLICD, EntityBundlePartId KIOLHHMPBGL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct PLFOLEGFAEF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity MJGFIOIFLLK;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct BDPKEPLHFIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ELNCCGELHMI(1)]
	public Entity MAKBFCPADHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ELNCCGELHMI(2)]
	public bool DCDMJFDIGKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct OEECNAIHJGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ELNCCGELHMI(1)]
	public DINAKLMNMAH DGHGGLCLOJG;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[IOCPGOHMEEP(0, 4)]
public enum DINAKLMNMAH
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
[OAEODNDKOKK]
public struct JALMCFBGCPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[ELNCCGELHMI(1)]
	public Entity MAKBFCPADHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[ELNCCGELHMI(2)]
	public bool LKJMFLMFEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[ELNCCGELHMI(3)]
	public float OOMHJLBHGBB;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[OAEODNDKOKK]
public struct PDMLBDNFDOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	[ELNCCGELHMI(1)]
	public bool HDJKLLNHJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ELNCCGELHMI(2)]
	public bool LKJMFLMFEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ELNCCGELHMI(3)]
	public float BEHNLCDHMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ELNCCGELHMI(4)]
	public float LNKNIJLOFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ELNCCGELHMI(5)]
	public float ECDEJDOACEB;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct BHHKAJANBGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ELNCCGELHMI(1)]
	public bool HDJKLLNHJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ELNCCGELHMI(2)]
	public bool LKJMFLMFEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ELNCCGELHMI(3)]
	public float OOMHJLBHGBB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, JPHOKBHOMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6C20", Offset = "0x5EC5420", VA = "0x185EC6C20", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[OAEODNDKOKK]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, JPHOKBHOMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[ELNCCGELHMI(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, JPHOKBHOMOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DMDCKLHLJFF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface JPHOKBHOMOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity CCGBMEBCMPN
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
public struct PCBABBNIDMH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly bool AFICHJEBJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public uint OCDLOCKLLAI;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	private static bool ACFOHHIKCNA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
[OAEODNDKOKK]
[AOHGLJIDCDK("Light", 0)]
public struct GNLDLEPKIPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ELNCCGELHMI(1)]
	[NHKJGEIIFPH(0)]
	public bool KAJOKJADDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[ELNCCGELHMI(2)]
	[NHKJGEIIFPH(0)]
	public float IGJAMHOPAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(3)]
	public float JJGMEDPPIID;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[AOHGLJIDCDK("Light", 0)]
[OAEODNDKOKK]
public struct JBBMGPOPIKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[ELNCCGELHMI(1)]
	[NHKJGEIIFPH(0)]
	public float MFLJHNOGDGF;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.TypeVersion(2)]
public struct CFEIDAHLJOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public uint CKNHCIICDFI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EC70C0", Offset = "0x5EC58C0", VA = "0x185EC70C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[OAEODNDKOKK]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[DIBBDPBJJPP(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct ICPAJDHANBF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int AHHIAMNNOLB;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct JHCJPMJOHNE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public GCHandle HECHINHMFDM;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[IOCPGOHMEEP(0, 4)]
public enum LJDKIHLDEIJ
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
public struct BBAFPEOADNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct EPALHAJOACC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public int AHHIAMNNOLB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct JLIJOEJALFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct CNKBDKGBHFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct IOICEALBHLA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[AOHGLJIDCDK("Object", 0)]
[OAEODNDKOKK]
[TypeManager.TypeVersion(3)]
public struct NKACKNPBOEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ELNCCGELHMI(2)]
	public HPCDHIACLIA GCLPJEGOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	[ELNCCGELHMI(3)]
	[NHKJGEIIFPH(0)]
	public OFPFEMEMKND HACJFOBBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(4)]
	public JKFEKAADPAK ACMIHKLEKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[DIBBDPBJJPP(5)]
	public JBLAABGGCLC DKHKGJCPEFO;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static readonly OMBEAALPPEP<NKACKNPBOEF> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class BMIKMLEFHJD
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E40", Offset = "0x5EC5640", VA = "0x185EC6E40")]
	public static void INHNMALGLOD(this JBLAABGGCLC DKHKGJCPEFO, IPOEGHJDMEB FOOLGHLBLGN, bool GEIAKGCFOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E70", Offset = "0x5EC5670", VA = "0x185EC6E70")]
	public static bool JGDFDDGCEEL(this JBLAABGGCLC DKHKGJCPEFO, IPOEGHJDMEB FOOLGHLBLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E90", Offset = "0x5EC5690", VA = "0x185EC6E90")]
	public static JBLAABGGCLC OMMKHDMGCMK(this IPOEGHJDMEB FOOLGHLBLGN)
	{
		return default(JBLAABGGCLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E20", Offset = "0x5EC5620", VA = "0x185EC6E20")]
	public static void INHNMALGLOD(this OFPFEMEMKND DKHKGJCPEFO, OFPFEMEMKND FALDCKLPNKF, bool GEIAKGCFOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC790", Offset = "0x5DEAF90", VA = "0x185DEC790")]
	public static bool JGDFDDGCEEL(this OFPFEMEMKND DKHKGJCPEFO, OFPFEMEMKND FOOLGHLBLGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public enum IPOEGHJDMEB
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
[IOCPGOHMEEP(0, 16383)]
[Flags]
public enum JBLAABGGCLC
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
[IOCPGOHMEEP(0, 3)]
[Flags]
public enum OFPFEMEMKND
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
[IOCPGOHMEEP(0, 4)]
[NMBJGIONPMG]
public enum JKFEKAADPAK
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
public class NMBJGIONPMG : GJDLMOMMAJL
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD780", Offset = "0x5ECBF80", VA = "0x185ECD780", Slot = "7")]
	public override string LFNCFHCCHIK(string EMCGBONIADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3D445F0", Offset = "0x3D42DF0", VA = "0x183D445F0")]
	public NMBJGIONPMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[JGEHNKHNILJ(1)]
public struct HPCDHIACLIA : OHCAPAOIPLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[DIBBDPBJJPP(1)]
	public bool KAJOKJADDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[DIBBDPBJJPP(2)]
	public float3 CPLKDODKNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[DIBBDPBJJPP(3)]
	public float3 LCCMGKFDGNJ;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public static readonly OMBEAALPPEP<HPCDHIACLIA> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8410", Offset = "0x5EC6C10", VA = "0x185EC8410", Slot = "5")]
	public void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8480", Offset = "0x5EC6C80", VA = "0x185EC8480", Slot = "4")]
	public void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct EICDDIGINMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct HKPGEFGHFAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct JEKPLNHHIDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct KDHMKNPKMLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public FixedString32Bytes PMDCAPIFBIP;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[KHMGNMMLFME]
public struct HGNDJMKHELG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Entity PECGJPLCLGD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static HGNDJMKHELG DBFFIFAHFFL(Entity DOLICEBFIPF)
	{
		return default(HGNDJMKHELG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
[OAEODNDKOKK]
public struct EAIAHOAJMIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	[ELNCCGELHMI(1)]
	public Entity PNHKKEFOPHL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static EAIAHOAJMIG DBFFIFAHFFL(Entity EIJPPJGEAJM)
	{
		return default(EAIAHOAJMIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct HADDKLHIOOI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Entity EIJPPJGEAJM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static HADDKLHIOOI DBFFIFAHFFL(Entity EIJPPJGEAJM)
	{
		return default(HADDKLHIOOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JJNDOFAAHAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Entity ALEIPPLHCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Entity HDGBPOCFKFI;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal struct GNHGEFGMAJB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Entity CHIGMIEHPHN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static GNHGEFGMAJB DBFFIFAHFFL(Entity EIJPPJGEAJM)
	{
		return default(GNHGEFGMAJB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal struct CNNLEIEKKNO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[IOCPGOHMEEP(0, 2)]
public enum GODKMNPHHKF
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
[AOHGLJIDCDK("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
[OAEODNDKOKK]
public struct HBEPFKJEJEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[ELNCCGELHMI(1)]
	[NHKJGEIIFPH(0)]
	public float FEAIBNCLBII;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public static readonly OMBEAALPPEP<HBEPFKJEJEO> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
[OAEODNDKOKK]
public struct AIHNKAPEFHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[ELNCCGELHMI(1)]
	public ICDPOAEHPOL AEGCMOAJKHL;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[IOCPGOHMEEP(-1, 38)]
public enum ICDPOAEHPOL
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
[OAEODNDKOKK]
public struct OFBPOHDPJIN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[IOCPGOHMEEP(0, 7)]
	[Flags]
	public enum BCKPDGOHHMA
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
	[ELNCCGELHMI(1)]
	public BCKPDGOHHMA DKHKGJCPEFO;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public static readonly OMBEAALPPEP<OFBPOHDPJIN> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool NJPLMLKNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDAA0", Offset = "0x5ECC2A0", VA = "0x185ECDAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LJHHPPFHBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDA90", Offset = "0x5ECC290", VA = "0x185ECDA90")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
[OAEODNDKOKK]
public struct CKBJMABMGFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[ELNCCGELHMI(1)]
	public GODKMNPHHKF AEGCMOAJKHL;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct CEDKAGAJBOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public uint GLPKPIDPHCF;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[JGEHNKHNILJ(1)]
public struct OFBDDCMINLP : OHCAPAOIPLG
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[Flags]
	[IOCPGOHMEEP(0, 7)]
	public enum HDNGCEKLNGM
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
	[DIBBDPBJJPP(1)]
	public float NOGNACKJEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[DIBBDPBJJPP(2)]
	public int DPLJIKKKDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[DIBBDPBJJPP(3)]
	public HDNGCEKLNGM DKHKGJCPEFO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JHEEHDEFANJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD9A0", Offset = "0x5ECC1A0", VA = "0x185ECD9A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD9F0", Offset = "0x5ECC1F0", VA = "0x185ECD9F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BDEILKCPICC
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD9B0", Offset = "0x5ECC1B0", VA = "0x185ECD9B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDA70", Offset = "0x5ECC270", VA = "0x185ECDA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BNPBELHPGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD9E0", Offset = "0x5ECC1E0", VA = "0x185ECD9E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD9C0", Offset = "0x5ECC1C0", VA = "0x185ECD9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD950", Offset = "0x5ECC150", VA = "0x185ECD950", Slot = "5")]
	public void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDA10", Offset = "0x5ECC210", VA = "0x185ECDA10", Slot = "4")]
	public void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[KHMGNMMLFME]
internal struct JIGLBJIKOGF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Entity GOGCOCBNFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public int EAHCFBMNNCF;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct CBOABMONNAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ELNCCGELHMI(1)]
	public JKFHLDMIFKL FNHLOMPFGOL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static CBOABMONNAJ DBFFIFAHFFL(JKFHLDMIFKL DOLICEBFIPF)
	{
		return default(CBOABMONNAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[OAEODNDKOKK]
public struct FPPAMIKOAIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ELNCCGELHMI(1)]
	public Entity GOKMMBCCHCF;
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal struct ECLCNKMPAMH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Entity GOKMMBCCHCF;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
[OAEODNDKOKK]
public struct JAOBJMCDEAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ELNCCGELHMI(1)]
	public float3 ENHKIKKDBOC;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static readonly OMBEAALPPEP<JAOBJMCDEAD> FCIJPOCPFGE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2019170", Offset = "0x2017970", VA = "0x182019170")]
	public static JAOBJMCDEAD DBFFIFAHFFL(float3 DOLICEBFIPF)
	{
		return default(JAOBJMCDEAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
[OAEODNDKOKK]
public struct LBADMAAOMEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ELNCCGELHMI(1)]
	public quaternion AOABADNNGMN;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public static readonly OMBEAALPPEP<LBADMAAOMEO> FCIJPOCPFGE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7DD910", Offset = "0x7DC110", VA = "0x1807DD910")]
	public static LBADMAAOMEO DBFFIFAHFFL(quaternion DOLICEBFIPF)
	{
		return default(LBADMAAOMEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct MPFOKOGOPNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[ELNCCGELHMI(1)]
	public float3 OJABGBJGHIL;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly OMBEAALPPEP<MPFOKOGOPNM> FCIJPOCPFGE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2019170", Offset = "0x2017970", VA = "0x182019170")]
	public static MPFOKOGOPNM DBFFIFAHFFL(float3 DOLICEBFIPF)
	{
		return default(MPFOKOGOPNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct BNDPFGHEKAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[ELNCCGELHMI(1)]
	public OFBDDCMINLP ICGNFMFDOBD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct EDDFMFLKPID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct PILGLDBHCDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public uint OCDLOCKLLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public int FNIOEMJPHPA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA106A0", Offset = "0xA0EEA0", VA = "0x180A106A0")]
	public PILGLDBHCDG(uint KCCPABEMENM, int NGGOHFCNNCC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct GCAOIPLKOAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct PNLOKPPBHJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct NFEANJJEKAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct HPAEELCDNAC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct EGBCADIPNHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct AHHHDNGOJFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct GMIMDCILIPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct JFEMMFBHDPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct JFNNFJNOBLM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct MPDHPEEKOFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct DKIBOPHLAHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal struct DLFLHHDPLHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal struct CNOCLNGBPND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct AJLICHLGLII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct CNABCEOCHLE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
[OAEODNDKOKK]
public struct LKPDPDEBBLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[ELNCCGELHMI(1)]
	public FixedList32Bytes<int> HHHIFIJEMFI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct BEHNBACLDKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct LAFFFGAFPHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct DCAMGNPOEKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct BOOHDMCKCGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal struct PMMIPCNNLPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct CJGLHOFDHHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public struct FIKEGCEHLKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct KFCMLDIEOHL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[KHMGNMMLFME]
public struct OFLHPHJDFEH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public FixedString32Bytes OHNMLPMMMKK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct JIFAIFMPMFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal struct PCHPENNFGDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BC")]
internal struct CAFNLADDEHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct KOPCCDPMOKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[DIBBDPBJJPP(1)]
	public NGFBGOCMHNG GLPKPIDPHCF;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly OMBEAALPPEP<KOPCCDPMOKI> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public enum NGFBGOCMHNG : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct GALJAJPPMGC : IComponentData, IComparable<GALJAJPPMGC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public int NAKNPDOLOJO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x171C6E0", Offset = "0x171AEE0", VA = "0x18171C6E0", Slot = "4")]
	public int CompareTo(GALJAJPPMGC FPJCFKAMJHL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[TypeManager.TypeVersion(2)]
public struct CCIDJFCFDFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[ELNCCGELHMI(2)]
	public bool BMDGIBFIEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[ELNCCGELHMI(3)]
	public bool NEKODNHHOLJ;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public static readonly OMBEAALPPEP<CCIDJFCFDFL> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[OAEODNDKOKK]
public struct HAPFLGAECKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[ELNCCGELHMI(1)]
	public bool MDMJFAGMCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[ELNCCGELHMI(2)]
	public byte GANIGJABOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[ELNCCGELHMI(3)]
	public short ICEEDLAFELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[ELNCCGELHMI(4)]
	public ushort BLBJFIPDLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[ELNCCGELHMI(5)]
	public int EDNJOGGIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[ELNCCGELHMI(6)]
	public uint ICAJPNNIHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[ELNCCGELHMI(7)]
	public long OKOCFJGDKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ELNCCGELHMI(8)]
	public ulong ICJJDBEDDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ELNCCGELHMI(9)]
	public float DNMPMCFKPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ELNCCGELHMI(10)]
	public double NDFBPPDKIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[ELNCCGELHMI(11)]
	public IMPKINHOHLD NAJCLOILMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ELNCCGELHMI(12)]
	public GPNDDHCDDBC LLBNMEMHBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ELNCCGELHMI(13)]
	public FHNJPFKABOG NHOKJDPFGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ELNCCGELHMI(14)]
	public KNDLLBFKNLJ KDKOKLABBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ELNCCGELHMI(15)]
	public OIEAKEGDOPL BMGPEHGKFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ELNCCGELHMI(16)]
	public POIKPHKHCBO MHBNCPEMOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[ELNCCGELHMI(17)]
	public CIHICNHGJHG HPHICBAHOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[ELNCCGELHMI(18)]
	public CBMKIBDMEMJ PPPCGLONIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[ELNCCGELHMI(20)]
	public Quaternion ELKJOIHCMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[ELNCCGELHMI(22)]
	public Vector3 DENPMOENFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ELNCCGELHMI(23)]
	public Vector4 ANOAJAPLNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ELNCCGELHMI(40)]
	public Entity BEGALJBFALF;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum IMPKINHOHLD : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public enum GPNDDHCDDBC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum FHNJPFKABOG : short
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum KNDLLBFKNLJ : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum OIEAKEGDOPL
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum POIKPHKHCBO : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public enum CIHICNHGJHG : long
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public enum CBMKIBDMEMJ : ulong
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
	[OAEODNDKOKK]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[OAEODNDKOKK]
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
public class ELILLBPKAAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public int KAGAAHEAJHB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public int HIHIHCKEOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public GameObject AOMHCMIECFG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ELILLBPKAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class GEHGBBMDINI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public struct PPKLNOHHLIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Vector3 KPJJJPDCNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<SerializableGuid> FJJLAMGGCEM;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public class CCLKKANGBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public PPKLNOHHLIH FFCHEJDCGED;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CCLKKANGBCP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public SerializableGuid OAPDBOLDLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public List<int> MLFOJIPNAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public List<PPKLNOHHLIH> HJBJDNKFAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public List<CCLKKANGBCP> LMKGDJHBLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public GameObject AOMHCMIECFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Light CBFCKGBEGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Collider NIHGMHGGAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public string OOKLJCLDBHM;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public GEHGBBMDINI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct FBPCKAGEGCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[ELNCCGELHMI(1)]
	public float3 LMLFAJABOEC;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public static readonly OMBEAALPPEP<FBPCKAGEGCD> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
[OAEODNDKOKK]
public struct LKPJBFIGBKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	[ELNCCGELHMI(1)]
	public quaternion AOABADNNGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ELNCCGELHMI(2)]
	public float3 ENHKIKKDBOC;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public static readonly OMBEAALPPEP<LKPJBFIGBKI> FCIJPOCPFGE;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x39CE1A0", Offset = "0x39CC9A0", VA = "0x1839CE1A0")]
	public LKPJBFIGBKI(quaternion AOABADNNGMN, float3 ENHKIKKDBOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6FC0", Offset = "0x5EC57C0", VA = "0x185EC6FC0")]
	public static RigidTransform DBFFIFAHFFL(LKPJBFIGBKI PJOEKHLIHGM)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6FC0", Offset = "0x5EC57C0", VA = "0x185EC6FC0")]
	public static LKPJBFIGBKI DBFFIFAHFFL(RigidTransform EHPMOHOPBBK)
	{
		return default(LKPJBFIGBKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class OMECLAAOKCA
{
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct BJMFOHJJMOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float4x4 KNIFKFGDHAI;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly OMBEAALPPEP<BJMFOHJJMOC> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public struct IKNJGNKPKFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float4x4 JHMJPNGIPCF;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static readonly OMBEAALPPEP<IKNJGNKPKFA> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct LECLAAODDJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	[ELNCCGELHMI(1)]
	public float PCHJELNHBAN;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public static readonly OMBEAALPPEP<LECLAAODDJP> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct IEMKAMAJNKI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int APNKNLJGLCM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int EAHCFBMNNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8660", Offset = "0x5EC6E60", VA = "0x185EC8660")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8670", Offset = "0x5EC6E70", VA = "0x185EC8670")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[OAEODNDKOKK]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct DJEPKLBIJNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[ELNCCGELHMI(1)]
	public NEIDLMEBKHH NLMOPEKPPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[ELNCCGELHMI(2)]
	public JDEDOIIHGFH MPHFNCEPMJP;
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[IOCPGOHMEEP(0, 1)]
[Flags]
public enum NEIDLMEBKHH
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
[IOCPGOHMEEP(-2, 2)]
public enum JDEDOIIHGFH
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
public struct GLGNOIDKCLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public float3 KBOEOOHIKIE;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static readonly OMBEAALPPEP<GLGNOIDKCLL> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct ALLKDOLCBPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public float3 FLFCGPFDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public quaternion JOBDANNFLEE;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static readonly OMBEAALPPEP<ALLKDOLCBPI> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class DHDLOACNGJC
{
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public struct KDPGNKLNADL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public float IECFDMFNJBL;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static readonly OMBEAALPPEP<KDPGNKLNADL> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[IOCPGOHMEEP(1000, 8000)]
public enum GNCNNCODHCF
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
public static class NJKMJBGOKBI
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal enum ABCFEOEMOJK
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
internal static class MJIGHDEIFJO
{
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[IOCPGOHMEEP(0, 9)]
public enum BDLCFCMICHD
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
public static class CKNLHIJJHIL
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7290", Offset = "0x5EC5A90", VA = "0x185EC7290")]
	public static bool CDFJPIEKAGI(this BDLCFCMICHD FEMLPFMLNLN)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[OAEODNDKOKK]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public GNCNNCODHCF prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class KDAIOIPPNKH
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC94A0", Offset = "0x5EC7CA0", VA = "0x185EC94A0")]
	public static BDLCFCMICHD NKEEDENDHBA(this GNCNNCODHCF OINDNEFNLBC)
	{
		return default(BDLCFCMICHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[IOCPGOHMEEP(int.MinValue, int.MaxValue)]
public enum LJGCDAIHJKP
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
[IOCPGOHMEEP(-1, 31)]
public enum KNFCOAIEJCG
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
[OAEODNDKOKK]
[AOHGLJIDCDK("Visual", 0)]
public struct MJMLFADJELD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(1)]
	public LJGCDAIHJKP NGHDCCDAAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(2)]
	public KNFCOAIEJCG ECIAJACKHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	[ELNCCGELHMI(3)]
	[NHKJGEIIFPH(0)]
	public float NFNFBBBPDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(4)]
	public Vector3 IDNFEPJICMM;
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[HIOOACJJPKA]
[LLHIBPGHLON(2613756846563002039uL, 6372660366488563574uL)]
[AOHGLJIDCDK("Container", 0)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct JLJNBCANAOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(1)]
	public LIBLACFKPAL GCBLBFNIIED;
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[Flags]
[IOCPGOHMEEP(0, 15)]
public enum LIBLACFKPAL
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
[HIOOACJJPKA]
[LLHIBPGHLON(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct INHFDNCNCLC : IComponentData, IEquatable<INHFDNCNCLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[ELNCCGELHMI(1)]
	public FixedString64Bytes PMDCAPIFBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[ELNCCGELHMI(2)]
	public KEOFIHPFFDL DMJCNNACDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[ELNCCGELHMI(3)]
	public LIBLACFKPAL GCBLBFNIIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[ELNCCGELHMI(4)]
	public PICOLMPIMHA AFKBEHFOBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[ELNCCGELHMI(5)]
	public NJCCEBHKLID DKHKGJCPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[ELNCCGELHMI(6)]
	public float DKBLLJFFMEK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8A00", Offset = "0x5EC7200", VA = "0x185EC8A00", Slot = "4")]
	public bool Equals(INHFDNCNCLC FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[LLHIBPGHLON(1213445203937950283uL, 119653618660684511uL)]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[HIOOACJJPKA]
public struct BOIJICJJPKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[ELNCCGELHMI(1)]
	public OOBHEBKJAGN MKJEIGIMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public GCHandle PIOFGCGEFCD;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[JGEHNKHNILJ(1)]
public struct OOBHEBKJAGN : OHCAPAOIPLG, IEquatable<OOBHEBKJAGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[DIBBDPBJJPP(1)]
	public int MBMFHFDDILC;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC60", Offset = "0x5ECC460", VA = "0x185ECDC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDBE0", Offset = "0x5ECC3E0", VA = "0x185ECDBE0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFC0", Offset = "0x7DC7C0", VA = "0x1807DDFC0", Slot = "6")]
	public bool Equals(OOBHEBKJAGN FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x171C770", Offset = "0x171AF70", VA = "0x18171C770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDBC0", Offset = "0x5ECC3C0", VA = "0x185ECDBC0", Slot = "5")]
	public void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDCC0", Offset = "0x5ECC4C0", VA = "0x185ECDCC0", Slot = "4")]
	public void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[HIOOACJJPKA]
[LLHIBPGHLON(218523523639012570uL, 15191719635551116065uL)]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
public struct MEOBGIGBODK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private uint GJDLANOKEND;
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[LLHIBPGHLON(9898405628982320166uL, 2023375009558162791uL)]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[HIOOACJJPKA]
public struct BFENBDDHAAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[ELNCCGELHMI(1)]
	public JBLAABGGCLC DKHKGJCPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[ELNCCGELHMI(2)]
	public HPCDHIACLIA GCLPJEGOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[ELNCCGELHMI(3)]
	[NHKJGEIIFPH(0)]
	public bool FIMNEDHPHMN;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly OMBEAALPPEP<BFENBDDHAAE> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[HIOOACJJPKA]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[LLHIBPGHLON(9807788745867066359uL, 15168486114979071194uL)]
public struct FPAOFIMCKNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[ELNCCGELHMI(1)]
	public JBLAABGGCLC DKHKGJCPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[ELNCCGELHMI(2)]
	public HPCDHIACLIA GCLPJEGOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[ELNCCGELHMI(3)]
	[NHKJGEIIFPH(0)]
	public bool FIMNEDHPHMN;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly OMBEAALPPEP<FPAOFIMCKNM> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[HIOOACJJPKA]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[LLHIBPGHLON(4470189027631723570uL, 5922380073816386711uL)]
public struct HPFHAHKBFKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[DIBBDPBJJPP(1)]
	public JBLAABGGCLC DKHKGJCPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[ELNCCGELHMI(2)]
	public HPCDHIACLIA GCLPJEGOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[ELNCCGELHMI(3)]
	[NHKJGEIIFPH(0)]
	public OFPFEMEMKND HACJFOBBIDE;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly OMBEAALPPEP<HPFHAHKBFKJ> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[LLHIBPGHLON(12226092714547765037uL, 15970362445488810630uL)]
[HIOOACJJPKA]
public struct KBLBDKEKFAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[ELNCCGELHMI(2)]
	public HPCDHIACLIA GCLPJEGOBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	[NHKJGEIIFPH(0)]
	[ELNCCGELHMI(3)]
	public OFPFEMEMKND HACJFOBBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[DIBBDPBJJPP(4)]
	public JBLAABGGCLC DKHKGJCPEFO;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly OMBEAALPPEP<KBLBDKEKFAM> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
[LLHIBPGHLON(3318727941304405759uL, 6047901070934821887uL)]
[HIOOACJJPKA]
public struct ODAGGCMKNGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	public int KHOAALNCNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	[ELNCCGELHMI(2)]
	public bool BMDGIBFIEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	[ELNCCGELHMI(3)]
	public bool NEKODNHHOLJ;

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	public static readonly OMBEAALPPEP<ODAGGCMKNGJ> FCIJPOCPFGE;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[LLHIBPGHLON(5861057081882613294uL, 13746475565109640919uL)]
[HIOOACJJPKA]
public struct ICKFPHDAHHP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[IOCPGOHMEEP(0, 1)]
	public enum JCOKNDJECMJ
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
	[ELNCCGELHMI(1)]
	public JCOKNDJECMJ KMNPIGKFDAO;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[HIOOACJJPKA]
[LLHIBPGHLON(14327281633525910712uL, 2559857777606771911uL)]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
public struct KMBKKFJFCNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	[ELNCCGELHMI(1)]
	public GNCNNCODHCF OINDNEFNLBC;
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[HIOOACJJPKA]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[LLHIBPGHLON(15725208981563603541uL, 17017036095303668770uL)]
public struct MKJIJIBEDON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	[ELNCCGELHMI(1)]
	public GNCNNCODHCF OINDNEFNLBC;
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[HIOOACJJPKA]
[LLHIBPGHLON(1029043735688538310uL, 14256247939851101839uL)]
public struct JOPIDMICEFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public BDLCFCMICHD FEMLPFMLNLN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[HIOOACJJPKA]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[LLHIBPGHLON(17667479821163689808uL, 11946378475791123970uL)]
public struct MNMIHJAKPDC : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : HHDBBJLHMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF730", Offset = "0x5ECDF30", VA = "0x185ECF730", Slot = "4")]
		public sealed override void FNHLHCLCODJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class FGIFKJJBNLL : ContainerPropertyBag<KIEMMHBAPOJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class FFBDNBAJGAD : Property<KIEMMHBAPOJ, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7A00", Offset = "0x5EC6200", VA = "0x185EC7A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EC79C0", Offset = "0x5EC61C0", VA = "0x185EC79C0")]
		public FFBDNBAJGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7970", Offset = "0x5EC6170", VA = "0x185EC7970", Slot = "14")]
		public override Rigidbody GetValue(KIEMMHBAPOJ EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7990", Offset = "0x5EC6190", VA = "0x185EC7990", Slot = "15")]
		public override void SetValue(KIEMMHBAPOJ EFKPBKMFDOG, Rigidbody DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7A30", Offset = "0x5EC6230", VA = "0x185EC7A30")]
	public FGIFKJJBNLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class AENKNIACGBP : ContainerPropertyBag<JNOOLCMLGCC>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class FHBMHEKHIAB : Property<JNOOLCMLGCC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7B50", Offset = "0x5EC6350", VA = "0x185EC7B50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B10", Offset = "0x5EC6310", VA = "0x185EC7B10")]
		public FHBMHEKHIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7970", Offset = "0x5EC6170", VA = "0x185EC7970", Slot = "14")]
		public override object GetValue(JNOOLCMLGCC EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7990", Offset = "0x5EC6190", VA = "0x185EC7990", Slot = "15")]
		public override void SetValue(JNOOLCMLGCC EFKPBKMFDOG, object DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6920", Offset = "0x5EC5120", VA = "0x185EC6920")]
	public AENKNIACGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class LLFCBHGGNGE : ContainerPropertyBag<INFCPOGJHFA>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class JGPHBKAEIAE : Property<INFCPOGJHFA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8C30", Offset = "0x5EC7430", VA = "0x185EC8C30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8BF0", Offset = "0x5EC73F0", VA = "0x185EC8BF0")]
		public JGPHBKAEIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7970", Offset = "0x5EC6170", VA = "0x185EC7970", Slot = "14")]
		public override object GetValue(INFCPOGJHFA EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7990", Offset = "0x5EC6190", VA = "0x185EC7990", Slot = "15")]
		public override void SetValue(INFCPOGJHFA EFKPBKMFDOG, object DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9E30", Offset = "0x5EC8630", VA = "0x185EC9E30")]
	public LLFCBHGGNGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class DECAIKEODCK : ContainerPropertyBag<NJKBOAGICID>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class LJBCCOGDCNC : Property<NJKBOAGICID, BKONHFHHNPH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9D40", Offset = "0x5EC8540", VA = "0x185EC9D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9D00", Offset = "0x5EC8500", VA = "0x185EC9D00")]
		public LJBCCOGDCNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7970", Offset = "0x5EC6170", VA = "0x185EC7970", Slot = "14")]
		public override BKONHFHHNPH GetValue(NJKBOAGICID EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7990", Offset = "0x5EC6190", VA = "0x185EC7990", Slot = "15")]
		public override void SetValue(NJKBOAGICID EFKPBKMFDOG, BKONHFHHNPH DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC74B0", Offset = "0x5EC5CB0", VA = "0x185EC74B0")]
	public DECAIKEODCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal class GLOLNAIIANP : ContainerPropertyBag<ELILLBPKAAH>
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class FLKFFAHKMPF : Property<ELILLBPKAAH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7CB0", Offset = "0x5EC64B0", VA = "0x185EC7CB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7C70", Offset = "0x5EC6470", VA = "0x185EC7C70")]
		public FLKFFAHKMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7C30", Offset = "0x5EC6430", VA = "0x185EC7C30", Slot = "14")]
		public override int GetValue(ELILLBPKAAH EFKPBKMFDOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7C50", Offset = "0x5EC6450", VA = "0x185EC7C50", Slot = "15")]
		public override void SetValue(ELILLBPKAAH EFKPBKMFDOG, int DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class FKHCNNHKMCG : Property<ELILLBPKAAH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7C00", Offset = "0x5EC6400", VA = "0x185EC7C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7BC0", Offset = "0x5EC63C0", VA = "0x185EC7BC0")]
		public FKHCNNHKMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B80", Offset = "0x5EC6380", VA = "0x185EC7B80", Slot = "14")]
		public override int GetValue(ELILLBPKAAH EFKPBKMFDOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7BA0", Offset = "0x5EC63A0", VA = "0x185EC7BA0", Slot = "15")]
		public override void SetValue(ELILLBPKAAH EFKPBKMFDOG, int DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class LNBIDABACNM : Property<ELILLBPKAAH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD2D0", Offset = "0x5ECBAD0", VA = "0x185ECD2D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD290", Offset = "0x5ECBA90", VA = "0x185ECD290")]
		public LNBIDABACNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD240", Offset = "0x5ECBA40", VA = "0x185ECD240", Slot = "14")]
		public override GameObject GetValue(ELILLBPKAAH EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD260", Offset = "0x5ECBA60", VA = "0x185ECD260", Slot = "15")]
		public override void SetValue(ELILLBPKAAH EFKPBKMFDOG, GameObject DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7FD0", Offset = "0x5EC67D0", VA = "0x185EC7FD0")]
	public GLOLNAIIANP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class PLHBOLGPIAL : ContainerPropertyBag<GEHGBBMDINI>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class NDGMGAFCEAA : Property<GEHGBBMDINI, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD5E0", Offset = "0x5ECBDE0", VA = "0x185ECD5E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD5A0", Offset = "0x5ECBDA0", VA = "0x185ECD5A0")]
		public NDGMGAFCEAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD550", Offset = "0x5ECBD50", VA = "0x185ECD550", Slot = "14")]
		public override SerializableGuid GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD580", Offset = "0x5ECBD80", VA = "0x185ECD580", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, SerializableGuid DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class AALBAAIMFCC : Property<GEHGBBMDINI, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x5EC67B0", Offset = "0x5EC4FB0", VA = "0x185EC67B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6770", Offset = "0x5EC4F70", VA = "0x185EC6770")]
		public AALBAAIMFCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6720", Offset = "0x5EC4F20", VA = "0x185EC6720", Slot = "14")]
		public override List<int> GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6740", Offset = "0x5EC4F40", VA = "0x185EC6740", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, List<int> DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class ANEHCJEDGOH : Property<GEHGBBMDINI, List<GEHGBBMDINI.PPKLNOHHLIH>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5EC6BF0", Offset = "0x5EC53F0", VA = "0x185EC6BF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6BB0", Offset = "0x5EC53B0", VA = "0x185EC6BB0")]
		public ANEHCJEDGOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6B60", Offset = "0x5EC5360", VA = "0x185EC6B60", Slot = "14")]
		public override List<GEHGBBMDINI.PPKLNOHHLIH> GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6B80", Offset = "0x5EC5380", VA = "0x185EC6B80", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, List<GEHGBBMDINI.PPKLNOHHLIH> DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class OILAKKKFAAG : Property<GEHGBBMDINI, List<GEHGBBMDINI.CCLKKANGBCP>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x5ECDB90", Offset = "0x5ECC390", VA = "0x185ECDB90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDB50", Offset = "0x5ECC350", VA = "0x185ECDB50")]
		public OILAKKKFAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDB00", Offset = "0x5ECC300", VA = "0x185ECDB00", Slot = "14")]
		public override List<GEHGBBMDINI.CCLKKANGBCP> GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDB20", Offset = "0x5ECC320", VA = "0x185ECDB20", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, List<GEHGBBMDINI.CCLKKANGBCP> DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class MBLGDIOIHDJ : Property<GEHGBBMDINI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD390", Offset = "0x5ECBB90", VA = "0x185ECD390", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD350", Offset = "0x5ECBB50", VA = "0x185ECD350")]
		public MBLGDIOIHDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD300", Offset = "0x5ECBB00", VA = "0x185ECD300", Slot = "14")]
		public override GameObject GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD320", Offset = "0x5ECBB20", VA = "0x185ECD320", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, GameObject DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class ILGHGAACBCI : Property<GEHGBBMDINI, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8960", Offset = "0x5EC7160", VA = "0x185EC8960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8920", Offset = "0x5EC7120", VA = "0x185EC8920")]
		public ILGHGAACBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC88D0", Offset = "0x5EC70D0", VA = "0x185EC88D0", Slot = "14")]
		public override Light GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC88F0", Offset = "0x5EC70F0", VA = "0x185EC88F0", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, Light DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	private class IFILHLHBBGD : Property<GEHGBBMDINI, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8770", Offset = "0x5EC6F70", VA = "0x185EC8770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8730", Offset = "0x5EC6F30", VA = "0x185EC8730")]
		public IFILHLHBBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EC86E0", Offset = "0x5EC6EE0", VA = "0x185EC86E0", Slot = "14")]
		public override Collider GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8700", Offset = "0x5EC6F00", VA = "0x185EC8700", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, Collider DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class GCCCINHKLLL : Property<GEHGBBMDINI, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7E70", Offset = "0x5EC6670", VA = "0x185EC7E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7E30", Offset = "0x5EC6630", VA = "0x185EC7E30")]
		public GCCCINHKLLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7DE0", Offset = "0x5EC65E0", VA = "0x185EC7DE0", Slot = "14")]
		public override string GetValue(GEHGBBMDINI EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7E00", Offset = "0x5EC6600", VA = "0x185EC7E00", Slot = "15")]
		public override void SetValue(GEHGBBMDINI EFKPBKMFDOG, string DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE2D0", Offset = "0x5ECCAD0", VA = "0x185ECE2D0")]
	public PLHBOLGPIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class DEGICNHNKNC : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class CLKPMKBJMEM : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5EC73A0", Offset = "0x5EC5BA0", VA = "0x185EC73A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EC72B0", Offset = "0x5EC5AB0", VA = "0x185EC72B0")]
		public CLKPMKBJMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xE06140", Offset = "0xE04940", VA = "0x180E06140", Slot = "14")]
		public override Data128 GetValue(SerializableGuid EFKPBKMFDOG)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EC72A0", Offset = "0x5EC5AA0", VA = "0x185EC72A0", Slot = "15")]
		public override void SetValue(SerializableGuid EFKPBKMFDOG, Data128 DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7590", Offset = "0x5EC5D90", VA = "0x185EC7590")]
	public DEGICNHNKNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class KGIPDBBHJHG : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	private class PJFLEKOBCFG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE000", Offset = "0x5ECC800", VA = "0x185ECE000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDF10", Offset = "0x5ECC710", VA = "0x185ECDF10")]
		public PJFLEKOBCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x12CE800", Offset = "0x12CD000", VA = "0x1812CE800", Slot = "14")]
		public override int GetValue(Data128 EFKPBKMFDOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9340", Offset = "0x5EC7B40", VA = "0x185EC9340", Slot = "15")]
		public override void SetValue(Data128 EFKPBKMFDOG, int DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class CJDCJAMJPLO : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7260", Offset = "0x5EC5A60", VA = "0x185EC7260", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7170", Offset = "0x5EC5970", VA = "0x185EC7170")]
		public CJDCJAMJPLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7150", Offset = "0x5EC5950", VA = "0x185EC7150", Slot = "14")]
		public override int GetValue(Data128 EFKPBKMFDOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7160", Offset = "0x5EC5960", VA = "0x185EC7160", Slot = "15")]
		public override void SetValue(Data128 EFKPBKMFDOG, int DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	private class HLOFMBJKJHM : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC83E0", Offset = "0x5EC6BE0", VA = "0x185EC83E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5EC82F0", Offset = "0x5EC6AF0", VA = "0x185EC82F0")]
		public HLOFMBJKJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x15A0A30", Offset = "0x159F230", VA = "0x1815A0A30", Slot = "14")]
		public override int GetValue(Data128 EFKPBKMFDOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EC82E0", Offset = "0x5EC6AE0", VA = "0x185EC82E0", Slot = "15")]
		public override void SetValue(Data128 EFKPBKMFDOG, int DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class ADDCLPGNEGB : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5EC68F0", Offset = "0x5EC50F0", VA = "0x185EC68F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6800", Offset = "0x5EC5000", VA = "0x185EC6800")]
		public ADDCLPGNEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5EC67E0", Offset = "0x5EC4FE0", VA = "0x185EC67E0", Slot = "14")]
		public override int GetValue(Data128 EFKPBKMFDOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5EC67F0", Offset = "0x5EC4FF0", VA = "0x185EC67F0", Slot = "15")]
		public override void SetValue(Data128 EFKPBKMFDOG, int DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5EC96D0", Offset = "0x5EC7ED0", VA = "0x185EC96D0")]
	public KGIPDBBHJHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class PJKODDGJHKB : ContainerPropertyBag<GEHGBBMDINI.PPKLNOHHLIH>
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	private class PPIGCBEMNDJ : Property<GEHGBBMDINI.PPKLNOHHLIH, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE830", Offset = "0x5ECD030", VA = "0x185ECE830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE7F0", Offset = "0x5ECCFF0", VA = "0x185ECE7F0")]
		public PPIGCBEMNDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF00", Offset = "0x8E9700", VA = "0x1808EAF00", Slot = "14")]
		public override Vector3 GetValue(GEHGBBMDINI.PPKLNOHHLIH EFKPBKMFDOG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE7D0", Offset = "0x5ECCFD0", VA = "0x185ECE7D0", Slot = "15")]
		public override void SetValue(GEHGBBMDINI.PPKLNOHHLIH EFKPBKMFDOG, Vector3 DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class INPNOODHFID : Property<GEHGBBMDINI.PPKLNOHHLIH, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8B40", Offset = "0x5EC7340", VA = "0x185EC8B40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8B00", Offset = "0x5EC7300", VA = "0x185EC8B00")]
		public INPNOODHFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8AE0", Offset = "0x5EC72E0", VA = "0x185EC8AE0", Slot = "14")]
		public override List<SerializableGuid> GetValue(GEHGBBMDINI.PPKLNOHHLIH EFKPBKMFDOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8AF0", Offset = "0x5EC72F0", VA = "0x185EC8AF0", Slot = "15")]
		public override void SetValue(GEHGBBMDINI.PPKLNOHHLIH EFKPBKMFDOG, List<SerializableGuid> DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE030", Offset = "0x5ECC830", VA = "0x185ECE030")]
	public PJKODDGJHKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class JMKKKOAEGAF : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class OBPPDMGHMOB : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5ECD8B0", Offset = "0x5ECC0B0", VA = "0x185ECD8B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD870", Offset = "0x5ECC070", VA = "0x185ECD870")]
		public OBPPDMGHMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD850", Offset = "0x5ECC050", VA = "0x185ECD850", Slot = "14")]
		public override float GetValue(Vector3 EFKPBKMFDOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD860", Offset = "0x5ECC060", VA = "0x185ECD860", Slot = "15")]
		public override void SetValue(Vector3 EFKPBKMFDOG, float DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011C")]
	private class KFLDEKALBAO : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x5EC96A0", Offset = "0x5EC7EA0", VA = "0x185EC96A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9660", Offset = "0x5EC7E60", VA = "0x185EC9660")]
		public KFLDEKALBAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9640", Offset = "0x5EC7E40", VA = "0x185EC9640", Slot = "14")]
		public override float GetValue(Vector3 EFKPBKMFDOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9650", Offset = "0x5EC7E50", VA = "0x185EC9650", Slot = "15")]
		public override void SetValue(Vector3 EFKPBKMFDOG, float DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	private class GKBDNCFHMCJ : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC7EF0", Offset = "0x5EC66F0", VA = "0x185EC7EF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7EB0", Offset = "0x5EC66B0", VA = "0x185EC7EB0")]
		public GKBDNCFHMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1986160", Offset = "0x1984960", VA = "0x181986160", Slot = "14")]
		public override float GetValue(Vector3 EFKPBKMFDOG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7EA0", Offset = "0x5EC66A0", VA = "0x185EC7EA0", Slot = "15")]
		public override void SetValue(Vector3 EFKPBKMFDOG, float DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9130", Offset = "0x5EC7930", VA = "0x185EC9130")]
	public JMKKKOAEGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class COMHGOIAFCG : ContainerPropertyBag<GEHGBBMDINI.CCLKKANGBCP>
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class PNDGMELJNIN : Property<GEHGBBMDINI.CCLKKANGBCP, GEHGBBMDINI.PPKLNOHHLIH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE7A0", Offset = "0x5ECCFA0", VA = "0x185ECE7A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE760", Offset = "0x5ECCF60", VA = "0x185ECE760")]
		public PNDGMELJNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE6F0", Offset = "0x5ECCEF0", VA = "0x185ECE6F0", Slot = "14")]
		public override GEHGBBMDINI.PPKLNOHHLIH GetValue(GEHGBBMDINI.CCLKKANGBCP EFKPBKMFDOG)
		{
			return default(GEHGBBMDINI.PPKLNOHHLIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE720", Offset = "0x5ECCF20", VA = "0x185ECE720", Slot = "15")]
		public override void SetValue(GEHGBBMDINI.CCLKKANGBCP EFKPBKMFDOG, GEHGBBMDINI.PPKLNOHHLIH DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5EC73D0", Offset = "0x5EC5BD0", VA = "0x185EC73D0")]
	public COMHGOIAFCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
internal class PLEAADHPPCJ : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	private class KAHIKGFMFLD : Property<RRObjectPrefabV2Data, GNCNNCODHCF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string JOBPEPKBADK
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9390", Offset = "0x5EC7B90", VA = "0x185EC9390", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool POGMNPDPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9350", Offset = "0x5EC7B50", VA = "0x185EC9350")]
		public KAHIKGFMFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x12CE800", Offset = "0x12CD000", VA = "0x1812CE800", Slot = "14")]
		public override GNCNNCODHCF GetValue(RRObjectPrefabV2Data EFKPBKMFDOG)
		{
			return default(GNCNNCODHCF);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9340", Offset = "0x5EC7B40", VA = "0x185EC9340", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data EFKPBKMFDOG, GNCNNCODHCF DOLICEBFIPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE1F0", Offset = "0x5ECC9F0", VA = "0x185ECE1F0")]
	public PLEAADHPPCJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE860", Offset = "0x5ECD060", VA = "0x185ECE860")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000123")]
public class ADJKIDCLGDK
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ADJKIDCLGDK()
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

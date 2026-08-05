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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EMKIMDBPFPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode IDOBDFAEGHD;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FCDCEIPDNLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public ECMHEOBCCNJ BMIOPDPBBEO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly EHINJJAKHPP<FCDCEIPDNLI> IKMLLOOIGKE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BODLONCECIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GEEPPKKIDEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum ECMHEOBCCNJ
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
public struct DPBCLPBJFCP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct FFONFNGJPDF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity KGAHDFAFPLE;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JOBAICGJPLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity LPDGANJNOMK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NBEPOBONHCE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DCDOGDEOKDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity PHNFANHCONA;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OJDBNGOKNMF : KMGHKNHPEGG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KMDPNCANKMK IOLFAPGDCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KMDPNCANKMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NCCNKJBKGNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 NEIHEGNBFNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ADPHJBKGEME : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EFODGPKEEEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 FLGPPHOOBGE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EHINJJAKHPP<JDODOAMJNGM> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JDODOAMJNGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 FLGPPHOOBGE;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly EHINJJAKHPP<JDODOAMJNGM> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NBKPDLJEBGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 CHKIHGCNILH;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FJJNPEHKKCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 CIDLBOPNMFM;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BBHKIKMJKCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float CHMEOKKDFLI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EHINJJAKHPP<BBHKIKMJKCM> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OIEPOLDIGIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float DKINIKOLCGL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly EHINJJAKHPP<OIEPOLDIGIP> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KMFIIJCGDGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 BGABOHGMMJE;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PMCIPCJHCIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public KLJHGLPFOPI EPFHBFGFNKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BONBIMMHNOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public KLJHGLPFOPI PKJOFIOGPEK;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[IMFHLDEPPHL]
public struct HILHELGLCGM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity HHHGBIJCKBC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HDONFPFCBJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HEICGLOBMKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NAJGFBFKKGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DOCAPBIJBOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints AKPIKNNEDOD;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EFMFFPDDBIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float JNJCPCMFNDI;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly EHINJJAKHPP<EFMFFPDDBIF> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GJHICGJMBKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float JHJLCBLFJFP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct MCKFKGFOEIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CPILKLMPAFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int NFCEKIKIBGC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xBCA080", Offset = "0xBC8E80", VA = "0x180BCA080")]
	public static CPILKLMPAFM KFCNDMGKJHB(int POACLGOFKAJ)
	{
		return default(CPILKLMPAFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class BGDLIIBFOGB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody ANDHNALLMFE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D316A0", Offset = "0x5D304A0", VA = "0x185D316A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BGDLIIBFOGB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct FFNNPCGHCJD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NFEOGANHHDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 PCFFHDKFCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CDLINLJEPNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 JIJAOBLIPMH;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HDBGPALIAIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float CJCGOBADDML;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EHINJJAKHPP<HDBGPALIAIL> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GGPMIDGFDPB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object GKKOIDFKPNB;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D32960", Offset = "0x5D31760", VA = "0x185D32960", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GGPMIDGFDPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BAPLLMCLKHJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object EOHNNPFJNPK;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D31390", Offset = "0x5D30190", VA = "0x185D31390", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BAPLLMCLKHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum KLJHGLPFOPI
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NJDNLEIDKBA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IBIAPBPMOCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONMEFHAPCJC(ECMHEOBCCNJ FAGNKKLHAKO, ECMHEOBCCNJ MKIGNGOBIGF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOGDLKEAHPJ();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGBPKCHKANG();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCOAOEOCLOG(bool GEFNNEJLOOB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FCCAOLELCBJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMGACKJAGEK();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IKPMGNBADNH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public IBIAPBPMOCH KPFKMGJJBDJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D33650", Offset = "0x5D32450", VA = "0x185D33650", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IKPMGNBADNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LOPGJCBILPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(BBDHFKCDKMF nameHash, CLMBKIMNLOD stableTypeHash, Type type)> PDOOHHKEDGB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(BBDHFKCDKMF nameHash, CLMBKIMNLOD stableTypeHash, Type type)> LEJODLLBJNM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(BBDHFKCDKMF previousNameHash, CLMBKIMNLOD previousStableTypeHash, Type currentTypeName)> PNDFMBKGBHF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct OLCNCJCFPJK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, IPMLIMBHIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D31370", Offset = "0x5D30170", VA = "0x185D31370", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
[PEDKEDLAFMA]
public struct APKJEEPOAEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[LFOJAEPCNMI(1)]
	public quaternion IOMLNAOLLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[LFOJAEPCNMI(2)]
	public float3 BBEJKAIJGPI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly EHINJJAKHPP<APKJEEPOAEH> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3934AF0", Offset = "0x39338F0", VA = "0x183934AF0")]
	public APKJEEPOAEH(quaternion IOMLNAOLLNL, float3 BBEJKAIJGPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D312D0", Offset = "0x5D300D0", VA = "0x185D312D0")]
	public static APKJEEPOAEH KFCNDMGKJHB(RigidTransform AMPHGEMEFBO)
	{
		return default(APKJEEPOAEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MDFJGJGJGBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[PEDKEDLAFMA]
public struct LHBHLBPKJPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[LFOJAEPCNMI(1)]
	public float IAHLFMLLBJD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly EHINJJAKHPP<LHBHLBPKJPB> IKMLLOOIGKE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[PEDKEDLAFMA]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, IPMLIMBHIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[LFOJAEPCNMI(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D31380", Offset = "0x5D30180", VA = "0x185D31380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct KFEHODPCKJL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, IPMLIMBHIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FDFNCFFGCCC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct HOAJNLKDONE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[LFOJAEPCNMI(1)]
	public SerializableGuid CIANJEHDGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[LFOJAEPCNMI(2)]
	public SerializableGuid BELINILLNPN;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
[PEDKEDLAFMA]
public struct JPNNJNAPAML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[LFOJAEPCNMI(1)]
	public Entity ENPAPEKLELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[LFOJAEPCNMI(2)]
	public uint GHNGKOMPLDM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EntityBundlePartId DLHDDMHFIJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1C77C70", Offset = "0x1C76A70", VA = "0x181C77C70")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1C81570", Offset = "0x1C80370", VA = "0x181C81570")]
	public JPNNJNAPAML(Entity ENPAPEKLELL, EntityBundlePartId DCJAGKIKDGI)
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
		[Cpp2IlInjected.Address(RVA = "0x7D5350", Offset = "0x7D4150", VA = "0x1807D5350")]
		internal EntityBundlePartId(uint KKIIDNMAMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330")]
		internal uint PPPGLONKJKM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1643810", Offset = "0x1642610", VA = "0x181643810", Slot = "4")]
		public bool Equals(EntityBundlePartId LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D32510", Offset = "0x5D31310", VA = "0x185D32510", Slot = "0")]
		public override bool Equals(object DGPHOMINFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAF0", Offset = "0x7EE8F0", VA = "0x1807EFAF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1643830", Offset = "0x1642630", VA = "0x181643830")]
		public static bool PNFEPLLEJJK(EntityBundlePartId APOJANFJHJO, EntityBundlePartId DFBIFCHBAHF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct FPBIOJEEIND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity KJADJNMINCF;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct MBDFIJPBELP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity KJADJNMINCF;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[PEDKEDLAFMA]
[EEHCBAKIPNJ("Container", 0)]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
public struct MOMDAFKMLNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(1)]
	public CEKEAEGJOJK EDLEEIHJKHO;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly EHINJJAKHPP<MOMDAFKMLNP> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DNGEBOLJDNG(0, 127)]
public enum CEKEAEGJOJK
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
public static class OBIDDHBEFDO
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum BDBLKELBOCM
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
	public enum MCLLOIGAOFN
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
	[Cpp2IlInjected.Address(RVA = "0x5D382B0", Offset = "0x5D370B0", VA = "0x185D382B0")]
	public static (BDBLKELBOCM, MCLLOIGAOFN) NFIGEBGGDBA(this CEKEAEGJOJK EBJJLHAJJCM)
	{
		return default((BDBLKELBOCM, MCLLOIGAOFN));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[EEHCBAKIPNJ("Container", 0)]
public struct DKEIMJFADKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(1)]
	public OFOPJDAIGFF NGKIJLGBEBC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly EHINJJAKHPP<DKEIMJFADKA> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DNGEBOLJDNG(0, 2)]
public enum OFOPJDAIGFF
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
[PEDKEDLAFMA]
[EEHCBAKIPNJ("Container", 0)]
public struct BPEBBLFKHME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(1)]
	public ENIPDIKNDGJ INEMIPHENMH;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DNGEBOLJDNG(0, 15943)]
[Flags]
public enum ENIPDIKNDGJ
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
public struct JEPEDJBNHJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct JJJCCOOFGIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct IGFNCBGNKDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct AFGMOAIFHJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct AIHLMENGGKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct OLBLLCOJBLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct NCGOCIFKHPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct JHFFBKIPDBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KGPNPNEGOHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[EEHCBAKIPNJ("Container", 0)]
public struct PHJADBOAEIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	[LFOJAEPCNMI(1)]
	[FMEPFMNIKLJ(0)]
	public float PBAFEEAKDGB;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[EEHCBAKIPNJ("Container", 0)]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[PEDKEDLAFMA]
public struct CPAIHELAPJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[LFOJAEPCNMI(1)]
	[FMEPFMNIKLJ(0)]
	public FixedString64Bytes MEBBBIMBIJO;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct NJHLOPMHPJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private NativeList<JOPOMJOPFBA> FDDNGNHADLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<Entity> BKNJENIJOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private JobHandle GIFCONDMHLL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NKLAIHGEKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5D38060", Offset = "0x5D36E60", VA = "0x185D38060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D38010", Offset = "0x5D36E10", VA = "0x185D38010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42A68A0", Offset = "0x42A56A0", VA = "0x1842A68A0")]
	public NJHLOPMHPJF(NativeList<JOPOMJOPFBA> FDDNGNHADLG, NativeList<Entity> BKNJENIJOJI, JobHandle GIFCONDMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D380D0", Offset = "0x5D36ED0", VA = "0x185D380D0")]
	public (Entity, NativeSlice<Entity>) PFHBMPOKAGM(int NAKKFLBPDCC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D37FB0", Offset = "0x5D36DB0", VA = "0x185D37FB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct JOPOMJOPFBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity PHNFANHCONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int NNACFOFLCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int JGMNJBPPKGP;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface MBFKJGGINKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJBGOKCOCFB(bool JIEFCKEOLMC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[EEHCBAKIPNJ("Container", 0)]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[PEDKEDLAFMA]
public struct INLIEFJIPLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[LFOJAEPCNMI(1)]
	[FMEPFMNIKLJ(0)]
	public PLENLMKDNJC JCGHONMJOMH;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DNGEBOLJDNG(0, 1)]
public enum PLENLMKDNJC
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
[EJGCMAFBLNE(1)]
public struct GLGCLMKBLKL : IComparable<GLGCLMKBLKL>, IEquatable<GLGCLMKBLKL>, EGKFDGGDBHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[JMOPPIDHHHN(1)]
	public uint EPGKCHPFJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[JMOPPIDHHHN(2)]
	public uint OPCKMEBGOLN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private uint LJGPLGFEIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D32C00", Offset = "0x5D31A00", VA = "0x185D32C00")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D33050", Offset = "0x5D31E50", VA = "0x185D33050")]
	public GLGCLMKBLKL(int EPGKCHPFJFC, int COOGGCKOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D33050", Offset = "0x5D31E50", VA = "0x185D33050")]
	public GLGCLMKBLKL(uint EPGKCHPFJFC, uint COOGGCKOEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D32CE0", Offset = "0x5D31AE0", VA = "0x185D32CE0")]
	public GLGCLMKBLKL GHKBDIHPOMI(int NNACFOFLCKF = 1)
	{
		return default(GLGCLMKBLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D32D50", Offset = "0x5D31B50", VA = "0x185D32D50")]
	public GLGCLMKBLKL GOMENKLGLEC(int NNACFOFLCKF = 1)
	{
		return default(GLGCLMKBLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D32EF0", Offset = "0x5D31CF0", VA = "0x185D32EF0")]
	public static GLGCLMKBLKL PODCJEOEOEG(GLGCLMKBLKL NLBDNIEIKMB, GLGCLMKBLKL NFFCMKPCJPP)
	{
		return default(GLGCLMKBLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D32BD0", Offset = "0x5D319D0", VA = "0x185D32BD0")]
	private static uint BAOFEKEJBEO(uint APOJANFJHJO, uint DFBIFCHBAHF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D32C10", Offset = "0x5D31A10", VA = "0x185D32C10", Slot = "4")]
	public int CompareTo(GLGCLMKBLKL LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D32C30", Offset = "0x5D31A30", VA = "0x185D32C30", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D32F70", Offset = "0x5D31D70", VA = "0x185D32F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D32CC0", Offset = "0x5D31AC0", VA = "0x185D32CC0", Slot = "5")]
	public bool Equals(GLGCLMKBLKL LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D32DC0", Offset = "0x5D31BC0", VA = "0x185D32DC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D32E10", Offset = "0x5D31C10", VA = "0x185D32E10", Slot = "6")]
	public void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D32E80", Offset = "0x5D31C80", VA = "0x185D32E80", Slot = "7")]
	public void NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x221DAB0", Offset = "0x221C8B0", VA = "0x18221DAB0")]
	public static bool PNFEPLLEJJK(GLGCLMKBLKL NLBDNIEIKMB, GLGCLMKBLKL NFFCMKPCJPP)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[EJGCMAFBLNE(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[JMOPPIDHHHN(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[JMOPPIDHHHN(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[JMOPPIDHHHN(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[JMOPPIDHHHN(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[EJGCMAFBLNE(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, EGKFDGGDBHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[JMOPPIDHHHN(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public static SerializableGuid KFCNDMGKJHB(Guid EIODILKIKCN)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D39900", Offset = "0x5D38700", VA = "0x185D39900", Slot = "4")]
		public bool Equals(SerializableGuid LKMMHIOOCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5D398E0", Offset = "0x5D386E0", VA = "0x185D398E0", Slot = "5")]
		public int CompareTo(SerializableGuid LKMMHIOOCMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5D39930", Offset = "0x5D38730", VA = "0x185D39930", Slot = "6")]
		public void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D399F0", Offset = "0x5D387F0", VA = "0x185D399F0", Slot = "7")]
		public void NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D39A70", Offset = "0x5D38870", VA = "0x185D39A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct DFILKBOMIIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
[PEDKEDLAFMA]
public struct JCAPGKNHAAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[LFOJAEPCNMI(1)]
	public Entity PABBJIBBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[LFOJAEPCNMI(2)]
	public bool DMBNEPGGNAL;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
[PEDKEDLAFMA]
public struct PLJEAOHKJFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[LFOJAEPCNMI(1)]
	public CJHIJPGGEAF JIEMKJHDHAG;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DNGEBOLJDNG(0, 4)]
public enum CJHIJPGGEAF
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
[PEDKEDLAFMA]
public struct ECELMEIHLPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[LFOJAEPCNMI(1)]
	public Entity PABBJIBBIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[LFOJAEPCNMI(2)]
	public bool PDJOKOKAHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[LFOJAEPCNMI(3)]
	public float NBJAKALPEBB;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
[PEDKEDLAFMA]
public struct FMLDANKNPAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[LFOJAEPCNMI(1)]
	public bool EFMDODKKOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[LFOJAEPCNMI(2)]
	public bool PDJOKOKAHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[LFOJAEPCNMI(3)]
	public float NEOFCPOBGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[LFOJAEPCNMI(4)]
	public float OAPEGBFADLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[LFOJAEPCNMI(5)]
	public float PDNOBEJABKG;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[PEDKEDLAFMA]
public struct PBJGKJIAMPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[LFOJAEPCNMI(1)]
	public bool EFMDODKKOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[LFOJAEPCNMI(2)]
	public bool PDJOKOKAHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[LFOJAEPCNMI(3)]
	public float NBJAKALPEBB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, IPMLIMBHIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D31370", Offset = "0x5D30170", VA = "0x185D31370", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[PEDKEDLAFMA]
	public struct ParentData : IComponentData, IPMLIMBHIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[LFOJAEPCNMI(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, IPMLIMBHIHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct ELEBGMBHELL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface IPMLIMBHIHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity KHNJMAEDDIC
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
public struct JGPEHHABMJH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly bool ELICBKNLKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public uint KOOCPFNFEKK;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	private static bool DJHJOOGFAGI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[EEHCBAKIPNJ("Light", 0)]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct IMHPKMGFKKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[LFOJAEPCNMI(1)]
	[FMEPFMNIKLJ(0)]
	public bool FCMINLNDGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(2)]
	public float ALGHILKCEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[LFOJAEPCNMI(3)]
	[FMEPFMNIKLJ(0)]
	public float NFGCMBPOMHF;
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[EEHCBAKIPNJ("Light", 0)]
public struct IMJNMKNHBAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(1)]
	public float MCGEJFABPJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.TypeVersion(2)]
public struct HFLMCEGCJME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public uint DLGBKDOILKG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D33260", Offset = "0x5D32060", VA = "0x185D33260", Slot = "3")]
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
	[PEDKEDLAFMA]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[JMOPPIDHHHN(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct HEBJDKCKFEA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int IOPJNMNEAKH;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct IFBFLGEFADP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public GCHandle POHCHKPHHMD;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DNGEBOLJDNG(0, 4)]
public enum PIKKNCEMNGF
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
public struct PCJKNKEOLIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct EAHHFKOHJGF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public int IOPJNMNEAKH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct JDEKDBCBIHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct GKAKHHIFBFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FBDODGCKIDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.TypeVersion(3)]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[PEDKEDLAFMA]
[EEHCBAKIPNJ("Object", 0)]
public struct NDMPDKHIOLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[LFOJAEPCNMI(2)]
	public JAJOAIJCJNA AGCMCFFDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[LFOJAEPCNMI(3)]
	[FMEPFMNIKLJ(0)]
	public HBPJKAFHAGH BIOHJLGHJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[LFOJAEPCNMI(4)]
	[FMEPFMNIKLJ(0)]
	public BPLBHOPELNG BEEKFGAMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[JMOPPIDHHHN(5)]
	public INLNPLELDND INEMIPHENMH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public static readonly EHINJJAKHPP<NDMPDKHIOLE> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class EEBMCDEGGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D320F0", Offset = "0x5D30EF0", VA = "0x185D320F0")]
	public static void MFACMGCFCOL(this INLNPLELDND INEMIPHENMH, PAFCGKHNOCP KIEALJPLHJJ, bool FHMOAAILLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D320A0", Offset = "0x5D30EA0", VA = "0x185D320A0")]
	public static bool DCGAHAEBMEF(this INLNPLELDND INEMIPHENMH, PAFCGKHNOCP KIEALJPLHJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D320C0", Offset = "0x5D30EC0", VA = "0x185D320C0")]
	public static INLNPLELDND EOPCPGKINMM(this PAFCGKHNOCP KIEALJPLHJJ)
	{
		return default(INLNPLELDND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D320D0", Offset = "0x5D30ED0", VA = "0x185D320D0")]
	public static void MFACMGCFCOL(this HBPJKAFHAGH INEMIPHENMH, HBPJKAFHAGH OIPHPKKDAIF, bool FHMOAAILLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5C66710", Offset = "0x5C65510", VA = "0x185C66710")]
	public static bool DCGAHAEBMEF(this HBPJKAFHAGH INEMIPHENMH, HBPJKAFHAGH KIEALJPLHJJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public enum PAFCGKHNOCP
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
[DNGEBOLJDNG(0, 16383)]
[Flags]
public enum INLNPLELDND
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
[DNGEBOLJDNG(0, 3)]
public enum HBPJKAFHAGH
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
[DNGEBOLJDNG(0, 4)]
[BFPFAMCHBLE]
public enum BPLBHOPELNG
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
public class BFPFAMCHBLE : GONMAILKGKG
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D315D0", Offset = "0x5D303D0", VA = "0x185D315D0", Slot = "7")]
	public override string DENFBJJPHJF(string JLNEIALFDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BFPFAMCHBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[EJGCMAFBLNE(1)]
public struct JAJOAIJCJNA : EGKFDGGDBHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[JMOPPIDHHHN(1)]
	public bool FCMINLNDGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[JMOPPIDHHHN(2)]
	public float3 JLODNPLPDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[JMOPPIDHHHN(3)]
	public float3 OMBJHIDODNJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly EHINJJAKHPP<JAJOAIJCJNA> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D33730", Offset = "0x5D32530", VA = "0x185D33730", Slot = "5")]
	public void NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5D336E0", Offset = "0x5D324E0", VA = "0x185D336E0", Slot = "4")]
	public void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct ACDBOCDHNEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct JMAAHCDBCIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct POMDAOBHJKP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct PNFIFOBIHKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public FixedString32Bytes MEBBBIMBIJO;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[IMFHLDEPPHL]
public struct HLFEGAAIHGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Entity GJBLGBOBAMI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static HLFEGAAIHGN KFCNDMGKJHB(Entity POACLGOFKAJ)
	{
		return default(HLFEGAAIHGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct PJFMDLFDEJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[LFOJAEPCNMI(1)]
	public Entity DDOHLMCLCKK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static PJFMDLFDEJA KFCNDMGKJHB(Entity HHHGBIJCKBC)
	{
		return default(PJFMDLFDEJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct BNCEKKNHINK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Entity HHHGBIJCKBC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static BNCEKKNHINK KFCNDMGKJHB(Entity HHHGBIJCKBC)
	{
		return default(BNCEKKNHINK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct GMKFPIPPFDP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Entity PLOCKODCAJK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static GMKFPIPPFDP KFCNDMGKJHB(Entity HHHGBIJCKBC)
	{
		return default(GMKFPIPPFDP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct GMFOIAHHDJC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[DNGEBOLJDNG(0, 2)]
public enum LBJDABLGGNK
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
[EEHCBAKIPNJ("Physics", 0)]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct EIPOINIIFNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[LFOJAEPCNMI(1)]
	[FMEPFMNIKLJ(0)]
	public float NJLEMPHPMLK;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public static readonly EHINJJAKHPP<EIPOINIIFNE> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
[PEDKEDLAFMA]
public struct FINJEIJKLHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[LFOJAEPCNMI(1)]
	public JFBOGCJIFLL PDMBCHLIAMH;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DNGEBOLJDNG(-1, 38)]
public enum JFBOGCJIFLL
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
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct GIPDDIDFAIG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Flags]
	[DNGEBOLJDNG(0, 7)]
	public enum EKKPPBOJHDG
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
	[LFOJAEPCNMI(1)]
	public EKKPPBOJHDG INEMIPHENMH;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public static readonly EHINJJAKHPP<GIPDDIDFAIG> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool GMMJGOEMKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D32B00", Offset = "0x5D31900", VA = "0x185D32B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool EADOOIBDGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D32B10", Offset = "0x5D31910", VA = "0x185D32B10")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
[PEDKEDLAFMA]
public struct FJGJHANDECO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[LFOJAEPCNMI(1)]
	public LBJDABLGGNK PDMBCHLIAMH;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct BJPHEDCKDGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public uint FBJEHMGCPKI;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[EJGCMAFBLNE(1)]
public struct LCDOAOMGIMC : EGKFDGGDBHJ
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[Flags]
	[DNGEBOLJDNG(0, 7)]
	public enum CEBOEDPIEHO
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
	[JMOPPIDHHHN(1)]
	public float MHIMMLJEFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[JMOPPIDHHHN(2)]
	public int FCECMLIMAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[JMOPPIDHHHN(3)]
	public CEBOEDPIEHO INEMIPHENMH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool NGOFEMJDPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5D34220", Offset = "0x5D33020", VA = "0x185D34220")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D341E0", Offset = "0x5D32FE0", VA = "0x185D341E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NMGGFJDMKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D341A0", Offset = "0x5D32FA0", VA = "0x185D341A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5D341C0", Offset = "0x5D32FC0", VA = "0x185D341C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LEHHJGMOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D341B0", Offset = "0x5D32FB0", VA = "0x185D341B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5D34200", Offset = "0x5D33000", VA = "0x185D34200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D34290", Offset = "0x5D33090", VA = "0x185D34290", Slot = "5")]
	public void NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D34230", Offset = "0x5D33030", VA = "0x185D34230", Slot = "4")]
	public void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[IMFHLDEPPHL]
internal struct GFAMIIBKJBJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Entity DJGHIGBIJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public int OCMJNDDMDAL;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct OPJBGANEPIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[LFOJAEPCNMI(1)]
	public GLGCLMKBLKL NDNHDKGPLFG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static OPJBGANEPIB KFCNDMGKJHB(GLGCLMKBLKL POACLGOFKAJ)
	{
		return default(OPJBGANEPIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct MDLBCMGPBBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[LFOJAEPCNMI(1)]
	public Entity DNGAALMGOEC;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal struct GBHFKGKBLOK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Entity DNGAALMGOEC;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct LNMINBHKCKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[LFOJAEPCNMI(1)]
	public float3 BBEJKAIJGPI;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public static readonly EHINJJAKHPP<LNMINBHKCKD> IKMLLOOIGKE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1F50DC0", Offset = "0x1F4FBC0", VA = "0x181F50DC0")]
	public static LNMINBHKCKD KFCNDMGKJHB(float3 POACLGOFKAJ)
	{
		return default(LNMINBHKCKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct COFPHJFJKHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[LFOJAEPCNMI(1)]
	public quaternion IOMLNAOLLNL;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public static readonly EHINJJAKHPP<COFPHJFJKHO> IKMLLOOIGKE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
	public static COFPHJFJKHO KFCNDMGKJHB(quaternion POACLGOFKAJ)
	{
		return default(COFPHJFJKHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct OKDPLEMLFKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[LFOJAEPCNMI(1)]
	public float3 PIIOFNMPMNI;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static readonly EHINJJAKHPP<OKDPLEMLFKK> IKMLLOOIGKE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1F50DC0", Offset = "0x1F4FBC0", VA = "0x181F50DC0")]
	public static OKDPLEMLFKK KFCNDMGKJHB(float3 POACLGOFKAJ)
	{
		return default(OKDPLEMLFKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct FHFFBJLOOCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[LFOJAEPCNMI(1)]
	public LCDOAOMGIMC APKDPMMLKGB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct FIPPHKOLPIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct HNEIOIKHEOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public uint KOOCPFNFEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public int HCLADMEDPLI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x97A610", Offset = "0x979410", VA = "0x18097A610")]
	public HNEIOIKHEOK(uint IIKCOPGMCJN, int AMKGEBHBFOL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct MHFPEDDKDMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct CFBECMJAMGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct BGFKKPJJJNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct MHMHLPOCOJN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct GGPPONHDMKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct MFHBFLHPAHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct NELFACHFGKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct CFAIBJGEMEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal struct DGCPDOCOJJF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct NBJFNCDECDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal struct HHNFIGHOCDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct CFBEAJMMJEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal struct GEEBODJKMGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct IACPEHCLAJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct IKLOJLKPJIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct OACFAECLOFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[LFOJAEPCNMI(1)]
	public FixedList32Bytes<int> JOEMCHLNLOG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct BLOLFPJALJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct PCJEAOKKKBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct AABDLGDALFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct ADMAOKOODMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct FNPJKCHMCFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct HJJJIHEKAEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct LHDGIGDCPAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[IMFHLDEPPHL]
public struct CFAOHGDIBKD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public FixedString32Bytes MJKABCAIEKE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal struct GDNEFMPGNJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal struct FFAHEDCFFNJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
[PEDKEDLAFMA]
public struct BFIEMGAENHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[JMOPPIDHHHN(1)]
	public HFNPLAKMHJA FBJEHMGCPKI;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly EHINJJAKHPP<BFIEMGAENHM> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum HFNPLAKMHJA : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct PLGFCBNINGG : IComponentData, IComparable<PLGFCBNINGG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public int AFAFJIEJAIF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1651BA0", Offset = "0x16509A0", VA = "0x181651BA0", Slot = "4")]
	public int CompareTo(PLGFCBNINGG LKMMHIOOCMN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[PEDKEDLAFMA]
public struct LIELCEKBGND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[LFOJAEPCNMI(2)]
	public bool GAOEPKHMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[LFOJAEPCNMI(3)]
	public bool OJPAGCNBBKO;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly EHINJJAKHPP<LIELCEKBGND> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct GEJNAHHBBIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[LFOJAEPCNMI(1)]
	public bool IOAGIBJCGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[LFOJAEPCNMI(2)]
	public byte BELBPNDNFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[LFOJAEPCNMI(3)]
	public short PAOOMOLHACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[LFOJAEPCNMI(4)]
	public ushort HIIEMFKHDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[LFOJAEPCNMI(5)]
	public int FAOGKAPBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[LFOJAEPCNMI(6)]
	public uint IDEGIAOEJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[LFOJAEPCNMI(7)]
	public long NFHLGACFKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[LFOJAEPCNMI(8)]
	public ulong EOPPJFNOHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[LFOJAEPCNMI(9)]
	public float IABPLADEMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[LFOJAEPCNMI(10)]
	public double JMAACBIONGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[LFOJAEPCNMI(11)]
	public JPPLGKHPNGF LIIMGBDLIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[LFOJAEPCNMI(12)]
	public FAFMNONACPE KJDMOIALIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[LFOJAEPCNMI(13)]
	public PHHPCCEKEDE LAGLAGJJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[LFOJAEPCNMI(14)]
	public EMNAKLHANBO AKJIBDHEGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[LFOJAEPCNMI(15)]
	public OIHONLIFLAK EIGPDLPKLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[LFOJAEPCNMI(16)]
	public IPHCHPDDPFJ MIBHAJEBLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[LFOJAEPCNMI(17)]
	public FPCCPHEDAHD EMABKJMGNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[LFOJAEPCNMI(18)]
	public IHGOKLNDKAG MCJMMJPKIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[LFOJAEPCNMI(20)]
	public Quaternion ALMICHJCECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[LFOJAEPCNMI(22)]
	public Vector3 JJFPFHEJDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[LFOJAEPCNMI(23)]
	public Vector4 FHNCPLNMHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[LFOJAEPCNMI(40)]
	public Entity LHEPFDJLMFK;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum JPPLGKHPNGF : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum FAFMNONACPE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public enum PHHPCCEKEDE : short
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public enum EMNAKLHANBO : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public enum OIHONLIFLAK
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public enum IPHCHPDDPFJ : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum FPCCPHEDAHD : long
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public enum IHGOKLNDKAG : ulong
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
	[PEDKEDLAFMA]
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
	[PEDKEDLAFMA]
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
public class MJDBMMDCKLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public int HGPPIPGOKCB;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public int FCAEKAGLBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public GameObject LEMKPNELLPI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MJDBMMDCKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public class EMHLIKNFPFE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public struct ACLBGAACHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public Vector3 GCJPDGIGCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public List<SerializableGuid> PGCKKCCJKDK;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class PJGHGIGEDCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public ACLBGAACHHO PKHGMLELNIB;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PJGHGIGEDCF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public SerializableGuid BPMBGCCCAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<int> FCHLOIHFOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<ACLBGAACHHO> NBPDCNADHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public List<PJGHGIGEDCF> CCGLGAMGEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public GameObject LEMKPNELLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Light JCIPPADENKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Collider DOMPEOMIALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public string DJOHBEPEHGJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public EMHLIKNFPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[PEDKEDLAFMA]
public struct EHOKBACLKBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[LFOJAEPCNMI(1)]
	public float3 JGILIIIIHIH;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public static readonly EHINJJAKHPP<EHOKBACLKBI> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
[PEDKEDLAFMA]
public struct LMOBHKOOHGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[LFOJAEPCNMI(1)]
	public quaternion IOMLNAOLLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[LFOJAEPCNMI(2)]
	public float3 BBEJKAIJGPI;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public static readonly EHINJJAKHPP<LMOBHKOOHGM> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3934AF0", Offset = "0x39338F0", VA = "0x183934AF0")]
	public LMOBHKOOHGM(quaternion IOMLNAOLLNL, float3 BBEJKAIJGPI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D312D0", Offset = "0x5D300D0", VA = "0x185D312D0")]
	public static RigidTransform KFCNDMGKJHB(LMOBHKOOHGM KKIDBJDDGAI)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D312D0", Offset = "0x5D300D0", VA = "0x185D312D0")]
	public static LMOBHKOOHGM KFCNDMGKJHB(RigidTransform AMPHGEMEFBO)
	{
		return default(LMOBHKOOHGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class MMNNEMGOKGG
{
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public struct FMBCLJELFDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public float4x4 DOKNCLGLGJG;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public static readonly EHINJJAKHPP<FMBCLJELFDP> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct JNGNBCKOIMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public float4x4 PENILBCOAKC;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static readonly EHINJJAKHPP<JNGNBCKOIMO> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
[PEDKEDLAFMA]
public struct GKEHOBJBFLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	[LFOJAEPCNMI(1)]
	public float IAHLFMLLBJD;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public static readonly EHINJJAKHPP<GKEHOBJBFLL> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public struct BMKEBCADHBB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int ODAIOEGANPG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int OCMJNDDMDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D317E0", Offset = "0x5D305E0", VA = "0x185D317E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D317D0", Offset = "0x5D305D0", VA = "0x185D317D0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
[PEDKEDLAFMA]
public struct IGKPGAKJBMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	[LFOJAEPCNMI(1)]
	public CLDCKBNNCCE JHOPBNJIHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	[LFOJAEPCNMI(2)]
	public EFADCLNNHJK GMLLHMELIAJ;
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[DNGEBOLJDNG(0, 1)]
[Flags]
public enum CLDCKBNNCCE
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
[DNGEBOLJDNG(-2, 2)]
public enum EFADCLNNHJK
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
public struct PEEBINOFCDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public float3 NLFPLEECKBG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly EHINJJAKHPP<PEEBINOFCDG> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct FDAMELIEKPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public float3 CMKBDFOJBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public quaternion ALADLBOMNEP;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static readonly EHINJJAKHPP<FDAMELIEKPC> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class CAKIMFAHIOA
{
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct NAEDGOKFECF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public float LCPOAECAOOH;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static readonly EHINJJAKHPP<NAEDGOKFECF> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[DNGEBOLJDNG(1000, 8000)]
public enum GPKGCNFDJCC
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
public static class DMPBMPNIPCH
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal enum PDDHGHBIIFP
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
internal static class EBDINEFNLGF
{
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[DNGEBOLJDNG(0, 9)]
public enum NLAGBABKJIG
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
public static class CBFCNPOEMPI
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5D317F0", Offset = "0x5D305F0", VA = "0x185D317F0")]
	public static bool GAHCMKJNJBF(this NLAGBABKJIG OMJKELCDIKA)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[PEDKEDLAFMA]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public GPKGCNFDJCC prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class IPIJFMOIFKE
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5D336C0", Offset = "0x5D324C0", VA = "0x185D336C0")]
	public static NLAGBABKJIG MONPKLCDBGM(this GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(NLAGBABKJIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[DNGEBOLJDNG(int.MinValue, int.MaxValue)]
public enum GIIHDPGBKAM
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
[DNGEBOLJDNG(-1, 31)]
public enum GAMFDPNEANF
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
[EEHCBAKIPNJ("Visual", 0)]
[PEDKEDLAFMA]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
public struct DCJKMFLGMJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(1)]
	public GIIHDPGBKAM CEPDKAIKDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	[LFOJAEPCNMI(2)]
	[FMEPFMNIKLJ(0)]
	public GAMFDPNEANF PMPKGHHPFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(3)]
	public float NCDIDBGNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(4)]
	public Vector3 AEDHFFIAAJC;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
[EEHCBAKIPNJ("Container", 0)]
[OPOLAFFJHJM(2613756846563002039uL, 6372660366488563574uL)]
[CICNFJOMBAG]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
public struct AOMELIOCLEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	[LFOJAEPCNMI(1)]
	[FMEPFMNIKLJ(0)]
	public HFGNPBHHAEH BBKHLHOPJAC;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[DNGEBOLJDNG(0, 15)]
[Flags]
public enum HFGNPBHHAEH
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
[CICNFJOMBAG]
[OPOLAFFJHJM(9804513251708000208uL, 10903582988135044631uL)]
public struct MBDNOENDJEK : IComponentData, IEquatable<MBDNOENDJEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[LFOJAEPCNMI(1)]
	public FixedString64Bytes MEBBBIMBIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[LFOJAEPCNMI(2)]
	public OFOPJDAIGFF NGKIJLGBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	[LFOJAEPCNMI(3)]
	public HFGNPBHHAEH BBKHLHOPJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	[LFOJAEPCNMI(4)]
	public PLENLMKDNJC JCGHONMJOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	[LFOJAEPCNMI(5)]
	public ENIPDIKNDGJ INEMIPHENMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	[LFOJAEPCNMI(6)]
	public float PBAFEEAKDGB;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5D37B40", Offset = "0x5D36940", VA = "0x185D37B40", Slot = "4")]
	public bool Equals(MBDNOENDJEK LKMMHIOOCMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[CICNFJOMBAG]
[OPOLAFFJHJM(1213445203937950283uL, 119653618660684511uL)]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct DKABNPJJBNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	[LFOJAEPCNMI(1)]
	public BFCOEMJLBME NPPOKCIFNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public GCHandle BBDPDFCKIOF;
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[EJGCMAFBLNE(1)]
public struct BFCOEMJLBME : EGKFDGGDBHJ, IEquatable<BFCOEMJLBME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	[JMOPPIDHHHN(1)]
	public int KKIIDNMAMKF;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5D314E0", Offset = "0x5D302E0", VA = "0x185D314E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D31460", Offset = "0x5D30260", VA = "0x185D31460", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1643810", Offset = "0x1642610", VA = "0x181643810", Slot = "6")]
	public bool Equals(BFCOEMJLBME LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1651C30", Offset = "0x1650A30", VA = "0x181651C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D31550", Offset = "0x5D30350", VA = "0x185D31550", Slot = "5")]
	public void NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D31540", Offset = "0x5D30340", VA = "0x185D31540", Slot = "4")]
	public void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[CICNFJOMBAG]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[OPOLAFFJHJM(218523523639012570uL, 15191719635551116065uL)]
public struct LBAODPCFNBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private uint GCEDJPKHIGK;
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[OPOLAFFJHJM(9898405628982320166uL, 2023375009558162791uL)]
[CICNFJOMBAG]
public struct MMJCBEIAILP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	[LFOJAEPCNMI(1)]
	public INLNPLELDND INEMIPHENMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[LFOJAEPCNMI(2)]
	public JAJOAIJCJNA AGCMCFFDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(3)]
	public bool EPFCMGMAJCL;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly EHINJJAKHPP<MMJCBEIAILP> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
[CICNFJOMBAG]
[OPOLAFFJHJM(9807788745867066359uL, 15168486114979071194uL)]
public struct DBJNHIIMIFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[LFOJAEPCNMI(1)]
	public INLNPLELDND INEMIPHENMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[LFOJAEPCNMI(2)]
	public JAJOAIJCJNA AGCMCFFDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[FMEPFMNIKLJ(0)]
	[LFOJAEPCNMI(3)]
	public bool EPFCMGMAJCL;

	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public static readonly EHINJJAKHPP<DBJNHIIMIFI> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[CICNFJOMBAG]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[OPOLAFFJHJM(4470189027631723570uL, 5922380073816386711uL)]
public struct POHPIAKBMGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[JMOPPIDHHHN(1)]
	public INLNPLELDND INEMIPHENMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[LFOJAEPCNMI(2)]
	public JAJOAIJCJNA AGCMCFFDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[LFOJAEPCNMI(3)]
	[FMEPFMNIKLJ(0)]
	public HBPJKAFHAGH BIOHJLGHJGB;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly EHINJJAKHPP<POHPIAKBMGL> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[OPOLAFFJHJM(12226092714547765037uL, 15970362445488810630uL)]
[CICNFJOMBAG]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct CHAHCFOICGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[LFOJAEPCNMI(2)]
	public JAJOAIJCJNA AGCMCFFDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[LFOJAEPCNMI(3)]
	[FMEPFMNIKLJ(0)]
	public HBPJKAFHAGH BIOHJLGHJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[JMOPPIDHHHN(4)]
	public INLNPLELDND INEMIPHENMH;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly EHINJJAKHPP<CHAHCFOICGN> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[CICNFJOMBAG]
[OPOLAFFJHJM(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct OCADONEBDKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public int BCDOOKJBMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[LFOJAEPCNMI(2)]
	public bool GAOEPKHMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	[LFOJAEPCNMI(3)]
	public bool OJPAGCNBBKO;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly EHINJJAKHPP<OCADONEBDKH> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[CICNFJOMBAG]
[OPOLAFFJHJM(5861057081882613294uL, 13746475565109640919uL)]
public struct NMOCOPINMMJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[DNGEBOLJDNG(0, 1)]
	public enum CLKFHKAEPDJ
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
	[LFOJAEPCNMI(1)]
	public CLKFHKAEPDJ FNEILKKEDGI;
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[CICNFJOMBAG]
[OPOLAFFJHJM(14327281633525910712uL, 2559857777606771911uL)]
public struct HPKHIAPFDOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	[LFOJAEPCNMI(1)]
	public GPKGCNFDJCC LEGGGLNIAOM;
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[OPOLAFFJHJM(15725208981563603541uL, 17017036095303668770uL)]
[CICNFJOMBAG]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
public struct NBGIAMMLLME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[LFOJAEPCNMI(1)]
	public GPKGCNFDJCC LEGGGLNIAOM;
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[OPOLAFFJHJM(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[CICNFJOMBAG]
public struct AFNGAGHNBNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public NLAGBABKJIG OMJKELCDIKA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[CICNFJOMBAG]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[OPOLAFFJHJM(17667479821163689808uL, 11946378475791123970uL)]
public struct CPBHHEEJHDC : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : MCMFKIKAHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D39A80", Offset = "0x5D38880", VA = "0x185D39A80", Slot = "4")]
		public sealed override void MJDOOMDPGLF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal class DEPGHHPIAFG : ContainerPropertyBag<BGDLIIBFOGB>
{
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class JJKGAILGOLM : Property<BGDLIIBFOGB, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x5D33A60", Offset = "0x5D32860", VA = "0x185D33A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D33A20", Offset = "0x5D32820", VA = "0x185D33A20")]
		public JJKGAILGOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D30D90", Offset = "0x5D2FB90", VA = "0x185D30D90", Slot = "14")]
		public override Rigidbody GetValue(BGDLIIBFOGB LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DB0", Offset = "0x5D2FBB0", VA = "0x185D30DB0", Slot = "15")]
		public override void SetValue(BGDLIIBFOGB LAJBGPNDGLJ, Rigidbody POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D31EE0", Offset = "0x5D30CE0", VA = "0x185D31EE0")]
	public DEPGHHPIAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class OCHELLDKLHA : ContainerPropertyBag<GGPMIDGFDPB>
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class AFHNAKBMKAB : Property<GGPMIDGFDPB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5D30E20", Offset = "0x5D2FC20", VA = "0x185D30E20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DE0", Offset = "0x5D2FBE0", VA = "0x185D30DE0")]
		public AFHNAKBMKAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D30D90", Offset = "0x5D2FB90", VA = "0x185D30D90", Slot = "14")]
		public override object GetValue(GGPMIDGFDPB LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DB0", Offset = "0x5D2FBB0", VA = "0x185D30DB0", Slot = "15")]
		public override void SetValue(GGPMIDGFDPB LAJBGPNDGLJ, object POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D38500", Offset = "0x5D37300", VA = "0x185D38500")]
	public OCHELLDKLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal class KKAICKEEEKN : ContainerPropertyBag<BAPLLMCLKHJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class OCFFDEPNHCK : Property<BAPLLMCLKHJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5D384D0", Offset = "0x5D372D0", VA = "0x185D384D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D38490", Offset = "0x5D37290", VA = "0x185D38490")]
		public OCFFDEPNHCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D30D90", Offset = "0x5D2FB90", VA = "0x185D30D90", Slot = "14")]
		public override object GetValue(BAPLLMCLKHJ LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DB0", Offset = "0x5D2FBB0", VA = "0x185D30DB0", Slot = "15")]
		public override void SetValue(BAPLLMCLKHJ LAJBGPNDGLJ, object POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D33E90", Offset = "0x5D32C90", VA = "0x185D33E90")]
	public KKAICKEEEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
internal class CDANOPAOBAL : ContainerPropertyBag<IKPMGNBADNH>
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class FDADDLEMFKG : Property<IKPMGNBADNH, IBIAPBPMOCH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5D326F0", Offset = "0x5D314F0", VA = "0x185D326F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D326B0", Offset = "0x5D314B0", VA = "0x185D326B0")]
		public FDADDLEMFKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D30D90", Offset = "0x5D2FB90", VA = "0x185D30D90", Slot = "14")]
		public override IBIAPBPMOCH GetValue(IKPMGNBADNH LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DB0", Offset = "0x5D2FBB0", VA = "0x185D30DB0", Slot = "15")]
		public override void SetValue(IKPMGNBADNH LAJBGPNDGLJ, IBIAPBPMOCH POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D31800", Offset = "0x5D30600", VA = "0x185D31800")]
	public CDANOPAOBAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class KLGDIMDEOGA : ContainerPropertyBag<MJDBMMDCKLH>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class OELHKGAFMAJ : Property<MJDBMMDCKLH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5D38790", Offset = "0x5D37590", VA = "0x185D38790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D38750", Offset = "0x5D37550", VA = "0x185D38750")]
		public OELHKGAFMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D38710", Offset = "0x5D37510", VA = "0x185D38710", Slot = "14")]
		public override int GetValue(MJDBMMDCKLH LAJBGPNDGLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D38730", Offset = "0x5D37530", VA = "0x185D38730", Slot = "15")]
		public override void SetValue(MJDBMMDCKLH LAJBGPNDGLJ, int POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	private class DDLGHIJNDFK : Property<MJDBMMDCKLH, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x5D31EB0", Offset = "0x5D30CB0", VA = "0x185D31EB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D31E70", Offset = "0x5D30C70", VA = "0x185D31E70")]
		public DDLGHIJNDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D31E30", Offset = "0x5D30C30", VA = "0x185D31E30", Slot = "14")]
		public override int GetValue(MJDBMMDCKLH LAJBGPNDGLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5D31E50", Offset = "0x5D30C50", VA = "0x185D31E50", Slot = "15")]
		public override void SetValue(MJDBMMDCKLH LAJBGPNDGLJ, int POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class EKMDAFCDDAI : Property<MJDBMMDCKLH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x5D32400", Offset = "0x5D31200", VA = "0x185D32400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D323C0", Offset = "0x5D311C0", VA = "0x185D323C0")]
		public EKMDAFCDDAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D32370", Offset = "0x5D31170", VA = "0x185D32370", Slot = "14")]
		public override GameObject GetValue(MJDBMMDCKLH LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D32390", Offset = "0x5D31190", VA = "0x185D32390", Slot = "15")]
		public override void SetValue(MJDBMMDCKLH LAJBGPNDGLJ, GameObject POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D33F70", Offset = "0x5D32D70", VA = "0x185D33F70")]
	public KLGDIMDEOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class LGNDNKHOKJC : ContainerPropertyBag<EMHLIKNFPFE>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class BMFGJFJKMPG : Property<EMHLIKNFPFE, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5D317A0", Offset = "0x5D305A0", VA = "0x185D317A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D31760", Offset = "0x5D30560", VA = "0x185D31760")]
		public BMFGJFJKMPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D31710", Offset = "0x5D30510", VA = "0x185D31710", Slot = "14")]
		public override SerializableGuid GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D31740", Offset = "0x5D30540", VA = "0x185D31740", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, SerializableGuid POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class CIJIAJDFMKF : Property<EMHLIKNFPFE, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x5D31A50", Offset = "0x5D30850", VA = "0x185D31A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D31A10", Offset = "0x5D30810", VA = "0x185D31A10")]
		public CIJIAJDFMKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D319C0", Offset = "0x5D307C0", VA = "0x185D319C0", Slot = "14")]
		public override List<int> GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D319E0", Offset = "0x5D307E0", VA = "0x185D319E0", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, List<int> POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class PKPCLMFBLOP : Property<EMHLIKNFPFE, List<EMHLIKNFPFE.ACLBGAACHHO>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x5D38A90", Offset = "0x5D37890", VA = "0x185D38A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D38A50", Offset = "0x5D37850", VA = "0x185D38A50")]
		public PKPCLMFBLOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D38A00", Offset = "0x5D37800", VA = "0x185D38A00", Slot = "14")]
		public override List<EMHLIKNFPFE.ACLBGAACHHO> GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D38A20", Offset = "0x5D37820", VA = "0x185D38A20", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, List<EMHLIKNFPFE.ACLBGAACHHO> POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class OABLPEKFMDP : Property<EMHLIKNFPFE, List<EMHLIKNFPFE.PJGHGIGEDCF>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5D38280", Offset = "0x5D37080", VA = "0x185D38280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D38240", Offset = "0x5D37040", VA = "0x185D38240")]
		public OABLPEKFMDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D381F0", Offset = "0x5D36FF0", VA = "0x185D381F0", Slot = "14")]
		public override List<EMHLIKNFPFE.PJGHGIGEDCF> GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D38210", Offset = "0x5D37010", VA = "0x185D38210", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, List<EMHLIKNFPFE.PJGHGIGEDCF> POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class JFCAONFBGIM : Property<EMHLIKNFPFE, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x5D339F0", Offset = "0x5D327F0", VA = "0x185D339F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D339B0", Offset = "0x5D327B0", VA = "0x185D339B0")]
		public JFCAONFBGIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D33960", Offset = "0x5D32760", VA = "0x185D33960", Slot = "14")]
		public override GameObject GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D33980", Offset = "0x5D32780", VA = "0x185D33980", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, GameObject POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class LLKMOLJDGEM : Property<EMHLIKNFPFE, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x5D348E0", Offset = "0x5D336E0", VA = "0x185D348E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D348A0", Offset = "0x5D336A0", VA = "0x185D348A0")]
		public LLKMOLJDGEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D34850", Offset = "0x5D33650", VA = "0x185D34850", Slot = "14")]
		public override Light GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D34870", Offset = "0x5D33670", VA = "0x185D34870", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, Light POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class OGHAIMABNMN : Property<EMHLIKNFPFE, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x5D38850", Offset = "0x5D37650", VA = "0x185D38850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D38810", Offset = "0x5D37610", VA = "0x185D38810")]
		public OGHAIMABNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D387C0", Offset = "0x5D375C0", VA = "0x185D387C0", Slot = "14")]
		public override Collider GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D387E0", Offset = "0x5D375E0", VA = "0x185D387E0", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, Collider POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class FAEBFGOLFBO : Property<EMHLIKNFPFE, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5D32620", Offset = "0x5D31420", VA = "0x185D32620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D325E0", Offset = "0x5D313E0", VA = "0x185D325E0")]
		public FAEBFGOLFBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D32590", Offset = "0x5D31390", VA = "0x185D32590", Slot = "14")]
		public override string GetValue(EMHLIKNFPFE LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D325B0", Offset = "0x5D313B0", VA = "0x185D325B0", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE LAJBGPNDGLJ, string POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D34370", Offset = "0x5D33170", VA = "0x185D34370")]
	public LGNDNKHOKJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class KBHKLNMINPH : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class OEFEIPEMCDD : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5D386E0", Offset = "0x5D374E0", VA = "0x185D386E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5D385F0", Offset = "0x5D373F0", VA = "0x185D385F0")]
		public OEFEIPEMCDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "14")]
		public override Data128 GetValue(SerializableGuid LAJBGPNDGLJ)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D385E0", Offset = "0x5D373E0", VA = "0x185D385E0", Slot = "15")]
		public override void SetValue(SerializableGuid LAJBGPNDGLJ, Data128 POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D33D10", Offset = "0x5D32B10", VA = "0x185D33D10")]
	public KBHKLNMINPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal class AMFDIOBDBME : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class CJLKFFPHKAH : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x5D31B80", Offset = "0x5D30980", VA = "0x185D31B80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D31A90", Offset = "0x5D30890", VA = "0x185D31A90")]
		public CJLKFFPHKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20", Slot = "14")]
		public override int GetValue(Data128 LAJBGPNDGLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D31A80", Offset = "0x5D30880", VA = "0x185D31A80", Slot = "15")]
		public override void SetValue(Data128 LAJBGPNDGLJ, int POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class HHHAHJPCCNK : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x5D33400", Offset = "0x5D32200", VA = "0x185D33400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D33310", Offset = "0x5D32110", VA = "0x185D33310")]
		public HHHAHJPCCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D332F0", Offset = "0x5D320F0", VA = "0x185D332F0", Slot = "14")]
		public override int GetValue(Data128 LAJBGPNDGLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D33300", Offset = "0x5D32100", VA = "0x185D33300", Slot = "15")]
		public override void SetValue(Data128 LAJBGPNDGLJ, int POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class GIIPCEFLMJP : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5D32AD0", Offset = "0x5D318D0", VA = "0x185D32AD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D329E0", Offset = "0x5D317E0", VA = "0x185D329E0")]
		public GIIPCEFLMJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x14F0890", Offset = "0x14EF690", VA = "0x1814F0890", Slot = "14")]
		public override int GetValue(Data128 LAJBGPNDGLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D329D0", Offset = "0x5D317D0", VA = "0x185D329D0", Slot = "15")]
		public override void SetValue(Data128 LAJBGPNDGLJ, int POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class IEOHNPMLJJH : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5D33620", Offset = "0x5D32420", VA = "0x185D33620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D33530", Offset = "0x5D32330", VA = "0x185D33530")]
		public IEOHNPMLJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D33510", Offset = "0x5D32310", VA = "0x185D33510", Slot = "14")]
		public override int GetValue(Data128 LAJBGPNDGLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D33520", Offset = "0x5D32320", VA = "0x185D33520", Slot = "15")]
		public override void SetValue(Data128 LAJBGPNDGLJ, int POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D30E50", Offset = "0x5D2FC50", VA = "0x185D30E50")]
	public AMFDIOBDBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal class HEBKIBCDPKK : ContainerPropertyBag<EMHLIKNFPFE.ACLBGAACHHO>
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class AEHKOEJCDOB : Property<EMHLIKNFPFE.ACLBGAACHHO, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5D30D60", Offset = "0x5D2FB60", VA = "0x185D30D60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5D30D20", Offset = "0x5D2FB20", VA = "0x185D30D20")]
		public AEHKOEJCDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x862EB0", Offset = "0x861CB0", VA = "0x180862EB0", Slot = "14")]
		public override Vector3 GetValue(EMHLIKNFPFE.ACLBGAACHHO LAJBGPNDGLJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D30D00", Offset = "0x5D2FB00", VA = "0x185D30D00", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE.ACLBGAACHHO LAJBGPNDGLJ, Vector3 POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class KLKMKHHHHHD : Property<EMHLIKNFPFE.ACLBGAACHHO, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x5D34170", Offset = "0x5D32F70", VA = "0x185D34170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D34130", Offset = "0x5D32F30", VA = "0x185D34130")]
		public KLKMKHHHHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D34110", Offset = "0x5D32F10", VA = "0x185D34110", Slot = "14")]
		public override List<SerializableGuid> GetValue(EMHLIKNFPFE.ACLBGAACHHO LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D34120", Offset = "0x5D32F20", VA = "0x185D34120", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE.ACLBGAACHHO LAJBGPNDGLJ, List<SerializableGuid> POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D33100", Offset = "0x5D31F00", VA = "0x185D33100")]
	public HEBKIBCDPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class JOGANFCJLKE : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class DDCJFPDMPAC : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5D31E00", Offset = "0x5D30C00", VA = "0x185D31E00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5D31DC0", Offset = "0x5D30BC0", VA = "0x185D31DC0")]
		public DDCJFPDMPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5D31DA0", Offset = "0x5D30BA0", VA = "0x185D31DA0", Slot = "14")]
		public override float GetValue(Vector3 LAJBGPNDGLJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5D31DB0", Offset = "0x5D30BB0", VA = "0x185D31DB0", Slot = "15")]
		public override void SetValue(Vector3 LAJBGPNDGLJ, float POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private class LDPAKJMHMPA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x5D34340", Offset = "0x5D33140", VA = "0x185D34340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5D34300", Offset = "0x5D33100", VA = "0x185D34300")]
		public LDPAKJMHMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5D342E0", Offset = "0x5D330E0", VA = "0x185D342E0", Slot = "14")]
		public override float GetValue(Vector3 LAJBGPNDGLJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5D342F0", Offset = "0x5D330F0", VA = "0x185D342F0", Slot = "15")]
		public override void SetValue(Vector3 LAJBGPNDGLJ, float POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class DLGLKEHGMML : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x5D32070", Offset = "0x5D30E70", VA = "0x185D32070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5D32030", Offset = "0x5D30E30", VA = "0x185D32030")]
		public DLGLKEHGMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x18BC310", Offset = "0x18BB110", VA = "0x1818BC310", Slot = "14")]
		public override float GetValue(Vector3 LAJBGPNDGLJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5D32020", Offset = "0x5D30E20", VA = "0x185D32020", Slot = "15")]
		public override void SetValue(Vector3 LAJBGPNDGLJ, float POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D33B70", Offset = "0x5D32970", VA = "0x185D33B70")]
	public JOGANFCJLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal class NFKPICJHEDL : ContainerPropertyBag<EMHLIKNFPFE.PJGHGIGEDCF>
{
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	private class EMPPFCHEKKL : Property<EMHLIKNFPFE.PJGHGIGEDCF, EMHLIKNFPFE.ACLBGAACHHO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x5D324E0", Offset = "0x5D312E0", VA = "0x185D324E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5D324A0", Offset = "0x5D312A0", VA = "0x185D324A0")]
		public EMPPFCHEKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5D32430", Offset = "0x5D31230", VA = "0x185D32430", Slot = "14")]
		public override EMHLIKNFPFE.ACLBGAACHHO GetValue(EMHLIKNFPFE.PJGHGIGEDCF LAJBGPNDGLJ)
		{
			return default(EMHLIKNFPFE.ACLBGAACHHO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5D32460", Offset = "0x5D31260", VA = "0x185D32460", Slot = "15")]
		public override void SetValue(EMHLIKNFPFE.PJGHGIGEDCF LAJBGPNDGLJ, EMHLIKNFPFE.ACLBGAACHHO POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D37ED0", Offset = "0x5D36CD0", VA = "0x185D37ED0")]
	public NFKPICJHEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal class HMINNDNJCDG : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	private class CJNGJKEDCBJ : Property<RRObjectPrefabV2Data, GPKGCNFDJCC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5D31BF0", Offset = "0x5D309F0", VA = "0x185D31BF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5D31BB0", Offset = "0x5D309B0", VA = "0x185D31BB0")]
		public CJNGJKEDCBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20", Slot = "14")]
		public override GPKGCNFDJCC GetValue(RRObjectPrefabV2Data LAJBGPNDGLJ)
		{
			return default(GPKGCNFDJCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D31A80", Offset = "0x5D30880", VA = "0x185D31A80", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data LAJBGPNDGLJ, GPKGCNFDJCC POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5D33430", Offset = "0x5D32230", VA = "0x185D33430")]
	public HMINNDNJCDG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5D38BB0", Offset = "0x5D379B0", VA = "0x185D38BB0")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
public class LCOCJIOOHJG
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LCOCJIOOHJG()
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

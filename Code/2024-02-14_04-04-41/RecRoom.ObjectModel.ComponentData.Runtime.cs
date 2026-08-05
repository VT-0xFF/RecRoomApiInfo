using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ComponentData_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AGLLOOBOLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6001530", Offset = "0x6000930", VA = "0x186001530", Slot = "8")]
		public override void NHPGLMFECNH(JNDAGNIJMBN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6001260", Offset = "0x6000660", VA = "0x186001260", Slot = "7")]
		public override void IGEABKOPJLM(DBKMADPFFIH registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6001930", Offset = "0x6000D30", VA = "0x186001930")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KHOOACFIMGK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JAJAPGCHAGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode PAMMOHEDAPI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HKIFKLBNJDG]
public struct PMFCBIOGMIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public FBGBOJPDDPL GKEAGGDANLC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly PMFCBIOGMIN KBJBMEBJHNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FFDLBNNIDHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MFEAOKJKOPE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FBGBOJPDDPL
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
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct INGJDPMKJEF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[InternalBufferCapacity(0)]
public struct OJLMPJLKCLI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity NDPOCNKCALI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct LJEIAPDIHKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity BBCCHMIJNJG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GGPBMCKLFFG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LOICMFICGKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity LMAHFBOHCNI;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AJNAKLMNNEF : OIEEBFPFACJ, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LALOMEGNPHJ DAEBGOEBDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(LALOMEGNPHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GKCNBIGHAND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 GOGCFEMIGCF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OBPADKLNJND : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HKIFKLBNJDG]
public struct JBHKBLJBBNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 DMBPOMMOKCI;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JBHKBLJBBNA KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[HKIFKLBNJDG]
public struct EFJAJFKMOJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 DMBPOMMOKCI;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly EFJAJFKMOJI KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CBIEHPJGDBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 GOCJFCBIBBA;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LCBMBLIHONN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 LIIGECEGNEG;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HKIFKLBNJDG]
public struct AKLDFNECDHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float KINAAEOFFEN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly AKLDFNECDHP KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[HKIFKLBNJDG]
public struct GEJMACILKFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float CMIMLEJAPOA;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly GEJMACILKFG KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CKCIMLOFEFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 GGNNFEKGFGP;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HPAJELPEAPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public DPMKPOINNGM KKJFENMGLMK;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EELLBBHPIJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public DPMKPOINNGM JGGCFOJEELP;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ANDKDOOOFML]
public struct ODMGMFJFBBB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity IBMHOJHGCIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ICOKGEECPDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JLAOFAAPCGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PDJMHIHGKCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct BIHPBIDPGKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints BADIBLOLFPI;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HKIFKLBNJDG]
public struct KIBECCAOPPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float APHJOBCNCLL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly KIBECCAOPPN KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NIAHJHBOEJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float ONCKKCMOCFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct OIHBCEBLBGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct BEBJHJAOAID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int DMNDKJBEKDG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xBFD7D0", Offset = "0xBFCBD0", VA = "0x180BFD7D0")]
	public static BEBJHJAOAID CPALPDKLBCM(int FDFHGIHHGHO)
	{
		return default(BEBJHJAOAID);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LENOGGGBOAO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody HELFJOICHKE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6000AC0", Offset = "0x5FFFEC0", VA = "0x186000AC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LENOGGGBOAO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AJILGLHHOHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FAPJGGNDBNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 JHBLCBJMNGM;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct NEGJLKCLMHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 HLPPLJDPLMM;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[HKIFKLBNJDG]
public struct IHLJIAGDBFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float CFFACJBEAFK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IHLJIAGDBFE KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PBEPAIONIBK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object OLPFIGKBEGB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6000DA0", Offset = "0x60001A0", VA = "0x186000DA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public PBEPAIONIBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DLGBEAPEGDK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object PIPHICNADLC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFD70", Offset = "0x5FFF170", VA = "0x185FFFD70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public DLGBEAPEGDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum DPMKPOINNGM
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum EOKKCCNABNA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FPCCLLKIMJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EODIDENHFFD(FBGBOJPDDPL DOFFEAJCHKC, FBGBOJPDDPL DFEJJMNJAAI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJFEIJEODBA();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJBDPDNHELC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AOEPFNFEKGK(bool DPOOEGCHNAG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HAKGICMHJOD();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGBCENGGCGE();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FHLOJLNOKHM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FPCCLLKIMJC HCEAOPGKOGF;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6000080", Offset = "0x5FFF480", VA = "0x186000080", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public FHLOJLNOKHM()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, MODFINNOGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFA90", Offset = "0x5FFEE90", VA = "0x185FFFA90", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, MODFINNOGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MMNFCOJMBJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KAJJIMCBIJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity EJIHOFIDBNB;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OIMKLPNHNAG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity EJIHOFIDBNB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BFOLGOHCIDE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NativeList<MADECKCFEMI> KCBIKINGGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeList<Entity> BFBKBNPMFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JobHandle HFPNAGFOPLB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BMHMLPNNFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFAA0", Offset = "0x5FFEEA0", VA = "0x185FFFAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFC90", Offset = "0x5FFF090", VA = "0x185FFFC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x446C820", Offset = "0x446BC20", VA = "0x18446C820")]
	public BFOLGOHCIDE(NativeList<MADECKCFEMI> KCBIKINGGCN, NativeList<Entity> BFBKBNPMFFL, JobHandle HFPNAGFOPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFB70", Offset = "0x5FFEF70", VA = "0x185FFFB70")]
	public (Entity, NativeSlice<Entity>) JMMNBHGDOAE(int CCNHOKJIGCD)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFB10", Offset = "0x5FFEF10", VA = "0x185FFFB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MADECKCFEMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Entity LMAHFBOHCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int ABOMIAEBHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int CBKFAHCFHJN;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface JKKDJPGDMHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKKLFLLPBBI(bool DEFNMJDBMIP);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct GNHKNBPJIMN : IEquatable<GNHKNBPJIMN>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate bool JGHKDDDMMDH(int OHLLMKBPNCN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly bool KJHINPOPEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly bool NPELHBOOKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly bool NNEHLLOCNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly bool OPEDEIIBKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JGHKDDDMMDH FCBJNIGDGMA;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6000660", Offset = "0x5FFFA60", VA = "0x186000660")]
	public GNHKNBPJIMN(AAJBBPEHLCO HPGFBABPMCF, JGHKDDDMMDH FCBJNIGDGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6000630", Offset = "0x5FFFA30", VA = "0x186000630")]
	public GNHKNBPJIMN(bool KJHINPOPEBP, bool NPELHBOOKEH, bool NNEHLLOCNAH, bool OPEDEIIBKGP, JGHKDDDMMDH FCBJNIGDGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60003D0", Offset = "0x5FFF7D0", VA = "0x1860003D0")]
	public bool EPHMGFLPIIH(int OHLLMKBPNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60005E0", Offset = "0x5FFF9E0", VA = "0x1860005E0")]
	public bool NHNJJBIDCHH(int OHLLMKBPNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60005B0", Offset = "0x5FFF9B0", VA = "0x1860005B0")]
	public bool LHFONCECFED(int OHLLMKBPNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6000580", Offset = "0x5FFF980", VA = "0x186000580")]
	public bool LEBBBCNDIEE(int OHLLMKBPNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60004B0", Offset = "0x5FFF8B0", VA = "0x1860004B0", Slot = "4")]
	public bool Equals(GNHKNBPJIMN AAMIMDAKFMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6000400", Offset = "0x5FFF800", VA = "0x186000400", Slot = "0")]
	public override bool Equals(object MBCPMMHPENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60004E0", Offset = "0x5FFF8E0", VA = "0x1860004E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6000610", Offset = "0x5FFFA10", VA = "0x186000610")]
	private bool OGHAANGFLND(int OHLLMKBPNCN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct LAKCLBBCFEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct JBPHABKOAGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct JFFHAHOPIGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[InternalBufferCapacity(17)]
public struct DAMNKLNLJAL : IBufferElementData, IEquatable<DAMNKLNLJAL>, MODFINNOGLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity NDPOCNKCALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int JNGHAIOCBOM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity LOIADICGELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFD20", Offset = "0x5FFF120", VA = "0x185FFFD20", Slot = "4")]
	public bool Equals(DAMNKLNLJAL AAMIMDAKFMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NICBHOPBDJP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity GBJJOJLHMPF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, MODFINNOGLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x175FC80", Offset = "0x175F080", VA = "0x18175FC80")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFA90", Offset = "0x5FFEE90", VA = "0x185FFFA90", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct EOFMOKJFMCB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly bool LIEFAHOJBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public uint LPMDLNDMMIP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	private static bool MDFENOCJILK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.TypeVersion(2)]
public struct GDJJLPBDIKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint MMIKKJNKDOB;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6000300", Offset = "0x5FFF700", VA = "0x186000300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct CGLBLLPPADG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int DKPDOFNCECP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct KFOINBBHHNG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GCHandle JOLEBOJEOOP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct KJDLKNBGKLI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct COPDFFFLEFD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int DKPDOFNCECP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct POKOAHHCGNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LNMHMJGFHJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct PGNKLGBMIFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct CIFFHAJBCJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct FBFJCCDMBFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct NBDAKNKMGHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct MMBLOPEKPKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FixedString32Bytes OMHHPMIDNAN;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ANDKDOOOFML]
public struct PJCDLPCIHGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity KIGINGBAPMD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static PJCDLPCIHGB CPALPDKLBCM(Entity FDFHGIHHGHO)
	{
		return default(PJCDLPCIHGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct HIJDGLFJOCJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity IBMHOJHGCIG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static HIJDGLFJOCJ CPALPDKLBCM(Entity IBMHOJHGCIG)
	{
		return default(HIJDGLFJOCJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct KJCPEGJJKIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity PLADBKFLDHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JPLNLJOPEHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Entity PLADBKFLDHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct AEEAFIMKNAP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity GGMLLBKMDLP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x86D430", Offset = "0x86C830", VA = "0x18086D430")]
	public static AEEAFIMKNAP CPALPDKLBCM(Entity IBMHOJHGCIG)
	{
		return default(AEEAFIMKNAP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct EEBBIPMOBDL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JJINBFLAIFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public uint OMDPMMKPCNP;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[ANDKDOOOFML]
internal struct LIMLLCFOJIA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity PPEJCMNBDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int OJANCMLFDOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct FELGLCJHPKG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity FHHIMEEIDFM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct AGMIMAAOICG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct FIAMFMOHBON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint LPMDLNDMMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int DMDFHOBEKHF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA42880", Offset = "0xA41C80", VA = "0x180A42880")]
	public FIAMFMOHBON(uint JNEMHFGCOPN, int LHFNMBABLEB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GPFKOAPKOCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct AGNNKFEDJMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct OPFBBKDMAKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct IFHCEKIEAOI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HLELMGCDBAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct BLCHJKDOCCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct EBMNFCPAMCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct MOOCEIFBOHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct AMGKLOAPLBD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct MDJHJJCMEKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct KHLEAFABFKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct MPDLHHFCKKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct GFBHALKJGKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct MGLJLGJMCHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NIPALCKHKID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FGLDIDNFCAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct BLOGGBGKHHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct GKCBMNJELEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct BCBNKAKMBAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct HMNEDGPOFPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct CCDDKGEIBEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FEKBLIFBLBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct OKCJOJIFCGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct IMCKHJHPFPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[ANDKDOOOFML]
public struct EBKGIBCEGIM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FixedString32Bytes OIDBKFFEAFB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct MEGMJMODFJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct PELDIKGKFNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct LONPJMANCJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct DEDHBIPLIDG : IComponentData, IComparable<DEDHBIPLIDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int KPECFFPLHEH;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1766FE0", Offset = "0x17663E0", VA = "0x181766FE0", Slot = "4")]
	public int CompareTo(DEDHBIPLIDG AAMIMDAKFMC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[HKIFKLBNJDG]
public struct MHCAABPDFNH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float4x4 IBKLELJJPCA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly MHCAABPDFNH KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[HKIFKLBNJDG]
public struct ILJJHHKLMPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float4x4 PHLDJFEKFHO;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly ILJJHHKLMPL KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HIOEGENJGJI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private int MOIAJNFKNIN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OJANCMLFDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60006B0", Offset = "0x5FFFAB0", VA = "0x1860006B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60006A0", Offset = "0x5FFFAA0", VA = "0x1860006A0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[HKIFKLBNJDG]
public struct JPNAOACDGKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 ABBINGNKOJG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly JPNAOACDGKH KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[HKIFKLBNJDG]
public struct FOFLAICLFIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 HGKJDOIPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public quaternion PGPLGEJKHLI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly FOFLAICLFIL KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class PHCDODNHOCF
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[HKIFKLBNJDG]
public struct CHBAFCDBJPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float GKNDOCHIKPD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CHBAFCDBJPG KBJBMEBJHNF;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct FPMGKJFMCFB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FixedList32Bytes<int> KPHFHOMDNLN;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DPPNNDACCPC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FixedList32Bytes<int> KPHFHOMDNLN;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class NFEPBDANHFN : ContainerPropertyBag<LENOGGGBOAO>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class NNNNENGJFDB : Property<LENOGGGBOAO, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string BJAHCKCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6000D70", Offset = "0x6000170", VA = "0x186000D70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool OAMNHFOMJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6000D30", Offset = "0x6000130", VA = "0x186000D30")]
		public NNNNENGJFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFC0", Offset = "0x5FFF3C0", VA = "0x185FFFFC0", Slot = "14")]
		public override Rigidbody GetValue(LENOGGGBOAO CHBOBHMMJGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFE0", Offset = "0x5FFF3E0", VA = "0x185FFFFE0", Slot = "15")]
		public override void SetValue(LENOGGGBOAO CHBOBHMMJGK, Rigidbody FDFHGIHHGHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6000C50", Offset = "0x6000050", VA = "0x186000C50")]
	public NFEPBDANHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal class FIOMPJBAJEE : ContainerPropertyBag<PBEPAIONIBK>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class FBJJHIMIAIF : Property<PBEPAIONIBK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string BJAHCKCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6000050", Offset = "0x5FFF450", VA = "0x186000050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool OAMNHFOMJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6000010", Offset = "0x5FFF410", VA = "0x186000010")]
		public FBJJHIMIAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFC0", Offset = "0x5FFF3C0", VA = "0x185FFFFC0", Slot = "14")]
		public override object GetValue(PBEPAIONIBK CHBOBHMMJGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFE0", Offset = "0x5FFF3E0", VA = "0x185FFFFE0", Slot = "15")]
		public override void SetValue(PBEPAIONIBK CHBOBHMMJGK, object FDFHGIHHGHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x60000F0", Offset = "0x5FFF4F0", VA = "0x1860000F0")]
	public FIOMPJBAJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class EDPKCFDIMBI : ContainerPropertyBag<DLGBEAPEGDK>
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class LPEMKEBEDBO : Property<DLGBEAPEGDK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string BJAHCKCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6000B70", Offset = "0x5FFFF70", VA = "0x186000B70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool OAMNHFOMJCD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6000B30", Offset = "0x5FFFF30", VA = "0x186000B30")]
		public LPEMKEBEDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFC0", Offset = "0x5FFF3C0", VA = "0x185FFFFC0", Slot = "14")]
		public override object GetValue(DLGBEAPEGDK CHBOBHMMJGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFE0", Offset = "0x5FFF3E0", VA = "0x185FFFFE0", Slot = "15")]
		public override void SetValue(DLGBEAPEGDK CHBOBHMMJGK, object FDFHGIHHGHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFDE0", Offset = "0x5FFF1E0", VA = "0x185FFFDE0")]
	public EDPKCFDIMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal class IIJCPDCNGME : ContainerPropertyBag<FHLOJLNOKHM>
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class LABOHIOFOMK : Property<FHLOJLNOKHM, FPCCLLKIMJC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string BJAHCKCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6000A90", Offset = "0x5FFFE90", VA = "0x186000A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool OAMNHFOMJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6000A50", Offset = "0x5FFFE50", VA = "0x186000A50")]
		public LABOHIOFOMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFC0", Offset = "0x5FFF3C0", VA = "0x185FFFFC0", Slot = "14")]
		public override FPCCLLKIMJC GetValue(FHLOJLNOKHM CHBOBHMMJGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFFE0", Offset = "0x5FFF3E0", VA = "0x185FFFFE0", Slot = "15")]
		public override void SetValue(FHLOJLNOKHM CHBOBHMMJGK, FPCCLLKIMJC FDFHGIHHGHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6000700", Offset = "0x5FFFB00", VA = "0x186000700")]
	public IIJCPDCNGME()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6000E50", Offset = "0x6000250", VA = "0x186000E50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class MOKIHPOCJIO
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public MOKIHPOCJIO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
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

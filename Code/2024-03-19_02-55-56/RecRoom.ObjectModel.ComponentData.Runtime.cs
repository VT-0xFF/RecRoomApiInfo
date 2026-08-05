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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
	public class _AssemblyIndex : GGAMJMDOFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6244470", Offset = "0x6243470", VA = "0x186244470", Slot = "8")]
		public override void PKDINHKFILI(DOOENEHKPHI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62441A0", Offset = "0x62431A0", VA = "0x1862441A0", Slot = "7")]
		public override void MDFHBIGCNKI(GENAOEOACHE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6244870", Offset = "0x6243870", VA = "0x186244870")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OIHOFEACFCA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NONCNMCIEKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode ANGIMGHPFEF;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[IBPPGIBLCFK]
public struct OHPNAMFCKLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public HHOMPEABPEF IGFKCOKEDFH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly OHPNAMFCKLL KOOHNFGMCMF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HOGDNIOMLCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OJEFDJPPNAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HHOMPEABPEF
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
public struct CNLLEOFIMLM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[InternalBufferCapacity(0)]
public struct JCFHEIKEGJM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity ONPHKLFILKP;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FDNMCHBGJJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity MMPNPJILHCD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BIOEECGPMLA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CHLHLNCEJJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity HLMIIECLDOF;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FGIMEFNAKFC : PPGFAPKHABB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JHPAFKNCJMC EIKPALDJOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(JHPAFKNCJMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LEGKHGMACKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 NMLADDAKKIJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JHFMAAELMIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[IBPPGIBLCFK]
public struct PLCCDIPEBLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 DKAAPFIKAGL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly PLCCDIPEBLD KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[IBPPGIBLCFK]
public struct MJHKFFPIKPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 DKAAPFIKAGL;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly MJHKFFPIKPJ KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NHLGGJAOIIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 GFCPNHHPNNG;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PFDAHFCDIEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 MGMPAJEFBBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IBPPGIBLCFK]
public struct GEAEPNCAEJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float JLFBHJAKOFJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GEAEPNCAEJF KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[IBPPGIBLCFK]
public struct EKGKNNLKHJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float PPABFNHGLCM;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly EKGKNNLKHJD KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IJAEPGDNGBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 JGKCLNJJNGJ;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct GFDOGCNPDCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public FAKPEAJNMEL LGOPBFADNKO;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DIJLEDONPEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public FAKPEAJNMEL LCAIHEPAIML;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OGCFEHAKHHM]
public struct EGPAOJLGAIH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity FHDCFAANCBM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HAOCCLFBCOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MDEFKCABJFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BMHMLEBKKBA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FCELLKDDHHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints EEKLAKLEJLM;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[IBPPGIBLCFK]
public struct BPMPMNJJCGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float ANEBNAPLIDD;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly BPMPMNJJCGC KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct AMCIICJMMGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float GDHIJDDIABK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KGFBIFEKIAN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ANFGKNNHNPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int NPOLBFFFLMF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD8A8A0", Offset = "0xD898A0", VA = "0x180D8A8A0")]
	public static ANFGKNNHNPG GGALBBDOOLM(int CFJDHAGGAJO)
	{
		return default(ANFGKNNHNPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NOJENJCNPLK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody GIOJGBHHAFL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62439A0", Offset = "0x62429A0", VA = "0x1862439A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public NOJENJCNPLK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct MAKFGJPGODE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MPBICNIMLCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 FPIFBDKIOIN;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ADGJLELBKPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 JKBHKGAJHBA;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[IBPPGIBLCFK]
public struct NODNAOACEFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float ELFCNDMNJCN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly NODNAOACEFA KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JHEDLFCKGHE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object LBGPPJMFPLO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62431A0", Offset = "0x62421A0", VA = "0x1862431A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public JHEDLFCKGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BPJLPEKPNKG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object OJEFAOPEAAA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6242B10", Offset = "0x6241B10", VA = "0x186242B10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public BPJLPEKPNKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum FAKPEAJNMEL
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum JHOHKNNGDMA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LKLAPCNOJNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLLDEEICGNP(HHOMPEABPEF AJFLPFKLJHB, HHOMPEABPEF PHCMKGPCKNP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCBFKHLHFKC();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFBEIMGLKBH();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMNFOBBGJMI(bool ONAEAHOIGFP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OKNAICFJIHO();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKELPPJCKHJ();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DCOPNOEKIPG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LKLAPCNOJNG KDCFGGFNDKN;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6242C10", Offset = "0x6241C10", VA = "0x186242C10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DCOPNOEKIPG()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, HDFLLLHEFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6242B00", Offset = "0x6241B00", VA = "0x186242B00", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, HDFLLLHEFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct AEPOMJLJAKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct APNPJONMIFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity JBEADMAJMLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LKGFKFBECAL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity JBEADMAJMLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FPJMJLLKJPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NativeList<JHEABNEMPKK> GJLGDAAEBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeList<Entity> OPEKPHPGPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JobHandle LBMFCHLMCNM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CMGJDOFKOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6242EB0", Offset = "0x6241EB0", VA = "0x186242EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BIBAPHNHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6243040", Offset = "0x6242040", VA = "0x186243040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4606210", Offset = "0x4605210", VA = "0x184606210")]
	public FPJMJLLKJPK(NativeList<JHEABNEMPKK> GJLGDAAEBOE, NativeList<Entity> OPEKPHPGPEC, JobHandle LBMFCHLMCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6242F20", Offset = "0x6241F20", VA = "0x186242F20")]
	public (Entity, NativeSlice<Entity>) HIGNCAPMEOP(int BFOKHFCOJAP)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6242E50", Offset = "0x6241E50", VA = "0x186242E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct JHEABNEMPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Entity HLMIIECLDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int CNHEAECNOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int NAHHNFGPNAE;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CJNJBIJNDCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHFLPEPJCIK(bool OFPPNPHPILG);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct KKFJFPABEBM : IEquatable<KKFJFPABEBM>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate bool IPLMMEMGNML(int PHEFCCOCLHJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly bool GLPNBLFBCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly bool JAIGGDDMGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly bool FDCBGECNFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly bool GOAEKKDFOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly IPLMMEMGNML FDJFJJEACLL;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6243530", Offset = "0x6242530", VA = "0x186243530")]
	public KKFJFPABEBM(KPMECJNFOCC LKCCHOABBBP, IPLMMEMGNML FDJFJJEACLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6243500", Offset = "0x6242500", VA = "0x186243500")]
	public KKFJFPABEBM(bool GLPNBLFBCJP, bool JAIGGDDMGDP, bool FDCBGECNFGA, bool GOAEKKDFOOP, IPLMMEMGNML FDJFJJEACLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62432A0", Offset = "0x62422A0", VA = "0x1862432A0")]
	public bool DMGAIAMPKGN(int PHEFCCOCLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62434D0", Offset = "0x62424D0", VA = "0x1862434D0")]
	public bool KNNHMFIFAJC(int PHEFCCOCLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6243470", Offset = "0x6242470", VA = "0x186243470")]
	public bool HMKNIBLLPHA(int PHEFCCOCLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62434A0", Offset = "0x62424A0", VA = "0x1862434A0")]
	public bool IBHAFINPGKC(int PHEFCCOCLHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62432D0", Offset = "0x62422D0", VA = "0x1862432D0", Slot = "4")]
	public bool Equals(KKFJFPABEBM PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6243300", Offset = "0x6242300", VA = "0x186243300", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x62433D0", Offset = "0x62423D0", VA = "0x1862433D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62433B0", Offset = "0x62423B0", VA = "0x1862433B0")]
	private bool GBIAKKGOGIE(int PHEFCCOCLHJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct PNGJFEANIKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct JGCNMFBOBBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PCCHGKEDLNG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[InternalBufferCapacity(17)]
public struct CKAIBIDHLBP : IBufferElementData, IEquatable<CKAIBIDHLBP>, HDFLLLHEFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity ONPHKLFILKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int LAEMMMOGOPP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity CHCKJKLKEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6242BC0", Offset = "0x6241BC0", VA = "0x186242BC0", Slot = "4")]
	public bool Equals(CKAIBIDHLBP PJNBIAFGNNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct GMPIFFMAPIM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity JDKKOONEPFF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, HDFLLLHEFOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x889EF0", Offset = "0x888EF0", VA = "0x180889EF0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1847D70", Offset = "0x1846D70", VA = "0x181847D70")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6242B00", Offset = "0x6241B00", VA = "0x186242B00", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct HFGANHFIMAL<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly bool CJEPHDFADJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public uint AOAMOCEFMLB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	private static bool LKELBGBPENM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.TypeVersion(2)]
public struct JOAPBALLALA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint NMFKHIHHFBE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6243210", Offset = "0x6242210", VA = "0x186243210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct OLCAAFKECIP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int PFILPIPAOOK;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BCEINEFKLCL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GCHandle MEHBNHCMBEL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FPBAGGBKHFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct IAHGFGJGNEM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int PFILPIPAOOK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct JBMCKDILMEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct BJODMOGINNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct AEIPDNDIODA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct DJMJLMMLLMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct KDBIAFLLDEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct JNMHKOEOLNO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct GGFBCMDHFFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FixedString32Bytes GCMHJLFFDHO;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[OGCFEHAKHHM]
public struct BCPOABDPBMP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity HGCDECHKIOG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static BCPOABDPBMP GGALBBDOOLM(Entity CFJDHAGGAJO)
	{
		return default(BCPOABDPBMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct OPGNKKJIBBF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity FHDCFAANCBM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static OPGNKKJIBBF GGALBBDOOLM(Entity FHDCFAANCBM)
	{
		return default(OPGNKKJIBBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct KGFINHOGFGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity GPKPGEBBFPN;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HANFPHADOOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Entity GPKPGEBBFPN;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct FEIHNHDBANA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity LMABEHEJONA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x87BB10", Offset = "0x87AB10", VA = "0x18087BB10")]
	public static FEIHNHDBANA GGALBBDOOLM(Entity FHDCFAANCBM)
	{
		return default(FEIHNHDBANA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct DKHBLFPOOOE : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JBDHMIDHLCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public uint PENODPCCLDA;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[OGCFEHAKHHM]
internal struct JHAGCMIJHAP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity FIIKIFJAKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int GCDIELAOHNA;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct OFLGFPIKEEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity JOCNNCKECPA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct GMHBGEEFOEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct GDALPGHBHJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint AOAMOCEFMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int FKLHCNANAEI;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xAF6870", Offset = "0xAF5870", VA = "0x180AF6870")]
	public GDALPGHBHJL(uint AMJLCDEFJAL, int ENHOGCNILLP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct OIBDNKOKKJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct FMBJBGAEDNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct FMODHCHFGBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct BJCBBAIIFBL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KGHPCJDDLML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct HOLACKLAHNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct JCPKGKIKADI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct PFJEKDBCDON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct FBMKEMGBHCC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct BMABBMFENOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct JECHALGLMHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct DNGDCLBLKMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct OKLPELKIEDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HODNPKKAALB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct OPMMOADOGMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct DBNHDENFPDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct LELBOIEKBJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct CKCMIKFOEBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IDGMIKIMAFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct NMANOGAKJKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct LDOIKDONCNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct HFICJIHDLBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct APAOFKBMCOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct ALAPGGGLEMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[OGCFEHAKHHM]
public struct OCNAOAAFGPN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FixedString32Bytes DOOGGGNPJGA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HPPGDLMMJLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct FNHNCDIBEMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct CPFIAKCOCGE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct DOLEKPKFMAP : IComponentData, IComparable<DOLEKPKFMAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int PBMJFNCAKDF;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x184C070", Offset = "0x184B070", VA = "0x18184C070", Slot = "4")]
	public int CompareTo(DOLEKPKFMAP PJNBIAFGNNN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[IBPPGIBLCFK]
public struct FHHJPBHJEAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float4x4 BPKHEMMNNKE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FHHJPBHJEAJ KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[IBPPGIBLCFK]
public struct GNLLEPHCKOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float4x4 KPLMAFPDACJ;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly GNLLEPHCKOK KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GDFAHKLJCIG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private int EDHBIFMKOJN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int GCDIELAOHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6243090", Offset = "0x6242090", VA = "0x186243090")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x62430A0", Offset = "0x62420A0", VA = "0x1862430A0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[IBPPGIBLCFK]
public struct OLIPLAEABOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 MDGIHDKKABA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly OLIPLAEABOB KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[IBPPGIBLCFK]
public struct LGPEJJDNOCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 PKDBIHBDKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public quaternion GOAHENPPMCD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly LGPEJJDNOCH KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class FDGDLHNKCAF
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[IBPPGIBLCFK]
public struct APBHONBDHGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float DGIIKPFDKKD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly APBHONBDHGG KOOHNFGMCMF;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct GAGNOHKBIJE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FixedList32Bytes<int> APDCHDEHAEA;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct KONMFCKCJLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FixedList32Bytes<int> APDCHDEHAEA;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class OMKKOLLKEDP : ContainerPropertyBag<NOJENJCNPLK>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class AFDOLKGIFAM : Property<NOJENJCNPLK, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string JJGLPFPAGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6242A20", Offset = "0x6241A20", VA = "0x186242A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool LMHDAJNCEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62429E0", Offset = "0x62419E0", VA = "0x1862429E0")]
		public AFDOLKGIFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6242990", Offset = "0x6241990", VA = "0x186242990", Slot = "14")]
		public override Rigidbody GetValue(NOJENJCNPLK CNBEIAALEIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62429B0", Offset = "0x62419B0", VA = "0x1862429B0", Slot = "15")]
		public override void SetValue(NOJENJCNPLK CNBEIAALEIM, Rigidbody CFJDHAGGAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6243B40", Offset = "0x6242B40", VA = "0x186243B40")]
	public OMKKOLLKEDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal class EDNDFMOOOPG : ContainerPropertyBag<JHEDLFCKGHE>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class ANEOMBIBAIK : Property<JHEDLFCKGHE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string JJGLPFPAGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6242A90", Offset = "0x6241A90", VA = "0x186242A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool LMHDAJNCEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6242A50", Offset = "0x6241A50", VA = "0x186242A50")]
		public ANEOMBIBAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6242990", Offset = "0x6241990", VA = "0x186242990", Slot = "14")]
		public override object GetValue(JHEDLFCKGHE CNBEIAALEIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62429B0", Offset = "0x62419B0", VA = "0x1862429B0", Slot = "15")]
		public override void SetValue(JHEDLFCKGHE CNBEIAALEIM, object CFJDHAGGAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6242C80", Offset = "0x6241C80", VA = "0x186242C80")]
	public EDNDFMOOOPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class NJHPFLAGCNM : ContainerPropertyBag<BPJLPEKPNKG>
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class PDDBIFMLCBB : Property<BPJLPEKPNKG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string JJGLPFPAGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6243C60", Offset = "0x6242C60", VA = "0x186243C60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool LMHDAJNCEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6243C20", Offset = "0x6242C20", VA = "0x186243C20")]
		public PDDBIFMLCBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6242990", Offset = "0x6241990", VA = "0x186242990", Slot = "14")]
		public override object GetValue(BPJLPEKPNKG CNBEIAALEIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62429B0", Offset = "0x62419B0", VA = "0x1862429B0", Slot = "15")]
		public override void SetValue(BPJLPEKPNKG CNBEIAALEIM, object CFJDHAGGAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6243880", Offset = "0x6242880", VA = "0x186243880")]
	public NJHPFLAGCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal class LICGBNNJOIB : ContainerPropertyBag<DCOPNOEKIPG>
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class OEBJAEKIMFA : Property<DCOPNOEKIPG, LKLAPCNOJNG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string JJGLPFPAGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6243A50", Offset = "0x6242A50", VA = "0x186243A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool LMHDAJNCEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6243A10", Offset = "0x6242A10", VA = "0x186243A10")]
		public OEBJAEKIMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6242990", Offset = "0x6241990", VA = "0x186242990", Slot = "14")]
		public override LKLAPCNOJNG GetValue(DCOPNOEKIPG CNBEIAALEIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62429B0", Offset = "0x62419B0", VA = "0x1862429B0", Slot = "15")]
		public override void SetValue(DCOPNOEKIPG CNBEIAALEIM, LKLAPCNOJNG CFJDHAGGAJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62436A0", Offset = "0x62426A0", VA = "0x1862436A0")]
	public LICGBNNJOIB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6243D90", Offset = "0x6242D90", VA = "0x186243D90")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class LCCIMHLHFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public LCCIMHLHFIH()
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

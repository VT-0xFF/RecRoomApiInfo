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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
	public class _AssemblyIndex : AMNHIIEBCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6205200", Offset = "0x6204400", VA = "0x186205200", Slot = "8")]
		public override void ILDOOKAPLMG(LNNICLBDLGC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6205600", Offset = "0x6204800", VA = "0x186205600", Slot = "7")]
		public override void PEJJJDIJBDC(NHBHPCMLJOC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62058D0", Offset = "0x6204AD0", VA = "0x1862058D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ABFCJGPBIAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OBMFMKABMFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode EGBDJLMLAJN;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ACKMOHGKGNM]
public struct BFDHMLAAIOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public JKDPHHAOMCD AGMFMOENLAN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly BFDHMLAAIOG NAPBCIPCGOL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PJOCLKMDAHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DIAEPOMIFJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JKDPHHAOMCD
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
public struct HLAEAHOEKBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[InternalBufferCapacity(0)]
public struct ALENHIMNLKH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity HLNBFGHFDID;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ILENNNDJAOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity DMKJLMNBOME;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FHGMDICDNHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GOCDAMPJECM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity EAMCHADGEIB;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PCOAFDCFJEC : LCACNONGNHO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LJAPKFBJAGO NINDFLPFGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(LJAPKFBJAGO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1838430", Offset = "0x1837630", VA = "0x181838430", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JHCKLLMONJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 AGFBIEEGBDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NHBFBIALNIM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ACKMOHGKGNM]
public struct BIGGMGEEIGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 OJJCMJGBEIA;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly BIGGMGEEIGG NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ACKMOHGKGNM]
public struct OFGACBGHDHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 OJJCMJGBEIA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly OFGACBGHDHD NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MPPGFIFEDCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 DKBICBDPFNO;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CAIIEBIKGJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 MGFMBHEAABA;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ACKMOHGKGNM]
public struct AHGMCIKBBNF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float ODLGKIJMIGC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly AHGMCIKBBNF NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ACKMOHGKGNM]
public struct AGOPALCJKLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float CLFEOAKKOBN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly AGOPALCJKLM NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PABOKONECEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 HIJPCOCMPFN;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KDLDEFDAGPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PMDABCIAEAH BPILJBAMGFI;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MFKANBLGEII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public PMDABCIAEAH AGHBEGKOEDD;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FGJIIMPMGDF]
public struct ICKFKLPDEEC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity CHIBHEBBKEE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EBBOGLEHEMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JOEOPOODEBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FHBOFBEOCLG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GKOJFINFAON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints IGCLOJGKDJN;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ACKMOHGKGNM]
public struct CLAHOKMGJLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float FMHMPJKMLFK;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly CLAHOKMGJLG NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct MEJBHAFLJBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float KLNHJFKNGHP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct CLJJIECCAOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KKNBCFFCLFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int NKJNCKONFCP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD867E0", Offset = "0xD859E0", VA = "0x180D867E0")]
	public static KKNBCFFCLFF MLCODHGANFM(int AFCGKMGKPEF)
	{
		return default(KKNBCFFCLFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PFCJLCECBGJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody MILIHKPJLEL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6204D10", Offset = "0x6203F10", VA = "0x186204D10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public PFCJLCECBGJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PGJMNPKOOCC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FONHBAANKPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 CLIOBNEJAAB;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct CFFKECDEMJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 KEMDGEPABAD;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[ACKMOHGKGNM]
public struct DFHNNLINHME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float LNKOGOHPEKM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DFHNNLINHME NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class PJHDPHKIMGI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object EIIKHJKBONI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6204D80", Offset = "0x6203F80", VA = "0x186204D80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public PJHDPHKIMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DEGNBDMBNLL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object DFAENAJPGEA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6203F30", Offset = "0x6203130", VA = "0x186203F30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public DEGNBDMBNLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum PMDABCIAEAH
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum CDNENJJICFO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HKJDEMHDADA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJEMKLOBFCO(JKDPHHAOMCD AADGLEEKKEE, JKDPHHAOMCD IKOMCBPPDOD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAEFJNBHBBG();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOKFHMGKFOE();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOAEEJGIECN(bool AGBMHBNNBPK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DGBHHDFIMIL();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHOAJKCCPFH();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PCMEGLDMLGL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HKJDEMHDADA DGIJOHHJELI;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6204CA0", Offset = "0x6203EA0", VA = "0x186204CA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public PCMEGLDMLGL()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, ECKFJHJMMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1838430", Offset = "0x1837630", VA = "0x181838430", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6203A70", Offset = "0x6202C70", VA = "0x186203A70", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, ECKFJHJMMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1838430", Offset = "0x1837630", VA = "0x181838430", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct AFFFLBLPBPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FEIPNNNFIBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity EOOCOJLAAFI;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JKPGGMKHFCA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity EOOCOJLAAFI;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct JJABBCMBILM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NativeList<OLBMFOOJIJB> PDLBALBLNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeList<Entity> DGOFKFLNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JobHandle EIMNPGHHIJH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OCMFLJFDOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6204250", Offset = "0x6203450", VA = "0x186204250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6204440", Offset = "0x6203640", VA = "0x186204440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x45F74E0", Offset = "0x45F66E0", VA = "0x1845F74E0")]
	public JJABBCMBILM(NativeList<OLBMFOOJIJB> PDLBALBLNPB, NativeList<Entity> DGOFKFLNNLB, JobHandle EIMNPGHHIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62042C0", Offset = "0x62034C0", VA = "0x1862042C0")]
	public (Entity, NativeSlice<Entity>) DKDHMBPDMLC(int ABHDANNAKPK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62043E0", Offset = "0x62035E0", VA = "0x1862043E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OLBMFOOJIJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Entity EAMCHADGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int GNHLLBKBLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int NCLKCGHBFFI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface IPJGDCIEDDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAGKHIDBEOE(bool BNPNCHMKOPL);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct LPNIEEGLDAG : IEquatable<LPNIEEGLDAG>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate bool MAJPEIPABIP(int GMBNCAOLOEM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly bool GJIEEJKAEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly bool OBBPIMLEAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly bool JCCNGNPHCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly bool GLNBIFHLNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MAJPEIPABIP FHJHKFAJKFE;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62048A0", Offset = "0x6203AA0", VA = "0x1862048A0")]
	public LPNIEEGLDAG(MMOGLMFPNLM NLKHKPJHECN, MAJPEIPABIP FHJHKFAJKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6204870", Offset = "0x6203A70", VA = "0x186204870")]
	public LPNIEEGLDAG(bool GJIEEJKAEMC, bool OBBPIMLEAMF, bool JCCNGNPHCEG, bool GLNBIFHLNBG, MAJPEIPABIP FHJHKFAJKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62047F0", Offset = "0x62039F0", VA = "0x1862047F0")]
	public bool KJGDHINAOCF(int GMBNCAOLOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62047C0", Offset = "0x62039C0", VA = "0x1862047C0")]
	public bool JDMAKEFCPGN(int GMBNCAOLOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6204820", Offset = "0x6203A20", VA = "0x186204820")]
	public bool LLBDEADCOEB(int GMBNCAOLOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6204610", Offset = "0x6203810", VA = "0x186204610")]
	public bool AMELEAMGIFB(int GMBNCAOLOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6204640", Offset = "0x6203840", VA = "0x186204640", Slot = "4")]
	public bool Equals(LPNIEEGLDAG NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6204670", Offset = "0x6203870", VA = "0x186204670", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6204720", Offset = "0x6203920", VA = "0x186204720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6204850", Offset = "0x6203A50", VA = "0x186204850")]
	private bool OCMBFIKDCEL(int GMBNCAOLOEM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct MJLCFFGFLIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct MFNDGNPKAMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct CNOPCHMMAGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[InternalBufferCapacity(17)]
public struct ONEIEJPFGDA : IBufferElementData, IEquatable<ONEIEJPFGDA>, ECKFJHJMMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity HLNBFGHFDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int CDOJPCACMLI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity FMAKCNHMJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1838430", Offset = "0x1837630", VA = "0x181838430", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6204BA0", Offset = "0x6203DA0", VA = "0x186204BA0", Slot = "4")]
	public bool Equals(ONEIEJPFGDA NFMPGFPPFKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct JJCHDIHNBBC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity JNLJLDNIIAF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, ECKFJHJMMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1838430", Offset = "0x1837630", VA = "0x181838430", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1838430", Offset = "0x1837630", VA = "0x181838430")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6203A70", Offset = "0x6202C70", VA = "0x186203A70", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct MCIKHDAIPIB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly bool DOGDMICGGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public uint BHKGCBGMEPD;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	private static bool AELELOIBLCO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.TypeVersion(2)]
public struct ECAFLPHMPLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint IIHDOPFMODP;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6204050", Offset = "0x6203250", VA = "0x186204050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct ALGMOPGKMFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int AHFDPNNADCM;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct AMANLHEJJAL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GCHandle NOEKPLDBJAI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct CIDGENHHAJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct DMLBAMLBAHN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int AHFDPNNADCM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct NMHANDHGNMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct ICNLAJCHCFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct NHAHAJKMHFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct MCDEJBPLGLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct LNNAPGKJMGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IEJJNEDEIKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct EFAHNHJMLGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FixedString32Bytes NLBAJPAADNH;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[FGJIIMPMGDF]
public struct APMHHDJKOJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity BABPGNHEAGK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static APMHHDJKOJN MLCODHGANFM(Entity AFCGKMGKPEF)
	{
		return default(APMHHDJKOJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct NEADENDFEPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity CHIBHEBBKEE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static NEADENDFEPK MLCODHGANFM(Entity CHIBHEBBKEE)
	{
		return default(NEADENDFEPK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct PFAPBEBNBPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity NDDEFIKGKKD;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IAPJJCOEEOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Entity NDDEFIKGKKD;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct APBJPGOCBBI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity PJIFLHHKGDI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static APBJPGOCBBI MLCODHGANFM(Entity CHIBHEBBKEE)
	{
		return default(APBJPGOCBBI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct GOJMCNPCPON : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct FIAFDOHCOCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public uint LMCDLECLJKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[FGJIIMPMGDF]
internal struct CBBPHNECLDB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity CMBNDDBKGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int ILNNGHKJMBD;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct BJHBAALKKNG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity HOJMEJFBGOL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct LDIAFEKNABO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct LHLNFCAMBGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint BHKGCBGMEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int POINKMCMEDJ;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xAF2C30", Offset = "0xAF1E30", VA = "0x180AF2C30")]
	public LHLNFCAMBGN(uint OKLJANOJIBP, int IKIGIDAGAJC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct PMLBFIFEDEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct MJHDKMBILBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct EEOOMHLELGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct IBIAPMGEFKP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct GJOKAOLACLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct HGHEEFIDLKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct KPFNANLNLGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct NDBEAOLBGFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct ADGDMHIGEDN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct GLHFJJILBHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct JAJBLFCDMAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct JEMILFNPALM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct DCKEEALFNBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct KLNANNMNBML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct IOGMJAEIHHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct JDAMBIPIEGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct DFNNIAFDGIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JEPJCAFELKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct HPJHKDCNLHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct HENABKIEBAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct OPAKGPEHAHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct IPFDEPDKEMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct NPCMOBEKNLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LCAMOPKDKBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[FGJIIMPMGDF]
public struct MHBEFHMNIEI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FixedString32Bytes PJHNNIPHPHM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct JOIHAEACJAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct HKBOPMKOJID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct PLFOICGHJFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct FJEHJFAPCBB : IComponentData, IComparable<FJEHJFAPCBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int GENAFOKHFIJ;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x183B440", Offset = "0x183A640", VA = "0x18183B440", Slot = "4")]
	public int CompareTo(FJEHJFAPCBB NFMPGFPPFKH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[ACKMOHGKGNM]
public struct BOMHNKGIEOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float4x4 HBKKDACMJFL;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly BOMHNKGIEOL NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[ACKMOHGKGNM]
public struct PBOKOMOEECF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float4x4 MMBCEDEOPCF;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly PBOKOMOEECF NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct KODCPMGECLL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private int CGHLKOAHHLL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ILNNGHKJMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6204510", Offset = "0x6203710", VA = "0x186204510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6204520", Offset = "0x6203720", VA = "0x186204520")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[ACKMOHGKGNM]
public struct KGGGIDDPCEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 ECDMHKKLFOH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly KGGGIDDPCEB NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[ACKMOHGKGNM]
public struct HKILPKJFGEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 HBEJPCPOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public quaternion KIIONLKEIBO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly HKILPKJFGEM NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class GNAHIMBJNKF
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[ACKMOHGKGNM]
public struct HJLIMEAGMPF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float KOPOLGGBFNE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly HJLIMEAGMPF NAPBCIPCGOL;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct KNMJFLGPECC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FixedList32Bytes<int> BOBCAOFCCEB;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct JFNIDNEKDFE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FixedList32Bytes<int> BOBCAOFCCEB;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class LPEILDLPHBP : ContainerPropertyBag<PFCJLCECBGJ>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class OMLMBIMAPBI : Property<PFCJLCECBGJ, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string IHKMJLPGIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6204B70", Offset = "0x6203D70", VA = "0x186204B70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool FPDKMGECOKP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6204B30", Offset = "0x6203D30", VA = "0x186204B30")]
		public OMLMBIMAPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6203BA0", Offset = "0x6202DA0", VA = "0x186203BA0", Slot = "14")]
		public override Rigidbody GetValue(PFCJLCECBGJ DEFANHHPGKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6203BC0", Offset = "0x6202DC0", VA = "0x186203BC0", Slot = "15")]
		public override void SetValue(PFCJLCECBGJ DEFANHHPGKO, Rigidbody AFCGKMGKPEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6204530", Offset = "0x6203730", VA = "0x186204530")]
	public LPEILDLPHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal class ODDAKFOCPBI : ContainerPropertyBag<PJHDPHKIMGI>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class NEAOMGIFHJK : Property<PJHDPHKIMGI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string IHKMJLPGIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6204920", Offset = "0x6203B20", VA = "0x186204920", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool FPDKMGECOKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x62048E0", Offset = "0x6203AE0", VA = "0x1862048E0")]
		public NEAOMGIFHJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6203BA0", Offset = "0x6202DA0", VA = "0x186203BA0", Slot = "14")]
		public override object GetValue(PJHDPHKIMGI DEFANHHPGKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6203BC0", Offset = "0x6202DC0", VA = "0x186203BC0", Slot = "15")]
		public override void SetValue(PJHDPHKIMGI DEFANHHPGKO, object AFCGKMGKPEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6204950", Offset = "0x6203B50", VA = "0x186204950")]
	public ODDAKFOCPBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class DCKOIMENAEB : ContainerPropertyBag<DEGNBDMBNLL>
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class BGCHENPEAMD : Property<DEGNBDMBNLL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string IHKMJLPGIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6203C30", Offset = "0x6202E30", VA = "0x186203C30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool FPDKMGECOKP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6203BF0", Offset = "0x6202DF0", VA = "0x186203BF0")]
		public BGCHENPEAMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6203BA0", Offset = "0x6202DA0", VA = "0x186203BA0", Slot = "14")]
		public override object GetValue(DEGNBDMBNLL DEFANHHPGKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6203BC0", Offset = "0x6202DC0", VA = "0x186203BC0", Slot = "15")]
		public override void SetValue(DEGNBDMBNLL DEFANHHPGKO, object AFCGKMGKPEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6203E50", Offset = "0x6203050", VA = "0x186203E50")]
	public DCKOIMENAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal class BBPEECOEKKF : ContainerPropertyBag<PCMEGLDMLGL>
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class EAPAPPOFJNL : Property<PCMEGLDMLGL, HKJDEMHDADA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string IHKMJLPGIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6204020", Offset = "0x6203220", VA = "0x186204020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool FPDKMGECOKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6203FE0", Offset = "0x62031E0", VA = "0x186203FE0")]
		public EAPAPPOFJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6203BA0", Offset = "0x6202DA0", VA = "0x186203BA0", Slot = "14")]
		public override HKJDEMHDADA GetValue(PCMEGLDMLGL DEFANHHPGKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6203BC0", Offset = "0x6202DC0", VA = "0x186203BC0", Slot = "15")]
		public override void SetValue(PCMEGLDMLGL DEFANHHPGKO, HKJDEMHDADA AFCGKMGKPEF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6203A80", Offset = "0x6202C80", VA = "0x186203A80")]
	public BBPEECOEKKF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6204DF0", Offset = "0x6203FF0", VA = "0x186204DF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class CNDGMOJHGPO
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public CNDGMOJHGPO()
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

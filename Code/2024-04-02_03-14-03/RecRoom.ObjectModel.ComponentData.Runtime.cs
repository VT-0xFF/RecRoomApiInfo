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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
	public class _AssemblyIndex : PHLPCMENMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61DC360", Offset = "0x61DAF60", VA = "0x1861DC360", Slot = "8")]
		public override void CAHAKELCOOI(EJCABKCJHLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61DC760", Offset = "0x61DB360", VA = "0x1861DC760", Slot = "7")]
		public override void FDOOCIJIABF(EJEDBMCLDFB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61DCA30", Offset = "0x61DB630", VA = "0x1861DCA30")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OFNPOBCMCFE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BLAFDOOJFIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode PDPNKAIKMCH;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OAMDNGCNDEC]
public struct BMCPMNDEIPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public FELBOIIGGGO MFLHCJNBCOI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly BMCPMNDEIPE IDMMFBJNCBP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KJDCPOMOIKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MDINILFCLAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FELBOIIGGGO
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
public struct PEGIBOAEOOE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[InternalBufferCapacity(0)]
public struct FAOFGDOHLJB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity MAEGJLGHFOA;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HLIOHMLBENA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity MJOMMKLGFIJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HKGABDIIMAC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KDIHAMDENLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity EBCHPMPLBLG;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DOJPFMIFJKN : GOPJDCFJMPH, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OAMNLLMKGGL NMENGCAOJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(OAMNLLMKGGL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HDKKDNCCICB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 CMAODNIPGJM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OFOFEMLAANO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OAMDNGCNDEC]
public struct JDGKHAKCFGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 OHKJAEKCMKL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly JDGKHAKCFGF IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OAMDNGCNDEC]
public struct KGPANDOLAON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 OHKJAEKCMKL;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly KGPANDOLAON IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DJJENGHKAFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 AOLEGNPIGIE;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LMDOIKOPEKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 AAFOBPBIKPE;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[OAMDNGCNDEC]
public struct FDKONIFBNFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float MKCKNDCPEHA;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly FDKONIFBNFG IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OAMDNGCNDEC]
public struct CDNAPJLPDDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float IMIDLOBIBCH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly CDNAPJLPDDD IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JHEFLCCPOLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 ODMOIAIAIIG;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KAMNFAOELAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public MIOBPNFJILE NLNFNBHBJDC;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BJBBBJIOMJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public MIOBPNFJILE NELPGAOICDA;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[JINKCKDOOEF]
public struct EOBCKEMFMKC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity CMFPBPOIOPE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IJGOAPCMJHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GMAKBFBFCPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BDKIKNHEFBP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IPCBPEBIILE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints GNOFCBICNBA;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[OAMDNGCNDEC]
public struct LJMOGOPMNJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float OPCEKLFMMME;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly LJMOGOPMNJE IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct IGMKBIDPAGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float BCMJKEKLFCO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JCAMEJAFCJG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct FPKHCBEABMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int ABAHNFADIED;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD8C510", Offset = "0xD8B110", VA = "0x180D8C510")]
	public static FPKHCBEABMH PFOIJBDHIHJ(int BLKAHBIJBJO)
	{
		return default(FPKHCBEABMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GKJLLILDOOL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody GNCJKDNCDJM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x61DB630", Offset = "0x61DA230", VA = "0x1861DB630", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GKJLLILDOOL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LDPFPGAPIFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HHGPDIDCMEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 DJANAFJPKFF;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct KIKODDPKODE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 OOFHBPOGMFI;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[OAMDNGCNDEC]
public struct PAFKPPKKLFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float NFJICLEMGNN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly PAFKPPKKLFH IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DGAFIDPPMFH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object KOJOHCCMNFF;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61DB250", Offset = "0x61D9E50", VA = "0x1861DB250", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public DGAFIDPPMFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GKBNGCOCIMH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object EIIGKKDJBHG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61DB5C0", Offset = "0x61DA1C0", VA = "0x1861DB5C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public GKBNGCOCIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum MIOBPNFJILE
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum LFBHMICPMPL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HCNAIJBDPFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFCLJBAFAKL(FELBOIIGGGO OJAIGPFEEFN, FELBOIIGGGO PHHKIEBOCCO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHOLKLJOFGH();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLAJDBNNDCN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNFILLAAEDE(bool JNMAPFFBLPC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OAJBCJPHPGH();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAIICGAGCCB();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BJMMJODIAGK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public HCNAIJBDPFJ BFOAMIDLFGM;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61DABC0", Offset = "0x61D97C0", VA = "0x1861DABC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BJMMJODIAGK()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, CDFIGFDGHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61DABB0", Offset = "0x61D97B0", VA = "0x1861DABB0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, CDFIGFDGHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EHBDPDFDHNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FFAKBNPOILH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity DLEGPBJMIOG;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FHIJDBCECLF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity DLEGPBJMIOG;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct CJCEELLJCML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NativeList<LLBOAHHCNOE> FABAKEKBFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeList<Entity> GOCHAMAIMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JobHandle JAJDCBMGAHG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CCNOFCBMAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61DAF10", Offset = "0x61D9B10", VA = "0x1861DAF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61DADA0", Offset = "0x61D99A0", VA = "0x1861DADA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x45B4330", Offset = "0x45B2F30", VA = "0x1845B4330")]
	public CJCEELLJCML(NativeList<LLBOAHHCNOE> FABAKEKBFEB, NativeList<Entity> GOCHAMAIMBE, JobHandle JAJDCBMGAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61DADF0", Offset = "0x61D99F0", VA = "0x1861DADF0")]
	public (Entity, NativeSlice<Entity>) KBOFELALOJG(int CFPNJHJGBGM)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61DAD40", Offset = "0x61D9940", VA = "0x1861DAD40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LLBOAHHCNOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Entity EBCHPMPLBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int OIAPMOHIBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int GFICJHOBPLH;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GNFGIEBKHJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAFGJKDHDFK(bool JEOCDGIIEGF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct DEGHKCBFMGE : IEquatable<DEGHKCBFMGE>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate bool PNKIHDCJPJB(int FHDOEPMHPEB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly bool BFIONCPNAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly bool GNDPLLJEBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly bool AMOKLJNCEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly bool GCAOIIBLACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PNKIHDCJPJB LGPNDCKCFAG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61DB1E0", Offset = "0x61D9DE0", VA = "0x1861DB1E0")]
	public DEGHKCBFMGE(GEIOBDNIBFI OGPBDNPMEAI, PNKIHDCJPJB LGPNDCKCFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61DB220", Offset = "0x61D9E20", VA = "0x1861DB220")]
	public DEGHKCBFMGE(bool BFIONCPNAHB, bool GNDPLLJEBPC, bool AMOKLJNCEMJ, bool GCAOIIBLACI, PNKIHDCJPJB LGPNDCKCFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61DB180", Offset = "0x61D9D80", VA = "0x1861DB180")]
	public bool OCOMDNBKMEI(int FHDOEPMHPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x61DB0B0", Offset = "0x61D9CB0", VA = "0x1861DB0B0")]
	public bool FGIMNKPDMIG(int FHDOEPMHPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61DB1B0", Offset = "0x61D9DB0", VA = "0x1861DB1B0")]
	public bool OFEBEDLPNEB(int FHDOEPMHPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61DAF80", Offset = "0x61D9B80", VA = "0x1861DAF80")]
	public bool CNFIHCHFOOM(int FHDOEPMHPEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61DAFD0", Offset = "0x61D9BD0", VA = "0x1861DAFD0", Slot = "4")]
	public bool Equals(DEGHKCBFMGE NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x61DB000", Offset = "0x61D9C00", VA = "0x1861DB000", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x61DB0E0", Offset = "0x61D9CE0", VA = "0x1861DB0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61DAFB0", Offset = "0x61D9BB0", VA = "0x1861DAFB0")]
	private bool DCKPNJPIOML(int FHDOEPMHPEB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IIEMDMPNNGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct GFAHDBELJAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct KKHPDMLIHOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[InternalBufferCapacity(17)]
public struct PGMJCCPFHMG : IBufferElementData, IEquatable<PGMJCCPFHMG>, CDFIGFDGHPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity MAEGJLGHFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int GKHFAJMFBDI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity JEOHELFNFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61DBDE0", Offset = "0x61DA9E0", VA = "0x1861DBDE0", Slot = "4")]
	public bool Equals(PGMJCCPFHMG NAFFCAIMPLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct JLFBDBOGEPP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity INCCBEGLCIP;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, CDFIGFDGHPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x87F9A0", Offset = "0x87E5A0", VA = "0x18087F9A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x185D2E0", Offset = "0x185BEE0", VA = "0x18185D2E0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61DABB0", Offset = "0x61D97B0", VA = "0x1861DABB0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct GAHDILOPPOE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly bool CBDMCJHEAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public uint GNFBFDCELFC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	private static bool AHFOALHAJHE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.TypeVersion(2)]
public struct CGAAAIJPAEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint JHGMOOFKKDJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61DACB0", Offset = "0x61D98B0", VA = "0x1861DACB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GPMGOIJJDPB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int BEIODOEPHKL;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct AJAFALKBJKK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GCHandle LDJIGKKEKFI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct HBBCCEMJMDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct PJACBLIAEMK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int BEIODOEPHKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct IGFLEPDJPNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct DGBHDKOOBGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct PLLHLFIIPML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct CHEFLEKDOAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct EFIBGBGHJMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct DFJPJNIDDMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct JKAABJPOPLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FixedString32Bytes MPGNMPAPHDB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[JINKCKDOOEF]
public struct CPDEJJLFFFF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity LCNNNOGNJJG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static CPDEJJLFFFF PFOIJBDHIHJ(Entity BLKAHBIJBJO)
	{
		return default(CPDEJJLFFFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct HABEMJDLOJE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity CMFPBPOIOPE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static HABEMJDLOJE PFOIJBDHIHJ(Entity CMFPBPOIOPE)
	{
		return default(HABEMJDLOJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct BDDCBGILGBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity LAKKJNDHFHI;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct PBAFAKKCPNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Entity LAKKJNDHFHI;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct MMBCNDLALAH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity AOAMCCIFDOB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640")]
	public static MMBCNDLALAH PFOIJBDHIHJ(Entity CMFPBPOIOPE)
	{
		return default(MMBCNDLALAH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct ABBMOOBCHJN : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct IODPLECHJOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public uint KAHEAPGLNDI;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[JINKCKDOOEF]
internal struct CHKBEGBLGBK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity POBMFHNKEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int PMIDLPOCCEE;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct BAILPDMGKFB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity PIPIGKGGBCB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct PFLJPIIEKIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct FBDDNPLANBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint GNFBFDCELFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int BBDPJGGEGEP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xADE590", Offset = "0xADD190", VA = "0x180ADE590")]
	public FBDDNPLANBM(uint OPNNHKLAFFB, int DENNHKDHEKG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct NJAFIJEIGCO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct BHOGMIGGPFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct IPLAJLGGCDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct LCBEKMNLAGF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct CIKOPGAENMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct FBEMHDLFCFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct KFAIBNAFNMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct LGLOBJIPLPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct HMHNPGOMAMN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct DNIGJIDKIAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct FILFEIMJCEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct IOBGCOCLJHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct EIHLAJFJPLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct DCNHPLKEKEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct IEIPFEHFHAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct HCLAHDEMDJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct KEFFBOKKDEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct KEADLBDPPIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct LHGCOHOMOEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct HAMDIDJHIFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct BNHGEOLGMBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal struct CILCAAKGIEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct JMJPCCABLHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct MHOJKFACHPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct IKEAGKCCADI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[JINKCKDOOEF]
public struct PJJJFBMFNHE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FixedString32Bytes JBHAKCLHNCB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct OFDDBFHEOHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct FFHKCAHDENE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct IMGLFFNDEIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct BLJDADOHICH : IComponentData, IComparable<BLJDADOHICH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int CAEHNIAHEAE;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1863F00", Offset = "0x1862B00", VA = "0x181863F00", Slot = "4")]
	public int CompareTo(BLJDADOHICH NAFFCAIMPLI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[OAMDNGCNDEC]
public struct FDKHJJGEPEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float4x4 GPGKLANJFLI;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FDKHJJGEPEP IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[OAMDNGCNDEC]
public struct PJEJKFMPIDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float4x4 HKEGKNCJDJH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly PJEJKFMPIDJ IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct ANMFLBFCJOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private int CHALLLHOBFD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PMIDLPOCCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x61DAB90", Offset = "0x61D9790", VA = "0x1861DAB90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x61DABA0", Offset = "0x61D97A0", VA = "0x1861DABA0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[OAMDNGCNDEC]
public struct KJEPPJBEFAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 MPKLLCDIMMG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly KJEPPJBEFAI IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[OAMDNGCNDEC]
public struct FNGIADGCJIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 GMKEEAOHFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public quaternion MJCNDCDLGEO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly FNGIADGCJIN IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class NCHGJPKCPHB
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[OAMDNGCNDEC]
public struct ABOGBANAPOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float FPFKADMBFHD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly ABOGBANAPOI IDMMFBJNCBP;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct IOHICGAEGBO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FixedList32Bytes<int> PJIFCCMNNGH;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct ABIKBDBJLLB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FixedList32Bytes<int> PJIFCCMNNGH;
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class HDGIHFGLJMO : ContainerPropertyBag<GKJLLILDOOL>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private class JHFJPJLAGIJ : Property<GKJLLILDOOL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string PEJAGGFBEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x61DBA60", Offset = "0x61DA660", VA = "0x1861DBA60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool FHOMOFINOFF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61DBA20", Offset = "0x61DA620", VA = "0x1861DBA20")]
		public JHFJPJLAGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x61DB860", Offset = "0x61DA460", VA = "0x1861DB860", Slot = "14")]
		public override Rigidbody GetValue(GKJLLILDOOL JEAKPHJODOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x61DB880", Offset = "0x61DA480", VA = "0x1861DB880", Slot = "15")]
		public override void SetValue(GKJLLILDOOL JEAKPHJODOO, Rigidbody BLKAHBIJBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61DB780", Offset = "0x61DA380", VA = "0x1861DB780")]
	public HDGIHFGLJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal class GGJPJCMAMGD : ContainerPropertyBag<DGAFIDPPMFH>
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class OAIBBKLOIPO : Property<DGAFIDPPMFH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string PEJAGGFBEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x61DBD70", Offset = "0x61DA970", VA = "0x1861DBD70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool FHOMOFINOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x61DBD30", Offset = "0x61DA930", VA = "0x1861DBD30")]
		public OAIBBKLOIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x61DB860", Offset = "0x61DA460", VA = "0x1861DB860", Slot = "14")]
		public override object GetValue(DGAFIDPPMFH JEAKPHJODOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x61DB880", Offset = "0x61DA480", VA = "0x1861DB880", Slot = "15")]
		public override void SetValue(DGAFIDPPMFH JEAKPHJODOO, object BLKAHBIJBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61DB4E0", Offset = "0x61DA0E0", VA = "0x1861DB4E0")]
	public GGJPJCMAMGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class HCANLDPHEII : ContainerPropertyBag<GKBNGCOCIMH>
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private class HIMOOGPAMPI : Property<GKBNGCOCIMH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string PEJAGGFBEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x61DB8F0", Offset = "0x61DA4F0", VA = "0x1861DB8F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool FHOMOFINOFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x61DB8B0", Offset = "0x61DA4B0", VA = "0x1861DB8B0")]
		public HIMOOGPAMPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x61DB860", Offset = "0x61DA460", VA = "0x1861DB860", Slot = "14")]
		public override object GetValue(GKBNGCOCIMH JEAKPHJODOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x61DB880", Offset = "0x61DA480", VA = "0x1861DB880", Slot = "15")]
		public override void SetValue(GKBNGCOCIMH JEAKPHJODOO, object BLKAHBIJBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61DB6A0", Offset = "0x61DA2A0", VA = "0x1861DB6A0")]
	public HCANLDPHEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal class LCMAAJCHPLA : ContainerPropertyBag<BJMMJODIAGK>
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private class PPNHACEGFDD : Property<BJMMJODIAGK, HCNAIJBDPFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string PEJAGGFBEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x61DBF20", Offset = "0x61DAB20", VA = "0x1861DBF20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool FHOMOFINOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61DBEE0", Offset = "0x61DAAE0", VA = "0x1861DBEE0")]
		public PPNHACEGFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61DB860", Offset = "0x61DA460", VA = "0x1861DB860", Slot = "14")]
		public override HCNAIJBDPFJ GetValue(BJMMJODIAGK JEAKPHJODOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61DB880", Offset = "0x61DA480", VA = "0x1861DB880", Slot = "15")]
		public override void SetValue(BJMMJODIAGK JEAKPHJODOO, HCNAIJBDPFJ BLKAHBIJBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61DBC10", Offset = "0x61DA810", VA = "0x1861DBC10")]
	public LCMAAJCHPLA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x61DBF50", Offset = "0x61DAB50", VA = "0x1861DBF50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class ALONICFNKBO
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public ALONICFNKBO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
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

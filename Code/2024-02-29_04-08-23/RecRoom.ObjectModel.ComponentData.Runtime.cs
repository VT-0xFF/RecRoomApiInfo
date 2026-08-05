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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
	public class _AssemblyIndex : MLJNMKFIGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x60AB790", Offset = "0x60AA590", VA = "0x1860AB790", Slot = "8")]
		public override void MFEEKKLICMI(NMNCJDKLJOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60AB4C0", Offset = "0x60AA2C0", VA = "0x1860AB4C0", Slot = "7")]
		public override void MEOPLKPOECA(IBOMLBLPLMA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60ABB90", Offset = "0x60AA990", VA = "0x1860ABB90")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KCKHABGPEJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AJGFKPJIJIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode JHNIGALIDLI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DMHFBNPMGIL]
public struct NCLIEGEPKPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PEEEMJJCGFN CHMMLFIIIBE;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly NCLIEGEPKPL IEMILNCFJOJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HDLIODLBEGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GLGFNDOKLMB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum PEEEMJJCGFN
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
public struct IGMNLDMIEOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[InternalBufferCapacity(0)]
public struct EJCJOIFKPIC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity BIFNKFCMILB;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NPKEKCFJCMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity AJKCELPHOFC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IMPHFIDOAAP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HENFNFNIHNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity ADCDJFADKCK;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GJKFBOMHECE : HGJGNGAIBGJ, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FNLKMNMOINE IHNOCLBKBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FNLKMNMOINE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PIHDCMBJJKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 FBHFCMIJCNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JENGDMBIOIJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DMHFBNPMGIL]
public struct FBGBIKHDGGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 IDFMLECGHGM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly FBGBIKHDGGL IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DMHFBNPMGIL]
public struct IENLKNOIAFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 IDFMLECGHGM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly IENLKNOIAFJ IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FAJHHLBBAIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 PLHKJEFPKDD;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct PNJFBBDBJDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 GBKJAANJCCF;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DMHFBNPMGIL]
public struct HHFKENOHDFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float OBHHOAJLMAN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly HHFKENOHDFH IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DMHFBNPMGIL]
public struct IDFOMHIFNLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float LPCAAJKDNLL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly IDFOMHIFNLK IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DOMBMGFNPIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 AJAKDEHIKIA;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MKNKBLFOMFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PMOKGNOEINJ PNBIKGIPGPP;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct IFEHPGFHJDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public PMOKGNOEINJ MNDGJAFPAEJ;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FPPLBKKNIBL]
public struct GBCDKFOCLID : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity KEAAKDKHLOM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MBACEPHBLNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LBOOHGCDKKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BOIHPHBLHPF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HOPOEDCAOGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints CAJIGFCNKFE;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DMHFBNPMGIL]
public struct OAKCHOPNPKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float LGAMILJNGKH;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly OAKCHOPNPKA IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct OHCFFPGLPLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float ALMIPBGDHBO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct AACOMKIADHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct NPCENIJOLNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int HDIGJPNKHEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC163E0", Offset = "0xC151E0", VA = "0x180C163E0")]
	public static NPCENIJOLNL EADAJIFKEOK(int NKKIECLCEML)
	{
		return default(NPCENIJOLNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JLCLLKPMCFI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody EMNDMNOMIMH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60AA8C0", Offset = "0x60A96C0", VA = "0x1860AA8C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JLCLLKPMCFI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DHPJCPFGOBL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PNIKOKFNNKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 NDNOKJPALDK;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OKOCLMLMOBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 FEAOCKEGNIC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DMHFBNPMGIL]
public struct IIOJEGJOFFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float OMFBLEBFAGC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IIOJEGJOFFM IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KBHOPNIAGGF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object CDLKACFEBMH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60AA930", Offset = "0x60A9730", VA = "0x1860AA930", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public KBHOPNIAGGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BPPNNCGKOEJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object KNELAEOBEJK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60AA0E0", Offset = "0x60A8EE0", VA = "0x1860AA0E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public BPPNNCGKOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum PMOKGNOEINJ
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum OIIAKGKODFP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface BNMCAMKAGGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHCEFLDOPOF(PEEEMJJCGFN CLIAGDNIEBC, PEEEMJJCGFN FGMBHENNCGO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKKAKNPKGPD();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJEFOENMCHL();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGCBDINGOMK(bool KFHMHOFNHOL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DEHOBCKKILK();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKKOAHPBOGI();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class OCFKCHDFINI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public BNMCAMKAGGO NLEKEIELOKE;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60AB040", Offset = "0x60A9E40", VA = "0x1860AB040", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public OCFKCHDFINI()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, NMLGMOGBFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60A9D30", Offset = "0x60A8B30", VA = "0x1860A9D30", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, NMLGMOGBFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JDCNNCEIAII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NOMIKFKEOII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity BIKJMPONMKB;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FBDFFEDCOKG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity BIKJMPONMKB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GMNAKELLJDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NativeList<NPONKAHCMLC> GGNIELNEMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeList<Entity> GIHCJNMBPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JobHandle PHKOIIDBFOB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CIOMBLIBDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60AA570", Offset = "0x60A9370", VA = "0x1860AA570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60AA520", Offset = "0x60A9320", VA = "0x1860AA520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x44E0070", Offset = "0x44DEE70", VA = "0x1844E0070")]
	public GMNAKELLJDL(NativeList<NPONKAHCMLC> GGNIELNEMEF, NativeList<Entity> GIHCJNMBPHB, JobHandle PHKOIIDBFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60AA3A0", Offset = "0x60A91A0", VA = "0x1860AA3A0")]
	public (Entity, NativeSlice<Entity>) DGJFPKLGCFN(int PGCIMAABPAK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60AA4C0", Offset = "0x60A92C0", VA = "0x1860AA4C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct NPONKAHCMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Entity ADCDJFADKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int OOCJLKADJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int FAPCCJLFBAA;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ADOEHHLMBOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIPFHBEPKGM(bool ACNJCHHJDMG);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct MACOEFFCPFN : IEquatable<MACOEFFCPFN>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate bool JNBDILMEPLE(int PMIHOHEADPP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly bool EKAHHOINNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly bool LKGLGGLAOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly bool JBGBGKELALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly bool GHBOKICABEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JNBDILMEPLE MKIMFOEIKPG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60AADB0", Offset = "0x60A9BB0", VA = "0x1860AADB0")]
	public MACOEFFCPFN(NONJHGAANGP LJFFFJBJMOK, JNBDILMEPLE MKIMFOEIKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60AADF0", Offset = "0x60A9BF0", VA = "0x1860AADF0")]
	public MACOEFFCPFN(bool EKAHHOINNCF, bool LKGLGGLAOLH, bool JBGBGKELALP, bool GHBOKICABEE, JNBDILMEPLE MKIMFOEIKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60AAD80", Offset = "0x60A9B80", VA = "0x1860AAD80")]
	public bool JBHCIHIMCGI(int PMIHOHEADPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60AAB80", Offset = "0x60A9980", VA = "0x1860AAB80")]
	public bool CNGJLOHJBNG(int PMIHOHEADPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60AAD50", Offset = "0x60A9B50", VA = "0x1860AAD50")]
	public bool HIPHNPLJFGE(int PMIHOHEADPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60AAB50", Offset = "0x60A9950", VA = "0x1860AAB50")]
	public bool ALKNCMDCMEK(int PMIHOHEADPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60AABB0", Offset = "0x60A99B0", VA = "0x1860AABB0", Slot = "4")]
	public bool Equals(MACOEFFCPFN FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60AABE0", Offset = "0x60A99E0", VA = "0x1860AABE0", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60AAC90", Offset = "0x60A9A90", VA = "0x1860AAC90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60AAD30", Offset = "0x60A9B30", VA = "0x1860AAD30")]
	private bool HGOPPHFFIFJ(int PMIHOHEADPP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct MBPJOFJJMGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct DNOLNACLLDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct MGPNLJHNDDG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[InternalBufferCapacity(17)]
public struct NIFALJMPHJI : IBufferElementData, IEquatable<NIFALJMPHJI>, NMLGMOGBFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity BIFNKFCMILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int NDFKLLHMKEI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity KEBMMLINAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60AAED0", Offset = "0x60A9CD0", VA = "0x1860AAED0", Slot = "4")]
	public bool Equals(NIFALJMPHJI FPEEGIOMOFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MOJMEKCEOEG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity JBBBNCIFJCN;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, NMLGMOGBFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8167F0", Offset = "0x8155F0", VA = "0x1808167F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x178A7E0", Offset = "0x17895E0", VA = "0x18178A7E0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60A9D30", Offset = "0x60A8B30", VA = "0x1860A9D30", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct OMMFOPICDPE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly bool MEKBGLMALDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public uint NLGIHLOAADC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	private static bool NEMBABGLKDC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.TypeVersion(2)]
public struct EADICNDEPFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint HPNFNHHPEKF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60AA210", Offset = "0x60A9010", VA = "0x1860AA210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct PGCHBBCPPDF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int ODBNCIFPAEH;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct ECBBKBBLGIN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GCHandle KLNBMNNIGIC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct PJKPKIPKAAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct ACJFBEFIEKK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int ODBNCIFPAEH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct AJOMMKOOFFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct ENPJGDNBKKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct HLBEFHMGFBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct GLLFJFHOFLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct KEICODJDIHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct EIEDJANCJFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct LBJBJNLODAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FixedString32Bytes OHHBGJPCFJD;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[FPPLBKKNIBL]
public struct NOKMLIEBHLL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity HDHKKHFDKEN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static NOKMLIEBHLL EADAJIFKEOK(Entity NKKIECLCEML)
	{
		return default(NOKMLIEBHLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct JFCLKIHGMLL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity KEAAKDKHLOM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static JFCLKIHGMLL EADAJIFKEOK(Entity KEAAKDKHLOM)
	{
		return default(JFCLKIHGMLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct CNNEAENBILD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity NEADJFEOJJM;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HABAMNDGBLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Entity NEADJFEOJJM;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct LHKNFOHMGNM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity PEHCJKHKMPB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static LHKNFOHMGNM EADAJIFKEOK(Entity KEAAKDKHLOM)
	{
		return default(LHKNFOHMGNM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct PLNNMFIGHPC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct MNLLBNHJKHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public uint ILCLKBNEPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[FPPLBKKNIBL]
internal struct DEAHKHNMKDJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity HPPDOIEGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int ENPOKNEMOMH;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct GBLGICCLBKK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity ICJDMMCGALH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct KLOJLKDLMAP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct CODFKBOJOPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint NLGIHLOAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int JAOHKOMFFJH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA58C60", Offset = "0xA57A60", VA = "0x180A58C60")]
	public CODFKBOJOPJ(uint LGKDEGIMMCH, int ENOMBJNGDGM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ONCKEOKMAOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct MMOCFEBKEIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct GEADEEKPKCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct KHIBFNFNFFN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct PIEENCMOCKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct JMMBOIGAPDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MJPHPANDLIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct HIKCAGFAPCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct FNNHCGDCLBK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct ICMHCIHHDLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct DDENKOKCJJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct AJPEHKHKDAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct PDJMCBIIEDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct FHFNAPBDNGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct ODPIIDNGPLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct AIGFMOPCJFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct POPALDLNPFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct MFBGCIHAKJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct OMHAIKLHNAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct OMELFDPEFCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct GLHGECALHDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct IOHECBBBMOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct JDJBJNBHCKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct GMCEGIOAJIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[FPPLBKKNIBL]
public struct IMMIFKLBDHB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FixedString32Bytes HEMGNEANHEC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct HNJMKDIKFAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct HHJOGHCGPHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct NFCPGMFNNDA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct GGKJDDCLCKO : IComponentData, IComparable<GGKJDDCLCKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int JHFKDCOIOFK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1796720", Offset = "0x1795520", VA = "0x181796720", Slot = "4")]
	public int CompareTo(GGKJDDCLCKO FPEEGIOMOFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DMHFBNPMGIL]
public struct KDCEPANBBDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float4x4 EINNBNBAGDD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly KDCEPANBBDG IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DMHFBNPMGIL]
public struct BIDOJAFGNMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float4x4 GBHGFIFOAOD;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BIDOJAFGNMF IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct LOIFMNJJNCC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private int CLILGEFOAEI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ENPOKNEMOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60AAB40", Offset = "0x60A9940", VA = "0x1860AAB40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60AAB30", Offset = "0x60A9930", VA = "0x1860AAB30")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DMHFBNPMGIL]
public struct ACGLGLNGCEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 KOHDLBIANLH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly ACGLGLNGCEM IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DMHFBNPMGIL]
public struct BFMIHFONDDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 JCOIMLJCHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public quaternion GJMDICOFEBG;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly BFMIHFONDDK IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class GAGFFNFGLJM
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[DMHFBNPMGIL]
public struct HDOEHGJFJCK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float BMJKLBIJILN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly HDOEHGJFJCK IEMILNCFJOJ;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct HMMGKIIHNGD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FixedList32Bytes<int> JAKMGJIIIFN;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct KHBOCIGGDPA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FixedList32Bytes<int> JAKMGJIIIFN;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class HPMKFIBPKOL : ContainerPropertyBag<JLCLLKPMCFI>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class DJAPFADKPLO : Property<JLCLLKPMCFI, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string GMLPMAJDOJG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x60AA1E0", Offset = "0x60A8FE0", VA = "0x1860AA1E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool JPJFNMHJCCI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60AA1A0", Offset = "0x60A8FA0", VA = "0x1860AA1A0")]
		public DJAPFADKPLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60AA150", Offset = "0x60A8F50", VA = "0x1860AA150", Slot = "14")]
		public override Rigidbody GetValue(JLCLLKPMCFI PPDHICBEIFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60AA170", Offset = "0x60A8F70", VA = "0x1860AA170", Slot = "15")]
		public override void SetValue(JLCLLKPMCFI PPDHICBEIFC, Rigidbody NKKIECLCEML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60AA660", Offset = "0x60A9460", VA = "0x1860AA660")]
	public HPMKFIBPKOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal class BBOKEMAGLGE : ContainerPropertyBag<KBHOPNIAGGF>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class LAFDPPJFAIM : Property<KBHOPNIAGGF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string GMLPMAJDOJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x60AAB00", Offset = "0x60A9900", VA = "0x1860AAB00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool JPJFNMHJCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60AAAC0", Offset = "0x60A98C0", VA = "0x1860AAAC0")]
		public LAFDPPJFAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60AA150", Offset = "0x60A8F50", VA = "0x1860AA150", Slot = "14")]
		public override object GetValue(KBHOPNIAGGF PPDHICBEIFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60AA170", Offset = "0x60A8F70", VA = "0x1860AA170", Slot = "15")]
		public override void SetValue(KBHOPNIAGGF PPDHICBEIFC, object NKKIECLCEML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x60A9D40", Offset = "0x60A8B40", VA = "0x1860A9D40")]
	public BBOKEMAGLGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class BJMAJCGEJPL : ContainerPropertyBag<BPPNNCGKOEJ>
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class KBIBIDNDPOG : Property<BPPNNCGKOEJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string GMLPMAJDOJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x60AA9E0", Offset = "0x60A97E0", VA = "0x1860AA9E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool JPJFNMHJCCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60AA9A0", Offset = "0x60A97A0", VA = "0x1860AA9A0")]
		public KBIBIDNDPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x60AA150", Offset = "0x60A8F50", VA = "0x1860AA150", Slot = "14")]
		public override object GetValue(BPPNNCGKOEJ PPDHICBEIFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x60AA170", Offset = "0x60A8F70", VA = "0x1860AA170", Slot = "15")]
		public override void SetValue(BPPNNCGKOEJ PPDHICBEIFC, object NKKIECLCEML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60AA000", Offset = "0x60A8E00", VA = "0x1860AA000")]
	public BJMAJCGEJPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal class OCDHBDGHHDF : ContainerPropertyBag<OCFKCHDFINI>
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class MEFEKOEKEIA : Property<OCFKCHDFINI, BNMCAMKAGGO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string GMLPMAJDOJG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x60AAE60", Offset = "0x60A9C60", VA = "0x1860AAE60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool JPJFNMHJCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60AAE20", Offset = "0x60A9C20", VA = "0x1860AAE20")]
		public MEFEKOEKEIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60AA150", Offset = "0x60A8F50", VA = "0x1860AA150", Slot = "14")]
		public override BNMCAMKAGGO GetValue(OCFKCHDFINI PPDHICBEIFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60AA170", Offset = "0x60A8F70", VA = "0x1860AA170", Slot = "15")]
		public override void SetValue(OCFKCHDFINI PPDHICBEIFC, BNMCAMKAGGO NKKIECLCEML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60AAF60", Offset = "0x60A9D60", VA = "0x1860AAF60")]
	public OCDHBDGHHDF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60AB0B0", Offset = "0x60A9EB0", VA = "0x1860AB0B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class JLGMMEPJMLK
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JLGMMEPJMLK()
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

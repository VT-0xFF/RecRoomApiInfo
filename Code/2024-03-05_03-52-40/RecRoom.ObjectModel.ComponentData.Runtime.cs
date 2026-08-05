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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
	public class _AssemblyIndex : HEIIAPOGIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6195E60", Offset = "0x6194C60", VA = "0x186195E60", Slot = "8")]
		public override void LGPDKPMBCMB(HAPHBLIKDOL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6195B90", Offset = "0x6194990", VA = "0x186195B90", Slot = "7")]
		public override void JEBNCHIJAHF(OOAKPECIOPI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6196260", Offset = "0x6195060", VA = "0x186196260")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ECBMJFMLNHA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DJCGHOJLDJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode OELPLALNLPI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OEPCNOCNDEL]
public struct FLFLEFCMHCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public BBBOLAEIGKI NLAGFFICNFN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly FLFLEFCMHCG DKIJAJPJIFN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IIEPOHKIEIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HCENGODKGBF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BBBOLAEIGKI
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
public struct KLNFLKLDHPO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[InternalBufferCapacity(0)]
public struct INLIIBKOGJK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity ENAIIHBGJMJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DLAOOPLEFAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity FEOGIMKDFKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct EPEHAAHJKOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MEIMKNCKBPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity GOKLEGFJHEB;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EMFJDMFKFGG : BLJPPMGBKOF, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CLLDGJOLLJE MEBIHPLENKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(CLLDGJOLLJE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MDMIHECIOLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 CEPMDHGMCLO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IKADLLLPBAI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OEPCNOCNDEL]
public struct EIOJILHELML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 IGGLLNEODMB;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly EIOJILHELML DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OEPCNOCNDEL]
public struct GHNAIJFKNHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 IGGLLNEODMB;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly GHNAIJFKNHD DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JKFFPKAPDNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 FLPLJHBEOPB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DOMGEDEAAGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 KFHNGKPPPEB;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[OEPCNOCNDEL]
public struct CMOGNHIBKAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float KDDOHOOCHHJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CMOGNHIBKAO DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OEPCNOCNDEL]
public struct BADGFGMBDOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float ILCGOBBKFDL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly BADGFGMBDOG DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JMMJBGKOIOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 CLOIDDBPCEO;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MGFJGFNOHKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public JDKPCKNKNHD FGCJPOAPAMO;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FKMDFGNCONB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JDKPCKNKNHD DABEFMJALCL;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KFKELFOCBPI]
public struct EFGLBJAKCOH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity JLCPBIBMCCJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JIANBEJGCEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct CCFHJBOJIEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CMMMIKIIFHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KLCCKJMCDAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints CPCGIPGIALE;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[OEPCNOCNDEL]
public struct KDMMCANFIHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float KBFMHMBPEKC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly KDMMCANFIHL DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NKMENPLBKEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float FPONOBPJGCA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KKKHJFMGCJC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct HLCOLDOACNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int EBBHMPPOANE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD7D620", Offset = "0xD7C420", VA = "0x180D7D620")]
	public static HLCOLDOACNB CCJKPBOFOJB(int MAEBFBHFPDE)
	{
		return default(HLCOLDOACNB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MJCLLIHIOGJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody BNKGAHAACAL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6195640", Offset = "0x6194440", VA = "0x186195640", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MJCLLIHIOGJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LOIHPOFOMEF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FPLIKOCMCCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 BCFCIEMLLAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct AGFJBHJNDCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 HEHJKNMAHHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[OEPCNOCNDEL]
public struct KCJDAEKNGID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float BOBBJPNMAMG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KCJDAEKNGID DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DFOLFNADLLG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object MOCKPMKGABI;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61948B0", Offset = "0x61936B0", VA = "0x1861948B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public DFOLFNADLLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DNPELOHMOMC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object OCALNMKIIDM;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6194920", Offset = "0x6193720", VA = "0x186194920", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public DNPELOHMOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum JDKPCKNKNHD
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum BBFONOIEIIB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface EBHOAKANDLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLNFIAMJPLK(BBBOLAEIGKI JCCAIAGCGGH, BBBOLAEIGKI MGHFFGCLDLJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECHKEMNBLKI();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KGMHAAFDHHN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IMAJCBAAIFC(bool GDPLLHKJJCM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DONALGPPIKB();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNDIMEIDCJM();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HKEPIFABFDH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public EBHOAKANDLL ANFAEPKPBOF;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61951A0", Offset = "0x6193FA0", VA = "0x1861951A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HKEPIFABFDH()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, HMEPPGLCLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x61944B0", Offset = "0x61932B0", VA = "0x1861944B0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, HMEPPGLCLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct PIHHLKOLHAK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct AIJAOHAFLON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity CGCDNDMHDJB;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DFNJIFGOPOJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity CGCDNDMHDJB;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GOPKCCMOPLH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NativeList<BDNFHNEBFJO> JDKPJKFNDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeList<Entity> JGCMMONGDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JobHandle PHIMPJOOHAK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LNCGINAIOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x61950C0", Offset = "0x6193EC0", VA = "0x1861950C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EDOFPONLMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6194F50", Offset = "0x6193D50", VA = "0x186194F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4597630", Offset = "0x4596430", VA = "0x184597630")]
	public GOPKCCMOPLH(NativeList<BDNFHNEBFJO> JDKPJKFNDHL, NativeList<Entity> JGCMMONGDCK, JobHandle PHIMPJOOHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6194FA0", Offset = "0x6193DA0", VA = "0x186194FA0")]
	public (Entity, NativeSlice<Entity>) HMKONJNJPMF(int GKGOKFIMAIP)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6194EF0", Offset = "0x6193CF0", VA = "0x186194EF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BDNFHNEBFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Entity GOKLEGFJHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int LBJEFCOBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int AKCMMEDPGHB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NCKDHGJMLJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOFFEIMEFAM(bool PCJLNONEMIB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct KNMBPKAMPMH : IEquatable<KNMBPKAMPMH>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate bool LMBIHJPHKMP(int GNMODFEIMHL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly bool LMNDFFCIMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly bool PGAGMMGMADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly bool PBEGLNJEGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly bool JOIOPHFKHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LMBIHJPHKMP PENCAABCGGM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61955B0", Offset = "0x61943B0", VA = "0x1861955B0")]
	public KNMBPKAMPMH(PNFLHPNKBIO MDPMDKOAJOO, LMBIHJPHKMP PENCAABCGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6195580", Offset = "0x6194380", VA = "0x186195580")]
	public KNMBPKAMPMH(bool LMNDFFCIMEO, bool PGAGMMGMADB, bool PBEGLNJEGMH, bool JOIOPHFKHBE, LMBIHJPHKMP PENCAABCGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6195520", Offset = "0x6194320", VA = "0x186195520")]
	public bool KLPHGMOGAAM(int GNMODFEIMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6195550", Offset = "0x6194350", VA = "0x186195550")]
	public bool LIJOGNIPNNJ(int GNMODFEIMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6195450", Offset = "0x6194250", VA = "0x186195450")]
	public bool FLEIOCIOAFG(int GNMODFEIMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6195320", Offset = "0x6194120", VA = "0x186195320")]
	public bool CPEOLPHHJGN(int GNMODFEIMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6195350", Offset = "0x6194150", VA = "0x186195350", Slot = "4")]
	public bool Equals(KNMBPKAMPMH EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6195380", Offset = "0x6194180", VA = "0x186195380", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6195480", Offset = "0x6194280", VA = "0x186195480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6195430", Offset = "0x6194230", VA = "0x186195430")]
	private bool FDGJODEMMNH(int GNMODFEIMHL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GEJKIDONNPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct HKNMINPCHGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FGGLIKFACEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[InternalBufferCapacity(17)]
public struct MIJLEFIDLLA : IBufferElementData, IEquatable<MIJLEFIDLLA>, HMEPPGLCLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity ENAIIHBGJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int HGIFDFGOCIH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity BLPNPGGIFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61955F0", Offset = "0x61943F0", VA = "0x1861955F0", Slot = "4")]
	public bool Equals(MIJLEFIDLLA EDOEJIMPOFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct ODOLFHANJDC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity KANCFEJKJBM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, HMEPPGLCLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x86A5A0", Offset = "0x8693A0", VA = "0x18086A5A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x180BEC0", Offset = "0x180ACC0", VA = "0x18180BEC0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x61944B0", Offset = "0x61932B0", VA = "0x1861944B0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KPHFALKJFKE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly bool ADIMDPHMPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public uint EDLKHBIDMDK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	private static bool HDFCKMCAGNF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.TypeVersion(2)]
public struct JNLGNAGIFPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint OOEJHFFJLLH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6195210", Offset = "0x6194010", VA = "0x186195210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct JILIBLBIBFE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int FMKLCCJFDIB;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct GLEONCOHPHH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GCHandle HEOMNDHIEHD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct OFKPOKODGDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct MKKDAONHHNN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int FMKLCCJFDIB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct LMDDOKFIOGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MAEJNOOHFAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct NAIABNBEPNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct OJNACFJBDPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct MGNCOFPAMAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct LNNNEEFMKKN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct AJDHLIBBBMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FixedString32Bytes OCCHBLONHPL;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[KFKELFOCBPI]
public struct KCILNMKEBBP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity KFDCKLAIOIG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static KCILNMKEBBP CCJKPBOFOJB(Entity MAEBFBHFPDE)
	{
		return default(KCILNMKEBBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct CACFDCBPPFF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity JLCPBIBMCCJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static CACFDCBPPFF CCJKPBOFOJB(Entity JLCPBIBMCCJ)
	{
		return default(CACFDCBPPFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct KLGMPCGIFNF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity LJHPDCINFBA;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct NKJBBMMJLBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Entity LJHPDCINFBA;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct KAMEKCLPFAA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity KDMBIAJGEHD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static KAMEKCLPFAA CCJKPBOFOJB(Entity JLCPBIBMCCJ)
	{
		return default(KAMEKCLPFAA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct GHDENCDCKBG : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct OPKIEPBHOAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public uint OCEOBDFJNCG;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[KFKELFOCBPI]
internal struct ODGMPEBGCDG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity ECCHPFIPDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int OHINPGIGDNE;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct NLLEHDMJODI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity MKOPNCBCKGG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct KLHEJOAHEOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct COPLOMKAPKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint EDLKHBIDMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int DDGLJICAJAC;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xAAB8D0", Offset = "0xAAA6D0", VA = "0x180AAB8D0")]
	public COPLOMKAPKG(uint CCHCAMNDAEH, int HDMMHEEOILD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct HJIKFJBAGDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct NEENPDJNCKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct AGOBECLPMMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct NOPJAHDHADI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KCMPJOJCALA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct KPKHKBJGDOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct LAFLCOAEJFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct FLAEKLGLPBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct BGENLCLKOCC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct KNDKNMAPHFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct LDFEKPBMODN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct HFMJBCFNIEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct GOHHKELKICN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct ONLFGKOKOFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct CNFMGPMKHOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GPPGKCDAFAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct ANAOPFJIFAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct LGPDHIJOCGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct HBNBENBAAII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct HBHJAGFIJBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct PNECAFFLCMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct ODHOECEBNDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct ELPHKOHGPIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KABEGGHHMAI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[KFKELFOCBPI]
public struct FHPGAANEFHA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FixedString32Bytes EAHBLLLJAMK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DLNOAIMCEBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct LFHLKIGOGDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct MPDGNIDFJHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct LJNHMKDOKIC : IComponentData, IComparable<LJNHMKDOKIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int AJBKJGBEKJK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1813240", Offset = "0x1812040", VA = "0x181813240", Slot = "4")]
	public int CompareTo(LJNHMKDOKIC EDOEJIMPOFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[OEPCNOCNDEL]
public struct FCKDLNBHBJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float4x4 JEIBPPLFMCE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FCKDLNBHBJJ DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[OEPCNOCNDEL]
public struct NNGAMJCLFJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float4x4 GCBICDLKKHL;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NNGAMJCLFJE DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct ODIOBLELHDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private int NEPBHELFMAB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OHINPGIGDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6195770", Offset = "0x6194570", VA = "0x186195770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6195760", Offset = "0x6194560", VA = "0x186195760")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[OEPCNOCNDEL]
public struct BAABMEHDPCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 OOFNGCDPKLJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly BAABMEHDPCE DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[OEPCNOCNDEL]
public struct AAGGICEKMGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 AJFNKFFNDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public quaternion OKEJHHGCFPM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly AAGGICEKMGM DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class FLNFLLGGIOJ
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[OEPCNOCNDEL]
public struct FBGHDOAGIGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float KEEGDMPOHEB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly FBGHDOAGIGI DKIJAJPJIFN;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct ONJGHPBIGKF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FixedList32Bytes<int> OOECMMNMHLG;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct NCEEDBCDHIB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FixedList32Bytes<int> OOECMMNMHLG;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
internal class CBOIHFEEHPL : ContainerPropertyBag<MJCLLIHIOGJ>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private class BCMFOMIHBDE : Property<MJCLLIHIOGJ, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string PAHJIBDDKIP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6194610", Offset = "0x6193410", VA = "0x186194610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool OJMEMOAMNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61945D0", Offset = "0x61933D0", VA = "0x1861945D0")]
		public BCMFOMIHBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6194580", Offset = "0x6193380", VA = "0x186194580", Slot = "14")]
		public override Rigidbody GetValue(MJCLLIHIOGJ LANMIEEPANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x61945A0", Offset = "0x61933A0", VA = "0x1861945A0", Slot = "15")]
		public override void SetValue(MJCLLIHIOGJ LANMIEEPANH, Rigidbody MAEBFBHFPDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6194720", Offset = "0x6193520", VA = "0x186194720")]
	public CBOIHFEEHPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal class BHLICIFEPBD : ContainerPropertyBag<DFOLFNADLLG>
{
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	private class GBIEOINANJP : Property<DFOLFNADLLG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string PAHJIBDDKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6194DC0", Offset = "0x6193BC0", VA = "0x186194DC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool OJMEMOAMNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6194D80", Offset = "0x6193B80", VA = "0x186194D80")]
		public GBIEOINANJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6194580", Offset = "0x6193380", VA = "0x186194580", Slot = "14")]
		public override object GetValue(DFOLFNADLLG LANMIEEPANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x61945A0", Offset = "0x61933A0", VA = "0x1861945A0", Slot = "15")]
		public override void SetValue(DFOLFNADLLG LANMIEEPANH, object MAEBFBHFPDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6194640", Offset = "0x6193440", VA = "0x186194640")]
	public BHLICIFEPBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal class GALNFNNMNPA : ContainerPropertyBag<DNPELOHMOMC>
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class HACJLKIKLPB : Property<DNPELOHMOMC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string PAHJIBDDKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6195170", Offset = "0x6193F70", VA = "0x186195170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool OJMEMOAMNDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6195130", Offset = "0x6193F30", VA = "0x186195130")]
		public HACJLKIKLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6194580", Offset = "0x6193380", VA = "0x186194580", Slot = "14")]
		public override object GetValue(DNPELOHMOMC LANMIEEPANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x61945A0", Offset = "0x61933A0", VA = "0x1861945A0", Slot = "15")]
		public override void SetValue(DNPELOHMOMC LANMIEEPANH, object MAEBFBHFPDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6194CA0", Offset = "0x6193AA0", VA = "0x186194CA0")]
	public GALNFNNMNPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal class FKPIINHKLOP : ContainerPropertyBag<HKEPIFABFDH>
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	private class DFGELFOJGFM : Property<HKEPIFABFDH, EBHOAKANDLL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string PAHJIBDDKIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6194880", Offset = "0x6193680", VA = "0x186194880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool OJMEMOAMNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6194840", Offset = "0x6193640", VA = "0x186194840")]
		public DFGELFOJGFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6194580", Offset = "0x6193380", VA = "0x186194580", Slot = "14")]
		public override EBHOAKANDLL GetValue(HKEPIFABFDH LANMIEEPANH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61945A0", Offset = "0x61933A0", VA = "0x1861945A0", Slot = "15")]
		public override void SetValue(HKEPIFABFDH LANMIEEPANH, EBHOAKANDLL MAEBFBHFPDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6194B80", Offset = "0x6193980", VA = "0x186194B80")]
	public FKPIINHKLOP()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6195780", Offset = "0x6194580", VA = "0x186195780")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class HPJJGAKKNAL
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HPJJGAKKNAL()
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

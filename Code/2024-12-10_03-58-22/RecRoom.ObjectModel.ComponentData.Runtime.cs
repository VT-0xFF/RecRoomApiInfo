using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D70480", Offset = "0x6D6F080", VA = "0x186D70480", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D70860", Offset = "0x6D6F460", VA = "0x186D70860", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ADMNOIAMICG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, IOHHOLJEHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DB70", Offset = "0x6D6C770", VA = "0x186D6DB70", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, IOHHOLJEHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LEAKHOIIPEJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PEOFEBPCBEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity HFBELHNPKGD;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LMDPECILPCC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity HFBELHNPKGD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HNAOEMJOLDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<FEPMEIKGCCP> ODCEKOLHHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> APPEJMGLJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle PJNBMNEECAJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JJKFDCCDGME
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6ED10", Offset = "0x6D6D910", VA = "0x186D6ED10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EC60", Offset = "0x6D6D860", VA = "0x186D6EC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC690", Offset = "0x4EAB290", VA = "0x184EAC690")]
	public HNAOEMJOLDG(NativeList<FEPMEIKGCCP> ODCEKOLHHJF, NativeList<Entity> APPEJMGLJCI, JobHandle PJNBMNEECAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EB40", Offset = "0x6D6D740", VA = "0x186D6EB40")]
	public (Entity, NativeSlice<Entity>) BKCDAPOPCIE(int EKJHOCEPHIA)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D6ECB0", Offset = "0x6D6D8B0", VA = "0x186D6ECB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FEPMEIKGCCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity AHFIDHNOIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int APMEPKJBNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int OLBMNABBGHI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CFIKKAPKJEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCMFAFBPKOH(bool CJDOAAFCOOM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct CBNMDOLKPAM : IEquatable<CBNMDOLKPAM>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool KAFGCNMFAGB(int EKDFELJLMMH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool LFDEPGKLBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool OJMFIFNABFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool HFJJCNMPOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool FDMILOAMLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KAFGCNMFAGB JFFHNLIJCOP;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DEB0", Offset = "0x6D6CAB0", VA = "0x186D6DEB0")]
	public CBNMDOLKPAM(NCAHLIGACJD KCDIMIFJDPI, KAFGCNMFAGB JFFHNLIJCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DEF0", Offset = "0x6D6CAF0", VA = "0x186D6DEF0")]
	public CBNMDOLKPAM(bool LFDEPGKLBEA, bool OJMFIFNABFO, bool HFJJCNMPOGM, bool FDMILOAMLGN, KAFGCNMFAGB JFFHNLIJCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DDD0", Offset = "0x6D6C9D0", VA = "0x186D6DDD0")]
	public bool IFMEHIFGMBH(int EKDFELJLMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DE00", Offset = "0x6D6CA00", VA = "0x186D6DE00")]
	public bool JAEPBCJDCMD(int EKDFELJLMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DE30", Offset = "0x6D6CA30", VA = "0x186D6DE30")]
	public bool JFIKJGKAEAH(int EKDFELJLMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DE80", Offset = "0x6D6CA80", VA = "0x186D6DE80")]
	public bool PDNOJHPMFIH(int EKDFELJLMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DD00", Offset = "0x6D6C900", VA = "0x186D6DD00", Slot = "4")]
	public bool Equals(CBNMDOLKPAM FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DC50", Offset = "0x6D6C850", VA = "0x186D6DC50", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DD30", Offset = "0x6D6C930", VA = "0x186D6DD30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DE60", Offset = "0x6D6CA60", VA = "0x186D6DE60")]
	private bool NJOIKLGCAAF(int EKDFELJLMMH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HIKMPHIGKJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AGKNCBPEDAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CFDAKMAABFH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct OOIDEAGKKBJ : IBufferElementData, IEquatable<OOIDEAGKKBJ>, IOHHOLJEHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity MADODMHNENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int NNHFLNLJLGN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity EJOJDCJMJND
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FEC0", Offset = "0x6D6EAC0", VA = "0x186D6FEC0", Slot = "4")]
	public bool Equals(OOIDEAGKKBJ FDOEIPBMJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct LCGNBLLFJCG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct KHJDDEHPKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly OPIINFAFECM EJLPKIGKOOI;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
		public KHJDDEHPKAJ(OPIINFAFECM NKNBAKJGNGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F7E0", Offset = "0x6D6E3E0", VA = "0x186D6F7E0")]
		public bool LPPPPGFIHMI(LCGNBLLFJCG DKLAIGNLIFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F7D0", Offset = "0x6D6E3D0", VA = "0x186D6F7D0")]
		public bool GJJBKFDLPBM(LCGNBLLFJCG DKLAIGNLIFK, OPIINFAFECM KJIFJKKFGIB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly OPIINFAFECM PFHBJFGKNGA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
	public LCGNBLLFJCG(OPIINFAFECM PFHBJFGKNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FA10", Offset = "0x6D6E610", VA = "0x186D6FA10")]
	public LCGNBLLFJCG DPHPDJAKHIM(OPIINFAFECM KKJGLMOBAKK)
	{
		return default(LCGNBLLFJCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FA20", Offset = "0x6D6E620", VA = "0x186D6FA20")]
	public LCGNBLLFJCG MGFCANLEDIL(OPIINFAFECM JAAFHDKPPPB)
	{
		return default(LCGNBLLFJCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FA30", Offset = "0x6D6E630", VA = "0x186D6FA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum OPIINFAFECM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TestEmbodiment = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	All = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Flags]
public enum JHKDGFMBEEC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[SingletonComponent]
public struct IDDIFCGJANI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public JHKDGFMBEEC PFHBJFGKNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool PBHHJFBDPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NMCNOPEPFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EDA0", Offset = "0x6D6D9A0", VA = "0x186D6EDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EDD0", Offset = "0x6D6D9D0", VA = "0x186D6EDD0")]
	private IDDIFCGJANI(JHKDGFMBEEC PFHBJFGKNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6ED80", Offset = "0x6D6D980", VA = "0x186D6ED80")]
	public IDDIFCGJANI DPHPDJAKHIM(JHKDGFMBEEC KKJGLMOBAKK)
	{
		return default(IDDIFCGJANI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EDB0", Offset = "0x6D6D9B0", VA = "0x186D6EDB0")]
	public IDDIFCGJANI MGFCANLEDIL(JHKDGFMBEEC JAAFHDKPPPB)
	{
		return default(IDDIFCGJANI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KODLBGCKCNM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LKANGNCBLEF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity BMGEHNEPGKB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, IOHHOLJEHKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DB70", Offset = "0x6D6C770", VA = "0x186D6DB70", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[SingletonComponent]
public struct APJNMAJEDBI : ISystemStateBufferElementData, IBufferElementData, IOHHOLJEHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity OKNDNPBNCCC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity FJGACADKINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PCIOCDEPGFO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity HPOBFOOFPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity BJHBOFFNAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity MMPNJHFHNIA;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HGJNAJAGFLC<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly bool OFMFOLKKKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint MGMHHLKDAIA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool DIFACLPMACF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct HBCKBLIFHHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public uint LGHCKNJFOLO;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E6C0", Offset = "0x6D6D2C0", VA = "0x186D6E6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KBNDEBCJAJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[SingletonComponent]
public struct FNNJDICGCAC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int IOMDGCPLNGN;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DAKEJAEJACP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int CAACCCMGHHA;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JEOICLLIDME : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GCHandle BEIEELJJPOP;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct JDGGNLAPGEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int CAACCCMGHHA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BKCFMEDJJGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct APFIIPDEHPJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int CAACCCMGHHA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HKDEHMDAJPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EOKDHCBBAJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct IDMDEKPMCGN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JAIADFCFBFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CollisionDetectionMode HIEDGHNFCPL;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[RegisterComponentDefault]
public struct LCMBPMPADHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public PFKPGFLKLMF OAKLNNLPFOM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly LCMBPMPADHP GHFEJGGLAKB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FMEKPCJCIML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JOJFOJKAMJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct KAOFHIHGKFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct JFLIPOEGFCJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity MADODMHNENF;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DACFFKNIDKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity CDBGCEIGNJC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PKJOJIPFLOG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MECFCOJOINH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity AHFIDHNOIFE;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MKMJOKFDPOD : JNCHEOMDDME, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OAGOMCPOLNA LLMIDEEHJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(OAGOMCPOLNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CAKKBHBIHHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3 IIEDKJMDIGC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct ELCPFNJKBOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterComponentDefault]
public struct AIOFNIOOGGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 ELANOGBCBLD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly AIOFNIOOGGF GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RegisterComponentDefault]
public struct GBLAOCBLLPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3x3 ELANOGBCBLD;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly GBLAOCBLLPP GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JCINALIOPNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 MEELHOKHILI;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OOLENIKGIDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3 KAAGCIMBKFG;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RegisterComponentDefault]
public struct FJFJKJPEBAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float PCIILPKJMNG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly FJFJKJPEBAB GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct JLLNNIEIFNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float MCMCPAMEIAA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly JLLNNIEIFNA GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PDNLHBLFJPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 LIEOAJBFBJC;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct PFPDNFNIIIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EGPFJKHDCKA GGPFMEACCMA;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BLJKFFIDKCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public EGPFJKHDCKA DOKDIPBJBHN;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[SingletonComponent]
public struct MLJJPMHFIEC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity OKNDNPBNCCC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct PEMECECLKEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct CCLHEKMGEEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct OKLHDJHAKMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public RigidbodyConstraints AINIPHMCKCE;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[RegisterComponentDefault]
public struct HMGJLFDICNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float HODFGNLOPME;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly HMGJLFDICNC GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct IAGGKFLEAMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float DILIKGMIDNL;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class BJGDJCDHJPM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct PPGBLIKHCOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public object ALIHIEOGJHH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject DKOODDCANLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object ANMGBAOFAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object BAKANJLFKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public PPGBLIKHCOG ALIHIEOGJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate BNMKPEBPPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Delegate ABDINECPFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public DBNLNCLIBPO<Delegate> DIIIOANNDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public DBNLNCLIBPO<Delegate> DMHLLNEJDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public DBNLNCLIBPO<Delegate> LFNHFJJFONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public DBNLNCLIBPO<Delegate> KDKJKKKOFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public DBNLNCLIBPO<Delegate> KMIIPFKCNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public DBNLNCLIBPO<Delegate> CPEEIHNPCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public DBNLNCLIBPO<Delegate> MGDAOBPNGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public DBNLNCLIBPO<Delegate> AOGPAJNANCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public DBNLNCLIBPO<Delegate> JMEBKEEAGEJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DC00", Offset = "0x6D6C800", VA = "0x186D6DC00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public BJGDJCDHJPM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LIHKHGMKIDK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct CGINNKIEEPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int PGAOIFFPKGD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1552660", Offset = "0x1551260", VA = "0x181552660")]
	public static CGINNKIEEPO FGDKAMMLLCN(int CABLCDOIFFL)
	{
		return default(CGINNKIEEPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class LOOHBCNLNGA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Rigidbody DOMJNFIKOOO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FCB0", Offset = "0x6D6E8B0", VA = "0x186D6FCB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public LOOHBCNLNGA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct DOFFIGEJEHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct AONDCJNHPMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 CMHJKMGAIPO;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct FGKMBFOJNCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float3 MDMLBPNGPMJ;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[RegisterComponentDefault]
public struct LJBAKDOOOOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float POLCFGAGAIO;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly LJBAKDOOOOL GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KJCNAAFNBDH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object CHCLFDIODOL;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F7F0", Offset = "0x6D6E3F0", VA = "0x186D6F7F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public KJCNAAFNBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class HMMFCJKMDEP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public object DNJDPGMCFCI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EA10", Offset = "0x6D6D610", VA = "0x186D6EA10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HMMFCJKMDEP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FHKGDDLINIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct JMJCKELGJJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct CJHIKLLNCMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct KEDCPLHDIBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct CAIOOFAOCMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct FOIGEFAMCAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FixedString32Bytes GMBAACDNNFI;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SingletonComponent]
public struct MHNMCAIJDBE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity DCLJEHJGEFC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static MHNMCAIJDBE FGDKAMMLLCN(Entity CABLCDOIFFL)
	{
		return default(MHNMCAIJDBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct HJPOPAMIJJA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity OKNDNPBNCCC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static HJPOPAMIJJA FGDKAMMLLCN(Entity OKNDNPBNCCC)
	{
		return default(HJPOPAMIJJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ABCAKMBGDHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity DLOKOLIFNGG;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DJHCNGGCJGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity DLOKOLIFNGG;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct PIMBBJIPANH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity HABHNDLKNEF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0")]
	public static PIMBBJIPANH FGDKAMMLLCN(Entity OKNDNPBNCCC)
	{
		return default(PIMBBJIPANH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct AJNIDAGMBHB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct GNDDBGFBPLN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct NGBHOJOLGIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint OGMJKGKJANG;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[SingletonComponent]
internal struct MMBILJODKHB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity FOHKBJHIPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int MFJLAMOCOBC;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct DOKKJGJNADK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity HICFJNJABJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct IDCMMFMMHFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HDABJPLFINK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public uint MGMHHLKDAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int PLONJPFBENE;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x909730", Offset = "0x908330", VA = "0x180909730")]
	public HDABJPLFINK(uint BLLHBMNDAND, int DAKEHLLLAIP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct BMAOILMEMLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct JHJDBLBMEBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct PFHAPLFMPBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HGJHDAHKJME : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct ICBFPDCNLBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GKLGENEIEGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct JDGNENKONMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct DOOLDPAHOAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct DDHJEEGKIDE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct BBJMBBMAPDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct HHKOPJBAJEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct AEDFMIDPIAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct DIPGKCIEMCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct AFJLFMFMOJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal struct PFOKJNOGEHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct LKJLPBFGEGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct MINJBFCGDAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct NNPNIMKHJLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct FJEAIMIMMFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct IEBPNIOENAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MGFMNKIKOJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct KPOIJEFBHFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct PNPNHBBDHPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct JKPKFLDABGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct FBKBGJJACPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct KADJJEKBJAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct NFOOGLPGJHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct ABMBKLKCIBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct OGPKCKANODH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[SingletonComponent]
public struct OGJPHALKHEK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes GPACIGDFIMA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct PBIOKIGLDEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct FCBGBGMJFKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct HEPFKBMPFFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct ABHLMJJHCIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal struct OEJOEKPLFFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct FCGPOBILELB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct NENOHCFDJAB : IComponentData, IComparable<NENOHCFDJAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int GFHBGJLHPGL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1835840", Offset = "0x1834440", VA = "0x181835840", Slot = "4")]
	public int CompareTo(NENOHCFDJAB FDOEIPBMJJM)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct HJMDPMMJAIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct MHAAKHDHMEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public quaternion EAGKGJHHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 GKJAMFFKDLE;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct DDGILLNJBBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float PHJDEKOPNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float OIJABLCBJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float CDDNOAMLGPD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ABBFFKNCDBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct LJBHHIBNGAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct BJHGJDEMHLH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct IPAIAINPNIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int CAACCCMGHHA;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[SingletonComponent]
public struct MJCAAOKPBCK : ISystemStateBufferElementData, IBufferElementData, IOHHOLJEHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity APFPONLDBCK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity FJGACADKINK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[RegisterComponentDefault]
public struct CLGIJEJDHAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 HBCHLBPEEHC;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly CLGIJEJDHAD GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RegisterComponentDefault]
public struct HJMKEOCMNLA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float4x4 ICJJPDGCFNI;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly HJMKEOCMNLA GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct PHAIEOCAEDJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int ACBKFPALHDE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MFJLAMOCOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FF90", Offset = "0x6D6EB90", VA = "0x186D6FF90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FF80", Offset = "0x6D6EB80", VA = "0x186D6FF80")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RegisterComponentDefault]
public struct BAMBMGGECBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 JLHAOGPHCLP;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly BAMBMGGECBN GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RegisterComponentDefault]
public struct FGHAOLHIIAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 GKJAMFFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public quaternion EAGKGJHHIJH;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly FGHAOLHIIAB GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class GKLKKGJLBAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RegisterComponentDefault]
public struct LFBCFPDJIMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float LEPHCHIBNPA;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly LFBCFPDJIMM GHFEJGGLAKB;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct MMFFPHHHGME : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity PKJMBHGNAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AFHJIGHFEFH CHCPEAEKFEB;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct AGPGBIEHIMC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AFHJIGHFEFH CHCPEAEKFEB;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct KLDMANCKFPA : ISystemStateComponentData, IComponentData, IOHHOLJEHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity LCMKGCMMEHM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity FJGACADKINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct OBLHOPCCIDB : ISystemStateBufferElementData, IBufferElementData, IOHHOLJEHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity IGPBDGBPBFN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity FJGACADKINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct FDKJGNDLIGH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity PKJMBHGNAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public AFHJIGHFEFH CHCPEAEKFEB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct IMMCJIGDAKK : IEqualityComparer<FDKJGNDLIGH>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static IMMCJIGDAKK GHFEJGGLAKB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EDE0", Offset = "0x6D6D9E0", VA = "0x186D6EDE0", Slot = "4")]
	public bool Equals(FDKJGNDLIGH MBJABMPNEHF, FDKJGNDLIGH MNMGCDILGBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6EE30", Offset = "0x6D6DA30", VA = "0x186D6EE30", Slot = "5")]
	public int GetHashCode(FDKJGNDLIGH PLAMADMDGIO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct LDACJBHDFPO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> IONNJJHBKGH;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct LNOEOJCKOCF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FixedList32Bytes<int> IONNJJHBKGH;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct EEDMFEDJFAH : ISystemStateBufferElementData, IBufferElementData, IOHHOLJEHKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity JOCHBJGCHJO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity EJOJDCJMJND
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA644F0", Offset = "0xA630F0", VA = "0x180A644F0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x100D370", Offset = "0x100BF70", VA = "0x18100D370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class KCPFBFGFPFE : ContainerPropertyBag<BJGDJCDHJPM>
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class OPKKOKHCJPN : Property<BJGDJCDHJPM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6D6FF50", Offset = "0x6D6EB50", VA = "0x186D6FF50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FF10", Offset = "0x6D6EB10", VA = "0x186D6FF10")]
		public OPKKOKHCJPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D700", Offset = "0x6D6C300", VA = "0x186D6D700", Slot = "14")]
		public override GameObject GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D720", Offset = "0x6D6C320", VA = "0x186D6D720", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, GameObject CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class NKDDLOEIOMF : Property<BJGDJCDHJPM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D6FDB0", Offset = "0x6D6E9B0", VA = "0x186D6FDB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FD70", Offset = "0x6D6E970", VA = "0x186D6FD70")]
		public NKDDLOEIOMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FD20", Offset = "0x6D6E920", VA = "0x186D6FD20", Slot = "14")]
		public override object GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FD40", Offset = "0x6D6E940", VA = "0x186D6FD40", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, object CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class COAAPIKHOPH : Property<BJGDJCDHJPM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6D6E140", Offset = "0x6D6CD40", VA = "0x186D6E140", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E100", Offset = "0x6D6CD00", VA = "0x186D6E100")]
		public COAAPIKHOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E0B0", Offset = "0x6D6CCB0", VA = "0x186D6E0B0", Slot = "14")]
		public override object GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E0D0", Offset = "0x6D6CCD0", VA = "0x186D6E0D0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, object CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class KNHPCDFLCJC : Property<BJGDJCDHJPM, BJGDJCDHJPM.PPGBLIKHCOG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6D6F9E0", Offset = "0x6D6E5E0", VA = "0x186D6F9E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F9A0", Offset = "0x6D6E5A0", VA = "0x186D6F9A0")]
		public KNHPCDFLCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F950", Offset = "0x6D6E550", VA = "0x186D6F950", Slot = "14")]
		public override BJGDJCDHJPM.PPGBLIKHCOG GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(BJGDJCDHJPM.PPGBLIKHCOG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F970", Offset = "0x6D6E570", VA = "0x186D6F970", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, BJGDJCDHJPM.PPGBLIKHCOG CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class HMONHFPLKCH : Property<BJGDJCDHJPM, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6D6EB10", Offset = "0x6D6D710", VA = "0x186D6EB10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EAD0", Offset = "0x6D6D6D0", VA = "0x186D6EAD0")]
		public HMONHFPLKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EA80", Offset = "0x6D6D680", VA = "0x186D6EA80", Slot = "14")]
		public override Delegate GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EAA0", Offset = "0x6D6D6A0", VA = "0x186D6EAA0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, Delegate CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class CPFHPPNDLHP : Property<BJGDJCDHJPM, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6D6E200", Offset = "0x6D6CE00", VA = "0x186D6E200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E1C0", Offset = "0x6D6CDC0", VA = "0x186D6E1C0")]
		public CPFHPPNDLHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E170", Offset = "0x6D6CD70", VA = "0x186D6E170", Slot = "14")]
		public override Delegate GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E190", Offset = "0x6D6CD90", VA = "0x186D6E190", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, Delegate CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class JPNINLNDLCD : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6D6F060", Offset = "0x6D6DC60", VA = "0x186D6F060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F020", Offset = "0x6D6DC20", VA = "0x186D6F020")]
		public JPNINLNDLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EFB0", Offset = "0x6D6DBB0", VA = "0x186D6EFB0", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EFE0", Offset = "0x6D6DBE0", VA = "0x186D6EFE0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class HKMOPLGOCKG : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6D6E9A0", Offset = "0x6D6D5A0", VA = "0x186D6E9A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E960", Offset = "0x6D6D560", VA = "0x186D6E960")]
		public HKMOPLGOCKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E8F0", Offset = "0x6D6D4F0", VA = "0x186D6E8F0", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E920", Offset = "0x6D6D520", VA = "0x186D6E920", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class ANKGCJCABEK : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6D6DB40", Offset = "0x6D6C740", VA = "0x186D6DB40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DB00", Offset = "0x6D6C700", VA = "0x186D6DB00")]
		public ANKGCJCABEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DA90", Offset = "0x6D6C690", VA = "0x186D6DA90", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DAC0", Offset = "0x6D6C6C0", VA = "0x186D6DAC0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class LHAOJGDPKAJ : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6D6FC40", Offset = "0x6D6E840", VA = "0x186D6FC40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FC00", Offset = "0x6D6E800", VA = "0x186D6FC00")]
		public LHAOJGDPKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FB80", Offset = "0x6D6E780", VA = "0x186D6FB80", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FBC0", Offset = "0x6D6E7C0", VA = "0x186D6FBC0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class EANIDGMEHGL : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6D6E3D0", Offset = "0x6D6CFD0", VA = "0x186D6E3D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E390", Offset = "0x6D6CF90", VA = "0x186D6E390")]
		public EANIDGMEHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E310", Offset = "0x6D6CF10", VA = "0x186D6E310", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E350", Offset = "0x6D6CF50", VA = "0x186D6E350", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class HDAGEKFEHEE : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6D6E810", Offset = "0x6D6D410", VA = "0x186D6E810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E7D0", Offset = "0x6D6D3D0", VA = "0x186D6E7D0")]
		public HDAGEKFEHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E750", Offset = "0x6D6D350", VA = "0x186D6E750", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E790", Offset = "0x6D6D390", VA = "0x186D6E790", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class AKHMJOPBMEI : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6D6DA60", Offset = "0x6D6C660", VA = "0x186D6DA60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DA20", Offset = "0x6D6C620", VA = "0x186D6DA20")]
		public AKHMJOPBMEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D9A0", Offset = "0x6D6C5A0", VA = "0x186D6D9A0", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D9E0", Offset = "0x6D6C5E0", VA = "0x186D6D9E0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class AIIPOMMPMJJ : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D880", Offset = "0x6D6C480", VA = "0x186D6D880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D840", Offset = "0x6D6C440", VA = "0x186D6D840")]
		public AIIPOMMPMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D7C0", Offset = "0x6D6C3C0", VA = "0x186D6D7C0", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D800", Offset = "0x6D6C400", VA = "0x186D6D800", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class KLMMJIFEFCE : Property<BJGDJCDHJPM, DBNLNCLIBPO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6D6F920", Offset = "0x6D6E520", VA = "0x186D6F920", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F8E0", Offset = "0x6D6E4E0", VA = "0x186D6F8E0")]
		public KLMMJIFEFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F860", Offset = "0x6D6E460", VA = "0x186D6F860", Slot = "14")]
		public override DBNLNCLIBPO<Delegate> GetValue(BJGDJCDHJPM EBEEBGHJNFK)
		{
			return default(DBNLNCLIBPO<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6F8A0", Offset = "0x6D6E4A0", VA = "0x186D6F8A0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM EBEEBGHJNFK, DBNLNCLIBPO<Delegate> CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F170", Offset = "0x6D6DD70", VA = "0x186D6F170")]
	public KCPFBFGFPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class CKKBMLIOMIM : ContainerPropertyBag<BJGDJCDHJPM.PPGBLIKHCOG>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class JKHLPPHOKBC : Property<BJGDJCDHJPM.PPGBLIKHCOG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6D6EF40", Offset = "0x6D6DB40", VA = "0x186D6EF40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EF00", Offset = "0x6D6DB00", VA = "0x186D6EF00")]
		public JKHLPPHOKBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xF5F430", Offset = "0xF5E030", VA = "0x180F5F430", Slot = "14")]
		public override object GetValue(BJGDJCDHJPM.PPGBLIKHCOG EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x49BC4D0", Offset = "0x49BB0D0", VA = "0x1849BC4D0", Slot = "15")]
		public override void SetValue(BJGDJCDHJPM.PPGBLIKHCOG EBEEBGHJNFK, object CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D6DF20", Offset = "0x6D6CB20", VA = "0x186D6DF20")]
	public CKKBMLIOMIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class GNKKOPPNGHM : ContainerPropertyBag<DBNLNCLIBPO<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E660", Offset = "0x6D6D260", VA = "0x186D6E660")]
	public GNKKOPPNGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class DHOFOLCGBGH : ContainerPropertyBag<LOOHBCNLNGA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class LGGBIEIDOKO : Property<LOOHBCNLNGA, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6D6FB50", Offset = "0x6D6E750", VA = "0x186D6FB50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FB10", Offset = "0x6D6E710", VA = "0x186D6FB10")]
		public LGGBIEIDOKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D700", Offset = "0x6D6C300", VA = "0x186D6D700", Slot = "14")]
		public override Rigidbody GetValue(LOOHBCNLNGA EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D720", Offset = "0x6D6C320", VA = "0x186D6D720", Slot = "15")]
		public override void SetValue(LOOHBCNLNGA EBEEBGHJNFK, Rigidbody CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6E230", Offset = "0x6D6CE30", VA = "0x186D6E230")]
	public DHOFOLCGBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class OFKCCJODBMA : ContainerPropertyBag<KJCNAAFNBDH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	private class JCJLLAHOJDH : Property<KJCNAAFNBDH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D6EED0", Offset = "0x6D6DAD0", VA = "0x186D6EED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D6EE90", Offset = "0x6D6DA90", VA = "0x186D6EE90")]
		public JCJLLAHOJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D700", Offset = "0x6D6C300", VA = "0x186D6D700", Slot = "14")]
		public override object GetValue(KJCNAAFNBDH EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D720", Offset = "0x6D6C320", VA = "0x186D6D720", Slot = "15")]
		public override void SetValue(KJCNAAFNBDH EBEEBGHJNFK, object CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6FDE0", Offset = "0x6D6E9E0", VA = "0x186D6FDE0")]
	public OFKCCJODBMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class KAMFINEGCJO : ContainerPropertyBag<HMMFCJKMDEP>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class ADGPODANPGO : Property<HMMFCJKMDEP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string IHBMAHBKJLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D790", Offset = "0x6D6C390", VA = "0x186D6D790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool POMDFADBODP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D750", Offset = "0x6D6C350", VA = "0x186D6D750")]
		public ADGPODANPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D700", Offset = "0x6D6C300", VA = "0x186D6D700", Slot = "14")]
		public override object GetValue(HMMFCJKMDEP EBEEBGHJNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D720", Offset = "0x6D6C320", VA = "0x186D6D720", Slot = "15")]
		public override void SetValue(HMMFCJKMDEP EBEEBGHJNFK, object CABLCDOIFFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D6F090", Offset = "0x6D6DC90", VA = "0x186D6F090")]
	public KAMFINEGCJO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D6FFA0", Offset = "0x6D6EBA0", VA = "0x186D6FFA0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class IGMOIHGFJHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public IGMOIHGFJHJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
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

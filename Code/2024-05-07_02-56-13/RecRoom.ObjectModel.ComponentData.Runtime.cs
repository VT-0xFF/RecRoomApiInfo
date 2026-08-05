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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
	public class _AssemblyIndex : CAKBDCNKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62B5C30", Offset = "0x62B4E30", VA = "0x1862B5C30", Slot = "8")]
		public override void LFGBMGLIJAD(PDIHABEAKLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x62B5900", Offset = "0x62B4B00", VA = "0x1862B5900", Slot = "7")]
		public override void IINKMOFLHPO(FFJDENDLOOB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62B6010", Offset = "0x62B5210", VA = "0x1862B6010")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EECMCBNELBL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, IMDCEKFCFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62B30A0", Offset = "0x62B22A0", VA = "0x1862B30A0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
		public AuthoredChildrenData(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static implicit operator AuthoredChildrenData(Entity entity)
		{
			return default(AuthoredChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, IMDCEKFCFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MBEDFJBFAJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MALFACKFCJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity EAKIHPHMGNJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MIOGAOJLLFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity EAKIHPHMGNJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CHPHCLJDLAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<OPNICECBJBF> KFJAAJFKGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> NHBCKLPDFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle FMIOCBOJMFC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JFENMLEHNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62B3230", Offset = "0x62B2430", VA = "0x1862B3230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62B31E0", Offset = "0x62B23E0", VA = "0x1862B31E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4712900", Offset = "0x4711B00", VA = "0x184712900")]
	public CHPHCLJDLAE(NativeList<OPNICECBJBF> KFJAAJFKGJC, NativeList<Entity> NHBCKLPDFEC, JobHandle FMIOCBOJMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x62B32A0", Offset = "0x62B24A0", VA = "0x1862B32A0")]
	public (Entity, NativeSlice<Entity>) OCBHMFJDMFM(int GJIHJJPNBNJ)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62B3180", Offset = "0x62B2380", VA = "0x1862B3180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OPNICECBJBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity MIAAKEAGJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int BJPGLMJPACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int HHOELNLHIEN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NANLOOGAICB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPNDCOMICPE(bool HMLLKAFMCLD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct CIKHAOECKEP : IEquatable<CIKHAOECKEP>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool FCGHIKEAPHE(int BMIJGDHAHBI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool KEIMECPJLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool ODENHNIANJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool OCLOANMABFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool NEMNCPILNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FCGHIKEAPHE GIOLHOEPMDO;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62B36C0", Offset = "0x62B28C0", VA = "0x1862B36C0")]
	public CIKHAOECKEP(DMFJIBOHKNI KIAPHNPFBHE, FCGHIKEAPHE GIOLHOEPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62B3690", Offset = "0x62B2890", VA = "0x1862B3690")]
	public CIKHAOECKEP(bool KEIMECPJLNE, bool ODENHNIANJE, bool OCLOANMABFH, bool NEMNCPILNAH, FCGHIKEAPHE GIOLHOEPMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62B3600", Offset = "0x62B2800", VA = "0x1862B3600")]
	public bool LELJEOLKGBH(int BMIJGDHAHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62B3660", Offset = "0x62B2860", VA = "0x1862B3660")]
	public bool LKDHFIEIDAK(int BMIJGDHAHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62B3630", Offset = "0x62B2830", VA = "0x1862B3630")]
	public bool LJNIJHKMNPO(int BMIJGDHAHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62B35D0", Offset = "0x62B27D0", VA = "0x1862B35D0")]
	public bool HKOMJOBNIMN(int BMIJGDHAHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62B3430", Offset = "0x62B2630", VA = "0x1862B3430", Slot = "4")]
	public bool Equals(CIKHAOECKEP NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62B3460", Offset = "0x62B2660", VA = "0x1862B3460", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62B3530", Offset = "0x62B2730", VA = "0x1862B3530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62B3510", Offset = "0x62B2710", VA = "0x1862B3510")]
	private bool GCMGKHIMPKE(int BMIJGDHAHBI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FBNAMEMMAAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JELIHPCHKME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BEDGJCKGCLM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct LGJLNJCNFFL : IBufferElementData, IEquatable<LGJLNJCNFFL>, IMDCEKFCFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity DEGINJHPGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int MJOBHIAHLCN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity OHJLJOONLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62B4A20", Offset = "0x62B3C20", VA = "0x1862B4A20", Slot = "4")]
	public bool Equals(LGJLNJCNFFL NOBJAPGNDAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JNELIAHOOEE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity NLKEPCJNNED;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, IMDCEKFCFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62B30A0", Offset = "0x62B22A0", VA = "0x1862B30A0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct GOJGOCDEJHJ<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly bool KMIBCIBKNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint ICOOKDEDBBH;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	private static bool ALJJGFKDHJI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.TypeVersion(2)]
public struct FEKMONIIIBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public uint EBEJNHLDNJM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62B3F90", Offset = "0x62B3190", VA = "0x1862B3F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IBAMNPJNCAG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public int FNJDHDECLPG;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IJOGOIPKEOG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public GCHandle MFKMKABACHK;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct KKGPBBBOHOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int FNJDHDECLPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PMCMFGHPDLC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BPJEEPJDOFO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int FNJDHDECLPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BKHMPNDPIAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct AHDDCDNMPIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ONMPJBAMMFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IEIEJAMLDGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CollisionDetectionMode BEDEEBDNMFM;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[EPOKBJHPJBE]
public struct KIEAPMHJAAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public PGDHFLLAIAB PMLHDOBKICP;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly KIEAPMHJAAN CGCFGJJDBDI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JGDBLDCIBGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct BDDEIJHJMHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct AGLPJMDDMFK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[InternalBufferCapacity(0)]
public struct NHEPJHIGFJO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Entity DEGINJHPGFA;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OBEGHCKLJIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity BHNONFFBKHO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FJHEJDMBGNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct FLCNOAPLIJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity MIAAKEAGJGI;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct IFFPECLLDIG : EKMIDNDKGON, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AMNPIJKABKO KFEHFNEHCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(AMNPIJKABKO);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LJKJEAMKFIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 MNGMGGGOAJB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct ALDIPJMEOAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[EPOKBJHPJBE]
public struct MANLDCEPDAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3x3 JOOIMGMBBCM;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly MANLDCEPDAI CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[EPOKBJHPJBE]
public struct KMHFIDBAJCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 JOOIMGMBBCM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly KMHFIDBAJCJ CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HBODIJKIAFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 JJPKCFMKMFJ;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EPCPABCBNIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3 PGECKPPOHFN;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[EPOKBJHPJBE]
public struct IMBFJFFAMHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float PLNEOMNIDDL;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly IMBFJFFAMHA CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[EPOKBJHPJBE]
public struct LPHALGHCEDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float IKALNGDHJLK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly LPHALGHCEDM CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct PNEJFKEGEBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float3 FKMCDAMJKEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FLIHAKBCLMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public ANOFOMAGMPD JMKNFJCECHO;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GPMKNOHHGFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public ANOFOMAGMPD BJHHGAPFLJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ACKFBHLNIMF]
public struct DGIPMPNBAOH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity NFFCGLFHPNG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct GNBECGEGFHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct IGAODCPKLKO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct KHPHAMOPLAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public RigidbodyConstraints LAHLNEAOJKI;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[EPOKBJHPJBE]
public struct KHKMMCMCAHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float FNFPENLAOHJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly KHKMMCMCAHP CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct IJIHGJLHDOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float ICEHDFEGFAC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class AIFPHELDACK : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct ODGMCIGJBLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public object MMBOHDDPJJN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public GameObject OPEBICILKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object ONPBKHJGMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public object HEJMMHOFKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public ODGMCIGJBLM MMBOHDDPJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Delegate MJCNEHNAOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Delegate HKLMEGKLAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public HAJELMLNIMF<Delegate> CEEGCOANPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public HAJELMLNIMF<Delegate> ABLPLIFJLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public HAJELMLNIMF<Delegate> HJAHHNHBPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public HAJELMLNIMF<Delegate> GBGHELBPJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public HAJELMLNIMF<Delegate> GILEHAAIIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public HAJELMLNIMF<Delegate> CDNFCNMEIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public HAJELMLNIMF<Delegate> MMMEBJFNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HAJELMLNIMF<Delegate> DANPKEDIJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public HAJELMLNIMF<Delegate> LFICPFGLEEK;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62B2EA0", Offset = "0x62B20A0", VA = "0x1862B2EA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public AIFPHELDACK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct CDFEHJIFBCA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AOKHDKHMGKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int ANLIGPJEJNI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
	public static AOKHDKHMGKP LOOIAEAGNBK(int NICEPFIEJED)
	{
		return default(AOKHDKHMGKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MGPBDGPEAPI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Rigidbody LAANOCCOMFF;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62B4D40", Offset = "0x62B3F40", VA = "0x1862B4D40", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MGPBDGPEAPI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KDIIOANANBK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct KLCJNCEIPKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 IACHFILKNFB;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GPNAPPAAOPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 JPMMLNGJNDB;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[EPOKBJHPJBE]
public struct DJAFDBKCCPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float OLJJGOCOBMP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly DJAFDBKCCPE CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class BEEECNGFFCC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object MHLAEMECHPG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62B30B0", Offset = "0x62B22B0", VA = "0x1862B30B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public BEEECNGFFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class GHFHJGLOOKD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object PAMAKDAHHPP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62B4100", Offset = "0x62B3300", VA = "0x1862B4100", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GHFHJGLOOKD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct KFIOPAKCLKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct CGCLEDOKHEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct NDLCAMEPFGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct KEOJGNDAODJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FixedString32Bytes IKEFBMMMAJB;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[ACKFBHLNIMF]
public struct PAFNHCABNJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity MHMLGKPICFI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static PAFNHCABNJN LOOIAEAGNBK(Entity NICEPFIEJED)
	{
		return default(PAFNHCABNJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct CBOFDPKIMOI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Entity NFFCGLFHPNG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static CBOFDPKIMOI LOOIAEAGNBK(Entity NFFCGLFHPNG)
	{
		return default(CBOFDPKIMOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct MHMLPGKDKKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity COPABGKAFAH;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct KPJHANKBPKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity COPABGKAFAH;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct BJFIEEIGFIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity BBBBCCNNDAF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static BJFIEEIGFIC LOOIAEAGNBK(Entity NFFCGLFHPNG)
	{
		return default(BJFIEEIGFIC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct CBIBCFIOGDP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EAOJINLLDGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint LOGOABBJBAN;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[ACKFBHLNIMF]
internal struct JFPJGCHOEKP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity LCKPAHBGKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int HMFNCGHECPG;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct JGNHMPIENMP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity PEFLLODODLA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct NJONEGHDBNP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct BMKHDCANKDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public uint ICOOKDEDBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int HCJJMCPIAHO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAF4D20", Offset = "0xAF3F20", VA = "0x180AF4D20")]
	public BMKHDCANKDK(uint NNDHLMIGBEN, int LONFFAIDMFF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct JKLPDFLBJJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct HBPGGGMJCOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct EKIHJEBGGFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct DCDBMDMAAAI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct EMFFFNMGENN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct ILDABEENNAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct DHGDGNLMDHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct PGOICBCFPAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct NMBOFKLAIPC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct OPHNBNBBODK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct DADIGHKABCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct NEHOFKEHGHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct BPDLDLNJKGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct MGLENIDBEGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct EHGDAPBCHOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct JDBICCPICAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct CDEIEAIPGLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct PALEPELHNKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct JFDGCLOEPDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct CEHLDENJAKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct OJJBLLPNPBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct FJDJDPHDNOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct GBGDGPCLEIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct KKLFCOONCGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct PBAOLBNOMED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct NLFHFPFMDNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KNGJMOGPJFL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[ACKFBHLNIMF]
public struct LJAFEKMNMJF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public FixedString32Bytes NOPGIOBJJNI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct IDLHDAHKHDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct IBDJBFLONPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct FAMGMAOBNDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct IIBJBBMFCOG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct NJBNINPPHKK : IComponentData, IComparable<NJBNINPPHKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int ABFKLBFLJOA;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18AC8F0", Offset = "0x18ABAF0", VA = "0x1818AC8F0", Slot = "4")]
	public int CompareTo(NJBNINPPHKK NOBJAPGNDAK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct JMMFCDNGLCH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BKHCEGNPIEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion HBCECKEGCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 DHMMMGDKPCG;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct OPKLLAGKAMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float AFGEGDDPANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float LGGHKDOMACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float NBCMDKJLGGD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct CALMPHHLLKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct POOIDFBMMPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct BLMDAHDCLCG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OIIGNILHHMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int FNJDHDECLPG;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[ACKFBHLNIMF]
public struct JAILLCCFKFB : ISystemStateBufferElementData, IBufferElementData, IMDCEKFCFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity POKLKCPNLGE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity GCAHNCHIFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x18A74B0", Offset = "0x18A66B0", VA = "0x1818A74B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[EPOKBJHPJBE]
public struct ABDMBJNOANO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float4x4 HHHGPOPHIGH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly ABDMBJNOANO CGCFGJJDBDI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct IIKKOPGJLKM : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct PGBGCANOEPO : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct LDHIOAPKPGA : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct KHCMDEAIKEK : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[EPOKBJHPJBE]
public struct PBHKCPICECG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float4x4 JGFCBJHFPMK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly PBHKCPICECG CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct OGLKJNCNLGG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int AGDFNMHNLOG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int HMFNCGHECPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62B51F0", Offset = "0x62B43F0", VA = "0x1862B51F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62B5200", Offset = "0x62B4400", VA = "0x1862B5200")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[EPOKBJHPJBE]
public struct OHPJIGGNOJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 KGDNBIJEJIM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly OHPJIGGNOJG CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[EPOKBJHPJBE]
public struct NKKDGDOINHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 DHMMMGDKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public quaternion HBCECKEGCGH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly NKKDGDOINHM CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class PCIHKOLIKIL
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[EPOKBJHPJBE]
public struct CKGGOOLHAAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float KBCBJLGLGBD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly CKGGOOLHAAL CGCFGJJDBDI;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FNCGIMFDIHC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedList32Bytes<int> EHMKHCNPLNL;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct DFHDNKHEELJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FixedList32Bytes<int> EHMKHCNPLNL;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal class CJJCMMPOKHJ : ContainerPropertyBag<AIFPHELDACK>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class JBAJIMJEMKM : Property<AIFPHELDACK, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x62B4520", Offset = "0x62B3720", VA = "0x1862B4520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62B44E0", Offset = "0x62B36E0", VA = "0x1862B44E0")]
		public JBAJIMJEMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62B2DE0", Offset = "0x62B1FE0", VA = "0x1862B2DE0", Slot = "14")]
		public override GameObject GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62B2E00", Offset = "0x62B2000", VA = "0x1862B2E00", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, GameObject NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private class LOEKDOHEFNG : Property<AIFPHELDACK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x62B4B00", Offset = "0x62B3D00", VA = "0x1862B4B00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x62B4AC0", Offset = "0x62B3CC0", VA = "0x1862B4AC0")]
		public LOEKDOHEFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62B4A70", Offset = "0x62B3C70", VA = "0x1862B4A70", Slot = "14")]
		public override object GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62B4A90", Offset = "0x62B3C90", VA = "0x1862B4A90", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, object NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private class ALMHFCEHBHD : Property<AIFPHELDACK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x62B3070", Offset = "0x62B2270", VA = "0x1862B3070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62B3030", Offset = "0x62B2230", VA = "0x1862B3030")]
		public ALMHFCEHBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x62B2FE0", Offset = "0x62B21E0", VA = "0x1862B2FE0", Slot = "14")]
		public override object GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62B3000", Offset = "0x62B2200", VA = "0x1862B3000", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, object NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class KMODANFIFKL : Property<AIFPHELDACK, AIFPHELDACK.ODGMCIGJBLM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62B4830", Offset = "0x62B3A30", VA = "0x1862B4830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62B47F0", Offset = "0x62B39F0", VA = "0x1862B47F0")]
		public KMODANFIFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62B47A0", Offset = "0x62B39A0", VA = "0x1862B47A0", Slot = "14")]
		public override AIFPHELDACK.ODGMCIGJBLM GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(AIFPHELDACK.ODGMCIGJBLM);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62B47C0", Offset = "0x62B39C0", VA = "0x1862B47C0", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, AIFPHELDACK.ODGMCIGJBLM NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class ELPCCFEGJJB : Property<AIFPHELDACK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62B3F60", Offset = "0x62B3160", VA = "0x1862B3F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62B3F20", Offset = "0x62B3120", VA = "0x1862B3F20")]
		public ELPCCFEGJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62B3ED0", Offset = "0x62B30D0", VA = "0x1862B3ED0", Slot = "14")]
		public override Delegate GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62B3EF0", Offset = "0x62B30F0", VA = "0x1862B3EF0", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, Delegate NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class OAGENGHAOKG : Property<AIFPHELDACK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x62B51C0", Offset = "0x62B43C0", VA = "0x1862B51C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62B5180", Offset = "0x62B4380", VA = "0x1862B5180")]
		public OAGENGHAOKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62B5130", Offset = "0x62B4330", VA = "0x1862B5130", Slot = "14")]
		public override Delegate GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62B5150", Offset = "0x62B4350", VA = "0x1862B5150", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, Delegate NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private class HLKEENDGFCI : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x62B4220", Offset = "0x62B3420", VA = "0x1862B4220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62B41E0", Offset = "0x62B33E0", VA = "0x1862B41E0")]
		public HLKEENDGFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x62B4170", Offset = "0x62B3370", VA = "0x1862B4170", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62B41A0", Offset = "0x62B33A0", VA = "0x1862B41A0", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class GDBBCBJMNHA : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x62B40D0", Offset = "0x62B32D0", VA = "0x1862B40D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x62B4090", Offset = "0x62B3290", VA = "0x1862B4090")]
		public GDBBCBJMNHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62B4020", Offset = "0x62B3220", VA = "0x1862B4020", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62B4050", Offset = "0x62B3250", VA = "0x1862B4050", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private class LDFHKKMLEIE : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x62B49F0", Offset = "0x62B3BF0", VA = "0x1862B49F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62B49B0", Offset = "0x62B3BB0", VA = "0x1862B49B0")]
		public LDFHKKMLEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62B4940", Offset = "0x62B3B40", VA = "0x1862B4940", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62B4970", Offset = "0x62B3B70", VA = "0x1862B4970", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private class HOCCKFNGJIL : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x62B4310", Offset = "0x62B3510", VA = "0x1862B4310", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62B42D0", Offset = "0x62B34D0", VA = "0x1862B42D0")]
		public HOCCKFNGJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62B4250", Offset = "0x62B3450", VA = "0x1862B4250", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62B4290", Offset = "0x62B3490", VA = "0x1862B4290", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private class AJFGHCCMHIB : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x62B2FB0", Offset = "0x62B21B0", VA = "0x1862B2FB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62B2F70", Offset = "0x62B2170", VA = "0x1862B2F70")]
		public AJFGHCCMHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62B2EF0", Offset = "0x62B20F0", VA = "0x1862B2EF0", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62B2F30", Offset = "0x62B2130", VA = "0x1862B2F30", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private class MKPGGCBOLNB : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x62B4E70", Offset = "0x62B4070", VA = "0x1862B4E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62B4E30", Offset = "0x62B4030", VA = "0x1862B4E30")]
		public MKPGGCBOLNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62B4DB0", Offset = "0x62B3FB0", VA = "0x1862B4DB0", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62B4DF0", Offset = "0x62B3FF0", VA = "0x1862B4DF0", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private class DHECBHBDKPA : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x62B3E60", Offset = "0x62B3060", VA = "0x1862B3E60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62B3E20", Offset = "0x62B3020", VA = "0x1862B3E20")]
		public DHECBHBDKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62B3DA0", Offset = "0x62B2FA0", VA = "0x1862B3DA0", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62B3DE0", Offset = "0x62B2FE0", VA = "0x1862B3DE0", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private class IPPDOMIOHGL : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x62B44B0", Offset = "0x62B36B0", VA = "0x1862B44B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62B4470", Offset = "0x62B3670", VA = "0x1862B4470")]
		public IPPDOMIOHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62B43F0", Offset = "0x62B35F0", VA = "0x1862B43F0", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62B4430", Offset = "0x62B3630", VA = "0x1862B4430", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class NHPNBEIICPH : Property<AIFPHELDACK, HAJELMLNIMF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x62B4F60", Offset = "0x62B4160", VA = "0x1862B4F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62B4F20", Offset = "0x62B4120", VA = "0x1862B4F20")]
		public NHPNBEIICPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62B4EA0", Offset = "0x62B40A0", VA = "0x1862B4EA0", Slot = "14")]
		public override HAJELMLNIMF<Delegate> GetValue(AIFPHELDACK BFOBHJGOFNM)
		{
			return default(HAJELMLNIMF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62B4EE0", Offset = "0x62B40E0", VA = "0x1862B4EE0", Slot = "15")]
		public override void SetValue(AIFPHELDACK BFOBHJGOFNM, HAJELMLNIMF<Delegate> NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62B3700", Offset = "0x62B2900", VA = "0x1862B3700")]
	public CJJCMMPOKHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class MECEOHABKHK : ContainerPropertyBag<AIFPHELDACK.ODGMCIGJBLM>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class NIMGFHGKLCP : Property<AIFPHELDACK.ODGMCIGJBLM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x62B4FD0", Offset = "0x62B41D0", VA = "0x1862B4FD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62B4F90", Offset = "0x62B4190", VA = "0x1862B4F90")]
		public NIMGFHGKLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C84F0", Offset = "0x8C76F0", VA = "0x1808C84F0", Slot = "14")]
		public override object GetValue(AIFPHELDACK.ODGMCIGJBLM BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x42AECF0", Offset = "0x42ADEF0", VA = "0x1842AECF0", Slot = "15")]
		public override void SetValue(AIFPHELDACK.ODGMCIGJBLM BFOBHJGOFNM, object NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x62B4C60", Offset = "0x62B3E60", VA = "0x1862B4C60")]
	public MECEOHABKHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class CFPKBNOBLHC : ContainerPropertyBag<HAJELMLNIMF<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62B3120", Offset = "0x62B2320", VA = "0x1862B3120")]
	public CFPKBNOBLHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class KNLIGKBMALO : ContainerPropertyBag<MGPBDGPEAPI>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class HPADBHBMMJI : Property<MGPBDGPEAPI, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x62B4380", Offset = "0x62B3580", VA = "0x1862B4380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62B4340", Offset = "0x62B3540", VA = "0x1862B4340")]
		public HPADBHBMMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x62B2DE0", Offset = "0x62B1FE0", VA = "0x1862B2DE0", Slot = "14")]
		public override Rigidbody GetValue(MGPBDGPEAPI BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62B2E00", Offset = "0x62B2000", VA = "0x1862B2E00", Slot = "15")]
		public override void SetValue(MGPBDGPEAPI BFOBHJGOFNM, Rigidbody NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x62B4860", Offset = "0x62B3A60", VA = "0x1862B4860")]
	public KNLIGKBMALO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class PKFLJLKJKNP : ContainerPropertyBag<BEEECNGFFCC>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class CIHNCCIAHBE : Property<BEEECNGFFCC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x62B3400", Offset = "0x62B2600", VA = "0x1862B3400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62B33C0", Offset = "0x62B25C0", VA = "0x1862B33C0")]
		public CIHNCCIAHBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62B2DE0", Offset = "0x62B1FE0", VA = "0x1862B2DE0", Slot = "14")]
		public override object GetValue(BEEECNGFFCC BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x62B2E00", Offset = "0x62B2000", VA = "0x1862B2E00", Slot = "15")]
		public override void SetValue(BEEECNGFFCC BFOBHJGOFNM, object NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x62B5340", Offset = "0x62B4540", VA = "0x1862B5340")]
	public PKFLJLKJKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class JKDOGMNJHDD : ContainerPropertyBag<GHFHJGLOOKD>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class ADMECBGNGLE : Property<GHFHJGLOOKD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x62B2E70", Offset = "0x62B2070", VA = "0x1862B2E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool EABCDIJODPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62B2E30", Offset = "0x62B2030", VA = "0x1862B2E30")]
		public ADMECBGNGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x62B2DE0", Offset = "0x62B1FE0", VA = "0x1862B2DE0", Slot = "14")]
		public override object GetValue(GHFHJGLOOKD BFOBHJGOFNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62B2E00", Offset = "0x62B2000", VA = "0x1862B2E00", Slot = "15")]
		public override void SetValue(GHFHJGLOOKD BFOBHJGOFNM, object NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62B4550", Offset = "0x62B3750", VA = "0x1862B4550")]
	public JKDOGMNJHDD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62B5420", Offset = "0x62B4620", VA = "0x1862B5420")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class NIBLCMOALME
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NIBLCMOALME()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
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

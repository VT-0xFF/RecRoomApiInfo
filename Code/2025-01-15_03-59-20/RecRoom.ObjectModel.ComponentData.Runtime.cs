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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ComponentData_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x712D880", Offset = "0x712CC80", VA = "0x18712D880", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x712DC60", Offset = "0x712D060", VA = "0x18712DC60", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DEPEBIHGFOF : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x712AB10", Offset = "0x7129F10", VA = "0x18712AB10", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ELHLEKICIHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HFKMGMGPGDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity BGJHAOMHCJE;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KCAHELNCHDL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity BGJHAOMHCJE;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LDOABBHIDMB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<FIDDOLAECAF> FEEAEGFDPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> PJHBBBEBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle ILDCEBCINIL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MALNNEJEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x712CA60", Offset = "0x712BE60", VA = "0x18712CA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x712CB30", Offset = "0x712BF30", VA = "0x18712CB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51DE340", Offset = "0x51DD740", VA = "0x1851DE340")]
	public LDOABBHIDMB(NativeList<FIDDOLAECAF> FEEAEGFDPMF, NativeList<Entity> PJHBBBEBPEC, JobHandle ILDCEBCINIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x712C940", Offset = "0x712BD40", VA = "0x18712C940")]
	public (Entity, NativeSlice<Entity>) CBGPFEJOLIE(int IBIAGDBMPOH)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x712CAD0", Offset = "0x712BED0", VA = "0x18712CAD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FIDDOLAECAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity NIMLNKDMKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int LHBPAMEKCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int OIPEPMJNPGM;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NMKEKCJFJFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGHKEFAIOAA(bool ENPNKMAIGKP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GBFDJIMHAEC : IEquatable<GBFDJIMHAEC>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool ALLHKCINEGA(int EOMBDLJNDJM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool GMDHCOALIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool FKGIHBLLJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool JBEDBNKMBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool HECEODEKMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly ALLHKCINEGA DOHEEOCGCCL;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x712BE40", Offset = "0x712B240", VA = "0x18712BE40")]
	public GBFDJIMHAEC(LAKABHFBLCH OBCABLKNBMC, ALLHKCINEGA DOHEEOCGCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x712BE80", Offset = "0x712B280", VA = "0x18712BE80")]
	public GBFDJIMHAEC(bool GMDHCOALIIB, bool FKGIHBLLJKK, bool JBEDBNKMBHE, bool HECEODEKMCG, ALLHKCINEGA DOHEEOCGCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x712BBE0", Offset = "0x712AFE0", VA = "0x18712BBE0")]
	public bool AMLNGAKKHPH(int EOMBDLJNDJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x712BDF0", Offset = "0x712B1F0", VA = "0x18712BDF0")]
	public bool NJBNDELFFBH(int EOMBDLJNDJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x712BDC0", Offset = "0x712B1C0", VA = "0x18712BDC0")]
	public bool KNANCAHFECA(int EOMBDLJNDJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x712BD90", Offset = "0x712B190", VA = "0x18712BD90")]
	public bool KHFJJNELDBG(int EOMBDLJNDJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x712BC10", Offset = "0x712B010", VA = "0x18712BC10", Slot = "4")]
	public bool Equals(GBFDJIMHAEC BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x712BC40", Offset = "0x712B040", VA = "0x18712BC40", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x712BCF0", Offset = "0x712B0F0", VA = "0x18712BCF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x712BE20", Offset = "0x712B220", VA = "0x18712BE20")]
	private bool NODENFODFIE(int EOMBDLJNDJM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IDOHICCEIKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GAIEEKMFACC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KPOJAENHACG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct ILJHGKMFCPD : IBufferElementData, IEquatable<ILJHGKMFCPD>, FDELCCPMKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity FKLPGABAEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int HMHBLOONOPO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity EEPJKMFEPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x712C3C0", Offset = "0x712B7C0", VA = "0x18712C3C0", Slot = "4")]
	public bool Equals(ILJHGKMFCPD BMKPAKCEMFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FFBACPNIILP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public OEDMJPMNCAI LMACEGOCAOG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x712B8F0", Offset = "0x712ACF0", VA = "0x18712B8F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public FFBACPNIILP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OEDMJPMNCAI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JCFBCPDHINH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct POPHOEKEODK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct GIDKKDKDGIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly HIHFLBDDDNH MPNLPKFELDG;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x29218E0", Offset = "0x2920CE0", VA = "0x1829218E0")]
		public GIDKKDKDGIP(HIHFLBDDDNH LKEBFDOBBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x712BF80", Offset = "0x712B380", VA = "0x18712BF80")]
		public bool FAILCGLHIBB(POPHOEKEODK OMBEPFICNBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x712BF70", Offset = "0x712B370", VA = "0x18712BF70")]
		public bool DMHPPJOAJAN(POPHOEKEODK OMBEPFICNBE, HIHFLBDDDNH LIGLPKKFBGL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly HIHFLBDDDNH FIFAJFFKKCJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29218E0", Offset = "0x2920CE0", VA = "0x1829218E0")]
	public POPHOEKEODK(HIHFLBDDDNH FIFAJFFKKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x712D220", Offset = "0x712C620", VA = "0x18712D220")]
	public POPHOEKEODK ELDNMJGFBJL(HIHFLBDDDNH PBANFOFCFKD)
	{
		return default(POPHOEKEODK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x712D230", Offset = "0x712C630", VA = "0x18712D230")]
	public POPHOEKEODK JLGGBDEAOOL(HIHFLBDDDNH IDPALJPPIAL)
	{
		return default(POPHOEKEODK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x712D240", Offset = "0x712C640", VA = "0x18712D240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum HIHFLBDDDNH : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Flags]
public enum JAGDLIBBEBJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[SingletonComponent]
public struct LOEMPJBCFLA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JAGDLIBBEBJ FIFAJFFKKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool BDLNANGFKIP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KBOKBDILACD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x712CCA0", Offset = "0x712C0A0", VA = "0x18712CCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x712CCB0", Offset = "0x712C0B0", VA = "0x18712CCB0")]
	private LOEMPJBCFLA(JAGDLIBBEBJ FIFAJFFKKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x712CC60", Offset = "0x712C060", VA = "0x18712CC60")]
	public LOEMPJBCFLA ELDNMJGFBJL(JAGDLIBBEBJ PBANFOFCFKD)
	{
		return default(LOEMPJBCFLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x712CC80", Offset = "0x712C080", VA = "0x18712CC80")]
	public LOEMPJBCFLA JLGGBDEAOOL(JAGDLIBBEBJ IDPALJPPIAL)
	{
		return default(LOEMPJBCFLA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FFLKLBBLFIM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JNFEJJBNLJJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity GOLFHLBIMHP;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, FDELCCPMKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x712AB10", Offset = "0x7129F10", VA = "0x18712AB10", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[SingletonComponent]
public struct IGGKBODEKAJ : ISystemStateBufferElementData, IBufferElementData, FDELCCPMKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity DGPOIOLCNNN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity LCFCJAKPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct AMGKLODMKFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity DCENHALJJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity LPDKCOFBICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity OPPGCNFPHIE;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct ECCGIDDDNFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Guid FNECNONNEND;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CBOFCDCPKAF<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool BDPCGJLEFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint NNGBICOJCNN;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	private static bool JDCFHONODDD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[TypeManager.TypeVersion(2)]
public struct DCPCAEEBJOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public uint GGHCAKPOADN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x712B5A0", Offset = "0x712A9A0", VA = "0x18712B5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct DGHFDCGPCCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SingletonComponent]
public struct BEGHLAGADKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int OLDIEMCNADF;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NLCOEDLELEC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int BHDCNGMMPLN;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct AMHDFPEFGFF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GCHandle LHPIPNIHCDE;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JIMHPJJCJHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int BHDCNGMMPLN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct JOLDHFCPLOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LDGODDHNOOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int BHDCNGMMPLN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JLMGKFJIHGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct EFFOOANGFDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct EGCOHJDPMKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct KMFEDHNABKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public CollisionDetectionMode HJEKCNOGAEP;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RegisterComponentDefault]
public struct JBLBIIFFFKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public HODEOENILDN PAOPFMEKMIA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly JBLBIIFFFKN LNPPLFIHDAJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CNDBIBKFIBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FEMMKLKAONJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FMLEHHHJOAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[InternalBufferCapacity(0)]
public struct BDPMHBKMDCM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity FKLPGABAEFE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OLMFMPEDCBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity AMMKPAGCALK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct ELJODMPBCAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EENCIJDEACG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Entity NIMLNKDMKHI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KJCJPEJKJJH : ONAIEHJBKEH, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MJMELJIEOEP AFAHLPCLAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(MJMELJIEOEP);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AIFFAIIIDIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 JEBAPEFGHBK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct NNBMJCFPBME : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RegisterComponentDefault]
public struct FOBBPBEFBNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3x3 FGCLICEBIDE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly FOBBPBEFBNJ LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct JINMBIGHCDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float3x3 FGCLICEBIDE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly JINMBIGHCDO LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BNIEEIGJABI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 DEELGBDAAJN;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct OOMBKGNKELC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 PLMHBNCNPNB;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RegisterComponentDefault]
public struct GKGLOEIIGJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float CJMLLELNHBG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly GKGLOEIIGJL LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[RegisterComponentDefault]
public struct KHIJAHMIEAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float LDBELGFFKNE;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly KHIJAHMIEAK LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct BFLHMCAHCDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 EDDMEOFJKNE;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct JECLPKFOJDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public KBLCCMMKFLK ACMAJJOJKEO;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct JPOAGHAKIGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public KBLCCMMKFLK GGJMJHKHOGG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[SingletonComponent]
public struct MFDFFCADKNL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Entity DGPOIOLCNNN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct GPJDEPADGCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct OAHKBJCLDKO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct EEEMEAENCGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public RigidbodyConstraints OEKAOCMFPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
public struct CLEEFNOCDFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float AICNDFBFCHA;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly CLEEFNOCDFM LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct DFMNGFPEPDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float NOPCKONEOHG;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GKJPHGPCIDG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct DFBJCPOCOBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public object IAENBOLPMIM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GameObject MCCIFMIMANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public object ADFPJBPFNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public object IKNMNLEAGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public DFBJCPOCOBK IAENBOLPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Delegate OJIEIFFHMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Delegate IDFLPFCLDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IGBALICKMIC<Delegate> IGHOCFDBMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public IGBALICKMIC<Delegate> FIINKHLHKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public IGBALICKMIC<Delegate> ALEMJBPOCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public IGBALICKMIC<Delegate> KKCBGEAHMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public IGBALICKMIC<Delegate> LIMHHPIILHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public IGBALICKMIC<Delegate> LCKKNCPFMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public IGBALICKMIC<Delegate> HJNGPECHLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IGBALICKMIC<Delegate> DMPJMKPIKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public IGBALICKMIC<Delegate> GMKGPJDDOOK;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x712C090", Offset = "0x712B490", VA = "0x18712C090", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public GKJPHGPCIDG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct JPBMBKFBPHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct FGDCGKDGIIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int KEOJDPANDED;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1829780", Offset = "0x1828B80", VA = "0x181829780")]
	public static FGDCGKDGIIO IDKOEJANABA(int HCPAOILCJCB)
	{
		return default(FGDCGKDGIIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ELOCMDFAHCO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Rigidbody LAANDEEMEGN;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x712B780", Offset = "0x712AB80", VA = "0x18712B780", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public ELOCMDFAHCO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct MLBGJBGFLNI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct IDHMBJAFGPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float3 KFMFAILJFNK;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct LENILPJFCGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 KLNNEIDEPKF;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
public struct AHBFDGKDEFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float GCLKEGNCDBE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly AHBFDGKDEFB LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class OMPPNLPMFMA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public object OMOGMHNLMEE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x712D140", Offset = "0x712C540", VA = "0x18712D140", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OMPPNLPMFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class OOLFHAIMOIM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public object LBADCHIPJHG;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x712D1B0", Offset = "0x712C5B0", VA = "0x18712D1B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public OOLFHAIMOIM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct NFGDNJKGLJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct FAHGGHOJFMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct HLGCAJLEOAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct ACGGIHOPBPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct CCLLLPKJJCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct LBCPNFEOJPA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct DIDMCGHHPHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public FixedString32Bytes LJAGHAHCFHJ;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[SingletonComponent]
public struct HMNKBPKKGJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity BOFPDPJECEF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static HMNKBPKKGJL IDKOEJANABA(Entity HCPAOILCJCB)
	{
		return default(HMNKBPKKGJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal struct PJJNLOMDHDH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity DGPOIOLCNNN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static PJJNLOMDHDH IDKOEJANABA(Entity DGPOIOLCNNN)
	{
		return default(PJJNLOMDHDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct DFFIOOPKNPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity HGOKFHKAIFL;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct LOMHBNNLDEE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity HGOKFHKAIFL;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct EAPOHFLHMIH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Entity PGJIGJJCHHH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xA93730", Offset = "0xA92B30", VA = "0x180A93730")]
	public static EAPOHFLHMIH IDKOEJANABA(Entity DGPOIOLCNNN)
	{
		return default(EAPOHFLHMIH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct EFIFLFMKEHP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct CDBNAACJNLN : IBufferElementData, IEquatable<CDBNAACJNLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Entity EFLOLCEOAOA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x712B260", Offset = "0x712A660", VA = "0x18712B260", Slot = "4")]
	public bool Equals(CDBNAACJNLN BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x712B270", Offset = "0x712A670", VA = "0x18712B270", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct KDJCFOAMBML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public uint GKEHKEEIHAE;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[SingletonComponent]
internal struct IDIDFHNIGOE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Entity AHAAMINLDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public int IIACLAMOIEE;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct DPBBEJFNFMI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity GNDJONLPBDP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JAKBNJNBIJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct BGNAFOKHMJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public uint NNGBICOJCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int MJNJBEBNIAK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x961F80", Offset = "0x961380", VA = "0x180961F80")]
	public BGNAFOKHMJB(uint INBECLLPNCG, int JLOGGKBIAHG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct KJHOGDLBMHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct EOINOHPFCID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JFPIBADNNDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct GCIJOLIKANO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct ODMALHLGCEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LHFMBNIMOOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FIECPOIMPAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LPPIFGJAAPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct DCKDNPNLAJJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JCLPABJMHDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct CHIAOAPLFHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct MMEIDIIOJEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct MNAJNNDGGIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct GBLGPKJJIPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct MOAFOOOKJIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct CIJBMCCHOII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct MOPEDHDPIKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct MPDPFDIJJLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct APPBHKNOFHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct CAILGPCOBLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PPDNIGABCIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct GFPIABLALHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LBBHLCABKHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct EJDJNLFNILK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct EMPGPPMCELJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct BCDGCFNKCJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct DBJADELHGJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct LJGHALIAMJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct POLDHGBIICC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[SingletonComponent]
public struct HNKEDLOFCJA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public FixedString32Bytes ODCOLEGLGGM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct NJHBBAPOECC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct IOFALNHPPEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal struct CDDHIDJDMGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal struct JDKBHEFENEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct ACNCOMPAJHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct MKILEOAICNH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct GACBONBAPGN : IComponentData, IComparable<GACBONBAPGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int MOMLJDNKHLF;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1B33860", Offset = "0x1B32C60", VA = "0x181B33860", Slot = "4")]
	public int CompareTo(GACBONBAPGN BMKPAKCEMFK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct IHKDNEPNFEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct AOHFBIKEAAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public quaternion CBCAIPELAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float3 CPGMOBFHDAC;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct LKEJBCPBNAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float ILDHFBCIHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float LKGBJFNPLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float LJOCBKMECPO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct CFCMDEMNKLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct NONJPLCOCIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct CADGILOLEOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct LPJFPAHGMIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int BHDCNGMMPLN;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[SingletonComponent]
public struct INDIIEHBGNN : ISystemStateBufferElementData, IBufferElementData, FDELCCPMKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity PEEBEBLBIKF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity LCFCJAKPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RegisterComponentDefault]
public struct OICDFAPEJLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float4x4 EOGOCOHBANI;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly OICDFAPEJLL LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RegisterComponentDefault]
public struct AIHIDPCBKLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float4x4 KAFLPFIJPOD;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly AIHIDPCBKLO LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct HKCOHKKGGLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int CDMPPPPINHO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IIACLAMOIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x712C1D0", Offset = "0x712B5D0", VA = "0x18712C1D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x712C1E0", Offset = "0x712B5E0", VA = "0x18712C1E0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[RegisterComponentDefault]
public struct JFODACKOGLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public float3 LBEMHKFEOJG;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly JFODACKOGLB LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[RegisterComponentDefault]
public struct FOFEFCAJDDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 CPGMOBFHDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public quaternion CBCAIPELAJP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly FOFEFCAJDDI LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class PNBHECOOMNC
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[RegisterComponentDefault]
public struct EMICMOLONGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float CKAAMNCOIAA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly EMICMOLONGO LNPPLFIHDAJ;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct IEPIDIMGBMP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Entity KOGDHKPKBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public AEMLLOGJEJB HBOEBNCIJMJ;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct DFCPHEOKKIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public AEMLLOGJEJB HBOEBNCIJMJ;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct CIEOBAADJGA : ISystemStateComponentData, IComponentData, FDELCCPMKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity JIIJJAKJBGA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity LCFCJAKPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct JNEDLCINHCA : ISystemStateBufferElementData, IBufferElementData, FDELCCPMKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity AAKHFDMBBDA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity LCFCJAKPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct ILLKPLNIFAC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity KOGDHKPKBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public AEMLLOGJEJB HBOEBNCIJMJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct CHIKIPMGLNC : IEqualityComparer<ILLKPLNIFAC>
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static CHIKIPMGLNC LNPPLFIHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x712B300", Offset = "0x712A700", VA = "0x18712B300", Slot = "4")]
	public bool Equals(ILLKPLNIFAC KENGFOGLPKI, ILLKPLNIFAC IFGPABAHODO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x712B350", Offset = "0x712A750", VA = "0x18712B350", Slot = "5")]
	public int GetHashCode(ILLKPLNIFAC NCHBKHMIMGJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct NKPEOBJGCFG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public FixedList32Bytes<int> KDNNPAMIKAL;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct KAMKDHANHPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public FixedList32Bytes<int> KDNNPAMIKAL;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct HAHPAMPLKIO : ISystemStateBufferElementData, IBufferElementData, FDELCCPMKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity NGOGFAHMJBK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity EEPJKMFEPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1213DB0", Offset = "0x12131B0", VA = "0x181213DB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class NNEBDFCLHNA : ContainerPropertyBag<FFBACPNIILP>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class OKBBOJEGKJF : Property<FFBACPNIILP, OEDMJPMNCAI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x712CFC0", Offset = "0x712C3C0", VA = "0x18712CFC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x712CF80", Offset = "0x712C380", VA = "0x18712CF80")]
		public OKBBOJEGKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x712BEB0", Offset = "0x712B2B0", VA = "0x18712BEB0", Slot = "14")]
		public override OEDMJPMNCAI GetValue(FFBACPNIILP CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x712BED0", Offset = "0x712B2D0", VA = "0x18712BED0", Slot = "15")]
		public override void SetValue(FFBACPNIILP CLDCJHAFFHO, OEDMJPMNCAI HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x712CD80", Offset = "0x712C180", VA = "0x18712CD80")]
	public NNEBDFCLHNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class BHCPJHCLGMI : ContainerPropertyBag<GKJPHGPCIDG>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class OECEFDGDGJH : Property<GKJPHGPCIDG, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x712CEA0", Offset = "0x712C2A0", VA = "0x18712CEA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x712CE60", Offset = "0x712C260", VA = "0x18712CE60")]
		public OECEFDGDGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x712BEB0", Offset = "0x712B2B0", VA = "0x18712BEB0", Slot = "14")]
		public override GameObject GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x712BED0", Offset = "0x712B2D0", VA = "0x18712BED0", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, GameObject HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class DCLBAIPKOGN : Property<GKJPHGPCIDG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x712B570", Offset = "0x712A970", VA = "0x18712B570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x712B530", Offset = "0x712A930", VA = "0x18712B530")]
		public DCLBAIPKOGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x712B4E0", Offset = "0x712A8E0", VA = "0x18712B4E0", Slot = "14")]
		public override object GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x712B500", Offset = "0x712A900", VA = "0x18712B500", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, object HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class MEIDBNIJJOP : Property<GKJPHGPCIDG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x712CD50", Offset = "0x712C150", VA = "0x18712CD50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x712CD10", Offset = "0x712C110", VA = "0x18712CD10")]
		public MEIDBNIJJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x712CCC0", Offset = "0x712C0C0", VA = "0x18712CCC0", Slot = "14")]
		public override object GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x712CCE0", Offset = "0x712C0E0", VA = "0x18712CCE0", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, object HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class GJIHFMOAOFJ : Property<GKJPHGPCIDG, GKJPHGPCIDG.DFBJCPOCOBK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x712C020", Offset = "0x712B420", VA = "0x18712C020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x712BFE0", Offset = "0x712B3E0", VA = "0x18712BFE0")]
		public GJIHFMOAOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x712BF90", Offset = "0x712B390", VA = "0x18712BF90", Slot = "14")]
		public override GKJPHGPCIDG.DFBJCPOCOBK GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(GKJPHGPCIDG.DFBJCPOCOBK);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x712BFB0", Offset = "0x712B3B0", VA = "0x18712BFB0", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, GKJPHGPCIDG.DFBJCPOCOBK HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class AIAMOCMJFGE : Property<GKJPHGPCIDG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x712AA30", Offset = "0x7129E30", VA = "0x18712AA30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x712A9F0", Offset = "0x7129DF0", VA = "0x18712A9F0")]
		public AIAMOCMJFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x712A9A0", Offset = "0x7129DA0", VA = "0x18712A9A0", Slot = "14")]
		public override Delegate GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x712A9C0", Offset = "0x7129DC0", VA = "0x18712A9C0", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, Delegate HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class EOMCOBJKIJP : Property<GKJPHGPCIDG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x712B8C0", Offset = "0x712ACC0", VA = "0x18712B8C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x712B880", Offset = "0x712AC80", VA = "0x18712B880")]
		public EOMCOBJKIJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x712B830", Offset = "0x712AC30", VA = "0x18712B830", Slot = "14")]
		public override Delegate GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x712B850", Offset = "0x712AC50", VA = "0x18712B850", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, Delegate HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class BAPEDKGCHEC : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x712ABD0", Offset = "0x7129FD0", VA = "0x18712ABD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x712AB90", Offset = "0x7129F90", VA = "0x18712AB90")]
		public BAPEDKGCHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x712AB20", Offset = "0x7129F20", VA = "0x18712AB20", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x712AB50", Offset = "0x7129F50", VA = "0x18712AB50", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class OMFOOLJDJDD : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x712D0A0", Offset = "0x712C4A0", VA = "0x18712D0A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x712D060", Offset = "0x712C460", VA = "0x18712D060")]
		public OMFOOLJDJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x712CFF0", Offset = "0x712C3F0", VA = "0x18712CFF0", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x712D020", Offset = "0x712C420", VA = "0x18712D020", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class LMHPJBIGLNO : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x712CC30", Offset = "0x712C030", VA = "0x18712CC30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x712CBF0", Offset = "0x712BFF0", VA = "0x18712CBF0")]
		public LMHPJBIGLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x712CB80", Offset = "0x712BF80", VA = "0x18712CB80", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x712CBB0", Offset = "0x712BFB0", VA = "0x18712CBB0", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class KFAGOFJFGPD : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x712C7E0", Offset = "0x712BBE0", VA = "0x18712C7E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x712C7A0", Offset = "0x712BBA0", VA = "0x18712C7A0")]
		public KFAGOFJFGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x712C720", Offset = "0x712BB20", VA = "0x18712C720", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x712C760", Offset = "0x712BB60", VA = "0x18712C760", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class KOJNCJPOOCE : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x712C910", Offset = "0x712BD10", VA = "0x18712C910", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x712C8D0", Offset = "0x712BCD0", VA = "0x18712C8D0")]
		public KOJNCJPOOCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x712C850", Offset = "0x712BC50", VA = "0x18712C850", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x712C890", Offset = "0x712BC90", VA = "0x18712C890", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class GMLPIIPONJG : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x712C1A0", Offset = "0x712B5A0", VA = "0x18712C1A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x712C160", Offset = "0x712B560", VA = "0x18712C160")]
		public GMLPIIPONJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x712C0E0", Offset = "0x712B4E0", VA = "0x18712C0E0", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x712C120", Offset = "0x712B520", VA = "0x18712C120", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class IKEICNMNBOL : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x712C2B0", Offset = "0x712B6B0", VA = "0x18712C2B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x712C270", Offset = "0x712B670", VA = "0x18712C270")]
		public IKEICNMNBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x712C1F0", Offset = "0x712B5F0", VA = "0x18712C1F0", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x712C230", Offset = "0x712B630", VA = "0x18712C230", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class CKOEKDPICGL : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x712B470", Offset = "0x712A870", VA = "0x18712B470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x712B430", Offset = "0x712A830", VA = "0x18712B430")]
		public CKOEKDPICGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x712B3B0", Offset = "0x712A7B0", VA = "0x18712B3B0", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x712B3F0", Offset = "0x712A7F0", VA = "0x18712B3F0", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	private class JMINEJFEBBK : Property<GKJPHGPCIDG, IGBALICKMIC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x712C680", Offset = "0x712BA80", VA = "0x18712C680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x712C640", Offset = "0x712BA40", VA = "0x18712C640")]
		public JMINEJFEBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x712C5C0", Offset = "0x712B9C0", VA = "0x18712C5C0", Slot = "14")]
		public override IGBALICKMIC<Delegate> GetValue(GKJPHGPCIDG CLDCJHAFFHO)
		{
			return default(IGBALICKMIC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x712C600", Offset = "0x712BA00", VA = "0x18712C600", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG CLDCJHAFFHO, IGBALICKMIC<Delegate> HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x712AC00", Offset = "0x712A000", VA = "0x18712AC00")]
	public BHCPJHCLGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class AHKMEEECJBH : ContainerPropertyBag<GKJPHGPCIDG.DFBJCPOCOBK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class EHHHOKDBCLJ : Property<GKJPHGPCIDG.DFBJCPOCOBK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x712B670", Offset = "0x712AA70", VA = "0x18712B670", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x712B630", Offset = "0x712AA30", VA = "0x18712B630")]
		public EHHHOKDBCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAA4480", Offset = "0xAA3880", VA = "0x180AA4480", Slot = "14")]
		public override object GetValue(GKJPHGPCIDG.DFBJCPOCOBK CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4CD14F0", Offset = "0x4CD08F0", VA = "0x184CD14F0", Slot = "15")]
		public override void SetValue(GKJPHGPCIDG.DFBJCPOCOBK CLDCJHAFFHO, object HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x712A8C0", Offset = "0x7129CC0", VA = "0x18712A8C0")]
	public AHKMEEECJBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class FFOPDLOOGNL : ContainerPropertyBag<IGBALICKMIC<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x712B960", Offset = "0x712AD60", VA = "0x18712B960")]
	public FFOPDLOOGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class ADHCGHIGKMF : ContainerPropertyBag<ELOCMDFAHCO>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class JOCLGPNGEMA : Property<ELOCMDFAHCO, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x712C6F0", Offset = "0x712BAF0", VA = "0x18712C6F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x712C6B0", Offset = "0x712BAB0", VA = "0x18712C6B0")]
		public JOCLGPNGEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x712BEB0", Offset = "0x712B2B0", VA = "0x18712BEB0", Slot = "14")]
		public override Rigidbody GetValue(ELOCMDFAHCO CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x712BED0", Offset = "0x712B2D0", VA = "0x18712BED0", Slot = "15")]
		public override void SetValue(ELOCMDFAHCO CLDCJHAFFHO, Rigidbody HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x712A7A0", Offset = "0x7129BA0", VA = "0x18712A7A0")]
	public ADHCGHIGKMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class EKBEPMPEDLN : ContainerPropertyBag<OMPPNLPMFMA>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class GHHCJKCOKFC : Property<OMPPNLPMFMA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x712BF40", Offset = "0x712B340", VA = "0x18712BF40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x712BF00", Offset = "0x712B300", VA = "0x18712BF00")]
		public GHHCJKCOKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x712BEB0", Offset = "0x712B2B0", VA = "0x18712BEB0", Slot = "14")]
		public override object GetValue(OMPPNLPMFMA CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x712BED0", Offset = "0x712B2D0", VA = "0x18712BED0", Slot = "15")]
		public override void SetValue(OMPPNLPMFMA CLDCJHAFFHO, object HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x712B6A0", Offset = "0x712AAA0", VA = "0x18712B6A0")]
	public EKBEPMPEDLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class ILBFMALJKDB : ContainerPropertyBag<OOLFHAIMOIM>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class OMLLPNLJJOB : Property<OOLFHAIMOIM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string DKCJKHANLJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x712D110", Offset = "0x712C510", VA = "0x18712D110", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool DNNGBKHPAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x712D0D0", Offset = "0x712C4D0", VA = "0x18712D0D0")]
		public OMLLPNLJJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x712BEB0", Offset = "0x712B2B0", VA = "0x18712BEB0", Slot = "14")]
		public override object GetValue(OOLFHAIMOIM CLDCJHAFFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x712BED0", Offset = "0x712B2D0", VA = "0x18712BED0", Slot = "15")]
		public override void SetValue(OOLFHAIMOIM CLDCJHAFFHO, object HCPAOILCJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x712C2E0", Offset = "0x712B6E0", VA = "0x18712C2E0")]
	public ILBFMALJKDB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x712D2A0", Offset = "0x712C6A0", VA = "0x18712D2A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class EIEKKDBLJLC
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public EIEKKDBLJLC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
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

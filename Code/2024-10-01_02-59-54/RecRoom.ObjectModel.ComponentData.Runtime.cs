using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7540", Offset = "0x6EE6940", VA = "0x186EE7540", Slot = "9")]
		public override void CADENCJBOFE(LMPNKKPFPOD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7920", Offset = "0x6EE6D20", VA = "0x186EE7920", Slot = "7")]
		public override void GCGIHMEMAJH(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JHGONDAKLIN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, OOCPMEOPAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4920", Offset = "0x6EE3D20", VA = "0x186EE4920", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, OOCPMEOPAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PGFJBNIFPLO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MGKGCHIOKHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity MGHFGFPHKLK;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KHDAGNPDPIH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity MGHFGFPHKLK;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DBIJCHHCFNL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<CEIJCJPNJAN> KMNGFBGILAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> JJANLOKLKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle LGCKIPFOBAH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ODMBGBHFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4CC0", Offset = "0x6EE40C0", VA = "0x186EE4CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4D30", Offset = "0x6EE4130", VA = "0x186EE4D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50BD7E0", Offset = "0x50BCBE0", VA = "0x1850BD7E0")]
	public DBIJCHHCFNL(NativeList<CEIJCJPNJAN> KMNGFBGILAD, NativeList<Entity> JJANLOKLKLL, JobHandle LGCKIPFOBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4D80", Offset = "0x6EE4180", VA = "0x186EE4D80")]
	public (Entity, NativeSlice<Entity>) LFOOIFIHKDM(int INBIGDGMENB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4C60", Offset = "0x6EE4060", VA = "0x186EE4C60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CEIJCJPNJAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity FINELPFBLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int GMCJIJBLJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int IDHDBIDGMFM;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CDAFDPDPBLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BNAKMJMGAAC(bool PGPCPEEGDCD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct GEKBBCGBJCA : IEquatable<GEKBBCGBJCA>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool DBPBMBLAKGE(int NMAAEIEEHNK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool NFCOAFOEBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool EFGEOCKIBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool NCIABCDMICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool GGHDCDHCNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DBPBMBLAKGE NFIAGLEMLPB;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5670", Offset = "0x6EE4A70", VA = "0x186EE5670")]
	public GEKBBCGBJCA(KLDPKACKFII MLLKMCGEGGN, DBPBMBLAKGE NFIAGLEMLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EE56B0", Offset = "0x6EE4AB0", VA = "0x186EE56B0")]
	public GEKBBCGBJCA(bool NFCOAFOEBCK, bool EFGEOCKIBCK, bool NCIABCDMICC, bool GGHDCDHCNLE, DBPBMBLAKGE NFIAGLEMLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5610", Offset = "0x6EE4A10", VA = "0x186EE5610")]
	public bool ONCDBOHPANK(int NMAAEIEEHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5460", Offset = "0x6EE4860", VA = "0x186EE5460")]
	public bool EJBAMBIMKED(int NMAAEIEEHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5640", Offset = "0x6EE4A40", VA = "0x186EE5640")]
	public bool PLJCPMMDMBF(int NMAAEIEEHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5430", Offset = "0x6EE4830", VA = "0x186EE5430")]
	public bool DECDOLOENCM(int NMAAEIEEHNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5490", Offset = "0x6EE4890", VA = "0x186EE5490", Slot = "4")]
	public bool Equals(GEKBBCGBJCA OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE54C0", Offset = "0x6EE48C0", VA = "0x186EE54C0", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5570", Offset = "0x6EE4970", VA = "0x186EE5570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5410", Offset = "0x6EE4810", VA = "0x186EE5410")]
	private bool CNFIMJMLPDK(int NMAAEIEEHNK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BPPPKFGGNCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CKMONMOBPLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JHHOHMMPNDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct NMFNOEMPBLJ : IBufferElementData, IEquatable<NMFNOEMPBLJ>, OOCPMEOPAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity BBNLJLBANGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int LELIJNDCAOG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity PANKHFPJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6D80", Offset = "0x6EE6180", VA = "0x186EE6D80", Slot = "4")]
	public bool Equals(NMFNOEMPBLJ OCKBFCIKBEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct JHPNLDCPJBG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct BDAMOOKDKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly NBOFAMCGKEP DDBKLNEABOL;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x23EC4C0", Offset = "0x23EB8C0", VA = "0x1823EC4C0")]
		public BDAMOOKDKHJ(NBOFAMCGKEP KEAJDFHGHEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4940", Offset = "0x6EE3D40", VA = "0x186EE4940")]
		public bool LHHDAKNLIJE(JHPNLDCPJBG CFOKINIJPEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4930", Offset = "0x6EE3D30", VA = "0x186EE4930")]
		public bool DFLGBFJMPHP(JHPNLDCPJBG CFOKINIJPEJ, NBOFAMCGKEP PCBJBEANEKB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly NBOFAMCGKEP JJOGOIFHHOI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23EC4C0", Offset = "0x23EB8C0", VA = "0x1823EC4C0")]
	public JHPNLDCPJBG(NBOFAMCGKEP JJOGOIFHHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5D30", Offset = "0x6EE5130", VA = "0x186EE5D30")]
	public JHPNLDCPJBG PGCMEEFDAKC(NBOFAMCGKEP CAGMIHHFMCE)
	{
		return default(JHPNLDCPJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5D20", Offset = "0x6EE5120", VA = "0x186EE5D20")]
	public JHPNLDCPJBG KLGGNPCDOEP(NBOFAMCGKEP NCPPEKDKFMN)
	{
		return default(JHPNLDCPJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5D40", Offset = "0x6EE5140", VA = "0x186EE5D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum NBOFAMCGKEP : byte
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
public enum MGIDAHAODLP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[NACHBFFGGAM]
public struct LBKACOFKFLO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public MGIDAHAODLP JJOGOIFHHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool ELHIMPPCFCK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GMEADOEENFI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6A60", Offset = "0x6EE5E60", VA = "0x186EE6A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6AB0", Offset = "0x6EE5EB0", VA = "0x186EE6AB0")]
	private LBKACOFKFLO(MGIDAHAODLP JJOGOIFHHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6A90", Offset = "0x6EE5E90", VA = "0x186EE6A90")]
	public LBKACOFKFLO PGCMEEFDAKC(MGIDAHAODLP CAGMIHHFMCE)
	{
		return default(LBKACOFKFLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6A70", Offset = "0x6EE5E70", VA = "0x186EE6A70")]
	public LBKACOFKFLO KLGGNPCDOEP(MGIDAHAODLP NCPPEKDKFMN)
	{
		return default(LBKACOFKFLO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GPPIPCJHAGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LHJILPMJMPG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity OCJIEPGJDEN;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, OOCPMEOPAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4920", Offset = "0x6EE3D20", VA = "0x186EE4920", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[NACHBFFGGAM]
public struct EFELHMPGJPD : ISystemStateBufferElementData, IBufferElementData, OOCPMEOPAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity GLFIOFJHMHG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity LONFIIBANJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JOIOCNFNDJH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity KBOCABGIIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity JDALFLFOJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity BJHMHKBFAFL;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HGPJPGHFPCN<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly bool OOLCMFGMABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint NEBOKKOGFLN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool FANGOPNNDLC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct LEOEAMDLJBL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public uint LDAONIDCHPO;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6AC0", Offset = "0x6EE5EC0", VA = "0x186EE6AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HPJEHBBIDFG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[NACHBFFGGAM]
public struct KPKAFGNGHOA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int PACKDACPNGP;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct GCPBLAMBAHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int IPFLJJEIEDM;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct BAENAOOILBL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GCHandle FKJLKMGMJEI;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct MNHAKAPGNOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int IPFLJJEIEDM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IDCCKIKDMKM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JJBCHJBPMIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int IPFLJJEIEDM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct EKABBJNPLLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct LBMGMGBAPHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct JMLNNOAHNMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HGCGFGDLKLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CollisionDetectionMode DIKOJDOOKMD;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CEPPEJBLCGE]
public struct CNBHKKLMHFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public GGHKEJOODBA DPGGHNNGJFP;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly CNBHKKLMHFK DPPOJDBEGAC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BGIAOEAGECJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KNPNGPFLBKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct LKIBKLLJJBA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct NOMOABCJFEA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity BBNLJLBANGM;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ECKFMBBAJMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity IIOPLDELPHL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IONNNPGLOFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GJBGLNDPGFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity FINELPFBLOK;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KLMGPFBDMBB : MPNAPJPPNHB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LKDBJJLCJFF EGDFENNKPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(LKDBJJLCJFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct OLIIIJBMDGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3 JHHMDEPKMHK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct APNBOHJGIOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CEPPEJBLCGE]
public struct DDOAGPECKFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 KPHEAMINHPD;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly DDOAGPECKFP DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[CEPPEJBLCGE]
public struct JBNDGGFDGFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3x3 KPHEAMINHPD;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly JBNDGGFDGFE DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LLMAPFOBPCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 MDJKGCHPOIM;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct NJINFAPMGHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3 PFKJDAOKNOH;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[CEPPEJBLCGE]
public struct LHGLIJDOLHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float FOLHFMPODCB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly LHGLIJDOLHB DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[CEPPEJBLCGE]
public struct JKMDFKPLKKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float APCOMMKOIJO;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly JKMDFKPLKKI DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct OGGFPGMDDLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 DLDHGCMFNCN;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MNGIDFJPHJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public JKBHAFMADLE GELMBKBNOMH;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PFJOGJICEED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public JKBHAFMADLE BJCNCOFJICI;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[NACHBFFGGAM]
public struct BJDBMNDMCOL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity GLFIOFJHMHG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KCOCJLJBGKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct GEBIIJLINEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct FFFKOKAMBKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public RigidbodyConstraints ANBNDKFDKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[CEPPEJBLCGE]
public struct AMDGHNBIGON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float KFCIMOFFMKG;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly AMDGHNBIGON DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct LAJBFCEADDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float BGEJOOEAEGP;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class PJPHMHCBFLP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct NBEFFMELDGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public object DGMAGOKPCJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject JPONDMDOHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object LOFMEKEIBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object EOEGDOPMNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NBEFFMELDGE DGMAGOKPCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate BAJIIHEBFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Delegate JPAIMNMKGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public OEJBDDIGDHA<Delegate> NBNHEGNPMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public OEJBDDIGDHA<Delegate> ADBGNLEHKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public OEJBDDIGDHA<Delegate> AJMCCAJNHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public OEJBDDIGDHA<Delegate> EBLGIKLKLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public OEJBDDIGDHA<Delegate> KLDEIMOBBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public OEJBDDIGDHA<Delegate> OLBIIBCIEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public OEJBDDIGDHA<Delegate> OECLLJMKBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public OEJBDDIGDHA<Delegate> AINBLDDNJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public OEJBDDIGDHA<Delegate> IHPADGKBHFF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6FB0", Offset = "0x6EE63B0", VA = "0x186EE6FB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public PJPHMHCBFLP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct DPLPJHMCDNF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct NPGMHGJJAIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int JJFHGHDBJLF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x175DE00", Offset = "0x175D200", VA = "0x18175DE00")]
	public static NPGMHGJJAIP ICFKEBCLOFF(int LIHHDPOHLDK)
	{
		return default(NPGMHGJJAIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class AJCGCKANPLG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Rigidbody AMNBHPNNAMP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4870", Offset = "0x6EE3C70", VA = "0x186EE4870", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public AJCGCKANPLG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct OOANLOEBPEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct PLBNEHCEAHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 DKHLGFLPFKA;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct DKFMKNDNMKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float3 NBBOFJMDBHM;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[CEPPEJBLCGE]
public struct JBKJANCAGOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float EIBFMEAJEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly JBKJANCAGOD DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KJCIMALEPPA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object MNFIAJEPEBD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6EE69F0", Offset = "0x6EE5DF0", VA = "0x186EE69F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public KJCIMALEPPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class KFKLMKCNOEA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public object JEPMNCBKMEP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6320", Offset = "0x6EE5720", VA = "0x186EE6320", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public KFKLMKCNOEA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct NKONOJKDPJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct BJDIPKCCOKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct DECOICHBHEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JLDEHCNOMAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct IJCEEJODHAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct OJBDPJBJPHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FixedString32Bytes ADANIHOIEKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[NACHBFFGGAM]
public struct AKANFIGAPHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity HDJLELFLAEI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static AKANFIGAPHB ICFKEBCLOFF(Entity LIHHDPOHLDK)
	{
		return default(AKANFIGAPHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct ENAIKBCNMAH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity GLFIOFJHMHG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static ENAIKBCNMAH ICFKEBCLOFF(Entity GLFIOFJHMHG)
	{
		return default(ENAIKBCNMAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct JNODIEHJFCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity AGNEDJFJDII;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct EKDHCJDJCHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity AGNEDJFJDII;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct LFOPOGIBLPD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity CACFFOJFMIB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0")]
	public static LFOPOGIBLPD ICFKEBCLOFF(Entity GLFIOFJHMHG)
	{
		return default(LFOPOGIBLPD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct KPDKPIKADJC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct LPCDMJCNEFL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct CAOFEEKMPKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint DMDALLEEEHI;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[NACHBFFGGAM]
internal struct NNLKBGIEPOO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity ILCEGPPMGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int AEAHMAMPNLO;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct CNMLNEBCIAE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity EDPABMPBBIL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct EMDFMGPMJIK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct DBPJAEGIGFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public uint NEBOKKOGFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int KAMFCNHPLNA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA74660", Offset = "0xA73A60", VA = "0x180A74660")]
	public DBPJAEGIGFH(uint FOKNDCAPLEL, int DHOCKOJADGD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct KEFNNFMIIHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct NEFJADGODBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct FLHDEHIGHPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct IDLLONHPCDO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct BFLHIKFNHMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct KKDMAIOFAPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct EFENKCBFHBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct MPCLPIJPEOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct CBPEOLFGDDP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct IGPMFHHIGME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct EIHCHNKGIKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct DMOMNOHIBHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct GGGHIKBBKEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct DEOFHJHOKEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MOFJJNHJIBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct JLKKNOOCBHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct EENNDBGEHIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct HBDALILPBAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct DPCMBNHEEHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct HCLMFLICGGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MDLJFINABPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HDAMFFHGDDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct DLCLEEKAIBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct KIFMLKKKIFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct NOLBEONLDNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct LMNMNODGNMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct BIBMMKKBDPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct GAEMBPMPCCA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[NACHBFFGGAM]
public struct OKCOIMKOODP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes KOHHCGEDHKD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct AJHJBNJKHCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct BEHIHJCKCBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct LKGOAGPJOLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct IJDFACIHLBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct AMDDIEOABCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct GEPLBLDPJDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct KAJFIPMIDHB : IComponentData, IComparable<KAJFIPMIDHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int FJPEKLOANFJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F84150", Offset = "0x1F83550", VA = "0x181F84150", Slot = "4")]
	public int CompareTo(KAJFIPMIDHB OCKBFCIKBEN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct FJBNLJPLIFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MGHMNIKJENB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public quaternion EFFHGIJAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 MBJNFCDOKCE;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LOOMHGEHDLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float JDJNLGPJCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float FECGGMCMMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float BICKKFGHHLK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct OIOMDIPPOMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct CAIGDMDOAML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct GMAMAHAJLBD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct HLFKINDHPCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int IPFLJJEIEDM;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[NACHBFFGGAM]
public struct DNFDOHAOBKH : ISystemStateBufferElementData, IBufferElementData, OOCPMEOPAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity OLFOKAIDJJB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity LONFIIBANJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[CEPPEJBLCGE]
public struct JDIEANFEHJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 OLNCOFIJPPD;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly JDIEANFEHJJ DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[CEPPEJBLCGE]
public struct ONPDEGMBDME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float4x4 CAFBJCDCNAC;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly ONPDEGMBDME DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct EELOJHALEJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int EMFOBCBJPAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AEAHMAMPNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5170", Offset = "0x6EE4570", VA = "0x186EE5170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5160", Offset = "0x6EE4560", VA = "0x186EE5160")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[CEPPEJBLCGE]
public struct HGLAKLCPOLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 BOHLGAGBDNL;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly HGLAKLCPOLI DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[CEPPEJBLCGE]
public struct JPJLDMJIMAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 MBJNFCDOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public quaternion EFFHGIJAIIE;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly JPJLDMJIMAD DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class CGLLCOPKEJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[CEPPEJBLCGE]
public struct OEBPGOCOANE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float AAKBEONIBBB;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly OEBPGOCOANE DPPOJDBEGAC;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct GOECAJDIPKI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity DBIFLCNMMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public COLLBNOHADC DDBAKACFGMN;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct MANOIIKDPBA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public COLLBNOHADC DDBAKACFGMN;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct NKKICKBDFHE : ISystemStateComponentData, IComponentData, OOCPMEOPAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity IMHKEPBHMIM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity LONFIIBANJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct BPMHBCCIEMB : ISystemStateBufferElementData, IBufferElementData, OOCPMEOPAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity GICGDKLEGEL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity LONFIIBANJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct BALBNNLJJFC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity DBIFLCNMMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public COLLBNOHADC DDBAKACFGMN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct AFGLCFLFPCC : IEqualityComparer<BALBNNLJJFC>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static AFGLCFLFPCC DPPOJDBEGAC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE47C0", Offset = "0x6EE3BC0", VA = "0x186EE47C0", Slot = "4")]
	public bool Equals(BALBNNLJJFC CFANGCOBGCF, BALBNNLJJFC HHLCHNICLGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4810", Offset = "0x6EE3C10", VA = "0x186EE4810", Slot = "5")]
	public int GetHashCode(BALBNNLJJFC PBAACPJGKNP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct IJDLKIKKPJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> DDHIEPBKNHM;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct ANNGOECPHEI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FixedList32Bytes<int> DDHIEPBKNHM;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct NKCNAFDHCEA : ISystemStateBufferElementData, IBufferElementData, OOCPMEOPAFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity DKLGEMAJDHG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity PANKHFPJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x112A3E0", Offset = "0x11297E0", VA = "0x18112A3E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class KHLELJOPBEC : ContainerPropertyBag<PJPHMHCBFLP>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class HIFINBELEAO : Property<PJPHMHCBFLP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6EE57A0", Offset = "0x6EE4BA0", VA = "0x186EE57A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5760", Offset = "0x6EE4B60", VA = "0x186EE5760")]
		public HIFINBELEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A10", Offset = "0x6EE3E10", VA = "0x186EE4A10", Slot = "14")]
		public override GameObject GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A30", Offset = "0x6EE3E30", VA = "0x186EE4A30", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, GameObject LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class FOLGELLDJAI : Property<PJPHMHCBFLP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6EE53E0", Offset = "0x6EE47E0", VA = "0x186EE53E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6EE53A0", Offset = "0x6EE47A0", VA = "0x186EE53A0")]
		public FOLGELLDJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5350", Offset = "0x6EE4750", VA = "0x186EE5350", Slot = "14")]
		public override object GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5370", Offset = "0x6EE4770", VA = "0x186EE5370", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, object LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class LIEOBIJGEDE : Property<PJPHMHCBFLP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6C20", Offset = "0x6EE6020", VA = "0x186EE6C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6BE0", Offset = "0x6EE5FE0", VA = "0x186EE6BE0")]
		public LIEOBIJGEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6B90", Offset = "0x6EE5F90", VA = "0x186EE6B90", Slot = "14")]
		public override object GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6BB0", Offset = "0x6EE5FB0", VA = "0x186EE6BB0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, object LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class IJNINBLMEDI : Property<PJPHMHCBFLP, PJPHMHCBFLP.NBEFFMELDGE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5B10", Offset = "0x6EE4F10", VA = "0x186EE5B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5AD0", Offset = "0x6EE4ED0", VA = "0x186EE5AD0")]
		public IJNINBLMEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A80", Offset = "0x6EE4E80", VA = "0x186EE5A80", Slot = "14")]
		public override PJPHMHCBFLP.NBEFFMELDGE GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(PJPHMHCBFLP.NBEFFMELDGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5AA0", Offset = "0x6EE4EA0", VA = "0x186EE5AA0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, PJPHMHCBFLP.NBEFFMELDGE LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class NGCJAEMEOCB : Property<PJPHMHCBFLP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6D50", Offset = "0x6EE6150", VA = "0x186EE6D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6D10", Offset = "0x6EE6110", VA = "0x186EE6D10")]
		public NGCJAEMEOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6CC0", Offset = "0x6EE60C0", VA = "0x186EE6CC0", Slot = "14")]
		public override Delegate GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6CE0", Offset = "0x6EE60E0", VA = "0x186EE6CE0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, Delegate LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class BEECPKBGIBL : Property<PJPHMHCBFLP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6EE49E0", Offset = "0x6EE3DE0", VA = "0x186EE49E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE49A0", Offset = "0x6EE3DA0", VA = "0x186EE49A0")]
		public BEECPKBGIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4950", Offset = "0x6EE3D50", VA = "0x186EE4950", Slot = "14")]
		public override Delegate GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4970", Offset = "0x6EE3D70", VA = "0x186EE4970", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, Delegate LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class HPKJMGLPOIC : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5A50", Offset = "0x6EE4E50", VA = "0x186EE5A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A10", Offset = "0x6EE4E10", VA = "0x186EE5A10")]
		public HPKJMGLPOIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EE59A0", Offset = "0x6EE4DA0", VA = "0x186EE59A0", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6EE59D0", Offset = "0x6EE4DD0", VA = "0x186EE59D0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class KEEHCNCGHAF : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6EE62F0", Offset = "0x6EE56F0", VA = "0x186EE62F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6EE62B0", Offset = "0x6EE56B0", VA = "0x186EE62B0")]
		public KEEHCNCGHAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6240", Offset = "0x6EE5640", VA = "0x186EE6240", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6270", Offset = "0x6EE5670", VA = "0x186EE6270", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class HJNHGKABOPB : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5880", Offset = "0x6EE4C80", VA = "0x186EE5880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5840", Offset = "0x6EE4C40", VA = "0x186EE5840")]
		public HJNHGKABOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE57D0", Offset = "0x6EE4BD0", VA = "0x186EE57D0", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5800", Offset = "0x6EE4C00", VA = "0x186EE5800", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class KCFABPDIIBJ : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6210", Offset = "0x6EE5610", VA = "0x186EE6210", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE61D0", Offset = "0x6EE55D0", VA = "0x186EE61D0")]
		public KCFABPDIIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6150", Offset = "0x6EE5550", VA = "0x186EE6150", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6190", Offset = "0x6EE5590", VA = "0x186EE6190", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class HNGMGICBBDN : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5970", Offset = "0x6EE4D70", VA = "0x186EE5970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5930", Offset = "0x6EE4D30", VA = "0x186EE5930")]
		public HNGMGICBBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6EE58B0", Offset = "0x6EE4CB0", VA = "0x186EE58B0", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6EE58F0", Offset = "0x6EE4CF0", VA = "0x186EE58F0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class EJKFCCENFEH : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5240", Offset = "0x6EE4640", VA = "0x186EE5240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5200", Offset = "0x6EE4600", VA = "0x186EE5200")]
		public EJKFCCENFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5180", Offset = "0x6EE4580", VA = "0x186EE5180", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE51C0", Offset = "0x6EE45C0", VA = "0x186EE51C0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class JIDOBKHOHAJ : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5E60", Offset = "0x6EE5260", VA = "0x186EE5E60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5E20", Offset = "0x6EE5220", VA = "0x186EE5E20")]
		public JIDOBKHOHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5DA0", Offset = "0x6EE51A0", VA = "0x186EE5DA0", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5DE0", Offset = "0x6EE51E0", VA = "0x186EE5DE0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class ECIDAIOBFPK : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6EE5130", Offset = "0x6EE4530", VA = "0x186EE5130", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE50F0", Offset = "0x6EE44F0", VA = "0x186EE50F0")]
		public ECIDAIOBFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5070", Offset = "0x6EE4470", VA = "0x186EE5070", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE50B0", Offset = "0x6EE44B0", VA = "0x186EE50B0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class PJLFFFMPPCK : Property<PJPHMHCBFLP, OEJBDDIGDHA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6F80", Offset = "0x6EE6380", VA = "0x186EE6F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6F40", Offset = "0x6EE6340", VA = "0x186EE6F40")]
		public PJLFFFMPPCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6EC0", Offset = "0x6EE62C0", VA = "0x186EE6EC0", Slot = "14")]
		public override OEJBDDIGDHA<Delegate> GetValue(PJPHMHCBFLP KLAPMCLMAPI)
		{
			return default(OEJBDDIGDHA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6F00", Offset = "0x6EE6300", VA = "0x186EE6F00", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP KLAPMCLMAPI, OEJBDDIGDHA<Delegate> LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE6390", Offset = "0x6EE5790", VA = "0x186EE6390")]
	public KHLELJOPBEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class FNGPNKBJFNA : ContainerPropertyBag<PJPHMHCBFLP.NBEFFMELDGE>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class MGEFMGJDIDG : Property<PJPHMHCBFLP.NBEFFMELDGE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6C90", Offset = "0x6EE6090", VA = "0x186EE6C90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6C50", Offset = "0x6EE6050", VA = "0x186EE6C50")]
		public MGEFMGJDIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9310", Offset = "0x9F8710", VA = "0x1809F9310", Slot = "14")]
		public override object GetValue(PJPHMHCBFLP.NBEFFMELDGE KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4BB35A0", Offset = "0x4BB29A0", VA = "0x184BB35A0", Slot = "15")]
		public override void SetValue(PJPHMHCBFLP.NBEFFMELDGE KLAPMCLMAPI, object LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5270", Offset = "0x6EE4670", VA = "0x186EE5270")]
	public FNGPNKBJFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class PKCJPLBECBI : ContainerPropertyBag<OEJBDDIGDHA<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7000", Offset = "0x6EE6400", VA = "0x186EE7000")]
	public PKCJPLBECBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class BONIDOLFHIJ : ContainerPropertyBag<AJCGCKANPLG>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class KALAFGFPEDL : Property<AJCGCKANPLG, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6EE6120", Offset = "0x6EE5520", VA = "0x186EE6120", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6EE60E0", Offset = "0x6EE54E0", VA = "0x186EE60E0")]
		public KALAFGFPEDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A10", Offset = "0x6EE3E10", VA = "0x186EE4A10", Slot = "14")]
		public override Rigidbody GetValue(AJCGCKANPLG KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A30", Offset = "0x6EE3E30", VA = "0x186EE4A30", Slot = "15")]
		public override void SetValue(AJCGCKANPLG KLAPMCLMAPI, Rigidbody LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4B40", Offset = "0x6EE3F40", VA = "0x186EE4B40")]
	public BONIDOLFHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JNAHLAMAEKJ : ContainerPropertyBag<KJCIMALEPPA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class BNBHDNPFNOO : Property<KJCIMALEPPA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4B10", Offset = "0x6EE3F10", VA = "0x186EE4B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4AD0", Offset = "0x6EE3ED0", VA = "0x186EE4AD0")]
		public BNBHDNPFNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A10", Offset = "0x6EE3E10", VA = "0x186EE4A10", Slot = "14")]
		public override object GetValue(KJCIMALEPPA KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A30", Offset = "0x6EE3E30", VA = "0x186EE4A30", Slot = "15")]
		public override void SetValue(KJCIMALEPPA KLAPMCLMAPI, object LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5ED0", Offset = "0x6EE52D0", VA = "0x186EE5ED0")]
	public JNAHLAMAEKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class DGKMHDFLPPN : ContainerPropertyBag<KFKLMKCNOEA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class BHKLGHNLGIK : Property<KFKLMKCNOEA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string BKJCNMKILGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6EE4AA0", Offset = "0x6EE3EA0", VA = "0x186EE4AA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool OGEBMIKLHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A60", Offset = "0x6EE3E60", VA = "0x186EE4A60")]
		public BHKLGHNLGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A10", Offset = "0x6EE3E10", VA = "0x186EE4A10", Slot = "14")]
		public override object GetValue(KFKLMKCNOEA KLAPMCLMAPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4A30", Offset = "0x6EE3E30", VA = "0x186EE4A30", Slot = "15")]
		public override void SetValue(KFKLMKCNOEA KLAPMCLMAPI, object LIHHDPOHLDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4F90", Offset = "0x6EE4390", VA = "0x186EE4F90")]
	public DGKMHDFLPPN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7060", Offset = "0x6EE6460", VA = "0x186EE7060")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class EOOKEPBOIFH
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public EOOKEPBOIFH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
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

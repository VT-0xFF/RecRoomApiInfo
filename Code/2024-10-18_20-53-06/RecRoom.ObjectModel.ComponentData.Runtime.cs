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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7250", Offset = "0x6ED6650", VA = "0x186ED7250", Slot = "9")]
		public override void GODKDCDNPIN(ODFBNDCDLKP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6DE0", Offset = "0x6ED61E0", VA = "0x186ED6DE0", Slot = "7")]
		public override void FHGDNAMCNFF(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HFEKECAGOLF : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, IJJMFBMHOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6ED40D0", Offset = "0x6ED34D0", VA = "0x186ED40D0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, IJJMFBMHOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FOLLEIMPANK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NBBLHMPNPOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity MKPENDKHMJE;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PLOEKAFMFCM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity MKPENDKHMJE;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GCNHEKPNPMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<JMBDDIOMEBN> PHPOAPFDPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> FMNHMKFDJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle NCGFNEJFFED;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JDLMGHLFGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5530", Offset = "0x6ED4930", VA = "0x186ED5530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED56C0", Offset = "0x6ED4AC0", VA = "0x186ED56C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5068600", Offset = "0x5067A00", VA = "0x185068600")]
	public GCNHEKPNPMF(NativeList<JMBDDIOMEBN> PHPOAPFDPHF, NativeList<Entity> FMNHMKFDJAF, JobHandle NCGFNEJFFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6ED55A0", Offset = "0x6ED49A0", VA = "0x186ED55A0")]
	public (Entity, NativeSlice<Entity>) JLNIBOJFBBH(int PGOOPNPHNCA)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6ED54D0", Offset = "0x6ED48D0", VA = "0x186ED54D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JMBDDIOMEBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity KCFGMPGPMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int OLMEFNCLGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int LOKMFEIHLAN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MEHFNKLGDCL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCCGNKKALKL(bool HCLDGOFIEIE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PNCOGLBPEGO : IEquatable<PNCOGLBPEGO>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool GOLJAKGGNKH(int KIGKEDGNJCM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool IGFJJEFDAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool ELGGCGPGHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool KICIAGOHDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool KPFHAIPLEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GOLJAKGGNKH DHCEMCJOEBF;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6ED68C0", Offset = "0x6ED5CC0", VA = "0x186ED68C0")]
	public PNCOGLBPEGO(MHPNLKALAJE MOPHLBHNAIL, GOLJAKGGNKH DHCEMCJOEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6890", Offset = "0x6ED5C90", VA = "0x186ED6890")]
	public PNCOGLBPEGO(bool IGFJJEFDAPJ, bool ELGGCGPGHDK, bool KICIAGOHDKC, bool KPFHAIPLEIH, GOLJAKGGNKH DHCEMCJOEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6660", Offset = "0x6ED5A60", VA = "0x186ED6660")]
	public bool EGMLJDIDAGF(int KIGKEDGNJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6860", Offset = "0x6ED5C60", VA = "0x186ED6860")]
	public bool MNAPLOGGCLP(int KIGKEDGNJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6770", Offset = "0x6ED5B70", VA = "0x186ED6770")]
	public bool FLBMECDFFEA(int KIGKEDGNJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6630", Offset = "0x6ED5A30", VA = "0x186ED6630")]
	public bool DLFJOEFMHJK(int KIGKEDGNJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6690", Offset = "0x6ED5A90", VA = "0x186ED6690", Slot = "4")]
	public bool Equals(PNCOGLBPEGO KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED66C0", Offset = "0x6ED5AC0", VA = "0x186ED66C0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED67A0", Offset = "0x6ED5BA0", VA = "0x186ED67A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6840", Offset = "0x6ED5C40", VA = "0x186ED6840")]
	private bool HKIMBHIBGEA(int KIGKEDGNJCM)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LLBEMJAOGBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CDCECDNIBDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FLKLEMAMFHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct BFMCLNAKMDB : IBufferElementData, IEquatable<BFMCLNAKMDB>, IJJMFBMHOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity KADEDLJJJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int IAFMPAIKJAF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity BHEJKLBADKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6ED40E0", Offset = "0x6ED34E0", VA = "0x186ED40E0", Slot = "4")]
	public bool Equals(BFMCLNAKMDB KNLMODPGFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct JODBOBJPCOB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct OBMKJHKPLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CHKGPPNLCHD LDKONBAMFMF;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x23E8990", Offset = "0x23E7D90", VA = "0x1823E8990")]
		public OBMKJHKPLFA(CHKGPPNLCHD ENJCFLDEILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6450", Offset = "0x6ED5850", VA = "0x186ED6450")]
		public bool CDONDNFFMPK(JODBOBJPCOB HMNKCALELIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6440", Offset = "0x6ED5840", VA = "0x186ED6440")]
		public bool BEPMEBKHJAG(JODBOBJPCOB HMNKCALELIN, CHKGPPNLCHD FBGCGCBPIHE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly CHKGPPNLCHD PNNDGNECDFN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23E8990", Offset = "0x23E7D90", VA = "0x1823E8990")]
	public JODBOBJPCOB(CHKGPPNLCHD PNNDGNECDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5C10", Offset = "0x6ED5010", VA = "0x186ED5C10")]
	public JODBOBJPCOB KAOFLHKBIGC(CHKGPPNLCHD FBJOCAMBKBA)
	{
		return default(JODBOBJPCOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5C00", Offset = "0x6ED5000", VA = "0x186ED5C00")]
	public JODBOBJPCOB GKLFABGEFFC(CHKGPPNLCHD FLJCLBPHFOP)
	{
		return default(JODBOBJPCOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5C20", Offset = "0x6ED5020", VA = "0x186ED5C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum CHKGPPNLCHD : byte
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
public enum EMHDNBMABMA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KDDEBMLONMH]
public struct FOIFIEPDPOM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public EMHDNBMABMA PNNDGNECDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool BBEIAPKHAME;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FOGMEJJPINO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED53C0", Offset = "0x6ED47C0", VA = "0x186ED53C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5410", Offset = "0x6ED4810", VA = "0x186ED5410")]
	private FOIFIEPDPOM(EMHDNBMABMA PNNDGNECDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED53F0", Offset = "0x6ED47F0", VA = "0x186ED53F0")]
	public FOIFIEPDPOM KAOFLHKBIGC(EMHDNBMABMA FBJOCAMBKBA)
	{
		return default(FOIFIEPDPOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED53D0", Offset = "0x6ED47D0", VA = "0x186ED53D0")]
	public FOIFIEPDPOM GKLFABGEFFC(EMHDNBMABMA FLJCLBPHFOP)
	{
		return default(FOIFIEPDPOM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KJBBHEJLJPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct GPGFAFFGFCD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity JNFMEKLKAAC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, IJJMFBMHOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6ED40D0", Offset = "0x6ED34D0", VA = "0x186ED40D0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[KDDEBMLONMH]
public struct JIJJDCNPEHL : ISystemStateBufferElementData, IBufferElementData, IJJMFBMHOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity KFLBPHJAJJL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity HNEDHKDBNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MEJHPKNGFKB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity JACEJBMEGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity HMBOCLLNDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity CGCBMHAGOAD;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct ONEAHEPPKFK<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly bool CPKPPJFCLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint GFHDJGDLHCL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool IDPBMMGFFJD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct BGNNGHBDGGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public uint HMIKNHIODJA;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4130", Offset = "0x6ED3530", VA = "0x186ED4130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IJIGMDNMBBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KDDEBMLONMH]
public struct ILBNBGPAGGH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int PHIGGHJMAKD;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JLGNMLMOCAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int AEAJAMHEDBI;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct APECJFABIPN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GCHandle AHGKLMFLOAN;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct BACGNDICEAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int AEAJAMHEDBI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JHPDJCKHCMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DKPLFPAAKKP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int AEAJAMHEDBI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct EEDHPHFGING : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct CMEHOCIHFDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct AEGDPIGJFIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct NFEAHJHJAFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CollisionDetectionMode GDGLJBOPOGO;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PFCDPCKNEOK]
public struct GAJJNKBONKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public JHPLKFFCHDF HHOJLFLENMB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly GAJJNKBONKE BONGJJLJANI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BKEDDDHLDMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BENBEFHNHCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct IMFPDPPLGHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct IMAOOLBMJGM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity KADEDLJJJFO;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct PCFLPFDMBKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity DEDHJMDEEIE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KMGIAAOPALF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct EDFMAINBLEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity KCFGMPGPMFA;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct PIBFCHGJHOA : GBLBIOPPAEE, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DEGJJGDACCH LPNGFFCEAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(DEGJJGDACCH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LCFFOBHBHOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3 DPJDAGBFMPA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct JEDIJACAENO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PFCDPCKNEOK]
public struct DHCOEECGJNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 GDOAKHFJMIE;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly DHCOEECGJNI BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PFCDPCKNEOK]
public struct JPCALKKNKBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3x3 GDOAKHFJMIE;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly JPCALKKNKBI BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct INKPBEKDPNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 NGMMDAEMMOD;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct AJJNENCKDEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3 KMAPIAABKLB;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PFCDPCKNEOK]
public struct CMCCEHNACCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float HAKHDOPAANA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly CMCCEHNACCB BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PFCDPCKNEOK]
public struct EEAMILFKNND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float OEDOLBEBPAL;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EEAMILFKNND BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct JPPCCOFPEKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 HLPHMHEEKLB;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct CMNBMINDFOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LGMGBDCHIJJ LGKAHCGFMBH;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NNKOPLDIAGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public LGMGBDCHIJJ DPCCCHJOODD;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[KDDEBMLONMH]
public struct AEFHJOPFJPE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity KFLBPHJAJJL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct ECCNCGBMBOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct PMCGGDLPCHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct LBIBJKBCPDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public RigidbodyConstraints APGEKBNINPE;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[PFCDPCKNEOK]
public struct EKBCNHJBAEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float IJEGMGKOCME;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly EKBCNHJBAEJ BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct OPNAHAHAJMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float MDKLFLDLIGL;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class CIANCIDELPI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct PLMCINGOKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public object KKBKFEKPJDP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject BCDDMHHPJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object GPCHFGDJDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object OGNONKDLBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public PLMCINGOKGI KKBKFEKPJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate IKDIOGOPPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Delegate BKALNPGGMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public KCGEJFGCIEC<Delegate> PGPOEHBEHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public KCGEJFGCIEC<Delegate> FEPIPPDKHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public KCGEJFGCIEC<Delegate> NGIHLBFCEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public KCGEJFGCIEC<Delegate> ABCFJKIKOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public KCGEJFGCIEC<Delegate> KEILCNCNFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public KCGEJFGCIEC<Delegate> OHPIEBMDMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public KCGEJFGCIEC<Delegate> HGPKPBOHDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public KCGEJFGCIEC<Delegate> IEGEAMMFFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public KCGEJFGCIEC<Delegate> FEDGFBIJJGC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4370", Offset = "0x6ED3770", VA = "0x186ED4370", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public CIANCIDELPI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AOEHKCPECLF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct GJLLBCHNADH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int JPINDNJKION;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1731A10", Offset = "0x1730E10", VA = "0x181731A10")]
	public static GJLLBCHNADH EGFECENGKHG(int EEPLCHCGAIN)
	{
		return default(GJLLBCHNADH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class LBOFCGAADJD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Rigidbody FLPMJAFBFIG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6110", Offset = "0x6ED5510", VA = "0x186ED6110", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public LBOFCGAADJD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct DGNHNPAAKIM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct KGNFPGKHJEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 BGJOJHOMGKA;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct JKNDOMHAJMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float3 DLNLPMKHKIC;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[PFCDPCKNEOK]
public struct BMHMPKMINEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float GKLBIKHMPPN;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly BMHMPKMINEA BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class EOMJKAGAIJH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object IIFNIABMLHO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4F30", Offset = "0x6ED4330", VA = "0x186ED4F30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public EOMJKAGAIJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class KHCEFJIAEIM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public object DLNBJKEGKFI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5F00", Offset = "0x6ED5300", VA = "0x186ED5F00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public KHCEFJIAEIM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct GIPGNBIAOKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct KMCCKJCLOBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct KFAIJIPMMMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct CLBFCJNJPCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HMGDFKIHLAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KOAJHIHHHBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FixedString32Bytes DDDHPCNFCEK;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[KDDEBMLONMH]
public struct BPKEGJCEPOJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity AMLGJOJEOEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static BPKEGJCEPOJ EGFECENGKHG(Entity EEPLCHCGAIN)
	{
		return default(BPKEGJCEPOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct IBJLAOGFCGP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity KFLBPHJAJJL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static IBJLAOGFCGP EGFECENGKHG(Entity KFLBPHJAJJL)
	{
		return default(IBJLAOGFCGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct AMCBOJEBDLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity ENPCBPAPFCK;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct EBDKHPIBPHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity ENPCBPAPFCK;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct DBBIOMHKJJB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity OHDLNODBGMB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460")]
	public static DBBIOMHKJJB EGFECENGKHG(Entity KFLBPHJAJJL)
	{
		return default(DBBIOMHKJJB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct OIHPPKIEEND : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct BDBOCIJOIME : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct JJDCIGKKIED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint ABNEAOFINHP;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[KDDEBMLONMH]
internal struct FCCCPGLNMKF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity GKDKLJEKOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int HAJICDLBEKC;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct IIOALNMHBMM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity AHMPLBBAMHE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct NGJFCCNMBHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct DEGLMFAKNGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public uint GFHDJGDLHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int OLEKHMIBMHI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
	public DEGLMFAKNGN(uint AMFBBPILKDO, int KLPPBBAKDIE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct MGJHGGPKPFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FOJAOLFLNAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct JLKMNNGHHDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct FIHKDOENGAJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct OFLJNFLCDMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct BOEKAEGFEGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GBMLLHCJCJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct LIIBHNCCGAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct ODHNOLLBGMH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct CDMILMGOJNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct BAHGAIBOGBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FKHGNJMEBEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct LONJBDILFLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct JBANBJLKIKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OBHFGJJBNBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct IKCJKHJOJDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct KLNCGJCFDAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OJOJNPPFAME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct EHFPCHFJKNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct IKNJJDCPICC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct OLKIIEJGIGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct MMPNCMLPEEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct GHNPBJFFOHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct IEPHBJDBLMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct EBPEPEDEFHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct DLNLIELHIGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct FJGMFLAHPNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct OKDPBFOLHJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[KDDEBMLONMH]
public struct MPAKIPIFOEP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes ICMMNOKPMGG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct DIIBPLLFBLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct PPMOEPIOEHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct PLJKBDOOOIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct CKOCLEABKJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct MPFIDICIOOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct DCJCGHCMGGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct KJJDLKIMMCG : IComponentData, IComparable<KJJDLKIMMCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int JKDHINEFMLG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F33FB0", Offset = "0x1F333B0", VA = "0x181F33FB0", Slot = "4")]
	public int CompareTo(KJJDLKIMMCG KNLMODPGFOA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct NBMPGKAFMKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct PIPHKHDDAPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public quaternion MDJOMEFJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 CLHMEGFDOKF;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct CBFNNCHHHHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float CMKDKBKKAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float BLINFIIKBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float AMKINHGOMFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GCPFBDGFGFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct FNFDMCGDCLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct BEODGHABEAD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct JDIEPOEFMIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int AEAJAMHEDBI;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[KDDEBMLONMH]
public struct FOGLBGJJDBI : ISystemStateBufferElementData, IBufferElementData, IJJMFBMHOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity FCFKEIFCDCL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity HNEDHKDBNID
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PFCDPCKNEOK]
public struct KJIPDCFKJNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 HHOCJEIFIIL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly KJIPDCFKJNE BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[PFCDPCKNEOK]
public struct BLHIMOKIIBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float4x4 PDPDNLJIBAL;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly BLHIMOKIIBC BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct DKLLKONIGKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int NOHCICKLMII;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HAJICDLBEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4D30", Offset = "0x6ED4130", VA = "0x186ED4D30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4D20", Offset = "0x6ED4120", VA = "0x186ED4D20")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PFCDPCKNEOK]
public struct EMKOFGPFINN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 LBAGFEFBFHM;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly EMKOFGPFINN BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[PFCDPCKNEOK]
public struct PHOGBJFIEGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 CLHMEGFDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public quaternion MDJOMEFJFHD;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly PHOGBJFIEGM BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class DOGANOJENBD
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[PFCDPCKNEOK]
public struct OECAJPFLPHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float MBLHNCMAFPB;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly OECAJPFLPHC BONGJJLJANI;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct MIFHLCHFEBP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity KKOJCNMAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public ABCKHNEHFAE KEKHLMMPMLO;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct DHFCJAGONKF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ABCKHNEHFAE KEKHLMMPMLO;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct KCDCECMOCNM : ISystemStateComponentData, IComponentData, IJJMFBMHOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity OACLGAKONPN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity HNEDHKDBNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct NDJPOGMILOJ : ISystemStateBufferElementData, IBufferElementData, IJJMFBMHOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity JMEKGEONDHK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity HNEDHKDBNID
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct BFJHEJBNLPM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity KKOJCNMAGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ABCKHNEHFAE KEKHLMMPMLO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct KGOODJACMHB : IEqualityComparer<BFJHEJBNLPM>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static KGOODJACMHB BONGJJLJANI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5E50", Offset = "0x6ED5250", VA = "0x186ED5E50", Slot = "4")]
	public bool Equals(BFJHEJBNLPM LBEGFJJGJFP, BFJHEJBNLPM GAMIAAAKNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5EA0", Offset = "0x6ED52A0", VA = "0x186ED5EA0", Slot = "5")]
	public int GetHashCode(BFJHEJBNLPM FMAFBHGACNM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct PFEFLHPOMHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> HNGFBCNFFAA;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct IJALJLKKCAM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FixedList32Bytes<int> HNGFBCNFFAA;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct HGELCEDGOEJ : ISystemStateBufferElementData, IBufferElementData, IJJMFBMHOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity BPMECCNPOBO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity BHEJKLBADKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9FE670", Offset = "0x9FDA70", VA = "0x1809FE670", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x10FC370", Offset = "0x10FB770", VA = "0x1810FC370", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class CLJFLEIHCNK : ContainerPropertyBag<CIANCIDELPI>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class FMBMHHJOBPJ : Property<CIANCIDELPI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6ED52D0", Offset = "0x6ED46D0", VA = "0x186ED52D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5290", Offset = "0x6ED4690", VA = "0x186ED5290")]
		public FMBMHHJOBPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5240", Offset = "0x6ED4640", VA = "0x186ED5240", Slot = "14")]
		public override GameObject GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5260", Offset = "0x6ED4660", VA = "0x186ED5260", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, GameObject EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class BPCEIOEONJH : Property<CIANCIDELPI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4340", Offset = "0x6ED3740", VA = "0x186ED4340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4300", Offset = "0x6ED3700", VA = "0x186ED4300")]
		public BPCEIOEONJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6ED42B0", Offset = "0x6ED36B0", VA = "0x186ED42B0", Slot = "14")]
		public override object GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ED42D0", Offset = "0x6ED36D0", VA = "0x186ED42D0", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, object EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class ICOCKEAPEMB : Property<CIANCIDELPI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5A30", Offset = "0x6ED4E30", VA = "0x186ED5A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED59F0", Offset = "0x6ED4DF0", VA = "0x186ED59F0")]
		public ICOCKEAPEMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED59A0", Offset = "0x6ED4DA0", VA = "0x186ED59A0", Slot = "14")]
		public override object GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED59C0", Offset = "0x6ED4DC0", VA = "0x186ED59C0", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, object EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class HCCGCKCCEJB : Property<CIANCIDELPI, CIANCIDELPI.PLMCINGOKGI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5900", Offset = "0x6ED4D00", VA = "0x186ED5900", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6ED58C0", Offset = "0x6ED4CC0", VA = "0x186ED58C0")]
		public HCCGCKCCEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5870", Offset = "0x6ED4C70", VA = "0x186ED5870", Slot = "14")]
		public override CIANCIDELPI.PLMCINGOKGI GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(CIANCIDELPI.PLMCINGOKGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5890", Offset = "0x6ED4C90", VA = "0x186ED5890", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, CIANCIDELPI.PLMCINGOKGI EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class JJLFPMKJHID : Property<CIANCIDELPI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5BD0", Offset = "0x6ED4FD0", VA = "0x186ED5BD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5B90", Offset = "0x6ED4F90", VA = "0x186ED5B90")]
		public JJLFPMKJHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5B40", Offset = "0x6ED4F40", VA = "0x186ED5B40", Slot = "14")]
		public override Delegate GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5B60", Offset = "0x6ED4F60", VA = "0x186ED5B60", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, Delegate EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class FNMKIGHDMHA : Property<CIANCIDELPI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5390", Offset = "0x6ED4790", VA = "0x186ED5390", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5350", Offset = "0x6ED4750", VA = "0x186ED5350")]
		public FNMKIGHDMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5300", Offset = "0x6ED4700", VA = "0x186ED5300", Slot = "14")]
		public override Delegate GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5320", Offset = "0x6ED4720", VA = "0x186ED5320", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, Delegate EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class IIDAEMEDEEL : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5B10", Offset = "0x6ED4F10", VA = "0x186ED5B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5AD0", Offset = "0x6ED4ED0", VA = "0x186ED5AD0")]
		public IIDAEMEDEEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5A60", Offset = "0x6ED4E60", VA = "0x186ED5A60", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5A90", Offset = "0x6ED4E90", VA = "0x186ED5A90", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class NOELJBGODNM : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6410", Offset = "0x6ED5810", VA = "0x186ED6410", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6ED63D0", Offset = "0x6ED57D0", VA = "0x186ED63D0")]
		public NOELJBGODNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6360", Offset = "0x6ED5760", VA = "0x186ED6360", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6390", Offset = "0x6ED5790", VA = "0x186ED6390", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class KAEBNKCPFLK : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5E20", Offset = "0x6ED5220", VA = "0x186ED5E20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5DE0", Offset = "0x6ED51E0", VA = "0x186ED5DE0")]
		public KAEBNKCPFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5D70", Offset = "0x6ED5170", VA = "0x186ED5D70", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5DA0", Offset = "0x6ED51A0", VA = "0x186ED5DA0", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class MIKNCBMKFPB : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6240", Offset = "0x6ED5640", VA = "0x186ED6240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6200", Offset = "0x6ED5600", VA = "0x186ED6200")]
		public MIKNCBMKFPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6180", Offset = "0x6ED5580", VA = "0x186ED6180", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6ED61C0", Offset = "0x6ED55C0", VA = "0x186ED61C0", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class MKMAMDADPIH : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6ED6330", Offset = "0x6ED5730", VA = "0x186ED6330", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6ED62F0", Offset = "0x6ED56F0", VA = "0x186ED62F0")]
		public MKMAMDADPIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6270", Offset = "0x6ED5670", VA = "0x186ED6270", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6ED62B0", Offset = "0x6ED56B0", VA = "0x186ED62B0", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class KMHCPPNDIPA : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6ED60E0", Offset = "0x6ED54E0", VA = "0x186ED60E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6ED60A0", Offset = "0x6ED54A0", VA = "0x186ED60A0")]
		public KMHCPPNDIPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6020", Offset = "0x6ED5420", VA = "0x186ED6020", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6060", Offset = "0x6ED5460", VA = "0x186ED6060", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class DFAKDJIGKCH : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4C00", Offset = "0x6ED4000", VA = "0x186ED4C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4BC0", Offset = "0x6ED3FC0", VA = "0x186ED4BC0")]
		public DFAKDJIGKCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4B40", Offset = "0x6ED3F40", VA = "0x186ED4B40", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4B80", Offset = "0x6ED3F80", VA = "0x186ED4B80", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class GLNHOPALMHG : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6ED57D0", Offset = "0x6ED4BD0", VA = "0x186ED57D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5790", Offset = "0x6ED4B90", VA = "0x186ED5790")]
		public GLNHOPALMHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5710", Offset = "0x6ED4B10", VA = "0x186ED5710", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5750", Offset = "0x6ED4B50", VA = "0x186ED5750", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class DOBDHAPOGPA : Property<CIANCIDELPI, KCGEJFGCIEC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4E00", Offset = "0x6ED4200", VA = "0x186ED4E00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4DC0", Offset = "0x6ED41C0", VA = "0x186ED4DC0")]
		public DOBDHAPOGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4D40", Offset = "0x6ED4140", VA = "0x186ED4D40", Slot = "14")]
		public override KCGEJFGCIEC<Delegate> GetValue(CIANCIDELPI FKEBHAJCLGD)
		{
			return default(KCGEJFGCIEC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4D80", Offset = "0x6ED4180", VA = "0x186ED4D80", Slot = "15")]
		public override void SetValue(CIANCIDELPI FKEBHAJCLGD, KCGEJFGCIEC<Delegate> EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6ED43C0", Offset = "0x6ED37C0", VA = "0x186ED43C0")]
	public CLJFLEIHCNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class FDEKLFAJLDI : ContainerPropertyBag<CIANCIDELPI.PLMCINGOKGI>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class AGLHKDFMFGI : Property<CIANCIDELPI.PLMCINGOKGI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6ED40A0", Offset = "0x6ED34A0", VA = "0x186ED40A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6ED4060", Offset = "0x6ED3460", VA = "0x186ED4060")]
		public AGLHKDFMFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9BDB10", Offset = "0x9BCF10", VA = "0x1809BDB10", Slot = "14")]
		public override object GetValue(CIANCIDELPI.PLMCINGOKGI FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B85900", Offset = "0x4B84D00", VA = "0x184B85900", Slot = "15")]
		public override void SetValue(CIANCIDELPI.PLMCINGOKGI FKEBHAJCLGD, object EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5080", Offset = "0x6ED4480", VA = "0x186ED5080")]
	public FDEKLFAJLDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class OOFKKKOLGLF : ContainerPropertyBag<KCGEJFGCIEC<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6ED64A0", Offset = "0x6ED58A0", VA = "0x186ED64A0")]
	public OOFKKKOLGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class FCIPGLKGMHL : ContainerPropertyBag<LBOFCGAADJD>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class HFIDEKJLCGF : Property<LBOFCGAADJD, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5970", Offset = "0x6ED4D70", VA = "0x186ED5970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5930", Offset = "0x6ED4D30", VA = "0x186ED5930")]
		public HFIDEKJLCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5240", Offset = "0x6ED4640", VA = "0x186ED5240", Slot = "14")]
		public override Rigidbody GetValue(LBOFCGAADJD FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5260", Offset = "0x6ED4660", VA = "0x186ED5260", Slot = "15")]
		public override void SetValue(LBOFCGAADJD FKEBHAJCLGD, Rigidbody EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4FA0", Offset = "0x6ED43A0", VA = "0x186ED4FA0")]
	public FCIPGLKGMHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class FEHCOENPIIO : ContainerPropertyBag<EOMJKAGAIJH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class GANDGJLCHCB : Property<EOMJKAGAIJH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6ED54A0", Offset = "0x6ED48A0", VA = "0x186ED54A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5460", Offset = "0x6ED4860", VA = "0x186ED5460")]
		public GANDGJLCHCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5240", Offset = "0x6ED4640", VA = "0x186ED5240", Slot = "14")]
		public override object GetValue(EOMJKAGAIJH FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5260", Offset = "0x6ED4660", VA = "0x186ED5260", Slot = "15")]
		public override void SetValue(EOMJKAGAIJH FKEBHAJCLGD, object EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5160", Offset = "0x6ED4560", VA = "0x186ED5160")]
	public FEHCOENPIIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class DCPHFBBFLME : ContainerPropertyBag<KHCEFJIAEIM>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class HAKJEANBJBN : Property<KHCEFJIAEIM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string ICAKBBAJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6ED5840", Offset = "0x6ED4C40", VA = "0x186ED5840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool IHEEMPBAFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5800", Offset = "0x6ED4C00", VA = "0x186ED5800")]
		public HAKJEANBJBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5240", Offset = "0x6ED4640", VA = "0x186ED5240", Slot = "14")]
		public override object GetValue(KHCEFJIAEIM FKEBHAJCLGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6ED5260", Offset = "0x6ED4660", VA = "0x186ED5260", Slot = "15")]
		public override void SetValue(KHCEFJIAEIM FKEBHAJCLGD, object EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6ED4A60", Offset = "0x6ED3E60", VA = "0x186ED4A60")]
	public DCPHFBBFLME()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6900", Offset = "0x6ED5D00", VA = "0x186ED6900")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class JHDCDGCMADC
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public JHDCDGCMADC()
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

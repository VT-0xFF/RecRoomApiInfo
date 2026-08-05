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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x736A560", Offset = "0x7369760", VA = "0x18736A560", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x736A910", Offset = "0x7369B10", VA = "0x18736A910", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JANNJELCIIG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, EKAFPKEPBPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73677B0", Offset = "0x73669B0", VA = "0x1873677B0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, EKAFPKEPBPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PICCNMBPABG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IJNIFGDNACK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity MPPBGKPCGPG;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JHBCMICMNKB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity MPPBGKPCGPG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OPHEHCEHDMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<DEHAMOPCFKI> IJKKBFFPJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> BJKKAAIBNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle DLGFKNLCAHD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GJCMKJAFLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7369CD0", Offset = "0x7368ED0", VA = "0x187369CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BIMHEMDFFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7369EC0", Offset = "0x73690C0", VA = "0x187369EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54914C0", Offset = "0x54906C0", VA = "0x1854914C0")]
	public OPHEHCEHDMC(NativeList<DEHAMOPCFKI> IJKKBFFPJJN, NativeList<Entity> BJKKAAIBNLG, JobHandle DLGFKNLCAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7369DA0", Offset = "0x7368FA0", VA = "0x187369DA0")]
	public (Entity, NativeSlice<Entity>) ECKGMDHHOJL(int KPGFBDAMCDA)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7369D40", Offset = "0x7368F40", VA = "0x187369D40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DEHAMOPCFKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity DONMCNODAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int KLICPJBJAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int BJJBELCKPHA;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PFAHFLNFHHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCHGKCKFBPK(bool APDCFGIOKJN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BPLFGCNEMLM : IEquatable<BPLFGCNEMLM>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool CFAHHHKDLAM(int NEKLIKCEFAN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool HCGJJEMJKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool FBDHIDOLOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool ICAMEHGEMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool CEDFEBHGIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CFAHHHKDLAM MIMLNPCHOPL;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7367C90", Offset = "0x7366E90", VA = "0x187367C90")]
	public BPLFGCNEMLM(EFIBLMLADKJ HPIEALDMKDL, CFAHHHKDLAM MIMLNPCHOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7367CE0", Offset = "0x7366EE0", VA = "0x187367CE0")]
	public BPLFGCNEMLM(bool HCGJJEMJKFO, bool FBDHIDOLOOK, bool ICAMEHGEMAI, bool CEDFEBHGIBC, CFAHHHKDLAM MIMLNPCHOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7367A80", Offset = "0x7366C80", VA = "0x187367A80")]
	public bool ENGFOODOKPN(int NEKLIKCEFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7367B90", Offset = "0x7366D90", VA = "0x187367B90")]
	public bool FDFLEKOOPLJ(int NEKLIKCEFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7367A50", Offset = "0x7366C50", VA = "0x187367A50")]
	public bool EDGKCDJDKJA(int NEKLIKCEFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7367C60", Offset = "0x7366E60", VA = "0x187367C60")]
	public bool IDJKNGCFMHP(int NEKLIKCEFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7367B60", Offset = "0x7366D60", VA = "0x187367B60", Slot = "4")]
	public bool Equals(BPLFGCNEMLM JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7367AB0", Offset = "0x7366CB0", VA = "0x187367AB0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7367BC0", Offset = "0x7366DC0", VA = "0x187367BC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7367A30", Offset = "0x7366C30", VA = "0x187367A30")]
	private bool ECHPNJAFKHJ(int NEKLIKCEFAN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GKGHDPACIAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JDNEHGGDFFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FFBGCECLGLK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct KILBKIAHAKE : IBufferElementData, IEquatable<KILBKIAHAKE>, EKAFPKEPBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity KGPDHHGDIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int EGJOLCEKGFE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity JHKIMHBGPBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73694E0", Offset = "0x73686E0", VA = "0x1873694E0", Slot = "4")]
	public bool Equals(KILBKIAHAKE JAINJPLCLDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OAEJKMBPIFG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KMKOIABPNNL NDNLMFPEABK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7369A20", Offset = "0x7368C20", VA = "0x187369A20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public OAEJKMBPIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KMKOIABPNNL
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FBLNCMBIMIA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FIGPHGHGAIE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct DLNFDDDLPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KEMIEFINEKI MFBIAIPKOIL;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B23000", Offset = "0x2B22200", VA = "0x182B23000")]
		public DLNFDDDLPLD(KEMIEFINEKI GEIKHCHIPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7367F80", Offset = "0x7367180", VA = "0x187367F80")]
		public bool IOIOFOCGOMM(FIGPHGHGAIE JCPIOJDOOIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7367F90", Offset = "0x7367190", VA = "0x187367F90")]
		public bool LHIDEDIOEJG(FIGPHGHGAIE JCPIOJDOOIC, KEMIEFINEKI OKCAEANJFCG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KEMIEFINEKI ICBDFLPIKCK;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B23000", Offset = "0x2B22200", VA = "0x182B23000")]
	public FIGPHGHGAIE(KEMIEFINEKI ICBDFLPIKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x73684E0", Offset = "0x73676E0", VA = "0x1873684E0")]
	public FIGPHGHGAIE HCKLIGDNHFD(KEMIEFINEKI IHPCDCDDGJJ)
	{
		return default(FIGPHGHGAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x73684D0", Offset = "0x73676D0", VA = "0x1873684D0")]
	public FIGPHGHGAIE DOGJPGGEPFO(KEMIEFINEKI DINGADIGADC)
	{
		return default(FIGPHGHGAIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73684F0", Offset = "0x73676F0", VA = "0x1873684F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum KEMIEFINEKI : ushort
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
public enum GJBPCLFGENB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[SingletonComponent]
public struct KGMNLBIGMJP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public GJBPCLFGENB ICBDFLPIKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool FKJMLCHEOPM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OEMILEIDEOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7369450", Offset = "0x7368650", VA = "0x187369450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7369480", Offset = "0x7368680", VA = "0x187369480")]
	private KGMNLBIGMJP(GJBPCLFGENB ICBDFLPIKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7369460", Offset = "0x7368660", VA = "0x187369460")]
	public KGMNLBIGMJP HCKLIGDNHFD(GJBPCLFGENB IHPCDCDDGJJ)
	{
		return default(KGMNLBIGMJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7369430", Offset = "0x7368630", VA = "0x187369430")]
	public KGMNLBIGMJP DOGJPGGEPFO(GJBPCLFGENB DINGADIGADC)
	{
		return default(KGMNLBIGMJP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MEFBPOAFNFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EHOBKCJPHME : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity PPPALAGKFON;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, EKAFPKEPBPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x73677B0", Offset = "0x73669B0", VA = "0x1873677B0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[SingletonComponent]
public struct BFELGDJBMNJ : ISystemStateBufferElementData, IBufferElementData, EKAFPKEPBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity KPFAGKHHMMH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity HMEPBLPCNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FOBHPGKAHKA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity JPFFLNFJCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity DIAPBPCMGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity JLMIJBBPKDK;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LOGKBMJGJBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Guid IBPGMNEANFH;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JBFAGEJGFDN<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool CLGLGAODANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint GDGPBNJNCNE;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	private static bool NKHBHCIHMPA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[TypeManager.TypeVersion(2)]
public struct ANJIELNIPKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public uint LEPMNPLMJHD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7367720", Offset = "0x7366920", VA = "0x187367720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct MAOFLDDFEND : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SingletonComponent]
public struct MMDCOCFIFBC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KJDDBPLFMEM;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PPCLECBJEEO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int NIGKDAPIFGC;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FPPPOECKNOB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GCHandle AFDPKHKJHJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MCHNCCABPFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int NIGKDAPIFGC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KODHLEBOEDC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GKLHPPNDGBD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int NIGKDAPIFGC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct INGKEFKLJNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct JAHIOAMKBOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KLOMDCONJAN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PAOGMNNIMDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public CollisionDetectionMode IBFDHPIELJJ;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RegisterComponentDefault]
public struct OCANMIGCAEE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public MICCOKKHGKO AAGJLNLGFNO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly OCANMIGCAEE MIAJNEPFAEF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct EAEMNIPDFNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct MPJLNIMFACE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GEGBIKICJAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[InternalBufferCapacity(0)]
public struct BAFGELEEODI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity KGPDHHGDIDC;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JBADPEHIOHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity DBEHKFODEEL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct GCODPDGJPAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct MJBBHADCEEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Entity DONMCNODAED;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct MGBBBGDHKKH : CIFJBMBLDLJ, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DCBMCJIAAJO HPBJMIAFNBO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(DCBMCJIAAJO);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BBGNEFALHKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 JBBMMGPDEIH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JLGNCPIJIKP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RegisterComponentDefault]
public struct LJFOENEHABM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3x3 FIGDPMEJCDO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LJFOENEHABM MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct HOCJGHEBHOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float3x3 FIGDPMEJCDO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly HOCJGHEBHOI MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct NKDPKDLOHHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 GNNEOAJKBHM;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct IHNHIKEFBJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 AJCLEGOPNAO;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RegisterComponentDefault]
public struct AJMNFAJIJPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float EIEHIEIECON;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly AJMNFAJIJPP MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[RegisterComponentDefault]
public struct GODDCLGKKEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float GOGOOMKLMHN;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GODDCLGKKEJ MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KAKDLINKGNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 BAKALIDCPJC;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct PAIFCKGMKAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public DCBINGCLJFB KNCGOCBINPC;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct BLBAIFNJAGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public DCBINGCLJFB EMPAEKAKCEG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[SingletonComponent]
public struct NLGANOBPCDL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Entity KPFAGKHHMMH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct NMMPCGPPNHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct IFKNNKNEODB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct NOKPDGKHIFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public RigidbodyConstraints AOGKGEKOLBE;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
public struct AFEGPINAJFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float PJDGNNPGGJH;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly AFEGPINAJFH MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct ANNHGNBADFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float PLJIBPHCHLF;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KIDJHCMBOHI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct BKHBBABDMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public object CEPBBDKEOKL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GameObject GBMEGJCINPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public object BNLOKBIMGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public object CGDOAAMEMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public BKHBBABDMKN CEPBBDKEOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Delegate PJAKMIJGNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Delegate JEPJPPEOAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public CMGBCFKNNNB<Delegate> PBEBFKOBHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public CMGBCFKNNNB<Delegate> NGBJDKANEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public CMGBCFKNNNB<Delegate> IGGJNHPBPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public CMGBCFKNNNB<Delegate> EHGAIJPFNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public CMGBCFKNNNB<Delegate> MDBJJIFKHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public CMGBCFKNNNB<Delegate> AJELFPLAEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public CMGBCFKNNNB<Delegate> HABEAAOGNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public CMGBCFKNNNB<Delegate> MAOALMIMNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public CMGBCFKNNNB<Delegate> EHPIPNEABHF;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7369490", Offset = "0x7368690", VA = "0x187369490", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public KIDJHCMBOHI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct EOACLLLPOOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HLCCLDICLGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int BDEHFOACKBD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1BC4DA0", Offset = "0x1BC3FA0", VA = "0x181BC4DA0")]
	public static HLCCLDICLGC KEDBNOKLEHE(int OMEFCJCOLII)
	{
		return default(HLCCLDICLGC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class ALAIICEADFL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Rigidbody MHCBGAAMHGE;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73676B0", Offset = "0x73668B0", VA = "0x1873676B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ALAIICEADFL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct FJIJMCOGDOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct IPHHPLGJLDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float3 HGECGPDEJMF;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct KIEPPACLMGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 BEIJOKHFPBB;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
public struct KBIOHKELCIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float BIADNHCEEAK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly KBIOHKELCIG MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MMGNLGAHMFG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public object IBBAFMJIFLM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73698C0", Offset = "0x7368AC0", VA = "0x1873698C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public MMGNLGAHMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FPNMOODKLHN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public object GNIMFFCHMOJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7368630", Offset = "0x7367830", VA = "0x187368630", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public FPNMOODKLHN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct OJEMHMFOHHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct FKAKJIKOKAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct GMLBCEEIFIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct LAHNAODGJBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct JLBDOGAKBCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DOGJNMGFAMH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct IHDCDGJDEOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public FixedString32Bytes LMOANCJLHKC;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[SingletonComponent]
public struct EFLFEDLKOGM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity PLMFADGOOMM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static EFLFEDLKOGM KEDBNOKLEHE(Entity OMEFCJCOLII)
	{
		return default(EFLFEDLKOGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal struct ACCEJAENIDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity KPFAGKHHMMH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static ACCEJAENIDG KEDBNOKLEHE(Entity KPFAGKHHMMH)
	{
		return default(ACCEJAENIDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct HNHBBDMCBAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity PEMHHCCAFOC;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct KEOCGMPBDAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity PEMHHCCAFOC;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct IJPNFEJDCBA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Entity EHIMPDDIJNI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xB3B5B0", Offset = "0xB3A7B0", VA = "0x180B3B5B0")]
	public static IJPNFEJDCBA KEDBNOKLEHE(Entity KPFAGKHHMMH)
	{
		return default(IJPNFEJDCBA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct JAJDDNPJNJF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct DBABDJKICHC : IBufferElementData, IEquatable<DBABDJKICHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Entity MACGDAGEMKH;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7367E90", Offset = "0x7367090", VA = "0x187367E90", Slot = "4")]
	public bool Equals(DBABDJKICHC JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7367E00", Offset = "0x7367000", VA = "0x187367E00", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct HDIKNDPKHLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public uint LNKNPHKNIOF;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[SingletonComponent]
internal struct PIDGGOOFFJE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Entity JABDKBNOIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public int CPLNODNGKGB;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct BMHHDDBMBHP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity KAAKBIHCNAB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct ICBFPMKONFH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NBLLKKOAKPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public uint GDGPBNJNCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int IFDLKEDMJIP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
	public NBLLKKOAKPO(uint LPLAJJPJCID, int BKDDEILBNNH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct EIMFFPHHNKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct LLNJLADNDPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct AILKOCBPEHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct LOEAKGEKGKP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct MDIAEDEFCMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct BBCMDEGMOHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct PBGNFPCKCMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GBGGBLGGMKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct FAJKLLPKFJD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct KDPPOLCMJFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct IPDLIBLJHGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HGABCDOGMMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct HOJBKFFKPKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct LOEJGDMIOIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct ACOAAHJPHOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MFCIPKKGMNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct EGPKNHKFFGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct MLHEPMBCCJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct MNLOEDHBJID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct FDPPJPPIMJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct KEGFODNKEHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OBJBNIKEIND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DDAEAOPGAEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct BENEJPBEPGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct CCBMPHBJMHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct DENNPMKIGIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct CLIKEKLPPNN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct PMEPHPALPIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct MLBDPMNCMNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct DACPDAHBOPJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[SingletonComponent]
public struct BDOPILFNNEP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public FixedString32Bytes ODABBBAHLHK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct JFNPILKPOAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct IBCBAKJMMCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal struct LBHJAAJOHDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct AFNIEAGJECE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal struct BHIEMEAPJHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct LEMPNFKKPIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct PAMBKBPBDBC : IComponentData, IComparable<PAMBKBPBDBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int PBIJCDCKADG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1EC0230", Offset = "0x1EBF430", VA = "0x181EC0230", Slot = "4")]
	public int CompareTo(PAMBKBPBDBC JAINJPLCLDO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct NFPIILFCDFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct PKDEKOJFBEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public quaternion EGIHDGHICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float3 FCKJMOMOHAE;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct CHGCKDBODGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float HGMLHMGDKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float DBLOAHFCAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float NPDANJADEGP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct GNLEKOOLGDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct OFMLPLENJKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct CAJPEKLNNCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct DKNBOAFMLML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int NIGKDAPIFGC;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[SingletonComponent]
public struct NBHCDFIKCBP : ISystemStateBufferElementData, IBufferElementData, EKAFPKEPBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity CFNJPDBBFFB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity HMEPBLPCNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RegisterComponentDefault]
public struct OKCBBGLGCME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float4x4 OFLJHGAMOIE;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly OKCBBGLGCME MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[RegisterComponentDefault]
public struct BJGOANIJDBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float4x4 HGDBCCODBIA;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly BJGOANIJDBA MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct ABMKOOADMMA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int EKKEOCJEOGK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CPLNODNGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73674D0", Offset = "0x73666D0", VA = "0x1873674D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x73674E0", Offset = "0x73666E0", VA = "0x1873674E0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[RegisterComponentDefault]
public struct KGFCGIGGDJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public float3 FCKJMOMOHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public quaternion EGIHDGHICMO;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly KGFCGIGGDJK MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class CIIAKCFNGIL
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[RegisterComponentDefault]
public struct ECNNDCBOHHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float GMNLKGAFBCI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly ECNNDCBOHHF MIAJNEPFAEF;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct EPACKNNNKOP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity GEDEGGCFAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public CJJHDAEBBAK BGJHPMCGJDB;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct ABBNMMBCLEN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public CJJHDAEBBAK BGJHPMCGJDB;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct JJNOJHHMPCM : ISystemStateComponentData, IComponentData, EKAFPKEPBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Entity EMDADMPPCND;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity HMEPBLPCNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct LEAEBCANPIO : ISystemStateBufferElementData, IBufferElementData, EKAFPKEPBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Entity CFDHMKPBPGB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity HMEPBLPCNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct PAEIAFFKCHB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity GEDEGGCFAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public CJJHDAEBBAK BGJHPMCGJDB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct ENCPDOIFLEI : IEqualityComparer<PAEIAFFKCHB>
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static ENCPDOIFLEI MIAJNEPFAEF;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7368180", Offset = "0x7367380", VA = "0x187368180", Slot = "4")]
	public bool Equals(PAEIAFFKCHB KIEMJAMMNPB, PAEIAFFKCHB IIOFLMMOEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73681D0", Offset = "0x73673D0", VA = "0x1873681D0", Slot = "5")]
	public int GetHashCode(PAEIAFFKCHB LCACGJDNDHA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct PACIEGODKGH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public FixedList32Bytes<int> FIHHAAIJGPL;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct LCCBMFGLLOF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public FixedList32Bytes<int> FIHHAAIJGPL;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct LAJCDCIFGDO : ISystemStateBufferElementData, IBufferElementData, EKAFPKEPBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity OJCOELHOOGP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity JHKIMHBGPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xBC28D0", Offset = "0xBC1AD0", VA = "0x180BC28D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1470350", Offset = "0x146F550", VA = "0x181470350", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class DCCNOCOJONG : ContainerPropertyBag<OAEJKMBPIFG>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class JJMKGHBMIFJ : Property<OAEJKMBPIFG, KMKOIABPNNL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x73690F0", Offset = "0x73682F0", VA = "0x1873690F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x73690B0", Offset = "0x73682B0", VA = "0x1873690B0")]
		public JJMKGHBMIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7368410", Offset = "0x7367610", VA = "0x187368410", Slot = "14")]
		public override KMKOIABPNNL GetValue(OAEJKMBPIFG CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7368430", Offset = "0x7367630", VA = "0x187368430", Slot = "15")]
		public override void SetValue(OAEJKMBPIFG CKNPDKKKGFM, KMKOIABPNNL OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7367EA0", Offset = "0x73670A0", VA = "0x187367EA0")]
	public DCCNOCOJONG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class INJMGJAAFBN : ContainerPropertyBag<KIDJHCMBOHI>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class LMLHIKMLMKK : Property<KIDJHCMBOHI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7369670", Offset = "0x7368870", VA = "0x187369670", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7369630", Offset = "0x7368830", VA = "0x187369630")]
		public LMLHIKMLMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7368410", Offset = "0x7367610", VA = "0x187368410", Slot = "14")]
		public override GameObject GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7368430", Offset = "0x7367630", VA = "0x187368430", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, GameObject OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class HBHMMLDKLFE : Property<KIDJHCMBOHI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7368860", Offset = "0x7367A60", VA = "0x187368860", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7368820", Offset = "0x7367A20", VA = "0x187368820")]
		public HBHMMLDKLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x73687D0", Offset = "0x73679D0", VA = "0x1873687D0", Slot = "14")]
		public override object GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x73687F0", Offset = "0x73679F0", VA = "0x1873687F0", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, object OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class JHLNPMLGINN : Property<KIDJHCMBOHI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7369080", Offset = "0x7368280", VA = "0x187369080", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7369040", Offset = "0x7368240", VA = "0x187369040")]
		public JHLNPMLGINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7368FF0", Offset = "0x73681F0", VA = "0x187368FF0", Slot = "14")]
		public override object GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7369010", Offset = "0x7368210", VA = "0x187369010", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, object OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class JLPIPNKPPEC : Property<KIDJHCMBOHI, KIDJHCMBOHI.BKHBBABDMKN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x73691B0", Offset = "0x73683B0", VA = "0x1873691B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7369170", Offset = "0x7368370", VA = "0x187369170")]
		public JLPIPNKPPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7369120", Offset = "0x7368320", VA = "0x187369120", Slot = "14")]
		public override KIDJHCMBOHI.BKHBBABDMKN GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(KIDJHCMBOHI.BKHBBABDMKN);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7369140", Offset = "0x7368340", VA = "0x187369140", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, KIDJHCMBOHI.BKHBBABDMKN OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class EELJFGCBMOB : Property<KIDJHCMBOHI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7368070", Offset = "0x7367270", VA = "0x187368070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7368030", Offset = "0x7367230", VA = "0x187368030")]
		public EELJFGCBMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7367FE0", Offset = "0x73671E0", VA = "0x187367FE0", Slot = "14")]
		public override Delegate GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7368000", Offset = "0x7367200", VA = "0x187368000", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, Delegate OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class MHDIINGKJHG : Property<KIDJHCMBOHI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7369890", Offset = "0x7368A90", VA = "0x187369890", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7369850", Offset = "0x7368A50", VA = "0x187369850")]
		public MHDIINGKJHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7369800", Offset = "0x7368A00", VA = "0x187369800", Slot = "14")]
		public override Delegate GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7369820", Offset = "0x7368A20", VA = "0x187369820", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, Delegate OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class FMDFJACJEJD : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7368600", Offset = "0x7367800", VA = "0x187368600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73685C0", Offset = "0x73677C0", VA = "0x1873685C0")]
		public FMDFJACJEJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7368550", Offset = "0x7367750", VA = "0x187368550", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7368580", Offset = "0x7367780", VA = "0x187368580", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class OHMCCNMNJKL : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7369B80", Offset = "0x7368D80", VA = "0x187369B80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7369B40", Offset = "0x7368D40", VA = "0x187369B40")]
		public OHMCCNMNJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7369AD0", Offset = "0x7368CD0", VA = "0x187369AD0", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7369B00", Offset = "0x7368D00", VA = "0x187369B00", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class BDKDHNIDLFM : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7367870", Offset = "0x7366A70", VA = "0x187367870", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7367830", Offset = "0x7366A30", VA = "0x187367830")]
		public BDKDHNIDLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x73677C0", Offset = "0x73669C0", VA = "0x1873677C0", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x73677F0", Offset = "0x73669F0", VA = "0x1873677F0", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class FDJPAHMAIMD : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x73683E0", Offset = "0x73675E0", VA = "0x1873683E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x73683A0", Offset = "0x73675A0", VA = "0x1873683A0")]
		public FDJPAHMAIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7368320", Offset = "0x7367520", VA = "0x187368320", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7368360", Offset = "0x7367560", VA = "0x187368360", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class GJBINAMEDHA : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7368760", Offset = "0x7367960", VA = "0x187368760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7368720", Offset = "0x7367920", VA = "0x187368720")]
		public GJBINAMEDHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73686A0", Offset = "0x73678A0", VA = "0x1873686A0", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x73686E0", Offset = "0x73678E0", VA = "0x1873686E0", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class CBLCCBEIJEO : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7367DD0", Offset = "0x7366FD0", VA = "0x187367DD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7367D90", Offset = "0x7366F90", VA = "0x187367D90")]
		public CBLCCBEIJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7367D10", Offset = "0x7366F10", VA = "0x187367D10", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7367D50", Offset = "0x7366F50", VA = "0x187367D50", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class FCMAHAEPMJH : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x73682F0", Offset = "0x73674F0", VA = "0x1873682F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73682B0", Offset = "0x73674B0", VA = "0x1873682B0")]
		public FCMAHAEPMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7368230", Offset = "0x7367430", VA = "0x187368230", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7368270", Offset = "0x7367470", VA = "0x187368270", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class MPNGLLDJJDA : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x73699F0", Offset = "0x7368BF0", VA = "0x1873699F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x73699B0", Offset = "0x7368BB0", VA = "0x1873699B0")]
		public MPNGLLDJJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7369930", Offset = "0x7368B30", VA = "0x187369930", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7369970", Offset = "0x7368B70", VA = "0x187369970", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	private class MAFCJDBKJPL : Property<KIDJHCMBOHI, CMGBCFKNNNB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7369760", Offset = "0x7368960", VA = "0x187369760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7369720", Offset = "0x7368920", VA = "0x187369720")]
		public MAFCJDBKJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x73696A0", Offset = "0x73688A0", VA = "0x1873696A0", Slot = "14")]
		public override CMGBCFKNNNB<Delegate> GetValue(KIDJHCMBOHI CKNPDKKKGFM)
		{
			return default(CMGBCFKNNNB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x73696E0", Offset = "0x73688E0", VA = "0x1873696E0", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI CKNPDKKKGFM, CMGBCFKNNNB<Delegate> OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7368990", Offset = "0x7367B90", VA = "0x187368990")]
	public INJMGJAAFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class KCHNDIPOANN : ContainerPropertyBag<KIDJHCMBOHI.BKHBBABDMKN>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class PKFGFBLJMJN : Property<KIDJHCMBOHI.BKHBBABDMKN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7369F50", Offset = "0x7369150", VA = "0x187369F50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7369F10", Offset = "0x7369110", VA = "0x187369F10")]
		public PKFGFBLJMJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xCF9140", Offset = "0xCF8340", VA = "0x180CF9140", Slot = "14")]
		public override object GetValue(KIDJHCMBOHI.BKHBBABDMKN CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4F797B0", Offset = "0x4F789B0", VA = "0x184F797B0", Slot = "15")]
		public override void SetValue(KIDJHCMBOHI.BKHBBABDMKN CKNPDKKKGFM, object OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7369220", Offset = "0x7368420", VA = "0x187369220")]
	public KCHNDIPOANN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class AIOBMKJOJAG : ContainerPropertyBag<CMGBCFKNNNB<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7367610", Offset = "0x7366810", VA = "0x187367610")]
	public AIOBMKJOJAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class BPIAICJAOND : ContainerPropertyBag<ALAIICEADFL>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class MCJBAPPLCJE : Property<ALAIICEADFL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x73697D0", Offset = "0x73689D0", VA = "0x1873697D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7369790", Offset = "0x7368990", VA = "0x187369790")]
		public MCJBAPPLCJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7368410", Offset = "0x7367610", VA = "0x187368410", Slot = "14")]
		public override Rigidbody GetValue(ALAIICEADFL CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7368430", Offset = "0x7367630", VA = "0x187368430", Slot = "15")]
		public override void SetValue(ALAIICEADFL CKNPDKKKGFM, Rigidbody OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7367950", Offset = "0x7366B50", VA = "0x187367950")]
	public BPIAICJAOND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class AGGGMBGJNFM : ContainerPropertyBag<MMGNLGAHMFG>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class OINLCKBPNML : Property<MMGNLGAHMFG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7369BF0", Offset = "0x7368DF0", VA = "0x187369BF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7369BB0", Offset = "0x7368DB0", VA = "0x187369BB0")]
		public OINLCKBPNML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7368410", Offset = "0x7367610", VA = "0x187368410", Slot = "14")]
		public override object GetValue(MMGNLGAHMFG CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7368430", Offset = "0x7367630", VA = "0x187368430", Slot = "15")]
		public override void SetValue(MMGNLGAHMFG CKNPDKKKGFM, object OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7367530", Offset = "0x7366730", VA = "0x187367530")]
	public AGGGMBGJNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class EIFNNHIJNJD : ContainerPropertyBag<FPNMOODKLHN>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class FIDLANDCNBO : Property<FPNMOODKLHN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string PCMLNMEPCBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x73684A0", Offset = "0x73676A0", VA = "0x1873684A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool NPIFBDLIKBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7368460", Offset = "0x7367660", VA = "0x187368460")]
		public FIDLANDCNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7368410", Offset = "0x7367610", VA = "0x187368410", Slot = "14")]
		public override object GetValue(FPNMOODKLHN CKNPDKKKGFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7368430", Offset = "0x7367630", VA = "0x187368430", Slot = "15")]
		public override void SetValue(FPNMOODKLHN CKNPDKKKGFM, object OMEFCJCOLII)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73680A0", Offset = "0x73672A0", VA = "0x1873680A0")]
	public EIFNNHIJNJD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7369F80", Offset = "0x7369180", VA = "0x187369F80")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class ODLABCMJMIE
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ODLABCMJMIE()
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

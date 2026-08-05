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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x708CB70", Offset = "0x708B370", VA = "0x18708CB70", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x708CF70", Offset = "0x708B770", VA = "0x18708CF70", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KMNIDJDKGGK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, ABOECODEINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7089E80", Offset = "0x7088680", VA = "0x187089E80", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, ABOECODEINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KEEDKKOLIOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HNCGMFPFMOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity KCHKCGGIPFO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KENOGMDKMGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity KCHKCGGIPFO;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KMCDGIIKEAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<CGDKBMPDDED> GMDHIEFOGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> MPDGECOCKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle HGLLPADGGCE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BJEHFDDNHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x708B970", Offset = "0x708A170", VA = "0x18708B970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x708B9E0", Offset = "0x708A1E0", VA = "0x18708B9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51A1EC0", Offset = "0x51A06C0", VA = "0x1851A1EC0")]
	public KMCDGIIKEAC(NativeList<CGDKBMPDDED> GMDHIEFOGKJ, NativeList<Entity> MPDGECOCKKB, JobHandle HGLLPADGGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x708B850", Offset = "0x708A050", VA = "0x18708B850")]
	public (Entity, NativeSlice<Entity>) FBBFKEBDANH(int KKPBEBNOEKN)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x708B7F0", Offset = "0x7089FF0", VA = "0x18708B7F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CGDKBMPDDED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity KAMAKIBPPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int MHPJBPKHONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int OANKAJFHCKB;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BAJINNPGNMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEAGIIKBHJP(bool JHPKLHINPOM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct ACHFDAAAJAJ : IEquatable<ACHFDAAAJAJ>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool MMBKOKDMHNI(int LGAFEOMEGIH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool FEOOOCAPFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool AEMGBBBELDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool GEDBCHBLPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool GAGJLMBFAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MMBKOKDMHNI JNPGMDLOJBG;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7089CD0", Offset = "0x70884D0", VA = "0x187089CD0")]
	public ACHFDAAAJAJ(IBNNJJAFPLG NHJAJPHALPB, MMBKOKDMHNI JNPGMDLOJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7089D10", Offset = "0x7088510", VA = "0x187089D10")]
	public ACHFDAAAJAJ(bool FEOOOCAPFHE, bool AEMGBBBELDA, bool GEDBCHBLPGA, bool GAGJLMBFAFD, MMBKOKDMHNI JNPGMDLOJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7089CA0", Offset = "0x70884A0", VA = "0x187089CA0")]
	public bool OLEHGBPCCNK(int LGAFEOMEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7089BD0", Offset = "0x70883D0", VA = "0x187089BD0")]
	public bool GAGLNDBIBIJ(int LGAFEOMEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7089A90", Offset = "0x7088290", VA = "0x187089A90")]
	public bool BLODJLNFKDC(int LGAFEOMEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7089AC0", Offset = "0x70882C0", VA = "0x187089AC0")]
	public bool EHFMFEEGPAM(int LGAFEOMEGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7089AF0", Offset = "0x70882F0", VA = "0x187089AF0", Slot = "4")]
	public bool Equals(ACHFDAAAJAJ LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7089B20", Offset = "0x7088320", VA = "0x187089B20", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7089C00", Offset = "0x7088400", VA = "0x187089C00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7089A70", Offset = "0x7088270", VA = "0x187089A70")]
	private bool ALADLKJPKOG(int LGAFEOMEGIH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KLFLHFGBGGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HGEDCGOPABK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HKPJAENEDKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct LNKDFMDNDBH : IBufferElementData, IEquatable<LNKDFMDNDBH>, ABOECODEINN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity IDCFOEBAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int GBLAELHDBMF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity BNJPOLHFIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x708BC90", Offset = "0x708A490", VA = "0x18708BC90", Slot = "4")]
	public bool Equals(LNKDFMDNDBH LIHCAHPMPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ELGMOLAMCJO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public DOGDACMPKBI CKKNJFDGPPK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x708A830", Offset = "0x7089030", VA = "0x18708A830", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public ELGMOLAMCJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface DOGDACMPKBI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FDKJBLBIGNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct CMDOPBGICKN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct MOGFBHIDJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly CCNLCOEEOJN LFMNCGIDJME;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x291E050", Offset = "0x291C850", VA = "0x18291E050")]
		public MOGFBHIDJNO(CCNLCOEEOJN HJCEIAENEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x708BF30", Offset = "0x708A730", VA = "0x18708BF30")]
		public bool DFACEAGNFBB(CMDOPBGICKN DAPAONJILOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x708BF40", Offset = "0x708A740", VA = "0x18708BF40")]
		public bool EOEOALHNKOK(CMDOPBGICKN DAPAONJILOO, CCNLCOEEOJN OIIJLFFECLA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly CCNLCOEEOJN EAAMBBHLFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x291E050", Offset = "0x291C850", VA = "0x18291E050")]
	public CMDOPBGICKN(CCNLCOEEOJN EAAMBBHLFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x708A450", Offset = "0x7088C50", VA = "0x18708A450")]
	public CMDOPBGICKN DCMJGJNLGEM(CCNLCOEEOJN GKHKCJLALAK)
	{
		return default(CMDOPBGICKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x708A440", Offset = "0x7088C40", VA = "0x18708A440")]
	public CMDOPBGICKN DCCBCOGFEEA(CCNLCOEEOJN CENDCNFGOGA)
	{
		return default(CMDOPBGICKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x708A460", Offset = "0x7088C60", VA = "0x18708A460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum CCNLCOEEOJN : ushort
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
public enum CFMEJGJGEHE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[SingletonComponent]
public struct MKBNIGAODHD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public CFMEJGJGEHE EAAMBBHLFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool IJNKNAGELAM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HNCKGHJMPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x708BE10", Offset = "0x708A610", VA = "0x18708BE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x708BE20", Offset = "0x708A620", VA = "0x18708BE20")]
	private MKBNIGAODHD(CFMEJGJGEHE EAAMBBHLFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x708BDF0", Offset = "0x708A5F0", VA = "0x18708BDF0")]
	public MKBNIGAODHD DCMJGJNLGEM(CFMEJGJGEHE GKHKCJLALAK)
	{
		return default(MKBNIGAODHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x708BDD0", Offset = "0x708A5D0", VA = "0x18708BDD0")]
	public MKBNIGAODHD DCCBCOGFEEA(CFMEJGJGEHE CENDCNFGOGA)
	{
		return default(MKBNIGAODHD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DNEPAMJJLNB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct APNNCGINBGF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity LFNAOODHHBF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, ABOECODEINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7089E80", Offset = "0x7088680", VA = "0x187089E80", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[SingletonComponent]
public struct CADGGAJGOAL : ISystemStateBufferElementData, IBufferElementData, ABOECODEINN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity DPHKAEKJOIN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity MEGDLLJFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LIBHKEALOOF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity MKGAKFHMCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity HJHBDNCHCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity GHMGPALFCBL;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct DMLMPLKFBMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Guid PLMJELCKKDA;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct MGIMAJLMHAM<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool LNCHMIOPEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint MMEHCNPHGFO;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	private static bool IBGGGFPEFCD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[TypeManager.TypeVersion(2)]
public struct MMBFAENFGJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public uint AJAJHFMPOHN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x708BEA0", Offset = "0x708A6A0", VA = "0x18708BEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct DOGADMIDLOB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SingletonComponent]
public struct LCFBEANILJJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int DFHLAEINNIE;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BJJNBPMBDKI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int NEHJMKFJILC;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FOLOBDEIGJB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GCHandle PDGJCLOOGJP;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct KKEPIMEFJGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int NEHJMKFJILC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OLICDJJBHHA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct KLDKAELBJDN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int NEHJMKFJILC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EINHDBIIECO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct EFNNMILHKCO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BCDNIFCBHBI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct KEPFHIPBOEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public CollisionDetectionMode JEFBMJDDAGA;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RegisterComponentDefault]
public struct ADPFMLDEHHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public HNNBIECDFEH BBCFHCAFGBM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly ADPFMLDEHHH KFAGBODOJLH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ALBPDKBEDGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JMOKMPJOIIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LBDBLKAEJFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[InternalBufferCapacity(0)]
public struct ONFEBCGMKCF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity IDCFOEBAIPD;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct HKOEOGNDNAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity NCCLECGLDAO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IACNBMKALEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EEFEFOEALBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Entity KAMAKIBPPKG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FFDMJGCDOAB : GMKMNIIHDAE, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CCDACHFALGH EOBIPHHMBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(CCDACHFALGH);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LMEBJCPNBGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 HEHDOAGPNLF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JJJDAFCBEFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RegisterComponentDefault]
public struct AIBLNMMMJMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3x3 OEHAFFDNIEG;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly AIBLNMMMJMC KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct DIBNEINBGDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float3x3 OEHAFFDNIEG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly DIBNEINBGDB KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct JLEMAPABCAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 DMACIFANPCC;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct KKMDAMKJNEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 JGILHAPICOA;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RegisterComponentDefault]
public struct OJBEMBMICMP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float FHJGJMPJJFA;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly OJBEMBMICMP KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[RegisterComponentDefault]
public struct CPINEONBHDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float FBJKNDPHEDA;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly CPINEONBHDJ KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct MDJGEIAMEDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 IFKGFAGLFCM;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct DCGDCGMDIEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NEDCKNNIBBL FHHJIDAFGDE;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct MFAOAJNMJKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NEDCKNNIBBL GAPBBPEJIHK;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[SingletonComponent]
public struct BFLGCIHKLJM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Entity DPHKAEKJOIN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct AKGDMDPFCND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct JJPOCHCJCEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct CANHECADCOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public RigidbodyConstraints LFOBAMAPEEO;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
public struct NFFICJLDPDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float GEIDIHCKBLF;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly NFFICJLDPDB KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct MGNFPDCCIHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float IFDDAPCJLNL;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class CNIPNDAJGFI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct BADAIHEHHNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public object BKKJPNGFNIJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GameObject PBJIFBOBIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public object MBOAOJPOLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public object MJCKDMNJHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public BADAIHEHHNP BKKJPNGFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Delegate ENIINHOLNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Delegate EKABAPAHNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public FAHGBPLMFAB<Delegate> HIJIJOEMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public FAHGBPLMFAB<Delegate> GPFOCBGEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public FAHGBPLMFAB<Delegate> NOLJPGONPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public FAHGBPLMFAB<Delegate> EJALENCCMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public FAHGBPLMFAB<Delegate> DLAFLFFHNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public FAHGBPLMFAB<Delegate> GNOMCFJJDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FAHGBPLMFAB<Delegate> HHACEEFPAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public FAHGBPLMFAB<Delegate> EMNFPNDCKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public FAHGBPLMFAB<Delegate> BBPLMKNADHB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x708A4C0", Offset = "0x7088CC0", VA = "0x18708A4C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CNIPNDAJGFI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct FNHJNEDGGJF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct GNBJGAMJGMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int FOMFIFJDKID;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x181D930", Offset = "0x181C130", VA = "0x18181D930")]
	public static GNBJGAMJGMG FMEIMHFCNHG(int INDENPJBLHO)
	{
		return default(GNBJGAMJGMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BKJLMKNKEAJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Rigidbody PFJJBBEKFJA;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x708A1E0", Offset = "0x70889E0", VA = "0x18708A1E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public BKJLMKNKEAJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HBFBBOLLNLE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct CDPJAEPJBDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float3 NAILJECMJDD;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HLBJAIACKCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 KAHKKJLHEEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
public struct CBODBGDKMIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float HFILCMMNBNC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CBODBGDKMIF KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ILJLHOHDBKA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public object CIPDDKBJFMI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x708B2E0", Offset = "0x7089AE0", VA = "0x18708B2E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public ILJLHOHDBKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class CEJNCGPNCMO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public object LNEGFHDGJFL;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x708A3D0", Offset = "0x7088BD0", VA = "0x18708A3D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CEJNCGPNCMO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HJKNJMEEFOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct MIJIMAOKFEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct JAPIIGADLEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct FIMGCIHABMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct LLHNLGKBFDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct HKFCIBCODPF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct LKDEKBFKMDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public FixedString32Bytes IKMKCMDHFDC;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[SingletonComponent]
public struct EOCAACFOFIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity CMJNKCJNAGB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static EOCAACFOFIK FMEIMHFCNHG(Entity INDENPJBLHO)
	{
		return default(EOCAACFOFIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal struct AIIKLOAHHPG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity DPHKAEKJOIN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static AIIKLOAHHPG FMEIMHFCNHG(Entity DPHKAEKJOIN)
	{
		return default(AIIKLOAHHPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct BECCBMIEPDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity GFPFLIAFJNG;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct HKJFOGFGFBL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity GFPFLIAFJNG;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct CNJIKIBIEFE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Entity OIJHBBJICNA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0")]
	public static CNJIKIBIEFE FMEIMHFCNHG(Entity DPHKAEKJOIN)
	{
		return default(CNJIKIBIEFE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct FPLJABCHGKH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct BDACGIIDEHO : IBufferElementData, IEquatable<BDACGIIDEHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Entity FEDPMJDNJMC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7089F70", Offset = "0x7088770", VA = "0x187089F70", Slot = "4")]
	public bool Equals(BDACGIIDEHO LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7089F80", Offset = "0x7088780", VA = "0x187089F80", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct LMADAPGEPBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public uint MAAOIFPNGGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[SingletonComponent]
internal struct BLFNNCFBFAC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Entity NHHDDOHIEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public int ECDOOAABOPD;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct EMHKLAHFHJB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity GBFAPJDBEMN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct HDCOKHOCKKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct EOGEKGKKNJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public uint MMEHCNPHGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int OOKAGFFDFJB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x95D280", Offset = "0x95BA80", VA = "0x18095D280")]
	public EOGEKGKKNJK(uint GHAHMEAIGKN, int MINKGFEOJAD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FIEFLLMDKGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GBFBNHPAPMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct CAKJKNBDHDG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct LKHNGNLNDAL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct EOMLGHHPIND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct PMKDEHNMDPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct OPCFINEMABK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LHHHAMIGDGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct BDLPJHOMDOO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct KGMGIJFBAPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FIOPHGPPGOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct AOKKCBDCDNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct HBIFHKHBHNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct KAGDLENACIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct FMPONDNKMLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct JMFIAKNJMEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct IBPNIMAOMHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct CNFMHNEILPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct PCPEPEEEEBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct NDLIMLMANOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct AIHPGCCJOEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct ENOMHHMLPCB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct AFNIPLJNEHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct HLLMGLGHCBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct FKKCBOHJOMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct PHMBGNPPCLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct ADODAKKICNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FADAMAPLFLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct LJNLNNFAFNO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[SingletonComponent]
public struct BFMGPDLIKLG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public FixedString32Bytes LJMDFKCKKHM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct OHDPFHLADOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct HMMDLOKFPCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal struct CJAPDMJDENB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal struct MGAHCJDGJPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct GFPNJJDJEMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct DPCOAMMHMOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct OKEPNIHPPAJ : IComponentData, IComparable<OKEPNIHPPAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int DDMHBFJKHLK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1B25130", Offset = "0x1B23930", VA = "0x181B25130", Slot = "4")]
	public int CompareTo(OKEPNIHPPAJ LIHCAHPMPHD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct PLJPLCPJGOF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct CPDAIOKPEAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public quaternion OJEGGOKKPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float3 BALIIBCILHH;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct CDBKNHGFILH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float MEFBJEMMLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float LGHFBFGHAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float KLFIBFMJEPF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct PFBIGOHNMJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct PEPNBPCGHAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct KIMLKHENOBK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct FOILJKDDANM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int NEHJMKFJILC;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[SingletonComponent]
public struct JLCMOEMJPEA : ISystemStateBufferElementData, IBufferElementData, ABOECODEINN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity DAJIEEBMGGN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity MEGDLLJFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RegisterComponentDefault]
public struct JGHGKPMOMKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float4x4 IHLAHCEBMED;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly JGHGKPMOMKH KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RegisterComponentDefault]
public struct PCHLPFKDAFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float4x4 KBJBMNDHNHM;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly PCHLPFKDAFJ KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct PAKKCAGLJII : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int AJKGEMGFIAH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ECDOOAABOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x708C2E0", Offset = "0x708AAE0", VA = "0x18708C2E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x708C2F0", Offset = "0x708AAF0", VA = "0x18708C2F0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[RegisterComponentDefault]
public struct CCELCAEFDEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public float3 OCPPOONHMAK;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly CCELCAEFDEP KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[RegisterComponentDefault]
public struct JMHEFFBKAPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float3 BALIIBCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public quaternion OJEGGOKKPLF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly JMHEFFBKAPH KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class BEBGLEHCNFE
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[RegisterComponentDefault]
public struct EHHBHACKAFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float GMEBIGADCFE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly EHHBHACKAFL KFAGBODOJLH;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct PKINPJLAMJA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Entity PMGFPJDBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public JBOELMKONKK NNGPPKEHFMP;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct IFBCDJJAJGI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public JBOELMKONKK NNGPPKEHFMP;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct ILPLMPPNCPE : ISystemStateComponentData, IComponentData, ABOECODEINN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity AFJCLAOHICF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity MEGDLLJFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct FOKMBIBFHGB : ISystemStateBufferElementData, IBufferElementData, ABOECODEINN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity HDBAHGBOBCH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity MEGDLLJFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct ECKDCPFBFCL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity PMGFPJDBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public JBOELMKONKK NNGPPKEHFMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct FNPCMNCPIFN : IEqualityComparer<ECKDCPFBFCL>
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static FNPCMNCPIFN KFAGBODOJLH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x708B140", Offset = "0x7089940", VA = "0x18708B140", Slot = "4")]
	public bool Equals(ECKDCPFBFCL KHINBLFKKED, ECKDCPFBFCL NCCBPIFKDGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x708B190", Offset = "0x7089990", VA = "0x18708B190", Slot = "5")]
	public int GetHashCode(ECKDCPFBFCL INCBEIDOHDO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct IBEBGJAAPLO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public FixedList32Bytes<int> LJIMCKDEHJA;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct NLCJDIBJHBE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public FixedList32Bytes<int> LJIMCKDEHJA;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct EKIBBAMCOPG : ISystemStateBufferElementData, IBufferElementData, ABOECODEINN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity CHCHAFOOMHD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity BNJPOLHFIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x95E870", Offset = "0x95D070", VA = "0x18095E870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1201780", Offset = "0x11FFF80", VA = "0x181201780", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class FCKDMOOHHMA : ContainerPropertyBag<ELGMOLAMCJO>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class NHFAJEKIEJK : Property<ELGMOLAMCJO, DOGDACMPKBI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x708C200", Offset = "0x708AA00", VA = "0x18708C200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x708C1C0", Offset = "0x708A9C0", VA = "0x18708C1C0")]
		public NHFAJEKIEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x708A250", Offset = "0x7088A50", VA = "0x18708A250", Slot = "14")]
		public override DOGDACMPKBI GetValue(ELGMOLAMCJO MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x708A270", Offset = "0x7088A70", VA = "0x18708A270", Slot = "15")]
		public override void SetValue(ELGMOLAMCJO MFHCHOKEAIG, DOGDACMPKBI INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x708A8A0", Offset = "0x70890A0", VA = "0x18708A8A0")]
	public FCKDMOOHHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class FKCKPDHFBFK : ContainerPropertyBag<CNIPNDAJGFI>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class BPDEFKKBMEF : Property<CNIPNDAJGFI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x708A2E0", Offset = "0x7088AE0", VA = "0x18708A2E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x708A2A0", Offset = "0x7088AA0", VA = "0x18708A2A0")]
		public BPDEFKKBMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x708A250", Offset = "0x7088A50", VA = "0x18708A250", Slot = "14")]
		public override GameObject GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x708A270", Offset = "0x7088A70", VA = "0x18708A270", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, GameObject INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class LDHBCBMHPNL : Property<CNIPNDAJGFI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x708BAC0", Offset = "0x708A2C0", VA = "0x18708BAC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x708BA80", Offset = "0x708A280", VA = "0x18708BA80")]
		public LDHBCBMHPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x708BA30", Offset = "0x708A230", VA = "0x18708BA30", Slot = "14")]
		public override object GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x708BA50", Offset = "0x708A250", VA = "0x18708BA50", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, object INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class DPPBPALGOBH : Property<CNIPNDAJGFI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x708A7C0", Offset = "0x7088FC0", VA = "0x18708A7C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x708A780", Offset = "0x7088F80", VA = "0x18708A780")]
		public DPPBPALGOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x708A730", Offset = "0x7088F30", VA = "0x18708A730", Slot = "14")]
		public override object GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x708A750", Offset = "0x7088F50", VA = "0x18708A750", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, object INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class PMHHCKFGFEO : Property<CNIPNDAJGFI, CNIPNDAJGFI.BADAIHEHHNP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x708C560", Offset = "0x708AD60", VA = "0x18708C560", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x708C520", Offset = "0x708AD20", VA = "0x18708C520")]
		public PMHHCKFGFEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x708C4D0", Offset = "0x708ACD0", VA = "0x18708C4D0", Slot = "14")]
		public override CNIPNDAJGFI.BADAIHEHHNP GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(CNIPNDAJGFI.BADAIHEHHNP);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x708C4F0", Offset = "0x708ACF0", VA = "0x18708C4F0", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, CNIPNDAJGFI.BADAIHEHHNP INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class LICGIIAOOEP : Property<CNIPNDAJGFI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x708BC60", Offset = "0x708A460", VA = "0x18708BC60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x708BC20", Offset = "0x708A420", VA = "0x18708BC20")]
		public LICGIIAOOEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x708BBD0", Offset = "0x708A3D0", VA = "0x18708BBD0", Slot = "14")]
		public override Delegate GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x708BBF0", Offset = "0x708A3F0", VA = "0x18708BBF0", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, Delegate INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class PGMODDPBAPN : Property<CNIPNDAJGFI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x708C4A0", Offset = "0x708ACA0", VA = "0x18708C4A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x708C460", Offset = "0x708AC60", VA = "0x18708C460")]
		public PGMODDPBAPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x708C410", Offset = "0x708AC10", VA = "0x18708C410", Slot = "14")]
		public override Delegate GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x708C430", Offset = "0x708AC30", VA = "0x18708C430", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, Delegate INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class BGNMMBHJANA : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x708A0C0", Offset = "0x70888C0", VA = "0x18708A0C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x708A080", Offset = "0x7088880", VA = "0x18708A080")]
		public BGNMMBHJANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x708A010", Offset = "0x7088810", VA = "0x18708A010", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x708A040", Offset = "0x7088840", VA = "0x18708A040", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class JNOOLMFKDDO : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x708B7C0", Offset = "0x7089FC0", VA = "0x18708B7C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x708B780", Offset = "0x7089F80", VA = "0x18708B780")]
		public JNOOLMFKDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x708B710", Offset = "0x7089F10", VA = "0x18708B710", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x708B740", Offset = "0x7089F40", VA = "0x18708B740", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class NAKKFMLDAON : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x708C000", Offset = "0x708A800", VA = "0x18708C000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x708BFC0", Offset = "0x708A7C0", VA = "0x18708BFC0")]
		public NAKKFMLDAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x708BF50", Offset = "0x708A750", VA = "0x18708BF50", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x708BF80", Offset = "0x708A780", VA = "0x18708BF80", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class MBKBGNEMFDD : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x708BDA0", Offset = "0x708A5A0", VA = "0x18708BDA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x708BD60", Offset = "0x708A560", VA = "0x18708BD60")]
		public MBKBGNEMFDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x708BCE0", Offset = "0x708A4E0", VA = "0x18708BCE0", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x708BD20", Offset = "0x708A520", VA = "0x18708BD20", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class HOECBFBLAGC : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x708B2B0", Offset = "0x7089AB0", VA = "0x18708B2B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x708B270", Offset = "0x7089A70", VA = "0x18708B270")]
		public HOECBFBLAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x708B1F0", Offset = "0x70899F0", VA = "0x18708B1F0", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x708B230", Offset = "0x7089A30", VA = "0x18708B230", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class FKKNAJLMDPF : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x708B110", Offset = "0x7089910", VA = "0x18708B110", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x708B0D0", Offset = "0x70898D0", VA = "0x18708B0D0")]
		public FKKNAJLMDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x708B050", Offset = "0x7089850", VA = "0x18708B050", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x708B090", Offset = "0x7089890", VA = "0x18708B090", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class JKBLGGDIABJ : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x708B5B0", Offset = "0x7089DB0", VA = "0x18708B5B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x708B570", Offset = "0x7089D70", VA = "0x18708B570")]
		public JKBLGGDIABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x708B4F0", Offset = "0x7089CF0", VA = "0x18708B4F0", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x708B530", Offset = "0x7089D30", VA = "0x18708B530", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class JEKMANBHPEG : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x708B410", Offset = "0x7089C10", VA = "0x18708B410", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x708B3D0", Offset = "0x7089BD0", VA = "0x18708B3D0")]
		public JEKMANBHPEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x708B350", Offset = "0x7089B50", VA = "0x18708B350", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x708B390", Offset = "0x7089B90", VA = "0x18708B390", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	private class BKALBIHANKI : Property<CNIPNDAJGFI, FAHGBPLMFAB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x708A1B0", Offset = "0x70889B0", VA = "0x18708A1B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x708A170", Offset = "0x7088970", VA = "0x18708A170")]
		public BKALBIHANKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x708A0F0", Offset = "0x70888F0", VA = "0x18708A0F0", Slot = "14")]
		public override FAHGBPLMFAB<Delegate> GetValue(CNIPNDAJGFI MFHCHOKEAIG)
		{
			return default(FAHGBPLMFAB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x708A130", Offset = "0x7088930", VA = "0x18708A130", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI MFHCHOKEAIG, FAHGBPLMFAB<Delegate> INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x708A9F0", Offset = "0x70891F0", VA = "0x18708A9F0")]
	public FKCKPDHFBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class NAKPDNDKBGB : ContainerPropertyBag<CNIPNDAJGFI.BADAIHEHHNP>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class PAEDMEHHBPJ : Property<CNIPNDAJGFI.BADAIHEHHNP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x708C2B0", Offset = "0x708AAB0", VA = "0x18708C2B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x708C270", Offset = "0x708AA70", VA = "0x18708C270")]
		public PAEDMEHHBPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA96610", Offset = "0xA94E10", VA = "0x180A96610", Slot = "14")]
		public override object GetValue(CNIPNDAJGFI.BADAIHEHHNP MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7FF0", Offset = "0x4CA67F0", VA = "0x184CA7FF0", Slot = "15")]
		public override void SetValue(CNIPNDAJGFI.BADAIHEHHNP MFHCHOKEAIG, object INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x708C030", Offset = "0x708A830", VA = "0x18708C030")]
	public NAKPDNDKBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class PDHJOOIPOMF : ContainerPropertyBag<FAHGBPLMFAB<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x708C3B0", Offset = "0x708ABB0", VA = "0x18708C3B0")]
	public PDHJOOIPOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class BADBHKODLLL : ContainerPropertyBag<BKJLMKNKEAJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class NCPMPCHFLHB : Property<BKJLMKNKEAJ, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x708C150", Offset = "0x708A950", VA = "0x18708C150", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x708C110", Offset = "0x708A910", VA = "0x18708C110")]
		public NCPMPCHFLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x708A250", Offset = "0x7088A50", VA = "0x18708A250", Slot = "14")]
		public override Rigidbody GetValue(BKJLMKNKEAJ MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x708A270", Offset = "0x7088A70", VA = "0x18708A270", Slot = "15")]
		public override void SetValue(BKJLMKNKEAJ MFHCHOKEAIG, Rigidbody INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7089E90", Offset = "0x7088690", VA = "0x187089E90")]
	public BADBHKODLLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class LFEOOMBOFBO : ContainerPropertyBag<ILJLHOHDBKA>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class MLFALFLHLBF : Property<ILJLHOHDBKA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x708BE70", Offset = "0x708A670", VA = "0x18708BE70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x708BE30", Offset = "0x708A630", VA = "0x18708BE30")]
		public MLFALFLHLBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x708A250", Offset = "0x7088A50", VA = "0x18708A250", Slot = "14")]
		public override object GetValue(ILJLHOHDBKA MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x708A270", Offset = "0x7088A70", VA = "0x18708A270", Slot = "15")]
		public override void SetValue(ILJLHOHDBKA MFHCHOKEAIG, object INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x708BAF0", Offset = "0x708A2F0", VA = "0x18708BAF0")]
	public LFEOOMBOFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class COGLABEOJBP : ContainerPropertyBag<CEJNCGPNCMO>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class FDHBCCCFEIB : Property<CEJNCGPNCMO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string AEHPFKGBHAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x708A9C0", Offset = "0x70891C0", VA = "0x18708A9C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool CDFNJCJNLIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x708A980", Offset = "0x7089180", VA = "0x18708A980")]
		public FDHBCCCFEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x708A250", Offset = "0x7088A50", VA = "0x18708A250", Slot = "14")]
		public override object GetValue(CEJNCGPNCMO MFHCHOKEAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x708A270", Offset = "0x7088A70", VA = "0x18708A270", Slot = "15")]
		public override void SetValue(CEJNCGPNCMO MFHCHOKEAIG, object INDENPJBLHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x708A510", Offset = "0x7088D10", VA = "0x18708A510")]
	public COGLABEOJBP()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x708C590", Offset = "0x708AD90", VA = "0x18708C590")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class AGIJBHGDPCL
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public AGIJBHGDPCL()
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

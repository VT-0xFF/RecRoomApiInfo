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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73C9660", Offset = "0x73C8460", VA = "0x1873C9660", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73C9A10", Offset = "0x73C8810", VA = "0x1873C9A10", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AHAEFBNMAPE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73C6840", Offset = "0x73C5640", VA = "0x1873C6840", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CNALCPFDKEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NMDBGFPJDGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity CHGCHBMKCKM;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GOBBOOJEKOG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity CHGCHBMKCKM;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DFAFMAKHMKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<MEGFGNPHEOJ> NMGJGIIGOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> AIEBFFNAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle JELKNJKJNOO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HLLEOGFNEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x73C6ED0", Offset = "0x73C5CD0", VA = "0x1873C6ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x73C6E80", Offset = "0x73C5C80", VA = "0x1873C6E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5471D70", Offset = "0x5470B70", VA = "0x185471D70")]
	public DFAFMAKHMKI(NativeList<MEGFGNPHEOJ> NMGJGIIGOKD, NativeList<Entity> AIEBFFNAGAP, JobHandle JELKNJKJNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x73C6F40", Offset = "0x73C5D40", VA = "0x1873C6F40")]
	public (Entity, NativeSlice<Entity>) JAHOHEOAIFE(int JELBMBFLBOP)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x73C6E20", Offset = "0x73C5C20", VA = "0x1873C6E20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MEGFGNPHEOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity DOJENPPADJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int DACBEFNKNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int AIIKLGOLFIK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ILBEHGLCKCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FBFDCEOGDDB(bool GMLEOMAPLNJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BCJJDBKBEOO : IEquatable<BCJJDBKBEOO>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool IHJONBLDPOM(int JOGIDIAAHEC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool ABPMCEKFBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool APKABNCNPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool BEMPMINMKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool PJENOFFDBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IHJONBLDPOM CMHDHKACPPA;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x73C6AE0", Offset = "0x73C58E0", VA = "0x1873C6AE0")]
	public BCJJDBKBEOO(OFKIBJDIALG HNALEDONGCB, IHJONBLDPOM CMHDHKACPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x73C6AB0", Offset = "0x73C58B0", VA = "0x1873C6AB0")]
	public BCJJDBKBEOO(bool ABPMCEKFBPO, bool APKABNCNPCI, bool BEMPMINMKML, bool PJENOFFDBFF, IHJONBLDPOM CMHDHKACPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73C6960", Offset = "0x73C5760", VA = "0x1873C6960")]
	public bool FKJDPOEMNFO(int JOGIDIAAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73C6A50", Offset = "0x73C5850", VA = "0x1873C6A50")]
	public bool KNEDBJNLBLG(int JOGIDIAAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x73C6850", Offset = "0x73C5650", VA = "0x1873C6850")]
	public bool BFBDDDLKBNK(int JOGIDIAAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x73C6A80", Offset = "0x73C5880", VA = "0x1873C6A80")]
	public bool LAHBGMFMJLD(int JOGIDIAAHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x73C6880", Offset = "0x73C5680", VA = "0x1873C6880", Slot = "4")]
	public bool Equals(BCJJDBKBEOO LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x73C68B0", Offset = "0x73C56B0", VA = "0x1873C68B0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x73C6990", Offset = "0x73C5790", VA = "0x1873C6990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x73C6A30", Offset = "0x73C5830", VA = "0x1873C6A30")]
	private bool JGKHNNFAGCC(int JOGIDIAAHEC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DKGEAJGGCOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ANKAMLLLOEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LDKBEDPBCHA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct NEPOIGOBLAN : IBufferElementData, IEquatable<NEPOIGOBLAN>, LAPBMAEDKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity DOOFGBAMPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int FONONCEMPGM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity FCDJJEBMDID
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73C89C0", Offset = "0x73C77C0", VA = "0x1873C89C0", Slot = "4")]
	public bool Equals(NEPOIGOBLAN LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PJBAHGPELGL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public ANIPKKMJKKG DFHAIKHKAKA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x73C9010", Offset = "0x73C7E10", VA = "0x1873C9010", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PJBAHGPELGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ANIPKKMJKKG
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KHCOOENNGJG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct OJJNNHCOMPN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct EHBGJCNEEKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly HDMFGKLOAGI JMHNNGHPPIH;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2B43600", Offset = "0x2B42400", VA = "0x182B43600")]
		public EHBGJCNEEKP(HDMFGKLOAGI AKKEBJBBJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x73C7120", Offset = "0x73C5F20", VA = "0x1873C7120")]
		public bool NEPHLAPKCCJ(OJJNNHCOMPN JPLFANFCANH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x73C7110", Offset = "0x73C5F10", VA = "0x1873C7110")]
		public bool BDCMCJEACIB(OJJNNHCOMPN JPLFANFCANH, HDMFGKLOAGI NMDBPCHLHHJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly HDMFGKLOAGI IINGPMEFKHN;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B43600", Offset = "0x2B42400", VA = "0x182B43600")]
	public OJJNNHCOMPN(HDMFGKLOAGI IINGPMEFKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x73C8DA0", Offset = "0x73C7BA0", VA = "0x1873C8DA0")]
	public OJJNNHCOMPN NCCMLIHLNBH(HDMFGKLOAGI JINFNIDCKNE)
	{
		return default(OJJNNHCOMPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x73C8D90", Offset = "0x73C7B90", VA = "0x1873C8D90")]
	public OJJNNHCOMPN EBPDBGJLEHP(HDMFGKLOAGI MKALDKJJOGJ)
	{
		return default(OJJNNHCOMPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73C8DB0", Offset = "0x73C7BB0", VA = "0x1873C8DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum HDMFGKLOAGI : ushort
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
public enum DFDEPFGHPNF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[SingletonComponent]
public struct GEKFFNOFHIE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public DFDEPFGHPNF IINGPMEFKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool OODGIEEAPNE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LCKAEKMALAI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73C73C0", Offset = "0x73C61C0", VA = "0x1873C73C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73C73F0", Offset = "0x73C61F0", VA = "0x1873C73F0")]
	private GEKFFNOFHIE(DFDEPFGHPNF IINGPMEFKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x73C73D0", Offset = "0x73C61D0", VA = "0x1873C73D0")]
	public GEKFFNOFHIE NCCMLIHLNBH(DFDEPFGHPNF JINFNIDCKNE)
	{
		return default(GEKFFNOFHIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x73C73A0", Offset = "0x73C61A0", VA = "0x1873C73A0")]
	public GEKFFNOFHIE EBPDBGJLEHP(DFDEPFGHPNF MKALDKJJOGJ)
	{
		return default(GEKFFNOFHIE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BKEEHBIFEDA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JILKMDKIFOB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity CMLNMADLFPG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, LAPBMAEDKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x73C6840", Offset = "0x73C5640", VA = "0x1873C6840", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[SingletonComponent]
public struct HJDKHEEEDOF : ISystemStateBufferElementData, IBufferElementData, LAPBMAEDKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity DGNDJCBPFEH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity HDAMGELLPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MFCNKHLDGIP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity IEKHNECBMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity GHLEFAKAJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity PGKKCCOMOBM;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CANMHBMANGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Guid OGOMDMBFOMG;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct IMECKHKEEAH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool JJCPGCBCCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint ENKGJBOFNBL;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	private static bool MEAMIEIPCPD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[TypeManager.TypeVersion(2)]
public struct FOMCPGNEJBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public uint ANPHDBAPADE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x73C7230", Offset = "0x73C6030", VA = "0x1873C7230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LJOLOLEIKAM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SingletonComponent]
public struct LHACINOBPOO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KOEAEJBFAJM;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NLCALHAANDA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int MLOEPLKKMAH;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KMNMDODMKCO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GCHandle PPOFCBEAAFK;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OMHEHDIECID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MLOEPLKKMAH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MFNAMGCJBIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct NOLFOHJIIGO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int MLOEPLKKMAH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct OCAGLFHIGDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HCKLHNMLMHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BPIEMOPHEPF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct OJPFEAKBPFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public CollisionDetectionMode DLIGLIEBNGL;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RegisterComponentDefault]
public struct KCJHHLGMODP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public FMMANLJJECN GHNKEDNEIKB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly KCJHHLGMODP KPNHHCMCHOD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct BPFNJHNDDDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct IBJMIABNCJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GHLDFLOJDEA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[InternalBufferCapacity(0)]
public struct IMNEDOAIGGM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity DOOFGBAMPBE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct ABACEICBPDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity IFAMCPHMKIP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct KIADGINGNHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct FHBMEGCDDCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Entity DOJENPPADJD;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct JLMKAANMCPE : HGKNHAOCIKL, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CDBMLNCPFOP PBKOFPLJDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(CDBMLNCPFOP);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BOCKCJHBGHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 IHNNMMEJCGH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct PIHMHCOKNFN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RegisterComponentDefault]
public struct KNHJGIPOIBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3x3 EDOCJKBEENH;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly KNHJGIPOIBJ KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct FMLFBBHCMHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float3x3 EDOCJKBEENH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly FMLFBBHCMHB KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct FAAKBGCCBJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 MBLLJOBKECO;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct ACEENOHHDEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 IMBDGPJICOA;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[RegisterComponentDefault]
public struct ODNAPKBFJNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float HOKBOJMCPKF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly ODNAPKBFJNP KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[RegisterComponentDefault]
public struct DPDKMJKCHOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float EPBICGONCPE;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly DPDKMJKCHOP KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NFBIPLFOICA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 GJBMPLJHKOL;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct BCAFDHLIKDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public OAPFEGBJMCF NOODLEOBFGB;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GOFANFMMJMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public OAPFEGBJMCF ONPPOJMKPKN;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[SingletonComponent]
public struct IHDBOFALEIO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Entity DGNDJCBPFEH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct FIBPHNCOAJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct AJFCGFGMIKA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct IADLJFILGMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public RigidbodyConstraints FPMNJBFKPFN;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
public struct IMDFFNDCOII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float GBAJHMLCMJB;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly IMDFFNDCOII KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct CAOOJGEEIJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float HCEIMKNAAFE;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HHBGBBJKAME : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct BCLLILDAFHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public object CCGHOCGLGEA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GameObject IHNPMPCJPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public object OPBCLMGMDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public object DAENEMFDFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public BCLLILDAFHM CCGHOCGLGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Delegate JMCPACPDKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Delegate NIELDKGKHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public ODEPIHBIIKA<Delegate> DNEMCKDGEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ODEPIHBIIKA<Delegate> EFOPMBBNNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ODEPIHBIIKA<Delegate> LOFPENJPJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public ODEPIHBIIKA<Delegate> JENAOAJNMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public ODEPIHBIIKA<Delegate> PCELLNDBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public ODEPIHBIIKA<Delegate> EDCANAPAOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public ODEPIHBIIKA<Delegate> IGHCAPICNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public ODEPIHBIIKA<Delegate> BJAFNAAHIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public ODEPIHBIIKA<Delegate> NHOINOPHEPM;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x73C76A0", Offset = "0x73C64A0", VA = "0x1873C76A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public HHBGBBJKAME()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct CBHIAJDGPCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct IKKCBOLMLLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int NLIANNKPGCF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0020", Offset = "0x1BEEE20", VA = "0x181BF0020")]
	public static IKKCBOLMLLN JCHCBNMNCNP(int IPHILEOFJLB)
	{
		return default(IKKCBOLMLLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class OCHDIKNFGPM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Rigidbody IDAFMFPGOAC;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73C8B90", Offset = "0x73C7990", VA = "0x1873C8B90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public OCHDIKNFGPM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct BPFBBDJOCEH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct GMLCFMJKGIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float3 APIEHLLLAEO;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DDFAHHFDBKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 PHFLICDNCII;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
public struct LLFCMHAKIKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float DLNNFHKAMLO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly LLFCMHAKIKB KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class FPEFEFPPBHG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public object JPLBAKBGOHC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73C7330", Offset = "0x73C6130", VA = "0x1873C7330", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public FPEFEFPPBHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class EGNDBIDDOKK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public object LKFJDNBADOJ;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x73C70A0", Offset = "0x73C5EA0", VA = "0x1873C70A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public EGNDBIDDOKK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct LKGLJCGHEOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct LEDOGBLJCIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct KILODPNPCLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct OGPADMGKIJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ABBGEIKNEEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct OPDCKFNIPGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct APBEGAIJPFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public FixedString32Bytes PPKJBGAOBJL;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[SingletonComponent]
public struct HFCIBKFAOHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity BIPFCCJFNGE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static HFCIBKFAOHI JCHCBNMNCNP(Entity IPHILEOFJLB)
	{
		return default(HFCIBKFAOHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal struct OAANPPNJPAP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity DGNDJCBPFEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static OAANPPNJPAP JCHCBNMNCNP(Entity DGNDJCBPFEH)
	{
		return default(OAANPPNJPAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct AOLAFOHAACN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity MEJBKPLENBN;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct OLGBPBNEAJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity MEJBKPLENBN;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct HNBMJLCOFHK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Entity ABONFMELAKL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static HNBMJLCOFHK JCHCBNMNCNP(Entity DGNDJCBPFEH)
	{
		return default(HNBMJLCOFHK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct LDKEDNJLMPC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct NJBPCMOFMBF : IBufferElementData, IEquatable<NJBPCMOFMBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Entity DBFEHIHKCIO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x73C8A10", Offset = "0x73C7810", VA = "0x1873C8A10", Slot = "4")]
	public bool Equals(NJBPCMOFMBF LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x73C8A20", Offset = "0x73C7820", VA = "0x1873C8A20", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct FHHLDCKFBHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public uint BBDOELHAPOH;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[SingletonComponent]
internal struct NABEDCHDHMG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Entity ELKAABPKIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public int KNCPCNBMDNF;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct NAICECEJHKB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity MPFNEAFMDIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct GMNGCGCCECC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct CGACONHAINA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public uint ENKGJBOFNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int JICDDFIBGFB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xBD9040", Offset = "0xBD7E40", VA = "0x180BD9040")]
	public CGACONHAINA(uint JLLOBCDGCJF, int BMJLFBNPAEF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct CDPPJOLHHMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct FPJKBFMOOEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JJKMMHCOCNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct BDJPGJEAMIG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct LAAGPLBJOPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GADEIGKGIDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct BBEOAHCGIGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct MHLPFBNDFEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct PNEFGNJCCBH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct OGPAFAGCJIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NJFCOFBLGPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct EDBNOMFFCKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LLIBMJBJGJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct EPDAMADGAOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal struct OHFONGIIHJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct LNCIIONLCBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct DDCHIHKFNHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct OIOECCHBPAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct IPDGJHPJEMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct ICFGMHDGGBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct MBINBOPHNOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct BHBCDOLBMOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct CJNKJOFPKAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct CKGFKMFBAKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct HMGNFFFALII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct DKMMIEPGFMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct CJKCOGFLABO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct FIDHDCOMHOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct DFACAFEIKOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct LLLGOHAGMNI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[SingletonComponent]
public struct ELDGOGPCJPD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public FixedString32Bytes LCGMANEHHDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct APAFKOGNKKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct NILLEONGEMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal struct NKKBHDDHAGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct HIKPIOEIKFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal struct JKGMLJJLDDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct KPGIGCGEIEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct GDPOMNGADED : IComponentData, IComparable<GDPOMNGADED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int NAFOMNBNEMG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1EE6B10", Offset = "0x1EE5910", VA = "0x181EE6B10", Slot = "4")]
	public int CompareTo(GDPOMNGADED LHMPMCLNOPG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct GAOAMOHOAFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct PDMEPPANNKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public quaternion CKABIAOPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float3 AKEODPFBHJE;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct FHEBIPGAMKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float OGCCNAKMGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float KEPBDJNIMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float ECNFAHNOFEE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct JHKNNCHEFBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct KIBDEBNFBAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct JHIALGLPHHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct IOEFDMMKAFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MLOEPLKKMAH;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[SingletonComponent]
public struct NCFCBCFGMCB : ISystemStateBufferElementData, IBufferElementData, LAPBMAEDKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity MKAIGHNBGKO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity HDAMGELLPBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RegisterComponentDefault]
public struct CHGCOMHGODP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float4x4 NPLBDHHMGPP;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly CHGCOMHGODP KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[RegisterComponentDefault]
public struct HODEBEJLHLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float4x4 DBNIFHLIALC;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly HODEBEJLHLJ KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct PGLEFFHFNMG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private int DCLDFMBPMOO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KNCPCNBMDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73C9000", Offset = "0x73C7E00", VA = "0x1873C9000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x73C8FF0", Offset = "0x73C7DF0", VA = "0x1873C8FF0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[RegisterComponentDefault]
public struct HNBNGPIBBDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public float3 AKEODPFBHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public quaternion CKABIAOPKPM;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly HNBNGPIBBDO KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class HNEJCBPBPCF
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[RegisterComponentDefault]
public struct MLKAEDPGNGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float BKDHHPIPODG;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MLKAEDPGNGA KPNHHCMCHOD;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct KGAIEPBICGA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity DGBJJAAHDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public PMJLGJGNALL NCGEJMOHJLG;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct FKAHOIMDEOL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public PMJLGJGNALL NCGEJMOHJLG;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct AHONMGHIFCL : ISystemStateComponentData, IComponentData, LAPBMAEDKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Entity MPGLDFENCOD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity HDAMGELLPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct GKDBFCPMKKD : ISystemStateBufferElementData, IBufferElementData, LAPBMAEDKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Entity PNMKOPDEHHK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity HDAMGELLPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct INJOKMPNODE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity DGBJJAAHDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public PMJLGJGNALL NCGEJMOHJLG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct KMNBJHGEMJF : IEqualityComparer<INJOKMPNODE>
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static KMNBJHGEMJF KPNHHCMCHOD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73C8720", Offset = "0x73C7520", VA = "0x1873C8720", Slot = "4")]
	public bool Equals(INJOKMPNODE LBONEMFCDEA, INJOKMPNODE IOKFBHNPJAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73C8770", Offset = "0x73C7570", VA = "0x1873C8770", Slot = "5")]
	public int GetHashCode(INJOKMPNODE JOOHPPHJKMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct HNNMODNIIGF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public FixedList32Bytes<int> LGAJBJOLBKK;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct JFIDMHNEEGD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public FixedList32Bytes<int> LGAJBJOLBKK;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct PDBILIKKECP : ISystemStateBufferElementData, IBufferElementData, LAPBMAEDKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity LAGLLEONBNO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity FCDJJEBMDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x148FD60", Offset = "0x148EB60", VA = "0x18148FD60", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class IMCPLFHJEEF : ContainerPropertyBag<PJBAHGPELGL>
{
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class AHPJKKNAGCJ : Property<PJBAHGPELGL, ANIPKKMJKKG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x73C6750", Offset = "0x73C5550", VA = "0x1873C6750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x73C6710", Offset = "0x73C5510", VA = "0x1873C6710")]
		public AHPJKKNAGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x73C66C0", Offset = "0x73C54C0", VA = "0x1873C66C0", Slot = "14")]
		public override ANIPKKMJKKG GetValue(PJBAHGPELGL BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x73C66E0", Offset = "0x73C54E0", VA = "0x1873C66E0", Slot = "15")]
		public override void SetValue(PJBAHGPELGL BCNFHKMHIOK, ANIPKKMJKKG IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73C7AA0", Offset = "0x73C68A0", VA = "0x1873C7AA0")]
	public IMCPLFHJEEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class JMFPIBIAMDD : ContainerPropertyBag<HHBGBBJKAME>
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class OIECMMLAILL : Property<HHBGBBJKAME, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x73C8D60", Offset = "0x73C7B60", VA = "0x1873C8D60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73C8D20", Offset = "0x73C7B20", VA = "0x1873C8D20")]
		public OIECMMLAILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x73C66C0", Offset = "0x73C54C0", VA = "0x1873C66C0", Slot = "14")]
		public override GameObject GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x73C66E0", Offset = "0x73C54E0", VA = "0x1873C66E0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, GameObject IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class PAJKLCABKCF : Property<HHBGBBJKAME, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x73C8EA0", Offset = "0x73C7CA0", VA = "0x1873C8EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x73C8E60", Offset = "0x73C7C60", VA = "0x1873C8E60")]
		public PAJKLCABKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x73C8E10", Offset = "0x73C7C10", VA = "0x1873C8E10", Slot = "14")]
		public override object GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x73C8E30", Offset = "0x73C7C30", VA = "0x1873C8E30", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, object IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class PAPKINKBFOK : Property<HHBGBBJKAME, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x73C8F60", Offset = "0x73C7D60", VA = "0x1873C8F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x73C8F20", Offset = "0x73C7D20", VA = "0x1873C8F20")]
		public PAPKINKBFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x73C8ED0", Offset = "0x73C7CD0", VA = "0x1873C8ED0", Slot = "14")]
		public override object GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x73C8EF0", Offset = "0x73C7CF0", VA = "0x1873C8EF0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, object IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class HFKOBNLPFEP : Property<HHBGBBJKAME, HHBGBBJKAME.BCLLILDAFHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x73C7670", Offset = "0x73C6470", VA = "0x1873C7670", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x73C7630", Offset = "0x73C6430", VA = "0x1873C7630")]
		public HFKOBNLPFEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x73C75E0", Offset = "0x73C63E0", VA = "0x1873C75E0", Slot = "14")]
		public override HHBGBBJKAME.BCLLILDAFHM GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(HHBGBBJKAME.BCLLILDAFHM);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x73C7600", Offset = "0x73C6400", VA = "0x1873C7600", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, HHBGBBJKAME.BCLLILDAFHM IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class AKIAJHHKOHN : Property<HHBGBBJKAME, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x73C6810", Offset = "0x73C5610", VA = "0x1873C6810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x73C67D0", Offset = "0x73C55D0", VA = "0x1873C67D0")]
		public AKIAJHHKOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73C6780", Offset = "0x73C5580", VA = "0x1873C6780", Slot = "14")]
		public override Delegate GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x73C67A0", Offset = "0x73C55A0", VA = "0x1873C67A0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, Delegate IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class JLOFDBHNIOH : Property<HHBGBBJKAME, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x73C7E10", Offset = "0x73C6C10", VA = "0x1873C7E10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x73C7DD0", Offset = "0x73C6BD0", VA = "0x1873C7DD0")]
		public JLOFDBHNIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x73C7D80", Offset = "0x73C6B80", VA = "0x1873C7D80", Slot = "14")]
		public override Delegate GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x73C7DA0", Offset = "0x73C6BA0", VA = "0x1873C7DA0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, Delegate IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class IPIHHMMDFCE : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x73C7C70", Offset = "0x73C6A70", VA = "0x1873C7C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x73C7C30", Offset = "0x73C6A30", VA = "0x1873C7C30")]
		public IPIHHMMDFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73C7BC0", Offset = "0x73C69C0", VA = "0x1873C7BC0", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x73C7BF0", Offset = "0x73C69F0", VA = "0x1873C7BF0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class OGHEIADNICN : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x73C8CF0", Offset = "0x73C7AF0", VA = "0x1873C8CF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x73C8CB0", Offset = "0x73C7AB0", VA = "0x1873C8CB0")]
		public OGHEIADNICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x73C8C40", Offset = "0x73C7A40", VA = "0x1873C8C40", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x73C8C70", Offset = "0x73C7A70", VA = "0x1873C8C70", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class NPIJLMIALPE : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x73C8B60", Offset = "0x73C7960", VA = "0x1873C8B60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x73C8B20", Offset = "0x73C7920", VA = "0x1873C8B20")]
		public NPIJLMIALPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x73C8AB0", Offset = "0x73C78B0", VA = "0x1873C8AB0", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x73C8AE0", Offset = "0x73C78E0", VA = "0x1873C8AE0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class KDALOOFIKEC : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x73C85A0", Offset = "0x73C73A0", VA = "0x1873C85A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x73C8560", Offset = "0x73C7360", VA = "0x1873C8560")]
		public KDALOOFIKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x73C84E0", Offset = "0x73C72E0", VA = "0x1873C84E0", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x73C8520", Offset = "0x73C7320", VA = "0x1873C8520", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class CILPKKMOODD : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x73C6D10", Offset = "0x73C5B10", VA = "0x1873C6D10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x73C6CD0", Offset = "0x73C5AD0", VA = "0x1873C6CD0")]
		public CILPKKMOODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73C6C50", Offset = "0x73C5A50", VA = "0x1873C6C50", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x73C6C90", Offset = "0x73C5A90", VA = "0x1873C6C90", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class GLNBPHBNGAM : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x73C74C0", Offset = "0x73C62C0", VA = "0x1873C74C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x73C7480", Offset = "0x73C6280", VA = "0x1873C7480")]
		public GLNBPHBNGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x73C7400", Offset = "0x73C6200", VA = "0x1873C7400", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73C7440", Offset = "0x73C6240", VA = "0x1873C7440", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class IKNFCLHDPDL : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x73C7A70", Offset = "0x73C6870", VA = "0x1873C7A70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73C7A30", Offset = "0x73C6830", VA = "0x1873C7A30")]
		public IKNFCLHDPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x73C79B0", Offset = "0x73C67B0", VA = "0x1873C79B0", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x73C79F0", Offset = "0x73C67F0", VA = "0x1873C79F0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class HECCJIIJEBC : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x73C75B0", Offset = "0x73C63B0", VA = "0x1873C75B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x73C7570", Offset = "0x73C6370", VA = "0x1873C7570")]
		public HECCJIIJEBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x73C74F0", Offset = "0x73C62F0", VA = "0x1873C74F0", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x73C7530", Offset = "0x73C6330", VA = "0x1873C7530", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	private class AGEAHOLKDBD : Property<HHBGBBJKAME, ODEPIHBIIKA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x73C6690", Offset = "0x73C5490", VA = "0x1873C6690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73C6650", Offset = "0x73C5450", VA = "0x1873C6650")]
		public AGEAHOLKDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x73C65D0", Offset = "0x73C53D0", VA = "0x1873C65D0", Slot = "14")]
		public override ODEPIHBIIKA<Delegate> GetValue(HHBGBBJKAME BCNFHKMHIOK)
		{
			return default(ODEPIHBIIKA<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x73C6610", Offset = "0x73C5410", VA = "0x1873C6610", Slot = "15")]
		public override void SetValue(HHBGBBJKAME BCNFHKMHIOK, ODEPIHBIIKA<Delegate> IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73C7E40", Offset = "0x73C6C40", VA = "0x1873C7E40")]
	public JMFPIBIAMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class JLLALGEBGOP : ContainerPropertyBag<HHBGBBJKAME.BCLLILDAFHM>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class MBDLOHANANA : Property<HHBGBBJKAME.BCLLILDAFHM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x73C8950", Offset = "0x73C7750", VA = "0x1873C8950", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x73C8910", Offset = "0x73C7710", VA = "0x1873C8910")]
		public MBDLOHANANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xD198F0", Offset = "0xD186F0", VA = "0x180D198F0", Slot = "14")]
		public override object GetValue(HHBGBBJKAME.BCLLILDAFHM BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4F62CA0", Offset = "0x4F61AA0", VA = "0x184F62CA0", Slot = "15")]
		public override void SetValue(HHBGBBJKAME.BCLLILDAFHM BCNFHKMHIOK, object IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x73C7CA0", Offset = "0x73C6AA0", VA = "0x1873C7CA0")]
	public JLLALGEBGOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class PELDPPMEPJN : ContainerPropertyBag<ODEPIHBIIKA<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x73C8F90", Offset = "0x73C7D90", VA = "0x1873C8F90")]
	public PELDPPMEPJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class IGOCMMGHAMB : ContainerPropertyBag<OCHDIKNFGPM>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class KMJCFALPAND : Property<OCHDIKNFGPM, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x73C86F0", Offset = "0x73C74F0", VA = "0x1873C86F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x73C86B0", Offset = "0x73C74B0", VA = "0x1873C86B0")]
		public KMJCFALPAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x73C66C0", Offset = "0x73C54C0", VA = "0x1873C66C0", Slot = "14")]
		public override Rigidbody GetValue(OCHDIKNFGPM BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x73C66E0", Offset = "0x73C54E0", VA = "0x1873C66E0", Slot = "15")]
		public override void SetValue(OCHDIKNFGPM BCNFHKMHIOK, Rigidbody IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x73C78D0", Offset = "0x73C66D0", VA = "0x1873C78D0")]
	public IGOCMMGHAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class KJIMCHIKFJO : ContainerPropertyBag<FPEFEFPPBHG>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class FOOAJIPPNKI : Property<FPEFEFPPBHG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x73C7300", Offset = "0x73C6100", VA = "0x1873C7300", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x73C72C0", Offset = "0x73C60C0", VA = "0x1873C72C0")]
		public FOOAJIPPNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x73C66C0", Offset = "0x73C54C0", VA = "0x1873C66C0", Slot = "14")]
		public override object GetValue(FPEFEFPPBHG BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x73C66E0", Offset = "0x73C54E0", VA = "0x1873C66E0", Slot = "15")]
		public override void SetValue(FPEFEFPPBHG BCNFHKMHIOK, object IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x73C85D0", Offset = "0x73C73D0", VA = "0x1873C85D0")]
	public KJIMCHIKFJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal class CLDEDIAFAOF : ContainerPropertyBag<EGNDBIDDOKK>
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class BEPANINEDGM : Property<EGNDBIDDOKK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x73C6B70", Offset = "0x73C5970", VA = "0x1873C6B70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool HPHENKFIHIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x73C6B30", Offset = "0x73C5930", VA = "0x1873C6B30")]
		public BEPANINEDGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x73C66C0", Offset = "0x73C54C0", VA = "0x1873C66C0", Slot = "14")]
		public override object GetValue(EGNDBIDDOKK BCNFHKMHIOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x73C66E0", Offset = "0x73C54E0", VA = "0x1873C66E0", Slot = "15")]
		public override void SetValue(EGNDBIDDOKK BCNFHKMHIOK, object IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73C6D40", Offset = "0x73C5B40", VA = "0x1873C6D40")]
	public CLDEDIAFAOF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x73C9080", Offset = "0x73C7E80", VA = "0x1873C9080")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class PINIBFHHCLA
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PINIBFHHCLA()
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

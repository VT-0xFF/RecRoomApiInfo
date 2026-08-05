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
using Unity.Collections.LowLevel.Unsafe;
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x79E6EE0", Offset = "0x79E62E0", VA = "0x1879E6EE0", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79E7290", Offset = "0x79E6690", VA = "0x1879E7290", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct DDKDILEEPLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct CGBGBMKJDPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct KPAEMFEAOEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct KDHDLEBAFJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct JJGMGFPFCPE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79E3B20", Offset = "0x79E2F20", VA = "0x1879E3B20", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct PCMBKKOFDLM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct LBDKNMPENNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity BJBPEHCAPFN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct MIKGLAPBPOF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity BJBPEHCAPFN;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ICCFMKCGDLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<MEAPDDCLFEN> PDCKCKOILPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> MIFKLFMOHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle CNINKJDDJFJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IDHODAIBOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x79E5700", Offset = "0x79E4B00", VA = "0x1879E5700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x79E5530", Offset = "0x79E4930", VA = "0x1879E5530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x58A9B80", Offset = "0x58A8F80", VA = "0x1858A9B80")]
	public ICCFMKCGDLD(NativeList<MEAPDDCLFEN> PDCKCKOILPI, NativeList<Entity> MIFKLFMOHMG, JobHandle CNINKJDDJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x79E55E0", Offset = "0x79E49E0", VA = "0x1879E55E0")]
	public (Entity, NativeSlice<Entity>) HALHDKGPDIP(int JKHIIFLAPEC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79E5580", Offset = "0x79E4980", VA = "0x1879E5580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MEAPDDCLFEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity BKHMOJGGBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int HGHGCNDALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int BFBCILDCBHG;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LCFOEDCHBII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOOLKHEIGIE(bool FPOCBGLDBOB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BGHKFKGEOFE : IEquatable<BGHKFKGEOFE>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool OBDELGJAHLB(int GIBMIJMGIIO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool MONBMGDPFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool GHKECLPALPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool NPBNHOFNPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool HLIGGHACBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OBDELGJAHLB FCKLOAIGGKC;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79E3FD0", Offset = "0x79E33D0", VA = "0x1879E3FD0")]
	public BGHKFKGEOFE(FECKIEFHJNO KHCEBCMPDGO, OBDELGJAHLB FCKLOAIGGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79E3FA0", Offset = "0x79E33A0", VA = "0x1879E3FA0")]
	public BGHKFKGEOFE(bool MONBMGDPFNH, bool GHKECLPALPC, bool NPBNHOFNPPP, bool HLIGGHACBNP, OBDELGJAHLB FCKLOAIGGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x79E3CE0", Offset = "0x79E30E0", VA = "0x1879E3CE0")]
	public bool EMOMEOJILAH(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x79E3E90", Offset = "0x79E3290", VA = "0x1879E3E90")]
	public bool IFBFFBLIMNM(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79E3CB0", Offset = "0x79E30B0", VA = "0x1879E3CB0")]
	public bool BEBBJCAEFNG(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x79E3EC0", Offset = "0x79E32C0", VA = "0x1879E3EC0")]
	public bool LKLIHOIMMOD(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x79E3DC0", Offset = "0x79E31C0", VA = "0x1879E3DC0", Slot = "4")]
	public bool Equals(BGHKFKGEOFE KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x79E3D10", Offset = "0x79E3110", VA = "0x1879E3D10", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x79E3DF0", Offset = "0x79E31F0", VA = "0x1879E3DF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x79E3EF0", Offset = "0x79E32F0", VA = "0x1879E3EF0")]
	private bool MEBGCNHBLHC(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x79E3F10", Offset = "0x79E3310", VA = "0x1879E3F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct ONDNKEMNJKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct JPANJLNCKJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct BNBLADFFDMP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct CBFMIICJKFB : IBufferElementData, IEquatable<CBFMIICJKFB>, PPOOIPHJPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity MKPPIPAJFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int KNDNMJHEIJG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity GPIMNMHDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x79E4120", Offset = "0x79E3520", VA = "0x1879E4120", Slot = "4")]
	public bool Equals(CBFMIICJKFB KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FMKLDLNGAGF : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public LHHKKBOIJOC JOIGCFJFACD;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x79E5010", Offset = "0x79E4410", VA = "0x1879E5010", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public FMKLDLNGAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LHHKKBOIJOC
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct AKADHDPCJGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct HKMNOCHMDIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly MHFDPAMPHHI LHPKDMOOJKH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CA53E0", Offset = "0x2CA47E0", VA = "0x182CA53E0")]
	public HKMNOCHMDIB(MHFDPAMPHHI LHPKDMOOJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x79E53D0", Offset = "0x79E47D0", VA = "0x1879E53D0")]
	public HKMNOCHMDIB AECMHBOBEAO(MHFDPAMPHHI OABEHMABAGN)
	{
		return default(HKMNOCHMDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x79E53E0", Offset = "0x79E47E0", VA = "0x1879E53E0")]
	public HKMNOCHMDIB BOBAJLLHLGJ(MHFDPAMPHHI EBFCDCACDOC)
	{
		return default(HKMNOCHMDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x79E53F0", Offset = "0x79E47F0", VA = "0x1879E53F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum MHFDPAMPHHI : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class CFLDLFMKMIO
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct LPJIKNMPMFO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public MHFDPAMPHHI IHEFFHAPEIF;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x79E60C0", Offset = "0x79E54C0", VA = "0x1879E60C0")]
	public bool FINOCNONADG(HKMNOCHMDIB MLGNKPAOBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x79E60D0", Offset = "0x79E54D0", VA = "0x1879E60D0")]
	public bool FPFOEFBOGLG(HKMNOCHMDIB MLGNKPAOBIG, MHFDPAMPHHI AJBCBFLGIOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum AFDCOIHPMIL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
[SingletonComponent]
public struct KGIDBBPDDNC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public AFDCOIHPMIL LHPKDMOOJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool PBLMDHGECFK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PBPPDAJGMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x79E5E20", Offset = "0x79E5220", VA = "0x1879E5E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x79E5E30", Offset = "0x79E5230", VA = "0x1879E5E30")]
	private KGIDBBPDDNC(AFDCOIHPMIL LHPKDMOOJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x79E5DE0", Offset = "0x79E51E0", VA = "0x1879E5DE0")]
	public KGIDBBPDDNC AECMHBOBEAO(AFDCOIHPMIL OABEHMABAGN)
	{
		return default(KGIDBBPDDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x79E5E00", Offset = "0x79E5200", VA = "0x1879E5E00")]
	public KGIDBBPDDNC BOBAJLLHLGJ(AFDCOIHPMIL EBFCDCACDOC)
	{
		return default(KGIDBBPDDNC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct JEDBKNIEEMO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[InternalBufferCapacity(1)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct DMFFBMMIEBJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity LLHCDDEOHEJ;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, PPOOIPHJPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79E3B20", Offset = "0x79E2F20", VA = "0x1879E3B20", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct OEAILJDIIIB : ISystemStateBufferElementData, IBufferElementData, PPOOIPHJPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity GJIBJHOJMIG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity LPLOADAFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct FHAEIJHKMBH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity GJAKDINEKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity JKPCDDHINHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity HFEJIDDMAEG;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EPDPDINNIIB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool PNPLPCMDCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint KEKBOOCDHCE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool EMCNDBLKCHB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct GEIHJCOIKJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint EGBPHAKIEKH;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
	public GEIHJCOIKJE(BCEABACEBEP NCMOPCAHFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x79E5160", Offset = "0x79E4560", VA = "0x1879E5160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D345A0", Offset = "0x1D339A0", VA = "0x181D345A0")]
	public static GEIHJCOIKJE CLMIANKGGAM(BCEABACEBEP NCMOPCAHFNM)
	{
		return default(GEIHJCOIKJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct BOJHLDKDIKG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity GJIBJHOJMIG;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct AKJCENIAJOF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public BCEABACEBEP FFOEEMKIKJO;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct AGBGCMPFLEJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity GJIBJHOJMIG;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct BHAOEGIMJJA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid KDBHLLEACIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int ECKHNAPCKGD;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct GICGNINEIIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int FFOEEMKIKJO;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct NADNCEEHOCJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity GJIBJHOJMIG;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct PNLPIHNECAK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BCEABACEBEP FFOEEMKIKJO;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct LILEGCBHBPF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity GJIBJHOJMIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct PHBLDGGENOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct MLHHOCACAME : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int BFOGIBLDDCP;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct JMKNCGNHFIB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int LGLPENFMNLD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OLEMOLOENHO JKFJGFPEPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0")]
		get
		{
			return default(OLEMOLOENHO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct FOKMBCKGBAO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle AHDFJPJEAAE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct ANEAMLPEPOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct JFFAEEIBBAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct PCNAKDELGGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct MPKGLAMGBOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct CPCBNCDBOLL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct ODNHGNDNOMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int CJFNAFNJJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int IOFNCNFBMGK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x79E6620", Offset = "0x79E5A20", VA = "0x1879E6620")]
	public ODNHGNDNOMA(Entity GJIBJHOJMIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct MGNCEOGMDKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode JKONDHLDKND;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct JBGEOMMCCPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public FIEJAHACKON OHNCJDBHPAB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JBGEOMMCCPH AMGMCPILGIN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct EIKFOJLFOBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct FBJHCEBCIKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct EGALOGOOMGP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
[InternalBufferCapacity(0)]
public struct HIPABDOLAOB : IBufferElementData, IEquatable<HIPABDOLAOB>, PPOOIPHJPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity MKPPIPAJFEO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity GPIMNMHDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x79E3B20", Offset = "0x79E2F20", VA = "0x1879E3B20", Slot = "4")]
	public bool Equals(HIPABDOLAOB KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct EAHLODLDKKC : IComponentData, PPOOIPHJPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity KLDFHLFOOFN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity GPIMNMHDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct BMEJJHAJHEH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct GBIHNHBMNMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity BKHMOJGGBFN;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct EMADODDBOPG : PBKGDJOHGIO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BJFJLFKBJFP KJMHNECGCCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BJFJLFKBJFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct NKIFOKGCJFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 GCIKGIFFIEC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct FENDBPKBPOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct JNCNBEBMAOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 IKGOFIJNLFF;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly JNCNBEBMAOG AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct LMHBGEFLLIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 IKGOFIJNLFF;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly LMHBGEFLLIB AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct PKCHIAKJNKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 LJPIDDMFANM;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct GCEPOBKPAEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 MACIIGFEBDM;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct MMNEHDOAKPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float GPIFHIIMOPC;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly MMNEHDOAKPD AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct HHGNIBEIOFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float PPBNKHJBEAH;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly HHGNIBEIOFN AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct AKMCOJHGGEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 NNNHBNCKIMI;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct JJMHPNAAOMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FIBKGJKLAIB CHIPIMBLAEM;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct ONAJDMDGACP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity GJIBJHOJMIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct LJMONHNOCFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct JOBHDGJHNFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct FHEHAEKPDNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints JCJBHGPHKEH;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct BPCFNPIOKII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float JGEJGDEPAMA;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly BPCFNPIOKII AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct MFMPMNMFKHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float HKKACPANMAN;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GIMJEBIFLNH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject GIIGFIAPGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object KPMNEKMAFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object DBCBPEINLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public EALHJCEOOHG CBKJHEDHFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate NDMIPJMELLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate OCMDJPIJPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public LEHDJFKJBJH<Delegate> LLILOAFGLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public LEHDJFKJBJH<Delegate> AHAGGKEMEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public LEHDJFKJBJH<Delegate> IBFECACBANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public LEHDJFKJBJH<Delegate> JCICHNPEAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public LEHDJFKJBJH<Delegate> PDOELHLNEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public LEHDJFKJBJH<Delegate> FMAPIODHHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public LEHDJFKJBJH<Delegate> NFOMKNOLMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public LEHDJFKJBJH<Delegate> IBNOOOILJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LEHDJFKJBJH<Delegate> BELCKOCMFIO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79E51D0", Offset = "0x79E45D0", VA = "0x1879E51D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public GIMJEBIFLNH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct FHEEEENCIFI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct JHNKKMJHGPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int HPFLMMCJPMO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1D345A0", Offset = "0x1D339A0", VA = "0x181D345A0")]
	public static JHNKKMJHGPO CLMIANKGGAM(int FFOEEMKIKJO)
	{
		return default(JHNKKMJHGPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class HCLHNIJDCJE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody OIBOOLMLIIP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79E52D0", Offset = "0x79E46D0", VA = "0x1879E52D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public HCLHNIJDCJE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct KNGOCCHFONH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct FMIMPPMBKJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 APEPLMENJNI;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct FLEKHLPCGGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 GPBFPENHNGM;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct GIELKKJPPKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float FJKIFFMNIOF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly GIELKKJPPKP AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NGMMAJCKEMH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object PEBGLJNJCPP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79E64F0", Offset = "0x79E58F0", VA = "0x1879E64F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public NGMMAJCKEMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CGIDDAJCAJJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object JFPNBLPNPAE;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x79E4420", Offset = "0x79E3820", VA = "0x1879E4420", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public CGIDDAJCAJJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct MLNBAGIPJDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct DAFNLJGACBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct LGBEHCKINGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct HKABLBJOPIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct KNJCIDPBANM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct ALGFHBMKCKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct FLAPIHHPCGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct CPPLDMJMPPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct NDELIEGBECJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct HJDEDAIFCBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public GGPCEIFODOC LDLNJJNNPMJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79E5380", Offset = "0x79E4780", VA = "0x1879E5380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct GPEKDMPGDEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct DKOMFMNANEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct NIPBNPIDCHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct EEOPGPGHLCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes IGEPDAOOLBO;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct GPINMPCOOPH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<GGPCEIFODOC, Entity> MGOLEPHGBMA;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct CNFGHKKDMCI : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity MEIEOMLIAPB;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct NIHDGIPFDMK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity GJIBJHOJMIG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
	public static NIHDGIPFDMK CLMIANKGGAM(Entity GJIBJHOJMIG)
	{
		return default(NIHDGIPFDMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct IAJEBECGDOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity FEHEODPEKII;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct PCEOBCFJDMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity FEHEODPEKII;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct CHOMDLLFCJJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity DEMKCIIPHDE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0")]
	public static CHOMDLLFCJJ CLMIANKGGAM(Entity GJIBJHOJMIG)
	{
		return default(CHOMDLLFCJJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct ONAHIPJHELF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct KFIOKIEHCFB : IBufferElementData, IEquatable<KFIOKIEHCFB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity KAMFOOMOHPK;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x78339D0", Offset = "0x7832DD0", VA = "0x1878339D0", Slot = "4")]
	public bool Equals(KFIOKIEHCFB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79E5D50", Offset = "0x79E5150", VA = "0x1879E5D50", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct PHFNKABOMMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint IOFNCNFBMGK;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct GDINMMOLDHI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity DGNGPICABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int CJFNAFNJJLB;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct HILGCANFIDL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity FNFDDMEMDEJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct PPNIGJGFJKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct KMJEGCNFICN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint KEKBOOCDHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int EGNGFKIDGIB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
	public KMJEGCNFICN(uint NCMADHDDFLF, int OLJDGMOOGKG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct IACFJDCLNPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct EAKOGNGLHGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct DPFIBHMGCLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct BADBMJHIHAG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct GNNIOLNIBLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct CPMFDBCCCPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct MENCGNFMCNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct OGLILHPKGJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct EIOBLOCBAHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct PHEFIEBKOAF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct HDFPMGFOAIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct HJFDLLMOAFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct IAOJFPOHFCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct LBCLGMPJIIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct KDPAOLIPFKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct NEKCOJFMFEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct ANJIIKFPDOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct KDCNOGKJMOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct CIPBHCONJON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct PICBDFGCGFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct OIEIPFNHDPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct DOFMFMGFFLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct HCDBGJKJGLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct NLCJEBMBHCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct HCOPJNBKFCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct FHICGMJLCGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct NDCAJFAIIIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct LDIKBIBMOAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct CCFFDCOKMAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct KDDGMHOEAMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct HCFJCOPOGON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct MEDLPGOOECK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[EJCNPCDJKKD]
public struct FLHLCHIEHEF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct LDLMDECBHMH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes AAOLLMPNAHE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct HJIECAGMKDB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct MOFCPFGEIPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct JAFOPJHDAEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct AABCMAPMMHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct ONNMFJOOPCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct JKIPJCEODKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct KECPGGCPFEP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct BHIBHLEMBHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion AJFJKBHPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 INHMOEHIHAJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct FCJPJFHJAOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float AICCODLDNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float DKBGIEODDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float KNHDIMACNEG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct PAIJJHOEFJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct PPJMAPGLPKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct FKNGIKNOIGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct PJLGGAJDMHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int LGLPENFMNLD;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct FMLCINDJCIM : ISystemStateBufferElementData, IBufferElementData, PPOOIPHJPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity KAHAMJEBHHN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity LPLOADAFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct DIPENJJEFOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 NAEMGJDJMGH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly DIPENJJEFOP AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct HACEGKGNOBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 DOMEGPMGOEI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly HACEGKGNOBP AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct NEAAHFOBGCL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int FJMKPGFMOMK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CJFNAFNJJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x79E6460", Offset = "0x79E5860", VA = "0x1879E6460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79E6470", Offset = "0x79E5870", VA = "0x1879E6470")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct IGLKOLMGDIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 INHMOEHIHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion AJFJKBHPFHG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly IGLKOLMGDIK AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class BLIKCFHHLBB
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct JPNIJAGGBGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float HGMOIBMDOMH;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly JPNIJAGGBGB AMGMCPILGIN;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct NEGOOEEFEKB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity EOGFPKLNIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public KKDMKJIEJIF AGBLNEPGFKF;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct GFBPIBKJPNN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public KKDMKJIEJIF AGBLNEPGFKF;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct HLKANNHFBEH : ISystemStateComponentData, IComponentData, PPOOIPHJPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity EAOBCLAGGPD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity LPLOADAFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct JNDIEILAMAP : ISystemStateBufferElementData, IBufferElementData, PPOOIPHJPLD, IEquatable<JNDIEILAMAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity DBKJFPJKHDI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity LPLOADAFMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x78339D0", Offset = "0x7832DD0", VA = "0x1878339D0", Slot = "6")]
	public bool Equals(JNDIEILAMAP KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x79E5B90", Offset = "0x79E4F90", VA = "0x1879E5B90", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9E04A0", Offset = "0x9DF8A0", VA = "0x1809E04A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct NAGNGMNEHAO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity EOGFPKLNIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public KKDMKJIEJIF AGBLNEPGFKF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct MKCDHJMNPAO : IEqualityComparer<NAGNGMNEHAO>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static MKCDHJMNPAO AMGMCPILGIN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79E6290", Offset = "0x79E5690", VA = "0x1879E6290", Slot = "4")]
	public bool Equals(NAGNGMNEHAO MEAMPLHPPKP, NAGNGMNEHAO KDELALKKKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x79E62E0", Offset = "0x79E56E0", VA = "0x1879E62E0", Slot = "5")]
	public int GetHashCode(NAGNGMNEHAO BLFGIKOAKOL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct DDPFAMDENEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> CODPILFJFBC;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct NLHDEEBPMGK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> CODPILFJFBC;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct DCGKFLOPPCB : ISystemStateBufferElementData, IBufferElementData, PPOOIPHJPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity MEJGBNNCEJE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity GPIMNMHDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xE3A760", Offset = "0xE39B60", VA = "0x180E3A760", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class MOBMLHNPCGD : ContainerPropertyBag<FMKLDLNGAGF>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class INKMLIPKIAP : Property<FMKLDLNGAGF, LHHKKBOIJOC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x79E5960", Offset = "0x79E4D60", VA = "0x1879E5960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x79E5920", Offset = "0x79E4D20", VA = "0x1879E5920")]
		public INKMLIPKIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x79E4020", Offset = "0x79E3420", VA = "0x1879E4020", Slot = "14")]
		public override LHHKKBOIJOC GetValue(FMKLDLNGAGF NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x79E4040", Offset = "0x79E3440", VA = "0x1879E4040", Slot = "15")]
		public override void SetValue(FMKLDLNGAGF NKMJDOBLHGP, LHHKKBOIJOC FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x79E6380", Offset = "0x79E5780", VA = "0x1879E6380")]
	public MOBMLHNPCGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class FMJABHDEFPP : ContainerPropertyBag<GIMJEBIFLNH>
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class NGLIAGIMJKG : Property<GIMJEBIFLNH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x79E64C0", Offset = "0x79E58C0", VA = "0x1879E64C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x79E6480", Offset = "0x79E5880", VA = "0x1879E6480")]
		public NGLIAGIMJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x79E4020", Offset = "0x79E3420", VA = "0x1879E4020", Slot = "14")]
		public override GameObject GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x79E4040", Offset = "0x79E3440", VA = "0x1879E4040", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, GameObject FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class NPBNHNMFPDA : Property<GIMJEBIFLNH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x79E65F0", Offset = "0x79E59F0", VA = "0x1879E65F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x79E65B0", Offset = "0x79E59B0", VA = "0x1879E65B0")]
		public NPBNHNMFPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x79E6560", Offset = "0x79E5960", VA = "0x1879E6560", Slot = "14")]
		public override object GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x79E6580", Offset = "0x79E5980", VA = "0x1879E6580", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, object FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class BADKPKDLJKL : Property<GIMJEBIFLNH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x79E3BC0", Offset = "0x79E2FC0", VA = "0x1879E3BC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x79E3B80", Offset = "0x79E2F80", VA = "0x1879E3B80")]
		public BADKPKDLJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x79E3B30", Offset = "0x79E2F30", VA = "0x1879E3B30", Slot = "14")]
		public override object GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x79E3B50", Offset = "0x79E2F50", VA = "0x1879E3B50", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, object FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class CBLIAKJANGL : Property<GIMJEBIFLNH, EALHJCEOOHG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x79E4200", Offset = "0x79E3600", VA = "0x1879E4200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x79E41C0", Offset = "0x79E35C0", VA = "0x1879E41C0")]
		public CBLIAKJANGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x79E4170", Offset = "0x79E3570", VA = "0x1879E4170", Slot = "14")]
		public override EALHJCEOOHG GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x79E4190", Offset = "0x79E3590", VA = "0x1879E4190", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, EALHJCEOOHG FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class CCKHIIFFNFP : Property<GIMJEBIFLNH, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x79E42C0", Offset = "0x79E36C0", VA = "0x1879E42C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x79E4280", Offset = "0x79E3680", VA = "0x1879E4280")]
		public CCKHIIFFNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x79E4230", Offset = "0x79E3630", VA = "0x1879E4230", Slot = "14")]
		public override Delegate GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x79E4250", Offset = "0x79E3650", VA = "0x1879E4250", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, Delegate FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class EFLPHCLMGCP : Property<GIMJEBIFLNH, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x79E48B0", Offset = "0x79E3CB0", VA = "0x1879E48B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x79E4870", Offset = "0x79E3C70", VA = "0x1879E4870")]
		public EFLPHCLMGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x79E4820", Offset = "0x79E3C20", VA = "0x1879E4820", Slot = "14")]
		public override Delegate GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x79E4840", Offset = "0x79E3C40", VA = "0x1879E4840", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, Delegate FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class CEOBKCIFPEE : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x79E43F0", Offset = "0x79E37F0", VA = "0x1879E43F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x79E43B0", Offset = "0x79E37B0", VA = "0x1879E43B0")]
		public CEOBKCIFPEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x79E4360", Offset = "0x79E3760", VA = "0x1879E4360", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x79E4380", Offset = "0x79E3780", VA = "0x1879E4380", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class LNLNHMIDAIC : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x79E6090", Offset = "0x79E5490", VA = "0x1879E6090", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x79E6050", Offset = "0x79E5450", VA = "0x1879E6050")]
		public LNLNHMIDAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x79E6000", Offset = "0x79E5400", VA = "0x1879E6000", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x79E6020", Offset = "0x79E5420", VA = "0x1879E6020", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class OHIKBOIPOIA : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x79E6780", Offset = "0x79E5B80", VA = "0x1879E6780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x79E6740", Offset = "0x79E5B40", VA = "0x1879E6740")]
		public OHIKBOIPOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x79E66F0", Offset = "0x79E5AF0", VA = "0x1879E66F0", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x79E6710", Offset = "0x79E5B10", VA = "0x1879E6710", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class JALHEBHDEGF : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x79E5A20", Offset = "0x79E4E20", VA = "0x1879E5A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x79E59E0", Offset = "0x79E4DE0", VA = "0x1879E59E0")]
		public JALHEBHDEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x79E5990", Offset = "0x79E4D90", VA = "0x1879E5990", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x79E59B0", Offset = "0x79E4DB0", VA = "0x1879E59B0", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class MDCDANIADPL : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x79E6180", Offset = "0x79E5580", VA = "0x1879E6180", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x79E6140", Offset = "0x79E5540", VA = "0x1879E6140")]
		public MDCDANIADPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x79E60F0", Offset = "0x79E54F0", VA = "0x1879E60F0", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x79E6110", Offset = "0x79E5510", VA = "0x1879E6110", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class KHGDHBOPEAO : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x79E5ED0", Offset = "0x79E52D0", VA = "0x1879E5ED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x79E5E90", Offset = "0x79E5290", VA = "0x1879E5E90")]
		public KHGDHBOPEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x79E5E40", Offset = "0x79E5240", VA = "0x1879E5E40", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x79E5E60", Offset = "0x79E5260", VA = "0x1879E5E60", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class BDMFKKMFJEG : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x79E3C80", Offset = "0x79E3080", VA = "0x1879E3C80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x79E3C40", Offset = "0x79E3040", VA = "0x1879E3C40")]
		public BDMFKKMFJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x79E3BF0", Offset = "0x79E2FF0", VA = "0x1879E3BF0", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x79E3C10", Offset = "0x79E3010", VA = "0x1879E3C10", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class DFGFIFOOEDA : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x79E4660", Offset = "0x79E3A60", VA = "0x1879E4660", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x79E4620", Offset = "0x79E3A20", VA = "0x1879E4620")]
		public DFGFIFOOEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x79E45D0", Offset = "0x79E39D0", VA = "0x1879E45D0", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x79E45F0", Offset = "0x79E39F0", VA = "0x1879E45F0", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class OHCECFGEICJ : Property<GIMJEBIFLNH, LEHDJFKJBJH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x79E66C0", Offset = "0x79E5AC0", VA = "0x1879E66C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x79E6680", Offset = "0x79E5A80", VA = "0x1879E6680")]
		public OHCECFGEICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79E6630", Offset = "0x79E5A30", VA = "0x1879E6630", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x79E6650", Offset = "0x79E5A50", VA = "0x1879E6650", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x79E49B0", Offset = "0x79E3DB0", VA = "0x1879E49B0")]
	public FMJABHDEFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class FCOHPHBJMCC : ContainerPropertyBag<LEHDJFKJBJH<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x79E48E0", Offset = "0x79E3CE0", VA = "0x1879E48E0")]
	public FCOHPHBJMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class MEFEPELFCGE : ContainerPropertyBag<HCLHNIJDCJE>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class JPGGCBEHICO : Property<HCLHNIJDCJE, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x79E5CE0", Offset = "0x79E50E0", VA = "0x1879E5CE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x79E5CA0", Offset = "0x79E50A0", VA = "0x1879E5CA0")]
		public JPGGCBEHICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x79E4020", Offset = "0x79E3420", VA = "0x1879E4020", Slot = "14")]
		public override Rigidbody GetValue(HCLHNIJDCJE NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x79E4040", Offset = "0x79E3440", VA = "0x1879E4040", Slot = "15")]
		public override void SetValue(HCLHNIJDCJE NKMJDOBLHGP, Rigidbody FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x79E61B0", Offset = "0x79E55B0", VA = "0x1879E61B0")]
	public MEFEPELFCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class IBBAJPHBDLC : ContainerPropertyBag<NGMMAJCKEMH>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class BMOCGHLBLJH : Property<NGMMAJCKEMH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x79E40B0", Offset = "0x79E34B0", VA = "0x1879E40B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x79E4070", Offset = "0x79E3470", VA = "0x1879E4070")]
		public BMOCGHLBLJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x79E4020", Offset = "0x79E3420", VA = "0x1879E4020", Slot = "14")]
		public override object GetValue(NGMMAJCKEMH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x79E4040", Offset = "0x79E3440", VA = "0x1879E4040", Slot = "15")]
		public override void SetValue(NGMMAJCKEMH NKMJDOBLHGP, object FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x79E5450", Offset = "0x79E4850", VA = "0x1879E5450")]
	public IBBAJPHBDLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class EEHJFOJPLPC : ContainerPropertyBag<CGIDDAJCAJJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class FJPKHMKIMKM : Property<CGIDDAJCAJJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x79E4980", Offset = "0x79E3D80", VA = "0x1879E4980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x79E4940", Offset = "0x79E3D40", VA = "0x1879E4940")]
		public FJPKHMKIMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x79E4020", Offset = "0x79E3420", VA = "0x1879E4020", Slot = "14")]
		public override object GetValue(CGIDDAJCAJJ NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x79E4040", Offset = "0x79E3440", VA = "0x1879E4040", Slot = "15")]
		public override void SetValue(CGIDDAJCAJJ NKMJDOBLHGP, object FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x79E4740", Offset = "0x79E3B40", VA = "0x1879E4740")]
	public EEHJFOJPLPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class FOLKPMCJFAO : ContainerPropertyBag<CNFGHKKDMCI>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class ILEOHBALAMG : Property<CNFGHKKDMCI, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x79E58F0", Offset = "0x79E4CF0", VA = "0x1879E58F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x79E58B0", Offset = "0x79E4CB0", VA = "0x1879E58B0")]
		public ILEOHBALAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xDB5FA0", Offset = "0xDB53A0", VA = "0x180DB5FA0", Slot = "14")]
		public override Entity GetValue(CNFGHKKDMCI NKMJDOBLHGP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x79E58A0", Offset = "0x79E4CA0", VA = "0x1879E58A0", Slot = "15")]
		public override void SetValue(CNFGHKKDMCI NKMJDOBLHGP, Entity FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x79E5080", Offset = "0x79E4480", VA = "0x1879E5080")]
	public FOLKPMCJFAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class CPEFPBCBOHB : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class CDHAGGPBDFM : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x79E4330", Offset = "0x79E3730", VA = "0x1879E4330", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x79E42F0", Offset = "0x79E36F0", VA = "0x1879E42F0")]
		public CDHAGGPBDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2049D90", Offset = "0x2049190", VA = "0x182049D90", Slot = "14")]
		public override int GetValue(Entity NKMJDOBLHGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x782EEE0", Offset = "0x782E2E0", VA = "0x18782EEE0", Slot = "15")]
		public override void SetValue(Entity NKMJDOBLHGP, int FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class JOCMKHCNECI : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string KAFLMFCDNKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x79E5C70", Offset = "0x79E5070", VA = "0x1879E5C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x79E5C30", Offset = "0x79E5030", VA = "0x1879E5C30")]
		public JOCMKHCNECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xE45EB0", Offset = "0xE452B0", VA = "0x180E45EB0", Slot = "14")]
		public override int GetValue(Entity NKMJDOBLHGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x79E5C20", Offset = "0x79E5020", VA = "0x1879E5C20", Slot = "15")]
		public override void SetValue(Entity NKMJDOBLHGP, int FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x79E4490", Offset = "0x79E3890", VA = "0x1879E4490")]
	public CPEFPBCBOHB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x79E67B0", Offset = "0x79E5BB0", VA = "0x1879E67B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class PLEFJCMKMIM
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public PLEFJCMKMIM()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
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

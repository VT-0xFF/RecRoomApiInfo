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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A34A50", Offset = "0x7A33E50", VA = "0x187A34A50", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A34DE0", Offset = "0x7A341E0", VA = "0x187A34DE0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
			[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A316B0", Offset = "0x7A30AB0", VA = "0x187A316B0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A33290", Offset = "0x7A32690", VA = "0x187A33290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A330C0", Offset = "0x7A324C0", VA = "0x187A330C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x58EF2F0", Offset = "0x58EE6F0", VA = "0x1858EF2F0")]
	public ICCFMKCGDLD(NativeList<MEAPDDCLFEN> PDCKCKOILPI, NativeList<Entity> MIFKLFMOHMG, JobHandle CNINKJDDJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A33170", Offset = "0x7A32570", VA = "0x187A33170")]
	public (Entity, NativeSlice<Entity>) HALHDKGPDIP(int JKHIIFLAPEC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A33110", Offset = "0x7A32510", VA = "0x187A33110", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A31B60", Offset = "0x7A30F60", VA = "0x187A31B60")]
	public BGHKFKGEOFE(FECKIEFHJNO KHCEBCMPDGO, OBDELGJAHLB FCKLOAIGGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A31B30", Offset = "0x7A30F30", VA = "0x187A31B30")]
	public BGHKFKGEOFE(bool MONBMGDPFNH, bool GHKECLPALPC, bool NPBNHOFNPPP, bool HLIGGHACBNP, OBDELGJAHLB FCKLOAIGGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A31870", Offset = "0x7A30C70", VA = "0x187A31870")]
	public bool EMOMEOJILAH(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A31A20", Offset = "0x7A30E20", VA = "0x187A31A20")]
	public bool IFBFFBLIMNM(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A31840", Offset = "0x7A30C40", VA = "0x187A31840")]
	public bool BEBBJCAEFNG(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A31A50", Offset = "0x7A30E50", VA = "0x187A31A50")]
	public bool LKLIHOIMMOD(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A31950", Offset = "0x7A30D50", VA = "0x187A31950", Slot = "4")]
	public bool Equals(BGHKFKGEOFE KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A318A0", Offset = "0x7A30CA0", VA = "0x187A318A0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A31980", Offset = "0x7A30D80", VA = "0x187A31980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A31A80", Offset = "0x7A30E80", VA = "0x187A31A80")]
	private bool MEBGCNHBLHC(int GIBMIJMGIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A31AA0", Offset = "0x7A30EA0", VA = "0x187A31AA0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A31CB0", Offset = "0x7A310B0", VA = "0x187A31CB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A32BA0", Offset = "0x7A31FA0", VA = "0x187A32BA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CA0120", Offset = "0x2C9F520", VA = "0x182CA0120")]
	public HKMNOCHMDIB(MHFDPAMPHHI LHPKDMOOJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A32F60", Offset = "0x7A32360", VA = "0x187A32F60")]
	public HKMNOCHMDIB AECMHBOBEAO(MHFDPAMPHHI OABEHMABAGN)
	{
		return default(HKMNOCHMDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A32F70", Offset = "0x7A32370", VA = "0x187A32F70")]
	public HKMNOCHMDIB BOBAJLLHLGJ(MHFDPAMPHHI EBFCDCACDOC)
	{
		return default(HKMNOCHMDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A32F80", Offset = "0x7A32380", VA = "0x187A32F80", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A33C30", Offset = "0x7A33030", VA = "0x187A33C30")]
	public bool FINOCNONADG(HKMNOCHMDIB MLGNKPAOBIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A33C40", Offset = "0x7A33040", VA = "0x187A33C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A339A0", Offset = "0x7A32DA0", VA = "0x187A339A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A339B0", Offset = "0x7A32DB0", VA = "0x187A339B0")]
	private KGIDBBPDDNC(AFDCOIHPMIL LHPKDMOOJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A33960", Offset = "0x7A32D60", VA = "0x187A33960")]
	public KGIDBBPDDNC AECMHBOBEAO(AFDCOIHPMIL OABEHMABAGN)
	{
		return default(KGIDBBPDDNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A33980", Offset = "0x7A32D80", VA = "0x187A33980")]
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
			[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A316B0", Offset = "0x7A30AB0", VA = "0x187A316B0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
	public GEIHJCOIKJE(BCEABACEBEP NCMOPCAHFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A32CF0", Offset = "0x7A320F0", VA = "0x187A32CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D45E10", Offset = "0x1D45210", VA = "0x181D45E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A34190", Offset = "0x7A33590", VA = "0x187A34190")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A316B0", Offset = "0x7A30AB0", VA = "0x187A316B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BJFJLFKBJFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A32D60", Offset = "0x7A32160", VA = "0x187A32D60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D45E10", Offset = "0x1D45210", VA = "0x181D45E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A32E60", Offset = "0x7A32260", VA = "0x187A32E60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A34060", Offset = "0x7A33460", VA = "0x187A34060", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A31FB0", Offset = "0x7A313B0", VA = "0x187A31FB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A32F10", Offset = "0x7A32310", VA = "0x187A32F10", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
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
	[Cpp2IlInjected.Address(RVA = "0xBDB660", Offset = "0xBDAA60", VA = "0x180BDB660")]
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
	[Cpp2IlInjected.Address(RVA = "0x78807C0", Offset = "0x787FBC0", VA = "0x1878807C0", Slot = "4")]
	public bool Equals(KFIOKIEHCFB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A338D0", Offset = "0x7A32CD0", VA = "0x187A338D0", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A33FD0", Offset = "0x7A333D0", VA = "0x187A33FD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A33FE0", Offset = "0x7A333E0", VA = "0x187A33FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x78807C0", Offset = "0x787FBC0", VA = "0x1878807C0", Slot = "6")]
	public bool Equals(JNDIEILAMAP KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A33710", Offset = "0x7A32B10", VA = "0x187A33710", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9F6640", Offset = "0x9F5A40", VA = "0x1809F6640", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0x7A33E00", Offset = "0x7A33200", VA = "0x187A33E00", Slot = "4")]
	public bool Equals(NAGNGMNEHAO MEAMPLHPPKP, NAGNGMNEHAO KDELALKKKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A33E50", Offset = "0x7A33250", VA = "0x187A33E50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xC747C0", Offset = "0xC73BC0", VA = "0x180C747C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xE3ECA0", Offset = "0xE3E0A0", VA = "0x180E3ECA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A334F0", Offset = "0x7A328F0", VA = "0x187A334F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7A334B0", Offset = "0x7A328B0", VA = "0x187A334B0")]
		public INKMLIPKIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BB0", Offset = "0x7A30FB0", VA = "0x187A31BB0", Slot = "14")]
		public override LHHKKBOIJOC GetValue(FMKLDLNGAGF NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BD0", Offset = "0x7A30FD0", VA = "0x187A31BD0", Slot = "15")]
		public override void SetValue(FMKLDLNGAGF NKMJDOBLHGP, LHHKKBOIJOC FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A33EF0", Offset = "0x7A332F0", VA = "0x187A33EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A34030", Offset = "0x7A33430", VA = "0x187A34030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A33FF0", Offset = "0x7A333F0", VA = "0x187A33FF0")]
		public NGLIAGIMJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BB0", Offset = "0x7A30FB0", VA = "0x187A31BB0", Slot = "14")]
		public override GameObject GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BD0", Offset = "0x7A30FD0", VA = "0x187A31BD0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A34160", Offset = "0x7A33560", VA = "0x187A34160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7A34120", Offset = "0x7A33520", VA = "0x187A34120")]
		public NPBNHNMFPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7A340D0", Offset = "0x7A334D0", VA = "0x187A340D0", Slot = "14")]
		public override object GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7A340F0", Offset = "0x7A334F0", VA = "0x187A340F0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A31750", Offset = "0x7A30B50", VA = "0x187A31750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7A31710", Offset = "0x7A30B10", VA = "0x187A31710")]
		public BADKPKDLJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7A316C0", Offset = "0x7A30AC0", VA = "0x187A316C0", Slot = "14")]
		public override object GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A316E0", Offset = "0x7A30AE0", VA = "0x187A316E0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A31D90", Offset = "0x7A31190", VA = "0x187A31D90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7A31D50", Offset = "0x7A31150", VA = "0x187A31D50")]
		public CBLIAKJANGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A31D00", Offset = "0x7A31100", VA = "0x187A31D00", Slot = "14")]
		public override EALHJCEOOHG GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A31D20", Offset = "0x7A31120", VA = "0x187A31D20", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A31E50", Offset = "0x7A31250", VA = "0x187A31E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A31E10", Offset = "0x7A31210", VA = "0x187A31E10")]
		public CCKHIIFFNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7A31DC0", Offset = "0x7A311C0", VA = "0x187A31DC0", Slot = "14")]
		public override Delegate GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A31DE0", Offset = "0x7A311E0", VA = "0x187A31DE0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A32440", Offset = "0x7A31840", VA = "0x187A32440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7A32400", Offset = "0x7A31800", VA = "0x187A32400")]
		public EFLPHCLMGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A323B0", Offset = "0x7A317B0", VA = "0x187A323B0", Slot = "14")]
		public override Delegate GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7A323D0", Offset = "0x7A317D0", VA = "0x187A323D0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A31F80", Offset = "0x7A31380", VA = "0x187A31F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7A31F40", Offset = "0x7A31340", VA = "0x187A31F40")]
		public CEOBKCIFPEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7A31EF0", Offset = "0x7A312F0", VA = "0x187A31EF0", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7A31F10", Offset = "0x7A31310", VA = "0x187A31F10", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A33C00", Offset = "0x7A33000", VA = "0x187A33C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7A33BC0", Offset = "0x7A32FC0", VA = "0x187A33BC0")]
		public LNLNHMIDAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A33B70", Offset = "0x7A32F70", VA = "0x187A33B70", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A33B90", Offset = "0x7A32F90", VA = "0x187A33B90", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A342F0", Offset = "0x7A336F0", VA = "0x187A342F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7A342B0", Offset = "0x7A336B0", VA = "0x187A342B0")]
		public OHIKBOIPOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7A34260", Offset = "0x7A33660", VA = "0x187A34260", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7A34280", Offset = "0x7A33680", VA = "0x187A34280", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A335B0", Offset = "0x7A329B0", VA = "0x187A335B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A33570", Offset = "0x7A32970", VA = "0x187A33570")]
		public JALHEBHDEGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A33520", Offset = "0x7A32920", VA = "0x187A33520", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A33540", Offset = "0x7A32940", VA = "0x187A33540", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A33CF0", Offset = "0x7A330F0", VA = "0x187A33CF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A33CB0", Offset = "0x7A330B0", VA = "0x187A33CB0")]
		public MDCDANIADPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A33C60", Offset = "0x7A33060", VA = "0x187A33C60", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A33C80", Offset = "0x7A33080", VA = "0x187A33C80", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A33A50", Offset = "0x7A32E50", VA = "0x187A33A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A33A10", Offset = "0x7A32E10", VA = "0x187A33A10")]
		public KHGDHBOPEAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A339C0", Offset = "0x7A32DC0", VA = "0x187A339C0", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A339E0", Offset = "0x7A32DE0", VA = "0x187A339E0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A31810", Offset = "0x7A30C10", VA = "0x187A31810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A317D0", Offset = "0x7A30BD0", VA = "0x187A317D0")]
		public BDMFKKMFJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A31780", Offset = "0x7A30B80", VA = "0x187A31780", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A317A0", Offset = "0x7A30BA0", VA = "0x187A317A0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A321F0", Offset = "0x7A315F0", VA = "0x187A321F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A321B0", Offset = "0x7A315B0", VA = "0x187A321B0")]
		public DFGFIFOOEDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A32160", Offset = "0x7A31560", VA = "0x187A32160", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A32180", Offset = "0x7A31580", VA = "0x187A32180", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A34230", Offset = "0x7A33630", VA = "0x187A34230", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A341F0", Offset = "0x7A335F0", VA = "0x187A341F0")]
		public OHCECFGEICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A341A0", Offset = "0x7A335A0", VA = "0x187A341A0", Slot = "14")]
		public override LEHDJFKJBJH<Delegate> GetValue(GIMJEBIFLNH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A341C0", Offset = "0x7A335C0", VA = "0x187A341C0", Slot = "15")]
		public override void SetValue(GIMJEBIFLNH NKMJDOBLHGP, LEHDJFKJBJH<Delegate> FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7A32540", Offset = "0x7A31940", VA = "0x187A32540")]
	public FMJABHDEFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class FCOHPHBJMCC : ContainerPropertyBag<LEHDJFKJBJH<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A32470", Offset = "0x7A31870", VA = "0x187A32470")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A33860", Offset = "0x7A32C60", VA = "0x187A33860", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A33820", Offset = "0x7A32C20", VA = "0x187A33820")]
		public JPGGCBEHICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BB0", Offset = "0x7A30FB0", VA = "0x187A31BB0", Slot = "14")]
		public override Rigidbody GetValue(HCLHNIJDCJE NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BD0", Offset = "0x7A30FD0", VA = "0x187A31BD0", Slot = "15")]
		public override void SetValue(HCLHNIJDCJE NKMJDOBLHGP, Rigidbody FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A33D20", Offset = "0x7A33120", VA = "0x187A33D20")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A31C40", Offset = "0x7A31040", VA = "0x187A31C40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A31C00", Offset = "0x7A31000", VA = "0x187A31C00")]
		public BMOCGHLBLJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BB0", Offset = "0x7A30FB0", VA = "0x187A31BB0", Slot = "14")]
		public override object GetValue(NGMMAJCKEMH NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BD0", Offset = "0x7A30FD0", VA = "0x187A31BD0", Slot = "15")]
		public override void SetValue(NGMMAJCKEMH NKMJDOBLHGP, object FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A32FE0", Offset = "0x7A323E0", VA = "0x187A32FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A32510", Offset = "0x7A31910", VA = "0x187A32510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A324D0", Offset = "0x7A318D0", VA = "0x187A324D0")]
		public FJPKHMKIMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BB0", Offset = "0x7A30FB0", VA = "0x187A31BB0", Slot = "14")]
		public override object GetValue(CGIDDAJCAJJ NKMJDOBLHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7A31BD0", Offset = "0x7A30FD0", VA = "0x187A31BD0", Slot = "15")]
		public override void SetValue(CGIDDAJCAJJ NKMJDOBLHGP, object FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A322D0", Offset = "0x7A316D0", VA = "0x187A322D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A33480", Offset = "0x7A32880", VA = "0x187A33480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7A33440", Offset = "0x7A32840", VA = "0x187A33440")]
		public ILEOHBALAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xDBA790", Offset = "0xDB9B90", VA = "0x180DBA790", Slot = "14")]
		public override Entity GetValue(CNFGHKKDMCI NKMJDOBLHGP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7A33430", Offset = "0x7A32830", VA = "0x187A33430", Slot = "15")]
		public override void SetValue(CNFGHKKDMCI NKMJDOBLHGP, Entity FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A32C10", Offset = "0x7A32010", VA = "0x187A32C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A31EC0", Offset = "0x7A312C0", VA = "0x187A31EC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A31E80", Offset = "0x7A31280", VA = "0x187A31E80")]
		public CDHAGGPBDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2055A00", Offset = "0x2054E00", VA = "0x182055A00", Slot = "14")]
		public override int GetValue(Entity NKMJDOBLHGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x787BCE0", Offset = "0x787B0E0", VA = "0x18787BCE0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A337F0", Offset = "0x7A32BF0", VA = "0x187A337F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool HMHCPPJANGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A337B0", Offset = "0x7A32BB0", VA = "0x187A337B0")]
		public JOCMKHCNECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xE49D40", Offset = "0xE49140", VA = "0x180E49D40", Slot = "14")]
		public override int GetValue(Entity NKMJDOBLHGP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A337A0", Offset = "0x7A32BA0", VA = "0x187A337A0", Slot = "15")]
		public override void SetValue(Entity NKMJDOBLHGP, int FFOEEMKIKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A32020", Offset = "0x7A31420", VA = "0x187A32020")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A34320", Offset = "0x7A33720", VA = "0x187A34320")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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

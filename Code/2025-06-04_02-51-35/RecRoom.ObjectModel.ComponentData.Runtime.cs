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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x814ED60", Offset = "0x814D560", VA = "0x18814ED60", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x814F0F0", Offset = "0x814D8F0", VA = "0x18814F0F0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct DNMBPFIPIOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct GCBLFEOJNEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct ECDJBHGHOJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct MEGLMMNCJKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct GMMNDPDNMAM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, FLIJOCAGNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x814BE80", Offset = "0x814A680", VA = "0x18814BE80", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct KEEEPDDLOPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct EJPFKJDPEHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct ACCLGALFKDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity ECDCBMOANKL;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct IHLOEGHHNNH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity ECDCBMOANKL;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct DMAODNGMMLE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<FIOMPBCHECM> GBLMBDPBDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> GLHKCACHPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle GGAIACICGIO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AGNMEGAEAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x814C930", Offset = "0x814B130", VA = "0x18814C930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x814C8E0", Offset = "0x814B0E0", VA = "0x18814C8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC5A0", Offset = "0x5EBADA0", VA = "0x185EBC5A0")]
	public DMAODNGMMLE(NativeList<FIOMPBCHECM> GBLMBDPBDGD, NativeList<Entity> GLHKCACHPDE, JobHandle GGAIACICGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x814C7C0", Offset = "0x814AFC0", VA = "0x18814C7C0")]
	public (Entity, NativeSlice<Entity>) HPEFCIIILKK(int CCPDHPNHILC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x814C760", Offset = "0x814AF60", VA = "0x18814C760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FIOMPBCHECM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity MJAMEBJFAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int BJCMHPBMOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int AEPPOMGGPKB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MNLCIJBGECJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDNBAPPDKNN(bool HAPFLJBOLFG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct IPGDFEPIDBP : IEquatable<IPGDFEPIDBP>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool IAMEDNNMJCO(int LFGOLEKPJOL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool FGLNDHIGJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool ADFKNONPHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool OAONLMJOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool LDIONGIFMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IAMEDNNMJCO CLCMPAOELBJ;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x814DAF0", Offset = "0x814C2F0", VA = "0x18814DAF0")]
	public IPGDFEPIDBP(KOIOMAEALHN NMFHGOAHANN, IAMEDNNMJCO CLCMPAOELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x814DB40", Offset = "0x814C340", VA = "0x18814DB40")]
	public IPGDFEPIDBP(bool FGLNDHIGJOO, bool ADFKNONPHPL, bool OAONLMJOPDM, bool LDIONGIFMMO, IAMEDNNMJCO CLCMPAOELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x814DA30", Offset = "0x814C230", VA = "0x18814DA30")]
	public bool MLCMGIPFPBE(int LFGOLEKPJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x814D800", Offset = "0x814C000", VA = "0x18814D800")]
	public bool AOALBLBMLAL(int LFGOLEKPJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x814DA00", Offset = "0x814C200", VA = "0x18814DA00")]
	public bool KPBEGIFILGC(int LFGOLEKPJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x814D9B0", Offset = "0x814C1B0", VA = "0x18814D9B0")]
	public bool HKAIJFHJDKI(int LFGOLEKPJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x814D830", Offset = "0x814C030", VA = "0x18814D830", Slot = "4")]
	public bool Equals(IPGDFEPIDBP KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x814D860", Offset = "0x814C060", VA = "0x18814D860", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x814D910", Offset = "0x814C110", VA = "0x18814D910", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x814D9E0", Offset = "0x814C1E0", VA = "0x18814D9E0")]
	private bool JODKEAAPFGB(int LFGOLEKPJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x814DA60", Offset = "0x814C260", VA = "0x18814DA60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CHNFKBNADFH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public OMNGNIEEKFB CMKGOBJPAMC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x814C230", Offset = "0x814AA30", VA = "0x18814C230", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CHNFKBNADFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OMNGNIEEKFB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct BMCKOKOAJBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct LLJFNMEPENN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly OJALPHELFNC KHEGDAFCGHP;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F14EA0", Offset = "0x2F136A0", VA = "0x182F14EA0")]
	public LLJFNMEPENN(OJALPHELFNC KHEGDAFCGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x814DF10", Offset = "0x814C710", VA = "0x18814DF10")]
	public LLJFNMEPENN AIMOKPHOMFM(OJALPHELFNC HIODFMDMINH)
	{
		return default(LLJFNMEPENN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x814DF20", Offset = "0x814C720", VA = "0x18814DF20")]
	public LLJFNMEPENN BPPCPFGMMLB(OJALPHELFNC DGILGJFEPFE)
	{
		return default(LLJFNMEPENN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x814DF30", Offset = "0x814C730", VA = "0x18814DF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Flags]
public enum OJALPHELFNC : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ReferredToByGroup = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GOGDCOLKBMA
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct ELBJPNINJBG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public OJALPHELFNC APNIDIECMJK;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x814CB50", Offset = "0x814B350", VA = "0x18814CB50")]
	public bool EPBNPNAMBDC(LLJFNMEPENN KLOIKONCKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x814CB30", Offset = "0x814B330", VA = "0x18814CB30")]
	public bool BHODIBKAOAB(LLJFNMEPENN KLOIKONCKDK, OJALPHELFNC JKHBCNOKKEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum LHIONIIFLBJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct NAHKLDBODKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public LHIONIIFLBJ KHEGDAFCGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool JELEANBPOJL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LLDBBMJFMJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x814E3B0", Offset = "0x814CBB0", VA = "0x18814E3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x814E3C0", Offset = "0x814CBC0", VA = "0x18814E3C0")]
	private NAHKLDBODKH(LHIONIIFLBJ KHEGDAFCGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x814E370", Offset = "0x814CB70", VA = "0x18814E370")]
	public NAHKLDBODKH AIMOKPHOMFM(LHIONIIFLBJ HIODFMDMINH)
	{
		return default(NAHKLDBODKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x814E390", Offset = "0x814CB90", VA = "0x18814E390")]
	public NAHKLDBODKH BPPCPFGMMLB(LHIONIIFLBJ DGILGJFEPFE)
	{
		return default(NAHKLDBODKH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct LMDCPFADOMK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[InternalBufferCapacity(1)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct CADHJHOPEPN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity AJJPCBPCNFG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, FLIJOCAGNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x814BE80", Offset = "0x814A680", VA = "0x18814BE80", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct HMPOHCIGIIM : ISystemStateBufferElementData, IBufferElementData, FLIJOCAGNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity JAOKKIIOCBD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity JDCDJCPFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct KOABKFGAFCK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity DMJNDMPEIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity JMKDHHMPFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity MLJLELODJKD;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct OBAJBNEBFEA<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly bool KBFIABEIPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public uint BCGMJMNLEKN;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool EPCFNPFHOOO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct MNJLDBCLBGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint JIOIDHONOBO;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
	public MNJLDBCLBGP(JKKCHPONOAD JLCFKNGJCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x814E2D0", Offset = "0x814CAD0", VA = "0x18814E2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F60400", Offset = "0x1F5EC00", VA = "0x181F60400")]
	public static MNJLDBCLBGP KEINEINMKGA(JKKCHPONOAD JLCFKNGJCID)
	{
		return default(MNJLDBCLBGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct GPAHBIGDDIB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Entity JAOKKIIOCBD;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct DMOEIKDHHNI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public JKKCHPONOAD MGONBEDEDON;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct CNDDNLLCGOF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity JAOKKIIOCBD;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct DECGBHHFDFI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Guid JMHOEKKPCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int FMGALNGIOGC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct HFCHFJGOLAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int MGONBEDEDON;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct AMEFPPBGCLB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity JAOKKIIOCBD;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct IBPAMPOFOKG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public JKKCHPONOAD MGONBEDEDON;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct LELFCOBPIKI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity JAOKKIIOCBD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct GLCMALLIIBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
[SingletonComponent]
public struct HBPPBEELJOP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int NHMKOPOILJA;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct KOPOBGGKFCF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int FIOLDALLLFF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GBNNBLFIGLH CFFHLJNFCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		get
		{
			return default(GBNNBLFIGLH);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct LCABENNEDGL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public GCHandle JOKCFBBCBCI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct DELDBJBABHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct DKNDBAHEPLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct HJCHNCAAANA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct OMNGJLBJDPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct GHMHMEIAFHN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct CIDOOLDPFJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public int PNJCJGEIDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int EHCBHNLMEHF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x814C2A0", Offset = "0x814AAA0", VA = "0x18814C2A0")]
	public CIDOOLDPFJG(Entity JAOKKIIOCBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct AKJFMLAEIMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public CollisionDetectionMode DBJLGBMEDMD;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct OBGFJHNKMJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public KEIJGPDJMGG CLAAIIANCHA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly OBGFJHNKMJK JMOEBDABFID;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct BIKAPMHKNFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct FJPNNINMGOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct GHMKDAICHNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct MEKEFAAIPED : IBufferElementData, IEquatable<MEKEFAAIPED>, FLIJOCAGNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Entity LNFGEICLAJH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity JHJLAPANHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x814BE80", Offset = "0x814A680", VA = "0x18814BE80", Slot = "4")]
	public bool Equals(MEKEFAAIPED KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct COJBLFOCHBH : IComponentData, FLIJOCAGNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity MJNLMOPPION;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity JHJLAPANHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct ADOFKIAHEMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct OCAMGPCKOID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity MJAMEBJFAIN;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct PEIFLFHJIJI : DNJEBEAAODP, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KAIGLBDFENJ CPFLBKIHGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KAIGLBDFENJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct NEKEFODDLAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float3 ENANGLGEIFI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct BDFKKADLJIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct PEGLGDHNCAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3x3 DFHJECEIBFN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly PEGLGDHNCAL JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct KKPOIDEJLJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float3x3 DFHJECEIBFN;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KKPOIDEJLJB JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct BGNCDLJMMDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 MMCOLPHNMEM;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct IJLIPOLGCMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 FKLEDLNIKJE;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct MEMGGEDCMEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float LCEFIAIHMFG;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly MEMGGEDCMEB JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct GLPIJPABJNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float BBKPNBIPFIH;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly GLPIJPABJNE JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct DMFOFAEPAMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float3 EHOBMIPPFPD;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct EPLBKBKDKNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public CAKMKKHPGOG CKOJAFBCIHC;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct KFJMCMANCHG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity JAOKKIIOCBD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct NMJOONGBLIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct KEPHAFOJJFE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct FEDPHHFCFHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public RigidbodyConstraints HGDOLNEPPLK;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct GEGGDAJGNLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float HOMLIBAIFBF;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly GEGGDAJGNLD JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct BOHOBLOJPOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float HEODOPIDKFA;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class EDCKHCGFOHG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public GameObject EMOLHEPHCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public object FBFFNGMLCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object PGPBHKJAAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public AEGIMLOKCDC AMHLEGGNPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Delegate CFNKGHDHBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate PGEJOICIOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FJODPEEPKJK<Delegate> BHMNANJPAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public FJODPEEPKJK<Delegate> IKKHAOIDFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public FJODPEEPKJK<Delegate> KHLOGEIJBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public FJODPEEPKJK<Delegate> PLOEHGLODBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public FJODPEEPKJK<Delegate> LMCMLNHBIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public FJODPEEPKJK<Delegate> LKBNALGBGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FJODPEEPKJK<Delegate> MJEOAJCIOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FJODPEEPKJK<Delegate> FCONNIOPILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public FJODPEEPKJK<Delegate> JNBGKHBNKDM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x814CAE0", Offset = "0x814B2E0", VA = "0x18814CAE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EDCKHCGFOHG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct BBOBKCCDADN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct PPDNNBCGDCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int LGIFIGKGPPJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1F60400", Offset = "0x1F5EC00", VA = "0x181F60400")]
	public static PPDNNBCGDCF KEINEINMKGA(int MGONBEDEDON)
	{
		return default(PPDNNBCGDCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GAFJOCFEPHC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Rigidbody HNPNGMHGBOO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x814CD70", Offset = "0x814B570", VA = "0x18814CD70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GAFJOCFEPHC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct LNKANPFOIPJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct OHCNFKAOLMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3 CGCEKAJGJHA;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct GEKIAJGKCHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 KFKKLCCOCPA;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct ADAPHHBEMGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float JMBACJNCEKP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly ADAPHHBEMGI JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class ABNFFHCPAIH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public object LDBJEDOPNIC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x814BB50", Offset = "0x814A350", VA = "0x18814BB50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ABNFFHCPAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class IJLBMAHCILM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object MNAGKGCLLDH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x814D790", Offset = "0x814BF90", VA = "0x18814D790", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IJLBMAHCILM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct IOMHCJELHKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct DFHHJLBBNMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct FHNFJBHAKFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct JAJIHJIJLND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct CLCMAPHCNHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct FIAMOAFKBNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct DJIJHDJMALM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct HGOIAFDPAEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct LNGKEMMBBHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct CIJNHGMHGLI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct GJMBHGNJAIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public EGIPCMMOIAA EPFGDLJCLLF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x814CF50", Offset = "0x814B750", VA = "0x18814CF50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct HFACHJINNIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct LMMAFDECDBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct LAGCALBOKCI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct MKKKAMHMLLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes HPANEBBHGAC;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct MHJAPJIJPPB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UnsafeParallelHashMap<EGIPCMMOIAA, Entity> MOIAJFOLIAB;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct EGEFPLBGBEJ : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Entity FGOHPCOCAIB;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct AOJGELCNHGK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity JAOKKIIOCBD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static AOJGELCNHGK KEINEINMKGA(Entity JAOKKIIOCBD)
	{
		return default(AOJGELCNHGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct OAFANIELCCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity EKCLMBODIAC;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct JEIENMDBNIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity EKCLMBODIAC;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct KPHJAOACKJH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity HDEMMCAHGNJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xD02080", Offset = "0xD00880", VA = "0x180D02080")]
	public static KPHJAOACKJH KEINEINMKGA(Entity JAOKKIIOCBD)
	{
		return default(KPHJAOACKJH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct MFNOIKACFOI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct AADPCJPCPHD : IBufferElementData, IEquatable<AADPCJPCPHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity CHENMEEMFFG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E860", Offset = "0x7F4D060", VA = "0x187F4E860", Slot = "4")]
	public bool Equals(AADPCJPCPHD KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x814BA10", Offset = "0x814A210", VA = "0x18814BA10", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct OLDDIGLKOPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public uint EHCBHNLMEHF;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
[SingletonComponent]
internal struct GHEAGBKIPHC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity CJBDHOMMHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public int PNJCJGEIDHG;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct EINFAFFJOAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Entity KLNCEFCFPOE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct ILGEKCKNFGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct LGKDKMFOHAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public uint BCGMJMNLEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int JDEKOOIPACG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
	public LGKDKMFOHAO(uint EBOGPDFLCBL, int APDIMAOJICC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct OCLECLEOFLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct NAMJONKOHCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct DHMHFDMHOFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct KLMIIANAOIF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct KPIJGKBFDEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct FMNNAAJJBBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct JEDPKBFOAPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct CEMACMDDDHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct FBFGMJPKKJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct DJMBAIFMCLM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct NCAELNKMFJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct BAKCKCOJALL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct LOLLCEBIICO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct EAKPMGBBDDG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct HEBHHIKJIED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct PMEMHKAOONI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct MCKCMCDJGGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct KKEIKKGHFAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct EFFKHFHNCOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct NLADFFBNPNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct IOBHNIMILJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct JBEDJDKJKEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct DGMNACIPDID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct MPCBMKCNDOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct AEDBFOCOBLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct DBPFFBGAFME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct NHHMNJBCDBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct KGFMJCHKKNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct MCAOPEALEMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct NLGLCFGNFAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct NLBNOOCGNCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct MCGNIHDCFPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct IHAFJIABDHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[CHLHACDEDBH]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct LEMCFAJJEIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct GIADHDKKKJF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public FixedString32Bytes JIDPAGEBNDJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct FBLCCGFPLFA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct JHEPLNDENAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct IAFLPEMBIIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct ONODDFCNLGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct NIKBAHHDMGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct NADLOEHGLNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct GJOIJEMAHDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct GLEHAIJKLMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public quaternion FENAGHBAFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 KKEEFCOJJFM;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct HILEGFDAABK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float ELAIAAANIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float LJFABJPHLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float AAHIMIIFIOF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct EEMHNBGMIGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct GNJLNFLLBFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct MHFLJDKHEDG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct ILCJEAPIFOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public int FIOLDALLLFF;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
[SingletonComponent]
public struct KHMECIPOHAJ : ISystemStateBufferElementData, IBufferElementData, FLIJOCAGNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity LDIEJDNDIGI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Entity JDCDJCPFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct AAPKHHPHOIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float4x4 LINOGJJPFMH;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly AAPKHHPHOIJ JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct DBGJFJLBANA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float4x4 DJHJNAPODOP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly DBGJFJLBANA JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct DGFJNKKDGAE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int LDDOOLIDCPE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PNJCJGEIDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x814C580", Offset = "0x814AD80", VA = "0x18814C580")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x814C590", Offset = "0x814AD90", VA = "0x18814C590")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct GAJHAHJOOHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public float3 KKEEFCOJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public quaternion FENAGHBAFHI;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly GAJHAHJOOHE JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class BAINBCCNALP
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct ALMIFFANDFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float GKKJBGHLAJO;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly ALMIFFANDFL JMOEBDABFID;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct MLCAJGBDGDE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity LCPLPGNINPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public HANCEIDOMMA ENEFJOLLDHH;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct OBFLGBIGPGH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public HANCEIDOMMA ENEFJOLLDHH;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct LDHLFHBIGDC : ISystemStateComponentData, IComponentData, FLIJOCAGNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity PKBMMFHCONE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity JDCDJCPFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct HJAPNIFMCKP : ISystemStateBufferElementData, IBufferElementData, FLIJOCAGNHH, IEquatable<HJAPNIFMCKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity FAAIPLCLOKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity JDCDJCPFDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E860", Offset = "0x7F4D060", VA = "0x187F4E860", Slot = "6")]
	public bool Equals(HJAPNIFMCKP KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x814CFE0", Offset = "0x814B7E0", VA = "0x18814CFE0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct LJBJFHMLAAP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity LCPLPGNINPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public HANCEIDOMMA ENEFJOLLDHH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct KNGHENAHAIB : IEqualityComparer<LJBJFHMLAAP>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static KNGHENAHAIB JMOEBDABFID;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x814DE00", Offset = "0x814C600", VA = "0x18814DE00", Slot = "4")]
	public bool Equals(LJBJFHMLAAP BDGPJOKJNIL, LJBJFHMLAAP HDAFCDJNHAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x814DE50", Offset = "0x814C650", VA = "0x18814DE50", Slot = "5")]
	public int GetHashCode(LJBJFHMLAAP HPLLAPMNIJF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct CGEHKOBNBKC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public FixedList32Bytes<int> LKKCBIFCBED;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct HFFOEHJCEBP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> LKKCBIFCBED;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct FPNINIIDLGF : ISystemStateBufferElementData, IBufferElementData, FLIJOCAGNHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Entity DFCLHAFLLGC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Entity JHJLAPANHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x128A850", Offset = "0x1289050", VA = "0x18128A850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class DKDEMLCNIFC : ContainerPropertyBag<CHNFKBNADFH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class NACMMBHDPHP : Property<CHNFKBNADFH, OMNGNIEEKFB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x814E340", Offset = "0x814CB40", VA = "0x18814E340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x814E300", Offset = "0x814CB00", VA = "0x18814E300")]
		public NACMMBHDPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x814BDC0", Offset = "0x814A5C0", VA = "0x18814BDC0", Slot = "14")]
		public override OMNGNIEEKFB GetValue(CHNFKBNADFH MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x814BDE0", Offset = "0x814A5E0", VA = "0x18814BDE0", Slot = "15")]
		public override void SetValue(CHNFKBNADFH MBKOPLBCEJA, OMNGNIEEKFB MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x814C680", Offset = "0x814AE80", VA = "0x18814C680")]
	public DKDEMLCNIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class IBJNPGAOGFK : ContainerPropertyBag<EDCKHCGFOHG>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class ENCAJJPHHPA : Property<EDCKHCGFOHG, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x814CBA0", Offset = "0x814B3A0", VA = "0x18814CBA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x814CB60", Offset = "0x814B360", VA = "0x18814CB60")]
		public ENCAJJPHHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x814BDC0", Offset = "0x814A5C0", VA = "0x18814BDC0", Slot = "14")]
		public override GameObject GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x814BDE0", Offset = "0x814A5E0", VA = "0x18814BDE0", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, GameObject MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class AJAOHOLGDAP : Property<EDCKHCGFOHG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x814BC90", Offset = "0x814A490", VA = "0x18814BC90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x814BC50", Offset = "0x814A450", VA = "0x18814BC50")]
		public AJAOHOLGDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x814BC00", Offset = "0x814A400", VA = "0x18814BC00", Slot = "14")]
		public override object GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x814BC20", Offset = "0x814A420", VA = "0x18814BC20", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, object MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class BFAJODPIJJM : Property<EDCKHCGFOHG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x814C060", Offset = "0x814A860", VA = "0x18814C060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x814C020", Offset = "0x814A820", VA = "0x18814C020")]
		public BFAJODPIJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x814BFD0", Offset = "0x814A7D0", VA = "0x18814BFD0", Slot = "14")]
		public override object GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x814BFF0", Offset = "0x814A7F0", VA = "0x18814BFF0", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, object MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class EDCAPLEDOJC : Property<EDCKHCGFOHG, AEGIMLOKCDC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x814CAB0", Offset = "0x814B2B0", VA = "0x18814CAB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x814CA70", Offset = "0x814B270", VA = "0x18814CA70")]
		public EDCAPLEDOJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x814CA20", Offset = "0x814B220", VA = "0x18814CA20", Slot = "14")]
		public override AEGIMLOKCDC GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x814CA40", Offset = "0x814B240", VA = "0x18814CA40", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, AEGIMLOKCDC MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class MFCFKIEKAKP : Property<EDCKHCGFOHG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x814E2A0", Offset = "0x814CAA0", VA = "0x18814E2A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x814E260", Offset = "0x814CA60", VA = "0x18814E260")]
		public MFCFKIEKAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x814E210", Offset = "0x814CA10", VA = "0x18814E210", Slot = "14")]
		public override Delegate GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x814E230", Offset = "0x814CA30", VA = "0x18814E230", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, Delegate MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class NMBCDHLPOAB : Property<EDCKHCGFOHG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x814E460", Offset = "0x814CC60", VA = "0x18814E460", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x814E420", Offset = "0x814CC20", VA = "0x18814E420")]
		public NMBCDHLPOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x814E3D0", Offset = "0x814CBD0", VA = "0x18814E3D0", Slot = "14")]
		public override Delegate GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x814E3F0", Offset = "0x814CBF0", VA = "0x18814E3F0", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, Delegate MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class JCPBFMKLFDB : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x814DC70", Offset = "0x814C470", VA = "0x18814DC70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x814DC30", Offset = "0x814C430", VA = "0x18814DC30")]
		public JCPBFMKLFDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x814DBE0", Offset = "0x814C3E0", VA = "0x18814DBE0", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x814DC00", Offset = "0x814C400", VA = "0x18814DC00", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class CBHNDPHINCL : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x814C200", Offset = "0x814AA00", VA = "0x18814C200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x814C1C0", Offset = "0x814A9C0", VA = "0x18814C1C0")]
		public CBHNDPHINCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x814C170", Offset = "0x814A970", VA = "0x18814C170", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x814C190", Offset = "0x814A990", VA = "0x18814C190", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class AKOPAHNBOKD : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x814BD50", Offset = "0x814A550", VA = "0x18814BD50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x814BD10", Offset = "0x814A510", VA = "0x18814BD10")]
		public AKOPAHNBOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x814BCC0", Offset = "0x814A4C0", VA = "0x18814BCC0", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x814BCE0", Offset = "0x814A4E0", VA = "0x18814BCE0", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class FJBFCMIOPPL : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x814CC60", Offset = "0x814B460", VA = "0x18814CC60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x814CC20", Offset = "0x814B420", VA = "0x18814CC20")]
		public FJBFCMIOPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x814CBD0", Offset = "0x814B3D0", VA = "0x18814CBD0", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x814CBF0", Offset = "0x814B3F0", VA = "0x18814CBF0", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class IBKOKBJBOBD : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x814D760", Offset = "0x814BF60", VA = "0x18814D760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x814D720", Offset = "0x814BF20", VA = "0x18814D720")]
		public IBKOKBJBOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x814D6D0", Offset = "0x814BED0", VA = "0x18814D6D0", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x814D6F0", Offset = "0x814BEF0", VA = "0x18814D6F0", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class MEODBEHDICM : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x814E1E0", Offset = "0x814C9E0", VA = "0x18814E1E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x814E1A0", Offset = "0x814C9A0", VA = "0x18814E1A0")]
		public MEODBEHDICM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x814E150", Offset = "0x814C950", VA = "0x18814E150", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x814E170", Offset = "0x814C970", VA = "0x18814E170", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class LMGPELDHBDH : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x814E020", Offset = "0x814C820", VA = "0x18814E020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x814DFE0", Offset = "0x814C7E0", VA = "0x18814DFE0")]
		public LMGPELDHBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x814DF90", Offset = "0x814C790", VA = "0x18814DF90", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x814DFB0", Offset = "0x814C7B0", VA = "0x18814DFB0", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class CNOGFJDBBPD : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x814C4A0", Offset = "0x814ACA0", VA = "0x18814C4A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x814C460", Offset = "0x814AC60", VA = "0x18814C460")]
		public CNOGFJDBBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x814C410", Offset = "0x814AC10", VA = "0x18814C410", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x814C430", Offset = "0x814AC30", VA = "0x18814C430", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class LOPNHLAHEAP : Property<EDCKHCGFOHG, FJODPEEPKJK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x814E0E0", Offset = "0x814C8E0", VA = "0x18814E0E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x814E0A0", Offset = "0x814C8A0", VA = "0x18814E0A0")]
		public LOPNHLAHEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x814E050", Offset = "0x814C850", VA = "0x18814E050", Slot = "14")]
		public override FJODPEEPKJK<Delegate> GetValue(EDCKHCGFOHG MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x814E070", Offset = "0x814C870", VA = "0x18814E070", Slot = "15")]
		public override void SetValue(EDCKHCGFOHG MBKOPLBCEJA, FJODPEEPKJK<Delegate> MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x814D070", Offset = "0x814B870", VA = "0x18814D070")]
	public IBJNPGAOGFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class LCDNOGALGAM : ContainerPropertyBag<FJODPEEPKJK<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x814DEB0", Offset = "0x814C6B0", VA = "0x18814DEB0")]
	public LCDNOGALGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class FNKNODPNIFM : ContainerPropertyBag<GAFJOCFEPHC>
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class APIJIGIBEMJ : Property<GAFJOCFEPHC, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x814BE50", Offset = "0x814A650", VA = "0x18814BE50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x814BE10", Offset = "0x814A610", VA = "0x18814BE10")]
		public APIJIGIBEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x814BDC0", Offset = "0x814A5C0", VA = "0x18814BDC0", Slot = "14")]
		public override Rigidbody GetValue(GAFJOCFEPHC MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x814BDE0", Offset = "0x814A5E0", VA = "0x18814BDE0", Slot = "15")]
		public override void SetValue(GAFJOCFEPHC MBKOPLBCEJA, Rigidbody MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x814CC90", Offset = "0x814B490", VA = "0x18814CC90")]
	public FNKNODPNIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class BMNEPHPGOMI : ContainerPropertyBag<ABNFFHCPAIH>
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class JAOLMAJLNMC : Property<ABNFFHCPAIH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x814DBB0", Offset = "0x814C3B0", VA = "0x18814DBB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x814DB70", Offset = "0x814C370", VA = "0x18814DB70")]
		public JAOLMAJLNMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x814BDC0", Offset = "0x814A5C0", VA = "0x18814BDC0", Slot = "14")]
		public override object GetValue(ABNFFHCPAIH MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x814BDE0", Offset = "0x814A5E0", VA = "0x18814BDE0", Slot = "15")]
		public override void SetValue(ABNFFHCPAIH MBKOPLBCEJA, object MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x814C090", Offset = "0x814A890", VA = "0x18814C090")]
	public BMNEPHPGOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class CNMIKEFAFAC : ContainerPropertyBag<IJLBMAHCILM>
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class KJPLHIOOFOB : Property<IJLBMAHCILM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x814DCE0", Offset = "0x814C4E0", VA = "0x18814DCE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x814DCA0", Offset = "0x814C4A0", VA = "0x18814DCA0")]
		public KJPLHIOOFOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x814BDC0", Offset = "0x814A5C0", VA = "0x18814BDC0", Slot = "14")]
		public override object GetValue(IJLBMAHCILM MBKOPLBCEJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x814BDE0", Offset = "0x814A5E0", VA = "0x18814BDE0", Slot = "15")]
		public override void SetValue(IJLBMAHCILM MBKOPLBCEJA, object MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x814C2B0", Offset = "0x814AAB0", VA = "0x18814C2B0")]
	public CNMIKEFAFAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class DGLGOMEJFLC : ContainerPropertyBag<EGEFPLBGBEJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class CNOBPNHDKGJ : Property<EGEFPLBGBEJ, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x814C3E0", Offset = "0x814ABE0", VA = "0x18814C3E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x814C3A0", Offset = "0x814ABA0", VA = "0x18814C3A0")]
		public CNOBPNHDKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAEDD10", Offset = "0xAEC510", VA = "0x180AEDD10", Slot = "14")]
		public override Entity GetValue(EGEFPLBGBEJ MBKOPLBCEJA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x814C390", Offset = "0x814AB90", VA = "0x18814C390", Slot = "15")]
		public override void SetValue(EGEFPLBGBEJ MBKOPLBCEJA, Entity MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x814C5A0", Offset = "0x814ADA0", VA = "0x18814C5A0")]
	public DGLGOMEJFLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class BAAHOKNJNAA : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class OKBGDEHPBCE : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x814E510", Offset = "0x814CD10", VA = "0x18814E510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x814E4D0", Offset = "0x814CCD0", VA = "0x18814E4D0")]
		public OKBGDEHPBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2287BC0", Offset = "0x22863C0", VA = "0x182287BC0", Slot = "14")]
		public override int GetValue(Entity MBKOPLBCEJA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F49E20", Offset = "0x7F48620", VA = "0x187F49E20", Slot = "15")]
		public override void SetValue(Entity MBKOPLBCEJA, int MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class ECIKEBLPOLO : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x814C9F0", Offset = "0x814B1F0", VA = "0x18814C9F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool FEDAMJDDKCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x814C9B0", Offset = "0x814B1B0", VA = "0x18814C9B0")]
		public ECIKEBLPOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x12614E0", Offset = "0x125FCE0", VA = "0x1812614E0", Slot = "14")]
		public override int GetValue(Entity MBKOPLBCEJA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x814C9A0", Offset = "0x814B1A0", VA = "0x18814C9A0", Slot = "15")]
		public override void SetValue(Entity MBKOPLBCEJA, int MGONBEDEDON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x814BE90", Offset = "0x814A690", VA = "0x18814BE90")]
	public BAAHOKNJNAA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x814E630", Offset = "0x814CE30", VA = "0x18814E630")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class LBHJJCIMPIK
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LBHJJCIMPIK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class RbexHierarchyChildBuffer
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

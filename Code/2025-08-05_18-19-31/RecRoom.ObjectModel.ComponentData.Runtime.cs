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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8465050", Offset = "0x8464450", VA = "0x188465050", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8465400", Offset = "0x8464800", VA = "0x188465400", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct PLKBHHPHGPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct KMANALHAMLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct GMNCAKLHOJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct NFAIDFGAEMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct AHOFBAOKLBD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8461DD0", Offset = "0x84611D0", VA = "0x188461DD0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct NGGFKEPMLEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct BFJALJJMNDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct CIGKOJFKBCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity ODHPOMIHIEL;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct DJGHDPEALEA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity ODHPOMIHIEL;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CBOFCKGDHCL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<PLIPCGEGODP> OAINENKGJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> HFFBIEIKFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle EDPKGAKIIHD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AJBBOECICAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84623F0", Offset = "0x84617F0", VA = "0x1884623F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8462220", Offset = "0x8461620", VA = "0x188462220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6111A40", Offset = "0x6110E40", VA = "0x186111A40")]
	public CBOFCKGDHCL(NativeList<PLIPCGEGODP> OAINENKGJOI, NativeList<Entity> HFFBIEIKFEG, JobHandle EDPKGAKIIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84622D0", Offset = "0x84616D0", VA = "0x1884622D0")]
	public (Entity, NativeSlice<Entity>) EOFFIJHLNMK(int LBMGGFIIAAK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8462270", Offset = "0x8461670", VA = "0x188462270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PLIPCGEGODP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity LDEPDDDHLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int FDIDNNCIDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int COONBEDHJNN;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IBAIAMHIOAO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKNLFIGKOJL(bool JPKBPCJJOHB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GAGBOOCEKHA : IEquatable<GAGBOOCEKHA>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool PFOABIGEDKJ(int CJKINMFPLED);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool FLPBNNBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool JEKOFNKJDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool IPADJFIFOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool KNMKBMJDJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PFOABIGEDKJ DEBOLFBLLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84630A0", Offset = "0x84624A0", VA = "0x1884630A0")]
	public GAGBOOCEKHA(BNADNEMKMMC DPALHGCDOLB, PFOABIGEDKJ DEBOLFBLLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8463070", Offset = "0x8462470", VA = "0x188463070")]
	public GAGBOOCEKHA(bool FLPBNNBIKLF, bool JEKOFNKJDJP, bool IPADJFIFOCE, bool KNMKBMJDJDP, PFOABIGEDKJ DEBOLFBLLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8462DB0", Offset = "0x84621B0", VA = "0x188462DB0")]
	public bool DMDBBBODGCN(int CJKINMFPLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8462F60", Offset = "0x8462360", VA = "0x188462F60")]
	public bool IFCMNAFNCJC(int CJKINMFPLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8462D80", Offset = "0x8462180", VA = "0x188462D80")]
	public bool COIMGFAOJHM(int CJKINMFPLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8462FB0", Offset = "0x84623B0", VA = "0x188462FB0")]
	public bool PHIJIFLLAPG(int CJKINMFPLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8462DE0", Offset = "0x84621E0", VA = "0x188462DE0", Slot = "4")]
	public bool Equals(GAGBOOCEKHA LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8462E10", Offset = "0x8462210", VA = "0x188462E10", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8462EC0", Offset = "0x84622C0", VA = "0x188462EC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8462F90", Offset = "0x8462390", VA = "0x188462F90")]
	private bool MKNNKDAEKEM(int CJKINMFPLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8462FE0", Offset = "0x84623E0", VA = "0x188462FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LJJPLFFHFLI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public BCFFHAFDNGI JDBDJBFOEIE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8463BB0", Offset = "0x8462FB0", VA = "0x188463BB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LJJPLFFHFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BCFFHAFDNGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct EEPFKIFHOMM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity MKBPHNMFJIM;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct ODNAFPJHONE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity LJKGAEGIGKH;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
public struct AGNDBKOJKHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity JFCMNDMMCMC;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct DEENLBKCLDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool BDKIHFGPPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool DCKCAEDMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int FKFOCGJBPFL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct IKIHLMIHJKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
[SingletonComponent]
public struct NMDMDPJNODJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Entity MEOOAHKPJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Entity JBGMEOLEHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Entity AFGEOAKACMJ;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct GMNCMMFPOOC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Entity DKAJEJBIPCD;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct LGMFDKDHGIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 LBCFHLNAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public quaternion EMLGDFFEJED;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct LPFJNABGEHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct DNGGAJFIFIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly DHLLHFOHCNJ LNCHDGGPIOD;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x31899A0", Offset = "0x3188DA0", VA = "0x1831899A0")]
	public DNGGAJFIFIN(DHLLHFOHCNJ LNCHDGGPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8462950", Offset = "0x8461D50", VA = "0x188462950")]
	public DNGGAJFIFIN PGBGNMHAHNM(DHLLHFOHCNJ GHJFIPDNFIH)
	{
		return default(DNGGAJFIFIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8462940", Offset = "0x8461D40", VA = "0x188462940")]
	public DNGGAJFIFIN IFPLHAOCLOO(DHLLHFOHCNJ LJINBOHHMLM)
	{
		return default(DNGGAJFIFIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8462960", Offset = "0x8461D60", VA = "0x188462960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Flags]
public enum DHLLHFOHCNJ : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ReferredToByGroup = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DDBNEDCHAKM
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct APFPLLGEHIM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public DHLLHFOHCNJ LMIPJLKLBLJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8461DC0", Offset = "0x84611C0", VA = "0x188461DC0")]
	public bool PEHNLIHNKMI(DNGGAJFIFIN HPKLOAFPFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8461DA0", Offset = "0x84611A0", VA = "0x188461DA0")]
	public bool NKJNAEHCCNB(DNGGAJFIFIN HPKLOAFPFED, DHLLHFOHCNJ DAJLOLJJBCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum IOGFOGHNJBC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct LCEFIHMDAKL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public IOGFOGHNJBC LNCHDGGPIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public bool GKKNHMEMGDF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OKIJBKMLDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84639F0", Offset = "0x8462DF0", VA = "0x1884639F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8463A20", Offset = "0x8462E20", VA = "0x188463A20")]
	private LCEFIHMDAKL(IOGFOGHNJBC LNCHDGGPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8463A00", Offset = "0x8462E00", VA = "0x188463A00")]
	public LCEFIHMDAKL PGBGNMHAHNM(IOGFOGHNJBC GHJFIPDNFIH)
	{
		return default(LCEFIHMDAKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84639D0", Offset = "0x8462DD0", VA = "0x1884639D0")]
	public LCEFIHMDAKL IFPLHAOCLOO(IOGFOGHNJBC LJINBOHHMLM)
	{
		return default(LCEFIHMDAKL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct PKONEEJJPFF : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[InternalBufferCapacity(1)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct HJAEICEOECC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity CJEDLHAFNCM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, OBHJLGHKFJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8461DD0", Offset = "0x84611D0", VA = "0x188461DD0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct IPNMNCGOFHB : ISystemStateBufferElementData, IBufferElementData, OBHJLGHKFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity MEOOAHKPJCE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity DFHPPODNHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct AKNKAEHLKGC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity GKKEBJLKCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity GLIANFCJFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity IHILMGBHJCP;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct MLAIPGIDDHO<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly bool JDPJAANKGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint CPPLNONLACG;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool OAPFKKPOCLC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct EAMGLPDGNOF : IBufferElementData, IEquatable<EAMGLPDGNOF>, OBHJLGHKFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity HDAMCCOINNK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity PLEIIBDBEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8461DD0", Offset = "0x84611D0", VA = "0x188461DD0", Slot = "4")]
	public bool Equals(EAMGLPDGNOF LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct LIIDMBJHHHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint MMDGEJPDMAL;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
	public LIIDMBJHHHO(DNOIABBOEPJ LGKFNBNJHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8463A30", Offset = "0x8462E30", VA = "0x188463A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2127560", Offset = "0x2126960", VA = "0x182127560")]
	public static LIIDMBJHHHO GKKMDDPCKIG(DNOIABBOEPJ LGKFNBNJHLJ)
	{
		return default(LIIDMBJHHHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct HHGMMDKOEHJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Entity MEOOAHKPJCE;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct BPOLABBIAKE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public DNOIABBOEPJ CBMEHPPMEEA;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct JGMJFJKFAJP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity MEOOAHKPJCE;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct NDNHGOAMCHE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid OOOANFDGEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int PPNAGMANAKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct GEAFFFHEGBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int CBMEHPPMEEA;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct IBFHNCMNKND : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity MEOOAHKPJCE;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct OPCONNEFNND : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DNOIABBOEPJ CBMEHPPMEEA;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct DONIBFDBDNB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity MEOOAHKPJCE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct HPKDBIIABAK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct AGGOPICDGMB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NCJPEMHOJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct GMBCKAAOCHG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int BDBJAOEOBNM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NNAECDFEPDN MEGGFBBKPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		get
		{
			return default(NNAECDFEPDN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct ALPCKHGAPIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GCHandle JDPADOBCGAI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct KHNENOAHJLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct GONFMKMOIEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct LJOPENCFOAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct LEDGBDLIFJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct JEHFCAHNIPF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct AMEKLBNMFHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public int NOEININIMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int CDBBOGJDAGP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8461D90", Offset = "0x8461190", VA = "0x188461D90")]
	public AMEKLBNMFHC(Entity MEOOAHKPJCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct CGGLOJFHAEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CollisionDetectionMode PDOCODNNFDM;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct HOKKNEEPDEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public IEEJIDPBMPL MDNKIPBAOMK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly HOKKNEEPDEG BCIBOEFGOGH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct ILCEKHMPGMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct PHHCLMJLDOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct FLAGDJODHNG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct MNBPIKIFNHK : IBufferElementData, IEquatable<MNBPIKIFNHK>, OBHJLGHKFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Entity HCOPOFCDINJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity PLEIIBDBEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8461DD0", Offset = "0x84611D0", VA = "0x188461DD0", Slot = "4")]
	public bool Equals(MNBPIKIFNHK LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct HLFDNGKEFIO : IComponentData, OBHJLGHKFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Entity JIECBJMGMAC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity PLEIIBDBEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct KHGFBBBBEFN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct HGMOCBIPDJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity LDEPDDDHLLO;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct AHPBFECOAPD : HHFHACAEKFF, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PBABGNFFMGK LAJHMEKKOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PBABGNFFMGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct JCBFBBKKOPF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 DMDGKBPCGBH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct KDIKIEGLFFL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct BNDLDHNIFKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3x3 PPLCOJDNDDL;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly BNDLDHNIFKG BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct PCPOHAKPCEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float3x3 PPLCOJDNDDL;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly PCPOHAKPCEC BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct KIAGPPKPGCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float3 PEDLCIHOOPE;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct FGOJDDJHFCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float3 ODINABHADCD;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct CBCFOGLGHAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float LPMPAALCOKA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly CBCFOGLGHAI BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct FBHECOFFMIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float EJJOEPLPAGK;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FBHECOFFMIJ BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct JIACEELJEOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 FDILJFDIMHF;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct BJFCDHIHIJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IAOENOOJLJP MMGBJKAOGPE;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct NFNGGEKFABL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Entity MEOOAHKPJCE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct FEPPEIJPHFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct GHKNGNHJIAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct KBCCFBLFBEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public RigidbodyConstraints LALLJGKPOOD;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct FEIGJIPHOCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float OLLOEFCLBJG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly FEIGJIPHOCD BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct KLAHAICCGEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float DIJLKGIKLBD;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GJOBFIPDHPE : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GameObject JBJNKCGNJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public object HIJGLGEOKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public object OEHBEOFJFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public CEBAJGBFBNL PKMDJAGDKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Delegate MAOEDDJKOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Delegate KMDOOBMHNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PNBCFLDECIA<Delegate> GHBMCKBMCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public PNBCFLDECIA<Delegate> OBBEMLGBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public PNBCFLDECIA<Delegate> DBPFDDPCGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public PNBCFLDECIA<Delegate> AJGFEOANPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public PNBCFLDECIA<Delegate> LEJBJBFPNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public PNBCFLDECIA<Delegate> NPNPPNIGMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public PNBCFLDECIA<Delegate> OOOBBDDABNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public PNBCFLDECIA<Delegate> GPBPJDEGCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public PNBCFLDECIA<Delegate> MAKBAFGLPFH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84630F0", Offset = "0x84624F0", VA = "0x1884630F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GJOBFIPDHPE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct ABCNNNOONPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct OEKHLIHBDFM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct CHPDFEHODAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int JFPBCPONFPO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2127560", Offset = "0x2126960", VA = "0x182127560")]
	public static CHPDFEHODAD GKKMDDPCKIG(int CBMEHPPMEEA)
	{
		return default(CHPDFEHODAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KNMGAJPHFDL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Rigidbody JAFLLGIEKOM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84638A0", Offset = "0x8462CA0", VA = "0x1884638A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public KNMGAJPHFDL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct GAACABHLDJE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct CDKOBOBGPGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 NBPDCMBDPJL;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct LAHHNJFIENA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 PODFFOEBFLC;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct CMGPBJODMGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float JILCGKJACAE;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CMGPBJODMGG BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NCECAGCAKAJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object MEIEDKFKOGC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8463CB0", Offset = "0x84630B0", VA = "0x188463CB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NCECAGCAKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class LJDPEEBEDKM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public object HNNHNKPNBDC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8463A60", Offset = "0x8462E60", VA = "0x188463A60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LJDPEEBEDKM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct JLHNHJGIFDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct HNINGJDJFDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct MCJFJBINJBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct OFLGJNIMMGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct BJCOFDOFMBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct PGCGIHHNMCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct NICJCGOAAGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct FPMGMDJPDDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct LIFICLIOFJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct EBENIEGAAIJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct NGICKBGEDAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public JMAJLEBDBPE CIJDBPBBPNJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8463F10", Offset = "0x8463310", VA = "0x188463F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct OIEBABMKIJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct HIGOJJNHIAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct MNHAGBNBDLH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct FCLDLHAKLLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FixedString32Bytes HDNPPEBJPAE;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct GHGMDJGLLFH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public UnsafeParallelHashMap<JMAJLEBDBPE, Entity> EPNKIPJHADK;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct FNKFPLDJNLN : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity DIPPPCMGOCA;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct LDCLFICLNGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity MEOOAHKPJCE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static LDCLFICLNGB GKKMDDPCKIG(Entity MEOOAHKPJCE)
	{
		return default(LDCLFICLNGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct FCCDFNNBLKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity EDMGEDMMPPG;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct EBPGPJJBLPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity EDMGEDMMPPG;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct JMELMDOAGHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity BAONJCKLOGA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780")]
	public static JMELMDOAGHL GKKMDDPCKIG(Entity MEOOAHKPJCE)
	{
		return default(JMELMDOAGHL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct JMBDILNOFCP : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct NBOJEBIMLLI : IBufferElementData, IEquatable<NBOJEBIMLLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity BBJELFHBAMM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8252900", Offset = "0x8251D00", VA = "0x188252900", Slot = "4")]
	public bool Equals(NBOJEBIMLLI LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8463C20", Offset = "0x8463020", VA = "0x188463C20", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct GIKEMOMPLOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint CDBBOGJDAGP;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct NBMBBFJKHGD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity APINDHBJOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public int NOEININIMIL;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct PANELFKHDFL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity JIJBIEHNKAL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct MNGPKAJCJNC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct HOOKHGODAAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public uint CPPLNONLACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int BMADHCDCJNL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xE6F630", Offset = "0xE6EA30", VA = "0x180E6F630")]
	public HOOKHGODAAJ(uint CEDNGBODBDN, int NAMLEEIEALI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct AAJAIFFONBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct EIMLCGDPGDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct CCKNNNDCIGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct OPMEKOOFBEN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct EBGJGJPJPAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct LGBFPHALPOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct EKCMKLFEEJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct LKHCFIFCOAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct EPMOFDEGOOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct ENPDBOBPPKG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct JEOJENKEPHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct GAGAJONFKKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct NKFFGNCOOKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct HEFMEDJCDKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct GEDILHFKFEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct CAPFBGGKOKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct PIBMCCPIOAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct FOCLAFIPJMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct DMEMOENOFCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct IKJMLKFIKHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct CIFAJOOPHEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct DNFNKGDAAMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
public struct CIFELLOHKGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct AOIIOEHLJFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct BPNEBIBIEHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct EJHNIDFOKOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct PAIIOAGNEOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct MOPGONHFINN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct LEFJLCDOMDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct FONABJGFIIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct FPMOKJIJFKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct ABDLBCMGCEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct EKMBBOFECPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct BKLKKKHDOPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[LEDNBHLMOKI]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct ANGENIHNAKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct NAMHILMFGKN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedString32Bytes HHKLKJCBFCE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct BNNKBDAJGAA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct PPFEJHIGFBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct BPPLCGKPHDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct AFBJOEEEOCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct CGAMLBBLCHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct FLNBAPLOKIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(15820134490602808056uL)]
public struct FJJMCNHGCCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public int HLICOFLIEFP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct FJIFENAALPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct PDEAFPFGFEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion EMLGDFFEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 LBCFHLNAPLC;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct EAGOHEEKNEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float NFPHNNKGDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float IOGPFNDNOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float JIFAOFFMMDH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct FGNJKFHFDBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct FGLOBHIJDFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct KEDJGMJLCNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct PHOIIFIGGOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int BDBJAOEOBNM;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct ILDHGCODGMG : ISystemStateBufferElementData, IBufferElementData, OBHJLGHKFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity JKJOEJKLENN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity DFHPPODNHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct NGCCBEHCKOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float4x4 ELKMOODBHMG;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly NGCCBEHCKOF BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct ABFOAOCFNAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float4x4 LCHGFDBANLN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly ABFOAOCFNAE BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct CBAPMIBEOEM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int OFNEKIEEKEK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NOEININIMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84621C0", Offset = "0x84615C0", VA = "0x1884621C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84621D0", Offset = "0x84615D0", VA = "0x1884621D0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
[RegisterComponentDefault]
public struct KNDFIMAFMDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float3 LBCFHLNAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public quaternion EMLGDFFEJED;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly KNDFIMAFMDK BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class GFNMFOIIKBO
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
[RegisterComponentDefault]
public struct FJHBPMLPIHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public float KALCJGABHFH;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly FJHBPMLPIHG BCIBOEFGOGH;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct FKEMFDNLEMJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Entity JFINDLBKLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public GDCPGHBNPPK OBGGAHJDHFG;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct LEFJLEACBDI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public GDCPGHBNPPK OBGGAHJDHFG;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct EDLJJEKCMEC : ISystemStateComponentData, IComponentData, OBHJLGHKFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Entity CCGANJILKHA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity DFHPPODNHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct HODOGFMPGGK : ISystemStateBufferElementData, IBufferElementData, OBHJLGHKFJO, IEquatable<HODOGFMPGGK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity FDBGAHGLCJO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity DFHPPODNHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8252900", Offset = "0x8251D00", VA = "0x188252900", Slot = "6")]
	public bool Equals(HODOGFMPGGK LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84632B0", Offset = "0x84626B0", VA = "0x1884632B0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct KNHMPPFLNDC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Entity JFINDLBKLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public GDCPGHBNPPK OBGGAHJDHFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct GMJBAOCOEDL : IEqualityComparer<KNHMPPFLNDC>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static GMJBAOCOEDL BCIBOEFGOGH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8463140", Offset = "0x8462540", VA = "0x188463140", Slot = "4")]
	public bool Equals(KNHMPPFLNDC FNBJHADJBNG, KNHMPPFLNDC MODFPFNICHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8463190", Offset = "0x8462590", VA = "0x188463190", Slot = "5")]
	public int GetHashCode(KNHMPPFLNDC DEJGDIIDCDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct IGHLLMBKEOK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public FixedList32Bytes<int> AOIOCLJAONJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct OKDJOHCDDDB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public FixedList32Bytes<int> AOIOCLJAONJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct LKPKKADOALG : ISystemStateBufferElementData, IBufferElementData, OBHJLGHKFJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Entity ODEDAJLKNFE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity PLEIIBDBEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1395E90", Offset = "0x1395290", VA = "0x181395E90", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class LJGGKIMDNBG : ContainerPropertyBag<LJJPLFFHFLI>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class EIMOIGCAKON : Property<LJJPLFFHFLI, BCFFHAFDNGI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8462C10", Offset = "0x8462010", VA = "0x188462C10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8462BD0", Offset = "0x8461FD0", VA = "0x188462BD0")]
		public EIMOIGCAKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84627C0", Offset = "0x8461BC0", VA = "0x1884627C0", Slot = "14")]
		public override BCFFHAFDNGI GetValue(LJJPLFFHFLI MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84627E0", Offset = "0x8461BE0", VA = "0x1884627E0", Slot = "15")]
		public override void SetValue(LJJPLFFHFLI MNCIANLLPKI, BCFFHAFDNGI CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8463AD0", Offset = "0x8462ED0", VA = "0x188463AD0")]
	public LJGGKIMDNBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class OEFCOFEDNMI : ContainerPropertyBag<GJOBFIPDHPE>
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class NOAPEDGPDFA : Property<GJOBFIPDHPE, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8463FA0", Offset = "0x84633A0", VA = "0x188463FA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8463F60", Offset = "0x8463360", VA = "0x188463F60")]
		public NOAPEDGPDFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84627C0", Offset = "0x8461BC0", VA = "0x1884627C0", Slot = "14")]
		public override GameObject GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84627E0", Offset = "0x8461BE0", VA = "0x1884627E0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, GameObject CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class BIJBGPIGHMM : Property<GJOBFIPDHPE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8461E70", Offset = "0x8461270", VA = "0x188461E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8461E30", Offset = "0x8461230", VA = "0x188461E30")]
		public BIJBGPIGHMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8461DE0", Offset = "0x84611E0", VA = "0x188461DE0", Slot = "14")]
		public override object GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8461E00", Offset = "0x8461200", VA = "0x188461E00", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, object CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class IGEPDBBGIBI : Property<GJOBFIPDHPE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8463550", Offset = "0x8462950", VA = "0x188463550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8463510", Offset = "0x8462910", VA = "0x188463510")]
		public IGEPDBBGIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84634C0", Offset = "0x84628C0", VA = "0x1884634C0", Slot = "14")]
		public override object GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84634E0", Offset = "0x84628E0", VA = "0x1884634E0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, object CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class IJOJCJCFBNH : Property<GJOBFIPDHPE, CEBAJGBFBNL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8463610", Offset = "0x8462A10", VA = "0x188463610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84635D0", Offset = "0x84629D0", VA = "0x1884635D0")]
		public IJOJCJCFBNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8463580", Offset = "0x8462980", VA = "0x188463580", Slot = "14")]
		public override CEBAJGBFBNL GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84635A0", Offset = "0x84629A0", VA = "0x1884635A0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, CEBAJGBFBNL CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class OKNLAGDFFOK : Property<GJOBFIPDHPE, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8464780", Offset = "0x8463B80", VA = "0x188464780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8464740", Offset = "0x8463B40", VA = "0x188464740")]
		public OKNLAGDFFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x84646F0", Offset = "0x8463AF0", VA = "0x1884646F0", Slot = "14")]
		public override Delegate GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8464710", Offset = "0x8463B10", VA = "0x188464710", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, Delegate CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class DIBGOFAAJCK : Property<GJOBFIPDHPE, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8462790", Offset = "0x8461B90", VA = "0x188462790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8462750", Offset = "0x8461B50", VA = "0x188462750")]
		public DIBGOFAAJCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8462700", Offset = "0x8461B00", VA = "0x188462700", Slot = "14")]
		public override Delegate GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8462720", Offset = "0x8461B20", VA = "0x188462720", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, Delegate CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class BKPCPOALGHD : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8461F30", Offset = "0x8461330", VA = "0x188461F30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8461EF0", Offset = "0x84612F0", VA = "0x188461EF0")]
		public BKPCPOALGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8461EA0", Offset = "0x84612A0", VA = "0x188461EA0", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8461EC0", Offset = "0x84612C0", VA = "0x188461EC0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class DFPDNBPMDOJ : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x84626D0", Offset = "0x8461AD0", VA = "0x1884626D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8462690", Offset = "0x8461A90", VA = "0x188462690")]
		public DFPDNBPMDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8462640", Offset = "0x8461A40", VA = "0x188462640", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8462660", Offset = "0x8461A60", VA = "0x188462660", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class LBOMFPBGFMO : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x84639A0", Offset = "0x8462DA0", VA = "0x1884639A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8463960", Offset = "0x8462D60", VA = "0x188463960")]
		public LBOMFPBGFMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8463910", Offset = "0x8462D10", VA = "0x188463910", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8463930", Offset = "0x8462D30", VA = "0x188463930", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class EDACHBNEAGC : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8462B30", Offset = "0x8461F30", VA = "0x188462B30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8462AF0", Offset = "0x8461EF0", VA = "0x188462AF0")]
		public EDACHBNEAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8462AA0", Offset = "0x8461EA0", VA = "0x188462AA0", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8462AC0", Offset = "0x8461EC0", VA = "0x188462AC0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class KECPNKGEEPO : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x84636D0", Offset = "0x8462AD0", VA = "0x1884636D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8463690", Offset = "0x8462A90", VA = "0x188463690")]
		public KECPNKGEEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8463640", Offset = "0x8462A40", VA = "0x188463640", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8463660", Offset = "0x8462A60", VA = "0x188463660", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class OBJENNNFICD : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8464060", Offset = "0x8463460", VA = "0x188464060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8464020", Offset = "0x8463420", VA = "0x188464020")]
		public OBJENNNFICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8463FD0", Offset = "0x84633D0", VA = "0x188463FD0", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8463FF0", Offset = "0x84633F0", VA = "0x188463FF0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class HEBFBLHLEHJ : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8463280", Offset = "0x8462680", VA = "0x188463280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8463240", Offset = "0x8462640", VA = "0x188463240")]
		public HEBFBLHLEHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84631F0", Offset = "0x84625F0", VA = "0x1884631F0", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8463210", Offset = "0x8462610", VA = "0x188463210", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class CNJFBDBLOEC : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8462610", Offset = "0x8461A10", VA = "0x188462610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x84625D0", Offset = "0x84619D0", VA = "0x1884625D0")]
		public CNJFBDBLOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8462580", Offset = "0x8461980", VA = "0x188462580", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84625A0", Offset = "0x84619A0", VA = "0x1884625A0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class DMKNJJHJAPE : Property<GJOBFIPDHPE, PNBCFLDECIA<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8462910", Offset = "0x8461D10", VA = "0x188462910", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84628D0", Offset = "0x8461CD0", VA = "0x1884628D0")]
		public DMKNJJHJAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8462880", Offset = "0x8461C80", VA = "0x188462880", Slot = "14")]
		public override PNBCFLDECIA<Delegate> GetValue(GJOBFIPDHPE MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x84628A0", Offset = "0x8461CA0", VA = "0x1884628A0", Slot = "15")]
		public override void SetValue(GJOBFIPDHPE MNCIANLLPKI, PNBCFLDECIA<Delegate> CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8464090", Offset = "0x8463490", VA = "0x188464090")]
	public OEFCOFEDNMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class HPBADJAPHGN : ContainerPropertyBag<PNBCFLDECIA<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8463380", Offset = "0x8462780", VA = "0x188463380")]
	public HPBADJAPHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class IEABMCHIMAA : ContainerPropertyBag<KNMGAJPHFDL>
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	private class DMAMBNLCONK : Property<KNMGAJPHFDL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8462850", Offset = "0x8461C50", VA = "0x188462850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8462810", Offset = "0x8461C10", VA = "0x188462810")]
		public DMAMBNLCONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x84627C0", Offset = "0x8461BC0", VA = "0x1884627C0", Slot = "14")]
		public override Rigidbody GetValue(KNMGAJPHFDL MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84627E0", Offset = "0x8461BE0", VA = "0x1884627E0", Slot = "15")]
		public override void SetValue(KNMGAJPHFDL MNCIANLLPKI, Rigidbody CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x84633E0", Offset = "0x84627E0", VA = "0x1884633E0")]
	public IEABMCHIMAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class CNJDJMMLPMD : ContainerPropertyBag<NCECAGCAKAJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	private class KIHDEFOMHOL : Property<NCECAGCAKAJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8463740", Offset = "0x8462B40", VA = "0x188463740", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8463700", Offset = "0x8462B00", VA = "0x188463700")]
		public KIHDEFOMHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x84627C0", Offset = "0x8461BC0", VA = "0x1884627C0", Slot = "14")]
		public override object GetValue(NCECAGCAKAJ MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84627E0", Offset = "0x8461BE0", VA = "0x1884627E0", Slot = "15")]
		public override void SetValue(NCECAGCAKAJ MNCIANLLPKI, object CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84624A0", Offset = "0x84618A0", VA = "0x1884624A0")]
	public CNJDJMMLPMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class BMJJEOOKHPD : ContainerPropertyBag<LJDPEEBEDKM>
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	private class EGHLHLFAENO : Property<LJDPEEBEDKM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8462BA0", Offset = "0x8461FA0", VA = "0x188462BA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8462B60", Offset = "0x8461F60", VA = "0x188462B60")]
		public EGHLHLFAENO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84627C0", Offset = "0x8461BC0", VA = "0x1884627C0", Slot = "14")]
		public override object GetValue(LJDPEEBEDKM MNCIANLLPKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84627E0", Offset = "0x8461BE0", VA = "0x1884627E0", Slot = "15")]
		public override void SetValue(LJDPEEBEDKM MNCIANLLPKI, object CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8461F60", Offset = "0x8461360", VA = "0x188461F60")]
	public BMJJEOOKHPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class DPHFGGDCBHA : ContainerPropertyBag<FNKFPLDJNLN>
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class BPFNCIKDNAB : Property<FNKFPLDJNLN, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8462190", Offset = "0x8461590", VA = "0x188462190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8462150", Offset = "0x8461550", VA = "0x188462150")]
		public BPFNCIKDNAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAD61A0", Offset = "0xAD55A0", VA = "0x180AD61A0", Slot = "14")]
		public override Entity GetValue(FNKFPLDJNLN MNCIANLLPKI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8462140", Offset = "0x8461540", VA = "0x188462140", Slot = "15")]
		public override void SetValue(FNKFPLDJNLN MNCIANLLPKI, Entity CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84629C0", Offset = "0x8461DC0", VA = "0x1884629C0")]
	public DPHFGGDCBHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class NEKJFNFCLKM : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class PHGJDOBFNKH : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x84648F0", Offset = "0x8463CF0", VA = "0x1884648F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x84648B0", Offset = "0x8463CB0", VA = "0x1884648B0")]
		public PHGJDOBFNKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x142C4C0", Offset = "0x142B8C0", VA = "0x18142C4C0", Slot = "14")]
		public override int GetValue(Entity MNCIANLLPKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x824C690", Offset = "0x824BA90", VA = "0x18824C690", Slot = "15")]
		public override void SetValue(Entity MNCIANLLPKI, int CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class FJKDFLEMMMO : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string GODGCHFEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8462D50", Offset = "0x8462150", VA = "0x188462D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool NBPHDBEEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8462D10", Offset = "0x8462110", VA = "0x188462D10")]
		public FJKDFLEMMMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x13A7150", Offset = "0x13A6550", VA = "0x1813A7150", Slot = "14")]
		public override int GetValue(Entity MNCIANLLPKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8462D00", Offset = "0x8462100", VA = "0x188462D00", Slot = "15")]
		public override void SetValue(Entity MNCIANLLPKI, int CBMEHPPMEEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8463D20", Offset = "0x8463120", VA = "0x188463D20")]
	public NEKJFNFCLKM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8464920", Offset = "0x8463D20", VA = "0x188464920")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class FCNBKKGCIKA
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCNBKKGCIKA()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
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

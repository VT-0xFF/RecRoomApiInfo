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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82B3170", Offset = "0x82B1D70", VA = "0x1882B3170", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82B3520", Offset = "0x82B2120", VA = "0x1882B3520", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2480", VA = "0x1828B3880")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct JGCHKINLGFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct DDOEPLNNDMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct KGPHFKJDAIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct FCDHNGFKMDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct HLOLPIEMHHL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE40", Offset = "0x82AEA40", VA = "0x1882AFE40", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct GEMFFMJLMMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct HFKGMMFNKDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct HBEFKGOKFOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity ILNBOOONKAL;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct KLMNLENEOLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity ILNBOOONKAL;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LELMGHONPJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<PNBNJMIKGPP> GKHHGFOFEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> ELALCBFLKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle GPAFPAOOIJM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AKCFPEAFOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82B1710", Offset = "0x82B0310", VA = "0x1882B1710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82B17E0", Offset = "0x82B03E0", VA = "0x1882B17E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x600AF10", Offset = "0x6009B10", VA = "0x18600AF10")]
	public LELMGHONPJJ(NativeList<PNBNJMIKGPP> GKHHGFOFEKD, NativeList<Entity> ELALCBFLKDB, JobHandle GPAFPAOOIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x82B1830", Offset = "0x82B0430", VA = "0x1882B1830")]
	public (Entity, NativeSlice<Entity>) MFELIJFHLOB(int FLNKCEHIHDH)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82B1780", Offset = "0x82B0380", VA = "0x1882B1780", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PNBNJMIKGPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity OLIIIAEGOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int HDEKJKJDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int LBLBECEIAEC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KAPOCFHGBLJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHMFLDHMAEE(bool OLJENPHDJCP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GGODHFCPDIN : IEquatable<GGODHFCPDIN>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool CMMHNFHGDKK(int JGGIBDMAPLG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool CIBJJJFDDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool DNJCFPFAHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool FICHBIMEEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool MDNFEDOCHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CMMHNFHGDKK NNPFHCHEKFP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82B0DA0", Offset = "0x82AF9A0", VA = "0x1882B0DA0")]
	public GGODHFCPDIN(GCOFBKNOKHB HHPCFHFLKHA, CMMHNFHGDKK NNPFHCHEKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x82B0D70", Offset = "0x82AF970", VA = "0x1882B0D70")]
	public GGODHFCPDIN(bool CIBJJJFDDIF, bool DNJCFPFAHAP, bool FICHBIMEEJO, bool MDNFEDOCHPA, CMMHNFHGDKK NNPFHCHEKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x82B0CB0", Offset = "0x82AF8B0", VA = "0x1882B0CB0")]
	public bool PDKOAIPDEEO(int JGGIBDMAPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x82B0C50", Offset = "0x82AF850", VA = "0x1882B0C50")]
	public bool LOJAJPADIKH(int JGGIBDMAPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82B0C20", Offset = "0x82AF820", VA = "0x1882B0C20")]
	public bool KPFFOFCICKB(int JGGIBDMAPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x82B0C80", Offset = "0x82AF880", VA = "0x1882B0C80")]
	public bool PCCHPMDACFP(int JGGIBDMAPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x82B0A80", Offset = "0x82AF680", VA = "0x1882B0A80", Slot = "4")]
	public bool Equals(GGODHFCPDIN IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x82B0AB0", Offset = "0x82AF6B0", VA = "0x1882B0AB0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x82B0B60", Offset = "0x82AF760", VA = "0x1882B0B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x82B0C00", Offset = "0x82AF800", VA = "0x1882B0C00")]
	private bool HFJEKJLDLKB(int JGGIBDMAPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82B0CE0", Offset = "0x82AF8E0", VA = "0x1882B0CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PMGCFAJBCCH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public FEFKONOOGAB GAHJODIGGJP;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82B28D0", Offset = "0x82B14D0", VA = "0x1882B28D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PMGCFAJBCCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FEFKONOOGAB
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct KAFHIPGJONE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity KILDJALJEOF;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct FPFCMPHBLGF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity AHIKODPOKNB;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
public struct FOPDPNCMOND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity NHJGJBHFFOA;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct DOFJCKMAEFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool GOJJCLOKFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool JAKAJIAJEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int KLKKPEDDDGL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct FACIABKAIGG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
[SingletonComponent]
public struct DJCIPMMLNIL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Entity CGLPEGHHGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Entity IPHLELBEMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Entity ILNMOJHGKOA;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct HKKBMAPBPHG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Entity KMKNICEEDJF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct DGIFLMIDIBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 FEMJLOIOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public quaternion DINDLKHALMD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct BEIAMFEIIOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct DLEDJBPPIDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly LJJDHCKOKCD NLKGNEBHKBM;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x30FED20", Offset = "0x30FD920", VA = "0x1830FED20")]
	public DLEDJBPPIDO(LJJDHCKOKCD NLKGNEBHKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82B0460", Offset = "0x82AF060", VA = "0x1882B0460")]
	public DLEDJBPPIDO JDAHDAPEEDM(LJJDHCKOKCD KMHPGNIBJKO)
	{
		return default(DLEDJBPPIDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82B0450", Offset = "0x82AF050", VA = "0x1882B0450")]
	public DLEDJBPPIDO ILCBKMAKEFK(LJJDHCKOKCD BIEIECFMCEB)
	{
		return default(DLEDJBPPIDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82B0470", Offset = "0x82AF070", VA = "0x1882B0470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Flags]
public enum LJJDHCKOKCD : ushort
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
public static class FMNBGHIBOBO
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct CMJHDCCFKLD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public LJJDHCKOKCD EJAGPIPLMAM;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82B0280", Offset = "0x82AEE80", VA = "0x1882B0280")]
	public bool PKGPCNMEFPL(DLEDJBPPIDO IDGAHNOJONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x82B0260", Offset = "0x82AEE60", VA = "0x1882B0260")]
	public bool IDILDOAHFAL(DLEDJBPPIDO IDGAHNOJONP, LJJDHCKOKCD JJAFEAIJFKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum BAJAOOOLDBJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct MCEIFFCIABN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public BAJAOOOLDBJ NLKGNEBHKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public bool DFIJOMOJJPH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IEJNALAOIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82B1CA0", Offset = "0x82B08A0", VA = "0x1882B1CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82B1CB0", Offset = "0x82B08B0", VA = "0x1882B1CB0")]
	private MCEIFFCIABN(BAJAOOOLDBJ NLKGNEBHKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82B1C80", Offset = "0x82B0880", VA = "0x1882B1C80")]
	public MCEIFFCIABN JDAHDAPEEDM(BAJAOOOLDBJ KMHPGNIBJKO)
	{
		return default(MCEIFFCIABN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x82B1C60", Offset = "0x82B0860", VA = "0x1882B1C60")]
	public MCEIFFCIABN ILCBKMAKEFK(BAJAOOOLDBJ BIEIECFMCEB)
	{
		return default(MCEIFFCIABN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct AGMHKOHIFMN : IComponentData
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
public struct EHJNGOGPDJA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity NHGKGPGBMCE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, HCLAGIILNMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE40", Offset = "0x82AEA40", VA = "0x1882AFE40", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct GBPIIBHMLCG : ISystemStateBufferElementData, IBufferElementData, HCLAGIILNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity CGLPEGHHGMM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity KJHIOGAKPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct NAGDBHJNMII : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity CGAKLJFBLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity AGBKADKDAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity EDEKOBJMOIL;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NPFPHCPKLIA<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly bool BGMCAGMEELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint MPNLEGAAIBE;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool OMMAPLINDBK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct LNHLJLBADDI : IBufferElementData, IEquatable<LNHLJLBADDI>, HCLAGIILNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity EIGHLKEBDFF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity NMJHDLMINAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x82AFE40", Offset = "0x82AEA40", VA = "0x1882AFE40", Slot = "4")]
	public bool Equals(LNHLJLBADDI IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct JICELGNMKJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint PHCMGNPAMMN;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14B6AC0", Offset = "0x14B56C0", VA = "0x1814B6AC0")]
	public JICELGNMKJB(BPKOKGNGCMF PIIIPDILKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x82B13B0", Offset = "0x82AFFB0", VA = "0x1882B13B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20CFE30", Offset = "0x20CEA30", VA = "0x1820CFE30")]
	public static JICELGNMKJB KDDDGPNBGLG(BPKOKGNGCMF PIIIPDILKIL)
	{
		return default(JICELGNMKJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct CMLBCFIFFJP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Entity CGLPEGHHGMM;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct FFPMNNNOBHB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public BPKOKGNGCMF BKMPCFIAHIG;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct BKLEIHPJNNP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity CGLPEGHHGMM;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct BOGDBJAAOOC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid FHNOHJCOOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int NKGPOLKDIPE;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct FJKOPJDLBMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int BKMPCFIAHIG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct NNGGOGIBBLL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity CGLPEGHHGMM;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct NAHCDPIEPHO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public BPKOKGNGCMF BKMPCFIAHIG;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct OKIDNHHFBNI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity CGLPEGHHGMM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct PPOEAHAKFAI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct JOAJFPKJAKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int EHBBMKLJLND;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct CBCKEHEPGNI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int LHBOIGHHIJM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MKFFFMAICOP OLKCOIECONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80")]
		get
		{
			return default(MKFFFMAICOP);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct IEGGLECFCEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GCHandle LBMFCIEEMKO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct OOHOMLJNFKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct EHHMLELFEBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct AJOCIEDANII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct DCDLMPJFJDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct HLDHAGPGCGP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct OGGIFOGHMJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public int LCCBBMBENOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int LAHAJPPAFND;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82B26E0", Offset = "0x82B12E0", VA = "0x1882B26E0")]
	public OGGIFOGHMJO(Entity CGLPEGHHGMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct KFLNALCNAAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CollisionDetectionMode JNIGAJFOEKM;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct MGBHFCLHJHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public AFJPHDDPDEH CKKAKIHFJGB;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly MGBHFCLHJHP JOFMPALJJOB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct OGMBDFDJANF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct HKPACIIOLLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct FCPGLECEDHN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct IEBKGGBJDCC : IBufferElementData, IEquatable<IEBKGGBJDCC>, HCLAGIILNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Entity EPHCGLFDDNO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity NMJHDLMINAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82AFE40", Offset = "0x82AEA40", VA = "0x1882AFE40", Slot = "4")]
	public bool Equals(IEBKGGBJDCC IIOGPDPGOLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct JFGKEBAEGEH : IComponentData, HCLAGIILNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Entity IEPNOLIPIDE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity NMJHDLMINAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct KEKHJFOAPKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct OLOHFONNCDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity OLIIIAEGOLD;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct HOPKAFAIGHC : JFMAFOHJGBG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GKFLOHMIEAL KENOBOABDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GKFLOHMIEAL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct EGLABBKKBMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 OGFANHGPNGD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct KCDHHEENPKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct FLODEMNCLFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3x3 PNNDPFLBCFP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly FLODEMNCLFL JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct CFJKDJNOJBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float3x3 PNNDPFLBCFP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CFJKDJNOJBG JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct LIOBFGECIBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float3 MHEMPLHMBPN;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct BLOKPKNECJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float3 JGOHMOJIIBG;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct ADOAPBKMOHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float BJHPFAJEKKI;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly ADOAPBKMOHD JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct JPJLLHFIFNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float GANANGCGCCC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly JPJLLHFIFNL JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct NPBBEDPFOLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 HEBFOFDKFCL;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct NGNNMEEHCMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public KEMCMOHNHFH GHPLEABLMHG;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct NLOGBELLKKO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Entity CGLPEGHHGMM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct FHPDODALMPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct JNFLPNAIHIN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct BGJPDPJIFGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public RigidbodyConstraints HOGJHFPIEIG;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct NCLHDJMJNAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KDBGDFEJKCH;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NCLHDJMJNAC JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct CHCNPMPPDEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float ILGBGMMHMGA;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DOFGPFODPJF : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GameObject HLOIBGDKPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public object CCGNIJAGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public object GOHEJMINAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public JJDJNNFCKLB IECIOIOJDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Delegate LFFBAOENDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Delegate JKJOCGPNNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public EAICLJOGAIB<Delegate> HDICLHEMLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public EAICLJOGAIB<Delegate> JBLHMOIOPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public EAICLJOGAIB<Delegate> KOMHJJKCCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public EAICLJOGAIB<Delegate> DOPOKMNBLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public EAICLJOGAIB<Delegate> CANIPOADIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public EAICLJOGAIB<Delegate> IIIFLGDFGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public EAICLJOGAIB<Delegate> EHHAHEMHLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public EAICLJOGAIB<Delegate> KIOBNCFGDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public EAICLJOGAIB<Delegate> HKHMKNABLLC;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x82B04D0", Offset = "0x82AF0D0", VA = "0x1882B04D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public DOFGPFODPJF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct LDLPIFEHAEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct IKHAEJDCAIC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct MLJKCHGABDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int KBAFIDGBPPN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x20CFE30", Offset = "0x20CEA30", VA = "0x1820CFE30")]
	public static MLJKCHGABDH KDDDGPNBGLG(int BKMPCFIAHIG)
	{
		return default(MLJKCHGABDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MLLBPPJONKI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Rigidbody NHJGDBOOFHP;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82B1E80", Offset = "0x82B0A80", VA = "0x1882B1E80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MLLBPPJONKI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct ONOBFDJBFOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct PKEPOJKEEEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 JGLAFHCCNMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct JOFKAOJGBDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 ANDGMPFHLOF;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct EMAJHEPIBCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float OPDGOLDLPBM;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly EMAJHEPIBCG JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HGPHCKOBFMH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object BBAIDOKOGPC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x82B0FB0", Offset = "0x82AFBB0", VA = "0x1882B0FB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public HGPHCKOBFMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PAHPMFLLJJH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public object AFGECMFEBBC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x82B26F0", Offset = "0x82B12F0", VA = "0x1882B26F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PAHPMFLLJJH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct LBJFFPMEFKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct FMDHJKBELKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct MJHPMNJCGCO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct CDBHDPFENEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct CPLMPHEDFNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct LCENDJGIHCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct DCDILPJEEOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct JIEGDHFPBOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct HCOIKNNNJEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct LGIFIDPJBPB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct EJPHHHCJNLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public MJOIKADLMGF BKDDIFICJED;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x82B0590", Offset = "0x82AF190", VA = "0x1882B0590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct FJPBJOFGALL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct HJMALBBPFNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct AKFHOFDBHHL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct BDABMNLKFGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FixedString32Bytes BKILENEPEEB;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct KAPIAJJKEBI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public UnsafeParallelHashMap<MJOIKADLMGF, Entity> CNDJELHNGMN;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct MFBNGKFFKHK : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity NCNGPGGAKKE;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct CJEHHMDEGHH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity CGLPEGHHGMM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static CJEHHMDEGHH KDDDGPNBGLG(Entity CGLPEGHHGMM)
	{
		return default(CJEHHMDEGHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct IOHGOOAIJAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity EAKGAFOJMIB;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct EFFKBBFCNPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity EAKGAFOJMIB;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct NCGKIAAGDIP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity JADLBGHNBEB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD8D830", Offset = "0xD8C430", VA = "0x180D8D830")]
	public static NCGKIAAGDIP KDDDGPNBGLG(Entity CGLPEGHHGMM)
	{
		return default(NCGKIAAGDIP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct OAGKANMJLHI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct LGLMPJACKDJ : IBufferElementData, IEquatable<LGLMPJACKDJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity LENPJBDMDOJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x80A50C0", Offset = "0x80A3CC0", VA = "0x1880A50C0", Slot = "4")]
	public bool Equals(LGLMPJACKDJ IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82B1A90", Offset = "0x82B0690", VA = "0x1882B1A90", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct CKAADMLECGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint LAHAJPPAFND;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct HCOAKJIGODI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity KGIAOCDIILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public int LCCBBMBENOH;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct AALBAAFPNGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity JAPNMDMDLII;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct KBPHKPGOBCH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct KIMBBHNACDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public uint MPNLEGAAIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int PICCLAANCBD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xE432B0", Offset = "0xE41EB0", VA = "0x180E432B0")]
	public KIMBBHNACDM(uint PMDMCOPOLMP, int FLEDLCJMDGP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct JEJOBCKHOFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct ADJALFJNNCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct KDGJKFPFMDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct AMIBKAHLOMK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct DKBIDFAOPAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct BLOMIPJEPJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct BOKIBJBKHLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct DELGGLIOGHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct GBCNINHEDIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct CPLKIGGKEKI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct OMEJLNBHNFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct NFEBOMODNNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct LKJHEANHLCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct MKECCKLJOGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct FEEIFFAOPPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct CAJMIMKLKDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct DNOIPIHNIHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct NKLIOCPNIBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct DABAJCDGIJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct FMEMCPJCDLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct PJGMAHJDCII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct IPPJOCBNEKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
public struct FPKPCGFMDHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct KGLLKDMHOKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct GDCJJNCBBHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct MADGMHIFPIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct KCJNOIDDABB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct MNICIONPILD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct JKLFNLPEJEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct IOGHCCMKDKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct KAFJCBKMDOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct DEIJMJPPBLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct LJKPIMCKPHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct CEEAGIJBOLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[IANHPOCHJIL]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct CBNNEOEFNPF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct NIEHMABCGKO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedString32Bytes GMFCELNCIOG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct MCIBAEKKLDB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct ICOFABJNKJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct GCABMFFLGHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct BNAFNLLIKAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct BPAPCHGIFPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct FGCNMLLELGI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(15820134490602808056uL)]
public struct ADALLNNKLGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public int AJJMAFNKADA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct KOIBPDCHMAG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct OJJEFIAFJHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion DINDLKHALMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 FEMJLOIOGIK;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct MKJBPCBLDBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float JDJLCIFLELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float BGMPIKGHJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float AGHBNDOPDPK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct KANPNMBFKIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct KHOICHLDGJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct FBKICEHAFFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct FIHJGGODFII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int LHBOIGHHIJM;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct LKHIAOBLBIB : ISystemStateBufferElementData, IBufferElementData, HCLAGIILNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity EIEILELNLLN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity KJHIOGAKPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct JNDHGIEHMOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float4x4 DGFBJMKCEGM;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly JNDHGIEHMOB JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct PBIGECMIEEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float4x4 PPLFAKNDFFF;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly PBIGECMIEEL JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct PNEOIJDAECN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int HJGGNFFBJJO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LCCBBMBENOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82B2950", Offset = "0x82B1550", VA = "0x1882B2950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82B2940", Offset = "0x82B1540", VA = "0x1882B2940")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
[RegisterComponentDefault]
public struct EOBHAMPFGCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float3 FEMJLOIOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public quaternion DINDLKHALMD;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly EOBHAMPFGCB JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class MIJDPEPLNJF
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
[RegisterComponentDefault]
public struct GJKDLNEKCBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public float ABMILNKLFPM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly GJKDLNEKCBE JOFMPALJJOB;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct EBJOHLFDBIH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Entity KAPGMCDEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public MCKGLJLILAB MEGBHLJHDNE;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct ECLGNKOMDIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public MCKGLJLILAB MEGBHLJHDNE;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct KIPGLGOPOOP : ISystemStateComponentData, IComponentData, HCLAGIILNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Entity JAOGNEOIMGK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity KJHIOGAKPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct ELELDNHCFDC : ISystemStateBufferElementData, IBufferElementData, HCLAGIILNMG, IEquatable<ELELDNHCFDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity CKGPNMNCHMA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity KJHIOGAKPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x80A50C0", Offset = "0x80A3CC0", VA = "0x1880A50C0", Slot = "6")]
	public bool Equals(ELELDNHCFDC IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82B05E0", Offset = "0x82AF1E0", VA = "0x1882B05E0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD8DE80", Offset = "0xD8CA80", VA = "0x180D8DE80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct CPMEEEIDHCE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Entity KAPGMCDEGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public MCKGLJLILAB MEGBHLJHDNE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct IGDMPDJHNOC : IEqualityComparer<CPMEEEIDHCE>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static IGDMPDJHNOC JOFMPALJJOB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82B1100", Offset = "0x82AFD00", VA = "0x1882B1100", Slot = "4")]
	public bool Equals(CPMEEEIDHCE LGCEHLADNJC, CPMEEEIDHCE LFHMHCKODDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x82B1150", Offset = "0x82AFD50", VA = "0x1882B1150", Slot = "5")]
	public int GetHashCode(CPMEEEIDHCE KOJLNGLNBMH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct PMEFALEOMAF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public FixedList32Bytes<int> OBELFLFLBMI;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct NBENCEBNOMM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public FixedList32Bytes<int> OBELFLFLBMI;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct FDGNIPGMLFG : ISystemStateBufferElementData, IBufferElementData, HCLAGIILNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Entity BEANPBDJHLH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity NMJHDLMINAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1347740", Offset = "0x1346340", VA = "0x181347740", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class NFMJNGOIFKO : ContainerPropertyBag<PMGCFAJBCCH>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class BHCIPAGFFLD : Property<PMGCFAJBCCH, FEFKONOOGAB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x82AFFA0", Offset = "0x82AEBA0", VA = "0x1882AFFA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF60", Offset = "0x82AEB60", VA = "0x1882AFF60")]
		public BHCIPAGFFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF10", Offset = "0x82AEB10", VA = "0x1882AFF10", Slot = "14")]
		public override FEFKONOOGAB GetValue(PMGCFAJBCCH EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF30", Offset = "0x82AEB30", VA = "0x1882AFF30", Slot = "15")]
		public override void SetValue(PMGCFAJBCCH EHEGCBFMKDA, FEFKONOOGAB BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x82B2590", Offset = "0x82B1190", VA = "0x1882B2590")]
	public NFMJNGOIFKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class MPKHDNCFLEI : ContainerPropertyBag<DOFGPFODPJF>
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class CEGCFIJHEGA : Property<DOFGPFODPJF, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x82B00D0", Offset = "0x82AECD0", VA = "0x1882B00D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x82B0090", Offset = "0x82AEC90", VA = "0x1882B0090")]
		public CEGCFIJHEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF10", Offset = "0x82AEB10", VA = "0x1882AFF10", Slot = "14")]
		public override GameObject GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF30", Offset = "0x82AEB30", VA = "0x1882AFF30", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, GameObject BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class BECBMOCGKMP : Property<DOFGPFODPJF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x82AFEE0", Offset = "0x82AEAE0", VA = "0x1882AFEE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82AFEA0", Offset = "0x82AEAA0", VA = "0x1882AFEA0")]
		public BECBMOCGKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE50", Offset = "0x82AEA50", VA = "0x1882AFE50", Slot = "14")]
		public override object GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE70", Offset = "0x82AEA70", VA = "0x1882AFE70", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, object BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class KLFBJPLNBAN : Property<DOFGPFODPJF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x82B16E0", Offset = "0x82B02E0", VA = "0x1882B16E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82B16A0", Offset = "0x82B02A0", VA = "0x1882B16A0")]
		public KLFBJPLNBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82B1650", Offset = "0x82B0250", VA = "0x1882B1650", Slot = "14")]
		public override object GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82B1670", Offset = "0x82B0270", VA = "0x1882B1670", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, object BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class PIPDJDKKIFC : Property<DOFGPFODPJF, JJDJNNFCKLB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x82B28A0", Offset = "0x82B14A0", VA = "0x1882B28A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82B2860", Offset = "0x82B1460", VA = "0x1882B2860")]
		public PIPDJDKKIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82B2810", Offset = "0x82B1410", VA = "0x1882B2810", Slot = "14")]
		public override JJDJNNFCKLB GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82B2830", Offset = "0x82B1430", VA = "0x1882B2830", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, JJDJNNFCKLB BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class JAMLNAELJII : Property<DOFGPFODPJF, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x82B12C0", Offset = "0x82AFEC0", VA = "0x1882B12C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x82B1280", Offset = "0x82AFE80", VA = "0x1882B1280")]
		public JAMLNAELJII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x82B1230", Offset = "0x82AFE30", VA = "0x1882B1230", Slot = "14")]
		public override Delegate GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x82B1250", Offset = "0x82AFE50", VA = "0x1882B1250", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, Delegate BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class JICABDKCNDC : Property<DOFGPFODPJF, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x82B1380", Offset = "0x82AFF80", VA = "0x1882B1380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x82B1340", Offset = "0x82AFF40", VA = "0x1882B1340")]
		public JICABDKCNDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x82B12F0", Offset = "0x82AFEF0", VA = "0x1882B12F0", Slot = "14")]
		public override Delegate GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82B1310", Offset = "0x82AFF10", VA = "0x1882B1310", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, Delegate BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class MIAKINJIPIA : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x82B1E50", Offset = "0x82B0A50", VA = "0x1882B1E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82B1E10", Offset = "0x82B0A10", VA = "0x1882B1E10")]
		public MIAKINJIPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x82B1DC0", Offset = "0x82B09C0", VA = "0x1882B1DC0", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x82B1DE0", Offset = "0x82B09E0", VA = "0x1882B1DE0", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class MCEHPAMOJHA : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x82B1C30", Offset = "0x82B0830", VA = "0x1882B1C30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82B1BF0", Offset = "0x82B07F0", VA = "0x1882B1BF0")]
		public MCEHPAMOJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82B1BA0", Offset = "0x82B07A0", VA = "0x1882B1BA0", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x82B1BC0", Offset = "0x82B07C0", VA = "0x1882B1BC0", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class CAMPMLEGFAC : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x82B0060", Offset = "0x82AEC60", VA = "0x1882B0060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x82B0020", Offset = "0x82AEC20", VA = "0x1882B0020")]
		public CAMPMLEGFAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82AFFD0", Offset = "0x82AEBD0", VA = "0x1882AFFD0", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x82AFFF0", Offset = "0x82AEBF0", VA = "0x1882AFFF0", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class JNCJIMMCNNC : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x82B1470", Offset = "0x82B0070", VA = "0x1882B1470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82B1430", Offset = "0x82B0030", VA = "0x1882B1430")]
		public JNCJIMMCNNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x82B13E0", Offset = "0x82AFFE0", VA = "0x1882B13E0", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82B1400", Offset = "0x82B0000", VA = "0x1882B1400", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class GNODFAMPAID : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x82B0EC0", Offset = "0x82AFAC0", VA = "0x1882B0EC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82B0E80", Offset = "0x82AFA80", VA = "0x1882B0E80")]
		public GNODFAMPAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82B0E30", Offset = "0x82AFA30", VA = "0x1882B0E30", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x82B0E50", Offset = "0x82AFA50", VA = "0x1882B0E50", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class MFDDENOLMOM : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x82B1D50", Offset = "0x82B0950", VA = "0x1882B1D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82B1D10", Offset = "0x82B0910", VA = "0x1882B1D10")]
		public MFDDENOLMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x82B1CC0", Offset = "0x82B08C0", VA = "0x1882B1CC0", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82B1CE0", Offset = "0x82B08E0", VA = "0x1882B1CE0", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class HBGGPEADOJP : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x82B0F80", Offset = "0x82AFB80", VA = "0x1882B0F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82B0F40", Offset = "0x82AFB40", VA = "0x1882B0F40")]
		public HBGGPEADOJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82B0EF0", Offset = "0x82AFAF0", VA = "0x1882B0EF0", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82B0F10", Offset = "0x82AFB10", VA = "0x1882B0F10", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class KBMPGKLKAPN : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x82B1620", Offset = "0x82B0220", VA = "0x1882B1620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x82B15E0", Offset = "0x82B01E0", VA = "0x1882B15E0")]
		public KBMPGKLKAPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x82B1590", Offset = "0x82B0190", VA = "0x1882B1590", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x82B15B0", Offset = "0x82B01B0", VA = "0x1882B15B0", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class GAONDJKNHIF : Property<DOFGPFODPJF, EAICLJOGAIB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x82B0A50", Offset = "0x82AF650", VA = "0x1882B0A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x82B0A10", Offset = "0x82AF610", VA = "0x1882B0A10")]
		public GAONDJKNHIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82B09C0", Offset = "0x82AF5C0", VA = "0x1882B09C0", Slot = "14")]
		public override EAICLJOGAIB<Delegate> GetValue(DOFGPFODPJF EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x82B09E0", Offset = "0x82AF5E0", VA = "0x1882B09E0", Slot = "15")]
		public override void SetValue(DOFGPFODPJF EHEGCBFMKDA, EAICLJOGAIB<Delegate> BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82B1EF0", Offset = "0x82B0AF0", VA = "0x1882B1EF0")]
	public MPKHDNCFLEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class CICPPNGBLJC : ContainerPropertyBag<EAICLJOGAIB<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x82B0200", Offset = "0x82AEE00", VA = "0x1882B0200")]
	public CICPPNGBLJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class PPONADACHED : ContainerPropertyBag<MLLBPPJONKI>
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	private class OAKGMDIBEKI : Property<MLLBPPJONKI, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x82B26B0", Offset = "0x82B12B0", VA = "0x1882B26B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x82B2670", Offset = "0x82B1270", VA = "0x1882B2670")]
		public OAKGMDIBEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF10", Offset = "0x82AEB10", VA = "0x1882AFF10", Slot = "14")]
		public override Rigidbody GetValue(MLLBPPJONKI EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF30", Offset = "0x82AEB30", VA = "0x1882AFF30", Slot = "15")]
		public override void SetValue(MLLBPPJONKI EHEGCBFMKDA, Rigidbody BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x82B2960", Offset = "0x82B1560", VA = "0x1882B2960")]
	public PPONADACHED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class HJBIFGIIELO : ContainerPropertyBag<HGPHCKOBFMH>
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	private class FGLCEHMFAPO : Property<HGPHCKOBFMH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x82B0890", Offset = "0x82AF490", VA = "0x1882B0890", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x82B0850", Offset = "0x82AF450", VA = "0x1882B0850")]
		public FGLCEHMFAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF10", Offset = "0x82AEB10", VA = "0x1882AFF10", Slot = "14")]
		public override object GetValue(HGPHCKOBFMH EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF30", Offset = "0x82AEB30", VA = "0x1882AFF30", Slot = "15")]
		public override void SetValue(HGPHCKOBFMH EHEGCBFMKDA, object BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82B1020", Offset = "0x82AFC20", VA = "0x1882B1020")]
	public HJBIFGIIELO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class CPPJJECOJLF : ContainerPropertyBag<PAHPMFLLJJH>
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	private class EHGJIEJMOGD : Property<PAHPMFLLJJH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x82B0560", Offset = "0x82AF160", VA = "0x1882B0560", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x82B0520", Offset = "0x82AF120", VA = "0x1882B0520")]
		public EHGJIEJMOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF10", Offset = "0x82AEB10", VA = "0x1882AFF10", Slot = "14")]
		public override object GetValue(PAHPMFLLJJH EHEGCBFMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x82AFF30", Offset = "0x82AEB30", VA = "0x1882AFF30", Slot = "15")]
		public override void SetValue(PAHPMFLLJJH EHEGCBFMKDA, object BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x82B0290", Offset = "0x82AEE90", VA = "0x1882B0290")]
	public CPPJJECOJLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class DAGAAPKJNJH : ContainerPropertyBag<MFBNGKFFKHK>
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class LIGGLPOIEIM : Property<MFBNGKFFKHK, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x82B1B70", Offset = "0x82B0770", VA = "0x1882B1B70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x82B1B30", Offset = "0x82B0730", VA = "0x1882B1B30")]
		public LIGGLPOIEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAC36E0", Offset = "0xAC22E0", VA = "0x180AC36E0", Slot = "14")]
		public override Entity GetValue(MFBNGKFFKHK EHEGCBFMKDA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x82B1B20", Offset = "0x82B0720", VA = "0x1882B1B20", Slot = "15")]
		public override void SetValue(MFBNGKFFKHK EHEGCBFMKDA, Entity BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x82B0370", Offset = "0x82AEF70", VA = "0x1882B0370")]
	public DAGAAPKJNJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class LGJHNFDHLEN : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class EOLFDDJNNEE : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x82B0820", Offset = "0x82AF420", VA = "0x1882B0820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x82B07E0", Offset = "0x82AF3E0", VA = "0x1882B07E0")]
		public EOLFDDJNNEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2427140", Offset = "0x2425D40", VA = "0x182427140", Slot = "14")]
		public override int GetValue(Entity EHEGCBFMKDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x809EF60", Offset = "0x809DB60", VA = "0x18809EF60", Slot = "15")]
		public override void SetValue(Entity EHEGCBFMKDA, int BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class IHACEADMFFB : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string FEGHCLOCPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x82B1200", Offset = "0x82AFE00", VA = "0x1882B1200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool OBFGHCLKFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x82B11C0", Offset = "0x82AFDC0", VA = "0x1882B11C0")]
		public IHACEADMFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x13573D0", Offset = "0x1355FD0", VA = "0x1813573D0", Slot = "14")]
		public override int GetValue(Entity EHEGCBFMKDA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x82B11B0", Offset = "0x82AFDB0", VA = "0x1882B11B0", Slot = "15")]
		public override void SetValue(Entity EHEGCBFMKDA, int BKMPCFIAHIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x82B1950", Offset = "0x82B0550", VA = "0x1882B1950")]
	public LGJHNFDHLEN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x82B2A40", Offset = "0x82B1640", VA = "0x1882B2A40")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class MBCOCJPKMMG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MBCOCJPKMMG()
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

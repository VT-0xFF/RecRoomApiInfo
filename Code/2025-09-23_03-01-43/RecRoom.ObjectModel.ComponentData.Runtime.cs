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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x86B82A0", Offset = "0x86B68A0", VA = "0x1886B82A0", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86B8650", Offset = "0x86B6C50", VA = "0x1886B8650", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29CB0D0", Offset = "0x29C96D0", VA = "0x1829CB0D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct GENDLIAEJNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct IJJDAPHJIIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct EFCCKGKIOHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct GBPFACBMLPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct GBMCJFGIPKH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, LDBPIHKDINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86B5540", Offset = "0x86B3B40", VA = "0x1886B5540", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct EJGGCNLOPLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct CLLPHOLBLJM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct PHKMIEFDMKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity KGLDGPAOPBI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct IJCNEIFKNMB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity KGLDGPAOPBI;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HNMAOCBOPFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<BPEGJCFPHOA> ECMHDBMLNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> IMJMHCHKPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle BJFLKGBEEDK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OBNBONBFFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86B64B0", Offset = "0x86B4AB0", VA = "0x1886B64B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86B6340", Offset = "0x86B4940", VA = "0x1886B6340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x631A7F0", Offset = "0x6318DF0", VA = "0x18631A7F0")]
	public HNMAOCBOPFC(NativeList<BPEGJCFPHOA> ECMHDBMLNPI, NativeList<Entity> IMJMHCHKPBM, JobHandle BJFLKGBEEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x86B6390", Offset = "0x86B4990", VA = "0x1886B6390")]
	public (Entity, NativeSlice<Entity>) JKAIBAAFOLE(int ENCGNPAFEED)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x86B62E0", Offset = "0x86B48E0", VA = "0x1886B62E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BPEGJCFPHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity BOCNDANOLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int PIOCNHLFCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int NODGHDHCBPE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FJEOIKNPIGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLHJKPMKOMJ(bool ECGIKIIHHJL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AEJMIEKMDCM : IEquatable<AEJMIEKMDCM>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool BAFHEAGOAAM(int MGHFDLLINAI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool IDIAGEDIELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool NKLOAAMLPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool EPOCLEHONHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool IKIGGNNAEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BAFHEAGOAAM ONJKJIJBLML;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86B5340", Offset = "0x86B3940", VA = "0x1886B5340")]
	public AEJMIEKMDCM(HEODPNLMNME ANBGOGICGFD, BAFHEAGOAAM ONJKJIJBLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x86B5390", Offset = "0x86B3990", VA = "0x1886B5390")]
	public AEJMIEKMDCM(bool IDIAGEDIELB, bool NKLOAAMLPPL, bool EPOCLEHONHE, bool IKIGGNNAEHM, BAFHEAGOAAM ONJKJIJBLML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x86B5050", Offset = "0x86B3650", VA = "0x1886B5050")]
	public bool CCJONMIDJCJ(int MGHFDLLINAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x86B50A0", Offset = "0x86B36A0", VA = "0x1886B50A0")]
	public bool ELIAKONFKJG(int MGHFDLLINAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x86B5280", Offset = "0x86B3880", VA = "0x1886B5280")]
	public bool NEIOGIGEJKP(int MGHFDLLINAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86B5250", Offset = "0x86B3850", VA = "0x1886B5250")]
	public bool KNPLBJGCPIG(int MGHFDLLINAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x86B50D0", Offset = "0x86B36D0", VA = "0x1886B50D0", Slot = "4")]
	public bool Equals(AEJMIEKMDCM AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86B5100", Offset = "0x86B3700", VA = "0x1886B5100", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x86B51B0", Offset = "0x86B37B0", VA = "0x1886B51B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x86B5080", Offset = "0x86B3680", VA = "0x1886B5080")]
	private bool DCPCKEHCKMB(int MGHFDLLINAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x86B52B0", Offset = "0x86B38B0", VA = "0x1886B52B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class INGAIBEBEAL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public FOHKKODBCBA LLBCHEOKJKH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x86B6700", Offset = "0x86B4D00", VA = "0x1886B6700", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public INGAIBEBEAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FOHKKODBCBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct MEIJKOHODNI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity GHLKJKNDPMH;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct LGDNJIDKAME : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity IINDNIHHNDE;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
public struct DDGMBBDIPJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity EEOKMPCGLJC;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct GHDKOKGPEBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool JPLKBKKHBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool OHABGHBEHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int BFAGJOFNFKP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct PDJLOGEJKEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
[SingletonComponent]
public struct DENLCKIPOOB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Entity JAPNANJIKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Entity MBEMCNLLFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Entity IMNBHPJJKLP;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct NAELNABPFEE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Entity KGLHNAOBPON;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct PKDCJNFKBBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 APHHGJIDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public quaternion LDAEEKEKDJC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct DBNAHHNFCOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct KDFHOJFJGPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly HPIJAFDJGJK COOCNAEDNNJ;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3276BC0", Offset = "0x32751C0", VA = "0x183276BC0")]
	public KDFHOJFJGPA(HPIJAFDJGJK COOCNAEDNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x86B6900", Offset = "0x86B4F00", VA = "0x1886B6900")]
	public KDFHOJFJGPA GPMPBOBEHGA(HPIJAFDJGJK JNAMBJCGLLO)
	{
		return default(KDFHOJFJGPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x86B68F0", Offset = "0x86B4EF0", VA = "0x1886B68F0")]
	public KDFHOJFJGPA CCOBOLLDOLE(HPIJAFDJGJK HJHMOIEOOBC)
	{
		return default(KDFHOJFJGPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86B6910", Offset = "0x86B4F10", VA = "0x1886B6910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Flags]
public enum HPIJAFDJGJK : ushort
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
public static class PBPOHKDILAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct HGGJFHIMNCE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public HPIJAFDJGJK IAMBJPONLDI;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86B62B0", Offset = "0x86B48B0", VA = "0x1886B62B0")]
	public bool HAMJHMMANOP(KDFHOJFJGPA AFMNMICPFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x86B62C0", Offset = "0x86B48C0", VA = "0x1886B62C0")]
	public bool IMFLIDPJFLB(KDFHOJFJGPA AFMNMICPFJF, HPIJAFDJGJK EBDHAPJLLKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum GNNGOOHJLPH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct DINDILAINEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GNNGOOHJLPH COOCNAEDNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public bool DCEMAPLHDJB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PHMPOMENLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86B5C40", Offset = "0x86B4240", VA = "0x1886B5C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x86B5C50", Offset = "0x86B4250", VA = "0x1886B5C50")]
	private DINDILAINEE(GNNGOOHJLPH COOCNAEDNNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x86B5C20", Offset = "0x86B4220", VA = "0x1886B5C20")]
	public DINDILAINEE GPMPBOBEHGA(GNNGOOHJLPH JNAMBJCGLLO)
	{
		return default(DINDILAINEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x86B5C00", Offset = "0x86B4200", VA = "0x1886B5C00")]
	public DINDILAINEE CCOBOLLDOLE(GNNGOOHJLPH HJHMOIEOOBC)
	{
		return default(DINDILAINEE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct CEBJGNHCDGP : IComponentData
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
public struct FCDCDBDPPBH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity OHNKOPEMOEL;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, LDBPIHKDINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86B5540", Offset = "0x86B3B40", VA = "0x1886B5540", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct OLNLGAELNKH : ISystemStateBufferElementData, IBufferElementData, LDBPIHKDINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity JAPNANJIKLB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity CAKIIDEDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct NBMEICBJHLF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity PBEMEBAEKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity JDGAFAJMIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity MPLJGMGMODH;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JCCEFEEJGJO<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly bool GLJIKBGGLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint KKEJFIEPAPA;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool NNFLCGAJFPK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct CNMLBBOADAJ : IBufferElementData, IEquatable<CNMLBBOADAJ>, LDBPIHKDINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity CBEKJHOJHDO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity DADGKOMEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86B5540", Offset = "0x86B3B40", VA = "0x1886B5540", Slot = "4")]
	public bool Equals(CNMLBBOADAJ AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct DPNIAKPBFKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint CIJDNPLAPAA;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
	public DPNIAKPBFKL(NEKBNCKOEOB MLCIEJIIPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86B5D20", Offset = "0x86B4320", VA = "0x1886B5D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x21D6500", Offset = "0x21D4B00", VA = "0x1821D6500")]
	public static DPNIAKPBFKL HNGLNPFKABH(NEKBNCKOEOB MLCIEJIIPCN)
	{
		return default(DPNIAKPBFKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct DPCDEHNELDG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Entity JAPNANJIKLB;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct PEMIKCLNFBO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public NEKBNCKOEOB KOPHBHGIACG;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct ABCBIGJDIFF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity JAPNANJIKLB;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct KMMGLHNNGBH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid JJCLDINKIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int LMJBLNOIBOL;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct BALGOBLKNKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int KOPHBHGIACG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct NAOEPHFFALF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity JAPNANJIKLB;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct MCDJEJAPDKH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NEKBNCKOEOB KOPHBHGIACG;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct PNFPKMCGLFA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity JAPNANJIKLB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct MJGLONHLANH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct LPFCLICFFHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int OIFMJLAHCKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct BMKMAHFDKBM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int JPKKOPNBEKB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NOCCEEEBCMN LPEGIPJBBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450")]
		get
		{
			return default(NOCCEEEBCMN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct HGFAGGILHEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GCHandle PCBJMKANMJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct AIEOGKJDGFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct COBJNGFHHOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct MGNMDKJECJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct JLADNLGPLPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct LANPBFCPAGG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct PHJGEBKHKEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public int PMIGBJGNLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int AENIMEGPBEO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x86B7960", Offset = "0x86B5F60", VA = "0x1886B7960")]
	public PHJGEBKHKEI(Entity JAPNANJIKLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct PFAFFMIONIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CollisionDetectionMode CEOKCFELEHI;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct FJBPHKABGNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public AHNGGBKKFOE OACAMIMDAGC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly FJBPHKABGNK DKABDBMACEB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct BOIEGFONHGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct KPIEALOIFFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct EKAMPKLDPAP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct ANMGDBDMIIN : IBufferElementData, IEquatable<ANMGDBDMIIN>, LDBPIHKDINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Entity PEKDBPKONMC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity DADGKOMEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x86B5540", Offset = "0x86B3B40", VA = "0x1886B5540", Slot = "4")]
	public bool Equals(ANMGDBDMIIN AAGCKLPFJME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct GMMJBKAHOEB : IComponentData, LDBPIHKDINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Entity BEBONNCPGLF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity DADGKOMEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct CCDLHDOILGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct GLCDJFKAINO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity BOCNDANOLJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct KOICJACFEIL : JBMENPDAFLO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KKEEAGOOBJN OFOPPBFBONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KKEEAGOOBJN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct FBOIHGHBCAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 CADNMDCAAFA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct MAMKGACMAFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct IDNHKEHCPKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3x3 OPHOLPNMGIB;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IDNHKEHCPKN DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct PDJMNGCOAOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float3x3 OPHOLPNMGIB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly PDJMNGCOAOP DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct ONIDIFMPLIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float3 FDFODBEFLDL;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct JDBMMGALBHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float3 BAIDGDMCMHD;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct KFDFHOGOHHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float GBEPMFMOIOL;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly KFDFHOGOHHO DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct COIKECKCEJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float MJMKGABGKJE;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly COIKECKCEJG DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct OGKIDPJFIAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 HGPMPPHFMID;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct DFEJHLCKGPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public FMEBMDLLDAA ECFMGNDDOAN;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct NBBBENBNBJG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Entity JAPNANJIKLB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct BLNKOOPAAEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct DMLNDBCAFNG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct DFOOCJOPGNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public RigidbodyConstraints NMHLAJBHIIC;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct BOJLLEFPEOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float MNJJHIIOEMF;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly BOJLLEFPEOG DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct IHHHCCIFJDA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float DOJNFLMGJGC;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LGHDIHHAPHC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GameObject JJEACKINPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public object PACJHOIGNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public object OEHIILGIAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public GDGJFLEDIKD DOJBOEGBBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Delegate HEMHJEPKDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Delegate HHLJEPCEAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public BEHKKOBPFOO<Delegate> HOGAENEOBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public BEHKKOBPFOO<Delegate> NMCBNDJOPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public BEHKKOBPFOO<Delegate> LIEOJOCOBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public BEHKKOBPFOO<Delegate> JCKHMLBCHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public BEHKKOBPFOO<Delegate> MGPHDKBDLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public BEHKKOBPFOO<Delegate> IDBHNPDLFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public BEHKKOBPFOO<Delegate> NPFJOPJIGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public BEHKKOBPFOO<Delegate> CBBMGAAMCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public BEHKKOBPFOO<Delegate> OIHCGKAJKOB;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86B7160", Offset = "0x86B5760", VA = "0x1886B7160", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public LGHDIHHAPHC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct LDNPHAABEMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct LBEGBIBAIAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct COBDDONIBKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int CABAPDGFOOE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x21D6500", Offset = "0x21D4B00", VA = "0x1821D6500")]
	public static COBDDONIBKJ HNGLNPFKABH(int KOPHBHGIACG)
	{
		return default(COBDDONIBKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DANBIJMKIHN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Rigidbody CCIMPGNIBAH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x86B5B90", Offset = "0x86B4190", VA = "0x1886B5B90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public DANBIJMKIHN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct KAJFACCHHNP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct EPOKJEGANIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 PCNHEAPIMMO;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct ODEHLKEGLBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 EJLBFNGBOJC;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct BJNDMGJFCGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float KJOOMDLGCPL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly BJNDMGJFCGI DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KNANMEPCPFO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object NNAMNGDEOGL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x86B6A90", Offset = "0x86B5090", VA = "0x1886B6A90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public KNANMEPCPFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PLFLGMNKPGA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public object KAPBPABPNIG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x86B7A50", Offset = "0x86B6050", VA = "0x1886B7A50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public PLFLGMNKPGA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct LDFELMKBFHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct HPGLBEFELEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct NFOOMOMDCHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct GNLMGKLJCIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct EBGEEBAMEAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct GIKBCEAOKIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct ADLPAFBPGFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct HCPGMKLCHNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct ABOOHPALKAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct IMPIIHCDFKI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct GIIAEDMNKEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public MLPFDOKAHEM HDJBBJKIGDL;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86B60C0", Offset = "0x86B46C0", VA = "0x1886B60C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct OAKIKDIBMPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct GOEINMCPMOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct BOFPKOBPLCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct BLIANAMLENK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FixedString32Bytes NDIENANOGEK;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct JCBCFHKFNHP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public UnsafeParallelHashMap<MLPFDOKAHEM, Entity> JFHNGLILOCE;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct OCDKANOFBJC : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity HJENDPCHHNB;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct KAOLGBKOAHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity JAPNANJIKLB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static KAOLGBKOAHI HNGLNPFKABH(Entity JAPNANJIKLB)
	{
		return default(KAOLGBKOAHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct ALLIOLFFJFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity PBJPFCHCEDC;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct IDHBDGCBIDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity PBJPFCHCEDC;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct PJHGHHFOEKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity MODHGAICCLA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xE29190", Offset = "0xE27790", VA = "0x180E29190")]
	public static PJHGHHFOEKD HNGLNPFKABH(Entity JAPNANJIKLB)
	{
		return default(PJHGHHFOEKD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct POOFBKIACAD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct NJNCPJOPDLB : IBufferElementData, IEquatable<NJNCPJOPDLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity EBFGEDGGNBO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84A3640", Offset = "0x84A1C40", VA = "0x1884A3640", Slot = "4")]
	public bool Equals(NJNCPJOPDLB AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86B75C0", Offset = "0x86B5BC0", VA = "0x1886B75C0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct ALKNOMOGFGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint AENIMEGPBEO;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct NLJPMHAGJKC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity JEDFFEPHGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public int PMIGBJGNLLP;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct PJBGKJGGLGG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity CDGMNFKFLKC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct HMHNECLFMIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct HDJONKBFJOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public uint KKEJFIEPAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int DDDPFPLABOA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
	public HDJONKBFJOH(uint NCJADJOJMCG, int IKOOOILEGKC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct NMNLLLENLOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct LCKNPHFGIIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct OJMLEOJLPPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct HKMBOLFNILC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct AOFLOIAOJAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct NIBJOFMAMEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct NBFFEGNAPGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct GBENKEAAJOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct EPMEEJPEFBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct POGBMCNNJMH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct AGIGGMKCFED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct DAMINJMIAMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct INEFEOBKALL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct ADJGOFPJGDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct ABHFBBDDBMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct JECPNCHBBKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct BIJCFEBCAIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct PKFOOEIHPON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct BMJCFOOKBMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct IENKNJKCECF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct EHIPONPJEID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct ONCMFDDCOBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
public struct HIGJJLMJMIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct LCIJBLMLKCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct HCHONFKEAIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct FGEDAMMLDGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct MBOKHPDOKOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct EGHHBAEEKJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct IKABMOONIEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct NNMDJGLIAAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct PNKDLJACJOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct KHAIHLMIJBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct DPJOAHINCHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct NDDANLMGNCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[BJDJCOCFGGP]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct BLJLNNCKMIN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct KFNPKGAIEEC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedString32Bytes PEIEJMGOHLN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct CHIMMOHFIPB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct EDJAAHKMAFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct PODAHBDKBGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct IIBAGODFJGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct AOACCINMFCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct GLGIBALEAJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(15820134490602808056uL)]
public struct MLEIDLMAEMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public int OJNBNNADNJG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct KEHJOIBABHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct KGHPGHHKJIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion LDAEEKEKDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 APHHGJIDDCM;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct LNMEEBBMIJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float KALKGKIFIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float HFAAOFLAPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float DICFKKHIIPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct GBGOOANNHHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct BEIKCCFBHFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct NOAKMJDBGDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct KKMGCBOADHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int JPKKOPNBEKB;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct BDOMEGDOHBE : ISystemStateBufferElementData, IBufferElementData, LDBPIHKDINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity LMKHOCAFFFE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity CAKIIDEDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct EGFODLHFEBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float4x4 BIDFECCCCEE;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly EGFODLHFEBN DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct FHPDLHIFIKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float4x4 PDKLFCKPAOP;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly FHPDLHIFIKK DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct KMONJHNMLAL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int NEPLMDEKFCE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int PMIGBJGNLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86B6A70", Offset = "0x86B5070", VA = "0x1886B6A70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86B6A80", Offset = "0x86B5080", VA = "0x1886B6A80")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
[RegisterComponentDefault]
public struct BDCHGCCEOFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float3 APHHGJIDDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public quaternion LDAEEKEKDJC;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly BDCHGCCEOFK DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class JDABEEABDJN
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
[RegisterComponentDefault]
public struct HCLJFHMEGON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public float PJJCAEDHCKM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly HCLJFHMEGON DKABDBMACEB;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct BEPDHEBADDG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Entity DIHEIGLHFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public INIBMAJCADC LJNIMHNLCFF;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct BLMLJPMNJKB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public INIBMAJCADC LJNIMHNLCFF;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct BFEDJNBJNKK : ISystemStateComponentData, IComponentData, LDBPIHKDINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Entity PCLFJGMAHBI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity CAKIIDEDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct OIPEAPJMKOO : ISystemStateBufferElementData, IBufferElementData, LDBPIHKDINF, IEquatable<OIPEAPJMKOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity AACLLEKPCIE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity CAKIIDEDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84A3640", Offset = "0x84A1C40", VA = "0x1884A3640", Slot = "6")]
	public bool Equals(OIPEAPJMKOO AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x86B7710", Offset = "0x86B5D10", VA = "0x1886B7710", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct KGBFGHDILAE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Entity DIHEIGLHFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public INIBMAJCADC LJNIMHNLCFF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct PPHLIIPFIEF : IEqualityComparer<KGBFGHDILAE>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static PPHLIIPFIEF DKABDBMACEB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x86B7AC0", Offset = "0x86B60C0", VA = "0x1886B7AC0", Slot = "4")]
	public bool Equals(KGBFGHDILAE GBNAKFLHCOE, KGBFGHDILAE ODEKEFJCIIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x86B7B10", Offset = "0x86B6110", VA = "0x1886B7B10", Slot = "5")]
	public int GetHashCode(KGBFGHDILAE MPIDDJPOOMJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct NELJBPBHKCD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public FixedList32Bytes<int> GFELOCNKDDG;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct DFEDEOOECDK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public FixedList32Bytes<int> GFELOCNKDDG;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct CCBJGPLMFNE : ISystemStateBufferElementData, IBufferElementData, LDBPIHKDINF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Entity AAKIOJLABGL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity DADGKOMEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1404BB0", Offset = "0x14031B0", VA = "0x181404BB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class HPLHLCCHOMF : ContainerPropertyBag<INGAIBEBEAL>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class AOHNONBCLCI : Property<INGAIBEBEAL, FOHKKODBCBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x86B5590", Offset = "0x86B3B90", VA = "0x1886B5590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x86B5550", Offset = "0x86B3B50", VA = "0x1886B5550")]
		public AOHNONBCLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x86B53C0", Offset = "0x86B39C0", VA = "0x1886B53C0", Slot = "14")]
		public override FOHKKODBCBA GetValue(INGAIBEBEAL JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x86B53E0", Offset = "0x86B39E0", VA = "0x1886B53E0", Slot = "15")]
		public override void SetValue(INGAIBEBEAL JBBCAANONNB, FOHKKODBCBA KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x86B6520", Offset = "0x86B4B20", VA = "0x1886B6520")]
	public HPLHLCCHOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class LBOCMPDDKFF : ContainerPropertyBag<LGHDIHHAPHC>
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class AFCJNBOFIDD : Property<LGHDIHHAPHC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x86B5450", Offset = "0x86B3A50", VA = "0x1886B5450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86B5410", Offset = "0x86B3A10", VA = "0x1886B5410")]
		public AFCJNBOFIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86B53C0", Offset = "0x86B39C0", VA = "0x1886B53C0", Slot = "14")]
		public override GameObject GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86B53E0", Offset = "0x86B39E0", VA = "0x1886B53E0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, GameObject KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class KJLNGNAHJCN : Property<LGHDIHHAPHC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x86B6A40", Offset = "0x86B5040", VA = "0x1886B6A40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86B6A00", Offset = "0x86B5000", VA = "0x1886B6A00")]
		public KJLNGNAHJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86B69B0", Offset = "0x86B4FB0", VA = "0x1886B69B0", Slot = "14")]
		public override object GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86B69D0", Offset = "0x86B4FD0", VA = "0x1886B69D0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, object KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class LMHJGGKFHBG : Property<LGHDIHHAPHC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x86B72B0", Offset = "0x86B58B0", VA = "0x1886B72B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86B7270", Offset = "0x86B5870", VA = "0x1886B7270")]
		public LMHJGGKFHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86B7220", Offset = "0x86B5820", VA = "0x1886B7220", Slot = "14")]
		public override object GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86B7240", Offset = "0x86B5840", VA = "0x1886B7240", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, object KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class CCNPOCCLOMP : Property<LGHDIHHAPHC, GDGJFLEDIKD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x86B58C0", Offset = "0x86B3EC0", VA = "0x1886B58C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86B5880", Offset = "0x86B3E80", VA = "0x1886B5880")]
		public CCNPOCCLOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x86B5830", Offset = "0x86B3E30", VA = "0x1886B5830", Slot = "14")]
		public override GDGJFLEDIKD GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x86B5850", Offset = "0x86B3E50", VA = "0x1886B5850", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, GDGJFLEDIKD KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class CKIFOABLMDH : Property<LGHDIHHAPHC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x86B5A60", Offset = "0x86B4060", VA = "0x1886B5A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86B5A20", Offset = "0x86B4020", VA = "0x1886B5A20")]
		public CKIFOABLMDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86B59D0", Offset = "0x86B3FD0", VA = "0x1886B59D0", Slot = "14")]
		public override Delegate GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86B59F0", Offset = "0x86B3FF0", VA = "0x1886B59F0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, Delegate KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class BNPAIHNFDCP : Property<LGHDIHHAPHC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x86B57C0", Offset = "0x86B3DC0", VA = "0x1886B57C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86B5780", Offset = "0x86B3D80", VA = "0x1886B5780")]
		public BNPAIHNFDCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86B5730", Offset = "0x86B3D30", VA = "0x1886B5730", Slot = "14")]
		public override Delegate GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86B5750", Offset = "0x86B3D50", VA = "0x1886B5750", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, Delegate KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class JGIPGHEMMIM : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x86B68C0", Offset = "0x86B4EC0", VA = "0x1886B68C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x86B6880", Offset = "0x86B4E80", VA = "0x1886B6880")]
		public JGIPGHEMMIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x86B6830", Offset = "0x86B4E30", VA = "0x1886B6830", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x86B6850", Offset = "0x86B4E50", VA = "0x1886B6850", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class MFJJNGEKLJD : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x86B7450", Offset = "0x86B5A50", VA = "0x1886B7450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x86B7410", Offset = "0x86B5A10", VA = "0x1886B7410")]
		public MFJJNGEKLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x86B73C0", Offset = "0x86B59C0", VA = "0x1886B73C0", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x86B73E0", Offset = "0x86B59E0", VA = "0x1886B73E0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class CMKFEAONGPA : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x86B5B20", Offset = "0x86B4120", VA = "0x1886B5B20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x86B5AE0", Offset = "0x86B40E0", VA = "0x1886B5AE0")]
		public CMKFEAONGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86B5A90", Offset = "0x86B4090", VA = "0x1886B5A90", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x86B5AB0", Offset = "0x86B40B0", VA = "0x1886B5AB0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class PBDHPPICLJF : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x86B7830", Offset = "0x86B5E30", VA = "0x1886B7830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x86B77F0", Offset = "0x86B5DF0", VA = "0x1886B77F0")]
		public PBDHPPICLJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x86B77A0", Offset = "0x86B5DA0", VA = "0x1886B77A0", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x86B77C0", Offset = "0x86B5DC0", VA = "0x1886B77C0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class AEABJEHCIHG : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x86B5020", Offset = "0x86B3620", VA = "0x1886B5020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x86B4FE0", Offset = "0x86B35E0", VA = "0x1886B4FE0")]
		public AEABJEHCIHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86B4F90", Offset = "0x86B3590", VA = "0x1886B4F90", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86B4FB0", Offset = "0x86B35B0", VA = "0x1886B4FB0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class OGJDKBEHJND : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x86B76E0", Offset = "0x86B5CE0", VA = "0x1886B76E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x86B76A0", Offset = "0x86B5CA0", VA = "0x1886B76A0")]
		public OGJDKBEHJND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x86B7650", Offset = "0x86B5C50", VA = "0x1886B7650", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x86B7670", Offset = "0x86B5C70", VA = "0x1886B7670", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class ANAOBBHBMDL : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x86B5510", Offset = "0x86B3B10", VA = "0x1886B5510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86B54D0", Offset = "0x86B3AD0", VA = "0x1886B54D0")]
		public ANAOBBHBMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x86B5480", Offset = "0x86B3A80", VA = "0x1886B5480", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86B54A0", Offset = "0x86B3AA0", VA = "0x1886B54A0", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class DJAOEMJDKHH : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x86B5CF0", Offset = "0x86B42F0", VA = "0x1886B5CF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x86B5CB0", Offset = "0x86B42B0", VA = "0x1886B5CB0")]
		public DJAOEMJDKHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x86B5C60", Offset = "0x86B4260", VA = "0x1886B5C60", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86B5C80", Offset = "0x86B4280", VA = "0x1886B5C80", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class INOKNIOKFFB : Property<LGHDIHHAPHC, BEHKKOBPFOO<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x86B6800", Offset = "0x86B4E00", VA = "0x1886B6800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86B67C0", Offset = "0x86B4DC0", VA = "0x1886B67C0")]
		public INOKNIOKFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x86B6770", Offset = "0x86B4D70", VA = "0x1886B6770", Slot = "14")]
		public override BEHKKOBPFOO<Delegate> GetValue(LGHDIHHAPHC JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x86B6790", Offset = "0x86B4D90", VA = "0x1886B6790", Slot = "15")]
		public override void SetValue(LGHDIHHAPHC JBBCAANONNB, BEHKKOBPFOO<Delegate> KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x86B6B00", Offset = "0x86B5100", VA = "0x1886B6B00")]
	public LBOCMPDDKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class AAJPOOMOLAI : ContainerPropertyBag<BEHKKOBPFOO<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x86B4F30", Offset = "0x86B3530", VA = "0x1886B4F30")]
	public AAJPOOMOLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class GLDMHLOLOLC : ContainerPropertyBag<DANBIJMKIHN>
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	private class LIAELJPCFNK : Property<DANBIJMKIHN, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x86B71F0", Offset = "0x86B57F0", VA = "0x1886B71F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x86B71B0", Offset = "0x86B57B0", VA = "0x1886B71B0")]
		public LIAELJPCFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86B53C0", Offset = "0x86B39C0", VA = "0x1886B53C0", Slot = "14")]
		public override Rigidbody GetValue(DANBIJMKIHN JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86B53E0", Offset = "0x86B39E0", VA = "0x1886B53E0", Slot = "15")]
		public override void SetValue(DANBIJMKIHN JBBCAANONNB, Rigidbody KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x86B6110", Offset = "0x86B4710", VA = "0x1886B6110")]
	public GLDMHLOLOLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class PKAPNOLKDLF : ContainerPropertyBag<KNANMEPCPFO>
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	private class EDMMGOHAJKL : Property<KNANMEPCPFO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x86B5E70", Offset = "0x86B4470", VA = "0x1886B5E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x86B5E30", Offset = "0x86B4430", VA = "0x1886B5E30")]
		public EDMMGOHAJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x86B53C0", Offset = "0x86B39C0", VA = "0x1886B53C0", Slot = "14")]
		public override object GetValue(KNANMEPCPFO JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x86B53E0", Offset = "0x86B39E0", VA = "0x1886B53E0", Slot = "15")]
		public override void SetValue(KNANMEPCPFO JBBCAANONNB, object KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x86B7970", Offset = "0x86B5F70", VA = "0x1886B7970")]
	public PKAPNOLKDLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class EBIEOIAKCLG : ContainerPropertyBag<PLFLGMNKPGA>
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	private class CEBNPICLFOJ : Property<PLFLGMNKPGA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x86B5930", Offset = "0x86B3F30", VA = "0x1886B5930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86B58F0", Offset = "0x86B3EF0", VA = "0x1886B58F0")]
		public CEBNPICLFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x86B53C0", Offset = "0x86B39C0", VA = "0x1886B53C0", Slot = "14")]
		public override object GetValue(PLFLGMNKPGA JBBCAANONNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x86B53E0", Offset = "0x86B39E0", VA = "0x1886B53E0", Slot = "15")]
		public override void SetValue(PLFLGMNKPGA JBBCAANONNB, object KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x86B5D50", Offset = "0x86B4350", VA = "0x1886B5D50")]
	public EBIEOIAKCLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class MAJCIJDLEGC : ContainerPropertyBag<OCDKANOFBJC>
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class GBGDPNAPHNJ : Property<OCDKANOFBJC, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x86B6090", Offset = "0x86B4690", VA = "0x1886B6090", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x86B6050", Offset = "0x86B4650", VA = "0x1886B6050")]
		public GBGDPNAPHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xB0AC50", Offset = "0xB09250", VA = "0x180B0AC50", Slot = "14")]
		public override Entity GetValue(OCDKANOFBJC JBBCAANONNB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x86B6040", Offset = "0x86B4640", VA = "0x1886B6040", Slot = "15")]
		public override void SetValue(OCDKANOFBJC JBBCAANONNB, Entity KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x86B72E0", Offset = "0x86B58E0", VA = "0x1886B72E0")]
	public MAJCIJDLEGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class NDJIJNCJNGG : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class CFOAGOGFLKL : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x86B59A0", Offset = "0x86B3FA0", VA = "0x1886B59A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x86B5960", Offset = "0x86B3F60", VA = "0x1886B5960")]
		public CFOAGOGFLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x14B5E40", Offset = "0x14B4440", VA = "0x1814B5E40", Slot = "14")]
		public override int GetValue(Entity JBBCAANONNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x849D6B0", Offset = "0x849BCB0", VA = "0x18849D6B0", Slot = "15")]
		public override void SetValue(Entity JBBCAANONNB, int KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class HAKHOKMMGOL : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string EEABAFMMHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x86B6240", Offset = "0x86B4840", VA = "0x1886B6240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool BOFAKENAFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86B6200", Offset = "0x86B4800", VA = "0x1886B6200")]
		public HAKHOKMMGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1416890", Offset = "0x1414E90", VA = "0x181416890", Slot = "14")]
		public override int GetValue(Entity JBBCAANONNB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86B61F0", Offset = "0x86B47F0", VA = "0x1886B61F0", Slot = "15")]
		public override void SetValue(Entity JBBCAANONNB, int KOPHBHGIACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x86B7480", Offset = "0x86B5A80", VA = "0x1886B7480")]
	public NDJIJNCJNGG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x86B7B70", Offset = "0x86B6170", VA = "0x1886B7B70")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class IDEENHLMJMC
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IDEENHLMJMC()
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

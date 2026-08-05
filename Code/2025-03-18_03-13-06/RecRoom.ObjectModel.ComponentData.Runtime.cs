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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7757070", Offset = "0x7756270", VA = "0x187757070", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7757400", Offset = "0x7756600", VA = "0x187757400", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct OKAJKNCEGHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct BFKDHFKEACB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct HOBIOBDCLMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct IOAONCELGJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct FALGAHKBCIE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, OBDHBPANACL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7753F30", Offset = "0x7753130", VA = "0x187753F30", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct NENMELKCPAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct OMIOEEAIABG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity NNDCGCCIFNP;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct FPIJCJAHPKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity NNDCGCCIFNP;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OOPBPCEMIEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<KNNAHAKKMDN> INKKLGKFLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> NOHABFFGIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle IBAHKKADFPN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NLGAJPMMPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7756700", Offset = "0x7755900", VA = "0x187756700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77568F0", Offset = "0x7755AF0", VA = "0x1877568F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5691890", Offset = "0x5690A90", VA = "0x185691890")]
	public OOPBPCEMIEL(NativeList<KNNAHAKKMDN> INKKLGKFLFO, NativeList<Entity> NOHABFFGIJA, JobHandle IBAHKKADFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77567D0", Offset = "0x77559D0", VA = "0x1877567D0")]
	public (Entity, NativeSlice<Entity>) HJBKIBKIPKF(int JMNJKPGAJIF)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7756770", Offset = "0x7755970", VA = "0x187756770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KNNAHAKKMDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity BFPPPKIAFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int DCNPLBBIONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int EEBDBIBAAFF;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FMMAJMBGCNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCMMIJGFODC(bool AHFFDICEGEF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BBCOBMNHEBC : IEquatable<BBCOBMNHEBC>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool LEBAEFLJODF(int MJBKPLCECIO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool KHJBOJPLNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool FAHDABJGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool NJGGELPFNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool MJFNGMCDHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LEBAEFLJODF IMEMAPPBCFP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7754260", Offset = "0x7753460", VA = "0x187754260")]
	public BBCOBMNHEBC(KDCOCJHBCHK BCFKGGKKKIL, LEBAEFLJODF IMEMAPPBCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7754230", Offset = "0x7753430", VA = "0x187754230")]
	public BBCOBMNHEBC(bool KHJBOJPLNMA, bool FAHDABJGFMP, bool NJGGELPFNFK, bool MJFNGMCDHLH, LEBAEFLJODF IMEMAPPBCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7754170", Offset = "0x7753370", VA = "0x187754170")]
	public bool KOLKNOGKEHF(int MJBKPLCECIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7753F70", Offset = "0x7753170", VA = "0x187753F70")]
	public bool CEGPKHDKPPM(int MJBKPLCECIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7754140", Offset = "0x7753340", VA = "0x187754140")]
	public bool HEEOMNDPLEK(int MJBKPLCECIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7753F40", Offset = "0x7753140", VA = "0x187753F40")]
	public bool ALMAAMBFNEG(int MJBKPLCECIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7754070", Offset = "0x7753270", VA = "0x187754070", Slot = "4")]
	public bool Equals(BBCOBMNHEBC LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7753FC0", Offset = "0x77531C0", VA = "0x187753FC0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77540A0", Offset = "0x77532A0", VA = "0x1877540A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7753FA0", Offset = "0x77531A0", VA = "0x187753FA0")]
	private bool ENEJJHIHJGN(int MJBKPLCECIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77541A0", Offset = "0x77533A0", VA = "0x1877541A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct IJBKBHENODO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct HIEDMJENDHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct OEAIJLOGJIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct AHPJJGIEGLN : IBufferElementData, IEquatable<AHPJJGIEGLN>, OBDHBPANACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity OAOLODPFDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int NHENBDOAMOM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity HGMPIGBGJBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7753D30", Offset = "0x7752F30", VA = "0x187753D30", Slot = "4")]
	public bool Equals(AHPJJGIEGLN LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EIAEBCGMMDA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public JLHFMODMEEH MDCLBIIGDEE;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7754880", Offset = "0x7753A80", VA = "0x187754880", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public EIAEBCGMMDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JLHFMODMEEH
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct NIHPJKLHDGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct EMCJIALDFFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly INLMDMNBHFM HOCPDDGNMPO;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BD61F0", Offset = "0x2BD53F0", VA = "0x182BD61F0")]
	public EMCJIALDFFL(INLMDMNBHFM HOCPDDGNMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77549C0", Offset = "0x7753BC0", VA = "0x1877549C0")]
	public EMCJIALDFFL PMGEFPADPPC(INLMDMNBHFM AMIBNJHCEID)
	{
		return default(EMCJIALDFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x77549B0", Offset = "0x7753BB0", VA = "0x1877549B0")]
	public EMCJIALDFFL EJBBNLDDKHF(INLMDMNBHFM CNKFADMIGAP)
	{
		return default(EMCJIALDFFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77549D0", Offset = "0x7753BD0", VA = "0x1877549D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum INLMDMNBHFM : ushort
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
public static class IFEHIBJAPDD
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct LHOAOGMDMNI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public INLMDMNBHFM NFALBICEPCA;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x77562E0", Offset = "0x77554E0", VA = "0x1877562E0")]
	public bool FNBDJDKJFLI(EMCJIALDFFL IKOLDLKBFEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x77562F0", Offset = "0x77554F0", VA = "0x1877562F0")]
	public bool MAMHAEMPHDH(EMCJIALDFFL IKOLDLKBFEC, INLMDMNBHFM EBMOKNJBBOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum DMKFIDIDENP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
[SingletonComponent]
public struct DPFDAAJJGPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DMKFIDIDENP HOCPDDGNMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool CBMEKFIKDNN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PCBBMOFNPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7754840", Offset = "0x7753A40", VA = "0x187754840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7754870", Offset = "0x7753A70", VA = "0x187754870")]
	private DPFDAAJJGPK(DMKFIDIDENP HOCPDDGNMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7754850", Offset = "0x7753A50", VA = "0x187754850")]
	public DPFDAAJJGPK PMGEFPADPPC(DMKFIDIDENP AMIBNJHCEID)
	{
		return default(DPFDAAJJGPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7754820", Offset = "0x7753A20", VA = "0x187754820")]
	public DPFDAAJJGPK EJBBNLDDKHF(DMKFIDIDENP CNKFADMIGAP)
	{
		return default(DPFDAAJJGPK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct CFIHFOEMEPJ : IComponentData
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
public struct IMCNBIFBOED : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity KLGCLGLMPBG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, OBDHBPANACL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7753F30", Offset = "0x7753130", VA = "0x187753F30", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct KFJCHHBPJCF : ISystemStateBufferElementData, IBufferElementData, OBDHBPANACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity JJMNGBLHAJC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity EAFAIKPPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct EPLIFOCKBLF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity DOFHFIGOGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity BIOKBBNFAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity OLHGPHKBDKG;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OCLKNFEAJEB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool IEIFJCLJNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint GLICGCFCKCL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool GGKBPANMIGF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct IEOKEDJKLNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint BKLAEDALOJK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120")]
	public IEOKEDJKLNN(GLJKKHGGAPE MEEPADKGNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77557E0", Offset = "0x77549E0", VA = "0x1877557E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
	public static IEOKEDJKLNN AJAOLMPMCKD(GLJKKHGGAPE MEEPADKGNGG)
	{
		return default(IEOKEDJKLNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct LEGPFACBHJE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity JJMNGBLHAJC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct KAIEIOJBIBF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GLJKKHGGAPE OMFJNFBDJCA;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct MPILCFHOJJC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity JJMNGBLHAJC;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct HGEKODMOKPN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid FGPNICIMMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int IPBKHOJKHLJ;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct CPPHJNAGLCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int OMFJNFBDJCA;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct IAKDEJNJGDC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity JJMNGBLHAJC;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct OHBLCEKAAOA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GLJKKHGGAPE OMFJNFBDJCA;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct GKENCENHGDJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity JJMNGBLHAJC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct NHIHAOGBFGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct BBCELFEKEDM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int IFLGFMNJIEB;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct LGHBKPEOFNK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int ADIMAPFNMNK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NEPEIILKAIK OHPANDMLHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0")]
		get
		{
			return default(NEPEIILKAIK);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct GKPOINLDDDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle INHJDBAIPPO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct EIOPECFFCBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct PHCEAJDJHAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct CAGKKGLCHBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct KPDOLEBIEBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct PPEKNFGLANH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct JMKAICHBHOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int KOOLKCPAFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int LCLBPLEFKON;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7755F60", Offset = "0x7755160", VA = "0x187755F60")]
	public JMKAICHBHOF(Entity JJMNGBLHAJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct GAEHMBINKPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode BPDKLAHHLAG;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct JGMACCCPDME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public OJGJEEMDGCF HLEGOJNDJKK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JGMACCCPDME IDMKIMBBHMK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct OGLLOIPICNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct FIDHFNIJLON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct KKBOCKAILMP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct JAPDNDAEABO : IBufferElementData, IEquatable<JAPDNDAEABO>, OBDHBPANACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity OAOLODPFDMA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity HGMPIGBGJBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7753F30", Offset = "0x7753130", VA = "0x187753F30", Slot = "4")]
	public bool Equals(JAPDNDAEABO LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct BOFAJHLNPHG : IComponentData, OBDHBPANACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity JNGEIJHHFEP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity HGMPIGBGJBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct IKHIFAJCEDC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct HPJAOAHNGML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity BFPPPKIAFBG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct JBNIBFCGOGD : MCMNOGDHFPG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JKNBJEOANBN DAOINGDMGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(JKNBJEOANBN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct ILLBGDCJOIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 MENNJEABNLH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct LEMPLPLBCJB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct NCPCJCAGGND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 JJJBLBAHNIE;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly NCPCJCAGGND IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct AMJNLJODAPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 JJJBLBAHNIE;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly AMJNLJODAPO IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct KLAHADDPHPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 CBCNDKFGLDL;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct DJGLGPDONJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 FCJEGGCJPOM;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct JOOFADLKLHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float IKNCFBOGMHJ;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly JOOFADLKLHB IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct DGMLFADECKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float FAMHEECINGG;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly DGMLFADECKE IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct BOCBIJKCINE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 KMIDEFGABNB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct FKEGEOLAHGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public LEFFBPINKCP LJHEANDAHHF;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct GLPHFOHMALK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity JJMNGBLHAJC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct LEOKPKPPNDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct MKEHPIMGLKO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct HJLEPIGBGBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints PNGJLDCFDLM;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct JDHADGLDPNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float FICKOBECBPI;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly JDHADGLDPNE IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct OLKIHPNCGKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float MCIFMMODLGH;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GGKJHNPEDBJ : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject LNIONOAAAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object FAEAAGHGADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object LGNMFADNHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public CLFEIHJGDEO PLMNOBPOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate HHMPFJFBFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate GBOGGLPDNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public HKOOMBBGJCN<Delegate> MDKDBHLMCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public HKOOMBBGJCN<Delegate> NPBKJLHODIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public HKOOMBBGJCN<Delegate> CDEGCEOKIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public HKOOMBBGJCN<Delegate> GKONDNIFFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public HKOOMBBGJCN<Delegate> KEAGKMHFCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public HKOOMBBGJCN<Delegate> OCDDKJFDNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public HKOOMBBGJCN<Delegate> ODBAJOCOJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public HKOOMBBGJCN<Delegate> KCKAKFBKAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public HKOOMBBGJCN<Delegate> IMMLEOAAONH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7754C30", Offset = "0x7753E30", VA = "0x187754C30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public GGKJHNPEDBJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct FDNNOIPNHHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct KAGPOEFMMCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int MNGLDPMDNMC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1C8B720", Offset = "0x1C8A920", VA = "0x181C8B720")]
	public static KAGPOEFMMCB AJAOLMPMCKD(int OMFJNFBDJCA)
	{
		return default(KAGPOEFMMCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class ADGMJDGCJFH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody JOEOLIHHIPL;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7753CC0", Offset = "0x7752EC0", VA = "0x187753CC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public ADGMJDGCJFH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct PPCIHDJABOC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct DBONEEECHMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 KPBNIKDIOKJ;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct GJJPANNIJEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 DMAMLJEEFCB;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct NCNJGIMCOPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float PKAPLPGPEAP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly NCNJGIMCOPG IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HMBEHENELOP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object NJBAGDNLPGI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7755030", Offset = "0x7754230", VA = "0x187755030", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public HMBEHENELOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class GKNGNDAMEPI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object CMOCCKDNIJD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7754C80", Offset = "0x7753E80", VA = "0x187754C80", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public GKNGNDAMEPI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct BCJNEGHGHNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct DGCMDFFOAEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct CAELKGOJNHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct NBNCCMAMGNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct NIDFFDEJCCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct EIMFIJNLIMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct DOGNJFDILOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct EAGIODHIOJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct LODABAKEDDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct KCNGADICBID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NBBHKCNOHOE MDFLFIACCBK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7756020", Offset = "0x7755220", VA = "0x187756020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct IELBNKDGLOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct NJAKJACIEFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct LGGIEGKIHDO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct GIDPIGHMDMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes MBDFMCIDAOB;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct NBONDCPJFFN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<NBBHKCNOHOE, Entity> OOJFPFHONPG;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct LLNKLPGENFB : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity IAHBAHDDJEM;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct JHLNEFKINJK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity JJMNGBLHAJC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static JHLNEFKINJK AJAOLMPMCKD(Entity JJMNGBLHAJC)
	{
		return default(JHLNEFKINJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct KEBFBHAICKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity PFOFPLAHFGM;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct DLAMHKJCEEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity PFOFPLAHFGM;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct IBIFKEHMMBD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity HFOGFPOHMLG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020")]
	public static IBIFKEHMMBD AJAOLMPMCKD(Entity JJMNGBLHAJC)
	{
		return default(IBIFKEHMMBD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct MJEEIAJIMEN : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct OOBLKPADNAC : IBufferElementData, IEquatable<OOBLKPADNAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity PHLPEABIFAC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75AA470", Offset = "0x75A9670", VA = "0x1875AA470", Slot = "4")]
	public bool Equals(OOBLKPADNAC LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7756670", Offset = "0x7755870", VA = "0x187756670", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct JLPMLCIOIKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint LCLBPLEFKON;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct JDJIOINOCJN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity OFLKAPOMOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int KOOLKCPAFBB;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct GMFNKIJIPIA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity GBAEHOGFOIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct JEDKNNABINI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct DNAIBBGHFKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint GLICGCFCKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int BDBJIIBOIJF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xC25680", Offset = "0xC24880", VA = "0x180C25680")]
	public DNAIBBGHFKD(uint CMMAOHDJJOP, int PJJAMPBBNLB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct GBEDPHMEAIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct MDIAFKFGBCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct EIOMMGMBAGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct NHNPEGPNCAE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct CPPACIGJCIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct KIFMLELEBMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct GCMIEGCJANO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct FEMBMOHKFLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct CONPMJLGCHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct HMMGBCKBMKF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct KHJLEMCBEDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct JEPKBELAIAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct OBBGLOMMLAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct OLHGIJLOJFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct BNGKHHPCJCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct BDMONLEHEKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct FNNCALCMONJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct OHFOMPGEAPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct GEPGJNBIFPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct AKCPMDPJEOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct KIPFOAFJLHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct INPELHIIOJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct KJEBMPPDELC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct LEMJAFMCJBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct EHGGPCIKEEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct EBJCHGAOOIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct CCOIOAAKEHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct ODCPBHKKGLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct HOLMFJCPIAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct DPEPEPFFLOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[EDGMLCEIBGG]
public struct PKAAHABJBKA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct EOGAOPEBJFD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes DIOGKKBMGFI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct DGMBALLDPEF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct CKBJLBIGEFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct CPBFDGEFENN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct LMDICMLKJCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct EAGIFMOCCNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct DNFCOKDPOKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct MFGNLPPOEOE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct GBMAJJEFIPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion GLMEOLPKLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 LBPAIJGCICL;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct HDKHJKJDOAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float NEOLGHPDEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float PGGPIGKMHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float CIEPFKCPOFC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct OFDGGCBKBGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct HMLBNIKGGML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct PJAEOEMMLOA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct IDEPGHMBNPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int ADIMAPFNMNK;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct HEMMHHADEHC : ISystemStateBufferElementData, IBufferElementData, OBDHBPANACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity GHJPMHHACDK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity EAFAIKPPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct CMCICNIAMNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 HBJBICGOEKN;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CMCICNIAMNJ IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct BJHKJLBEMKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 DICECBFGCDM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly BJHKJLBEMKO IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct NJHCPAFMOGD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int MEGLGNFFLBA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KOOLKCPAFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x77565D0", Offset = "0x77557D0", VA = "0x1877565D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77565C0", Offset = "0x77557C0", VA = "0x1877565C0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct DLFEAFOAKKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 LBPAIJGCICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion GLMEOLPKLCA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly DLFEAFOAKKD IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class PMOKBPOPBFD
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct DKBNLIKNPCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float LFDPDOJIELI;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly DKBNLIKNPCN IDMKIMBBHMK;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct GIKMBMONCBH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity LBENHLFHFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public LALIAMPJIPE HFOOBLKJDEM;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct PCNJJKJJKDH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public LALIAMPJIPE HFOOBLKJDEM;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct PPGJOPFMBPD : ISystemStateComponentData, IComponentData, OBDHBPANACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity CMDONCAECIK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity EAFAIKPPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct OFGAJJPFPAP : ISystemStateBufferElementData, IBufferElementData, OBDHBPANACL, IEquatable<OFGAJJPFPAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity AFHNBMFIFLE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity EAFAIKPPIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x75AA470", Offset = "0x75A9670", VA = "0x1875AA470", Slot = "6")]
	public bool Equals(OFGAJJPFPAP LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x77565E0", Offset = "0x77557E0", VA = "0x1877565E0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct DNEJDEIHNKF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity LBENHLFHFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public LALIAMPJIPE HFOOBLKJDEM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct FCOKEDAAKGH : IEqualityComparer<DNEJDEIHNKF>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static FCOKEDAAKGH IDMKIMBBHMK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7754A30", Offset = "0x7753C30", VA = "0x187754A30", Slot = "4")]
	public bool Equals(DNEJDEIHNKF NNDJDIFFAID, DNEJDEIHNKF AMFIBFNKFFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7754A80", Offset = "0x7753C80", VA = "0x187754A80", Slot = "5")]
	public int GetHashCode(DNEJDEIHNKF ONELFPFEALD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct DJLADMGEHBD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> ANPAKJGAMFF;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct GCOKAPOGNDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> ANPAKJGAMFF;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct KCAEGNEECPB : ISystemStateBufferElementData, IBufferElementData, OBDHBPANACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity JMNDPAIONGG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity HGMPIGBGJBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1509820", Offset = "0x1508A20", VA = "0x181509820", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class HFCHLMBHLCM : ContainerPropertyBag<EIAEBCGMMDA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class LFFOOEGJLDP : Property<EIAEBCGMMDA, JLHFMODMEEH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x77562B0", Offset = "0x77554B0", VA = "0x1877562B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7756270", Offset = "0x7755470", VA = "0x187756270")]
		public LFFOOEGJLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x77544D0", Offset = "0x77536D0", VA = "0x1877544D0", Slot = "14")]
		public override JLHFMODMEEH GetValue(EIAEBCGMMDA GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x77544F0", Offset = "0x77536F0", VA = "0x1877544F0", Slot = "15")]
		public override void SetValue(EIAEBCGMMDA GFOILLNHEFN, JLHFMODMEEH OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7754E70", Offset = "0x7754070", VA = "0x187754E70")]
	public HFCHLMBHLCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class HMJIIIFAIOG : ContainerPropertyBag<GGKJHNPEDBJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class JOPCJBFEIEE : Property<GGKJHNPEDBJ, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7755FF0", Offset = "0x77551F0", VA = "0x187755FF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7755FB0", Offset = "0x77551B0", VA = "0x187755FB0")]
		public JOPCJBFEIEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x77544D0", Offset = "0x77536D0", VA = "0x1877544D0", Slot = "14")]
		public override GameObject GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x77544F0", Offset = "0x77536F0", VA = "0x1877544F0", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, GameObject OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class FKDDJJKGHAA : Property<GGKJHNPEDBJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7754B70", Offset = "0x7753D70", VA = "0x187754B70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7754B30", Offset = "0x7753D30", VA = "0x187754B30")]
		public FKDDJJKGHAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7754AE0", Offset = "0x7753CE0", VA = "0x187754AE0", Slot = "14")]
		public override object GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7754B00", Offset = "0x7753D00", VA = "0x187754B00", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, object OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class IOLFIOJKIPC : Property<GGKJHNPEDBJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7755BC0", Offset = "0x7754DC0", VA = "0x187755BC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7755B80", Offset = "0x7754D80", VA = "0x187755B80")]
		public IOLFIOJKIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7755B30", Offset = "0x7754D30", VA = "0x187755B30", Slot = "14")]
		public override object GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7755B50", Offset = "0x7754D50", VA = "0x187755B50", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, object OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class JMJGJJKCJNA : Property<GGKJHNPEDBJ, CLFEIHJGDEO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7755F30", Offset = "0x7755130", VA = "0x187755F30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7755EF0", Offset = "0x77550F0", VA = "0x187755EF0")]
		public JMJGJJKCJNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7755EA0", Offset = "0x77550A0", VA = "0x187755EA0", Slot = "14")]
		public override CLFEIHJGDEO GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7755EC0", Offset = "0x77550C0", VA = "0x187755EC0", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, CLFEIHJGDEO OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class IMODNACOCDF : Property<GGKJHNPEDBJ, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7755A40", Offset = "0x7754C40", VA = "0x187755A40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7755A00", Offset = "0x7754C00", VA = "0x187755A00")]
		public IMODNACOCDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x77559B0", Offset = "0x7754BB0", VA = "0x1877559B0", Slot = "14")]
		public override Delegate GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x77559D0", Offset = "0x7754BD0", VA = "0x1877559D0", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, Delegate OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class INOBPMLFLAF : Property<GGKJHNPEDBJ, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7755B00", Offset = "0x7754D00", VA = "0x187755B00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7755AC0", Offset = "0x7754CC0", VA = "0x187755AC0")]
		public INOBPMLFLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7755A70", Offset = "0x7754C70", VA = "0x187755A70", Slot = "14")]
		public override Delegate GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7755A90", Offset = "0x7754C90", VA = "0x187755A90", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, Delegate OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class KDBJFDMCCAF : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7756100", Offset = "0x7755300", VA = "0x187756100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x77560C0", Offset = "0x77552C0", VA = "0x1877560C0")]
		public KDBJFDMCCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7756070", Offset = "0x7755270", VA = "0x187756070", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7756090", Offset = "0x7755290", VA = "0x187756090", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class ANFLIMGEONG : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7753F00", Offset = "0x7753100", VA = "0x187753F00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7753EC0", Offset = "0x77530C0", VA = "0x187753EC0")]
		public ANFLIMGEONG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7753E70", Offset = "0x7753070", VA = "0x187753E70", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7753E90", Offset = "0x7753090", VA = "0x187753E90", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class MOAHDJFIMOF : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x77563A0", Offset = "0x77555A0", VA = "0x1877563A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7756360", Offset = "0x7755560", VA = "0x187756360")]
		public MOAHDJFIMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7756310", Offset = "0x7755510", VA = "0x187756310", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7756330", Offset = "0x7755530", VA = "0x187756330", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class IJOGFOKKLAG : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7755980", Offset = "0x7754B80", VA = "0x187755980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7755940", Offset = "0x7754B40", VA = "0x187755940")]
		public IJOGFOKKLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x77558F0", Offset = "0x7754AF0", VA = "0x1877558F0", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7755910", Offset = "0x7754B10", VA = "0x187755910", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class NBABPBMICLB : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7756460", Offset = "0x7755660", VA = "0x187756460", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7756420", Offset = "0x7755620", VA = "0x187756420")]
		public NBABPBMICLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x77563D0", Offset = "0x77555D0", VA = "0x1877563D0", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x77563F0", Offset = "0x77555F0", VA = "0x1877563F0", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class HEJDCBCIPEL : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7754E40", Offset = "0x7754040", VA = "0x187754E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7754E00", Offset = "0x7754000", VA = "0x187754E00")]
		public HEJDCBCIPEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7754DB0", Offset = "0x7753FB0", VA = "0x187754DB0", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7754DD0", Offset = "0x7753FD0", VA = "0x187754DD0", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class BBPCKGKJELC : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7754340", Offset = "0x7753540", VA = "0x187754340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7754300", Offset = "0x7753500", VA = "0x187754300")]
		public BBPCKGKJELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x77542B0", Offset = "0x77534B0", VA = "0x1877542B0", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x77542D0", Offset = "0x77534D0", VA = "0x1877542D0", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class EJIGJJHDCKK : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7754980", Offset = "0x7753B80", VA = "0x187754980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7754940", Offset = "0x7753B40", VA = "0x187754940")]
		public EJIGJJHDCKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x77548F0", Offset = "0x7753AF0", VA = "0x1877548F0", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7754910", Offset = "0x7753B10", VA = "0x187754910", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class GMLOBFLFHAG : Property<GGKJHNPEDBJ, HKOOMBBGJCN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7754D80", Offset = "0x7753F80", VA = "0x187754D80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7754D40", Offset = "0x7753F40", VA = "0x187754D40")]
		public GMLOBFLFHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7754CF0", Offset = "0x7753EF0", VA = "0x187754CF0", Slot = "14")]
		public override HKOOMBBGJCN<Delegate> GetValue(GGKJHNPEDBJ GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7754D10", Offset = "0x7753F10", VA = "0x187754D10", Slot = "15")]
		public override void SetValue(GGKJHNPEDBJ GFOILLNHEFN, HKOOMBBGJCN<Delegate> OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x77550A0", Offset = "0x77542A0", VA = "0x1877550A0")]
	public HMJIIIFAIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class CPKGHJDFONM : ContainerPropertyBag<HKOOMBBGJCN<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7754590", Offset = "0x7753790", VA = "0x187754590")]
	public CPKGHJDFONM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class HIBBJHNMGKL : ContainerPropertyBag<ADGMJDGCJFH>
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class JCDIAPDPIAN : Property<ADGMJDGCJFH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7755C30", Offset = "0x7754E30", VA = "0x187755C30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7755BF0", Offset = "0x7754DF0", VA = "0x187755BF0")]
		public JCDIAPDPIAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x77544D0", Offset = "0x77536D0", VA = "0x1877544D0", Slot = "14")]
		public override Rigidbody GetValue(ADGMJDGCJFH GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x77544F0", Offset = "0x77536F0", VA = "0x1877544F0", Slot = "15")]
		public override void SetValue(ADGMJDGCJFH GFOILLNHEFN, Rigidbody OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7754F50", Offset = "0x7754150", VA = "0x187754F50")]
	public HIBBJHNMGKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class IAFLAGFKCOK : ContainerPropertyBag<HMBEHENELOP>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class IIMOEBPPJMN : Property<HMBEHENELOP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x77558C0", Offset = "0x7754AC0", VA = "0x1877558C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7755880", Offset = "0x7754A80", VA = "0x187755880")]
		public IIMOEBPPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x77544D0", Offset = "0x77536D0", VA = "0x1877544D0", Slot = "14")]
		public override object GetValue(HMBEHENELOP GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x77544F0", Offset = "0x77536F0", VA = "0x1877544F0", Slot = "15")]
		public override void SetValue(HMBEHENELOP GFOILLNHEFN, object OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7755700", Offset = "0x7754900", VA = "0x187755700")]
	public IAFLAGFKCOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class JHJGAFHACHB : ContainerPropertyBag<GKNGNDAMEPI>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class CPAOCCJDFBA : Property<GKNGNDAMEPI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7754560", Offset = "0x7753760", VA = "0x187754560", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7754520", Offset = "0x7753720", VA = "0x187754520")]
		public CPAOCCJDFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x77544D0", Offset = "0x77536D0", VA = "0x1877544D0", Slot = "14")]
		public override object GetValue(GKNGNDAMEPI GFOILLNHEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x77544F0", Offset = "0x77536F0", VA = "0x1877544F0", Slot = "15")]
		public override void SetValue(GKNGNDAMEPI GFOILLNHEFN, object OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7755CE0", Offset = "0x7754EE0", VA = "0x187755CE0")]
	public JHJGAFHACHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class JHNMODPJGDK : ContainerPropertyBag<LLNKLPGENFB>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class DJAOKPPBJAD : Property<LLNKLPGENFB, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7754680", Offset = "0x7753880", VA = "0x187754680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7754640", Offset = "0x7753840", VA = "0x187754640")]
		public DJAOKPPBJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xD459C0", Offset = "0xD44BC0", VA = "0x180D459C0", Slot = "14")]
		public override Entity GetValue(LLNKLPGENFB GFOILLNHEFN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7754630", Offset = "0x7753830", VA = "0x187754630", Slot = "15")]
		public override void SetValue(LLNKLPGENFB GFOILLNHEFN, Entity OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7755DC0", Offset = "0x7754FC0", VA = "0x187755DC0")]
	public JHNMODPJGDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class KGBLAEFHADL : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class IHLJJENLHAP : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7755850", Offset = "0x7754A50", VA = "0x187755850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7755810", Offset = "0x7754A10", VA = "0x187755810")]
		public IHLJJENLHAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1F84300", Offset = "0x1F83500", VA = "0x181F84300", Slot = "14")]
		public override int GetValue(Entity GFOILLNHEFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7595330", Offset = "0x7594530", VA = "0x187595330", Slot = "15")]
		public override void SetValue(Entity GFOILLNHEFN, int OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class GCOMFEOGPOH : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string FOBFABOAOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7754C00", Offset = "0x7753E00", VA = "0x187754C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool KNKMFKKGHON
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7754BC0", Offset = "0x7753DC0", VA = "0x187754BC0")]
		public GCOMFEOGPOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7754BA0", Offset = "0x7753DA0", VA = "0x187754BA0", Slot = "14")]
		public override int GetValue(Entity GFOILLNHEFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7754BB0", Offset = "0x7753DB0", VA = "0x187754BB0", Slot = "15")]
		public override void SetValue(Entity GFOILLNHEFN, int OMFJNFBDJCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7756130", Offset = "0x7755330", VA = "0x187756130")]
	public KGBLAEFHADL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7756940", Offset = "0x7755B40", VA = "0x187756940")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
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

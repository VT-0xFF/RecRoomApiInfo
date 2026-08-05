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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7745640", Offset = "0x7744A40", VA = "0x187745640", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77459D0", Offset = "0x7744DD0", VA = "0x1877459D0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2491CF0", Offset = "0x24910F0", VA = "0x182491CF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct LHGCEIPNCML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct MIJAFPLPIEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct HLNBKPFPOOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct CPKFNKCPIGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct CJJGNOMKBIM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77423D0", Offset = "0x77417D0", VA = "0x1877423D0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct CFGHIBHENAG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct LDCNMOHGJED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity AANMCHFNIAA;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct LOLEIHHKLLN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity AANMCHFNIAA;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IFJNIICEAMM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<EKELJDIBGEB> BBHGBJIDBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> BNIFHCMDEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle EJAJPPCPDCM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MEKKKKJOLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7743940", Offset = "0x7742D40", VA = "0x187743940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7743770", Offset = "0x7742B70", VA = "0x187743770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x563AAB0", Offset = "0x5639EB0", VA = "0x18563AAB0")]
	public IFJNIICEAMM(NativeList<EKELJDIBGEB> BBHGBJIDBDD, NativeList<Entity> BNIFHCMDEND, JobHandle EJAJPPCPDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7743820", Offset = "0x7742C20", VA = "0x187743820")]
	public (Entity, NativeSlice<Entity>) EPAJMFPCKDD(int ILOCIBNKPPB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77437C0", Offset = "0x7742BC0", VA = "0x1877437C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EKELJDIBGEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity HAIKBOLEOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int FGCNBOMLCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int EHCAJIFPCLL;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PODCFPIHGLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHDGJGMNLCB(bool MHEGIHPLHIN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JDFPAMOMAHK : IEquatable<JDFPAMOMAHK>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool EOKIHEDLGDA(int OOHLOECMMAJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool DIKFKKFJGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool JLGJEDFHAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool MEMNKMIKMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool HGFOFJFKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EOKIHEDLGDA MMPBNNOHCAC;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7743D80", Offset = "0x7743180", VA = "0x187743D80")]
	public JDFPAMOMAHK(AEGHABAAKPJ NHJKDMPGJCM, EOKIHEDLGDA MMPBNNOHCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7743D50", Offset = "0x7743150", VA = "0x187743D50")]
	public JDFPAMOMAHK(bool DIKFKKFJGGM, bool JLGJEDFHAHL, bool MEMNKMIKMOD, bool HGFOFJFKAKG, EOKIHEDLGDA MMPBNNOHCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7743A60", Offset = "0x7742E60", VA = "0x187743A60")]
	public bool AHDKDJENNBE(int OOHLOECMMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7743C90", Offset = "0x7743090", VA = "0x187743C90")]
	public bool MDCDFHGKNLC(int OOHLOECMMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7743AC0", Offset = "0x7742EC0", VA = "0x187743AC0")]
	public bool EIEMFINIMKH(int OOHLOECMMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7743A90", Offset = "0x7742E90", VA = "0x187743A90")]
	public bool EFBFOKOHMGO(int OOHLOECMMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7743BA0", Offset = "0x7742FA0", VA = "0x187743BA0", Slot = "4")]
	public bool Equals(JDFPAMOMAHK MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7743AF0", Offset = "0x7742EF0", VA = "0x187743AF0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7743BF0", Offset = "0x7742FF0", VA = "0x187743BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7743BD0", Offset = "0x7742FD0", VA = "0x187743BD0")]
	private bool FGKJBCMABEB(int OOHLOECMMAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7743CC0", Offset = "0x77430C0", VA = "0x187743CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct ICMIFMCPIOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct CPGHIHIGIDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct PLOJEHMHJPJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct LFCKHCFBNHN : IBufferElementData, IEquatable<LFCKHCFBNHN>, EIHDBAKFPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity HJDJLPGLCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int ECDHCNPANAN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity EFFOJELMBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7744020", Offset = "0x7743420", VA = "0x187744020", Slot = "4")]
	public bool Equals(LFCKHCFBNHN MNALNBMKJLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BCPCIFECFAP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public CGPCHBCELLP HHNIGDLPHIF;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7742450", Offset = "0x7741850", VA = "0x187742450", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public BCPCIFECFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CGPCHBCELLP
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct PIBPDAJGHFE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct BIJBMHNKEMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly ACDPCFMGIJG BDGDCOEIDIC;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1A50", Offset = "0x2BD0E50", VA = "0x182BD1A50")]
	public BIJBMHNKEMN(ACDPCFMGIJG BDGDCOEIDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7742580", Offset = "0x7741980", VA = "0x187742580")]
	public BIJBMHNKEMN ABAAJJAGIFA(ACDPCFMGIJG ICFGLBCKAJF)
	{
		return default(BIJBMHNKEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7742590", Offset = "0x7741990", VA = "0x187742590")]
	public BIJBMHNKEMN NHOMFAGGNNE(ACDPCFMGIJG PGCEBCOICDB)
	{
		return default(BIJBMHNKEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x77425A0", Offset = "0x77419A0", VA = "0x1877425A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum ACDPCFMGIJG : ushort
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
public static class HHGMLMBFGMO
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct ELPLPNOOADM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public ACDPCFMGIJG HLNOFBFNIDF;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7742B30", Offset = "0x7741F30", VA = "0x187742B30")]
	public bool NHEMAEFFNDO(BIJBMHNKEMN KMFFNFMHLPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7742B10", Offset = "0x7741F10", VA = "0x187742B10")]
	public bool AJFGJCPLOEB(BIJBMHNKEMN KMFFNFMHLPH, ACDPCFMGIJG GBGDLJCDKBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum ADIAFOONIBH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
[SingletonComponent]
public struct BJNNLNBLMPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public ADIAFOONIBH BDGDCOEIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool EKPEAJEJAIL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JHJOJCPHMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7742620", Offset = "0x7741A20", VA = "0x187742620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7742650", Offset = "0x7741A50", VA = "0x187742650")]
	private BJNNLNBLMPK(ADIAFOONIBH BDGDCOEIDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7742600", Offset = "0x7741A00", VA = "0x187742600")]
	public BJNNLNBLMPK ABAAJJAGIFA(ADIAFOONIBH ICFGLBCKAJF)
	{
		return default(BJNNLNBLMPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7742630", Offset = "0x7741A30", VA = "0x187742630")]
	public BJNNLNBLMPK NHOMFAGGNNE(ADIAFOONIBH PGCEBCOICDB)
	{
		return default(BJNNLNBLMPK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct AIGAKPKDHIO : IComponentData
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
public struct OPABPOKJINM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity BMCPKIKFBJE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, EIHDBAKFPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77423D0", Offset = "0x77417D0", VA = "0x1877423D0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct FFGNNEJIBLD : ISystemStateBufferElementData, IBufferElementData, EIHDBAKFPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity JNOEBKCCPMC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity FOFFOEGGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct BOGJOPCFNIF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity LHEHAMMCEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity BNKBGJJBFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity CGMLLFFNAPB;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CJHDLAEGHGN<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool DAHIKGIHLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint IJBCPIFPCHH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool KBEKHEAGBKJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct APOAMLDBIKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint CICCIOEDNOC;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
	public APOAMLDBIKM(GGJEEKAHCEJ KCOCCFMGKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x77423A0", Offset = "0x77417A0", VA = "0x1877423A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1C8C810", Offset = "0x1C8BC10", VA = "0x181C8C810")]
	public static APOAMLDBIKM JKGHIELMIOO(GGJEEKAHCEJ KCOCCFMGKDO)
	{
		return default(APOAMLDBIKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct GNIKEEFCPKP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity JNOEBKCCPMC;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct OMOJKNKIIKD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GGJEEKAHCEJ PEBNJNGMMHE;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct FPCJCADMOPN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity JNOEBKCCPMC;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct GJONDMAACDO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid BCIHOIBCNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int LOHPPDCIAAL;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct CLKNEOJNJKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int PEBNJNGMMHE;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct CODDGKDFDAP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity JNOEBKCCPMC;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct JNBNIBCJCMI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GGJEEKAHCEJ PEBNJNGMMHE;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct LNMNMNPCJDL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity JNOEBKCCPMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct EJHGLNFOKHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct LHBCCDBADMO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int IINAJBJMMPM;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct BJNJAGJHMDO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int FDLLGPFCFLD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EKCODMPEECK IAAFMKOAJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
		get
		{
			return default(EKCODMPEECK);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct AMNIFHIBFHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle HJBNAKIDHAA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct KPCHNPJGFJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct MKMHBNABFOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct ANCHIAKAPOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct DFEPPIIEDPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct LACEJMCHMIM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct OLIELIFJEPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int FFCBHHABFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int IFKCKGNMHDI;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7744C60", Offset = "0x7744060", VA = "0x187744C60")]
	public OLIELIFJEPB(Entity JNOEBKCCPMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct MGGKGNDBNEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode CCPJAHDFNBH;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct IINKLNAIELL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public BJOOMCLMBJJ OEFAJMEGLGL;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly IINKLNAIELL LPOHMOGIBPI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct NDMNFKGIMKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct IFBOHNIFDAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct FCADJMNNHHM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct NFGDLFAMBAJ : IBufferElementData, IEquatable<NFGDLFAMBAJ>, EIHDBAKFPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity HJDJLPGLCKM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity EFFOJELMBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77423D0", Offset = "0x77417D0", VA = "0x1877423D0", Slot = "4")]
	public bool Equals(NFGDLFAMBAJ MNALNBMKJLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct FILCCCBGNEL : IComponentData, EIHDBAKFPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity HKNGNFLDPKM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity EFFOJELMBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct GBPFPPJMNJI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct BIMGLJNIIOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity HAIKBOLEOOP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct CGJAKPHHMIO : OBAONHHGAGB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FEAEKKDDKCJ AHBGJIEIPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FEAEKKDDKCJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct KALEMICHLDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 BGNGJNJCKJB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct DOAMLODKNBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct OGEFMFKDBJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 NLLCNCDPKGI;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly OGEFMFKDBJE LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct GCNEMGMIBIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 NLLCNCDPKGI;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GCNEMGMIBIH LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct DMICNDPACCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 EMCEGJNFCJF;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct APMNOIEAMLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 IONBHPKMJJK;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct ODFAGJPKBAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float EJKFHACCJHL;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly ODFAGJPKBAE LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct EFEMOLAHCJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float OANBPDAGANI;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly EFEMOLAHCJF LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct JFPHPOIFDGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 MIFJANOJFJM;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct LBMBJMNJDIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HFGJKELOCBA JIMHAMIIBMC;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct FOPFIPANPIL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity JNOEBKCCPMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct HBOLHICAFCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct HDBCNGKFKDD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct GBEMNGFHCOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints MEHEDGHBFCE;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct LPPDJABJNHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float FHCMKDGDFDN;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly LPPDJABJNHN LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct AJPEPAGEJNH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float IMCAIGOOKBG;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class LNEKOJHMBOA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject IIKFCCENKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object EDPEGJAFKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object LFNBKKGJMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public JKPGNNKAEHC JKFJDNKEMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate KNFIBNGLPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate ODEHKCHDIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public LAEKEAJIIJD<Delegate> FKOFGHEKHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public LAEKEAJIIJD<Delegate> JHHNMJGLEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public LAEKEAJIIJD<Delegate> INEPJNNDGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public LAEKEAJIIJD<Delegate> PDDBCPHHOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public LAEKEAJIIJD<Delegate> IOJLCDHADAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public LAEKEAJIIJD<Delegate> MOCMIEOIKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public LAEKEAJIIJD<Delegate> DHHHDNKFAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public LAEKEAJIIJD<Delegate> KFOIKELGHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LAEKEAJIIJD<Delegate> FBCJPFLBMNA;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7744250", Offset = "0x7743650", VA = "0x187744250", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public LNEKOJHMBOA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct PNOHDLNMCHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct BMOKKONELLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int GKDNEENHLNE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1C8C810", Offset = "0x1C8BC10", VA = "0x181C8C810")]
	public static BMOKKONELLH JKGHIELMIOO(int PEBNJNGMMHE)
	{
		return default(BMOKKONELLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class GAPAACGKMAP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody DGHNPONNDGG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7742D50", Offset = "0x7742150", VA = "0x187742D50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public GAPAACGKMAP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct PKELPFJMCFI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct ELAJEMOFLCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 GKHALKPEBDP;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct KKAMIAJHIBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 BCGMKGELHNE;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct JFJLIDNBCHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float AHDLFBNBLDH;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly JFJLIDNBCHP LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class GLBLEJPIJIA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object DJGDIKPFCLI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7743120", Offset = "0x7742520", VA = "0x187743120", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public GLBLEJPIJIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PLGCJAGCPAM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object DHPCBPDDDFN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7744D30", Offset = "0x7744130", VA = "0x187744D30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public PLGCJAGCPAM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct DAFCEFNFIAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct MJLKCJLFLHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct KLHCLOIEAGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct DEFOPEBKFMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct IBDEHMJIJDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct ELKMEFACOHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct BHIAIMMCIFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct HBBKBOMANGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct FMAMAMOEHEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct AKDBGDEFDMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public ECNPGCHCJCD FJLKFACHKGL;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7742350", Offset = "0x7741750", VA = "0x187742350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct DOPGMIAAKPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct NKOEHPNNPFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct KLODKIOEIGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct DFAPBJHPLLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes OGOCCCFKJPG;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct NIFKFEKIMBM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<ECNPGCHCJCD, Entity> MEEPPALKCKP;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct LPKJEPAIPDE : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity MNEHMOHBKNM;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct AOIPNFBIHBC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity JNOEBKCCPMC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static AOIPNFBIHBC JKGHIELMIOO(Entity JNOEBKCCPMC)
	{
		return default(AOIPNFBIHBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct MFKDCJEDKNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity PFOFNPGBOND;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct HCKOICFGFPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity PFOFNPGBOND;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct ICLALOKPAII : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity HOBBDCGFCBF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static ICLALOKPAII JKGHIELMIOO(Entity JNOEBKCCPMC)
	{
		return default(ICLALOKPAII);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct NIEJNAPFDDD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct CLHKFJANOBH : IBufferElementData, IEquatable<CLHKFJANOBH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity OBGINBOAKMJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x75982E0", Offset = "0x75976E0", VA = "0x1875982E0", Slot = "4")]
	public bool Equals(CLHKFJANOBH MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7742720", Offset = "0x7741B20", VA = "0x187742720", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct CIIDFEHDBFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint IFKCKGNMHDI;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct ABBDCNMIDIO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity IPGAMDJAJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int FFCBHHABFJN;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct NDDBJPHAEPA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity ACNBKDIDKCE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct FLPPNKLIGDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct IJFDAJFPCDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint IJBCPIFPCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int IJJPBMNHGFF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xC23C00", Offset = "0xC23000", VA = "0x180C23C00")]
	public IJFDAJFPCDP(uint MMIAJHJDCMN, int GCPPILHOGOO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct EGNFGOHMPKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct MAJLPLNHOEA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct CCIJLHMJHFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct PEPDDCPEKDJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct PHOPCPEJLML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct POEOBDCOLJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct EKOBALPLHHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct OHGAHLLNDCL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct BHDPFABMJDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct JJINDFPCKNH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct BIBHBBLJGMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct BIMDFJCJOAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct LJHGPIDPMNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct DFFKMFFLCAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct PGDKFNMPMNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct MCEJIPBECDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct ICCCNIAENKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct BCHGBMPHKAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct NLBBJAJBDOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct NALCDPDNAFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct EBKFONGDMDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct FLKDEKCDKDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct DKGLMPNKNJO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct LLEMADGNKJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct CHABPEMDIMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct AOFEGPEKNBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct EFJHAOIGPMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct MEMGLKAAHDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct KEMCJPJFDCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct EBHOMMDJONB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[FACLIEIBEDG]
public struct IHMBJJDKJIL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct OLODOGKNOAN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes IDNJHOBOFAO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct CDFLCNBNIGG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct HIJBBBMDLDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct EEKFHABFFDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct NNMLINHMDEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct DNJJCDKDBEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct CJNAJLAENGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct PBGHLEDHMCM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct BPJAHFCFMMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion NBFJKGINHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 HJBDDDIFEBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct HPDEBKBJKHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float OOMNOKCAHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float OFHKAOOHHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float KOJEDPMCGBM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct LGPNJFMPHHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct LOIHNFCBNLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct FBOALPHDNPA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct GECMCLNFLDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int FDLLGPFCFLD;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct BMPDHLDMCPF : ISystemStateBufferElementData, IBufferElementData, EIHDBAKFPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity KIMKLLCFIPN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity FOFFOEGGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct PNMPOLIEICP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 JKKODGKHHOG;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly PNMPOLIEICP LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct HBLLNBNCCOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 PLFHPFICCHB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly HBLLNBNCCOF LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct FAIEEKIJJBL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int BLMLNABFNDE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FFCBHHABFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7742BA0", Offset = "0x7741FA0", VA = "0x187742BA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7742BB0", Offset = "0x7741FB0", VA = "0x187742BB0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct GBHMPEOHOGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 HJBDDDIFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion NBFJKGINHEC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly GBHMPEOHOGA LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class PPBABDLNFAE
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct LMKFMMHEOED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float AEOLMGIHOIN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly LMKFMMHEOED LPOHMOGIBPI;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct BEOEPFFLGFN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity DEDIIAHFDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NHILINKIAMC CALDBNGCNDJ;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct HACFKLGOCMA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NHILINKIAMC CALDBNGCNDJ;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct KBPFHPCBGHJ : ISystemStateComponentData, IComponentData, EIHDBAKFPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity PABHOIEKLEA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity FOFFOEGGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct FOPEHOIJFNJ : ISystemStateBufferElementData, IBufferElementData, EIHDBAKFPCG, IEquatable<FOPEHOIJFNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity ILMEEEGMBLM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity FOFFOEGGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x75982E0", Offset = "0x75976E0", VA = "0x1875982E0", Slot = "6")]
	public bool Equals(FOPEHOIJFNJ MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7742CC0", Offset = "0x77420C0", VA = "0x187742CC0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct EDBJFDICPDD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity DEDIIAHFDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NHILINKIAMC CALDBNGCNDJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct HIIHMIBOLHJ : IEqualityComparer<EDBJFDICPDD>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static HIIHMIBOLHJ LPOHMOGIBPI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x77434C0", Offset = "0x77428C0", VA = "0x1877434C0", Slot = "4")]
	public bool Equals(EDBJFDICPDD COMHOHNLIIN, EDBJFDICPDD PJGBAACMKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7743510", Offset = "0x7742910", VA = "0x187743510", Slot = "5")]
	public int GetHashCode(EDBJFDICPDD NBAMGPFDMIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct NMJGFBCPABB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> JJCIOCEFNLE;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct NFAJOEOPAKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> JJCIOCEFNLE;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct FGICHDCIBFC : ISystemStateBufferElementData, IBufferElementData, EIHDBAKFPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity NPGIKBLCLGE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity EFFOJELMBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class JMHKEOCLIIJ : ContainerPropertyBag<BCPCIFECFAP>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class KMKMJCNFJJM : Property<BCPCIFECFAP, CGPCHBCELLP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7743FF0", Offset = "0x77433F0", VA = "0x187743FF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7743FB0", Offset = "0x77433B0", VA = "0x187743FB0")]
		public KMKMJCNFJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7742290", Offset = "0x7741690", VA = "0x187742290", Slot = "14")]
		public override CGPCHBCELLP GetValue(BCPCIFECFAP EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x77422B0", Offset = "0x77416B0", VA = "0x1877422B0", Slot = "15")]
		public override void SetValue(BCPCIFECFAP EOMAFKDOFHE, CGPCHBCELLP PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7743E10", Offset = "0x7743210", VA = "0x187743E10")]
	public JMHKEOCLIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class MCGDLOECHBN : ContainerPropertyBag<LNEKOJHMBOA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class MIHFGFEBOGJ : Property<LNEKOJHMBOA, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7744B00", Offset = "0x7743F00", VA = "0x187744B00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7744AC0", Offset = "0x7743EC0", VA = "0x187744AC0")]
		public MIHFGFEBOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7742290", Offset = "0x7741690", VA = "0x187742290", Slot = "14")]
		public override GameObject GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x77422B0", Offset = "0x77416B0", VA = "0x1877422B0", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, GameObject PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class GNAEIOBHDGP : Property<LNEKOJHMBOA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7743220", Offset = "0x7742620", VA = "0x187743220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x77431E0", Offset = "0x77425E0", VA = "0x1877431E0")]
		public GNAEIOBHDGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7743190", Offset = "0x7742590", VA = "0x187743190", Slot = "14")]
		public override object GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x77431B0", Offset = "0x77425B0", VA = "0x1877431B0", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, object PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class BFANJIECILI : Property<LNEKOJHMBOA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7742550", Offset = "0x7741950", VA = "0x187742550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7742510", Offset = "0x7741910", VA = "0x187742510")]
		public BFANJIECILI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x77424C0", Offset = "0x77418C0", VA = "0x1877424C0", Slot = "14")]
		public override object GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x77424E0", Offset = "0x77418E0", VA = "0x1877424E0", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, object PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class HPBCGFKCDNJ : Property<LNEKOJHMBOA, JKPGNNKAEHC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7743600", Offset = "0x7742A00", VA = "0x187743600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x77435C0", Offset = "0x77429C0", VA = "0x1877435C0")]
		public HPBCGFKCDNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7743570", Offset = "0x7742970", VA = "0x187743570", Slot = "14")]
		public override JKPGNNKAEHC GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7743590", Offset = "0x7742990", VA = "0x187743590", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, JKPGNNKAEHC PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class DCIPIGHNCHC : Property<LNEKOJHMBOA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7742900", Offset = "0x7741D00", VA = "0x187742900", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x77428C0", Offset = "0x7741CC0", VA = "0x1877428C0")]
		public DCIPIGHNCHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7742870", Offset = "0x7741C70", VA = "0x187742870", Slot = "14")]
		public override Delegate GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7742890", Offset = "0x7741C90", VA = "0x187742890", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, Delegate PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class PPDCAHIMNHI : Property<LNEKOJHMBOA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7744EE0", Offset = "0x77442E0", VA = "0x187744EE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7744EA0", Offset = "0x77442A0", VA = "0x187744EA0")]
		public PPDCAHIMNHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7744E50", Offset = "0x7744250", VA = "0x187744E50", Slot = "14")]
		public override Delegate GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7744E70", Offset = "0x7744270", VA = "0x187744E70", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, Delegate PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class LIFOGHGCLHG : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7744100", Offset = "0x7743500", VA = "0x187744100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x77440C0", Offset = "0x77434C0", VA = "0x1877440C0")]
		public LIFOGHGCLHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7744070", Offset = "0x7743470", VA = "0x187744070", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7744090", Offset = "0x7743490", VA = "0x187744090", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class LNLMHGMJEBN : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7744330", Offset = "0x7743730", VA = "0x187744330", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x77442F0", Offset = "0x77436F0", VA = "0x1877442F0")]
		public LNLMHGMJEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x77442A0", Offset = "0x77436A0", VA = "0x1877442A0", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x77442C0", Offset = "0x77436C0", VA = "0x1877442C0", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class LOPCDMCPDLA : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x77443F0", Offset = "0x77437F0", VA = "0x1877443F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x77443B0", Offset = "0x77437B0", VA = "0x1877443B0")]
		public LOPCDMCPDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7744360", Offset = "0x7743760", VA = "0x187744360", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7744380", Offset = "0x7743780", VA = "0x187744380", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class ONPDCENOCKA : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7744D00", Offset = "0x7744100", VA = "0x187744D00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7744CC0", Offset = "0x77440C0", VA = "0x187744CC0")]
		public ONPDCENOCKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7744C70", Offset = "0x7744070", VA = "0x187744C70", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7744C90", Offset = "0x7744090", VA = "0x187744C90", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class KABEFNFCIAE : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7743F80", Offset = "0x7743380", VA = "0x187743F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7743F40", Offset = "0x7743340", VA = "0x187743F40")]
		public KABEFNFCIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7743EF0", Offset = "0x77432F0", VA = "0x187743EF0", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7743F10", Offset = "0x7743310", VA = "0x187743F10", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class BMEKDGIAFDA : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x77426F0", Offset = "0x7741AF0", VA = "0x1877426F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x77426B0", Offset = "0x7741AB0", VA = "0x1877426B0")]
		public BMEKDGIAFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7742660", Offset = "0x7741A60", VA = "0x187742660", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7742680", Offset = "0x7741A80", VA = "0x187742680", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class COLJMKAAECI : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7742840", Offset = "0x7741C40", VA = "0x187742840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7742800", Offset = "0x7741C00", VA = "0x187742800")]
		public COLJMKAAECI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x77427B0", Offset = "0x7741BB0", VA = "0x1877427B0", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x77427D0", Offset = "0x7741BD0", VA = "0x1877427D0", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class EIKONAIANPC : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7742AE0", Offset = "0x7741EE0", VA = "0x187742AE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7742AA0", Offset = "0x7741EA0", VA = "0x187742AA0")]
		public EIKONAIANPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7742A50", Offset = "0x7741E50", VA = "0x187742A50", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7742A70", Offset = "0x7741E70", VA = "0x187742A70", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class GDINMDAHOHL : Property<LNEKOJHMBOA, LAEKEAJIIJD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7743070", Offset = "0x7742470", VA = "0x187743070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7743030", Offset = "0x7742430", VA = "0x187743030")]
		public GDINMDAHOHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7742FE0", Offset = "0x77423E0", VA = "0x187742FE0", Slot = "14")]
		public override LAEKEAJIIJD<Delegate> GetValue(LNEKOJHMBOA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7743000", Offset = "0x7742400", VA = "0x187743000", Slot = "15")]
		public override void SetValue(LNEKOJHMBOA EOMAFKDOFHE, LAEKEAJIIJD<Delegate> PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7744460", Offset = "0x7743860", VA = "0x187744460")]
	public MCGDLOECHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class EMMNPBOAHML : ContainerPropertyBag<LAEKEAJIIJD<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7742B40", Offset = "0x7741F40", VA = "0x187742B40")]
	public EMMNPBOAHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class LLLNAHOBHBI : ContainerPropertyBag<GAPAACGKMAP>
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class ADNOIAGKNFK : Property<GAPAACGKMAP, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7742320", Offset = "0x7741720", VA = "0x187742320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x77422E0", Offset = "0x77416E0", VA = "0x1877422E0")]
		public ADNOIAGKNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7742290", Offset = "0x7741690", VA = "0x187742290", Slot = "14")]
		public override Rigidbody GetValue(GAPAACGKMAP EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x77422B0", Offset = "0x77416B0", VA = "0x1877422B0", Slot = "15")]
		public override void SetValue(GAPAACGKMAP EOMAFKDOFHE, Rigidbody PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7744130", Offset = "0x7743530", VA = "0x187744130")]
	public LLLNAHOBHBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class GOOCJGIJOAM : ContainerPropertyBag<GLBLEJPIJIA>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class IJPPEJFLADG : Property<GLBLEJPIJIA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7743A30", Offset = "0x7742E30", VA = "0x187743A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x77439F0", Offset = "0x7742DF0", VA = "0x1877439F0")]
		public IJPPEJFLADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7742290", Offset = "0x7741690", VA = "0x187742290", Slot = "14")]
		public override object GetValue(GLBLEJPIJIA EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x77422B0", Offset = "0x77416B0", VA = "0x1877422B0", Slot = "15")]
		public override void SetValue(GLBLEJPIJIA EOMAFKDOFHE, object PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7743330", Offset = "0x7742730", VA = "0x187743330")]
	public GOOCJGIJOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class DECPBKOPIAH : ContainerPropertyBag<PLGCJAGCPAM>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class BBAMECGDNMB : Property<PLGCJAGCPAM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7742420", Offset = "0x7741820", VA = "0x187742420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x77423E0", Offset = "0x77417E0", VA = "0x1877423E0")]
		public BBAMECGDNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7742290", Offset = "0x7741690", VA = "0x187742290", Slot = "14")]
		public override object GetValue(PLGCJAGCPAM EOMAFKDOFHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x77422B0", Offset = "0x77416B0", VA = "0x1877422B0", Slot = "15")]
		public override void SetValue(PLGCJAGCPAM EOMAFKDOFHE, object PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7742930", Offset = "0x7741D30", VA = "0x187742930")]
	public DECPBKOPIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class GNANLHBFIGN : ContainerPropertyBag<LPKJEPAIPDE>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class GFNHAGFFPIM : Property<LPKJEPAIPDE, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x77430F0", Offset = "0x77424F0", VA = "0x1877430F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x77430B0", Offset = "0x77424B0", VA = "0x1877430B0")]
		public GFNHAGFFPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xD45410", Offset = "0xD44810", VA = "0x180D45410", Slot = "14")]
		public override Entity GetValue(LPKJEPAIPDE EOMAFKDOFHE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x77430A0", Offset = "0x77424A0", VA = "0x1877430A0", Slot = "15")]
		public override void SetValue(LPKJEPAIPDE EOMAFKDOFHE, Entity PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7743250", Offset = "0x7742650", VA = "0x187743250")]
	public GNANLHBFIGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class IBAFLFFBGLA : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class FOBNDEKHOMM : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7742C90", Offset = "0x7742090", VA = "0x187742C90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7742C50", Offset = "0x7742050", VA = "0x187742C50")]
		public FOBNDEKHOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1F83240", Offset = "0x1F82640", VA = "0x181F83240", Slot = "14")]
		public override int GetValue(Entity EOMAFKDOFHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7583390", Offset = "0x7582790", VA = "0x187583390", Slot = "15")]
		public override void SetValue(Entity EOMAFKDOFHE, int PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class FKCGKIHIPKC : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string NAMECGEJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7742C20", Offset = "0x7742020", VA = "0x187742C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool FBPFCDPCCGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7742BE0", Offset = "0x7741FE0", VA = "0x187742BE0")]
		public FKCGKIHIPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7742BC0", Offset = "0x7741FC0", VA = "0x187742BC0", Slot = "14")]
		public override int GetValue(Entity EOMAFKDOFHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7742BD0", Offset = "0x7741FD0", VA = "0x187742BD0", Slot = "15")]
		public override void SetValue(Entity EOMAFKDOFHE, int PEBNJNGMMHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7743630", Offset = "0x7742A30", VA = "0x187743630")]
	public IBAFLFFBGLA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7744F10", Offset = "0x7744310", VA = "0x187744F10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class FKHLMKNECEB
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public FKHLMKNECEB()
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

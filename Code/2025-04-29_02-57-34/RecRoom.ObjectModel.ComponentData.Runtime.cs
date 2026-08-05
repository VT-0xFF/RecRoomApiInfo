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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C64690", Offset = "0x7C63A90", VA = "0x187C64690", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C64A40", Offset = "0x7C63E40", VA = "0x187C64A40", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x25D0340", Offset = "0x25CF740", VA = "0x1825D0340")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct MMHDNNIAPHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct IHKJOCPLLGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct DNKIPPJIDFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct JHGCDFKGALG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct BEIKKHEBJKK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, PLNJOFEBCGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C61470", Offset = "0x7C60870", VA = "0x187C61470", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct EINFGONNPFC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct MNGJIINLLOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity FFKHLPABKKI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct GJIOMEAMFNP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity FFKHLPABKKI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LCFOLMLJNPI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<POKOCNMCLMJ> EMAOGGMAGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> PKJMJMJALBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle KAKLANICLFE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HAHEDGIEFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C63060", Offset = "0x7C62460", VA = "0x187C63060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C631F0", Offset = "0x7C625F0", VA = "0x187C631F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5AB3670", Offset = "0x5AB2A70", VA = "0x185AB3670")]
	public LCFOLMLJNPI(NativeList<POKOCNMCLMJ> EMAOGGMAGOD, NativeList<Entity> PKJMJMJALBH, JobHandle KAKLANICLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C630D0", Offset = "0x7C624D0", VA = "0x187C630D0")]
	public (Entity, NativeSlice<Entity>) MBALNCMBPHA(int DPBBAIABGAH)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C63000", Offset = "0x7C62400", VA = "0x187C63000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct POKOCNMCLMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity DGFFJNKGDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int IALPEJIGIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int CFKBLDHNBAA;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FPCPOBDKGHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMDIOJEHAEG(bool NNLOIADDDJE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MAMNGIEKLJA : IEquatable<MAMNGIEKLJA>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool GIHNLOFBAEO(int FIFFOHPGPDL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool OBBNLOOPCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool CBNLILKHHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool EGAHIFNBFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool OIDBLEHAPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GIHNLOFBAEO GMEHMGGNGHL;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C63720", Offset = "0x7C62B20", VA = "0x187C63720")]
	public MAMNGIEKLJA(PKKKHDDPEDA PNEABCGFGDJ, GIHNLOFBAEO GMEHMGGNGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C63770", Offset = "0x7C62B70", VA = "0x187C63770")]
	public MAMNGIEKLJA(bool OBBNLOOPCML, bool CBNLILKHHNG, bool EGAHIFNBFMM, bool OIDBLEHAPEF, GIHNLOFBAEO GMEHMGGNGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C63460", Offset = "0x7C62860", VA = "0x187C63460")]
	public bool DCMKEMBGJPB(int FIFFOHPGPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C63610", Offset = "0x7C62A10", VA = "0x187C63610")]
	public bool MDHCCNMNEGH(int FIFFOHPGPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C63640", Offset = "0x7C62A40", VA = "0x187C63640")]
	public bool MMEBKCOCNPL(int FIFFOHPGPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C63430", Offset = "0x7C62830", VA = "0x187C63430")]
	public bool AGLCJLHGABA(int FIFFOHPGPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C63490", Offset = "0x7C62890", VA = "0x187C63490", Slot = "4")]
	public bool Equals(MAMNGIEKLJA DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C634C0", Offset = "0x7C628C0", VA = "0x187C634C0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C63570", Offset = "0x7C62970", VA = "0x187C63570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C63670", Offset = "0x7C62A70", VA = "0x187C63670")]
	private bool OMCJFAGELJM(int FIFFOHPGPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C63690", Offset = "0x7C62A90", VA = "0x187C63690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct MNGGOHEAENK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct MMLALAHDAJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct HEPEEABIGFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct NBOPBKKDCNC : IBufferElementData, IEquatable<NBOPBKKDCNC>, PLNJOFEBCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity EDKEHABGEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int HKHPIMEGHBH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity HAGCNILHEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C63B40", Offset = "0x7C62F40", VA = "0x187C63B40", Slot = "4")]
	public bool Equals(NBOPBKKDCNC DMMBOHMLHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MJKLMOCNKJJ : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public FHCFNOFPAEF CJCALCCIHMC;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C638D0", Offset = "0x7C62CD0", VA = "0x187C638D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MJKLMOCNKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FHCFNOFPAEF
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct PKOKPMGOJBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct HJFJLPPPDJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly JPAPNGLHOCL AGFBEKIECPI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2D36000", Offset = "0x2D35400", VA = "0x182D36000")]
	public HJFJLPPPDJC(JPAPNGLHOCL AGFBEKIECPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C62B50", Offset = "0x7C61F50", VA = "0x187C62B50")]
	public HJFJLPPPDJC OBNOCAPMKHB(JPAPNGLHOCL CPOGJIMIINE)
	{
		return default(HJFJLPPPDJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C62B40", Offset = "0x7C61F40", VA = "0x187C62B40")]
	public HJFJLPPPDJC FOKJFLLMFFK(JPAPNGLHOCL PIMECHNMNDA)
	{
		return default(HJFJLPPPDJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C62B60", Offset = "0x7C61F60", VA = "0x187C62B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum JPAPNGLHOCL : ushort
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
public static class HILPDPPAIML
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct NHOBNOGHEIH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JPAPNGLHOCL AGOJDCHGOHM;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C63C20", Offset = "0x7C63020", VA = "0x187C63C20")]
	public bool AMDABDEHMBM(HJFJLPPPDJC FKNMKMGBGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C63C30", Offset = "0x7C63030", VA = "0x187C63C30")]
	public bool MLPJCCDGIEC(HJFJLPPPDJC FKNMKMGBGGB, JPAPNGLHOCL HGCJPAOLJIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum HOEMEIBBEMB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
[SingletonComponent]
public struct BLIHAKPDEDK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HOEMEIBBEMB AGFBEKIECPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool HBBMCPICEHB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool INELHCAJIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C615D0", Offset = "0x7C609D0", VA = "0x187C615D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C61620", Offset = "0x7C60A20", VA = "0x187C61620")]
	private BLIHAKPDEDK(HOEMEIBBEMB AGFBEKIECPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C61600", Offset = "0x7C60A00", VA = "0x187C61600")]
	public BLIHAKPDEDK OBNOCAPMKHB(HOEMEIBBEMB CPOGJIMIINE)
	{
		return default(BLIHAKPDEDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C615E0", Offset = "0x7C609E0", VA = "0x187C615E0")]
	public BLIHAKPDEDK FOKJFLLMFFK(HOEMEIBBEMB PIMECHNMNDA)
	{
		return default(BLIHAKPDEDK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct AIELMNCBCKL : IComponentData
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
public struct DNIHGOBCBOF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity JIIMDMEODPL;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, PLNJOFEBCGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C61470", Offset = "0x7C60870", VA = "0x187C61470", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct FPNAHJKEHON : ISystemStateBufferElementData, IBufferElementData, PLNJOFEBCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity BGFOMMJBGIM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity GAEEFHDEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct BHPGFFLKDAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity FKNBFJHIEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity EBAEBCLCPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity IFDACOAFNIP;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FFLJHFPAFFM<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool CMMDKLGDPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint IOGBDPFAKGC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool FGPOOHPFGOE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct GHPMDJPPDOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint LPJCFKONGNK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x122C2A0", Offset = "0x122B6A0", VA = "0x18122C2A0")]
	public GHPMDJPPDOL(DBEKHLEEGHN COBPAFJKMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C627C0", Offset = "0x7C61BC0", VA = "0x187C627C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAD20", Offset = "0x1DDA120", VA = "0x181DDAD20")]
	public static GHPMDJPPDOL HIHFKEJHDAH(DBEKHLEEGHN COBPAFJKMHM)
	{
		return default(GHPMDJPPDOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct FBCNALCKPJE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity BGFOMMJBGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct ECACNHMEAKJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DBEKHLEEGHN OOEMJLHLIHJ;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct JGEKHPMILAH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity BGFOMMJBGIM;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct HICNDKDFCFL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid FIAGFFPOAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PCGLBCNIEAP;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct PAOEOOKGGKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int OOEMJLHLIHJ;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct JPAAABGHBGE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity BGFOMMJBGIM;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct OIAPGEEPOAG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public DBEKHLEEGHN OOEMJLHLIHJ;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct COINKPAEMDJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity BGFOMMJBGIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct AFMOIFBOMND : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct GFPBGDDNHHF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LLAFKEMFDFN;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct AOLHODLIIDA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int JAOBHFJGJEN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LENNHFKFEFN DLKKDNHIDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0")]
		get
		{
			return default(LENNHFKFEFN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct OOOKOODAFKA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle JBHBNIBPKDA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct BBAFICPCFMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct MNAEBJHMBIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct OMNMMIDKINE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct BDGBMJJLPDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct HMMNCPFNALO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct GAMJBHKMPNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int COPLIEINKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int IPCFHGIMHJJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C62020", Offset = "0x7C61420", VA = "0x187C62020")]
	public GAMJBHKMPNN(Entity BGFOMMJBGIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct DJFBMNANBJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode LKBDMJHOMGO;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct DKEBJMHLGBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public BAJKLLBGNIN DNOCAMDKDAC;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly DKEBJMHLGBM GCAAODGDGAI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct DIGILNMFBLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct IOAEBJADEID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct EIIKLMINKID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
[InternalBufferCapacity(0)]
public struct JKKEDHFGAMP : IBufferElementData, IEquatable<JKKEDHFGAMP>, PLNJOFEBCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity EDKEHABGEPK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity HAGCNILHEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C61470", Offset = "0x7C60870", VA = "0x187C61470", Slot = "4")]
	public bool Equals(JKKEDHFGAMP DMMBOHMLHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct MNBKGAIDBIC : IComponentData, PLNJOFEBCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity GEFLCBDBKHP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity HAGCNILHEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct EMEPBEKOCIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct BPNGDJDNLJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity DGFFJNKGDJD;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct NPLLOHNHIMC : EFKDPLHJHPM, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JJLCDLHMNPI DKLOOEGDBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(JJLCDLHMNPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct FBDFNJAGFEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 MDNKHNCENEE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct OHDAOKBJIGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct JAIFHGMELKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 HPJNAEPAFBI;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly JAIFHGMELKI GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct EIDAEBPGDNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 HPJNAEPAFBI;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly EIDAEBPGDNP GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct NGAAIFCAMLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 FAJBCFLPLGC;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct AJLCADFJPEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 LNGPADAGGDF;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct LEAEEOFIFNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float KLKFJKGMACJ;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly LEAEEOFIFNO GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct OAOCDAJNAEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float NAFPEBPFOHG;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly OAOCDAJNAEH GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct AJGPMHDKAPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 KKHJCDFCJKD;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct AEPKEBEAEKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public GPDLPHADFJO HAEPBLJIHNG;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct AHOKMHNMICJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity BGFOMMJBGIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct EOEGAPLIEOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct KIKAPGMPNMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct GNCEPLJEGLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints DPGBGNIJCOG;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct FJNKBEBMFMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float IHAJIBMNICB;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FJNKBEBMFMK GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct FMAFLNEDJNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float HEKBEHMEPEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OBCIIOFBKHH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject GMFIIANHHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object KMGNJNAMCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object LNOHIDOFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public BAMDIAFJDCJ MLJHONPGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate MFMCJKICGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate DPJEMPGMFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public OAGGALGHDAH<Delegate> MDGOCFGHFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public OAGGALGHDAH<Delegate> OHOLFLOMMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public OAGGALGHDAH<Delegate> LKJGMCHKFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public OAGGALGHDAH<Delegate> OJNEGNCKGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public OAGGALGHDAH<Delegate> APHKHMEDBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public OAGGALGHDAH<Delegate> MHDJGOGBPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public OAGGALGHDAH<Delegate> LKAINPIPIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public OAGGALGHDAH<Delegate> GCDBMCIKENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public OAGGALGHDAH<Delegate> IEIIJBKNNJC;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C63C90", Offset = "0x7C63090", VA = "0x187C63C90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public OBCIIOFBKHH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct GPLALHFCFDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct CCDAJFFMGDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int HPCAINGOKFI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAD20", Offset = "0x1DDA120", VA = "0x181DDAD20")]
	public static CCDAJFFMGDO HIHFKEJHDAH(int OOEMJLHLIHJ)
	{
		return default(CCDAJFFMGDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class MCAIIHKAOED : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody HHPFGDJAMCG;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C637A0", Offset = "0x7C62BA0", VA = "0x187C637A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public MCAIIHKAOED()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct HNPKOOLNENM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct NOCJHGGDNBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 EDKDJJNNIFC;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct CMOPENMKMAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 GEIOPELMCBI;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct EOCGLDIFMKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float ANPEKBMOALB;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly EOCGLDIFMKH GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class IAGAJJJBLLH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object PDKJFMAFIGA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C62BC0", Offset = "0x7C61FC0", VA = "0x187C62BC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public IAGAJJJBLLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BFNILLHBIMI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object CPINNKMBPLK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C61560", Offset = "0x7C60960", VA = "0x187C61560", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public BFNILLHBIMI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct KIPLOPKLHHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct MPJLMKGKEAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct EDFLAHPBIKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct MHNJILIMHBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct CINDCHFJCIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct EBNIMDOABLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct FEOMABHMIPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct FABDALACEAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct KKBNOIOPCLD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct FHFFIGAEIAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public POGIPCAMMFK DGCMHMGCOIA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C61ED0", Offset = "0x7C612D0", VA = "0x187C61ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct BLJCOJJPIFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct EFCCAIIPKPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct DDNEODOIALH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct FGNKCCMEBJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes KCCMEIDBNGP;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct EEBBBAEKDAC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<POGIPCAMMFK, Entity> OFNNHMBPEIG;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct MAAEBNKLKDN : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity POEIKEMLPAC;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct OHNHMPLCNHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity BGFOMMJBGIM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static OHNHMPLCNHJ HIHFKEJHDAH(Entity BGFOMMJBGIM)
	{
		return default(OHNHMPLCNHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct BGOJKPGDEHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity APPOCJELHJE;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct LGOOLNHDLHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity APPOCJELHJE;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct MAJNIPNBGGA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity DMFEOHDCJED;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC51D60", Offset = "0xC51160", VA = "0x180C51D60")]
	public static MAJNIPNBGGA HIHFKEJHDAH(Entity BGFOMMJBGIM)
	{
		return default(MAJNIPNBGGA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct MBDFKIOINKH : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct NDOGDHIAONG : IBufferElementData, IEquatable<NDOGDHIAONG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity AFHPEILJIBE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB470", Offset = "0x7AAA870", VA = "0x187AAB470", Slot = "4")]
	public bool Equals(NDOGDHIAONG DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C63B90", Offset = "0x7C62F90", VA = "0x187C63B90", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct POJNANPKOJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint IPCFHGIMHJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct KIINKGBHMPO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity IAMJEIEGALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int COPLIEINKOF;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct HEBGILHPCKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity ENBGJLJJBHG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct BONMMNIADCL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct NJCHANPEDOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint IOGBDPFAKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int CIOBOHGIGIH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xCE0AB0", Offset = "0xCDFEB0", VA = "0x180CE0AB0")]
	public NJCHANPEDOA(uint CEHLLCLJMHN, int IKCFGADICAO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct GBDDOJBMLNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct MKELBNDAIDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct ELIOBBEDOMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct CHCBMPLNFHJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct LJFAJLLFFMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct LAOBEBJDJJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct LIFFOLGGJEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct LDBLPEILIIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct CBELGFDLJFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct EDHONDFJJBE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct KHNODHCAFFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct EGGMJOOGIAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct HOEOIBLAJLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct GBIAOIEBDPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct LGINFANPDLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct HFFPBCKCHDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct NNGPOBOBPFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct BHGLGEGMEPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct AFANIDIKEKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct CJMBJBBMPIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct KCBFJLDJIKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct FBFAOIKFCOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct OEJMEFABOAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct FCCIEAOEEAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct GJCJAFCALLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct LGNKLJBMFHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct EKAIICKGFJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct EPLOPCLEBKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct NJMGKIAFEPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct FCLPJKLEHEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct CKFFIMGCPPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct LKPLHJMCELE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[NCGIIFIKLAB]
public struct BOGBEGPLDJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct FCGFGLJDPPF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes BJFHDDMNBNB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct JNCJDDILIAB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct FCHOMPGLPJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct GCBNHMBPPBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct CKOEINJCCPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct GCPIGOFNAIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct CMAHDFEPKDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct PMFFPMOIHPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct HPGPINHMGEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion PNEDBEMJDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 KBPOHLLNAIG;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct PHBELKMCPJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float DLJAJJLLKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float MBLNKLHPNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float JLLNILFJFHC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct BODBMGADEBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct DFBAHKKGGLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct IDCIKAEBPBD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct OEILPBPCCEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int JAOBHFJGJEN;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct OCJNACHNJKM : ISystemStateBufferElementData, IBufferElementData, PLNJOFEBCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity KKMKNNENHBP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity GAEEFHDEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct HHIOEEGJHCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 HAGICCCHOEI;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly HHIOEEGJHCO GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct JKHJCKCFPDA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 BMGCDEEJCKG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly JKHJCKCFPDA GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct IKKNHBFGBJP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int LLHKGIFCGHB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int COPLIEINKOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C62C40", Offset = "0x7C62040", VA = "0x187C62C40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C62C30", Offset = "0x7C62030", VA = "0x187C62C30")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct CMCEBAPNICA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 KBPOHLLNAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion PNEDBEMJDJJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly CMCEBAPNICA GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class OEMENHAOCFN
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct OCDPBKIPEOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float OCABEFOGMCB;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly OCDPBKIPEOO GCAAODGDGAI;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct OLNPMKALOPP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity CICOHMGGHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public LBLHMKOBDAM JCPHFIALCGL;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct NAGCCDMJEJA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public LBLHMKOBDAM JCPHFIALCGL;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct AFNMFCBIAEJ : ISystemStateComponentData, IComponentData, PLNJOFEBCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity BAENOJENPOO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity GAEEFHDEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct GKNLNGMFFAM : ISystemStateBufferElementData, IBufferElementData, PLNJOFEBCGI, IEquatable<GKNLNGMFFAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity ONPLLAIAOMF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity GAEEFHDEMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AAB470", Offset = "0x7AAA870", VA = "0x187AAB470", Slot = "6")]
	public bool Equals(GKNLNGMFFAM DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C627F0", Offset = "0x7C61BF0", VA = "0x187C627F0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA165E0", Offset = "0xA159E0", VA = "0x180A165E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct HHFHBKIEMPM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity CICOHMGGHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public LBLHMKOBDAM JCPHFIALCGL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct JLIPCBDFONL : IEqualityComparer<HHFHBKIEMPM>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static JLIPCBDFONL GCAAODGDGAI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C62E70", Offset = "0x7C62270", VA = "0x187C62E70", Slot = "4")]
	public bool Equals(HHFHBKIEMPM COBPEJEHIHC, HHFHBKIEMPM CEJJJCAALLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C62EC0", Offset = "0x7C622C0", VA = "0x187C62EC0", Slot = "5")]
	public int GetHashCode(HHFHBKIEMPM KLANNNFBLNB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct KLPPAECJBDP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> ECIJIOCGBJK;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct CHMNPPFDFLO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> ECIJIOCGBJK;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct ONBHAHILLIA : ISystemStateBufferElementData, IBufferElementData, PLNJOFEBCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity FHAONKDCGHA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity HAGCNILHEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6E20", Offset = "0xCE6220", VA = "0x180CE6E20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEAD0B0", Offset = "0xEAC4B0", VA = "0x180EAD0B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class GOKOJJAEEBK : ContainerPropertyBag<MJKLMOCNKJJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class GDEOEKFBNAD : Property<MJKLMOCNKJJ, FHCFNOFPAEF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C626D0", Offset = "0x7C61AD0", VA = "0x187C626D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C62690", Offset = "0x7C61A90", VA = "0x187C62690")]
		public GDEOEKFBNAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C61940", Offset = "0x7C60D40", VA = "0x187C61940", Slot = "14")]
		public override FHCFNOFPAEF GetValue(MJKLMOCNKJJ INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C61960", Offset = "0x7C60D60", VA = "0x187C61960", Slot = "15")]
		public override void SetValue(MJKLMOCNKJJ INELJPKBMLP, FHCFNOFPAEF OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C62880", Offset = "0x7C61C80", VA = "0x187C62880")]
	public GOKOJJAEEBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class GCHAIHDFCBE : ContainerPropertyBag<OBCIIOFBKHH>
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class EIELJJELEKO : Property<OBCIIOFBKHH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7C61D80", Offset = "0x7C61180", VA = "0x187C61D80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C61D40", Offset = "0x7C61140", VA = "0x187C61D40")]
		public EIELJJELEKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C61940", Offset = "0x7C60D40", VA = "0x187C61940", Slot = "14")]
		public override GameObject GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C61960", Offset = "0x7C60D60", VA = "0x187C61960", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, GameObject OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class AMMEMHOJONE : Property<OBCIIOFBKHH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7C61440", Offset = "0x7C60840", VA = "0x187C61440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7C61400", Offset = "0x7C60800", VA = "0x187C61400")]
		public AMMEMHOJONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7C613B0", Offset = "0x7C607B0", VA = "0x187C613B0", Slot = "14")]
		public override object GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7C613D0", Offset = "0x7C607D0", VA = "0x187C613D0", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, object OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class FLHBGKDFKCG : Property<OBCIIOFBKHH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7C61FF0", Offset = "0x7C613F0", VA = "0x187C61FF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C61FB0", Offset = "0x7C613B0", VA = "0x187C61FB0")]
		public FLHBGKDFKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C61F60", Offset = "0x7C61360", VA = "0x187C61F60", Slot = "14")]
		public override object GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C61F80", Offset = "0x7C61380", VA = "0x187C61F80", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, object OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class GEOJDDECOIK : Property<OBCIIOFBKHH, BAMDIAFJDCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7C62790", Offset = "0x7C61B90", VA = "0x187C62790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C62750", Offset = "0x7C61B50", VA = "0x187C62750")]
		public GEOJDDECOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C62700", Offset = "0x7C61B00", VA = "0x187C62700", Slot = "14")]
		public override BAMDIAFJDCJ GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C62720", Offset = "0x7C61B20", VA = "0x187C62720", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, BAMDIAFJDCJ OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class HBOMOONMOAN : Property<OBCIIOFBKHH, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7C62A60", Offset = "0x7C61E60", VA = "0x187C62A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C62A20", Offset = "0x7C61E20", VA = "0x187C62A20")]
		public HBOMOONMOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C629D0", Offset = "0x7C61DD0", VA = "0x187C629D0", Slot = "14")]
		public override Delegate GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C629F0", Offset = "0x7C61DF0", VA = "0x187C629F0", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, Delegate OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class CGDHBBMPJPJ : Property<OBCIIOFBKHH, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7C61720", Offset = "0x7C60B20", VA = "0x187C61720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C616E0", Offset = "0x7C60AE0", VA = "0x187C616E0")]
		public CGDHBBMPJPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C61690", Offset = "0x7C60A90", VA = "0x187C61690", Slot = "14")]
		public override Delegate GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C616B0", Offset = "0x7C60AB0", VA = "0x187C616B0", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, Delegate OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class DADBMMAKOIL : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7C61910", Offset = "0x7C60D10", VA = "0x187C61910", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C618D0", Offset = "0x7C60CD0", VA = "0x187C618D0")]
		public DADBMMAKOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C61880", Offset = "0x7C60C80", VA = "0x187C61880", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C618A0", Offset = "0x7C60CA0", VA = "0x187C618A0", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class DHCDNFBBLGA : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7C61A90", Offset = "0x7C60E90", VA = "0x187C61A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C61A50", Offset = "0x7C60E50", VA = "0x187C61A50")]
		public DHCDNFBBLGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C61A00", Offset = "0x7C60E00", VA = "0x187C61A00", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C61A20", Offset = "0x7C60E20", VA = "0x187C61A20", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class LGKJIKFNOPJ : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7C63310", Offset = "0x7C62710", VA = "0x187C63310", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C632D0", Offset = "0x7C626D0", VA = "0x187C632D0")]
		public LGKJIKFNOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C63280", Offset = "0x7C62680", VA = "0x187C63280", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C632A0", Offset = "0x7C626A0", VA = "0x187C632A0", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class MJDHEKKBJBL : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7C638A0", Offset = "0x7C62CA0", VA = "0x187C638A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C63860", Offset = "0x7C62C60", VA = "0x187C63860")]
		public MJDHEKKBJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C63810", Offset = "0x7C62C10", VA = "0x187C63810", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C63830", Offset = "0x7C62C30", VA = "0x187C63830", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class OFKEDCPFBGO : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7C63E70", Offset = "0x7C63270", VA = "0x187C63E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C63E30", Offset = "0x7C63230", VA = "0x187C63E30")]
		public OFKEDCPFBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C63DE0", Offset = "0x7C631E0", VA = "0x187C63DE0", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C63E00", Offset = "0x7C63200", VA = "0x187C63E00", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class DNCCFILJCED : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7C61C10", Offset = "0x7C61010", VA = "0x187C61C10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C61BD0", Offset = "0x7C60FD0", VA = "0x187C61BD0")]
		public DNCCFILJCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C61B80", Offset = "0x7C60F80", VA = "0x187C61B80", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C61BA0", Offset = "0x7C60FA0", VA = "0x187C61BA0", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class MLCMADBCOGE : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C639D0", Offset = "0x7C62DD0", VA = "0x187C639D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C63990", Offset = "0x7C62D90", VA = "0x187C63990")]
		public MLCMADBCOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C63940", Offset = "0x7C62D40", VA = "0x187C63940", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C63960", Offset = "0x7C62D60", VA = "0x187C63960", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class ODHACIELGDL : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C63DB0", Offset = "0x7C631B0", VA = "0x187C63DB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C63D70", Offset = "0x7C63170", VA = "0x187C63D70")]
		public ODHACIELGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C63D20", Offset = "0x7C63120", VA = "0x187C63D20", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C63D40", Offset = "0x7C63140", VA = "0x187C63D40", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class PJOFOGFFFBC : Property<OBCIIOFBKHH, OAGGALGHDAH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7C63F30", Offset = "0x7C63330", VA = "0x187C63F30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C63EF0", Offset = "0x7C632F0", VA = "0x187C63EF0")]
		public PJOFOGFFFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C63EA0", Offset = "0x7C632A0", VA = "0x187C63EA0", Slot = "14")]
		public override OAGGALGHDAH<Delegate> GetValue(OBCIIOFBKHH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C63EC0", Offset = "0x7C632C0", VA = "0x187C63EC0", Slot = "15")]
		public override void SetValue(OBCIIOFBKHH INELJPKBMLP, OAGGALGHDAH<Delegate> OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C62030", Offset = "0x7C61430", VA = "0x187C62030")]
	public GCHAIHDFCBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class BMKGIDLJMDD : ContainerPropertyBag<OAGGALGHDAH<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C61630", Offset = "0x7C60A30", VA = "0x187C61630")]
	public BMKGIDLJMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class FHEIBOBCOEP : ContainerPropertyBag<MCAIIHKAOED>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class LOFJEOJLAND : Property<MCAIIHKAOED, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7C63380", Offset = "0x7C62780", VA = "0x187C63380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C63340", Offset = "0x7C62740", VA = "0x187C63340")]
		public LOFJEOJLAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C61940", Offset = "0x7C60D40", VA = "0x187C61940", Slot = "14")]
		public override Rigidbody GetValue(MCAIIHKAOED INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C61960", Offset = "0x7C60D60", VA = "0x187C61960", Slot = "15")]
		public override void SetValue(MCAIIHKAOED INELJPKBMLP, Rigidbody OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C61DF0", Offset = "0x7C611F0", VA = "0x187C61DF0")]
	public FHEIBOBCOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class BBEFPHPELLG : ContainerPropertyBag<IAGAJJJBLLH>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class DDNCCPGKBEN : Property<IAGAJJJBLLH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7C619D0", Offset = "0x7C60DD0", VA = "0x187C619D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C61990", Offset = "0x7C60D90", VA = "0x187C61990")]
		public DDNCCPGKBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C61940", Offset = "0x7C60D40", VA = "0x187C61940", Slot = "14")]
		public override object GetValue(IAGAJJJBLLH INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C61960", Offset = "0x7C60D60", VA = "0x187C61960", Slot = "15")]
		public override void SetValue(IAGAJJJBLLH INELJPKBMLP, object OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C61480", Offset = "0x7C60880", VA = "0x187C61480")]
	public BBEFPHPELLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class KOGODPKICNB : ContainerPropertyBag<BFNILLHBIMI>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class JLCDOFDEEBG : Property<BFNILLHBIMI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7C62E40", Offset = "0x7C62240", VA = "0x187C62E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C62E00", Offset = "0x7C62200", VA = "0x187C62E00")]
		public JLCDOFDEEBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C61940", Offset = "0x7C60D40", VA = "0x187C61940", Slot = "14")]
		public override object GetValue(BFNILLHBIMI INELJPKBMLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C61960", Offset = "0x7C60D60", VA = "0x187C61960", Slot = "15")]
		public override void SetValue(BFNILLHBIMI INELJPKBMLP, object OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C62F20", Offset = "0x7C62320", VA = "0x187C62F20")]
	public KOGODPKICNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class AHAPPABDIFA : ContainerPropertyBag<MAAEBNKLKDN>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class MAFIHJMKJGA : Property<MAAEBNKLKDN, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7C63400", Offset = "0x7C62800", VA = "0x187C63400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C633C0", Offset = "0x7C627C0", VA = "0x187C633C0")]
		public MAFIHJMKJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xE266A0", Offset = "0xE25AA0", VA = "0x180E266A0", Slot = "14")]
		public override Entity GetValue(MAAEBNKLKDN INELJPKBMLP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C633B0", Offset = "0x7C627B0", VA = "0x187C633B0", Slot = "15")]
		public override void SetValue(MAAEBNKLKDN INELJPKBMLP, Entity OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C612D0", Offset = "0x7C606D0", VA = "0x187C612D0")]
	public AHAPPABDIFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class MMPDBIDDNAG : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class GPKDFKKGNGG : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7C629A0", Offset = "0x7C61DA0", VA = "0x187C629A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C62960", Offset = "0x7C61D60", VA = "0x187C62960")]
		public GPKDFKKGNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x20EBB50", Offset = "0x20EAF50", VA = "0x1820EBB50", Slot = "14")]
		public override int GetValue(Entity INELJPKBMLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AA6B00", Offset = "0x7AA5F00", VA = "0x187AA6B00", Slot = "15")]
		public override void SetValue(Entity INELJPKBMLP, int OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class DJEHDKBPKEF : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string LIPJOHOCCJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7C61B10", Offset = "0x7C60F10", VA = "0x187C61B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool HGFLKIPPAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C61AD0", Offset = "0x7C60ED0", VA = "0x187C61AD0")]
		public DJEHDKBPKEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xEB8A90", Offset = "0xEB7E90", VA = "0x180EB8A90", Slot = "14")]
		public override int GetValue(Entity INELJPKBMLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C61AC0", Offset = "0x7C60EC0", VA = "0x187C61AC0", Slot = "15")]
		public override void SetValue(Entity INELJPKBMLP, int OOEMJLHLIHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C63A00", Offset = "0x7C62E00", VA = "0x187C63A00")]
	public MMPDBIDDNAG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C63F60", Offset = "0x7C63360", VA = "0x187C63F60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class PBFMMKCDNDG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public PBFMMKCDNDG()
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

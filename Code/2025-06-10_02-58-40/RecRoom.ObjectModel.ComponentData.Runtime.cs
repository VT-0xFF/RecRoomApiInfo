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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DFFC20", Offset = "0x7DFEE20", VA = "0x187DFFC20", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFFB0", Offset = "0x7DFF1B0", VA = "0x187DFFFB0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct ABLLDNPDNIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct JCBLIENCBCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct FLAANJMEOOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct EKLDPGBBGDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct IOAIHOPGKCP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCBF0", Offset = "0x7DFBDF0", VA = "0x187DFCBF0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct BBGFNMCNCGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct LKOKHAJBGDI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct LGKMIAELLPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity JFAHHPPOJNG;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct MAGGCOLODHF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity JFAHHPPOJNG;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FBIMDJLIBNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<HINOCLFALGO> OLPCAOJAAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> AGMBNFMMDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle KHHGIDEGAOE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PAKAGCJKALC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD7B0", Offset = "0x7DFC9B0", VA = "0x187DFD7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD760", Offset = "0x7DFC960", VA = "0x187DFD760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CBF820", Offset = "0x5CBEA20", VA = "0x185CBF820")]
	public FBIMDJLIBNC(NativeList<HINOCLFALGO> OLPCAOJAAOJ, NativeList<Entity> AGMBNFMMDMN, JobHandle KHHGIDEGAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD820", Offset = "0x7DFCA20", VA = "0x187DFD820")]
	public (Entity, NativeSlice<Entity>) IPNEKNFMDIJ(int HPPAPFGKKNG)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD700", Offset = "0x7DFC900", VA = "0x187DFD700", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HINOCLFALGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity OLEJNEHCCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int GJBFKFHLHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int CLBDAFJFHFB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PMGGNLKKOFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PICPAFPEIKF(bool LJFEJDPLDJD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct MKAKBJIMMNG : IEquatable<MKAKBJIMMNG>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool CIEDOPPGDPF(int MKCPMOJFGDP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool NMDKNCNNCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool MLJCCALADEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool KBDEHAENDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool AGDNDBGNABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CIEDOPPGDPF NHFJPKDONOK;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEDA0", Offset = "0x7DFDFA0", VA = "0x187DFEDA0")]
	public MKAKBJIMMNG(JMAPILMLMLJ FFMDBMBLMEI, CIEDOPPGDPF NHFJPKDONOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEDF0", Offset = "0x7DFDFF0", VA = "0x187DFEDF0")]
	public MKAKBJIMMNG(bool NMDKNCNNCAF, bool MLJCCALADEO, bool KBDEHAENDDM, bool AGDNDBGNABC, CIEDOPPGDPF NHFJPKDONOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEAB0", Offset = "0x7DFDCB0", VA = "0x187DFEAB0")]
	public bool BOPPNFKILLK(int MKCPMOJFGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DFECB0", Offset = "0x7DFDEB0", VA = "0x187DFECB0")]
	public bool LANPJHJNOOC(int MKCPMOJFGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEBC0", Offset = "0x7DFDDC0", VA = "0x187DFEBC0")]
	public bool FDBHOODHHCJ(int MKCPMOJFGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7DFECE0", Offset = "0x7DFDEE0", VA = "0x187DFECE0")]
	public bool MGNLCPCDKFF(int MKCPMOJFGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEB90", Offset = "0x7DFDD90", VA = "0x187DFEB90", Slot = "4")]
	public bool Equals(MKAKBJIMMNG CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEAE0", Offset = "0x7DFDCE0", VA = "0x187DFEAE0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEBF0", Offset = "0x7DFDDF0", VA = "0x187DFEBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEC90", Offset = "0x7DFDE90", VA = "0x187DFEC90")]
	private bool HJLNFGAJNIK(int MKCPMOJFGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DFED10", Offset = "0x7DFDF10", VA = "0x187DFED10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JBOMKNOFFKP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NLCJIIIDMMO MHIOLFBBMPO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE3B0", Offset = "0x7DFD5B0", VA = "0x187DFE3B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JBOMKNOFFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NLCJIIIDMMO
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct GNCPNMDBBHL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct GPEEJLFGMIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly CJNICJGKPAB PGLOAFGFKBA;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F37ED0", Offset = "0x2F370D0", VA = "0x182F37ED0")]
	public GPEEJLFGMIH(CJNICJGKPAB PGLOAFGFKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDD50", Offset = "0x7DFCF50", VA = "0x187DFDD50")]
	public GPEEJLFGMIH KKCEBPBJLJH(CJNICJGKPAB PIJDCMHMNNF)
	{
		return default(GPEEJLFGMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDD40", Offset = "0x7DFCF40", VA = "0x187DFDD40")]
	public GPEEJLFGMIH CDOJHGGDHOP(CJNICJGKPAB MNACDBGCJOA)
	{
		return default(GPEEJLFGMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDD60", Offset = "0x7DFCF60", VA = "0x187DFDD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Flags]
public enum CJNICJGKPAB : ushort
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
public static class NCCHMBDFNAG
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct PIFFIJNDCIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public CJNICJGKPAB IEDHMOHOLHK;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DFF450", Offset = "0x7DFE650", VA = "0x187DFF450")]
	public bool EGAKLGIHIPH(GPEEJLFGMIH DIHLNNHKGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DFF460", Offset = "0x7DFE660", VA = "0x187DFF460")]
	public bool HMNDMNBMIFO(GPEEJLFGMIH DIHLNNHKGLP, CJNICJGKPAB OHKDJNBMMEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum DEIAIKPOOFM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct EDDHNKEPNEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DEIAIKPOOFM PGLOAFGFKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool JGDLAIEHCOH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JHANCCLDKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD500", Offset = "0x7DFC700", VA = "0x187DFD500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD510", Offset = "0x7DFC710", VA = "0x187DFD510")]
	private EDDHNKEPNEE(DEIAIKPOOFM PGLOAFGFKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD4E0", Offset = "0x7DFC6E0", VA = "0x187DFD4E0")]
	public EDDHNKEPNEE KKCEBPBJLJH(DEIAIKPOOFM PIJDCMHMNNF)
	{
		return default(EDDHNKEPNEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD4C0", Offset = "0x7DFC6C0", VA = "0x187DFD4C0")]
	public EDDHNKEPNEE CDOJHGGDHOP(DEIAIKPOOFM MNACDBGCJOA)
	{
		return default(EDDHNKEPNEE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct HBBOJDDDHOP : IComponentData
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
public struct IHCLHKAHLAJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity MOMEOMBMFPA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, DKLHOFAAIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCBF0", Offset = "0x7DFBDF0", VA = "0x187DFCBF0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct IAHJJNLMFPI : ISystemStateBufferElementData, IBufferElementData, DKLHOFAAIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity GONFONDIOED;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity JICIEFKGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct BFKACBDPFLE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity FDFGDJGPNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity PKBAIIDGHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity KLLGBEEAAOG;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KBFNEAFJBPH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly bool APFGOMCKPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public uint BGEEALDEFFK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool MBFFJGHMMOD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct BAAGKDAJDCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint HMKPOFFJPBA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
	public BAAGKDAJDCP(DLILJGCOAIF HHOFDEAFCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCC00", Offset = "0x7DFBE00", VA = "0x187DFCC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D1D0", Offset = "0x1F5C3D0", VA = "0x181F5D1D0")]
	public static BAAGKDAJDCP PDHAGBEBCNG(DLILJGCOAIF HHOFDEAFCJP)
	{
		return default(BAAGKDAJDCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct GNDIHKEAJPG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Entity GONFONDIOED;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct OCOHINEJOLI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public DLILJGCOAIF KJIOHKMJAPE;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct ICKGGOAOILM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity GONFONDIOED;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct COJANLEAKIB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Guid DJOIAEMCFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int OCEHNHGKKJH;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct OPGEFOEJDIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int KJIOHKMJAPE;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct DOCEKOCKAJF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity GONFONDIOED;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct MAGMHGCFMKG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public DLILJGCOAIF KJIOHKMJAPE;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct OBLHCBDGOOH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity GONFONDIOED;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct OICJGINCEHN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
[SingletonComponent]
public struct GDPHIKGAPGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int KDKKOEPGIOI;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct PINLEKHNAFH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LPGODJOFLMG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NPGIOFFINPJ EHJMMMPNJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0")]
		get
		{
			return default(NPGIOFFINPJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct IAABCHFOLKE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public GCHandle CJIPBCBECNM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct AKFIFNJBHMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct GEILNKJKLOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct ECNFOKCJHHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct GJLHGDJHIHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct LCJGGCOHKKN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct GELPHPLEPKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public int CMDFFDAPDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int EPCDIDIGEAG;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDC30", Offset = "0x7DFCE30", VA = "0x187DFDC30")]
	public GELPHPLEPKM(Entity GONFONDIOED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct CHLLLANMGIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public CollisionDetectionMode EAGNKJBBBFL;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct BLDANKECKMP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public DLGGNNMFNFI BJOKEBBCKEN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly BLDANKECKMP LGHIFDBIJOC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct CPAHNGFMKIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct AGGMEFHCMCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct LMEFICOBIML : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct PNEFGKAIEAE : IBufferElementData, IEquatable<PNEFGKAIEAE>, DKLHOFAAIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Entity JPCNHODHEGA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity HGOADOFLMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCBF0", Offset = "0x7DFBDF0", VA = "0x187DFCBF0", Slot = "4")]
	public bool Equals(PNEFGKAIEAE CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct EPMKBPCEFNH : IComponentData, DKLHOFAAIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity FLKKOCNDECC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity HGOADOFLMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct JMHHGLAHKBD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct BLEDJAOOEIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity OLEJNEHCCLF;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct HMLGHBJKKGD : JIJNINCELOC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KHPAGHLCBPJ JAFKIBCGFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KHPAGHLCBPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct FODNPPDDCED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float3 BGJHDLDOPEP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct LPMNHLDGEPE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct GABGBLOKHEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3x3 FPNINKIFPEL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly GABGBLOKHEM LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct KHPHHHAPPMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float3x3 FPNINKIFPEL;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KHPHHHAPPMB LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct JGIEDMEMEKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 KJBLMOLJCFH;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct AFMPIPNFIDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 MIABBFMNEAM;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct FMNKFCBHGNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float PPLIIDFMLFD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly FMNKFCBHGNB LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct OGKPOAIOAFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float KEPKOEINOKO;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly OGKPOAIOAFL LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct EDGEPEMEBGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float3 AFEMOKLBAFK;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct BFHEIILPHOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public JOHOKOFPFMP OJDGNKGODEN;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct KMCMBNNDPFB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity GONFONDIOED;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct IOCMNIFIEAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct JPBKICDLCCE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct JNECDFDCBEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public RigidbodyConstraints EJJDBFLMEOO;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct ANAIFGNFOIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float NBMGNKBIKAP;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly ANAIFGNFOIG LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct HNHAKLEBFDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float LOIIKFBOEPH;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class LHNHAOIHJIF : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public GameObject LBBGHAOMHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public object DABPEKAOOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object MGCDEJLDKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public AMDJOLLNHGD FKBPAPGLMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Delegate OMCCCMNCHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate CLBADEIPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NKNHMBEFOJB<Delegate> OBOIEICLLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NKNHMBEFOJB<Delegate> HPBJMBLCOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NKNHMBEFOJB<Delegate> JAGLJIKHAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public NKNHMBEFOJB<Delegate> ADLKEDIPANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public NKNHMBEFOJB<Delegate> MIHMCAHAGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public NKNHMBEFOJB<Delegate> MNHMEEKMIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public NKNHMBEFOJB<Delegate> HOEDMABAHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public NKNHMBEFOJB<Delegate> DJHGJCOPOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NKNHMBEFOJB<Delegate> FHEFALFLFFJ;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE8E0", Offset = "0x7DFDAE0", VA = "0x187DFE8E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public LHNHAOIHJIF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct JMMFMBDGLFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct PNMEHDJMHLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int LFCJGCMMCCB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1F5D1D0", Offset = "0x1F5C3D0", VA = "0x181F5D1D0")]
	public static PNMEHDJMHLM PDHAGBEBCNG(int KJIOHKMJAPE)
	{
		return default(PNMEHDJMHLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class GNDNFFKNGON : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Rigidbody CCNFPPEFCMI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDCD0", Offset = "0x7DFCED0", VA = "0x187DFDCD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GNDNFFKNGON()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct POBBKBIBOHH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct EDFFOOJNAPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3 MKIIBLHCBDM;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct JEKFLEAHBDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 AJNMLFPKEJH;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct LEOKEDOCGKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float JCIDHECHMEG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly LEOKEDOCGKI LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class DIOOHKIBIBA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public object AHPOKBNMGKM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD450", Offset = "0x7DFC650", VA = "0x187DFD450", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public DIOOHKIBIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AEMCGMLCEMK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object AJIMPGMIHHH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC9B0", Offset = "0x7DFBBB0", VA = "0x187DFC9B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public AEMCGMLCEMK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct LNKOKDAFCGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct KGMFDMNBMMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct GDDHLAPAKCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct EPALGPKJNAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct NCHAOCBDLBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct INDIPNNNLLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct KECBABDLMOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct IGIAGNPMBAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct CFNJPOIFCME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct FOPMFMENICO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct DDADPKJHACL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public CEAHLANEAPC HAPPMEIKPMA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCDA0", Offset = "0x7DFBFA0", VA = "0x187DFCDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct IDOABGJHKDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct KPNPOJKHHPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct KPILIFIAHOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct BDMMIHCOPGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes GBOCGPJOEEK;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct DHDGDJOCDLD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UnsafeParallelHashMap<CEAHLANEAPC, Entity> KHIBIJKKAAD;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct GPOOLPGLJIK : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Entity DACPGIGDMOH;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct IBMIFICCMBC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity GONFONDIOED;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static IBMIFICCMBC PDHAGBEBCNG(Entity GONFONDIOED)
	{
		return default(IBMIFICCMBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct GBFNFKDJJFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity MFKBAGDPAIE;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct LKBCOEFKFKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity MFKBAGDPAIE;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct DLNGONDELHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity AFKNNCDCNBL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xCDE2C0", Offset = "0xCDD4C0", VA = "0x180CDE2C0")]
	public static DLNGONDELHJ PDHAGBEBCNG(Entity GONFONDIOED)
	{
		return default(DLNGONDELHJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct KPFDGEAPOOA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct GNCFLNBMHCJ : IBufferElementData, IEquatable<GNCFLNBMHCJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity NMGEDOJLPMK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C02A80", Offset = "0x7C01C80", VA = "0x187C02A80", Slot = "4")]
	public bool Equals(GNCFLNBMHCJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7DFDC40", Offset = "0x7DFCE40", VA = "0x187DFDC40", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct GBPAGEBKAGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public uint EPCDIDIGEAG;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
[SingletonComponent]
internal struct GBIGHPGHLEG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity FNPPOOMPKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public int CMDFFDAPDIB;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct KPBGJGIFEKL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Entity MJAMAMCODKD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct DMODOMHKINH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct FAKNALFLPLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public uint BGEEALDEFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int ODELOIMFAKB;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD9EE70", Offset = "0xD9E070", VA = "0x180D9EE70")]
	public FAKNALFLPLF(uint HCGGAHHFICN, int CCGNCIIBLJM)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct DBPOFIKPCHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct EMEAKNAGKDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct DDFOINPECDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct PCGGADKDHHF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct MEOOFMBCALN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct HEAKJGLKLFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct GNCBHADNICG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct AJJGFAHIMKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct KFKIKLDCEHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct HJGIJEBNMPK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct ENECMDOOPPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct NKPGNLOHNCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct PPBIGIGDGJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct GMEJHDFJGHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct FPIBFGILFFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct HEPFPKIMKJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct CDNKLBEDHJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct HOABDDGCCMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct HGJEIPOFKHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct FHBCKEPGMMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct HMAOEDGCBBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct ENDJAICIPKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct DBFCHGDOIMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct BCEOHGGDFIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct KFBMPECEMCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct CABJKKOADAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct LBBMHLMEGNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct KJHPMBEOAHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct DCLNALMPHDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct ELFKNBOCOJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct DJDFKKDHDFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct DDHCACHNEOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct IEHNPODGACK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[CFDCGBDKGOG]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct BNAOGGDDIFN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct IMPAIMEJGNO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public FixedString32Bytes BGOPKLLOOIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct BGILCBNBBMN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct DAPMLCHJGBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct NMOONELODLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct BJJODNBLICF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct FGMNPONPFJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct GHFHCCDFHAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct KHBDLACEFOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct GADPGBFPCDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public quaternion NDOBKEDDJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 FICCENLPJEL;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct PJMBPCFKIDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float BCMOOOIKOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float INGHLFNCJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float LBCJABIMDKB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct CFMGEHCIFMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct DHJKIFGDHBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct IGBCMOIACKP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct GEOHMAGFJDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public int LPGODJOFLMG;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
[SingletonComponent]
public struct PONLMGLGDJC : ISystemStateBufferElementData, IBufferElementData, DKLHOFAAIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity JKJCIPJAKEC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Entity JICIEFKGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct NDHAGPPJPML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float4x4 FIMMFIEBCLJ;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly NDHAGPPJPML LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct PDLMABGEIEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float4x4 FEOMPHHNKMM;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly PDLMABGEIEI LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct OLDECGIPMEB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int BIOEBEIDDBG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CMDFFDAPDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF1A0", Offset = "0x7DFE3A0", VA = "0x187DFF1A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF190", Offset = "0x7DFE390", VA = "0x187DFF190")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct BOJFIKNJDFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public float3 FICCENLPJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public quaternion NDOBKEDDJAJ;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BOJFIKNJDFL LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class MELIAGBMLEC
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct HABDEBMFOCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float BKMPKPMOIOP;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly HABDEBMFOCF LGHIFDBIJOC;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct MOPEPEDNGKP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity IMLPAHMDDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public HEGALGDCMOB LHEEKNEOKAD;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct FPMJJDJHBJG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public HEGALGDCMOB LHEEKNEOKAD;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct OKCCNMEAFGA : ISystemStateComponentData, IComponentData, DKLHOFAAIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity IMMAKBDNFNI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity JICIEFKGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct HJNPHOCKFGJ : ISystemStateBufferElementData, IBufferElementData, DKLHOFAAIEO, IEquatable<HJNPHOCKFGJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity LFEADGGKLGE;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity JICIEFKGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C02A80", Offset = "0x7C01C80", VA = "0x187C02A80", Slot = "6")]
	public bool Equals(HJNPHOCKFGJ CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE040", Offset = "0x7DFD240", VA = "0x187DFE040", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct NBADFGDODKP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity IMLPAHMDDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public HEGALGDCMOB LHEEKNEOKAD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct AMIBCNLLMMO : IEqualityComparer<NBADFGDODKP>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static AMIBCNLLMMO LGHIFDBIJOC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCA20", Offset = "0x7DFBC20", VA = "0x187DFCA20", Slot = "4")]
	public bool Equals(NBADFGDODKP HGCMPGNMMIB, NBADFGDODKP PIALGICKFLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCA70", Offset = "0x7DFBC70", VA = "0x187DFCA70", Slot = "5")]
	public int GetHashCode(NBADFGDODKP KFMNDOMPAMC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct LLKGDDIIAMD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public FixedList32Bytes<int> OECAECFBJIG;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct IMNLHKOJCIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> OECAECFBJIG;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct DMKPOJAEOCL : ISystemStateBufferElementData, IBufferElementData, DKLHOFAAIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Entity OHPCEBGFIIA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Entity HGOADOFLMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x124E8B0", Offset = "0x124DAB0", VA = "0x18124E8B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class NDKOCNHEIHN : ContainerPropertyBag<JBOMKNOFFKP>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class PLNGKFJKIII : Property<JBOMKNOFFKP, NLCJIIIDMMO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7DFF4C0", Offset = "0x7DFE6C0", VA = "0x187DFF4C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF480", Offset = "0x7DFE680", VA = "0x187DFF480")]
		public PLNGKFJKIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE4E0", Offset = "0x7DFD6E0", VA = "0x187DFE4E0", Slot = "14")]
		public override NLCJIIIDMMO GetValue(JBOMKNOFFKP MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE500", Offset = "0x7DFD700", VA = "0x187DFE500", Slot = "15")]
		public override void SetValue(JBOMKNOFFKP MBLPEFIMNGA, NLCJIIIDMMO KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEED0", Offset = "0x7DFE0D0", VA = "0x187DFEED0")]
	public NDKOCNHEIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class DEDBEFNKEMC : ContainerPropertyBag<LHNHAOIHJIF>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class JPAPOALAKHE : Property<LHNHAOIHJIF, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE6A0", Offset = "0x7DFD8A0", VA = "0x187DFE6A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE660", Offset = "0x7DFD860", VA = "0x187DFE660")]
		public JPAPOALAKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE4E0", Offset = "0x7DFD6E0", VA = "0x187DFE4E0", Slot = "14")]
		public override GameObject GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE500", Offset = "0x7DFD700", VA = "0x187DFE500", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, GameObject KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class FMKKOEIDKJF : Property<LHNHAOIHJIF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7DFDAD0", Offset = "0x7DFCCD0", VA = "0x187DFDAD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDA90", Offset = "0x7DFCC90", VA = "0x187DFDA90")]
		public FMKKOEIDKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDA40", Offset = "0x7DFCC40", VA = "0x187DFDA40", Slot = "14")]
		public override object GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDA60", Offset = "0x7DFCC60", VA = "0x187DFDA60", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, object KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class EPKALGEMBHD : Property<LHNHAOIHJIF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD6D0", Offset = "0x7DFC8D0", VA = "0x187DFD6D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD690", Offset = "0x7DFC890", VA = "0x187DFD690")]
		public EPKALGEMBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD640", Offset = "0x7DFC840", VA = "0x187DFD640", Slot = "14")]
		public override object GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD660", Offset = "0x7DFC860", VA = "0x187DFD660", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, object KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class JKPNBPPJBPB : Property<LHNHAOIHJIF, AMDJOLLNHGD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE630", Offset = "0x7DFD830", VA = "0x187DFE630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE5F0", Offset = "0x7DFD7F0", VA = "0x187DFE5F0")]
		public JKPNBPPJBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE5A0", Offset = "0x7DFD7A0", VA = "0x187DFE5A0", Slot = "14")]
		public override AMDJOLLNHGD GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE5C0", Offset = "0x7DFD7C0", VA = "0x187DFE5C0", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, AMDJOLLNHGD KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class PGENJLIDKCO : Property<LHNHAOIHJIF, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7DFF420", Offset = "0x7DFE620", VA = "0x187DFF420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF3E0", Offset = "0x7DFE5E0", VA = "0x187DFF3E0")]
		public PGENJLIDKCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF390", Offset = "0x7DFE590", VA = "0x187DFF390", Slot = "14")]
		public override Delegate GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF3B0", Offset = "0x7DFE5B0", VA = "0x187DFF3B0", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, Delegate KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class HMCCNICBMPH : Property<LHNHAOIHJIF, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE240", Offset = "0x7DFD440", VA = "0x187DFE240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE200", Offset = "0x7DFD400", VA = "0x187DFE200")]
		public HMCCNICBMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE1B0", Offset = "0x7DFD3B0", VA = "0x187DFE1B0", Slot = "14")]
		public override Delegate GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE1D0", Offset = "0x7DFD3D0", VA = "0x187DFE1D0", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, Delegate KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class HDNNHOEKMJP : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7DFDF50", Offset = "0x7DFD150", VA = "0x187DFDF50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDF10", Offset = "0x7DFD110", VA = "0x187DFDF10")]
		public HDNNHOEKMJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDEC0", Offset = "0x7DFD0C0", VA = "0x187DFDEC0", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDEE0", Offset = "0x7DFD0E0", VA = "0x187DFDEE0", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class HBDDJOEMAIP : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7DFDE90", Offset = "0x7DFD090", VA = "0x187DFDE90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDE50", Offset = "0x7DFD050", VA = "0x187DFDE50")]
		public HBDDJOEMAIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDE00", Offset = "0x7DFD000", VA = "0x187DFDE00", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDE20", Offset = "0x7DFD020", VA = "0x187DFDE20", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class ONMDBHHDHFH : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7DFF2B0", Offset = "0x7DFE4B0", VA = "0x187DFF2B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF270", Offset = "0x7DFE470", VA = "0x187DFF270")]
		public ONMDBHHDHFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF220", Offset = "0x7DFE420", VA = "0x187DFF220", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF240", Offset = "0x7DFE440", VA = "0x187DFF240", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class EPHNKBHGOMP : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD610", Offset = "0x7DFC810", VA = "0x187DFD610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD5D0", Offset = "0x7DFC7D0", VA = "0x187DFD5D0")]
		public EPHNKBHGOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD580", Offset = "0x7DFC780", VA = "0x187DFD580", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD5A0", Offset = "0x7DFC7A0", VA = "0x187DFD5A0", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class HEJCNNKEPKK : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE010", Offset = "0x7DFD210", VA = "0x187DFE010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDFD0", Offset = "0x7DFD1D0", VA = "0x187DFDFD0")]
		public HEJCNNKEPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDF80", Offset = "0x7DFD180", VA = "0x187DFDF80", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDFA0", Offset = "0x7DFD1A0", VA = "0x187DFDFA0", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class LMJFEPLCIMH : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE9C0", Offset = "0x7DFDBC0", VA = "0x187DFE9C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE980", Offset = "0x7DFDB80", VA = "0x187DFE980")]
		public LMJFEPLCIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE930", Offset = "0x7DFDB30", VA = "0x187DFE930", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE950", Offset = "0x7DFDB50", VA = "0x187DFE950", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class JCNOJPCIGPM : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE4B0", Offset = "0x7DFD6B0", VA = "0x187DFE4B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE470", Offset = "0x7DFD670", VA = "0x187DFE470")]
		public JCNOJPCIGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE420", Offset = "0x7DFD620", VA = "0x187DFE420", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE440", Offset = "0x7DFD640", VA = "0x187DFE440", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class NPNNLHPPOOK : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7DFF120", Offset = "0x7DFE320", VA = "0x187DFF120", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF0E0", Offset = "0x7DFE2E0", VA = "0x187DFF0E0")]
		public NPNNLHPPOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF090", Offset = "0x7DFE290", VA = "0x187DFF090", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF0B0", Offset = "0x7DFE2B0", VA = "0x187DFF0B0", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class MDAIJNKMMHI : Property<LHNHAOIHJIF, NKNHMBEFOJB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7DFEA80", Offset = "0x7DFDC80", VA = "0x187DFEA80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEA40", Offset = "0x7DFDC40", VA = "0x187DFEA40")]
		public MDAIJNKMMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE9F0", Offset = "0x7DFDBF0", VA = "0x187DFE9F0", Slot = "14")]
		public override NKNHMBEFOJB<Delegate> GetValue(LHNHAOIHJIF MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEA10", Offset = "0x7DFDC10", VA = "0x187DFEA10", Slot = "15")]
		public override void SetValue(LHNHAOIHJIF MBLPEFIMNGA, NKNHMBEFOJB<Delegate> KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCDF0", Offset = "0x7DFBFF0", VA = "0x187DFCDF0")]
	public DEDBEFNKEMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class ENBFMJMMEOD : ContainerPropertyBag<NKNHMBEFOJB<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD520", Offset = "0x7DFC720", VA = "0x187DFD520")]
	public ENBFMJMMEOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class NJCEBDJBMBH : ContainerPropertyBag<GNDNFFKNGON>
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class JEMJCAKNGPL : Property<GNDNFFKNGON, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE570", Offset = "0x7DFD770", VA = "0x187DFE570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE530", Offset = "0x7DFD730", VA = "0x187DFE530")]
		public JEMJCAKNGPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE4E0", Offset = "0x7DFD6E0", VA = "0x187DFE4E0", Slot = "14")]
		public override Rigidbody GetValue(GNDNFFKNGON MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE500", Offset = "0x7DFD700", VA = "0x187DFE500", Slot = "15")]
		public override void SetValue(GNDNFFKNGON MBLPEFIMNGA, Rigidbody KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7DFEFB0", Offset = "0x7DFE1B0", VA = "0x187DFEFB0")]
	public NJCEBDJBMBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class APJMJJMBENK : ContainerPropertyBag<DIOOHKIBIBA>
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class OLNPFHELLAE : Property<DIOOHKIBIBA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7DFF1F0", Offset = "0x7DFE3F0", VA = "0x187DFF1F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF1B0", Offset = "0x7DFE3B0", VA = "0x187DFF1B0")]
		public OLNPFHELLAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE4E0", Offset = "0x7DFD6E0", VA = "0x187DFE4E0", Slot = "14")]
		public override object GetValue(DIOOHKIBIBA MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE500", Offset = "0x7DFD700", VA = "0x187DFE500", Slot = "15")]
		public override void SetValue(DIOOHKIBIBA MBLPEFIMNGA, object KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7DFCB10", Offset = "0x7DFBD10", VA = "0x187DFCB10")]
	public APJMJJMBENK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class AAPJNHEMHOD : ContainerPropertyBag<AEMCGMLCEMK>
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class LDHDCMOOJOJ : Property<AEMCGMLCEMK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE870", Offset = "0x7DFDA70", VA = "0x187DFE870", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE830", Offset = "0x7DFDA30", VA = "0x187DFE830")]
		public LDHDCMOOJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE4E0", Offset = "0x7DFD6E0", VA = "0x187DFE4E0", Slot = "14")]
		public override object GetValue(AEMCGMLCEMK MBLPEFIMNGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE500", Offset = "0x7DFD700", VA = "0x187DFE500", Slot = "15")]
		public override void SetValue(AEMCGMLCEMK MBLPEFIMNGA, object KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7DFC8D0", Offset = "0x7DFBAD0", VA = "0x187DFC8D0")]
	public AAPJNHEMHOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class HLDGIDIHNJG : ContainerPropertyBag<GPOOLPGLJIK>
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class FJEICAINKKG : Property<GPOOLPGLJIK, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7DFDA10", Offset = "0x7DFCC10", VA = "0x187DFDA10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD9D0", Offset = "0x7DFCBD0", VA = "0x187DFD9D0")]
		public FJEICAINKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xAC7530", Offset = "0xAC6730", VA = "0x180AC7530", Slot = "14")]
		public override Entity GetValue(GPOOLPGLJIK MBLPEFIMNGA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD9C0", Offset = "0x7DFCBC0", VA = "0x187DFD9C0", Slot = "15")]
		public override void SetValue(GPOOLPGLJIK MBLPEFIMNGA, Entity KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE0D0", Offset = "0x7DFD2D0", VA = "0x187DFE0D0")]
	public HLDGIDIHNJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class INLECNBFMPG : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class KKNFNNMBHEL : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7DFE800", Offset = "0x7DFDA00", VA = "0x187DFE800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE7C0", Offset = "0x7DFD9C0", VA = "0x187DFE7C0")]
		public KKNFNNMBHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2295500", Offset = "0x2294700", VA = "0x182295500", Slot = "14")]
		public override int GetValue(Entity MBLPEFIMNGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDE30", Offset = "0x7BFD030", VA = "0x187BFDE30", Slot = "15")]
		public override void SetValue(Entity MBLPEFIMNGA, int KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class FEGBEOBKGDL : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string KGCJIDMKOBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD990", Offset = "0x7DFCB90", VA = "0x187DFD990", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool JNOIOHADNLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD950", Offset = "0x7DFCB50", VA = "0x187DFD950")]
		public FEGBEOBKGDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x125C8E0", Offset = "0x125BAE0", VA = "0x18125C8E0", Slot = "14")]
		public override int GetValue(Entity MBLPEFIMNGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD940", Offset = "0x7DFCB40", VA = "0x187DFD940", Slot = "15")]
		public override void SetValue(Entity MBLPEFIMNGA, int KJIOHKMJAPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE270", Offset = "0x7DFD470", VA = "0x187DFE270")]
	public INLECNBFMPG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF4F0", Offset = "0x7DFE6F0", VA = "0x187DFF4F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class JIMOOFOMAIG
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public JIMOOFOMAIG()
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

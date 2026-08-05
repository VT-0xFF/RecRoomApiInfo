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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F78150", Offset = "0x7F76D50", VA = "0x187F78150", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F784E0", Offset = "0x7F770E0", VA = "0x187F784E0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct FEHNANKKIHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct FFEAPDKNJLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct CFILKKIPHFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct DKAJJDJJMCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct FCNLBFNFAOM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, ONKMFKGPHBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F74FE0", Offset = "0x7F73BE0", VA = "0x187F74FE0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct KPCIMNJNPPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct NMEIHLFDKBP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct ALHCLAKEGDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity EBACDMBHHNE;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct NLOPFGBHBDL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity EBACDMBHHNE;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KPPACFMPCNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<DDNKKMNAKLF> HFGPOPJOMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> DJHJIKNKGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle DJIBHNIMKKB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HLKMBCEEOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F76780", Offset = "0x7F75380", VA = "0x187F76780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F76730", Offset = "0x7F75330", VA = "0x187F76730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DBE3E0", Offset = "0x5DBCFE0", VA = "0x185DBE3E0")]
	public KPPACFMPCNJ(NativeList<DDNKKMNAKLF> HFGPOPJOMIJ, NativeList<Entity> DJHJIKNKGMF, JobHandle DJIBHNIMKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F76610", Offset = "0x7F75210", VA = "0x187F76610")]
	public (Entity, NativeSlice<Entity>) KLGEFFIDGMB(int DEONLBGGLDI)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F765B0", Offset = "0x7F751B0", VA = "0x187F765B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DDNKKMNAKLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity HMGDINOCJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int KPHEINADMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int FMOIHNPEKPL;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FGMAABPPANI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJENOPPHNNH(bool ODOPEDALFKC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct PEPMMAMONPM : IEquatable<PEPMMAMONPM>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool PCPJBJGGBHC(int KJIKHIJJPOK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool OJGNFKEACGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool DMABMMPIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool NLBFMANBONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool KBFAKOEILHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PCPJBJGGBHC IMEPOHDOAKH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F77820", Offset = "0x7F76420", VA = "0x187F77820")]
	public PEPMMAMONPM(PPFJOHBKEDL GEFKHBLJENB, PCPJBJGGBHC IMEPOHDOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F777F0", Offset = "0x7F763F0", VA = "0x187F777F0")]
	public PEPMMAMONPM(bool OJGNFKEACGD, bool DMABMMPIMKH, bool NLBFMANBONC, bool KBFAKOEILHM, PCPJBJGGBHC IMEPOHDOAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F77530", Offset = "0x7F76130", VA = "0x187F77530")]
	public bool AOLIHOBJMOD(int KJIKHIJJPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F77730", Offset = "0x7F76330", VA = "0x187F77730")]
	public bool KEIBIPHNPAD(int KJIKHIJJPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F77560", Offset = "0x7F76160", VA = "0x187F77560")]
	public bool CBGAHGDMKJF(int KJIKHIJJPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F77500", Offset = "0x7F76100", VA = "0x187F77500")]
	public bool AIFBPIPNBLH(int KJIKHIJJPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F775B0", Offset = "0x7F761B0", VA = "0x187F775B0", Slot = "4")]
	public bool Equals(PEPMMAMONPM GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F775E0", Offset = "0x7F761E0", VA = "0x187F775E0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F77690", Offset = "0x7F76290", VA = "0x187F77690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F77590", Offset = "0x7F76190", VA = "0x187F77590")]
	private bool CKLHLOPAGBO(int KJIKHIJJPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F77760", Offset = "0x7F76360", VA = "0x187F77760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AEFPEOABGKJ : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public BAPIJFCDNAC NOFOOCBNKOH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F74E00", Offset = "0x7F73A00", VA = "0x187F74E00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public AEFPEOABGKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BAPIJFCDNAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct FBIHBJOIMDN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity BCBDONNFNOA;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct FGKFFDMEICG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity PJBHIEEEOFN;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct KEHIJGGMCEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool GILDCKNILIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool MDELBDLIJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int NODACCCAAJG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct BOLPCMPMPEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct MLDHHPNKNDI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Entity HNBJIMFBOOA;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct NNOFFCGGCJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3 IIBJECFMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public quaternion BFEELDCLMGM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct FPNJBPBGEHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct EPNIKDHCLBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly OHNHEDBFDMH GIKOBMGKCPJ;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2FD6BD0", Offset = "0x2FD57D0", VA = "0x182FD6BD0")]
	public EPNIKDHCLBE(OHNHEDBFDMH GIKOBMGKCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F75680", Offset = "0x7F74280", VA = "0x187F75680")]
	public EPNIKDHCLBE LODCILNHPLM(OHNHEDBFDMH EMNOCLLKEAG)
	{
		return default(EPNIKDHCLBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F75690", Offset = "0x7F74290", VA = "0x187F75690")]
	public EPNIKDHCLBE PNCPMHMNDDF(OHNHEDBFDMH BAIBDNHPKPF)
	{
		return default(EPNIKDHCLBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F756A0", Offset = "0x7F742A0", VA = "0x187F756A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum OHNHEDBFDMH : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ReferredToByGroup = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CILHNGAJGBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct ICCKKKMLEMF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public OHNHEDBFDMH ENKIEIJJMMM;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F75ED0", Offset = "0x7F74AD0", VA = "0x187F75ED0")]
	public bool FDPAKADPPHL(EPNIKDHCLBE JDBOPLIKLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F75EE0", Offset = "0x7F74AE0", VA = "0x187F75EE0")]
	public bool IFOICAKJDMC(EPNIKDHCLBE JDBOPLIKLDF, OHNHEDBFDMH IODEKNABGFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[Flags]
public enum POCCBIPBPGP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
[SingletonComponent]
public struct LHJFKDAKCED : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public POCCBIPBPGP GIKOBMGKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public bool AHKOIGCIIEF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LAPGFCGFODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F767F0", Offset = "0x7F753F0", VA = "0x187F767F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F76840", Offset = "0x7F75440", VA = "0x187F76840")]
	private LHJFKDAKCED(POCCBIPBPGP GIKOBMGKCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F76800", Offset = "0x7F75400", VA = "0x187F76800")]
	public LHJFKDAKCED LODCILNHPLM(POCCBIPBPGP EMNOCLLKEAG)
	{
		return default(LHJFKDAKCED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F76820", Offset = "0x7F75420", VA = "0x187F76820")]
	public LHJFKDAKCED PNCPMHMNDDF(POCCBIPBPGP BAIBDNHPKPF)
	{
		return default(LHJFKDAKCED);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct IANAGKMNBLE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	[InternalBufferCapacity(1)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct DGLDBGAPNGP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public Entity NNPEJAAEIIO;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, ONKMFKGPHBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F74FE0", Offset = "0x7F73BE0", VA = "0x187F74FE0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct FCMGMIEPPOI : ISystemStateBufferElementData, IBufferElementData, ONKMFKGPHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Entity JMNEAPNCNHN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity ICBFOLBLMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct NDLCOIOEEJF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity AEOMLIBJBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity LGKPAOMJEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity NNKLKHNIPCP;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct JLBBELHFDIN<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static readonly bool JICHDGIBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public uint GJMIENGNHHP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool JNEEAPGNOLO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct HPDCJOHMBJJ : IBufferElementData, IEquatable<HPDCJOHMBJJ>, ONKMFKGPHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity LGKJIFFPIKD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity DBIOGLFMBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F74FE0", Offset = "0x7F73BE0", VA = "0x187F74FE0", Slot = "4")]
	public bool Equals(HPDCJOHMBJJ GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct ILEEHEAKPIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public uint AAALLNKBKED;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
	public ILEEHEAKPIA(PLLPLODJPBF OAJMKPFMDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F75F00", Offset = "0x7F74B00", VA = "0x187F75F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB210", Offset = "0x1FF9E10", VA = "0x181FFB210")]
	public static ILEEHEAKPIA GHOKLFELACP(PLLPLODJPBF OAJMKPFMDHN)
	{
		return default(ILEEHEAKPIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct CGNCADBIAHJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity JMNEAPNCNHN;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct ELNBDFPFFGK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public PLLPLODJPBF OOHGFGHCOAJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct DANPIOKKGHK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity JMNEAPNCNHN;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct BEIEGJCOFCB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Guid LHECJJHBNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int DPOOEAFKIHD;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct OEFPLJOBPND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int OOHGFGHCOAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct GMOOEJAHGJC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity JMNEAPNCNHN;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct NCCIKNKEMEL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public PLLPLODJPBF OOHGFGHCOAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct CDGBLOINBOG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Entity JMNEAPNCNHN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct AKAPIIEBNFP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct EHDDKBHOIBN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int NELPKNNODID;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct FJDJJNCIPFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public int EOHMOFMBNIL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LDINANBBIGL PGDMGEMOHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90")]
		get
		{
			return default(LDINANBBIGL);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct CHBMCDBEIGO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public GCHandle IEENLACAEHB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct HNIIMFMAPLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct PKBDKPHOEON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct IOLPLEEIAGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct HEAFPIJLHJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct NJAANIBNFND : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct DIEJCCPABJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public int EMMACFPOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int JBMEHOAGBAN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F75380", Offset = "0x7F73F80", VA = "0x187F75380")]
	public DIEJCCPABJG(Entity JMNEAPNCNHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct JCGEJBDHFJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public CollisionDetectionMode JFCHPDAJNNC;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct FFGIOCOGNLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public OEENMKMDDDK EMIKEBGPHEJ;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly FFGIOCOGNLF DIACPKGMELN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct LFDGBHBLAMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct BGKJOENKCIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct PDGDKNIOBAN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct GOPEBNFPOOD : IBufferElementData, IEquatable<GOPEBNFPOOD>, ONKMFKGPHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Entity DIMLHDJJHIH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity DBIOGLFMBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F74FE0", Offset = "0x7F73BE0", VA = "0x187F74FE0", Slot = "4")]
	public bool Equals(GOPEBNFPOOD GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct GAAEAGLNBHL : IComponentData, ONKMFKGPHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Entity LIPFJJEAFCE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity DBIOGLFMBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct JOKPEIDJOCP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct CDGKPAOODFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Entity HMGDINOCJAI;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct DBCGBGNGPJH : NDGFBGBBCFA, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public POLGAOBAGKI LMODLJNFGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(POLGAOBAGKI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct LGDPPOCBMAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float3 JFPJINJILLA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct KCDCBEJCLGK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct KAHJBIPCIAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float3x3 CEKIKLAHOOP;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly KAHJBIPCIAC DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct PJNCJDDLIGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3x3 CEKIKLAHOOP;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly PJNCJDDLIGO DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct EOADNOCPMLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3 DAAAEIACHOL;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct HFLODCANAFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float3 LKLPDFIHPKH;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct FEFLGLCKHCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float HHFMIDKIEFC;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FEFLGLCKHCA DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct ENOHJAOOHBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float ANMIDDLBPMK;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly ENOHJAOOHBA DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct APEBGOMINAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float3 KDJGBALEEKL;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct BAJFEIFBKPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public GKDEPMMONOP EOGPMCJGNGN;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct DJNIPBPHKOB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Entity JMNEAPNCNHN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct LBOHGCPEIGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct OCCJGGLFBMA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct OLLCBEJBAMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public RigidbodyConstraints JJDIIFPJODM;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct LKJEECIFFEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float DCMEDBFEGHF;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LKJEECIFFEG DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct EMLKDABBAGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float OFPPMINECCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class HGILPGPAKAP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public GameObject AOALCMHDOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object CEFLBKCOONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object GGJKMHKKKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public MBNIPOOIKJF NFBECNGMMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Delegate LHFJKIPCKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Delegate JLEMHLHOAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public JAGGGNKIKJG<Delegate> MLDAAOAIEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public JAGGGNKIKJG<Delegate> GJBIJCMKOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public JAGGGNKIKJG<Delegate> HOKBBNMLAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public JAGGGNKIKJG<Delegate> COKNALCMJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public JAGGGNKIKJG<Delegate> HNOBAMPCDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public JAGGGNKIKJG<Delegate> JGLIAMDHKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public JAGGGNKIKJG<Delegate> LEHFNOICLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public JAGGGNKIKJG<Delegate> KFIIALKAGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public JAGGGNKIKJG<Delegate> KBCICGKDDPC;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F75DD0", Offset = "0x7F749D0", VA = "0x187F75DD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public HGILPGPAKAP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct HNGHCEOHOOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct NKKIDLIKGLF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct MBBOOBAOCGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int LEDECIJODNN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB210", Offset = "0x1FF9E10", VA = "0x181FFB210")]
	public static MBBOOBAOCGH GHOKLFELACP(int OOHGFGHCOAJ)
	{
		return default(MBBOOBAOCGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class HPINLOGBGHA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Rigidbody LCBHJGJGEAD;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F75E20", Offset = "0x7F74A20", VA = "0x187F75E20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public HPINLOGBGHA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct EIOADPEMODL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct FKACFHPMNCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 NOBIPBDPLMJ;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct NFMAFMHPPKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 PLOBHHEKGDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct DAABINBCBOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float EHHFCBJCHCE;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly DAABINBCBOC DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class PBMNLKIEKJO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public object BLHBJBEHCCJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F772A0", Offset = "0x7F75EA0", VA = "0x187F772A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public PBMNLKIEKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NLFINGLGEDI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public object DFIECJAFCDL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F76B60", Offset = "0x7F75760", VA = "0x187F76B60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public NLFINGLGEDI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct MNIPLPOBOPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct GDEOFAMCHEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct ONCHFBHMPMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct IFKIKLFJIBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct DBHGPEMNFHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct PLECAGFPAFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct PPONPEOFLPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct MCBMGLOBNDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct FPKEBDDODLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct FMBGPGBMINM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct KHHHGNOCHLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public LJNJPJOGIHD MPFBANPBMKI;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F76540", Offset = "0x7F75140", VA = "0x187F76540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct OGDILJMHGIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct GGAINJILCEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct EGKGAKOPHAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct CCKNCJPMDKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public FixedString32Bytes LAOCJKNALFF;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct PEOFFDNABHD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public UnsafeParallelHashMap<LJNJPJOGIHD, Entity> CNOELMLOOOM;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct CDOJAOMKLIL : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Entity DMFPKAFLCDG;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct GDMLIOGIPEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity JMNEAPNCNHN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GDMLIOGIPEJ GHOKLFELACP(Entity JMNEAPNCNHN)
	{
		return default(GDMLIOGIPEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct DOKPJJKHPJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Entity FKGBOBEBGCD;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct LJPDMEBJLGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Entity FKGBOBEBGCD;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct AJFNPDMLGPO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity LOICENNPGJH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static AJFNPDMLGPO GHOKLFELACP(Entity JMNEAPNCNHN)
	{
		return default(AJFNPDMLGPO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct DCOIDECOANB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct ANMCBEAGDOD : IBufferElementData, IEquatable<ANMCBEAGDOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity CGFJHEEIGOP;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D750A0", Offset = "0x7D73CA0", VA = "0x187D750A0", Slot = "4")]
	public bool Equals(ANMCBEAGDOD GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F74F50", Offset = "0x7F73B50", VA = "0x187F74F50", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct ONIDEJOJAKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public uint JBMEHOAGBAN;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct JCIGCADMBGN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity MLBPOBOGEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int EMMACFPOKFB;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct NAIKOOHEEOA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity GIIDJBGBEKP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct NBMKLBEDNJO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct GBKIFFAIFKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint GJMIENGNHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int ALHNHBGGLGP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
	public GBKIFFAIFKL(uint ECNCIMMHGMO, int EJLEIEKNGMO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct LIIPJIGAJIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct ICNHFOHJGFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct LCLKCNKCEIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct EPOJLNFOBPE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct FKIFBAPJGME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct HJKCIGPJGNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct MHMIFHLONGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct CBHKBHJGOEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct KKPJMNOFGGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct CBJLFLLIMFL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct MPGMGJJMOEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct DDLFBEKDMML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct MABENLIFBNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct PMBPKMBKJFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct FDHPFHIPGBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct COCHMIDPDOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct JNJIELDNPCB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct BHNMLHOBEAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct HINEDPJBLDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct ANPNLNHOAJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct JKAAMKIEECH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct CFPMFFPHCJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct FICOPMALKFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct GBGOPCENFMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct LCJOJPKNFEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct PGAKFHCLBPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct BFPDDHJOJJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct NJFHMEGOIII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct IPEJPPPAFLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct FGAFIIAKCBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct EMAHDKOEHNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct GPOILGKEHGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct DCFLGCPLIIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[MGJAHLKLMMG]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct FAHKBDKGJDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
[SingletonComponent]
public struct OFPGJBMGNGB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public FixedString32Bytes GPIJFOKHGBC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct IALKEEMBOGB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct DHEIFEKKCJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct DGCMDMOFOFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct MDFJBNNIMOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct AFJKENKECPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct CBLJDKMCIJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct JAOGICHJPBK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct POCBAPMHDAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public quaternion BFEELDCLMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float3 IIBJECFMAJC;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct KNCKCGOPKOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float HFBEHOCMKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public float JLNHGIENDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float FFEFLGCMNCO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct FLJIPKCOBLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct EKMGFAKBMHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct DJBNPPCIFOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct HBAPGJFHOIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int EOHMOFMBNIL;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct FLANIANEHGN : ISystemStateBufferElementData, IBufferElementData, ONKMFKGPHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Entity LHMLMAPKPBE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity ICBFOLBLMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct BEHIECPGKNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float4x4 OKFHCFBBIFL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly BEHIECPGKNA DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
[RegisterComponentDefault]
public struct KBOFEPBAGAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float4x4 HHGKCBBJJPO;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly KBOFEPBAGAB DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct KMEKKFDOKKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private int LLGOOPDCPMH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EMMACFPOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F765A0", Offset = "0x7F751A0", VA = "0x187F765A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F76590", Offset = "0x7F75190", VA = "0x187F76590")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct PEEDPFJDDAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float3 IIBJECFMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public quaternion BFEELDCLMGM;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly PEEDPFJDDAC DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class FPJDJNPCIMC
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct IAIHJNCKMFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float OGHLIFFFPNH;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static readonly IAIHJNCKMFJ DIACPKGMELN;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct FDMCKOKEKHB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Entity KAEEKMHMHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FBBLGIGMICK OCHMMOHMIHP;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct MBHEILJINAC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public FBBLGIGMICK OCHMMOHMIHP;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct PGAAEIJLAHN : ISystemStateComponentData, IComponentData, ONKMFKGPHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Entity IJNCJOKBAFO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity ICBFOLBLMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct EGJKNEDNDJA : ISystemStateBufferElementData, IBufferElementData, ONKMFKGPHBN, IEquatable<EGJKNEDNDJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Entity GAMFOEPLCOL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity ICBFOLBLMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D750A0", Offset = "0x7D73CA0", VA = "0x187D750A0", Slot = "6")]
	public bool Equals(EGJKNEDNDJA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F754F0", Offset = "0x7F740F0", VA = "0x187F754F0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct CHPFMGBPCFK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Entity KAEEKMHMHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public FBBLGIGMICK OCHMMOHMIHP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public struct KBBMBMIJABJ : IEqualityComparer<CHPFMGBPCFK>
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public static KBBMBMIJABJ DIACPKGMELN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F761F0", Offset = "0x7F74DF0", VA = "0x187F761F0", Slot = "4")]
	public bool Equals(CHPFMGBPCFK KFGAJBKADFK, CHPFMGBPCFK FEABMDLFEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F76240", Offset = "0x7F74E40", VA = "0x187F76240", Slot = "5")]
	public int GetHashCode(CHPFMGBPCFK KDKJDFFGNJJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct IDKKCLOEDKG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public FixedList32Bytes<int> FHDDDNNLNCN;
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct HJJLMDAEDCK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public FixedList32Bytes<int> FHDDDNNLNCN;
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct FBIMKEOEAMF : ISystemStateBufferElementData, IBufferElementData, ONKMFKGPHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Entity HBHHFPDHHPM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity DBIOGLFMBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal class FGALJPLAKIN : ContainerPropertyBag<AEFPEOABGKJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class FMGFCEBDNEO : Property<AEFPEOABGKJ, BAPIJFCDNAC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7F75C20", Offset = "0x7F74820", VA = "0x187F75C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F75BE0", Offset = "0x7F747E0", VA = "0x187F75BE0")]
		public FMGFCEBDNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A60", Offset = "0x7F74660", VA = "0x187F75A60", Slot = "14")]
		public override BAPIJFCDNAC GetValue(AEFPEOABGKJ MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A80", Offset = "0x7F74680", VA = "0x187F75A80", Slot = "15")]
		public override void SetValue(AEFPEOABGKJ MHCMGFKMEEN, BAPIJFCDNAC OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F75980", Offset = "0x7F74580", VA = "0x187F75980")]
	public FGALJPLAKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal class OCDNLOKCJKM : ContainerPropertyBag<HGILPGPAKAP>
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class MJKMKJDAGOO : Property<HGILPGPAKAP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7F76B30", Offset = "0x7F75730", VA = "0x187F76B30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F76AF0", Offset = "0x7F756F0", VA = "0x187F76AF0")]
		public MJKMKJDAGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A60", Offset = "0x7F74660", VA = "0x187F75A60", Slot = "14")]
		public override GameObject GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A80", Offset = "0x7F74680", VA = "0x187F75A80", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, GameObject OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class FJNIHCOJGEP : Property<HGILPGPAKAP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7F75BB0", Offset = "0x7F747B0", VA = "0x187F75BB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F75B70", Offset = "0x7F74770", VA = "0x187F75B70")]
		public FJNIHCOJGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F75B20", Offset = "0x7F74720", VA = "0x187F75B20", Slot = "14")]
		public override object GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F75B40", Offset = "0x7F74740", VA = "0x187F75B40", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, object OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class MEBMHBFIADO : Property<HGILPGPAKAP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7F769E0", Offset = "0x7F755E0", VA = "0x187F769E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F769A0", Offset = "0x7F755A0", VA = "0x187F769A0")]
		public MEBMHBFIADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F76950", Offset = "0x7F75550", VA = "0x187F76950", Slot = "14")]
		public override object GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F76970", Offset = "0x7F75570", VA = "0x187F76970", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, object OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class EIKNIBOACIC : Property<HGILPGPAKAP, MBNIPOOIKJF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7F75610", Offset = "0x7F74210", VA = "0x187F75610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F755D0", Offset = "0x7F741D0", VA = "0x187F755D0")]
		public EIKNIBOACIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F75580", Offset = "0x7F74180", VA = "0x187F75580", Slot = "14")]
		public override MBNIPOOIKJF GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F755A0", Offset = "0x7F741A0", VA = "0x187F755A0", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, MBNIPOOIKJF OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class KCFOBDDHDHK : Property<HGILPGPAKAP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7F763E0", Offset = "0x7F74FE0", VA = "0x187F763E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F763A0", Offset = "0x7F74FA0", VA = "0x187F763A0")]
		public KCFOBDDHDHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F76350", Offset = "0x7F74F50", VA = "0x187F76350", Slot = "14")]
		public override Delegate GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F76370", Offset = "0x7F74F70", VA = "0x187F76370", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, Delegate OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class DGCGMHCKICH : Property<HGILPGPAKAP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7F75350", Offset = "0x7F73F50", VA = "0x187F75350", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F75310", Offset = "0x7F73F10", VA = "0x187F75310")]
		public DGCGMHCKICH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F752C0", Offset = "0x7F73EC0", VA = "0x187F752C0", Slot = "14")]
		public override Delegate GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F752E0", Offset = "0x7F73EE0", VA = "0x187F752E0", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, Delegate OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class GEAHJNKAHIE : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7F75CE0", Offset = "0x7F748E0", VA = "0x187F75CE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F75CA0", Offset = "0x7F748A0", VA = "0x187F75CA0")]
		public GEAHJNKAHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7F75C50", Offset = "0x7F74850", VA = "0x187F75C50", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F75C70", Offset = "0x7F74870", VA = "0x187F75C70", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class KGOEIGLFDCE : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7F76510", Offset = "0x7F75110", VA = "0x187F76510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7F764D0", Offset = "0x7F750D0", VA = "0x187F764D0")]
		public KGOEIGLFDCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F76480", Offset = "0x7F75080", VA = "0x187F76480", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F764A0", Offset = "0x7F750A0", VA = "0x187F764A0", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class CNDECGCNHGK : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7F75190", Offset = "0x7F73D90", VA = "0x187F75190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F75150", Offset = "0x7F73D50", VA = "0x187F75150")]
		public CNDECGCNHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F75100", Offset = "0x7F73D00", VA = "0x187F75100", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7F75120", Offset = "0x7F73D20", VA = "0x187F75120", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class DDDMLEBHKFO : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7F75290", Offset = "0x7F73E90", VA = "0x187F75290", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F75250", Offset = "0x7F73E50", VA = "0x187F75250")]
		public DDDMLEBHKFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F75200", Offset = "0x7F73E00", VA = "0x187F75200", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F75220", Offset = "0x7F73E20", VA = "0x187F75220", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class LNOPKHNNGME : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7F76920", Offset = "0x7F75520", VA = "0x187F76920", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F768E0", Offset = "0x7F754E0", VA = "0x187F768E0")]
		public LNOPKHNNGME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F76890", Offset = "0x7F75490", VA = "0x187F76890", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F768B0", Offset = "0x7F754B0", VA = "0x187F768B0", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class PEANOMLAMJE : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7F773A0", Offset = "0x7F75FA0", VA = "0x187F773A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F77360", Offset = "0x7F75F60", VA = "0x187F77360")]
		public PEANOMLAMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F77310", Offset = "0x7F75F10", VA = "0x187F77310", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F77330", Offset = "0x7F75F30", VA = "0x187F77330", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class GMDEBKIABJO : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F75DA0", Offset = "0x7F749A0", VA = "0x187F75DA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F75D60", Offset = "0x7F74960", VA = "0x187F75D60")]
		public GMDEBKIABJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F75D10", Offset = "0x7F74910", VA = "0x187F75D10", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F75D30", Offset = "0x7F74930", VA = "0x187F75D30", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class PFFHEMJHEJM : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7F77900", Offset = "0x7F76500", VA = "0x187F77900", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F778C0", Offset = "0x7F764C0", VA = "0x187F778C0")]
		public PFFHEMJHEJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F77870", Offset = "0x7F76470", VA = "0x187F77870", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F77890", Offset = "0x7F76490", VA = "0x187F77890", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class FDKKMOGMLLE : Property<HGILPGPAKAP, JAGGGNKIKJG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7F75790", Offset = "0x7F74390", VA = "0x187F75790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F75750", Offset = "0x7F74350", VA = "0x187F75750")]
		public FDKKMOGMLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F75700", Offset = "0x7F74300", VA = "0x187F75700", Slot = "14")]
		public override JAGGGNKIKJG<Delegate> GetValue(HGILPGPAKAP MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F75720", Offset = "0x7F74320", VA = "0x187F75720", Slot = "15")]
		public override void SetValue(HGILPGPAKAP MHCMGFKMEEN, JAGGGNKIKJG<Delegate> OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F76BD0", Offset = "0x7F757D0", VA = "0x187F76BD0")]
	public OCDNLOKCJKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class BMHEIJAGCJM : ContainerPropertyBag<JAGGGNKIKJG<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F750A0", Offset = "0x7F73CA0", VA = "0x187F750A0")]
	public BMHEIJAGCJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class AKHHMOAGLNF : ContainerPropertyBag<HPINLOGBGHA>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class INAECLICFEB : Property<HPINLOGBGHA, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7F75F70", Offset = "0x7F74B70", VA = "0x187F75F70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F75F30", Offset = "0x7F74B30", VA = "0x187F75F30")]
		public INAECLICFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A60", Offset = "0x7F74660", VA = "0x187F75A60", Slot = "14")]
		public override Rigidbody GetValue(HPINLOGBGHA MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A80", Offset = "0x7F74680", VA = "0x187F75A80", Slot = "15")]
		public override void SetValue(HPINLOGBGHA MHCMGFKMEEN, Rigidbody OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F74E70", Offset = "0x7F73A70", VA = "0x187F74E70")]
	public AKHHMOAGLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class MEIPKIPHCKA : ContainerPropertyBag<PBMNLKIEKJO>
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class ONHIODNPAIC : Property<PBMNLKIEKJO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7F77270", Offset = "0x7F75E70", VA = "0x187F77270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F77230", Offset = "0x7F75E30", VA = "0x187F77230")]
		public ONHIODNPAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A60", Offset = "0x7F74660", VA = "0x187F75A60", Slot = "14")]
		public override object GetValue(PBMNLKIEKJO MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A80", Offset = "0x7F74680", VA = "0x187F75A80", Slot = "15")]
		public override void SetValue(PBMNLKIEKJO MHCMGFKMEEN, object OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F76A10", Offset = "0x7F75610", VA = "0x187F76A10")]
	public MEIPKIPHCKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class DPFJDPMNKOI : ContainerPropertyBag<NLFINGLGEDI>
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	private class FGFPKPBOFPH : Property<NLFINGLGEDI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7F75AF0", Offset = "0x7F746F0", VA = "0x187F75AF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F75AB0", Offset = "0x7F746B0", VA = "0x187F75AB0")]
		public FGFPKPBOFPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A60", Offset = "0x7F74660", VA = "0x187F75A60", Slot = "14")]
		public override object GetValue(NLFINGLGEDI MHCMGFKMEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F75A80", Offset = "0x7F74680", VA = "0x187F75A80", Slot = "15")]
		public override void SetValue(NLFINGLGEDI MHCMGFKMEEN, object OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F75410", Offset = "0x7F74010", VA = "0x187F75410")]
	public DPFJDPMNKOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class JOLKJEBGBIE : ContainerPropertyBag<CDOJAOMKLIL>
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	private class JOOJNKMNBDK : Property<CDOJAOMKLIL, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7F760D0", Offset = "0x7F74CD0", VA = "0x187F760D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F76090", Offset = "0x7F74C90", VA = "0x187F76090")]
		public JOOJNKMNBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA842A0", Offset = "0xA82EA0", VA = "0x180A842A0", Slot = "14")]
		public override Entity GetValue(CDOJAOMKLIL MHCMGFKMEEN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F76080", Offset = "0x7F74C80", VA = "0x187F76080", Slot = "15")]
		public override void SetValue(CDOJAOMKLIL MHCMGFKMEEN, Entity OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F75FA0", Offset = "0x7F74BA0", VA = "0x187F75FA0")]
	public JOLKJEBGBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class FECLJHFJJFA : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	private class KGDBECONIBG : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7F76450", Offset = "0x7F75050", VA = "0x187F76450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F76410", Offset = "0x7F75010", VA = "0x187F76410")]
		public KGDBECONIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2329350", Offset = "0x2327F50", VA = "0x182329350", Slot = "14")]
		public override int GetValue(Entity MHCMGFKMEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D70660", Offset = "0x7D6F260", VA = "0x187D70660", Slot = "15")]
		public override void SetValue(Entity MHCMGFKMEEN, int OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class DKJGAHEEMDK : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string AJPMCBKCCJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7F753E0", Offset = "0x7F73FE0", VA = "0x187F753E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool KKNAEFNJMGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F753A0", Offset = "0x7F73FA0", VA = "0x187F753A0")]
		public DKJGAHEEMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12B0DE0", Offset = "0x12AF9E0", VA = "0x1812B0DE0", Slot = "14")]
		public override int GetValue(Entity MHCMGFKMEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F75390", Offset = "0x7F73F90", VA = "0x187F75390", Slot = "15")]
		public override void SetValue(Entity MHCMGFKMEEN, int OOHGFGHCOAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F757C0", Offset = "0x7F743C0", VA = "0x187F757C0")]
	public FECLJHFJJFA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F77A20", Offset = "0x7F76620", VA = "0x187F77A20")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public class GCLFJLNKBGD
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GCLFJLNKBGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
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

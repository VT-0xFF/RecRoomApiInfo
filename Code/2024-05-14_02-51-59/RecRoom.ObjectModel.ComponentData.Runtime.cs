using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using Unity.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
	public class _AssemblyIndex : JFIBNGDIICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64052A0", Offset = "0x6403CA0", VA = "0x1864052A0", Slot = "8")]
		public override void OOPDCFDDFOD(MDGGPHKAOOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64056A0", Offset = "0x64040A0", VA = "0x1864056A0", Slot = "7")]
		public override void PDJAKHOMCAD(DAGDGGLGLGO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64059D0", Offset = "0x64043D0", VA = "0x1864059D0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OJFEOMJJJMB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, AOLNPLBNKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64028D0", Offset = "0x64012D0", VA = "0x1864028D0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
		public AuthoredChildrenData(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
		public static implicit operator AuthoredChildrenData(Entity entity)
		{
			return default(AuthoredChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, AOLNPLBNKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JFFNFKBLOBM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CLAIIEEGMFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity KMELNGCBOEO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FNFGPCKCPIJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity KMELNGCBOEO;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NKCGPNBNNMK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<HNJEEBMPFDJ> HMLHKBFNJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> KLFBIAJIMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle KLHLHHDJPHP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IFFKIMEMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6404680", Offset = "0x6403080", VA = "0x186404680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64045D0", Offset = "0x6402FD0", VA = "0x1864045D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x47AF2F0", Offset = "0x47ADCF0", VA = "0x1847AF2F0")]
	public NKCGPNBNNMK(NativeList<HNJEEBMPFDJ> HMLHKBFNJDD, NativeList<Entity> KLFBIAJIMPN, JobHandle KLHLHHDJPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64046F0", Offset = "0x64030F0", VA = "0x1864046F0")]
	public (Entity, NativeSlice<Entity>) JOCJAIDOGBI(int AJODNFJNJPO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6404620", Offset = "0x6403020", VA = "0x186404620", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HNJEEBMPFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity AKBOHBAKCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int KNFIDNLGJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int JEKCEPEEELJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LNFPJAMJKKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDGKEHLCLOD(bool OCICAOFBNKP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DPJMMGOINKH : IEquatable<DPJMMGOINKH>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool LFNICECEFGF(int OFMNGOBJEKH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool HJADCKKKILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool CGKEPBEAPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool OHBMHPJIIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool JOCDGBCGACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LFNICECEFGF JMNOLJJGAAG;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64030B0", Offset = "0x6401AB0", VA = "0x1864030B0")]
	public DPJMMGOINKH(NIDCEBJLBCC LDCPKAFLBID, LFNICECEFGF JMNOLJJGAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64030F0", Offset = "0x6401AF0", VA = "0x1864030F0")]
	public DPJMMGOINKH(bool HJADCKKKILJ, bool CGKEPBEAPMI, bool OHBMHPJIIBB, bool JOCDGBCGACC, LFNICECEFGF JMNOLJJGAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6403000", Offset = "0x6401A00", VA = "0x186403000")]
	public bool JMBDDIPNLDD(int OFMNGOBJEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6403050", Offset = "0x6401A50", VA = "0x186403050")]
	public bool MCKPOJBABDK(int OFMNGOBJEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6402F30", Offset = "0x6401930", VA = "0x186402F30")]
	public bool FIGCKDMCKFG(int OFMNGOBJEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6403080", Offset = "0x6401A80", VA = "0x186403080")]
	public bool MPFEOKBBCNF(int OFMNGOBJEKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6402F00", Offset = "0x6401900", VA = "0x186402F00", Slot = "4")]
	public bool Equals(DPJMMGOINKH HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6402E50", Offset = "0x6401850", VA = "0x186402E50", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6402F60", Offset = "0x6401960", VA = "0x186402F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6403030", Offset = "0x6401A30", VA = "0x186403030")]
	private bool KBJFBOCGIGI(int OFMNGOBJEKH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ENCLBIDBFAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DKBCHKHPCFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IGJMMKFDJDC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct IFOLCMPEJFC : IBufferElementData, IEquatable<IFOLCMPEJFC>, AOLNPLBNKAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity APJECMEEJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int NEOBIHFFOEN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity FKPPLIDEMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6403730", Offset = "0x6402130", VA = "0x186403730", Slot = "4")]
	public bool Equals(IFOLCMPEJFC HKMMPHJFKEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ICIKHKPBALK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity ADAFFOHGCMD;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, AOLNPLBNKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x64028D0", Offset = "0x64012D0", VA = "0x1864028D0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ELFOIJMCGDE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly bool PCOPBBJPOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint KKNALGEOJBI;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	private static bool MCHFNLPOJHD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.TypeVersion(2)]
public struct MFMJKLBAPHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public uint JPOPHFGBDCF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6404480", Offset = "0x6402E80", VA = "0x186404480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BLNFKNGNGGE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public int INOGMJCLNPP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct JAHIHFCLMIJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public GCHandle LBPPELCKKCD;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FOALBALEEIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int INOGMJCLNPP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DKAILEMGGPA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LFHJLCOIFOC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int INOGMJCLNPP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BCGCMMHFHJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PFEKBKHKOPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PKLCIGGLMPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FJDBFLJNBIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CollisionDetectionMode PMKOJGGKMCC;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CNFNMLBEGPL]
public struct BMGMMAELKJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NGCLDJOGPMC AEJDKAPEGGK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly BMGMMAELKJB GMHFJIOGOCL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct HBDHNEDDEOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PPBOJLCPPFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct NKLFOHBPCIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[InternalBufferCapacity(0)]
public struct JDLNOBGKEAA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Entity APJECMEEJIN;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct GCGDFDBOAEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity HHJLJBMAMDD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DHBPJJADCHI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MCBGDHGFJBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity AKBOHBAKCNP;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct AGEIIHIBHOA : DJMDLBAMNKH, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HJBNGCMMFNB KIPEFBELNKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HJBNGCMMFNB);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct OOEHEEKIKFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 NPFKJJFNGJC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HHOHIBDPOKM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CNFNMLBEGPL]
public struct ONNGACGCJAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3x3 HFJLFDEDEMP;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly ONNGACGCJAA GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[CNFNMLBEGPL]
public struct CHNPFJGBIBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 HFJLFDEDEMP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly CHNPFJGBIBI GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct ADPJIMANFKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 NKBDHHPBJML;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct OKKKFJGPNPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3 JHHKGHADNJI;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[CNFNMLBEGPL]
public struct AEIACLEJKEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float IBGIDNLLCMM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly AEIACLEJKEA GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CNFNMLBEGPL]
public struct HNAIKGFMJFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float FNKPGOFMDOO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly HNAIKGFMJFP GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JIPFKIKMHCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float3 IHPJGIMODNC;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BNPIMOGAGDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public JFKHEFJKEKA GACJJBDOHIK;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FAHMADMMAKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public JFKHEFJKEKA AOKLLMHDHKP;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[MPEDJKDILCB]
public struct IAPDCNAEDKB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity DFBELOGKKCC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OMDPPIONMJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct MCMBJCCHPNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct HDONKODPLCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public RigidbodyConstraints AMMCNKHJGOI;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[CNFNMLBEGPL]
public struct GCMJPLDAMHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float PCJDNEMEBMM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly GCMJPLDAMHE GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct NMENLFGKOFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float KILJGMPMJBA;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ALDOMBMBCMK : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct KFPKDAKEGKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public object DJFIGOLNDGF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public GameObject PACDKKMGCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object EPBPEJCJMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public object BADJGOJIEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public KFPKDAKEGKH DJFIGOLNDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Delegate LEHCKDBFMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Delegate KGIAMPDGHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public JPBPCHLNJNF<Delegate> GMKBPGFBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public JPBPCHLNJNF<Delegate> APKMDNHGCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public JPBPCHLNJNF<Delegate> PADHBIMGGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public JPBPCHLNJNF<Delegate> CJJDCDOIKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public JPBPCHLNJNF<Delegate> MFOEBDGPHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public JPBPCHLNJNF<Delegate> EDHOHGGGCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JPBPCHLNJNF<Delegate> NDOEDJGBGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public JPBPCHLNJNF<Delegate> BMHMJDIFAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public JPBPCHLNJNF<Delegate> FIJPKPBNOGG;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6402880", Offset = "0x6401280", VA = "0x186402880", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public ALDOMBMBCMK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct AHKCMCOCOMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct CLDBNOLNFNH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int NEDENKGPICB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xD7D0B0", Offset = "0xD7BAB0", VA = "0x180D7D0B0")]
	public static CLDBNOLNFNH KHGGPLGKNCG(int AEJBOLFACJC)
	{
		return default(CLDBNOLNFNH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class GCAPLONCGJG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Rigidbody LNCKMBKIAHH;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x64033B0", Offset = "0x6401DB0", VA = "0x1864033B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public GCAPLONCGJG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct FENKJFDHKBG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct NDFGBHANMDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 CEBHPCKMGCF;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct PMAHHJFFMAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 HLHANNCAGLP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[CNFNMLBEGPL]
public struct FMFLJALCMJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float HJGGHBFHEJE;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly FMFLJALCMJL GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class IEKKDIKNFIP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object CCBBGNPGNCJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x64036C0", Offset = "0x64020C0", VA = "0x1864036C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public IEKKDIKNFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class FAGKNBAILGA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object HAGHEJCNKOF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6403210", Offset = "0x6401C10", VA = "0x186403210", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FAGKNBAILGA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct DPIKDPKLKPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct IHOBPJJKCKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LDIFIIFCAJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct MEEKPIHHOMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FixedString32Bytes GKDOOPOCBPP;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[MPEDJKDILCB]
public struct DBJCKNKNGLA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity OCOLBAAFGJP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static DBJCKNKNGLA KHGGPLGKNCG(Entity AEJBOLFACJC)
	{
		return default(DBJCKNKNGLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct OBENLABGCBC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Entity DFBELOGKKCC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static OBENLABGCBC KHGGPLGKNCG(Entity DFBELOGKKCC)
	{
		return default(OBENLABGCBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct JLJOJMIGHOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity BCPOCOMEKBP;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct FJDBNOAGBLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity BCPOCOMEKBP;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct DHPILMPBDBG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity MFBILFMMCNE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x830920", Offset = "0x82F320", VA = "0x180830920")]
	public static DHPILMPBDBG KHGGPLGKNCG(Entity DFBELOGKKCC)
	{
		return default(DHPILMPBDBG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct PNLAJDEFFMJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct NAHHAMMBMHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint LHMJGBJEDAH;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[MPEDJKDILCB]
internal struct BDKBBFOEHEI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity CLLGPPOEHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int ABBNIPHGMGH;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct JJCAGBEFOGA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity DNEBDNGMCOF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JOAIHGINKGO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct KFIKIJDOJHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public uint KKNALGEOJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int NOAGBPADCDA;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xB14BF0", Offset = "0xB135F0", VA = "0x180B14BF0")]
	public KFIKIJDOJHM(uint JOGNDLOEJGN, int MILMJNPKAFN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KIDPNCAFPGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct JFHAGJAFFLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct GJBPICDPMOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct BPOLLOFLGPE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct HJONLCLDFAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct ACJPNFOMPFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct KKJCDGCONKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct FKDLAHODLHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct IOPCKJHPPAA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct FHPKBEKMMFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct LMEPIFMMAOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct GFFNKICNMID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct APLLENLNIPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct CBDGAEDBGNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FEGFEBBIGKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct OGCABPINLEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct AKJJOEKGELC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct EAHMIBCEOMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct CDKEFLOIIMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct OMKABJKAPLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JGHLIFGPDPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IKIFMGIDBJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JMKNOIAENHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct GJPCELKMDJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct MBDDPJNNNBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct ECINJLFJCKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LIODBNJGADM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[MPEDJKDILCB]
public struct IHHNCCGAOJG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public FixedString32Bytes FGGJAMLKMFJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct NLDIJADINPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct KMJHDLEOHGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct MILIPCELEHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct BLBOEGAMECE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct IBOGAEHPKEJ : IComponentData, IComparable<IBOGAEHPKEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int HNMAMKBHDAK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18D5110", Offset = "0x18D3B10", VA = "0x1818D5110", Slot = "4")]
	public int CompareTo(IBOGAEHPKEJ HKMMPHJFKEA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct HAMKMKNEDJA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HAOHNAICNBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion DMBBOEJIOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 DGOJEOCFHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct NLPELJDKDDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float JABMIBNNCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float NEEHGJCMJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KPFJAIFKGMB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct DPEBDECEPBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct PMCAPJOGNCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct JGHAGHPPGGO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct MNLEJPAKIFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int INOGMJCLNPP;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[MPEDJKDILCB]
public struct BLNJPEPAMPD : ISystemStateBufferElementData, IBufferElementData, AOLNPLBNKAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity CMCELNBGPLK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity PBLLFEENDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x18CB420", Offset = "0x18C9E20", VA = "0x1818CB420", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[CNFNMLBEGPL]
public struct PPGOMGFDNKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float4x4 KKLJEPPAMFI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly PPGOMGFDNKE GMHFJIOGOCL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct IEDLMBHNBLF : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct HGEEIBIGHDL : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct FOPIGGODOJG : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct JBLJBJCGLOP : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[CNFNMLBEGPL]
public struct JINENGOFJFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float4x4 LDHLOHPAJPD;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly JINENGOFJFC GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct AKNGDJGMOBP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int JCHGNABKCBE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int ABBNIPHGMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6402830", Offset = "0x6401230", VA = "0x186402830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6402820", Offset = "0x6401220", VA = "0x186402820")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[CNFNMLBEGPL]
public struct NOOPKOMCHDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 JBPANDNFDNM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NOOPKOMCHDD GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[CNFNMLBEGPL]
public struct AKNCEAPBEMP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 DGOJEOCFHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public quaternion DMBBOEJIOJM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly AKNCEAPBEMP GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class PCBFDBHIFCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[CNFNMLBEGPL]
public struct ALBDHFEICFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float AFAGBNOOEIN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly ALBDHFEICFP GMHFJIOGOCL;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct NOAEJCPBENJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedList32Bytes<int> KAHJCFKMJIK;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NOBHAMNDPEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FixedList32Bytes<int> KAHJCFKMJIK;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal class LDOJJPJLHEI : ContainerPropertyBag<ALDOMBMBCMK>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class DBLIAIJFHGL : Property<ALDOMBMBCMK, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6402E20", Offset = "0x6401820", VA = "0x186402E20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6402DE0", Offset = "0x64017E0", VA = "0x186402DE0")]
		public DBLIAIJFHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6402D90", Offset = "0x6401790", VA = "0x186402D90", Slot = "14")]
		public override GameObject GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6402DB0", Offset = "0x64017B0", VA = "0x186402DB0", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, GameObject AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private class BIOILFCCNPK : Property<ALDOMBMBCMK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6402A50", Offset = "0x6401450", VA = "0x186402A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6402A10", Offset = "0x6401410", VA = "0x186402A10")]
		public BIOILFCCNPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x64029C0", Offset = "0x64013C0", VA = "0x1864029C0", Slot = "14")]
		public override object GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x64029E0", Offset = "0x64013E0", VA = "0x1864029E0", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, object AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private class LDCKDAKKBEJ : Property<ALDOMBMBCMK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6403CA0", Offset = "0x64026A0", VA = "0x186403CA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6403C60", Offset = "0x6402660", VA = "0x186403C60")]
		public LDCKDAKKBEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6403C10", Offset = "0x6402610", VA = "0x186403C10", Slot = "14")]
		public override object GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6403C30", Offset = "0x6402630", VA = "0x186403C30", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, object AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class NBJDMAEBBPK : Property<ALDOMBMBCMK, ALDOMBMBCMK.KFPKDAKEGKH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x64045A0", Offset = "0x6402FA0", VA = "0x1864045A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6404560", Offset = "0x6402F60", VA = "0x186404560")]
		public NBJDMAEBBPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6404510", Offset = "0x6402F10", VA = "0x186404510", Slot = "14")]
		public override ALDOMBMBCMK.KFPKDAKEGKH GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(ALDOMBMBCMK.KFPKDAKEGKH);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6404530", Offset = "0x6402F30", VA = "0x186404530", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, ALDOMBMBCMK.KFPKDAKEGKH AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class KLIIJMNPDDI : Property<ALDOMBMBCMK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6403A10", Offset = "0x6402410", VA = "0x186403A10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64039D0", Offset = "0x64023D0", VA = "0x1864039D0")]
		public KLIIJMNPDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6403980", Offset = "0x6402380", VA = "0x186403980", Slot = "14")]
		public override Delegate GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64039A0", Offset = "0x64023A0", VA = "0x1864039A0", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, Delegate AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class GKBBBAALOHB : Property<ALDOMBMBCMK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6403560", Offset = "0x6401F60", VA = "0x186403560", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6403520", Offset = "0x6401F20", VA = "0x186403520")]
		public GKBBBAALOHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64034D0", Offset = "0x6401ED0", VA = "0x1864034D0", Slot = "14")]
		public override Delegate GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64034F0", Offset = "0x6401EF0", VA = "0x1864034F0", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, Delegate AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private class NMMMPFLGJJN : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6404930", Offset = "0x6403330", VA = "0x186404930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64048F0", Offset = "0x64032F0", VA = "0x1864048F0")]
		public NMMMPFLGJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6404880", Offset = "0x6403280", VA = "0x186404880", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x64048B0", Offset = "0x64032B0", VA = "0x1864048B0", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class PIGNEENBGNF : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6404CE0", Offset = "0x64036E0", VA = "0x186404CE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6404CA0", Offset = "0x64036A0", VA = "0x186404CA0")]
		public PIGNEENBGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6404C30", Offset = "0x6403630", VA = "0x186404C30", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6404C60", Offset = "0x6403660", VA = "0x186404C60", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private class JIMLKFBJFAM : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x64038A0", Offset = "0x64022A0", VA = "0x1864038A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6403860", Offset = "0x6402260", VA = "0x186403860")]
		public JIMLKFBJFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64037F0", Offset = "0x64021F0", VA = "0x1864037F0", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6403820", Offset = "0x6402220", VA = "0x186403820", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private class BPOFEJHCPCP : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6402B80", Offset = "0x6401580", VA = "0x186402B80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6402B40", Offset = "0x6401540", VA = "0x186402B40")]
		public BPOFEJHCPCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6402AC0", Offset = "0x64014C0", VA = "0x186402AC0", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6402B00", Offset = "0x6401500", VA = "0x186402B00", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private class KNJGODKDCIE : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6403B00", Offset = "0x6402500", VA = "0x186403B00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6403AC0", Offset = "0x64024C0", VA = "0x186403AC0")]
		public KNJGODKDCIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6403A40", Offset = "0x6402440", VA = "0x186403A40", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6403A80", Offset = "0x6402480", VA = "0x186403A80", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private class EGMPDIIDFHI : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x64031E0", Offset = "0x6401BE0", VA = "0x1864031E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64031A0", Offset = "0x6401BA0", VA = "0x1864031A0")]
		public EGMPDIIDFHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6403120", Offset = "0x6401B20", VA = "0x186403120", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6403160", Offset = "0x6401B60", VA = "0x186403160", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private class FMLPHPLHKJF : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6403380", Offset = "0x6401D80", VA = "0x186403380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6403340", Offset = "0x6401D40", VA = "0x186403340")]
		public FMLPHPLHKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64032C0", Offset = "0x6401CC0", VA = "0x1864032C0", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6403300", Offset = "0x6401D00", VA = "0x186403300", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private class IAJEHNMPPGD : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6403690", Offset = "0x6402090", VA = "0x186403690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6403650", Offset = "0x6402050", VA = "0x186403650")]
		public IAJEHNMPPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64035D0", Offset = "0x6401FD0", VA = "0x1864035D0", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6403610", Offset = "0x6402010", VA = "0x186403610", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class LIIMFCHHLKJ : Property<ALDOMBMBCMK, JPBPCHLNJNF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x64043F0", Offset = "0x6402DF0", VA = "0x1864043F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64043B0", Offset = "0x6402DB0", VA = "0x1864043B0")]
		public LIIMFCHHLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6404330", Offset = "0x6402D30", VA = "0x186404330", Slot = "14")]
		public override JPBPCHLNJNF<Delegate> GetValue(ALDOMBMBCMK NFHEIBLLDGM)
		{
			return default(JPBPCHLNJNF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6404370", Offset = "0x6402D70", VA = "0x186404370", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK NFHEIBLLDGM, JPBPCHLNJNF<Delegate> AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6403CD0", Offset = "0x64026D0", VA = "0x186403CD0")]
	public LDOJJPJLHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class CCBONFHNEKP : ContainerPropertyBag<ALDOMBMBCMK.KFPKDAKEGKH>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class OIOFDOEIPHE : Property<ALDOMBMBCMK.KFPKDAKEGKH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6404A20", Offset = "0x6403420", VA = "0x186404A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x64049E0", Offset = "0x64033E0", VA = "0x1864049E0")]
		public OIOFDOEIPHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D7AA0", Offset = "0x8D64A0", VA = "0x1808D7AA0", Slot = "14")]
		public override object GetValue(ALDOMBMBCMK.KFPKDAKEGKH NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x4340F80", Offset = "0x433F980", VA = "0x184340F80", Slot = "15")]
		public override void SetValue(ALDOMBMBCMK.KFPKDAKEGKH NFHEIBLLDGM, object AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6402BB0", Offset = "0x64015B0", VA = "0x186402BB0")]
	public CCBONFHNEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class LPECKFADLPP : ContainerPropertyBag<JPBPCHLNJNF<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6404420", Offset = "0x6402E20", VA = "0x186404420")]
	public LPECKFADLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class KOCFCBBMEPD : ContainerPropertyBag<GCAPLONCGJG>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class ILFEEPFKKHD : Property<GCAPLONCGJG, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x64037C0", Offset = "0x64021C0", VA = "0x1864037C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6403780", Offset = "0x6402180", VA = "0x186403780")]
		public ILFEEPFKKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6402D90", Offset = "0x6401790", VA = "0x186402D90", Slot = "14")]
		public override Rigidbody GetValue(GCAPLONCGJG NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6402DB0", Offset = "0x64017B0", VA = "0x186402DB0", Slot = "15")]
		public override void SetValue(GCAPLONCGJG NFHEIBLLDGM, Rigidbody AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6403B30", Offset = "0x6402530", VA = "0x186403B30")]
	public KOCFCBBMEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class BAEBBKPGJMF : ContainerPropertyBag<IEKKDIKNFIP>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class GGGONGJIMND : Property<IEKKDIKNFIP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x64034A0", Offset = "0x6401EA0", VA = "0x1864034A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6403460", Offset = "0x6401E60", VA = "0x186403460")]
		public GGGONGJIMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6402D90", Offset = "0x6401790", VA = "0x186402D90", Slot = "14")]
		public override object GetValue(IEKKDIKNFIP NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6402DB0", Offset = "0x64017B0", VA = "0x186402DB0", Slot = "15")]
		public override void SetValue(IEKKDIKNFIP NFHEIBLLDGM, object AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64028E0", Offset = "0x64012E0", VA = "0x1864028E0")]
	public BAEBBKPGJMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class PELKDPFNDPB : ContainerPropertyBag<FAGKNBAILGA>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class NKDEMJFEGME : Property<FAGKNBAILGA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string HAKLMNHDJOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6404850", Offset = "0x6403250", VA = "0x186404850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FIKMFADPAMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6404810", Offset = "0x6403210", VA = "0x186404810")]
		public NKDEMJFEGME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6402D90", Offset = "0x6401790", VA = "0x186402D90", Slot = "14")]
		public override object GetValue(FAGKNBAILGA NFHEIBLLDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6402DB0", Offset = "0x64017B0", VA = "0x186402DB0", Slot = "15")]
		public override void SetValue(FAGKNBAILGA NFHEIBLLDGM, object AEJBOLFACJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6404B50", Offset = "0x6403550", VA = "0x186404B50")]
	public PELKDPFNDPB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6404DC0", Offset = "0x64037C0", VA = "0x186404DC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class FJLMCBABILJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FJLMCBABILJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
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

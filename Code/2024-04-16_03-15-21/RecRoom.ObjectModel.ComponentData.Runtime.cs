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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
	public class _AssemblyIndex : BHGNIPDAAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61F9810", Offset = "0x61F8A10", VA = "0x1861F9810", Slot = "8")]
		public override void AKMCFODBHPA(AJJICLPDKOG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61F9BF0", Offset = "0x61F8DF0", VA = "0x1861F9BF0", Slot = "7")]
		public override void EAPEEHEGJIE(KLNBNPBNHPO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61F9F20", Offset = "0x61F9120", VA = "0x1861F9F20")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HIJEANHGGPO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, FDKAFJDCLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61F6F10", Offset = "0x61F6110", VA = "0x1861F6F10", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
		public AuthoredChildrenData(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static implicit operator AuthoredChildrenData(Entity entity)
		{
			return default(AuthoredChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, FDKAFJDCLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct KNEOIJANADP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OCMFIJGDOOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity DMEGFDPEPIJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EGGNIFMJNGK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity DMEGFDPEPIJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KPNKAJNJHJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<PBFDPIEDDNJ> CNBMOIOFEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> HHOEBJJCBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle IFPDAOGJICE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AKDOKGLOPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61F8950", Offset = "0x61F7B50", VA = "0x1861F8950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61F87E0", Offset = "0x61F79E0", VA = "0x1861F87E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4649090", Offset = "0x4648290", VA = "0x184649090")]
	public KPNKAJNJHJM(NativeList<PBFDPIEDDNJ> CNBMOIOFEPB, NativeList<Entity> HHOEBJJCBAL, JobHandle IFPDAOGJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61F8830", Offset = "0x61F7A30", VA = "0x1861F8830")]
	public (Entity, NativeSlice<Entity>) GJOHEOPBIFP(int IBNKLDKLAGI)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61F8780", Offset = "0x61F7980", VA = "0x1861F8780", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PBFDPIEDDNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity MFIBAFBMCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int BMIAFODFMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int EAMNBPDOIFO;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MCFEEEGCMMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDAONKAMDEB(bool MMKNADDHOFK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct AJFACKHGDCO : IEquatable<AJFACKHGDCO>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool JKEFJGCPCPO(int BJLBPPPFCJE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool DGIOHHCHFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool BIGGCCEPOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool FNMHINPOBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool IFOOIHILNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly JKEFJGCPCPO GGPBEPCFDLJ;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61F6ED0", Offset = "0x61F60D0", VA = "0x1861F6ED0")]
	public AJFACKHGDCO(BPEECEOEIPM PCHAAMDAAJA, JKEFJGCPCPO GGPBEPCFDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61F6EA0", Offset = "0x61F60A0", VA = "0x1861F6EA0")]
	public AJFACKHGDCO(bool DGIOHHCHFOH, bool BIGGCCEPOJH, bool FNMHINPOBLK, bool IFOOIHILNBC, JKEFJGCPCPO GGPBEPCFDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61F6C40", Offset = "0x61F5E40", VA = "0x1861F6C40")]
	public bool ANGJLGLIMCM(int BJLBPPPFCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61F6E70", Offset = "0x61F6070", VA = "0x1861F6E70")]
	public bool LKGNAALMCKE(int BJLBPPPFCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61F6CA0", Offset = "0x61F5EA0", VA = "0x1861F6CA0")]
	public bool DEAIIALLACG(int BJLBPPPFCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61F6C70", Offset = "0x61F5E70", VA = "0x1861F6C70")]
	public bool DADBJOLKIOE(int BJLBPPPFCJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61F6DA0", Offset = "0x61F5FA0", VA = "0x1861F6DA0", Slot = "4")]
	public bool Equals(AJFACKHGDCO MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61F6CF0", Offset = "0x61F5EF0", VA = "0x1861F6CF0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61F6DD0", Offset = "0x61F5FD0", VA = "0x1861F6DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61F6CD0", Offset = "0x61F5ED0", VA = "0x1861F6CD0")]
	private bool ENMDMPMIDAE(int BJLBPPPFCJE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct INGMFCMAEFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EBEKOFKAMJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KPNHFKBHGBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct OENHMALOAMA : IBufferElementData, IEquatable<OENHMALOAMA>, FDKAFJDCLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity MMGOAMJJJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int HDIDPBFFDAK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity OFGDNGNDIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61F9100", Offset = "0x61F8300", VA = "0x1861F9100", Slot = "4")]
	public bool Equals(OENHMALOAMA MEJMHKPOODP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JAENJIANDLI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity CKPLJBHBJAG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, FDKAFJDCLGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61F6F10", Offset = "0x61F6110", VA = "0x1861F6F10", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct JHICNKDEAPE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly bool DJHIIBCIELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint NAGOEFCCIBE;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	private static bool AADNHFCPGLC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.TypeVersion(2)]
public struct DFJINGPBCDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public uint JFJPFJMGJIK;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61F72D0", Offset = "0x61F64D0", VA = "0x1861F72D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct IADLNOCCAGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public int KGKDPPPPNGC;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FIIMEJALFDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public GCHandle MIPPBGBDILK;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NMLPMAADIAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int KGKDPPPPNGC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PDPECKJNJGN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct IPCCJFPLMIH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int KGKDPPPPNGC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DPAEGIJOOLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PDFBHHALJAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OIIBAGJOFMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KLLPCHCPEHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CollisionDetectionMode CBLFCJIPJAE;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KMIKPGJNFBN]
public struct FEBMIPCJEIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public LABHNEIMMOD BHHJJADCFHO;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly FEBMIPCJEIK LMPCLGLBJMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct MLGOHODIJGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JNCJMNJIGPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct CLBCNEPHLPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[InternalBufferCapacity(0)]
public struct KOEKAEJCKDP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Entity MMGOAMJJJHK;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct MDADKNPLFKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity DLAKBCKOLFN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LIFLCJEKCOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MFFDODBAELE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity MFIBAFBMCBA;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct GBDLAJBJKEN : CKDCONOAFHB, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PGLFKBNKEPI KAMHMDIJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PGLFKBNKEPI);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GGNGLOGHPPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 AECMCLOEGIC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GLHCFHFMOAM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KMIKPGJNFBN]
public struct IAIDICHJCEE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3x3 JHFHHANIEJN;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly IAIDICHJCEE LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[KMIKPGJNFBN]
public struct POKLEAICBDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 JHFHHANIEJN;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly POKLEAICBDM LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct GKLGIHGGEAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 MAOCGKNEGHI;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct EAOMNHCBFEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3 PLCKDHMBEMB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[KMIKPGJNFBN]
public struct DPIAKBIDGNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float OINDEDMFBFO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly DPIAKBIDGNI LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KMIKPGJNFBN]
public struct GBFCBIPLDBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float OKLIAJJPEOF;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly GBFCBIPLDBB LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct JJHGCNCILBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float3 ACMNOFBFEIN;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EOFMHJNBBNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public BKKIHAGPCJF ACJKHHABOOP;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CKDEIJEGICK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public BKKIHAGPCJF NJADCHEHGCF;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HDEKKBFPNJG]
public struct EOEEMCFKEHF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity ACPAMCNIKHM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct GAHJMACEJDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BHGJFMCBKNA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FELCCGEDIKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public RigidbodyConstraints JDFMLCNEJHG;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[KMIKPGJNFBN]
public struct GHLHLKIBPKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float AILOPPMEIDJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly GHLHLKIBPKJ LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JBOCAHOFBBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float GKGGFPDPLHH;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class IALFPKMPKCJ : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct KHEPGOCDKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public object NDMFFPNMIAF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public GameObject CHIOFKOKCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object FOOKBFDCOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public object LCHGOJJMFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public KHEPGOCDKEB NDMFFPNMIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Delegate JCJMHNLJKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Delegate AJPKNKEPEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public LPIFGGNFNAF<Delegate> EKJAHPALGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public LPIFGGNFNAF<Delegate> HMALIFPCPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public LPIFGGNFNAF<Delegate> AMEJMCAMKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public LPIFGGNFNAF<Delegate> PHKIFJJADOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public LPIFGGNFNAF<Delegate> HCJCKJPDDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public LPIFGGNFNAF<Delegate> BNLCLNFEPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public LPIFGGNFNAF<Delegate> KABJCHFBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public LPIFGGNFNAF<Delegate> CPCCKBDHLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LPIFGGNFNAF<Delegate> IAMJKOOKFJN;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x61F82D0", Offset = "0x61F74D0", VA = "0x1861F82D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public IALFPKMPKCJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct LOCGNJJBHAK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LMLOONGDEBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int HHGKGNAECCN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xD898F0", Offset = "0xD88AF0", VA = "0x180D898F0")]
	public static LMLOONGDEBD GEOGJCANPGE(int EKDDCPALANJ)
	{
		return default(LMLOONGDEBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DDDGBMCIMBI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Rigidbody BCOOEAJBGOP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61F7260", Offset = "0x61F6460", VA = "0x1861F7260", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public DDDGBMCIMBI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct GFHCDJOJLPP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct CHCJIBAPCLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 DIDBDFPOMNO;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct IJKEJGBFJGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 MDKLJOBFIPP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[KMIKPGJNFBN]
public struct EFIPMMJFMDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float AEFLHIAGBKE;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly EFIPMMJFMDK LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DBIBNAILOAM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object PCGOPDBMDBC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61F71F0", Offset = "0x61F63F0", VA = "0x1861F71F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public DBIBNAILOAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class DACNIFCKONE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object CMPCAMMHJDP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61F7180", Offset = "0x61F6380", VA = "0x1861F7180", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public DACNIFCKONE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct DAMJGFMFKCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct BOLALAGCIGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct PIIGJGNLENP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct DIBMBOCHIIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FixedString32Bytes MPENHPFDCDK;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[HDEKKBFPNJG]
public struct DEHPDLAHPAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity GEPFFFNJCJE;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static DEHPDLAHPAJ GEOGJCANPGE(Entity EKDDCPALANJ)
	{
		return default(DEHPDLAHPAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct EPJMGBHCCBL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Entity ACPAMCNIKHM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static EPJMGBHCCBL GEOGJCANPGE(Entity ACPAMCNIKHM)
	{
		return default(EPJMGBHCCBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct IBMPAJIKMCK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity DMKCCGBBHJE;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct CPABHLBKNND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity DMKCCGBBHJE;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct KOJJBCFPDJD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity FANMLKCPIAM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8788E0", Offset = "0x877AE0", VA = "0x1808788E0")]
	public static KOJJBCFPDJD GEOGJCANPGE(Entity ACPAMCNIKHM)
	{
		return default(KOJJBCFPDJD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct KFOPHJJDBEL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EGNIMHDJNIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint BKPHPJDBECD;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[HDEKKBFPNJG]
internal struct MGLBCKNPOIO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity GAEHHNBBAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int MBGANDEDPDN;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct JJAGDFEMFNE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity MNAHIBFBBOC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct OICJKJFGPAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct GEEGCHCFKAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public uint NAGOEFCCIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int KAPKCDDBDCK;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xAE09D0", Offset = "0xADFBD0", VA = "0x180AE09D0")]
	public GEEGCHCFKAO(uint LNIAHCJEDFN, int HLPGGFNNHJH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct PPALMAPMEGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct BMBJOLAMAIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct KGILPBCBLBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct OKKCLPBLFGP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct OCICAOMFGPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct AGLNNFPFHKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct OODCKIJGIJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct EEPLKEJMILB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct LILEBKEEOEM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct DKMCNNNHEKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct EHILFAGDFHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct ALIOMDOIBFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct MONGELIHJJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct NPDKNDNLDCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FGIKALEJCPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct PCDEFDEKJAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct APADOMEBOPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct ILFKOMJFMMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct JLEKKHJNFNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct PBODHPLAJMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PMDHNGBNGNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct PMJHCKHMFOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct KFNOGEFIFNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct PJOCEIOEBJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct JOGAOBLJILM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct JGCBHOCNDFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct POIFDLNEIPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[HDEKKBFPNJG]
public struct JJNPFAKFCMA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public FixedString32Bytes KLOCHNOKOMB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct CAHMOPMGIOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct CBLFOGCODGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct HBEAPBNPOGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct EPMBDMECMJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct ABBIFOCDGFL : IComponentData, IComparable<ABBIFOCDGFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int PDEKACJNMON;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x18B2650", Offset = "0x18B1850", VA = "0x1818B2650", Slot = "4")]
	public int CompareTo(ABBIFOCDGFL MEJMHKPOODP)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct LPGAGLLNHGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct ACKKKBJKLAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion ECLCOOPOABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 JCMPCLFLJHD;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct MPHOIDOINOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float NOCMENLJCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float LJIJELAFJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float CHHCKHGOHNN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct INGOKFGPFJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct PKPJEGCHLDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EAOEODMDPDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct MIJBBHKOBCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int KGKDPPPPNGC;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[HDEKKBFPNJG]
public struct GLOMBDAIBOO : ISystemStateBufferElementData, IBufferElementData, FDKAFJDCLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity ANBEFLCFDCJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity MBMFDLMGMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x18AAAF0", Offset = "0x18A9CF0", VA = "0x1818AAAF0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[KMIKPGJNFBN]
public struct LLFOMIAEMLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float4x4 PIDPJJGJLAE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly LLFOMIAEMLO LMPCLGLBJMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct ICONJNLBIFC : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct JBHNDNAEHCI : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct IJKMBPMBAPC : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct GGNNNNLEJOM : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[KMIKPGJNFBN]
public struct BMOEEFAIEFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float4x4 MFMCJLFMNOP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BMOEEFAIEFA LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct KCLADHHPKEE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int GOPIBNOPKGN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int MBGANDEDPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x61F8620", Offset = "0x61F7820", VA = "0x1861F8620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61F8610", Offset = "0x61F7810", VA = "0x1861F8610")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[KMIKPGJNFBN]
public struct NKLCELMAKGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 CHOJGAMBDBH;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly NKLCELMAKGK LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[KMIKPGJNFBN]
public struct HHAHIBONOKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 JCMPCLFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public quaternion ECLCOOPOABI;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly HHAHIBONOKB LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class HCGHDOGEAAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[KMIKPGJNFBN]
public struct LDEJDJOGLOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float GANHJMCEGBO;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly LDEJDJOGLOL LMPCLGLBJMP;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FMHGGBJKEGG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedList32Bytes<int> GIDCLHMBPPO;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NPADKIDLMAI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FixedList32Bytes<int> GIDCLHMBPPO;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal class EPFFOICEPEF : ContainerPropertyBag<IALFPKMPKCJ>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class FBCOPHHKFKJ : Property<IALFPKMPKCJ, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x61F7D20", Offset = "0x61F6F20", VA = "0x1861F7D20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x61F7CE0", Offset = "0x61F6EE0", VA = "0x1861F7CE0")]
		public FBCOPHHKFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x61F70C0", Offset = "0x61F62C0", VA = "0x1861F70C0", Slot = "14")]
		public override GameObject GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x61F70E0", Offset = "0x61F62E0", VA = "0x1861F70E0", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, GameObject EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private class HCDHAFHHFGO : Property<IALFPKMPKCJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61F7F90", Offset = "0x61F7190", VA = "0x1861F7F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x61F7F50", Offset = "0x61F7150", VA = "0x1861F7F50")]
		public HCDHAFHHFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x61F7F00", Offset = "0x61F7100", VA = "0x1861F7F00", Slot = "14")]
		public override object GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61F7F20", Offset = "0x61F7120", VA = "0x1861F7F20", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, object EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private class LFBLLAGEGNP : Property<IALFPKMPKCJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x61F8B50", Offset = "0x61F7D50", VA = "0x1861F8B50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x61F8B10", Offset = "0x61F7D10", VA = "0x1861F8B10")]
		public LFBLLAGEGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x61F8AC0", Offset = "0x61F7CC0", VA = "0x1861F8AC0", Slot = "14")]
		public override object GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x61F8AE0", Offset = "0x61F7CE0", VA = "0x1861F8AE0", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, object EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class LBHIBPHCAFG : Property<IALFPKMPKCJ, IALFPKMPKCJ.KHEPGOCDKEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x61F8A50", Offset = "0x61F7C50", VA = "0x1861F8A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x61F8A10", Offset = "0x61F7C10", VA = "0x1861F8A10")]
		public LBHIBPHCAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x61F89C0", Offset = "0x61F7BC0", VA = "0x1861F89C0", Slot = "14")]
		public override IALFPKMPKCJ.KHEPGOCDKEB GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(IALFPKMPKCJ.KHEPGOCDKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x61F89E0", Offset = "0x61F7BE0", VA = "0x1861F89E0", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, IALFPKMPKCJ.KHEPGOCDKEB EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class IILHLIKBNBN : Property<IALFPKMPKCJ, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x61F83B0", Offset = "0x61F75B0", VA = "0x1861F83B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x61F8370", Offset = "0x61F7570", VA = "0x1861F8370")]
		public IILHLIKBNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x61F8320", Offset = "0x61F7520", VA = "0x1861F8320", Slot = "14")]
		public override Delegate GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x61F8340", Offset = "0x61F7540", VA = "0x1861F8340", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, Delegate EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class LOFEJFLOEFI : Property<IALFPKMPKCJ, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x61F8D30", Offset = "0x61F7F30", VA = "0x1861F8D30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61F8CF0", Offset = "0x61F7EF0", VA = "0x1861F8CF0")]
		public LOFEJFLOEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x61F8CA0", Offset = "0x61F7EA0", VA = "0x1861F8CA0", Slot = "14")]
		public override Delegate GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x61F8CC0", Offset = "0x61F7EC0", VA = "0x1861F8CC0", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, Delegate EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private class EAJOHJNKIAP : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x61F7450", Offset = "0x61F6650", VA = "0x1861F7450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x61F7410", Offset = "0x61F6610", VA = "0x1861F7410")]
		public EAJOHJNKIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x61F73A0", Offset = "0x61F65A0", VA = "0x1861F73A0", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61F73D0", Offset = "0x61F65D0", VA = "0x1861F73D0", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class ODEJLNILCGI : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x61F90D0", Offset = "0x61F82D0", VA = "0x1861F90D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x61F9090", Offset = "0x61F8290", VA = "0x1861F9090")]
		public ODEJLNILCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61F9020", Offset = "0x61F8220", VA = "0x1861F9020", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x61F9050", Offset = "0x61F8250", VA = "0x1861F9050", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private class KEDMHIDADNB : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x61F86E0", Offset = "0x61F78E0", VA = "0x1861F86E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61F86A0", Offset = "0x61F78A0", VA = "0x1861F86A0")]
		public KEDMHIDADNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61F8630", Offset = "0x61F7830", VA = "0x1861F8630", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x61F8660", Offset = "0x61F7860", VA = "0x1861F8660", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private class OAAFEALIGHP : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x61F8FF0", Offset = "0x61F81F0", VA = "0x1861F8FF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61F8FB0", Offset = "0x61F81B0", VA = "0x1861F8FB0")]
		public OAAFEALIGHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x61F8F30", Offset = "0x61F8130", VA = "0x1861F8F30", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x61F8F70", Offset = "0x61F8170", VA = "0x1861F8F70", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private class BMDCIJKAKDE : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x61F6FE0", Offset = "0x61F61E0", VA = "0x1861F6FE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x61F6FA0", Offset = "0x61F61A0", VA = "0x1861F6FA0")]
		public BMDCIJKAKDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x61F6F20", Offset = "0x61F6120", VA = "0x1861F6F20", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61F6F60", Offset = "0x61F6160", VA = "0x1861F6F60", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private class GKEJLBDNNEN : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x61F7ED0", Offset = "0x61F70D0", VA = "0x1861F7ED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61F7E90", Offset = "0x61F7090", VA = "0x1861F7E90")]
		public GKEJLBDNNEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x61F7E10", Offset = "0x61F7010", VA = "0x1861F7E10", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61F7E50", Offset = "0x61F7050", VA = "0x1861F7E50", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private class ILLPJJGOFKM : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x61F84A0", Offset = "0x61F76A0", VA = "0x1861F84A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x61F8460", Offset = "0x61F7660", VA = "0x1861F8460")]
		public ILLPJJGOFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61F83E0", Offset = "0x61F75E0", VA = "0x1861F83E0", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61F8420", Offset = "0x61F7620", VA = "0x1861F8420", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private class HLIKAKNJCME : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x61F81B0", Offset = "0x61F73B0", VA = "0x1861F81B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61F8170", Offset = "0x61F7370", VA = "0x1861F8170")]
		public HLIKAKNJCME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61F80F0", Offset = "0x61F72F0", VA = "0x1861F80F0", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61F8130", Offset = "0x61F7330", VA = "0x1861F8130", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class OHPNFAMECMF : Property<IALFPKMPKCJ, LPIFGGNFNAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x61F9210", Offset = "0x61F8410", VA = "0x1861F9210", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61F91D0", Offset = "0x61F83D0", VA = "0x1861F91D0")]
		public OHPNFAMECMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61F9150", Offset = "0x61F8350", VA = "0x1861F9150", Slot = "14")]
		public override LPIFGGNFNAF<Delegate> GetValue(IALFPKMPKCJ BIBKBFDHJAF)
		{
			return default(LPIFGGNFNAF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x61F9190", Offset = "0x61F8390", VA = "0x1861F9190", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ BIBKBFDHJAF, LPIFGGNFNAF<Delegate> EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61F7680", Offset = "0x61F6880", VA = "0x1861F7680")]
	public EPFFOICEPEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class EOOBIKOLAIN : ContainerPropertyBag<IALFPKMPKCJ.KHEPGOCDKEB>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class LOIHPNCJKAP : Property<IALFPKMPKCJ.KHEPGOCDKEB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x61F8DA0", Offset = "0x61F7FA0", VA = "0x1861F8DA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61F8D60", Offset = "0x61F7F60", VA = "0x1861F8D60")]
		public LOIHPNCJKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8D0", Offset = "0x8B9AD0", VA = "0x1808BA8D0", Slot = "14")]
		public override object GetValue(IALFPKMPKCJ.KHEPGOCDKEB BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x41ECAF0", Offset = "0x41EBCF0", VA = "0x1841ECAF0", Slot = "15")]
		public override void SetValue(IALFPKMPKCJ.KHEPGOCDKEB BIBKBFDHJAF, object EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61F75A0", Offset = "0x61F67A0", VA = "0x1861F75A0")]
	public EOOBIKOLAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class IPCNMKAACEO : ContainerPropertyBag<LPIFGGNFNAF<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61F84D0", Offset = "0x61F76D0", VA = "0x1861F84D0")]
	public IPCNMKAACEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class NCKFLJCKGCL : ContainerPropertyBag<DDDGBMCIMBI>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class CKDNMGFBJHJ : Property<DDDGBMCIMBI, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x61F7150", Offset = "0x61F6350", VA = "0x1861F7150", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x61F7110", Offset = "0x61F6310", VA = "0x1861F7110")]
		public CKDNMGFBJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x61F70C0", Offset = "0x61F62C0", VA = "0x1861F70C0", Slot = "14")]
		public override Rigidbody GetValue(DDDGBMCIMBI BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61F70E0", Offset = "0x61F62E0", VA = "0x1861F70E0", Slot = "15")]
		public override void SetValue(DDDGBMCIMBI BIBKBFDHJAF, Rigidbody EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x61F8DD0", Offset = "0x61F7FD0", VA = "0x1861F8DD0")]
	public NCKFLJCKGCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class EEPGMHECOED : ContainerPropertyBag<DBIBNAILOAM>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class KGCOCEMCMMF : Property<DBIBNAILOAM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x61F8750", Offset = "0x61F7950", VA = "0x1861F8750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x61F8710", Offset = "0x61F7910", VA = "0x1861F8710")]
		public KGCOCEMCMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61F70C0", Offset = "0x61F62C0", VA = "0x1861F70C0", Slot = "14")]
		public override object GetValue(DBIBNAILOAM BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x61F70E0", Offset = "0x61F62E0", VA = "0x1861F70E0", Slot = "15")]
		public override void SetValue(DBIBNAILOAM BIBKBFDHJAF, object EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61F7480", Offset = "0x61F6680", VA = "0x1861F7480")]
	public EEPGMHECOED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class IPDACGCCMPA : ContainerPropertyBag<DACNIFCKONE>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class LLJDLBCIIJB : Property<DACNIFCKONE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string FLDBLPHJNKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x61F8C70", Offset = "0x61F7E70", VA = "0x1861F8C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool APKLFGKPCKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x61F8C30", Offset = "0x61F7E30", VA = "0x1861F8C30")]
		public LLJDLBCIIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x61F70C0", Offset = "0x61F62C0", VA = "0x1861F70C0", Slot = "14")]
		public override object GetValue(DACNIFCKONE BIBKBFDHJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x61F70E0", Offset = "0x61F62E0", VA = "0x1861F70E0", Slot = "15")]
		public override void SetValue(DACNIFCKONE BIBKBFDHJAF, object EKDDCPALANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61F8530", Offset = "0x61F7730", VA = "0x1861F8530")]
	public IPDACGCCMPA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x61F9330", Offset = "0x61F8530", VA = "0x1861F9330")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class HDGKNGCCBDL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HDGKNGCCBDL()
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

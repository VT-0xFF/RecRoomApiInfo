using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
	public class _AssemblyIndex : NDNGKAAFJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6934B90", Offset = "0x6933390", VA = "0x186934B90", Slot = "8")]
		public override void BJELADPEBKG(LJEINPAGHKF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6934780", Offset = "0x6932F80", VA = "0x186934780", Slot = "7")]
		public override void BFCPECEAJCI(IHFCEGICLHO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6934F70", Offset = "0x6933770", VA = "0x186934F70")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EAPJDBIMNOG : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, DKOBEFLJNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6931C40", Offset = "0x6930440", VA = "0x186931C40", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, DKOBEFLJNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CFAJONIGFEJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NJENFCGPHMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity NLNJMFBENEN;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HOFBBHHHHIG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity NLNJMFBENEN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PGDBGHABCPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<GFANHGKHHPE> OALOGAIBJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> HLBMNPMAFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle IKOGPNHIMCJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LONMKELIFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6933EB0", Offset = "0x69326B0", VA = "0x186933EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6933E60", Offset = "0x6932660", VA = "0x186933E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4B9D030", Offset = "0x4B9B830", VA = "0x184B9D030")]
	public PGDBGHABCPE(NativeList<GFANHGKHHPE> OALOGAIBJFE, NativeList<Entity> HLBMNPMAFDB, JobHandle IKOGPNHIMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6933F20", Offset = "0x6932720", VA = "0x186933F20")]
	public (Entity, NativeSlice<Entity>) OHMADHGPJCL(int JIAIKHGLBJE)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6933E00", Offset = "0x6932600", VA = "0x186933E00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GFANHGKHHPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity AHKBBGKKCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int MFLLOPOPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int IDGMEKAEIMD;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DGCAKFDHMLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICEKHGNMLCI(bool LAHEJIBMINA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct FFMOAGNKKDO : IEquatable<FFMOAGNKKDO>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool NGBGFKBHPKJ(int HKJHDCJABMO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool MOHCPODIKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool JBBPPLGOPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool JFNLAHGBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool GHBPCIFIOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NGBGFKBHPKJ GIEAPFDNHJC;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69324D0", Offset = "0x6930CD0", VA = "0x1869324D0")]
	public FFMOAGNKKDO(KNIOBLBDGHD LLFDOLOPMIF, NGBGFKBHPKJ GIEAPFDNHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69324A0", Offset = "0x6930CA0", VA = "0x1869324A0")]
	public FFMOAGNKKDO(bool MOHCPODIKIG, bool JBBPPLGOPIP, bool JFNLAHGBPEC, bool GHBPCIFIOOE, NGBGFKBHPKJ GIEAPFDNHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6932410", Offset = "0x6930C10", VA = "0x186932410")]
	public bool KKJABKMKLHE(int HKJHDCJABMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6932470", Offset = "0x6930C70", VA = "0x186932470")]
	public bool OMNFIOPJFEL(int HKJHDCJABMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6932240", Offset = "0x6930A40", VA = "0x186932240")]
	public bool CILHKPFFFMC(int HKJHDCJABMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6932440", Offset = "0x6930C40", VA = "0x186932440")]
	public bool MEOLIHIOLFG(int HKJHDCJABMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6932340", Offset = "0x6930B40", VA = "0x186932340", Slot = "4")]
	public bool Equals(FFMOAGNKKDO OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6932290", Offset = "0x6930A90", VA = "0x186932290", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6932370", Offset = "0x6930B70", VA = "0x186932370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6932270", Offset = "0x6930A70", VA = "0x186932270")]
	private bool DHPIIPAJCIG(int HKJHDCJABMO)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GECKCAILGBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MHKNEDEMJAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ACDJJPBBIED : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct NCBHEPGLIEN : IBufferElementData, IEquatable<NCBHEPGLIEN>, DKOBEFLJNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity CKKNFOBALJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int HLIOKOODJMM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity OOPPMFCGPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6933810", Offset = "0x6932010", VA = "0x186933810", Slot = "4")]
	public bool Equals(NCBHEPGLIEN OGFCKBADKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct FIKGHDAFMLD : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct HMNLLMBMHMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CKDFMJGCFON PNIJDPIHCDC;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
		public HMNLLMBMHMA(CKDFMJGCFON KNDKPOHNLEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6932970", Offset = "0x6931170", VA = "0x186932970")]
		public bool MEGGPNKKDMJ(FIKGHDAFMLD CPDJCCMNOOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6932960", Offset = "0x6931160", VA = "0x186932960")]
		public bool HAAEIOMOILI(FIKGHDAFMLD CPDJCCMNOOB, CKDFMJGCFON KIHAMOFLCAP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly CKDFMJGCFON JGDADENKOGL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
	public FIKGHDAFMLD(CKDFMJGCFON JGDADENKOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6932520", Offset = "0x6930D20", VA = "0x186932520")]
	public FIKGHDAFMLD LEAEGPBAFOI(CKDFMJGCFON PBDBGHLCFGD)
	{
		return default(FIKGHDAFMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6932510", Offset = "0x6930D10", VA = "0x186932510")]
	public FIKGHDAFMLD FJHCIBKNDKA(CKDFMJGCFON LFPPPMPNJIP)
	{
		return default(FIKGHDAFMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6932530", Offset = "0x6930D30", VA = "0x186932530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum CKDFMJGCFON : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	IsRootObject = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasColliders = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TestEmbodiment = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	All = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Flags]
public enum NIIEDNNDPML : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[LKMLJLOKDDE]
public struct LPOJOFLFJPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NIIEDNNDPML JGDADENKOGL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ANKFCBBCKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69336B0", Offset = "0x6931EB0", VA = "0x1869336B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
	private LPOJOFLFJPL(NIIEDNNDPML JGDADENKOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6932520", Offset = "0x6930D20", VA = "0x186932520")]
	public LPOJOFLFJPL LEAEGPBAFOI(NIIEDNNDPML PBDBGHLCFGD)
	{
		return default(LPOJOFLFJPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6932510", Offset = "0x6930D10", VA = "0x186932510")]
	public LPOJOFLFJPL FJHCIBKNDKA(NIIEDNNDPML LFPPPMPNJIP)
	{
		return default(LPOJOFLFJPL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KPHGLOJJIKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct EIJCNACODJE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity JLOPODBDMCG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, DKOBEFLJNJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6931C40", Offset = "0x6930440", VA = "0x186931C40", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[LKMLJLOKDDE]
public struct APOEBJPCPKC : ISystemStateBufferElementData, IBufferElementData, DKOBEFLJNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity JIPIEBFBEML;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity MEGDONGFGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NJNJAFANAIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity OBOPPAMOOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity DCLIPCGFFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity EAMOEGFHJOF;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct DDHHJGLMONN<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly bool CPEGFNCLDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public uint NBFNIANFJJK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool IIIIJPCGNMB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct GELNFKIPDLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint FFLKAAGPPMK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69327C0", Offset = "0x6930FC0", VA = "0x1869327C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CPIGCPAPHOP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int MALOKOEKACK;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct GGEGAMJIAEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public GCHandle BAINCNDGHCD;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DPMPDMKPOFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int MALOKOEKACK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JJLLKPABHLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct EFLCCGGPHDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct JHLFHHEKEAL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int MALOKOEKACK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OMJACCHCLJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LMEHHHJAKGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OJAKMKDFLAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct IACDHONJMFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public CollisionDetectionMode KBMFMKLOEDN;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[IILGAHJJKCN]
public struct ODEKJNCBGEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public LPELNIAIFBH MGCLGBEFOBI;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly ODEKJNCBGEM BMGLDIIFJMA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EAIBKFANBMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HIIPJAMPLCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct FDJABEIHOPC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[InternalBufferCapacity(0)]
public struct PGIMHIJBJJP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity CKKNFOBALJL;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct GDOEHAOLNJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity GGJNHHDMGON;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NFCLJBNDMLM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct OCNOFKNMJJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity AHKBBGKKCNK;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KDDDIDNINBC : OCABEDPNOFO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public APEEKCJGOHE EIFODBLDLBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(APEEKCJGOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct FALKFCBALMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float3 JKPHILDBACE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct AOBKBJEPGMD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[IILGAHJJKCN]
public struct DLGKKPFHELH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3x3 JANBHHCNKIH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly DLGKKPFHELH BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IILGAHJJKCN]
public struct NNEGIHJBNEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 JANBHHCNKIH;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly NNEGIHJBNEF BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct NFLONIFELPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3 HPNJNGBGBHB;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NMLOJOEMOEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3 JLBHEKADEAL;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[IILGAHJJKCN]
public struct AFMKIKMFHDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float NIFKMOHMPFH;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly AFMKIKMFHDL BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[IILGAHJJKCN]
public struct LAKNOFMOJKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float DEHBBBPFAIN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly LAKNOFMOJKL BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct ELNKNKEMKJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float3 AFMBELFAFIM;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct HBPMAFFIADG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public AAOCMHJKPKO APONHBLBCOK;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BMBMDHENJDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public AAOCMHJKPKO ANFFMJAODED;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[LKMLJLOKDDE]
public struct ACBALAMGHDM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity JIPIEBFBEML;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct BKAFAPMCFHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct GKAPMPFGCKO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct GLAACMEKOGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public RigidbodyConstraints AMILDFOPLDD;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[IILGAHJJKCN]
public struct JONNMKLFDJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float MCAKFMNMJOC;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JONNMKLFDJG BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct BKCCOMFKNIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float GFHAEHONOMK;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class KIAPKLIOIHL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct NECCDFBFDNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public object HLJNKLNAEBN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GameObject DLBGNHFNDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public object DNDKHKAGAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public object GKAKNJFADHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NECCDFBFDNM HLJNKLNAEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Delegate CDLMAFJHDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Delegate IJBLNAHMLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public OMHIDPJPNNC<Delegate> NIOMDKFBDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public OMHIDPJPNNC<Delegate> LLCCMBKOGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public OMHIDPJPNNC<Delegate> AJGOEGCGJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public OMHIDPJPNNC<Delegate> EOMCPEFADEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public OMHIDPJPNNC<Delegate> JKMIIAJMNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public OMHIDPJPNNC<Delegate> IBJGCEMPDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public OMHIDPJPNNC<Delegate> IELGJPKANOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public OMHIDPJPNNC<Delegate> AJEKIGOLANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public OMHIDPJPNNC<Delegate> AMMICNNOHHJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6932F50", Offset = "0x6931750", VA = "0x186932F50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public KIAPKLIOIHL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct BOCHNOKJHHM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct CNIHJJJLKAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int ENKLCFHPNAH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE0B770", Offset = "0xE09F70", VA = "0x180E0B770")]
	public static CNIHJJJLKAJ IKACJOLFJPE(int IPHHABIKCHD)
	{
		return default(CNIHJJJLKAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class LINOJBCCJHB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Rigidbody EBBDKHLIBPM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6933640", Offset = "0x6931E40", VA = "0x186933640", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public LINOJBCCJHB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct DNBLCMABNMD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct FPGHDDCEHDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float3 HLMGJIDHMFL;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct OGNBANAMDKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 BDPGEMOCEKF;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[IILGAHJJKCN]
public struct KACKCFKMFEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float JJEIEHNJDNN;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly KACKCFKMFEL BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class NFPJOJBDGNB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public object HNNLBMFPCKL;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6933860", Offset = "0x6932060", VA = "0x186933860", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NFPJOJBDGNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class POMPCDADGDE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public object KMDJPDBJMAM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69341C0", Offset = "0x69329C0", VA = "0x1869341C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public POMPCDADGDE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct EBAHJFIGMNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DHKOHBEDGPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct JJCLHGJIAIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct EJFFJCCCEPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct OJLCMNEAKBH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct ENLEPAEGJBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public FixedString32Bytes GCDLMFGKKMH;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[LKMLJLOKDDE]
public struct CLAGDJENMLP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Entity HBKOGPCMPEI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static CLAGDJENMLP IKACJOLFJPE(Entity IPHHABIKCHD)
	{
		return default(CLAGDJENMLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal struct MNNECBHJAHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity JIPIEBFBEML;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static MNNECBHJAHI IKACJOLFJPE(Entity JIPIEBFBEML)
	{
		return default(MNNECBHJAHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct OHPOIKILKOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity HCEENBGNODE;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct JHOEHGICDKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity HCEENBGNODE;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct LJJIIOCCBKA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity MEODFMLODED;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600")]
	public static LJJIIOCCBKA IKACJOLFJPE(Entity JIPIEBFBEML)
	{
		return default(LJJIIOCCBKA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct AMOALOGGNBH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct KNLMNEBBLOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct CFIIKCHHKOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public uint MBDJOBPGDCG;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[LKMLJLOKDDE]
internal struct KCENNDDFCFG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity OMAFCIHDJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int JBDLDJOINOF;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct LKGMBHPBGOP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity NMJBHNPAEDN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct BJMHOLAENNN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct MCMFIOMOADA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public uint NBFNIANFJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int CMMMNHFPGBJ;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
	public MCMFIOMOADA(uint JPGEDHHIMJM, int HCLCLNDCBHN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct JFIGHHKLEMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct GDOGGCNJJCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct LFNHHKPFKIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct KBNBFEHLPOA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct PHOHJHDPMKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LKHOEGJICPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct DILNGNHBGPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct HDKPELKEMGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal struct JEILPIAJIME : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct DFBJPPOLHAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct DKBCELMJOEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct EHDKNJNILGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal struct CCDFDEHOKEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct HFCIPDHDOOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AHNEAPKBIDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct HDCGDJLEIML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct FDEONFKOIFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct EPLCHBKOLCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct NDNLGOHNFBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct CHKFLPFPAGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct MBCHHBGKOKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct AMHHAGAOGDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct LLDADOBAKAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct OMOBFNCHFDG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct KBDOCJBEINM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OGNNMPEKKGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct NENOAAADDLN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[LKMLJLOKDDE]
public struct EKIOGHKFJAJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public FixedString32Bytes MAMHFGLGIND;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct GIDHFBPNPJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct IABJAFBHGHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct BEDPJPDLCPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct OMLBNNOIMLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct EBMBCEEJAMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct EPMCJLFPMLC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct CFGCEFPMPAD : IComponentData, IComparable<CFGCEFPMPAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int HKAJPMPNCIN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1A170B0", Offset = "0x1A158B0", VA = "0x181A170B0", Slot = "4")]
	public int CompareTo(CFGCEFPMPAD OGFCKBADKBE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct FHAJNMBIPFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct NFLIBBFIGMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public quaternion LOMIHBHMPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float3 GBKEBGLIOFD;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct JKHJKNNPAGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float LJCDOHAEDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float HMNBELOBDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float HBOOMENELEG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct DDLEJDEIIAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct JBGKGGBPBKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct PMCFOHFANII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct HNNDHCKELMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int MALOKOEKACK;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[LKMLJLOKDDE]
public struct OHPIGJIMCEE : ISystemStateBufferElementData, IBufferElementData, DKOBEFLJNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity FJADDONBCKL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity MEGDONGFGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[IILGAHJJKCN]
public struct OPBJGLFICLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float4x4 DEPKGPMMHDA;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly OPBJGLFICLO BMGLDIIFJMA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct FBNOALFJAKG : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct GMABBHHPCCJ : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct PLIABKANGHD : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct NCONFDCGFFL : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[IILGAHJJKCN]
public struct KGEJIJGGDGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 GLLDBGEFOBO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly KGEJIJGGDGN BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct GOGPBBEDBGE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int KJCIPHADKDC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JBDLDJOINOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6932940", Offset = "0x6931140", VA = "0x186932940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6932950", Offset = "0x6931150", VA = "0x186932950")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[IILGAHJJKCN]
public struct BIONCHMBHDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 AHBFLCDFCBK;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly BIONCHMBHDJ BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[IILGAHJJKCN]
public struct IHFBDKFEGNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 GBKEBGLIOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public quaternion LOMIHBHMPMH;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly IHFBDKFEGNI BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class PCIGDNIAIEO
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[IILGAHJJKCN]
public struct CHLFIOHPDJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float CAAAADOOBDE;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly CHLFIOHPDJL BMGLDIIFJMA;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct GKMCEJOCAPM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity COODGNDJFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public JBMHKOHEBLO NBMJJDIPDAE;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct ENPOHGAICFG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public JBMHKOHEBLO NBMJJDIPDAE;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct DDIEKLIABJM : ISystemStateComponentData, IComponentData, DKOBEFLJNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity ECKNMNLLOJH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity MEGDONGFGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct CJLOAMLLLLH : ISystemStateBufferElementData, IBufferElementData, DKOBEFLJNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Entity KOCOMANCEIM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity MEGDONGFGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct DILBMPKKNNL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity COODGNDJFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public JBMHKOHEBLO NBMJJDIPDAE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct NHFFJIMCION : IEqualityComparer<DILBMPKKNNL>
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static NHFFJIMCION BMGLDIIFJMA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69338D0", Offset = "0x69320D0", VA = "0x1869338D0", Slot = "4")]
	public bool Equals(DILBMPKKNNL PNGIKMLKECD, DILBMPKKNNL MADKMAGKKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6933920", Offset = "0x6932120", VA = "0x186933920", Slot = "5")]
	public int GetHashCode(DILBMPKKNNL GHDJADLHPAA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct AEKFCEGGMHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedList32Bytes<int> KJGCAHPCGKA;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct DMLNIIHHMOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public FixedList32Bytes<int> KJGCAHPCGKA;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct CFNKDFNMCDK : ISystemStateBufferElementData, IBufferElementData, DKOBEFLJNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Entity GLCCJEAPGFM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity OOPPMFCGPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1A12AC0", Offset = "0x1A112C0", VA = "0x181A12AC0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class LINDIINBNII : ContainerPropertyBag<KIAPKLIOIHL>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class CFHPKBBCKJH : Property<KIAPKLIOIHL, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6931F10", Offset = "0x6930710", VA = "0x186931F10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6931ED0", Offset = "0x69306D0", VA = "0x186931ED0")]
		public CFHPKBBCKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6931E80", Offset = "0x6930680", VA = "0x186931E80", Slot = "14")]
		public override GameObject GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6931EA0", Offset = "0x69306A0", VA = "0x186931EA0", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, GameObject IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class KFMOOBIFFFP : Property<KIAPKLIOIHL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6932E70", Offset = "0x6931670", VA = "0x186932E70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6932E30", Offset = "0x6931630", VA = "0x186932E30")]
		public KFMOOBIFFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6932DE0", Offset = "0x69315E0", VA = "0x186932DE0", Slot = "14")]
		public override object GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6932E00", Offset = "0x6931600", VA = "0x186932E00", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, object IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class PIBGPMCIGBB : Property<KIAPKLIOIHL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69340D0", Offset = "0x69328D0", VA = "0x1869340D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6934090", Offset = "0x6932890", VA = "0x186934090")]
		public PIBGPMCIGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6934040", Offset = "0x6932840", VA = "0x186934040", Slot = "14")]
		public override object GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6934060", Offset = "0x6932860", VA = "0x186934060", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, object IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class AALMOLEKNFK : Property<KIAPKLIOIHL, KIAPKLIOIHL.NECCDFBFDNM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6931AE0", Offset = "0x69302E0", VA = "0x186931AE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6931AA0", Offset = "0x69302A0", VA = "0x186931AA0")]
		public AALMOLEKNFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6931A50", Offset = "0x6930250", VA = "0x186931A50", Slot = "14")]
		public override KIAPKLIOIHL.NECCDFBFDNM GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(KIAPKLIOIHL.NECCDFBFDNM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6931A70", Offset = "0x6930270", VA = "0x186931A70", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, KIAPKLIOIHL.NECCDFBFDNM IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class PJKMPGAKCKH : Property<KIAPKLIOIHL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6934190", Offset = "0x6932990", VA = "0x186934190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6934150", Offset = "0x6932950", VA = "0x186934150")]
		public PJKMPGAKCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6934100", Offset = "0x6932900", VA = "0x186934100", Slot = "14")]
		public override Delegate GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6934120", Offset = "0x6932920", VA = "0x186934120", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, Delegate IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class BJCFPANHCLG : Property<KIAPKLIOIHL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6931D60", Offset = "0x6930560", VA = "0x186931D60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6931D20", Offset = "0x6930520", VA = "0x186931D20")]
		public BJCFPANHCLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6931CD0", Offset = "0x69304D0", VA = "0x186931CD0", Slot = "14")]
		public override Delegate GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6931CF0", Offset = "0x69304F0", VA = "0x186931CF0", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, Delegate IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class PEBIDMINGGA : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6933CE0", Offset = "0x69324E0", VA = "0x186933CE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6933CA0", Offset = "0x69324A0", VA = "0x186933CA0")]
		public PEBIDMINGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6933C30", Offset = "0x6932430", VA = "0x186933C30", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6933C60", Offset = "0x6932460", VA = "0x186933C60", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class GBOJPONGMJI : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6932790", Offset = "0x6930F90", VA = "0x186932790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6932750", Offset = "0x6930F50", VA = "0x186932750")]
		public GBOJPONGMJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69326E0", Offset = "0x6930EE0", VA = "0x1869326E0", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6932710", Offset = "0x6930F10", VA = "0x186932710", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class MHMIHKCFJOE : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6933770", Offset = "0x6931F70", VA = "0x186933770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6933730", Offset = "0x6931F30", VA = "0x186933730")]
		public MHMIHKCFJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69336C0", Offset = "0x6931EC0", VA = "0x1869336C0", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69336F0", Offset = "0x6931EF0", VA = "0x1869336F0", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class GMDOAIDNNNF : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6932910", Offset = "0x6931110", VA = "0x186932910", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69328D0", Offset = "0x69310D0", VA = "0x1869328D0")]
		public GMDOAIDNNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6932850", Offset = "0x6931050", VA = "0x186932850", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6932890", Offset = "0x6931090", VA = "0x186932890", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class PFJLBAKLEGI : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6933DD0", Offset = "0x69325D0", VA = "0x186933DD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6933D90", Offset = "0x6932590", VA = "0x186933D90")]
		public PFJLBAKLEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6933D10", Offset = "0x6932510", VA = "0x186933D10", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6933D50", Offset = "0x6932550", VA = "0x186933D50", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class INNIBKJGIOP : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6932C50", Offset = "0x6931450", VA = "0x186932C50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6932C10", Offset = "0x6931410", VA = "0x186932C10")]
		public INNIBKJGIOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6932B90", Offset = "0x6931390", VA = "0x186932B90", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6932BD0", Offset = "0x69313D0", VA = "0x186932BD0", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class DCJPCDLLILA : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6932120", Offset = "0x6930920", VA = "0x186932120", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69320E0", Offset = "0x69308E0", VA = "0x1869320E0")]
		public DCJPCDLLILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6932060", Offset = "0x6930860", VA = "0x186932060", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69320A0", Offset = "0x69308A0", VA = "0x1869320A0", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class ADCIEPHAEGH : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6931BD0", Offset = "0x69303D0", VA = "0x186931BD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6931B90", Offset = "0x6930390", VA = "0x186931B90")]
		public ADCIEPHAEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6931B10", Offset = "0x6930310", VA = "0x186931B10", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6931B50", Offset = "0x6930350", VA = "0x186931B50", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class CBIJGOEMDFO : Property<KIAPKLIOIHL, OMHIDPJPNNC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6931E50", Offset = "0x6930650", VA = "0x186931E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6931E10", Offset = "0x6930610", VA = "0x186931E10")]
		public CBIJGOEMDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6931D90", Offset = "0x6930590", VA = "0x186931D90", Slot = "14")]
		public override OMHIDPJPNNC<Delegate> GetValue(KIAPKLIOIHL KDCLBHAMNHO)
		{
			return default(OMHIDPJPNNC<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6931DD0", Offset = "0x69305D0", VA = "0x186931DD0", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL KDCLBHAMNHO, OMHIDPJPNNC<Delegate> IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6932FE0", Offset = "0x69317E0", VA = "0x186932FE0")]
	public LINDIINBNII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class HPAKEIPCMGK : ContainerPropertyBag<KIAPKLIOIHL.NECCDFBFDNM>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class PPIIDPOCMMD : Property<KIAPKLIOIHL.NECCDFBFDNM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6934270", Offset = "0x6932A70", VA = "0x186934270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6934230", Offset = "0x6932A30", VA = "0x186934230")]
		public PPIIDPOCMMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9CD630", Offset = "0x9CBE30", VA = "0x1809CD630", Slot = "14")]
		public override object GetValue(KIAPKLIOIHL.NECCDFBFDNM KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x46A5FF0", Offset = "0x46A47F0", VA = "0x1846A5FF0", Slot = "15")]
		public override void SetValue(KIAPKLIOIHL.NECCDFBFDNM KDCLBHAMNHO, object IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6932980", Offset = "0x6931180", VA = "0x186932980")]
	public HPAKEIPCMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class PCELHCDPMKL : ContainerPropertyBag<OMHIDPJPNNC<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6933BD0", Offset = "0x69323D0", VA = "0x186933BD0")]
	public PCELHCDPMKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JMPOFLFNBJC : ContainerPropertyBag<LINOJBCCJHB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class NKCIGMNDLMP : Property<LINOJBCCJHB, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x69339C0", Offset = "0x69321C0", VA = "0x1869339C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6933980", Offset = "0x6932180", VA = "0x186933980")]
		public NKCIGMNDLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6931E80", Offset = "0x6930680", VA = "0x186931E80", Slot = "14")]
		public override Rigidbody GetValue(LINOJBCCJHB KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6931EA0", Offset = "0x69306A0", VA = "0x186931EA0", Slot = "15")]
		public override void SetValue(LINOJBCCJHB KDCLBHAMNHO, Rigidbody IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6932C80", Offset = "0x6931480", VA = "0x186932C80")]
	public JMPOFLFNBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class COFLMKGFGJL : ContainerPropertyBag<NFPJOJBDGNB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class MNDAFGIPLCN : Property<NFPJOJBDGNB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69337E0", Offset = "0x6931FE0", VA = "0x1869337E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69337A0", Offset = "0x6931FA0", VA = "0x1869337A0")]
		public MNDAFGIPLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6931E80", Offset = "0x6930680", VA = "0x186931E80", Slot = "14")]
		public override object GetValue(NFPJOJBDGNB KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6931EA0", Offset = "0x69306A0", VA = "0x186931EA0", Slot = "15")]
		public override void SetValue(NFPJOJBDGNB KDCLBHAMNHO, object IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6931F80", Offset = "0x6930780", VA = "0x186931F80")]
	public COFLMKGFGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class FNNDLLHEKKI : ContainerPropertyBag<POMPCDADGDE>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class FNEBDBPFMJM : Property<POMPCDADGDE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string HMPIIAILGKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x69325D0", Offset = "0x6930DD0", VA = "0x1869325D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HJHOCNCEBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6932590", Offset = "0x6930D90", VA = "0x186932590")]
		public FNEBDBPFMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6931E80", Offset = "0x6930680", VA = "0x186931E80", Slot = "14")]
		public override object GetValue(POMPCDADGDE KDCLBHAMNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6931EA0", Offset = "0x69306A0", VA = "0x186931EA0", Slot = "15")]
		public override void SetValue(POMPCDADGDE KDCLBHAMNHO, object IPHHABIKCHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6932600", Offset = "0x6930E00", VA = "0x186932600")]
	public FNNDLLHEKKI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69342A0", Offset = "0x6932AA0", VA = "0x1869342A0")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class CBIBAIGKJBN
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CBIBAIGKJBN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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

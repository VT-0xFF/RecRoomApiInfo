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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
	public class _AssemblyIndex : HPGCOLCGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A5CB70", Offset = "0x6A5BB70", VA = "0x186A5CB70", Slot = "9")]
		public override void EGOKAKAMEDC(MIBLFBDCCLC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A5CF70", Offset = "0x6A5BF70", VA = "0x186A5CF70", Slot = "7")]
		public override void HGAIFAIGHIE(PHIPDPPEFAH registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A5D3E0", Offset = "0x6A5C3E0", VA = "0x186A5D3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KLDNAPJKOPJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, ONIOGOIKLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A59F20", Offset = "0x6A58F20", VA = "0x186A59F20", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, ONIOGOIKLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct BMNOEBPBAFM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OJHGPCGLGIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity IAABHDKLPFH;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JOIONOPCONM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity IAABHDKLPFH;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OJPAIBCHMKF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<HAPOJMHHBPB> BNMAGGPPOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> BPJOCLHCOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle JKLBGOBBIDA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool COGFBBOENKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C2A0", Offset = "0x6A5B2A0", VA = "0x186A5C2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C430", Offset = "0x6A5B430", VA = "0x186A5C430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4CE79B0", Offset = "0x4CE69B0", VA = "0x184CE79B0")]
	public OJPAIBCHMKF(NativeList<HAPOJMHHBPB> BNMAGGPPOBB, NativeList<Entity> BPJOCLHCOAA, JobHandle JKLBGOBBIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C310", Offset = "0x6A5B310", VA = "0x186A5C310")]
	public (Entity, NativeSlice<Entity>) GHFPGKKOKBN(int GGJGGMKAJPM)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C240", Offset = "0x6A5B240", VA = "0x186A5C240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HAPOJMHHBPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity JMCFDCHCIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int BEMLKOBANDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int IGIHBEMLMOK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MCELAAFGJDH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMHFMBAMNCF(bool BBKNIHCHKAI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BIEBIJDNCGJ : IEquatable<BIEBIJDNCGJ>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool EJACMCLLDGJ(int GCCAFDBPHMC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool GIKHNNPILCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool AOCMHNLCOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool BALJJNHJJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool HDIDNMLHFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EJACMCLLDGJ BGMMKOCKNOA;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A1C0", Offset = "0x6A591C0", VA = "0x186A5A1C0")]
	public BIEBIJDNCGJ(CCGENIJLDEA MOMOANKHLJC, EJACMCLLDGJ BGMMKOCKNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A190", Offset = "0x6A59190", VA = "0x186A5A190")]
	public BIEBIJDNCGJ(bool GIKHNNPILCB, bool AOCMHNLCOLF, bool BALJJNHJJNI, bool HDIDNMLHFJA, EJACMCLLDGJ BGMMKOCKNOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A040", Offset = "0x6A59040", VA = "0x186A5A040")]
	public bool FIOPEINEMOD(int GCCAFDBPHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A010", Offset = "0x6A59010", VA = "0x186A5A010")]
	public bool FCKINJAFLKP(int GCCAFDBPHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A160", Offset = "0x6A59160", VA = "0x186A5A160")]
	public bool JHPPIJELFPO(int GCCAFDBPHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A110", Offset = "0x6A59110", VA = "0x186A5A110")]
	public bool HPNANPBOBMK(int GCCAFDBPHMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A59FE0", Offset = "0x6A58FE0", VA = "0x186A59FE0", Slot = "4")]
	public bool Equals(BIEBIJDNCGJ ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A59F30", Offset = "0x6A58F30", VA = "0x186A59F30", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A070", Offset = "0x6A59070", VA = "0x186A5A070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A140", Offset = "0x6A59140", VA = "0x186A5A140")]
	private bool IGHPGJMKGFB(int GCCAFDBPHMC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LOCDKLJNPFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OKGECNIGFAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BECPKIOPMDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct HGDGHHDGHPI : IBufferElementData, IEquatable<HGDGHHDGHPI>, ONIOGOIKLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity CDKDCIHMCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int KFEHOEEBGJI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity OKONADCADKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A5ACE0", Offset = "0x6A59CE0", VA = "0x186A5ACE0", Slot = "4")]
	public bool Equals(HGDGHHDGHPI ACBLPNJDJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct OFAGIMEPDCM : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct CDJKODBFGPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LCNNEGMMAKA FCPKMKNPHBH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x21BB7E0", Offset = "0x21BA7E0", VA = "0x1821BB7E0")]
		public CDJKODBFGPO(LCNNEGMMAKA HHPEHGMIOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A310", Offset = "0x6A59310", VA = "0x186A5A310")]
		public bool PCCAKPIFNFC(OFAGIMEPDCM KEGOFLCGPFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A300", Offset = "0x6A59300", VA = "0x186A5A300")]
		public bool JOEGFFOJDEI(OFAGIMEPDCM KEGOFLCGPFP, LCNNEGMMAKA NHOKAOFMEKI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly LCNNEGMMAKA NDHBMPOPILB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21BB7E0", Offset = "0x21BA7E0", VA = "0x1821BB7E0")]
	public OFAGIMEPDCM(LCNNEGMMAKA NDHBMPOPILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C1C0", Offset = "0x6A5B1C0", VA = "0x186A5C1C0")]
	public OFAGIMEPDCM BKMNMPOFJBO(LCNNEGMMAKA LFIBOMKMGGI)
	{
		return default(OFAGIMEPDCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C1D0", Offset = "0x6A5B1D0", VA = "0x186A5C1D0")]
	public OFAGIMEPDCM OKGKLEMJCNB(LCNNEGMMAKA DPOLKNPLHIJ)
	{
		return default(OFAGIMEPDCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C1E0", Offset = "0x6A5B1E0", VA = "0x186A5C1E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum LCNNEGMMAKA : byte
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
public enum OKEEDKMGDGI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[COCJPGPKIJO]
public struct KFOPKHGNJNM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OKEEDKMGDGI NDHBMPOPILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool OIEABLHLOIE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NFANGHICCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B8A0", Offset = "0x6A5A8A0", VA = "0x186A5B8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B8D0", Offset = "0x6A5A8D0", VA = "0x186A5B8D0")]
	private KFOPKHGNJNM(OKEEDKMGDGI NDHBMPOPILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B880", Offset = "0x6A5A880", VA = "0x186A5B880")]
	public KFOPKHGNJNM BKMNMPOFJBO(OKEEDKMGDGI LFIBOMKMGGI)
	{
		return default(KFOPKHGNJNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B8B0", Offset = "0x6A5A8B0", VA = "0x186A5B8B0")]
	public KFOPKHGNJNM OKGKLEMJCNB(OKEEDKMGDGI DPOLKNPLHIJ)
	{
		return default(KFOPKHGNJNM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MPJBJAKBHJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MOBAKAEMGKM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity ECAKBJCOIME;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, ONIOGOIKLCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A59F20", Offset = "0x6A58F20", VA = "0x186A59F20", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[COCJPGPKIJO]
public struct EHNPCNNPDEG : ISystemStateBufferElementData, IBufferElementData, ONIOGOIKLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity BOENFECPGGB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity OAMBKKJBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JFINLIEPNLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity NPEOCHOLOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity ACEFCMFNECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity JODLDJFBOAJ;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IDBFEDNDMHK<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool KJINILEJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint DGGMEBAKHMG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool LNNEDKICGMC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct FHKLBKIAJLA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint FKAELPKMDJG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A960", Offset = "0x6A59960", VA = "0x186A5A960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HKFALECDKBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[COCJPGPKIJO]
public struct BBLHMLKLJEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int ABBKPDFMCNH;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct GBCDDNPOKPI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int NAOBJALFMLA;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DIHGJOCDDNG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle OJGIJFKLONK;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct EINKLNAMPNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int NAOBJALFMLA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CJEHOJKKLIC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct JOFKDACMKEC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int NAOBJALFMLA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MNAAEGADJGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ICFKNKIPIFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct NOEDKLJOKEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MICCBPPEDEE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode KOAEJJFJEFN;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[MKNHPDLJIKM]
public struct CNCPELJDBDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OOGOAJCGPNN DOGJFLACEAO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly CNCPELJDBDM OCOPOGJODOC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct POODPMHCMLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct CFADBHFIALA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct FFOIBIGHHDC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct CACEADBDKKJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity CDKDCIHMCOB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct MLKBGHEALAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity EMOKCJBMKOL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DEELJHPLMEF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LALCEHJPBOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity JMCFDCHCIPI;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CHGGJGOAEGP : NCCHEKFGKAN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DPMICKHFIFL EGJLHJCJDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(DPMICKHFIFL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct FAGOOHMOAGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 GIBIPKFLPGK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IIAMKGIMAGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[MKNHPDLJIKM]
public struct FPNLCBKCADA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 HLMANMMDAEK;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly FPNLCBKCADA OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[MKNHPDLJIKM]
public struct BPPHLNNLOMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 HLMANMMDAEK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly BPPHLNNLOMB OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct JHPDCCJLJBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 OOFDJFFKELB;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GPGPKLLBOJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 AIIOPPPLBIO;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[MKNHPDLJIKM]
public struct CEINJHGCCNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float INHOFKEGDFJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly CEINJHGCCNP OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MKNHPDLJIKM]
public struct MJGAOCGIFCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float PMFOALBFFLN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly MJGAOCGIFCE OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct AGPJBBHPMEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 OLADPOLGPGE;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MMILJCNELDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public JMHIAMIADEH DJMDNPHHLCI;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PLKLGDDNHPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public JMHIAMIADEH DENFJECDAHM;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[COCJPGPKIJO]
public struct NGACANJHHNM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity BOENFECPGGB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KIMDKKHCJEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct BLMLHPAHKNM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct CFNHLKAAOAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints KDMHMPJFOPO;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[MKNHPDLJIKM]
public struct EJLJIDOFFID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float CLPMHAMDMMI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly EJLJIDOFFID OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct EHLIALNCKDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float GKAKHGCNJLM;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class ICLBEHGHDBC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct JGLNNOKBOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object KDEMNNBJFJE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject IDHOMJBMFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object PNEIHPCJIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object EJHJHBFJOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public JGLNNOKBOGG KDEMNNBJFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate MNDJAJKBCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate BEPNDILIBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FFHDOOGPBPF<Delegate> PKDFPFHIGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FFHDOOGPBPF<Delegate> NCJIILEMDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public FFHDOOGPBPF<Delegate> BKNOPKNGHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public FFHDOOGPBPF<Delegate> FKDBIAFJECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public FFHDOOGPBPF<Delegate> BKILINNLBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public FFHDOOGPBPF<Delegate> EAJGMCLLMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public FFHDOOGPBPF<Delegate> BMAAGIHIEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public FFHDOOGPBPF<Delegate> JEOGNEAFDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public FFHDOOGPBPF<Delegate> HHDIKGNEMFL;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B400", Offset = "0x6A5A400", VA = "0x186A5B400", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public ICLBEHGHDBC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct IKINIKHBIDF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct ANDAJOIGBKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int LEBJMIAJMFK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE6D640", Offset = "0xE6C640", VA = "0x180E6D640")]
	public static ANDAJOIGBKD GCCHPLCKKEJ(int JJCEIJMGOAB)
	{
		return default(ANDAJOIGBKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IMOCIFBBNFH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody MEADPIPLGKG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B490", Offset = "0x6A5A490", VA = "0x186A5B490", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public IMOCIFBBNFH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct EAELCJOIEIF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct FGFECMGLOHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 IFMDAJCPKED;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct PJLEDMGFCJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 LKAKKODKGLB;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[MKNHPDLJIKM]
public struct ILOODOOMGJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float KNEPNOIABKO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly ILOODOOMGJD OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class ANIOJCKOCHB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object OFMDODIPAHA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A59EB0", Offset = "0x6A58EB0", VA = "0x186A59EB0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public ANIOJCKOCHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class OPCGMNPMCGC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object JDHDGPJGLOO;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A5C540", Offset = "0x6A5B540", VA = "0x186A5C540", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public OPCGMNPMCGC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct OOBHGKMHHML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct MDKFOLDFMJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct DBEECAFHKJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct OGDMIEFBPJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct POOLAJKIAAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KJFCEKBBNLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes CKEJJGPNKGO;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[COCJPGPKIJO]
public struct ANIPCKHDEJE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity FEGAALCJPNO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static ANIPCKHDEJE GCCHPLCKKEJ(Entity JJCEIJMGOAB)
	{
		return default(ANIPCKHDEJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct PPLLECBPCCG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity BOENFECPGGB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static PPLLECBPCCG GCCHPLCKKEJ(Entity BOENFECPGGB)
	{
		return default(PPLLECBPCCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct CFBGOFHMBPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity DBIJFKCEAGM;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct BBALDCKCLNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity DBIJFKCEAGM;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct GEJCLBOHMCI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity KPPAENBKMOB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10")]
	public static GEJCLBOHMCI GCCHPLCKKEJ(Entity BOENFECPGGB)
	{
		return default(GEJCLBOHMCI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct KMPAEJDMIID : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct LCBGODKONCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct FEKGAIABHNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint FFOAGBHJNBO;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[COCJPGPKIJO]
internal struct IKDFONFJNNI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity CIFAAOHDEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int HCALFJOJKJO;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct NDHAMEDJKMC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity NNDCOCPJBGH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct GMGFGCEBPDJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct GIGCHLMKIJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint DGGMEBAKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int GDGKJNBKJJC;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
	public GIGCHLMKIJB(uint CBDBMHBIDEF, int PNBEOFPICFK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct CBCJOFKPCKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct HFMPIELHNNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct EALMEBLBNKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct EDDAICAOEEH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MHIHFKBMLCB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct CCCKCPPOKGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct PANJLHABCKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct KNOCKMAKCCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct PDIOEGEJNJG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct ILIEDCEJLNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct KOBONPGHNDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct EGNLHPLLKBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct PJGPFMGLKIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct JGIFICDKIFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DLOONCHLMNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct EMNBBKKNDGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct NLHPBOBLABF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct HMEAHLBFMFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct JNFGBKFDPDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct EMJFHCBGFLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct CLNDBODHNGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct BEKMLDJFKON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct FCFFCIJPJAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct DAJCPNHNLLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct CLPDDJIHBNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct AINLLHHDBLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct AECEJGLCMHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DLEACLCJBHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[COCJPGPKIJO]
public struct JFOPHDHJFPF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes EEMOJGOOGIP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct CDEPALILHHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct OEPBHGLBAEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct PKDHLBOAMBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct EBAOKBBGELO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct CNOFAKBNNDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct KGFHFEHAMHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct FKKFOCOBPIB : IComponentData, IComparable<FKKFOCOBPIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int OPECBPNAMMG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B94100", Offset = "0x1B93100", VA = "0x181B94100", Slot = "4")]
	public int CompareTo(FKKFOCOBPIB ACBLPNJDJBF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct HBBHPHLAOAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct FHFHKBOAFIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion BCKIPOGEHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 LLLHNMGEKPM;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct MABFGBGFABH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float FLCFCNDOBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float LDONOJNLKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float ILOJPIMDJCF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EDJGBFKMAMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ANOMDDJBGJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct DMFEMONBHFE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct DIIDFKOMEKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int NAOBJALFMLA;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[COCJPGPKIJO]
public struct DNCGOPDEBGE : ISystemStateBufferElementData, IBufferElementData, ONIOGOIKLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity KIICPOGENEP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity OAMBKKJBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[MKNHPDLJIKM]
public struct JEEGDCCKDBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 HDLAKNACLFO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly JEEGDCCKDBA OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[MKNHPDLJIKM]
public struct NJDGHCFDLKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 NAKEHMEBJJB;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly NJDGHCFDLKH OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct GCGGFBKBOAI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int BJHNECGCFGM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HCALFJOJKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A5ABE0", Offset = "0x6A59BE0", VA = "0x186A5ABE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A5ABF0", Offset = "0x6A59BF0", VA = "0x186A5ABF0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[MKNHPDLJIKM]
public struct KFIBAHDABMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 MPIHFJFPKJC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly KFIBAHDABMF OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[MKNHPDLJIKM]
public struct FDBFJBOLGEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 LLLHNMGEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion BCKIPOGEHOJ;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly FDBFJBOLGEO OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class ONNKJILNFDJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[MKNHPDLJIKM]
public struct JFMPGNECPDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float PMLJOPCNKMC;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly JFMPGNECPDF OCOPOGJODOC;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct MNOJJMDKOAK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity FMFBBDLJBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public MLMCOPCJNLO GKANCDPDLNF;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct GOEDMGFMNGK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public MLMCOPCJNLO GKANCDPDLNF;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct MKNMPNBHFOJ : ISystemStateComponentData, IComponentData, ONIOGOIKLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity HMLGIEBFMDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity OAMBKKJBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct MJEBPAOCBDD : ISystemStateBufferElementData, IBufferElementData, ONIOGOIKLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity CMHKCENLFLG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity OAMBKKJBIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct GBKGDMHEGMK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity FMFBBDLJBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public MLMCOPCJNLO GKANCDPDLNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct LFCBICEDEHM : IEqualityComparer<GBKGDMHEGMK>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static LFCBICEDEHM OCOPOGJODOC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BA90", Offset = "0x6A5AA90", VA = "0x186A5BA90", Slot = "4")]
	public bool Equals(GBKGDMHEGMK PONGAOGJLMF, GBKGDMHEGMK FOJLHADHAPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BAE0", Offset = "0x6A5AAE0", VA = "0x186A5BAE0", Slot = "5")]
	public int GetHashCode(GBKGDMHEGMK NOPFNIKINJA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct PDLJCCJJDJO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> AIOEALANAFH;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct AEPBDPAHOHD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> AIOEALANAFH;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct AKLKKCBFBOF : ISystemStateBufferElementData, IBufferElementData, ONIOGOIKLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity PMILCALBNAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity OKONADCADKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99F870", Offset = "0x99E870", VA = "0x18099F870", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF0CB80", Offset = "0xF0BB80", VA = "0x180F0CB80", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class HLJOCJCCFBO : ContainerPropertyBag<ICLBEHGHDBC>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class DAABIFJIBCL : Property<ICLBEHGHDBC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A5A5F0", Offset = "0x6A595F0", VA = "0x186A5A5F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A5B0", Offset = "0x6A595B0", VA = "0x186A5A5B0")]
		public DAABIFJIBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A360", Offset = "0x6A59360", VA = "0x186A5A360", Slot = "14")]
		public override GameObject GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A380", Offset = "0x6A59380", VA = "0x186A5A380", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, GameObject JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class MOOGLEDDPEL : Property<ICLBEHGHDBC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6A5BF00", Offset = "0x6A5AF00", VA = "0x186A5BF00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BEC0", Offset = "0x6A5AEC0", VA = "0x186A5BEC0")]
		public MOOGLEDDPEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE70", Offset = "0x6A5AE70", VA = "0x186A5BE70", Slot = "14")]
		public override object GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BE90", Offset = "0x6A5AE90", VA = "0x186A5BE90", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, object JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class KHAANHDOOPL : Property<ICLBEHGHDBC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6A5B970", Offset = "0x6A5A970", VA = "0x186A5B970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B930", Offset = "0x6A5A930", VA = "0x186A5B930")]
		public KHAANHDOOPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B8E0", Offset = "0x6A5A8E0", VA = "0x186A5B8E0", Slot = "14")]
		public override object GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B900", Offset = "0x6A5A900", VA = "0x186A5B900", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, object JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class JFDDOMIMNME : Property<ICLBEHGHDBC, ICLBEHGHDBC.JGLNNOKBOGG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6A5B730", Offset = "0x6A5A730", VA = "0x186A5B730", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B6F0", Offset = "0x6A5A6F0", VA = "0x186A5B6F0")]
		public JFDDOMIMNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B6A0", Offset = "0x6A5A6A0", VA = "0x186A5B6A0", Slot = "14")]
		public override ICLBEHGHDBC.JGLNNOKBOGG GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(ICLBEHGHDBC.JGLNNOKBOGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B6C0", Offset = "0x6A5A6C0", VA = "0x186A5B6C0", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, ICLBEHGHDBC.JGLNNOKBOGG JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class ONEGEPJMHIJ : Property<ICLBEHGHDBC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6A5C510", Offset = "0x6A5B510", VA = "0x186A5C510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C4D0", Offset = "0x6A5B4D0", VA = "0x186A5C4D0")]
		public ONEGEPJMHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C480", Offset = "0x6A5B480", VA = "0x186A5C480", Slot = "14")]
		public override Delegate GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C4A0", Offset = "0x6A5B4A0", VA = "0x186A5C4A0", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, Delegate JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class LKODOACGECA : Property<ICLBEHGHDBC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6A5BD20", Offset = "0x6A5AD20", VA = "0x186A5BD20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BCE0", Offset = "0x6A5ACE0", VA = "0x186A5BCE0")]
		public LKODOACGECA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BC90", Offset = "0x6A5AC90", VA = "0x186A5BC90", Slot = "14")]
		public override Delegate GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BCB0", Offset = "0x6A5ACB0", VA = "0x186A5BCB0", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, Delegate JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class AEDOHMBAPCM : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6A59E80", Offset = "0x6A58E80", VA = "0x186A59E80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A59E40", Offset = "0x6A58E40", VA = "0x186A59E40")]
		public AEDOHMBAPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A59DD0", Offset = "0x6A58DD0", VA = "0x186A59DD0", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A59E00", Offset = "0x6A58E00", VA = "0x186A59E00", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class DNLKBEPKGCA : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A5A6D0", Offset = "0x6A596D0", VA = "0x186A5A6D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A690", Offset = "0x6A59690", VA = "0x186A5A690")]
		public DNLKBEPKGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A620", Offset = "0x6A59620", VA = "0x186A5A620", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A650", Offset = "0x6A59650", VA = "0x186A5A650", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class PPNPIDEAGBJ : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6A5C660", Offset = "0x6A5B660", VA = "0x186A5C660", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C620", Offset = "0x6A5B620", VA = "0x186A5C620")]
		public PPNPIDEAGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C5B0", Offset = "0x6A5B5B0", VA = "0x186A5C5B0", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C5E0", Offset = "0x6A5B5E0", VA = "0x186A5C5E0", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class LBOFBGHKFOH : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6A5BA60", Offset = "0x6A5AA60", VA = "0x186A5BA60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BA20", Offset = "0x6A5AA20", VA = "0x186A5BA20")]
		public LBOFBGHKFOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B9A0", Offset = "0x6A5A9A0", VA = "0x186A5B9A0", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B9E0", Offset = "0x6A5A9E0", VA = "0x186A5B9E0", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class EIBOCICFGGK : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6A5A7C0", Offset = "0x6A597C0", VA = "0x186A5A7C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A780", Offset = "0x6A59780", VA = "0x186A5A780")]
		public EIBOCICFGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A700", Offset = "0x6A59700", VA = "0x186A5A700", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A740", Offset = "0x6A59740", VA = "0x186A5A740", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class NKANNMBGFJI : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6A5C0A0", Offset = "0x6A5B0A0", VA = "0x186A5C0A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C060", Offset = "0x6A5B060", VA = "0x186A5C060")]
		public NKANNMBGFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BFE0", Offset = "0x6A5AFE0", VA = "0x186A5BFE0", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C020", Offset = "0x6A5B020", VA = "0x186A5C020", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class FIICHFHHGBB : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6A5AAB0", Offset = "0x6A59AB0", VA = "0x186A5AAB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A5AA70", Offset = "0x6A59A70", VA = "0x186A5AA70")]
		public FIICHFHHGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A9F0", Offset = "0x6A599F0", VA = "0x186A5A9F0", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A5AA30", Offset = "0x6A59A30", VA = "0x186A5AA30", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class JDDEJIDJMKD : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6A5B5C0", Offset = "0x6A5A5C0", VA = "0x186A5B5C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B580", Offset = "0x6A5A580", VA = "0x186A5B580")]
		public JDDEJIDJMKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B500", Offset = "0x6A5A500", VA = "0x186A5B500", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B540", Offset = "0x6A5A540", VA = "0x186A5B540", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class NOMCJPNGNDO : Property<ICLBEHGHDBC, FFHDOOGPBPF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6A5C190", Offset = "0x6A5B190", VA = "0x186A5C190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C150", Offset = "0x6A5B150", VA = "0x186A5C150")]
		public NOMCJPNGNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C0D0", Offset = "0x6A5B0D0", VA = "0x186A5C0D0", Slot = "14")]
		public override FFHDOOGPBPF<Delegate> GetValue(ICLBEHGHDBC MMBLPJPOBHB)
		{
			return default(FFHDOOGPBPF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C110", Offset = "0x6A5B110", VA = "0x186A5C110", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC MMBLPJPOBHB, FFHDOOGPBPF<Delegate> JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AD30", Offset = "0x6A59D30", VA = "0x186A5AD30")]
	public HLJOCJCCFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class LHLAFFKFDBD : ContainerPropertyBag<ICLBEHGHDBC.JGLNNOKBOGG>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class LIMGGBDNAEF : Property<ICLBEHGHDBC.JGLNNOKBOGG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6A5BC60", Offset = "0x6A5AC60", VA = "0x186A5BC60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A5BC20", Offset = "0x6A5AC20", VA = "0x186A5BC20")]
		public LIMGGBDNAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB0A9E0", Offset = "0xB099E0", VA = "0x180B0A9E0", Slot = "14")]
		public override object GetValue(ICLBEHGHDBC.JGLNNOKBOGG MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x47EC5D0", Offset = "0x47EB5D0", VA = "0x1847EC5D0", Slot = "15")]
		public override void SetValue(ICLBEHGHDBC.JGLNNOKBOGG MMBLPJPOBHB, object JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BB40", Offset = "0x6A5AB40", VA = "0x186A5BB40")]
	public LHLAFFKFDBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class JMINOELELBJ : ContainerPropertyBag<FFHDOOGPBPF<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A5B7A0", Offset = "0x6A5A7A0", VA = "0x186A5B7A0")]
	public JMINOELELBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class HACKHIHOEPH : ContainerPropertyBag<IMOCIFBBNFH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class COMPFBGEMHO : Property<IMOCIFBBNFH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6A5A580", Offset = "0x6A59580", VA = "0x186A5A580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A540", Offset = "0x6A59540", VA = "0x186A5A540")]
		public COMPFBGEMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A360", Offset = "0x6A59360", VA = "0x186A5A360", Slot = "14")]
		public override Rigidbody GetValue(IMOCIFBBNFH MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A380", Offset = "0x6A59380", VA = "0x186A5A380", Slot = "15")]
		public override void SetValue(IMOCIFBBNFH MMBLPJPOBHB, Rigidbody JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A5AC00", Offset = "0x6A59C00", VA = "0x186A5AC00")]
	public HACKHIHOEPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class MECGGHFAFCK : ContainerPropertyBag<ANIOJCKOCHB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class HNGJKJEFLJN : Property<ANIOJCKOCHB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A5B3D0", Offset = "0x6A5A3D0", VA = "0x186A5B3D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A5B390", Offset = "0x6A5A390", VA = "0x186A5B390")]
		public HNGJKJEFLJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A360", Offset = "0x6A59360", VA = "0x186A5A360", Slot = "14")]
		public override object GetValue(ANIOJCKOCHB MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A380", Offset = "0x6A59380", VA = "0x186A5A380", Slot = "15")]
		public override void SetValue(ANIOJCKOCHB MMBLPJPOBHB, object JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A5BD50", Offset = "0x6A5AD50", VA = "0x186A5BD50")]
	public MECGGHFAFCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class COKOMALLDMI : ContainerPropertyBag<OPCGMNPMCGC>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class CELEKPGJDHO : Property<OPCGMNPMCGC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string NPDJPDJBDCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6A5A3F0", Offset = "0x6A593F0", VA = "0x186A5A3F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool KEMHBPIIPLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A3B0", Offset = "0x6A593B0", VA = "0x186A5A3B0")]
		public CELEKPGJDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A360", Offset = "0x6A59360", VA = "0x186A5A360", Slot = "14")]
		public override object GetValue(OPCGMNPMCGC MMBLPJPOBHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A5A380", Offset = "0x6A59380", VA = "0x186A5A380", Slot = "15")]
		public override void SetValue(OPCGMNPMCGC MMBLPJPOBHB, object JJCEIJMGOAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A5A460", Offset = "0x6A59460", VA = "0x186A5A460")]
	public COKOMALLDMI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A5C690", Offset = "0x6A5B690", VA = "0x186A5C690")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class HCDGHKBPKAH
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HCDGHKBPKAH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F140D0", Offset = "0x6F12AD0", VA = "0x186F140D0", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F144B0", Offset = "0x6F12EB0", VA = "0x186F144B0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LLFEEFPPAKL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F11610", Offset = "0x6F10010", VA = "0x186F11610", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PCGAPBOPIOP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HOAAJFCOGEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity KFNIJNOEJEG;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EMBBJENALNH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity KFNIJNOEJEG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FJPPKNMNABP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<OGNJBLEDLHN> BKEFCCJMBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> AOAAAHMILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle FGPOBPGGBEF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CLJHAIJPKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F122A0", Offset = "0x6F10CA0", VA = "0x186F122A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HMLBKDIMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F121F0", Offset = "0x6F10BF0", VA = "0x186F121F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50A8C90", Offset = "0x50A7690", VA = "0x1850A8C90")]
	public FJPPKNMNABP(NativeList<OGNJBLEDLHN> BKEFCCJMBIM, NativeList<Entity> AOAAAHMILLN, JobHandle FGPOBPGGBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F120D0", Offset = "0x6F10AD0", VA = "0x186F120D0")]
	public (Entity, NativeSlice<Entity>) DHJNAPOPCCC(int FNLONGIJDLD)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F12240", Offset = "0x6F10C40", VA = "0x186F12240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OGNJBLEDLHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity ELFANOAFHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int FDHHGENAMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int JGKAMGBGMHI;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CCCIKFHOKNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLFKJCHCPAK(bool PAJJHNNEAIG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PCDEBMJHAHM : IEquatable<PCDEBMJHAHM>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool KCKHJFEJKAJ(int ECMIGICIFIJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool AGPJGPHPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool EDAKOEFMIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool MMBHMBADOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool KNLBPMAFBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KCKHJFEJKAJ HECGHMENGBL;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F13B20", Offset = "0x6F12520", VA = "0x186F13B20")]
	public PCDEBMJHAHM(OKCENOEKMFE DDACCEBMBND, KCKHJFEJKAJ HECGHMENGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F13B60", Offset = "0x6F12560", VA = "0x186F13B60")]
	public PCDEBMJHAHM(bool AGPJGPHPIOH, bool EDAKOEFMIFB, bool MMBHMBADOKK, bool KNLBPMAFBHO, KCKHJFEJKAJ HECGHMENGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F13A90", Offset = "0x6F12490", VA = "0x186F13A90")]
	public bool NPMBHJMEALP(int ECMIGICIFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F13AF0", Offset = "0x6F124F0", VA = "0x186F13AF0")]
	public bool PIFFJPOFHAL(int ECMIGICIFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F13AC0", Offset = "0x6F124C0", VA = "0x186F13AC0")]
	public bool OIKCGLPJNGG(int ECMIGICIFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F138C0", Offset = "0x6F122C0", VA = "0x186F138C0")]
	public bool AMFDIOMCEDJ(int ECMIGICIFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F138F0", Offset = "0x6F122F0", VA = "0x186F138F0", Slot = "4")]
	public bool Equals(PCDEBMJHAHM GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F13920", Offset = "0x6F12320", VA = "0x186F13920", Slot = "0")]
	public override bool Equals(object BBNKFKDCOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F139D0", Offset = "0x6F123D0", VA = "0x186F139D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F13A70", Offset = "0x6F12470", VA = "0x186F13A70")]
	private bool MAIAPIHNKJM(int ECMIGICIFIJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JLONACMNECK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MLFALAIMPBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MOPCELAFGHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct AIIMCALPNAO : IBufferElementData, IEquatable<AIIMCALPNAO>, FMLIHBJIFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity FHMNKMMPPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int HGBFJCLPFOC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity JLLBNBOODCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F11410", Offset = "0x6F0FE10", VA = "0x186F11410", Slot = "4")]
	public bool Equals(AIIMCALPNAO GDOGPMPJPOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct AHHFAFAIAPB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct BCFLOFEJAHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly BNFNEGOAIBC EMJNGFENCLE;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2452AC0", Offset = "0x24514C0", VA = "0x182452AC0")]
		public BCFLOFEJAHH(BNFNEGOAIBC KAMFNKGAIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F11620", Offset = "0x6F10020", VA = "0x186F11620")]
		public bool FOALOCBHEPM(AHHFAFAIAPB MCKJDGPEGCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F11630", Offset = "0x6F10030", VA = "0x186F11630")]
		public bool KIDANFCNGCI(AHHFAFAIAPB MCKJDGPEGCJ, BNFNEGOAIBC FAEODEMPBAM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly BNFNEGOAIBC NFMAABONNCF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2452AC0", Offset = "0x24514C0", VA = "0x182452AC0")]
	public AHHFAFAIAPB(BNFNEGOAIBC NFMAABONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F11390", Offset = "0x6F0FD90", VA = "0x186F11390")]
	public AHHFAFAIAPB DHEKLEHJEJH(BNFNEGOAIBC LJEKEFEPGGF)
	{
		return default(AHHFAFAIAPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F113A0", Offset = "0x6F0FDA0", VA = "0x186F113A0")]
	public AHHFAFAIAPB JGFELILKMOJ(BNFNEGOAIBC GGDFKPLMAMN)
	{
		return default(AHHFAFAIAPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F113B0", Offset = "0x6F0FDB0", VA = "0x186F113B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum BNFNEGOAIBC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TestEmbodiment = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	All = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Flags]
public enum IKHHKPECGEP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[SingletonComponent]
public struct NHEAHCGILCA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public IKHHKPECGEP NFMAABONNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool CLLIONACFNG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GNGFIIJFEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F13700", Offset = "0x6F12100", VA = "0x186F13700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F13710", Offset = "0x6F12110", VA = "0x186F13710")]
	private NHEAHCGILCA(IKHHKPECGEP NFMAABONNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F136C0", Offset = "0x6F120C0", VA = "0x186F136C0")]
	public NHEAHCGILCA DHEKLEHJEJH(IKHHKPECGEP LJEKEFEPGGF)
	{
		return default(NHEAHCGILCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F136E0", Offset = "0x6F120E0", VA = "0x186F136E0")]
	public NHEAHCGILCA JGFELILKMOJ(IKHHKPECGEP GGDFKPLMAMN)
	{
		return default(NHEAHCGILCA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OCGOKGKKJFM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JOEJMFMHAIF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity NEGCLJILLLC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, FMLIHBJIFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F11610", Offset = "0x6F10010", VA = "0x186F11610", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[SingletonComponent]
public struct JIBIADPKKMJ : ISystemStateBufferElementData, IBufferElementData, FMLIHBJIFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity IHGPCLDNNFC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity JNOPHKJEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NAHNDPBBLLP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity GAHPPBBIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity LIDFKHDMAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity IDAIKODKOME;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PJIHOOPDHAB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly bool MCOKBKCIBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint IGHIMFEDCDD;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool JKFPPCKECGP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct BGKMFMCHKOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public uint EBHBJKALOGC;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F11700", Offset = "0x6F10100", VA = "0x186F11700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KHKINFAMDCE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[SingletonComponent]
public struct JHPDMHDMBCA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int GBKDKCFHMOL;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NIOBKBFPENN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int KDHNKHNNOPD;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct ILCAKOHMELC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GCHandle GGIFJPNAAFN;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IFMLOLONKCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int KDHNKHNNOPD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PKCFPNIEIBH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EBLLDBMJDAP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int KDHNKHNNOPD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IGEDDHPAAMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GNOIELOMCEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KEFGEKJIIDD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GIJJOILNDDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CollisionDetectionMode AMLEBCOENJD;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[RegisterComponentDefault]
public struct OMOCBFNMJHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public DEMMDJFFENH GHEFJFMOMAP;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly OMOCBFNMJHP JCFGJMCEKAD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct BDKHMBBMHAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LLICOKFNIDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct GBNNJLEHLEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct OFGFKBNJHPO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity FHMNKMMPPIB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CGJHPPIPOFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity NNFBEGDDJKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FPBHNPBNEKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OIKKMGGCMOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity ELFANOAFHKM;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct CDAAOJGJKMN : FMMBHLNCLAA, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DMLFMPENEDC DDHEDJFLMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(DMLFMPENEDC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct NDFADOMADAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3 JGMPLNIFFDO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FLKDIBCCKEJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[RegisterComponentDefault]
public struct NFBEBPFMCHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 ACCJDJLAHDJ;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly NFBEBPFMCHE JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[RegisterComponentDefault]
public struct IKEBLCCECGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3x3 ACCJDJLAHDJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly IKEBLCCECGL JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BEAAEENIFCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 DLIPEFCAENC;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct FIKAJNBHCGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3 GIIFKCHCFHH;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[RegisterComponentDefault]
public struct JIPOKFBONCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float OIGHKFJKGLI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JIPOKFBONCB JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct KAAMJHLENOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float GLKLENNKDJA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly KAAMJHLENOL JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct DGDMMKHHJFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 HBLDFDJINKP;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct GOKBGLLOJOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public AKCEHIDIOBB AKHMGCKIEOM;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct IHPOMPNOLLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public AKCEHIDIOBB LNBOGIKDHGL;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[SingletonComponent]
public struct FCHMKAMAHCL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity IHGPCLDNNFC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct MDKKDGGJNKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct BKKJAPHLBKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct AAMNGEBCFHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public RigidbodyConstraints LFELAMOCLPH;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[RegisterComponentDefault]
public struct MKIFFMIGGLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float JFLELCGIBFO;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly MKIFFMIGGLN JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct IPJAGKCNFAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float IJHMBBOGMEI;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class LLEFCPNBLDO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct EOEBBNDJICA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public object MAGOHDADLGM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject NJFNKLJIFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object NDJKCCIODDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object PGNBDMPDDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public EOEBBNDJICA MAGOHDADLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate EEJNHAIMONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Delegate LJFJAEHJBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public DCKFJKFGLDP<Delegate> CIBFCDDPFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public DCKFJKFGLDP<Delegate> DCIDIKFEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public DCKFJKFGLDP<Delegate> LOLAINDJFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public DCKFJKFGLDP<Delegate> NCJGHCBNLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public DCKFJKFGLDP<Delegate> NPFLMAFNCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public DCKFJKFGLDP<Delegate> JEKIDHLONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public DCKFJKFGLDP<Delegate> GIOPFEPDJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public DCKFJKFGLDP<Delegate> IJLJMKELELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public DCKFJKFGLDP<Delegate> IGCFCECICCM;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F13500", Offset = "0x6F11F00", VA = "0x186F13500", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public LLEFCPNBLDO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct APNPDANNCOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct JKIEKHMIOLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int EBBCHAFPHAB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1721280", Offset = "0x171FC80", VA = "0x181721280")]
	public static JKIEKHMIOLH OLKJPEKNNFN(int PKCLPFEIPFH)
	{
		return default(JKIEKHMIOLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KJIBFFLIHCH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Rigidbody PILKPKKMGBO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F13290", Offset = "0x6F11C90", VA = "0x186F13290", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KJIBFFLIHCH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct FGMHPBEFJOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GFBAKCNCDDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 FMPOKOCBLML;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct FIBDMBJIKLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float3 FOPADPEODOF;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[RegisterComponentDefault]
public struct ABPBCFCKPGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float NFBFBMGOOIH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly ABPBCFCKPGL JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KHIOFAGJICL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object MLJNFGADMAL;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F131B0", Offset = "0x6F11BB0", VA = "0x186F131B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KHIOFAGJICL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JPIBJFEGAMD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public object LPEFOHAOEPI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F12F30", Offset = "0x6F11930", VA = "0x186F12F30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JPIBJFEGAMD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct LGDPGKHLONE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct KGABILJBGHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct OGDFBBBGLFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct BOFMACLOMGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct ELNKFEHIEMP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct MMACLGEIEID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FixedString32Bytes JHJFHDOAMLG;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[SingletonComponent]
public struct CFEHAILKMBM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity AOJOHHCFNCH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static CFEHAILKMBM OLKJPEKNNFN(Entity PKCLPFEIPFH)
	{
		return default(CFEHAILKMBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct HOEFLOEAKEH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity IHGPCLDNNFC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static HOEFLOEAKEH OLKJPEKNNFN(Entity IHGPCLDNNFC)
	{
		return default(HOEFLOEAKEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ALNNJGLHPKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity FHAIKCKPLMG;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct OPOJANOHHIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity FHAIKCKPLMG;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct GGCPBPPKJAD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity CEMHADLJOAO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA09F00", Offset = "0xA08900", VA = "0x180A09F00")]
	public static GGCPBPPKJAD OLKJPEKNNFN(Entity IHGPCLDNNFC)
	{
		return default(GGCPBPPKJAD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct ECBLKEANCIG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct BENHNFAKICA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct GKJNOHFDODO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint OCMGGEGAGNJ;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[SingletonComponent]
internal struct DIEJNLIHJAN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity GBACLBFCEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int GCBONJOGHCD;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct DLBGMKNDCFN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity HJJBBOBEJCK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct IMDIFAFLAPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HLKABMPEFMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public uint IGHIMFEDCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int IBJJGHGMFPM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA9D890", Offset = "0xA9C290", VA = "0x180A9D890")]
	public HLKABMPEFMH(uint LCLGKGKDKEH, int EMJALOPIOLK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct DKNBLBEOPJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct LAAEKIMGIHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LGBPCOAIKLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct LKIHIMHFOLL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct LPNNCEIPPDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GEJADBACLNN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IAELNGOANND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct FKLMBGMIMNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct CDODCDEFDPG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct BIIKKLAAHLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct ADILJCDCBOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct PLEPIBPEIDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LJGAFOKDFFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct NFCLCIEFFBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal struct LDLPCOONDHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct KPLAMFGKHHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HLOEGPIHHDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct AEFIOHAPMIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct IKDJCCKHHHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct FGDADNNHPGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct AKJEFLCOLLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct ODGDBNLGJHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct MOPIPLEEEHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct JPOIMOCEDPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct EMDHPDOGELK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct CBCLPBONNNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct LJEDNIKFALN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct LCONEEAKPNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct NHFAKEMJECB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[SingletonComponent]
public struct DOLCHALLOIE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes KLBPNCLBHIJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct NDNDMAIIFHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct KFAHFILKCDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct JPINGONKJBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct BDACPCHGCGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
internal struct LNBMBNEOGLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct JGAECGBEGCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct LJFHCKANODF : IComponentData, IComparable<LJFHCKANODF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int BNPPBAIDGDP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x201A640", Offset = "0x2019040", VA = "0x18201A640", Slot = "4")]
	public int CompareTo(LJFHCKANODF GDOGPMPJPOO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct ALFMDEFBGGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct LGCFMGNAGFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public quaternion MHLCHCEFDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 PCPIJKGKPCE;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EPFNFEIAOBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float OAFDEMLJDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float BGNDDIBMOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float JFJADDIBEHH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct BJCKOHFKHLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct CLALEBHDBEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct FGPPIILMJIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct BMKLNLNONOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int KDHNKHNNOPD;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[SingletonComponent]
public struct GCKLAFCJNCG : ISystemStateBufferElementData, IBufferElementData, FMLIHBJIFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity FHMBDNEADLF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity JNOPHKJEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[RegisterComponentDefault]
public struct GCKEAICJLEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 PIKKDLPKNMG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly GCKEAICJLEJ JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[RegisterComponentDefault]
public struct LJMBIHFAFCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float4x4 OIIDHEPGBAL;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly LJMBIHFAFCA JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct HNNEFHBHLIJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int MGKAABBPNHM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GCBONJOGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F125E0", Offset = "0x6F10FE0", VA = "0x186F125E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F125F0", Offset = "0x6F10FF0", VA = "0x186F125F0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[RegisterComponentDefault]
public struct NLBHCGOEIIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 HNNPNOHBNAG;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly NLBHCGOEIIC JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[RegisterComponentDefault]
public struct EHEOFLIBAMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 PCPIJKGKPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public quaternion MHLCHCEFDAI;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly EHEOFLIBAMM JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class EGKCMDOENBI
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[RegisterComponentDefault]
public struct NDBBDLMKDCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float CFJADKMNPFD;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly NDBBDLMKDCG JCFGJMCEKAD;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct APPDJHIIDLO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity FPJLBCBAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GABGNEGOHJK CLPBJKNGJBH;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct OJCMOEHELPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public GABGNEGOHJK CLPBJKNGJBH;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct NFHMHANHBHN : ISystemStateComponentData, IComponentData, FMLIHBJIFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity MIPAHIFMGBN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity JNOPHKJEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct ONCCGDDCCFJ : ISystemStateBufferElementData, IBufferElementData, FMLIHBJIFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity OMPNILJEOCD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity JNOPHKJEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GANJJJHMDPL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity FPJLBCBAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public GABGNEGOHJK CLPBJKNGJBH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct BPENMEAFMGC : IEqualityComparer<GANJJJHMDPL>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static BPENMEAFMGC JCFGJMCEKAD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F11790", Offset = "0x6F10190", VA = "0x186F11790", Slot = "4")]
	public bool Equals(GANJJJHMDPL PMBJFHIMJKC, GANJJJHMDPL HBABDGBANAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F117E0", Offset = "0x6F101E0", VA = "0x186F117E0", Slot = "5")]
	public int GetHashCode(GANJJJHMDPL BBNKFKDCOLP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct HACHDPHFALG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> JDCDPICBDPE;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct LHEOBLEAIJP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FixedList32Bytes<int> JDCDPICBDPE;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct NGNGNBICDKH : ISystemStateBufferElementData, IBufferElementData, FMLIHBJIFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity GEFHPOHJBAG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity JLLBNBOODCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1176420", Offset = "0x1174E20", VA = "0x181176420", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class JMKMFCBKENL : ContainerPropertyBag<LLEFCPNBLDO>
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class KHKHFLBMCFA : Property<LLEFCPNBLDO, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F13260", Offset = "0x6F11C60", VA = "0x186F13260", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F13220", Offset = "0x6F11C20", VA = "0x186F13220")]
		public KHKHFLBMCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F11460", Offset = "0x6F0FE60", VA = "0x186F11460", Slot = "14")]
		public override GameObject GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F11480", Offset = "0x6F0FE80", VA = "0x186F11480", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, GameObject PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class BFFMPKNFJOJ : Property<LLEFCPNBLDO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6F116D0", Offset = "0x6F100D0", VA = "0x186F116D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6F11690", Offset = "0x6F10090", VA = "0x186F11690")]
		public BFFMPKNFJOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6F11640", Offset = "0x6F10040", VA = "0x186F11640", Slot = "14")]
		public override object GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6F11660", Offset = "0x6F10060", VA = "0x186F11660", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, object PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class JEDILDBGPGK : Property<LLEFCPNBLDO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6F12780", Offset = "0x6F11180", VA = "0x186F12780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F12740", Offset = "0x6F11140", VA = "0x186F12740")]
		public JEDILDBGPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F126F0", Offset = "0x6F110F0", VA = "0x186F126F0", Slot = "14")]
		public override object GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F12710", Offset = "0x6F11110", VA = "0x186F12710", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, object PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class CJLFKNIDDNK : Property<LLEFCPNBLDO, LLEFCPNBLDO.EOEBBNDJICA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6F11B10", Offset = "0x6F10510", VA = "0x186F11B10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F11AD0", Offset = "0x6F104D0", VA = "0x186F11AD0")]
		public CJLFKNIDDNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F11A80", Offset = "0x6F10480", VA = "0x186F11A80", Slot = "14")]
		public override LLEFCPNBLDO.EOEBBNDJICA GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(LLEFCPNBLDO.EOEBBNDJICA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F11AA0", Offset = "0x6F104A0", VA = "0x186F11AA0", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, LLEFCPNBLDO.EOEBBNDJICA PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class HEOOIBHIGBA : Property<LLEFCPNBLDO, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6F125B0", Offset = "0x6F10FB0", VA = "0x186F125B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F12570", Offset = "0x6F10F70", VA = "0x186F12570")]
		public HEOOIBHIGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F12520", Offset = "0x6F10F20", VA = "0x186F12520", Slot = "14")]
		public override Delegate GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F12540", Offset = "0x6F10F40", VA = "0x186F12540", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, Delegate PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class EHNCIFLKKGO : Property<LLEFCPNBLDO, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6F120A0", Offset = "0x6F10AA0", VA = "0x186F120A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F12060", Offset = "0x6F10A60", VA = "0x186F12060")]
		public EHNCIFLKKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F12010", Offset = "0x6F10A10", VA = "0x186F12010", Slot = "14")]
		public override Delegate GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F12030", Offset = "0x6F10A30", VA = "0x186F12030", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, Delegate PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class NHKDCKDGALN : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6F137D0", Offset = "0x6F121D0", VA = "0x186F137D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F13790", Offset = "0x6F12190", VA = "0x186F13790")]
		public NHKDCKDGALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F13720", Offset = "0x6F12120", VA = "0x186F13720", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F13750", Offset = "0x6F12150", VA = "0x186F13750", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class JPJINFNOCBE : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6F13050", Offset = "0x6F11A50", VA = "0x186F13050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F13010", Offset = "0x6F11A10", VA = "0x186F13010")]
		public JPJINFNOCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F12FA0", Offset = "0x6F119A0", VA = "0x186F12FA0", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6F12FD0", Offset = "0x6F119D0", VA = "0x186F12FD0", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class JJGIBBLOMMG : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6F128A0", Offset = "0x6F112A0", VA = "0x186F128A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F12860", Offset = "0x6F11260", VA = "0x186F12860")]
		public JJGIBBLOMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6F127F0", Offset = "0x6F111F0", VA = "0x186F127F0", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F12820", Offset = "0x6F11220", VA = "0x186F12820", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class EEFDOGGPBIF : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6F11EB0", Offset = "0x6F108B0", VA = "0x186F11EB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F11E70", Offset = "0x6F10870", VA = "0x186F11E70")]
		public EEFDOGGPBIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F11DF0", Offset = "0x6F107F0", VA = "0x186F11DF0", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F11E30", Offset = "0x6F10830", VA = "0x186F11E30", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class CBNDKFCKOOO : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6F119E0", Offset = "0x6F103E0", VA = "0x186F119E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6F119A0", Offset = "0x6F103A0", VA = "0x186F119A0")]
		public CBNDKFCKOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F11920", Offset = "0x6F10320", VA = "0x186F11920", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F11960", Offset = "0x6F10360", VA = "0x186F11960", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class CLIIPCNLAJG : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6F11C00", Offset = "0x6F10600", VA = "0x186F11C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F11BC0", Offset = "0x6F105C0", VA = "0x186F11BC0")]
		public CLIIPCNLAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F11B40", Offset = "0x6F10540", VA = "0x186F11B40", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F11B80", Offset = "0x6F10580", VA = "0x186F11B80", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class KAGDOLOLCAF : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6F13180", Offset = "0x6F11B80", VA = "0x186F13180", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6F13140", Offset = "0x6F11B40", VA = "0x186F13140")]
		public KAGDOLOLCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F130C0", Offset = "0x6F11AC0", VA = "0x186F130C0", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F13100", Offset = "0x6F11B00", VA = "0x186F13100", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class ALNEOLINCHJ : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6F115E0", Offset = "0x6F0FFE0", VA = "0x186F115E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F115A0", Offset = "0x6F0FFA0", VA = "0x186F115A0")]
		public ALNEOLINCHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F11520", Offset = "0x6F0FF20", VA = "0x186F11520", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F11560", Offset = "0x6F0FF60", VA = "0x186F11560", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class GLAJNAKGJED : Property<LLEFCPNBLDO, DCKFJKFGLDP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6F124F0", Offset = "0x6F10EF0", VA = "0x186F124F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F124B0", Offset = "0x6F10EB0", VA = "0x186F124B0")]
		public GLAJNAKGJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F12430", Offset = "0x6F10E30", VA = "0x186F12430", Slot = "14")]
		public override DCKFJKFGLDP<Delegate> GetValue(LLEFCPNBLDO DNJEODDCEHK)
		{
			return default(DCKFJKFGLDP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F12470", Offset = "0x6F10E70", VA = "0x186F12470", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO DNJEODDCEHK, DCKFJKFGLDP<Delegate> PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F128D0", Offset = "0x6F112D0", VA = "0x186F128D0")]
	public JMKMFCBKENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
internal class LBEHAJJLDOM : ContainerPropertyBag<LLEFCPNBLDO.EOEBBNDJICA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private class GDJPKLIJHDG : Property<LLEFCPNBLDO.EOEBBNDJICA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6F12400", Offset = "0x6F10E00", VA = "0x186F12400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F123C0", Offset = "0x6F10DC0", VA = "0x186F123C0")]
		public GDJPKLIJHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA1A120", Offset = "0xA18B20", VA = "0x180A1A120", Slot = "14")]
		public override object GetValue(LLEFCPNBLDO.EOEBBNDJICA DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4BA8830", Offset = "0x4BA7230", VA = "0x184BA8830", Slot = "15")]
		public override void SetValue(LLEFCPNBLDO.EOEBBNDJICA DNJEODDCEHK, object PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F13300", Offset = "0x6F11D00", VA = "0x186F13300")]
	public LBEHAJJLDOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class PLHFLOHJMDP : ContainerPropertyBag<DCKFJKFGLDP<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F13B90", Offset = "0x6F12590", VA = "0x186F13B90")]
	public PLHFLOHJMDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class DDKGALJDCLI : ContainerPropertyBag<KJIBFFLIHCH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	private class LGKFFODBONO : Property<KJIBFFLIHCH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6F13420", Offset = "0x6F11E20", VA = "0x186F13420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F133E0", Offset = "0x6F11DE0", VA = "0x186F133E0")]
		public LGKFFODBONO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6F11460", Offset = "0x6F0FE60", VA = "0x186F11460", Slot = "14")]
		public override Rigidbody GetValue(KJIBFFLIHCH DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F11480", Offset = "0x6F0FE80", VA = "0x186F11480", Slot = "15")]
		public override void SetValue(KJIBFFLIHCH DNJEODDCEHK, Rigidbody PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F11C30", Offset = "0x6F10630", VA = "0x186F11C30")]
	public DDKGALJDCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
internal class CALACNENEML : ContainerPropertyBag<KHIOFAGJICL>
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	private class CDLBNGFPNMA : Property<KHIOFAGJICL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6F11A50", Offset = "0x6F10450", VA = "0x186F11A50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F11A10", Offset = "0x6F10410", VA = "0x186F11A10")]
		public CDLBNGFPNMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6F11460", Offset = "0x6F0FE60", VA = "0x186F11460", Slot = "14")]
		public override object GetValue(KHIOFAGJICL DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F11480", Offset = "0x6F0FE80", VA = "0x186F11480", Slot = "15")]
		public override void SetValue(KHIOFAGJICL DNJEODDCEHK, object PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F11840", Offset = "0x6F10240", VA = "0x186F11840")]
	public CALACNENEML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class DJFJKFFNCAA : ContainerPropertyBag<JPIBJFEGAMD>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class ALEHHAIJEKP : Property<JPIBJFEGAMD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string OENPDLODONH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6F114F0", Offset = "0x6F0FEF0", VA = "0x186F114F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HICONDDLJMF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F114B0", Offset = "0x6F0FEB0", VA = "0x186F114B0")]
		public ALEHHAIJEKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F11460", Offset = "0x6F0FE60", VA = "0x186F11460", Slot = "14")]
		public override object GetValue(JPIBJFEGAMD DNJEODDCEHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F11480", Offset = "0x6F0FE80", VA = "0x186F11480", Slot = "15")]
		public override void SetValue(JPIBJFEGAMD DNJEODDCEHK, object PKCLPFEIPFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F11D10", Offset = "0x6F10710", VA = "0x186F11D10")]
	public DJFJKFFNCAA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6F13BF0", Offset = "0x6F125F0", VA = "0x186F13BF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class JJODAPEKCBG
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public JJODAPEKCBG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD920", Offset = "0x6FAC920", VA = "0x186FAD920", Slot = "9")]
		public override void GNNKBPHDLHE(KFFDGDFCPPM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FADD00", Offset = "0x6FACD00", VA = "0x186FADD00", Slot = "7")]
		public override void MLNHEDKHLIC(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PBNKDELGACH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAF30", Offset = "0x6FA9F30", VA = "0x186FAAF30", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NOGNJGNBBAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DFGIPCFBKEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity NKIIMHFEHOF;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DGOJELFBPGH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity NKIIMHFEHOF;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IKEDFGPOFOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<AIEBIMFMODB> CCLHDNOBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> IPLACEBNKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle CGOCMLLNHDP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OPPNLAPBCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FABB00", Offset = "0x6FAAB00", VA = "0x186FABB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BCEJCMKMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FABCF0", Offset = "0x6FAACF0", VA = "0x186FABCF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5113390", Offset = "0x5112390", VA = "0x185113390")]
	public IKEDFGPOFOM(NativeList<AIEBIMFMODB> CCLHDNOBGEP, NativeList<Entity> IPLACEBNKPP, JobHandle CGOCMLLNHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FABB70", Offset = "0x6FAAB70", VA = "0x186FABB70")]
	public (Entity, NativeSlice<Entity>) DNEHGHBLJGD(int MEJGJHNGKCJ)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FABC90", Offset = "0x6FAAC90", VA = "0x186FABC90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AIEBIMFMODB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity BAOAKGNNKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int OFDADLBABBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int CDEEBECPNGB;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GMDIPBPLLJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKLDLKNEPFB(bool BNBGOAOBFJN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct ELHFGBIDBHF : IEquatable<ELHFGBIDBHF>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool ECFLDFMLHGH(int EJNEHCOECHP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool AHLHMBPNONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool HECFBMEHKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool OCNIOJDFGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool KKNLKLFDHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly ECFLDFMLHGH KODPPFPDPHJ;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB4F0", Offset = "0x6FAA4F0", VA = "0x186FAB4F0")]
	public ELHFGBIDBHF(KGMCLDKIBHB IECLEDMOCFH, ECFLDFMLHGH KODPPFPDPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB4C0", Offset = "0x6FAA4C0", VA = "0x186FAB4C0")]
	public ELHFGBIDBHF(bool AHLHMBPNONM, bool HECFBMEHKBF, bool OCNIOJDFGMN, bool KKNLKLFDHJL, ECFLDFMLHGH KODPPFPDPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB490", Offset = "0x6FAA490", VA = "0x186FAB490")]
	public bool NGIMFPEOJCG(int EJNEHCOECHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB260", Offset = "0x6FAA260", VA = "0x186FAB260")]
	public bool CDCEMMJMCOG(int EJNEHCOECHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB440", Offset = "0x6FAA440", VA = "0x186FAB440")]
	public bool HBLGGNOBABA(int EJNEHCOECHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB290", Offset = "0x6FAA290", VA = "0x186FAB290")]
	public bool CIDKCHGEKKO(int EJNEHCOECHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB2C0", Offset = "0x6FAA2C0", VA = "0x186FAB2C0", Slot = "4")]
	public bool Equals(ELHFGBIDBHF DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB2F0", Offset = "0x6FAA2F0", VA = "0x186FAB2F0", Slot = "0")]
	public override bool Equals(object IFPBFCLBBDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB3A0", Offset = "0x6FAA3A0", VA = "0x186FAB3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB470", Offset = "0x6FAA470", VA = "0x186FAB470")]
	private bool IJPOIICJKDI(int EJNEHCOECHP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LLNHLNMEDKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NPIJKHGAAFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NBGDMEMGKKC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct LINGGLEPENE : IBufferElementData, IEquatable<LINGGLEPENE>, GAJADDOMLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity KOOGBCPBMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int PJMPBKCBEEF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity POKDKAMAFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC570", Offset = "0x6FAB570", VA = "0x186FAC570", Slot = "4")]
	public bool Equals(LINGGLEPENE DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct JBKDLDJDALI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct MPHBJCFDHGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly BCIDNGCIKOK IEPDGPJLHMB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x24BC480", Offset = "0x24BB480", VA = "0x1824BC480")]
		public MPHBJCFDHGC(BCIDNGCIKOK EIGAIHODBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6FACA10", Offset = "0x6FABA10", VA = "0x186FACA10")]
		public bool IJNMMELOLAJ(JBKDLDJDALI EMECOBOHCNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6FACA00", Offset = "0x6FABA00", VA = "0x186FACA00")]
		public bool GBKKLLKONDA(JBKDLDJDALI EMECOBOHCNC, BCIDNGCIKOK EHCCAENALNB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly BCIDNGCIKOK GGLKIMCOCFB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x24BC480", Offset = "0x24BB480", VA = "0x1824BC480")]
	public JBKDLDJDALI(BCIDNGCIKOK GGLKIMCOCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6FABDF0", Offset = "0x6FAADF0", VA = "0x186FABDF0")]
	public JBKDLDJDALI HKMDHCEDFNK(BCIDNGCIKOK NPFADPHPNDF)
	{
		return default(JBKDLDJDALI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6FABE00", Offset = "0x6FAAE00", VA = "0x186FABE00")]
	public JBKDLDJDALI JHEBPHPLMMK(BCIDNGCIKOK KPKGKPLBDAG)
	{
		return default(JBKDLDJDALI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6FABE10", Offset = "0x6FAAE10", VA = "0x186FABE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum BCIDNGCIKOK : byte
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
public enum FMDKGLCALEE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[FIFNPLEBIIH]
public struct FNAEOKAOGID : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public FMDKGLCALEE GGLKIMCOCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool IEKEEIKNPON;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool COOOGMKINIG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB670", Offset = "0x6FAA670", VA = "0x186FAB670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB680", Offset = "0x6FAA680", VA = "0x186FAB680")]
	private FNAEOKAOGID(FMDKGLCALEE GGLKIMCOCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB630", Offset = "0x6FAA630", VA = "0x186FAB630")]
	public FNAEOKAOGID HKMDHCEDFNK(FMDKGLCALEE NPFADPHPNDF)
	{
		return default(FNAEOKAOGID);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB650", Offset = "0x6FAA650", VA = "0x186FAB650")]
	public FNAEOKAOGID JHEBPHPLMMK(FMDKGLCALEE KPKGKPLBDAG)
	{
		return default(FNAEOKAOGID);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LJPKMGBHMKC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MLAJEENMEOD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity IKGBLBMBOKH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, GAJADDOMLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAF30", Offset = "0x6FA9F30", VA = "0x186FAAF30", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FIFNPLEBIIH]
public struct KCMHCDBPBGC : ISystemStateBufferElementData, IBufferElementData, GAJADDOMLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity KKABBGOPMMA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity NDNKGJEJKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FAJJDLNGCLG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity NNAALBAIFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity ADMJBHENEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity ANFOLGLCJPD;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PEEMFDLBOFL<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly bool MNCIMEONHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint CAAMOGBKFAC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool GOAIHKPFLED()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct OHPCMMHOGDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public uint OLCLOKFKMJO;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD1B0", Offset = "0x6FAC1B0", VA = "0x186FAD1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GIHAFDNDBOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[FIFNPLEBIIH]
public struct BJOAPBOOOAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int BPBLGGPLLMN;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct HKICCDPNNMF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int IGGGJEBFAKN;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct AIFHNCKOAPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GCHandle HGMIFKJKEDH;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct IDPEBFLPMOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int IGGGJEBFAKN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct FDAJBOHBBNP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LAHCDMKEBMG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int IGGGJEBFAKN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LMBOIEMFGJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct CLFCEONDOFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct GBGOALDPIML : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct KNIOFJLHNPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CollisionDetectionMode EFOBGBBOHFK;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BCOOMLFPCGL]
public struct DLDNHLGHFGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public DJFOEHMHKBO LHIOLDHLMOK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly DLDNHLGHFGF LONMIMAJOAB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct LHPPMONHNDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct MDMPFKNAPMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct MCBOKLGABGE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct LJDKLLMDBLI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity KOOGBCPBMOE;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DEEOGELCNEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity JNLBEALAMNB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct MHBDGJGKDGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct GEKPFKMDEEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity BAOAKGNNKEP;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BIJJLOJONBF : MBIPKDJDKJN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LMAPKKOFJAC DLGIEOLCGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(LMAPKKOFJAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DHODPCIBNPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3 HELHLEJOBCN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IPBKAMCPEJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BCOOMLFPCGL]
public struct JHPFKCGODDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 JIKPFJEBGIO;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly JHPFKCGODDD LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BCOOMLFPCGL]
public struct AMKHPONPJKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3x3 JIKPFJEBGIO;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly AMKHPONPJKB LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct FFOHDLGEGDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 CILMNIIKCKC;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KOFACCNNPIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3 JMDMBAHJHBH;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BCOOMLFPCGL]
public struct JNADMHJHOLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float MDNNEPADFBB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JNADMHJHOLI LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BCOOMLFPCGL]
public struct JMCCIFBPAGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float NAEBBHHCDMM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly JMCCIFBPAGP LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct HNHIOALJEFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 AFCAJCHKJLE;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct HOFGGJDAJLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public BJBOIDJKKGM BHFCKEOBCFF;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct FLPEPIMIEJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public BJBOIDJKKGM HMOEPPEOIKC;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[FIFNPLEBIIH]
public struct GLPHDFFPMAL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity KKABBGOPMMA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NNODFNNDEGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct GICNENDFFMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct CNLIANNMBAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public RigidbodyConstraints BIGLDLOJOLB;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BCOOMLFPCGL]
public struct GGIBODMFMCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float IHEIHEJADLH;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GGIBODMFMCJ LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct COJAKPJBPGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float EIBKJKGFOGD;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class OKLAHGONBEL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct NHACAPNIOCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public object AKICAIGKLDP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject IEELEEMHGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object AKNOEMBKPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object GPOKNDMALON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NHACAPNIOCD AKICAIGKLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate OAHOBKMEEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Delegate IDMLKBILLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public AEBIOGGIKME<Delegate> JGNCMDDHIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public AEBIOGGIKME<Delegate> COJHGKABDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public AEBIOGGIKME<Delegate> ACIJMMMLHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public AEBIOGGIKME<Delegate> EDOPDGCJKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public AEBIOGGIKME<Delegate> CDBKNJMBAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public AEBIOGGIKME<Delegate> CFKMFOKKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public AEBIOGGIKME<Delegate> ENBLFGHNBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public AEBIOGGIKME<Delegate> FGCHBJFBIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public AEBIOGGIKME<Delegate> KEKBHKCEFNE;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FAD300", Offset = "0x6FAC300", VA = "0x186FAD300", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OKLAHGONBEL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct JFLIMGGPIJI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BJDEKEAOFBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int NBADINIBHIK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x183EE30", Offset = "0x183DE30", VA = "0x18183EE30")]
	public static BJDEKEAOFBH ILBKFABDDDI(int BJDKOHEGDOK)
	{
		return default(BJDEKEAOFBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class KODNMMEFDAK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Rigidbody MIGHIIBDOBO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC430", Offset = "0x6FAB430", VA = "0x186FAC430", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public KODNMMEFDAK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct MPGLIOMPPON : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IFKFDDCEEIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 DLOHMJPHMGK;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct EGEFMJBBBLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float3 DLJIHGEKHEP;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[BCOOMLFPCGL]
public struct IKPAOEHCFFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float NDBOODBGHDN;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IKPAOEHCFFL LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LGFNBPJICOK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object DLALOBOOOMP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC500", Offset = "0x6FAB500", VA = "0x186FAC500", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public LGFNBPJICOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class IDAGOJFMHLD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public object PMKDEIIIPDB;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB9B0", Offset = "0x6FAA9B0", VA = "0x186FAB9B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public IDAGOJFMHLD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FAMIMOGINIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct HAEFMMOKGHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct JBFDHICCODJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct ILHOHDEENDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct BEDNENIAEIJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct ABJPHNNGIOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FixedString32Bytes DMCFPOLFNCF;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[FIFNPLEBIIH]
public struct MGMPANPJJHE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity NLEJIHGAKCB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static MGMPANPJJHE ILBKFABDDDI(Entity BJDKOHEGDOK)
	{
		return default(MGMPANPJJHE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct KLIAAMBIDFI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity KKABBGOPMMA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static KLIAAMBIDFI ILBKFABDDDI(Entity KKABBGOPMMA)
	{
		return default(KLIAAMBIDFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct DLMLGPCEBPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity HAGLNEOEDGC;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct JOMDDNELILP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity HAGLNEOEDGC;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct AKHLHAGAIMA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity BHKHPHLBAKC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xAB9C20", Offset = "0xAB8C20", VA = "0x180AB9C20")]
	public static AKHLHAGAIMA ILBKFABDDDI(Entity KKABBGOPMMA)
	{
		return default(AKHLHAGAIMA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct CBAOJPCBMMP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct MDEFOBONIEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct LBFNIADGMJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint FNBFBBNHKCM;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[FIFNPLEBIIH]
internal struct BFBLHMHLKMF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity IGMPFNNPDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int KHAIDMGPIED;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct CCLIGOCNFLA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity PDELKCEAEJO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct FKOMFHEPPOJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct IHCKPEIMEPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public uint CAAMOGBKFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int CLAPNAPECFK;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x99A6C0", Offset = "0x9996C0", VA = "0x18099A6C0")]
	public IHCKPEIMEPE(uint FLGCJINLJMD, int AHCBMJOMFAH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct DHEBHJFOBBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct NCGECHKLKLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct NFCEMDBCHEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct FJGGLBPAMJC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct EKBOOENINKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct CFHEKDGOEPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct NONMNMOPHEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct ENKDMFPFGLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct ALLDFBPGGPG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PALIOIIPNEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct JEDPALFPDCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct DKCCBEAEHNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct AAELNFMALIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct AKDNOEDNPII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct HIPLPHJGJGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct AOHOGCCDNKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct HFFNKIMGDBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct DHIIOLBAHPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HEBKIFODFMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct OIALJGAFEHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct GEOPDEBIOFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct LLPNFOPAFHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct IJCJOJBMKBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct PFDGBGDMGOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct MDFCEFFOKDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct PJJNEHCIHDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct BGNBHDAAMHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct FJPGGEHDHMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[FIFNPLEBIIH]
public struct LLCHALAJLCE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes DDOEMKPCPHL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct EEFCCHBJPNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DBGKNBGFADF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct PMEFPLJHHKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct LECJPEFOAOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct KDBJNFBLPMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct LAKICOHPBIF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct DCDFGDEBBHB : IComponentData, IComparable<DCDFGDEBBHB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int AFBBDHOIECI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2118D20", Offset = "0x2117D20", VA = "0x182118D20", Slot = "4")]
	public int CompareTo(DCDFGDEBBHB DFABCHNPEEM)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct LHDJPAHALEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct BAGJIPGBEPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public quaternion JKJHCABJJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 PAMMLHPIJIB;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct HMLLCNKNMOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float GGJNKAAJANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float ECHKCLIMFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float BFHKOCMBCED;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct GPHHMPDDAKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct KAAOAECPHPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct JEOPILCMFHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct JPJAKEMMOBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int IGGGJEBFAKN;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[FIFNPLEBIIH]
public struct KCBDIGIHHKP : ISystemStateBufferElementData, IBufferElementData, GAJADDOMLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity DPNCJOLAJOK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity NDNKGJEJKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BCOOMLFPCGL]
public struct ALEJAFODADL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 LGOFBEKFOOB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly ALEJAFODADL LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BCOOMLFPCGL]
public struct HHMLDEMJFJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float4x4 DNBOGBAIIKD;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly HHMLDEMJFJP LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct FCBLLCAHGLD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int GPAAEOAEOCH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KHAIDMGPIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB610", Offset = "0x6FAA610", VA = "0x186FAB610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB620", Offset = "0x6FAA620", VA = "0x186FAB620")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BCOOMLFPCGL]
public struct OGKOEAPJFPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 DDFNHHFJHML;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly OGKOEAPJFPO LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[BCOOMLFPCGL]
public struct DHCEIGBGNBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 PAMMLHPIJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public quaternion JKJHCABJJIO;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly DHCEIGBGNBA LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class GEKAHABMMHE
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[BCOOMLFPCGL]
public struct ACCDLKBDGIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float EBMGHBCDOGE;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly ACCDLKBDGIA LONMIMAJOAB;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct HIDKCAJMNNM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity OANGBAAODID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public KBKKNPPGCKK LLLGBHDHFFG;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct ENFNBHNAGPC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public KBKKNPPGCKK LLLGBHDHFFG;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct OBPLJCIEEEF : ISystemStateComponentData, IComponentData, GAJADDOMLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity MPFENKGEFEA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity NDNKGJEJKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct ONKAIKGPNNL : ISystemStateBufferElementData, IBufferElementData, GAJADDOMLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity DGEFELJOGKE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity NDNKGJEJKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct KFOCLIEBFHE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity OANGBAAODID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public KBKKNPPGCKK LLLGBHDHFFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct NPPJHGNAMFE : IEqualityComparer<KFOCLIEBFHE>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static NPPJHGNAMFE LONMIMAJOAB;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FACA20", Offset = "0x6FABA20", VA = "0x186FACA20", Slot = "4")]
	public bool Equals(KFOCLIEBFHE GOCMFEAMGHO, KFOCLIEBFHE AEFHGLLPABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FACA70", Offset = "0x6FABA70", VA = "0x186FACA70", Slot = "5")]
	public int GetHashCode(KFOCLIEBFHE IFPBFCLBBDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct NPCCINBNJNN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> HLIJPJKOGAE;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct FLMHIFGINFI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FixedList32Bytes<int> HLIJPJKOGAE;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct GOAIIMGNDKL : ISystemStateBufferElementData, IBufferElementData, GAJADDOMLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity DBLHEEKFEIM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity POKDKAMAFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x120BE10", Offset = "0x120AE10", VA = "0x18120BE10", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class ODKJFOIPPAJ : ContainerPropertyBag<OKLAHGONBEL>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class GODHFBFDCHO : Property<OKLAHGONBEL, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB7F0", Offset = "0x6FAA7F0", VA = "0x186FAB7F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB7B0", Offset = "0x6FAA7B0", VA = "0x186FAB7B0")]
		public GODHFBFDCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6FAABE0", Offset = "0x6FA9BE0", VA = "0x186FAABE0", Slot = "14")]
		public override GameObject GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAC00", Offset = "0x6FA9C00", VA = "0x186FAAC00", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, GameObject BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class OJMKGBBJPPH : Property<OKLAHGONBEL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6FAD2D0", Offset = "0x6FAC2D0", VA = "0x186FAD2D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD290", Offset = "0x6FAC290", VA = "0x186FAD290")]
		public OJMKGBBJPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD240", Offset = "0x6FAC240", VA = "0x186FAD240", Slot = "14")]
		public override object GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD260", Offset = "0x6FAC260", VA = "0x186FAD260", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, object BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class KKAODJKKBEH : Property<OKLAHGONBEL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC400", Offset = "0x6FAB400", VA = "0x186FAC400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC3C0", Offset = "0x6FAB3C0", VA = "0x186FAC3C0")]
		public KKAODJKKBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC370", Offset = "0x6FAB370", VA = "0x186FAC370", Slot = "14")]
		public override object GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC390", Offset = "0x6FAB390", VA = "0x186FAC390", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, object BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class MPGHCHOCEDP : Property<OKLAHGONBEL, OKLAHGONBEL.NHACAPNIOCD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC9D0", Offset = "0x6FAB9D0", VA = "0x186FAC9D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC990", Offset = "0x6FAB990", VA = "0x186FAC990")]
		public MPGHCHOCEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC940", Offset = "0x6FAB940", VA = "0x186FAC940", Slot = "14")]
		public override OKLAHGONBEL.NHACAPNIOCD GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(OKLAHGONBEL.NHACAPNIOCD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC960", Offset = "0x6FAB960", VA = "0x186FAC960", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, OKLAHGONBEL.NHACAPNIOCD BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class CIOBEFDMGML : Property<OKLAHGONBEL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6FAAFD0", Offset = "0x6FA9FD0", VA = "0x186FAAFD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAF90", Offset = "0x6FA9F90", VA = "0x186FAAF90")]
		public CIOBEFDMGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAF40", Offset = "0x6FA9F40", VA = "0x186FAAF40", Slot = "14")]
		public override Delegate GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAF60", Offset = "0x6FA9F60", VA = "0x186FAAF60", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, Delegate BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class LLKEIPEKFEH : Property<OKLAHGONBEL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC650", Offset = "0x6FAB650", VA = "0x186FAC650", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC610", Offset = "0x6FAB610", VA = "0x186FAC610")]
		public LLKEIPEKFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC5C0", Offset = "0x6FAB5C0", VA = "0x186FAC5C0", Slot = "14")]
		public override Delegate GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC5E0", Offset = "0x6FAB5E0", VA = "0x186FAC5E0", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, Delegate BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class IILCGGKLHJC : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6FABAD0", Offset = "0x6FAAAD0", VA = "0x186FABAD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FABA90", Offset = "0x6FAAA90", VA = "0x186FABA90")]
		public IILCGGKLHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FABA20", Offset = "0x6FAAA20", VA = "0x186FABA20", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FABA50", Offset = "0x6FAAA50", VA = "0x186FABA50", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class MDOIMOOPEGE : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC910", Offset = "0x6FAB910", VA = "0x186FAC910", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC8D0", Offset = "0x6FAB8D0", VA = "0x186FAC8D0")]
		public MDOIMOOPEGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC860", Offset = "0x6FAB860", VA = "0x186FAC860", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC890", Offset = "0x6FAB890", VA = "0x186FAC890", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class HHOCOGKNCKJ : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB980", Offset = "0x6FAA980", VA = "0x186FAB980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB940", Offset = "0x6FAA940", VA = "0x186FAB940")]
		public HHOCOGKNCKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB8D0", Offset = "0x6FAA8D0", VA = "0x186FAB8D0", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB900", Offset = "0x6FAA900", VA = "0x186FAB900", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class PDIEOKBMNDL : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6FAD410", Offset = "0x6FAC410", VA = "0x186FAD410", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD3D0", Offset = "0x6FAC3D0", VA = "0x186FAD3D0")]
		public PDIEOKBMNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD350", Offset = "0x6FAC350", VA = "0x186FAD350", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD390", Offset = "0x6FAC390", VA = "0x186FAD390", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class ALELCLIDAMI : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6FAAE10", Offset = "0x6FA9E10", VA = "0x186FAAE10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FAADD0", Offset = "0x6FA9DD0", VA = "0x186FAADD0")]
		public ALELCLIDAMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAD50", Offset = "0x6FA9D50", VA = "0x186FAAD50", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAD90", Offset = "0x6FA9D90", VA = "0x186FAAD90", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class MCKOPOINBAI : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC830", Offset = "0x6FAB830", VA = "0x186FAC830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC7F0", Offset = "0x6FAB7F0", VA = "0x186FAC7F0")]
		public MCKOPOINBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC770", Offset = "0x6FAB770", VA = "0x186FAC770", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC7B0", Offset = "0x6FAB7B0", VA = "0x186FAC7B0", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class LMABNNPACCN : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC740", Offset = "0x6FAB740", VA = "0x186FAC740", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC700", Offset = "0x6FAB700", VA = "0x186FAC700")]
		public LMABNNPACCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC680", Offset = "0x6FAB680", VA = "0x186FAC680", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC6C0", Offset = "0x6FAB6C0", VA = "0x186FAC6C0", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class JCAFIENHKGJ : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6FABF30", Offset = "0x6FAAF30", VA = "0x186FABF30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FABEF0", Offset = "0x6FAAEF0", VA = "0x186FABEF0")]
		public JCAFIENHKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FABE70", Offset = "0x6FAAE70", VA = "0x186FABE70", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FABEB0", Offset = "0x6FAAEB0", VA = "0x186FABEB0", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class EDBGPBHOECL : Property<OKLAHGONBEL, AEBIOGGIKME<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB230", Offset = "0x6FAA230", VA = "0x186FAB230", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB1F0", Offset = "0x6FAA1F0", VA = "0x186FAB1F0")]
		public EDBGPBHOECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB170", Offset = "0x6FAA170", VA = "0x186FAB170", Slot = "14")]
		public override AEBIOGGIKME<Delegate> GetValue(OKLAHGONBEL GHHOPPHGNHJ)
		{
			return default(AEBIOGGIKME<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB1B0", Offset = "0x6FAA1B0", VA = "0x186FAB1B0", Slot = "15")]
		public override void SetValue(OKLAHGONBEL GHHOPPHGNHJ, AEBIOGGIKME<Delegate> BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6FACAD0", Offset = "0x6FABAD0", VA = "0x186FACAD0")]
	public ODKJFOIPPAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class ENLNFEMKNDB : ContainerPropertyBag<OKLAHGONBEL.NHACAPNIOCD>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class JMDHCFFLLCN : Property<OKLAHGONBEL.NHACAPNIOCD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC1B0", Offset = "0x6FAB1B0", VA = "0x186FAC1B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC170", Offset = "0x6FAB170", VA = "0x186FAC170")]
		public JMDHCFFLLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xACCCB0", Offset = "0xACBCB0", VA = "0x180ACCCB0", Slot = "14")]
		public override object GetValue(OKLAHGONBEL.NHACAPNIOCD GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C1A890", Offset = "0x4C19890", VA = "0x184C1A890", Slot = "15")]
		public override void SetValue(OKLAHGONBEL.NHACAPNIOCD GHHOPPHGNHJ, object BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB530", Offset = "0x6FAA530", VA = "0x186FAB530")]
	public ENLNFEMKNDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class LDBPNIHKOCE : ContainerPropertyBag<AEBIOGGIKME<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC4A0", Offset = "0x6FAB4A0", VA = "0x186FAC4A0")]
	public LDBPNIHKOCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class GHGLFLMBKKJ : ContainerPropertyBag<KODNMMEFDAK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class AHNMKJCKHOG : Property<KODNMMEFDAK, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6FAAC70", Offset = "0x6FA9C70", VA = "0x186FAAC70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAC30", Offset = "0x6FA9C30", VA = "0x186FAAC30")]
		public AHNMKJCKHOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FAABE0", Offset = "0x6FA9BE0", VA = "0x186FAABE0", Slot = "14")]
		public override Rigidbody GetValue(KODNMMEFDAK GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAC00", Offset = "0x6FA9C00", VA = "0x186FAAC00", Slot = "15")]
		public override void SetValue(KODNMMEFDAK GHHOPPHGNHJ, Rigidbody BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB6D0", Offset = "0x6FAA6D0", VA = "0x186FAB6D0")]
	public GHGLFLMBKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JJLLILLAONH : ContainerPropertyBag<LGFNBPJICOK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class IOLKBNANMJF : Property<LGFNBPJICOK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6FABDC0", Offset = "0x6FAADC0", VA = "0x186FABDC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FABD80", Offset = "0x6FAAD80", VA = "0x186FABD80")]
		public IOLKBNANMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FAABE0", Offset = "0x6FA9BE0", VA = "0x186FAABE0", Slot = "14")]
		public override object GetValue(LGFNBPJICOK GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAC00", Offset = "0x6FA9C00", VA = "0x186FAAC00", Slot = "15")]
		public override void SetValue(LGFNBPJICOK GHHOPPHGNHJ, object BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC050", Offset = "0x6FAB050", VA = "0x186FAC050")]
	public JJLLILLAONH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class KGJMGNHBMJG : ContainerPropertyBag<IDAGOJFMHLD>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class KJIAAOPHEFP : Property<IDAGOJFMHLD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string KKNEIOOKBDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC340", Offset = "0x6FAB340", VA = "0x186FAC340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool AGBMIOANOEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC300", Offset = "0x6FAB300", VA = "0x186FAC300")]
		public KJIAAOPHEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FAABE0", Offset = "0x6FA9BE0", VA = "0x186FAABE0", Slot = "14")]
		public override object GetValue(IDAGOJFMHLD GHHOPPHGNHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAC00", Offset = "0x6FA9C00", VA = "0x186FAAC00", Slot = "15")]
		public override void SetValue(IDAGOJFMHLD GHHOPPHGNHJ, object BJDKOHEGDOK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FAC220", Offset = "0x6FAB220", VA = "0x186FAC220")]
	public KGJMGNHBMJG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6FAD440", Offset = "0x6FAC440", VA = "0x186FAD440")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class OBMFEFCOIEE
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OBMFEFCOIEE()
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

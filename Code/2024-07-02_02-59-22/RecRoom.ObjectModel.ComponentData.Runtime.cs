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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
	public class _AssemblyIndex : KHGPJHOJOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A56240", Offset = "0x6A55240", VA = "0x186A56240", Slot = "8")]
		public override void LOCAGFNGOIC(ADLFNLPBEEE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A55E40", Offset = "0x6A54E40", VA = "0x186A55E40", Slot = "7")]
		public override void KJMJPABGNLA(MPPJJFLBNOM registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A56640", Offset = "0x6A55640", VA = "0x186A56640")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PHLIOOPHAOD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, IKAFELLNDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A53180", Offset = "0x6A52180", VA = "0x186A53180", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, IKAFELLNDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JNPGMJIGBLL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JFENKGLBEPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity AANPFNJHEDJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FIICCAHILKK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity AANPFNJHEDJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PNCECJNMIPP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<MPABIEIPIOG> DCBEJFIDLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> GKEEOHBEIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle OPKPNABHNJC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A55780", Offset = "0x6A54780", VA = "0x186A55780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A55910", Offset = "0x6A54910", VA = "0x186A55910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4CE19B0", Offset = "0x4CE09B0", VA = "0x184CE19B0")]
	public PNCECJNMIPP(NativeList<MPABIEIPIOG> DCBEJFIDLIP, NativeList<Entity> GKEEOHBEIPB, JobHandle OPKPNABHNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A557F0", Offset = "0x6A547F0", VA = "0x186A557F0")]
	public (Entity, NativeSlice<Entity>) NHMOKFODDEB(int JFDIHIMJIHB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A55720", Offset = "0x6A54720", VA = "0x186A55720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MPABIEIPIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity FMGEJNFFGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int ANNLKNNLIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int DOIKAIEGGLD;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IBKBAGKMNPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKANCNCFFJD(bool MLPJONHPDEC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct CFLEICKAICO : IEquatable<CFLEICKAICO>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool PNHEFALLACG(int IGGMMJMDDDD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool EIEOJLFJNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool CFPJODIOAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool LLCIHKGGICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool DKGLMLPBFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PNHEFALLACG MFMCPNCENFC;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A537D0", Offset = "0x6A527D0", VA = "0x186A537D0")]
	public CFLEICKAICO(MJBOEELPMEM IDICACLIBFM, PNHEFALLACG MFMCPNCENFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A53810", Offset = "0x6A52810", VA = "0x186A53810")]
	public CFLEICKAICO(bool EIEOJLFJNDE, bool CFPJODIOAEB, bool LLCIHKGGICM, bool DKGLMLPBFFK, PNHEFALLACG MFMCPNCENFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A535A0", Offset = "0x6A525A0", VA = "0x186A535A0")]
	public bool EOKBKMJFFOL(int IGGMMJMDDDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A537A0", Offset = "0x6A527A0", VA = "0x186A537A0")]
	public bool OKHLNHJJGGI(int IGGMMJMDDDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A53570", Offset = "0x6A52570", VA = "0x186A53570")]
	public bool APDENPKFMFE(int IGGMMJMDDDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A53750", Offset = "0x6A52750", VA = "0x186A53750")]
	public bool HDEAJGPLHCB(int IGGMMJMDDDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A53680", Offset = "0x6A52680", VA = "0x186A53680", Slot = "4")]
	public bool Equals(CFLEICKAICO LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A535D0", Offset = "0x6A525D0", VA = "0x186A535D0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A536B0", Offset = "0x6A526B0", VA = "0x186A536B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A53780", Offset = "0x6A52780", VA = "0x186A53780")]
	private bool JJDMEHFILAE(int IGGMMJMDDDD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JKHPEOAHBOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MBCDNACKBKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LIONOCPDABN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct GKKKNILAHHI : IBufferElementData, IEquatable<GKKKNILAHHI>, IKAFELLNDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity FLFKBMMIINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int FMECGGGAFDL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity KDICIHJGNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A53CD0", Offset = "0x6A52CD0", VA = "0x186A53CD0", Slot = "4")]
	public bool Equals(GKKKNILAHHI LJAAPFIIPOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct GHAIICKDMOC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct IEGPNMPIBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly NDEIOLOPFAH JFGPDGIAMOD;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x217F560", Offset = "0x217E560", VA = "0x18217F560")]
		public IEGPNMPIBGD(NDEIOLOPFAH LMECIGJKCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A540C0", Offset = "0x6A530C0", VA = "0x186A540C0")]
		public bool DOALLADJBKL(GHAIICKDMOC FGEAEFHPDPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A540B0", Offset = "0x6A530B0", VA = "0x186A540B0")]
		public bool BDMDKBHMMPN(GHAIICKDMOC FGEAEFHPDPJ, NDEIOLOPFAH PDNIIFKLLGG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly NDEIOLOPFAH GOKDCCIDHIG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x217F560", Offset = "0x217E560", VA = "0x18217F560")]
	public GHAIICKDMOC(NDEIOLOPFAH GOKDCCIDHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A53C60", Offset = "0x6A52C60", VA = "0x186A53C60")]
	public GHAIICKDMOC HANNIJGNKJE(NDEIOLOPFAH DCOLJJDLHOJ)
	{
		return default(GHAIICKDMOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A53C50", Offset = "0x6A52C50", VA = "0x186A53C50")]
	public GHAIICKDMOC CJCDEMIFKLC(NDEIOLOPFAH MLFGLDNFDNK)
	{
		return default(GHAIICKDMOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A53C70", Offset = "0x6A52C70", VA = "0x186A53C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum NDEIOLOPFAH : byte
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
public enum MGAJKGPNKOH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[CEOJINBDPLN]
public struct BLHPPHBFOBD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public MGAJKGPNKOH GOKDCCIDHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool FOLLLHLJHJE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GMDBPLCDNML
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A53430", Offset = "0x6A52430", VA = "0x186A53430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A53440", Offset = "0x6A52440", VA = "0x186A53440")]
	private BLHPPHBFOBD(MGAJKGPNKOH GOKDCCIDHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A53410", Offset = "0x6A52410", VA = "0x186A53410")]
	public BLHPPHBFOBD HANNIJGNKJE(MGAJKGPNKOH DCOLJJDLHOJ)
	{
		return default(BLHPPHBFOBD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A533F0", Offset = "0x6A523F0", VA = "0x186A533F0")]
	public BLHPPHBFOBD CJCDEMIFKLC(MGAJKGPNKOH MLFGLDNFDNK)
	{
		return default(BLHPPHBFOBD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GHOODHDGMKN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JLDEHHBHJFN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity OABHELEOFIF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, IKAFELLNDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A53180", Offset = "0x6A52180", VA = "0x186A53180", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[CEOJINBDPLN]
public struct KAGKEAPEFKP : ISystemStateBufferElementData, IBufferElementData, IKAFELLNDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity JOAHHHNEJGM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity ENONCDBLDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FEDFEKFGHOJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity FHHGFPFMPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity JOBPJJODOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity JFBMHPCHKOC;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct OHDFKCCEDAB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool DJDJJCHPPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint EJLNKFBPMJD;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool HDDDLBGCEPF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct KCGMGEHENBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint DGEICNJKJOL;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A543C0", Offset = "0x6A533C0", VA = "0x186A543C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KNHCMHJNGGE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int AOKMKNGFNPG;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct GMJEFLPMBIE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public GCHandle HLNFMMKAIAK;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PKLPPGDMCHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int AOKMKNGFNPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct IGFPLBMHPFG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct CMHNDAEFAJE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int AOKMKNGFNPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KMOEBFOFGLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FODHNCMFFCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MJECPNLBOGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct DHLBEIKAGDA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CollisionDetectionMode KLKDLLPLIJP;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[KJKOJGIDCCF]
public struct KKOHCCBGPON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public HPJFBALBIOJ GGMJBGMLFDN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KKOHCCBGPON BMMJODHNHHN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EABPHDOBONC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BMEHIHKLGJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KNOMDBKHKAD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[InternalBufferCapacity(0)]
public struct FFKOAMIHPHA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity FLFKBMMIINC;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct EIFJJIJBLKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity HHMPHBNGMGF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct KPNOGKPEPBL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct CANBLMBEJLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity FMGEJNFFGHE;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NOONMKOAPGI : IFEHJAGOEKO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EBLIKEEJFDD KJFOPJMOHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(EBLIKEEJFDD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LLIGJIPMLAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 PHFKLNEEBDG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct OJNBPLOHDBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KJKOJGIDCCF]
public struct IBGADMADJMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3x3 EHAKGOGHFPP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IBGADMADJMH BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[KJKOJGIDCCF]
public struct MCPCJJIDLOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 EHAKGOGHFPP;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly MCPCJJIDLOO BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct PLLNHICKKKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3 INNPAJAHMDD;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct NIGNAFFAFJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 AOPAJHLPLFB;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[KJKOJGIDCCF]
public struct KEKLJABBKEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float KHMNNLKLGNK;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly KEKLJABBKEN BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[KJKOJGIDCCF]
public struct LIACBHPDJLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float EKONFELAOEI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly LIACBHPDJLF BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct OMOALAIJIHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float3 DKANNPGKCGK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct HJJGLHGKLBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public JAFDOBAHKIN KMDGACFHLDK;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PDMNGFIDKNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public JAFDOBAHKIN AFJFLMFJAKP;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[CEOJINBDPLN]
public struct GBPHKFBFMIJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity JOAHHHNEJGM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct COBBGDAKBGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PELPKANCDGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct PCKBDBLFMIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public RigidbodyConstraints HBAOCIHDKOO;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[KJKOJGIDCCF]
public struct CODILBHJJFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float KCBCOJGBNPD;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly CODILBHJJFJ BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct PFGAFGMODJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float EKDGABLHIEO;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BAPODPKADOG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct PFGFABFNBIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public object MLBJOODCFMN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public GameObject INALOLPJOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public object KHBLFNBEAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object CAMICLGIMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public PFGFABFNBIC MLBJOODCFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Delegate HNNBFNNHMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate ALEHJFBLFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public GOOAPFACFOD<Delegate> KCMLPHOLHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GOOAPFACFOD<Delegate> AFEONEJDICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public GOOAPFACFOD<Delegate> IDLGEPLNKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public GOOAPFACFOD<Delegate> OJOGIHFFDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public GOOAPFACFOD<Delegate> EAJELPMPEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public GOOAPFACFOD<Delegate> PHOJMLOBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public GOOAPFACFOD<Delegate> JOAJMFLBJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public GOOAPFACFOD<Delegate> GOPBFPAPNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GOOAPFACFOD<Delegate> GEHGBBNKKFA;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A53190", Offset = "0x6A52190", VA = "0x186A53190", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public BAPODPKADOG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct NMJCEDCBGBO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct CIFFFOEGLED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int BMALGHDAPGD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE1FD00", Offset = "0xE1ED00", VA = "0x180E1FD00")]
	public static CIFFFOEGLED CPPJIHNILOM(int CBAEIEAPLIH)
	{
		return default(CIFFFOEGLED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CLFAAGEMJHB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Rigidbody NEPLMIMPLJL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A53880", Offset = "0x6A52880", VA = "0x186A53880", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public CLFAAGEMJHB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct IJHEOPAMFIO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct KIKJFLOBOGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 BEELOOCNBOF;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct JJKMGNLCPCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 EFBILKIFBJD;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[KJKOJGIDCCF]
public struct CGFMECMCNCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float FHIFBAIDGGH;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CGFMECMCNCI BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class LJMBDJIMDIC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public object CFGIGFBHDAP;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A54780", Offset = "0x6A53780", VA = "0x186A54780", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public LJMBDJIMDIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class BIKJPOMELFG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object PLHKDKAHFPP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A53380", Offset = "0x6A52380", VA = "0x186A53380", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public BIKJPOMELFG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct EJGIKKDBPPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct CGPBPOMGLHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IBHKJBLHHKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct GOBONAAAOLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct OHOFKHKDMJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct HDLEPHOOOJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public FixedString32Bytes LCLKDNPLMED;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[CEOJINBDPLN]
public struct KFDAKOIOHOB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity HPPMLCIIGCM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static KFDAKOIOHOB CPPJIHNILOM(Entity CBAEIEAPLIH)
	{
		return default(KFDAKOIOHOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct OMFGLLGHFNL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity JOAHHHNEJGM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static OMFGLLGHFNL CPPJIHNILOM(Entity JOAHHHNEJGM)
	{
		return default(OMFGLLGHFNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct APBICJFLECB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity DJILCHDBGGK;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct DCNEOEGFOMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity DJILCHDBGGK;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal struct BHEFLHELJLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity HGAIFICJLLG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0")]
	public static BHEFLHELJLI CPPJIHNILOM(Entity JOAHHHNEJGM)
	{
		return default(BHEFLHELJLI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct OPLLDGOGNFM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct GJOPPDNAODE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct LOJOJEDBACO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public uint HNNOPDLCPBM;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[CEOJINBDPLN]
internal struct CPBDLOCEDAJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity BFCLHANIGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public int LLPJHIPCNFD;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct DGNAIBIIGBE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity PHPAEBAONCF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct OICMGJDAIJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct OGMLFPBLCHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public uint EJLNKFBPMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KIFHKCDENLN;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xC57490", Offset = "0xC56490", VA = "0x180C57490")]
	public OGMLFPBLCHE(uint HGNFFPJLHFE, int GDNCMEDJCKH)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct PELPANODEIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct DFEPBNBHBIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct NGJCEDICMLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct CGBOGADBDGI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct DKBOOPDMEPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BOFABLFIMDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct FFIDCOHJFKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct BDNFMALKKNO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal struct HHICPCPHADB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct LHCIOKMHHFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct HAGLGKDFNHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct CCJFCPJLBNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct PNBOBKOMECI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal struct AGJMJFGBNND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GFOCFPGBOFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LHHMJKIMPHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MDJIHGPEOEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct DBNPFFGAPIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct MLMPHPECBJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct BMGPDDFILOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct AAOOBAACNDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct ECICOMGGLAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct AOEPBNNEBGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct PPAALHNIIOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct CEENLGLCIGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct LFDBLHAIFFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HDKJGGOHGOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct LNCJAICFLAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[CEOJINBDPLN]
public struct GDCEAOCEDLN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public FixedString32Bytes EGOPOEBLEJP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct GJHEJIFHHGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct NDGCJAPALCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct EMCEAKPKPMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct FDBJMPMBGGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct GFDFLFMHOEA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct MNLPMCJKDEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct DPJBMHLGJNA : IComponentData, IComparable<DPJBMHLGJNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int NDPBFHAJHNJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1A8A980", Offset = "0x1A89980", VA = "0x181A8A980", Slot = "4")]
	public int CompareTo(DPJBMHLGJNA LJAAPFIIPOF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct MLIDFIFMIEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct HLFJPLFMKEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public quaternion ADNGPFKNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 MOIICCIPACK;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct AOGLBLIEHPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float BCALOCJLAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float ACJCLBHFDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float FLFCMDIMHGC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct JJADNBECCAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct ANHALDNKGPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct JDLIPCJAHPI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct NICMBPDNJOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int AOKMKNGFNPG;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[CEOJINBDPLN]
public struct PMNPOFMPINF : ISystemStateBufferElementData, IBufferElementData, IKAFELLNDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity IJGAKAKDEFC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity ENONCDBLDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[KJKOJGIDCCF]
public struct DCCJPKODCLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float4x4 BNPCKFFMPMH;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly DCCJPKODCLP BMMJODHNHHN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct OIEHHFMOCNJ : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct POKEMOIEOJI : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct CODAHDINIIL : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct BMDKEEMFDKP : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[KJKOJGIDCCF]
public struct PDPBDLBJHEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 NBMFEBPFDJH;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly PDPBDLBJHEB BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct DMGNKHHHPGO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int GMBNLMJMNPB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LLPJHIPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A53AD0", Offset = "0x6A52AD0", VA = "0x186A53AD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A53AE0", Offset = "0x6A52AE0", VA = "0x186A53AE0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[KJKOJGIDCCF]
public struct EFGLJCGLDBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 LHMFKCCIJBN;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly EFGLJCGLDBK BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[KJKOJGIDCCF]
public struct NJOEMKLOFOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 MOIICCIPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion ADNGPFKNGFI;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly NJOEMKLOFOL BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class FJPGMONDIAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[KJKOJGIDCCF]
public struct CEKFKGOFEKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float BJMLHKGBKAN;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CEKFKGOFEKG BMMJODHNHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct IFJONBFONKM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity DMIBAMIPIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public LKPJMGKMABK JGHIAOJOLJP;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct CFBLIDCDLHH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LKPJMGKMABK JGHIAOJOLJP;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MCEOPJEHHMA : ISystemStateComponentData, IComponentData, IKAFELLNDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Entity BMDINFODMJG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity ENONCDBLDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GLMCBAKKJNB : ISystemStateBufferElementData, IBufferElementData, IKAFELLNDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity CJLGPJLNIEG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity ENONCDBLDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct HHDNOHGDCIK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity DMIBAMIPIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public LKPJMGKMABK JGHIAOJOLJP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct OKDJOGOLILI : IEqualityComparer<HHDNOHGDCIK>
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static OKDJOGOLILI BMMJODHNHHN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A54CA0", Offset = "0x6A53CA0", VA = "0x186A54CA0", Slot = "4")]
	public bool Equals(HHDNOHGDCIK OOALEDCPNBJ, HHDNOHGDCIK HDFOCKKCOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A54CF0", Offset = "0x6A53CF0", VA = "0x186A54CF0", Slot = "5")]
	public int GetHashCode(HHDNOHGDCIK HBFCGFKGCAF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct NGBMJFOGHMK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public FixedList32Bytes<int> LNFPBHCJGHO;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct MDLBGKFDJJM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> LNFPBHCJGHO;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct EPBHHDAPGEF : ISystemStateBufferElementData, IBufferElementData, IKAFELLNDPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Entity IBCEGIPDOPK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity KDICIHJGNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED0", Offset = "0x8D3ED0", VA = "0x1808D4ED0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE3B9B0", Offset = "0xE3A9B0", VA = "0x180E3B9B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class PKBBNCCABGI : ContainerPropertyBag<BAPODPKADOG>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class MDGIFDFBKHI : Property<BAPODPKADOG, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A54980", Offset = "0x6A53980", VA = "0x186A54980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A54940", Offset = "0x6A53940", VA = "0x186A54940")]
		public MDGIFDFBKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A548F0", Offset = "0x6A538F0", VA = "0x186A548F0", Slot = "14")]
		public override GameObject GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A54910", Offset = "0x6A53910", VA = "0x186A54910", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GameObject CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class BEACCEKBOCJ : Property<BAPODPKADOG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6A53270", Offset = "0x6A52270", VA = "0x186A53270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A53230", Offset = "0x6A52230", VA = "0x186A53230")]
		public BEACCEKBOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A531E0", Offset = "0x6A521E0", VA = "0x186A531E0", Slot = "14")]
		public override object GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A53200", Offset = "0x6A52200", VA = "0x186A53200", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, object CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class KINBPHLMFCF : Property<BAPODPKADOG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6A54610", Offset = "0x6A53610", VA = "0x186A54610", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A545D0", Offset = "0x6A535D0", VA = "0x186A545D0")]
		public KINBPHLMFCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A54580", Offset = "0x6A53580", VA = "0x186A54580", Slot = "14")]
		public override object GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A545A0", Offset = "0x6A535A0", VA = "0x186A545A0", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, object CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class LFEGPDNPEIJ : Property<BAPODPKADOG, BAPODPKADOG.PFGFABFNBIC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6A54710", Offset = "0x6A53710", VA = "0x186A54710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A546D0", Offset = "0x6A536D0", VA = "0x186A546D0")]
		public LFEGPDNPEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A54680", Offset = "0x6A53680", VA = "0x186A54680", Slot = "14")]
		public override BAPODPKADOG.PFGFABFNBIC GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(BAPODPKADOG.PFGFABFNBIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A546A0", Offset = "0x6A536A0", VA = "0x186A546A0", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, BAPODPKADOG.PFGFABFNBIC CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class JANHKIICAEM : Property<BAPODPKADOG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6A541C0", Offset = "0x6A531C0", VA = "0x186A541C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A54180", Offset = "0x6A53180", VA = "0x186A54180")]
		public JANHKIICAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6A54130", Offset = "0x6A53130", VA = "0x186A54130", Slot = "14")]
		public override Delegate GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6A54150", Offset = "0x6A53150", VA = "0x186A54150", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, Delegate CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class HEBDGLGJNBO : Property<BAPODPKADOG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6A53DB0", Offset = "0x6A52DB0", VA = "0x186A53DB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A53D70", Offset = "0x6A52D70", VA = "0x186A53D70")]
		public HEBDGLGJNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A53D20", Offset = "0x6A52D20", VA = "0x186A53D20", Slot = "14")]
		public override Delegate GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A53D40", Offset = "0x6A52D40", VA = "0x186A53D40", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, Delegate CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class JPGHOEHEDII : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6A54390", Offset = "0x6A53390", VA = "0x186A54390", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A54350", Offset = "0x6A53350", VA = "0x186A54350")]
		public JPGHOEHEDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A542E0", Offset = "0x6A532E0", VA = "0x186A542E0", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A54310", Offset = "0x6A53310", VA = "0x186A54310", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class MMIJLIBBMBE : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A54AD0", Offset = "0x6A53AD0", VA = "0x186A54AD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A54A90", Offset = "0x6A53A90", VA = "0x186A54A90")]
		public MMIJLIBBMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A54A20", Offset = "0x6A53A20", VA = "0x186A54A20", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A54A50", Offset = "0x6A53A50", VA = "0x186A54A50", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class CFBBDPDAJJM : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6A53540", Offset = "0x6A52540", VA = "0x186A53540", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A53500", Offset = "0x6A52500", VA = "0x186A53500")]
		public CFBBDPDAJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A53490", Offset = "0x6A52490", VA = "0x186A53490", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A534C0", Offset = "0x6A524C0", VA = "0x186A534C0", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class PKAJKLBPKDM : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6A55020", Offset = "0x6A54020", VA = "0x186A55020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A54FE0", Offset = "0x6A53FE0", VA = "0x186A54FE0")]
		public PKAJKLBPKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A54F60", Offset = "0x6A53F60", VA = "0x186A54F60", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A54FA0", Offset = "0x6A53FA0", VA = "0x186A54FA0", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class DKIPCCKBNJN : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6A53AA0", Offset = "0x6A52AA0", VA = "0x186A53AA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A53A60", Offset = "0x6A52A60", VA = "0x186A53A60")]
		public DKIPCCKBNJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A539E0", Offset = "0x6A529E0", VA = "0x186A539E0", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A53A20", Offset = "0x6A52A20", VA = "0x186A53A20", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class HIGLCGEAAKD : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6A53EA0", Offset = "0x6A52EA0", VA = "0x186A53EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A53E60", Offset = "0x6A52E60", VA = "0x186A53E60")]
		public HIGLCGEAAKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A53DE0", Offset = "0x6A52DE0", VA = "0x186A53DE0", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A53E20", Offset = "0x6A52E20", VA = "0x186A53E20", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class PHEHIKAALHJ : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6A54F30", Offset = "0x6A53F30", VA = "0x186A54F30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A54EF0", Offset = "0x6A53EF0", VA = "0x186A54EF0")]
		public PHEHIKAALHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A54E70", Offset = "0x6A53E70", VA = "0x186A54E70", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A54EB0", Offset = "0x6A53EB0", VA = "0x186A54EB0", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class JILMPNBMNBB : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6A542B0", Offset = "0x6A532B0", VA = "0x186A542B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A54270", Offset = "0x6A53270", VA = "0x186A54270")]
		public JILMPNBMNBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A541F0", Offset = "0x6A531F0", VA = "0x186A541F0", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A54230", Offset = "0x6A53230", VA = "0x186A54230", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class KDKKLBOKNFF : Property<BAPODPKADOG, GOOAPFACFOD<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6A54510", Offset = "0x6A53510", VA = "0x186A54510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A544D0", Offset = "0x6A534D0", VA = "0x186A544D0")]
		public KDKKLBOKNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A54450", Offset = "0x6A53450", VA = "0x186A54450", Slot = "14")]
		public override GOOAPFACFOD<Delegate> GetValue(BAPODPKADOG OMDOLEEBJJJ)
		{
			return default(GOOAPFACFOD<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A54490", Offset = "0x6A53490", VA = "0x186A54490", Slot = "15")]
		public override void SetValue(BAPODPKADOG OMDOLEEBJJJ, GOOAPFACFOD<Delegate> CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A55050", Offset = "0x6A54050", VA = "0x186A55050")]
	public PKBBNCCABGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class ALKCBMPEKII : ContainerPropertyBag<BAPODPKADOG.PFGFABFNBIC>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class MLENNBILPBL : Property<BAPODPKADOG.PFGFABFNBIC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6A549F0", Offset = "0x6A539F0", VA = "0x186A549F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A549B0", Offset = "0x6A539B0", VA = "0x186A549B0")]
		public MLENNBILPBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA1D6E0", Offset = "0xA1C6E0", VA = "0x180A1D6E0", Slot = "14")]
		public override object GetValue(BAPODPKADOG.PFGFABFNBIC OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x47F3D40", Offset = "0x47F2D40", VA = "0x1847F3D40", Slot = "15")]
		public override void SetValue(BAPODPKADOG.PFGFABFNBIC OMDOLEEBJJJ, object CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A530A0", Offset = "0x6A520A0", VA = "0x186A530A0")]
	public ALKCBMPEKII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class IFMAOKOMLAC : ContainerPropertyBag<GOOAPFACFOD<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A540D0", Offset = "0x6A530D0", VA = "0x186A540D0")]
	public IFMAOKOMLAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class HNHIIHBFDIO : ContainerPropertyBag<CLFAAGEMJHB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class OOKCBHKHDPD : Property<CLFAAGEMJHB, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6A54D90", Offset = "0x6A53D90", VA = "0x186A54D90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A54D50", Offset = "0x6A53D50", VA = "0x186A54D50")]
		public OOKCBHKHDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A548F0", Offset = "0x6A538F0", VA = "0x186A548F0", Slot = "14")]
		public override Rigidbody GetValue(CLFAAGEMJHB OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A54910", Offset = "0x6A53910", VA = "0x186A54910", Slot = "15")]
		public override void SetValue(CLFAAGEMJHB OMDOLEEBJJJ, Rigidbody CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A53ED0", Offset = "0x6A52ED0", VA = "0x186A53ED0")]
	public HNHIIHBFDIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class ENCCADJCFLN : ContainerPropertyBag<LJMBDJIMDIC>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class PLIAALNDFMB : Property<LJMBDJIMDIC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A556F0", Offset = "0x6A546F0", VA = "0x186A556F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A556B0", Offset = "0x6A546B0", VA = "0x186A556B0")]
		public PLIAALNDFMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A548F0", Offset = "0x6A538F0", VA = "0x186A548F0", Slot = "14")]
		public override object GetValue(LJMBDJIMDIC OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A54910", Offset = "0x6A53910", VA = "0x186A54910", Slot = "15")]
		public override void SetValue(LJMBDJIMDIC OMDOLEEBJJJ, object CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A53B70", Offset = "0x6A52B70", VA = "0x186A53B70")]
	public ENCCADJCFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class BEODFEGEMKD : ContainerPropertyBag<BIKJPOMELFG>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class NAGPGPNNELG : Property<BIKJPOMELFG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string CDMBLCLEAGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6A54B40", Offset = "0x6A53B40", VA = "0x186A54B40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool FAOLOMOFDJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A54B00", Offset = "0x6A53B00", VA = "0x186A54B00")]
		public NAGPGPNNELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A548F0", Offset = "0x6A538F0", VA = "0x186A548F0", Slot = "14")]
		public override object GetValue(BIKJPOMELFG OMDOLEEBJJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A54910", Offset = "0x6A53910", VA = "0x186A54910", Slot = "15")]
		public override void SetValue(BIKJPOMELFG OMDOLEEBJJJ, object CBAEIEAPLIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A532A0", Offset = "0x6A522A0", VA = "0x186A532A0")]
	public BEODFEGEMKD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A55960", Offset = "0x6A54960", VA = "0x186A55960")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class ECFAFCMGIDH
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public ECFAFCMGIDH()
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecNet;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Keepsakes_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A730", Offset = "0x7B78F30", VA = "0x187B7A730", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FKKKABMEKHA : IComparer<CCAFHCPHPLB>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class AAAMDPEHPIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CCAFHCPHPLB x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public CCAFHCPHPLB y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AAAMDPEHPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCC0800", Offset = "0xCBF000", VA = "0x180CC0800")]
		internal bool HFELFNNPNDM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E45580", Offset = "0x1E43D80", VA = "0x181E45580")]
		internal bool PIIPOEFALEF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCC0800", Offset = "0xCBF000", VA = "0x180CC0800")]
		internal bool ICLOOLPINOJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E45580", Offset = "0x1E43D80", VA = "0x181E45580")]
		internal bool LGBNAGHEEEE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> BLIMKLDBAHF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public FKKKABMEKHA(List<KeepsakeCategoryThemePair> KEDGOPBBJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B78020", Offset = "0x7B76820", VA = "0x187B78020", Slot = "4")]
	public int Compare(CCAFHCPHPLB LEFBJAGNHCD, CCAFHCPHPLB LLGPJHIECFH)
	{
		return default(int);
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public CCAFHCPHPLB KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DBBJMDENMLB]
public class AMJANEFLDEH : BNEMALMGLKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class PCBNBEOPDKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CCAFHCPHPLB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PCBNBEOPDKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7B79E30", Offset = "0x7B78630", VA = "0x187B79E30")]
		internal KJPDFMLMKLI<Guid> GJEANNHKBDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B79DA0", Offset = "0x7B785A0", VA = "0x187B79DA0")]
		internal void COKLMDEEGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B79DD0", Offset = "0x7B785D0", VA = "0x187B79DD0")]
		internal void ENCMOELBFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B79FC0", Offset = "0x7B787C0", VA = "0x187B79FC0")]
		internal void NPFINEGKAAJ(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B79F90", Offset = "0x7B78790", VA = "0x187B79F90")]
		internal void JHLDHIBDCJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MELKDJGOGBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MELKDJGOGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B79080", Offset = "0x7B77880", VA = "0x187B79080")]
		internal void GCNCFJJMFKI(HPAOKCHKDHH response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B79020", Offset = "0x7B77820", VA = "0x187B79020")]
		internal void DFCLOMIBJBL(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AKBLMNEEGAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AKBLMNEEGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B69340", Offset = "0x7B67B40", VA = "0x187B69340")]
		internal bool MNGFFFMEFBO(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HDAKLEMOMHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CCAFHCPHPLB? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HDAKLEMOMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B783F0", Offset = "0x7B76BF0", VA = "0x187B783F0")]
		internal void GCGINPHDDEO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B78780", Offset = "0x7B76F80", VA = "0x187B78780")]
		internal void MJACEPCHEJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B78480", Offset = "0x7B76C80", VA = "0x187B78480")]
		internal KJPDFMLMKLI<IEnumerable<Guid>> KNNBAPDHDMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x769B740", Offset = "0x7699F40", VA = "0x18769B740")]
		internal bool ONOJPKCIKNO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CFFHKBJNLKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HDAKLEMOMHM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CFFHKBJNLKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B774C0", Offset = "0x7B75CC0", VA = "0x187B774C0")]
		internal KJPDFMLMKLI<IEnumerable<Guid>> GLAFIMDOAKO(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FABJLKMPIAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CFFHKBJNLKO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public FABJLKMPIAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B77EF0", Offset = "0x7B766F0", VA = "0x187B77EF0")]
		internal bool EDAPFBOGMIN(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IGCFFLKJICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FABJLKMPIAH CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IGCFFLKJICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B787B0", Offset = "0x7B76FB0", VA = "0x187B787B0")]
		internal bool MLCDDPKHPEB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NNPHGCFKIFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NNPHGCFKIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B79BB0", Offset = "0x7B783B0", VA = "0x187B79BB0")]
		internal KJPDFMLMKLI<IEnumerable<Guid>> GNMFLNNEIAF(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B77AA0", Offset = "0x7B762A0", VA = "0x187B77AA0")]
		internal bool NFFEANCEHJC(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class IJDDHKKDLDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public IJDDHKKDLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B78860", Offset = "0x7B77060", VA = "0x187B78860")]
		internal void DLGGMNOKAJO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B78780", Offset = "0x7B76F80", VA = "0x187B78780")]
		internal void AOAKPBLGEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B788F0", Offset = "0x7B770F0", VA = "0x187B788F0")]
		internal KJPDFMLMKLI<Dictionary<Guid, CCAFHCPHPLB>> JMCBICLEBLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x769B740", Offset = "0x7699F40", VA = "0x18769B740")]
		internal bool DGCLFAEEHCF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MNIDIDJMHPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MNIDIDJMHPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B79430", Offset = "0x7B77C30", VA = "0x187B79430")]
		internal KJPDFMLMKLI<Dictionary<Guid, CCAFHCPHPLB>> AOKLJEAGGIO(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class EMDKAOBADIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EMDKAOBADIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B77E10", Offset = "0x7B76610", VA = "0x187B77E10")]
		internal bool OPPCIMHEDHA(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B77CC0", Offset = "0x7B764C0", VA = "0x187B77CC0")]
		internal KeyValuePair<Guid, CCAFHCPHPLB> NNECOILFFGE(Guid instanceId)
		{
			return default(KeyValuePair<Guid, CCAFHCPHPLB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class JEFAPNPODNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JEFAPNPODNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2485570", Offset = "0x2483D70", VA = "0x182485570")]
		internal bool EFAJKPGELBK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PHFIPMLDAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PHFIPMLDAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2485570", Offset = "0x2483D70", VA = "0x182485570")]
		internal bool ACELLFGCFNO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EGKDLFPPLFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EGKDLFPPLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B77AC0", Offset = "0x7B762C0", VA = "0x187B77AC0")]
		internal KJPDFMLMKLI<Dictionary<Guid, CCAFHCPHPLB>> ILFDPDLNLDF(Dictionary<Guid, CCAFHCPHPLB> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B77AA0", Offset = "0x7B762A0", VA = "0x187B77AA0")]
		internal bool BDNICCLHGJM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class OFBHGGECOEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OFBHGGECOEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B79D20", Offset = "0x7B78520", VA = "0x187B79D20")]
		internal bool BIGOHAPLJPD(KeyValuePair<Guid, CCAFHCPHPLB> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PMPLCCBCNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, CCAFHCPHPLB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PMPLCCBCNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A3D0", Offset = "0x7B78BD0", VA = "0x187B7A3D0")]
		internal KeyValuePair<CCAFHCPHPLB, int> MGFAFKODBCO(CCAFHCPHPLB category)
		{
			return default(KeyValuePair<CCAFHCPHPLB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class MBBCBKKCBOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CCAFHCPHPLB category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MBBCBKKCBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xDB8180", Offset = "0xDB6980", VA = "0x180DB8180")]
		internal bool KCGKKEPILAL(CCAFHCPHPLB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class EAEIENHNDJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, CCAFHCPHPLB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EAEIENHNDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7B77950", Offset = "0x7B76150", VA = "0x187B77950")]
		internal KeyValuePair<CCAFHCPHPLB, int> IKLJGMIGGJI(CCAFHCPHPLB category)
		{
			return default(KeyValuePair<CCAFHCPHPLB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PKNNAGJODPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CCAFHCPHPLB category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PKNNAGJODPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDB8180", Offset = "0xDB6980", VA = "0x180DB8180")]
		internal bool JFLLIHGFKNE(CCAFHCPHPLB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class ANHCPMPHPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ANHCPMPHPEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B772E0", Offset = "0x7B75AE0", VA = "0x187B772E0")]
		internal bool NFFMJOKNFCH(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B773D0", Offset = "0x7B75BD0", VA = "0x187B773D0")]
		internal bool NINJEGJEEOF(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B772C0", Offset = "0x7B75AC0", VA = "0x187B772C0")]
		internal bool LJPJNBLDCNP(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B772C0", Offset = "0x7B75AC0", VA = "0x187B772C0")]
		internal bool PHMCLPNMOLL(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LILFMEMAFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LILFMEMAFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xE2AA10", Offset = "0xE29210", VA = "0x180E2AA10")]
		internal bool AFFMEBLAKEJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class GNGANAHHLNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GNGANAHHLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B78330", Offset = "0x7B76B30", VA = "0x187B78330")]
		internal bool BJJLNDHMMBK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x242D370", Offset = "0x242BB70", VA = "0x18242D370")]
		internal bool LNILFBNCGOH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ANHCAGHOJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public ANHCAGHOJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B77260", Offset = "0x7B75A60", VA = "0x187B77260")]
		internal bool ABHLNCLHMBC(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OEFJODHFMCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OEFJODHFMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xE2AA10", Offset = "0xE29210", VA = "0x180E2AA10")]
		internal bool HPKEJCNNGGK(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DDBEAGKHHPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public DDBEAGKHHPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B77600", Offset = "0x7B75E00", VA = "0x187B77600")]
		internal bool BCDFAAFHBNN(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MALJEBFMLAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CCAFHCPHPLB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MALJEBFMLAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2056010", Offset = "0x2054810", VA = "0x182056010")]
		internal bool LPOBOOFDCDC(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GAFKBPFBNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GAFKBPFBNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B782D0", Offset = "0x7B76AD0", VA = "0x187B782D0")]
		internal bool GFLBKKGDIHN(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NLHFLDMGJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public CCAFHCPHPLB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NLHFLDMGJPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B79B70", Offset = "0x7B78370", VA = "0x187B79B70")]
		internal bool BFLCOGLJODK(KeyValuePair<Guid, CCAFHCPHPLB> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HAFCFPLDMFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public CCAFHCPHPLB newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HAFCFPLDMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2056010", Offset = "0x2054810", VA = "0x182056010")]
		internal bool JEMOBAIBFLP(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LFBMKEMCBKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public LFBMKEMCBKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B78FA0", Offset = "0x7B777A0", VA = "0x187B78FA0")]
		internal bool FJMGNELDPPH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JEECPPCPDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public JEECPPCPDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B78BE0", Offset = "0x7B773E0", VA = "0x187B78BE0")]
		internal bool IOGGOJNPLPC(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class KOFJAKKALFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JEECPPCPDJO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public KOFJAKKALFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B78CD0", Offset = "0x7B774D0", VA = "0x187B78CD0")]
		internal bool GPAOFOGONBI(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NIHEMBGKHJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CCOEKIMEHPP args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B795E0", Offset = "0x7B77DE0", VA = "0x187B795E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B79B10", Offset = "0x7B78310", VA = "0x187B79B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct DHIAFHNHMOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AMJANEFLDEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B77660", Offset = "0x7B75E60", VA = "0x187B77660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B778F0", Offset = "0x7B760F0", VA = "0x187B778F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime OLLKHHDHDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LFKAPAEDBDK CBJGPIJBJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KHPAFCLPOII AAIMKMEIGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly KPACFGMFONP KDEKHJLPEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BNMDPGEMCAO LMGFPKMAFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly BGPDBLKFCBP CDLOFOIHHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GBJPDBLPGFK DECJJILFAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly IKDBLDBFNFM PGELCPLMIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FOAMNLJKJEK HIEPPCLFHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IKIGIOAMAFP IAOMPOAAHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly AMGCJOHDPNP AMOKLMGEKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly PLBGOAOMEFP MCIFHDIDLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly NNIMGBPGDIF CPOJFCFCEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly IOLAPEOHCCL MCDMGKHLNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly FIDPLCEPKNP OGGFBMPBOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly MKCGLADJFFJ MLNADBAMFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly AHPGDOMHCDN<KeepsakesConfig.KeepsakesOptions> AKIEDMONOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly AGPOKEKNOGC HFMDFHLKMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> PPFHKNGHODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> DDOBEHJDIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> FEIOCNCPLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<CCAFHCPHPLB, int> KBNHJNPHNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> DAEHLLIICIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable FCBECFNFJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task GBHEKACHHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KJPDFMLMKLI<Guid> MGEJHHHDGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? DAAMHGMHPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO ADMKCLPNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KJPDFMLMKLI<KeepsakeProgressionEventInstancesDTO> GHIHLNILFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<CCAFHCPHPLB, KeepsakeCategoryConfigDTO> ICNCAHDJGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO NIBLFANCMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> FFIFFKHMNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> BCBPHBKEGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> NAOOIDLNLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> APCABCMCKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> CCOEHJIOKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> EFCBJBMPLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> HMLAPPCLNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> JBLHBBJEMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DFHGMFFENFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> PPPNBGJLIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> IOIEEKDINAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> KAEOBMDOPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime CCKFGOGPJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable LOMJNBCDPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, CCAFHCPHPLB> ADPHCPMOHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<CCAFHCPHPLB, int> PCAEOGFBNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> KEDGOPBBJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FKKKABMEKHA LMEHNAGABIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IEBAFFAJCOD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JOKKBOCFPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A730", VA = "0x180A0BF30", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0BCB0", Offset = "0xA0A4B0", VA = "0x180A0BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PLMIFFBKDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B730E0", Offset = "0x7B718E0", VA = "0x187B730E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HEFGLGGOLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B73500", Offset = "0x7B71D00", VA = "0x187B73500", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long NHANLBKOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B71060", Offset = "0x7B6F860", VA = "0x187B71060")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? GEPOAOBOMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B74FA0", Offset = "0x7B737A0", VA = "0x187B74FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool DFJDMBJMAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B75420", Offset = "0x7B73C20", VA = "0x187B75420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> JIBPBCEDKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA88030", Offset = "0xA86830", VA = "0x180A88030", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> JKAEBEACIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA898F0", Offset = "0xA880F0", VA = "0x180A898F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> IOHLHGFCHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA9DCD0", Offset = "0xA9C4D0", VA = "0x180A9DCD0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> BGBECICAOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA97130", Offset = "0xA95930", VA = "0x180A97130", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool KOKCGOAMHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB59CE0", Offset = "0xB584E0", VA = "0x180B59CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> NLNEGJCOGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B732C0", Offset = "0x7B71AC0", VA = "0x187B732C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B75BE0", Offset = "0x7B743E0", VA = "0x187B75BE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JEENIPIOEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6ABB0", Offset = "0x7B693B0", VA = "0x187B6ABB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B72CA0", Offset = "0x7B714A0", VA = "0x187B72CA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PCCGMJOKNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B759E0", Offset = "0x7B741E0", VA = "0x187B759E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B69F10", Offset = "0x7B68710", VA = "0x187B69F10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B75C90", Offset = "0x7B74490", VA = "0x187B75C90")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AMJANEFLDEH([LDAFGEHKDJK(null)][NotNull] LFKAPAEDBDK CBJGPIJBJDI, [NotNull][LDAFGEHKDJK(null)] KGOPFPAOFEK ILOBEJMDKPD, [NotNull][LDAFGEHKDJK(null)] KHPAFCLPOII AAIMKMEIGCM, [NotNull][LDAFGEHKDJK(null)] KPACFGMFONP KDEKHJLPEGA, [LDAFGEHKDJK(null)][NotNull] BNMDPGEMCAO LMGFPKMAFCO, [LDAFGEHKDJK(null)][NotNull] BGPDBLKFCBP CDLOFOIHHCC, [LDAFGEHKDJK(null)][NotNull] GBJPDBLPGFK DECJJILFAAA, [NotNull][LDAFGEHKDJK(null)] IKDBLDBFNFM PGELCPLMIHC, [NotNull][LDAFGEHKDJK(null)] FOAMNLJKJEK HIEPPCLFHOF, [NotNull][LDAFGEHKDJK(null)] HBFAJGNBGJB IPDHKLAPNML, [NotNull][LDAFGEHKDJK(null)] IKIGIOAMAFP IAOMPOAAHFJ, [NotNull][LDAFGEHKDJK(null)] AMGCJOHDPNP AMOKLMGEKJN, [NotNull][LDAFGEHKDJK(null)] PLBGOAOMEFP MCIFHDIDLCH, [NotNull][LDAFGEHKDJK(null)] NNIMGBPGDIF CPOJFCFCEPM, [LDAFGEHKDJK(null)][NotNull] IOLAPEOHCCL MCDMGKHLNON, [LDAFGEHKDJK(null)][NotNull] FIDPLCEPKNP OGGFBMPBOHL, [NotNull][LDAFGEHKDJK(null)] MKCGLADJFFJ MLNADBAMFHP, [LDAFGEHKDJK(null)][NotNull] AHPGDOMHCDN<KeepsakesConfig.KeepsakesOptions> AKIEDMONOFM, [NotNull][LDAFGEHKDJK(null)] AGPOKEKNOGC HFMDFHLKMEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B70370", Offset = "0x7B6EB70", VA = "0x187B70370", Slot = "15")]
	public bool IBEBJNOMNOI(List<string> BBDAJAICAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E040", Offset = "0x7B6C840", VA = "0x187B6E040", Slot = "16")]
	public KJPDFMLMKLI<Guid> FOHEPPNBCLG(CCAFHCPHPLB AKOLCMIIEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B69C90", Offset = "0x7B68490", VA = "0x187B69C90", Slot = "17")]
	public ELBPMMKABPA BGMELEBMFHB(Guid HNPAEJPLMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B73FB0", Offset = "0x7B727B0", VA = "0x187B73FB0", Slot = "18")]
	public ELBPMMKABPA NBBFGFENLCC(Guid HNPAEJPLMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B72310", Offset = "0x7B70B10", VA = "0x187B72310", Slot = "19")]
	public bool KGKMMBFNHCP(Guid HNPAEJPLMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A7E0", Offset = "0x7B68FE0", VA = "0x187B6A7E0", Slot = "20")]
	public bool CABMIKJHANA(Guid HNPAEJPLMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F780", Offset = "0x7B6DF80", VA = "0x187B6F780")]
	public KeepsakeTheme GNIBIFMLEKM(Guid HNPAEJPLMGK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B6DAF0", Offset = "0x7B6C2F0", VA = "0x187B6DAF0")]
	public bool FAHLNJKNBPH(CCAFHCPHPLB AKOLCMIIEMC, [Out] KeepsakeTheme GAGDHEHKGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FFC0", Offset = "0x7B6E7C0", VA = "0x187B6FFC0")]
	public List<KeepsakeTheme> HMNJFKCJFLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7B75860", Offset = "0x7B74060", VA = "0x187B75860")]
	public int PFECKPCKAAE(CCAFHCPHPLB AKOLCMIIEMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B75A80", Offset = "0x7B74280", VA = "0x187B75A80")]
	public CCAFHCPHPLB PIDCMHHDDDJ(Guid HNPAEJPLMGK)
	{
		return default(CCAFHCPHPLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B69360", Offset = "0x7B67B60", VA = "0x187B69360", Slot = "34")]
	public List<CCAFHCPHPLB> ABNIIAKLBLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7B69BD0", Offset = "0x7B683D0", VA = "0x187B69BD0", Slot = "35")]
	public IComparer<CCAFHCPHPLB> BEJCCBFBFKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B73AB0", Offset = "0x7B722B0", VA = "0x187B73AB0", Slot = "32")]
	public string MLDMDEDGIHB(CCAFHCPHPLB AKOLCMIIEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B6DEC0", Offset = "0x7B6C6C0", VA = "0x187B6DEC0", Slot = "33")]
	public string FLCKBPOANIH(CCAFHCPHPLB AKOLCMIIEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F0F0", Offset = "0x7B6D8F0", VA = "0x187B6F0F0", Slot = "21")]
	public bool GEFIPJAJNFA(Guid HNPAEJPLMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7B75430", Offset = "0x7B73C30", VA = "0x187B75430", Slot = "22")]
	public void PAIHPHNHAPE(Guid HNPAEJPLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B722C0", Offset = "0x7B70AC0", VA = "0x187B722C0", Slot = "23")]
	public void KGEMEMFFNEN(CCAFHCPHPLB AKOLCMIIEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7B69630", Offset = "0x7B67E30", VA = "0x187B69630", Slot = "24")]
	public void AFLKDNJKHDI(Guid HNPAEJPLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7B6B000", Offset = "0x7B69800", VA = "0x187B6B000", Slot = "25")]
	public int DCGDALNALAJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7B70B30", Offset = "0x7B6F330", VA = "0x187B70B30", Slot = "31")]
	public KJPDFMLMKLI<IEnumerable<Guid>> IIPPNPFBGMD(long MDLDCACFGIB, long BOOHEBBJOLC, CCAFHCPHPLB? AKOLCMIIEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7B69A30", Offset = "0x7B68230", VA = "0x187B69A30", Slot = "30")]
	public KJPDFMLMKLI<IEnumerable<Guid>> AMGCKEBCFKJ(long MDLDCACFGIB, long BOOHEBBJOLC, CCAFHCPHPLB? AKOLCMIIEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B71EA0", Offset = "0x7B706A0", VA = "0x187B71EA0", Slot = "54")]
	public KJPDFMLMKLI<Dictionary<Guid, CCAFHCPHPLB>> KFAIIICOKFD(long MDLDCACFGIB, long BOOHEBBJOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B73130", Offset = "0x7B71930", VA = "0x187B73130", Slot = "55")]
	public KJPDFMLMKLI<Dictionary<Guid, CCAFHCPHPLB>> LICANHGHGJI(long MDLDCACFGIB, long BOOHEBBJOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EB70", Offset = "0x7B6D370", VA = "0x187B6EB70", Slot = "26")]
	public KJPDFMLMKLI<int> FPLAHDAMEMD(long MDLDCACFGIB, long BOOHEBBJOLC, CCAFHCPHPLB? AKOLCMIIEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7B74520", Offset = "0x7B72D20", VA = "0x187B74520", Slot = "27")]
	public KJPDFMLMKLI<int> NCJPCECPLMD(long MDLDCACFGIB, long BOOHEBBJOLC, CCAFHCPHPLB? AKOLCMIIEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7B75210", Offset = "0x7B73A10", VA = "0x187B75210", Slot = "28")]
	public KJPDFMLMKLI<Dictionary<CCAFHCPHPLB, int>> ONGAGCDJOCJ(long MDLDCACFGIB, long BOOHEBBJOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7B73C30", Offset = "0x7B72430", VA = "0x187B73C30", Slot = "29")]
	public KJPDFMLMKLI<Dictionary<CCAFHCPHPLB, int>> MMBLGAGCGEP(long MDLDCACFGIB, long BOOHEBBJOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7B735C0", Offset = "0x7B71DC0", VA = "0x187B735C0", Slot = "37")]
	public bool LONBBFLHHJH(long MDLDCACFGIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7B71320", Offset = "0x7B6FB20", VA = "0x187B71320", Slot = "56")]
	public bool JIPFMNGJKFM(long MDLDCACFGIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7B74670", Offset = "0x7B72E70", VA = "0x187B74670", Slot = "38")]
	public bool NDJDKNCBFOA(long MDLDCACFGIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7B6BC80", Offset = "0x7B6A480", VA = "0x187B6BC80", Slot = "57")]
	public bool DGMHHPPGNMH(long MDLDCACFGIB, [Out] HKCLMJONLNA HNDPGHDJPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7B698F0", Offset = "0x7B680F0", VA = "0x187B698F0", Slot = "39")]
	public bool ALIEFONLIIE(long IGGBKAEOJGI, [Out] DateTime ECKALDCGCPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B71960", Offset = "0x7B70160", VA = "0x187B71960", Slot = "40")]
	public long JPFFKAJJPAB(long IGGBKAEOJGI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FAF0", Offset = "0x7B6E2F0", VA = "0x187B6FAF0", Slot = "41")]
	public long HGJJIBHDEFE(long MDLDCACFGIB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7B75030", Offset = "0x7B73830", VA = "0x187B75030", Slot = "42")]
	public int OLOHENMEFCP(long IGGBKAEOJGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7B70A50", Offset = "0x7B6F250", VA = "0x187B70A50", Slot = "43")]
	public bool IFHHECCBFBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7B73370", Offset = "0x7B71B70", VA = "0x187B73370", Slot = "44")]
	public bool LLOFLANPFOF(long IGGBKAEOJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B755F0", Offset = "0x7B73DF0", VA = "0x187B755F0", Slot = "45")]
	public IReadOnlyList<long> PDLDKNGMCJH(long IGGBKAEOJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7B70EE0", Offset = "0x7B6F6E0", VA = "0x187B70EE0", Slot = "46")]
	public int IJPIEAIIGON(long IGGBKAEOJGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7B70790", Offset = "0x7B6EF90", VA = "0x187B70790", Slot = "50")]
	public long ICOAMAKIEDN(long MAGJEOKDHGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7B74B10", Offset = "0x7B73310", VA = "0x187B74B10", Slot = "51")]
	public CCAFHCPHPLB OFLPOKJJGND()
	{
		return default(CCAFHCPHPLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7B74E70", Offset = "0x7B73670", VA = "0x187B74E70")]
	private bool OIBPKOOOOHG(Guid HNPAEJPLMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7B72580", Offset = "0x7B70D80", VA = "0x187B72580")]
	private void KNMFGOOIDKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F380", Offset = "0x7B6DB80", VA = "0x187B6F380")]
	private CCAFHCPHPLB GEIIMINAIOE()
	{
		return default(CCAFHCPHPLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7B6B620", Offset = "0x7B69E20", VA = "0x187B6B620")]
	private void DENEJJMEDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7B6DCD0", Offset = "0x7B6C4D0", VA = "0x187B6DCD0")]
	private int FBHKOPAJKCO(KeepsakeRoomListDTO OLOIOFAFAPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7B6AA80", Offset = "0x7B69280", VA = "0x187B6AA80")]
	private int CDFIJEOFOCO(DateTime AOGIAKOFPPL, DateTime KDFGEOHBKLE, TimeSpan DDGKIDJPMEM, int GDPDGIEHMEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EE70", Offset = "0x7B6D670", VA = "0x187B6EE70")]
	private void GANBNAANMFE(IEnumerable<KeepsakeInstanceDTO> PPFHKNGHODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7B747A0", Offset = "0x7B72FA0", VA = "0x187B747A0")]
	private void NPLNHIHMBMF(IEnumerable<KeepsakeCollectionRecordDTO> EHMKPDBKKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7B69890", Offset = "0x7B68090", VA = "0x187B69890")]
	private void AKMPPEAPHDD(IEnumerable<long> DIKPMEONOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAB7A10", Offset = "0xAB6210", VA = "0x180AB7A10")]
	private void LIEDHAKCEEB(KeepsakeGlobalConfigDTO NIBLFANCMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7B72A40", Offset = "0x7B71240", VA = "0x187B72A40")]
	private bool KPOFKLFKGBB(CCAFHCPHPLB AKOLCMIIEMC, [Out] Guid OMDLHOCPOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7B6C1F0", Offset = "0x7B6A9F0", VA = "0x187B6C1F0")]
	private bool DOIGCOCEIFH([Out] Guid OMDLHOCPOHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B6EE10", Offset = "0x7B6D610", VA = "0x187B6EE10")]
	private bool GACJFKFFBAH(Guid HNPAEJPLMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7B754A0", Offset = "0x7B73CA0", VA = "0x187B754A0")]
	private IEnumerable<Guid> PDCOKOLCNPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B73EF0", Offset = "0x7B726F0", VA = "0x187B73EF0")]
	private IEnumerable<KeepsakeInstanceDTO> NAHKKCPMHAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B74710", Offset = "0x7B72F10", VA = "0x187B74710")]
	private void NODMLMOFIJL(Guid HNPAEJPLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F650", Offset = "0x7B6DE50", VA = "0x187B6F650")]
	private bool GGBLLOCKPJD(Guid HNPAEJPLMGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A640", Offset = "0x7B68E40", VA = "0x187B6A640")]
	private void BPAFILBIOEJ(Guid HNPAEJPLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B6C710", Offset = "0x7B6AF10", VA = "0x187B6C710")]
	private void EEHHBLEOHNA(CCAFHCPHPLB NACCBIPFJIO, int EMPGFEAJPDD, Dictionary<CCAFHCPHPLB, int> AEFIBAGLPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B69FB0", Offset = "0x7B687B0", VA = "0x187B69FB0")]
	private int BJOEJFAKHHB(CCAFHCPHPLB AKOLCMIIEMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B73620", Offset = "0x7B71E20", VA = "0x187B73620")]
	private void LPGKOEBLIOM(KeepsakeInstanceDTO EIKNNILJBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F8E0", Offset = "0x7B6E0E0", VA = "0x187B6F8E0")]
	private void HDBFFPGOIJJ(KeepsakeInstanceDTO EIKNNILJBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7B6D6C0", Offset = "0x7B6BEC0", VA = "0x187B6D6C0")]
	private void EMMCCLPEONJ(Guid HNPAEJPLMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B6AB80", Offset = "0x7B69380", VA = "0x187B6AB80")]
	private void HMDKPILGIED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B69870", Offset = "0x7B68070", VA = "0x187B69870")]
	private void AIOHIPGKAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7B72250", Offset = "0x7B70A50", VA = "0x187B72250")]
	private void KFOKPOFAEMN(DEALDLCNIEC PDKLKKAPOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7B6AB80", Offset = "0x7B69380", VA = "0x187B6AB80")]
	private void CFJPLLGIOLC(KFLCGBIEDHD PNHCNFOFAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7B6AB80", Offset = "0x7B69380", VA = "0x187B6AB80")]
	private void HFHHKPKJPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B72D40", Offset = "0x7B71540", VA = "0x187B72D40")]
	private void LGHOODMCFMF(float HAGKKHCGGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A0A0", Offset = "0x7B688A0", VA = "0x187B6A0A0")]
	private void BLEFMCPOIEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B6B420", Offset = "0x7B69C20", VA = "0x187B6B420")]
	private bool DEDMGONGBGO(Guid HNPAEJPLMGK, [Out] string HHGEFJCJOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FC60", Offset = "0x7B6E460", VA = "0x187B6FC60")]
	private bool HHNONICOLBN(Guid HNPAEJPLMGK, [Out] KeepsakeCategoryConfigDTO NACCBIPFJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B71130", Offset = "0x7B6F930", VA = "0x187B71130")]
	private void JHKNMKPHFED(string ANNJHMKGNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B71210", Offset = "0x7B6FA10", VA = "0x187B71210")]
	private bool JIPEEOGIOAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B737F0", Offset = "0x7B71FF0", VA = "0x187B737F0")]
	private List<long> MFNBNIJJMAG(IEnumerable<KeepsakeRoomDTO> DMPDKJDIEMI, IReadOnlyList<KeepsakeRoomListDTO> HDDPIJOOOIC, long IGGBKAEOJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7B6E650", Offset = "0x7B6CE50", VA = "0x187B6E650")]
	private bool FPGODAHCPAJ(Guid HNPAEJPLMGK, [Out] string LKNKJJBHDKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7B6DA90", Offset = "0x7B6C290", VA = "0x187B6DA90", Slot = "47")]
	public string ENGPKFBPJON(JEDMBLJKFJC JEGIOIIBLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7B71380", Offset = "0x7B6FB80", VA = "0x187B71380", Slot = "49")]
	public string JMLPJDMNLON(JEDMBLJKFJC JEGIOIIBLHA, long MDLDCACFGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B73E20", Offset = "0x7B72620", VA = "0x187B73E20", Slot = "48")]
	public string MOPEGJGDKND(JEDMBLJKFJC JEGIOIIBLHA, int BBPHNLHGLLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B6C7F0", Offset = "0x7B6AFF0", VA = "0x187B6C7F0")]
	private void EKPLHPOLPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B70600", Offset = "0x7B6EE00", VA = "0x187B70600")]
	private void ICADMKMOJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7B6BC60", Offset = "0x7B6A460", VA = "0x187B6BC60")]
	private JEDMBLJKFJC DFMAFLEIAIK(OOCKLLBKMIG GFLMEDCKLGN)
	{
		return default(JEDMBLJKFJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FE30", Offset = "0x7B6E630", VA = "0x187B6FE30")]
	private JEDMBLJKFJC HIJNDMPOBCG(OOCKLLBKMIG GFLMEDCKLGN)
	{
		return default(JEDMBLJKFJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B74340", Offset = "0x7B72B40", VA = "0x187B74340")]
	internal static string NBBJLCHKHOE(HPAOKCHKDHH DIHOEBLBNKE, string MCJPNFIPFIP, bool NLDEJKPPNNL, int ICODNCCBJPP, int JALKEMGLLDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B6C290", Offset = "0x7B6AA90", VA = "0x187B6C290", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F700", Offset = "0x7B6DF00", VA = "0x187B6F700")]
	private MJOPCCNIMCA GLIHHIOONIO(GFEBJDBBDID KLBOJNFLPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B6C030", Offset = "0x7B6A830", VA = "0x187B6C030")]
	private KOLLEJKBENP DGOGHFJKEID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7B6AC50", Offset = "0x7B69450", VA = "0x187B6AC50")]
	private Task CPJIHLDJFIF(CCOEKIMEHPP FHMAIKMLNLH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B72470", Offset = "0x7B70C70", VA = "0x187B72470")]
	[AsyncStateMachine(typeof(NIHEMBGKHJN))]
	private Task KMCDCJLANNL(CCOEKIMEHPP FHMAIKMLNLH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7B70F90", Offset = "0x7B6F790", VA = "0x187B70F90")]
	private Task INJJBGLANFC(CCOEKIMEHPP FHMAIKMLNLH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7B73CF0", Offset = "0x7B724F0", VA = "0x187B73CF0")]
	[AsyncStateMachine(typeof(DHIAFHNHMOJ))]
	private Task MNECMLPEFNF(string NJAAPDELBNN, TimeSpan JFNCDOKKMIN, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B6C6F0", Offset = "0x7B6AEF0", VA = "0x187B6C6F0")]
	[CompilerGenerated]
	private void EDEJOIGDDHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B6DE70", Offset = "0x7B6C670", VA = "0x187B6DE70")]
	[CompilerGenerated]
	private void FEPAJOFDLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A810", Offset = "0x7B69010", VA = "0x187B6A810")]
	[CompilerGenerated]
	private bool CCCANHOKGAG(KeepsakeInstanceDTO LEFBJAGNHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B6A910", Offset = "0x7B69110", VA = "0x187B6A910")]
	[CompilerGenerated]
	private KJPDFMLMKLI<Dictionary<CCAFHCPHPLB, int>> CCMENOOEJBM(Dictionary<Guid, CCAFHCPHPLB> LJLEIAJHLBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FE50", Offset = "0x7B6E650", VA = "0x187B6FE50")]
	[CompilerGenerated]
	private KJPDFMLMKLI<Dictionary<CCAFHCPHPLB, int>> HLGIDLBFFCA(Dictionary<Guid, CCAFHCPHPLB> LJLEIAJHLBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B6F8C0", Offset = "0x7B6E0C0", VA = "0x187B6F8C0")]
	[CompilerGenerated]
	private bool HCKNKOGAFEP(KeepsakeRoomListDTO LEFBJAGNHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B749E0", Offset = "0x7B731E0", VA = "0x187B749E0")]
	[CompilerGenerated]
	private bool OBPJNBAEHBD(KeepsakeInstanceDTO LEFBJAGNHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B694A0", Offset = "0x7B67CA0", VA = "0x187B694A0")]
	[CompilerGenerated]
	private void ACKNFPPMDHC(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<CCAFHCPHPLB, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> FNEFJGHGJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FC00", Offset = "0x7B6E400", VA = "0x187B6FC00")]
	[CompilerGenerated]
	private void HHJMGMCNPJB(string LKNKJJBHDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7B717A0", Offset = "0x7B6FFA0", VA = "0x187B717A0")]
	[CompilerGenerated]
	private Task JNNFGACOENO(CancellationToken JAKHDJMDFOD)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, AHPGDOMHCDN<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class BALMEONGGHC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
				public BALMEONGGHC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7B77490", Offset = "0x7B75C90", VA = "0x187B77490")]
				internal bool KOHHEMDAMHP(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7B77490", Offset = "0x7B75C90", VA = "0x187B77490")]
				internal bool LKFLAFGNFOM(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7B78DD0", Offset = "0x7B775D0", VA = "0x187B78DD0")]
			public bool AFLLDGCJFIJ(string EMEKLPBAJBE, [Out] KeepsakeTheme GAGDHEHKGAG)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B78D50", Offset = "0x7B77550", VA = "0x187B78D50")]
		[PJMOOJOMMCC.OJAOBFKEEAO.IHGAJDILMAJ]
		internal static void JMICLABLGOM(HHDGAAFLDEF PMKEELMHMLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
		public KeepsakesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AssetReference PickupPrefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float LoopingSfxVolume;
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

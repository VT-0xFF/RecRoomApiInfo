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
		[Cpp2IlInjected.Address(RVA = "0x7864B60", Offset = "0x7863F60", VA = "0x187864B60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IKJGIFEKJMM : IComparer<DCINACICPGL>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class PPDJOMGFBED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DCINACICPGL x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public DCINACICPGL y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PPDJOMGFBED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC3BB30", Offset = "0xC3AF30", VA = "0x180C3BB30")]
		internal bool GGFAJLHGJFM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D46A00", Offset = "0x1D45E00", VA = "0x181D46A00")]
		internal bool BCNCJIAPOAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC3BB30", Offset = "0xC3AF30", VA = "0x180C3BB30")]
		internal bool MBGGMOPEILP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D46A00", Offset = "0x1D45E00", VA = "0x181D46A00")]
		internal bool OJCBEPAKAMI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> AFAFGANHAHO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public IKJGIFEKJMM(List<KeepsakeCategoryThemePair> NNMFFJDLCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7862F70", Offset = "0x7862370", VA = "0x187862F70", Slot = "4")]
	public int Compare(DCINACICPGL JFJPEDLJOKC, DCINACICPGL MJINJIJLGDP)
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
		public DCINACICPGL KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NGHELBGCMPC]
public class EGJFPLHCBGD : KDNDLFGGOLF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GIPHOLNLKMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public EGJFPLHCBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public DCINACICPGL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GIPHOLNLKMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7862170", Offset = "0x7861570", VA = "0x187862170")]
		internal COLCOEKKCIF<Guid> CCFFPKOMMNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7862710", Offset = "0x7861B10", VA = "0x187862710")]
		internal void KLJCNOIKJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7862740", Offset = "0x7861B40", VA = "0x187862740")]
		internal void MKEJAEGHCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78622D0", Offset = "0x78616D0", VA = "0x1878622D0")]
		internal void EMGMHHNPPIN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x78626E0", Offset = "0x7861AE0", VA = "0x1878626E0")]
		internal void FHOJFDDPDLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OADNLOPFGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EGJFPLHCBGD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OADNLOPFGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x78640C0", Offset = "0x78634C0", VA = "0x1878640C0")]
		internal void KOCOGFBAALK(HAOLBLIKBLM response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7864470", Offset = "0x7863870", VA = "0x187864470")]
		internal void PJFKBHMAABN(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class EBMNCKFDKNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public EBMNCKFDKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7853E00", Offset = "0x7853200", VA = "0x187853E00")]
		internal bool AFEGCOMHEPM(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FPEHJCCENIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EGJFPLHCBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DCINACICPGL? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FPEHJCCENIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x78620E0", Offset = "0x78614E0", VA = "0x1878620E0")]
		internal void PKJJAGKPKGN(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7861DB0", Offset = "0x78611B0", VA = "0x187861DB0")]
		internal void FPNEFMEDKHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7861DE0", Offset = "0x78611E0", VA = "0x187861DE0")]
		internal COLCOEKKCIF<IEnumerable<Guid>> JFGGDOOCCCN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73D6960", Offset = "0x73D5D60", VA = "0x1873D6960")]
		internal bool FJBLPOPGEBF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IFBCLCIKHEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FPEHJCCENIC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IFBCLCIKHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7862DA0", Offset = "0x78621A0", VA = "0x187862DA0")]
		internal COLCOEKKCIF<IEnumerable<Guid>> GBKLHPDJCIO(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CBJEGCBKDDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IFBCLCIKHEF CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CBJEGCBKDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7853820", Offset = "0x7852C20", VA = "0x187853820")]
		internal bool GAPHHMBHEHI(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MMLPIEEEEJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CBJEGCBKDDE CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MMLPIEEEEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7863A80", Offset = "0x7862E80", VA = "0x187863A80")]
		internal bool FLCHENPKFBG(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MEDMNKFAKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EGJFPLHCBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MEDMNKFAKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7863910", Offset = "0x7862D10", VA = "0x187863910")]
		internal COLCOEKKCIF<IEnumerable<Guid>> DMNHNHAHCJF(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7853DE0", Offset = "0x78531E0", VA = "0x187853DE0")]
		internal bool JJKPOGJHKKG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PLJKEPNPPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EGJFPLHCBGD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PLJKEPNPPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x78648C0", Offset = "0x7863CC0", VA = "0x1878648C0")]
		internal void PLAIFNMOODP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7861DB0", Offset = "0x78611B0", VA = "0x187861DB0")]
		internal void HCDIACAKDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x78645D0", Offset = "0x78639D0", VA = "0x1878645D0")]
		internal COLCOEKKCIF<Dictionary<Guid, DCINACICPGL>> CKIEKHDFNMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x73D6960", Offset = "0x73D5D60", VA = "0x1873D6960")]
		internal bool JAODLIMNMCA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class MDIBOMBBEMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MDIBOMBBEMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7863760", Offset = "0x7862B60", VA = "0x187863760")]
		internal COLCOEKKCIF<Dictionary<Guid, DCINACICPGL>> MBFCLIEMGAF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LHPEBIMLKPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LHPEBIMLKPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x78634F0", Offset = "0x78628F0", VA = "0x1878634F0")]
		internal bool LHNANEJCAGD(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x78635D0", Offset = "0x78629D0", VA = "0x1878635D0")]
		internal KeyValuePair<Guid, DCINACICPGL> NAICFJAEHBE(Guid instanceId)
		{
			return default(KeyValuePair<Guid, DCINACICPGL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PGLEDJOKPIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PGLEDJOKPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x235A9D0", Offset = "0x2359DD0", VA = "0x18235A9D0")]
		internal bool LNAFFLOAJLI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PCAHBKEEPGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PCAHBKEEPGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x235A9D0", Offset = "0x2359DD0", VA = "0x18235A9D0")]
		internal bool IPMMPHCBBOA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DJHLNOJMOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public EGJFPLHCBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DJHLNOJMOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7853BE0", Offset = "0x7852FE0", VA = "0x187853BE0")]
		internal COLCOEKKCIF<Dictionary<Guid, DCINACICPGL>> HPCHEANOKPO(Dictionary<Guid, DCINACICPGL> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7853DE0", Offset = "0x78531E0", VA = "0x187853DE0")]
		internal bool KNGCHMHHJKM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PBKIGLPPNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PBKIGLPPNKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x78644D0", Offset = "0x78638D0", VA = "0x1878644D0")]
		internal bool KFJAPPFGJJC(KeyValuePair<Guid, DCINACICPGL> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GLAONAIHGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, DCINACICPGL> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GLAONAIHGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x78627A0", Offset = "0x7861BA0", VA = "0x1878627A0")]
		internal KeyValuePair<DCINACICPGL, int> NIMELKBBPMJ(DCINACICPGL category)
		{
			return default(KeyValuePair<DCINACICPGL, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GODBEHNJOLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DCINACICPGL category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GODBEHNJOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xD34F40", Offset = "0xD34340", VA = "0x180D34F40")]
		internal bool MDOGPNOBKCF(DCINACICPGL instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GPJCIOEGBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, DCINACICPGL> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GPJCIOEGBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x78628F0", Offset = "0x7861CF0", VA = "0x1878628F0")]
		internal KeyValuePair<DCINACICPGL, int> DDNJGNHDDLN(DCINACICPGL category)
		{
			return default(KeyValuePair<DCINACICPGL, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GHMOLJNHMAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DCINACICPGL category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GHMOLJNHMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD34F40", Offset = "0xD34340", VA = "0x180D34F40")]
		internal bool PJFGKJOGDJL(DCINACICPGL instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class CEDDJILGPAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public EGJFPLHCBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CEDDJILGPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7853AF0", Offset = "0x7852EF0", VA = "0x187853AF0")]
		internal bool JCOJMMAACDL(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7853A10", Offset = "0x7852E10", VA = "0x187853A10")]
		internal bool BEHGFNPJAAB(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7853AD0", Offset = "0x7852ED0", VA = "0x187853AD0")]
		internal bool JFPBCIMAGIN(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7853AD0", Offset = "0x7852ED0", VA = "0x187853AD0")]
		internal bool FAADEICDNMP(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FPODIIEPJED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FPODIIEPJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD94850", Offset = "0xD93C50", VA = "0x180D94850")]
		internal bool MCKKGFKAJOP(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CDHFBFAGNPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CDHFBFAGNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7853950", Offset = "0x7852D50", VA = "0x187853950")]
		internal bool BADNPELBIBG(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x231D090", Offset = "0x231C490", VA = "0x18231D090")]
		internal bool BKNFIODJDAF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HMLPFHEJMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public HMLPFHEJMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7862D40", Offset = "0x7862140", VA = "0x187862D40")]
		internal bool KHHKHHOHLEN(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JKGEMIPOANN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JKGEMIPOANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xD94850", Offset = "0xD93C50", VA = "0x180D94850")]
		internal bool AFCGCIMNHCI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IGENDNBEKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IGENDNBEKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7862EE0", Offset = "0x78622E0", VA = "0x187862EE0")]
		internal bool LHMIJMDPLLJ(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CGMHHFBOGDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DCINACICPGL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public CGMHHFBOGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F5D330", Offset = "0x1F5C730", VA = "0x181F5D330")]
		internal bool DHOGJMKJMFH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class FABGLCNNAMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FABGLCNNAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7861D50", Offset = "0x7861150", VA = "0x187861D50")]
		internal bool LFMNINCDLBI(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LNBBKLFAAMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DCINACICPGL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LNBBKLFAAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7863720", Offset = "0x7862B20", VA = "0x187863720")]
		internal bool KOPLOAKGGKM(KeyValuePair<Guid, DCINACICPGL> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FIPNAAJCMAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DCINACICPGL newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FIPNAAJCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1F5D330", Offset = "0x1F5C730", VA = "0x181F5D330")]
		internal bool IBDMKDNJGKH(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PBLOIAPKACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public PBLOIAPKACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7864550", Offset = "0x7863950", VA = "0x187864550")]
		internal bool MBLIIFEAIKN(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class AIDNEILNAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AIDNEILNAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7853730", Offset = "0x7852B30", VA = "0x187853730")]
		internal bool ABOKDNDPNGB(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JLPECJADEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AIDNEILNAEM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JLPECJADEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7863220", Offset = "0x7862620", VA = "0x187863220")]
		internal bool FAOEILAGIHJ(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NOJJKHEPKKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EGJFPLHCBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public CFLKKNKAIAK args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7863B30", Offset = "0x7862F30", VA = "0x187863B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7864060", Offset = "0x7863460", VA = "0x187864060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct HAJKMCIJNIG : IAsyncStateMachine
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
		public EGJFPLHCBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7862A40", Offset = "0x7861E40", VA = "0x187862A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7862CE0", Offset = "0x78620E0", VA = "0x187862CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime CIAEBECKCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NLHFEIEIHEO HEPNNPCGNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CNNOGMLOBAI ACHKKLKEKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly IFNKKMINNAC LKDCBJNGBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NFCLFNNJNGI GKKLACKILJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LHLINMOGEBD NNEBHMDLFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BPEHLOPPADN MCNLAJPOFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly DADHEHMMNDP JGEMNCIHBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly OAHJJJNDMGJ AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly LOJECIKAFKG JOALDEHKOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ONIKGHDKAOK KDEHOIALNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GCELNKFLECM LAJEGIAELAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ABHODGNCBEB PCEIOHFAAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly OKCPJJMIFAC KHMELAKOBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IGDAEPKKAEE MIDGFJPNLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly FEHNCHIDFDG EJEHNGBDFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NCMCMNCIACO<KeepsakesConfig.KeepsakesOptions> PJIJGMDDLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly KIKFEAEKMGH GOOAHAMPCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> PHLJHKHOOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> JEJEPEOGIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> OHLFCJNMLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<DCINACICPGL, int> GLLIKJPDPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> EBNBBDLMNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable OAACKKKAPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task ADEPNFBBBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private COLCOEKKCIF<Guid> IKFDMFDBJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? GECAPFNCOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO MMAMENHKMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private COLCOEKKCIF<KeepsakeProgressionEventInstancesDTO> EEJPKJDKEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<DCINACICPGL, KeepsakeCategoryConfigDTO> ECMKKNIOJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO ONMPCDNCGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> CEADGFGLNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> LPONKCKPGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> EKCNHLCNAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> LBCIFCHMPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> ANNBIPDICIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> PHHFHDEGDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> NNJCBIBEBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> CIMGEMJHFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GENMJDMEEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> DFKMLAOHCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> HGHIBAHLNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> LGPIPELHHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime OOIIGCCEGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable JLHNCJLKEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, DCINACICPGL> ENGMOOCPGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<DCINACICPGL, int> IDBLOIBOGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> NNMFFJDLCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IKJGIFEKJMM GHIIHLOIFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool NKPJGJAKLBG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NKAMEJGOOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE580", VA = "0x1809BF180", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9BEF00", Offset = "0x9BE300", VA = "0x1809BEF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LKKAKDFBMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x785B7A0", Offset = "0x785ABA0", VA = "0x18785B7A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JHFNNGNFEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7859B50", Offset = "0x7858F50", VA = "0x187859B50", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long CNACEPCNPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x785C290", Offset = "0x785B690", VA = "0x18785C290")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? HPILEOPCKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x785CA70", Offset = "0x785BE70", VA = "0x18785CA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool CPEBPCKFBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x785AC60", Offset = "0x785A060", VA = "0x18785AC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> AEJGAEMFGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA08D60", Offset = "0xA08160", VA = "0x180A08D60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> INNBLPCKKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA0DCC0", Offset = "0xA0D0C0", VA = "0x180A0DCC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> GGMIGDMELLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA17790", Offset = "0xA16B90", VA = "0x180A17790", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> GAHJJBEPFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA09250", Offset = "0xA08650", VA = "0x180A09250", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool DJNKNANMIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD18E0", Offset = "0xAD0CE0", VA = "0x180AD18E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> NNFEGECMACH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x785CDA0", Offset = "0x785C1A0", VA = "0x18785CDA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x785EAD0", Offset = "0x785DED0", VA = "0x18785EAD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JGCAKEDIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78586E0", Offset = "0x7857AE0", VA = "0x1878586E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x785CE50", Offset = "0x785C250", VA = "0x18785CE50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MDCOJJDCOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7858390", Offset = "0x7857790", VA = "0x187858390", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78556E0", Offset = "0x7854AE0", VA = "0x1878556E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7860780", Offset = "0x785FB80", VA = "0x187860780")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EGJFPLHCBGD([GKAMHFFOHNI(null)][NotNull] NLHFEIEIHEO HEPNNPCGNGJ, [NotNull][GKAMHFFOHNI(null)] AHFKEHIEJLO CDJLLPGBCKE, [NotNull][GKAMHFFOHNI(null)] CNNOGMLOBAI ACHKKLKEKMF, [NotNull][GKAMHFFOHNI(null)] IFNKKMINNAC LKDCBJNGBKC, [GKAMHFFOHNI(null)][NotNull] NFCLFNNJNGI GKKLACKILJN, [GKAMHFFOHNI(null)][NotNull] LHLINMOGEBD NNEBHMDLFHI, [GKAMHFFOHNI(null)][NotNull] BPEHLOPPADN MCNLAJPOFNG, [NotNull][GKAMHFFOHNI(null)] DADHEHMMNDP JGEMNCIHBBD, [NotNull][GKAMHFFOHNI(null)] OAHJJJNDMGJ AAHFLKJGFKB, [NotNull][GKAMHFFOHNI(null)] DFDDELLLAHL HGJNLEJNNKG, [NotNull][GKAMHFFOHNI(null)] LOJECIKAFKG JOALDEHKOIL, [NotNull][GKAMHFFOHNI(null)] ONIKGHDKAOK KDEHOIALNGB, [NotNull][GKAMHFFOHNI(null)] GCELNKFLECM LAJEGIAELAD, [NotNull][GKAMHFFOHNI(null)] ABHODGNCBEB PCEIOHFAAEF, [GKAMHFFOHNI(null)][NotNull] OKCPJJMIFAC KHMELAKOBLE, [GKAMHFFOHNI(null)][NotNull] IGDAEPKKAEE MIDGFJPNLLC, [NotNull][GKAMHFFOHNI(null)] FEHNCHIDFDG EJEHNGBDFNJ, [GKAMHFFOHNI(null)][NotNull] NCMCMNCIACO<KeepsakesConfig.KeepsakesOptions> PJIJGMDDLKH, [NotNull][GKAMHFFOHNI(null)] KIKFEAEKMGH GOOAHAMPCLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x785D050", Offset = "0x785C450", VA = "0x18785D050", Slot = "15")]
	public bool LBIMGGNDECE(List<string> BGEFNCCJFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7857C60", Offset = "0x7857060", VA = "0x187857C60", Slot = "16")]
	public COLCOEKKCIF<Guid> EJNCOFAMGED(DCINACICPGL CKJNDFNDNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7858430", Offset = "0x7857830", VA = "0x187858430", Slot = "17")]
	public KMDOHMPCNFD EMGNMIIBODB(Guid NLMCBFMCBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78593A0", Offset = "0x78587A0", VA = "0x1878593A0", Slot = "18")]
	public KMDOHMPCNFD GDBENKJHHHO(Guid NLMCBFMCBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x785CEF0", Offset = "0x785C2F0", VA = "0x18785CEF0", Slot = "19")]
	public bool KPEPIAPPDFM(Guid NLMCBFMCBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x78586B0", Offset = "0x7857AB0", VA = "0x1878586B0", Slot = "20")]
	public bool EOLKJAEKHNC(Guid NLMCBFMCBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78566D0", Offset = "0x7855AD0", VA = "0x1878566D0")]
	public KeepsakeTheme CJAPNNBEKHP(Guid NLMCBFMCBDO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x785FEA0", Offset = "0x785F2A0", VA = "0x18785FEA0")]
	public bool PFGDBBJPNEL(DCINACICPGL CKJNDFNDNFA, [Out] KeepsakeTheme MGKNNLLAILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7855E50", Offset = "0x7855250", VA = "0x187855E50")]
	public List<KeepsakeTheme> BLIPOCHLNPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7855560", Offset = "0x7854960", VA = "0x187855560")]
	public int AOIFFEIAKKM(DCINACICPGL CKJNDFNDNFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x785BF50", Offset = "0x785B350", VA = "0x18785BF50")]
	public DCINACICPGL IPGPAENEFLK(Guid NLMCBFMCBDO)
	{
		return default(DCINACICPGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7856AA0", Offset = "0x7855EA0", VA = "0x187856AA0", Slot = "34")]
	public List<DCINACICPGL> DHICLNLHLLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7859EE0", Offset = "0x78592E0", VA = "0x187859EE0", Slot = "35")]
	public IComparer<DCINACICPGL> GNDGOLCNLAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x785C0B0", Offset = "0x785B4B0", VA = "0x18785C0B0", Slot = "32")]
	public string JAKJLPHKOEJ(DCINACICPGL CKJNDFNDNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x785E680", Offset = "0x785DA80", VA = "0x18785E680", Slot = "33")]
	public string NCFKLBPAMKP(DCINACICPGL CKJNDFNDNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x785FC10", Offset = "0x785F010", VA = "0x18785FC10", Slot = "21")]
	public bool PCBEBMDBIFE(Guid NLMCBFMCBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x785CD30", Offset = "0x785C130", VA = "0x18785CD30", Slot = "22")]
	public void KJAGGKKNBGN(Guid NLMCBFMCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x785CA20", Offset = "0x785BE20", VA = "0x18785CA20", Slot = "23")]
	public void JHMLKGCHFCF(DCINACICPGL CKJNDFNDNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7853E20", Offset = "0x7853220", VA = "0x187853E20", Slot = "24")]
	public void ACDPNMCBPGL(Guid NLMCBFMCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7856DC0", Offset = "0x78561C0", VA = "0x187856DC0", Slot = "25")]
	public int DOFDOPMKNOM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7854100", Offset = "0x7853500", VA = "0x187854100", Slot = "31")]
	public COLCOEKKCIF<IEnumerable<Guid>> ADOJCEEMFNC(long CCHPCHDJHAI, long NHAMNJIOEHA, DCINACICPGL? CKJNDFNDNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x785D5E0", Offset = "0x785C9E0", VA = "0x18785D5E0", Slot = "30")]
	public COLCOEKKCIF<IEnumerable<Guid>> LGCGDBAINDF(long CCHPCHDJHAI, long NHAMNJIOEHA, DCINACICPGL? CKJNDFNDNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x785F7E0", Offset = "0x785EBE0", VA = "0x18785F7E0", Slot = "54")]
	public COLCOEKKCIF<Dictionary<Guid, DCINACICPGL>> OLDFOHFLAAH(long CCHPCHDJHAI, long NHAMNJIOEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x785F650", Offset = "0x785EA50", VA = "0x18785F650", Slot = "55")]
	public COLCOEKKCIF<Dictionary<Guid, DCINACICPGL>> OJPIHHOCCLN(long CCHPCHDJHAI, long NHAMNJIOEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x785B4F0", Offset = "0x785A8F0", VA = "0x18785B4F0", Slot = "26")]
	public COLCOEKKCIF<int> IMHGHDJMGEB(long CCHPCHDJHAI, long NHAMNJIOEHA, DCINACICPGL? CKJNDFNDNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7856950", Offset = "0x7855D50", VA = "0x187856950", Slot = "27")]
	public COLCOEKKCIF<int> CPHEJIEFLNO(long CCHPCHDJHAI, long NHAMNJIOEHA, DCINACICPGL? CKJNDFNDNFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x785E020", Offset = "0x785D420", VA = "0x18785E020", Slot = "28")]
	public COLCOEKKCIF<Dictionary<DCINACICPGL, int>> MFOGKKHIDCH(long CCHPCHDJHAI, long NHAMNJIOEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7859D80", Offset = "0x7859180", VA = "0x187859D80", Slot = "29")]
	public COLCOEKKCIF<Dictionary<DCINACICPGL, int>> GJDJJCDIKFD(long CCHPCHDJHAI, long NHAMNJIOEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x785FB90", Offset = "0x785EF90", VA = "0x18785FB90", Slot = "37")]
	public bool OLMPNPLFPEK(long CCHPCHDJHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7856200", Offset = "0x7855600", VA = "0x187856200", Slot = "56")]
	public bool CALDHMHLJLE(long CCHPCHDJHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7854060", Offset = "0x7853460", VA = "0x187854060", Slot = "38")]
	public bool ADEJHGFCONP(long CCHPCHDJHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x785BBA0", Offset = "0x785AFA0", VA = "0x18785BBA0", Slot = "57")]
	public bool IPCKPAJMFIK(long CCHPCHDJHAI, [Out] OCANBJBGDDG ALIJPKMLBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7856810", Offset = "0x7855C10", VA = "0x187856810", Slot = "39")]
	public bool CJPJIOAKPKP(long LCLELDKEEFP, [Out] DateTime EKGDDADFFAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7857720", Offset = "0x7856B20", VA = "0x187857720", Slot = "40")]
	public long EHCMGNGEHHK(long LCLELDKEEFP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x785C820", Offset = "0x785BC20", VA = "0x18785C820", Slot = "41")]
	public long JFOKMEAFGLK(long CCHPCHDJHAI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x785DE40", Offset = "0x785D240", VA = "0x18785DE40", Slot = "42")]
	public int MAFAFGHKIBJ(long LCLELDKEEFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x785F110", Offset = "0x785E510", VA = "0x18785F110", Slot = "43")]
	public bool NMBHCFHBBIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7856540", Offset = "0x7855940", VA = "0x187856540", Slot = "44")]
	public bool CDIDLCDNIKB(long LCLELDKEEFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7860080", Offset = "0x785F480", VA = "0x187860080", Slot = "45")]
	public IReadOnlyList<long> PKFBMABEHMI(long LCLELDKEEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x785E990", Offset = "0x785DD90", VA = "0x18785E990", Slot = "46")]
	public int NFHDABDCEHI(long LCLELDKEEFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x785B230", Offset = "0x785A630", VA = "0x18785B230", Slot = "50")]
	public long IMCPDPGEIII(long KFJFDEFBJII)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7860420", Offset = "0x785F820", VA = "0x187860420", Slot = "51")]
	public DCINACICPGL POAAPJCEDOD()
	{
		return default(DCINACICPGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x78602F0", Offset = "0x785F6F0", VA = "0x1878602F0")]
	private bool PNEGFHFKGBF(Guid NLMCBFMCBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x785C360", Offset = "0x785B760", VA = "0x18785C360")]
	private void JFGDEKLAMFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x785D2E0", Offset = "0x785C6E0", VA = "0x18785D2E0")]
	private DCINACICPGL LCLLMOKEJED()
	{
		return default(DCINACICPGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x785A620", Offset = "0x7859A20", VA = "0x18785A620")]
	private void HHAGFLEDKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x785E230", Offset = "0x785D630", VA = "0x18785E230")]
	private int MFOMIOCEAGD(KeepsakeRoomListDTO LHAHAFPNLDG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7858FC0", Offset = "0x78583C0", VA = "0x187858FC0")]
	private int FNBOCFAKLDA(DateTime ELPCELIHFIO, DateTime GNGGKHKKGMK, TimeSpan FNMCCIAFNNE, int EJCHFGJLPMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x78590C0", Offset = "0x78584C0", VA = "0x1878590C0")]
	private void FPPOGINJFMN(IEnumerable<KeepsakeInstanceDTO> PHLJHKHOOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7859730", Offset = "0x7858B30", VA = "0x187859730")]
	private void GEOPMMAOIDC(IEnumerable<KeepsakeCollectionRecordDTO> EKMJIEBBDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x785B1D0", Offset = "0x785A5D0", VA = "0x18785B1D0")]
	private void ILIOLBNOCML(IEnumerable<long> PAFNDKCBMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA2B890", Offset = "0xA2AC90", VA = "0x180A2B890")]
	private void LAILEODPGKB(KeepsakeGlobalConfigDTO ONMPCDNCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x785AF70", Offset = "0x785A370", VA = "0x18785AF70")]
	private bool IJCNMAECEML(DCINACICPGL CKJNDFNDNFA, [Out] Guid KPODNBENHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7859E40", Offset = "0x7859240", VA = "0x187859E40")]
	private bool GMOMAPKPFLN([Out] Guid KPODNBENHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x785C230", Offset = "0x785B630", VA = "0x18785C230")]
	private bool JALKJJIBJCF(Guid NLMCBFMCBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7858890", Offset = "0x7857C90", VA = "0x187858890")]
	private IEnumerable<Guid> FGKJDJMKLEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7856D00", Offset = "0x7856100", VA = "0x187856D00")]
	private IEnumerable<KeepsakeInstanceDTO> DMHMPAFHJGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x785EA40", Offset = "0x785DE40", VA = "0x18785EA40")]
	private void NHCPFPHGNMD(Guid NLMCBFMCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x785E5D0", Offset = "0x785D9D0", VA = "0x18785E5D0")]
	private bool NBMBGDPKMJN(Guid NLMCBFMCBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x785DCA0", Offset = "0x785D0A0", VA = "0x18785DCA0")]
	private void LJFNPAHGPEE(Guid NLMCBFMCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7857640", Offset = "0x7856A40", VA = "0x187857640")]
	private void EFMPHBMCPDJ(DCINACICPGL LPMLMMNKNGK, int BDHIDLAFBMN, Dictionary<DCINACICPGL, int> BCEPFEFPFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x785F320", Offset = "0x785E720", VA = "0x18785F320")]
	private int OBFFELDCLOP(DCINACICPGL CKJNDFNDNFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7855C80", Offset = "0x7855080", VA = "0x187855C80")]
	private void BKMGCFKNAAE(KeepsakeInstanceDTO JGJIKJKDOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x785ACF0", Offset = "0x785A0F0", VA = "0x18785ACF0")]
	private void IEJPIEAFLCH(KeepsakeInstanceDTO JGJIKJKDOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x78558B0", Offset = "0x7854CB0", VA = "0x1878558B0")]
	private void BKHFNACALEH(Guid NLMCBFMCBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x785D5B0", Offset = "0x785C9B0", VA = "0x18785D5B0")]
	private void PJMCBAMHHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7856520", Offset = "0x7855920", VA = "0x187856520")]
	private void CCNHPKICJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x785AF00", Offset = "0x785A300", VA = "0x18785AF00")]
	private void IEONPBHFGHP(KDMPGIPNGGP IHPBFDHNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x785D5B0", Offset = "0x785C9B0", VA = "0x18785D5B0")]
	private void LDEDLOOGFCB(KCELDHEAJMO HAPOBHMBDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x785D5B0", Offset = "0x785C9B0", VA = "0x18785D5B0")]
	private void PJHCHOIPEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x785EBE0", Offset = "0x785DFE0", VA = "0x18785EBE0")]
	private void NJLBJLOHMMC(float OKHHGFLPPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x785A080", Offset = "0x7859480", VA = "0x18785A080")]
	private void HEGNBBJLNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x785E3D0", Offset = "0x785D7D0", VA = "0x18785E3D0")]
	private bool MLBNHFPOEHL(Guid NLMCBFMCBDO, [Out] string KPDCJBCBHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x785CB60", Offset = "0x785BF60", VA = "0x18785CB60")]
	private bool KFMEHLLLBKI(Guid NLMCBFMCBDO, [Out] KeepsakeCategoryConfigDTO LPMLMMNKNGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7859FA0", Offset = "0x78593A0", VA = "0x187859FA0")]
	private void HDOIOGOLDDE(string BKEFPCBELPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7858780", Offset = "0x7857B80", VA = "0x187858780")]
	private bool FDLCELBBCFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7856260", Offset = "0x7855660", VA = "0x187856260")]
	private List<long> CCJHBHKHMNO(IEnumerable<KeepsakeRoomDTO> MPDNPBKIFFF, IReadOnlyList<KeepsakeRoomListDTO> MAJKPJJJHML, long LCLELDKEEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x785D780", Offset = "0x785CB80", VA = "0x18785D780")]
	private bool LGFCMPHJPHM(Guid NLMCBFMCBDO, [Out] string DFEFGBECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x785EB80", Offset = "0x785DF80", VA = "0x18785EB80", Slot = "47")]
	public string NHHGBAMLEFH(ODNCOMOCGAM CIMNIEMAOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x78589E0", Offset = "0x7857DE0", VA = "0x1878589E0", Slot = "49")]
	public string FKFPFCHDLOC(ODNCOMOCGAM CIMNIEMAOBI, long CCHPCHDJHAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x785F410", Offset = "0x785E810", VA = "0x18785F410", Slot = "48")]
	public string OGGAMEGPANA(ODNCOMOCGAM CIMNIEMAOBI, int NHAEEKCODMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7854690", Offset = "0x7853A90", VA = "0x187854690")]
	private void ALKNALMNDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x785E800", Offset = "0x785DC00", VA = "0x18785E800")]
	private void NDBLIGBKBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x785CA00", Offset = "0x785BE00", VA = "0x18785CA00")]
	private ODNCOMOCGAM JGOCJCAGKEC(FOEPCPJDPOJ HPJIMPHJDLJ)
	{
		return default(ODNCOMOCGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x785FBF0", Offset = "0x785EFF0", VA = "0x18785FBF0")]
	private ODNCOMOCGAM OPFGMGJDEMG(FOEPCPJDPOJ HPJIMPHJDLJ)
	{
		return default(ODNCOMOCGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78544B0", Offset = "0x78538B0", VA = "0x1878544B0")]
	internal static string AHNLNLIIFGJ(HAOLBLIKBLM FOICCHKEEHL, string KLGKKJHCIBN, bool LJBNNMCIPME, int EOOENEMGDGD, int LCDBMNHKECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x78571E0", Offset = "0x78565E0", VA = "0x1878571E0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x785AC70", Offset = "0x785A070", VA = "0x18785AC70")]
	private BAOOEPCCKJO HPJMIKOEDLB(FEIKLGLBIHI CPHNKAKPMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7858E00", Offset = "0x7858200", VA = "0x187858E00")]
	private PNCKNIPBJFF FLPIOBHICOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x785B7F0", Offset = "0x785ABF0", VA = "0x18785B7F0")]
	private Task IODOBFGMOKM(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7858280", Offset = "0x7857680", VA = "0x187858280")]
	[AsyncStateMachine(typeof(NOJJKHEPKKC))]
	private Task EJOLPGLLPMM(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x785C930", Offset = "0x785BD30", VA = "0x18785C930")]
	private Task JGADIAPKGKD(CFLKKNKAIAK JOIGLCNPHIH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7855780", Offset = "0x7854B80", VA = "0x187855780")]
	[AsyncStateMachine(typeof(HAJKMCIJNIG))]
	private Task APNCFLOGMLD(string EIGJGBPHOMK, TimeSpan IDGKPKMIEGL, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7856BE0", Offset = "0x7855FE0", VA = "0x187856BE0")]
	[CompilerGenerated]
	private void DIMCEHOLPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7859350", Offset = "0x7858750", VA = "0x187859350")]
	[CompilerGenerated]
	private void GAEKONKKHID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7856C00", Offset = "0x7856000", VA = "0x187856C00")]
	[CompilerGenerated]
	private bool DIOPBKBALOC(KeepsakeInstanceDTO JFJPEDLJOKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x785F4E0", Offset = "0x785E8E0", VA = "0x18785F4E0")]
	[CompilerGenerated]
	private COLCOEKKCIF<Dictionary<DCINACICPGL, int>> OHIJEAHAPLJ(Dictionary<Guid, DCINACICPGL> ONOJBOKEHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7859C10", Offset = "0x7859010", VA = "0x187859C10")]
	[CompilerGenerated]
	private COLCOEKKCIF<Dictionary<DCINACICPGL, int>> GJCGIBCNHDK(Dictionary<Guid, DCINACICPGL> ONOJBOKEHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7859970", Offset = "0x7858D70", VA = "0x187859970")]
	[CompilerGenerated]
	private bool GFHACIELFLG(KeepsakeRoomListDTO JFJPEDLJOKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x785F1F0", Offset = "0x785E5F0", VA = "0x18785F1F0")]
	[CompilerGenerated]
	private bool NPPLIIFKAJH(KeepsakeInstanceDTO JFJPEDLJOKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x785EF80", Offset = "0x785E380", VA = "0x18785EF80")]
	[CompilerGenerated]
	private void NKHENIJFOIO(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DCINACICPGL, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> FINCDPABCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x785CB00", Offset = "0x785BF00", VA = "0x18785CB00")]
	[CompilerGenerated]
	private void JNLGGNODHKP(string DFEFGBECJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7859990", Offset = "0x7858D90", VA = "0x187859990")]
	[CompilerGenerated]
	private Task GGPIIFLJNNB(CancellationToken DLIKNDGPJOK)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, NCMCMNCIACO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class IGNOLAIDCIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
				public IGNOLAIDCIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7862F40", Offset = "0x7862340", VA = "0x187862F40")]
				internal bool BGGCINJCLLC(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7862F40", Offset = "0x7862340", VA = "0x187862F40")]
				internal bool MBCLGNENNGO(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7863320", Offset = "0x7862720", VA = "0x187863320")]
			public bool EIJOMCCPKPG(string ANCMFJLFCNG, [Out] KeepsakeTheme MGKNNLLAILM)
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x78632A0", Offset = "0x78626A0", VA = "0x1878632A0")]
		[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
		internal static void KDIILJNJDKF(NPIEGGOELNH PHDMEDCBLHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAF7D80", Offset = "0xAF7180", VA = "0x180AF7D80")]
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

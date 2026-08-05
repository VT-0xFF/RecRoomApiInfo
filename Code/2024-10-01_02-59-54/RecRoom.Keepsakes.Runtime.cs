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
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E29830", Offset = "0x6E28C30", VA = "0x186E29830", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GCNEMDFMBFH : IComparer<DMDJAJBNJFC>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class PKCLAMGOCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DMDJAJBNJFC x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public DMDJAJBNJFC y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PKCLAMGOCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x12AD860", Offset = "0x12ACC60", VA = "0x1812AD860")]
		internal bool KLOPIKAEAJP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x17F9A20", Offset = "0x17F8E20", VA = "0x1817F9A20")]
		internal bool LMNJNEIOAAE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x12AD860", Offset = "0x12ACC60", VA = "0x1812AD860")]
		internal bool DGMPHCEBKMH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x17F9A20", Offset = "0x17F8E20", VA = "0x1817F9A20")]
		internal bool CHJGKOKDDBG(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> DDCLOKDIKMO;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
	public GCNEMDFMBFH(List<KeepsakeCategoryThemePair> JJLFFIDNLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A140", Offset = "0x6E19540", VA = "0x186E1A140", Slot = "4")]
	public int Compare(DMDJAJBNJFC CFANGCOBGCF, DMDJAJBNJFC HHLCHNICLGA)
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
		public DMDJAJBNJFC KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NFAHBLEIIKC]
public class OPIODDGNBJB : HEKDBGJIEOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class CAAGBJLOJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public OPIODDGNBJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public DMDJAJBNJFC keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CAAGBJLOJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E187E0", Offset = "0x6E17BE0", VA = "0x186E187E0")]
		internal MIJNEIJMPHL<Guid> IKMKLFOPGDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E18940", Offset = "0x6E17D40", VA = "0x186E18940")]
		internal void KKDNJLDJIPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E18970", Offset = "0x6E17D70", VA = "0x186E18970")]
		internal void LJNIPDDBMAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E189D0", Offset = "0x6E17DD0", VA = "0x186E189D0")]
		internal void MBGPELMNNJO(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E187B0", Offset = "0x6E17BB0", VA = "0x186E187B0")]
		internal void BMCLIJCLPIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class CPCJNMHDHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public OPIODDGNBJB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CPCJNMHDHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E18EC0", Offset = "0x6E182C0", VA = "0x186E18EC0")]
		internal void KEPEPBOHAIM(AHEMLIMIJMA response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E18E60", Offset = "0x6E18260", VA = "0x186E18E60")]
		internal void GDAJEGPHLLC(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class HGFDIDBBGGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HGFDIDBBGGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AB30", Offset = "0x6E19F30", VA = "0x186E1AB30")]
		internal bool HPPCLJBOOBA(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HBIIGGBCCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public OPIODDGNBJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public DMDJAJBNJFC? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HBIIGGBCCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AAA0", Offset = "0x6E19EA0", VA = "0x186E1AAA0")]
		internal void MFDALFMMDLJ(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A770", Offset = "0x6E19B70", VA = "0x186E1A770")]
		internal void AHJPJECGEMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A7A0", Offset = "0x6E19BA0", VA = "0x186E1A7A0")]
		internal MIJNEIJMPHL<IEnumerable<Guid>> CCBJKINDICC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C700", Offset = "0x6A6BB00", VA = "0x186A6C700")]
		internal bool HCEHHHKBFNA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class AEMGIELLIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public HBIIGGBCCED CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AEMGIELLIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E18540", Offset = "0x6E17940", VA = "0x186E18540")]
		internal MIJNEIJMPHL<IEnumerable<Guid>> IGFDCFOCMNJ(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BFEHLCNGHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AEMGIELLIJK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BFEHLCNGHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E18680", Offset = "0x6E17A80", VA = "0x186E18680")]
		internal bool ONNJIOEABOP(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class ODCFNJKGGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BFEHLCNGHNC CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ODCFNJKGGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B3F0", Offset = "0x6E1A7F0", VA = "0x186E1B3F0")]
		internal bool HINGNLHEFDA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class DDNNLJHNNDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public OPIODDGNBJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DDNNLJHNNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E19290", Offset = "0x6E18690", VA = "0x186E19290")]
		internal MIJNEIJMPHL<IEnumerable<Guid>> MCCFGPLEMAE(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E19270", Offset = "0x6E18670", VA = "0x186E19270")]
		internal bool JPBLCDIDEGM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PPHCKPLNIPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OPIODDGNBJB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PPHCKPLNIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E29590", Offset = "0x6E28990", VA = "0x186E29590")]
		internal void NANAHIBJOAA(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A770", Offset = "0x6E19B70", VA = "0x186E1A770")]
		internal void ACMPOHDGLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E292A0", Offset = "0x6E286A0", VA = "0x186E292A0")]
		internal MIJNEIJMPHL<Dictionary<Guid, DMDJAJBNJFC>> KEKMFOCPBOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A6C700", Offset = "0x6A6BB00", VA = "0x186A6C700")]
		internal bool KOBEFHHJKBO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class JHCNNFKOBBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JHCNNFKOBBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AED0", Offset = "0x6E1A2D0", VA = "0x186E1AED0")]
		internal MIJNEIJMPHL<Dictionary<Guid, DMDJAJBNJFC>> GBMCEGJLPBP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class FFMLBJLNGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FFMLBJLNGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A060", Offset = "0x6E19460", VA = "0x186E1A060")]
		internal bool CLOPGMGMMPL(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E19F10", Offset = "0x6E19310", VA = "0x186E19F10")]
		internal KeyValuePair<Guid, DMDJAJBNJFC> CEHJBAMJLLP(Guid instanceId)
		{
			return default(KeyValuePair<Guid, DMDJAJBNJFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FELJOMHOGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FELJOMHOGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D6D270", Offset = "0x1D6C670", VA = "0x181D6D270")]
		internal bool DNMLCKBHAJD(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PDPCBKLDJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PDPCBKLDJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1D6D270", Offset = "0x1D6C670", VA = "0x181D6D270")]
		internal bool BJGDJDNFOJI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DGFOPKIIMJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public OPIODDGNBJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DGFOPKIIMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E19430", Offset = "0x6E18830", VA = "0x186E19430")]
		internal MIJNEIJMPHL<Dictionary<Guid, DMDJAJBNJFC>> MBFIDJBAKAF(Dictionary<Guid, DMDJAJBNJFC> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E19270", Offset = "0x6E18670", VA = "0x186E19270")]
		internal bool HMBIMMGCHKD(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HPBBMDODHNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HPBBMDODHNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AB50", Offset = "0x6E19F50", VA = "0x186E1AB50")]
		internal bool CALNJHFECIM(KeyValuePair<Guid, DMDJAJBNJFC> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HPFBGAKEGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, DMDJAJBNJFC> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HPFBGAKEGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E1ABD0", Offset = "0x6E19FD0", VA = "0x186E1ABD0")]
		internal KeyValuePair<DMDJAJBNJFC, int> PHEDFAELEML(DMDJAJBNJFC category)
		{
			return default(KeyValuePair<DMDJAJBNJFC, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class NGKOIPKHLDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public DMDJAJBNJFC category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public NGKOIPKHLDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x981850", Offset = "0x980C50", VA = "0x180981850")]
		internal bool EDIBHDMJBEJ(DMDJAJBNJFC instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GHIMAEOKHLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, DMDJAJBNJFC> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GHIMAEOKHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A3F0", Offset = "0x6E197F0", VA = "0x186E1A3F0")]
		internal KeyValuePair<DMDJAJBNJFC, int> JHEJINKFOFC(DMDJAJBNJFC category)
		{
			return default(KeyValuePair<DMDJAJBNJFC, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GIOOJHALLMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public DMDJAJBNJFC category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GIOOJHALLMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x981850", Offset = "0x980C50", VA = "0x180981850")]
		internal bool DGAIBBABCLN(DMDJAJBNJFC instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class HAIENOEGLNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public OPIODDGNBJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HAIENOEGLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A680", Offset = "0x6E19A80", VA = "0x186E1A680")]
		internal bool IFDDOBLBEPB(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A5C0", Offset = "0x6E199C0", VA = "0x186E1A5C0")]
		internal bool HMCGAJMMPOE(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A5A0", Offset = "0x6E199A0", VA = "0x186E1A5A0")]
		internal bool BIFJMBDPGFB(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A5A0", Offset = "0x6E199A0", VA = "0x186E1A5A0")]
		internal bool KBEAFHFFAFC(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LGECLLPLMEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LGECLLPLMEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6C0", Offset = "0x9DEAC0", VA = "0x1809DF6C0")]
		internal bool GDGNFLPNOAB(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class JAPFLBBHHNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JAPFLBBHHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AD20", Offset = "0x6E1A120", VA = "0x186E1AD20")]
		internal bool CKHOMOBDJDA(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D32EB0", Offset = "0x1D322B0", VA = "0x181D32EB0")]
		internal bool GNMPHIFCENN(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GMHIDDLCEDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GMHIDDLCEDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A540", Offset = "0x6E19940", VA = "0x186E1A540")]
		internal bool COHOFCDCLLG(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FLNLFOCNIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public FLNLFOCNIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DF6C0", Offset = "0x9DEAC0", VA = "0x1809DF6C0")]
		internal bool CDIPOPNHPOK(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DOAHDLAGIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DOAHDLAGIAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E19630", Offset = "0x6E18A30", VA = "0x186E19630")]
		internal bool EMJPPPMGOFB(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GCAOOLIPAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public DMDJAJBNJFC keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GCAOOLIPAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x19FC860", Offset = "0x19FBC60", VA = "0x1819FC860")]
		internal bool IJJAKDELBGP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MMMLFICGJIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public MMMLFICGJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B390", Offset = "0x6E1A790", VA = "0x186E1B390")]
		internal bool HNHLNPGOGCK(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KMJEGJHANDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public DMDJAJBNJFC keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public KMJEGJHANDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B080", Offset = "0x6E1A480", VA = "0x186E1B080")]
		internal bool EMBJJCPDKFF(KeyValuePair<Guid, DMDJAJBNJFC> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OPFDKGCAEBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DMDJAJBNJFC newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OPFDKGCAEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x19FC860", Offset = "0x19FBC60", VA = "0x1819FC860")]
		internal bool PFCLONGJKLB(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class COPENBNIJEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public COPENBNIJEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E18DE0", Offset = "0x6E181E0", VA = "0x186E18DE0")]
		internal bool HMEHDODEJBC(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class JBCJGIHAIID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JBCJGIHAIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1ADE0", Offset = "0x6E1A1E0", VA = "0x186E1ADE0")]
		internal bool FGDNEFCHNPA(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MHCODMHCGBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JBCJGIHAIID CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public MHCODMHCGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B310", Offset = "0x6E1A710", VA = "0x186E1B310")]
		internal bool APIKCGCCCLD(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ECIKCNFFEFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public OPIODDGNBJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public PHNAGDHGBII args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E19980", Offset = "0x6E18D80", VA = "0x186E19980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E19EB0", Offset = "0x6E192B0", VA = "0x186E19EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EBKDNPJGMCI : IAsyncStateMachine
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
		public OPIODDGNBJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6E19690", Offset = "0x6E18A90", VA = "0x186E19690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6E19920", Offset = "0x6E18D20", VA = "0x186E19920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime JBBMACEEPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JHPEONEDLKB CIJJDKHHIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly BKGMLANMKKJ CIHECJALOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CLGAKFPCELG CEKFNNPKCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PGLIOGICKCC MOFDPPFIJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly FNHHMHANIPH NOGMIFBJMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly ALJHLBPNHAA DLDOODICMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly EPAOBPAKFLI MFEJFFLILMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ECJBOAIKALM GLAAFJDOHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MPEAJOEKBGL ACJHPCHLKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ODMHLMFNPCA MJOHBDFGFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly KNJPBACPBML EKGJNJOPIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EGFJPDLGFEJ GHOPOPKJDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HBDEKGAEIBN CENPMCEONAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly GIOKMGGDKEO AOFEGGBHDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GOLAIFJFJFA DPKKJKPNDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly INMOCPMHGNM<KeepsakesConfig.KeepsakesOptions> AHOANCKGKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly CCENJGFOMNL LJNLIKDCHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> EJBNPPDHLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> NJBHIPMPEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> DOKIGMEPJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<DMDJAJBNJFC, int> JCKLFHLAMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> EEEHANFBLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable DEEJJCBDJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task NFHLKNBEEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private MIJNEIJMPHL<Guid> CDFHFJNJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? HPEGGPCCJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO KEKLJICECKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MIJNEIJMPHL<KeepsakeProgressionEventInstancesDTO> NBCKAIPMGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<DMDJAJBNJFC, KeepsakeCategoryConfigDTO> LEMMKHHEJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO ICACJGKELEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> CIBBFDFJANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> JCGAINOCLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> AMBJJIMGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> ABAGKECCDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> ONCKEMGAEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> LKEAFFAEPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> KIHKPEMGMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> GDACENDEECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> CAAFBCKHKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LDFIBJGBPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> GHILEPDPHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> FGJHHPFPDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime LOKKECFKOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable IIMJNFMMAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, DMDJAJBNJFC> MJGDDBDHIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<DMDJAJBNJFC, int> GBEJJHGOKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> JJLFFIDNLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GCNEMDFMBFH IKDKJGDKDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool BOOMPHJMFCC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AGBJOMJNFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x927B80", Offset = "0x926F80", VA = "0x180927B80", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9229F0", Offset = "0x921DF0", VA = "0x1809229F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ALBDIPECHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6E26AF0", Offset = "0x6E25EF0", VA = "0x186E26AF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LDKDAAPKNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F520", Offset = "0x6E1E920", VA = "0x186E1F520", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long HINHDMJBGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E26070", Offset = "0x6E25470", VA = "0x186E26070")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? AHPKDKHACNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C0E0", Offset = "0x6E1B4E0", VA = "0x186E1C0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool LCHADFKMDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E20100", Offset = "0x6E1F500", VA = "0x186E20100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> LAFEOALCKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x906470", Offset = "0x905870", VA = "0x180906470", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> IMPNHAFOPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA34E50", Offset = "0xA34250", VA = "0x180A34E50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> JDHDAPGKLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA31A80", Offset = "0xA30E80", VA = "0x180A31A80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> FMDBMAEFIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95E9E0", Offset = "0x95DDE0", VA = "0x18095E9E0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool OCHFLINNCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1C94A80", Offset = "0x1C93E80", VA = "0x181C94A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> CMKILLEDIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1FB10", Offset = "0x6E1EF10", VA = "0x186E1FB10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C170", Offset = "0x6E1B570", VA = "0x186E1C170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IKDJCCOIKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E26140", Offset = "0x6E25540", VA = "0x186E26140", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E20FE0", Offset = "0x6E203E0", VA = "0x186E20FE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PIIKHACEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1FD60", Offset = "0x6E1F160", VA = "0x186E1FD60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E21D80", Offset = "0x6E21180", VA = "0x186E21D80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E27D20", Offset = "0x6E27120", VA = "0x186E27D20")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OPIODDGNBJB([ACGOIOBGIEE(null)][NotNull] JHPEONEDLKB CIJJDKHHIKG, [NotNull][ACGOIOBGIEE(null)] PEJPIEIGDPD LCHBCDLFDJO, [NotNull][ACGOIOBGIEE(null)] BKGMLANMKKJ CIHECJALOMC, [NotNull][ACGOIOBGIEE(null)] CLGAKFPCELG CEKFNNPKCCP, [ACGOIOBGIEE(null)][NotNull] PGLIOGICKCC MOFDPPFIJKJ, [ACGOIOBGIEE(null)][NotNull] FNHHMHANIPH NOGMIFBJMHC, [ACGOIOBGIEE(null)][NotNull] ALJHLBPNHAA DLDOODICMEC, [NotNull][ACGOIOBGIEE(null)] EPAOBPAKFLI MFEJFFLILMN, [NotNull][ACGOIOBGIEE(null)] ECJBOAIKALM GLAAFJDOHIB, [NotNull][ACGOIOBGIEE(null)] LFIFBGNKKNA JCMJMOJIIAE, [NotNull][ACGOIOBGIEE(null)] MPEAJOEKBGL ACJHPCHLKDG, [NotNull][ACGOIOBGIEE(null)] ODMHLMFNPCA MJOHBDFGFFD, [NotNull][ACGOIOBGIEE(null)] KNJPBACPBML EKGJNJOPIJE, [NotNull][ACGOIOBGIEE(null)] EGFJPDLGFEJ GHOPOPKJDMB, [ACGOIOBGIEE(null)][NotNull] HBDEKGAEIBN CENPMCEONAF, [ACGOIOBGIEE(null)][NotNull] GIOKMGGDKEO AOFEGGBHDEN, [NotNull][ACGOIOBGIEE(null)] GOLAIFJFJFA DPKKJKPNDNP, [ACGOIOBGIEE(null)][NotNull] INMOCPMHGNM<KeepsakesConfig.KeepsakesOptions> AHOANCKGKEN, [NotNull][ACGOIOBGIEE(null)] CCENJGFOMNL LJNLIKDCHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E261E0", Offset = "0x6E255E0", VA = "0x186E261E0", Slot = "15")]
	public bool NFIAPDIFGJA(List<string> FNPFABDAJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CCB0", Offset = "0x6E1C0B0", VA = "0x186E1CCB0", Slot = "16")]
	public MIJNEIJMPHL<Guid> CJCJBPAPBHN(DMDJAJBNJFC JOPLLPELDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E277E0", Offset = "0x6E26BE0", VA = "0x186E277E0", Slot = "17")]
	public AOFGCNMIPIP PHEIOAMJLKK(Guid LDEHNLDGLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E22EF0", Offset = "0x6E222F0", VA = "0x186E22EF0", Slot = "18")]
	public AOFGCNMIPIP IJADKBDAEBL(Guid LDEHNLDGLMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E224D0", Offset = "0x6E218D0", VA = "0x186E224D0", Slot = "19")]
	public bool HMLHINPLGIH(Guid LDEHNLDGLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E232F0", Offset = "0x6E226F0", VA = "0x186E232F0", Slot = "20")]
	public bool IPMMLLLKJIG(Guid LDEHNLDGLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E25F30", Offset = "0x6E25330", VA = "0x186E25F30")]
	public KeepsakeTheme MPDMLGBDNIA(Guid LDEHNLDGLMP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E26910", Offset = "0x6E25D10", VA = "0x186E26910")]
	public bool OIFEGDKAIOI(DMDJAJBNJFC JOPLLPELDEI, [Out] KeepsakeTheme MDFIFAJLGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DCC0", Offset = "0x6E1D0C0", VA = "0x186E1DCC0")]
	public List<KeepsakeTheme> DCAJAPJBEBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E265A0", Offset = "0x6E259A0", VA = "0x186E265A0")]
	public int NLNHFJLKELF(DMDJAJBNJFC JOPLLPELDEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E9D0", Offset = "0x6E1DDD0", VA = "0x186E1E9D0")]
	public DMDJAJBNJFC DFHHNFICHKN(Guid LDEHNLDGLMP)
	{
		return default(DMDJAJBNJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FFC0", Offset = "0x6E1F3C0", VA = "0x186E1FFC0", Slot = "34")]
	public List<DMDJAJBNJFC> FPLNHKAOLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E27C60", Offset = "0x6E27060", VA = "0x186E27C60", Slot = "35")]
	public IComparer<DMDJAJBNJFC> PPBACPFAGCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C9F0", Offset = "0x6E1BDF0", VA = "0x186E1C9F0", Slot = "32")]
	public string CDNJMAMGKFH(DMDJAJBNJFC JOPLLPELDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FBC0", Offset = "0x6E1EFC0", VA = "0x186E1FBC0", Slot = "33")]
	public string FIBOMOEJHBF(DMDJAJBNJFC JOPLLPELDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E23AE0", Offset = "0x6E22EE0", VA = "0x186E23AE0", Slot = "21")]
	public bool JIBGNDPEOPI(Guid LDEHNLDGLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E21470", Offset = "0x6E20870", VA = "0x186E21470", Slot = "22")]
	public void GHGCAECLINB(Guid LDEHNLDGLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BA50", Offset = "0x6E1AE50", VA = "0x186E1BA50", Slot = "23")]
	public void AHBBJFKJLFO(DMDJAJBNJFC JOPLLPELDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E27080", Offset = "0x6E26480", VA = "0x186E27080", Slot = "24")]
	public void OMIKMDGILEB(Guid LDEHNLDGLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E24E70", Offset = "0x6E24270", VA = "0x186E24E70", Slot = "25")]
	public int LPBKNLEGEBG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D690", Offset = "0x6E1CA90", VA = "0x186E1D690", Slot = "31")]
	public MIJNEIJMPHL<IEnumerable<Guid>> CLLGKHILNGM(long HLGODMOGCOI, long CKMKIDKCGCG, DMDJAJBNJFC? JOPLLPELDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E330", Offset = "0x6E1D730", VA = "0x186E1E330", Slot = "30")]
	public MIJNEIJMPHL<IEnumerable<Guid>> DDKOHEPHDGM(long HLGODMOGCOI, long CKMKIDKCGCG, DMDJAJBNJFC? JOPLLPELDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E620", Offset = "0x6E1DA20", VA = "0x186E1E620", Slot = "54")]
	public MIJNEIJMPHL<Dictionary<Guid, DMDJAJBNJFC>> DELAMPHKMPL(long HLGODMOGCOI, long CKMKIDKCGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E25360", Offset = "0x6E24760", VA = "0x186E25360", Slot = "55")]
	public MIJNEIJMPHL<Dictionary<Guid, DMDJAJBNJFC>> MBJJBKLHHAB(long HLGODMOGCOI, long CKMKIDKCGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B6A0", Offset = "0x6E1AAA0", VA = "0x186E1B6A0", Slot = "26")]
	public MIJNEIJMPHL<int> AFGJLMKKBKI(long HLGODMOGCOI, long CKMKIDKCGCG, DMDJAJBNJFC? JOPLLPELDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E4D0", Offset = "0x6E1D8D0", VA = "0x186E1E4D0", Slot = "27")]
	public MIJNEIJMPHL<int> DEJGIDNLPHM(long HLGODMOGCOI, long CKMKIDKCGCG, DMDJAJBNJFC? JOPLLPELDEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E233B0", Offset = "0x6E227B0", VA = "0x186E233B0", Slot = "28")]
	public MIJNEIJMPHL<Dictionary<DMDJAJBNJFC, int>> JDLFMFKEELE(long HLGODMOGCOI, long CKMKIDKCGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E23F70", Offset = "0x6E23370", VA = "0x186E23F70", Slot = "29")]
	public MIJNEIJMPHL<Dictionary<DMDJAJBNJFC, int>> KCNNBCHBDAC(long HLGODMOGCOI, long CKMKIDKCGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CC50", Offset = "0x6E1C050", VA = "0x186E1CC50", Slot = "37")]
	public bool CIHBDNHGGBF(long HLGODMOGCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C7C0", Offset = "0x6E1BBC0", VA = "0x186E1C7C0", Slot = "56")]
	public bool BOOMKMAJIPE(long HLGODMOGCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E244C0", Offset = "0x6E238C0", VA = "0x186E244C0", Slot = "38")]
	public bool KLEDEJKEJEE(long HLGODMOGCOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F760", Offset = "0x6E1EB60", VA = "0x186E1F760", Slot = "57")]
	public bool FFKLCGMCPKF(long HLGODMOGCOI, [Out] IANCGJNCMLM HDIIGKJDJMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E24940", Offset = "0x6E23D40", VA = "0x186E24940", Slot = "39")]
	public bool LBHBBPJJEGB(long PMDMNLKOGBH, [Out] DateTime PGIKFKGONIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E26B40", Offset = "0x6E25F40", VA = "0x186E26B40", Slot = "40")]
	public long OJIJGENJBBJ(long PMDMNLKOGBH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E26720", Offset = "0x6E25B20", VA = "0x186E26720", Slot = "41")]
	public long OHAJBBOBFMC(long HLGODMOGCOI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E25660", Offset = "0x6E24A60", VA = "0x186E25660", Slot = "42")]
	public int MEKHPLBHCIP(long PMDMNLKOGBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E26830", Offset = "0x6E25C30", VA = "0x186E26830", Slot = "43")]
	public bool OHMECPPKONJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E245E0", Offset = "0x6E239E0", VA = "0x186E245E0", Slot = "44")]
	public bool KOBCFMOAJOO(long PMDMNLKOGBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E27A60", Offset = "0x6E26E60", VA = "0x186E27A60", Slot = "45")]
	public IEnumerable<long> PNOJCGHOMCO(long PMDMNLKOGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F6B0", Offset = "0x6E1EAB0", VA = "0x186E1F6B0", Slot = "46")]
	public int FCAGIOHJBPA(long PMDMNLKOGBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C220", Offset = "0x6E1B620", VA = "0x186E1C220", Slot = "50")]
	public long BCEGJGNDNDJ(long HECHHGDHCLK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC90", Offset = "0x6E1E090", VA = "0x186E1EC90", Slot = "51")]
	public DMDJAJBNJFC DMGLFJFEFBN()
	{
		return default(DMDJAJBNJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EB30", Offset = "0x6E1DF30", VA = "0x186E1EB30")]
	private bool DHFGDJOMIKJ(Guid LDEHNLDGLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E21E20", Offset = "0x6E21220", VA = "0x186E21E20")]
	private void HGCCFOIPMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E211A0", Offset = "0x6E205A0", VA = "0x186E211A0")]
	private DMDJAJBNJFC GHBJOICGHHD()
	{
		return default(DMDJAJBNJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BAA0", Offset = "0x6E1AEA0", VA = "0x186E1BAA0")]
	private void AIPEMHCKBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E23DD0", Offset = "0x6E231D0", VA = "0x186E23DD0")]
	private int KAHEPDIJPPB(KeepsakeRoomListDTO FEPILMCLLJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E25E30", Offset = "0x6E25230", VA = "0x186E25E30")]
	private int MMKDFHEJEAH(DateTime PLLODIGJBAC, DateTime CDIJIAGCLKA, TimeSpan ELNILILJDNC, int CEKEOELMPEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DA40", Offset = "0x6E1CE40", VA = "0x186E1DA40")]
	private void CNGHBFNADJN(IEnumerable<KeepsakeInstanceDTO> EJBNPPDHLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E217D0", Offset = "0x6E20BD0", VA = "0x186E217D0")]
	private void HAPAFDIFJAN(IEnumerable<KeepsakeCollectionRecordDTO> AJEJKFHMJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E21140", Offset = "0x6E20540", VA = "0x186E21140")]
	private void GCHEHODCPHE(IEnumerable<long> GLKKDKKIAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xE97D00", Offset = "0xE97100", VA = "0x180E97D00")]
	private void AAKGKEDBBIJ(KeepsakeGlobalConfigDTO ICACJGKELEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E21B20", Offset = "0x6E20F20", VA = "0x186E21B20")]
	private bool HDDOLNAAPDN(DMDJAJBNJFC JOPLLPELDEI, [Out] Guid JBIJIAAOKCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E21730", Offset = "0x6E20B30", VA = "0x186E21730")]
	private bool HALBECEMFKP([Out] Guid JBIJIAAOKCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E23D70", Offset = "0x6E23170", VA = "0x186E23D70")]
	private bool JPLLKHIFNOD(Guid LDEHNLDGLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E22DA0", Offset = "0x6E221A0", VA = "0x186E22DA0")]
	private IEnumerable<Guid> IFOHPBDJGCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E21080", Offset = "0x6E20480", VA = "0x186E21080")]
	private IEnumerable<KeepsakeInstanceDTO> GAGBILABIBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E23320", Offset = "0x6E22720", VA = "0x186E23320")]
	private void JCMDECCLNNP(Guid LDEHNLDGLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EFF0", Offset = "0x6E1E3F0", VA = "0x186E1EFF0")]
	private bool DOBGJKCBPCJ(Guid LDEHNLDGLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E222D0", Offset = "0x6E216D0", VA = "0x186E222D0")]
	private void HHAEIBDIDFM(Guid LDEHNLDGLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CB70", Offset = "0x6E1BF70", VA = "0x186E1CB70")]
	private void CEICHAKBHIG(DMDJAJBNJFC EALJOJCJEEO, int DLDKKLKDNEM, Dictionary<DMDJAJBNJFC, int> FLPGICJFBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C6D0", Offset = "0x6E1BAD0", VA = "0x186E1C6D0")]
	private int BGCOPOBPEFO(DMDJAJBNJFC JOPLLPELDEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E24770", Offset = "0x6E23B70", VA = "0x186E24770")]
	private void LALIJFFHDJO(KeepsakeInstanceDTO PFODFNMNKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E227F0", Offset = "0x6E21BF0", VA = "0x186E227F0")]
	private void IAMEMOPFEBF(KeepsakeInstanceDTO PFODFNMNKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E24AA0", Offset = "0x6E23EA0", VA = "0x186E24AA0")]
	private void LMEIOHJIBBB(Guid LDEHNLDGLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC60", Offset = "0x6E1E060", VA = "0x186E1EC60")]
	private void LNGPBFOBIFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FD40", Offset = "0x6E1F140", VA = "0x186E1FD40")]
	private void FJAIBPEKAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E23280", Offset = "0x6E22680", VA = "0x186E23280")]
	private void INCCAAPLELM(HLIJPGBPOLB HLEALEHHCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC60", Offset = "0x6E1E060", VA = "0x186E1EC60")]
	private void DJANJLGBOBG(LGGIPINJNKF PBAACPJGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC60", Offset = "0x6E1E060", VA = "0x186E1EC60")]
	private void JHPCELHMIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E22A00", Offset = "0x6E21E00", VA = "0x186E22A00")]
	private void IDGDNFIDHJD(float BPCBDAAPHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E25840", Offset = "0x6E24C40", VA = "0x186E25840")]
	private void MGKPLHDEBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B4A0", Offset = "0x6E1A8A0", VA = "0x186E1B4A0")]
	private bool ACBHJJCCHIO(Guid LDEHNLDGLMP, [Out] string GJJGOFADMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C820", Offset = "0x6E1BC20", VA = "0x186E1C820")]
	private bool CAPBAGLGONA(Guid LDEHNLDGLMP, [Out] KeepsakeCategoryConfigDTO EALJOJCJEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E21650", Offset = "0x6E20A50", VA = "0x186E21650")]
	private void HAIBFINHJOH(string LKDIDALLBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B940", Offset = "0x6E1AD40", VA = "0x186E1B940")]
	private bool AGMEDKNHNHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E24210", Offset = "0x6E23610", VA = "0x186E24210")]
	private IEnumerable<long> KLCHLHGMJBE(IEnumerable<KeepsakeRoomDTO> CAJDOOJFOLB, IEnumerable<KeepsakeRoomListDTO> PNMLPDNGJDH, long PMDMNLKOGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E235C0", Offset = "0x6E229C0", VA = "0x186E235C0")]
	private bool JHJAKHCEBDC(Guid LDEHNLDGLMP, [Out] string GJAHCEMFFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E22470", Offset = "0x6E21870", VA = "0x186E22470", Slot = "47")]
	public string HMBNDFAOGDN(JMLDAHPMIIG BDIIIBEGNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E273C0", Offset = "0x6E267C0", VA = "0x186E273C0", Slot = "49")]
	public string PDAKEGKMKPM(JMLDAHPMIIG BDIIIBEGNEN, long HLGODMOGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F5E0", Offset = "0x6E1E9E0", VA = "0x186E1F5E0", Slot = "48")]
	public string FCAGCOAHEJD(JMLDAHPMIIG BDIIIBEGNEN, int IEOIIMFPCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E20110", Offset = "0x6E1F510", VA = "0x186E20110")]
	private void GABHLHHOBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C4E0", Offset = "0x6E1B8E0", VA = "0x186E1C4E0")]
	private void BEBCGAFPJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D670", Offset = "0x6E1CA70", VA = "0x186E1D670")]
	private JMLDAHPMIIG CLEOCICGBOK(HEBOPJJDABA DJHPLMABCLF)
	{
		return default(JMLDAHPMIIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E24A80", Offset = "0x6E23E80", VA = "0x186E24A80")]
	private JMLDAHPMIIG LIHAPMNDMLE(HEBOPJJDABA DJHPLMABCLF)
	{
		return default(JMLDAHPMIIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E24030", Offset = "0x6E23430", VA = "0x186E24030")]
	internal static string KGPCJKFOGIE(AHEMLIMIJMA PDHJKLOHACL, string AGIKNGPIELL, bool LCHJOALKGKL, int GJODOLPANPB, int DJCACOMPACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F0A0", Offset = "0x6E1E4A0", VA = "0x186E1F0A0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E24560", Offset = "0x6E23960", VA = "0x186E24560")]
	private CEFINKDJEPJ KMOJIEFEPFM(NGDBFKPHNOF GCAEHKIMAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E22630", Offset = "0x6E21A30", VA = "0x186E22630")]
	private OIIJPEDCKAB IALHPPGGPHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D2C0", Offset = "0x6E1C6C0", VA = "0x186E1D2C0")]
	private Task CKEKDHGHJCJ(PHNAGDHGBII HJEECPNIDIG, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E21A10", Offset = "0x6E20E10", VA = "0x186E21A10")]
	[AsyncStateMachine(typeof(ECIKCNFFEFG))]
	private Task HCOCEPADOEJ(PHNAGDHGBII HJEECPNIDIG, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E25290", Offset = "0x6E24690", VA = "0x186E25290")]
	private Task LPOPFHIHIAG(PHNAGDHGBII HJEECPNIDIG, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E200", Offset = "0x6E1D600", VA = "0x186E1E200")]
	[AsyncStateMachine(typeof(EBKDNPJGMCI))]
	private Task DDGLGOFCIMJ(string ADPAIBGIHMB, TimeSpan JOCLIOPGMMO, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F500", Offset = "0x6E1E900", VA = "0x186E1F500")]
	[CompilerGenerated]
	private void EEFLDLOLGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E25DE0", Offset = "0x6E251E0", VA = "0x186E25DE0")]
	[CompilerGenerated]
	private void MJIAJPJBNCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E272C0", Offset = "0x6E266C0", VA = "0x186E272C0")]
	[CompilerGenerated]
	private bool PCOHMGCCOHM(KeepsakeInstanceDTO CFANGCOBGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E214E0", Offset = "0x6E208E0", VA = "0x186E214E0")]
	[CompilerGenerated]
	private MIJNEIJMPHL<Dictionary<DMDJAJBNJFC, int>> GMGCNGFOOOO(Dictionary<Guid, DMDJAJBNJFC> FEHLPONGAHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E254F0", Offset = "0x6E248F0", VA = "0x186E254F0")]
	[CompilerGenerated]
	private MIJNEIJMPHL<Dictionary<DMDJAJBNJFC, int>> MCPLNJPHFGD(Dictionary<Guid, DMDJAJBNJFC> FEHLPONGAHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E27C40", Offset = "0x6E27040", VA = "0x186E27C40")]
	[CompilerGenerated]
	private bool POOMENADDGB(KeepsakeRoomListDTO CFANGCOBGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E26470", Offset = "0x6E25870", VA = "0x186E26470")]
	[CompilerGenerated]
	private bool NIOKLLJFNBP(KeepsakeInstanceDTO CFANGCOBGCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E070", Offset = "0x6E1D470", VA = "0x186E1E070")]
	[CompilerGenerated]
	private void DCEIIEGACKB(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<DMDJAJBNJFC, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> ABMKEFKAFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C670", Offset = "0x6E1BA70", VA = "0x186E1C670")]
	[CompilerGenerated]
	private void BFJLCDMIFLG(string GJAHCEMFFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FE00", Offset = "0x6E1F200", VA = "0x186E1FE00")]
	[CompilerGenerated]
	private Task FJHNJFAPIIG(CancellationToken HMAOMHELLAG)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, INMOCPMHGNM<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class DDPPDNEJCJK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
				public DDPPDNEJCJK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x6E19400", Offset = "0x6E18800", VA = "0x186E19400")]
				internal bool DINHMEPFMBJ(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6E19400", Offset = "0x6E18800", VA = "0x186E19400")]
				internal bool DGNJOMOKDKD(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B140", Offset = "0x6E1A540", VA = "0x186E1B140")]
			public bool FPIOOGLOECO(string FGDEOFMOALH, [Out] KeepsakeTheme MDFIFAJLGBC)
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
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B0C0", Offset = "0x6E1A4C0", VA = "0x186E1B0C0")]
		[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
		internal static void EJGLCCJGHFF(ACFNHMKNHLL KLAPMCLMAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA79810", Offset = "0xA78C10", VA = "0x180A79810")]
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

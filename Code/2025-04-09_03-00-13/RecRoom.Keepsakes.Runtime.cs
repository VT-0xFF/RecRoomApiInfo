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
		[Cpp2IlInjected.Address(RVA = "0x7924460", Offset = "0x7923860", VA = "0x187924460", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LCKCFECPKIF : IComparer<LAHJBOFKJLL>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class OKFNDPEKGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LAHJBOFKJLL x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public LAHJBOFKJLL y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OKFNDPEKGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC37EE0", Offset = "0xC372E0", VA = "0x180C37EE0")]
		internal bool IJKLGMHDBGA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D6A2C0", Offset = "0x1D696C0", VA = "0x181D6A2C0")]
		internal bool CNMMAFJNNIJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC37EE0", Offset = "0xC372E0", VA = "0x180C37EE0")]
		internal bool FIKPMCEGOFL(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D6A2C0", Offset = "0x1D696C0", VA = "0x181D6A2C0")]
		internal bool INIBKHNNNKP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> IBPHCMPFPOH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public LCKCFECPKIF(List<KeepsakeCategoryThemePair> NMJJCHCHHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7914530", Offset = "0x7913930", VA = "0x187914530", Slot = "4")]
	public int Compare(LAHJBOFKJLL MEAMPLHPPKP, LAHJBOFKJLL KDELALKKKOF)
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
		public LAHJBOFKJLL KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CBAKGNGODOD]
public class NAIPLBCJFGL : EIAKNHKEEII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MDBONIONOAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NAIPLBCJFGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public LAHJBOFKJLL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MDBONIONOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7914D60", Offset = "0x7914160", VA = "0x187914D60")]
		internal GOBMEFCJDOP<Guid> DBENCCLHIFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7914F40", Offset = "0x7914340", VA = "0x187914F40")]
		internal void HPKAOKIBBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7914EB0", Offset = "0x79142B0", VA = "0x187914EB0")]
		internal void GCHDFGNABAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7914950", Offset = "0x7913D50", VA = "0x187914950")]
		internal void AFBCDBFEGEO(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7914F10", Offset = "0x7914310", VA = "0x187914F10")]
		internal void GDLKDDDODHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OBLHPPGKMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NAIPLBCJFGL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OBLHPPGKMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x79232D0", Offset = "0x79226D0", VA = "0x1879232D0")]
		internal void BHCAONLFJGN(GMCONINGDKP response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7923680", Offset = "0x7922A80", VA = "0x187923680")]
		internal void NKAGKHHPCAN(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OHJNOLFOPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OHJNOLFOPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7923DA0", Offset = "0x79231A0", VA = "0x187923DA0")]
		internal bool IHACCLEPBIG(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MMBNHILBNHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NAIPLBCJFGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public LAHJBOFKJLL? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MMBNHILBNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7915360", Offset = "0x7914760", VA = "0x187915360")]
		internal void NNJJCJJOBBF(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7915030", Offset = "0x7914430", VA = "0x187915030")]
		internal void GHNNHFCJJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7915060", Offset = "0x7914460", VA = "0x187915060")]
		internal GOBMEFCJDOP<IEnumerable<Guid>> JGEJMGMLOAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x747F5E0", Offset = "0x747E9E0", VA = "0x18747F5E0")]
		internal bool MKPKCOALDCE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OELLGGJILOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public MMBNHILBNHP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public OELLGGJILOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7923C60", Offset = "0x7923060", VA = "0x187923C60")]
		internal GOBMEFCJDOP<IEnumerable<Guid>> BACMEECKACN(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CKMENKFHDAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public OELLGGJILOO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CKMENKFHDAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7913120", Offset = "0x7912520", VA = "0x187913120")]
		internal bool KBJKDPEJDGN(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class PFLPDDBNNIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CKMENKFHDAK CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PFLPDDBNNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7923DC0", Offset = "0x79231C0", VA = "0x187923DC0")]
		internal bool OOHLCGJEMLM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LJMBILGBPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NAIPLBCJFGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LJMBILGBPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x79147E0", Offset = "0x7913BE0", VA = "0x1879147E0")]
		internal GOBMEFCJDOP<IEnumerable<Guid>> EMEHKDGBAIG(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7913FE0", Offset = "0x79133E0", VA = "0x187913FE0")]
		internal bool NGMLBODPJPK(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class PPIKOODFFLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NAIPLBCJFGL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PPIKOODFFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7923ED0", Offset = "0x79232D0", VA = "0x187923ED0")]
		internal void CMIMHHPGFIK(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7915030", Offset = "0x7914430", VA = "0x187915030")]
		internal void HJJHGPLIIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7923F60", Offset = "0x7923360", VA = "0x187923F60")]
		internal GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> OJCPNJOHCNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x747F5E0", Offset = "0x747E9E0", VA = "0x18747F5E0")]
		internal bool PPNKHOOCEHN(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class DLKDEFJPAKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DLKDEFJPAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7913370", Offset = "0x7912770", VA = "0x187913370")]
		internal GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> IEOGDGJBJAH(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class IBHJLHPKNPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IBHJLHPKNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x79138C0", Offset = "0x7912CC0", VA = "0x1879138C0")]
		internal bool DIEBNKPKDEK(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x79139A0", Offset = "0x7912DA0", VA = "0x1879139A0")]
		internal KeyValuePair<Guid, LAHJBOFKJLL> OKEFEICOBPJ(Guid instanceId)
		{
			return default(KeyValuePair<Guid, LAHJBOFKJLL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DKALBBIGNME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DKALBBIGNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x23805E0", Offset = "0x237F9E0", VA = "0x1823805E0")]
		internal bool GBPDECHKOKJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EDECGFLMIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EDECGFLMIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x23805E0", Offset = "0x237F9E0", VA = "0x1823805E0")]
		internal bool IJIPJBCFKNP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JLOCLBOHFKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NAIPLBCJFGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JLOCLBOHFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7914000", Offset = "0x7913400", VA = "0x187914000")]
		internal GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> OHNAJFAIIKL(Dictionary<Guid, LAHJBOFKJLL> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7913FE0", Offset = "0x79133E0", VA = "0x187913FE0")]
		internal bool GJMBKBPFDFO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CFIPPBIBKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public CFIPPBIBKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x79130A0", Offset = "0x79124A0", VA = "0x1879130A0")]
		internal bool AJOABPAJCKB(KeyValuePair<Guid, LAHJBOFKJLL> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IHOGNJFKDHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, LAHJBOFKJLL> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IHOGNJFKDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7913B90", Offset = "0x7912F90", VA = "0x187913B90")]
		internal KeyValuePair<LAHJBOFKJLL, int> HEHLANPMIDD(LAHJBOFKJLL category)
		{
			return default(KeyValuePair<LAHJBOFKJLL, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BMNGEENBCJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LAHJBOFKJLL category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BMNGEENBCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xD466B0", Offset = "0xD45AB0", VA = "0x180D466B0")]
		internal bool OFEEOBMBMFP(LAHJBOFKJLL instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GOKLHHKEIOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, LAHJBOFKJLL> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GOKLHHKEIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7913770", Offset = "0x7912B70", VA = "0x187913770")]
		internal KeyValuePair<LAHJBOFKJLL, int> OLKEPLHCJAE(LAHJBOFKJLL category)
		{
			return default(KeyValuePair<LAHJBOFKJLL, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IIEPKEAEBMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public LAHJBOFKJLL category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IIEPKEAEBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD466B0", Offset = "0xD45AB0", VA = "0x180D466B0")]
		internal bool HOEAGELDKNK(LAHJBOFKJLL instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EGPJCAKNHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NAIPLBCJFGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EGPJCAKNHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7913600", Offset = "0x7912A00", VA = "0x187913600")]
		internal bool HHKGHOPDLAL(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7913540", Offset = "0x7912940", VA = "0x187913540")]
		internal bool EHAHINBOAOO(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7913520", Offset = "0x7912920", VA = "0x187913520")]
		internal bool BDAFMNCKEMG(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7913520", Offset = "0x7912920", VA = "0x187913520")]
		internal bool JCBCMAJCNGE(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GECCNEIPOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GECCNEIPOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xDB4D10", Offset = "0xDB4110", VA = "0x180DB4D10")]
		internal bool DNALPMHFHHI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class MJAJHGFLCBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public MJAJHGFLCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7914F70", Offset = "0x7914370", VA = "0x187914F70")]
		internal bool BEMGLFIGLDE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x23415A0", Offset = "0x23409A0", VA = "0x1823415A0")]
		internal bool HJOMKKJFICB(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PHJKEHDPAKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PHJKEHDPAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7923E70", Offset = "0x7923270", VA = "0x187923E70")]
		internal bool NJBGDMLMKMA(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class LOGLCBDNPGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public LOGLCBDNPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xDB4D10", Offset = "0xDB4110", VA = "0x180DB4D10")]
		internal bool PCDEKMNEHEP(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class KMIPEEKDAGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KMIPEEKDAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7914280", Offset = "0x7913680", VA = "0x187914280")]
		internal bool EEDJJMPLPGI(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KHFPLPPGCAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public LAHJBOFKJLL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public KHFPLPPGCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F87E40", Offset = "0x1F87240", VA = "0x181F87E40")]
		internal bool DFJCFBDEEKM(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IFNPLNNBLJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public IFNPLNNBLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7913B30", Offset = "0x7912F30", VA = "0x187913B30")]
		internal bool ECOPKAODFPI(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class ICPDEKNLBLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public LAHJBOFKJLL keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public ICPDEKNLBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7913AF0", Offset = "0x7912EF0", VA = "0x187913AF0")]
		internal bool BJAIPKODPOM(KeyValuePair<Guid, LAHJBOFKJLL> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EPNIFLBMEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public LAHJBOFKJLL newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public EPNIFLBMEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1F87E40", Offset = "0x1F87240", VA = "0x181F87E40")]
		internal bool GFLHEFCADDL(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class GLPICLCODED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public GLPICLCODED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x79136F0", Offset = "0x7912AF0", VA = "0x1879136F0")]
		internal bool EMDEODGKPFG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DGOHLNLCIDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public DGOHLNLCIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7913280", Offset = "0x7912680", VA = "0x187913280")]
		internal bool ABKEJOMOGHA(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class JMGMLIGCPBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DGOHLNLCIDE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JMGMLIGCPBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7914200", Offset = "0x7913600", VA = "0x187914200")]
		internal bool KPGNIOMPBBN(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct OCDEEOBKOMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NAIPLBCJFGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FEJGNMMNDHD args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x79236E0", Offset = "0x7922AE0", VA = "0x1879236E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7923C00", Offset = "0x7923000", VA = "0x187923C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct JIBOFAACHNH : IAsyncStateMachine
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
		public NAIPLBCJFGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7913CE0", Offset = "0x79130E0", VA = "0x187913CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7913F80", Offset = "0x7913380", VA = "0x187913F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime GCLLHFONHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CFLGIHOKKAL CPIBADAAELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly MBLMMOAPNPC ENHPGJIPLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly PCJHNLFLINK FPBCPLIFHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IIJCENGLKPN BHCIBFGHBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly LGIJHFEOCEK LMJMNPPPAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly NHHFHOCOGEC DNDEINMDIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly FKLBCLNGIJH JGGPEAFECGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly FMKBFEIFICC BOGAODIGBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EMNMJALBIKI KCDOKAOGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EOIPCPHMHDA GEFMJHDAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MKEHAOLCFAM PKMFECLHKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FDLGHKBFDFJ FBFPHGFBKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly JBKHHJPCACA MFJJDIDOLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly NLHJGDPBHNK IHPAONIPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ENCEHJNHPBL HKNGEHEEHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly OAODAKEKPCL<KeepsakesConfig.KeepsakesOptions> FBCMGOKFCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly NNOOHIAHMIG ENFLKMBLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> KLFPONPJPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> MHBHICFLOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> CPPGMBNEJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<LAHJBOFKJLL, int> OIFGHDLNFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> BJFNPKKLMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable HKKOFKLPPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task PBFLLCCMCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private GOBMEFCJDOP<Guid> LMNMEBKABJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? DEDDOKDKJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO DNIEINDOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GOBMEFCJDOP<KeepsakeProgressionEventInstancesDTO> LOFFOGFIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<LAHJBOFKJLL, KeepsakeCategoryConfigDTO> MLIMDAIOKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO LFIAPJIIDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> PADJOKKLAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> BHIAEFALCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> ICLNJEBFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> FFBEIIGIMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> LCNPLPEILAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> EBLABFHFKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> CEPAMKAHHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> CCJFOFBCKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LKOKOGMAIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> OJGEKHHGLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> JPNPAFIGIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> IDKGGCCGIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime MBCJJCDAGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable BAIIEKCKNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, LAHJBOFKJLL> AGJGKIMDPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<LAHJBOFKJLL, int> EILOABMAGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> NMJJCHCHHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private LCKCFECPKIF KAKDJGOBCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool IBKCPFNABDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IOFNBNHFMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D7F20", Offset = "0x9D7320", VA = "0x1809D7F20", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9D7D40", Offset = "0x9D7140", VA = "0x1809D7D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JJEPLINNHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x791B200", Offset = "0x791A600", VA = "0x18791B200", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BEBCFFMHNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x79172C0", Offset = "0x79166C0", VA = "0x1879172C0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long GHJFMHGHEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7919A70", Offset = "0x7918E70", VA = "0x187919A70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? LMIAIMBACDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x791E490", Offset = "0x791D890", VA = "0x18791E490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool NPBPONDFOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x791E100", Offset = "0x791D500", VA = "0x18791E100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> ODBBCHFIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA1DC30", Offset = "0xA1D030", VA = "0x180A1DC30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> JOENDFHPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA14E90", Offset = "0xA14290", VA = "0x180A14E90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> MMILFOHAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1D520", Offset = "0xA1C920", VA = "0x180A1D520", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> EJINNHECEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA25E80", Offset = "0xA25280", VA = "0x180A25E80", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool MDHNAFAENNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD8AA0", Offset = "0xAD7EA0", VA = "0x180AD8AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HBIILDIKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79201C0", Offset = "0x791F5C0", VA = "0x1879201C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x791F750", Offset = "0x791EB50", VA = "0x18791F750", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DEFGEONOPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7916E90", Offset = "0x7916290", VA = "0x187916E90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x791A630", Offset = "0x7919A30", VA = "0x18791A630", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FFAFPDPKGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x791DBB0", Offset = "0x791CFB0", VA = "0x18791DBB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x791E3F0", Offset = "0x791D7F0", VA = "0x18791E3F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7921D10", Offset = "0x7921110", VA = "0x187921D10")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NAIPLBCJFGL([CMKKAFOAFJE(null)][NotNull] CFLGIHOKKAL CPIBADAAELC, [NotNull][CMKKAFOAFJE(null)] MOALAMFEOFP PNCENFPCHLN, [NotNull][CMKKAFOAFJE(null)] MBLMMOAPNPC ENHPGJIPLKB, [NotNull][CMKKAFOAFJE(null)] PCJHNLFLINK FPBCPLIFHKA, [CMKKAFOAFJE(null)][NotNull] IIJCENGLKPN BHCIBFGHBLH, [CMKKAFOAFJE(null)][NotNull] LGIJHFEOCEK LMJMNPPPAHL, [CMKKAFOAFJE(null)][NotNull] NHHFHOCOGEC DNDEINMDIFI, [NotNull][CMKKAFOAFJE(null)] FKLBCLNGIJH JGGPEAFECGJ, [NotNull][CMKKAFOAFJE(null)] FMKBFEIFICC BOGAODIGBEK, [NotNull][CMKKAFOAFJE(null)] KEOINNCCKOJ LKHLAPFIFNG, [NotNull][CMKKAFOAFJE(null)] EMNMJALBIKI KCDOKAOGGDF, [NotNull][CMKKAFOAFJE(null)] EOIPCPHMHDA GEFMJHDAIEM, [NotNull][CMKKAFOAFJE(null)] MKEHAOLCFAM PKMFECLHKLB, [NotNull][CMKKAFOAFJE(null)] FDLGHKBFDFJ FBFPHGFBKEP, [CMKKAFOAFJE(null)][NotNull] JBKHHJPCACA MFJJDIDOLLB, [CMKKAFOAFJE(null)][NotNull] NLHJGDPBHNK IHPAONIPNJI, [NotNull][CMKKAFOAFJE(null)] ENCEHJNHPBL HKNGEHEEHMP, [CMKKAFOAFJE(null)][NotNull] OAODAKEKPCL<KeepsakesConfig.KeepsakesOptions> FBCMGOKFCPJ, [NotNull][CMKKAFOAFJE(null)] NNOOHIAHMIG ENFLKMBLIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7919120", Offset = "0x7918520", VA = "0x187919120", Slot = "15")]
	public bool DBGBPJGMPCP(List<string> MHPNIEANAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7916880", Offset = "0x7915C80", VA = "0x187916880", Slot = "16")]
	public GOBMEFCJDOP<Guid> BHNJBIBMAGJ(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7921A60", Offset = "0x7920E60", VA = "0x187921A60", Slot = "17")]
	public DJNFHDJGNJD PDNMPAOGADG(Guid LMJKJEPMLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x791BAF0", Offset = "0x791AEF0", VA = "0x18791BAF0", Slot = "18")]
	public DJNFHDJGNJD HBJNFJLANOP(Guid LMJKJEPMLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x791E520", Offset = "0x791D920", VA = "0x18791E520", Slot = "19")]
	public bool LIKPGAGPKNM(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7921CE0", Offset = "0x79210E0", VA = "0x187921CE0", Slot = "20")]
	public bool PFJKEKIMDLH(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x791F260", Offset = "0x791E660", VA = "0x18791F260")]
	public KeepsakeTheme MDEAHCLOAII(Guid LMJKJEPMLBH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x791FDC0", Offset = "0x791F1C0", VA = "0x18791FDC0")]
	public bool MMBKIEMFOAM(LAHJBOFKJLL CNOKJKFMJAG, [Out] KeepsakeTheme EOHCGFNFDBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x791F800", Offset = "0x791EC00", VA = "0x18791F800")]
	public List<KeepsakeTheme> MGMGCCEMPCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x791CCF0", Offset = "0x791C0F0", VA = "0x18791CCF0")]
	public int JALKNDOKKIO(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x791D3D0", Offset = "0x791C7D0", VA = "0x18791D3D0")]
	public LAHJBOFKJLL JMLABIOBJCF(Guid LMJKJEPMLBH)
	{
		return default(LAHJBOFKJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x791E110", Offset = "0x791D510", VA = "0x18791E110", Slot = "34")]
	public List<LAHJBOFKJLL> LEMFMJMKJFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x791C390", Offset = "0x791B790", VA = "0x18791C390", Slot = "35")]
	public IComparer<LAHJBOFKJLL> HOJOPMCHNCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x791E250", Offset = "0x791D650", VA = "0x18791E250", Slot = "32")]
	public string LFIENEBGBGF(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7919F60", Offset = "0x7919360", VA = "0x187919F60", Slot = "33")]
	public string ELMGNJJFBGG(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x791C670", Offset = "0x791BA70", VA = "0x18791C670", Slot = "21")]
	public bool IEKIOKGFJFF(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x79195A0", Offset = "0x79189A0", VA = "0x1879195A0", Slot = "22")]
	public void DNJBCEDBFPM(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x79208F0", Offset = "0x791FCF0", VA = "0x1879208F0", Slot = "23")]
	public void NPAEOOLABAJ(LAHJBOFKJLL CNOKJKFMJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7916F30", Offset = "0x7916330", VA = "0x187916F30", Slot = "24")]
	public void BLGKCKGEFMK(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x791B250", Offset = "0x791A650", VA = "0x18791B250", Slot = "25")]
	public int GKKPKFPAKNO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7915680", Offset = "0x7914A80", VA = "0x187915680", Slot = "31")]
	public GOBMEFCJDOP<IEnumerable<Guid>> AHNAJMDDHJH(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7917380", Offset = "0x7916780", VA = "0x187917380", Slot = "30")]
	public GOBMEFCJDOP<IEnumerable<Guid>> CDNBPNPAFME(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x79216B0", Offset = "0x7920AB0", VA = "0x1879216B0", Slot = "54")]
	public GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> PCAKEPGIEKF(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x791A8E0", Offset = "0x7919CE0", VA = "0x18791A8E0", Slot = "55")]
	public GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> GBADPCILANF(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x791BF30", Offset = "0x791B330", VA = "0x18791BF30", Slot = "26")]
	public GOBMEFCJDOP<int> HEEMGPHOGGC(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7917170", Offset = "0x7916570", VA = "0x187917170", Slot = "27")]
	public GOBMEFCJDOP<int> BPICKGIDCGJ(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7916140", Offset = "0x7915540", VA = "0x187916140", Slot = "28")]
	public GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> BCIKCCHELBB(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x79167C0", Offset = "0x7915BC0", VA = "0x1879167C0", Slot = "29")]
	public GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> BGLADIKMFFI(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x791E0A0", Offset = "0x791D4A0", VA = "0x18791E0A0", Slot = "37")]
	public bool LDKGKOCNOFK(long MIFADOBCMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x791AEE0", Offset = "0x791A2E0", VA = "0x18791AEE0", Slot = "56")]
	public bool GHBGJJLIEMB(long MIFADOBCMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x791BE90", Offset = "0x791B290", VA = "0x18791BE90", Slot = "38")]
	public bool HDFNKDINIOH(long MIFADOBCMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x79163E0", Offset = "0x79157E0", VA = "0x1879163E0", Slot = "57")]
	public bool BFGDDBIHBPL(long MIFADOBCMAC, [Out] JAKODCCBCFO ICIBOIABFIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x791FFC0", Offset = "0x791F3C0", VA = "0x18791FFC0", Slot = "39")]
	public bool MPHDLJMBKHA(long OEDBLEJCIMJ, [Out] DateTime ANJKOMDGAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x791ED20", Offset = "0x791E120", VA = "0x18791ED20", Slot = "40")]
	public long LMBIKBCHEDI(long OEDBLEJCIMJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79215A0", Offset = "0x79209A0", VA = "0x1879215A0", Slot = "41")]
	public long PBNICGFGNIE(long MIFADOBCMAC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x791DC50", Offset = "0x791D050", VA = "0x18791DC50", Slot = "42")]
	public int LBEDILFIGDO(long OEDBLEJCIMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7915BA0", Offset = "0x7914FA0", VA = "0x187915BA0", Slot = "43")]
	public bool APNHNNMMDNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x791D970", Offset = "0x791CD70", VA = "0x18791D970", Slot = "44")]
	public bool KGNOGHFBJPF(long OEDBLEJCIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x791DE30", Offset = "0x791D230", VA = "0x18791DE30", Slot = "45")]
	public IReadOnlyList<long> LBNFKFDFDPN(long OEDBLEJCIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x791DB00", Offset = "0x791CF00", VA = "0x18791DB00", Slot = "46")]
	public int KHCJLLPIAGK(long OEDBLEJCIMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7918C20", Offset = "0x7918020", VA = "0x187918C20", Slot = "50")]
	public long CNGHGDGDHEM(long GLKDPBBDFJD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x791D070", Offset = "0x791C470", VA = "0x18791D070", Slot = "51")]
	public LAHJBOFKJLL JENLMGEDKLA()
	{
		return default(LAHJBOFKJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x791A500", Offset = "0x7919900", VA = "0x18791A500")]
	private bool FEBODEAMOOJ(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7915C80", Offset = "0x7915080", VA = "0x187915C80")]
	private void BBFKMOJHNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7919B40", Offset = "0x7918F40", VA = "0x187919B40")]
	private LAHJBOFKJLL EIHNEBKDKAE()
	{
		return default(LAHJBOFKJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x791E6E0", Offset = "0x791DAE0", VA = "0x18791E6E0")]
	private void LLFLGBGLGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x791CB50", Offset = "0x791BF50", VA = "0x18791CB50")]
	private int JAHDJMFKBEF(KeepsakeRoomListDTO FPLGKICJMMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7917AC0", Offset = "0x7916EC0", VA = "0x187917AC0")]
	private int CLECCLKNKIB(DateTime NCEJPDOCPEN, DateTime PPPLOIPHDGD, TimeSpan KMIDHKGBONJ, int HCFNHLPAMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x79153F0", Offset = "0x79147F0", VA = "0x1879153F0")]
	private void ABFFLAPEMGC(IEnumerable<KeepsakeInstanceDTO> KLFPONPJPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7918EE0", Offset = "0x79182E0", VA = "0x187918EE0")]
	private void DAOENFIALKH(IEnumerable<KeepsakeCollectionRecordDTO> ECGNCLBPGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7920E60", Offset = "0x7920260", VA = "0x187920E60")]
	private void OILCGLAKGME(IEnumerable<long> PENMIKHIIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA1D8E0", Offset = "0xA1CCE0", VA = "0x180A1D8E0")]
	private void IDKAONKMPGL(KeepsakeGlobalConfigDTO LFIAPJIIDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7917650", Offset = "0x7916A50", VA = "0x187917650")]
	private bool CKBNOLEEOJL(LAHJBOFKJLL CNOKJKFMJAG, [Out] Guid NADBGBHIJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x791A840", Offset = "0x7919C40", VA = "0x18791A840")]
	private bool FPLNEJNOHNL([Out] Guid NADBGBHIJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x791E680", Offset = "0x791DA80", VA = "0x18791E680")]
	private bool LKFBEANGNCH(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7919E10", Offset = "0x7919210", VA = "0x187919E10")]
	private IEnumerable<Guid> EIPOBGODLML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79194E0", Offset = "0x79188E0", VA = "0x1879194E0")]
	private IEnumerable<KeepsakeInstanceDTO> DJHCNNIOGBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7916350", Offset = "0x7915750", VA = "0x187916350")]
	private void BFFECOOKFPP(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x791B670", Offset = "0x791AA70", VA = "0x18791B670")]
	private bool GNFBJHFAEJE(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7917BC0", Offset = "0x7916FC0", VA = "0x187917BC0")]
	private void CLFCFDIFDCC(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7920810", Offset = "0x791FC10", VA = "0x187920810")]
	private void NOIMFJHLGPK(LAHJBOFKJLL CMAMNCPNLFL, int ABOELGBENAG, Dictionary<LAHJBOFKJLL, int> DFNJIGBBNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x791C580", Offset = "0x791B980", VA = "0x18791C580")]
	private int IALNGPHMKEH(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x79213D0", Offset = "0x79207D0", VA = "0x1879213D0")]
	private void PAKECBHECAC(KeepsakeInstanceDTO JJHBOKJAOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79178B0", Offset = "0x7916CB0", VA = "0x1879178B0")]
	private void CLEAGPJFCLL(KeepsakeInstanceDTO JJHBOKJAOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x791B720", Offset = "0x791AB20", VA = "0x18791B720")]
	private void GOGHODJEDON(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7916790", Offset = "0x7915B90", VA = "0x187916790")]
	private void GGHMJLGJFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x79193B0", Offset = "0x79187B0", VA = "0x1879193B0")]
	private void DDGCJOLKINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x791C900", Offset = "0x791BD00", VA = "0x18791C900")]
	private void IGAHIJEFIKF(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7916790", Offset = "0x7915B90", VA = "0x187916790")]
	private void BGCINLNAPLH(BFPGFECOPIK BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7916790", Offset = "0x7915B90", VA = "0x187916790")]
	private void NGHGGFMHAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x791AA70", Offset = "0x7919E70", VA = "0x18791AA70")]
	private void GDPFMDEPNBD(float ENOGEACDIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7920270", Offset = "0x791F670", VA = "0x187920270")]
	private void NOCODPJHFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x791CE70", Offset = "0x791C270", VA = "0x18791CE70")]
	private bool JCDLEPBHBLD(Guid LMJKJEPMLBH, [Out] string INNEGDLMOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7920FA0", Offset = "0x79203A0", VA = "0x187920FA0")]
	private bool OLHLBKJHCDK(Guid LMJKJEPMLBH, [Out] KeepsakeCategoryConfigDTO CMAMNCPNLFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7920EC0", Offset = "0x79202C0", VA = "0x187920EC0")]
	private void OJDEHPHMJEL(string AHEBBEAMAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79193D0", Offset = "0x79187D0", VA = "0x1879193D0")]
	private bool DHDNGGKIAGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x791AF40", Offset = "0x791A340", VA = "0x18791AF40")]
	private List<long> GHDICAKDDEB(IEnumerable<KeepsakeRoomDTO> JBLJONBMMME, IReadOnlyList<KeepsakeRoomListDTO> MKAOPDHIFNP, long OEDBLEJCIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7920940", Offset = "0x791FD40", VA = "0x187920940")]
	private bool OIKKJDFLGHJ(Guid LMJKJEPMLBH, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7920100", Offset = "0x791F500", VA = "0x187920100", Slot = "47")]
	public string MPIOFJDHLCA(JABHBPEAHIK ILDGOGHMDCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x791D530", Offset = "0x791C930", VA = "0x18791D530", Slot = "49")]
	public string JNGEPBHJKOE(JABHBPEAHIK ILDGOGHMDCB, long MIFADOBCMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x791AE10", Offset = "0x791A210", VA = "0x18791AE10", Slot = "48")]
	public string GFOPIOKBEPN(JABHBPEAHIK ILDGOGHMDCB, int GCKHFLINCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7917D60", Offset = "0x7917160", VA = "0x187917D60")]
	private void CNAKOEPJDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x791C970", Offset = "0x791BD70", VA = "0x18791C970")]
	private void IJGCKLANPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x791E3D0", Offset = "0x791D7D0", VA = "0x18791E3D0")]
	private JABHBPEAHIK LGJKHACPIFK(BDANJMAPMIG KEJHEJGOCLK)
	{
		return default(JABHBPEAHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x791FFA0", Offset = "0x791F3A0", VA = "0x18791FFA0")]
	private JABHBPEAHIK MMPCOOEJJNP(BDANJMAPMIG KEJHEJGOCLK)
	{
		return default(JABHBPEAHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x791A160", Offset = "0x7919560", VA = "0x18791A160")]
	internal static string EOHFAFBAOOP(GMCONINGDKP DLNNHCPPFNB, string FPBJFCGKBOC, bool FNJFIOAAENO, int KDEHMPJOPFH, int BHAMAMAMEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7919610", Offset = "0x7918A10", VA = "0x187919610", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x791A0E0", Offset = "0x79194E0", VA = "0x18791A0E0")]
	private OGJPCDKPGHL EMIEJNGBIJL(DNIGIBHMBIB BPMEJAFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x791A340", Offset = "0x7919740", VA = "0x18791A340")]
	private HHAPIHFLFHJ FCHIBFAALIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x791F3A0", Offset = "0x791E7A0", VA = "0x18791F3A0")]
	private Task MEMGLGGLKEI(FEJGNMMNDHD BPKDFLJLPAA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x791FCB0", Offset = "0x791F0B0", VA = "0x18791FCB0")]
	[AsyncStateMachine(typeof(OCDEEOBKOMC))]
	private Task MIHNICIOOAL(FEJGNMMNDHD BPKDFLJLPAA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7921170", Offset = "0x7920570", VA = "0x187921170")]
	private Task OLLLFFPKMFD(FEJGNMMNDHD BPKDFLJLPAA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x791C450", Offset = "0x791B850", VA = "0x18791C450")]
	[AsyncStateMachine(typeof(JIBOFAACHNH))]
	private Task IAAJAHHBFGO(string DAMFJFKKFBI, TimeSpan LCCNAJIJFFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x791BE70", Offset = "0x791B270", VA = "0x18791BE70")]
	[CompilerGenerated]
	private void HCHKFPHEADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x791CB00", Offset = "0x791BF00", VA = "0x18791CB00")]
	[CompilerGenerated]
	private void IOAMMAPBGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x791FBB0", Offset = "0x791EFB0", VA = "0x18791FBB0")]
	[CompilerGenerated]
	private bool MIFMJDMNJDM(KeepsakeInstanceDTO MEAMPLHPPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7915A30", Offset = "0x7914E30", VA = "0x187915A30")]
	[CompilerGenerated]
	private GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> AIGOFIHCEOL(Dictionary<Guid, LAHJBOFKJLL> HONDLNIMKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x791A6D0", Offset = "0x7919AD0", VA = "0x18791A6D0")]
	[CompilerGenerated]
	private GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> FPCIBNONINH(Dictionary<Guid, LAHJBOFKJLL> HONDLNIMKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x791D950", Offset = "0x791CD50", VA = "0x18791D950")]
	[CompilerGenerated]
	private bool KAOAIHPMCKI(KeepsakeRoomListDTO MEAMPLHPPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7917520", Offset = "0x7916920", VA = "0x187917520")]
	[CompilerGenerated]
	private bool CHBMIEKOHHA(KeepsakeInstanceDTO MEAMPLHPPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7921240", Offset = "0x7920640", VA = "0x187921240")]
	[CompilerGenerated]
	private void PACAIADPCFJ(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<LAHJBOFKJLL, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> EOMAKEGNGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7920160", Offset = "0x791F560", VA = "0x187920160")]
	[CompilerGenerated]
	private void NBHCPPLMIAM(string AFHGIBDEPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x791C1D0", Offset = "0x791B5D0", VA = "0x18791C1D0")]
	[CompilerGenerated]
	private Task HHEJBNHNDCE(CancellationToken FCCLAMHGAIO)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, OAODAKEKPCL<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class CMLIEELHCFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
				public CMLIEELHCFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7913250", Offset = "0x7912650", VA = "0x187913250")]
				internal bool FIFLIJKOIJH(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7913250", Offset = "0x7912650", VA = "0x187913250")]
				internal bool CFCGBFLEMIO(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7914360", Offset = "0x7913760", VA = "0x187914360")]
			public bool FMGLOKOAHNJ(string AHCABCJHNEO, [Out] KeepsakeTheme EOHCGFNFDBA)
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x79142E0", Offset = "0x79136E0", VA = "0x1879142E0")]
		[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
		internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xB034E0", Offset = "0xB028E0", VA = "0x180B034E0")]
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

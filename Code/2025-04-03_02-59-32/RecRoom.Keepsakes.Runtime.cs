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
		[Cpp2IlInjected.Address(RVA = "0x78D5E00", Offset = "0x78D5200", VA = "0x1878D5E00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OKFNDPEKGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC31B20", Offset = "0xC30F20", VA = "0x180C31B20")]
		internal bool IJKLGMHDBGA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D59410", Offset = "0x1D58810", VA = "0x181D59410")]
		internal bool CNMMAFJNNIJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC31B20", Offset = "0xC30F20", VA = "0x180C31B20")]
		internal bool FIKPMCEGOFL(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D59410", Offset = "0x1D58810", VA = "0x181D59410")]
		internal bool INIBKHNNNKP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> IBPHCMPFPOH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public LCKCFECPKIF(List<KeepsakeCategoryThemePair> NMJJCHCHHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78C5CF0", Offset = "0x78C50F0", VA = "0x1878C5CF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MDBONIONOAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x78C6520", Offset = "0x78C5920", VA = "0x1878C6520")]
		internal GOBMEFCJDOP<Guid> DBENCCLHIFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x78C6710", Offset = "0x78C5B10", VA = "0x1878C6710")]
		internal void HPKAOKIBBKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x78C6680", Offset = "0x78C5A80", VA = "0x1878C6680")]
		internal void GCHDFGNABAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x78C6110", Offset = "0x78C5510", VA = "0x1878C6110")]
		internal void AFBCDBFEGEO(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x78C66E0", Offset = "0x78C5AE0", VA = "0x1878C66E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OBLHPPGKMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x78D4C50", Offset = "0x78D4050", VA = "0x1878D4C50")]
		internal void BHCAONLFJGN(GMCONINGDKP response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x78D5000", Offset = "0x78D4400", VA = "0x1878D5000")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OHJNOLFOPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x78D5730", Offset = "0x78D4B30", VA = "0x1878D5730")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MMBNHILBNHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x78C6B30", Offset = "0x78C5F30", VA = "0x1878C6B30")]
		internal void NNJJCJJOBBF(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x78C6800", Offset = "0x78C5C00", VA = "0x1878C6800")]
		internal void GHNNHFCJJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x78C6830", Offset = "0x78C5C30", VA = "0x1878C6830")]
		internal GOBMEFCJDOP<IEnumerable<Guid>> JGEJMGMLOAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7435690", Offset = "0x7434A90", VA = "0x187435690")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OELLGGJILOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x78D55F0", Offset = "0x78D49F0", VA = "0x1878D55F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CKMENKFHDAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x78C48E0", Offset = "0x78C3CE0", VA = "0x1878C48E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PFLPDDBNNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x78D5750", Offset = "0x78D4B50", VA = "0x1878D5750")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LJMBILGBPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78C5FA0", Offset = "0x78C53A0", VA = "0x1878C5FA0")]
		internal GOBMEFCJDOP<IEnumerable<Guid>> EMEHKDGBAIG(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78C57A0", Offset = "0x78C4BA0", VA = "0x1878C57A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PPIKOODFFLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x78D5860", Offset = "0x78D4C60", VA = "0x1878D5860")]
		internal void CMIMHHPGFIK(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x78C6800", Offset = "0x78C5C00", VA = "0x1878C6800")]
		internal void HJJHGPLIIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x78D58F0", Offset = "0x78D4CF0", VA = "0x1878D58F0")]
		internal GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> OJCPNJOHCNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7435690", Offset = "0x7434A90", VA = "0x187435690")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DLKDEFJPAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x78C4B30", Offset = "0x78C3F30", VA = "0x1878C4B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IBHJLHPKNPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x78C5080", Offset = "0x78C4480", VA = "0x1878C5080")]
		internal bool DIEBNKPKDEK(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x78C5160", Offset = "0x78C4560", VA = "0x1878C5160")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DKALBBIGNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x23908F0", Offset = "0x238FCF0", VA = "0x1823908F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EDECGFLMIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x23908F0", Offset = "0x238FCF0", VA = "0x1823908F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JLOCLBOHFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x78C57C0", Offset = "0x78C4BC0", VA = "0x1878C57C0")]
		internal GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> OHNAJFAIIKL(Dictionary<Guid, LAHJBOFKJLL> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x78C57A0", Offset = "0x78C4BA0", VA = "0x1878C57A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public CFIPPBIBKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x78C4860", Offset = "0x78C3C60", VA = "0x1878C4860")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IHOGNJFKDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x78C5350", Offset = "0x78C4750", VA = "0x1878C5350")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BMNGEENBCJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xD417E0", Offset = "0xD40BE0", VA = "0x180D417E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GOKLHHKEIOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x78C4F30", Offset = "0x78C4330", VA = "0x1878C4F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IIEPKEAEBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD417E0", Offset = "0xD40BE0", VA = "0x180D417E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EGPJCAKNHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x78C4DC0", Offset = "0x78C41C0", VA = "0x1878C4DC0")]
		internal bool HHKGHOPDLAL(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x78C4D00", Offset = "0x78C4100", VA = "0x1878C4D00")]
		internal bool EHAHINBOAOO(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x78C4CE0", Offset = "0x78C40E0", VA = "0x1878C4CE0")]
		internal bool BDAFMNCKEMG(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78C4CE0", Offset = "0x78C40E0", VA = "0x1878C4CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GECCNEIPOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xDB0490", Offset = "0xDAF890", VA = "0x180DB0490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MJAJHGFLCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x78C6740", Offset = "0x78C5B40", VA = "0x1878C6740")]
		internal bool BEMGLFIGLDE(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2353830", Offset = "0x2352C30", VA = "0x182353830")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PHJKEHDPAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x78D5800", Offset = "0x78D4C00", VA = "0x1878D5800")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public LOGLCBDNPGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xDB0490", Offset = "0xDAF890", VA = "0x180DB0490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KMIPEEKDAGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x78C5A40", Offset = "0x78C4E40", VA = "0x1878C5A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public KHFPLPPGCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A530", Offset = "0x1F79930", VA = "0x181F7A530")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public IFNPLNNBLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x78C52F0", Offset = "0x78C46F0", VA = "0x1878C52F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ICPDEKNLBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x78C52B0", Offset = "0x78C46B0", VA = "0x1878C52B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EPNIFLBMEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A530", Offset = "0x1F79930", VA = "0x181F7A530")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public GLPICLCODED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x78C4EB0", Offset = "0x78C42B0", VA = "0x1878C4EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public DGOHLNLCIDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x78C4A40", Offset = "0x78C3E40", VA = "0x1878C4A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public JMGMLIGCPBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x78C59C0", Offset = "0x78C4DC0", VA = "0x1878C59C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D5060", Offset = "0x78D4460", VA = "0x1878D5060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x78D5590", Offset = "0x78D4990", VA = "0x1878D5590", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C54A0", Offset = "0x78C48A0", VA = "0x1878C54A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x78C5740", Offset = "0x78C4B40", VA = "0x1878C5740", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C1F60", Offset = "0x9C1360", VA = "0x1809C1F60", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C1D80", Offset = "0x9C1180", VA = "0x1809C1D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JJEPLINNHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78CCAC0", Offset = "0x78CBEC0", VA = "0x1878CCAC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BEBCFFMHNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x78C8AD0", Offset = "0x78C7ED0", VA = "0x1878C8AD0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long GHJFMHGHEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78CB2E0", Offset = "0x78CA6E0", VA = "0x1878CB2E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? LMIAIMBACDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78CFDD0", Offset = "0x78CF1D0", VA = "0x1878CFDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool NPBPONDFOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78CFA30", Offset = "0x78CEE30", VA = "0x1878CFA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> ODBBCHFIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0C680", Offset = "0xA0BA80", VA = "0x180A0C680", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> JOENDFHPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA04FC0", Offset = "0xA043C0", VA = "0x180A04FC0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> MMILFOHAFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1A500", Offset = "0xA19900", VA = "0x180A1A500", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> EJINNHECEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA099A0", Offset = "0xA08DA0", VA = "0x180A099A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool MDHNAFAENNF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD06B0", Offset = "0xACFAB0", VA = "0x180AD06B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> HBIILDIKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78D1B10", Offset = "0x78D0F10", VA = "0x1878D1B10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78D10A0", Offset = "0x78D04A0", VA = "0x1878D10A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action DEFGEONOPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78C8690", Offset = "0x78C7A90", VA = "0x1878C8690", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x78CBEC0", Offset = "0x78CB2C0", VA = "0x1878CBEC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FFAFPDPKGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78CF4E0", Offset = "0x78CE8E0", VA = "0x1878CF4E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78CFD30", Offset = "0x78CF130", VA = "0x1878CFD30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78D3680", Offset = "0x78D2A80", VA = "0x1878D3680")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NAIPLBCJFGL([CMKKAFOAFJE(null)][NotNull] CFLGIHOKKAL CPIBADAAELC, [NotNull][CMKKAFOAFJE(null)] MOALAMFEOFP PNCENFPCHLN, [NotNull][CMKKAFOAFJE(null)] MBLMMOAPNPC ENHPGJIPLKB, [NotNull][CMKKAFOAFJE(null)] PCJHNLFLINK FPBCPLIFHKA, [CMKKAFOAFJE(null)][NotNull] IIJCENGLKPN BHCIBFGHBLH, [CMKKAFOAFJE(null)][NotNull] LGIJHFEOCEK LMJMNPPPAHL, [CMKKAFOAFJE(null)][NotNull] NHHFHOCOGEC DNDEINMDIFI, [NotNull][CMKKAFOAFJE(null)] FKLBCLNGIJH JGGPEAFECGJ, [NotNull][CMKKAFOAFJE(null)] FMKBFEIFICC BOGAODIGBEK, [NotNull][CMKKAFOAFJE(null)] KEOINNCCKOJ LKHLAPFIFNG, [NotNull][CMKKAFOAFJE(null)] EMNMJALBIKI KCDOKAOGGDF, [NotNull][CMKKAFOAFJE(null)] EOIPCPHMHDA GEFMJHDAIEM, [NotNull][CMKKAFOAFJE(null)] MKEHAOLCFAM PKMFECLHKLB, [NotNull][CMKKAFOAFJE(null)] FDLGHKBFDFJ FBFPHGFBKEP, [CMKKAFOAFJE(null)][NotNull] JBKHHJPCACA MFJJDIDOLLB, [CMKKAFOAFJE(null)][NotNull] NLHJGDPBHNK IHPAONIPNJI, [NotNull][CMKKAFOAFJE(null)] ENCEHJNHPBL HKNGEHEEHMP, [CMKKAFOAFJE(null)][NotNull] OAODAKEKPCL<KeepsakesConfig.KeepsakesOptions> FBCMGOKFCPJ, [NotNull][CMKKAFOAFJE(null)] NNOOHIAHMIG ENFLKMBLIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x78CA990", Offset = "0x78C9D90", VA = "0x1878CA990", Slot = "15")]
	public bool DBGBPJGMPCP(List<string> MHPNIEANAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x78C8070", Offset = "0x78C7470", VA = "0x1878C8070", Slot = "16")]
	public GOBMEFCJDOP<Guid> BHNJBIBMAGJ(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x78D33D0", Offset = "0x78D27D0", VA = "0x1878D33D0", Slot = "17")]
	public DJNFHDJGNJD PDNMPAOGADG(Guid LMJKJEPMLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78CD3D0", Offset = "0x78CC7D0", VA = "0x1878CD3D0", Slot = "18")]
	public DJNFHDJGNJD HBJNFJLANOP(Guid LMJKJEPMLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x78CFE60", Offset = "0x78CF260", VA = "0x1878CFE60", Slot = "19")]
	public bool LIKPGAGPKNM(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x78D3650", Offset = "0x78D2A50", VA = "0x1878D3650", Slot = "20")]
	public bool PFJKEKIMDLH(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78D0BA0", Offset = "0x78CFFA0", VA = "0x1878D0BA0")]
	public KeepsakeTheme MDEAHCLOAII(Guid LMJKJEPMLBH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x78D1710", Offset = "0x78D0B10", VA = "0x1878D1710")]
	public bool MMBKIEMFOAM(LAHJBOFKJLL CNOKJKFMJAG, [Out] KeepsakeTheme EOHCGFNFDBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x78D1150", Offset = "0x78D0550", VA = "0x1878D1150")]
	public List<KeepsakeTheme> MGMGCCEMPCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x78CE610", Offset = "0x78CDA10", VA = "0x1878CE610")]
	public int JALKNDOKKIO(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x78CED00", Offset = "0x78CE100", VA = "0x1878CED00")]
	public LAHJBOFKJLL JMLABIOBJCF(Guid LMJKJEPMLBH)
	{
		return default(LAHJBOFKJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x78CFA40", Offset = "0x78CEE40", VA = "0x1878CFA40", Slot = "34")]
	public List<LAHJBOFKJLL> LEMFMJMKJFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x78CDCA0", Offset = "0x78CD0A0", VA = "0x1878CDCA0", Slot = "35")]
	public IComparer<LAHJBOFKJLL> HOJOPMCHNCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x78CFB90", Offset = "0x78CEF90", VA = "0x1878CFB90", Slot = "32")]
	public string LFIENEBGBGF(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x78CB7F0", Offset = "0x78CABF0", VA = "0x1878CB7F0", Slot = "33")]
	public string ELMGNJJFBGG(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x78CDF80", Offset = "0x78CD380", VA = "0x1878CDF80", Slot = "21")]
	public bool IEKIOKGFJFF(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x78CAE10", Offset = "0x78CA210", VA = "0x1878CAE10", Slot = "22")]
	public void DNJBCEDBFPM(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x78D2250", Offset = "0x78D1650", VA = "0x1878D2250", Slot = "23")]
	public void NPAEOOLABAJ(LAHJBOFKJLL CNOKJKFMJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x78C8730", Offset = "0x78C7B30", VA = "0x1878C8730", Slot = "24")]
	public void BLGKCKGEFMK(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78CCB10", Offset = "0x78CBF10", VA = "0x1878CCB10", Slot = "25")]
	public int GKKPKFPAKNO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78C6E50", Offset = "0x78C6250", VA = "0x1878C6E50", Slot = "31")]
	public GOBMEFCJDOP<IEnumerable<Guid>> AHNAJMDDHJH(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x78C8B90", Offset = "0x78C7F90", VA = "0x1878C8B90", Slot = "30")]
	public GOBMEFCJDOP<IEnumerable<Guid>> CDNBPNPAFME(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x78D3020", Offset = "0x78D2420", VA = "0x1878D3020", Slot = "54")]
	public GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> PCAKEPGIEKF(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x78CC170", Offset = "0x78CB570", VA = "0x1878CC170", Slot = "55")]
	public GOBMEFCJDOP<Dictionary<Guid, LAHJBOFKJLL>> GBADPCILANF(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x78CD820", Offset = "0x78CCC20", VA = "0x1878CD820", Slot = "26")]
	public GOBMEFCJDOP<int> HEEMGPHOGGC(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x78C8970", Offset = "0x78C7D70", VA = "0x1878C8970", Slot = "27")]
	public GOBMEFCJDOP<int> BPICKGIDCGJ(long MIFADOBCMAC, long POLFGGGEODA, LAHJBOFKJLL? CNOKJKFMJAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x78C7930", Offset = "0x78C6D30", VA = "0x1878C7930", Slot = "28")]
	public GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> BCIKCCHELBB(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x78C7FB0", Offset = "0x78C73B0", VA = "0x1878C7FB0", Slot = "29")]
	public GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> BGLADIKMFFI(long MIFADOBCMAC, long POLFGGGEODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x78CF9D0", Offset = "0x78CEDD0", VA = "0x1878CF9D0", Slot = "37")]
	public bool LDKGKOCNOFK(long MIFADOBCMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x78CC780", Offset = "0x78CBB80", VA = "0x1878CC780", Slot = "56")]
	public bool GHBGJJLIEMB(long MIFADOBCMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x78CD780", Offset = "0x78CCB80", VA = "0x1878CD780", Slot = "38")]
	public bool HDFNKDINIOH(long MIFADOBCMAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x78C7BD0", Offset = "0x78C6FD0", VA = "0x1878C7BD0", Slot = "57")]
	public bool BFGDDBIHBPL(long MIFADOBCMAC, [Out] JAKODCCBCFO ICIBOIABFIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x78D1910", Offset = "0x78D0D10", VA = "0x1878D1910", Slot = "39")]
	public bool MPHDLJMBKHA(long OEDBLEJCIMJ, [Out] DateTime ANJKOMDGAAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x78D0660", Offset = "0x78CFA60", VA = "0x1878D0660", Slot = "40")]
	public long LMBIKBCHEDI(long OEDBLEJCIMJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x78D2F10", Offset = "0x78D2310", VA = "0x1878D2F10", Slot = "41")]
	public long PBNICGFGNIE(long MIFADOBCMAC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x78CF580", Offset = "0x78CE980", VA = "0x1878CF580", Slot = "42")]
	public int LBEDILFIGDO(long OEDBLEJCIMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x78C7380", Offset = "0x78C6780", VA = "0x1878C7380", Slot = "43")]
	public bool APNHNNMMDNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x78CF2A0", Offset = "0x78CE6A0", VA = "0x1878CF2A0", Slot = "44")]
	public bool KGNOGHFBJPF(long OEDBLEJCIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x78CF760", Offset = "0x78CEB60", VA = "0x1878CF760", Slot = "45")]
	public IReadOnlyList<long> LBNFKFDFDPN(long OEDBLEJCIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x78CF430", Offset = "0x78CE830", VA = "0x1878CF430", Slot = "46")]
	public int KHCJLLPIAGK(long OEDBLEJCIMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x78CA480", Offset = "0x78C9880", VA = "0x1878CA480", Slot = "50")]
	public long CNGHGDGDHEM(long GLKDPBBDFJD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x78CE990", Offset = "0x78CDD90", VA = "0x1878CE990", Slot = "51")]
	public LAHJBOFKJLL JENLMGEDKLA()
	{
		return default(LAHJBOFKJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x78CBD90", Offset = "0x78CB190", VA = "0x1878CBD90")]
	private bool FEBODEAMOOJ(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x78C7460", Offset = "0x78C6860", VA = "0x1878C7460")]
	private void BBFKMOJHNLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x78CB3B0", Offset = "0x78CA7B0", VA = "0x1878CB3B0")]
	private LAHJBOFKJLL EIHNEBKDKAE()
	{
		return default(LAHJBOFKJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x78D0020", Offset = "0x78CF420", VA = "0x1878D0020")]
	private void LLFLGBGLGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x78CE470", Offset = "0x78CD870", VA = "0x1878CE470")]
	private int JAHDJMFKBEF(KeepsakeRoomListDTO FPLGKICJMMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x78C92E0", Offset = "0x78C86E0", VA = "0x1878C92E0")]
	private int CLECCLKNKIB(DateTime NCEJPDOCPEN, DateTime PPPLOIPHDGD, TimeSpan KMIDHKGBONJ, int HCFNHLPAMJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x78C6BC0", Offset = "0x78C5FC0", VA = "0x1878C6BC0")]
	private void ABFFLAPEMGC(IEnumerable<KeepsakeInstanceDTO> KLFPONPJPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x78CA740", Offset = "0x78C9B40", VA = "0x1878CA740")]
	private void DAOENFIALKH(IEnumerable<KeepsakeCollectionRecordDTO> ECGNCLBPGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x78D27C0", Offset = "0x78D1BC0", VA = "0x1878D27C0")]
	private void OILCGLAKGME(IEnumerable<long> PENMIKHIIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA29010", Offset = "0xA28410", VA = "0x180A29010")]
	private void IDKAONKMPGL(KeepsakeGlobalConfigDTO LFIAPJIIDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78C8E60", Offset = "0x78C8260", VA = "0x1878C8E60")]
	private bool CKBNOLEEOJL(LAHJBOFKJLL CNOKJKFMJAG, [Out] Guid NADBGBHIJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x78CC0D0", Offset = "0x78CB4D0", VA = "0x1878CC0D0")]
	private bool FPLNEJNOHNL([Out] Guid NADBGBHIJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x78CFFC0", Offset = "0x78CF3C0", VA = "0x1878CFFC0")]
	private bool LKFBEANGNCH(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x78CB690", Offset = "0x78CAA90", VA = "0x1878CB690")]
	private IEnumerable<Guid> EIPOBGODLML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x78CAD50", Offset = "0x78CA150", VA = "0x1878CAD50")]
	private IEnumerable<KeepsakeInstanceDTO> DJHCNNIOGBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x78C7B40", Offset = "0x78C6F40", VA = "0x1878C7B40")]
	private void BFFECOOKFPP(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x78CCF50", Offset = "0x78CC350", VA = "0x1878CCF50")]
	private bool GNFBJHFAEJE(Guid LMJKJEPMLBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x78C93E0", Offset = "0x78C87E0", VA = "0x1878C93E0")]
	private void CLFCFDIFDCC(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x78D2170", Offset = "0x78D1570", VA = "0x1878D2170")]
	private void NOIMFJHLGPK(LAHJBOFKJLL CMAMNCPNLFL, int ABOELGBENAG, Dictionary<LAHJBOFKJLL, int> DFNJIGBBNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x78CDE90", Offset = "0x78CD290", VA = "0x1878CDE90")]
	private int IALNGPHMKEH(LAHJBOFKJLL CNOKJKFMJAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78D2D40", Offset = "0x78D2140", VA = "0x1878D2D40")]
	private void PAKECBHECAC(KeepsakeInstanceDTO JJHBOKJAOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x78C90D0", Offset = "0x78C84D0", VA = "0x1878C90D0")]
	private void CLEAGPJFCLL(KeepsakeInstanceDTO JJHBOKJAOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x78CD000", Offset = "0x78CC400", VA = "0x1878CD000")]
	private void GOGHODJEDON(Guid LMJKJEPMLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x78C7F80", Offset = "0x78C7380", VA = "0x1878C7F80")]
	private void GGHMJLGJFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x78CAC20", Offset = "0x78CA020", VA = "0x1878CAC20")]
	private void DDGCJOLKINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x78CE220", Offset = "0x78CD620", VA = "0x1878CE220")]
	private void IGAHIJEFIKF(BMAMFBAMLOB GKBKHGJHGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x78C7F80", Offset = "0x78C7380", VA = "0x1878C7F80")]
	private void BGCINLNAPLH(BFPGFECOPIK BLFGIKOAKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x78C7F80", Offset = "0x78C7380", VA = "0x1878C7F80")]
	private void NGHGGFMHAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x78CC300", Offset = "0x78CB700", VA = "0x1878CC300")]
	private void GDPFMDEPNBD(float ENOGEACDIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x78D1BC0", Offset = "0x78D0FC0", VA = "0x1878D1BC0")]
	private void NOCODPJHFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x78CE790", Offset = "0x78CDB90", VA = "0x1878CE790")]
	private bool JCDLEPBHBLD(Guid LMJKJEPMLBH, [Out] string INNEGDLMOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x78D2900", Offset = "0x78D1D00", VA = "0x1878D2900")]
	private bool OLHLBKJHCDK(Guid LMJKJEPMLBH, [Out] KeepsakeCategoryConfigDTO CMAMNCPNLFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x78D2820", Offset = "0x78D1C20", VA = "0x1878D2820")]
	private void OJDEHPHMJEL(string AHEBBEAMAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x78CAC40", Offset = "0x78CA040", VA = "0x1878CAC40")]
	private bool DHDNGGKIAGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x78CC7E0", Offset = "0x78CBBE0", VA = "0x1878CC7E0")]
	private List<long> GHDICAKDDEB(IEnumerable<KeepsakeRoomDTO> JBLJONBMMME, IReadOnlyList<KeepsakeRoomListDTO> MKAOPDHIFNP, long OEDBLEJCIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x78D22A0", Offset = "0x78D16A0", VA = "0x1878D22A0")]
	private bool OIKKJDFLGHJ(Guid LMJKJEPMLBH, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x78D1A50", Offset = "0x78D0E50", VA = "0x1878D1A50", Slot = "47")]
	public string MPIOFJDHLCA(JABHBPEAHIK ILDGOGHMDCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x78CEE60", Offset = "0x78CE260", VA = "0x1878CEE60", Slot = "49")]
	public string JNGEPBHJKOE(JABHBPEAHIK ILDGOGHMDCB, long MIFADOBCMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x78CC6A0", Offset = "0x78CBAA0", VA = "0x1878CC6A0", Slot = "48")]
	public string GFOPIOKBEPN(JABHBPEAHIK ILDGOGHMDCB, int GCKHFLINCCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x78C9580", Offset = "0x78C8980", VA = "0x1878C9580")]
	private void CNAKOEPJDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x78CE290", Offset = "0x78CD690", VA = "0x1878CE290")]
	private void IJGCKLANPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x78CFD10", Offset = "0x78CF110", VA = "0x1878CFD10")]
	private JABHBPEAHIK LGJKHACPIFK(BDANJMAPMIG KEJHEJGOCLK)
	{
		return default(JABHBPEAHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x78D18F0", Offset = "0x78D0CF0", VA = "0x1878D18F0")]
	private JABHBPEAHIK MMPCOOEJJNP(BDANJMAPMIG KEJHEJGOCLK)
	{
		return default(JABHBPEAHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78CB9F0", Offset = "0x78CADF0", VA = "0x1878CB9F0")]
	internal static string EOHFAFBAOOP(GMCONINGDKP DLNNHCPPFNB, string FPBJFCGKBOC, bool FNJFIOAAENO, int KDEHMPJOPFH, int BHAMAMAMEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x78CAE80", Offset = "0x78CA280", VA = "0x1878CAE80", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x78CB970", Offset = "0x78CAD70", VA = "0x1878CB970")]
	private OGJPCDKPGHL EMIEJNGBIJL(DNIGIBHMBIB BPMEJAFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x78CBBD0", Offset = "0x78CAFD0", VA = "0x1878CBBD0")]
	private HHAPIHFLFHJ FCHIBFAALIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x78D0CE0", Offset = "0x78D00E0", VA = "0x1878D0CE0")]
	private Task MEMGLGGLKEI(FEJGNMMNDHD BPKDFLJLPAA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x78D1600", Offset = "0x78D0A00", VA = "0x1878D1600")]
	[AsyncStateMachine(typeof(OCDEEOBKOMC))]
	private Task MIHNICIOOAL(FEJGNMMNDHD BPKDFLJLPAA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x78D2AD0", Offset = "0x78D1ED0", VA = "0x1878D2AD0")]
	private Task OLLLFFPKMFD(FEJGNMMNDHD BPKDFLJLPAA, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x78CDD60", Offset = "0x78CD160", VA = "0x1878CDD60")]
	[AsyncStateMachine(typeof(JIBOFAACHNH))]
	private Task IAAJAHHBFGO(string DAMFJFKKFBI, TimeSpan LCCNAJIJFFB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x78CD760", Offset = "0x78CCB60", VA = "0x1878CD760")]
	[CompilerGenerated]
	private void HCHKFPHEADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x78CE420", Offset = "0x78CD820", VA = "0x1878CE420")]
	[CompilerGenerated]
	private void IOAMMAPBGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x78D1500", Offset = "0x78D0900", VA = "0x1878D1500")]
	[CompilerGenerated]
	private bool MIFMJDMNJDM(KeepsakeInstanceDTO MEAMPLHPPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x78C7210", Offset = "0x78C6610", VA = "0x1878C7210")]
	[CompilerGenerated]
	private GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> AIGOFIHCEOL(Dictionary<Guid, LAHJBOFKJLL> HONDLNIMKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x78CBF60", Offset = "0x78CB360", VA = "0x1878CBF60")]
	[CompilerGenerated]
	private GOBMEFCJDOP<Dictionary<LAHJBOFKJLL, int>> FPCIBNONINH(Dictionary<Guid, LAHJBOFKJLL> HONDLNIMKFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x78CF280", Offset = "0x78CE680", VA = "0x1878CF280")]
	[CompilerGenerated]
	private bool KAOAIHPMCKI(KeepsakeRoomListDTO MEAMPLHPPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x78C8D30", Offset = "0x78C8130", VA = "0x1878C8D30")]
	[CompilerGenerated]
	private bool CHBMIEKOHHA(KeepsakeInstanceDTO MEAMPLHPPKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x78D2BB0", Offset = "0x78D1FB0", VA = "0x1878D2BB0")]
	[CompilerGenerated]
	private void PACAIADPCFJ(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<LAHJBOFKJLL, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> EOMAKEGNGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x78D1AB0", Offset = "0x78D0EB0", VA = "0x1878D1AB0")]
	[CompilerGenerated]
	private void NBHCPPLMIAM(string AFHGIBDEPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x78CDAE0", Offset = "0x78CCEE0", VA = "0x1878CDAE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
				public CMLIEELHCFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x78C4A10", Offset = "0x78C3E10", VA = "0x1878C4A10")]
				internal bool FIFLIJKOIJH(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x78C4A10", Offset = "0x78C3E10", VA = "0x1878C4A10")]
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
			[Cpp2IlInjected.Address(RVA = "0x78C5B20", Offset = "0x78C4F20", VA = "0x1878C5B20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x78C5AA0", Offset = "0x78C4EA0", VA = "0x1878C5AA0")]
		[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
		internal static void BBLAOBGDHMG(DHLGDCALOEP NKMJDOBLHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAFB4C0", Offset = "0xAFA8C0", VA = "0x180AFB4C0")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x8359060", Offset = "0x8357A60", VA = "0x188359060", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LMGOCBNHBOL : IComparer<KCEPIFFHDBI>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class HGHFKOHDFMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KCEPIFFHDBI x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public KCEPIFFHDBI y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HGHFKOHDFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE4E150", Offset = "0xE4CB50", VA = "0x180E4E150")]
		internal bool ICCKJHDFAFJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2178020", Offset = "0x2176A20", VA = "0x182178020")]
		internal bool CDHFAPOGKIO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE4E150", Offset = "0xE4CB50", VA = "0x180E4E150")]
		internal bool IPFNFKPDMEJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2178020", Offset = "0x2176A20", VA = "0x182178020")]
		internal bool HCMIGIIDMPO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> IGJLIHECFII;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public LMGOCBNHBOL(List<KeepsakeCategoryThemePair> JDDABFFLIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x83583E0", Offset = "0x8356DE0", VA = "0x1883583E0", Slot = "4")]
	public int Compare(KCEPIFFHDBI IECENJOJFJH, KCEPIFFHDBI OFOCBNJJIJE)
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
		public KCEPIFFHDBI KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[IHCCCAONNEJ]
public class EKDBILIFJLN : NGILPANNKKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KKAFBMECLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public EKDBILIFJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KCEPIFFHDBI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KKAFBMECLNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83573F0", Offset = "0x8355DF0", VA = "0x1883573F0")]
		internal DPMDGLGHBHJ<Guid> MKHGLJPJIHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8356F20", Offset = "0x8355920", VA = "0x188356F20")]
		internal void CGJEFIEHCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8356F50", Offset = "0x8355950", VA = "0x188356F50")]
		internal void DCFMKGDBGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8356FB0", Offset = "0x83559B0", VA = "0x188356FB0")]
		internal void IAIPCIHLAAI(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83573C0", Offset = "0x8355DC0", VA = "0x1883573C0")]
		internal void KEFFKLNBGMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LMDBFBIGHKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public EKDBILIFJLN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LMDBFBIGHKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8357FD0", Offset = "0x83569D0", VA = "0x188357FD0")]
		internal void GFDEMKPDCPG(PCCPNEPHNLM response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8358380", Offset = "0x8356D80", VA = "0x188358380")]
		internal void MOIBGNHIKJD(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LNJNEFDALIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LNJNEFDALIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8358690", Offset = "0x8357090", VA = "0x188358690")]
		internal bool GDCDAOELBFC(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CPLJBCBNKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EKDBILIFJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public KCEPIFFHDBI? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CPLJBCBNKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8348830", Offset = "0x8347230", VA = "0x188348830")]
		internal void CODCFOANKBD(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8347D60", Offset = "0x8346760", VA = "0x188347D60")]
		internal void GCCHNNCCEON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8348530", Offset = "0x8346F30", VA = "0x188348530")]
		internal DPMDGLGHBHJ<IEnumerable<Guid>> BICEJMKLLGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E26350", Offset = "0x7E24D50", VA = "0x187E26350")]
		internal bool HCHHCFNIHFP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GABGLGLDGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CPLJBCBNKJH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GABGLGLDGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8356930", Offset = "0x8355330", VA = "0x188356930")]
		internal DPMDGLGHBHJ<IEnumerable<Guid>> GKNMMCJADGF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class MHDFGGHMGJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GABGLGLDGFK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public MHDFGGHMGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83586B0", Offset = "0x83570B0", VA = "0x1883586B0")]
		internal bool HHNDHCOPDJN(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JELICGPHIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public MHDFGGHMGJK CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JELICGPHIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8356CC0", Offset = "0x83556C0", VA = "0x188356CC0")]
		internal bool OKEOPPPPJJI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HNLHAGOBNPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EKDBILIFJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HNLHAGOBNPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8356B50", Offset = "0x8355550", VA = "0x188356B50")]
		internal DPMDGLGHBHJ<IEnumerable<Guid>> BBCLGLPCIPP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8348110", Offset = "0x8346B10", VA = "0x188348110")]
		internal bool LCANCJECFFE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BEMEOGMACGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public EKDBILIFJLN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BEMEOGMACGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8348080", Offset = "0x8346A80", VA = "0x188348080")]
		internal void OAKEJOLMFCM(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8347D60", Offset = "0x8346760", VA = "0x188347D60")]
		internal void CIFKFGDHPOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8347D90", Offset = "0x8346790", VA = "0x188347D90")]
		internal DPMDGLGHBHJ<Dictionary<Guid, KCEPIFFHDBI>> GNLJGGPLNCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E26350", Offset = "0x7E24D50", VA = "0x187E26350")]
		internal bool PKCICNCGEOF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class KCKMMLMHHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KCKMMLMHHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8356D70", Offset = "0x8355770", VA = "0x188356D70")]
		internal DPMDGLGHBHJ<Dictionary<Guid, KCEPIFFHDBI>> EPJLKMPCOHN(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OJMINEKMIFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OJMINEKMIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8358D60", Offset = "0x8357760", VA = "0x188358D60")]
		internal bool LMKLOIEGGLH(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8358C10", Offset = "0x8357610", VA = "0x188358C10")]
		internal KeyValuePair<Guid, KCEPIFFHDBI> GIONMBKNMNE(Guid instanceId)
		{
			return default(KeyValuePair<Guid, KCEPIFFHDBI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class BHJAMEAGMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BHJAMEAGMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xFF6FA0", Offset = "0xFF59A0", VA = "0x180FF6FA0")]
		internal bool JDDINENFLMA(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KFEPPLJGDPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KFEPPLJGDPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xFF6FA0", Offset = "0xFF59A0", VA = "0x180FF6FA0")]
		internal bool KFGOJCKACFB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BGADHJGNEJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public EKDBILIFJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BGADHJGNEJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8348130", Offset = "0x8346B30", VA = "0x188348130")]
		internal DPMDGLGHBHJ<Dictionary<Guid, KCEPIFFHDBI>> JPLFHBMOHMA(Dictionary<Guid, KCEPIFFHDBI> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8348110", Offset = "0x8346B10", VA = "0x188348110")]
		internal bool FFGOCCPILBP(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class HGHMACHIIAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public HGHMACHIIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8356AD0", Offset = "0x83554D0", VA = "0x188356AD0")]
		internal bool LOIEGKINGKK(KeyValuePair<Guid, KCEPIFFHDBI> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LBNPGGGPKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, KCEPIFFHDBI> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LBNPGGGPKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8357D30", Offset = "0x8356730", VA = "0x188357D30")]
		internal KeyValuePair<KCEPIFFHDBI, int> PNKAHNBMGOK(KCEPIFFHDBI category)
		{
			return default(KeyValuePair<KCEPIFFHDBI, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FAEKGGDAKII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public KCEPIFFHDBI category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public FAEKGGDAKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xF650D0", Offset = "0xF63AD0", VA = "0x180F650D0")]
		internal bool CGKKOMLKAMI(KCEPIFFHDBI instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ANFMFKANGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, KCEPIFFHDBI> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ANFMFKANGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8347C10", Offset = "0x8346610", VA = "0x188347C10")]
		internal KeyValuePair<KCEPIFFHDBI, int> EFNIBJGPMOE(KCEPIFFHDBI category)
		{
			return default(KeyValuePair<KCEPIFFHDBI, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class NBNEOLALPDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public KCEPIFFHDBI category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NBNEOLALPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF650D0", Offset = "0xF63AD0", VA = "0x180F650D0")]
		internal bool OMAIGNLKOIP(KCEPIFFHDBI instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class COCBKELMALB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public EKDBILIFJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public COCBKELMALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8348360", Offset = "0x8346D60", VA = "0x188348360")]
		internal bool CJBIIPLIBKB(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8348450", Offset = "0x8346E50", VA = "0x188348450")]
		internal bool EJKMCCEGAFI(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8348510", Offset = "0x8346F10", VA = "0x188348510")]
		internal bool OKKLEPEOHMM(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8348510", Offset = "0x8346F10", VA = "0x188348510")]
		internal bool FFOBPIEOAOA(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class KABIIHHEAPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public KABIIHHEAPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xFD7070", Offset = "0xFD5A70", VA = "0x180FD7070")]
		internal bool JAJPPLEMDDJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NGIBOFNFFNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NGIBOFNFFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83587E0", Offset = "0x83571E0", VA = "0x1883587E0")]
		internal bool OHBECOMCCFH(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x27C0330", Offset = "0x27BED30", VA = "0x1827C0330")]
		internal bool HMOPNHECEIA(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GAIJKKBBGKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GAIJKKBBGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8356A70", Offset = "0x8355470", VA = "0x188356A70")]
		internal bool OEPGNMGKKNK(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DADPODBEKJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public DADPODBEKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xFD7070", Offset = "0xFD5A70", VA = "0x180FD7070")]
		internal bool MNJLKFKAALE(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AEMEMIOIKEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AEMEMIOIKEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8347B30", Offset = "0x8346530", VA = "0x188347B30")]
		internal bool HIJGHKGNCCA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class ENJCBCEJGII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public KCEPIFFHDBI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ENJCBCEJGII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x23BEC50", Offset = "0x23BD650", VA = "0x1823BEC50")]
		internal bool KBABDPEFELB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LHBMPFKACDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LHBMPFKACDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8357E80", Offset = "0x8356880", VA = "0x188357E80")]
		internal bool PJKEEJGLCKH(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AECNKFPAHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KCEPIFFHDBI keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public AECNKFPAHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8347AF0", Offset = "0x83464F0", VA = "0x188347AF0")]
		internal bool IGBPALBBONA(KeyValuePair<Guid, KCEPIFFHDBI> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PKOOPGCEDGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public KCEPIFFHDBI newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PKOOPGCEDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x23BEC50", Offset = "0x23BD650", VA = "0x1823BEC50")]
		internal bool DPGMDDHMOOJ(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ANEKDDDGGJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public ANEKDDDGGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8347B90", Offset = "0x8346590", VA = "0x188347B90")]
		internal bool JINOOIJEELB(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LJGNLFHOFKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LJGNLFHOFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8357EE0", Offset = "0x83568E0", VA = "0x188357EE0")]
		internal bool GKMAJNGGLCB(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class OHNGANJBLKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LJGNLFHOFKI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public OHNGANJBLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8358B90", Offset = "0x8357590", VA = "0x188358B90")]
		internal bool NGFOHHPLKNG(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct LBCHPHAKILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EKDBILIFJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public ALPHANGLKLD args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83577A0", Offset = "0x83561A0", VA = "0x1883577A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8357CD0", Offset = "0x83566D0", VA = "0x188357CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct NNJLPIDLCLO : IAsyncStateMachine
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
		public EKDBILIFJLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x83588A0", Offset = "0x83572A0", VA = "0x1883588A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8358B30", Offset = "0x8357530", VA = "0x188358B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime PPHLADDBPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PAEPHNDLHGC NGJCDCGBHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CDAOPLGKBOG EIAEAFGKNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DEJNEHNDCOE NOGHOHEBCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CMHOPIFKBPM ICLJDCHPALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PGOMLIKIJEK MBIPODKGFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GIJGNMIJPFI KBAKPPLFLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NEAJMIIPJPB PGGKFPINHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JEJOFHIOJBA HFINBJNJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly JFAKEFFKLPM DOKLLKEKPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly DOBMMJFGACH LKANEDOANEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MEFCPBHEKGO EJEEKHEBLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FAKECEEIPGB DIPEEFGFEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly KGFKJFFLCNF FHMECNNMBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AFKNABIJHJM JIEKHPOJENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly JBEAJCDGOAE FHJFJFFNNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly NEGJJIMNMJB<KeepsakesConfig.KeepsakesOptions> HHMKDMNANOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly DBKGBEHKCFL HENOFOKJKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> HNEHDNDCJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> BEPMAFPAMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> POCOBPCELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<KCEPIFFHDBI, int> GJNFJLFNLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> OELGAIILBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable BFCJENBLOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task FDKINPHCJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private DPMDGLGHBHJ<Guid> BPLHACDECIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? CCEHBNPGADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO IGLNHPGBJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private DPMDGLGHBHJ<KeepsakeProgressionEventInstancesDTO> ILPKLDIGNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<KCEPIFFHDBI, KeepsakeCategoryConfigDTO> GPBANMGEHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO LLBPCGNJEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> NPGHOHELBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> AMOPPDGMALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> JKJILIJADKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> LEMCHMPDCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> OKHPJCMFMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> JFIJMNHMIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> FHIFOCGKBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> CDJGHIPKEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NKLDHLNBMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GKGDKIAEEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> LFMMGGJFNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> FEELPHDIKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime BDNPHBGAKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable EBGCOFJKHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, KCEPIFFHDBI> DMNKBEGPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<KCEPIFFHDBI, int> HABOJOGJMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> JDDABFFLIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private LMGOCBNHBOL JLIIFIEEENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool CHAPCLILECB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EBMAJNHPIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAB31A0", Offset = "0xAB1BA0", VA = "0x180AB31A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GKIGCDEKDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x834B6A0", Offset = "0x834A0A0", VA = "0x18834B6A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EDDKFEHABFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x834DFC0", Offset = "0x834C9C0", VA = "0x18834DFC0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long LJOEDKDDBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x834AC00", Offset = "0x8349600", VA = "0x18834AC00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? NHDBKFKCGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x834FB00", Offset = "0x834E500", VA = "0x18834FB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool LHNNNNDHLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x834B690", Offset = "0x834A090", VA = "0x18834B690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> PGJNMNMHDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBE9A80", Offset = "0xBE8480", VA = "0x180BE9A80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> OKFMKIPNDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xBDB970", Offset = "0xBDA370", VA = "0x180BDB970", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> BJNKIEAKKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBF8800", Offset = "0xBF7200", VA = "0x180BF8800", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> EJHGKIGEMHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBE24F0", Offset = "0xBE0EF0", VA = "0x180BE24F0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool BPHPDEECDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB48240", Offset = "0xB46C40", VA = "0x180B48240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> BHEKKCMEFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x834FCF0", Offset = "0x834E6F0", VA = "0x18834FCF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83530F0", Offset = "0x8351AF0", VA = "0x1883530F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action JNMMHGKGEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x834D3A0", Offset = "0x834BDA0", VA = "0x18834D3A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8349980", Offset = "0x8348380", VA = "0x188349980", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PLAFENBBPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8353E20", Offset = "0x8352820", VA = "0x188353E20", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x834FDA0", Offset = "0x834E7A0", VA = "0x18834FDA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8355360", Offset = "0x8353D60", VA = "0x188355360")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EKDBILIFJLN([LNLOHEINMEO(null)][NotNull] PAEPHNDLHGC NGJCDCGBHID, [NotNull][LNLOHEINMEO(null)] JPFNCIEFDND CKOPEGDGOOO, [NotNull][LNLOHEINMEO(null)] CDAOPLGKBOG EIAEAFGKNMC, [NotNull][LNLOHEINMEO(null)] DEJNEHNDCOE NOGHOHEBCMP, [LNLOHEINMEO(null)][NotNull] CMHOPIFKBPM ICLJDCHPALF, [LNLOHEINMEO(null)][NotNull] PGOMLIKIJEK MBIPODKGFBO, [LNLOHEINMEO(null)][NotNull] GIJGNMIJPFI KBAKPPLFLKG, [NotNull][LNLOHEINMEO(null)] NEAJMIIPJPB PGGKFPINHMM, [NotNull][LNLOHEINMEO(null)] JEJOFHIOJBA HFINBJNJOEI, [NotNull][LNLOHEINMEO(null)] HEFLGLHEHDB IJEFLJEDBKG, [NotNull][LNLOHEINMEO(null)] JFAKEFFKLPM DOKLLKEKPCP, [NotNull][LNLOHEINMEO(null)] DOBMMJFGACH LKANEDOANEL, [NotNull][LNLOHEINMEO(null)] MEFCPBHEKGO EJEEKHEBLFH, [NotNull][LNLOHEINMEO(null)] FAKECEEIPGB DIPEEFGFEAM, [LNLOHEINMEO(null)][NotNull] KGFKJFFLCNF FHMECNNMBBF, [LNLOHEINMEO(null)][NotNull] AFKNABIJHJM JIEKHPOJENC, [NotNull][LNLOHEINMEO(null)] JBEAJCDGOAE FHJFJFFNNON, [LNLOHEINMEO(null)][NotNull] NEGJJIMNMJB<KeepsakesConfig.KeepsakesOptions> HHMKDMNANOF, [NotNull][LNLOHEINMEO(null)] DBKGBEHKCFL HENOFOKJKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x834F2E0", Offset = "0x834DCE0", VA = "0x18834F2E0", Slot = "15")]
	public bool HAOGFKPKAND(List<string> CKFPEPEIIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8354390", Offset = "0x8352D90", VA = "0x188354390", Slot = "16")]
	public DPMDGLGHBHJ<Guid> PDDCLBEJFMP(KCEPIFFHDBI IPEDAEKNAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x834F060", Offset = "0x834DA60", VA = "0x18834F060", Slot = "17")]
	public PNBAKNHPHGJ GPHCAJCJICA(Guid DFAIPONKOEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8352AB0", Offset = "0x83514B0", VA = "0x188352AB0", Slot = "18")]
	public PNBAKNHPHGJ MFKBGOFOBBD(Guid DFAIPONKOEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8351F00", Offset = "0x8350900", VA = "0x188351F00", Slot = "19")]
	public bool KPBOIEBAJOO(Guid DFAIPONKOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8349EF0", Offset = "0x83488F0", VA = "0x188349EF0", Slot = "20")]
	public bool CBJEAMJNLFA(Guid DFAIPONKOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x834D440", Offset = "0x834BE40", VA = "0x18834D440")]
	public KeepsakeTheme GACLPJEIJMI(Guid DFAIPONKOEG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8352E40", Offset = "0x8351840", VA = "0x188352E40")]
	public bool MLBPMMCACGP(KCEPIFFHDBI IPEDAEKNAAO, [Out] KeepsakeTheme FPBJIAAFAEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8351790", Offset = "0x8350190", VA = "0x188351790")]
	public List<KeepsakeTheme> KGHLNBEBPDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83540B0", Offset = "0x8352AB0", VA = "0x1883540B0")]
	public int OOKODAJGNOC(KCEPIFFHDBI IPEDAEKNAAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8354230", Offset = "0x8352C30", VA = "0x188354230")]
	public KCEPIFFHDBI PAJFPLBICKJ(Guid DFAIPONKOEG)
	{
		return default(KCEPIFFHDBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8349190", Offset = "0x8347B90", VA = "0x188349190", Slot = "34")]
	public List<KCEPIFFHDBI> BJNEEEHLBAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x834E080", Offset = "0x834CA80", VA = "0x18834E080", Slot = "35")]
	public IComparer<KCEPIFFHDBI> GHNIOFIBPOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8348C50", Offset = "0x8347650", VA = "0x188348C50", Slot = "32")]
	public string BHLILGKFBMD(KCEPIFFHDBI IPEDAEKNAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8352650", Offset = "0x8351050", VA = "0x188352650", Slot = "33")]
	public string LLOIGIJDFEJ(KCEPIFFHDBI IPEDAEKNAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83534B0", Offset = "0x8351EB0", VA = "0x1883534B0", Slot = "21")]
	public bool NNFAPBEEMEM(Guid DFAIPONKOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x834AE60", Offset = "0x8349860", VA = "0x18834AE60", Slot = "22")]
	public void DHIJOOCMIMJ(Guid DFAIPONKOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8350500", Offset = "0x834EF00", VA = "0x188350500", Slot = "23")]
	public void JBKEKLPMIJG(KCEPIFFHDBI IPEDAEKNAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x834CD80", Offset = "0x834B780", VA = "0x18834CD80", Slot = "24")]
	public void FDDDCBMKHMM(Guid DFAIPONKOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8354A90", Offset = "0x8353490", VA = "0x188354A90", Slot = "25")]
	public int PEADOKCOHBK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8348DD0", Offset = "0x83477D0", VA = "0x188348DD0", Slot = "31")]
	public DPMDGLGHBHJ<IEnumerable<Guid>> BINOAMDFDDD(long DKMPIOFKFMN, long MJEOOKBAILL, KCEPIFFHDBI? IPEDAEKNAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8352060", Offset = "0x8350A60", VA = "0x188352060", Slot = "30")]
	public DPMDGLGHBHJ<IEnumerable<Guid>> LBCOFLCFAAL(long DKMPIOFKFMN, long MJEOOKBAILL, KCEPIFFHDBI? IPEDAEKNAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8353950", Offset = "0x8352350", VA = "0x188353950", Slot = "54")]
	public DPMDGLGHBHJ<Dictionary<Guid, KCEPIFFHDBI>> OCHBNMNJGKH(long DKMPIOFKFMN, long MJEOOKBAILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x834FE40", Offset = "0x834E840", VA = "0x18834FE40", Slot = "55")]
	public DPMDGLGHBHJ<Dictionary<Guid, KCEPIFFHDBI>> IDJCEPOOHEF(long DKMPIOFKFMN, long MJEOOKBAILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8350D00", Offset = "0x834F700", VA = "0x188350D00", Slot = "26")]
	public DPMDGLGHBHJ<int> JKBJBHJBPPB(long DKMPIOFKFMN, long MJEOOKBAILL, KCEPIFFHDBI? IPEDAEKNAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x834FB90", Offset = "0x834E590", VA = "0x18834FB90", Slot = "27")]
	public DPMDGLGHBHJ<int> HLKGADFCLBP(long DKMPIOFKFMN, long MJEOOKBAILL, KCEPIFFHDBI? IPEDAEKNAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8352440", Offset = "0x8350E40", VA = "0x188352440", Slot = "28")]
	public DPMDGLGHBHJ<Dictionary<KCEPIFFHDBI, int>> LLGEMJBEJLE(long DKMPIOFKFMN, long MJEOOKBAILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8353D00", Offset = "0x8352700", VA = "0x188353D00", Slot = "29")]
	public DPMDGLGHBHJ<Dictionary<KCEPIFFHDBI, int>> OCOIPENJEMO(long DKMPIOFKFMN, long MJEOOKBAILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8353DC0", Offset = "0x83527C0", VA = "0x188353DC0", Slot = "37")]
	public bool OMHLECCONJH(long DKMPIOFKFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8351E60", Offset = "0x8350860", VA = "0x188351E60", Slot = "56")]
	public bool KIDCNALIEJB(long DKMPIOFKFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8349710", Offset = "0x8348110", VA = "0x188349710", Slot = "38")]
	public bool BLOFKJOMODH(long DKMPIOFKFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x834A200", Offset = "0x8348C00", VA = "0x18834A200", Slot = "57")]
	public bool CDKGIKJOEEG(long DKMPIOFKFMN, [Out] HEFDMCLHHJI JEOPJEMGELI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8353750", Offset = "0x8352150", VA = "0x188353750", Slot = "39")]
	public bool OAFNOHHAEOC(long FHHIGOKBOFO, [Out] DateTime KEKGNGGPNJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x834AED0", Offset = "0x83498D0", VA = "0x18834AED0", Slot = "40")]
	public long DKKLPIHNILI(long FHHIGOKBOFO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8353FA0", Offset = "0x83529A0", VA = "0x188353FA0", Slot = "41")]
	public long OOCMPMOMMOA(long DKMPIOFKFMN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83528D0", Offset = "0x83512D0", VA = "0x1883528D0", Slot = "42")]
	public int MEFPECGMIBD(long FHHIGOKBOFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x834AD80", Offset = "0x8349780", VA = "0x18834AD80", Slot = "43")]
	public bool DGGMCHOFJMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8350720", Offset = "0x834F120", VA = "0x188350720", Slot = "44")]
	public bool JCMCEANIFJL(long FHHIGOKBOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x834F890", Offset = "0x834E290", VA = "0x18834F890", Slot = "45")]
	public IReadOnlyList<long> HJGHANOLAHP(long FHHIGOKBOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8353020", Offset = "0x8351A20", VA = "0x188353020", Slot = "46")]
	public int MLMLPCBDPKN(long FHHIGOKBOFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x834C500", Offset = "0x834AF00", VA = "0x18834C500", Slot = "50")]
	public long EKBODKKAAEO(long DFNCIKGEJKH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x834DB20", Offset = "0x834C520", VA = "0x18834DB20", Slot = "51")]
	public KCEPIFFHDBI GECMFGOALIB()
	{
		return default(KCEPIFFHDBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x834A5B0", Offset = "0x8348FB0", VA = "0x18834A5B0")]
	private bool CFMHHFMHILM(Guid DFAIPONKOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8349A20", Offset = "0x8348420", VA = "0x188349A20")]
	private void CAJIICJCHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8350220", Offset = "0x834EC20", VA = "0x188350220")]
	private KCEPIFFHDBI JABNHJPDFIB()
	{
		return default(KCEPIFFHDBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8350FB0", Offset = "0x834F9B0", VA = "0x188350FB0")]
	private void JOILPNCCCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8353310", Offset = "0x8351D10", VA = "0x188353310")]
	private int NLNMOAOPEGH(KeepsakeRoomListDTO AFIJFPJIHPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8351690", Offset = "0x8350090", VA = "0x188351690")]
	private int KGHJILDIDPG(DateTime ILEHODGIEAI, DateTime KFIHHMOHABD, TimeSpan PMBGHDPIFLD, int FNHKBKFPNBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8349480", Offset = "0x8347E80", VA = "0x188349480")]
	private void BLKOECEPHDE(IEnumerable<KeepsakeInstanceDTO> HNEHDNDCJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x834FFD0", Offset = "0x834E9D0", VA = "0x18834FFD0")]
	private void IOCKBIJCHNH(IEnumerable<KeepsakeCollectionRecordDTO> CMFBJJBNJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x834B630", Offset = "0x834A030", VA = "0x18834B630")]
	private void DNFNEKAHDID(IEnumerable<long> JAMKFEAFIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xB60050", Offset = "0xB5EA50", VA = "0x180B60050")]
	private void NLAMEKOBAOP(KeepsakeGlobalConfigDTO LLBPCGNJEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x834CFC0", Offset = "0x834B9C0", VA = "0x18834CFC0")]
	private bool FHBANDGAAPF(KCEPIFFHDBI IPEDAEKNAAO, [Out] Guid MILDCGNLLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x83515F0", Offset = "0x834FFF0", VA = "0x1883515F0")]
	private bool KEMOMEHGPOE([Out] Guid MILDCGNLLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x834B5D0", Offset = "0x8349FD0", VA = "0x18834B5D0")]
	private bool DLBGLAHAAPD(Guid DFAIPONKOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8351B40", Offset = "0x8350540", VA = "0x188351B40")]
	private IEnumerable<Guid> KHPDCHPHGIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8353890", Offset = "0x8352290", VA = "0x188353890")]
	private IEnumerable<KeepsakeInstanceDTO> OBBJHEDLPHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x834CCF0", Offset = "0x834B6F0", VA = "0x18834CCF0")]
	private void FAGABJANKIP(Guid DFAIPONKOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x834ACD0", Offset = "0x83496D0", VA = "0x18834ACD0")]
	private bool DCOPNLIGJEJ(Guid DFAIPONKOEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83492E0", Offset = "0x8347CE0", VA = "0x1883492E0")]
	private void BLCEIMCKGAE(Guid DFAIPONKOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x834BFF0", Offset = "0x834A9F0", VA = "0x18834BFF0")]
	private void EBJIANDLEHH(KCEPIFFHDBI COBMGFAEIIO, int PKKGIIIEFOF, Dictionary<KCEPIFFHDBI, int> IEHGBMBMPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8354ED0", Offset = "0x83538D0", VA = "0x188354ED0")]
	private int PJDAPHCOELF(KCEPIFFHDBI IPEDAEKNAAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83497B0", Offset = "0x83481B0", VA = "0x1883497B0")]
	private void BNINOPMGHIC(KeepsakeInstanceDTO JLLHKOKPJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8352230", Offset = "0x8350C30", VA = "0x188352230")]
	private void LICBEEAIKEO(KeepsakeInstanceDTO JLLHKOKPJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x834C130", Offset = "0x834AB30", VA = "0x18834C130")]
	private void ECOHBKPEHEN(Guid DFAIPONKOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8352200", Offset = "0x8350C00", VA = "0x188352200")]
	private void MBPLFENOLHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8351EE0", Offset = "0x83508E0", VA = "0x188351EE0")]
	private void KNADDLFJNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x834F570", Offset = "0x834DF70", VA = "0x18834F570")]
	private void HCDAPFOKEAE(CBIENAKDHBL JCKBCDHGAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8352200", Offset = "0x8350C00", VA = "0x188352200")]
	private void LDFLGNHDMHO(KJPHDFMLMPO CEFJEHJNIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8352200", Offset = "0x8350C00", VA = "0x188352200")]
	private void NJMCJKNKAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8354FC0", Offset = "0x83539C0", VA = "0x188354FC0")]
	private void PMDAEFCPCOF(float PJMJFHIDLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x834D580", Offset = "0x834BF80", VA = "0x18834D580")]
	private void GAHHPABLOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x83488C0", Offset = "0x83472C0", VA = "0x1883488C0")]
	private bool ALHCKLNILME(Guid DFAIPONKOEG, [Out] string DKBEHBPOIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8350550", Offset = "0x834EF50", VA = "0x188350550")]
	private bool JCENBKIKOMF(Guid DFAIPONKOEG, [Out] KeepsakeCategoryConfigDTO COBMGFAEIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8353EC0", Offset = "0x83528C0", VA = "0x188353EC0")]
	private void ONJJCHEJLAN(string BCLNCLHGOEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x834F650", Offset = "0x834E050", VA = "0x18834F650")]
	private bool HHHIAFKHGDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8349F20", Offset = "0x8348920", VA = "0x188349F20")]
	private List<long> CCFIMNBGCOO(IEnumerable<KeepsakeRoomDTO> IMMPPLFIDLL, IReadOnlyList<KeepsakeRoomListDTO> NGFAOLGJGCB, long FHHIGOKBOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x834A6E0", Offset = "0x83490E0", VA = "0x18834A6E0")]
	private bool CLPKICEHGBN(Guid DFAIPONKOEG, [Out] string GFHOJCCMEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8350C20", Offset = "0x834F620", VA = "0x188350C20", Slot = "47")]
	public string JGPAAKKCKNG(DELEIOCNGIL DPFCMOJNBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x834C8D0", Offset = "0x834B2D0", VA = "0x18834C8D0", Slot = "49")]
	public string ENLHKBOMLJO(DELEIOCNGIL DPFCMOJNBAA, long DKMPIOFKFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x834BF10", Offset = "0x834A910", VA = "0x18834BF10", Slot = "48")]
	public string EAIPLCPMBEB(DELEIOCNGIL DPFCMOJNBAA, int LPOHNDPPEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x834E160", Offset = "0x834CB60", VA = "0x18834E160")]
	private void GJEDCAECDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8348AC0", Offset = "0x83474C0", VA = "0x188348AC0")]
	private void BECGHMNIOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x834F5E0", Offset = "0x834DFE0", VA = "0x18834F5E0")]
	private DELEIOCNGIL HDNPIDNNCNM(OOPMLGAEEJE BGPPHCKHDGB)
	{
		return default(DELEIOCNGIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x83530D0", Offset = "0x8351AD0", VA = "0x1883530D0")]
	private DELEIOCNGIL MMNBAHGCCNC(OOPMLGAEEJE BGPPHCKHDGB)
	{
		return default(DELEIOCNGIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x83508B0", Offset = "0x834F2B0", VA = "0x1883508B0")]
	internal static string JCPIAHACEHM(PCCPNEPHNLM FNAGPCFFJAJ, string PMGGJLFFPEC, bool GECGFHOOIOB, int MONALCHAACL, int OAPLABFFJGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x834B6F0", Offset = "0x834A0F0", VA = "0x18834B6F0", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8350C80", Offset = "0x834F680", VA = "0x188350C80")]
	private FNEGFJHAODE JJOKGFMJPNP(POIAKMBAMML PKHAABOHMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x834B410", Offset = "0x8349E10", VA = "0x18834B410")]
	private NNCIEOBEJLN DKNALBEHJGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x834BB50", Offset = "0x834A550", VA = "0x18834BB50")]
	private Task EADDMBPLGDN(ALPHANGLKLD GACFFBLMJOF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x834C7C0", Offset = "0x834B1C0", VA = "0x18834C7C0")]
	[AsyncStateMachine(typeof(LBCHPHAKILG))]
	private Task ENIOBEMCNJD(ALPHANGLKLD GACFFBLMJOF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x83549B0", Offset = "0x83533B0", VA = "0x1883549B0")]
	private Task PDEJGDMCPBA(ALPHANGLKLD GACFFBLMJOF, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x834F760", Offset = "0x834E160", VA = "0x18834F760")]
	[AsyncStateMachine(typeof(NNJLPIDLCLO))]
	private Task HHMBKCJCEAO(string ONGDPODJNBL, TimeSpan JPGBGDKOAGI, CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x834E140", Offset = "0x834CB40", VA = "0x18834E140")]
	[CompilerGenerated]
	private void GIMIFFJAAAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x834F600", Offset = "0x834E000", VA = "0x18834F600")]
	[CompilerGenerated]
	private void HEELDDJNHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83527D0", Offset = "0x83511D0", VA = "0x1883527D0")]
	[CompilerGenerated]
	private bool LMPPPNJCKHH(KeepsakeInstanceDTO IECENJOJFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x83531A0", Offset = "0x8351BA0", VA = "0x1883531A0")]
	[CompilerGenerated]
	private DPMDGLGHBHJ<Dictionary<KCEPIFFHDBI, int>> MOAGOFCICAH(Dictionary<Guid, KCEPIFFHDBI> PLGPMHGADGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x834D230", Offset = "0x834BC30", VA = "0x18834D230")]
	[CompilerGenerated]
	private DPMDGLGHBHJ<Dictionary<KCEPIFFHDBI, int>> FMACEHPPILF(Dictionary<Guid, KCEPIFFHDBI> PLGPMHGADGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8351EC0", Offset = "0x83508C0", VA = "0x188351EC0")]
	[CompilerGenerated]
	private bool KKFHDMLILGC(KeepsakeRoomListDTO IECENJOJFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x834DE90", Offset = "0x834C890", VA = "0x18834DE90")]
	[CompilerGenerated]
	private bool GGHEDHDIJCK(KeepsakeInstanceDTO IECENJOJFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8350A90", Offset = "0x834F490", VA = "0x188350A90")]
	[CompilerGenerated]
	private void JDNMBNIGJJN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<KCEPIFFHDBI, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CAIABPFCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x834C0D0", Offset = "0x834AAD0", VA = "0x18834C0D0")]
	[CompilerGenerated]
	private void ECNMPIGAPJJ(string GFHOJCCMEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8351CA0", Offset = "0x83506A0", VA = "0x188351CA0")]
	[CompilerGenerated]
	private Task KHPKGHBOIEF(CancellationToken IMPICMGKAEL)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, NEGJJIMNMJB<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class BKIIMFDGHMD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
				public BKIIMFDGHMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x8348330", Offset = "0x8346D30", VA = "0x188348330")]
				internal bool LHBJKFKJLHG(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x8348330", Offset = "0x8346D30", VA = "0x188348330")]
				internal bool HMEBPMGILOF(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x83575D0", Offset = "0x8355FD0", VA = "0x1883575D0")]
			public bool FEPNNJFLGKO(string HLFIJJOBFNM, [Out] KeepsakeTheme FPBJIAAFAEH)
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
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8357550", Offset = "0x8355F50", VA = "0x188357550")]
		[PPMDKOHJEBA.KMGFFEOOKKA.HAOMKJDLLID]
		internal static void EIKIOMKMPDG(CFAMNNNCHJA JBOIKIICKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
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

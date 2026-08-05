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
		[Cpp2IlInjected.Address(RVA = "0x7E1C490", Offset = "0x7E1B090", VA = "0x187E1C490", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NDNHCKILKKC : IComparer<BHEHIPCPHLE>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JGJOLAOKHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BHEHIPCPHLE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public BHEHIPCPHLE y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JGJOLAOKHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xDA2E80", Offset = "0xDA1A80", VA = "0x180DA2E80")]
		internal bool NLNNEJPJPKM(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2031D40", Offset = "0x2030940", VA = "0x182031D40")]
		internal bool FMPHCPAFIHD(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDA2E80", Offset = "0xDA1A80", VA = "0x180DA2E80")]
		internal bool EBNDFHBEKPI(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2031D40", Offset = "0x2030940", VA = "0x182031D40")]
		internal bool FFCFLIAKMGA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> KPJHCPGMOJB;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public NDNHCKILKKC(List<KeepsakeCategoryThemePair> NJONMIPGOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E1BBD0", Offset = "0x7E1A7D0", VA = "0x187E1BBD0", Slot = "4")]
	public int Compare(BHEHIPCPHLE KFGAJBKADFK, BHEHIPCPHLE FEABMDLFEMA)
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
		public BHEHIPCPHLE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BOOMHEJPJEF]
public class KGIBOLOCEEI : HFEHKPHOBIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EEHNOPILFLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public KGIBOLOCEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BHEHIPCPHLE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EEHNOPILFLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B9E0", Offset = "0x7E0A5E0", VA = "0x187E0B9E0")]
		internal KLHBLGBFFDH<Guid> HIOBFCCBDBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B950", Offset = "0x7E0A550", VA = "0x187E0B950")]
		internal void EFNKNKEIJHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B980", Offset = "0x7E0A580", VA = "0x187E0B980")]
		internal void EOFKKAPCGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BB40", Offset = "0x7E0A740", VA = "0x187E0BB40")]
		internal void MMICKFJBCCB(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BF50", Offset = "0x7E0AB50", VA = "0x187E0BF50")]
		internal void PAAAAJNMMJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class KDMIOLHDHDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KGIBOLOCEEI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KDMIOLHDHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CCB0", Offset = "0x7E0B8B0", VA = "0x187E0CCB0")]
		internal void FIIEDJPGCBJ(CHOAHIBBGFL response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CC50", Offset = "0x7E0B850", VA = "0x187E0CC50")]
		internal void DILDNCBBKKH(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class OMABJCABOMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OMABJCABOMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BE80", Offset = "0x7E1AA80", VA = "0x187E1BE80")]
		internal bool FFDBKHMAEFC(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IMMHLIEDODK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KGIBOLOCEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public BHEHIPCPHLE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IMMHLIEDODK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C8E0", Offset = "0x7E0B4E0", VA = "0x187E0C8E0")]
		internal void LGIJFMKEHLB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B130", Offset = "0x7E09D30", VA = "0x187E0B130")]
		internal void BOCLODKIFMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C5E0", Offset = "0x7E0B1E0", VA = "0x187E0C5E0")]
		internal KLHBLGBFFDH<IEnumerable<Guid>> FJPJJMFHAFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x791AA50", Offset = "0x7919650", VA = "0x18791AA50")]
		internal bool LLCKAJEJJIJ(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IKLIHGOIJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public IMMHLIEDODK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IKLIHGOIJDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C4A0", Offset = "0x7E0B0A0", VA = "0x187E0C4A0")]
		internal KLHBLGBFFDH<IEnumerable<Guid>> LDGADLJDCIG(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class IGMFIPKBIIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public IKLIHGOIJDO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IGMFIPKBIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C370", Offset = "0x7E0AF70", VA = "0x187E0C370")]
		internal bool ODOBPPIKLDC(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class JHMEFMEOKAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IGMFIPKBIIN CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JHMEFMEOKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C9D0", Offset = "0x7E0B5D0", VA = "0x187E0C9D0")]
		internal bool IBACFODMIOM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KFBNDGJJCND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public KGIBOLOCEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KFBNDGJJCND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E0D060", Offset = "0x7E0BC60", VA = "0x187E0D060")]
		internal KLHBLGBFFDH<IEnumerable<Guid>> NALOBIDECBP(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C200", Offset = "0x7E0AE00", VA = "0x187E0C200")]
		internal bool EHEHAJOBNJL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class AEODLEGCCIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KGIBOLOCEEI <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AEODLEGCCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B0A0", Offset = "0x7E09CA0", VA = "0x187E0B0A0")]
		internal void APKPCONDNFL(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B130", Offset = "0x7E09D30", VA = "0x187E0B130")]
		internal void FGBEEGLLBLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B160", Offset = "0x7E09D60", VA = "0x187E0B160")]
		internal KLHBLGBFFDH<Dictionary<Guid, BHEHIPCPHLE>> JKLMFHLKPMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x791AA50", Offset = "0x7919650", VA = "0x18791AA50")]
		internal bool JFCBENEHCMA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PMNPJLJLBHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PMNPJLJLBHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E1C0D0", Offset = "0x7E1ACD0", VA = "0x187E1C0D0")]
		internal KLHBLGBFFDH<Dictionary<Guid, BHEHIPCPHLE>> AOEOAKLOPDL(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PKIMIGJFHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PKIMIGJFHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BFF0", Offset = "0x7E1ABF0", VA = "0x187E1BFF0")]
		internal bool PNKFNJOLMJK(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BEA0", Offset = "0x7E1AAA0", VA = "0x187E1BEA0")]
		internal KeyValuePair<Guid, BHEHIPCPHLE> KAEJHCHHEDL(Guid instanceId)
		{
			return default(KeyValuePair<Guid, BHEHIPCPHLE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class MOHCDHHJAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MOHCDHHJAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x26C63C0", Offset = "0x26C4FC0", VA = "0x1826C63C0")]
		internal bool LMGAENKIKMK(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class FJIJJBIOOMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FJIJJBIOOMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x26C63C0", Offset = "0x26C4FC0", VA = "0x1826C63C0")]
		internal bool BGGNPEKLLJC(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EMCKDOJKAOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KGIBOLOCEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EMCKDOJKAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C000", Offset = "0x7E0AC00", VA = "0x187E0C000")]
		internal KLHBLGBFFDH<Dictionary<Guid, BHEHIPCPHLE>> HJFFCEPDEBI(Dictionary<Guid, BHEHIPCPHLE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C200", Offset = "0x7E0AE00", VA = "0x187E0C200")]
		internal bool HNOKPJFPOAI(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KKKBPHEPIFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public KKKBPHEPIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B0D0", Offset = "0x7E19CD0", VA = "0x187E1B0D0")]
		internal bool OOIALEHKECN(KeyValuePair<Guid, BHEHIPCPHLE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class JIGLPIKIHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, BHEHIPCPHLE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JIGLPIKIHAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CA80", Offset = "0x7E0B680", VA = "0x187E0CA80")]
		internal KeyValuePair<BHEHIPCPHLE, int> FBMGAPNCIMJ(BHEHIPCPHLE category)
		{
			return default(KeyValuePair<BHEHIPCPHLE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class CHPLKFOPNAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public BHEHIPCPHLE category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public CHPLKFOPNAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xEA7E40", Offset = "0xEA6A40", VA = "0x180EA7E40")]
		internal bool LKMNLDADAPM(BHEHIPCPHLE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MNCNBCIEPNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, BHEHIPCPHLE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MNCNBCIEPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BA80", Offset = "0x7E1A680", VA = "0x187E1BA80")]
		internal KeyValuePair<BHEHIPCPHLE, int> ICIBKFLHDHG(BHEHIPCPHLE category)
		{
			return default(KeyValuePair<BHEHIPCPHLE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FDHODCKAOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public BHEHIPCPHLE category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FDHODCKAOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xEA7E40", Offset = "0xEA6A40", VA = "0x180EA7E40")]
		internal bool LOKGOLHJGJN(BHEHIPCPHLE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class DMMIOLKGEAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public KGIBOLOCEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DMMIOLKGEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B4B0", Offset = "0x7E0A0B0", VA = "0x187E0B4B0")]
		internal bool KEFMDPLGHMH(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B5A0", Offset = "0x7E0A1A0", VA = "0x187E0B5A0")]
		internal bool OOMADBHKGJD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B490", Offset = "0x7E0A090", VA = "0x187E0B490")]
		internal bool MBPMNPPIMMA(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B490", Offset = "0x7E0A090", VA = "0x187E0B490")]
		internal bool APGEJDFIPAO(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class GMHOOGGLBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GMHOOGGLBGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xF0C150", Offset = "0xF0AD50", VA = "0x180F0C150")]
		internal bool GKNNLGLIIIK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FFFAPBHBBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FFFAPBHBBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C220", Offset = "0x7E0AE20", VA = "0x187E0C220")]
		internal bool KGCPJNCJGJK(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x263D010", Offset = "0x263BC10", VA = "0x18263D010")]
		internal bool GHNBLFOPFKJ(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LCPONPHGKMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LCPONPHGKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E1BA20", Offset = "0x7E1A620", VA = "0x187E1BA20")]
		internal bool ACJFIFJPKDI(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FEACEAFHNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FEACEAFHNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xF0C150", Offset = "0xF0AD50", VA = "0x180F0C150")]
		internal bool FJJBKBHGNOJ(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class JDJEPPKELKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JDJEPPKELKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C970", Offset = "0x7E0B570", VA = "0x187E0C970")]
		internal bool MMLONOGBCBO(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GBOJHCEMJKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public BHEHIPCPHLE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GBOJHCEMJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2272C80", Offset = "0x2271880", VA = "0x182272C80")]
		internal bool CJCJDJIOMHI(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GBNINPNCPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GBNINPNCPJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E0C2E0", Offset = "0x7E0AEE0", VA = "0x187E0C2E0")]
		internal bool MPFPAKDONJO(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DEKOCDBBLMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BHEHIPCPHLE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DEKOCDBBLMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B450", Offset = "0x7E0A050", VA = "0x187E0B450")]
		internal bool EOOCFNEDLOK(KeyValuePair<Guid, BHEHIPCPHLE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PGABMALLDDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public BHEHIPCPHLE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PGABMALLDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2272C80", Offset = "0x2271880", VA = "0x182272C80")]
		internal bool LNGHIDHKNJO(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class JJEHNDDKEJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JJEHNDDKEJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7E0CBD0", Offset = "0x7E0B7D0", VA = "0x187E0CBD0")]
		internal bool BLJCPEBAHMH(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class LAALIFHEJIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LAALIFHEJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B3A0", Offset = "0x7E19FA0", VA = "0x187E1B3A0")]
		internal bool DAPPCIHKGCH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EJPMHMEDIHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LAALIFHEJIA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EJPMHMEDIHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BF80", Offset = "0x7E0AB80", VA = "0x187E0BF80")]
		internal bool MPAONHNPBNK(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct LBLLNIPFOFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KGIBOLOCEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public KGGEOPPOKLC args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B490", Offset = "0x7E1A090", VA = "0x187E1B490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B9C0", Offset = "0x7E1A5C0", VA = "0x187E1B9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct EAFDCMHIDGO : IAsyncStateMachine
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
		public KGIBOLOCEEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B660", Offset = "0x7E0A260", VA = "0x187E0B660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B8F0", Offset = "0x7E0A4F0", VA = "0x187E0B8F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime MKEOFEFOCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NFEJPFBLDEI ENIBPJFNPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly FEMDNIDJBDC JLABFHCAMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly GMKOLAEIAKH HIAFIANLHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JCJBJMCKPOA DLLOOEFIEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CIIKPBEDJIP KFBBLAFGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly OJBKGFGPJKC MDNMLJAODAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LJNGIEKFBAB GCILBAMPJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BHCJDNPMBCM DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly KAHDDFIODAM EHOCDJCLHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly IBDLCEDNKJJ HNJMDBADCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BGBIMECKFEN OKJHDPLFJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ODAJJOAKOPA DHLCDOJOEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly ICBOPEHOHOA FMGIFFECKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HFLPMDDOIEK CJMFKLPHPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly DGKBILEDBJJ KHABKJJDOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly HMBBJPLHOBO<KeepsakesConfig.KeepsakesOptions> LEKHKJDBHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly FJCEKCIPLIL DDNEOJGAKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> CFEBHOBHBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> DDIPAOGLEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> BODDIHMBDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<BHEHIPCPHLE, int> PFCDFGDOIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> PDLPGIKCDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable KPGAPOCDFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task ADAOAGCGICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KLHBLGBFFDH<Guid> GJPJHEDABGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? DKCAEIJBKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO IGDPJHDFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KLHBLGBFFDH<KeepsakeProgressionEventInstancesDTO> MLNPHKNPIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<BHEHIPCPHLE, KeepsakeCategoryConfigDTO> KKCDIGBJOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO FIKKEFNNKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> CBJMCDHKHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> EODMIDMMCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> HIBFMKMEGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> MHJCHDGJMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> PANFCAPNMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> BENDGLFNJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> PLDCEPLBDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> DFILPLNBBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> OJJPJPJPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> IEAMIBCGIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> BOGEEBIKCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> NJDOCHKAJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime GHHKMDHPAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable OICLAFKFGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, BHEHIPCPHLE> ANFCHPEINEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<BHEHIPCPHLE, int> BGADJJMMLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> NJONMIPGOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NDNHCKILKKC FMMGDLGPMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool KODCODOBFKH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EPLAIMDFKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA4B580", Offset = "0xA4A180", VA = "0x180A4B580", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4B3A0", Offset = "0xA49FA0", VA = "0x180A4B3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FFNBIFLNONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E17660", Offset = "0x7E16260", VA = "0x187E17660", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JACCAPILEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E12510", Offset = "0x7E11110", VA = "0x187E12510", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long FENHBJLLGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E0E840", Offset = "0x7E0D440", VA = "0x187E0E840")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? HJCCILCCBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E175D0", Offset = "0x7E161D0", VA = "0x187E175D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PIJNBKGCEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E112F0", Offset = "0x7E0FEF0", VA = "0x187E112F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> BMNBEINICBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB4E480", Offset = "0xB4D080", VA = "0x180B4E480", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> FLEIDNILAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB45D90", Offset = "0xB44990", VA = "0x180B45D90", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> PPKOANOPLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB5AFF0", Offset = "0xB59BF0", VA = "0x180B5AFF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> IGJEIPIJJON
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB417F0", Offset = "0xB403F0", VA = "0x180B417F0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool FNPJIAEJIED
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC35010", Offset = "0xC33C10", VA = "0x180C35010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> BHJJBMFNLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E13830", Offset = "0x7E12430", VA = "0x187E13830", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E15D50", Offset = "0x7E14950", VA = "0x187E15D50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HBCCOFLJHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E12A50", Offset = "0x7E11650", VA = "0x187E12A50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E17450", Offset = "0x7E16050", VA = "0x187E17450", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JOIBBHEKOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E198C0", Offset = "0x7E184C0", VA = "0x187E198C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E173B0", Offset = "0x7E15FB0", VA = "0x187E173B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E19B00", Offset = "0x7E18700", VA = "0x187E19B00")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KGIBOLOCEEI([GFNPNOLPMKK(null)][NotNull] NFEJPFBLDEI ENIBPJFNPFO, [NotNull][GFNPNOLPMKK(null)] PPDHIJNIFFF IKNMBFJPHDE, [NotNull][GFNPNOLPMKK(null)] FEMDNIDJBDC JLABFHCAMBK, [NotNull][GFNPNOLPMKK(null)] GMKOLAEIAKH HIAFIANLHMN, [GFNPNOLPMKK(null)][NotNull] JCJBJMCKPOA DLLOOEFIEEC, [GFNPNOLPMKK(null)][NotNull] CIIKPBEDJIP KFBBLAFGOAP, [GFNPNOLPMKK(null)][NotNull] OJBKGFGPJKC MDNMLJAODAC, [NotNull][GFNPNOLPMKK(null)] LJNGIEKFBAB GCILBAMPJFN, [NotNull][GFNPNOLPMKK(null)] BHCJDNPMBCM DKIFPHGKANK, [NotNull][GFNPNOLPMKK(null)] OBEILBEGJHN PNDOMKBDFHG, [NotNull][GFNPNOLPMKK(null)] KAHDDFIODAM EHOCDJCLHKI, [NotNull][GFNPNOLPMKK(null)] IBDLCEDNKJJ HNJMDBADCOG, [NotNull][GFNPNOLPMKK(null)] BGBIMECKFEN OKJHDPLFJEK, [NotNull][GFNPNOLPMKK(null)] ODAJJOAKOPA DHLCDOJOEAI, [GFNPNOLPMKK(null)][NotNull] ICBOPEHOHOA FMGIFFECKIH, [GFNPNOLPMKK(null)][NotNull] HFLPMDDOIEK CJMFKLPHPOH, [NotNull][GFNPNOLPMKK(null)] DGKBILEDBJJ KHABKJJDOCJ, [GFNPNOLPMKK(null)][NotNull] HMBBJPLHOBO<KeepsakesConfig.KeepsakesOptions> LEKHKJDBHCI, [NotNull][GFNPNOLPMKK(null)] FJCEKCIPLIL DDNEOJGAKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F140", Offset = "0x7E0DD40", VA = "0x187E0F140", Slot = "15")]
	public bool BOELLPOEBAN(List<string> MKJJINEHFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E14230", Offset = "0x7E12E30", VA = "0x187E14230", Slot = "16")]
	public KLHBLGBFFDH<Guid> IHJBBGNAGOB(BHEHIPCPHLE NLHDCHLLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E17AA0", Offset = "0x7E166A0", VA = "0x187E17AA0", Slot = "17")]
	public AFMJGMMOLON NLJPBCOBANG(Guid OPNNCFPKPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E10B00", Offset = "0x7E0F700", VA = "0x187E10B00", Slot = "18")]
	public AFMJGMMOLON DOJGAGKDEBM(Guid OPNNCFPKPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E14F30", Offset = "0x7E13B30", VA = "0x187E14F30", Slot = "19")]
	public bool JEMJCANLIDM(Guid OPNNCFPKPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E11880", Offset = "0x7E10480", VA = "0x187E11880", Slot = "20")]
	public bool FAPFLMPJEHI(Guid OPNNCFPKPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E11D80", Offset = "0x7E10980", VA = "0x187E11D80")]
	public KeepsakeTheme GAGAIGDIFDD(Guid OPNNCFPKPIG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E170D0", Offset = "0x7E15CD0", VA = "0x187E170D0")]
	public bool MCJJHKNAOMB(BHEHIPCPHLE NLHDCHLLALI, [Out] KeepsakeTheme IPCEEOIAIHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E11F60", Offset = "0x7E10B60", VA = "0x187E11F60")]
	public List<KeepsakeTheme> GCDJGKPCLBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E194A0", Offset = "0x7E180A0", VA = "0x187E194A0")]
	public int PAMNPOANHPH(BHEHIPCPHLE NLHDCHLLALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D300", Offset = "0x7E0BF00", VA = "0x187E0D300")]
	public BHEHIPCPHLE AEFLGECJNAN(Guid OPNNCFPKPIG)
	{
		return default(BHEHIPCPHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E16C40", Offset = "0x7E15840", VA = "0x187E16C40", Slot = "34")]
	public List<BHEHIPCPHLE> KKEBMBAMNHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E15C90", Offset = "0x7E14890", VA = "0x187E15C90", Slot = "35")]
	public IComparer<BHEHIPCPHLE> KCHBBOMMGIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E15B10", Offset = "0x7E14710", VA = "0x187E15B10", Slot = "32")]
	public string KBNBLGBFGFN(BHEHIPCPHLE NLHDCHLLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E12BA0", Offset = "0x7E117A0", VA = "0x187E12BA0", Slot = "33")]
	public string HEGGPOIOJGA(BHEHIPCPHLE NLHDCHLLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E15E00", Offset = "0x7E14A00", VA = "0x187E15E00", Slot = "21")]
	public bool KDLJLOIIDOH(Guid OPNNCFPKPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E15260", Offset = "0x7E13E60", VA = "0x187E15260", Slot = "22")]
	public void JJCJJFHMJPO(Guid OPNNCFPKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E134F0", Offset = "0x7E120F0", VA = "0x187E134F0", Slot = "23")]
	public void HNHIHPIJCAO(BHEHIPCPHLE NLHDCHLLALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E14840", Offset = "0x7E13440", VA = "0x187E14840", Slot = "24")]
	public void IJELNMEMBHO(Guid OPNNCFPKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E11960", Offset = "0x7E10560", VA = "0x187E11960", Slot = "25")]
	public int FODLOGCHICO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E17D20", Offset = "0x7E16920", VA = "0x187E17D20", Slot = "31")]
	public KLHBLGBFFDH<IEnumerable<Guid>> NLOFCOLFGNG(long JKJNCHGDMGL, long ALPHLLKJEIN, BHEHIPCPHLE? NLHDCHLLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E125D0", Offset = "0x7E111D0", VA = "0x187E125D0", Slot = "30")]
	public KLHBLGBFFDH<IEnumerable<Guid>> GLFDIIDBIOE(long JKJNCHGDMGL, long ALPHLLKJEIN, BHEHIPCPHLE? NLHDCHLLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E114D0", Offset = "0x7E100D0", VA = "0x187E114D0", Slot = "54")]
	public KLHBLGBFFDH<Dictionary<Guid, BHEHIPCPHLE>> EPIHDHNHGCN(long JKJNCHGDMGL, long ALPHLLKJEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E12D20", Offset = "0x7E11920", VA = "0x187E12D20", Slot = "55")]
	public KLHBLGBFFDH<Dictionary<Guid, BHEHIPCPHLE>> HHDPFGLDOMJ(long JKJNCHGDMGL, long ALPHLLKJEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E152D0", Offset = "0x7E13ED0", VA = "0x187E152D0", Slot = "26")]
	public KLHBLGBFFDH<int> JOEKEEPINPP(long JKJNCHGDMGL, long ALPHLLKJEIN, BHEHIPCPHLE? NLHDCHLLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E16310", Offset = "0x7E14F10", VA = "0x187E16310", Slot = "27")]
	public KLHBLGBFFDH<int> KHDHDAOOJMF(long JKJNCHGDMGL, long ALPHLLKJEIN, BHEHIPCPHLE? NLHDCHLLALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E16EC0", Offset = "0x7E15AC0", VA = "0x187E16EC0", Slot = "28")]
	public KLHBLGBFFDH<Dictionary<BHEHIPCPHLE, int>> MCHDHIBCNEH(long JKJNCHGDMGL, long ALPHLLKJEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E14E10", Offset = "0x7E13A10", VA = "0x187E14E10", Slot = "29")]
	public KLHBLGBFFDH<Dictionary<BHEHIPCPHLE, int>> JABEFCEEHHA(long JKJNCHGDMGL, long ALPHLLKJEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E410", Offset = "0x7E0D010", VA = "0x187E0E410", Slot = "37")]
	public bool BDHCCLFEJFJ(long JKJNCHGDMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E118D0", Offset = "0x7E104D0", VA = "0x187E118D0", Slot = "56")]
	public bool FOBJECEAGPM(long JKJNCHGDMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E11EC0", Offset = "0x7E10AC0", VA = "0x187E11EC0", Slot = "38")]
	public bool GAIFCLINFMI(long JKJNCHGDMGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F730", Offset = "0x7E0E330", VA = "0x187E0F730", Slot = "57")]
	public bool CEDDPIPBNGN(long JKJNCHGDMGL, [Out] BIPOCDFJIKM IKCHFGAFMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DFB0", Offset = "0x7E0CBB0", VA = "0x187E0DFB0", Slot = "39")]
	public bool ALLFNPBPIIM(long HPKPICIDJDP, [Out] DateTime ANHDGDEAMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EC00", Offset = "0x7E0D800", VA = "0x187E0EC00", Slot = "40")]
	public long BLMBNOHILIK(long HPKPICIDJDP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7E18B80", Offset = "0x7E17780", VA = "0x187E18B80", Slot = "41")]
	public long OFFKPAJDJCI(long JKJNCHGDMGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7E16460", Offset = "0x7E15060", VA = "0x187E16460", Slot = "42")]
	public int KHGKINOIMMG(long HPKPICIDJDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7E12430", Offset = "0x7E11030", VA = "0x187E12430", Slot = "43")]
	public bool GKLHOCNJGCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7E17910", Offset = "0x7E16510", VA = "0x187E17910", Slot = "44")]
	public bool NLFPAMKKHDO(long HPKPICIDJDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E13280", Offset = "0x7E11E80", VA = "0x187E13280", Slot = "45")]
	public IReadOnlyList<long> HLCMNNJOOFN(long HPKPICIDJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E18C90", Offset = "0x7E17890", VA = "0x187E18C90", Slot = "46")]
	public int OHGNCIEHFHE(long HPKPICIDJDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E0F0", Offset = "0x7E0CCF0", VA = "0x187E0E0F0", Slot = "50")]
	public long ANKNODHKABF(long DDCLKDIPMPK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E0F3D0", Offset = "0x7E0DFD0", VA = "0x187E0F3D0", Slot = "51")]
	public BHEHIPCPHLE CAFCGDNEKMB()
	{
		return default(BHEHIPCPHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D1D0", Offset = "0x7E0BDD0", VA = "0x187E0D1D0")]
	private bool AECHKNDPIBB(Guid OPNNCFPKPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E18E10", Offset = "0x7E17A10", VA = "0x187E18E10")]
	private void OOPJOALOCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E13560", Offset = "0x7E12160", VA = "0x187E13560")]
	private BHEHIPCPHLE IAPDLEPIFDK()
	{
		return default(BHEHIPCPHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E138E0", Offset = "0x7E124E0", VA = "0x187E138E0")]
	private void IDHMCJHDMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E16770", Offset = "0x7E15370", VA = "0x187E16770")]
	private int KHIIICCKKHF(KeepsakeRoomListDTO FKEBBADOOCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E16D80", Offset = "0x7E15980", VA = "0x187E16D80")]
	private int KLCNIFGLKFC(DateTime ONINHGMMBHC, DateTime BJBANHIJBMN, TimeSpan ALICABDMPHH, int BKHMBBNKODD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7E16090", Offset = "0x7E14C90", VA = "0x187E16090")]
	private void KGGEPGAEIED(IEnumerable<KeepsakeInstanceDTO> CFEBHOBHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E16970", Offset = "0x7E15570", VA = "0x187E16970")]
	private void KJHLKPNGKPJ(IEnumerable<KeepsakeCollectionRecordDTO> MNKDLAKDOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E3B0", Offset = "0x7E0CFB0", VA = "0x187E0E3B0")]
	private void ANNAMCNJNIA(IEnumerable<long> NODOJPJJHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAB7280", Offset = "0xAB5E80", VA = "0x180AB7280")]
	private void DKIGEFEDMDH(KeepsakeGlobalConfigDTO FIKKEFNNKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7E176B0", Offset = "0x7E162B0", VA = "0x187E176B0")]
	private bool NLCDNNDKBJN(BHEHIPCPHLE NLHDCHLLALI, [Out] Guid OLBKJKJGIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E12310", Offset = "0x7E10F10", VA = "0x187E12310")]
	private bool GCINNHLHGDI([Out] Guid OLBKJKJGIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7E14ED0", Offset = "0x7E13AD0", VA = "0x187E14ED0")]
	private bool JBLLBLGKLAP(Guid OPNNCFPKPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FAE0", Offset = "0x7E0E6E0", VA = "0x187E0FAE0")]
	private IEnumerable<Guid> DICLCMIKIEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EB40", Offset = "0x7E0D740", VA = "0x187E0EB40")]
	private IEnumerable<KeepsakeInstanceDTO> BJHAMGFEFBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E16BB0", Offset = "0x7E157B0", VA = "0x187E16BB0")]
	private void KJNKOOEJIIP(Guid OPNNCFPKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7E12AF0", Offset = "0x7E116F0", VA = "0x187E12AF0")]
	private bool HDPMOADCJLI(Guid OPNNCFPKPIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7E19960", Offset = "0x7E18560", VA = "0x187E19960")]
	private void PPJHIKDPBHG(Guid OPNNCFPKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7E12970", Offset = "0x7E11570", VA = "0x187E12970")]
	private void GONNPDCMIBA(BHEHIPCPHLE KPHLJGGNDKB, int OOHMNDBAING, Dictionary<BHEHIPCPHLE, int> PCFBEMKCOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7E12770", Offset = "0x7E11370", VA = "0x187E12770")]
	private int GLKDKAOOBPN(BHEHIPCPHLE NLHDCHLLALI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E15090", Offset = "0x7E13C90", VA = "0x187E15090")]
	private void JFAGAOKHCBN(KeepsakeInstanceDTO HJLEJJFKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7E13070", Offset = "0x7E11C70", VA = "0x187E13070")]
	private void HKDKHJNPIMF(KeepsakeInstanceDTO HJLEJJFKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DA50", Offset = "0x7E0C650", VA = "0x187E0DA50")]
	private void AJMFMHKNCNK(Guid OPNNCFPKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7E11930", Offset = "0x7E10530", VA = "0x187E11930")]
	private void ICEJMABIFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7E16EA0", Offset = "0x7E15AA0", VA = "0x187E16EA0")]
	private void LNKFDHAIACK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E0EAD0", Offset = "0x7E0D6D0", VA = "0x187E0EAD0")]
	private void BJBIKMENKNN(LFGJEGOCDII DCFHCALNHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E11930", Offset = "0x7E10530", VA = "0x187E11930")]
	private void FOCLKMHFDBP(JIOIKDAMKEJ KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E11930", Offset = "0x7E10530", VA = "0x187E11930")]
	private void LLEPNKOBEFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E180D0", Offset = "0x7E16CD0", VA = "0x187E180D0")]
	private void NNPCPDLMLAM(float IOBMCBBJIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7E15570", Offset = "0x7E14170", VA = "0x187E15570")]
	private void JPIMMECMOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E14A80", Offset = "0x7E13680", VA = "0x187E14A80")]
	private bool INFMKGJGOCJ(Guid OPNNCFPKPIG, [Out] string KEDLOAHHOAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7E192D0", Offset = "0x7E17ED0", VA = "0x187E192D0")]
	private bool PAJHECBOAPI(Guid OPNNCFPKPIG, [Out] KeepsakeCategoryConfigDTO KPHLJGGNDKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E174F0", Offset = "0x7E160F0", VA = "0x187E174F0")]
	private void NICCMHJOAFB(string NCOBNPEFMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E18650", Offset = "0x7E17250", VA = "0x187E18650")]
	private bool NOOHNLKHEIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E13F20", Offset = "0x7E12B20", VA = "0x187E13F20")]
	private List<long> IDLDLCIOCHN(IEnumerable<KeepsakeRoomDTO> LAALGGGLGIA, IReadOnlyList<KeepsakeRoomListDTO> PPBKGAEDFGL, long HPKPICIDJDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D460", Offset = "0x7E0C060", VA = "0x187E0D460")]
	private bool AEMFJFMODOB(Guid OPNNCFPKPIG, [Out] string AJLIMPCCGHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7E16910", Offset = "0x7E15510", VA = "0x187E16910", Slot = "47")]
	public string KHKJBOOJHCL(PFOBOANJLEM MHELDLAMKHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E18760", Offset = "0x7E17360", VA = "0x187E18760", Slot = "49")]
	public string OBPOGMHOLEP(PFOBOANJLEM MHELDLAMKHB, long JKJNCHGDMGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7E0D980", Offset = "0x7E0C580", VA = "0x187E0D980", Slot = "48")]
	public string AFDNIHEIJAN(PFOBOANJLEM MHELDLAMKHB, int DDEPEJNLKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7E0FC30", Offset = "0x7E0E830", VA = "0x187E0FC30")]
	private void DJPMMEOFGKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0DE20", Offset = "0x7E0CA20", VA = "0x187E0DE20")]
	private void AKOGCLFBCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7E13540", Offset = "0x7E12140", VA = "0x187E13540")]
	private PFOBOANJLEM HNJALAKONGO(LFBDGCLJHNM KEEGIHCABGJ)
	{
		return default(PFOBOANJLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7E118B0", Offset = "0x7E104B0", VA = "0x187E118B0")]
	private PFOBOANJLEM FMGBDANFDBO(LFBDGCLJHNM KEEGIHCABGJ)
	{
		return default(PFOBOANJLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E18470", Offset = "0x7E17070", VA = "0x187E18470")]
	internal static string NOHDJHCDGLH(CHOAHIBBGFL KLLFGGKFBFO, string APCIHPKGPPE, bool BJBINAMKDPH, int OOGKKNLDOPP, int IJCJJJBCHOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E10E90", Offset = "0x7E0FA90", VA = "0x187E10E90", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7E123B0", Offset = "0x7E10FB0", VA = "0x187E123B0")]
	private PEJIBHJPOLO GEDADMBAKGF(BJCCECIKIFB OLKBPIKJLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E910", Offset = "0x7E0D510", VA = "0x187E0E910")]
	private LCOFMHPCGFG BIPEBPCJKDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E490", Offset = "0x7E0D090", VA = "0x187E0E490")]
	private Task BGCIMHLNLAD(KGGEOPPOKLC FABPHEFJGGN, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E12860", Offset = "0x7E11460", VA = "0x187E12860")]
	[AsyncStateMachine(typeof(LBLLNIPFOFE))]
	private Task GNHBMIFAOMI(KGGEOPPOKLC FABPHEFJGGN, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E18D40", Offset = "0x7E17940", VA = "0x187E18D40")]
	private Task OIFHBHKENHN(KGGEOPPOKLC FABPHEFJGGN, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E19620", Offset = "0x7E18220", VA = "0x187E19620")]
	[AsyncStateMachine(typeof(EAFDCMHIDGO))]
	private Task PBDEHCHAMDK(string FNFIPKNHEOF, TimeSpan JHIGHKLMENO, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E16E80", Offset = "0x7E15A80", VA = "0x187E16E80")]
	[CompilerGenerated]
	private void LCCKNKOJNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E141E0", Offset = "0x7E12DE0", VA = "0x187E141E0")]
	[CompilerGenerated]
	private void IFHIGFDOHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E172B0", Offset = "0x7E15EB0", VA = "0x187E172B0")]
	[CompilerGenerated]
	private bool MLDALEDDGEI(KeepsakeInstanceDTO KFGAJBKADFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E19750", Offset = "0x7E18350", VA = "0x187E19750")]
	[CompilerGenerated]
	private KLHBLGBFFDH<Dictionary<BHEHIPCPHLE, int>> PECBFADOPDG(Dictionary<Guid, BHEHIPCPHLE> LNBGJNMJIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E11360", Offset = "0x7E0FF60", VA = "0x187E11360")]
	[CompilerGenerated]
	private KLHBLGBFFDH<Dictionary<BHEHIPCPHLE, int>> ELMGIBKMHOE(Dictionary<Guid, BHEHIPCPHLE> LNBGJNMJIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E0E470", Offset = "0x7E0D070", VA = "0x187E0E470")]
	[CompilerGenerated]
	private bool BFMBAKDKGDK(KeepsakeRoomListDTO KFGAJBKADFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E16640", Offset = "0x7E15240", VA = "0x187E16640")]
	[CompilerGenerated]
	private bool KHIBGLFDIPP(KeepsakeInstanceDTO KFGAJBKADFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E14C80", Offset = "0x7E13880", VA = "0x187E14C80")]
	[CompilerGenerated]
	private void IODBBOIPPPN(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<BHEHIPCPHLE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> HECIKPJEDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7E11300", Offset = "0x7E0FF00", VA = "0x187E11300")]
	[CompilerGenerated]
	private void ELJJBOCHJDK(string AJLIMPCCGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E12EB0", Offset = "0x7E11AB0", VA = "0x187E12EB0")]
	[CompilerGenerated]
	private Task HJCGKONNMEN(CancellationToken FMDHLCIBECF)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, HMBBJPLHOBO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class GGKMGBPKFPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
				public GGKMGBPKFPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7E0C340", Offset = "0x7E0AF40", VA = "0x187E0C340")]
				internal bool CDNFKEKEPED(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7E0C340", Offset = "0x7E0AF40", VA = "0x187E0C340")]
				internal bool DKHEBHJBCDK(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7E1B1D0", Offset = "0x7E19DD0", VA = "0x187E1B1D0")]
			public bool BMHMPAFOMBI(string CCFFFONBLIA, [Out] KeepsakeTheme IPCEEOIAIHB)
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E1B150", Offset = "0x7E19D50", VA = "0x187E1B150")]
		[IGNGJLOKDFM.EEFPBBAIHAI.AEKIIFEBMBN]
		internal static void BACILHPJJBN(PFGPAPHADOM MHCMGFKMEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
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

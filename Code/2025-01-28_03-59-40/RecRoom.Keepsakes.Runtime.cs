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
		[Cpp2IlInjected.Address(RVA = "0x7266900", Offset = "0x7265B00", VA = "0x187266900", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FLHFMHMLKHE : IComparer<PCJJIJAIMEE>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class IJIHOCIJAMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PCJJIJAIMEE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public PCJJIJAIMEE y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IJIHOCIJAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB7D4C0", Offset = "0xB7C6C0", VA = "0x180B7D4C0")]
		internal bool NEFFHBMMIKP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C1BDB0", Offset = "0x1C1AFB0", VA = "0x181C1BDB0")]
		internal bool OODMPFJGCIP(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB7D4C0", Offset = "0xB7C6C0", VA = "0x180B7D4C0")]
		internal bool CJAJPOFEMNH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C1BDB0", Offset = "0x1C1AFB0", VA = "0x181C1BDB0")]
		internal bool DPEABBIOHAN(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> IABIBGGHPNF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x902B20", Offset = "0x901D20", VA = "0x180902B20")]
	public FLHFMHMLKHE(List<KeepsakeCategoryThemePair> ICJDHPMPOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7256650", Offset = "0x7255850", VA = "0x187256650", Slot = "4")]
	public int Compare(PCJJIJAIMEE KIEMJAMMNPB, PCJJIJAIMEE IIOFLMMOEPL)
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
		public PCJJIJAIMEE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KHFOLODBECL]
public class IIHKNOHNGEF : BAFCNJJFGLN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class INHPIPHAJGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IIHKNOHNGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PCJJIJAIMEE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public INHPIPHAJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x72651F0", Offset = "0x72643F0", VA = "0x1872651F0")]
		internal OABBPFFKNOC<Guid> ONLDLAHIENH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7265340", Offset = "0x7264540", VA = "0x187265340")]
		internal void PMOJKCOLCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7264D50", Offset = "0x7263F50", VA = "0x187264D50")]
		internal void DGPPJPNNBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7264DE0", Offset = "0x7263FE0", VA = "0x187264DE0")]
		internal void OKAAMPLIDFI(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7264DB0", Offset = "0x7263FB0", VA = "0x187264DB0")]
		internal void HGOJPIOLMIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class ILJBNCLOFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IIHKNOHNGEF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ILJBNCLOFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x72649A0", Offset = "0x7263BA0", VA = "0x1872649A0")]
		internal void JKMKDIDAFPH(IMAADEPLFIE response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7264940", Offset = "0x7263B40", VA = "0x187264940")]
		internal void GOGIFGIJHCK(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class CCKKLMIPNHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CCKKLMIPNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7255990", Offset = "0x7254B90", VA = "0x187255990")]
		internal bool MAIEPMCAFOF(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PFJAEGIPHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public IIHKNOHNGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public PCJJIJAIMEE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PFJAEGIPHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7266480", Offset = "0x7265680", VA = "0x187266480")]
		internal void ONAOPMGIJHN(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7256450", Offset = "0x7255650", VA = "0x187256450")]
		internal void FPEFDNDFCHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7266180", Offset = "0x7265380", VA = "0x187266180")]
		internal OABBPFFKNOC<IEnumerable<Guid>> EBLFKDDNFNO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E42000", Offset = "0x6E41200", VA = "0x186E42000")]
		internal bool DIDLBOEIIGE(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EGKLBIPEGLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public PFJAEGIPHDB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EGKLBIPEGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7256510", Offset = "0x7255710", VA = "0x187256510")]
		internal OABBPFFKNOC<IEnumerable<Guid>> PIJNCAALKFP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class KMAGNKGEIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public EGKLBIPEGLE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KMAGNKGEIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72653F0", Offset = "0x72645F0", VA = "0x1872653F0")]
		internal bool KBMHHGCGJPI(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class OEFACFPHGEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KMAGNKGEIBA CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OEFACFPHGEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7265D60", Offset = "0x7264F60", VA = "0x187265D60")]
		internal bool MMPOACHOOAL(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BNPBAAFPKKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IIHKNOHNGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BNPBAAFPKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7255820", Offset = "0x7254A20", VA = "0x187255820")]
		internal OABBPFFKNOC<IEnumerable<Guid>> FONACFFEBJA(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7255800", Offset = "0x7254A00", VA = "0x187255800")]
		internal bool FGDLDBNBDKO(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class DGJDCILLGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public IIHKNOHNGEF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DGJDCILLGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7256480", Offset = "0x7255680", VA = "0x187256480")]
		internal void OPKGICPBNAP(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7256450", Offset = "0x7255650", VA = "0x187256450")]
		internal void MFOFNBPIKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7256160", Offset = "0x7255360", VA = "0x187256160")]
		internal OABBPFFKNOC<Dictionary<Guid, PCJJIJAIMEE>> DJGDEDLNKED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E42000", Offset = "0x6E41200", VA = "0x186E42000")]
		internal bool JDGPBAGCNJL(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NKECGKHHBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NKECGKHHBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7265BB0", Offset = "0x7264DB0", VA = "0x187265BB0")]
		internal OABBPFFKNOC<Dictionary<Guid, PCJJIJAIMEE>> CCLAMBPDBCP(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CJHAACPHJBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CJHAACPHJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7256080", Offset = "0x7255280", VA = "0x187256080")]
		internal bool LJBKOJCNMEC(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7255F30", Offset = "0x7255130", VA = "0x187255F30")]
		internal KeyValuePair<Guid, PCJJIJAIMEE> CGKECFJCIOC(Guid instanceId)
		{
			return default(KeyValuePair<Guid, PCJJIJAIMEE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NPLAIMMFAJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NPLAIMMFAJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x21CCEE0", Offset = "0x21CC0E0", VA = "0x1821CCEE0")]
		internal bool ADEAEMEKANM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class BKKDHEHLPLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BKKDHEHLPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x21CCEE0", Offset = "0x21CC0E0", VA = "0x1821CCEE0")]
		internal bool NENPFCIDPDJ(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LOBFLIGCEOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public IIHKNOHNGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LOBFLIGCEOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7265770", Offset = "0x7264970", VA = "0x187265770")]
		internal OABBPFFKNOC<Dictionary<Guid, PCJJIJAIMEE>> OFIKAMLHHHK(Dictionary<Guid, PCJJIJAIMEE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7255800", Offset = "0x7254A00", VA = "0x187255800")]
		internal bool HKEHPCIBNAF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PKDLGEKFIJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PKDLGEKFIJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7266510", Offset = "0x7265710", VA = "0x187266510")]
		internal bool CDBFMDLNECA(KeyValuePair<Guid, PCJJIJAIMEE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PMAAEMNEAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, PCJJIJAIMEE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PMAAEMNEAAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7266590", Offset = "0x7265790", VA = "0x187266590")]
		internal KeyValuePair<PCJJIJAIMEE, int> GNCJANLDGFG(PCJJIJAIMEE category)
		{
			return default(KeyValuePair<PCJJIJAIMEE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class ADLFDCAIELO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PCJJIJAIMEE category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public ADLFDCAIELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xC8BDA0", Offset = "0xC8AFA0", VA = "0x180C8BDA0")]
		internal bool GNOMOKPCCIJ(PCJJIJAIMEE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MLACGIFOPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, PCJJIJAIMEE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MLACGIFOPHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7265A60", Offset = "0x7264C60", VA = "0x187265A60")]
		internal KeyValuePair<PCJJIJAIMEE, int> CGICNKDAGDN(PCJJIJAIMEE category)
		{
			return default(KeyValuePair<PCJJIJAIMEE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FPCICHJALFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public PCJJIJAIMEE category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FPCICHJALFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xC8BDA0", Offset = "0xC8AFA0", VA = "0x180C8BDA0")]
		internal bool HPIDEAJNHHC(PCJJIJAIMEE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BHIFFBBACLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public IIHKNOHNGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BHIFFBBACLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7255650", Offset = "0x7254850", VA = "0x187255650")]
		internal bool LFJHCKGNANM(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7255740", Offset = "0x7254940", VA = "0x187255740")]
		internal bool OOIDBAPHKGG(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7255630", Offset = "0x7254830", VA = "0x187255630")]
		internal bool ICGPEMFJOPD(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7255630", Offset = "0x7254830", VA = "0x187255630")]
		internal bool DLKCMMCBHCE(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JBJPJBJKGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public JBJPJBJKGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCF10D0", Offset = "0xCF02D0", VA = "0x180CF10D0")]
		internal bool NHCIAKFPNNI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BFBHBJLBEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public BFBHBJLBEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7255570", Offset = "0x7254770", VA = "0x187255570")]
		internal bool MCFGKAAHKKF(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2193FE0", Offset = "0x21931E0", VA = "0x182193FE0")]
		internal bool DPLKGLODKGO(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AFHKPPPGPNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AFHKPPPGPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7255420", Offset = "0x7254620", VA = "0x187255420")]
		internal bool JFILLDNEEDO(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CGEAOFJHMIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public CGEAOFJHMIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xCF10D0", Offset = "0xCF02D0", VA = "0x180CF10D0")]
		internal bool FEJLOEIGNEN(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class MIPGFDOHJJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MIPGFDOHJJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7265A00", Offset = "0x7264C00", VA = "0x187265A00")]
		internal bool NIKPFJNHKEI(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class OGJDBAFAMCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public PCJJIJAIMEE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public OGJDBAFAMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1E02E70", Offset = "0x1E02070", VA = "0x181E02E70")]
		internal bool DKDLNKHMOEO(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class MEAPIOKDLMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MEAPIOKDLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7265970", Offset = "0x7264B70", VA = "0x187265970")]
		internal bool BNIMKHMHMKM(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class FPBEJMGEFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public PCJJIJAIMEE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public FPBEJMGEFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7256900", Offset = "0x7255B00", VA = "0x187256900")]
		internal bool NGJJHAKMPHM(KeyValuePair<Guid, PCJJIJAIMEE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class KJGFOJHPPKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PCJJIJAIMEE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public KJGFOJHPPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E02E70", Offset = "0x1E02070", VA = "0x181E02E70")]
		internal bool OBFDAMLGJBF(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class PFDABLPDCIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public PFDABLPDCIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7266100", Offset = "0x7265300", VA = "0x187266100")]
		internal bool DJCBIFGODEE(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class APCPPMAMFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public APCPPMAMFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7255480", Offset = "0x7254680", VA = "0x187255480")]
		internal bool IHFHNMLEPHI(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IPEBNGIBBAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public APCPPMAMFBK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public IPEBNGIBBAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7265370", Offset = "0x7264570", VA = "0x187265370")]
		internal bool DIGMKPOJFKG(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct CGKNDHLPBJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IIHKNOHNGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GHIJJJNKODG args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72559B0", Offset = "0x7254BB0", VA = "0x1872559B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7255ED0", Offset = "0x72550D0", VA = "0x187255ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct PEDCOLNANNO : IAsyncStateMachine
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
		public IIHKNOHNGEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7265E10", Offset = "0x7265010", VA = "0x187265E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x72660A0", Offset = "0x72652A0", VA = "0x1872660A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime KBOLMMCMBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DPDFKPJJMMF NIMPJCAJLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly JIFFAJLNFED NCEIJPDJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly BJFFCPMIKKF GDIGJOFFBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BHGEBPAJCJG KFGGNNGBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CAKAGJOFHDA CNCOIDECOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JAMFFMCLHCL DMPKMPAGGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KFOMELNKPNH BNJCBFNOIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JMCGIMEIOCB IBMNPFDADDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly PIJBAIOLPJE EFOCGNBLMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HPINCOOOOOI HEJEOAPPAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly EENFDAPPFPG CLGFMPLKHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HIFAFLOJDEF BOMFMEFLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HDDNGEKEBJM AAMFMLKJOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AEIKKPCLJPA CJHNJLPANHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly AMGPLCCFDEC OILOAKOCPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly OIKOPNNNFIE<KeepsakesConfig.KeepsakesOptions> GPDCLNOGPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly AFJINEAEPKI APAGJACOOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> HPOHNPPKFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> DPNGPONKOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> LGACMFNLOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<PCJJIJAIMEE, int> HBJEGLAJGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> MONPGGCDOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable MJLNENACPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task PIAFKFLHFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private OABBPFFKNOC<Guid> LEHNAHPCBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? KNNPLPABPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO EAPIDLDLJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OABBPFFKNOC<KeepsakeProgressionEventInstancesDTO> ELFKBDFJGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<PCJJIJAIMEE, KeepsakeCategoryConfigDTO> KHMDIAAMLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO MDCIDFMOEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> ICEBIGKEODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> IAKIEMGDKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> DMGLBPEFIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> MAILEFMIGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> HFKIIFNEPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> ONAJGKPMEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> DOCCLJFPLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> BOJHFBOGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> IGGKEDOGAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> HKFFGGHJOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> HFIDICABHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> MIECOBJAJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime OGCHCKAJONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable NGCAGFABEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, PCJJIJAIMEE> CJKNKHPMIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<PCJJIJAIMEE, int> OGPHCDIKCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> ICJDHPMPOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FLHFMHMLKHE GCENIGGMCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool HCDLNFMMNGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KBLAAIAMOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x920F50", Offset = "0x920150", VA = "0x180920F50", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x920CD0", Offset = "0x91FED0", VA = "0x180920CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ANOKAFJOKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x725B1E0", Offset = "0x725A3E0", VA = "0x18725B1E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BKLCMHIOIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7258E30", Offset = "0x7258030", VA = "0x187258E30", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long GECEHDEMGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x725B070", Offset = "0x725A270", VA = "0x18725B070")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? JBFDHGBHOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7260DF0", Offset = "0x725FFF0", VA = "0x187260DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool FPPNKDGILCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x725D000", Offset = "0x725C200", VA = "0x18725D000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> MGNFLNFHOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9615E0", Offset = "0x9607E0", VA = "0x1809615E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> APHANGMGNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x960D50", Offset = "0x95FF50", VA = "0x180960D50", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> FKHEENMPLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x954140", Offset = "0x953340", VA = "0x180954140", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DJPCLPLCPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95A980", Offset = "0x959B80", VA = "0x18095A980", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool FNEBBAGNGID
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x23C0D20", Offset = "0x23BFF20", VA = "0x1823C0D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> LIAENADJCIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7259F30", Offset = "0x7259130", VA = "0x187259F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72610E0", Offset = "0x72602E0", VA = "0x1872610E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NDAELDHLHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7259C60", Offset = "0x7258E60", VA = "0x187259C60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x725AFD0", Offset = "0x725A1D0", VA = "0x18725AFD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JAKPILHGFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72621E0", Offset = "0x72613E0", VA = "0x1872621E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x725B140", Offset = "0x725A340", VA = "0x18725B140", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7263380", Offset = "0x7262580", VA = "0x187263380")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IIHKNOHNGEF([FMJHJHHALCB(null)][NotNull] DPDFKPJJMMF NIMPJCAJLLG, [NotNull][FMJHJHHALCB(null)] MEKMCOEEPLL NGAGNLPFNFJ, [NotNull][FMJHJHHALCB(null)] JIFFAJLNFED NCEIJPDJGFD, [NotNull][FMJHJHHALCB(null)] BJFFCPMIKKF GDIGJOFFBBM, [FMJHJHHALCB(null)][NotNull] BHGEBPAJCJG KFGGNNGBAKP, [FMJHJHHALCB(null)][NotNull] CAKAGJOFHDA CNCOIDECOMJ, [FMJHJHHALCB(null)][NotNull] JAMFFMCLHCL DMPKMPAGGPA, [NotNull][FMJHJHHALCB(null)] KFOMELNKPNH BNJCBFNOIOC, [NotNull][FMJHJHHALCB(null)] JMCGIMEIOCB IBMNPFDADDO, [NotNull][FMJHJHHALCB(null)] PHNNBMOFPME PJPIDONPAFD, [NotNull][FMJHJHHALCB(null)] PIJBAIOLPJE EFOCGNBLMPD, [NotNull][FMJHJHHALCB(null)] HPINCOOOOOI HEJEOAPPAGB, [NotNull][FMJHJHHALCB(null)] EENFDAPPFPG CLGFMPLKHPE, [NotNull][FMJHJHHALCB(null)] HIFAFLOJDEF BOMFMEFLCPJ, [FMJHJHHALCB(null)][NotNull] HDDNGEKEBJM AAMFMLKJOFL, [FMJHJHHALCB(null)][NotNull] AEIKKPCLJPA CJHNJLPANHO, [NotNull][FMJHJHHALCB(null)] AMGPLCCFDEC OILOAKOCPML, [FMJHJHHALCB(null)][NotNull] OIKOPNNNFIE<KeepsakesConfig.KeepsakesOptions> GPDCLNOGPJC, [NotNull][FMJHJHHALCB(null)] AFJINEAEPKI APAGJACOOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x725F1A0", Offset = "0x725E3A0", VA = "0x18725F1A0", Slot = "15")]
	public bool LJJOKLINPEH(List<string> KPMDELPMGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7261BD0", Offset = "0x7260DD0", VA = "0x187261BD0", Slot = "16")]
	public OABBPFFKNOC<Guid> ONPMGDCFGCH(PCJJIJAIMEE KJAKIKOOIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7256940", Offset = "0x7255B40", VA = "0x187256940", Slot = "17")]
	public JABNAOPJDOK AAHMANCDPOP(Guid IOIJMEMDMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x725A1B0", Offset = "0x72593B0", VA = "0x18725A1B0", Slot = "18")]
	public JABNAOPJDOK DOKDOPIDNDN(Guid IOIJMEMDMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x725C2F0", Offset = "0x725B4F0", VA = "0x18725C2F0", Slot = "19")]
	public bool GOOJDPBJDBG(Guid IOIJMEMDMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x725E730", Offset = "0x725D930", VA = "0x18725E730", Slot = "20")]
	public bool KMNNNMOGGKB(Guid IOIJMEMDMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x725E5F0", Offset = "0x725D7F0", VA = "0x18725E5F0")]
	public KeepsakeTheme KHKGPNJPJMD(Guid IOIJMEMDMBE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7258600", Offset = "0x7257800", VA = "0x187258600")]
	public bool BOOEAGDLCOM(PCJJIJAIMEE KJAKIKOOIAB, [Out] KeepsakeTheme MGOJMFCCPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72570A0", Offset = "0x72562A0", VA = "0x1872570A0")]
	public List<KeepsakeTheme> AKCIPBIFIFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7258480", Offset = "0x7257680", VA = "0x187258480")]
	public int BOIPKBJMBDI(PCJJIJAIMEE KJAKIKOOIAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7258120", Offset = "0x7257320", VA = "0x187258120")]
	public PCJJIJAIMEE BJCDNDPLGEA(Guid IOIJMEMDMBE)
	{
		return default(PCJJIJAIMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7261970", Offset = "0x7260B70", VA = "0x187261970", Slot = "34")]
	public List<PCJJIJAIMEE> ONHKPNGHFJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7257450", Offset = "0x7256650", VA = "0x187257450", Slot = "35")]
	public IComparer<PCJJIJAIMEE> AMGNKEBNOLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7260C70", Offset = "0x725FE70", VA = "0x187260C70", Slot = "32")]
	public string MPIMHPLDICP(PCJJIJAIMEE KJAKIKOOIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x725A990", Offset = "0x7259B90", VA = "0x18725A990", Slot = "33")]
	public string EBIANBBHOJJ(PCJJIJAIMEE KJAKIKOOIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7258920", Offset = "0x7257B20", VA = "0x187258920", Slot = "21")]
	public bool CCIEEKAEBPI(Guid IOIJMEMDMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7261480", Offset = "0x7260680", VA = "0x187261480", Slot = "22")]
	public void OHAHLPDGEJF(Guid IOIJMEMDMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x725F150", Offset = "0x725E350", VA = "0x18725F150", Slot = "23")]
	public void LJBODOAELFC(PCJJIJAIMEE KJAKIKOOIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x725F530", Offset = "0x725E730", VA = "0x18725F530", Slot = "24")]
	public void LPMMEILBJNF(Guid IOIJMEMDMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7262370", Offset = "0x7261570", VA = "0x187262370", Slot = "25")]
	public int PAPBIHKLNKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7262F70", Offset = "0x7262170", VA = "0x187262F70", Slot = "31")]
	public OABBPFFKNOC<IEnumerable<Guid>> PODHEANHALE(long MOMKFNIIPAA, long LGNJCAPGEBH, PCJJIJAIMEE? KJAKIKOOIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x725AE40", Offset = "0x725A040", VA = "0x18725AE40", Slot = "30")]
	public OABBPFFKNOC<IEnumerable<Guid>> EIFJLHHBFPM(long MOMKFNIIPAA, long LGNJCAPGEBH, PCJJIJAIMEE? KJAKIKOOIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7257C50", Offset = "0x7256E50", VA = "0x187257C50", Slot = "54")]
	public OABBPFFKNOC<Dictionary<Guid, PCJJIJAIMEE>> BEJEKPHGJFF(long MOMKFNIIPAA, long LGNJCAPGEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x725B230", Offset = "0x725A430", VA = "0x18725B230", Slot = "55")]
	public OABBPFFKNOC<Dictionary<Guid, PCJJIJAIMEE>> EPPIMNIPCEK(long MOMKFNIIPAA, long LGNJCAPGEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x725DA80", Offset = "0x725CC80", VA = "0x18725DA80", Slot = "26")]
	public OABBPFFKNOC<int> JIEMFONFEIE(long MOMKFNIIPAA, long LGNJCAPGEBH, PCJJIJAIMEE? KJAKIKOOIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x725ACE0", Offset = "0x7259EE0", VA = "0x18725ACE0", Slot = "27")]
	public OABBPFFKNOC<int> EHPNKLEIACH(long MOMKFNIIPAA, long LGNJCAPGEBH, PCJJIJAIMEE? KJAKIKOOIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7262D60", Offset = "0x7261F60", VA = "0x187262D60", Slot = "28")]
	public OABBPFFKNOC<Dictionary<PCJJIJAIMEE, int>> PMPKDJIJLJH(long MOMKFNIIPAA, long LGNJCAPGEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7258060", Offset = "0x7257260", VA = "0x187258060", Slot = "29")]
	public OABBPFFKNOC<Dictionary<PCJJIJAIMEE, int>> BHOBBAAMGDL(long MOMKFNIIPAA, long LGNJCAPGEBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7257510", Offset = "0x7256710", VA = "0x187257510", Slot = "37")]
	public bool AOFFAEONILJ(long MOMKFNIIPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7258000", Offset = "0x7257200", VA = "0x187258000", Slot = "56")]
	public bool BFIJIJEOOBO(long MOMKFNIIPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7259BC0", Offset = "0x7258DC0", VA = "0x187259BC0", Slot = "38")]
	public bool DAMFADCNPKP(long MOMKFNIIPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72597F0", Offset = "0x72589F0", VA = "0x1872597F0", Slot = "57")]
	public bool CMDJPHBJKHG(long MOMKFNIIPAA, [Out] FBAMJPCIPCD GLBNPDFOHMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72587E0", Offset = "0x72579E0", VA = "0x1872587E0", Slot = "39")]
	public bool CBLJPOBIKDM(long DGFDBEGFIFL, [Out] DateTime GPGLJAMIPPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7258EF0", Offset = "0x72580F0", VA = "0x187258EF0", Slot = "40")]
	public long CELLNAIPMMP(long DGFDBEGFIFL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x725E170", Offset = "0x725D370", VA = "0x18725E170", Slot = "41")]
	public long KBKPBNBEKEN(long MOMKFNIIPAA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x725E410", Offset = "0x725D610", VA = "0x18725E410", Slot = "42")]
	public int KGAJKAGIJKJ(long DGFDBEGFIFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x725E090", Offset = "0x725D290", VA = "0x18725E090", Slot = "43")]
	public bool KBIDLMDLCAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x725E280", Offset = "0x725D480", VA = "0x18725E280", Slot = "44")]
	public bool KDOKOOKPILF(long DGFDBEGFIFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7258BC0", Offset = "0x7257DC0", VA = "0x187258BC0", Slot = "45")]
	public IReadOnlyList<long> CDHFIHPCKHL(long DGFDBEGFIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x725D710", Offset = "0x725C910", VA = "0x18725D710", Slot = "46")]
	public int JCPJKOHLOMD(long DGFDBEGFIFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x725C450", Offset = "0x725B650", VA = "0x18725C450", Slot = "50")]
	public long HEKEGOPBKGA(long IBBNJPOMHJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x725BCA0", Offset = "0x725AEA0", VA = "0x18725BCA0", Slot = "51")]
	public PCJJIJAIMEE GEPJPCJIEHL()
	{
		return default(PCJJIJAIMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7260E80", Offset = "0x7260080", VA = "0x187260E80")]
	private bool NGHLJCCBLCF(Guid IOIJMEMDMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72627B0", Offset = "0x72619B0", VA = "0x1872627B0")]
	private void PFJIGCGHHIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x725D430", Offset = "0x725C630", VA = "0x18725D430")]
	private PCJJIJAIMEE JAKIOOKJEJP()
	{
		return default(PCJJIJAIMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x725B4D0", Offset = "0x725A6D0", VA = "0x18725B4D0")]
	private void FIPNDDBHIFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72614F0", Offset = "0x72606F0", VA = "0x1872614F0")]
	private int OJHFFIIMFDP(KeepsakeRoomListDTO KLKAGLHIFIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7259DB0", Offset = "0x7258FB0", VA = "0x187259DB0")]
	private int DKLPHJJBCLL(DateTime JKBODALKEOO, DateTime LOJNMBNPFOF, TimeSpan JMAMBOLMDIG, int OONPPJKMIAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7261190", Offset = "0x7260390", VA = "0x187261190")]
	private void NKPPJKFMJOI(IEnumerable<KeepsakeInstanceDTO> HPOHNPPKFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x725E760", Offset = "0x725D960", VA = "0x18725E760")]
	private void KPJMPMJOKND(IEnumerable<KeepsakeCollectionRecordDTO> LPBFNAJEEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7263320", Offset = "0x7262520", VA = "0x187263320")]
	private void POONGNFAJEK(IEnumerable<long> JEILMHLDHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x961D10", Offset = "0x960F10", VA = "0x180961D10")]
	private void OICLDBJKPMB(KeepsakeGlobalConfigDTO MDCIDFMOEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x725CBF0", Offset = "0x725BDF0", VA = "0x18725CBF0")]
	private bool IFFEHIDNFJD(PCJJIJAIMEE KJAKIKOOIAB, [Out] Guid PMFBOFCKGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x725C010", Offset = "0x725B210", VA = "0x18725C010")]
	private bool GFEDHPMDFCJ([Out] Guid PMFBOFCKGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7261420", Offset = "0x7260620", VA = "0x187261420")]
	private bool NNBODJJEGHN(Guid IOIJMEMDMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x725AB10", Offset = "0x7259D10", VA = "0x18725AB10")]
	private IEnumerable<Guid> EDEIJDHHAIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7262CA0", Offset = "0x7261EA0", VA = "0x187262CA0")]
	private IEnumerable<KeepsakeInstanceDTO> PKKOLEIGBJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x725F0C0", Offset = "0x725E2C0", VA = "0x18725F0C0")]
	private void LHNAHIBJJNO(Guid IOIJMEMDMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7259D00", Offset = "0x7258F00", VA = "0x187259D00")]
	private bool DKGHCGHJBPE(Guid IOIJMEMDMBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x725CE60", Offset = "0x725C060", VA = "0x18725CE60")]
	private void IFOJHJCCGCP(Guid IOIJMEMDMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7257B70", Offset = "0x7256D70", VA = "0x187257B70")]
	private void BDLLCDIFNCK(PCJJIJAIMEE ODGIEDCAFMF, int PKFKHBMNIBH, Dictionary<PCJJIJAIMEE, int> JACOMBMLBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7262280", Offset = "0x7261480", VA = "0x187262280")]
	private int PAOKEBLAMEP(PCJJIJAIMEE KJAKIKOOIAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7259FE0", Offset = "0x72591E0", VA = "0x187259FE0")]
	private void DODCIEBCAOA(KeepsakeInstanceDTO EIFPLKCPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x725F770", Offset = "0x725E970", VA = "0x18725F770")]
	private void MDDIGENAEHL(KeepsakeInstanceDTO EIFPLKCPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x725C820", Offset = "0x725BA20", VA = "0x18725C820")]
	private void IDPKNIJNABI(Guid IOIJMEMDMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x725B3C0", Offset = "0x725A5C0", VA = "0x18725B3C0")]
	private void HBBIOAGAKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7262C80", Offset = "0x7261E80", VA = "0x187262C80")]
	private void PJMMIGLDIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x725AC70", Offset = "0x7259E70", VA = "0x18725AC70")]
	private void EEMLKPBDMDF(IAFPHBAAAOE ABMEFKHBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x725B3C0", Offset = "0x725A5C0", VA = "0x18725B3C0")]
	private void OKBGCDJOJBI(HBMPCDLJNHN LCACGJDNDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x725B3C0", Offset = "0x725A5C0", VA = "0x18725B3C0")]
	private void FAKCMMOIOAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7256BC0", Offset = "0x7255DC0", VA = "0x187256BC0")]
	private void ABFLPPOIKBF(float JDOEILPOGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x725E9B0", Offset = "0x725DBB0", VA = "0x18725E9B0")]
	private void LBDIAOLIGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7258280", Offset = "0x7257480", VA = "0x187258280")]
	private bool BNAAPIMHEHA(Guid IOIJMEMDMBE, [Out] string OFABEPBOKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x725FB60", Offset = "0x725ED60", VA = "0x18725FB60")]
	private bool MFOGIBDAAKF(Guid IOIJMEMDMBE, [Out] KeepsakeCategoryConfigDTO ODGIEDCAFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x725B3F0", Offset = "0x725A5F0", VA = "0x18725B3F0")]
	private void FCJLIBEGBGA(string MMICDODOBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x725C710", Offset = "0x725B910", VA = "0x18725C710")]
	private bool IBLOJGLACCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7261690", Offset = "0x7260890", VA = "0x187261690")]
	private List<long> OMCCGDOPNMI(IEnumerable<KeepsakeRoomDTO> ECOHEEKAIID, IReadOnlyList<KeepsakeRoomListDTO> NAFCCDGEMGP, long DGFDBEGFIFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7257570", Offset = "0x7256770", VA = "0x187257570")]
	private bool BCJNFLPEDDM(Guid IOIJMEMDMBE, [Out] string GILNIHGCEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7257040", Offset = "0x7256240", VA = "0x187257040", Slot = "47")]
	public string AJGJHBMNBKB(ABGFDMBJMFM BPKENABGPED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x725D010", Offset = "0x725C210", VA = "0x18725D010", Slot = "49")]
	public string IPHNHGOMKLO(ABGFDMBJMFM BPKENABGPED, long MOMKFNIIPAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7257A90", Offset = "0x7256C90", VA = "0x187257A90", Slot = "48")]
	public string BCMCFCDGPKC(ABGFDMBJMFM BPKENABGPED, int LNOGENOHDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x725FD30", Offset = "0x725EF30", VA = "0x18725FD30")]
	private void MGBGCEKJIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x725D7C0", Offset = "0x725C9C0", VA = "0x18725D7C0")]
	private void JDHAPBLHHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7259BA0", Offset = "0x7258DA0", VA = "0x187259BA0")]
	private ABGFDMBJMFM CNGNEBMDJBL(JKIBGMHMKDH HCFIKKKEJOD)
	{
		return default(ABGFDMBJMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x725C2D0", Offset = "0x725B4D0", VA = "0x18725C2D0")]
	private ABGFDMBJMFM GJCLGKJFILA(JKIBGMHMKDH HCFIKKKEJOD)
	{
		return default(ABGFDMBJMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x725DD20", Offset = "0x725CF20", VA = "0x18725DD20")]
	internal static string JIHGICDLPGL(IMAADEPLFIE NGEFDMBBCMO, string INFPHJENMKL, bool MNHNNEEJBEE, int IMPOPOHINDB, int EBAPAOIKLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x725A530", Offset = "0x7259730", VA = "0x18725A530", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7259EB0", Offset = "0x72590B0", VA = "0x187259EB0")]
	private JIDFLMCDEBP DLPPMPOFJLP(IAGJLFEFIKH EJEKNOCBCJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x725F980", Offset = "0x725EB80", VA = "0x18725F980")]
	private JIKAOKCOAGM MELEDBDKOIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7259430", Offset = "0x7258630", VA = "0x187259430")]
	private Task CMBDFNBDEPA(GHIJJJNKODG OKBEKNPNPIM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7261AC0", Offset = "0x7260CC0", VA = "0x187261AC0")]
	[AsyncStateMachine(typeof(CGKNDHLPBJB))]
	private Task ONIBOEDNBGD(GHIJJJNKODG OKBEKNPNPIM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7256F60", Offset = "0x7256160", VA = "0x187256F60")]
	private Task AIKGKFAOOND(GHIJJJNKODG OKBEKNPNPIM, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x725D950", Offset = "0x725CB50", VA = "0x18725D950")]
	[AsyncStateMachine(typeof(PEDCOLNANNO))]
	private Task JEANCJIMBIC(string CBCJFCINKPJ, TimeSpan KGABHJAAHLB, CancellationToken BGEKICMONBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x725FB40", Offset = "0x725ED40", VA = "0x18725FB40")]
	[CompilerGenerated]
	private void MENDPJEAMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7260C20", Offset = "0x725FE20", VA = "0x187260C20")]
	[CompilerGenerated]
	private void MGKLHFICPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x725F430", Offset = "0x725E630", VA = "0x18725F430")]
	[CompilerGenerated]
	private bool LMHDJDNEKEA(KeepsakeInstanceDTO KIEMJAMMNPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x725EF50", Offset = "0x725E150", VA = "0x18725EF50")]
	[CompilerGenerated]
	private OABBPFFKNOC<Dictionary<PCJJIJAIMEE, int>> LCCPAHFPKBE(Dictionary<Guid, PCJJIJAIMEE> MDAFGGLADLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x725DF00", Offset = "0x725D100", VA = "0x18725DF00")]
	[CompilerGenerated]
	private OABBPFFKNOC<Dictionary<PCJJIJAIMEE, int>> JLLAMKFJGFK(Dictionary<Guid, PCJJIJAIMEE> MDAFGGLADLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x725E070", Offset = "0x725D270", VA = "0x18725E070")]
	[CompilerGenerated]
	private bool KBGBFFAAMEO(KeepsakeRoomListDTO KIEMJAMMNPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7260FB0", Offset = "0x72601B0", VA = "0x187260FB0")]
	[CompilerGenerated]
	private bool NGPMBAIJMKD(KeepsakeInstanceDTO KIEMJAMMNPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x725BB10", Offset = "0x725AD10", VA = "0x18725BB10")]
	[CompilerGenerated]
	private void GEBPLLDLOCL(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<PCJJIJAIMEE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> ELMABPNEBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x725C0B0", Offset = "0x725B2B0", VA = "0x18725C0B0")]
	[CompilerGenerated]
	private void GIBECFPGAJH(string GILNIHGCEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x725C110", Offset = "0x725B310", VA = "0x18725C110")]
	[CompilerGenerated]
	private Task GICHCPKDFPF(CancellationToken HBOMMAOLIMB)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, OIKOPNNNFIE<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class MHFGHAHOCCH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
				public MHFGHAHOCCH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x72659D0", Offset = "0x7264BD0", VA = "0x1872659D0")]
				internal bool AMENGMFCGIC(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x72659D0", Offset = "0x7264BD0", VA = "0x1872659D0")]
				internal bool HHDBCGHMJFC(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x72655A0", Offset = "0x72647A0", VA = "0x1872655A0")]
			public bool MMLALHNGKHB(string PKBGFKOAIFG, [Out] KeepsakeTheme MGOJMFCCPOC)
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7265520", Offset = "0x7264720", VA = "0x187265520")]
		[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
		internal static void EMFHCKBHCPB(JBPONICDCIO CKNPDKKKGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58510", VA = "0x180A59310")]
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

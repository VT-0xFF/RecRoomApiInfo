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
		[Cpp2IlInjected.Address(RVA = "0x7C81CC0", Offset = "0x7C802C0", VA = "0x187C81CC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IPHICIAMMHH : IComparer<AFACIFHCNFE>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class CIKPMNLIFFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AFACIFHCNFE x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AFACIFHCNFE y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CIKPMNLIFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCDC580", Offset = "0xCDAB80", VA = "0x180CDC580")]
		internal bool FKJEAFKOHGF(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BCA0", Offset = "0x1E8A2A0", VA = "0x181E8BCA0")]
		internal bool BMGCFKOHHBH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCDC580", Offset = "0xCDAB80", VA = "0x180CDC580")]
		internal bool ANEKHBJKDHJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E8BCA0", Offset = "0x1E8A2A0", VA = "0x181E8BCA0")]
		internal bool IGPENJAIJMO(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> OFPOALBHIKE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public IPHICIAMMHH(List<KeepsakeCategoryThemePair> DANFIPBJOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C71F80", Offset = "0x7C70580", VA = "0x187C71F80", Slot = "4")]
	public int Compare(AFACIFHCNFE CEJAAIDLEPA, AFACIFHCNFE IMNDAJIDDFG)
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
		public AFACIFHCNFE KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HJNCDIOGCJG]
public class LECBEAFJNJC : NKOPLKBCBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EBLKHEJAGIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AFACIFHCNFE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EBLKHEJAGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C71340", Offset = "0x7C6F940", VA = "0x187C71340")]
		internal KGAPFDAFEHM<Guid> PJMDOHJBLEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C71280", Offset = "0x7C6F880", VA = "0x187C71280")]
		internal void HKDIMOGKEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C712E0", Offset = "0x7C6F8E0", VA = "0x187C712E0")]
		internal void NAFBPJKPNBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C70E70", Offset = "0x7C6F470", VA = "0x187C70E70")]
		internal void EDDGMHFOJAN(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C712B0", Offset = "0x7C6F8B0", VA = "0x187C712B0")]
		internal void IJIPKCOLLBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HAGNLCFMKGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public LECBEAFJNJC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public HAGNLCFMKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C71A40", Offset = "0x7C70040", VA = "0x187C71A40")]
		internal void PBPCJBNJPGM(BHMEEJACIIA response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C719E0", Offset = "0x7C6FFE0", VA = "0x187C719E0")]
		internal void KHFJPFANONA(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class JCMNEOHLOOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JCMNEOHLOOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C72230", Offset = "0x7C70830", VA = "0x187C72230")]
		internal bool BCJBDLADILP(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class JPHMOAPCKJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AFACIFHCNFE? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JPHMOAPCKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C72280", Offset = "0x7C70880", VA = "0x187C72280")]
		internal void ENLOPNMJOGH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C72250", Offset = "0x7C70850", VA = "0x187C72250")]
		internal void CKMMHNOBNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C72310", Offset = "0x7C70910", VA = "0x187C72310")]
		internal KGAPFDAFEHM<IEnumerable<Guid>> KMDFCLCEIEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x77CB9C0", Offset = "0x77C9FC0", VA = "0x1877CB9C0")]
		internal bool GJJGHNKAMPG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PJBJBHAFMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public JPHMOAPCKJD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PJBJBHAFMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C81970", Offset = "0x7C7FF70", VA = "0x187C81970")]
		internal KGAPFDAFEHM<IEnumerable<Guid>> CLJOMILJDKH(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HIEAOGADHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public PJBJBHAFMBJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public HIEAOGADHHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C71DF0", Offset = "0x7C703F0", VA = "0x187C71DF0")]
		internal bool CKKKKJMMICG(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class EPNMBMPIJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public HIEAOGADHHO CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EPNMBMPIJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C71580", Offset = "0x7C6FB80", VA = "0x187C71580")]
		internal bool JOBAJBIFEOP(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BCLECBMAEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BCLECBMAEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C70AC0", Offset = "0x7C6F0C0", VA = "0x187C70AC0")]
		internal KGAPFDAFEHM<IEnumerable<Guid>> MEEBNIAOGCA(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C70AA0", Offset = "0x7C6F0A0", VA = "0x187C70AA0")]
		internal bool GALPCPDJBBA(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class OFGHMHGBAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public LECBEAFJNJC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OFGHMHGBAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C80FE0", Offset = "0x7C7F5E0", VA = "0x187C80FE0")]
		internal void MNBOIKDNPCB(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7C72250", Offset = "0x7C70850", VA = "0x187C72250")]
		internal void FKCPEOMMKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C81070", Offset = "0x7C7F670", VA = "0x187C81070")]
		internal KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> NIIBFAGNIJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x77CB9C0", Offset = "0x77C9FC0", VA = "0x1877CB9C0")]
		internal bool HBHGAGGDBEC(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FBAGHLJAFGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FBAGHLJAFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C71630", Offset = "0x7C6FC30", VA = "0x187C71630")]
		internal KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> AAPNJNBIKCE(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KEFIDKPPBJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KEFIDKPPBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C72760", Offset = "0x7C70D60", VA = "0x187C72760")]
		internal bool HCKNLEAJDCE(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C72610", Offset = "0x7C70C10", VA = "0x187C72610")]
		internal KeyValuePair<Guid, AFACIFHCNFE> GDICKBCOHBO(Guid instanceId)
		{
			return default(KeyValuePair<Guid, AFACIFHCNFE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class ALMDENPHAJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ALMDENPHAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x24B6D50", Offset = "0x24B5350", VA = "0x1824B6D50")]
		internal bool PHCALKNNMHI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class HHPHGKMIHEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public HHPHGKMIHEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x24B6D50", Offset = "0x24B5350", VA = "0x1824B6D50")]
		internal bool JMHLJMLLBLI(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class GBMDGEJDGNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GBMDGEJDGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C717E0", Offset = "0x7C6FDE0", VA = "0x187C717E0")]
		internal KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> FDHNHKFOKJI(Dictionary<Guid, AFACIFHCNFE> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C70AA0", Offset = "0x7C6F0A0", VA = "0x187C70AA0")]
		internal bool EMEFAPIEBJG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class EOBEDGLAAPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EOBEDGLAAPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C71500", Offset = "0x7C6FB00", VA = "0x187C71500")]
		internal bool GLECEIPNIPM(KeyValuePair<Guid, AFACIFHCNFE> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BKNJMCPBHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, AFACIFHCNFE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BKNJMCPBHGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C70C30", Offset = "0x7C6F230", VA = "0x187C70C30")]
		internal KeyValuePair<AFACIFHCNFE, int> AMLJBPBAEJN(AFACIFHCNFE category)
		{
			return default(KeyValuePair<AFACIFHCNFE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GNJGGLMMHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AFACIFHCNFE category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GNJGGLMMHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xDEC430", Offset = "0xDEAA30", VA = "0x180DEC430")]
		internal bool IBLKGDCPPCE(AFACIFHCNFE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class ANMFNGAINBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, AFACIFHCNFE> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ANMFNGAINBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C70950", Offset = "0x7C6EF50", VA = "0x187C70950")]
		internal KeyValuePair<AFACIFHCNFE, int> JPMFKCMPJDI(AFACIFHCNFE category)
		{
			return default(KeyValuePair<AFACIFHCNFE, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MKPJIKANHJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AFACIFHCNFE category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MKPJIKANHJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDEC430", Offset = "0xDEAA30", VA = "0x180DEC430")]
		internal bool JIDODGEABFE(AFACIFHCNFE instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class OEGKGKLOHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OEGKGKLOHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C80ED0", Offset = "0x7C7F4D0", VA = "0x187C80ED0")]
		internal bool JMCLOKKGGKP(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C80E10", Offset = "0x7C7F410", VA = "0x187C80E10")]
		internal bool JAMFNLCENPL(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C80FC0", Offset = "0x7C7F5C0", VA = "0x187C80FC0")]
		internal bool LKLCIEFGIBE(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C80FC0", Offset = "0x7C7F5C0", VA = "0x187C80FC0")]
		internal bool MMBBGECEINP(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NKBCGPLMGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NKBCGPLMGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xE67770", Offset = "0xE65D70", VA = "0x180E67770")]
		internal bool FEDFDBFKNDJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NHDPCMGFCGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public NHDPCMGFCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C80CE0", Offset = "0x7C7F2E0", VA = "0x187C80CE0")]
		internal bool IBPFOOBGCBJ(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x247DD20", Offset = "0x247C320", VA = "0x18247DD20")]
		internal bool NLDJMGFBGKH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IMLMOFPBOGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IMLMOFPBOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C71F20", Offset = "0x7C70520", VA = "0x187C71F20")]
		internal bool HFPBACCMEBD(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class POIIABKOGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public POIIABKOGNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xE67770", Offset = "0xE65D70", VA = "0x180E67770")]
		internal bool JFPIBNAMOJH(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class LDAOAJAPMFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LDAOAJAPMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C72A90", Offset = "0x7C71090", VA = "0x187C72A90")]
		internal bool JGGEMJMLDGF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JGFCFIJDAFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AFACIFHCNFE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public JGFCFIJDAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x209DCB0", Offset = "0x209C2B0", VA = "0x18209DCB0")]
		internal bool FOJAJHAJPJG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EDNKGIMPOLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EDNKGIMPOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C714A0", Offset = "0x7C6FAA0", VA = "0x187C714A0")]
		internal bool DEIOBJBGIMF(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OBFACGHIOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AFACIFHCNFE keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OBFACGHIOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C80DD0", Offset = "0x7C7F3D0", VA = "0x187C80DD0")]
		internal bool JPAEKFPBBLB(KeyValuePair<Guid, AFACIFHCNFE> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IMIIDBCBLJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AFACIFHCNFE newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public IMIIDBCBLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x209DCB0", Offset = "0x209C2B0", VA = "0x18209DCB0")]
		internal bool GBBKKOMPBIL(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ADHEOCNJLNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ADHEOCNJLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C708D0", Offset = "0x7C6EED0", VA = "0x187C708D0")]
		internal bool FHJLDBPBADG(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class DEFOELMGGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DEFOELMGGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C70D80", Offset = "0x7C6F380", VA = "0x187C70D80")]
		internal bool JMEGODOEOKG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class PDEHFDAEGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DEFOELMGGEG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PDEHFDAEGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C818F0", Offset = "0x7C7FEF0", VA = "0x187C818F0")]
		internal bool IPLKKIPEOEO(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct ONNGBHANMAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JOEFAEBJKIB args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C81360", Offset = "0x7C7F960", VA = "0x187C81360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C81890", Offset = "0x7C7FE90", VA = "0x187C81890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct MJKIECGFLOE : IAsyncStateMachine
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
		public LECBEAFJNJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C809F0", Offset = "0x7C7EFF0", VA = "0x187C809F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C80C80", Offset = "0x7C7F280", VA = "0x187C80C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime FNOHCKAPFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OALKBAEBPMC NGBPIDANFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ACLHKLLKNMH MFIGFFKMKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly EFKGGIOBKBJ KJGIFOBJBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KLKLDJKIJAI IHLJLJKADLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly GHEABDPEEMJ BFCIGLOEMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HBLAEJNBENG DLDECNJKBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly MBAMAOLNFEE MHAEOAHGKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LDMAAALPMPJ NODDAHEDIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HLICHGGPCCA IMGLEKANDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JEPLPAAEIMH AFBAPDBEIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HEAKNPJEKDG LAIFMBJMEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LDBCIIKLAGJ EKPGCGJEGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly HGPCKPIAKLB HCKHHIJHPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CFFBBPKENGE KMMCBALEKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly ABHKBFFIJLO KPKDGGHCPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly ILKBOCNMCLO<KeepsakesConfig.KeepsakesOptions> BFEGEHMOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JAHOCBPGMLL AJHJEIPEGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> AGJEJPPAKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> ODDKGOAOBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> CJKLGNELOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<AFACIFHCNFE, int> EPDCMHIAAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> BFLODJPCBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable KBPKFMHMMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task IHGDHMCMLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private KGAPFDAFEHM<Guid> MKAACNEOJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? BFJACEAHEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO EGAPGLGIBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KGAPFDAFEHM<KeepsakeProgressionEventInstancesDTO> MHOAEJGEOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<AFACIFHCNFE, KeepsakeCategoryConfigDTO> KCJMFPEDJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO NHIBEEAMDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> OAANKPILHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> OJPNLOGFKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> GIHECAEIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> CMGGFJCELCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> KHGGJMBPKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> MMAEBJDCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> JLFLAGHEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> GOIOOBPMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> FGDNLEJGHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> JMBHBEKBEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> LANHHPOHOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> HGPKOKCMBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime FNKKFCKABLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable GHOHNJCABAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, AFACIFHCNFE> JKAANIJPEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<AFACIFHCNFE, int> LDJONBJNGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> DANFIPBJOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IPHICIAMMHH CAKBCJBAFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool OAIKHKPDNMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LBLJPFEFHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GPHDADNBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C793C0", Offset = "0x7C779C0", VA = "0x187C793C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NPJFMOBNCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C7F360", Offset = "0x7C7D960", VA = "0x187C7F360", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long ANBOEKFEJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C78330", Offset = "0x7C76930", VA = "0x187C78330")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? OGPDCFPPNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C7D3E0", Offset = "0x7C7B9E0", VA = "0x187C7D3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool IEDPPGBODIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C73E10", Offset = "0x7C72410", VA = "0x187C73E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> GMDHBIAAJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAB0900", Offset = "0xAAEF00", VA = "0x180AB0900", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> MEBCPDPMGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAB1E80", Offset = "0xAB0480", VA = "0x180AB1E80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> HDNOBIJEPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAC1510", Offset = "0xABFB10", VA = "0x180AC1510", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DCKCBGAGKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAAB880", Offset = "0xAA9E80", VA = "0x180AAB880", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool OLMKHKNNOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB85160", Offset = "0xB83760", VA = "0x180B85160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> NMCEDEGNFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C7BC80", Offset = "0x7C7A280", VA = "0x187C7BC80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C79EC0", Offset = "0x7C784C0", VA = "0x187C79EC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action IFGNHOJLIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C78900", Offset = "0x7C76F00", VA = "0x187C78900", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7C620", Offset = "0x7C7AC20", VA = "0x187C7C620", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ELCIPCDALKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C7B9C0", Offset = "0x7C79FC0", VA = "0x187C7B9C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C77020", Offset = "0x7C75620", VA = "0x187C77020", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F420", Offset = "0x7C7DA20", VA = "0x187C7F420")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LECBEAFJNJC([DJIFKCCBBND(null)][NotNull] OALKBAEBPMC NGBPIDANFJD, [NotNull][DJIFKCCBBND(null)] JJOKNLDHNDC DGGBKPBNENO, [NotNull][DJIFKCCBBND(null)] ACLHKLLKNMH MFIGFFKMKAE, [NotNull][DJIFKCCBBND(null)] EFKGGIOBKBJ KJGIFOBJBII, [DJIFKCCBBND(null)][NotNull] KLKLDJKIJAI IHLJLJKADLH, [DJIFKCCBBND(null)][NotNull] GHEABDPEEMJ BFCIGLOEMAP, [DJIFKCCBBND(null)][NotNull] HBLAEJNBENG DLDECNJKBCP, [NotNull][DJIFKCCBBND(null)] MBAMAOLNFEE MHAEOAHGKDE, [NotNull][DJIFKCCBBND(null)] LDMAAALPMPJ NODDAHEDIAD, [NotNull][DJIFKCCBBND(null)] CNKBCNLGABK PAOEKOPNKAL, [NotNull][DJIFKCCBBND(null)] HLICHGGPCCA IMGLEKANDJE, [NotNull][DJIFKCCBBND(null)] JEPLPAAEIMH AFBAPDBEIOD, [NotNull][DJIFKCCBBND(null)] HEAKNPJEKDG LAIFMBJMEGH, [NotNull][DJIFKCCBBND(null)] LDBCIIKLAGJ EKPGCGJEGDB, [DJIFKCCBBND(null)][NotNull] HGPCKPIAKLB HCKHHIJHPNM, [DJIFKCCBBND(null)][NotNull] CFFBBPKENGE KMMCBALEKPA, [NotNull][DJIFKCCBBND(null)] ABHKBFFIJLO KPKDGGHCPAF, [DJIFKCCBBND(null)][NotNull] ILKBOCNMCLO<KeepsakesConfig.KeepsakesOptions> BFEGEHMOFBB, [NotNull][DJIFKCCBBND(null)] JAHOCBPGMLL AJHJEIPEGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A570", Offset = "0x7C78B70", VA = "0x187C7A570", Slot = "15")]
	public bool IBBMGDLHIDE(List<string> DOMAEGHOIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C75110", Offset = "0x7C73710", VA = "0x187C75110", Slot = "16")]
	public KGAPFDAFEHM<Guid> CBBAGMCFADN(AFACIFHCNFE HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E6C0", Offset = "0x7C7CCC0", VA = "0x187C7E6C0", Slot = "17")]
	public HPIGCMLNLFB OOKKLLFFHHB(Guid JMMICACHJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C76040", Offset = "0x7C74640", VA = "0x187C76040", Slot = "18")]
	public HPIGCMLNLFB DGIEHHIBNHN(Guid JMMICACHJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BB20", Offset = "0x7C7A120", VA = "0x187C7BB20", Slot = "19")]
	public bool KCIHHGPDIPG(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C78400", Offset = "0x7C76A00", VA = "0x187C78400", Slot = "20")]
	public bool FJCHHOLFEHN(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C75ED0", Offset = "0x7C744D0", VA = "0x187C75ED0")]
	public KeepsakeTheme CLALKOJNLOL(Guid JMMICACHJNH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C78720", Offset = "0x7C76D20", VA = "0x187C78720")]
	public bool FNMGFNIGAHH(AFACIFHCNFE HCKJHIJFJHB, [Out] KeepsakeTheme LCKKGMFHCLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C77E00", Offset = "0x7C76400", VA = "0x187C77E00")]
	public List<KeepsakeTheme> FBHHOIFPJCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C781B0", Offset = "0x7C767B0", VA = "0x187C781B0")]
	public int FELGBNANGCJ(AFACIFHCNFE HCKJHIJFJHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C73CB0", Offset = "0x7C722B0", VA = "0x187C73CB0")]
	public AFACIFHCNFE BMKMJNPJIMJ(Guid JMMICACHJNH)
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C73B10", Offset = "0x7C72110", VA = "0x187C73B10", Slot = "34")]
	public List<AFACIFHCNFE> BKBPFKAAOAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DF30", Offset = "0x7C7C530", VA = "0x187C7DF30", Slot = "35")]
	public IComparer<AFACIFHCNFE> OBOIJEABHLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C76450", Offset = "0x7C74A50", VA = "0x187C76450", Slot = "32")]
	public string DMMHNIIOGNE(AFACIFHCNFE HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D570", Offset = "0x7C7BB70", VA = "0x187C7D570", Slot = "33")]
	public string MBNPJOJFEFL(AFACIFHCNFE HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C79410", Offset = "0x7C77A10", VA = "0x187C79410", Slot = "21")]
	public bool HFMHJOKKBNO(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C560", Offset = "0x7C7AB60", VA = "0x187C7C560", Slot = "22")]
	public void KOOENPJKLND(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C5D0", Offset = "0x7C7ABD0", VA = "0x187C7C5D0", Slot = "23")]
	public void LABPHLPNBGM(AFACIFHCNFE HCKJHIJFJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DCF0", Offset = "0x7C7C2F0", VA = "0x187C7DCF0", Slot = "24")]
	public void OAKGNPCBDEL(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B2C0", Offset = "0x7C798C0", VA = "0x187C7B2C0", Slot = "25")]
	public int JJAMMPPCNIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C74D60", Offset = "0x7C73360", VA = "0x187C74D60", Slot = "31")]
	public KGAPFDAFEHM<IEnumerable<Guid>> CAMDHOLMIIO(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C78580", Offset = "0x7C76B80", VA = "0x187C78580", Slot = "30")]
	public KGAPFDAFEHM<IEnumerable<Guid>> FNJDKOMMEDN(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C730F0", Offset = "0x7C716F0", VA = "0x187C730F0", Slot = "54")]
	public KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> AONNEBOCJBF(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C180", Offset = "0x7C7A780", VA = "0x187C7C180", Slot = "55")]
	public KGAPFDAFEHM<Dictionary<Guid, AFACIFHCNFE>> KJAJJFFHEEN(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C79F70", Offset = "0x7C78570", VA = "0x187C79F70", Slot = "26")]
	public KGAPFDAFEHM<int> HMOOFKNMDEG(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C78FD0", Offset = "0x7C775D0", VA = "0x187C78FD0", Slot = "27")]
	public KGAPFDAFEHM<int> GIKBMDOIEBH(long CINEDGEJAIA, long FMIBHJAGMML, AFACIFHCNFE? HCKJHIJFJHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C789A0", Offset = "0x7C76FA0", VA = "0x187C789A0", Slot = "28")]
	public KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> GAKLEELILCF(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C440", Offset = "0x7C7AA40", VA = "0x187C7C440", Slot = "29")]
	public KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> KNAPILKEBKG(long CINEDGEJAIA, long FMIBHJAGMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D930", Offset = "0x7C7BF30", VA = "0x187C7D930", Slot = "37")]
	public bool MPKOKCOBPGN(long CINEDGEJAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C500", Offset = "0x7C7AB00", VA = "0x187C7C500", Slot = "56")]
	public bool KNEOGKOKCGB(long CINEDGEJAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C0E0", Offset = "0x7C7A6E0", VA = "0x187C7C0E0", Slot = "38")]
	public bool KIDMMMNJBKG(long CINEDGEJAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AF10", Offset = "0x7C79510", VA = "0x187C7AF10", Slot = "57")]
	public bool JAOHPBAKFDJ(long CINEDGEJAIA, [Out] HBIEODGBPJP JKGMBBJKHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E310", Offset = "0x7C7C910", VA = "0x187C7E310", Slot = "39")]
	public bool OHDLCKOLKLK(long LEFNFFBHJLH, [Out] DateTime PCOPOHCFOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C75990", Offset = "0x7C73F90", VA = "0x187C75990", Slot = "40")]
	public long CIPNDKFOHMO(long LEFNFFBHJLH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C310", Offset = "0x7C7A910", VA = "0x187C7C310", Slot = "41")]
	public long KLJDKKKJPMN(long CINEDGEJAIA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AD30", Offset = "0x7C79330", VA = "0x187C7AD30", Slot = "42")]
	public int IMLPCICOANG(long LEFNFFBHJLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C77D20", Offset = "0x7C76320", VA = "0x187C77D20", Slot = "43")]
	public bool EJLAOEGCPAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C79B60", Offset = "0x7C78160", VA = "0x187C79B60", Slot = "44")]
	public bool HICOLJJMCJD(long LEFNFFBHJLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E450", Offset = "0x7C7CA50", VA = "0x187C7E450", Slot = "45")]
	public IReadOnlyList<long> OJDGLONCKHN(long LEFNFFBHJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CFE0", Offset = "0x7C7B5E0", VA = "0x187C7CFE0", Slot = "46")]
	public int LFOFCFKLNCI(long LEFNFFBHJLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C72AF0", Offset = "0x7C710F0", VA = "0x187C72AF0", Slot = "50")]
	public long AAEOKOGAAMB(long NBJFEGFELAB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A210", Offset = "0x7C78810", VA = "0x187C7A210", Slot = "51")]
	public AFACIFHCNFE HNNDJMBLIDL()
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D200", Offset = "0x7C7B800", VA = "0x187C7D200")]
	private bool LHIHCECELPM(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C796A0", Offset = "0x7C77CA0", VA = "0x187C796A0")]
	private void HHHFMILOEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C73840", Offset = "0x7C71E40", VA = "0x187C73840")]
	private AFACIFHCNFE BJEHNKDMJCN()
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C776E0", Offset = "0x7C75CE0", VA = "0x187C776E0")]
	private void EHLNELGCGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C72F50", Offset = "0x7C71550", VA = "0x187C72F50")]
	private int AKPKFJAHCCA(KeepsakeRoomListDTO NPCFGEHHIHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E210", Offset = "0x7C7C810", VA = "0x187C7E210")]
	private int OGHAPHFOGDF(DateTime LONKALAOHFJ, DateTime DNKHHGLMKIP, TimeSpan FNAMPKBJNAA, int IIAMKMGPMAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B740", Offset = "0x7C79D40", VA = "0x187C7B740")]
	private void JPMNGOLIBIC(IEnumerable<KeepsakeInstanceDTO> AGJEJPPAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D6F0", Offset = "0x7C7BCF0", VA = "0x187C7D6F0")]
	private void MIBKFFEGJFK(IEnumerable<KeepsakeCollectionRecordDTO> MEBNFOKBONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C763F0", Offset = "0x7C749F0", VA = "0x187C763F0")]
	private void DHONBNNDJIP(IEnumerable<long> NHDFHNMBLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xACA6B0", Offset = "0xAC8CB0", VA = "0x180ACA6B0")]
	private void EJPGFIJBOCF(KeepsakeGlobalConfigDTO NHIBEEAMDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F100", Offset = "0x7C7D700", VA = "0x187C7F100")]
	private bool PKOKONDNNFC(AFACIFHCNFE HCKJHIJFJHB, [Out] Guid KOPMOEEACCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C75720", Offset = "0x7C73D20", VA = "0x187C75720")]
	private bool CBOCPBLDFOE([Out] Guid KOPMOEEACCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B6E0", Offset = "0x7C79CE0", VA = "0x187C7B6E0")]
	private bool JPMEEFDFHLN(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C78430", Offset = "0x7C76A30", VA = "0x187C78430")]
	private IEnumerable<Guid> FNCEPDACNEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BA60", Offset = "0x7C7A060", VA = "0x187C7BA60")]
	private IEnumerable<KeepsakeInstanceDTO> KCFIAEOCENM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C765D0", Offset = "0x7C74BD0", VA = "0x187C765D0")]
	private void DOIPNBPPLNB(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D330", Offset = "0x7C7B930", VA = "0x187C7D330")]
	private bool LJGJLGNIHMA(Guid JMMICACHJNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D990", Offset = "0x7C7BF90", VA = "0x187C7D990")]
	private void NBBBIDLBDMB(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A9E0", Offset = "0x7C78FE0", VA = "0x187C7A9E0")]
	private void IJMMHKBEHNP(AFACIFHCNFE BMEHNMPPGJP, int MKEAIFEPEDJ, Dictionary<AFACIFHCNFE, int> EBHOGNIHHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E010", Offset = "0x7C7C610", VA = "0x187C7E010")]
	private int ODAGAINEPLA(AFACIFHCNFE HCKJHIJFJHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C79CF0", Offset = "0x7C782F0", VA = "0x187C79CF0")]
	private void HJALLKIOCCI(KeepsakeInstanceDTO LFNFMCBMANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C734A0", Offset = "0x7C71AA0", VA = "0x187C734A0")]
	private void BABLDOGDDHI(KeepsakeInstanceDTO LFNFMCBMANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E940", Offset = "0x7C7CF40", VA = "0x187C7E940")]
	private void PDDHONKBENF(Guid JMMICACHJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C76010", Offset = "0x7C74610", VA = "0x187C76010")]
	private void FCDKBNJEABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C72F30", Offset = "0x7C71530", VA = "0x187C72F30")]
	private void AHJLCDDEEKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C74CF0", Offset = "0x7C732F0", VA = "0x187C74CF0")]
	private void BONLKPHLNPB(OGDCDNJBIFG JJJFPCEDAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C76010", Offset = "0x7C74610", VA = "0x187C76010")]
	private void MGMLBGHJCFJ(NPAEHGHLPDF BOMDCGFKGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C76010", Offset = "0x7C74610", VA = "0x187C76010")]
	private void DCLCIADAFJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C76C80", Offset = "0x7C75280", VA = "0x187C76C80")]
	private void EDOMDFCNJEL(float ECBHLBONMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7C77140", Offset = "0x7C75740", VA = "0x187C77140")]
	private void EHLEELDJNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C6C0", Offset = "0x7C7ACC0", VA = "0x187C7C6C0")]
	private bool LAMIKCLPMJD(Guid JMMICACHJNH, [Out] string JODDHBMOGLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C757C0", Offset = "0x7C73DC0", VA = "0x187C757C0")]
	private bool CEEGINGHOCJ(Guid JMMICACHJNH, [Out] KeepsakeCategoryConfigDTO BMEHNMPPGJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AAC0", Offset = "0x7C790C0", VA = "0x187C7AAC0")]
	private void IKDEBNCKKDN(string HKOKFJFBOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A8D0", Offset = "0x7C78ED0", VA = "0x187C7A8D0")]
	private bool IIFHKIFKKHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ED10", Offset = "0x7C7D310", VA = "0x187C7ED10")]
	private List<long> PGMLLHGIACD(IEnumerable<KeepsakeRoomDTO> EDKLNJCHBGM, IReadOnlyList<KeepsakeRoomListDTO> OGKLOLLJFHF, long LEFNFFBHJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C8C0", Offset = "0x7C7AEC0", VA = "0x187C7C8C0")]
	private bool LBGHCBMHNGB(Guid JMMICACHJNH, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7EFD0", Offset = "0x7C7D5D0", VA = "0x187C7EFD0", Slot = "47")]
	public string PJOLPNLHCHD(KFHGHFECODO EFDNENPKLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C78BB0", Offset = "0x7C771B0", VA = "0x187C78BB0", Slot = "49")]
	public string GBJCBBBHNEI(KFHGHFECODO EFDNENPKLBL, long CINEDGEJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A800", Offset = "0x7C78E00", VA = "0x187C7A800", Slot = "48")]
	public string IBNONOAANNC(KFHGHFECODO EFDNENPKLBL, int BBHCPOJFPGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C73E20", Offset = "0x7C72420", VA = "0x187C73E20")]
	private void BNENMMOEDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ABA0", Offset = "0x7C791A0", VA = "0x187C7ABA0")]
	private void IKOAHNKOALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C763D0", Offset = "0x7C749D0", VA = "0x187C763D0")]
	private KFHGHFECODO DGKJABNMJCF(MCEBFBBCOHL COMHFDPJFFN)
	{
		return default(KFHGHFECODO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CDE0", Offset = "0x7C7B3E0", VA = "0x187C7CDE0")]
	private KFHGHFECODO LCBPNJADCOJ(MCEBFBBCOHL COMHFDPJFFN)
	{
		return default(KFHGHFECODO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C7CE00", Offset = "0x7C7B400", VA = "0x187C7CE00")]
	internal static string LCJOIIFOHEH(BHMEEJACIIA CGKDHHEHGIL, string PBKDFEGIFHB, bool PCLIHCFJJKH, int KHOCALLPCNJ, int HCECBCJAPKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C76820", Offset = "0x7C74E20", VA = "0x187C76820", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C770C0", Offset = "0x7C756C0", VA = "0x187C770C0")]
	private GGIHIJCCBHJ EHBANKHCLAC(AIPAHMNCJKP DODIIHCCFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DB30", Offset = "0x7C7C130", VA = "0x187C7DB30")]
	private LFLPPHCMPGO NDHMFNIHOFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C7BD30", Offset = "0x7C7A330", VA = "0x187C7BD30")]
	private Task KGNODACOBFF(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E100", Offset = "0x7C7C700", VA = "0x187C7E100")]
	[AsyncStateMachine(typeof(ONNGBHANMAL))]
	private Task ODJJBDEMKIJ(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C7F030", Offset = "0x7C7D630", VA = "0x187C7F030")]
	private Task PJPGPFGLAKM(JOEFAEBJKIB ODJGLJIHJOP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C79120", Offset = "0x7C77720", VA = "0x187C79120")]
	[AsyncStateMachine(typeof(MJKIECGFLOE))]
	private Task HADAPDODJED(string NAAMEAFIHJI, TimeSpan LLLNDHJJMGP, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7DFF0", Offset = "0x7C7C5F0", VA = "0x187C7DFF0")]
	[CompilerGenerated]
	private void OCPCDFIADOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C72DB0", Offset = "0x7C713B0", VA = "0x187C72DB0")]
	[CompilerGenerated]
	private void AGDKIKBOJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D470", Offset = "0x7C7BA70", VA = "0x187C7D470")]
	[CompilerGenerated]
	private bool LMKGGMOPOIP(KeepsakeInstanceDTO CEJAAIDLEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7D090", Offset = "0x7C7B690", VA = "0x187C7D090")]
	[CompilerGenerated]
	private KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> LGLBDMBDOMI(Dictionary<Guid, AFACIFHCNFE> FKKOHBOMLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C79250", Offset = "0x7C77850", VA = "0x187C79250")]
	[CompilerGenerated]
	private KGAPFDAFEHM<Dictionary<AFACIFHCNFE, int>> HAEMMKKJKAI(Dictionary<Guid, AFACIFHCNFE> FKKOHBOMLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7C420", Offset = "0x7C7AA20", VA = "0x187C7C420")]
	[CompilerGenerated]
	private bool KMLEOFOIDMB(KeepsakeRoomListDTO CEJAAIDLEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C72E00", Offset = "0x7C71400", VA = "0x187C72E00")]
	[CompilerGenerated]
	private bool AGFNFLEHBHK(KeepsakeInstanceDTO CEJAAIDLEPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C736B0", Offset = "0x7C71CB0", VA = "0x187C736B0")]
	[CompilerGenerated]
	private void BHHBKJGCHDM(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<AFACIFHCNFE, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> NOMCIBPFMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C73C50", Offset = "0x7C72250", VA = "0x187C73C50")]
	[CompilerGenerated]
	private void BKKPIHBHOJL(string JHEMEKBLBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C76660", Offset = "0x7C74C60", VA = "0x187C76660")]
	[CompilerGenerated]
	private Task DPLAOEKDFEP(CancellationToken LOJEONOEAMK)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, ILKBOCNMCLO<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class OAOFGLHKCDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
				public OAOFGLHKCDN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x7C80DA0", Offset = "0x7C7F3A0", VA = "0x187C80DA0")]
				internal bool OECNGOEJMLE(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x7C80DA0", Offset = "0x7C7F3A0", VA = "0x187C80DA0")]
				internal bool POFNPAPMAME(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7C728C0", Offset = "0x7C70EC0", VA = "0x187C728C0")]
			public bool EGEJLKHFEAJ(string PDOFEIFJPIC, [Out] KeepsakeTheme LCKKGMFHCLN)
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
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C72840", Offset = "0x7C70E40", VA = "0x187C72840")]
		[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
		internal static void JPEDEHNINOC(AINJBKKEAIL NELIKBMJKPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xBBABA0", Offset = "0xBB91A0", VA = "0x180BBABA0")]
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

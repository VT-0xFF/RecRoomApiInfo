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
		[Cpp2IlInjected.Address(RVA = "0x7648540", Offset = "0x7647740", VA = "0x187648540", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HGDFNPHPCLP : IComparer<AJMLMFADNCB>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class CDNOIDNCADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AJMLMFADNCB x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public AJMLMFADNCB y;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CDNOIDNCADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBEDC50", Offset = "0xBECE50", VA = "0x180BEDC50")]
		internal bool CAILIIAHFNE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CADE00", Offset = "0x1CAD000", VA = "0x181CADE00")]
		internal bool GOEIAGAEAAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBEDC50", Offset = "0xBECE50", VA = "0x180BEDC50")]
		internal bool MNBCBFFNGDH(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CADE00", Offset = "0x1CAD000", VA = "0x181CADE00")]
		internal bool GIAKPAJANNJ(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<KeepsakeCategoryThemePair> OLKOFLKCMGI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x970550", Offset = "0x96F750", VA = "0x180970550")]
	public HGDFNPHPCLP(List<KeepsakeCategoryThemePair> KOLGAJCNLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x76387F0", Offset = "0x76379F0", VA = "0x1876387F0", Slot = "4")]
	public int Compare(AJMLMFADNCB NNDJDIFFAID, AJMLMFADNCB AMFIBFNKFFJ)
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
		public AJMLMFADNCB KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ALDPDJHMICB]
public class NIGDLHPOPBG : OBODNDLNOCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JPDHKMAHPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NIGDLHPOPBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AJMLMFADNCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JPDHKMAHPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7638C10", Offset = "0x7637E10", VA = "0x187638C10")]
		internal JBBNLHPJHLB<Guid> EHOGIOEFDCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7638D70", Offset = "0x7637F70", VA = "0x187638D70")]
		internal void LHBCHDECAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7638DA0", Offset = "0x7637FA0", VA = "0x187638DA0")]
		internal void LHMMJDJPDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7638E00", Offset = "0x7638000", VA = "0x187638E00")]
		internal void OAAGNJPFIAG(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7638BE0", Offset = "0x7637DE0", VA = "0x187638BE0")]
		internal void CNCMGCIOBLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LEGAFPCNLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NIGDLHPOPBG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LEGAFPCNLLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76397B0", Offset = "0x76389B0", VA = "0x1876397B0")]
		internal void LOCINLBOAAH(LODGHBBBPAC response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7639750", Offset = "0x7638950", VA = "0x187639750")]
		internal void AGJBFDMFNAE(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LKLKBFLBBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public LKLKBFLBBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7639B60", Offset = "0x7638D60", VA = "0x187639B60")]
		internal bool OMGMMOLDBLB(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DDKHCJLKJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NIGDLHPOPBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AJMLMFADNCB? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DDKHCJLKJID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7638160", Offset = "0x7637360", VA = "0x187638160")]
		internal void OMGPGBBNFIH(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7638130", Offset = "0x7637330", VA = "0x187638130")]
		internal void NFJBPDMBIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7637E30", Offset = "0x7637030", VA = "0x187637E30")]
		internal JBBNLHPJHLB<IEnumerable<Guid>> KDOHIEGKIFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71C75A0", Offset = "0x71C67A0", VA = "0x1871C75A0")]
		internal bool CDKEFLOIJEF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MJPDOMLKKFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DDKHCJLKJID CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MJPDOMLKKFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7639D10", Offset = "0x7638F10", VA = "0x187639D10")]
		internal JBBNLHPJHLB<IEnumerable<Guid>> CPOPCMGCNOC(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DOAAGHHIBNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public MJPDOMLKKFC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DOAAGHHIBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x76381F0", Offset = "0x76373F0", VA = "0x1876381F0")]
		internal bool JKMJJGKPHNJ(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class AHJKNMIEMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DOAAGHHIBNF CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AHJKNMIEMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7637300", Offset = "0x7636500", VA = "0x187637300")]
		internal bool BFCEKICDDEM(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MDOIJPDDDNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NIGDLHPOPBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MDOIJPDDDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7639B80", Offset = "0x7638D80", VA = "0x187639B80")]
		internal JBBNLHPJHLB<IEnumerable<Guid>> EJCKMGIOAFM(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7639CF0", Offset = "0x7638EF0", VA = "0x187639CF0")]
		internal bool KCNENJKABKF(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class EFEHDJGPGAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NIGDLHPOPBG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EFEHDJGPGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7638470", Offset = "0x7637670", VA = "0x187638470")]
		internal void DBIPDDMDBHO(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7638130", Offset = "0x7637330", VA = "0x187638130")]
		internal void JCIINDJNLJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7638500", Offset = "0x7637700", VA = "0x187638500")]
		internal JBBNLHPJHLB<Dictionary<Guid, AJMLMFADNCB>> DCJEAOLCKNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x71C75A0", Offset = "0x71C67A0", VA = "0x1871C75A0")]
		internal bool AOMDIEJFDIG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class ABKJHMEPHON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ABKJHMEPHON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7637150", Offset = "0x7636350", VA = "0x187637150")]
		internal JBBNLHPJHLB<Dictionary<Guid, AJMLMFADNCB>> FAPCEMGABIF(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class AIKLENGHKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AIKLENGHKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x76376D0", Offset = "0x76368D0", VA = "0x1876376D0")]
		internal bool CEINJCIFFGG(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7637580", Offset = "0x7636780", VA = "0x187637580")]
		internal KeyValuePair<Guid, AJMLMFADNCB> CDGFJIGBKOG(Guid instanceId)
		{
			return default(KeyValuePair<Guid, AJMLMFADNCB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PFKLPEILCCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PFKLPEILCCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x22B3C30", Offset = "0x22B2E30", VA = "0x1822B3C30")]
		internal bool AKFCJGDGKEF(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KPKMKKFCDJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KPKMKKFCDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x22B3C30", Offset = "0x22B2E30", VA = "0x1822B3C30")]
		internal bool EGEKAJJEMFN(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class OAFACKFKENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NIGDLHPOPBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public OAFACKFKENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7647E70", Offset = "0x7647070", VA = "0x187647E70")]
		internal JBBNLHPJHLB<Dictionary<Guid, AJMLMFADNCB>> OCMKPKCIPPI(Dictionary<Guid, AJMLMFADNCB> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7639CF0", Offset = "0x7638EF0", VA = "0x187639CF0")]
		internal bool POALPNABCJG(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PGIEKCBBIAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PGIEKCBBIAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7648070", Offset = "0x7647270", VA = "0x187648070")]
		internal bool NOPDCPIFDFF(KeyValuePair<Guid, AJMLMFADNCB> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class EFDCKFAGJFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public Dictionary<Guid, AJMLMFADNCB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EFDCKFAGJFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7638320", Offset = "0x7637520", VA = "0x187638320")]
		internal KeyValuePair<AJMLMFADNCB, int> BHEDOPCPIEJ(AJMLMFADNCB category)
		{
			return default(KeyValuePair<AJMLMFADNCB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OELIIFPJCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AJMLMFADNCB category;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public OELIIFPJCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xCF1E20", Offset = "0xCF1020", VA = "0x180CF1E20")]
		internal bool MGMLOLPMNND(AJMLMFADNCB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class PPBENEGAKPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Dictionary<Guid, AJMLMFADNCB> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PPBENEGAKPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x76481E0", Offset = "0x76473E0", VA = "0x1876481E0")]
		internal KeyValuePair<AJMLMFADNCB, int> CIOLCCAMAOA(AJMLMFADNCB category)
		{
			return default(KeyValuePair<AJMLMFADNCB, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class MJLKHFBHPBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AJMLMFADNCB category;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public MJLKHFBHPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xCF1E20", Offset = "0xCF1020", VA = "0x180CF1E20")]
		internal bool KJDFPEKDEJN(AJMLMFADNCB instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class AIGFIAHMAGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NIGDLHPOPBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AIGFIAHMAGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7637490", Offset = "0x7636690", VA = "0x187637490")]
		internal bool NFALKGMPAIA(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x76373B0", Offset = "0x76365B0", VA = "0x1876373B0")]
		internal bool GONBAFJANGA(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7637470", Offset = "0x7636670", VA = "0x187637470")]
		internal bool NKONNJOFGHN(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7637470", Offset = "0x7636670", VA = "0x187637470")]
		internal bool LNDCFIAGLPK(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NDHHKNCLLIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NDHHKNCLLIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD632F0", Offset = "0xD624F0", VA = "0x180D632F0")]
		internal bool CBBENPABNBI(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NGBILCKPNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NGBILCKPNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7639E50", Offset = "0x7639050", VA = "0x187639E50")]
		internal bool HBBIACKGMBL(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2276BC0", Offset = "0x2275DC0", VA = "0x182276BC0")]
		internal bool MEOHJCPLMNI(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IBJKOFKAJLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IBJKOFKAJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7638B80", Offset = "0x7637D80", VA = "0x187638B80")]
		internal bool FNOODKOHLPG(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class BJCPBBNDLMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BJCPBBNDLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xD632F0", Offset = "0xD624F0", VA = "0x180D632F0")]
		internal bool HPDBFCJNFLM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NLBJKLBFJIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NLBJKLBFJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7647E10", Offset = "0x7647010", VA = "0x187647E10")]
		internal bool MONHNDKCOLA(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GDGAHGDFKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AJMLMFADNCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public GDGAHGDFKND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1EB5690", Offset = "0x1EB4890", VA = "0x181EB5690")]
		internal bool GFGPFMPGHEK(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HHJNPOOJBGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HHJNPOOJBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7638AA0", Offset = "0x7637CA0", VA = "0x187638AA0")]
		internal bool LFEKHMEGBCK(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AKFLBMEKGOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AJMLMFADNCB keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AKFLBMEKGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x76377B0", Offset = "0x76369B0", VA = "0x1876377B0")]
		internal bool ICELDHMHABA(KeyValuePair<Guid, AJMLMFADNCB> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DBAFLLGHAJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AJMLMFADNCB newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DBAFLLGHAJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1EB5690", Offset = "0x1EB4890", VA = "0x181EB5690")]
		internal bool CJBGLHGJKML(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class IANLAIMODLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IANLAIMODLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7638B00", Offset = "0x7637D00", VA = "0x187638B00")]
		internal bool IANDGOBGJCP(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class PILDHNECIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public IReadOnlyList<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PILDHNECIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x76480F0", Offset = "0x76472F0", VA = "0x1876480F0")]
		internal bool POAGCDBKMKH(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class DBKJLCIBFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public PILDHNECIDL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DBKJLCIBFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7637DB0", Offset = "0x7636FB0", VA = "0x187637DB0")]
		internal bool IPIACAGAFPE(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct CLNPEOGFMDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NIGDLHPOPBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public JCDLFPMDPEJ args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7637820", Offset = "0x7636A20", VA = "0x187637820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7637D50", Offset = "0x7636F50", VA = "0x187637D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct LAIEACNDPHC : IAsyncStateMachine
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
		public NIGDLHPOPBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7639460", Offset = "0x7638660", VA = "0x187639460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x76396F0", Offset = "0x76388F0", VA = "0x1876396F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DateTime MHCHOFLLDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DJMGKIHNICF CLGEHLEDOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NLHGAKGCFGG OIPIECEPBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LHMLLIOMNJH HMHCMNBOAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PHCNIHPGKGC JDOCPLMCAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly EJMGGDFKJAB FAFBKMPEOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly JMBFECEELAG MBBJBKACAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly JIEMHCCKOBO BGBNHCPMMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly APCKJEBLMJJ IMAAHCGDBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HGMGKEGCNHK PEIJNBOJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ELFFMGKJAAD PKMDNKKFJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly PDNFNMJFHKG JJFFGKBPPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly FIDLPHPBEKK GJEICPBEFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DHIOAPMJDOP MLDCKNNNINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KLGMAPJIMDP CIFLIIBKPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IDECIICAEAC GMEPCNOKEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CDCIKMKCJGM<KeepsakesConfig.KeepsakesOptions> ONCKKBCCJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JDFJKMABMDJ PGKELCELKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> DLPBGMJFOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HashSet<Guid> ADHJOHGFBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HashSet<long> AKBLBLCEMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<AJMLMFADNCB, int> LDJCJEOLFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> FJDOMHNGJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IDisposable NNNBBDPKELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Task FOLJDDIMMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JBBNLHPJHLB<Guid> CCKCGBNNJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private long? CNOKIFIBMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private KeepsakeProgressionEventInstancesDTO MOAHOFPFOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JBBNLHPJHLB<KeepsakeProgressionEventInstancesDTO> OIHGFOCKJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IReadOnlyDictionary<AJMLMFADNCB, KeepsakeCategoryConfigDTO> CDAFCNMCIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeGlobalConfigDTO PHOINPFCMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private HashSet<long> ECGKFFNKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HashSet<long> KENDKJLBCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<KeepsakeRoomListDTO> NIDLIHIHPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<KeepsakeRoomListDTO> NMCNCMKGLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<KeepsakeRoomListDTO> NDCPBOMKGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Dictionary<long, string> GPKGIMFCNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Dictionary<long, string> HEJCPMNMJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Dictionary<long, DateTime> NDEFBJOLNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, List<KeepsakeRoomDTO>> NEBFOEMJPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, List<KeepsakeRoomDTO>> LNMBDKOAKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, long> LNKNOHLKMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly List<string> NGCMGFGIAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private DateTime KMFFKBIDEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IDisposable GPOBFFCIIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Dictionary<Guid, AJMLMFADNCB> KADPFAMFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Dictionary<AJMLMFADNCB, int> OCFGEAMOJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<KeepsakeCategoryThemePair> KOLGAJCNLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private HGDFNPHPCLP BJLBMKNKAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool BAFPOLNKKJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GGNOABDKPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x990150", Offset = "0x98F350", VA = "0x180990150", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x98FED0", Offset = "0x98F0D0", VA = "0x18098FED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BMJFFFCCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7641EC0", Offset = "0x76410C0", VA = "0x187641EC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JEMGHDOAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7640B20", Offset = "0x763FD20", VA = "0x187640B20", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private long HMBHFGOLFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7644920", Offset = "0x7643B20", VA = "0x187644920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long? EEAGIENMHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7644890", Offset = "0x7643A90", VA = "0x187644890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool GIDLNOICJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x76402E0", Offset = "0x763F4E0", VA = "0x1876402E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<KeepsakeRoomListDTO> AIMKNEFBBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EE0", Offset = "0x9D90E0", VA = "0x1809D9EE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> EDLNNFPFHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DB040", Offset = "0x9DA240", VA = "0x1809DB040", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> PIJPPGHOMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D9450", Offset = "0x9D8650", VA = "0x1809D9450", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyDictionary<long, string> DMBBJKPPMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9640", Offset = "0x9D8840", VA = "0x1809D9640", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	internal bool PFBOHMILNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA83050", Offset = "0xA82250", VA = "0x180A83050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> PBFLHCLLLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7644C40", Offset = "0x7643E40", VA = "0x187644C40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76433E0", Offset = "0x76425E0", VA = "0x1876433E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action CKLJCKLDAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7645FE0", Offset = "0x76451E0", VA = "0x187645FE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7640F10", Offset = "0x7640110", VA = "0x187640F10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MKLNPPCBLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x763B460", Offset = "0x763A660", VA = "0x18763B460", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7644720", Offset = "0x7643920", VA = "0x187644720", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7646840", Offset = "0x7645A40", VA = "0x187646840")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NIGDLHPOPBG([KMMHIEIDBEA(null)][NotNull] DJMGKIHNICF CLGEHLEDOKA, [NotNull][KMMHIEIDBEA(null)] LKJLIEKKDMF NCPDCFOBKPB, [NotNull][KMMHIEIDBEA(null)] NLHGAKGCFGG OIPIECEPBIA, [NotNull][KMMHIEIDBEA(null)] LHMLLIOMNJH HMHCMNBOAFM, [KMMHIEIDBEA(null)][NotNull] PHCNIHPGKGC JDOCPLMCAEF, [KMMHIEIDBEA(null)][NotNull] EJMGGDFKJAB FAFBKMPEOID, [KMMHIEIDBEA(null)][NotNull] JMBFECEELAG MBBJBKACAPD, [NotNull][KMMHIEIDBEA(null)] JIEMHCCKOBO BGBNHCPMMFB, [NotNull][KMMHIEIDBEA(null)] APCKJEBLMJJ IMAAHCGDBEG, [NotNull][KMMHIEIDBEA(null)] EPPLHJMCMBA EKDOFNGLKCJ, [NotNull][KMMHIEIDBEA(null)] HGMGKEGCNHK PEIJNBOJCOE, [NotNull][KMMHIEIDBEA(null)] ELFFMGKJAAD PKMDNKKFJHD, [NotNull][KMMHIEIDBEA(null)] PDNFNMJFHKG JJFFGKBPPDN, [NotNull][KMMHIEIDBEA(null)] FIDLPHPBEKK GJEICPBEFIC, [KMMHIEIDBEA(null)][NotNull] DHIOAPMJDOP MLDCKNNNINN, [KMMHIEIDBEA(null)][NotNull] KLGMAPJIMDP CIFLIIBKPBO, [NotNull][KMMHIEIDBEA(null)] IDECIICAEAC GMEPCNOKEEA, [KMMHIEIDBEA(null)][NotNull] CDCIKMKCJGM<KeepsakesConfig.KeepsakesOptions> ONCKKBCCJPH, [NotNull][KMMHIEIDBEA(null)] JDFJKMABMDJ PGKELCELKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x763C640", Offset = "0x763B840", VA = "0x18763C640", Slot = "15")]
	public bool DJOPKLLHMAP(List<string> CJJILOLOJDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x763F510", Offset = "0x763E710", VA = "0x18763F510", Slot = "16")]
	public JBBNLHPJHLB<Guid> GBFDLCEEHLJ(AJMLMFADNCB KIFIBMNLIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x763BAF0", Offset = "0x763ACF0", VA = "0x18763BAF0", Slot = "17")]
	public LHBFOPKLGGA CKBOLEEOIOE(Guid MDCODEADBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7645C50", Offset = "0x7644E50", VA = "0x187645C50", Slot = "18")]
	public LHBFOPKLGGA PEPNHAHAAJD(Guid MDCODEADBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x76414E0", Offset = "0x76406E0", VA = "0x1876414E0", Slot = "19")]
	public bool IOGHHJKCFEM(Guid MDCODEADBDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x763ED80", Offset = "0x763DF80", VA = "0x18763ED80", Slot = "20")]
	public bool FBLAADJEKLF(Guid MDCODEADBDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7644020", Offset = "0x7643220", VA = "0x187644020")]
	public KeepsakeTheme NKFDECLIBIO(Guid MDCODEADBDH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76422B0", Offset = "0x76414B0", VA = "0x1876422B0")]
	public bool KPKKJPCGBHL(AJMLMFADNCB KIFIBMNLIML, [Out] KeepsakeTheme CHPEDOOEJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x763B740", Offset = "0x763A940", VA = "0x18763B740")]
	public List<KeepsakeTheme> CJODJDANFEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7641820", Offset = "0x7640A20", VA = "0x187641820")]
	public int JJDNHINJEOF(AJMLMFADNCB KIFIBMNLIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x763B020", Offset = "0x763A220", VA = "0x18763B020")]
	public AJMLMFADNCB BIHIBLGNENG(Guid MDCODEADBDH)
	{
		return default(AJMLMFADNCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76438F0", Offset = "0x7642AF0", VA = "0x1876438F0", Slot = "34")]
	public List<AJMLMFADNCB> NBGOCKOHBPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7641D90", Offset = "0x7640F90", VA = "0x187641D90", Slot = "35")]
	public IComparer<AJMLMFADNCB> KHKFLECLOCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x763E550", Offset = "0x763D750", VA = "0x18763E550", Slot = "32")]
	public string ENHANIAHDIK(AJMLMFADNCB KIFIBMNLIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7643A30", Offset = "0x7642C30", VA = "0x187643A30", Slot = "33")]
	public string NGALPAILJEL(AJMLMFADNCB KIFIBMNLIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x763E6D0", Offset = "0x763D8D0", VA = "0x18763E6D0", Slot = "21")]
	public bool EOPFIMEGOIJ(Guid MDCODEADBDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7641E50", Offset = "0x7641050", VA = "0x187641E50", Slot = "22")]
	public void KIBFMPMJJEJ(Guid MDCODEADBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7640290", Offset = "0x763F490", VA = "0x187640290", Slot = "23")]
	public void GHCDKIDJEFE(AJMLMFADNCB KIFIBMNLIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x763B500", Offset = "0x763A700", VA = "0x18763B500", Slot = "24")]
	public void CECMGBCBBMF(Guid MDCODEADBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x763E960", Offset = "0x763DB60", VA = "0x18763E960", Slot = "25")]
	public int FAKCIBNILIH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76402F0", Offset = "0x763F4F0", VA = "0x1876402F0", Slot = "31")]
	public JBBNLHPJHLB<IEnumerable<Guid>> HAEHEOKFAAH(long KCAAOMDKNIH, long LGDNIKBGCMO, AJMLMFADNCB? KIFIBMNLIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7639F10", Offset = "0x7639110", VA = "0x187639F10", Slot = "30")]
	public JBBNLHPJHLB<IEnumerable<Guid>> ACMGOECLOFB(long KCAAOMDKNIH, long LGDNIKBGCMO, AJMLMFADNCB? KIFIBMNLIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7643C70", Offset = "0x7642E70", VA = "0x187643C70", Slot = "54")]
	public JBBNLHPJHLB<Dictionary<Guid, AJMLMFADNCB>> NJKFFKOLDMG(long KCAAOMDKNIH, long LGDNIKBGCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7640FB0", Offset = "0x76401B0", VA = "0x187640FB0", Slot = "55")]
	public JBBNLHPJHLB<Dictionary<Guid, AJMLMFADNCB>> IHCPMIANFID(long KCAAOMDKNIH, long LGDNIKBGCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76419A0", Offset = "0x7640BA0", VA = "0x1876419A0", Slot = "26")]
	public JBBNLHPJHLB<int> JOFGIHBKECB(long KCAAOMDKNIH, long LGDNIKBGCMO, AJMLMFADNCB? KIFIBMNLIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7641C40", Offset = "0x7640E40", VA = "0x187641C40", Slot = "27")]
	public JBBNLHPJHLB<int> KBNAEPPAGOE(long KCAAOMDKNIH, long LGDNIKBGCMO, AJMLMFADNCB? KIFIBMNLIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x763CF70", Offset = "0x763C170", VA = "0x18763CF70", Slot = "28")]
	public JBBNLHPJHLB<Dictionary<AJMLMFADNCB, int>> DOGKHNJEDJP(long KCAAOMDKNIH, long LGDNIKBGCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x763CEB0", Offset = "0x763C0B0", VA = "0x18763CEB0", Slot = "29")]
	public JBBNLHPJHLB<Dictionary<AJMLMFADNCB, int>> DNCNNHHIPCK(long KCAAOMDKNIH, long LGDNIKBGCMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7643360", Offset = "0x7642560", VA = "0x187643360", Slot = "37")]
	public bool LLELGFJNCIM(long KCAAOMDKNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7642230", Offset = "0x7641430", VA = "0x187642230", Slot = "56")]
	public bool KNJDDPGPDNG(long KCAAOMDKNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x763C290", Offset = "0x763B490", VA = "0x18763C290", Slot = "38")]
	public bool DGJCHGABGGP(long KCAAOMDKNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7646210", Offset = "0x7645410", VA = "0x187646210", Slot = "57")]
	public bool PMOPLPONMDH(long KCAAOMDKNIH, [Out] BBPHFIGNMKA GHHLMMEPDAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7640CF0", Offset = "0x763FEF0", VA = "0x187640CF0", Slot = "39")]
	public bool IDFMOOCEGKA(long HDOAPGAKEOF, [Out] DateTime EGMBAFIGGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7644CF0", Offset = "0x7643EF0", VA = "0x187644CF0", Slot = "40")]
	public long OFMEJMOCCLC(long HDOAPGAKEOF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x763D8B0", Offset = "0x763CAB0", VA = "0x18763D8B0", Slot = "41")]
	public long EAEEKACEKMI(long KCAAOMDKNIH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x763A0E0", Offset = "0x76392E0", VA = "0x18763A0E0", Slot = "42")]
	public int AKBHIEKIMJO(long HDOAPGAKEOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76449F0", Offset = "0x7643BF0", VA = "0x1876449F0", Slot = "43")]
	public bool OAOJNLGHJHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7641350", Offset = "0x7640550", VA = "0x187641350", Slot = "44")]
	public bool IMAFEJBJIIO(long HDOAPGAKEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7640780", Offset = "0x763F980", VA = "0x187640780", Slot = "45")]
	public IReadOnlyList<long> HHHKBINOGMF(long HDOAPGAKEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x763C590", Offset = "0x763B790", VA = "0x18763C590", Slot = "46")]
	public int DJGOAAKDEIF(long HDOAPGAKEOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x763EF20", Offset = "0x763E120", VA = "0x18763EF20", Slot = "50")]
	public long FFHPMBKCHCH(long JFLCAMHINGO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x763A450", Offset = "0x7639650", VA = "0x18763A450", Slot = "51")]
	public AJMLMFADNCB APGCPNBJEFI()
	{
		return default(AJMLMFADNCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76437C0", Offset = "0x76429C0", VA = "0x1876437C0")]
	private bool MMKGODJBFBM(Guid MDCODEADBDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7644160", Offset = "0x7643360", VA = "0x187644160")]
	private void NLFOILAPHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x763D5E0", Offset = "0x763C7E0", VA = "0x18763D5E0")]
	private AJMLMFADNCB EACLLECAOKM()
	{
		return default(AJMLMFADNCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x763DD70", Offset = "0x763CF70", VA = "0x18763DD70")]
	private void EEAHHONIJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x763AAB0", Offset = "0x7639CB0", VA = "0x18763AAB0")]
	private int BFFNMLKFFEO(KeepsakeRoomListDTO PCMLFFIAABC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x763A2C0", Offset = "0x76394C0", VA = "0x18763A2C0")]
	private int AKNKIDLCPMA(DateTime IDGENPBLOKG, DateTime OPPJPNMPGCB, TimeSpan NLOOJCINCBH, int FIPDBDJPHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76465C0", Offset = "0x76457C0", VA = "0x1876465C0")]
	private void PONPPPLPGEH(IEnumerable<KeepsakeInstanceDTO> DLPBGMJFOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x763C350", Offset = "0x763B550", VA = "0x18763C350")]
	private void DIDCHCCIIBC(IEnumerable<KeepsakeCollectionRecordDTO> BDAACPCCGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x763B400", Offset = "0x763A600", VA = "0x18763B400")]
	private void BMDMIIDAGIC(IEnumerable<long> BBOJHPFNIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9D7490", Offset = "0x9D6690", VA = "0x1809D7490")]
	private void GMMNOPMJPCJ(KeepsakeGlobalConfigDTO PHOINPFCMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x763F1E0", Offset = "0x763E3E0", VA = "0x18763F1E0")]
	private bool FGOMDPMBDFD(AJMLMFADNCB KIFIBMNLIML, [Out] Guid AHCOCFDNJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x763EE80", Offset = "0x763E080", VA = "0x18763EE80")]
	private bool FFDGEFPMNHJ([Out] Guid AHCOCFDNJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7641F10", Offset = "0x7641110", VA = "0x187641F10")]
	private bool KKHJPADPDKI(Guid MDCODEADBDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7645B00", Offset = "0x7644D00", VA = "0x187645B00")]
	private IEnumerable<Guid> OMHBLENCHPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7643BB0", Offset = "0x7642DB0", VA = "0x187643BB0")]
	private IEnumerable<KeepsakeInstanceDTO> NHADHONFMKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x763A3C0", Offset = "0x76395C0", VA = "0x18763A3C0")]
	private void APDEFNJLNCM(Guid MDCODEADBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76447C0", Offset = "0x76439C0", VA = "0x1876447C0")]
	private bool NONOHHMKCPJ(Guid MDCODEADBDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x763E3B0", Offset = "0x763D5B0", VA = "0x18763E3B0")]
	private void EHGPLLDCPEM(Guid MDCODEADBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x76406A0", Offset = "0x763F8A0", VA = "0x1876406A0")]
	private void HFHBKOBKGMJ(AJMLMFADNCB KDIPEHDJNCB, int AFOOKCAGKGE, Dictionary<AJMLMFADNCB, int> AIKJICMHNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x763B180", Offset = "0x763A380", VA = "0x18763B180")]
	private int BIIDEJAJKIJ(AJMLMFADNCB KIFIBMNLIML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7645410", Offset = "0x7644610", VA = "0x187645410")]
	private void OMACGOJFNDD(KeepsakeInstanceDTO FIFNGDABMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7641140", Offset = "0x7640340", VA = "0x187641140")]
	private void IKKHABKAFJO(KeepsakeInstanceDTO FIFNGDABMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x763AC50", Offset = "0x7639E50", VA = "0x18763AC50")]
	private void BGDJELPMGDK(Guid MDCODEADBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x763A0B0", Offset = "0x76392B0", VA = "0x18763A0B0")]
	private void AINGNAFJBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7642290", Offset = "0x7641490", VA = "0x187642290")]
	private void KPDCNILFAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x763EDB0", Offset = "0x763DFB0", VA = "0x18763EDB0")]
	private void FBOPEJJANCE(GMLPEAHICBN LBBDJNJENGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x763A0B0", Offset = "0x76392B0", VA = "0x18763A0B0")]
	private void ODGFKECHLKA(JKEAKPJDDED ONELFPFEALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x763A0B0", Offset = "0x76392B0", VA = "0x18763A0B0")]
	private void EDAKLDBAJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x763BD70", Offset = "0x763AF70", VA = "0x18763BD70")]
	private void DCHBGODDMJE(float ALNCKHBPHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x763FB20", Offset = "0x763ED20", VA = "0x18763FB20")]
	private void GEAGJBBMLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x763A830", Offset = "0x7639A30", VA = "0x18763A830")]
	private bool BDEBPPPIDKB(Guid MDCODEADBDH, [Out] string KCKMICEPNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x76400C0", Offset = "0x763F2C0", VA = "0x1876400C0")]
	private bool GFJADBLLHHO(Guid MDCODEADBDH, [Out] KeepsakeCategoryConfigDTO KDIPEHDJNCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7640E30", Offset = "0x7640030", VA = "0x187640E30")]
	private void IEMLBAFGDOP(string ELEFLNJJFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7640BE0", Offset = "0x763FDE0", VA = "0x187640BE0")]
	private bool ICKPAANPKIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7641F70", Offset = "0x7641170", VA = "0x187641F70")]
	private List<long> KMILGEHIKCN(IEnumerable<KeepsakeRoomDTO> MKLCIALFDAH, IReadOnlyList<KeepsakeRoomListDTO> BNILAKPCMLH, long HDOAPGAKEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x76455E0", Offset = "0x76447E0", VA = "0x1876455E0")]
	private bool OMGHEKNAFBD(Guid MDCODEADBDH, [Out] string HHOJHACJLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x763EE20", Offset = "0x763E020", VA = "0x18763EE20", Slot = "47")]
	public string FEDMMPOOGCP(FHEMJPFHCMD MEOBMAECNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x763CA90", Offset = "0x763BC90", VA = "0x18763CA90", Slot = "49")]
	public string DMOFIKBKOEA(FHEMJPFHCMD MEOBMAECNPG, long KCAAOMDKNIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x763F440", Offset = "0x763E640", VA = "0x18763F440", Slot = "48")]
	public string FINFEKCJIJE(FHEMJPFHCMD MEOBMAECNPG, int FBMCAPBCBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7642490", Offset = "0x7641690", VA = "0x187642490")]
	private void LBKEIBNIEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7646080", Offset = "0x7645280", VA = "0x187646080")]
	private void PLMIEJIPHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x76433C0", Offset = "0x76425C0", VA = "0x1876433C0")]
	private FHEMJPFHCMD LMDNILPIHLM(PPAHGJDENEL EOGFBABILGB)
	{
		return default(FHEMJPFHCMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x763C330", Offset = "0x763B530", VA = "0x18763C330")]
	private FHEMJPFHCMD DGJINLLFDGK(PPAHGJDENEL EOGFBABILGB)
	{
		return default(FHEMJPFHCMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7645230", Offset = "0x7644430", VA = "0x187645230")]
	internal static string OHNOJGMLPDF(LODGHBBBPAC IOIAEEJHBDN, string MOPJMIEGNJL, bool ILDCPJIPJCJ, int PIOKLFKOMGP, int FCHHLNNFHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x763D180", Offset = "0x763C380", VA = "0x18763D180", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x763A7B0", Offset = "0x76399B0", VA = "0x18763A7B0")]
	private KLKDBEPMPLI BCOCJLCFODF(GJGNFGDHFCI HLALJHGPAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7643600", Offset = "0x7642800", VA = "0x187643600")]
	private GNEMDIILJJK MLHOIABCNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x763D9C0", Offset = "0x763CBC0", VA = "0x18763D9C0")]
	private Task ECNHMICKPHD(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7641710", Offset = "0x7640910", VA = "0x187641710")]
	[AsyncStateMachine(typeof(CLNPEOGFMDM))]
	private Task JGLFOINOLKA(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7641640", Offset = "0x7640840", VA = "0x187641640")]
	private Task IONILIAGAMN(JCDLFPMDPEJ MEDGLPBHGFL, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x763C160", Offset = "0x763B360", VA = "0x18763C160")]
	[AsyncStateMachine(typeof(LAIEACNDPHC))]
	private Task DENFKAPJMHD(string DCEACFEGBDC, TimeSpan MBKKJPHOLMF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x763AA30", Offset = "0x7639C30", VA = "0x18763AA30")]
	[CompilerGenerated]
	private void BDJAEMAIJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x763C110", Offset = "0x763B310", VA = "0x18763C110")]
	[CompilerGenerated]
	private void DDNGKBLCKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7644620", Offset = "0x7643820", VA = "0x187644620")]
	[CompilerGenerated]
	private bool NNICDIBGKEG(KeepsakeInstanceDTO NNDJDIFFAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7644AD0", Offset = "0x7643CD0", VA = "0x187644AD0")]
	[CompilerGenerated]
	private JBBNLHPJHLB<Dictionary<AJMLMFADNCB, int>> OEFGPAEGOAN(Dictionary<Guid, AJMLMFADNCB> ILKNKILHLCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7643490", Offset = "0x7642690", VA = "0x187643490")]
	[CompilerGenerated]
	private JBBNLHPJHLB<Dictionary<AJMLMFADNCB, int>> MLCKNLKIBBP(Dictionary<Guid, AJMLMFADNCB> ILKNKILHLCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7644870", Offset = "0x7643A70", VA = "0x187644870")]
	[CompilerGenerated]
	private bool NPHEHHACENN(KeepsakeRoomListDTO NNDJDIFFAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x76409F0", Offset = "0x763FBF0", VA = "0x1876409F0")]
	[CompilerGenerated]
	private bool HNNCJKJFPNB(KeepsakeInstanceDTO NNDJDIFFAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x763B270", Offset = "0x763A470", VA = "0x18763B270")]
	[CompilerGenerated]
	private void BJCPOLBIGJD(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<AJMLMFADNCB, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> CHPLKOOFBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x763AA50", Offset = "0x7639C50", VA = "0x18763AA50")]
	[CompilerGenerated]
	private void BDOEIGMDKAC(string HHOJHACJLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x763C8D0", Offset = "0x763BAD0", VA = "0x18763C8D0")]
	[CompilerGenerated]
	private Task DLAFHCJPNGF(CancellationToken MGKBJIMHFDB)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class KeepsakesConfig : ScriptableObject, CDCIKMKCJGM<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			[CompilerGenerated]
			private sealed class CFCPNBHEPJP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
				public CFCPNBHEPJP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0x76377F0", Offset = "0x76369F0", VA = "0x1876377F0")]
				internal bool JAFHONMNJIM(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x76377F0", Offset = "0x76369F0", VA = "0x1876377F0")]
				internal bool IHCHMJJMCCL(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7639290", Offset = "0x7638490", VA = "0x187639290")]
			public bool GGHKOOMJAKJ(string DIALJKCJKLG, [Out] KeepsakeTheme CHPEDOOEJMM)
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7639210", Offset = "0x7638410", VA = "0x187639210")]
		[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
		internal static void JHDFHEGIBHJ(ANOENEDKKHA GFOILLNHEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
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

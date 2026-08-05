using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecNet;
using RecRoom.Keepsakes;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class KeepsakesConfig : ScriptableObject, LJPKNAJPJMB<KeepsakesConfig.KeepsakesOptions>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class KeepsakesOptions
		{
			[Cpp2IlInjected.Token(Token = "0x2000004")]
			[CompilerGenerated]
			private sealed class GHOMILENCHP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public string themeId;

				[Cpp2IlInjected.Token(Token = "0x6000005")]
				[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
				public GHOMILENCHP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000006")]
				[Cpp2IlInjected.Address(RVA = "0x583BC00", Offset = "0x583B000", VA = "0x18583BC00")]
				internal bool EOCAABIJLJD(KeepsakeTheme x)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000007")]
				[Cpp2IlInjected.Address(RVA = "0x583BC00", Offset = "0x583B000", VA = "0x18583BC00")]
				internal bool NNMMJLKBABH(KeepsakeTheme x)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000002")]
			[SerializeField]
			private KeepsakeTheme[] themes;

			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x583D2A0", Offset = "0x583C6A0", VA = "0x18583D2A0")]
			public bool OICJNFKMKBN(string AIMIEGFIDMA, out KeepsakeTheme FPKJLNHNBND)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private KeepsakesOptions options;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KeepsakesOptions Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x583D220", Offset = "0x583C620", VA = "0x18583D220")]
		[PGKDFPMEDOJ(CDFBKAGHDGH.GameOnly)]
		private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
		public KeepsakesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KHEACAPBLIH : IComparer<GMHDHODCNMC>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class AEIKCDJOFNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public GMHDHODCNMC x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public GMHDHODCNMC y;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public AEIKCDJOFNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B9270", Offset = "0x9B8670", VA = "0x1809B9270")]
		internal bool CNHDEMBDOIE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x181A8A0", Offset = "0x1819CA0", VA = "0x18181A8A0")]
		internal bool JFEALBLCDAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9B9270", Offset = "0x9B8670", VA = "0x1809B9270")]
		internal bool PLAPJPNDONE(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x181A8A0", Offset = "0x1819CA0", VA = "0x18181A8A0")]
		internal bool HNMFKNHOHAA(KeepsakeCategoryThemePair pair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KeepsakeCategoryThemePair> CPNAHPHIMKA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public KHEACAPBLIH(List<KeepsakeCategoryThemePair> CEFDHNLBCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x583CB60", Offset = "0x583BF60", VA = "0x18583CB60", Slot = "4")]
	public int Compare(GMHDHODCNMC EOMIKPKMCAG, GMHDHODCNMC PPNFDCNFKFC)
	{
		return default(int);
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct KeepsakeCategoryThemePair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public GMHDHODCNMC KeepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public KeepsakeTheme KeepsakeTheme;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NPECACBIKJK]
public class FNHNFKPIBCI : EGBNLJBLJLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NKIHOPBBLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public GMHDHODCNMC keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NKIHOPBBLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x583DEC0", Offset = "0x583D2C0", VA = "0x18583DEC0")]
		internal KDCMFGDLEKL<Guid> PHOKPKCHLPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x583DE90", Offset = "0x583D290", VA = "0x18583DE90")]
		internal void OELPBCCANEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x583D9A0", Offset = "0x583CDA0", VA = "0x18583D9A0")]
		internal void AFAGLNNOHFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x583DA00", Offset = "0x583CE00", VA = "0x18583DA00")]
		internal void HPGFHPOFOIM(string error)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x583DE60", Offset = "0x583D260", VA = "0x18583DE60")]
		internal void JIGGEOKHJHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KPJEFDMPBHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public string keepsakePickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int collectedKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int collectableKeepsakeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KPJEFDMPBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x583CE10", Offset = "0x583C210", VA = "0x18583CE10")]
		internal void LCEKNNDGNNF(ALCKNNFMMLO response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x583D1C0", Offset = "0x583C5C0", VA = "0x18583D1C0")]
		internal void NMAJGEFIEIA(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BEFAMMPFNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KeepsakeTheme theme;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BEFAMMPFNBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x582D7E0", Offset = "0x582CBE0", VA = "0x18582D7E0")]
		internal bool MAKGKBJDAKK(KeepsakeCategoryThemePair categoryThemePair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FMKPCNJBBJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GMHDHODCNMC? keepsakeCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FMKPCNJBBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x582DE30", Offset = "0x582D230", VA = "0x18582DE30")]
		internal void PCOIAAMGIKM(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x582DE00", Offset = "0x582D200", VA = "0x18582DE00")]
		internal void PBGDNPLOCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x582DAF0", Offset = "0x582CEF0", VA = "0x18582DAF0")]
		internal KDCMFGDLEKL<IEnumerable<Guid>> LNBKHKICICK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A74A20", Offset = "0x3A73E20", VA = "0x183A74A20")]
		internal bool ILLCNDGBGII(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IHFDNJCKADN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FMKPCNJBBJB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IHFDNJCKADN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x583C060", Offset = "0x583B460", VA = "0x18583C060")]
		internal KDCMFGDLEKL<IEnumerable<Guid>> AFCIGKKFHLI(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FCKLDIJPHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public IHFDNJCKADN CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FCKLDIJPHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x582D9C0", Offset = "0x582CDC0", VA = "0x18582D9C0")]
		internal bool MFEIKCMCDJD(Guid instanceId)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JBDEEBANHHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Guid instanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FCKLDIJPHGG CS$<>8__locals3;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JBDEEBANHHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x583C1B0", Offset = "0x583B5B0", VA = "0x18583C1B0")]
		internal bool GAFGOBNLHDE(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class IEFMCEHINBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IEFMCEHINBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x583BEF0", Offset = "0x583B2F0", VA = "0x18583BEF0")]
		internal KDCMFGDLEKL<IEnumerable<Guid>> KCHMODEGCIN(IEnumerable<Guid> instanceIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x583BE50", Offset = "0x583B250", VA = "0x18583BE50")]
		internal bool FLBLODNAMPH(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class NOJIIOHBDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public long progressionEventId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public NOJIIOHBDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x583E000", Offset = "0x583D400", VA = "0x18583E000")]
		internal void JHFIBCFDHBI(KeepsakeProgressionEventInstancesDTO result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x582DE00", Offset = "0x582D200", VA = "0x18582DE00")]
		internal void ECIJHEIKBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x583E080", Offset = "0x583D480", VA = "0x18583E080")]
		internal KDCMFGDLEKL<Dictionary<Guid, GMHDHODCNMC>> OLCLBCDNLLL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3A74A20", Offset = "0x3A73E20", VA = "0x183A74A20")]
		internal bool AGIAGMOIPBM(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KDDKBIOKEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public KeepsakeRoomInstanceIdsDTO instancesInRoom;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KDDKBIOKEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x583C990", Offset = "0x583BD90", VA = "0x18583C990")]
		internal KDCMFGDLEKL<Dictionary<Guid, GMHDHODCNMC>> POADKOAHMEM(KeepsakeRoomInstancesDTO roomInstancesDTO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class PNHFILINDME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public KeepsakeRoomInstancesDTO roomInstancesDTO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PNHFILINDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x583E730", Offset = "0x583DB30", VA = "0x18583E730")]
		internal bool LFDGOLEGMAN(Guid instanceId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x583E5B0", Offset = "0x583D9B0", VA = "0x18583E5B0")]
		internal KeyValuePair<Guid, GMHDHODCNMC> JPNPGCJKHHA(Guid instanceId)
		{
			return default(KeyValuePair<Guid, GMHDHODCNMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PEEHFKGNLKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PEEHFKGNLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x583E510", Offset = "0x583D910", VA = "0x18583E510")]
		internal bool KFNCJLIJJLB(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class OEEEGKNDFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Guid instanceId;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OEEEGKNDFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x583E380", Offset = "0x583D780", VA = "0x18583E380")]
		internal bool ANCPOKBGCLO(KeepsakeInstanceDTO dto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HLELEFKDEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Predicate<KeepsakeRoomInstanceIdsDTO> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HLELEFKDEHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x583BC30", Offset = "0x583B030", VA = "0x18583BC30")]
		internal KDCMFGDLEKL<Dictionary<Guid, GMHDHODCNMC>> EJOFDOFMALI(Dictionary<Guid, GMHDHODCNMC> instanceIdsAndCategories)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x583BE50", Offset = "0x583B250", VA = "0x18583BE50")]
		internal bool GDGGJIDBEPB(KeepsakeRoomInstanceIdsDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OJICPNNOIBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public KeepsakeRoomInstanceIdsDTO collectedInstanceIds;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OJICPNNOIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x583E420", Offset = "0x583D820", VA = "0x18583E420")]
		internal bool LIPOCPHCANB(KeyValuePair<Guid, GMHDHODCNMC> idCategoryPair)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class BBOGLBIMHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Dictionary<Guid, GMHDHODCNMC> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BBOGLBIMHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x582D680", Offset = "0x582CA80", VA = "0x18582D680")]
		internal KeyValuePair<GMHDHODCNMC, int> KEJNLKEEEPA(GMHDHODCNMC category)
		{
			return default(KeyValuePair<GMHDHODCNMC, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HAEPGGEPPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public GMHDHODCNMC category;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HAEPGGEPPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xCFADA0", Offset = "0xCFA1A0", VA = "0x180CFADA0")]
		internal bool EIHJLNCNJHF(GMHDHODCNMC instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JMLAOGGFJFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Dictionary<Guid, GMHDHODCNMC> instanceIdsAndCategories;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JMLAOGGFJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x583C570", Offset = "0x583B970", VA = "0x18583C570")]
		internal KeyValuePair<GMHDHODCNMC, int> HOCBGHGJCID(GMHDHODCNMC category)
		{
			return default(KeyValuePair<GMHDHODCNMC, int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PFEBAKFBPFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public GMHDHODCNMC category;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PFEBAKFBPFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xCFADA0", Offset = "0xCFA1A0", VA = "0x180CFADA0")]
		internal bool INLBFOBEEMF(GMHDHODCNMC instanceCategory)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class JDGPDPKJEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<KeepsakeRoomDTO, bool> <>9__3;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JDGPDPKJEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x583C3A0", Offset = "0x583B7A0", VA = "0x18583C3A0")]
		internal bool DNKMEENIMJL(DateTime nowUtc, DateTime eventStartTime, int roomOrder, TimeSpan unlockStartOffset, TimeSpan unlockInterval, int unlockBatchSize)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x583C2D0", Offset = "0x583B6D0", VA = "0x18583C2D0")]
		internal bool CODGNAOKECD(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x583C2B0", Offset = "0x583B6B0", VA = "0x18583C2B0")]
		internal bool EGCEFIIOODC(KeepsakeRoomDTO r)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x583C2B0", Offset = "0x583B6B0", VA = "0x18583C2B0")]
		internal bool BKMHCKIPABL(KeepsakeRoomDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JFMBBNNENLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JFMBBNNENLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xBBE310", Offset = "0xBBD710", VA = "0x180BBE310")]
		internal bool JBOIHDAFEDP(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JOEPLHNEDFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<KeepsakeRoomDTO, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JOEPLHNEDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x583C6D0", Offset = "0x583BAD0", VA = "0x18583C6D0")]
		internal bool NCFOPMIJONC(KeepsakeRoomListDTO roomList)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xB21DF0", Offset = "0xB211F0", VA = "0x180B21DF0")]
		internal bool JEKKMPEOIKG(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PDFNOHIPHAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public PDFNOHIPHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x583E4A0", Offset = "0x583D8A0", VA = "0x18583E4A0")]
		internal bool GIJAGEEODIO(KeepsakeRoomListDTO i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IOIDAPDCPBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IOIDAPDCPBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xBBE310", Offset = "0xBBD710", VA = "0x180BBE310")]
		internal bool ICFIHCDGFKM(KeepsakeRoomListDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CIMNCAMPDOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public CIMNCAMPDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x582D810", Offset = "0x582CC10", VA = "0x18582D810")]
		internal bool JDMCBJGADBD(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HFPOBDOJOCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public GMHDHODCNMC keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public HFPOBDOJOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xB25E90", Offset = "0xB25290", VA = "0x180B25E90")]
		internal bool BGCMKDLDEGA(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DCFCCBIMEIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Guid keepsakeInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DCFCCBIMEIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x582D8A0", Offset = "0x582CCA0", VA = "0x18582D8A0")]
		internal bool ALANBIPFEBO(KeyValuePair<Guid, KeepsakeInstanceDTO> instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ANMHGJOHKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public GMHDHODCNMC keepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ANMHGJOHKND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x582D640", Offset = "0x582CA40", VA = "0x18582D640")]
		internal bool GIONJLGBKGL(KeyValuePair<Guid, GMHDHODCNMC> x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MPCMIDBNGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GMHDHODCNMC newKeepsakeCategory;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MPCMIDBNGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xB25E90", Offset = "0xB25290", VA = "0x180B25E90")]
		internal bool DHBLPAHKKJH(KeepsakeInstanceDTO instance)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class DFCACEAPJKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public long currentRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public long? currentSubRoomId;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public DFCACEAPJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x582D930", Offset = "0x582CD30", VA = "0x18582D930")]
		internal bool CPALLLDIFEJ(KeepsakeInstanceDTO x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class JGPJHDBBPCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<KeepsakeRoomListDTO> roomList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public long keepsakeRoomListId;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public JGPJHDBBPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x583C480", Offset = "0x583B880", VA = "0x18583C480")]
		internal bool COHCILCHCCF(KeepsakeRoomDTO room)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class IDHGJAGFGKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KeepsakeRoomDTO room;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JGPJHDBBPCG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public IDHGJAGFGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x583BE70", Offset = "0x583B270", VA = "0x18583BE70")]
		internal bool BODGFONOPMH(KeepsakeRoomListDTO roomListDto)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MFIACNJMBDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AEEBPABFEDL args;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private Exception <e>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private List<KeepsakeInstanceDTO> <validKeepsakeInstances>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MFIACNJMBDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x583D470", Offset = "0x583C870", VA = "0x18583D470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KBDOEOKPFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public FNHNFKPIBCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public KBDOEOKPFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x583C7A0", Offset = "0x583BBA0", VA = "0x18583C7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DateTime JAHMNAHAPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly BALDLKIPFMK PONOPJLDPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MGBAGFBEKLP LCDHNPGIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FKACHEJGBKN OABLIIBHOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HHAFFEOHOPN AFGLHEFPOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CFJAIONOPOH MDIBAOPLIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly DNMDDKLIMKP AKKJHBFGCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PMICAKGHNFF MJJNPNJOEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly BOEFLMAPNBA COPLMJPOHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly MKIICJNKOMA IEGAMIIJNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly DIILBCIFIHN GMMKPPOEMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly AMEMEPFBHAD FKJMIIAMLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IHCEOCBHDOP IAABDJAMMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly FACJFOKGJDJ ICCBOJIKDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly JDNDFJHHCFM FIFIJDGGGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FHPGBOJECFJ OJMEENEKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LJPKNAJPJMB<KeepsakesConfig.KeepsakesOptions> PPHPNENEJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly DLINHDPINMI OMIBPOLHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<Guid, KeepsakeInstanceDTO> HAOEEGJKEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly HashSet<Guid> ILCJABOOOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HashSet<long> CIDBLAFBIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Dictionary<GMHDHODCNMC, int> HPCLJHCBKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly HashSet<Guid> JMONLBLNMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly IDisposable JLEALMFGOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Task CGMJIPPLDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KDCMFGDLEKL<Guid> ONJJJEBJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private long? LIGHODCPMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KeepsakeProgressionEventInstancesDTO BFELNKJCHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private KDCMFGDLEKL<KeepsakeProgressionEventInstancesDTO> MOACCFNIBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IReadOnlyDictionary<GMHDHODCNMC, KeepsakeCategoryConfigDTO> ABCHEIDIBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KeepsakeGlobalConfigDTO FAOBABMHNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private HashSet<long> GJDHIDIACPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private HashSet<long> GOBMCFEIKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private List<KeepsakeRoomListDTO> OOAOHMKGCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private List<KeepsakeRoomListDTO> ACONPFGCFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private List<KeepsakeRoomListDTO> HLBHHDKOGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Dictionary<long, string> OBBHFDKJCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Dictionary<long, string> AHAGMLDGLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private Dictionary<long, DateTime> PONICFACBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Dictionary<long, List<KeepsakeRoomDTO>> ELDCJOGHIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Dictionary<long, List<KeepsakeRoomDTO>> GNAEMIBCEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private Dictionary<long, long> GEPGLGCJHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<string> EIOOKFPNPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private DateTime HGHPICKEIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IDisposable EHHJPHDGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Dictionary<Guid, GMHDHODCNMC> KJGNHDBDFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private Dictionary<GMHDHODCNMC, int> ONGMEDNIMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private List<KeepsakeCategoryThemePair> CEFDHNLBCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private KHEACAPBLIH BOEJMAPEOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private bool IOLHKNPHPEI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JOLACAMEAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x11AA2E0", Offset = "0x11A96E0", VA = "0x1811AA2E0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x11B7640", Offset = "0x11B6A40", VA = "0x1811B7640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NKHDJICGNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x582E150", Offset = "0x582D550", VA = "0x18582E150", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IHILCNDJPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x583A2A0", Offset = "0x58396A0", VA = "0x18583A2A0", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private long BDMJJAJJACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5834090", Offset = "0x5833490", VA = "0x185834090")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private long? CHKFHJEPAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5836C70", Offset = "0x5836070", VA = "0x185836C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool JFGDAGKLFKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5839870", Offset = "0x5838C70", VA = "0x185839870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IReadOnlyList<KeepsakeRoomListDTO> DPDHHONNJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xC9B610", Offset = "0xC9AA10", VA = "0x180C9B610", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IReadOnlyList<KeepsakeRoomListDTO> LABOPJBNIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC58700", Offset = "0xC57B00", VA = "0x180C58700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<KeepsakeRoomListDTO> GIPHBKFKBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B20", Offset = "0x8E4F20", VA = "0x1808E5B20", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyDictionary<long, string> FAMMFJCKMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBBBDE0", Offset = "0xBBB1E0", VA = "0x180BBBDE0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	internal bool BEJNIOPEJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC9B620", Offset = "0xC9AA20", VA = "0x180C9B620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Guid?> JJHLPJCFCKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5831B80", Offset = "0x5830F80", VA = "0x185831B80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x582F140", Offset = "0x582E540", VA = "0x18582F140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action KBKNGKPDFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5836350", Offset = "0x5835750", VA = "0x185836350", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x58353B0", Offset = "0x58347B0", VA = "0x1858353B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BHJIMBPDEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5837FC0", Offset = "0x58373C0", VA = "0x185837FC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5838A60", Offset = "0x5837E60", VA = "0x185838A60", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x583A910", Offset = "0x5839D10", VA = "0x18583A910")]
	[Preserve]
	internal FNHNFKPIBCI([NotNull][JLJFOFICIEA(null)] BALDLKIPFMK PONOPJLDPPN, [NotNull][JLJFOFICIEA(null)] CFJIBAGFFHP OGKOILPHNAL, [NotNull][JLJFOFICIEA(null)] MGBAGFBEKLP LCDHNPGIGKB, [NotNull][JLJFOFICIEA(null)] FKACHEJGBKN OABLIIBHOHA, [NotNull][JLJFOFICIEA(null)] HHAFFEOHOPN AFGLHEFPOJD, [NotNull][JLJFOFICIEA(null)] CFJAIONOPOH MDIBAOPLIIF, [NotNull][JLJFOFICIEA(null)] DNMDDKLIMKP AKKJHBFGCBF, [NotNull][JLJFOFICIEA(null)] PMICAKGHNFF MJJNPNJOEDI, [NotNull][JLJFOFICIEA(null)] BOEFLMAPNBA COPLMJPOHBN, [NotNull][JLJFOFICIEA(null)] CCNELKHLPDN POLMMBOIGEI, [NotNull][JLJFOFICIEA(null)] MKIICJNKOMA IEGAMIIJNGH, [NotNull][JLJFOFICIEA(null)] DIILBCIFIHN GMMKPPOEMEF, [NotNull][JLJFOFICIEA(null)] AMEMEPFBHAD FKJMIIAMLEP, [NotNull][JLJFOFICIEA(null)] IHCEOCBHDOP IAABDJAMMLO, [NotNull][JLJFOFICIEA(null)] FACJFOKGJDJ ICCBOJIKDNA, [NotNull][JLJFOFICIEA(null)] JDNDFJHHCFM FIFIJDGGGND, [NotNull][JLJFOFICIEA(null)] FHPGBOJECFJ OJMEENEKFNI, [NotNull][JLJFOFICIEA(null)] LJPKNAJPJMB<KeepsakesConfig.KeepsakesOptions> PPHPNENEJCI, [NotNull][JLJFOFICIEA(null)] DLINHDPINMI OMIBPOLHBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5834960", Offset = "0x5833D60", VA = "0x185834960", Slot = "15")]
	public bool FPJLCOENLBI(List<string> DPHKIJLINDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5830160", Offset = "0x582F560", VA = "0x185830160", Slot = "16")]
	public KDCMFGDLEKL<Guid> DBBBPKALIPA(GMHDHODCNMC HDLDJIFAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5837D40", Offset = "0x5837140", VA = "0x185837D40", Slot = "17")]
	public LMHNGLGIJDH MHNNBBKAIGJ(Guid HODMOHOMIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5834510", Offset = "0x5833910", VA = "0x185834510", Slot = "18")]
	public LMHNGLGIJDH FMMNIGEABBE(Guid HODMOHOMIKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x58343C0", Offset = "0x58337C0", VA = "0x1858343C0", Slot = "19")]
	public bool FMJKBPLIFBG(Guid HODMOHOMIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5836F50", Offset = "0x5836350", VA = "0x185836F50", Slot = "20")]
	public bool JMKBIJGGNNO(Guid HODMOHOMIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5837510", Offset = "0x5836910", VA = "0x185837510")]
	public KeepsakeTheme LBJKKJLIECM(Guid HODMOHOMIKF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5834E00", Offset = "0x5834200", VA = "0x185834E00")]
	public bool GFGBAJBMOMH(GMHDHODCNMC HDLDJIFAKDK, out KeepsakeTheme FPKJLNHNBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x582FE10", Offset = "0x582F210", VA = "0x18582FE10")]
	public List<KeepsakeTheme> DBAOMKFFNBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5834FD0", Offset = "0x58343D0", VA = "0x185834FD0")]
	public int GFHAECBOIHK(GMHDHODCNMC HDLDJIFAKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x583A370", Offset = "0x5839770", VA = "0x18583A370")]
	public GMHDHODCNMC PLKJPOMCADI(Guid HODMOHOMIKF)
	{
		return default(GMHDHODCNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x582DFA0", Offset = "0x582D3A0", VA = "0x18582DFA0", Slot = "34")]
	public List<GMHDHODCNMC> AIEKPNBFNIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5836F80", Offset = "0x5836380", VA = "0x185836F80", Slot = "35")]
	public IComparer<GMHDHODCNMC> KBEGDBMCCCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x582E730", Offset = "0x582DB30", VA = "0x18582E730", Slot = "32")]
	public string BGOPKBHCLPK(GMHDHODCNMC HDLDJIFAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x58378D0", Offset = "0x5836CD0", VA = "0x1858378D0", Slot = "33")]
	public string LFIIOMMPNNF(GMHDHODCNMC HDLDJIFAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x582EEA0", Offset = "0x582E2A0", VA = "0x18582EEA0", Slot = "21")]
	public bool CFFPGFDBBPM(Guid HODMOHOMIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5838540", Offset = "0x5837940", VA = "0x185838540", Slot = "22")]
	public void NCBABEEPDNK(Guid HODMOHOMIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5836BB0", Offset = "0x5835FB0", VA = "0x185836BB0", Slot = "23")]
	public void IINLEPELMPO(GMHDHODCNMC HDLDJIFAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x582E1A0", Offset = "0x582D5A0", VA = "0x18582E1A0", Slot = "24")]
	public void APELLBIEOHG(Guid HODMOHOMIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x58385B0", Offset = "0x58379B0", VA = "0x1858385B0", Slot = "25")]
	public int NGLGMOPPMON()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x582FA20", Offset = "0x582EE20", VA = "0x18582FA20", Slot = "31")]
	public KDCMFGDLEKL<IEnumerable<Guid>> CPFALFCDCAO(long KFHMHOFPIPN, long HEMEJJGNILE, GMHDHODCNMC? HDLDJIFAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5835980", Offset = "0x5834D80", VA = "0x185835980", Slot = "30")]
	public KDCMFGDLEKL<IEnumerable<Guid>> GOHOIEKKHPJ(long KFHMHOFPIPN, long HEMEJJGNILE, GMHDHODCNMC? HDLDJIFAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x58367D0", Offset = "0x5835BD0", VA = "0x1858367D0", Slot = "54")]
	public KDCMFGDLEKL<Dictionary<Guid, GMHDHODCNMC>> IIHNDDLHLDL(long KFHMHOFPIPN, long HEMEJJGNILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5834230", Offset = "0x5833630", VA = "0x185834230", Slot = "55")]
	public KDCMFGDLEKL<Dictionary<Guid, GMHDHODCNMC>> FLIFHBLOOAD(long KFHMHOFPIPN, long HEMEJJGNILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5832C50", Offset = "0x5832050", VA = "0x185832C50", Slot = "26")]
	public KDCMFGDLEKL<int> DKBAFOFBECI(long KFHMHOFPIPN, long HEMEJJGNILE, GMHDHODCNMC? HDLDJIFAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5835240", Offset = "0x5834640", VA = "0x185835240", Slot = "27")]
	public KDCMFGDLEKL<int> GJJJBDCELKI(long KFHMHOFPIPN, long HEMEJJGNILE, GMHDHODCNMC? HDLDJIFAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5838F10", Offset = "0x5838310", VA = "0x185838F10", Slot = "28")]
	public KDCMFGDLEKL<Dictionary<GMHDHODCNMC, int>> OLDFMJAOKAM(long KFHMHOFPIPN, long HEMEJJGNILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5834160", Offset = "0x5833560", VA = "0x185834160", Slot = "29")]
	public KDCMFGDLEKL<Dictionary<GMHDHODCNMC, int>> FHCMLCKFJLC(long KFHMHOFPIPN, long HEMEJJGNILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5833930", Offset = "0x5832D30", VA = "0x185833930", Slot = "37")]
	public bool EPBBHHNFPCB(long KFHMHOFPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x58363F0", Offset = "0x58357F0", VA = "0x1858363F0", Slot = "56")]
	public bool HNOGILMKEFI(long KFHMHOFPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x58397D0", Offset = "0x5838BD0", VA = "0x1858397D0", Slot = "38")]
	public bool PDCLFJNFHLL(long KFHMHOFPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5839A10", Offset = "0x5838E10", VA = "0x185839A10", Slot = "57")]
	public bool PFLLMINLPOM(long KFHMHOFPIPN, out JJCEDPNKLNH IGBEGFPGCPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x582EAB0", Offset = "0x582DEB0", VA = "0x18582EAB0", Slot = "39")]
	public bool BPCHNLILBEM(long JMLMKPDPECA, out DateTime DKIIFFAOBLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x583A4E0", Offset = "0x58398E0", VA = "0x18583A4E0", Slot = "40")]
	public long PPEONIJBKKJ(long JMLMKPDPECA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5833510", Offset = "0x5832910", VA = "0x185833510", Slot = "41")]
	public long EFEHIPPOKLP(long KFHMHOFPIPN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5830F70", Offset = "0x5830370", VA = "0x185830F70", Slot = "42")]
	public int DFMGBDMLKKM(long JMLMKPDPECA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x582E8A0", Offset = "0x582DCA0", VA = "0x18582E8A0", Slot = "43")]
	public bool BLIGAJADHMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5839DD0", Offset = "0x58391D0", VA = "0x185839DD0", Slot = "44")]
	public bool PGJHFKMGIFD(long JMLMKPDPECA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5837330", Offset = "0x5836730", VA = "0x185837330", Slot = "45")]
	public IEnumerable<long> LAKCCNCKGJO(long JMLMKPDPECA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x58308B0", Offset = "0x582FCB0", VA = "0x1858308B0", Slot = "46")]
	public int DBONAIPCMHM(long JMLMKPDPECA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5833990", Offset = "0x5832D90", VA = "0x185833990", Slot = "50")]
	public long FBHLLMNBKIF(long OJMLIKKDMAP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5833CE0", Offset = "0x58330E0", VA = "0x185833CE0", Slot = "51")]
	public GMHDHODCNMC FGCEGIEJICA()
	{
		return default(GMHDHODCNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58376B0", Offset = "0x5836AB0", VA = "0x1858376B0")]
	private bool LDFBKJOECNO(Guid HODMOHOMIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5838060", Offset = "0x5837460", VA = "0x185838060")]
	private void MLIAEILEKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5833630", Offset = "0x5832A30", VA = "0x185833630")]
	private GMHDHODCNMC EGJBDCHOLAO()
	{
		return default(GMHDHODCNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x58309C0", Offset = "0x582FDC0", VA = "0x1858309C0")]
	private void DFMDNLHFGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x582F1E0", Offset = "0x582E5E0", VA = "0x18582F1E0")]
	private int CFOANPEOMOK(KeepsakeRoomListDTO KCHCKNOBDMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5837A40", Offset = "0x5836E40", VA = "0x185837A40")]
	private int LMGAKILHKOK(DateTime MMLICGEOLPK, DateTime PPINPEBJPDA, TimeSpan KODLHICOFBL, int ONCLPMBKNCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x583A090", Offset = "0x5839490", VA = "0x18583A090")]
	private void PJHPAPCLLFB(IEnumerable<KeepsakeInstanceDTO> HAOEEGJKEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5836D10", Offset = "0x5836110", VA = "0x185836D10")]
	private void JFGIIDKGLBM(IEnumerable<KeepsakeCollectionRecordDTO> DBLBGILGNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5838EB0", Offset = "0x58382B0", VA = "0x185838EB0")]
	private void OILEBNJOBHG(IEnumerable<long> HMLOMBLOKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xB419A0", Offset = "0xB40DA0", VA = "0x180B419A0")]
	private void JKIPHOJBJJP(KeepsakeGlobalConfigDTO FAOBABMHNKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5837020", Offset = "0x5836420", VA = "0x185837020")]
	private bool KJKEHEJHJEI(GMHDHODCNMC HDLDJIFAKDK, out Guid OMCLPPJKILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x582DEB0", Offset = "0x582D2B0", VA = "0x18582DEB0")]
	private bool AADOONBOMHO(out Guid OMCLPPJKILN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x58372D0", Offset = "0x58366D0", VA = "0x1858372D0")]
	private bool KNHBELECEHP(Guid HODMOHOMIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x58333B0", Offset = "0x58327B0", VA = "0x1858333B0")]
	private IEnumerable<Guid> EEPJPIFODBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5834890", Offset = "0x5833C90", VA = "0x185834890")]
	private IEnumerable<KeepsakeInstanceDTO> FNDKCBBAFBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x582F990", Offset = "0x582ED90", VA = "0x18582F990")]
	private void CNBGOCKBBGE(Guid HODMOHOMIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5832970", Offset = "0x5831D70", VA = "0x185832970")]
	private bool DHMGJHBEBAE(Guid HODMOHOMIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5836080", Offset = "0x5835480", VA = "0x185836080")]
	private void HGMHOHHEPMH(Guid HODMOHOMIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x58377F0", Offset = "0x5836BF0", VA = "0x1858377F0")]
	private void LFGCAKPJNHL(GMHDHODCNMC ILPOOGMOEIC, int PKMJFHFEIMN, ref Dictionary<GMHDHODCNMC, int> EJFLDDHAGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5839140", Offset = "0x5838540", VA = "0x185839140")]
	private int OMMCOFPBFFM(GMHDHODCNMC HDLDJIFAKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x582ECE0", Offset = "0x582E0E0", VA = "0x18582ECE0")]
	private void BPJFGPLMOJE(KeepsakeInstanceDTO OCLCLGFMLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x58365D0", Offset = "0x58359D0", VA = "0x1858365D0")]
	private void ICECLJCAJNI(KeepsakeInstanceDTO OCLCLGFMLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5839240", Offset = "0x5838640", VA = "0x185839240")]
	private void OOIILMKPNHN(Guid HODMOHOMIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x582F930", Offset = "0x582ED30", VA = "0x18582F930")]
	private void CMKCJJBPBJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5837D20", Offset = "0x5837120", VA = "0x185837D20")]
	private void MHDNGDJKBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5836BF0", Offset = "0x5835FF0", VA = "0x185836BF0")]
	private void ILMKOGEHFAP(PJKDLPBKDPA NDLHNJOADNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x582E6D0", Offset = "0x582DAD0", VA = "0x18582E6D0")]
	private void BEOMBKLEHDA(GBKEJAIKONN HFAGBIOODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5830960", Offset = "0x582FD60", VA = "0x185830960")]
	private void DCACOKHAPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x582F560", Offset = "0x582E960", VA = "0x18582F560")]
	private void CMGONODEKEH(float JKDNDHGFJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5835B20", Offset = "0x5834F20", VA = "0x185835B20")]
	private void HCNPKAPCGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x582F390", Offset = "0x582E790", VA = "0x18582F390")]
	private bool CHHLBFMHFMC(Guid HODMOHOMIKF, out string OLFJJPNCLOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5838B00", Offset = "0x5837F00", VA = "0x185838B00")]
	private bool NPMCBBDBGKD(Guid HODMOHOMIKF, out KeepsakeCategoryConfigDTO ILPOOGMOEIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x582EC00", Offset = "0x582E000", VA = "0x18582EC00")]
	private void BPIPJOPPGIA(string PBGNFGHMDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x582E990", Offset = "0x582DD90", VA = "0x18582E990")]
	private bool BLIGOJIMJLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x582E3F0", Offset = "0x582D7F0", VA = "0x18582E3F0")]
	private IEnumerable<long> BAHHEPCEMPL(IEnumerable<KeepsakeRoomDTO> GJMFGEGHBPJ, IEnumerable<KeepsakeRoomListDTO> LIBAPPJDKEN, long JMLMKPDPECA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x58315C0", Offset = "0x58309C0", VA = "0x1858315C0")]
	private bool DGDMMHFHMAC(Guid HODMOHOMIKF, out string FOMNCGOADBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x582E0F0", Offset = "0x582D4F0", VA = "0x18582E0F0", Slot = "47")]
	public string AMBACEBIFPP(HIBKGIAMNDM NANDFNJJFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5831170", Offset = "0x5830570", VA = "0x185831170", Slot = "49")]
	public string DFOJJIHJEMC(HIBKGIAMNDM NANDFNJJFJL, long KFHMHOFPIPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5830790", Offset = "0x582FB90", VA = "0x185830790", Slot = "48")]
	public string DBBNMKPAKJJ(HIBKGIAMNDM NANDFNJJFJL, int LEKEGLOONMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5831C20", Offset = "0x5831020", VA = "0x185831C20")]
	private void DHKNGEIABEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x582F420", Offset = "0x582E820", VA = "0x18582F420")]
	private void CICDHDMGOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5835130", Offset = "0x5834530", VA = "0x185835130")]
	private HIBKGIAMNDM GHFLLFJJEOG(IPMBFGHPPHB OMNMMDIPGBP)
	{
		return default(HIBKGIAMNDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x582DF80", Offset = "0x582D380", VA = "0x18582DF80")]
	private HIBKGIAMNDM AAKEHHFJEIH(IPMBFGHPPHB OMNMMDIPGBP)
	{
		return default(HIBKGIAMNDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5838CD0", Offset = "0x58380D0", VA = "0x185838CD0")]
	internal static string OBBDMOKMKCE(ALCKNNFMMLO EFJKGNCMMPN, string NAENNDPMFJA, bool KDFGAKJFFKN, int LMIMBMLHODE, int BIDHGICHDLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5832F10", Offset = "0x5832310", VA = "0x185832F10", Slot = "52")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5837B10", Offset = "0x5836F10", VA = "0x185837B10")]
	private EIDINADMANL MAKKGIBMCKF(NJNAENGEJEB ECNCNFMMPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x58357E0", Offset = "0x5834BE0", VA = "0x1858357E0")]
	private JDLIPIMGGDN GNALDHPMOIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5835450", Offset = "0x5834850", VA = "0x185835450")]
	private Task GKJLFFCACIK(AEEBPABFEDL AIEGNLJMEEC, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5839660", Offset = "0x5838A60", VA = "0x185839660")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFIACNJMBDD))]
	private Task PDADPJBBIOL(AEEBPABFEDL AIEGNLJMEEC, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x58395C0", Offset = "0x58389C0", VA = "0x1858395C0")]
	private Task PBLAFGAPNDF(AEEBPABFEDL AIEGNLJMEEC, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5834C70", Offset = "0x5834070", VA = "0x185834C70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KBDOEOKPFIK))]
	private Task GAGIBPPLMDF(string FHDJIGKOLJM, TimeSpan KLPBHJFNGGM, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x41B0EA0", Offset = "0x41B02A0", VA = "0x1841B0EA0")]
	[CompilerGenerated]
	private void NFFDMEDJBJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5838A10", Offset = "0x5837E10", VA = "0x185838A10")]
	[CompilerGenerated]
	private void NHBDHPAICHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5835150", Offset = "0x5834550", VA = "0x185835150")]
	[CompilerGenerated]
	private bool GHPBANAKHLE(KeepsakeInstanceDTO EOMIKPKMCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5836450", Offset = "0x5835850", VA = "0x185836450")]
	[CompilerGenerated]
	private KDCMFGDLEKL<Dictionary<GMHDHODCNMC, int>> ICDMNHCJGIC(Dictionary<Guid, GMHDHODCNMC> ACOKFGMFDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5839890", Offset = "0x5838C90", VA = "0x185839890")]
	[CompilerGenerated]
	private KDCMFGDLEKL<Dictionary<GMHDHODCNMC, int>> PDKICNCALJO(Dictionary<Guid, GMHDHODCNMC> ACOKFGMFDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5833CC0", Offset = "0x58330C0", VA = "0x185833CC0")]
	[CompilerGenerated]
	private bool FBJCGNICNBF(KeepsakeRoomListDTO EOMIKPKMCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5836220", Offset = "0x5835620", VA = "0x185836220")]
	[CompilerGenerated]
	private bool HJFMFPHDEDC(KeepsakeInstanceDTO EOMIKPKMCAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5837BA0", Offset = "0x5836FA0", VA = "0x185837BA0")]
	[CompilerGenerated]
	private void MBFCFIJNCPC(Tuple<KeepsakeRoomInstancesDTO, IReadOnlyDictionary<GMHDHODCNMC, KeepsakeCategoryConfigDTO>, KeepsakeGlobalConfigDTO> FCMCEKILEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5833350", Offset = "0x5832750", VA = "0x185833350")]
	[CompilerGenerated]
	private void EEKIPEKNGLP(string FOMNCGOADBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5832A20", Offset = "0x5831E20", VA = "0x185832A20")]
	[CompilerGenerated]
	private Task DIMNODALKII(CancellationToken FHDIJGKCHML)
	{
		return null;
	}
}
namespace RecRoom.Keepsakes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct KeepsakeTheme
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public string ThemeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int ThemeOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Pickup")]
		public string PickupName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public GameObject PickupPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AudioClip PickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public float PickupSfxVolume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Header("Colors")]
		public bool UseCustomColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Color BeamColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Color BaseColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Header("Looping Sound")]
		public AudioClip LoopingSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
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

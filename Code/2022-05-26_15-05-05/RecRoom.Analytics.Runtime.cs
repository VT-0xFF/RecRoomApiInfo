using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KNLJAMJCCDP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string ADGBCCAAAML = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string GHHHIDKEOHC = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string LHINJKFANCK = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string FELFHGBAGOG = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string JIAKDIALOGI = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string JFHAFAFJPBA = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string CCFJDCDMJAJ = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long PMEOCKIEICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EDHBPEGLDGP DDAEPAFOJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool BLNNMOJBDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float NNMLHHHODLD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D94620", Offset = "0x4D92C20", VA = "0x184D94620")]
	public KNLJAMJCCDP(string BCKODOMHNIM, float NNMLHHHODLD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2F280F0", Offset = "0x2F266F0", VA = "0x182F280F0")]
	public void EENGDDKAKGP<T>(string IFPGDLJELIP, T MPHFKGJNMOK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D94380", Offset = "0x4D92980", VA = "0x184D94380")]
	public void EENGDDKAKGP(string IFPGDLJELIP, string MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D94400", Offset = "0x4D92A00", VA = "0x184D94400")]
	public void EGMMHEPOFJP(string FEDBAJNOHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4D94520", Offset = "0x4D92B20", VA = "0x184D94520")]
	public void LKGLLPJLNMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4D94280", Offset = "0x4D92880", VA = "0x184D94280")]
	private void CGICJAGJOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4D945D0", Offset = "0x4D92BD0", VA = "0x184D945D0")]
	private bool NIEALEGNHPB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KHHOAHHIMGH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APPFHLGLKJA EDEIJCODOEL(string PGOLGDPLLOL, string GMFHCLGPKDM, [Optional] HHPMKCPCDDA JDNFBDHJHDP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	APPFHLGLKJA ONKCCOOHLMG(HHPMKCPCDDA JDNFBDHJHDP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCCHLKAHCDK(string DCLCFKCEHJL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PCJOKNGHLIB MJACBMLGHKF(string NPCADMBOBLP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PCJOKNGHLIB BCIBELDGPOH(string CHHALLKIJPF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	APPFHLGLKJA DONNNGFIKLP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IDEDKDEPGLK : KHHOAHHIMGH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string JFHBOMAHCPM = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string INPJLGFNMPG = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string CKKMABCJGGO = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string NMGLEJDGDPM = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string AGKMBIAFPCN = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string EPCIGOMDIBG = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string LCDJNMCCPAL = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string JIDFEEBGCKK = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string EBAPPJBNLOH = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, POMDAIBNGKD> EMAIHPMBPPM;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int JBLEDDBCHBP = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool EJOMGIDLDCN;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	[Preserve]
	public IDEDKDEPGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D92AD0", Offset = "0x4D910D0", VA = "0x184D92AD0")]
	[LFFPJIGGALK(CGKCNJFGIMF.Unity_BeforeSceneLoad)]
	private static void BOEMAPAGMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D92E30", Offset = "0x4D91430", VA = "0x184D92E30", Slot = "4")]
	public APPFHLGLKJA EDEIJCODOEL(string PGOLGDPLLOL, string GMFHCLGPKDM, [Optional] HHPMKCPCDDA JDNFBDHJHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D92CF0", Offset = "0x4D912F0", VA = "0x184D92CF0", Slot = "9")]
	public APPFHLGLKJA DONNNGFIKLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D93960", Offset = "0x4D91F60", VA = "0x184D93960", Slot = "5")]
	public APPFHLGLKJA ONKCCOOHLMG(HHPMKCPCDDA JDNFBDHJHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D92C30", Offset = "0x4D91230", VA = "0x184D92C30", Slot = "6")]
	public bool CCCHLKAHCDK(string DCLCFKCEHJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D93650", Offset = "0x4D91C50", VA = "0x184D93650", Slot = "7")]
	public PCJOKNGHLIB MJACBMLGHKF(string NPCADMBOBLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D92860", Offset = "0x4D90E60", VA = "0x184D92860", Slot = "8")]
	public PCJOKNGHLIB BCIBELDGPOH(string CHHALLKIJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D93230", Offset = "0x4D91830", VA = "0x184D93230")]
	private LGLDOPHKCIG HKNOOKHANHA(HHPMKCPCDDA JDNFBDHJHDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D92950", Offset = "0x4D90F50", VA = "0x184D92950")]
	private JILDDDKJHFM BNMCCABGLAC(string GMFHCLGPKDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D93760", Offset = "0x4D91D60", VA = "0x184D93760")]
	private void NGAOGGLDNEA(string NPCADMBOBLP, PCJOKNGHLIB MKKBKPHEKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F5E20", Offset = "0x6F4420", VA = "0x1806F5E20")]
	[CompilerGenerated]
	private void IMCGMDOCMHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JAIPHFBPGAG
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNLJAMJCCDP PILNGCONOOL(string BCKODOMHNIM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HHPMKCPCDDA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EPNCANBJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PJOHBKJKFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NHIBEMFGEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ICPGJADOJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? OCPHGODECFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? MKGPDFJLLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int KJHIONDLFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string FAECBLOFJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string DKKOPCDHHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string BIADHIOIFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string GGNJHIKFOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string BNOEAECIKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public AmplitudeAnalyticsClient.Settings BIAOFHKKFMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IMEFKLEJBBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x560190", Offset = "0x55E790", VA = "0x180560190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum LDOLOCMFOGE
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum APGJKJGEKFH
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class FFJBHCJHECO
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class LGDIMMKPLCG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int KCKPHLPEGJK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> MFHFGEMINJF;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
				public LGDIMMKPLCG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class NKHJDIPCGHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
				public NKHJDIPCGHK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x4D94EA0", Offset = "0x4D934A0", VA = "0x184D94EA0")]
				internal bool <GetBatch>b__0(LGDIMMKPLCG item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string MOKNEICLPFK = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string IOMEMFDDFKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<LGDIMMKPLCG> FLKBJLFHEIF;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? BEJJGCIHHDN
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x4D91C90", Offset = "0x4D90290", VA = "0x184D91C90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? LNEBAJOLKEP
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x4D911F0", Offset = "0x4D8F7F0", VA = "0x184D911F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4D91E70", Offset = "0x4D90470", VA = "0x184D91E70")]
			internal FFJBHCJHECO(string NOPEGBMDOLA, string GMFHCLGPKDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4D91810", Offset = "0x4D8FE10", VA = "0x184D91810")]
			public int LFELEMHEEGK([Optional] int? HMNFOKHGMKI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4D90DD0", Offset = "0x4D8F3D0", VA = "0x184D90DD0")]
			public List<Dictionary<string, object>> GEFGEAMALMK(int LLBBJKELCBA, int? HMNFOKHGMKI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4D91670", Offset = "0x4D8FC70", VA = "0x184D91670")]
			public void KAPLKKPNNHG(AmplitudeAnalyticsIdentifyMessage FIEDOLNFNLH, bool FPCDCONGLBA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4D91710", Offset = "0x4D8FD10", VA = "0x184D91710")]
			public void KAPLKKPNNHG(Dictionary<string, object> FIEDOLNFNLH, bool FPCDCONGLBA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4D91D20", Offset = "0x4D90320", VA = "0x184D91D20")]
			public void PKIGEPOLNCJ(params Dictionary<string, object>[] OOLANNCMGIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4D90FD0", Offset = "0x4D8F5D0", VA = "0x184D90FD0")]
			public void HOBGOHNMDGO(List<Dictionary<string, object>> BMGFOEBDDOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4D90CC0", Offset = "0x4D8F2C0", VA = "0x184D90CC0")]
			private void ACPIOJPOOJL(Dictionary<string, object> FIEDOLNFNLH, bool FPCDCONGLBA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4D91970", Offset = "0x4D8FF70", VA = "0x184D91970")]
			public void MDBGFHPMLGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4D912A0", Offset = "0x4D8F8A0", VA = "0x184D912A0")]
			private void JOGHAHAHACA([Optional] string MLOGMCKPFBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4D91B60", Offset = "0x4D90160", VA = "0x184D91B60")]
			private static string MMIODJKMEME(string MPHFKGJNMOK, string MKDJIBNCKNC)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x4D95750", Offset = "0x4D93D50", VA = "0x184D95750")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct NKFCHNGKKGF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int LKNDALCPIBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string KCIHBMOFBMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T GNLIGFNOLLF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NANNJGILDOJ : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private MCOOOHEMEPE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public NANNJGILDOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4D94780", Offset = "0x4D92D80", VA = "0x184D94780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4D94E50", Offset = "0x4D93450", VA = "0x184D94E50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class EAKIPBLBJCO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public BNGELMJMADH quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public EAKIPBLBJCO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4D90830", Offset = "0x4D8EE30", VA = "0x184D90830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4D90920", Offset = "0x4D8EF20", VA = "0x184D90920", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class HOEDEHBOJPF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000090")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public HOEDEHBOJPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4D926A0", Offset = "0x4D90CA0", VA = "0x184D926A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4D92810", Offset = "0x4D90E10", VA = "0x184D92810", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CLADLMHNENK : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private MCOOOHEMEPE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public CLADLMHNENK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4D90490", Offset = "0x4D8EA90", VA = "0x184D90490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4D906C0", Offset = "0x4D8ECC0", VA = "0x184D906C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class PCGFBKBJDOB : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private MCOOOHEMEPE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public PCGFBKBJDOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4D953A0", Offset = "0x4D939A0", VA = "0x184D953A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x4D955E0", Offset = "0x4D93BE0", VA = "0x184D955E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class OGDMGCHOHDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public FFJBHCJHECO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public OGDMGCHOHDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4D94F00", Offset = "0x4D93500", VA = "0x184D94F00")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4D94FA0", Offset = "0x4D935A0", VA = "0x184D94FA0")]
			internal void <FlushFromCache>b__1(NKFCHNGKKGF<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class JEIKNPEGOKO : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private MCOOOHEMEPE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public FFJBHCJHECO cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private OGDMGCHOHDB <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
			[DebuggerHidden]
			public JEIKNPEGOKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4D93B70", Offset = "0x4D92170", VA = "0x184D93B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4D94230", Offset = "0x4D92830", VA = "0x184D94230", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KAMDIOCBJGO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
			public KAMDIOCBJGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2698BD0", Offset = "0x26971D0", VA = "0x182698BD0")]
			internal NKFCHNGKKGF<T> <PostRudderStackJson>b__0(GLBHDKBAOFA postResponse)
			{
				return default(NKFCHNGKKGF<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JJAFOLKMBPG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
			public JJAFOLKMBPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2698BD0", Offset = "0x26971D0", VA = "0x182698BD0")]
			internal NKFCHNGKKGF<T> <PostAmplitudeJson>b__0(GLBHDKBAOFA postResponse)
			{
				return default(NKFCHNGKKGF<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PAHOFPMCLLC GBHOEELLNPP;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string EMHCFPNPAKB = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string LPJJBDNJHDC = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string CAFLIJKCJKL = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string CAHDIJIAAJH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string NLGIALMIBHK = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int ADICFGKFNFH = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int DBLHONCDNJB = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int NGGBNMFFDGH = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float KLJNFBLPJAB = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long NHJFHOCKBCF = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string IHCLHLDDAPA = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string JLJPADIGJFD = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool GGNBNCHLPAI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool ECOCIDHOAPF;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int NKCHIJHIIHC;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int OIKPPKKFAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private DJMECJNNIPC FOGDFKBNBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool JDPGMEKIKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float MDECLBMFJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float OLHMPNGPDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int IFAFEAEMDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int FLKENCNMPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? BKIJPDIHFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? ELDJMBDJHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long MFEIBKJBHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string DGHMMOEJHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long PGBDGPBPEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> FLBDOJGGNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private APGJKJGEKFH BBFHNKCPGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int MJCJMONHKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int BAMIICOPNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float AGAACOAGIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool NOCAIDMKPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool ICDGOFAAHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private FFJBHCJHECO FMDGNILCOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FFJBHCJHECO INLINHBHLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private FFJBHCJHECO JHKBEBOKBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> PPAPBJGOAOO;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo LCJFEMHAAFL;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string GHJNLGKOJKN;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string PNJMOOAMCHD = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string CEEGPNJKMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string HBDCFEIKDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string GLDKBKEGKLE;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string BNFIPIFLJJC = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string GLBFINCFDIB = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private PAHOFPMCLLC DPJPBPJFIHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CD10", Offset = "0x4D8B310", VA = "0x184D8CD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int BCMJAELMBBD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4D8CDF0", Offset = "0x4D8B3F0", VA = "0x184D8CDF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long GCNJBMMIAOP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F5F0", Offset = "0x4D8DBF0", VA = "0x184D8F5F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F6F0", Offset = "0x4D8DCF0", VA = "0x184D8F6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string CLJHJOGDMMN
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F590", Offset = "0x4D8DB90", VA = "0x184D8F590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string BKADDPLDAIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F5C0", Offset = "0x4D8DBC0", VA = "0x184D8F5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string LBKEALIPNGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x584700", Offset = "0x582D00", VA = "0x180584700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x572260", Offset = "0x570860", VA = "0x180572260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? MKGPDFJLLJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5E98F0", Offset = "0x5E7EF0", VA = "0x1805E98F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1154130", Offset = "0x1152730", VA = "0x181154130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LDOLOCMFOGE? CFJLDIJHFGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5EBAA0", Offset = "0x5EA0A0", VA = "0x1805EBAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2670D80", Offset = "0x266F380", VA = "0x182670D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NNIIIDGPCON
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA48D0", Offset = "0xAA2ED0", VA = "0x180AA48D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x16B6840", Offset = "0x16B4E40", VA = "0x1816B6840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool NJJKJHKEBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F4B0", Offset = "0x4D8DAB0", VA = "0x184D8F4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> BKGJNFFNAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F410", Offset = "0x4D8DA10", VA = "0x184D8F410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4D8F650", Offset = "0x4D8DC50", VA = "0x184D8F650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B440", Offset = "0x4D89A40", VA = "0x184D8B440", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B100", Offset = "0x4D89700", VA = "0x184D8B100")]
		private void AMANJAHIKNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EE30", Offset = "0x4D8D430", VA = "0x184D8EE30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E0A0", Offset = "0x4D8C6A0", VA = "0x184D8E0A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EFB0", Offset = "0x4D8D5B0", VA = "0x184D8EFB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E610", Offset = "0x4D8CC10", VA = "0x184D8E610")]
		public APPFHLGLKJA PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D590", Offset = "0x4D8BB90", VA = "0x184D8D590")]
		[IteratorStateMachine(typeof(NANNJGILDOJ))]
		public IEnumerator<MCOOOHEMEPE> Initialize(AmplitudeAnalyticsEvent FFMHLPFINFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EF00", Offset = "0x4D8D500", VA = "0x184D8EF00")]
		public void UpdateLastAliveTime(float INLHJCFKACP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E140", Offset = "0x4D8C740", VA = "0x184D8E140")]
		private APPFHLGLKJA PHBMOAGEAIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BE60", Offset = "0x4D8A460", VA = "0x184D8BE60")]
		private APPFHLGLKJA DPCGDPCCEOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EAC0", Offset = "0x4D8D0C0", VA = "0x184D8EAC0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DFC0", Offset = "0x4D8C5C0", VA = "0x184D8DFC0")]
		[IteratorStateMachine(typeof(EAKIPBLBJCO))]
		private IEnumerator OIKCHEFCDPM(BNGELMJMADH MDADFKNLCPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F210", Offset = "0x4D8D810", VA = "0x184D8F210")]
		[IteratorStateMachine(typeof(HOEDEHBOJPF))]
		public IEnumerator WaitForFlush(float HFMGPPJGPEM = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EE40", Offset = "0x4D8D440", VA = "0x184D8EE40")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D290", Offset = "0x4D8B890", VA = "0x184D8D290")]
		public static GGBMOGMPCML Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B300", Offset = "0x4D89900", VA = "0x184D8B300")]
		public static EDHBPEGLDGP AccountSelectionPostLoginEvent([NotNull] string BNCDFKEEJJM, string GEGFNBELGKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C090", Offset = "0x4D8A690", VA = "0x184D8C090")]
		public static EDHBPEGLDGP Event([NotNull] string BNCDFKEEJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E690", Offset = "0x4D8CC90", VA = "0x184D8E690")]
		public static EDHBPEGLDGP PreviousSessionEvent([NotNull] string BNCDFKEEJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D3D0", Offset = "0x4D8B9D0", VA = "0x184D8D3D0")]
		public static EDHBPEGLDGP InitializeEvent(string GEGFNBELGKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8EBD0", Offset = "0x4D8D1D0", VA = "0x184D8EBD0")]
		public static EDHBPEGLDGP StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B720", Offset = "0x4D89D20", VA = "0x184D8B720")]
		public static EDHBPEGLDGP CreateOutOfSessionEvent(string BNCDFKEEJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DA40", Offset = "0x4D8C040", VA = "0x184D8DA40")]
		public static APPFHLGLKJA LogOutOfSessionEvent(EDHBPEGLDGP CPFMCLJFBGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D890", Offset = "0x4D8BE90", VA = "0x184D8D890")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JMLMNBHNGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DD70", Offset = "0x4D8C370", VA = "0x184D8DD70")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JMLMNBHNGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DE40", Offset = "0x4D8C440", VA = "0x184D8DE40")]
		public void LogSerializedEventAsync(Dictionary<string, object> OKFALFPMCDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D960", Offset = "0x4D8BF60", VA = "0x184D8D960")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage NDKGBHDLCAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DF10", Offset = "0x4D8C510", VA = "0x184D8DF10")]
		private void NLKJECDMCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BAD0", Offset = "0x4D8A0D0", VA = "0x184D8BAD0")]
		private void DIINIIDEBGN(Dictionary<string, object> MIMODPGCKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B9E0", Offset = "0x4D89FE0", VA = "0x184D8B9E0")]
		private void DDJFCONJPDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D700", Offset = "0x4D8BD00", VA = "0x184D8D700")]
		private void JJKMGFMGEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D010", Offset = "0x4D8B610", VA = "0x184D8D010")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D120", Offset = "0x4D8B720", VA = "0x184D8D120")]
		[IteratorStateMachine(typeof(CLADLMHNENK))]
		private IEnumerator<MCOOOHEMEPE> HABOMJBIKDK(float HFMGPPJGPEM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D0A0", Offset = "0x4D8B6A0", VA = "0x184D8D0A0")]
		[IteratorStateMachine(typeof(PCGFBKBJDOB))]
		private IEnumerator<MCOOOHEMEPE> GBMBCKHMOHC(float HFMGPPJGPEM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D620", Offset = "0x4D8BC20", VA = "0x184D8D620")]
		[IteratorStateMachine(typeof(JEIKNPEGOKO))]
		private IEnumerator<MCOOOHEMEPE> JEBHMOEPJOE(FFJBHCJHECO JFHJFCDGNCO, int? HMNFOKHGMKI, string CAOGIPLJNDL, string MMALDJLBNGJ, float HFMGPPJGPEM, Action<int> BBOOEMLJFHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D1A0", Offset = "0x4D8B7A0", VA = "0x184D8D1A0")]
		private static void IBMOCOJABKC(bool JEDBCBHAGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E200", Offset = "0x4D8C800", VA = "0x184D8E200")]
		private global::DBIKMJJJBLJ<NKFCHNGKKGF<Dictionary<string, object>>> PLBLPKDDGGN(string CAOGIPLJNDL, string MMALDJLBNGJ, string FCNOOIOMJOB, string BOICOCJNBDG, Dictionary<string, object> GNLIGFNOLLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E370", Offset = "0x4D8C970", VA = "0x184D8E370")]
		private global::DBIKMJJJBLJ<NKFCHNGKKGF<List<Dictionary<string, object>>>> PLBLPKDDGGN(string CAOGIPLJNDL, string MMALDJLBNGJ, string FCNOOIOMJOB, string BOICOCJNBDG, List<Dictionary<string, object>> GNLIGFNOLLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1C18710", Offset = "0x1C16D10", VA = "0x181C18710")]
		private global::DBIKMJJJBLJ<NKFCHNGKKGF<T>> EPJDBMIBNEG<T>(string CAOGIPLJNDL, string MMALDJLBNGJ, string BOICOCJNBDG, T GNLIGFNOLLF, Dictionary<string, object> CGCFMOIKLOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1C18440", Offset = "0x1C16A40", VA = "0x181C18440")]
		private global::DBIKMJJJBLJ<NKFCHNGKKGF<T>> APACOEJKINO<T>(string CAOGIPLJNDL, string MMALDJLBNGJ, string FCNOOIOMJOB, T GNLIGFNOLLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4D8E050", Offset = "0x4D8C650", VA = "0x184D8E050")]
		private bool OKHDMICDCIM(float FDAHJLCPCMG, float HFMGPPJGPEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C1F0", Offset = "0x4D8A7F0", VA = "0x184D8C1F0")]
		private Dictionary<string, object> FCLJHHAGFAF(string MMALDJLBNGJ, Dictionary<string, object> GNLIGFNOLLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F2F0", Offset = "0x4D8D8F0", VA = "0x184D8F2F0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4D8BD00", Offset = "0x4D8A300", VA = "0x184D8BD00")]
		[CompilerGenerated]
		private long DMECMMGJHEK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4D8B0F0", Offset = "0x4D896F0", VA = "0x184D8B0F0")]
		[CompilerGenerated]
		private void AAFLBFEGOIJ(int JEKFEKGEJFF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x566620", Offset = "0x564C20", VA = "0x180566620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F990", Offset = "0x4D8DF90", VA = "0x184D8F990")]
		public static EDHBPEGLDGP GPCBEJLMGEM(string MNOJMAIICKJ, [NotNull] string IKJDOANBFNC, long AJPDEEJDPKM, long ALJPPPCDBJI, string GEGFNBELGKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FBF0", Offset = "0x4D8E1F0", VA = "0x184D8FBF0")]
		public static EDHBPEGLDGP PEHNCBJPMJP(string MNOJMAIICKJ, [NotNull] string IKJDOANBFNC, long AJPDEEJDPKM, long ALJPPPCDBJI, string GEGFNBELGKD, long PODHGPIAKDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FCE0", Offset = "0x4D8E2E0", VA = "0x184D8FCE0")]
		private AmplitudeAnalyticsEvent(string MNOJMAIICKJ, [NotNull] string IKJDOANBFNC, long AJPDEEJDPKM, long ALJPPPCDBJI, string GEGFNBELGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
		public void MODCDHNLIHF(long EHOJGHKIBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FAE0", Offset = "0x4D8E0E0", VA = "0x184D8FAE0", Slot = "5")]
		public override void MFDALOMNKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FA70", Offset = "0x4D8E070", VA = "0x184D8FA70", Slot = "6")]
		public override void HPMMIGELNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4D8F750", Offset = "0x4D8DD50", VA = "0x184D8F750", Slot = "4")]
		protected override Dictionary<string, object> CDGGOGBKJDD(Dictionary<string, object> NLMAFMFHGBA)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4D90710", Offset = "0x4D8ED10", VA = "0x184D90710")]
			public void AMMHFEOPIMH(Dictionary<string, object> DCKNLEOOOHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4D95630", Offset = "0x4D93C30", VA = "0x184D95630")]
			public void AMMHFEOPIMH(Dictionary<string, object> NHNMBAFNGBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x126D340", Offset = "0x126B940", VA = "0x18126D340")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4D900C0", Offset = "0x4D8E6C0", VA = "0x184D900C0")]
		public static GGBMOGMPCML GPCBEJLMGEM(string MNOJMAIICKJ, string GEGFNBELGKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4D903D0", Offset = "0x4D8E9D0", VA = "0x184D903D0")]
		protected AmplitudeAnalyticsIdentifyMessage(string MNOJMAIICKJ, string GEGFNBELGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4D90360", Offset = "0x4D8E960", VA = "0x184D90360")]
		public Dictionary<string, object> PLDHGKMBAID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4D8FE80", Offset = "0x4D8E480", VA = "0x184D8FE80", Slot = "4")]
		protected virtual Dictionary<string, object> CDGGOGBKJDD(Dictionary<string, object> NLMAFMFHGBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4D902C0", Offset = "0x4D8E8C0", VA = "0x184D902C0")]
		protected void PKEJJOINMLI(string MKDJIBNCKNC, Dictionary<string, object> ABGAMGNMPMC, Dictionary<string, object> HNLKBOABPBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4D901D0", Offset = "0x4D8E7D0", VA = "0x184D901D0")]
		protected void KBKNAMAIHGH(string MKDJIBNCKNC, string MPHFKGJNMOK, Dictionary<string, object> JFPAPBLAAJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4D90240", Offset = "0x4D8E840", VA = "0x184D90240", Slot = "5")]
		public virtual void MFDALOMNKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4D90160", Offset = "0x4D8E760", VA = "0x184D90160", Slot = "6")]
		public virtual void HPMMIGELNFF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GGBMOGMPCML : global::IBCLNEFAFNP<AmplitudeAnalyticsIdentifyMessage, GGBMOGMPCML>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override GGBMOGMPCML KOHBEGBNNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x615F60", Offset = "0x614560", VA = "0x180615F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage IAMINAGLEFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D92060", Offset = "0x4D90660", VA = "0x184D92060")]
	public GGBMOGMPCML(AmplitudeAnalyticsIdentifyMessage EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D91FD0", Offset = "0x4D905D0", VA = "0x184D91FD0", Slot = "4")]
	public override void HPMMIGELNFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EDHBPEGLDGP : global::IBCLNEFAFNP<AmplitudeAnalyticsEvent, EDHBPEGLDGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool FCFLKCMHBNH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override EDHBPEGLDGP KOHBEGBNNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x615F60", Offset = "0x614560", VA = "0x180615F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B0A0", Offset = "0x4D896A0", VA = "0x184D8B0A0")]
	public EDHBPEGLDGP(AmplitudeAnalyticsEvent EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent IAMINAGLEFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D909F0", Offset = "0x4D8EFF0", VA = "0x184D909F0", Slot = "4")]
	public override void HPMMIGELNFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x258AAC0", Offset = "0x25890C0", VA = "0x18258AAC0")]
	public EDHBPEGLDGP EENGDDKAKGP<T>(string IFPGDLJELIP, T[] MPHFKGJNMOK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D909E0", Offset = "0x4D8EFE0", VA = "0x184D909E0")]
	public EDHBPEGLDGP EENGDDKAKGP(string IFPGDLJELIP, string[] MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x258AA50", Offset = "0x2589050", VA = "0x18258AA50")]
	public EDHBPEGLDGP EENGDDKAKGP<T>(string IFPGDLJELIP, T MPHFKGJNMOK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D90970", Offset = "0x4D8EF70", VA = "0x184D90970")]
	public EDHBPEGLDGP EENGDDKAKGP(string IFPGDLJELIP, string MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4D90A90", Offset = "0x4D8F090", VA = "0x184D90A90")]
	private EDHBPEGLDGP JCDICJOLKAK(string IFPGDLJELIP, object MPHFKGJNMOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AHGCFAPNABA : EDHBPEGLDGP
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4D8B0A0", Offset = "0x4D896A0", VA = "0x184D8B0A0")]
	public AHGCFAPNABA(AmplitudeAnalyticsEvent EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D8AF70", Offset = "0x4D89570", VA = "0x184D8AF70", Slot = "4")]
	public override void HPMMIGELNFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class IBCLNEFAFNP<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::IBCLNEFAFNP<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M EPAKPJCIEHE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR KOHBEGBNNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x20B8150", Offset = "0x20B6750", VA = "0x1820B8150")]
	public IBCLNEFAFNP(M EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x20B8110", Offset = "0x20B6710", VA = "0x1820B8110")]
	public BLDR OCNAOFJPCOF(AmplitudeAnalyticsIdentifyMessage.DeviceInfo EOPEOGPNGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x20B8060", Offset = "0x20B6660", VA = "0x1820B8060")]
	public BLDR IHNFEJBKOEN(AmplitudeAnalyticsIdentifyMessage.RevenueData KFICKKFJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20B80A0", Offset = "0x20B66A0", VA = "0x1820B80A0")]
	public BLDR KNJMAHIAGNC(string IFPGDLJELIP, string MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x254DD20", Offset = "0x254C320", VA = "0x18254DD20")]
	public BLDR KNJMAHIAGNC<T>(string IFPGDLJELIP, T MPHFKGJNMOK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HPMMIGELNFF();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20B8030", Offset = "0x20B6630", VA = "0x1820B8030")]
	internal static string FDCAFJHDDHP(string MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20B7F50", Offset = "0x20B6550", VA = "0x1820B7F50")]
	private BLDR EOCKLFHLJLL(string IFPGDLJELIP, object MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M IAMINAGLEFG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JBPAPALENAA
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string OMCCGIEFAJN = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string DDCOLGDPHOE = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string NNCBHFDFJPP = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string DPOGFJPACOM = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string ILBFDDDJCGL = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string OEFMHDCNBEH = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string FLMEJGJKABP = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string MFFHFCCLHLF = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string JFOFAGAPECC = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string GBCHGOKMICG = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string AJCFLHOFJHN = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string PEHICCIONEA = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string FMNPDAEIAMM = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string KCEKEDMFMEP = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string JLBGEHEJMOO = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string PJPNLJNANNP = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string FOOJHGELCEK = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string ACOJJCOAFML = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string JBJFKGLIGOG = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string KENOPLNPCJF = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string EIIHFOCCKID = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string GAGLOJGKEMP = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public JBPAPALENAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EGNNGPFBCEN
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int CPGJEHHNNKK = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int FKOCMCBKJFC = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int ALJNMFKNGEG = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long ADEPLJIAHBF = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int KFENBIHCAKG = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int KIBPFJKAKHF = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string NKIEJBFFIHN = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string AFPPEMAMMEB = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string IHCCCAKIDGA = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string DDOOAAAJAIL = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string KKGGDLJLPMF = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string HJCINAGLEEP = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string CIMIEBAGHGI = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string MHOINHGOPKH = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string IKAJOICEPIL = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string NPDGAGLLKEE = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string FDNPDMGCJGD = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string AHNIMIIDDOG = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string DLIJBEGAJLO = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string GGNKMDBEEHL = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string JILEAABPLHA = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string IIFMAOCICJG = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string IACPBGPDMAC = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string KJEHLMJDNDC = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string HODFJOJPCCI = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string ABIPHIECGEK = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string GJIPCMPOJKP = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string PKGDLLCOFML = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string PCJIGEADHJG = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string FIHDHABEPAA = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string CBJKIIKAGHJ = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string OBAKGDBPPPA = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string ILBFDDDJCGL = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string DABDNGOGILJ = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int FLJJMKIPCDL = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> IECOCGDCEGL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D90B70", Offset = "0x4D8F170", VA = "0x184D90B70")]
	internal static bool LECBOMCNOFE(string MKDJIBNCKNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public EGNNGPFBCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DJMECJNNIPC
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool DCNAOCKEEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string NDENJMPHGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string NGICKFNCBCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string AHGAEOIAEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string FFKDOHFFMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DBIKMJJJBLJ<GLBHDKBAOFA> PLBLPKDDGGN(string CAOGIPLJNDL, Dictionary<string, string> OENMAHOGDAN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::DBIKMJJJBLJ<GLBHDKBAOFA> JCPIKDPJLEN(string CAOGIPLJNDL, string JGLBJEKGOEC, string CJGCGNIJHDI, string CENBGLDBBLI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct GLBHDKBAOFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int OJOBPHGGOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string DCCHFFLIBDF;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x568CF0", Offset = "0x5672F0", VA = "0x180568CF0")]
	public GLBHDKBAOFA(int LKNDALCPIBE, string KCIHBMOFBMB)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D920B0", Offset = "0x4D906B0", VA = "0x184D920B0")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D921B0", Offset = "0x4D907B0", VA = "0x184D921B0")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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

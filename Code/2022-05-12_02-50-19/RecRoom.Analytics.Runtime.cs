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
public class NGCNLDAHJBG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string CFDPKLECOIA = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string FJHIIJEPLMM = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string GJNCFBBFIPA = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string HFENNCMKACJ = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string IHPGBPFFNFL = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string BMBBBKEAFFH = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string ICJOGLIBPLH = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long OHBCDJNCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KNAJPNENGOG IBPCHHCMELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool KKJPBFLFJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float INJIANAAPMP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB0F0", Offset = "0x4CEA4F0", VA = "0x184CEB0F0")]
	public NGCNLDAHJBG(string PHPOBMJOKEK, float INJIANAAPMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B2ACF0", Offset = "0x3B2A0F0", VA = "0x183B2ACF0")]
	public void LGONNKNBJBL<T>(string NFGIMAMDELO, T MGNFAPLJAOB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4CEADA0", Offset = "0x4CEA1A0", VA = "0x184CEADA0")]
	public void LGONNKNBJBL(string NFGIMAMDELO, string MGNFAPLJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAFD0", Offset = "0x4CEA3D0", VA = "0x184CEAFD0")]
	public void PCBOBFNPBMJ(string LAIPHOCOACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAF20", Offset = "0x4CEA320", VA = "0x184CEAF20")]
	public void OLEFJMOKNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAE20", Offset = "0x4CEA220", VA = "0x184CEAE20")]
	private void MBBOKAPFBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4CEAD50", Offset = "0x4CEA150", VA = "0x184CEAD50")]
	private bool HAJNNABBFNB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AKLCFKIAADK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCCNBCFBHAJ JBPGKBOBEDK(string LANDFGOIHAK, string ELKIENPHMHJ, [Optional] MDEAFBAJPFM NOEEKPMBNAI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCCNBCFBHAJ POIOJMLBMND(MDEAFBAJPFM NOEEKPMBNAI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JMJBLFEKIEM(string KBCCJEIJCGH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OMOEHICEHOE DEBIGNLACMO(string CHGMOIKAMII);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OMOEHICEHOE PEALKHJBDLD(string MMGDECGKNEP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DCCNBCFBHAJ FDBNCJLLOAL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KOCDEMPKKKG : AKLCFKIAADK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string BNAOLMPCCMG = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string MLOELBELICG = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string NBOABAFJADE = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string MPLHBDBLGEJ = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string NAFHADEAOIJ = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string EJBGOLPFIIO = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string IBMFPHLKCBH = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string KCAJDCDOIGO = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string DCFDFKGHPMP = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, IIILCKJAFGH> PMLCANKPOHD;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int MHIBINOIOHE = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool GLAEFKJLIAD;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	[Preserve]
	public KOCDEMPKKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8F20", Offset = "0x4CE8320", VA = "0x184CE8F20")]
	[EJKHGMDHGAJ(BMBPAGGHGAE.Unity_BeforeSceneLoad)]
	private static void OCKKGDHMJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8A60", Offset = "0x4CE7E60", VA = "0x184CE8A60", Slot = "4")]
	public DCCNBCFBHAJ JBPGKBOBEDK(string LANDFGOIHAK, string ELKIENPHMHJ, [Optional] MDEAFBAJPFM NOEEKPMBNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8920", Offset = "0x4CE7D20", VA = "0x184CE8920", Slot = "9")]
	public DCCNBCFBHAJ FDBNCJLLOAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4CE9590", Offset = "0x4CE8990", VA = "0x184CE9590", Slot = "5")]
	public DCCNBCFBHAJ POIOJMLBMND(MDEAFBAJPFM NOEEKPMBNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8E60", Offset = "0x4CE8260", VA = "0x184CE8E60", Slot = "6")]
	public bool JMJBLFEKIEM(string KBCCJEIJCGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8810", Offset = "0x4CE7C10", VA = "0x184CE8810", Slot = "7")]
	public OMOEHICEHOE DEBIGNLACMO(string CHGMOIKAMII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4CE94A0", Offset = "0x4CE88A0", VA = "0x184CE94A0", Slot = "8")]
	public OMOEHICEHOE PEALKHJBDLD(string MMGDECGKNEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4CE9080", Offset = "0x4CE8480", VA = "0x184CE9080")]
	private LBIEGNOIAOJ OMPICAKDPBD(MDEAFBAJPFM NOEEKPMBNAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8490", Offset = "0x4CE7890", VA = "0x184CE8490")]
	private BNEOMNMHGML BLBEPLCBKCK(string ELKIENPHMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8610", Offset = "0x4CE7A10", VA = "0x184CE8610")]
	private void CGEAILLFFHA(string CHGMOIKAMII, OMOEHICEHOE GPHKLFGNPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x70A8E0", Offset = "0x709CE0", VA = "0x18070A8E0")]
	[CompilerGenerated]
	private void FEBHBMBGKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GPALJBMCLBG
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGCNLDAHJBG KPPEKDIENCF(string PHPOBMJOKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MDEAFBAJPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OKCIICINHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HFAOCBMKHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NLDDDKCJPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GHGAHKDJJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? IONGLAILKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? KAFOKOJOKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LMIBKOFEEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string BPCCPPNKAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string HKKCBFBANFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string MKGDHECFECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string GAOEPBALFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string BKGODLEHHMA
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
		public AmplitudeAnalyticsClient.Settings FBDDEEBJPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KKHNJLMEJJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x552190", Offset = "0x551590", VA = "0x180552190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD9EBF0", Offset = "0xD9DFF0", VA = "0x180D9EBF0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum IPDLNLONANF
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum LIACDPMPBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class MGILANOIIJM
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class NNDLILKFFJO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int KFIKHCKCMNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> CFCAELPGEKL;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
				public NNDLILKFFJO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class EEGNKHDCJDI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
				public EEGNKHDCJDI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x4CE71A0", Offset = "0x4CE65A0", VA = "0x184CE71A0")]
				internal bool <GetBatch>b__0(NNDLILKFFJO item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string CIKBDHJDOFD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string FNMFFNABCCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<NNDLILKFFJO> OMCMPCNCMHF;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? GECFDICAKIF
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x4CEA0D0", Offset = "0x4CE94D0", VA = "0x184CEA0D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? IFKFLJCGMOL
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x4CE9E20", Offset = "0x4CE9220", VA = "0x184CE9E20")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4CEA950", Offset = "0x4CE9D50", VA = "0x184CEA950")]
			internal MGILANOIIJM(string NGDMGANHBOO, string ELKIENPHMHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4CEA7F0", Offset = "0x4CE9BF0", VA = "0x184CEA7F0")]
			public int PFLBMEELAPA([Optional] int? MOCGIGICKID)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4CE9ED0", Offset = "0x4CE92D0", VA = "0x184CE9ED0")]
			public List<Dictionary<string, object>> FMMJCNDGGPJ(int LOAFMPCHCMP, int? MOCGIGICKID)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4CE98A0", Offset = "0x4CE8CA0", VA = "0x184CE98A0")]
			public void AKLJPMFNDEK(AmplitudeAnalyticsIdentifyMessage CMGFKLKICHP, bool CKLDLKOCOJP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4CE97A0", Offset = "0x4CE8BA0", VA = "0x184CE97A0")]
			public void AKLJPMFNDEK(Dictionary<string, object> CMGFKLKICHP, bool CKLDLKOCOJP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4CEA570", Offset = "0x4CE9970", VA = "0x184CEA570")]
			public void NDDJEPFDBCD(params Dictionary<string, object>[] ALEFKBCAODB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4CEA350", Offset = "0x4CE9750", VA = "0x184CEA350")]
			public void KNGGDCKFEPM(List<Dictionary<string, object>> BLPKIPBLAHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4CE9D10", Offset = "0x4CE9110", VA = "0x184CE9D10")]
			private void COIIFLDAGHB(Dictionary<string, object> CMGFKLKICHP, bool CKLDLKOCOJP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4CEA160", Offset = "0x4CE9560", VA = "0x184CEA160")]
			public void KDDLCCGCJCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4CE9940", Offset = "0x4CE8D40", VA = "0x184CE9940")]
			private void BOBKKNKGKPP([Optional] string LBAJDABNHAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4CEA6C0", Offset = "0x4CE9AC0", VA = "0x184CEA6C0")]
			private static string NEJMPAJMCMD(string MGNFAPLJAOB, string KACNOLACOBJ)
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
			[Cpp2IlInjected.Address(RVA = "0x4CEBBB0", Offset = "0x4CEAFB0", VA = "0x184CEBBB0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct KBFLAAEHDGD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int GCFGAAGCJHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string MKHANIBKCMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T NGDNLNLNCKL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BAPFEMNIABP : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private HBFHEEBHGHK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public BAPFEMNIABP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4CE6710", Offset = "0x4CE5B10", VA = "0x184CE6710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4CE6E00", Offset = "0x4CE6200", VA = "0x184CE6E00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class EEPHGKGPCII : IEnumerator<object>, IEnumerator, IDisposable
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
			public DDLKDBDLBFL quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public EEPHGKGPCII(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4CE7200", Offset = "0x4CE6600", VA = "0x184CE7200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4CE72F0", Offset = "0x4CE66F0", VA = "0x184CE72F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JNACCBBEACP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public JNACCBBEACP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4CE8080", Offset = "0x4CE7480", VA = "0x184CE8080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4CE81F0", Offset = "0x4CE75F0", VA = "0x184CE81F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class NEFIKEHNKGH : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private HBFHEEBHGHK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public NEFIKEHNKGH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4CEAAB0", Offset = "0x4CE9EB0", VA = "0x184CEAAB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4CEAD00", Offset = "0x4CEA100", VA = "0x184CEAD00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JBGHNBINDPN : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private HBFHEEBHGHK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public JBGHNBINDPN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4CE7DD0", Offset = "0x4CE71D0", VA = "0x184CE7DD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x4CE8030", Offset = "0x4CE7430", VA = "0x184CE8030", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FFBIFPBDPOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public MGILANOIIJM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
			public FFBIFPBDPOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4CE7340", Offset = "0x4CE6740", VA = "0x184CE7340")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4CE73E0", Offset = "0x4CE67E0", VA = "0x184CE73E0")]
			internal void <FlushFromCache>b__1(KBFLAAEHDGD<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class OPIDOMPECJN : IEnumerator<HBFHEEBHGHK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private HBFHEEBHGHK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public MGILANOIIJM cache;

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
			private FFBIFPBDPOM <>8__1;

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
			private HBFHEEBHGHK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5521C0", Offset = "0x5515C0", VA = "0x1805521C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6637D0", Offset = "0x662BD0", VA = "0x1806637D0")]
			[DebuggerHidden]
			public OPIDOMPECJN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4CEB380", Offset = "0x4CEA780", VA = "0x184CEB380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4CEBA40", Offset = "0x4CEAE40", VA = "0x184CEBA40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class ELCEOOKGCIM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
			public ELCEOOKGCIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2F9F430", Offset = "0x2F9E830", VA = "0x182F9F430")]
			internal KBFLAAEHDGD<T> <PostRudderStackJson>b__0(NJOOFGBKILB postResponse)
			{
				return default(KBFLAAEHDGD<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class IKHABMKIAJL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1C1C3B0", Offset = "0x1C1B7B0", VA = "0x181C1C3B0")]
			public IKHABMKIAJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2F9F430", Offset = "0x2F9E830", VA = "0x182F9F430")]
			internal KBFLAAEHDGD<T> <PostAmplitudeJson>b__0(NJOOFGBKILB postResponse)
			{
				return default(KBFLAAEHDGD<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private MMLNABINJEF LAFCMIMLDGA;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string DIOMILAHNBP = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string FBKCCAAOPNC = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string PAFEBLGPIGD = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string BDFEKAOKJCC = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string FMBCJJFGOND = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int PIKKAGEOLKL = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int AMFHCNBBLFC = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int IBAOFCGAFMJ = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float ILAEBGNAMDO = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long CDLAMGCLGEJ = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string BIBMCFIMFAC = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string LFKMGCKEMGN = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool PMPBBNDKHBD;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool MIEDBMHLOMO;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int DCCBPEENMNA;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int HELHIGJACNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OKKCGGJLCDL HBEKAKKBHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool IIPNDMPFLIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float ANFDKAPLFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float JANHHONKHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int HJCPHOLNAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int OCJKBFPLJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? IKPHPGGEEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? MJCMFGJHBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long IMHOPHMFKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string GFDKHHMAPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long JDDFBEDIOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> NDDPGOMGFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private LIACDPMPBOJ JKICBMIIBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int IFOGDHNJCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int MIMPLMNMNBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float KECIMOPPMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool DJFLDCAKBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool PGMKKIHCLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private MGILANOIIJM LBEIDKANAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private MGILANOIIJM CPIKOJFCJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private MGILANOIIJM OJDPKNMIGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JOHEJNEKAJL;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NIOAPMDMOMN;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string GAINIJOJMFE;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string GBEHAIJNKAA = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string EMBHNJGOGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string GCMAGAGKEDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string JPIEIKFFONI;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string HPNNKNFMILD = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string KODPINDILDF = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MMLNABINJEF LPKLAEECJFN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4CE3B30", Offset = "0x4CE2F30", VA = "0x184CE3B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int MCDOEECMKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4CE3500", Offset = "0x4CE2900", VA = "0x184CE3500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long LEOOJEFBMMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4CE5870", Offset = "0x4CE4C70", VA = "0x184CE5870")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4CE5970", Offset = "0x4CE4D70", VA = "0x184CE5970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string CBFFDKKCMOG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4CE5810", Offset = "0x4CE4C10", VA = "0x184CE5810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string OALFNKIDLFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4CE5840", Offset = "0x4CE4C40", VA = "0x184CE5840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string EANIIOIIGIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x576700", Offset = "0x575B00", VA = "0x180576700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x564260", Offset = "0x563660", VA = "0x180564260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? KAFOKOJOKFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8F0", Offset = "0x5DACF0", VA = "0x1805DB8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xF57B60", Offset = "0xF56F60", VA = "0x180F57B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IPDLNLONANF? KLEHCNGJDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5DDAA0", Offset = "0x5DCEA0", VA = "0x1805DDAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xF586F0", Offset = "0xF57AF0", VA = "0x180F586F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IJOPHOKHACA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB54730", Offset = "0xB53B30", VA = "0x180B54730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1105820", Offset = "0x1104C20", VA = "0x181105820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool ICKEKOANEMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4CE5730", Offset = "0x4CE4B30", VA = "0x184CE5730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DJAIOAHEMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4CE5690", Offset = "0x4CE4A90", VA = "0x184CE5690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4CE58D0", Offset = "0x4CE4CD0", VA = "0x184CE58D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2060", Offset = "0x4CE1460", VA = "0x184CE2060", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4680", Offset = "0x4CE3A80", VA = "0x184CE4680")]
		private void PIBGJJALFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4CE50B0", Offset = "0x4CE44B0", VA = "0x184CE50B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4CE45E0", Offset = "0x4CE39E0", VA = "0x184CE45E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5230", Offset = "0x4CE4630", VA = "0x184CE5230")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4890", Offset = "0x4CE3C90", VA = "0x184CE4890")]
		public DCCNBCFBHAJ PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3A20", Offset = "0x4CE2E20", VA = "0x184CE3A20")]
		[IteratorStateMachine(typeof(BAPFEMNIABP))]
		public IEnumerator<HBFHEEBHGHK> Initialize(AmplitudeAnalyticsEvent LKCAPPPEENK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5180", Offset = "0x4CE4580", VA = "0x184CE5180")]
		public void UpdateLastAliveTime(float IFJKCELAFBF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4520", Offset = "0x4CE3920", VA = "0x184CE4520")]
		private DCCNBCFBHAJ OKMNCMHKCIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2760", Offset = "0x4CE1B60", VA = "0x184CE2760")]
		private DCCNBCFBHAJ EEPAGFODMMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4D40", Offset = "0x4CE4140", VA = "0x184CE4D40")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1E90", Offset = "0x4CE1290", VA = "0x184CE1E90")]
		[IteratorStateMachine(typeof(EEPHGKGPCII))]
		private IEnumerator AMOHLFBDNKM(DDLKDBDLBFL DAABMEMKEJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5490", Offset = "0x4CE4890", VA = "0x184CE5490")]
		[IteratorStateMachine(typeof(JNACCBBEACP))]
		public IEnumerator WaitForFlush(float OPOIFNPNEEK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4CE50C0", Offset = "0x4CE44C0", VA = "0x184CE50C0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3720", Offset = "0x4CE2B20", VA = "0x184CE3720")]
		public static DPENKEFJLFL Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1F20", Offset = "0x4CE1320", VA = "0x184CE1F20")]
		public static KNAJPNENGOG AccountSelectionPostLoginEvent([NotNull] string NELDGOIHEFA, string OEFANGIGJDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2D20", Offset = "0x4CE2120", VA = "0x184CE2D20")]
		public static KNAJPNENGOG Event([NotNull] string NELDGOIHEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4910", Offset = "0x4CE3D10", VA = "0x184CE4910")]
		public static KNAJPNENGOG PreviousSessionEvent([NotNull] string NELDGOIHEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3860", Offset = "0x4CE2C60", VA = "0x184CE3860")]
		public static KNAJPNENGOG InitializeEvent(string OEFANGIGJDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4E50", Offset = "0x4CE4250", VA = "0x184CE4E50")]
		public static KNAJPNENGOG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4CE24A0", Offset = "0x4CE18A0", VA = "0x184CE24A0")]
		public static KNAJPNENGOG CreateOutOfSessionEvent(string NELDGOIHEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3EB0", Offset = "0x4CE32B0", VA = "0x184CE3EB0")]
		public static DCCNBCFBHAJ LogOutOfSessionEvent(KNAJPNENGOG HBJBKAAANLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3D00", Offset = "0x4CE3100", VA = "0x184CE3D00")]
		public void LogEventAsync(AmplitudeAnalyticsEvent IIBFFIHEIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4CE41E0", Offset = "0x4CE35E0", VA = "0x184CE41E0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent IIBFFIHEIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4CE42B0", Offset = "0x4CE36B0", VA = "0x184CE42B0")]
		public void LogSerializedEventAsync(Dictionary<string, object> AOEJJFEOJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3DD0", Offset = "0x4CE31D0", VA = "0x184CE3DD0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BIAOOEOCIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4470", Offset = "0x4CE3870", VA = "0x184CE4470")]
		private void OFKFPBNCJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2AF0", Offset = "0x4CE1EF0", VA = "0x184CE2AF0")]
		private void EMDNNMEMAML(Dictionary<string, object> NNEKAPIBDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4380", Offset = "0x4CE3780", VA = "0x184CE4380")]
		private void NNCIAKIABCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2E80", Offset = "0x4CE2280", VA = "0x184CE2E80")]
		private void FAPDCKILNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3420", Offset = "0x4CE2820", VA = "0x184CE3420")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2420", Offset = "0x4CE1820", VA = "0x184CE2420")]
		[IteratorStateMachine(typeof(NEFIKEHNKGH))]
		private IEnumerator<HBFHEEBHGHK> CIJNNIDDOJP(float OPOIFNPNEEK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3AB0", Offset = "0x4CE2EB0", VA = "0x184CE3AB0")]
		[IteratorStateMachine(typeof(JBGHNBINDPN))]
		private IEnumerator<HBFHEEBHGHK> JCMJNJEENLF(float OPOIFNPNEEK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2340", Offset = "0x4CE1740", VA = "0x184CE2340")]
		[IteratorStateMachine(typeof(OPIDOMPECJN))]
		private IEnumerator<HBFHEEBHGHK> CEDKMHCOJHC(MGILANOIIJM AFKOFAEODLB, int? MOCGIGICKID, string LOOGHPJGBGF, string IPCFKFOJNLC, float OPOIFNPNEEK, Action<int> EKCCBNPFDNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3C10", Offset = "0x4CE3010", VA = "0x184CE3C10")]
		private static void KMHCKBGPHPO(bool LOMIBIFPKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3010", Offset = "0x4CE2410", VA = "0x184CE3010")]
		private global::OIKEDAHIDPO<KBFLAAEHDGD<Dictionary<string, object>>> FNGFHIPHGJL(string LOOGHPJGBGF, string IPCFKFOJNLC, string ONKEIKNBJMH, string ILNLAMFNIKO, Dictionary<string, object> NGDNLNLNCKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3180", Offset = "0x4CE2580", VA = "0x184CE3180")]
		private global::OIKEDAHIDPO<KBFLAAEHDGD<List<Dictionary<string, object>>>> FNGFHIPHGJL(string LOOGHPJGBGF, string IPCFKFOJNLC, string ONKEIKNBJMH, string ILNLAMFNIKO, List<Dictionary<string, object>> NGDNLNLNCKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0D10", Offset = "0x1FC0110", VA = "0x181FC0D10")]
		private global::OIKEDAHIDPO<KBFLAAEHDGD<T>> DHGPENIBNOK<T>(string LOOGHPJGBGF, string IPCFKFOJNLC, string ILNLAMFNIKO, T NGDNLNLNCKL, Dictionary<string, object> DNCFMIIOADI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1FC0A40", Offset = "0x1FBFE40", VA = "0x181FC0A40")]
		private global::OIKEDAHIDPO<KBFLAAEHDGD<T>> CEFKNFKLDKG<T>(string LOOGHPJGBGF, string IPCFKFOJNLC, string ONKEIKNBJMH, T NGDNLNLNCKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4CE34B0", Offset = "0x4CE28B0", VA = "0x184CE34B0")]
		private bool GLOKPCKLCDN(float JCJELBAPEMM, float OPOIFNPNEEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4CE1370", Offset = "0x4CE0770", VA = "0x184CE1370")]
		private Dictionary<string, object> AIODJGEBDLN(string IPCFKFOJNLC, Dictionary<string, object> NGDNLNLNCKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5570", Offset = "0x4CE4970", VA = "0x184CE5570")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4CE2990", Offset = "0x4CE1D90", VA = "0x184CE2990")]
		[CompilerGenerated]
		private long EIHHGKJJPHK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4CE4880", Offset = "0x4CE3C80", VA = "0x184CE4880")]
		[CompilerGenerated]
		private void PNHGPGINGBO(int NJAMHDCPIMB)
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
			[Cpp2IlInjected.Address(RVA = "0x558620", Offset = "0x557A20", VA = "0x180558620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4CE59D0", Offset = "0x4CE4DD0", VA = "0x184CE59D0")]
		public static KNAJPNENGOG DDAMABLPPOO(string BNNMAOPHHMC, [NotNull] string IDIJMFIAIOG, long ELPLLNGMKIP, long JFHIPGLODMJ, string OEFANGIGJDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5AB0", Offset = "0x4CE4EB0", VA = "0x184CE5AB0")]
		public static KNAJPNENGOG JMNPJIPDOGJ(string BNNMAOPHHMC, [NotNull] string IDIJMFIAIOG, long ELPLLNGMKIP, long JFHIPGLODMJ, string OEFANGIGJDO, long DBEJIJMLKHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5F60", Offset = "0x4CE5360", VA = "0x184CE5F60")]
		private AmplitudeAnalyticsEvent(string BNNMAOPHHMC, [NotNull] string IDIJMFIAIOG, long ELPLLNGMKIP, long JFHIPGLODMJ, string OEFANGIGJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8FCF00", Offset = "0x8FC300", VA = "0x1808FCF00")]
		public void CNHOFENLLGE(long AHIENHDKBJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5E50", Offset = "0x4CE5250", VA = "0x184CE5E50", Slot = "5")]
		public override void OOBBDANBKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5DE0", Offset = "0x4CE51E0", VA = "0x184CE5DE0", Slot = "6")]
		public override void OILJIIMKIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4CE5BA0", Offset = "0x4CE4FA0", VA = "0x184CE5BA0", Slot = "4")]
		protected override Dictionary<string, object> MNPGKICMFKC(Dictionary<string, object> MLIPGCNDJFL)
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
			[Cpp2IlInjected.Address(RVA = "0x4CE7080", Offset = "0x4CE6480", VA = "0x184CE7080")]
			public void JCGOMGGDFLH(Dictionary<string, object> JIJPHFCGAEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4CEBA90", Offset = "0x4CEAE90", VA = "0x184CEBA90")]
			public void JCGOMGGDFLH(Dictionary<string, object> GHLBBKHLGPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x107BEB0", Offset = "0x107B2B0", VA = "0x18107BEB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x552490", Offset = "0x551890", VA = "0x180552490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4CE6170", Offset = "0x4CE5570", VA = "0x184CE6170")]
		public static DPENKEFJLFL DDAMABLPPOO(string BNNMAOPHHMC, string OEFANGIGJDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4CE6650", Offset = "0x4CE5A50", VA = "0x184CE6650")]
		protected AmplitudeAnalyticsIdentifyMessage(string BNNMAOPHHMC, string OEFANGIGJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4CE6100", Offset = "0x4CE5500", VA = "0x184CE6100")]
		public Dictionary<string, object> AGNIOFIBKPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4CE6280", Offset = "0x4CE5680", VA = "0x184CE6280", Slot = "4")]
		protected virtual Dictionary<string, object> MNPGKICMFKC(Dictionary<string, object> MLIPGCNDJFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4CE65B0", Offset = "0x4CE59B0", VA = "0x184CE65B0")]
		protected void PDOCLHEKKJD(string KACNOLACOBJ, Dictionary<string, object> AEBDAJPHHHD, Dictionary<string, object> GNGFECGLAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4CE6210", Offset = "0x4CE5610", VA = "0x184CE6210")]
		protected void GHCLLBKLKJC(string KACNOLACOBJ, string MGNFAPLJAOB, Dictionary<string, object> IPOFNIBPFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4CE6530", Offset = "0x4CE5930", VA = "0x184CE6530", Slot = "5")]
		public virtual void OOBBDANBKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4CE64C0", Offset = "0x4CE58C0", VA = "0x184CE64C0", Slot = "6")]
		public virtual void OILJIIMKIMA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DPENKEFJLFL : global::BMLLLPAEPAE<AmplitudeAnalyticsIdentifyMessage, DPENKEFJLFL>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override DPENKEFJLFL CCBOMACGAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x607F60", Offset = "0x607360", VA = "0x180607F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KCOGIKIMIAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4CE7030", Offset = "0x4CE6430", VA = "0x184CE7030")]
	public DPENKEFJLFL(AmplitudeAnalyticsIdentifyMessage IOHPBCJMLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4CE6FA0", Offset = "0x4CE63A0", VA = "0x184CE6FA0", Slot = "4")]
	public override void OILJIIMKIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KNAJPNENGOG : global::BMLLLPAEPAE<AmplitudeAnalyticsEvent, KNAJPNENGOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool MHLIDIDNEMD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override KNAJPNENGOG CCBOMACGAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x607F60", Offset = "0x607360", VA = "0x180607F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8440", Offset = "0x4CE7840", VA = "0x184CE8440")]
	public KNAJPNENGOG(AmplitudeAnalyticsEvent IOHPBCJMLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5521D0", Offset = "0x5515D0", VA = "0x1805521D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent KCOGIKIMIAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4CE83A0", Offset = "0x4CE77A0", VA = "0x184CE83A0", Slot = "4")]
	public override void OILJIIMKIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCF70", Offset = "0x1FCC370", VA = "0x181FCCF70")]
	public KNAJPNENGOG LGONNKNBJBL<T>(string NFGIMAMDELO, T[] MGNFAPLJAOB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8390", Offset = "0x4CE7790", VA = "0x184CE8390")]
	public KNAJPNENGOG LGONNKNBJBL(string NFGIMAMDELO, string[] MGNFAPLJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCF00", Offset = "0x1FCC300", VA = "0x181FCCF00")]
	public KNAJPNENGOG LGONNKNBJBL<T>(string NFGIMAMDELO, T MGNFAPLJAOB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8320", Offset = "0x4CE7720", VA = "0x184CE8320")]
	public KNAJPNENGOG LGONNKNBJBL(string NFGIMAMDELO, string MGNFAPLJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8240", Offset = "0x4CE7640", VA = "0x184CE8240")]
	private KNAJPNENGOG ADIMMHIIADJ(string NFGIMAMDELO, object MGNFAPLJAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OCGCAOIIEJM : KNAJPNENGOG
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4CE8440", Offset = "0x4CE7840", VA = "0x184CE8440")]
	public OCGCAOIIEJM(AmplitudeAnalyticsEvent IOHPBCJMLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB250", Offset = "0x4CEA650", VA = "0x184CEB250", Slot = "4")]
	public override void OILJIIMKIMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class BMLLLPAEPAE<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::BMLLLPAEPAE<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M IOHPBCJMLDB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR CCBOMACGAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F3BAC0", Offset = "0x1F3AEC0", VA = "0x181F3BAC0")]
	public BMLLLPAEPAE(M IOHPBCJMLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAAB0", Offset = "0x3BC9EB0", VA = "0x183BCAAB0")]
	public BLDR MKEFCMEHIHF(AmplitudeAnalyticsIdentifyMessage.DeviceInfo MKMHFMJFMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAA00", Offset = "0x3BC9E00", VA = "0x183BCAA00")]
	public BLDR HNIBAMAIGJK(AmplitudeAnalyticsIdentifyMessage.RevenueData INGGKLFDOJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAA40", Offset = "0x3BC9E40", VA = "0x183BCAA40")]
	public BLDR KLFIHGHHBLN(string NFGIMAMDELO, string MGNFAPLJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x21CF300", Offset = "0x21CE700", VA = "0x1821CF300")]
	public BLDR KLFIHGHHBLN<T>(string NFGIMAMDELO, T MGNFAPLJAOB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void OILJIIMKIMA();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BCABD0", Offset = "0x3BC9FD0", VA = "0x183BCABD0")]
	internal static string PGKNOPGGADI(string MGNFAPLJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAAF0", Offset = "0x3BC9EF0", VA = "0x183BCAAF0")]
	private BLDR OKPINPJHPGB(string NFGIMAMDELO, object MGNFAPLJAOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KCOGIKIMIAL();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DEBNAHOIMJI
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string IJMOPKPCDAC = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string DKABNHOLNIJ = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string CPIEBCFHHCG = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string OFIOGKHAHPN = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string PFFLJBPGLDC = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string NABCNKKLGCA = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string FJOIIOKAOLG = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string MDONFDIAINJ = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string OJCABNGNIPB = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string KENKGOMMJOA = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string DGMPGDNNDDF = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string EKDNMJHMIIB = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string DHEDGFDLBOL = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string CMOOIKCBOAC = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string FAGNECFCMCI = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string PNECMEFNEPE = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string LOEGDFAOIPB = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string ICLHEIBJBNL = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string EKADHENCOPH = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string DLOCFIODJPP = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string LMDHJDDMMHD = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string MMACGNPLMDI = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public DEBNAHOIMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CGMCHHJKHLN
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int LLPFGJHDGJD = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int AOHLNGCBMOI = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int KEHIFPGICCM = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long CKEKDBDBGAA = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int ALEPLJLMDPK = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int APJHEPGGIMM = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string EIIGHLCBLNJ = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string JAMEDFFELIJ = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string MDEPMGLCDBE = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string EPHLPLNEGBH = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string AMAADODPKOM = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string FJPGHPMCFDL = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string AMDKJDNIOPI = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string AINPEENDIMK = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string NNNCDGFDAIN = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string KOOCBMDPAJP = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string IINDHNGPCOC = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string IJIEKKMODID = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string LKNIHFKIKMO = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string JEDOMFMEOJP = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string PBKBIIPIMDG = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string IFKGHNOGEBJ = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string MNMIHPBNIGK = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string DNFCCHMGEHJ = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string PFFJLJODBEF = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string BIMFHAFLOPA = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string OCFNJDLCNHG = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string IGEMCAAMDPD = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string MBNJLAEPFEG = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string PLMDNIIHMLG = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string OBFDAKMEGLB = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string CGLBAEBFABK = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string PFFLJBPGLDC = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string GNCBEJGBBAL = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int IJJLECMEHOP = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LBIBFGFPLHC;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4CE6E50", Offset = "0x4CE6250", VA = "0x184CE6E50")]
	internal static bool BDIKDKFGMIJ(string KACNOLACOBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public CGMCHHJKHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OKKCGGJLCDL
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FIJIFBAJMBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string KGNEKAGLGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string FNDHJKCIDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string DNAFLIAENEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string KDIFBIOIEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OIKEDAHIDPO<NJOOFGBKILB> FNGFHIPHGJL(string LOOGHPJGBGF, Dictionary<string, string> AGDLAHIALPN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::OIKEDAHIDPO<NJOOFGBKILB> ABLBHNEPBPH(string LOOGHPJGBGF, string BAOHBFCJBEJ, string FDJIPHFHHIO, string MOBCLKEJCMI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct NJOOFGBKILB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int KLBCEDKJOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string DBODCJEOIII;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x55ACF0", Offset = "0x55A0F0", VA = "0x18055ACF0")]
	public NJOOFGBKILB(int GCFGAAGCJHE, string MKHANIBKCMH)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HAEMGHNAAMP
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] AOHONNKPCGG;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int JJMCEBLKFDI;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int GDGIIBGHMLJ;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger PODBKFNIFLC;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HAEMGHNAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4CE77E0", Offset = "0x4CE6BE0", VA = "0x184CE77E0")]
	private static string BJIMPFHNNLK(byte[] FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4CE78E0", Offset = "0x4CE6CE0", VA = "0x184CE78E0")]
	public static string LFJGIPFBMOM(byte[] MFCIHENGNMD, bool MBOLNOOKBJO)
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
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
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

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
public class JPKKKCOOFLH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string BBJGOAKEOJH = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string OOHNLMOIFBA = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string HOIIDDFHAHA = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string CPOELCOEBJE = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string DKLAPADHEDD = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string BHABLGCLPIE = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string EDFOMKPKFFD = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long IKEBEAKJJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private CAFENPECBMC HKJLHEDJAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool MFCNCAHAOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float FCADNCNJAKA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x575C980", Offset = "0x575B980", VA = "0x18575C980")]
	public JPKKKCOOFLH(string HGMAMKDGNHD, float FCADNCNJAKA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x34817F0", Offset = "0x34807F0", VA = "0x1834817F0")]
	public void DMJHFLJEIKB<T>(string KIMANJPEJBL, T JNLOLNFALGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x575C5E0", Offset = "0x575B5E0", VA = "0x18575C5E0")]
	public void DMJHFLJEIKB(string KIMANJPEJBL, string JNLOLNFALGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x575C760", Offset = "0x575B760", VA = "0x18575C760")]
	public void KJENIAJDNOA(string BNFHJLOGEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x575C6B0", Offset = "0x575B6B0", VA = "0x18575C6B0")]
	public void JDBAKPNACPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x575C880", Offset = "0x575B880", VA = "0x18575C880")]
	private void OAGKLAAJGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x575C660", Offset = "0x575B660", VA = "0x18575C660")]
	private bool GFEKGDJHDEO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OOLBBGDMLCF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIOJNGOAMAG AICHPOAHICB(string FBLLFIIJBAF, string ACEKGMHBELD, [Optional] MOEGPCCLFFG EHLFMJHGINO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIOJNGOAMAG KFIIIEDDPDG(MOEGPCCLFFG EHLFMJHGINO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JGIPLLAPGLI(string MBLDGFPCIAN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PNPJIOOLMPC DCIDNIIGNME(string CGJMNFFAEMA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PNPJIOOLMPC PKJFLKHFOPH(string EAEEGGAHGID);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HIOJNGOAMAG ANMFOAPFLBN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class PJHJMMACOFL : OOLBBGDMLCF
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string AGHCAIOMNGI = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string LCMFBFNDAGJ = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string PMCGMCAKIDJ = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string GPCJMBEPNEM = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string OEDOHGMPKEJ = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string INMCPNPDGAM = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string OCLFJACNBBI = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string KFAMNCBNHAH = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string HEBKMJODIKL = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, EAKEMCGCHGJ> PBDNFJPCPAO;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int BOOFJCLCENH = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool ECNBLBENJFB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	[Preserve]
	public PJHJMMACOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x575E5C0", Offset = "0x575D5C0", VA = "0x18575E5C0")]
	[BHDPALLLPBG(PKIMCINHCCF.Unity_BeforeSceneLoad)]
	private static void PDNNAJEGMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x575D7C0", Offset = "0x575C7C0", VA = "0x18575D7C0", Slot = "4")]
	public HIOJNGOAMAG AICHPOAHICB(string FBLLFIIJBAF, string ACEKGMHBELD, [Optional] MOEGPCCLFFG EHLFMJHGINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x575DBC0", Offset = "0x575CBC0", VA = "0x18575DBC0", Slot = "9")]
	public HIOJNGOAMAG ANMFOAPFLBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x575E050", Offset = "0x575D050", VA = "0x18575E050", Slot = "5")]
	public HIOJNGOAMAG KFIIIEDDPDG(MOEGPCCLFFG EHLFMJHGINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x575DF90", Offset = "0x575CF90", VA = "0x18575DF90", Slot = "6")]
	public bool JGIPLLAPGLI(string MBLDGFPCIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x575DD00", Offset = "0x575CD00", VA = "0x18575DD00", Slot = "7")]
	public PNPJIOOLMPC DCIDNIIGNME(string CGJMNFFAEMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x575E720", Offset = "0x575D720", VA = "0x18575E720", Slot = "8")]
	public PNPJIOOLMPC PKJFLKHFOPH(string EAEEGGAHGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x575E1A0", Offset = "0x575D1A0", VA = "0x18575E1A0")]
	private EBHFPHFOMIC MNDDKPOCOKC(MOEGPCCLFFG EHLFMJHGINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x575DE10", Offset = "0x575CE10", VA = "0x18575DE10")]
	private BKIKAAKAJFL IGEEJJLPLPP(string ACEKGMHBELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x575D5C0", Offset = "0x575C5C0", VA = "0x18575D5C0")]
	private void AABPGCJHECO(string CGJMNFFAEMA, PNPJIOOLMPC BIEIOBCMFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x842D90", Offset = "0x841D90", VA = "0x180842D90")]
	[CompilerGenerated]
	private void ENNBEFBHNJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EOPADAKFMJI
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPKKKCOOFLH NJJNEDJGHLH(string HGMAMKDGNHD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MOEGPCCLFFG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ABOAJINGBHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GCFMNNBEABH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MCHKEGDILHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHANHGNPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? OCJKECBNDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? NKHHKFCBJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int JLEEICENLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string AHCFCFHAMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string HNOILCDLJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string NDAFAJHGDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LMJMKEECHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string NMAFHKFGNPB
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
		public AmplitudeAnalyticsClient.Settings GHCMJHNKGLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PNFOILFFNJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5E5190", Offset = "0x5E4190", VA = "0x1805E5190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum KHNHNOANMHM
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum LDMHPAAAIJN
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class JKADKHOEIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class MNFCLLPBENK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int LGOCJEAMPIL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> KFDJFJEHDPA;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
				public MNFCLLPBENK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class PLEDLJHAHKK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
				public PLEDLJHAHKK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x575E8D0", Offset = "0x575D8D0", VA = "0x18575E8D0")]
				internal bool <GetBatch>b__0(MNFCLLPBENK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string CGIGMGLJDNI = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string LLBPEMIKGCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<MNFCLLPBENK> FNHNGFNLBCO;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? LCIFIKLGBGO
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x575BD40", Offset = "0x575AD40", VA = "0x18575BD40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? HPNEMAIJJJJ
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x575BDD0", Offset = "0x575ADD0", VA = "0x18575BDD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x575C480", Offset = "0x575B480", VA = "0x18575C480")]
			internal JKADKHOEIPJ(string CENHEAPOHPI, string ACEKGMHBELD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x575B9C0", Offset = "0x575A9C0", VA = "0x18575B9C0")]
			public int ICMELFNLBEH([Optional] int? DNCELHAFFMF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x575BFD0", Offset = "0x575AFD0", VA = "0x18575BFD0")]
			public List<Dictionary<string, object>> OGLPNJHBKCC(int JDIIJPEHECO, int? DNCELHAFFMF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x575C2D0", Offset = "0x575B2D0", VA = "0x18575C2D0")]
			public void PBIMJCDFMFI(AmplitudeAnalyticsIdentifyMessage MDAEAKFNGDG, bool DLOPCMALJEK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x575C1D0", Offset = "0x575B1D0", VA = "0x18575C1D0")]
			public void PBIMJCDFMFI(Dictionary<string, object> MDAEAKFNGDG, bool DLOPCMALJEK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x575BE80", Offset = "0x575AE80", VA = "0x18575BE80")]
			public void NGFLGHMEMLD(params Dictionary<string, object>[] PCNHNFCKIFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x575BB20", Offset = "0x575AB20", VA = "0x18575BB20")]
			public void IFMCNKKAMLE(List<Dictionary<string, object>> MGFMLNAKKLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x575C370", Offset = "0x575B370", VA = "0x18575C370")]
			private void PFNMOHMGKOF(Dictionary<string, object> MDAEAKFNGDG, bool DLOPCMALJEK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x575B6A0", Offset = "0x575A6A0", VA = "0x18575B6A0")]
			public void EGEJOIIBNJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x575B2D0", Offset = "0x575A2D0", VA = "0x18575B2D0")]
			private void BGGGDKOEJOM([Optional] string AOPOPCAIAKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x575B890", Offset = "0x575A890", VA = "0x18575B890")]
			private static string HBAFDAKEJAP(string JNLOLNFALGF, string GGLJFLNJABJ)
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
			[Cpp2IlInjected.Address(RVA = "0x575EA50", Offset = "0x575DA50", VA = "0x18575EA50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct HEJCBLJDOII<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int MMGGBBJMKEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string CBFILCMPOPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T HABKNLOAMNL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FHIJGCOCNJF : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private NGOCCMDJJLC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public FHIJGCOCNJF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x575A9F0", Offset = "0x57599F0", VA = "0x18575A9F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x575B0C0", Offset = "0x575A0C0", VA = "0x18575B0C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ADJJPOLDDMH : IEnumerator<object>, IEnumerator, IDisposable
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
			public IHDMPJIPDML quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public ADJJPOLDDMH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5754270", Offset = "0x5753270", VA = "0x185754270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5754360", Offset = "0x5753360", VA = "0x185754360", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class IFJDHILIPKH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public IFJDHILIPKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x575B110", Offset = "0x575A110", VA = "0x18575B110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x575B280", Offset = "0x575A280", VA = "0x18575B280", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ONOHKENCLFM : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private NGOCCMDJJLC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public ONOHKENCLFM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x575D340", Offset = "0x575C340", VA = "0x18575D340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x575D570", Offset = "0x575C570", VA = "0x18575D570", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class LJHFBLCPPMP : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private NGOCCMDJJLC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public LJHFBLCPPMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x575D0B0", Offset = "0x575C0B0", VA = "0x18575D0B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x575D2F0", Offset = "0x575C2F0", VA = "0x18575D2F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KOACLJPMKKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public JKADKHOEIPJ cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
			public KOACLJPMKKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x575CC10", Offset = "0x575BC10", VA = "0x18575CC10")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x575CCB0", Offset = "0x575BCB0", VA = "0x18575CCB0")]
			internal void <FlushFromCache>b__1(HEJCBLJDOII<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class BNFJIDEPIPF : IEnumerator<NGOCCMDJJLC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private NGOCCMDJJLC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public JKADKHOEIPJ cache;

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
			private KOACLJPMKKA <>8__1;

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
			private NGOCCMDJJLC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E51C0", Offset = "0x5E41C0", VA = "0x1805E51C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6F67D0", Offset = "0x6F57D0", VA = "0x1806F67D0")]
			[DebuggerHidden]
			public BNFJIDEPIPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5759750", Offset = "0x5758750", VA = "0x185759750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5759E10", Offset = "0x5758E10", VA = "0x185759E10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class PMHKMOCPPBJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
			public PMHKMOCPPBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x4535350", Offset = "0x4534350", VA = "0x184535350")]
			internal HEJCBLJDOII<T> <PostRudderStackJson>b__0(MHJFJHLGGBM postResponse)
			{
				return default(HEJCBLJDOII<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class BNMGGLFFFEE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1CB3C80", Offset = "0x1CB2C80", VA = "0x181CB3C80")]
			public BNMGGLFFFEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4535350", Offset = "0x4534350", VA = "0x184535350")]
			internal HEJCBLJDOII<T> <PostAmplitudeJson>b__0(MHJFJHLGGBM postResponse)
			{
				return default(HEJCBLJDOII<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DKPHKDPJJDM FIFPCLIGBDD;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string CEAAMOFOKPL = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string AIEFLAGKOHO = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string KIJHLGOGEMO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string MICPMBIAPPB = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string FBBAKJDGLPO = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int BMAHMCNIODF = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int NKNNIMAGBEP = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int AJFBMKFDNNB = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float OKHDJDLHBLM = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long PAMKAMKICAF = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string KFMOADAIKCE = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string JCAJNPACCCC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool CCOAJNIHPHG;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool IOMGHCAPHLN;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int MNBMKAPDHOK;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int OKEBIDLIANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private OPFKIAAJKGL FHICGPEHPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool PPCAEKJGPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float MNJGCDKKJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float CLNLPCNLLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int ONNFIBHMOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int OAFAILDFCGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? LBNEFBEBPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? OIDDFOGDJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long BLNMCGMPNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string BFMPHLBFCCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long NAJDDBMICAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> PILHIBMKMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private LDMHPAAAIJN BPCNOPDFFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int BHOLCKKOFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int CEMIDGMNNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float NHPAOADAIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool PHECLJJJGKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool NNHOIHIJCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JKADKHOEIPJ MODMJHKMPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private JKADKHOEIPJ NFGGPECAFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private JKADKHOEIPJ GBCFEOFLKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FHFHAFELFMG;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DNGJDKDCFLH;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string GAAEEGMKMMF;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string IJDAIBCNKLL = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string GIBMPHFCFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string LHILOJACCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string EPPJABEGPKC;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string CHDNNLIMMLJ = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string JGFFBBIPFIB = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DKPHKDPJJDM FBKJJPGBKDC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5755E70", Offset = "0x5754E70", VA = "0x185755E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int OGNCDJHGKEF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5756170", Offset = "0x5755170", VA = "0x185756170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long DECNLMFJMLH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x57588B0", Offset = "0x57578B0", VA = "0x1857588B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x57589B0", Offset = "0x57579B0", VA = "0x1857589B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string AAILFOPGIBP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5758850", Offset = "0x5757850", VA = "0x185758850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string MGHIGADLEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5758880", Offset = "0x5757880", VA = "0x185758880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string GLFJBDDONOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x609700", Offset = "0x608700", VA = "0x180609700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5F7260", Offset = "0x5F6260", VA = "0x1805F7260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? NKHHKFCBJHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x66E8F0", Offset = "0x66D8F0", VA = "0x18066E8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x107B6F0", Offset = "0x107A6F0", VA = "0x18107B6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KHNHNOANMHM? BAFDNHCHPOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x670AA0", Offset = "0x66FAA0", VA = "0x180670AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x29842E0", Offset = "0x29832E0", VA = "0x1829842E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool EHOJAKMDLNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xBEF250", Offset = "0xBEE250", VA = "0x180BEF250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1955FB0", Offset = "0x1954FB0", VA = "0x181955FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool PPMODLLDOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5758770", Offset = "0x5757770", VA = "0x185758770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> EIOBNELHNAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x57586D0", Offset = "0x57576D0", VA = "0x1857586D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5758910", Offset = "0x5757910", VA = "0x185758910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x57546B0", Offset = "0x57536B0", VA = "0x1857546B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x57569C0", Offset = "0x57559C0", VA = "0x1857569C0")]
		private void HKOKADKBAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x57580F0", Offset = "0x57570F0", VA = "0x1857580F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5757740", Offset = "0x5756740", VA = "0x185757740", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5758270", Offset = "0x5757270", VA = "0x185758270")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x57578D0", Offset = "0x57568D0", VA = "0x1857578D0")]
		public HIOJNGOAMAG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5756EC0", Offset = "0x5755EC0", VA = "0x185756EC0")]
		[IteratorStateMachine(typeof(FHIJGCOCNJF))]
		public IEnumerator<NGOCCMDJJLC> Initialize(AmplitudeAnalyticsEvent CBCCHCINEPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57581C0", Offset = "0x57571C0", VA = "0x1857581C0")]
		public void UpdateLastAliveTime(float CIHMBOMCHIG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x57560B0", Offset = "0x57550B0", VA = "0x1857560B0")]
		private HIOJNGOAMAG FBGBEFJIJCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57554B0", Offset = "0x57544B0", VA = "0x1857554B0")]
		private HIOJNGOAMAG BHPBPHBHBME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5757D80", Offset = "0x5756D80", VA = "0x185757D80")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5756F50", Offset = "0x5755F50", VA = "0x185756F50")]
		[IteratorStateMachine(typeof(ADJJPOLDDMH))]
		private IEnumerator KOGPNOLJEPB(IHDMPJIPDML JCHNABEOOPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x57584D0", Offset = "0x57574D0", VA = "0x1857584D0")]
		[IteratorStateMachine(typeof(IFJDHILIPKH))]
		public IEnumerator WaitForFlush(float HPLFELDFDJB = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5758100", Offset = "0x5757100", VA = "0x185758100")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5756BC0", Offset = "0x5755BC0", VA = "0x185756BC0")]
		public static DJPHDFBCCII Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5754570", Offset = "0x5753570", VA = "0x185754570")]
		public static CAFENPECBMC AccountSelectionPostLoginEvent([NotNull] string PCCMOEFJIED, string LKMFCEJIAMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5755F50", Offset = "0x5754F50", VA = "0x185755F50")]
		public static CAFENPECBMC Event([NotNull] string PCCMOEFJIED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5757950", Offset = "0x5756950", VA = "0x185757950")]
		public static CAFENPECBMC PreviousSessionEvent([NotNull] string PCCMOEFJIED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5756D00", Offset = "0x5755D00", VA = "0x185756D00")]
		public static CAFENPECBMC InitializeEvent(string LKMFCEJIAMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5757E90", Offset = "0x5756E90", VA = "0x185757E90")]
		public static CAFENPECBMC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5755BA0", Offset = "0x5754BA0", VA = "0x185755BA0")]
		public static CAFENPECBMC CreateOutOfSessionEvent(string PCCMOEFJIED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5757190", Offset = "0x5756190", VA = "0x185757190")]
		public static HIOJNGOAMAG LogOutOfSessionEvent(CAFENPECBMC JCOIBCAOMLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5756FE0", Offset = "0x5755FE0", VA = "0x185756FE0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LDHOJEAOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x57574C0", Offset = "0x57564C0", VA = "0x1857574C0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LDHOJEAOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5757590", Offset = "0x5756590", VA = "0x185757590")]
		public void LogSerializedEventAsync(Dictionary<string, object> CHAHMLOKDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x57570B0", Offset = "0x57560B0", VA = "0x1857570B0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LEPOKHMBPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x57556E0", Offset = "0x57546E0", VA = "0x1857556E0")]
		private void BLNJEKNLGDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5756790", Offset = "0x5755790", VA = "0x185756790")]
		private void HGHJHAGKNKM(Dictionary<string, object> EGJIHAFECAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x57577E0", Offset = "0x57567E0", VA = "0x1857577E0")]
		private void PJMNCBJHGIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5756570", Offset = "0x5755570", VA = "0x185756570")]
		private void FNCKIGACIFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5756700", Offset = "0x5755700", VA = "0x185756700")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x57564F0", Offset = "0x57554F0", VA = "0x1857564F0")]
		[IteratorStateMachine(typeof(ONOHKENCLFM))]
		private IEnumerator<NGOCCMDJJLC> FJFMPJMEKID(float HPLFELDFDJB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x57543B0", Offset = "0x57533B0", VA = "0x1857543B0")]
		[IteratorStateMachine(typeof(LJHFBLCPPMP))]
		private IEnumerator<NGOCCMDJJLC> ACAFIJEDGGL(float HPLFELDFDJB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5757660", Offset = "0x5756660", VA = "0x185757660")]
		[IteratorStateMachine(typeof(BNFJIDEPIPF))]
		private IEnumerator<NGOCCMDJJLC> MLFMLOKELDG(JKADKHOEIPJ JNALAKHGIMK, int? DNCELHAFFMF, string CMIAFDGCFCO, string OOKHIAGCDEM, float HPLFELDFDJB, Action<int> MFBCIJLGDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5754430", Offset = "0x5753430", VA = "0x185754430")]
		private static void AJPMJFHPBFO(bool ILMHMCPIECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5755A30", Offset = "0x5754A30", VA = "0x185755A30")]
		private global::LBHHDEJJNHM<HEJCBLJDOII<Dictionary<string, object>>> CPEHNKIOEBL(string CMIAFDGCFCO, string OOKHIAGCDEM, string HDIAMOJOMBH, string HILBFNKBMMJ, Dictionary<string, object> HABKNLOAMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5755790", Offset = "0x5754790", VA = "0x185755790")]
		private global::LBHHDEJJNHM<HEJCBLJDOII<List<Dictionary<string, object>>>> CPEHNKIOEBL(string CMIAFDGCFCO, string OOKHIAGCDEM, string HDIAMOJOMBH, string HILBFNKBMMJ, List<Dictionary<string, object>> HABKNLOAMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8AA0", Offset = "0x1DC7AA0", VA = "0x181DC8AA0")]
		private global::LBHHDEJJNHM<HEJCBLJDOII<T>> PBBPAAGJJLP<T>(string CMIAFDGCFCO, string OOKHIAGCDEM, string HILBFNKBMMJ, T HABKNLOAMNL, Dictionary<string, object> NJAAOLCAMJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1DC87D0", Offset = "0x1DC77D0", VA = "0x181DC87D0")]
		private global::LBHHDEJJNHM<HEJCBLJDOII<T>> LGLCFPEHIPK<T>(string CMIAFDGCFCO, string OOKHIAGCDEM, string HDIAMOJOMBH, T HABKNLOAMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5754520", Offset = "0x5753520", VA = "0x185754520")]
		private bool APDOAOFDHPK(float PNLIKPNCFEJ, float HPLFELDFDJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5754990", Offset = "0x5753990", VA = "0x185754990")]
		private Dictionary<string, object> BHILOAJJAKA(string OOKHIAGCDEM, Dictionary<string, object> HABKNLOAMNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x57585B0", Offset = "0x57575B0", VA = "0x1857585B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5756390", Offset = "0x5755390", VA = "0x185756390")]
		[CompilerGenerated]
		private long FEOFIMGAMJD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5755E60", Offset = "0x5754E60", VA = "0x185755E60")]
		[CompilerGenerated]
		private void EBBFADGHFJG(int PDCOEFIEFIN)
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
			[Cpp2IlInjected.Address(RVA = "0x5EB620", Offset = "0x5EA620", VA = "0x1805EB620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5758DB0", Offset = "0x5757DB0", VA = "0x185758DB0")]
		public static CAFENPECBMC FBMLCAAKPML(string GDLEDDNCPGJ, [NotNull] string NFJBDPGIJIL, long ABCACAOIPAM, long ACLHDGMLKLI, string LKMFCEJIAMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5758CC0", Offset = "0x5757CC0", VA = "0x185758CC0")]
		public static CAFENPECBMC DFFNMIEEAJM(string GDLEDDNCPGJ, [NotNull] string NFJBDPGIJIL, long ABCACAOIPAM, long ACLHDGMLKLI, string LKMFCEJIAMH, long DNAIDNJOBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5758FA0", Offset = "0x5757FA0", VA = "0x185758FA0")]
		private AmplitudeAnalyticsEvent(string GDLEDDNCPGJ, [NotNull] string NFJBDPGIJIL, long ABCACAOIPAM, long ACLHDGMLKLI, string LKMFCEJIAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1510D10", Offset = "0x150FD10", VA = "0x181510D10")]
		public void MLNCHJNCNEP(long AKLBLOHHPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5758E90", Offset = "0x5757E90", VA = "0x185758E90", Slot = "5")]
		public override void HNHKNOELALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5758A10", Offset = "0x5757A10", VA = "0x185758A10", Slot = "6")]
		public override void BDFNINHMFFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5758A80", Offset = "0x5757A80", VA = "0x185758A80", Slot = "4")]
		protected override Dictionary<string, object> BJJLMHMBMDH(Dictionary<string, object> LOFAEEKLAAN)
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
			[Cpp2IlInjected.Address(RVA = "0x575A2E0", Offset = "0x57592E0", VA = "0x18575A2E0")]
			public void HLHEBBOGMDF(Dictionary<string, object> CMMCCBCGMCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x575E930", Offset = "0x575D930", VA = "0x18575E930")]
			public void HLHEBBOGMDF(Dictionary<string, object> ABPHOKLNGCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x1346520", Offset = "0x1345520", VA = "0x181346520")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E5490", Offset = "0x5E4490", VA = "0x1805E5490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5759460", Offset = "0x5758460", VA = "0x185759460")]
		public static DJPHDFBCCII FBMLCAAKPML(string GDLEDDNCPGJ, string LKMFCEJIAMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5759690", Offset = "0x5758690", VA = "0x185759690")]
		protected AmplitudeAnalyticsIdentifyMessage(string GDLEDDNCPGJ, string LKMFCEJIAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5759500", Offset = "0x5758500", VA = "0x185759500")]
		public Dictionary<string, object> HKDNMOHAJDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5759220", Offset = "0x5758220", VA = "0x185759220", Slot = "4")]
		protected virtual Dictionary<string, object> BJJLMHMBMDH(Dictionary<string, object> LOFAEEKLAAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x57595F0", Offset = "0x57585F0", VA = "0x1857595F0")]
		protected void NAPHPFAIBMP(string GGLJFLNJABJ, Dictionary<string, object> AHJPDDBPMIA, Dictionary<string, object> INLCOLNMLLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5759140", Offset = "0x5758140", VA = "0x185759140")]
		protected void APAPGLLNAKE(string GGLJFLNJABJ, string JNLOLNFALGF, Dictionary<string, object> DHPLJKHDDLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5759570", Offset = "0x5758570", VA = "0x185759570", Slot = "5")]
		public virtual void HNHKNOELALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x57591B0", Offset = "0x57581B0", VA = "0x1857591B0", Slot = "6")]
		public virtual void BDFNINHMFFK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DJPHDFBCCII : global::PMNGOILHNIM<AmplitudeAnalyticsIdentifyMessage, DJPHDFBCCII>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override DJPHDFBCCII JJHBLENGBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69AF60", Offset = "0x699F60", VA = "0x18069AF60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PGODPJEKMDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x575A140", Offset = "0x5759140", VA = "0x18575A140")]
	public DJPHDFBCCII(AmplitudeAnalyticsIdentifyMessage LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x575A0B0", Offset = "0x57590B0", VA = "0x18575A0B0", Slot = "4")]
	public override void BDFNINHMFFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CAFENPECBMC : global::PMNGOILHNIM<AmplitudeAnalyticsEvent, CAFENPECBMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool IDCGKHLLLEE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override CAFENPECBMC JJHBLENGBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x69AF60", Offset = "0x699F60", VA = "0x18069AF60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x575A060", Offset = "0x5759060", VA = "0x18575A060")]
	public CAFENPECBMC(AmplitudeAnalyticsEvent LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E51D0", Offset = "0x5E41D0", VA = "0x1805E51D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent PGODPJEKMDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5759E60", Offset = "0x5758E60", VA = "0x185759E60", Slot = "4")]
	public override void BDFNINHMFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x23780A0", Offset = "0x23770A0", VA = "0x1823780A0")]
	public CAFENPECBMC DMJHFLJEIKB<T>(string KIMANJPEJBL, T[] JNLOLNFALGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5759FE0", Offset = "0x5758FE0", VA = "0x185759FE0")]
	public CAFENPECBMC DMJHFLJEIKB(string KIMANJPEJBL, string[] JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2378030", Offset = "0x2377030", VA = "0x182378030")]
	public CAFENPECBMC DMJHFLJEIKB<T>(string KIMANJPEJBL, T JNLOLNFALGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5759FF0", Offset = "0x5758FF0", VA = "0x185759FF0")]
	public CAFENPECBMC DMJHFLJEIKB(string KIMANJPEJBL, string JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5759F00", Offset = "0x5758F00", VA = "0x185759F00")]
	private CAFENPECBMC BLBEOFGKHGN(string KIMANJPEJBL, object JNLOLNFALGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KMDMMEKPNHB : CAFENPECBMC
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x575A060", Offset = "0x5759060", VA = "0x18575A060")]
	public KMDMMEKPNHB(AmplitudeAnalyticsEvent LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x575CAE0", Offset = "0x575BAE0", VA = "0x18575CAE0", Slot = "4")]
	public override void BDFNINHMFFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class PMNGOILHNIM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::PMNGOILHNIM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M LPDLECBMBMG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR JJHBLENGBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2178DB0", Offset = "0x2177DB0", VA = "0x182178DB0")]
	public PMNGOILHNIM(M LPDLECBMBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x30C99B0", Offset = "0x30C89B0", VA = "0x1830C99B0")]
	public BLDR CKJIAGGCLMB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo DJJMNMCMLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x30C9970", Offset = "0x30C8970", VA = "0x1830C9970")]
	public BLDR BEIAGNIDHAO(AmplitudeAnalyticsIdentifyMessage.RevenueData HCLBMOCKBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x30C9B00", Offset = "0x30C8B00", VA = "0x1830C9B00")]
	public BLDR JCNPEJIFLAD(string KIMANJPEJBL, string JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2387B30", Offset = "0x2386B30", VA = "0x182387B30")]
	public BLDR JCNPEJIFLAD<T>(string KIMANJPEJBL, T JNLOLNFALGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BDFNINHMFFK();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x30C99F0", Offset = "0x30C89F0", VA = "0x1830C99F0")]
	internal static string FBPNOBBELJC(string JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x30C9A20", Offset = "0x30C8A20", VA = "0x1830C9A20")]
	private BLDR FKEIMFDICJP(string KIMANJPEJBL, object JNLOLNFALGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PGODPJEKMDO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JMCJDJGOFGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string AIDLCLBFLAI = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string AJFKABNFMGI = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string JLIPOLAJLME = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string JGLEOCJJIMP = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string ALGFIAFHCGF = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string EOJILGLCPIG = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string EHOBEIEHOLD = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string PBIGMFFCOOF = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string HLJBFDFOFII = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string NBKFIDKINAH = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string OKGCKFGFBMB = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string JKNOAJIMBLP = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string MBBHNIPLCME = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string ACKEGHNAKBP = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string JEEIKBJCFIJ = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string PCDNGCLHILJ = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string NJJMDEKIEEJ = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string NGODEJOHFBE = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string KEFNCBDDONG = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string ALIHHCDGCIN = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string LJJJGNDMMNA = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string DGMIIIGEDNK = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public JMCJDJGOFGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DMBBMKILHAF
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int FBKAOHIJEAG = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int DEFCDDKBNDB = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int JBFDMBHNDAO = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long GNMOKIMMBCC = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int HAMCAFABBID = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int BICBCJNABGI = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string IFIJMABNICA = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string OONNDIDHJCG = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string NDOCOEIAIPO = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string ADCJANOFJML = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string KEKCCOFBMAE = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string EJEMMFFFOCJ = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string HPFGEEILNBM = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string LMBLHKCJCFN = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string ICIMGMKFBPE = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string COBCLGPBDBN = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string AIDJANDJIFF = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string IALOPPCJGDI = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string GLIPOEAMIAD = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string NBNCEMNFFHD = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string LBFNGNHFHEJ = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string APJHEEECBPC = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string FOKFPGGEMEG = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string FJIKLMDPLGB = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string NAFOMEGPEAI = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string NPIHAHKNMMJ = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string KDCJKMBHJBD = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string NLAIFDKAGGB = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string HMCKKLLDKEJ = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string BJNHEOCLKCH = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string BFNHFLKIKBA = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string JFLDAGMJCBI = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string ALGFIAFHCGF = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string JMKKKOPJKBE = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int NJHEFPAFDMA = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JDKHFLNOIDO;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x575A190", Offset = "0x5759190", VA = "0x18575A190")]
	internal static bool IJGGCMEHECA(string GGLJFLNJABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public DMBBMKILHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OPFKIAAJKGL
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool CIIHJLMCHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string EDBPLIMEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string ANJHKFDNINK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string ANLPNLHAFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string JMHGKPEMKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::LBHHDEJJNHM<MHJFJHLGGBM> CPEHNKIOEBL(string CMIAFDGCFCO, Dictionary<string, string> MMMKGBBAAOJ);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::LBHHDEJJNHM<MHJFJHLGGBM> BAKJBKHEGAH(string CMIAFDGCFCO, string JLGHGIEFAKD, string FIPIPACOEEG, string HJDGNJDIBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MHJFJHLGGBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int GOGEJFMBILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string HAPAPLOJEEB;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCF0", Offset = "0x5ECCF0", VA = "0x1805EDCF0")]
	public MHJFJHLGGBM(int MMGGBBJMKEI, string CBFILCMPOPC)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x575A400", Offset = "0x5759400", VA = "0x18575A400")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x575A500", Offset = "0x5759500", VA = "0x18575A500")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
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
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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

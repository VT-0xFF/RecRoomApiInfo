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
public class HBLMGKDMMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string JIPGKLIFMJP = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string AHEFICHEGPJ = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string HLMBEIAPKCB = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string ODJMJJMCHJG = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string NNCDPGBOKDM = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string PNFDOOGODKF = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string ECLNPMAKEMK = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long CCLGFADMAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private AKNBLHNGGJF MKIDPHIHLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool PLAGABNFJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float EDLOIDKDILP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E230", Offset = "0x4D6CE30", VA = "0x184D6E230")]
	public HBLMGKDMMGO(string ALDHPCGHFEO, float EDLOIDKDILP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2440280", Offset = "0x243EE80", VA = "0x182440280")]
	public void OJHEHJCFJIM<T>(string AKJHGOKOPOG, T ODCJDJDBONO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E1B0", Offset = "0x4D6CDB0", VA = "0x184D6E1B0")]
	public void OJHEHJCFJIM(string AKJHGOKOPOG, string ODCJDJDBONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E090", Offset = "0x4D6CC90", VA = "0x184D6E090")]
	public void JLKMMKBEICK(string ELFPOJMENMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4D6DF90", Offset = "0x4D6CB90", VA = "0x184D6DF90")]
	public void ECBOMBBKALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4D6DE90", Offset = "0x4D6CA90", VA = "0x184D6DE90")]
	private void BNFLOPDMLGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E040", Offset = "0x4D6CC40", VA = "0x184D6E040")]
	private bool EILOMCALIKN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EAHMLFPAPKP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBKKHCFLPCB JIBFOCILIBI(string KLHGBJEMDIL, string NMCAABPBNGD, [Optional] JOEDMOOBNJL MDFKKIOABNH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OBKKHCFLPCB JJNPNMFCOLD(JOEDMOOBNJL MDFKKIOABNH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HHEGANMMGJH(string PHJDIBJIBFH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DMFACDMKIAP JKAICBIHAPJ(string ENKIEKMAEJH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DMFACDMKIAP DEFMHNOGGNK(string CPJPLJGCIME);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OBKKHCFLPCB BOJMJKNHCGI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CPPJNEIGAPM : EAHMLFPAPKP
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string AMHDMFJELFL = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string IFDOJNLALFL = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string IAKEIFFOJCG = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string DPFBJGCKLFE = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string MLDELBKINMD = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string CEBPBNDFFNJ = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string PICHEEOIJNJ = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string LDPEFDEKCIN = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string CPDAJJBKKEB = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, NJKHKPJIBMG> MLLELEJDGPK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int JOAMLADKACL = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool BCOIKIIPOKP;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	[Preserve]
	public CPPJNEIGAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D6D070", Offset = "0x4D6BC70", VA = "0x184D6D070")]
	[NMAFIJJCKPG(LEMEFCIKAHM.Unity_BeforeSceneLoad)]
	private static void JMFGCJBKFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D6CA10", Offset = "0x4D6B610", VA = "0x184D6CA10", Slot = "4")]
	public OBKKHCFLPCB JIBFOCILIBI(string KLHGBJEMDIL, string NMCAABPBNGD, [Optional] JOEDMOOBNJL MDFKKIOABNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C520", Offset = "0x4D6B120", VA = "0x184D6C520", Slot = "9")]
	public OBKKHCFLPCB BOJMJKNHCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D6CE10", Offset = "0x4D6BA10", VA = "0x184D6CE10", Slot = "5")]
	public OBKKHCFLPCB JJNPNMFCOLD(JOEDMOOBNJL MDFKKIOABNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C950", Offset = "0x4D6B550", VA = "0x184D6C950", Slot = "6")]
	public bool HHEGANMMGJH(string PHJDIBJIBFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4D6CF60", Offset = "0x4D6BB60", VA = "0x184D6CF60", Slot = "7")]
	public DMFACDMKIAP JKAICBIHAPJ(string ENKIEKMAEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C660", Offset = "0x4D6B260", VA = "0x184D6C660", Slot = "8")]
	public DMFACDMKIAP DEFMHNOGGNK(string CPJPLJGCIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D6D1D0", Offset = "0x4D6BDD0", VA = "0x184D6D1D0")]
	private DDADDPEPBKF LBBEEHKNPGM(JOEDMOOBNJL MDFKKIOABNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C3A0", Offset = "0x4D6AFA0", VA = "0x184D6C3A0")]
	private MGLKGHCBIEN BKGLFBMMKMO(string NMCAABPBNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C750", Offset = "0x4D6B350", VA = "0x184D6C750")]
	private void DFPJCFHMIIA(string ENKIEKMAEJH, DMFACDMKIAP HANIBKNDEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C56E0", Offset = "0x6C42E0", VA = "0x1806C56E0")]
	[CompilerGenerated]
	private void CCIPPNEBMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OLKICBMGIBO
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBLMGKDMMGO KKICOOLGEEK(string ALDHPCGHFEO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JOEDMOOBNJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NLFMJMNALPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CCPMJKPMHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DIANAIGJJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PGIKMCIHJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? JPPMGCPHHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? FFDCDHKMAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LIONKMBDCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string PIOPJDGJKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string JBEGJFEJGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string EBPFPHOCEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string AGGOKPIALIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string PBJKOOAHDOM
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
		public AmplitudeAnalyticsClient.Settings ACBJDHNDHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GDLCGIJFJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x55C190", Offset = "0x55AD90", VA = "0x18055C190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum JIJNMJPMIEB
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum FEHIFJHGIKF
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class LHEFMNKLOOD
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class CMDANKOPAAL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int FHLOGKPGBDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> PFNHEIAFCFO;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
				public CMDANKOPAAL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class HHBHJAKNPFK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
				public HHBHJAKNPFK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x4D6E390", Offset = "0x4D6CF90", VA = "0x184D6E390")]
				internal bool <GetBatch>b__0(CMDANKOPAAL item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string APBBDKHIANI = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string PCINFLBBPEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<CMDANKOPAAL> POGDOEADCJC;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? PGMBHNCHFBK
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x4D6FAB0", Offset = "0x4D6E6B0", VA = "0x184D6FAB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? OMJGINGADPK
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x4D6F3F0", Offset = "0x4D6DFF0", VA = "0x184D6F3F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4D70400", Offset = "0x4D6F000", VA = "0x184D70400")]
			internal LHEFMNKLOOD(string KAODCPDIIFC, string NMCAABPBNGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4D6FB40", Offset = "0x4D6E740", VA = "0x184D6FB40")]
			public int GMOABECGPAN([Optional] int? JCDPJIDHFHC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4D70200", Offset = "0x4D6EE00", VA = "0x184D70200")]
			public List<Dictionary<string, object>> NPJFDBJKGEG(int OMNNPMLEKFL, int? JCDPJIDHFHC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F350", Offset = "0x4D6DF50", VA = "0x184D6F350")]
			public void AGBLLOOLNDJ(AmplitudeAnalyticsIdentifyMessage NJBMHJCLPCJ, bool NNIHPNIBDIP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F250", Offset = "0x4D6DE50", VA = "0x184D6F250")]
			public void AGBLLOOLNDJ(Dictionary<string, object> NJBMHJCLPCJ, bool NNIHPNIBDIP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4D700B0", Offset = "0x4D6ECB0", VA = "0x184D700B0")]
			public void MAHJJCOLLGL(params Dictionary<string, object>[] BNECECPGEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4D6FCA0", Offset = "0x4D6E8A0", VA = "0x184D6FCA0")]
			public void JIOGJCABIDG(List<Dictionary<string, object>> EBAJFBJMGPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F9A0", Offset = "0x4D6E5A0", VA = "0x184D6F9A0")]
			private void FBDJHFDEGBJ(Dictionary<string, object> NJBMHJCLPCJ, bool NNIHPNIBDIP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4D6FEC0", Offset = "0x4D6EAC0", VA = "0x184D6FEC0")]
			public void KECLLLIBGKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F4A0", Offset = "0x4D6E0A0", VA = "0x184D6F4A0")]
			private void EHNHHGIMEIN([Optional] string OBPJEPMLOAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F870", Offset = "0x4D6E470", VA = "0x184D6F870")]
			private static string EHNJBKKPGLC(string ODCJDJDBONO, string OMAJLLKKGPH)
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
			[Cpp2IlInjected.Address(RVA = "0x4D71150", Offset = "0x4D6FD50", VA = "0x184D71150")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct LAJCACJICBH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int FGGJLHCCBIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string FHIGKFEKMOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T KCJEDDGLLDK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class LFNLAEHHGDA : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private EPJBAFONDLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public LFNLAEHHGDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4D6EB30", Offset = "0x4D6D730", VA = "0x184D6EB30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4D6F200", Offset = "0x4D6DE00", VA = "0x184D6F200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GNGFBBKBKHI : IEnumerator<object>, IEnumerator, IDisposable
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
			public KOCFEPMOONC quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public GNGFBBKBKHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4D6DD50", Offset = "0x4D6C950", VA = "0x184D6DD50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4D6DE40", Offset = "0x4D6CA40", VA = "0x184D6DE40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ADHNJLKEMOG : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public ADHNJLKEMOG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4D66970", Offset = "0x4D65570", VA = "0x184D66970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4D66AE0", Offset = "0x4D656E0", VA = "0x184D66AE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ALALJHJLIFG : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private EPJBAFONDLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public ALALJHJLIFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4D66D80", Offset = "0x4D65980", VA = "0x184D66D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4D66FB0", Offset = "0x4D65BB0", VA = "0x184D66FB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class NMPPDJGCNMM : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private EPJBAFONDLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public NMPPDJGCNMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4D70DA0", Offset = "0x4D6F9A0", VA = "0x184D70DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x4D70FE0", Offset = "0x4D6FBE0", VA = "0x184D70FE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FHKLMNGKMCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public LHEFMNKLOOD cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public FHKLMNGKMCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4D6D7D0", Offset = "0x4D6C3D0", VA = "0x184D6D7D0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4D6D870", Offset = "0x4D6C470", VA = "0x184D6D870")]
			internal void <FlushFromCache>b__1(LAJCACJICBH<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class MJPCIAHNPDG : IEnumerator<EPJBAFONDLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private EPJBAFONDLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public LHEFMNKLOOD cache;

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
			private FHKLMNGKMCF <>8__1;

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
			private EPJBAFONDLI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x55C1C0", Offset = "0x55ADC0", VA = "0x18055C1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x66D7D0", Offset = "0x66C3D0", VA = "0x18066D7D0")]
			[DebuggerHidden]
			public MJPCIAHNPDG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4D70690", Offset = "0x4D6F290", VA = "0x184D70690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4D70D50", Offset = "0x4D6F950", VA = "0x184D70D50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KAGHJDPNNHL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
			public KAGHJDPNNHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2AC58B0", Offset = "0x2AC44B0", VA = "0x182AC58B0")]
			internal LAJCACJICBH<T> <PostRudderStackJson>b__0(AOHAFDKKDJG postResponse)
			{
				return default(LAJCACJICBH<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class POLPMNBBEJP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1CFDDC0", Offset = "0x1CFC9C0", VA = "0x181CFDDC0")]
			public POLPMNBBEJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2AC58B0", Offset = "0x2AC44B0", VA = "0x182AC58B0")]
			internal LAJCACJICBH<T> <PostAmplitudeJson>b__0(AOHAFDKKDJG postResponse)
			{
				return default(LAJCACJICBH<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HALNODJDIFM GPEJMMJABIO;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string JAPCHMHEENF = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string KCJIOBNKBBC = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string APHDBDKNOCD = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string HOEKFANKMFH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string KGOOCMHJMLG = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int GDFPNMAMIAO = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int PINBHBCBLFG = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int KCCHBELEGCB = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float IMNPAOGEEBK = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long IDKPLIJDBHI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string OOLKNGBKAOF = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string PJEEFJILFPE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool NLHJFGGHOCI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool PLHDAMCOJFM;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int AMOABKFPDMC;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int MIACIBIHLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private LBMPIFDCDME ONAONNGMEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool FEPBIEMLBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float IIONBAPDANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float MEKPHNDBMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int IGAEGPFCECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int PFPKNMFCIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? KGGNJGDCKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? MHEAONJPOFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long OLONJAKJALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string MEOFDFFPIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long BOIAPOGMPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> DIPMECFOFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private FEHIFJHGIKF DMHCHKOADGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int MLHCOJEFCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int NAOLMMPBNIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float EMKAEGGDDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool HCEMDADGLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool DANFPKIPCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LHEFMNKLOOD GLIHDBDDJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LHEFMNKLOOD PKHAOKIKBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LHEFMNKLOOD IFCPKAHKGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CFIGGBKFBJE;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NFOPAMKDPJD;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string OINOBJFMPGN;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string KLIPNJJEECN = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string PPEBHAEPPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string PNCHFBAHIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string NGBNKBGLFOP;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string ABICGHAJFFC = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string MKJNNCGHKHM = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private HALNODJDIFM CKILFLOPBEL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4D68D70", Offset = "0x4D67970", VA = "0x184D68D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int JKNKMDKGKDL
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4D69A40", Offset = "0x4D68640", VA = "0x184D69A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long NOGCDJKAFHI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B500", Offset = "0x4D6A100", VA = "0x184D6B500")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B600", Offset = "0x4D6A200", VA = "0x184D6B600")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string INGBJGBBIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B4A0", Offset = "0x4D6A0A0", VA = "0x184D6B4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string BJAPJHLKECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B4D0", Offset = "0x4D6A0D0", VA = "0x184D6B4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string CONGFKCPMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x580700", Offset = "0x57F300", VA = "0x180580700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x56E260", Offset = "0x56CE60", VA = "0x18056E260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? FFDCDHKMAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5E58F0", Offset = "0x5E44F0", VA = "0x1805E58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x11BF810", Offset = "0x11BE410", VA = "0x1811BF810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JIJNMJPMIEB? ELIKFDDHAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AA0", Offset = "0x5E66A0", VA = "0x1805E7AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x245A3A0", Offset = "0x2458FA0", VA = "0x18245A3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool OHNLNEFKKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA4210", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xE9B440", Offset = "0xE9A040", VA = "0x180E9B440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool OPIDABEGGHP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B3C0", Offset = "0x4D69FC0", VA = "0x184D6B3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PBBAPCCJHMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B320", Offset = "0x4D69F20", VA = "0x184D6B320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4D6B560", Offset = "0x4D6A160", VA = "0x184D6B560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D67C70", Offset = "0x4D66870", VA = "0x184D67C70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D68E50", Offset = "0x4D67A50", VA = "0x184D68E50")]
		private void HBHLGOCHCMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D6AD40", Offset = "0x4D69940", VA = "0x184D6AD40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A3D0", Offset = "0x4D68FD0", VA = "0x184D6A3D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D6AEC0", Offset = "0x4D69AC0", VA = "0x184D6AEC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A520", Offset = "0x4D69120", VA = "0x184D6A520")]
		public OBKKHCFLPCB PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D696F0", Offset = "0x4D682F0", VA = "0x184D696F0")]
		[IteratorStateMachine(typeof(LFNLAEHHGDA))]
		public IEnumerator<EPJBAFONDLI> Initialize(AmplitudeAnalyticsEvent OJODLPOEPCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D6AE10", Offset = "0x4D69A10", VA = "0x184D6AE10")]
		public void UpdateLastAliveTime(float EPGPPMJAFDF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D67F50", Offset = "0x4D66B50", VA = "0x184D67F50")]
		private OBKKHCFLPCB BDNHEHMMMBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D69780", Offset = "0x4D68380", VA = "0x184D69780")]
		private OBKKHCFLPCB JELMNGCKIPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A9D0", Offset = "0x4D695D0", VA = "0x184D6A9D0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D699B0", Offset = "0x4D685B0", VA = "0x184D699B0")]
		[IteratorStateMachine(typeof(GNGFBBKBKHI))]
		private IEnumerator KEDMFAFAKFH(KOCFEPMOONC CHIEKGAEGFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B120", Offset = "0x4D69D20", VA = "0x184D6B120")]
		[IteratorStateMachine(typeof(ADHNJLKEMOG))]
		public IEnumerator WaitForFlush(float COIACHHEFBM = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4D6AD50", Offset = "0x4D69950", VA = "0x184D6AD50")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4D693F0", Offset = "0x4D67FF0", VA = "0x184D693F0")]
		public static GDIMOHDCMPG Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D67B30", Offset = "0x4D66730", VA = "0x184D67B30")]
		public static AKNBLHNGGJF AccountSelectionPostLoginEvent([NotNull] string JDDOJOLEEAI, string OLHJCLJJFFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4D68B30", Offset = "0x4D67730", VA = "0x184D68B30")]
		public static AKNBLHNGGJF Event([NotNull] string JDDOJOLEEAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A5A0", Offset = "0x4D691A0", VA = "0x184D6A5A0")]
		public static AKNBLHNGGJF PreviousSessionEvent([NotNull] string JDDOJOLEEAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4D69530", Offset = "0x4D68130", VA = "0x184D69530")]
		public static AKNBLHNGGJF InitializeEvent(string OLHJCLJJFFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4D6AAE0", Offset = "0x4D696E0", VA = "0x184D6AAE0")]
		public static AKNBLHNGGJF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4D681A0", Offset = "0x4D66DA0", VA = "0x184D681A0")]
		public static AKNBLHNGGJF CreateOutOfSessionEvent(string JDDOJOLEEAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4D69E10", Offset = "0x4D68A10", VA = "0x184D69E10")]
		public static OBKKHCFLPCB LogOutOfSessionEvent(AKNBLHNGGJF JANPBBALCEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D69C60", Offset = "0x4D68860", VA = "0x184D69C60")]
		public void LogEventAsync(AmplitudeAnalyticsEvent AIFOGJBLAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A140", Offset = "0x4D68D40", VA = "0x184D6A140")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent AIFOGJBLAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A210", Offset = "0x4D68E10", VA = "0x184D6A210")]
		public void LogSerializedEventAsync(Dictionary<string, object> BPKOIDDOLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4D69D30", Offset = "0x4D68930", VA = "0x184D69D30")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BBMHKDACDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A470", Offset = "0x4D69070", VA = "0x184D6A470")]
		private void PBLIFGGBNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4D69140", Offset = "0x4D67D40", VA = "0x184D69140")]
		private void IBCKCAGIEKJ(Dictionary<string, object> AILHBGEMHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4D6A2E0", Offset = "0x4D68EE0", VA = "0x184D6A2E0")]
		private void NNMIGEKELLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4D68010", Offset = "0x4D66C10", VA = "0x184D68010")]
		private void CECGKDANDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4D68CE0", Offset = "0x4D678E0", VA = "0x184D68CE0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4D68460", Offset = "0x4D67060", VA = "0x184D68460")]
		[IteratorStateMachine(typeof(ALALJHJLIFG))]
		private IEnumerator<EPJBAFONDLI> DDAOALDPHED(float COIACHHEFBM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4D69370", Offset = "0x4D67F70", VA = "0x184D69370")]
		[IteratorStateMachine(typeof(NMPPDJGCNMM))]
		private IEnumerator<EPJBAFONDLI> IHEPKPKCJLD(float COIACHHEFBM = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4D68A50", Offset = "0x4D67650", VA = "0x184D68A50")]
		[IteratorStateMachine(typeof(MJPCIAHNPDG))]
		private IEnumerator<EPJBAFONDLI> DMLNDJCBFBP(LHEFMNKLOOD EGCLPNLNKMO, int? JCDPJIDHFHC, string DCIIAGMGEPA, string MMCAIDCPECG, float COIACHHEFBM, Action<int> ELNBHLMNCMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4D69050", Offset = "0x4D67C50", VA = "0x184D69050")]
		private static void HPFPIGMCMJE(bool OBEIMKHNDEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4D68640", Offset = "0x4D67240", VA = "0x184D68640")]
		private global::KKLFNGHEAIK<LAJCACJICBH<Dictionary<string, object>>> DFGAJOAMKFP(string DCIIAGMGEPA, string MMCAIDCPECG, string BBMHELOFIOA, string HMNNAMKHCHG, Dictionary<string, object> KCJEDDGLLDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4D687B0", Offset = "0x4D673B0", VA = "0x184D687B0")]
		private global::KKLFNGHEAIK<LAJCACJICBH<List<Dictionary<string, object>>>> DFGAJOAMKFP(string DCIIAGMGEPA, string MMCAIDCPECG, string BBMHELOFIOA, string HMNNAMKHCHG, List<Dictionary<string, object>> KCJEDDGLLDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB210", Offset = "0x1CC9E10", VA = "0x181CCB210")]
		private global::KKLFNGHEAIK<LAJCACJICBH<T>> FJIJIEOPEGA<T>(string DCIIAGMGEPA, string MMCAIDCPECG, string HMNNAMKHCHG, T KCJEDDGLLDK, Dictionary<string, object> HNJMGGODENG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1CCAF40", Offset = "0x1CC9B40", VA = "0x181CCAF40")]
		private global::KKLFNGHEAIK<LAJCACJICBH<T>> EPBKABEIEFB<T>(string DCIIAGMGEPA, string MMCAIDCPECG, string BBMHELOFIOA, T KCJEDDGLLDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4D68C90", Offset = "0x4D67890", VA = "0x184D68C90")]
		private bool FCNMLEHJOFP(float NFNLHAEHMAI, float COIACHHEFBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4D67000", Offset = "0x4D65C00", VA = "0x184D67000")]
		private Dictionary<string, object> ADMOOLJJANA(string MMCAIDCPECG, Dictionary<string, object> KCJEDDGLLDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B200", Offset = "0x4D69E00", VA = "0x184D6B200")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4D684E0", Offset = "0x4D670E0", VA = "0x184D684E0")]
		[CompilerGenerated]
		private long DEPIDMGKECH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4D67B20", Offset = "0x4D66720", VA = "0x184D67B20")]
		[CompilerGenerated]
		private void AMCHFEHOJFH(int GBOJGMFMLCE)
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
			[Cpp2IlInjected.Address(RVA = "0x562620", Offset = "0x561220", VA = "0x180562620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4D6BB10", Offset = "0x4D6A710", VA = "0x184D6BB10")]
		public static AKNBLHNGGJF KGHLJHHMDNN(string BEDKPKPHEKA, [NotNull] string FFPJLCHKDFN, long MNHFPAPBIIG, long GPCOFFKHPJO, string OLHJCLJJFFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D6BA20", Offset = "0x4D6A620", VA = "0x184D6BA20")]
		public static AKNBLHNGGJF EBGADLJCOBH(string BEDKPKPHEKA, [NotNull] string FFPJLCHKDFN, long MNHFPAPBIIG, long GPCOFFKHPJO, string OLHJCLJJFFE, long JFJKHNBJPMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4D6BBF0", Offset = "0x4D6A7F0", VA = "0x184D6BBF0")]
		private AmplitudeAnalyticsEvent(string BEDKPKPHEKA, [NotNull] string FFPJLCHKDFN, long MNHFPAPBIIG, long GPCOFFKHPJO, string OLHJCLJJFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x86B920", Offset = "0x86A520", VA = "0x18086B920")]
		public void BGCEJMHMNKL(long APKMLELIJLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B910", Offset = "0x4D6A510", VA = "0x184D6B910", Slot = "5")]
		public override void DKDPILLPCMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B660", Offset = "0x4D6A260", VA = "0x184D6B660", Slot = "6")]
		public override void ADPMHGBHLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4D6B6D0", Offset = "0x4D6A2D0", VA = "0x184D6B6D0", Slot = "4")]
		protected override Dictionary<string, object> BHKBJMEICLC(Dictionary<string, object> EKEPAGMFDAE)
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
			[Cpp2IlInjected.Address(RVA = "0x4D6D6B0", Offset = "0x4D6C2B0", VA = "0x184D6D6B0")]
			public void MFGIPILDMLA(Dictionary<string, object> ECLNOOFIFBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D71030", Offset = "0x4D6FC30", VA = "0x184D71030")]
			public void MFGIPILDMLA(Dictionary<string, object> NKIDJFFOACB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x11633E0", Offset = "0x1161FE0", VA = "0x1811633E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x55C490", Offset = "0x55B090", VA = "0x18055C490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C1D0", Offset = "0x4D6ADD0", VA = "0x184D6C1D0")]
		public static GDIMOHDCMPG KGHLJHHMDNN(string BEDKPKPHEKA, string OLHJCLJJFFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C2E0", Offset = "0x4D6AEE0", VA = "0x184D6C2E0")]
		protected AmplitudeAnalyticsIdentifyMessage(string BEDKPKPHEKA, string OLHJCLJJFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C040", Offset = "0x4D6AC40", VA = "0x184D6C040")]
		public Dictionary<string, object> DBEFLODPLIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4D6BE00", Offset = "0x4D6AA00", VA = "0x184D6BE00", Slot = "4")]
		protected virtual Dictionary<string, object> BHKBJMEICLC(Dictionary<string, object> EKEPAGMFDAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C130", Offset = "0x4D6AD30", VA = "0x184D6C130")]
		protected void JFDKMNEPNPG(string OMAJLLKKGPH, Dictionary<string, object> KCFKCEADEHI, Dictionary<string, object> HAHJIMNJIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C270", Offset = "0x4D6AE70", VA = "0x184D6C270")]
		protected void PEDLPMGMBEM(string OMAJLLKKGPH, string ODCJDJDBONO, Dictionary<string, object> ICHMIPGEILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4D6C0B0", Offset = "0x4D6ACB0", VA = "0x184D6C0B0", Slot = "5")]
		public virtual void DKDPILLPCMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4D6BD90", Offset = "0x4D6A990", VA = "0x184D6BD90", Slot = "6")]
		public virtual void ADPMHGBHLJC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class GDIMOHDCMPG : global::OGLHABAJOCE<AmplitudeAnalyticsIdentifyMessage, GDIMOHDCMPG>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override GDIMOHDCMPG NHDKILPEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x611F60", Offset = "0x610B60", VA = "0x180611F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage FPBLLOLACHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D6DD00", Offset = "0x4D6C900", VA = "0x184D6DD00")]
	public GDIMOHDCMPG(AmplitudeAnalyticsIdentifyMessage PFLCCLDEBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4D6DC70", Offset = "0x4D6C870", VA = "0x184D6DC70", Slot = "4")]
	public override void ADPMHGBHLJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class AKNBLHNGGJF : global::OGLHABAJOCE<AmplitudeAnalyticsEvent, AKNBLHNGGJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool DLJHFDPCBDE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override AKNBLHNGGJF NHDKILPEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x611F60", Offset = "0x610B60", VA = "0x180611F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4D66D30", Offset = "0x4D65930", VA = "0x184D66D30")]
	public AKNBLHNGGJF(AmplitudeAnalyticsEvent PFLCCLDEBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55C1D0", Offset = "0x55ADD0", VA = "0x18055C1D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent FPBLLOLACHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4D66B30", Offset = "0x4D65730", VA = "0x184D66B30", Slot = "4")]
	public override void ADPMHGBHLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x20F4690", Offset = "0x20F3290", VA = "0x1820F4690")]
	public AKNBLHNGGJF OJHEHJCFJIM<T>(string AKJHGOKOPOG, T[] ODCJDJDBONO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4D66D20", Offset = "0x4D65920", VA = "0x184D66D20")]
	public AKNBLHNGGJF OJHEHJCFJIM(string AKJHGOKOPOG, string[] ODCJDJDBONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x20F43E0", Offset = "0x20F2FE0", VA = "0x1820F43E0")]
	public AKNBLHNGGJF OJHEHJCFJIM<T>(string AKJHGOKOPOG, T ODCJDJDBONO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4D66CB0", Offset = "0x4D658B0", VA = "0x184D66CB0")]
	public AKNBLHNGGJF OJHEHJCFJIM(string AKJHGOKOPOG, string ODCJDJDBONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4D66BD0", Offset = "0x4D657D0", VA = "0x184D66BD0")]
	private AKNBLHNGGJF JJMCGOOJIEJ(string AKJHGOKOPOG, object ODCJDJDBONO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LKEACFCGBBB : AKNBLHNGGJF
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4D66D30", Offset = "0x4D65930", VA = "0x184D66D30")]
	public LKEACFCGBBB(AmplitudeAnalyticsEvent PFLCCLDEBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4D70560", Offset = "0x4D6F160", VA = "0x184D70560", Slot = "4")]
	public override void ADPMHGBHLJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class OGLHABAJOCE<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::OGLHABAJOCE<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M PFLCCLDEBMC;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR NHDKILPEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27E5620", Offset = "0x27E4220", VA = "0x1827E5620")]
	public OGLHABAJOCE(M PFLCCLDEBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x340CF80", Offset = "0x340BB80", VA = "0x18340CF80")]
	public BLDR GJJJBGBKGDP(AmplitudeAnalyticsIdentifyMessage.DeviceInfo JDOOGDCNEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x340D060", Offset = "0x340BC60", VA = "0x18340D060")]
	public BLDR PNDDFJEJOMH(AmplitudeAnalyticsIdentifyMessage.RevenueData KBLFLEFGJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x340CFF0", Offset = "0x340BBF0", VA = "0x18340CFF0")]
	public BLDR OPHBJILDLIJ(string AKJHGOKOPOG, string ODCJDJDBONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20FF230", Offset = "0x20FDE30", VA = "0x1820FF230")]
	public BLDR OPHBJILDLIJ<T>(string AKJHGOKOPOG, T ODCJDJDBONO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ADPMHGBHLJC();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x340CFC0", Offset = "0x340BBC0", VA = "0x18340CFC0")]
	internal static string LAPCCBIICKM(string ODCJDJDBONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x340CEA0", Offset = "0x340BAA0", VA = "0x18340CEA0")]
	private BLDR AMIFFBBPMEO(string AKJHGOKOPOG, object ODCJDJDBONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M FPBLLOLACHM();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OIEHNANKPNI
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string PPNFLNHIJCE = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string OALOJNLKJCP = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string BAFOCGCAGAC = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string ILOOCJDKBCN = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string DACLFPNIKFC = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string FDEODBPAEPD = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string PBDHCKGIIBA = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string ILKFLAFDOCE = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string ELPKLBOIEHC = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string OOMIJGEAKCD = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string LKBOIABLHNI = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string ELKCDABJGPP = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string DIJLMKKKOGP = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string OMINBIECMOP = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string HKLPIMLFICL = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string DEMOPNMIEOL = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string PJMNJGJHEIN = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string GCMPJJMHPDD = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string FBKBOAALMDO = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string EHLMOCBMGKD = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string OPGKOKAIBLK = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string LEDFHGHHDAH = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public OIEHNANKPNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JPOBENFANPL
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int IBIPMGCKDIH = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int CGEOJAGEHEC = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int GEPPFEMPKNP = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long GIJIMJBOPBN = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int PMJJDKDMKHP = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int PEFANKLPION = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string PIIEGHOINDD = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string FLCDNIGLOJJ = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string NKLOGCADALN = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string BNJGMHAFGBM = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string ABIABADEDDG = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string COKFKGIEKID = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string JIDBDKFJPPP = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string JOAMIGNINHH = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string CBLLFLBNIKF = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string OALLCPMLMML = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string GGJMIFBFFFL = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string NCPMJLOMPDN = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string KMHCDIDBGGH = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string LEIJFKPBLAA = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string FLKNMMMFDBE = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string PGOCBOEAGAJ = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string OOPFHHBBCPA = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string LGFIDLMGOMN = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string PMKMLPOJKCC = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string LEMFLBPKFKA = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string IBBENDPJMEJ = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string LNOICJNBGMK = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string JAHHIJAHIDM = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string NKIFBLJAPHN = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string HHFNPIAABMJ = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string DPDFEDFMKKD = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string DACLFPNIKFC = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string NFCHFOMJGMP = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int MBGECKEOJGI = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LKGAMBGEBFH;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E9E0", Offset = "0x4D6D5E0", VA = "0x184D6E9E0")]
	internal static bool EGNKBKDBNIO(string OMAJLLKKGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public JPOBENFANPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LBMPIFDCDME
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool JPGJADFNBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string EIABHINJAAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string DDHKPMDMDML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string MBOCEFKGOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string INICKCAPKFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::KKLFNGHEAIK<AOHAFDKKDJG> DFGAJOAMKFP(string DCIIAGMGEPA, Dictionary<string, string> CFIGBLDNPCI);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::KKLFNGHEAIK<AOHAFDKKDJG> LMBBACNAGCJ(string DCIIAGMGEPA, string DKMHMPHAHHH, string EFMOCPNLCHG, string EJNFKLHOPGP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct AOHAFDKKDJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int NDCOABFBLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string NMFIGONIGJB;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x564CF0", Offset = "0x5638F0", VA = "0x180564CF0")]
	public AOHAFDKKDJG(int FGGJLHCCBIN, string FHIGKFEKMOA)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HNGLDPHHCGI
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] HNCEJLIIPMJ;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int GPLDKCDHCAH;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int JHGLEHDFIPO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger ALPCFLGFGJH;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HNGLDPHHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E3F0", Offset = "0x4D6CFF0", VA = "0x184D6E3F0")]
	private static string CHLEKPLKKKF(byte[] GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E4F0", Offset = "0x4D6D0F0", VA = "0x184D6E4F0")]
	public static string KBPCOEPOAHA(byte[] EDEEEGMMOHA, bool EDDELBNCJAF)
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
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
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

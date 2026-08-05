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
public class HIBKPBFAAJG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string GJGLLBGPNGF = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string IEMGOKIEGKD = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string LHNNNHDPHOM = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string INPFDBEOEOF = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string KHHHIJNBNKL = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string KCIKCFNONDH = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string BEJIDEKNCEK = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long AIMELJECLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BNAAGDPCEHN GOHMODPKJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool EJJOGLGKACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float IADKOGMADMI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4F704D0", Offset = "0x4F6ECD0", VA = "0x184F704D0")]
	public HIBKPBFAAJG(string DEELCEOKAPK, float IADKOGMADMI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x308E8A0", Offset = "0x308D0A0", VA = "0x18308E8A0")]
	public void DFCEDLOMFGB<T>(string KAJCCHNPEKH, T HKJMLEKHILN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4F70130", Offset = "0x4F6E930", VA = "0x184F70130")]
	public void DFCEDLOMFGB(string KAJCCHNPEKH, string HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4F702B0", Offset = "0x4F6EAB0", VA = "0x184F702B0")]
	public void IPCOJPBFOME(string AJOPHKNNEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4F703D0", Offset = "0x4F6EBD0", VA = "0x184F703D0")]
	public void JBLJOJDJIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4F701B0", Offset = "0x4F6E9B0", VA = "0x184F701B0")]
	private void FOHEEGBKNPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4F70480", Offset = "0x4F6EC80", VA = "0x184F70480")]
	private bool JIOONHCKKGG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MJICKMMPBDA
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHCOLEGJNAC CDGCMJJMEMA(string JCFEMGIBNEJ, string FCEOJLFOOMC, [Optional] CIEDKLPJIII MGKJNFGBEMN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OHCOLEGJNAC BMPHMPCCBHE(CIEDKLPJIII MGKJNFGBEMN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBHABBHAHHL(string IEAOKMELNOB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NOAECDHOBNK JHLAOAPJCMK(string HHFAGGGBPOC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NOAECDHOBNK PJCHIBPJEMA(string MHIFDDEIFLJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OHCOLEGJNAC NJDENFPAFOB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ILODHPPLDBB : MJICKMMPBDA
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string PDDHIKHPGGK = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string AHGPHILKBFE = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string IGMHFNDHNMB = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string PCPIDDCJIGK = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string HDKACEDHEJF = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string NDNAKHMGFCD = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string FDOFHHKCCJI = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string JECPKAHEGCI = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string HOCCOMMELII = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, PCDNBHGHFAP> GMHEEBHHNBG;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int AEKFFLHMEOD = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool FONGAADHGDC;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	[Preserve]
	public ILODHPPLDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4F70FE0", Offset = "0x4F6F7E0", VA = "0x184F70FE0")]
	[ABKMGPBGAPE(DAJECPDJCNA.Unity_BeforeSceneLoad)]
	private static void HLLEEADIHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4F70A60", Offset = "0x4F6F260", VA = "0x184F70A60", Slot = "4")]
	public OHCOLEGJNAC CDGCMJJMEMA(string JCFEMGIBNEJ, string FCEOJLFOOMC, [Optional] CIEDKLPJIII MGKJNFGBEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4F71670", Offset = "0x4F6FE70", VA = "0x184F71670", Slot = "9")]
	public OHCOLEGJNAC NJDENFPAFOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4F70910", Offset = "0x4F6F110", VA = "0x184F70910", Slot = "5")]
	public OHCOLEGJNAC BMPHMPCCBHE(CIEDKLPJIII MGKJNFGBEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4F717B0", Offset = "0x4F6FFB0", VA = "0x184F717B0", Slot = "6")]
	public bool PBHABBHAHHL(string IEAOKMELNOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F71140", Offset = "0x4F6F940", VA = "0x184F71140", Slot = "7")]
	public NOAECDHOBNK JHLAOAPJCMK(string HHFAGGGBPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4F71870", Offset = "0x4F70070", VA = "0x184F71870", Slot = "8")]
	public NOAECDHOBNK PJCHIBPJEMA(string MHIFDDEIFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4F71250", Offset = "0x4F6FA50", VA = "0x184F71250")]
	private OJEHBDJKCCH KAFFCIKLMIN(CIEDKLPJIII MGKJNFGBEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4F70E60", Offset = "0x4F6F660", VA = "0x184F70E60")]
	private AIJMHGKHMFH FMAIOIFDCLN(string FCEOJLFOOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4F70710", Offset = "0x4F6EF10", VA = "0x184F70710")]
	private void AHADPGOCDDL(string HHFAGGGBPOC, NOAECDHOBNK JAAANOFOFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x806630", Offset = "0x804E30", VA = "0x180806630")]
	[CompilerGenerated]
	private void AHKAIEHHIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JONNGOPCEIP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIBKPBFAAJG CMFHMDGGBEJ(string DEELCEOKAPK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CIEDKLPJIII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LBOMCHFPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ELOFEMILIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CBDHPHDPENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EIJCOBGAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? NPHLBMCCBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? IFOJIBJAIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int MAMMPNBJAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string MECCJELEDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string DGLNGGOADLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string IAOCKFEGLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LKMCCIMMKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JGHLMLAIGGL
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
		public AmplitudeAnalyticsClient.Settings PDOHMCHEJLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JADJMOEDNOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5D5130", Offset = "0x5D3930", VA = "0x1805D5130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum DPDEMGIAPIE
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum MEHGEDPBDAM
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class PJKHMBMBHJL
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class NEKLPELGBPJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int BNCDJJNKJEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> IKLHMOEGOKJ;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
				public NEKLPELGBPJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class AKHHELGBCAM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
				public AKHHELGBCAM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x4F69160", Offset = "0x4F67960", VA = "0x184F69160")]
				internal bool <GetBatch>b__0(NEKLPELGBPJ item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string KMGIMBPGJNN = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string DBNJCAPPLBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<NEKLPELGBPJ> IHJOLNBNIOO;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? PHKCPJIJPON
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x4F73380", Offset = "0x4F71B80", VA = "0x184F73380")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? IPIBOFMPJCD
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x4F732D0", Offset = "0x4F71AD0", VA = "0x184F732D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4F736C0", Offset = "0x4F71EC0", VA = "0x184F736C0")]
			internal PJKHMBMBHJL(string FGMMNAHEMIA, string FCEOJLFOOMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4F72710", Offset = "0x4F70F10", VA = "0x184F72710")]
			public int CEBGIGNJIIJ([Optional] int? HJLKCFPECLI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4F72510", Offset = "0x4F70D10", VA = "0x184F72510")]
			public List<Dictionary<string, object>> ACNCNGFDDCM(int FLGCGODCHOA, int? HJLKCFPECLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4F73620", Offset = "0x4F71E20", VA = "0x184F73620")]
			public void OCKMGNDDHCN(AmplitudeAnalyticsIdentifyMessage ALCFLDIFDGE, bool ENCNKOGJIOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4F73520", Offset = "0x4F71D20", VA = "0x184F73520")]
			public void OCKMGNDDHCN(Dictionary<string, object> ALCFLDIFDGE, bool ENCNKOGJIOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4F72870", Offset = "0x4F71070", VA = "0x184F72870")]
			public void CKCEOCMOFJN(params Dictionary<string, object>[] PLDAINPBPBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4F730B0", Offset = "0x4F718B0", VA = "0x184F730B0")]
			public void JAKLEJLFAKI(List<Dictionary<string, object>> AHGBECNNFFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4F73410", Offset = "0x4F71C10", VA = "0x184F73410")]
			private void LNGIOMEHFJF(Dictionary<string, object> ALCFLDIFDGE, bool ENCNKOGJIOI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4F72EC0", Offset = "0x4F716C0", VA = "0x184F72EC0")]
			public void ILBHIFGNEHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4F729C0", Offset = "0x4F711C0", VA = "0x184F729C0")]
			private void FBHPKNACGML([Optional] string NBPFKJBAGFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4F72D90", Offset = "0x4F71590", VA = "0x184F72D90")]
			private static string FKKLGLKLBLM(string HKJMLEKHILN, string HJCJKDOGPGK)
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
			[Cpp2IlInjected.Address(RVA = "0x4F73940", Offset = "0x4F72140", VA = "0x184F73940")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct EGFGPNPIEJK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int LOEIMILMNNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string OICBCMKIIGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T PMHKKPFKLPP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GMDMCOLCNPO : IEnumerator<LNMNCIDADCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private LNMNCIDADCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private LNMNCIDADCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public GMDMCOLCNPO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4F6F2E0", Offset = "0x4F6DAE0", VA = "0x184F6F2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4F6F9B0", Offset = "0x4F6E1B0", VA = "0x184F6F9B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class AMKFHPHNIHH : IEnumerator<object>, IEnumerator, IDisposable
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
			public FLHPGANJIHL quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public AMKFHPHNIHH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4F691C0", Offset = "0x4F679C0", VA = "0x184F691C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4F692B0", Offset = "0x4F67AB0", VA = "0x184F692B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class EKIEDKFAACD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public EKIEDKFAACD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4F6F120", Offset = "0x4F6D920", VA = "0x184F6F120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4F6F290", Offset = "0x4F6DA90", VA = "0x184F6F290", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MJLENOMNBDJ : IEnumerator<LNMNCIDADCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private LNMNCIDADCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private LNMNCIDADCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public MJLENOMNBDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4F72290", Offset = "0x4F70A90", VA = "0x184F72290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4F724C0", Offset = "0x4F70CC0", VA = "0x184F724C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class HFDIIOLJOEF : IEnumerator<LNMNCIDADCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private LNMNCIDADCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private LNMNCIDADCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public HFDIIOLJOEF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4F6FEA0", Offset = "0x4F6E6A0", VA = "0x184F6FEA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x4F700E0", Offset = "0x4F6E8E0", VA = "0x184F700E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class HDHEGHACNMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public PJKHMBMBHJL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public HDHEGHACNMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4F6FA00", Offset = "0x4F6E200", VA = "0x184F6FA00")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4F6FAA0", Offset = "0x4F6E2A0", VA = "0x184F6FAA0")]
			internal void <FlushFromCache>b__1(EGFGPNPIEJK<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class BMCHHNAABMK : IEnumerator<LNMNCIDADCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private LNMNCIDADCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public PJKHMBMBHJL cache;

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
			private HDHEGHACNMH <>8__1;

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
			private LNMNCIDADCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x574F20", Offset = "0x573720", VA = "0x180574F20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5B8590", Offset = "0x5B6D90", VA = "0x1805B8590")]
			[DebuggerHidden]
			public BMCHHNAABMK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4F6E6A0", Offset = "0x4F6CEA0", VA = "0x184F6E6A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4F6ED60", Offset = "0x4F6D560", VA = "0x184F6ED60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NPBIGFFOMID<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
			public NPBIGFFOMID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x371F310", Offset = "0x371DB10", VA = "0x18371F310")]
			internal EGFGPNPIEJK<T> <PostRudderStackJson>b__0(NBLGNHLEELG postResponse)
			{
				return default(EGFGPNPIEJK<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DKDIHCEDDMM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
			public DKDIHCEDDMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x371F310", Offset = "0x371DB10", VA = "0x18371F310")]
			internal EGFGPNPIEJK<T> <PostAmplitudeJson>b__0(NBLGNHLEELG postResponse)
			{
				return default(EGFGPNPIEJK<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CKFDJHNMMLG EIBIHMPOMAM;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string BBBNLFDMGMH = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string EMINJPIPAIN = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string EBGKNEOOFFE = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string FAJDIDAADHC = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string AAMFHGIDIAL = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int NMIKNPIGHAF = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int FGLCOKNOFAJ = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int AKCPNDOPJJC = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float LKPGEPLPFPP = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long JHBOELHONFA = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string COAFEPEKKDP = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string LLOMGLNCIHH = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool BOIFOJACCAP;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool JPALONOGDGD;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int HKLCHGLCAOD;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int OPMOLHENDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private HKBEPFJJGAI BFIMJHEKGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool HFLHLNDODAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float PEDMGJLFICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float CNPFMFEHFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int FIMPHLIFOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int KDKJBKGCLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? DJGPLAIPCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? JPJGLANKEFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long EOHEBPBJFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string AJANJLPIKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long NBDOKGEKCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> IKFLPFJGJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private MEHGEDPBDAM CGFOFEFPBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int BGMEEIJEIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int GADDMPOCMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float NIJGBNJKOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool KMLHPLEDOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool PPPBMDEJIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private PJKHMBMBHJL EJOOPEPPMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private PJKHMBMBHJL EMFOICOFEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private PJKHMBMBHJL MNLIPLLHGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> PHABGIMKHKP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JFFMNFFDABK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string OAGLFNJKLFI;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string HJKEFJGNACH = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string IDPOBOEECBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string DLGLKOGEHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string GLAMPEPCONL;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string DCGIKMNDENK = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string HDLCJNOCCLL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CKFDJHNMMLG LOLIMBCDMLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4F6B220", Offset = "0x4F69A20", VA = "0x184F6B220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int KALIDOLBDKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4F6C200", Offset = "0x4F6AA00", VA = "0x184F6C200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long OBODPCEEJFF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D800", Offset = "0x4F6C000", VA = "0x184F6D800")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D900", Offset = "0x4F6C100", VA = "0x184F6D900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string DJHBGHNFLMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D7A0", Offset = "0x4F6BFA0", VA = "0x184F6D7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string FLNLBGDAKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D7D0", Offset = "0x4F6BFD0", VA = "0x184F6D7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string NKFEMGKNBLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71F930", Offset = "0x71E130", VA = "0x18071F930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6B40F0", Offset = "0x6B28F0", VA = "0x1806B40F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? IFOJIBJAIBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7CD420", Offset = "0x7CBC20", VA = "0x1807CD420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x15C70F0", Offset = "0x15C58F0", VA = "0x1815C70F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DPDEMGIAPIE? CBMFNDCMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71B2E0", Offset = "0x719AE0", VA = "0x18071B2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x739710", Offset = "0x737F10", VA = "0x180739710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NJKHEPKDJAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x15BFCA0", Offset = "0x15BE4A0", VA = "0x1815BFCA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1C8C900", Offset = "0x1C8B100", VA = "0x181C8C900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool LPPFIJKGHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D6C0", Offset = "0x4F6BEC0", VA = "0x184F6D6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JEHNDBJLBAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D620", Offset = "0x4F6BE20", VA = "0x184F6D620")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D860", Offset = "0x4F6C060", VA = "0x184F6D860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4F696C0", Offset = "0x4F67EC0", VA = "0x184F696C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4F6AAC0", Offset = "0x4F692C0", VA = "0x184F6AAC0")]
		private void FLCLELNHMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D040", Offset = "0x4F6B840", VA = "0x184F6D040")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C560", Offset = "0x4F6AD60", VA = "0x184F6C560", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D1C0", Offset = "0x4F6B9C0", VA = "0x184F6D1C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C820", Offset = "0x4F6B020", VA = "0x184F6C820")]
		public OHCOLEGJNAC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B600", Offset = "0x4F69E00", VA = "0x184F6B600")]
		[IteratorStateMachine(typeof(GMDMCOLCNPO))]
		public IEnumerator<LNMNCIDADCN> Initialize(AmplitudeAnalyticsEvent JJPJPHLONGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D110", Offset = "0x4F6B910", VA = "0x184F6D110")]
		public void UpdateLastAliveTime(float JGONAKIDPNC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B160", Offset = "0x4F69960", VA = "0x184F6B160")]
		private OHCOLEGJNAC HCCLLJGMHDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4F69300", Offset = "0x4F67B00", VA = "0x184F69300")]
		private OHCOLEGJNAC AEKNNIDAOKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CCD0", Offset = "0x4F6B4D0", VA = "0x184F6CCD0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C600", Offset = "0x4F6AE00", VA = "0x184F6C600")]
		[IteratorStateMachine(typeof(AMKFHPHNIHH))]
		private IEnumerator PELLNHBPBEA(FLHPGANJIHL COFGDKNLPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D420", Offset = "0x4F6BC20", VA = "0x184F6D420")]
		[IteratorStateMachine(typeof(EKIEDKFAACD))]
		public IEnumerator WaitForFlush(float FBPIGFIGOFL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D050", Offset = "0x4F6B850", VA = "0x184F6D050")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B300", Offset = "0x4F69B00", VA = "0x184F6B300")]
		public static IIADJBAGKPF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4F69580", Offset = "0x4F67D80", VA = "0x184F69580")]
		public static BNAAGDPCEHN AccountSelectionPostLoginEvent([NotNull] string OMPFANEAJHI, string DFMAEGNFGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A870", Offset = "0x4F69070", VA = "0x184F6A870")]
		public static BNAAGDPCEHN Event([NotNull] string OMPFANEAJHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C8A0", Offset = "0x4F6B0A0", VA = "0x184F6C8A0")]
		public static BNAAGDPCEHN PreviousSessionEvent([NotNull] string OMPFANEAJHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B440", Offset = "0x4F69C40", VA = "0x184F6B440")]
		public static BNAAGDPCEHN InitializeEvent(string DFMAEGNFGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4F6CDE0", Offset = "0x4F6B5E0", VA = "0x184F6CDE0")]
		public static BNAAGDPCEHN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A5B0", Offset = "0x4F68DB0", VA = "0x184F6A5B0")]
		public static BNAAGDPCEHN CreateOutOfSessionEvent(string OMPFANEAJHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BB00", Offset = "0x4F6A300", VA = "0x184F6BB00")]
		public static OHCOLEGJNAC LogOutOfSessionEvent(BNAAGDPCEHN NDDPCGKOFBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B950", Offset = "0x4F6A150", VA = "0x184F6B950")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JGIDEINEJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BE30", Offset = "0x4F6A630", VA = "0x184F6BE30")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JGIDEINEJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BF00", Offset = "0x4F6A700", VA = "0x184F6BF00")]
		public void LogSerializedEventAsync(Dictionary<string, object> NGBDMNDNOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BA20", Offset = "0x4F6A220", VA = "0x184F6BA20")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage NKMFJBPIGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C4A0", Offset = "0x4F6ACA0", VA = "0x184F6C4A0")]
		private void OGLDAAOJLKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4F6BFD0", Offset = "0x4F6A7D0", VA = "0x184F6BFD0")]
		private void MNPNKCCOMOB(Dictionary<string, object> AFCEMPHNELC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A9D0", Offset = "0x4F691D0", VA = "0x184F6A9D0")]
		private void FIABHPLIPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C690", Offset = "0x4F6AE90", VA = "0x184F6C690")]
		private void PJBFFNDOEOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F6ACC0", Offset = "0x4F694C0", VA = "0x184F6ACC0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C420", Offset = "0x4F6AC20", VA = "0x184F6C420")]
		[IteratorStateMachine(typeof(MJLENOMNBDJ))]
		private IEnumerator<LNMNCIDADCN> OAEMIHFGNBF(float FBPIGFIGOFL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B8D0", Offset = "0x4F6A0D0", VA = "0x184F6B8D0")]
		[IteratorStateMachine(typeof(HFDIIOLJOEF))]
		private IEnumerator<LNMNCIDADCN> LKLEMHBFLLH(float FBPIGFIGOFL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B7F0", Offset = "0x4F69FF0", VA = "0x184F6B7F0")]
		[IteratorStateMachine(typeof(BMCHHNAABMK))]
		private IEnumerator<LNMNCIDADCN> KGJJOEIDHAD(PJKHMBMBHJL CFJAHBNPDIO, int? HJLKCFPECLI, string HAGPDEOPDBD, string PGCEGDHKPPD, float FBPIGFIGOFL, Action<int> NNGIHFPHGOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4F6A4C0", Offset = "0x4F68CC0", VA = "0x184F6A4C0")]
		private static void CMJHFMOJLMC(bool KGMEIJMLLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4F6AD50", Offset = "0x4F69550", VA = "0x184F6AD50")]
		private global::MJKMFAPMHBB<EGFGPNPIEJK<Dictionary<string, object>>> GHFAOMOFIGM(string HAGPDEOPDBD, string PGCEGDHKPPD, string BNBMAGNCCIN, string MBMDECJHDMK, Dictionary<string, object> PMHKKPFKLPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4F6AEC0", Offset = "0x4F696C0", VA = "0x184F6AEC0")]
		private global::MJKMFAPMHBB<EGFGPNPIEJK<List<Dictionary<string, object>>>> GHFAOMOFIGM(string HAGPDEOPDBD, string PGCEGDHKPPD, string BNBMAGNCCIN, string MBMDECJHDMK, List<Dictionary<string, object>> PMHKKPFKLPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x222A750", Offset = "0x2228F50", VA = "0x18222A750")]
		private global::MJKMFAPMHBB<EGFGPNPIEJK<T>> DJOMDABKKPM<T>(string HAGPDEOPDBD, string PGCEGDHKPPD, string MBMDECJHDMK, T PMHKKPFKLPP, Dictionary<string, object> PBMAPHPMEOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x222A480", Offset = "0x2228C80", VA = "0x18222A480")]
		private global::MJKMFAPMHBB<EGFGPNPIEJK<T>> CJODGCEMEPG<T>(string HAGPDEOPDBD, string PGCEGDHKPPD, string BNBMAGNCCIN, T PMHKKPFKLPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4F69530", Offset = "0x4F67D30", VA = "0x184F69530")]
		private bool AGHCBMJIFDH(float AJNBLPLFEKD, float FBPIGFIGOFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F699A0", Offset = "0x4F681A0", VA = "0x184F699A0")]
		private Dictionary<string, object> BLGCAJMHFOJ(string PGCEGDHKPPD, Dictionary<string, object> PMHKKPFKLPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D500", Offset = "0x4F6BD00", VA = "0x184F6D500")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B690", Offset = "0x4F69E90", VA = "0x184F6B690")]
		[CompilerGenerated]
		private long JBNCKEKENJL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4F6C550", Offset = "0x4F6AD50", VA = "0x184F6C550")]
		[CompilerGenerated]
		private void OIIJILMPCIN(int HBKFOMJPMGC)
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
			[Cpp2IlInjected.Address(RVA = "0x612F80", Offset = "0x611780", VA = "0x180612F80")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DA70", Offset = "0x4F6C270", VA = "0x184F6DA70")]
		public static BNAAGDPCEHN DIFMOOHBFDA(string CDHIMBPFFEA, [NotNull] string HAGHOBLFAIP, long AGBIPNEINOB, long GHBDNGGMBDD, string DFMAEGNFGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DD90", Offset = "0x4F6C590", VA = "0x184F6DD90")]
		public static BNAAGDPCEHN JFPICDMEMJJ(string CDHIMBPFFEA, [NotNull] string HAGHOBLFAIP, long AGBIPNEINOB, long GHBDNGGMBDD, string DFMAEGNFGHO, long CNDEHHJGIOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DEF0", Offset = "0x4F6C6F0", VA = "0x184F6DEF0")]
		private AmplitudeAnalyticsEvent(string CDHIMBPFFEA, [NotNull] string HAGHOBLFAIP, long AGBIPNEINOB, long GHBDNGGMBDD, string DFMAEGNFGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA33840", Offset = "0xA32040", VA = "0x180A33840")]
		public void DKPBDLKPOGI(long NNPGOBMFNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4F6D960", Offset = "0x4F6C160", VA = "0x184F6D960", Slot = "5")]
		public override void CKDOGPILAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DE80", Offset = "0x4F6C680", VA = "0x184F6DE80", Slot = "6")]
		public override void PDEPKELKPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F6DB50", Offset = "0x4F6C350", VA = "0x184F6DB50", Slot = "4")]
		protected override Dictionary<string, object> HNAEPLPENIN(Dictionary<string, object> NLHMEIMCHCG)
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
			[Cpp2IlInjected.Address(RVA = "0x4F6F000", Offset = "0x4F6D800", VA = "0x184F6F000")]
			public void FHLPPCHJLPD(Dictionary<string, object> CPJBJKKDMIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F73820", Offset = "0x4F72020", VA = "0x184F73820")]
			public void FHLPPCHJLPD(Dictionary<string, object> BCJIBPOCCGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x160E7C0", Offset = "0x160CFC0", VA = "0x18160E7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5DDA30", Offset = "0x5DC230", VA = "0x1805DDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E110", Offset = "0x4F6C910", VA = "0x184F6E110")]
		public static IIADJBAGKPF DIFMOOHBFDA(string CDHIMBPFFEA, string DFMAEGNFGHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E5E0", Offset = "0x4F6CDE0", VA = "0x184F6E5E0")]
		protected AmplitudeAnalyticsIdentifyMessage(string CDHIMBPFFEA, string DFMAEGNFGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E3F0", Offset = "0x4F6CBF0", VA = "0x184F6E3F0")]
		public Dictionary<string, object> KEEGOLNAADA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E1B0", Offset = "0x4F6C9B0", VA = "0x184F6E1B0", Slot = "4")]
		protected virtual Dictionary<string, object> HNAEPLPENIN(Dictionary<string, object> NLHMEIMCHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E460", Offset = "0x4F6CC60", VA = "0x184F6E460")]
		protected void KFPMPMKPMGG(string HJCJKDOGPGK, Dictionary<string, object> MIFMOLKPMGB, Dictionary<string, object> KPIHGFEKOJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E500", Offset = "0x4F6CD00", VA = "0x184F6E500")]
		protected void LLIGJAKGDHF(string HJCJKDOGPGK, string HKJMLEKHILN, Dictionary<string, object> GELCAKCPJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E090", Offset = "0x4F6C890", VA = "0x184F6E090", Slot = "5")]
		public virtual void CKDOGPILAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4F6E570", Offset = "0x4F6CD70", VA = "0x184F6E570", Slot = "6")]
		public virtual void PDEPKELKPEB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IIADJBAGKPF : global::OKJGMGLLFGO<AmplitudeAnalyticsIdentifyMessage, IIADJBAGKPF>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override IIADJBAGKPF LAEPKBHGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x621ED0", Offset = "0x6206D0", VA = "0x180621ED0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MOJPOBJIBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F706C0", Offset = "0x4F6EEC0", VA = "0x184F706C0")]
	public IIADJBAGKPF(AmplitudeAnalyticsIdentifyMessage BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4F70630", Offset = "0x4F6EE30", VA = "0x184F70630", Slot = "4")]
	public override void PDEPKELKPEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BNAAGDPCEHN : global::OKJGMGLLFGO<AmplitudeAnalyticsEvent, BNAAGDPCEHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool DGDBEFHBBJD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override BNAAGDPCEHN LAEPKBHGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x621ED0", Offset = "0x6206D0", VA = "0x180621ED0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4F6EFB0", Offset = "0x4F6D7B0", VA = "0x184F6EFB0")]
	public BNAAGDPCEHN(AmplitudeAnalyticsEvent BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80", Slot = "5")]
	public override AmplitudeAnalyticsEvent MOJPOBJIBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4F6EF10", Offset = "0x4F6D710", VA = "0x184F6EF10", Slot = "4")]
	public override void PDEPKELKPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2479450", Offset = "0x2477C50", VA = "0x182479450")]
	public BNAAGDPCEHN DFCEDLOMFGB<T>(string KAJCCHNPEKH, T[] HKJMLEKHILN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F6EE20", Offset = "0x4F6D620", VA = "0x184F6EE20")]
	public BNAAGDPCEHN DFCEDLOMFGB(string KAJCCHNPEKH, string[] HKJMLEKHILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x24793E0", Offset = "0x2477BE0", VA = "0x1824793E0")]
	public BNAAGDPCEHN DFCEDLOMFGB<T>(string KAJCCHNPEKH, T HKJMLEKHILN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F6EDB0", Offset = "0x4F6D5B0", VA = "0x184F6EDB0")]
	public BNAAGDPCEHN DFCEDLOMFGB(string KAJCCHNPEKH, string HKJMLEKHILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4F6EE30", Offset = "0x4F6D630", VA = "0x184F6EE30")]
	private BNAAGDPCEHN FEJJMFNKIBK(string KAJCCHNPEKH, object HKJMLEKHILN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LFBFPJBCEJA : BNAAGDPCEHN
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F6EFB0", Offset = "0x4F6D7B0", VA = "0x184F6EFB0")]
	public LFBFPJBCEJA(AmplitudeAnalyticsEvent BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F72160", Offset = "0x4F70960", VA = "0x184F72160", Slot = "4")]
	public override void PDEPKELKPEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class OKJGMGLLFGO<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::OKJGMGLLFGO<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M BOBNBIKICDK;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR LAEPKBHGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2806BE0", Offset = "0x28053E0", VA = "0x182806BE0")]
	public OKJGMGLLFGO(M BOBNBIKICDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2806B00", Offset = "0x2805300", VA = "0x182806B00")]
	public BLDR LNCAGALIOAA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo HDAOHBJLBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2806AC0", Offset = "0x28052C0", VA = "0x182806AC0")]
	public BLDR JHOPAGOHJFK(AmplitudeAnalyticsIdentifyMessage.RevenueData FCCNIGBMNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2806B70", Offset = "0x2805370", VA = "0x182806B70")]
	public BLDR OOFFKACHKKM(string KAJCCHNPEKH, string HKJMLEKHILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x247FB00", Offset = "0x247E300", VA = "0x18247FB00")]
	public BLDR OOFFKACHKKM<T>(string KAJCCHNPEKH, T HKJMLEKHILN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void PDEPKELKPEB();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2806B40", Offset = "0x2805340", VA = "0x182806B40")]
	internal static string NKHMBMGLCCL(string HKJMLEKHILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x28069E0", Offset = "0x28051E0", VA = "0x1828069E0")]
	private BLDR ICHGLINKCOP(string KAJCCHNPEKH, object HKJMLEKHILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M MOJPOBJIBLF();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DIGELDLLDAN
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string JDMEPPCFKJF = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string NJBBKMNHCOM = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string PIHMEMKPPJK = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string EHCPECOMJAE = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string PCKLCFDLCHA = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string JEBKAEAOEJD = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string CFLMABKHNPA = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string FNHFBHAOCIE = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string EOPFAKBIOIJ = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string CLMMEMGAOHB = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string KKEGAFACAGG = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string FPJHCJMJLJK = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string LEFAHAEJODF = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string AMIJLPCCKCB = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string JBBMHJCCPFC = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string NOCAJLHGCHK = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string KAJKOFHCIGF = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string JCEOFJGMIEK = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string HFLNFIJDDEB = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string NOKBAFKHDDK = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string LAPEKFGAOAF = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string AMJDAPMNNEH = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public DIGELDLLDAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KPEDBCAJPJN
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int PNEDAFBOKBA = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int BNKGHAMODHE = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int MHJCMMANBAE = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long GMCIABIMKJP = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int OHMGDNKDMNF = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int MFEPNJEHMFK = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string DEFJLCGNINJ = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string PKDCLMGCNKA = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string EGAFLNOOGLN = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string LGHAKAJFJKK = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string IEBHNJMFOFH = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string KGGGHEFFNLF = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string PGNNLDDIMOB = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string AEGLLLLEDAE = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string DEGNIGHHFBK = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string AIFGMFENKJL = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string PFEFBDGDMGC = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string AGPLCAGJDNO = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string CHOBAIKBOHD = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string DCDDLOCAHFF = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string NECFICIFFLP = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string LLOCMACMLAD = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string GDPIAPCCAGF = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string HGIAHLIFCFL = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string CBFLIAENNPG = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string ONCALALDIOA = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string OPJHIFDPDPN = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string PCGLGOOFJAN = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string EJEHGKBCHEM = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string OLIODDIFLJE = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string FMJADHILICK = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string BFBFICCPHJE = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string PCKLCFDLCHA = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string PCGIJFBPGEJ = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int DEIKLJMCDEK = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OCMKCOIBCGP;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4F72010", Offset = "0x4F70810", VA = "0x184F72010")]
	internal static bool EBCHKELIMMM(string HJCJKDOGPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public KPEDBCAJPJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HKBEPFJJGAI
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool OKHMFOHFOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string IJCBPJINAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string AMHKPJLFMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string PCJDPKKOIEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string CAPPPBFPBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MJKMFAPMHBB<NBLGNHLEELG> GHFAOMOFIGM(string HAGPDEOPDBD, Dictionary<string, string> GIEBIBOIOPF);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::MJKMFAPMHBB<NBLGNHLEELG> ABHCCOFJCJF(string HAGPDEOPDBD, string EKBLOEAJJOH, string NGFHINGOJJJ, string PIBAJKMJMAH);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct NBLGNHLEELG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int KHJJBPDLOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string HPPNACHPBFN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x9E82D0", Offset = "0x9E6AD0", VA = "0x1809E82D0")]
	public NBLGNHLEELG(int LOEIMILMNNA, string OICBCMKIIGA)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JOLDJLBOGLF
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] NNDNCLBIBCO;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int BOAHHKDAAGN;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int BEAECOMNAKK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger HPFDFIDLOGO;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOLDJLBOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4F71A20", Offset = "0x4F70220", VA = "0x184F71A20")]
	private static string AAANGJFGDHI(byte[] EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4F71B20", Offset = "0x4F70320", VA = "0x184F71B20")]
	public static string CHJFNPPOLEP(byte[] IFAOIOLKGMC, bool CCLJOEHHPGP)
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
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

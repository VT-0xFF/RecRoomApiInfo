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
public class OHLLDLMOKOI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string CNKLHHMLNAL = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string FHMDOBLKFLG = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string PGHOOCMIJFL = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string NDNHNIJJPKN = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string OOHJBIOALLD = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string MDCLEDCBPLF = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string HLEBKGDPNBD = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long JMOJFHHPAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BJBMAJKFJME GDAPKFKFKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool PCFLFDONLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float CFMAAGHIEOE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E22630", Offset = "0x4E21030", VA = "0x184E22630")]
	public OHLLDLMOKOI(string MLDEKOLMCMP, float CFMAAGHIEOE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A48600", Offset = "0x3A47000", VA = "0x183A48600")]
	public void FPCLDDBKGHI<T>(string LIHBMCPCJED, T HPIAFNBPEPC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E223E0", Offset = "0x4E20DE0", VA = "0x184E223E0")]
	public void FPCLDDBKGHI(string LIHBMCPCJED, string HPIAFNBPEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E22460", Offset = "0x4E20E60", VA = "0x184E22460")]
	public void KAJEJFGKJMN(string MKJPEBHMHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E22580", Offset = "0x4E20F80", VA = "0x184E22580")]
	public void PNPOJOANAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E22290", Offset = "0x4E20C90", VA = "0x184E22290")]
	private void CGMGGCNAEAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E22390", Offset = "0x4E20D90", VA = "0x184E22390")]
	private bool FEEOLDMBCEG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GCMIHFJKAHM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCANMJCMFMC LPDEJFLNIEO(string CFFNJAAAHCK, string ELBNFNHFGBN, [Optional] BCKFEDPKEAO PKBMCNNABPI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LCANMJCMFMC BGNJFKOILKI(BCKFEDPKEAO PKBMCNNABPI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HGFLEGCFOFJ(string DLIEIEFOKJP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AHOHIGANELE HKKNGPFLAEA(string MMEEKMPHCMJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AHOHIGANELE NGFPHLIHBHC(string IAODOFBCBGD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LCANMJCMFMC CBFLOIKGBLE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GCLOLPKNECB : GCMIHFJKAHM
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string AIOICFLOEKL = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string JCILAABJFAI = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string MPDNMNANJEM = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string KDOLMAKNGKG = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string FDLDKOCCJPC = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string JKBMMFFDPPB = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string DGFGGFBGNEF = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string KKOJKOFOIKA = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string IEFAFMAOBKM = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, OBNALDOIMKK> BBNPOPNCKEC;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int ODBDBAFGIFK = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool MDBFCLOPGDK;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	[Preserve]
	public GCLOLPKNECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EDC0", Offset = "0x4E1D7C0", VA = "0x184E1EDC0")]
	[HHLALKEPADJ(EEBHKBEBFLD.Unity_BeforeSceneLoad)]
	private static void EIJNNFJOEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F510", Offset = "0x4E1DF10", VA = "0x184E1F510", Slot = "4")]
	public LCANMJCMFMC LPDEJFLNIEO(string CFFNJAAAHCK, string ELBNFNHFGBN, [Optional] BCKFEDPKEAO PKBMCNNABPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EA80", Offset = "0x4E1D480", VA = "0x184E1EA80", Slot = "9")]
	public LCANMJCMFMC CBFLOIKGBLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E930", Offset = "0x4E1D330", VA = "0x184E1E930", Slot = "5")]
	public LCANMJCMFMC BGNJFKOILKI(BCKFEDPKEAO PKBMCNNABPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EF20", Offset = "0x4E1D920", VA = "0x184E1EF20", Slot = "6")]
	public bool HGFLEGCFOFJ(string DLIEIEFOKJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EFE0", Offset = "0x4E1D9E0", VA = "0x184E1EFE0", Slot = "7")]
	public AHOHIGANELE HKKNGPFLAEA(string MMEEKMPHCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F910", Offset = "0x4E1E310", VA = "0x184E1F910", Slot = "8")]
	public AHOHIGANELE NGFPHLIHBHC(string IAODOFBCBGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F0F0", Offset = "0x4E1DAF0", VA = "0x184E1F0F0")]
	private BNKJLMFBELJ IJMHLIIJLJD(BCKFEDPKEAO PKBMCNNABPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4E1FA00", Offset = "0x4E1E400", VA = "0x184E1FA00")]
	private PDIKCGJMFGN PLOMFDPBHND(string ELBNFNHFGBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EBC0", Offset = "0x4E1D5C0", VA = "0x184E1EBC0")]
	private void EAHCCJLBONN(string MMEEKMPHCMJ, AHOHIGANELE DPAHJCPCBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x936770", Offset = "0x935170", VA = "0x180936770")]
	[CompilerGenerated]
	private void GCCGDANOAGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NLKIMDLJMKP
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OHLLDLMOKOI LFLMNMPDMGL(string MLDEKOLMCMP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BCKFEDPKEAO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NFODFEDHMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BDDGCJAGNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JDMOJBFOAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FNDPEKPFFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? EPEBCFCBINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? BJLKEABPNKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int DFJDJIHPFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string AOCANLGMHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string JGAGPFHLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string DMMFHKLIFKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string HLDMPLHBLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string DLENCMGHEGE
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
		public AmplitudeAnalyticsClient.Settings ELOBJGCKAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool LIOINFHFGPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x587EB0", Offset = "0x5868B0", VA = "0x180587EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum KLHLGGKJOCP
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum CPNACONFAEB
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class LGOHAABGFMD
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class GGEEPGCGCEG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int HFMGOFKBDMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> JEPDEIGNDEE;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
				public GGEEPGCGCEG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class NAMFNBJCKGM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
				public NAMFNBJCKGM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x4E22100", Offset = "0x4E20B00", VA = "0x184E22100")]
				internal bool <GetBatch>b__0(GGEEPGCGCEG item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string KMEDLJELFFC = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string JAFIMCJAMAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<GGEEPGCGCEG> MKNOCGHGKAE;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? DFNBIKKFFLG
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x4E21980", Offset = "0x4E20380", VA = "0x184E21980")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? MJMOAFFIHEL
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x4E21EF0", Offset = "0x4E208F0", VA = "0x184E21EF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x4E21FA0", Offset = "0x4E209A0", VA = "0x184E21FA0")]
			internal LGOHAABGFMD(string LBCIHIJGFPN, string ELBNFNHFGBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x4E21820", Offset = "0x4E20220", VA = "0x184E21820")]
			public int JLCBHAAFAJO([Optional] int? IOJJJIPFELH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x4E20DF0", Offset = "0x4E1F7F0", VA = "0x184E20DF0")]
			public List<Dictionary<string, object>> BDGFJIMIABF(int ANEIJAJFENE, int? IOJJJIPFELH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x4E210F0", Offset = "0x4E1FAF0", VA = "0x184E210F0")]
			public void DCAOHLDPJDM(AmplitudeAnalyticsIdentifyMessage FBOGCDJOCBP, bool LJGDJPEGMHO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x4E20FF0", Offset = "0x4E1F9F0", VA = "0x184E20FF0")]
			public void DCAOHLDPJDM(Dictionary<string, object> FBOGCDJOCBP, bool LJGDJPEGMHO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4E213B0", Offset = "0x4E1FDB0", VA = "0x184E213B0")]
			public void GFPEIJPKJDL(params Dictionary<string, object>[] KFOBHDHNDEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4E21190", Offset = "0x4E1FB90", VA = "0x184E21190")]
			public void EKJFBIELBHL(List<Dictionary<string, object>> BDOPPDGOMIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4E21DE0", Offset = "0x4E207E0", VA = "0x184E21DE0")]
			private void KLGNKKLAFPN(Dictionary<string, object> FBOGCDJOCBP, bool LJGDJPEGMHO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4E21500", Offset = "0x4E1FF00", VA = "0x184E21500")]
			public void GJBMBHOJOIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x4E21A10", Offset = "0x4E20410", VA = "0x184E21A10")]
			private void KFGBIKCEDJJ([Optional] string JCDPLEAFLPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4E216F0", Offset = "0x4E200F0", VA = "0x184E216F0")]
			private static string JDLKNEEGICB(string HPIAFNBPEPC, string IPKOPOLJGIA)
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
			[Cpp2IlInjected.Address(RVA = "0x4E228B0", Offset = "0x4E212B0", VA = "0x184E228B0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct LLGDMHDECJJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int HOMEEOADEBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string EAFFKNPLDID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T IHOFIDAONNJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GMPILIJLJNK : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private CBGPFCCMDJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public GMPILIJLJNK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x4E1FC40", Offset = "0x4E1E640", VA = "0x184E1FC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4E20310", Offset = "0x4E1ED10", VA = "0x184E20310", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FOKOCGPBGEJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public FLCLHLLPKNN quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public FOKOCGPBGEJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4E1E0E0", Offset = "0x4E1CAE0", VA = "0x184E1E0E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4E1E1D0", Offset = "0x4E1CBD0", VA = "0x184E1E1D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FHENLGFCFIL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public FHENLGFCFIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4E1DF20", Offset = "0x4E1C920", VA = "0x184E1DF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x4E1E090", Offset = "0x4E1CA90", VA = "0x184E1E090", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BOAHEOICANE : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private CBGPFCCMDJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public BOAHEOICANE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4E1D7A0", Offset = "0x4E1C1A0", VA = "0x184E1D7A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4E1D9D0", Offset = "0x4E1C3D0", VA = "0x184E1D9D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CHNODAMGAJJ : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private CBGPFCCMDJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public CHNODAMGAJJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x4E1DA20", Offset = "0x4E1C420", VA = "0x184E1DA20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x4E1DC60", Offset = "0x4E1C660", VA = "0x184E1DC60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KFGHCGHJCLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public LGOHAABGFMD cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public KFGHCGHJCLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4E20360", Offset = "0x4E1ED60", VA = "0x184E20360")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4E20400", Offset = "0x4E1EE00", VA = "0x184E20400")]
			internal void <FlushFromCache>b__1(LLGDMHDECJJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FOMEOPNIKBL : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private CBGPFCCMDJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public LGOHAABGFMD cache;

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
			private KFGHCGHJCLP <>8__1;

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
			private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
			[DebuggerHidden]
			public FOMEOPNIKBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4E1E220", Offset = "0x4E1CC20", VA = "0x184E1E220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x4E1E8E0", Offset = "0x4E1D2E0", VA = "0x184E1E8E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class CLDEMIIBAHM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
			public CLDEMIIBAHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3D60F10", Offset = "0x3D5F910", VA = "0x183D60F10")]
			internal LLGDMHDECJJ<T> <PostRudderStackJson>b__0(PINCNKJGINJ postResponse)
			{
				return default(LLGDMHDECJJ<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class OIPGAJIKMKL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
			public OIPGAJIKMKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x3D60F10", Offset = "0x3D5F910", VA = "0x183D60F10")]
			internal LLGDMHDECJJ<T> <PostAmplitudeJson>b__0(PINCNKJGINJ postResponse)
			{
				return default(LLGDMHDECJJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KHLILJNNBNI APMMBGEICMH;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string HLKCCJNNLBD = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string HIDMLOLEIML = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string OIAIJBJECNB = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string FNGFAFDGPIO = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string POOGBHJEHEP = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int MPADCMAAOJK = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int EMGJMHMFMOA = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int JLMHNJMFBEO = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float KIHMIJIDBON = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long NELHGJPPFIL = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string HNBLMDKKJEP = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string ANNBCFOOLJB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool MBMOKHFKINB;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool OOENNIGFCFI;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int GOGOPEJEEJC;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int NGIAOFCHADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private HGJFGFLIIAG NLKDDJMNKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool PODNDIGIFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float AMKHCGKEKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float ONADPNMKCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int MLLBMENLFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int IJNAJIAJFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? LKMKLAJLHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? COOHHJMGCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long GNEPLENLLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string GENFMHKPCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long EPPJOOJICKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> PNPLHBBCAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private CPNACONFAEB GCCCMKBNPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int KLOKFMDLHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int IPKLDFFOEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float DMBJCLONHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool AAEKFFDCAGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool KOOKNDBEEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LGOHAABGFMD JDPODJPDHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LGOHAABGFMD HGMHMCMADAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LGOHAABGFMD MGGAAIHEEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FDADAJCCHHN;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JHOJPBJLGHK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string MKPAGMLNAKA;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string ALAHPDDIGKA = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string MKDOAHPINLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string OFCENCCFPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string IFDGGLFNJOB;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string ACNKDDDFOIA = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string GKDGCGDHCED = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KHLILJNNBNI CAHOCPMGDKP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4E1B0A0", Offset = "0x4E19AA0", VA = "0x184E1B0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int FDIJBALGOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4E181B0", Offset = "0x4E16BB0", VA = "0x184E181B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long IKEJGCLMOHH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C6B0", Offset = "0x4E1B0B0", VA = "0x184E1C6B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C7B0", Offset = "0x4E1B1B0", VA = "0x184E1C7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string MIFEEACLHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C650", Offset = "0x4E1B050", VA = "0x184E1C650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string GAKBLKEFDIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C680", Offset = "0x4E1B080", VA = "0x184E1C680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string EAGANNILJKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5AC360", Offset = "0x5AAD60", VA = "0x1805AC360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x563850", Offset = "0x562250", VA = "0x180563850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? BJLKEABPNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5637F0", Offset = "0x5621F0", VA = "0x1805637F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1D20E90", Offset = "0x1D1F890", VA = "0x181D20E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KLHLGGKJOCP? PKGAMDIHGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6A1500", Offset = "0x69FF00", VA = "0x1806A1500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2F1A170", Offset = "0x2F18B70", VA = "0x182F1A170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MEPPIDKALOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1291EE0", Offset = "0x12908E0", VA = "0x181291EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2070050", Offset = "0x206EA50", VA = "0x182070050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool DFFMMKCAGDG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C570", Offset = "0x4E1AF70", VA = "0x184E1C570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> LNMMKIFDCJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C4D0", Offset = "0x4E1AED0", VA = "0x184E1C4D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4E1C710", Offset = "0x4E1B110", VA = "0x184E1C710")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4E18520", Offset = "0x4E16F20", VA = "0x184E18520", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4E18880", Offset = "0x4E17280", VA = "0x184E18880")]
		private void CBJDOLMKPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BEF0", Offset = "0x4E1A8F0", VA = "0x184E1BEF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B550", Offset = "0x4E19F50", VA = "0x184E1B550", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C070", Offset = "0x4E1AA70", VA = "0x184E1C070")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B6D0", Offset = "0x4E1A0D0", VA = "0x184E1B6D0")]
		public LCANMJCMFMC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A6A0", Offset = "0x4E190A0", VA = "0x184E1A6A0")]
		[IteratorStateMachine(typeof(GMPILIJLJNK))]
		public IEnumerator<CBGPFCCMDJP> Initialize(AmplitudeAnalyticsEvent JAIMPMMJHIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BFC0", Offset = "0x4E1A9C0", VA = "0x184E1BFC0")]
		public void UpdateLastAliveTime(float IOHNEIJDHEF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B180", Offset = "0x4E19B80", VA = "0x184E1B180")]
		private LCANMJCMFMC MHKIIJANAJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B240", Offset = "0x4E19C40", VA = "0x184E1B240")]
		private LCANMJCMFMC OOPDDECFOGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BB80", Offset = "0x4E1A580", VA = "0x184E1BB80")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B5F0", Offset = "0x4E19FF0", VA = "0x184E1B5F0")]
		[IteratorStateMachine(typeof(FOKOCGPBGEJ))]
		private IEnumerator PEHBLAAMKFA(FLCLHLLPKNN CEPPAMKHKNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C2D0", Offset = "0x4E1ACD0", VA = "0x184E1C2D0")]
		[IteratorStateMachine(typeof(FHENLGFCFIL))]
		public IEnumerator WaitForFlush(float BMNHOPLJPGO = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BF00", Offset = "0x4E1A900", VA = "0x184E1BF00")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A3A0", Offset = "0x4E18DA0", VA = "0x184E1A3A0")]
		public static ALLDJPBGIHI Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4E183E0", Offset = "0x4E16DE0", VA = "0x184E183E0")]
		public static BJBMAJKFJME AccountSelectionPostLoginEvent([NotNull] string ECGAMCBBJJC, string GBDOKMJFPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4E192C0", Offset = "0x4E17CC0", VA = "0x184E192C0")]
		public static BJBMAJKFJME Event([NotNull] string ECGAMCBBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B750", Offset = "0x4E1A150", VA = "0x184E1B750")]
		public static BJBMAJKFJME PreviousSessionEvent([NotNull] string ECGAMCBBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A4E0", Offset = "0x4E18EE0", VA = "0x184E1A4E0")]
		public static BJBMAJKFJME InitializeEvent(string GBDOKMJFPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4E1BC90", Offset = "0x4E1A690", VA = "0x184E1BC90")]
		public static BJBMAJKFJME StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4E18F80", Offset = "0x4E17980", VA = "0x184E18F80")]
		public static BJBMAJKFJME CreateOutOfSessionEvent(string ECGAMCBBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4E1ABD0", Offset = "0x4E195D0", VA = "0x184E1ABD0")]
		public static LCANMJCMFMC LogOutOfSessionEvent(BJBMAJKFJME AANNOPHDKAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E1AA20", Offset = "0x4E19420", VA = "0x184E1AA20")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LFJFKHNCDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4E1AF00", Offset = "0x4E19900", VA = "0x184E1AF00")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LFJFKHNCDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4E1AFD0", Offset = "0x4E199D0", VA = "0x184E1AFD0")]
		public void LogSerializedEventAsync(Dictionary<string, object> NGKPEBDEIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4E1AAF0", Offset = "0x4E194F0", VA = "0x184E1AAF0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage MCEDLNIIBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A2F0", Offset = "0x4E18CF0", VA = "0x184E1A2F0")]
		private void GHJPKHAACIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4E19F40", Offset = "0x4E18940", VA = "0x184E19F40")]
		private void FHPFKOFCLFG(Dictionary<string, object> OJLMNNBAEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A170", Offset = "0x4E18B70", VA = "0x184E1A170")]
		private void FMOLPCIGKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A890", Offset = "0x4E19290", VA = "0x184E1A890")]
		private void KEEOFBMNNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A260", Offset = "0x4E18C60", VA = "0x184E1A260")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4E18800", Offset = "0x4E17200", VA = "0x184E18800")]
		[IteratorStateMachine(typeof(BOAHEOICANE))]
		private IEnumerator<CBGPFCCMDJP> BGMCHBMLACJ(float BMNHOPLJPGO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4E19240", Offset = "0x4E17C40", VA = "0x184E19240")]
		[IteratorStateMachine(typeof(CHNODAMGAJJ))]
		private IEnumerator<CBGPFCCMDJP> DMLJMAAFAFH(float BMNHOPLJPGO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B470", Offset = "0x4E19E70", VA = "0x184E1B470")]
		[IteratorStateMachine(typeof(FOMEOPNIKBL))]
		private IEnumerator<CBGPFCCMDJP> OPPGCGCDLDM(LGOHAABGFMD GIJBCGBNLPG, int? IOJJJIPFELH, string AOLKNBAHDEO, string EGOBGJAOHHJ, float BMNHOPLJPGO, Action<int> EOOKCANDMIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4E18A80", Offset = "0x4E17480", VA = "0x184E18A80")]
		private static void CLMEIICBLII(bool HIHIBPKIGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4E18B70", Offset = "0x4E17570", VA = "0x184E18B70")]
		private global::HJGFLNHHJHD<LLGDMHDECJJ<Dictionary<string, object>>> CNFLBJNKNEK(string AOLKNBAHDEO, string EGOBGJAOHHJ, string CCHBEAMNDJN, string CADIMCMNCHI, Dictionary<string, object> IHOFIDAONNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4E18CE0", Offset = "0x4E176E0", VA = "0x184E18CE0")]
		private global::HJGFLNHHJHD<LLGDMHDECJJ<List<Dictionary<string, object>>>> CNFLBJNKNEK(string AOLKNBAHDEO, string EGOBGJAOHHJ, string CCHBEAMNDJN, string CADIMCMNCHI, List<Dictionary<string, object>> IHOFIDAONNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27BF070", Offset = "0x27BDA70", VA = "0x1827BF070")]
		private global::HJGFLNHHJHD<LLGDMHDECJJ<T>> MNDGLEONNFK<T>(string AOLKNBAHDEO, string EGOBGJAOHHJ, string CADIMCMNCHI, T IHOFIDAONNJ, Dictionary<string, object> NLKFKKLAHPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27BEDA0", Offset = "0x27BD7A0", VA = "0x1827BEDA0")]
		private global::HJGFLNHHJHD<LLGDMHDECJJ<T>> GNLDEBKLJMN<T>(string AOLKNBAHDEO, string EGOBGJAOHHJ, string CCHBEAMNDJN, T IHOFIDAONNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B680", Offset = "0x4E1A080", VA = "0x184E1B680")]
		private bool PJPEEBEOHDG(float PCMPCCDMENE, float BMNHOPLJPGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4E19420", Offset = "0x4E17E20", VA = "0x184E19420")]
		private Dictionary<string, object> FCCEPNGEFDD(string EGOBGJAOHHJ, Dictionary<string, object> IHOFIDAONNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C3B0", Offset = "0x4E1ADB0", VA = "0x184E1C3B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A730", Offset = "0x4E19130", VA = "0x184E1A730")]
		[CompilerGenerated]
		private long JALFDNDFNIG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4E183D0", Offset = "0x4E16DD0", VA = "0x184E183D0")]
		[CompilerGenerated]
		private void ALPCEAPJMNL(int FGANHBFCMFA)
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
			[Cpp2IlInjected.Address(RVA = "0x58E2B0", Offset = "0x58CCB0", VA = "0x18058E2B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C810", Offset = "0x4E1B210", VA = "0x184E1C810")]
		public static BJBMAJKFJME AEEGCHIFHAD(string NAGACMCOIBH, [NotNull] string DCHDIFKPLLE, long OGJDKGPMPGC, long PHOBGAMIGAM, string GBDOKMJFPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C8F0", Offset = "0x4E1B2F0", VA = "0x184E1C8F0")]
		public static BJBMAJKFJME DHGEBIGOAEE(string NAGACMCOIBH, [NotNull] string DCHDIFKPLLE, long OGJDKGPMPGC, long PHOBGAMIGAM, string GBDOKMJFPKL, long KIFDGBEJHGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CDA0", Offset = "0x4E1B7A0", VA = "0x184E1CDA0")]
		private AmplitudeAnalyticsEvent(string NAGACMCOIBH, [NotNull] string DCHDIFKPLLE, long OGJDKGPMPGC, long PHOBGAMIGAM, string GBDOKMJFPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xD03B70", Offset = "0xD02570", VA = "0x180D03B70")]
		public void BKLGOMMBBEL(long FABLPCLAIIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CC20", Offset = "0x4E1B620", VA = "0x184E1CC20", Slot = "5")]
		public override void KLBKKBPHGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CD30", Offset = "0x4E1B730", VA = "0x184E1CD30", Slot = "6")]
		public override void NCKPKJMKAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E1C9E0", Offset = "0x4E1B3E0", VA = "0x184E1C9E0", Slot = "4")]
		protected override Dictionary<string, object> DJHHHBAIJCO(Dictionary<string, object> JFOHGNFMHPG)
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
			[Cpp2IlInjected.Address(RVA = "0x4E1DCB0", Offset = "0x4E1C6B0", VA = "0x184E1DCB0")]
			public void FCNMOOPHKMJ(Dictionary<string, object> BOJMGAPFIFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E22790", Offset = "0x4E21190", VA = "0x184E22790")]
			public void FCNMOOPHKMJ(Dictionary<string, object> OCPCOEOKMFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x1CCCB00", Offset = "0x1CCB500", VA = "0x181CCCB00")]
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
			[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CF40", Offset = "0x4E1B940", VA = "0x184E1CF40")]
		public static ALLDJPBGIHI AEEGCHIFHAD(string NAGACMCOIBH, string GBDOKMJFPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D490", Offset = "0x4E1BE90", VA = "0x184E1D490")]
		protected AmplitudeAnalyticsIdentifyMessage(string NAGACMCOIBH, string GBDOKMJFPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D2C0", Offset = "0x4E1BCC0", VA = "0x184E1D2C0")]
		public Dictionary<string, object> DPAMOILEKMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D080", Offset = "0x4E1BA80", VA = "0x184E1D080", Slot = "4")]
		protected virtual Dictionary<string, object> DJHHHBAIJCO(Dictionary<string, object> JFOHGNFMHPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x4E1CFE0", Offset = "0x4E1B9E0", VA = "0x184E1CFE0")]
		protected void CGCNDCILKNL(string IPKOPOLJGIA, Dictionary<string, object> DCJKKOLDAPK, Dictionary<string, object> MAGGDIIICKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D3B0", Offset = "0x4E1BDB0", VA = "0x184E1D3B0")]
		protected void LJBPLFODIGA(string IPKOPOLJGIA, string HPIAFNBPEPC, Dictionary<string, object> CPLFDNIMMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D330", Offset = "0x4E1BD30", VA = "0x184E1D330", Slot = "5")]
		public virtual void KLBKKBPHGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E1D420", Offset = "0x4E1BE20", VA = "0x184E1D420", Slot = "6")]
		public virtual void NCKPKJMKAMP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ALLDJPBGIHI : global::LLKFBGIJDPD<AmplitudeAnalyticsIdentifyMessage, ALLDJPBGIHI>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override ALLDJPBGIHI OANBBNCNAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6452E0", Offset = "0x643CE0", VA = "0x1806452E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage BALBFLJGFCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E18160", Offset = "0x4E16B60", VA = "0x184E18160")]
	public ALLDJPBGIHI(AmplitudeAnalyticsIdentifyMessage OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4E180D0", Offset = "0x4E16AD0", VA = "0x184E180D0", Slot = "4")]
	public override void NCKPKJMKAMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BJBMAJKFJME : global::LLKFBGIJDPD<AmplitudeAnalyticsEvent, BJBMAJKFJME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool GNGBFNKKDJP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override BJBMAJKFJME OANBBNCNAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6452E0", Offset = "0x643CE0", VA = "0x1806452E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D750", Offset = "0x4E1C150", VA = "0x184E1D750")]
	public BJBMAJKFJME(AmplitudeAnalyticsEvent OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480", Slot = "5")]
	public override AmplitudeAnalyticsEvent BALBFLJGFCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D5D0", Offset = "0x4E1BFD0", VA = "0x184E1D5D0", Slot = "4")]
	public override void NCKPKJMKAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B94C80", Offset = "0x2B93680", VA = "0x182B94C80")]
	public BJBMAJKFJME FPCLDDBKGHI<T>(string LIHBMCPCJED, T[] HPIAFNBPEPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D5C0", Offset = "0x4E1BFC0", VA = "0x184E1D5C0")]
	public BJBMAJKFJME FPCLDDBKGHI(string LIHBMCPCJED, string[] HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B94C10", Offset = "0x2B93610", VA = "0x182B94C10")]
	public BJBMAJKFJME FPCLDDBKGHI<T>(string LIHBMCPCJED, T HPIAFNBPEPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D550", Offset = "0x4E1BF50", VA = "0x184E1D550")]
	public BJBMAJKFJME FPCLDDBKGHI(string LIHBMCPCJED, string HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D670", Offset = "0x4E1C070", VA = "0x184E1D670")]
	private BJBMAJKFJME OEILJFEBKDK(string LIHBMCPCJED, object HPIAFNBPEPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NKKIFBLDPNO : BJBMAJKFJME
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4E1D750", Offset = "0x4E1C150", VA = "0x184E1D750")]
	public NKKIFBLDPNO(AmplitudeAnalyticsEvent OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4E22160", Offset = "0x4E20B60", VA = "0x184E22160", Slot = "4")]
	public override void NCKPKJMKAMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class LLKFBGIJDPD<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::LLKFBGIJDPD<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M OLLHPIFFHKE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR OANBBNCNAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x178A0C0", Offset = "0x1788AC0", VA = "0x18178A0C0")]
	public LLKFBGIJDPD(M OLLHPIFFHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3B73360", Offset = "0x3B71D60", VA = "0x183B73360")]
	public BLDR EOLOCMGIDJO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo PJOHCMJCIPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3B73520", Offset = "0x3B71F20", VA = "0x183B73520")]
	public BLDR OFHNCMKGLIM(AmplitudeAnalyticsIdentifyMessage.RevenueData CIAFHCDFHLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B73480", Offset = "0x3B71E80", VA = "0x183B73480")]
	public BLDR LADIEGFJGMH(string LIHBMCPCJED, string HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2B9E680", Offset = "0x2B9D080", VA = "0x182B9E680")]
	public BLDR LADIEGFJGMH<T>(string LIHBMCPCJED, T HPIAFNBPEPC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NCKPKJMKAMP();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B734F0", Offset = "0x3B71EF0", VA = "0x183B734F0")]
	internal static string NPKMOFCNFHK(string HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3B733A0", Offset = "0x3B71DA0", VA = "0x183B733A0")]
	private BLDR HPLJEFBFLOD(string LIHBMCPCJED, object HPIAFNBPEPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M BALBFLJGFCE();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JHDOHJCPJAG
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string KIIBJNPPKDK = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string AHDGPPCOMHJ = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string FLGPHLOLGMB = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string PFPPGOBPPIN = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string ADGIMJIAOKC = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string LHCCIGPCCAO = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string OAHIKFKBGEE = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string FJCPDAANFKN = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string OGDLGIDFCOF = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string DEFDKGKOBLL = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string LLKJENHONLG = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string HOMLAINPPMJ = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string GKCLNBPNJKO = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string KFOKLPKMKGG = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string DBFOLDDJAGI = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string MHPKHGMIMBO = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string EINAMLGAKBJ = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string MDDJKJEPLNM = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string EGELNHLFHJC = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string HDABCKDAGNO = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string LPKIFADPBKM = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string FNMFPKHLOIO = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public JHDOHJCPJAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FDFBBEKEOKF
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int LENLFHBNHBE = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int LIEBCPIINJC = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int GLEDLMIBEHH = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long FJOHGDIEHOA = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int IMBGGOKMEGM = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int IDCGOAIFAJC = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string BLAPFICKDKC = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string FMGGMGABJLN = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string OBPAJDEOLKA = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string AFCLENNJJPF = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string IFHEFFOBAHL = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string GFHOLKOLBON = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string EDGCIOHPBJM = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string CBEIKDBEGIJ = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string AHEJHAGJINM = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string LAKPODLCPGF = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string GELCDIPAFMB = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string FKHGPIGMHBB = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string PLNMMLIGEKB = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string BEAIABIABHD = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string GDMJILLGPCG = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string JBCEOLICAKB = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string LJBNNMAPBNH = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string BPBBJMEJNGA = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string KIFMMEEIJNL = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string OHFIFDMBNFM = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string BDJNACMCGHM = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string DLBJIJKGEIJ = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string BMNHDAIANBL = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string FKCIHHKFNOF = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string BKOINABGAIM = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string KPLBIHNAKFA = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string ADGIMJIAOKC = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string FFLMPODGABN = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int GLMKHGBPBOM = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OHEHEBGGKMP;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DDD0", Offset = "0x4E1C7D0", VA = "0x184E1DDD0")]
	internal static bool NOAFAECOPAN(string IPKOPOLJGIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public FDFBBEKEOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HGJFGFLIIAG
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool NPJNDBPPGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string HMCLIHAAPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string CJLLNAFCPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string EIAEHHECJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string KOFPGEDGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::HJGFLNHHJHD<PINCNKJGINJ> CNFLBJNKNEK(string AOLKNBAHDEO, Dictionary<string, string> BOBGFLDBHDM);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::HJGFLNHHJHD<PINCNKJGINJ> PJDAJMEMPOM(string AOLKNBAHDEO, string NOCLJDKGDGE, string CGECAIKCPIL, string AJHMCOCANKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PINCNKJGINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int IMGEDDAPFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string HCDDIHDPMKG;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x590980", Offset = "0x58F380", VA = "0x180590980")]
	public PINCNKJGINJ(int HOMEEOADEBJ, string EAFFKNPLDID)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4E20B30", Offset = "0x4E1F530", VA = "0x184E20B30")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4E20800", Offset = "0x4E1F200", VA = "0x184E20800")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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

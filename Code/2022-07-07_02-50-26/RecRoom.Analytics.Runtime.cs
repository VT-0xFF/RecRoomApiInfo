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
public class PAMFCLMLDOE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string IEHBOLCAKJF = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string DNONGEDKHLE = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string BPBFGCELMAE = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string KJFMDFOPABM = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string BEPFFEIJEOM = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string CEKGICHIGHJ = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string INKDLJANLKN = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long GCILGOHGFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NCJCGDKACMI GOADGNCNFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool ENBEADCKPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float BJNIEDHODHA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50F7DD0", Offset = "0x50F6FD0", VA = "0x1850F7DD0")]
	public PAMFCLMLDOE(string HFIABLKHKDC, float BJNIEDHODHA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x260DDD0", Offset = "0x260CFD0", VA = "0x18260DDD0")]
	public void AINJMAEMDBD<T>(string AFDIALBCNMA, T LDPMPDNIHLJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50F7A30", Offset = "0x50F6C30", VA = "0x1850F7A30")]
	public void AINJMAEMDBD(string AFDIALBCNMA, string LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x50F7B00", Offset = "0x50F6D00", VA = "0x1850F7B00")]
	public void COJIIOECIJP(string FLJLCKPEKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x50F7D20", Offset = "0x50F6F20", VA = "0x1850F7D20")]
	public void PIHEMOHPFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x50F7C20", Offset = "0x50F6E20", VA = "0x1850F7C20")]
	private void GIBPPJDCDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x50F7AB0", Offset = "0x50F6CB0", VA = "0x1850F7AB0")]
	private bool AONHHCHEIKM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GMIHGEAADAK
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KJNBDKOEMOC INKIGOFOFOG(string JEAPJACGHNP, string IBMPCBPMGNP, [Optional] DHDAHHIPKCD DEPACOJCCOF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KJNBDKOEMOC BEDODAMHIJN(DHDAHHIPKCD DEPACOJCCOF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ACPNBKLBIOJ(string FHBMICNCPND);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCDMFFIMKJA JBGKCEBBIDC(string DMHLPMNGOCH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MCDMFFIMKJA JJGCDPLJABI(string BNMGJEHHLHM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KJNBDKOEMOC FHJGKMHPLLC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IMCKKIIJAHJ : GMIHGEAADAK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string KKEKMEFPNLG = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string JKDKAJFGGDI = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string FOMHBMAGPEI = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string CHGGNLJDFPI = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string IMBHCCNMNAO = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string AFLKCFFBPNF = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string LDCDIEHFCHM = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string OEOICECNLCA = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string FKFICCLHPPN = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, OFPJBGNCBFC> HKCBKFJOLHG;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int NAGHGGBEPIA = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool BJMMBBAAKLF;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	[Preserve]
	public IMCKKIIJAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x50F4A10", Offset = "0x50F3C10", VA = "0x1850F4A10")]
	[OFEHMNLHHIP(LIDFJGFJDHH.Unity_BeforeSceneLoad)]
	private static void BPGCKEIOKPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x50F50D0", Offset = "0x50F42D0", VA = "0x1850F50D0", Slot = "4")]
	public KJNBDKOEMOC INKIGOFOFOG(string JEAPJACGHNP, string IBMPCBPMGNP, [Optional] DHDAHHIPKCD DEPACOJCCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50F4B70", Offset = "0x50F3D70", VA = "0x1850F4B70", Slot = "9")]
	public KJNBDKOEMOC FHJGKMHPLLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50F48C0", Offset = "0x50F3AC0", VA = "0x1850F48C0", Slot = "5")]
	public KJNBDKOEMOC BEDODAMHIJN(DHDAHHIPKCD DEPACOJCCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50F4800", Offset = "0x50F3A00", VA = "0x1850F4800", Slot = "6")]
	public bool ACPNBKLBIOJ(string FHBMICNCPND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50F54D0", Offset = "0x50F46D0", VA = "0x1850F54D0", Slot = "7")]
	public MCDMFFIMKJA JBGKCEBBIDC(string DMHLPMNGOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50F55E0", Offset = "0x50F47E0", VA = "0x1850F55E0", Slot = "8")]
	public MCDMFFIMKJA JJGCDPLJABI(string BNMGJEHHLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50F4CB0", Offset = "0x50F3EB0", VA = "0x1850F4CB0")]
	private IBNKBFJABLA HEGGBBMCGDD(DHDAHHIPKCD DEPACOJCCOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x50F56D0", Offset = "0x50F48D0", VA = "0x1850F56D0")]
	private EEADKCFMMHJ NGIDEHHKMKJ(string IBMPCBPMGNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x50F5850", Offset = "0x50F4A50", VA = "0x1850F5850")]
	private void PIBGALAEFCE(string DMHLPMNGOCH, MCDMFFIMKJA DLEGCAANBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E7A90", Offset = "0x7E6C90", VA = "0x1807E7A90")]
	[CompilerGenerated]
	private void LLBCAIOEILC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NMAPHEFBHPJ
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAMFCLMLDOE CIJKANKJMOI(string HFIABLKHKDC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DHDAHHIPKCD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EGPLDFLMJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JMFCOKJEKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GHBBGGCLEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NIKKJPIAJGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? BLDLKIMJKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? AHEAAJIEDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int FJOEEJNAGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string FKBCMDLFHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string CGKGKHAGIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string PBPFFILKCNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KIKEDFDJIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string BFNJCMMHCOJ
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
		public AmplitudeAnalyticsClient.Settings OBCFBJICNFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DPFLFELAJMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x58A190", Offset = "0x589390", VA = "0x18058A190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum KDEKFDKGDMI
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum JDMIEAKMKHJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class CPNPPKPJJDP
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class JDFIIDHNKHG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int MNHIHBMJBNB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> CPKEBEKGFDE;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
				public JDFIIDHNKHG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class NBLAAHOHBMP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
				public NBLAAHOHBMP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x50F70B0", Offset = "0x50F62B0", VA = "0x1850F70B0")]
				internal bool <GetBatch>b__0(JDFIIDHNKHG item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string HLKGJCCFJHH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string ACCIHAJODLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<JDFIIDHNKHG> PMGAEFKEMGP;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? BEPLCLKINNJ
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x50F4030", Offset = "0x50F3230", VA = "0x1850F4030")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? KAFOGEDJPMI
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x50F3670", Offset = "0x50F2870", VA = "0x1850F3670")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x50F40C0", Offset = "0x50F32C0", VA = "0x1850F40C0")]
			internal CPNPPKPJJDP(string DKINOHELPPD, string IBMPCBPMGNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x50F3850", Offset = "0x50F2A50", VA = "0x1850F3850")]
			public int LJLOBCJLDFO([Optional] int? MKKLKOFKMNB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x50F3E30", Offset = "0x50F3030", VA = "0x1850F3E30")]
			public List<Dictionary<string, object>> OPLFMDAKGBO(int PBAHCDKGKGH, int? MKKLKOFKMNB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x50F33E0", Offset = "0x50F25E0", VA = "0x1850F33E0")]
			public void EGADLPNFNND(AmplitudeAnalyticsIdentifyMessage ANFJLMLDELH, bool LJFHNPGGGCN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x50F32E0", Offset = "0x50F24E0", VA = "0x1850F32E0")]
			public void EGADLPNFNND(Dictionary<string, object> ANFJLMLDELH, bool LJFHNPGGGCN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x50F39B0", Offset = "0x50F2BB0", VA = "0x1850F39B0")]
			public void NIIMFAIDDPE(params Dictionary<string, object>[] LDDEPAGPLAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x50F3B00", Offset = "0x50F2D00", VA = "0x1850F3B00")]
			public void ODIHOMEBMND(List<Dictionary<string, object>> GJMCEEBLOPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x50F3D20", Offset = "0x50F2F20", VA = "0x1850F3D20")]
			private void OMNKCCLHAEM(Dictionary<string, object> ANFJLMLDELH, bool LJFHNPGGGCN = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x50F3480", Offset = "0x50F2680", VA = "0x1850F3480")]
			public void FKPBEKDKALM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x50F2F10", Offset = "0x50F2110", VA = "0x1850F2F10")]
			private void ABJBMFGKKJL([Optional] string MFNPMHDHAHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x50F3720", Offset = "0x50F2920", VA = "0x1850F3720")]
			private static string LFPKEHADBGC(string LDPMPDNIHLJ, string ICIBGJCBOAM)
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
			[Cpp2IlInjected.Address(RVA = "0x50F8050", Offset = "0x50F7250", VA = "0x1850F8050")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct NKCGJIGLCKB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int DPOCMCGENBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string FIKMGBNPDNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T PEBANLICDNH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NKJPJJGPMAI : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private KIKOFGNMMEC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public NKJPJJGPMAI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x50F7310", Offset = "0x50F6510", VA = "0x1850F7310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x50F79E0", Offset = "0x50F6BE0", VA = "0x1850F79E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CJIOHIEEAEI : IEnumerator<object>, IEnumerator, IDisposable
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
			public JLGLDFIOJOP quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public CJIOHIEEAEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x50F2DD0", Offset = "0x50F1FD0", VA = "0x1850F2DD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x50F2EC0", Offset = "0x50F20C0", VA = "0x1850F2EC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class AJAJBHCDNEF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public AJAJBHCDNEF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x50ED870", Offset = "0x50ECA70", VA = "0x1850ED870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x50ED9E0", Offset = "0x50ECBE0", VA = "0x1850ED9E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JCPPOJLAPMN : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private KIKOFGNMMEC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public JCPPOJLAPMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x50F6100", Offset = "0x50F5300", VA = "0x1850F6100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x50F6330", Offset = "0x50F5530", VA = "0x1850F6330", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class GOLJHGOAJJI : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private KIKOFGNMMEC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public GOLJHGOAJJI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x50F4420", Offset = "0x50F3620", VA = "0x1850F4420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x50F4660", Offset = "0x50F3860", VA = "0x1850F4660", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KFHOOKBKDGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CPNPPKPJJDP cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
			public KFHOOKBKDGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x50F6380", Offset = "0x50F5580", VA = "0x1850F6380")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x50F6420", Offset = "0x50F5620", VA = "0x1850F6420")]
			internal void <FlushFromCache>b__1(NKCGJIGLCKB<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class LKMOGOKEIMP : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private KIKOFGNMMEC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public CPNPPKPJJDP cache;

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
			private KFHOOKBKDGC <>8__1;

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
			private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public LKMOGOKEIMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x50F6820", Offset = "0x50F5A20", VA = "0x1850F6820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x50F6EE0", Offset = "0x50F60E0", VA = "0x1850F6EE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class MFJPOGGDPLN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
			public MFJPOGGDPLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x44A2570", Offset = "0x44A1770", VA = "0x1844A2570")]
			internal NKCGJIGLCKB<T> <PostRudderStackJson>b__0(IIKGDELCCBI postResponse)
			{
				return default(NKCGJIGLCKB<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class JICCIJJNINK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
			public JICCIJJNINK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x44A2570", Offset = "0x44A1770", VA = "0x1844A2570")]
			internal NKCGJIGLCKB<T> <PostAmplitudeJson>b__0(IIKGDELCCBI postResponse)
			{
				return default(NKCGJIGLCKB<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private MADKLNMOPEK DEHCMHDHKCB;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string KMLCIHFCHOA = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string PIKKKDCAHOC = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string FFPFHPELCAC = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string EJKBIJNOCHO = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string FFDIDLPPNJE = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int NBGDLJKFPML = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int FMLJHGKLMAC = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int LIIBLNIIOEP = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float FGNPDIOBCAP = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long EEFOBFIDOLN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string PBJIDEEHAEI = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string OMJOPMIIMDC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool KCPEBDOBMPN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool IKKDNBHHCFD;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int NMCMJGEFDKI;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int DPMECANKJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private FMLGPKGGGFM MDGDEAHAPIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool AEMANGOONEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float AAFAMFHDKGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float HNKGCBEDLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int GJDCKICGADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int BBBDMAEPIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? IDJOCEHJDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? HGDGNICGENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long KMJDCJCNCNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string HFBHHMOEAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long FBNPAIFNKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> GMMLOJPDBKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private JDMIEAKMKHJ PGIAOOAJFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int MLLKPHMFNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int NCIKDEAHFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float KFCCLPGNGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool AKOGODDJDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool OGNJALMELLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private CPNPPKPJJDP FOIGOOEOFGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CPNPPKPJJDP GBIJOIOIHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private CPNPPKPJJDP GIKKGCFDDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> NLGKIFODDEF;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo IDHJGDOENNL;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string KBMHLFFAGPD;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string FLGMINKKKDG = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string FBLLCHCPKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string BAPOPDFMJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string DNFGOECGLCJ;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string GJFGIEOBLOK = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string FJBCLHCEAEO = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MADKLNMOPEK OJJFDBFDDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x50EFBC0", Offset = "0x50EEDC0", VA = "0x1850EFBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int MHDDINDKJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x50EF640", Offset = "0x50EE840", VA = "0x1850EF640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long NKLOJCNNHFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x50F1F30", Offset = "0x50F1130", VA = "0x1850F1F30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x50F2030", Offset = "0x50F1230", VA = "0x1850F2030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string FAMMNHEPKBI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x50F1ED0", Offset = "0x50F10D0", VA = "0x1850F1ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string KDBGFJEJJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x50F1F00", Offset = "0x50F1100", VA = "0x1850F1F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string LCNFDBHOHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5AE700", Offset = "0x5AD900", VA = "0x1805AE700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x59C260", Offset = "0x59B460", VA = "0x18059C260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? AHEAAJIEDJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6138F0", Offset = "0x612AF0", VA = "0x1806138F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x11642D0", Offset = "0x11634D0", VA = "0x1811642D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KDEKFDKGDMI? HICLCGHEJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x615AA0", Offset = "0x614CA0", VA = "0x180615AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x25AB190", Offset = "0x25AA390", VA = "0x1825AB190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool FCPBDNCLPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB93F50", Offset = "0xB93150", VA = "0x180B93F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x185D730", Offset = "0x185C930", VA = "0x18185D730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool DOPNILDNFHD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x50F1DF0", Offset = "0x50F0FF0", VA = "0x1850F1DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> OKEJJGENHGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x50F1D50", Offset = "0x50F0F50", VA = "0x1850F1D50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x50F1F90", Offset = "0x50F1190", VA = "0x1850F1F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50EDC80", Offset = "0x50ECE80", VA = "0x1850EDC80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x50EF9C0", Offset = "0x50EEBC0", VA = "0x1850EF9C0")]
		private void IBOBMJPLIHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50F1770", Offset = "0x50F0970", VA = "0x1850F1770")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50F0EB0", Offset = "0x50F00B0", VA = "0x1850F0EB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x50F18F0", Offset = "0x50F0AF0", VA = "0x1850F18F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50F0F50", Offset = "0x50F0150", VA = "0x1850F0F50")]
		public KJNBDKOEMOC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x50EFFA0", Offset = "0x50EF1A0", VA = "0x1850EFFA0")]
		[IteratorStateMachine(typeof(NKJPJJGPMAI))]
		public IEnumerator<KIKOFGNMMEC> Initialize(AmplitudeAnalyticsEvent OAIOFJPFPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x50F1840", Offset = "0x50F0A40", VA = "0x1850F1840")]
		public void UpdateLastAliveTime(float DEPDIALJLNJ = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x50EDA30", Offset = "0x50ECC30", VA = "0x1850EDA30")]
		private KJNBDKOEMOC ADIDLGFDNGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x50F0C80", Offset = "0x50EFE80", VA = "0x1850F0C80")]
		private KJNBDKOEMOC OOHPEKHNGJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50F1400", Offset = "0x50F0600", VA = "0x1850F1400")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50F0030", Offset = "0x50EF230", VA = "0x1850F0030")]
		[IteratorStateMachine(typeof(CJIOHIEEAEI))]
		private IEnumerator JCGCPAOMMHC(JLGLDFIOJOP PNOIBLEIGEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50F1B50", Offset = "0x50F0D50", VA = "0x1850F1B50")]
		[IteratorStateMachine(typeof(AJAJBHCDNEF))]
		public IEnumerator WaitForFlush(float FKFAPCMFFOJ = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x50F1780", Offset = "0x50F0980", VA = "0x1850F1780")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50EFCA0", Offset = "0x50EEEA0", VA = "0x1850EFCA0")]
		public static FLEDJONNAPM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x50EDB40", Offset = "0x50ECD40", VA = "0x1850EDB40")]
		public static NCJCGDKACMI AccountSelectionPostLoginEvent([NotNull] string HFAFFNOMMCI, string ENJFPBFNMNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x50EF030", Offset = "0x50EE230", VA = "0x1850EF030")]
		public static NCJCGDKACMI Event([NotNull] string HFAFFNOMMCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x50F0FD0", Offset = "0x50F01D0", VA = "0x1850F0FD0")]
		public static NCJCGDKACMI PreviousSessionEvent([NotNull] string HFAFFNOMMCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x50EFDE0", Offset = "0x50EEFE0", VA = "0x1850EFDE0")]
		public static NCJCGDKACMI InitializeEvent(string ENJFPBFNMNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x50F1510", Offset = "0x50F0710", VA = "0x1850F1510")]
		public static NCJCGDKACMI StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x50EE040", Offset = "0x50ED240", VA = "0x1850EE040")]
		public static NCJCGDKACMI CreateOutOfSessionEvent(string HFAFFNOMMCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x50F0730", Offset = "0x50EF930", VA = "0x1850F0730")]
		public static KJNBDKOEMOC LogOutOfSessionEvent(NCJCGDKACMI GNPNIKJGNOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x50F0580", Offset = "0x50EF780", VA = "0x1850F0580")]
		public void LogEventAsync(AmplitudeAnalyticsEvent DNKMDACDOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50F0A60", Offset = "0x50EFC60", VA = "0x1850F0A60")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent DNKMDACDOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x50F0B30", Offset = "0x50EFD30", VA = "0x1850F0B30")]
		public void LogSerializedEventAsync(Dictionary<string, object> GHEDCOOOPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x50F0650", Offset = "0x50EF850", VA = "0x1850F0650")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage MMFHJGGLBBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x50F03E0", Offset = "0x50EF5E0", VA = "0x1850F03E0")]
		private void KLCIDDFHFLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x50F01B0", Offset = "0x50EF3B0", VA = "0x1850F01B0")]
		private void KJNLKPGLPGP(Dictionary<string, object> OELODJPDBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x50F00C0", Offset = "0x50EF2C0", VA = "0x1850F00C0")]
		private void JDGEOJLOGHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x50EE300", Offset = "0x50ED500", VA = "0x1850EE300")]
		private void DHLDPGDFOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x50EF5A0", Offset = "0x50EE7A0", VA = "0x1850EF5A0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x50EEFB0", Offset = "0x50EE1B0", VA = "0x1850EEFB0")]
		[IteratorStateMachine(typeof(JCPPOJLAPMN))]
		private IEnumerator<KIKOFGNMMEC> ECBJANAOGAC(float FKFAPCMFFOJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x50F0C00", Offset = "0x50EFE00", VA = "0x1850F0C00")]
		[IteratorStateMachine(typeof(GOLJHGOAJJI))]
		private IEnumerator<KIKOFGNMMEC> OEJKAJKDPEI(float FKFAPCMFFOJ = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x50EDF60", Offset = "0x50ED160", VA = "0x1850EDF60")]
		[IteratorStateMachine(typeof(LKMOGOKEIMP))]
		private IEnumerator<KIKOFGNMMEC> CJFHGOBPENL(CPNPPKPJJDP PHICLPBHDPD, int? MKKLKOFKMNB, string PBPKGGBMNMM, string FONBEBFPJKB, float FKFAPCMFFOJ, Action<int> DIAEFMLCFNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x50F0490", Offset = "0x50EF690", VA = "0x1850F0490")]
		private static void LLCJBCEAGOP(bool ECOLMNKFJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x50EF190", Offset = "0x50EE390", VA = "0x1850EF190")]
		private global::FJLAHCBCPIJ<NKCGJIGLCKB<Dictionary<string, object>>> FJAGDJEFAGM(string PBPKGGBMNMM, string FONBEBFPJKB, string IKLAMEEJDAL, string IFFHKDAKPMN, Dictionary<string, object> PEBANLICDNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x50EF300", Offset = "0x50EE500", VA = "0x1850EF300")]
		private global::FJLAHCBCPIJ<NKCGJIGLCKB<List<Dictionary<string, object>>>> FJAGDJEFAGM(string PBPKGGBMNMM, string FONBEBFPJKB, string IKLAMEEJDAL, string IFFHKDAKPMN, List<Dictionary<string, object>> PEBANLICDNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1C95340", Offset = "0x1C94540", VA = "0x181C95340")]
		private global::FJLAHCBCPIJ<NKCGJIGLCKB<T>> ENPIOAGLGGM<T>(string PBPKGGBMNMM, string FONBEBFPJKB, string IFFHKDAKPMN, T PEBANLICDNH, Dictionary<string, object> BPDPJIKBMHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1C95070", Offset = "0x1C94270", VA = "0x181C95070")]
		private global::FJLAHCBCPIJ<NKCGJIGLCKB<T>> BOMPBBFDHNB<T>(string PBPKGGBMNMM, string FONBEBFPJKB, string IKLAMEEJDAL, T PEBANLICDNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x50EDAF0", Offset = "0x50ECCF0", VA = "0x1850EDAF0")]
		private bool AJOKIAMPJHE(float POBKADFLILN, float FKFAPCMFFOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x50EE490", Offset = "0x50ED690", VA = "0x1850EE490")]
		private Dictionary<string, object> EADKLIJGKKB(string FONBEBFPJKB, Dictionary<string, object> PEBANLICDNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x50F1C30", Offset = "0x50F0E30", VA = "0x1850F1C30")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x50EF860", Offset = "0x50EEA60", VA = "0x1850EF860")]
		[CompilerGenerated]
		private long GKFDCGAPBCL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x50EF630", Offset = "0x50EE830", VA = "0x1850EF630")]
		[CompilerGenerated]
		private void GDGIPGNJNAE(int MLGPAKMEKCA)
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
			[Cpp2IlInjected.Address(RVA = "0x590620", Offset = "0x58F820", VA = "0x180590620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x50F2430", Offset = "0x50F1630", VA = "0x1850F2430")]
		public static NCJCGDKACMI MFDAKPCHIOJ(string BGPOJNMOBBK, [NotNull] string NIKIPIACDGO, long IAPPFJGOKBC, long CGNJFCELOPJ, string ENJFPBFNMNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x50F2340", Offset = "0x50F1540", VA = "0x1850F2340")]
		public static NCJCGDKACMI KALEPLKBFIJ(string BGPOJNMOBBK, [NotNull] string NIKIPIACDGO, long IAPPFJGOKBC, long CGNJFCELOPJ, string ENJFPBFNMNE, long LOGNIEFPOIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x50F2620", Offset = "0x50F1820", VA = "0x1850F2620")]
		private AmplitudeAnalyticsEvent(string BGPOJNMOBBK, [NotNull] string NIKIPIACDGO, long IAPPFJGOKBC, long CGNJFCELOPJ, string ENJFPBFNMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1308210", Offset = "0x1307410", VA = "0x181308210")]
		public void HMKOKIOEMML(long CMOHPGOIDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x50F2510", Offset = "0x50F1710", VA = "0x1850F2510", Slot = "5")]
		public override void OEEAAALFGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x50F22D0", Offset = "0x50F14D0", VA = "0x1850F22D0", Slot = "6")]
		public override void GKCGMJJDFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x50F2090", Offset = "0x50F1290", VA = "0x1850F2090", Slot = "4")]
		protected override Dictionary<string, object> DNKGEOHLOIE(Dictionary<string, object> NEHEFBEMMGD)
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
			[Cpp2IlInjected.Address(RVA = "0x50F4220", Offset = "0x50F3420", VA = "0x1850F4220")]
			public void LICNNCDCPON(Dictionary<string, object> CDFOLJGFONL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x50F7F30", Offset = "0x50F7130", VA = "0x1850F7F30")]
			public void LICNNCDCPON(Dictionary<string, object> CACBOHAJICE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x1606930", Offset = "0x1605B30", VA = "0x181606930")]
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
			[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x58A490", Offset = "0x589690", VA = "0x18058A490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x50F2BF0", Offset = "0x50F1DF0", VA = "0x1850F2BF0")]
		public static FLEDJONNAPM MFDAKPCHIOJ(string BGPOJNMOBBK, string ENJFPBFNMNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x50F2D10", Offset = "0x50F1F10", VA = "0x1850F2D10")]
		protected AmplitudeAnalyticsIdentifyMessage(string BGPOJNMOBBK, string ENJFPBFNMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x50F27C0", Offset = "0x50F19C0", VA = "0x1850F27C0")]
		public Dictionary<string, object> ADGHMLGLFHN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x50F2830", Offset = "0x50F1A30", VA = "0x1850F2830", Slot = "4")]
		protected virtual Dictionary<string, object> DNKGEOHLOIE(Dictionary<string, object> NEHEFBEMMGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x50F2AE0", Offset = "0x50F1CE0", VA = "0x1850F2AE0")]
		protected void KHEOGDAOGIH(string ICIBGJCBOAM, Dictionary<string, object> LMBIKMBLGHB, Dictionary<string, object> PJNAMMFMEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x50F2B80", Offset = "0x50F1D80", VA = "0x1850F2B80")]
		protected void MDMNOECBFDE(string ICIBGJCBOAM, string LDPMPDNIHLJ, Dictionary<string, object> FOLPEMJHAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x50F2C90", Offset = "0x50F1E90", VA = "0x1850F2C90", Slot = "5")]
		public virtual void OEEAAALFGEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x50F2A70", Offset = "0x50F1C70", VA = "0x1850F2A70", Slot = "6")]
		public virtual void GKCGMJJDFPL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FLEDJONNAPM : global::CJBNLKEIEHE<AmplitudeAnalyticsIdentifyMessage, FLEDJONNAPM>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override FLEDJONNAPM GICFNAGLBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x63FF60", Offset = "0x63F160", VA = "0x18063FF60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage AOMLAAJEFPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x50F43D0", Offset = "0x50F35D0", VA = "0x1850F43D0")]
	public FLEDJONNAPM(AmplitudeAnalyticsIdentifyMessage NJKILBPPEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x50F4340", Offset = "0x50F3540", VA = "0x1850F4340", Slot = "4")]
	public override void GKCGMJJDFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NCJCGDKACMI : global::CJBNLKEIEHE<AmplitudeAnalyticsEvent, NCJCGDKACMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool IJEEEJMGGND;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override NCJCGDKACMI GICFNAGLBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x63FF60", Offset = "0x63F160", VA = "0x18063FF60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x50F7060", Offset = "0x50F6260", VA = "0x1850F7060")]
	public NCJCGDKACMI(AmplitudeAnalyticsEvent NJKILBPPEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent AOMLAAJEFPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x50F7270", Offset = "0x50F6470", VA = "0x1850F7270", Slot = "4")]
	public override void GKCGMJJDFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x22E84C0", Offset = "0x22E76C0", VA = "0x1822E84C0")]
	public NCJCGDKACMI AINJMAEMDBD<T>(string AFDIALBCNMA, T[] LDPMPDNIHLJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x50F7110", Offset = "0x50F6310", VA = "0x1850F7110")]
	public NCJCGDKACMI AINJMAEMDBD(string AFDIALBCNMA, string[] LDPMPDNIHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x22E81A0", Offset = "0x22E73A0", VA = "0x1822E81A0")]
	public NCJCGDKACMI AINJMAEMDBD<T>(string AFDIALBCNMA, T LDPMPDNIHLJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x50F7120", Offset = "0x50F6320", VA = "0x1850F7120")]
	public NCJCGDKACMI AINJMAEMDBD(string AFDIALBCNMA, string LDPMPDNIHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x50F7190", Offset = "0x50F6390", VA = "0x1850F7190")]
	private NCJCGDKACMI FDLMCOCNOKF(string AFDIALBCNMA, object LDPMPDNIHLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class MKMNGBLHIPH : NCJCGDKACMI
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x50F7060", Offset = "0x50F6260", VA = "0x1850F7060")]
	public MKMNGBLHIPH(AmplitudeAnalyticsEvent NJKILBPPEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x50F6F30", Offset = "0x50F6130", VA = "0x1850F6F30", Slot = "4")]
	public override void GKCGMJJDFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class CJBNLKEIEHE<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::CJBNLKEIEHE<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M NJKILBPPEMD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR GICFNAGLBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DB50", Offset = "0x1E5CD50", VA = "0x181E5DB50")]
	public CJBNLKEIEHE(M NJKILBPPEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3A60", Offset = "0x2BA2C60", VA = "0x182BA3A60")]
	public BLDR LABECNEAFJK(AmplitudeAnalyticsIdentifyMessage.DeviceInfo GMPMHFOHGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3A20", Offset = "0x2BA2C20", VA = "0x182BA3A20")]
	public BLDR KIHGMBNMCCD(AmplitudeAnalyticsIdentifyMessage.RevenueData IDGHIIKPKGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3980", Offset = "0x2BA2B80", VA = "0x182BA3980")]
	public BLDR DIFPLFHDLOL(string AFDIALBCNMA, string LDPMPDNIHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D14070", Offset = "0x2D13270", VA = "0x182D14070")]
	public BLDR DIFPLFHDLOL<T>(string AFDIALBCNMA, T LDPMPDNIHLJ) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void GKCGMJJDFPL();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BA39F0", Offset = "0x2BA2BF0", VA = "0x182BA39F0")]
	internal static string IGICGBONNBK(string LDPMPDNIHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3AA0", Offset = "0x2BA2CA0", VA = "0x182BA3AA0")]
	private BLDR PGOHCIHOIBE(string AFDIALBCNMA, object LDPMPDNIHLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M AOMLAAJEFPG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LGLFJADDKDC
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string NBDMJMJJDIH = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string PNPBEPHDOPC = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string MPGOMMJDGIP = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string OACBLCMPNFB = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string BLJODNCKECB = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string EPEFIEAAIPI = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string IEDGMGNEEPI = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string FMLBIODLOAP = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string JFJNNIPMADK = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string OHFLLBFOMGL = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string BFFNFNEPELP = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string MGJDDJKNFMM = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string GKLIHGGILKN = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string LGLBMEGCBJC = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string OANAHJGINNP = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string HMMFJKDHMEN = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string AONBILGLGHA = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string JJPMPDJLKGH = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string GBKNACKPOHO = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string MLCFFBEHCGJ = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string MKKHMAJGOMM = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string MIMFABMECAN = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public LGLFJADDKDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IEOEBKKHDNJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int NGHOHIAIHNA = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int DOIIKNPCBBO = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int LMDDOJHCEFG = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long HGJILBHDGLC = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int HOLIFOOFGIP = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int KOGBAMAAOMO = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string HPGGACGPKCJ = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string ONKHBOLPBMI = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string DJGKIPIEDAP = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string OMJDNAKAECE = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string AKODEGECFFC = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string PKEDOMNPMCA = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string AMGBBGDMMJE = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string JMJLFPNMAAA = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string ELLIDMHIJGB = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string COPFLGDACMA = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string EOFACHKMHAF = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string ELDEPHANFPN = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string PELKDDILPEJ = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string DAPEFAKEBEB = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string APGFPDBNECB = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string HFMAHMACHFI = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string MAGAFFPKBLP = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string BJLDODJJAJF = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string MKAMHNOFCEI = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string GDBBCMICIMH = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string BEAOHFFHOJN = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string AGEGECDPGHF = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string GJDLINGGKDO = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string POJOAPJBPBM = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string JDMHBNBAHAH = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string PMMEDLLDNDD = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string BLJODNCKECB = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string KJMMJDGDGAL = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int LBBNHLHBALI = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JMLNMCGNDAI;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x50F46B0", Offset = "0x50F38B0", VA = "0x1850F46B0")]
	internal static bool PLJHLDGFLAF(string ICIBGJCBOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public IEOEBKKHDNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FMLGPKGGGFM
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool EGDMCKJAFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string CAKPAGKKLCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string ELBFPGDLPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string CDFMFNOECKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string MBMOIPBNKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::FJLAHCBCPIJ<IIKGDELCCBI> FJAGDJEFAGM(string PBPKGGBMNMM, Dictionary<string, string> ACNFIJDGKFF);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::FJLAHCBCPIJ<IIKGDELCCBI> EEPEOPLGLDF(string PBPKGGBMNMM, string KLNIMHIIFCH, string MEBEGFNKKHB, string AEECNBPNJCO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IIKGDELCCBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int NGCMKJGKIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string EOKPCBLMJLE;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x592CF0", Offset = "0x591EF0", VA = "0x180592CF0")]
	public IIKGDELCCBI(int DPOCMCGENBL, string FIKMGBNPDNF)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JABMDOENCKP
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] CDGDAHNLLDM;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int FDPMPGKGLAJ;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int LAEDHJMCKNO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger CJEJEKHBKEN;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JABMDOENCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x50F5E40", Offset = "0x50F5040", VA = "0x1850F5E40")]
	private static string DMHFLPDODAP(byte[] DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x50F5B10", Offset = "0x50F4D10", VA = "0x1850F5B10")]
	public static string AJIDJKNPAKB(byte[] NGIBJOEMFPL, bool MFLHBEHGGNL)
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
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
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

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
public class MFOBKNMKBBC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string PDHIDIKNDAO = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string GAGINHKHLCC = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string OMOLOPBHNKN = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string GDFDAFBLIJD = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string EILHCGMEMKP = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string LPEOGPDFCGE = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string FBEOOCAKHLB = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long MALBKMKCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PAODHBCCFHC ELNBLMANMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool MLFGDBNOFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float GEJONKEHDFO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DB87C0", Offset = "0x5DB6FC0", VA = "0x185DB87C0")]
	public MFOBKNMKBBC(string BPKLNLDIJOC, float GEJONKEHDFO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36D0650", Offset = "0x36CEE50", VA = "0x1836D0650")]
	public void MMPEIDGCPIL<T>(string MIGODNJAHNA, T CCIMHDCKHOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8740", Offset = "0x5DB6F40", VA = "0x185DB8740")]
	public void MMPEIDGCPIL(string MIGODNJAHNA, string CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8600", Offset = "0x5DB6E00", VA = "0x185DB8600")]
	public void IJLKJLNLHOH(string GHKIAIPHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8420", Offset = "0x5DB6C20", VA = "0x185DB8420")]
	public void EJCCJOKBPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DB84E0", Offset = "0x5DB6CE0", VA = "0x185DB84E0")]
	private void FIMPHOCMAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DB86F0", Offset = "0x5DB6EF0", VA = "0x185DB86F0")]
	private bool KMODEBGPMNN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JEIDONNPCMD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MLEPGEJLFCO CDFKCHBFAME(string BHDGFKDAFCI, string LIFGHIGLIDO, [Optional] IPDIODIHEFB BFPIGKGLHDN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLEPGEJLFCO GKPPHMGMMBF(IPDIODIHEFB BFPIGKGLHDN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MLEPGEJLFCO PFDICNLFBAD(IPDIODIHEFB BFPIGKGLHDN, Dictionary<string, string> DFPLFJHJBHJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DIMNEPCALAH(string LFJEOPCHJFK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OPOHDIKFDEB BONGHCNJHMB(string KGKNLLMJGDD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OPOHDIKFDEB LJEHMOJPOEF(string EGPBKBCLCHC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MLEPGEJLFCO JIPAAGBNILM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MMGAPIKKEDA : JEIDONNPCMD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string CDLDHDADBLO = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string LOIDPEGKCAF = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string MOEMGHKAMJM = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string OODLFAHJKJF = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string ENMNOIMBHDA = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string KOPBAAHMINN = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string OPMHAPBMPDJ = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string FHIOHIIEBPG = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string OAPDPDADDEG = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, AIHNKCONNAD> JLCLFFDDCKC;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int FKBHFPNCNPI = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool JAAIBLPHAJM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	[Preserve]
	public MMGAPIKKEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9810", Offset = "0x5DB8010", VA = "0x185DB9810")]
	[FBDCEBOAGGK(ABMKJHLOOPK.GameOnly)]
	private static void KGPLODFCBMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8A70", Offset = "0x5DB7270", VA = "0x185DB8A70", Slot = "4")]
	public MLEPGEJLFCO CDFKCHBFAME(string BHDGFKDAFCI, string LIFGHIGLIDO, [Optional] IPDIODIHEFB BFPIGKGLHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9680", Offset = "0x5DB7E80", VA = "0x185DB9680", Slot = "10")]
	public MLEPGEJLFCO JIPAAGBNILM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5DB94D0", Offset = "0x5DB7CD0", VA = "0x185DB94D0", Slot = "5")]
	public MLEPGEJLFCO GKPPHMGMMBF(IPDIODIHEFB BFPIGKGLHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9DF0", Offset = "0x5DB85F0", VA = "0x185DB9DF0", Slot = "6")]
	public MLEPGEJLFCO PFDICNLFBAD(IPDIODIHEFB BFPIGKGLHDN, Dictionary<string, string> DFPLFJHJBHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9420", Offset = "0x5DB7C20", VA = "0x185DB9420", Slot = "7")]
	public bool DIMNEPCALAH(string LFJEOPCHJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8960", Offset = "0x5DB7160", VA = "0x185DB8960", Slot = "8")]
	public OPOHDIKFDEB BONGHCNJHMB(string KGKNLLMJGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9B60", Offset = "0x5DB8360", VA = "0x185DB9B60", Slot = "9")]
	public OPOHDIKFDEB LJEHMOJPOEF(string EGPBKBCLCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8F10", Offset = "0x5DB7710", VA = "0x185DB8F10")]
	private ABOAPHNEOFM CGPHNFDOEBD(IPDIODIHEFB BFPIGKGLHDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9C50", Offset = "0x5DB8450", VA = "0x185DB9C50")]
	private OMHGLICELPO OLBPLCAEBFJ(string LIFGHIGLIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9910", Offset = "0x5DB8110", VA = "0x185DB9910")]
	private void KJMKNMLCGMB(string KGKNLLMJGDD, OPOHDIKFDEB LEPJIGHFGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8BED70", Offset = "0x8BD570", VA = "0x1808BED70")]
	[CompilerGenerated]
	private void BDACEHJCGGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OGDCNFGEAJJ
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MFOBKNMKBBC ADHLFECCOPH(string BPKLNLDIJOC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IPDIODIHEFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KKOFKOJDOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool POEPMMJPNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BIIAHECNGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LHIEACOODAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? IANLHFOGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? FIMNDOPHIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int JEFMJCJMOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string BFDOCLDHHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string LDDIMBAHEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string NKMKJHKENML
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string BKBDFJDBOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string CKFOMEHKIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
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
		public AmplitudeAnalyticsClient.Settings JFKNBGNNGCI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GLFDFELADLG
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F9B80", Offset = "0x6F8380", VA = "0x1806F9B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum FMDNMPDEMOL
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum HDEAOCHPHLI
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class KHKCPKNLPCA
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class NKEAFIAAMOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int OOEOJAIFJIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> JLPBEJJHOPN;

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
				public NKEAFIAAMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class CIDFPKGIAGG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
				public CIDFPKGIAGG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x5DB55D0", Offset = "0x5DB3DD0", VA = "0x185DB55D0")]
				internal bool <GetBatch>b__0(NKEAFIAAMOI item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string JNPMHPIEMGM = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string OIPMKBNDJIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<NKEAFIAAMOI> PNBGGIKBOMP;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? JJEMPMOMEDE
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x5DB69A0", Offset = "0x5DB51A0", VA = "0x185DB69A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? PHCLJOKBNMI
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x5DB7BF0", Offset = "0x5DB63F0", VA = "0x185DB7BF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7CB0", Offset = "0x5DB64B0", VA = "0x185DB7CB0")]
			internal KHKCPKNLPCA(string FHNDMBCOEON, string LIFGHIGLIDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6810", Offset = "0x5DB5010", VA = "0x185DB6810")]
			public int AKELKKAKBCC([Optional] int? BEOHPDPACAN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5DB70B0", Offset = "0x5DB58B0", VA = "0x185DB70B0")]
			public List<Dictionary<string, object>> IBGIHFIGABC(int AMMNDDOFIIM, int? BEOHPDPACAN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7340", Offset = "0x5DB5B40", VA = "0x185DB7340")]
			public void ILPJBDLCCAC(AmplitudeAnalyticsIdentifyMessage ODMJCJPGHNI, bool EOHNHFHBDMI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5DB73E0", Offset = "0x5DB5BE0", VA = "0x185DB73E0")]
			public void ILPJBDLCCAC(Dictionary<string, object> ODMJCJPGHNI, bool EOHNHFHBDMI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6B80", Offset = "0x5DB5380", VA = "0x185DB6B80")]
			public void GCBCOPHFNFE(params Dictionary<string, object>[] LDCABBEGGPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5DB79A0", Offset = "0x5DB61A0", VA = "0x185DB79A0")]
			public void LNAHCNLEEJB(List<Dictionary<string, object>> NGLFOHDIMBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6A40", Offset = "0x5DB5240", VA = "0x185DB6A40")]
			private void FJIAFCEKBAA(Dictionary<string, object> ODMJCJPGHNI, bool EOHNHFHBDMI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6E40", Offset = "0x5DB5640", VA = "0x185DB6E40")]
			public void HOPOFHDCFAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5DB74F0", Offset = "0x5DB5CF0", VA = "0x185DB74F0")]
			private void LAMANKNLHFI([Optional] string HPFMFCELEFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6D10", Offset = "0x5DB5510", VA = "0x185DB6D10")]
			private static string GKGHODNNMFN(string CCIMHDCKHOF, string AGPLDPOAAIC)
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

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5DBAF80", Offset = "0x5DB9780", VA = "0x185DBAF80")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct BMIHIEMEIGG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int HFAEDGPPPCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string OKHOEEGPBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T GLECGLEHKPG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ONBOPDIHEGG : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private KDCGDINMKGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public ONBOPDIHEGG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5DBA210", Offset = "0x5DB8A10", VA = "0x185DBA210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5DBA800", Offset = "0x5DB9000", VA = "0x185DBA800", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MACADBMPLED : IEnumerator<object>, IEnumerator, IDisposable
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
			public AMPMBAOHAPE quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public MACADBMPLED(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5DB82F0", Offset = "0x5DB6AF0", VA = "0x185DB82F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5DB83E0", Offset = "0x5DB6BE0", VA = "0x185DB83E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class INNFPHAEHMM : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000020")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public INNFPHAEHMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6660", Offset = "0x5DB4E60", VA = "0x185DB6660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5DB67D0", Offset = "0x5DB4FD0", VA = "0x185DB67D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class AHCKACNBKDL : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private KDCGDINMKGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public AHCKACNBKDL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5DAEB10", Offset = "0x5DAD310", VA = "0x185DAEB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5DAEDB0", Offset = "0x5DAD5B0", VA = "0x185DAEDB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class ELBEOBDHINJ : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private KDCGDINMKGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public ELBEOBDHINJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5DB57B0", Offset = "0x5DB3FB0", VA = "0x185DB57B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5A50", Offset = "0x5DB4250", VA = "0x185DB5A50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class LCKKCFHGLNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public KHKCPKNLPCA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public LCKKCFHGLNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7E40", Offset = "0x5DB6640", VA = "0x185DB7E40")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5DB7EE0", Offset = "0x5DB66E0", VA = "0x185DB7EE0")]
			internal void <FlushFromCache>b__1(BMIHIEMEIGG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class EOJKPEOIPKF : IEnumerator<KDCGDINMKGL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private KDCGDINMKGL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public KHKCPKNLPCA cache;

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
			private LCKKCFHGLNG <>8__1;

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
			private KDCGDINMKGL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
			[DebuggerHidden]
			public EOJKPEOIPKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5A90", Offset = "0x5DB4290", VA = "0x185DB5A90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x5DB6320", Offset = "0x5DB4B20", VA = "0x185DB6320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class KAEDBDEFLKI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
			public KAEDBDEFLKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3587A30", Offset = "0x3586230", VA = "0x183587A30")]
			internal BMIHIEMEIGG<T> <PostRudderStackJson>b__0(LBNFCNLBLBM postResponse)
			{
				return default(BMIHIEMEIGG<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HBBDFGOIKEN<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
			public HBBDFGOIKEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x3587A30", Offset = "0x3586230", VA = "0x183587A30")]
			internal BMIHIEMEIGG<T> <PostAmplitudeJson>b__0(LBNFCNLBLBM postResponse)
			{
				return default(BMIHIEMEIGG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KOKMFIHPBLP HBNPHEAJAEE;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string PHLDLLBPBBH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string MIEGNKNOEFM = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string APHHHIAHDCD = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int GNENEGOGOAF = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int ENEBHGHIJOD = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int KBBGNAMMJGF = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float CFANIELDCPG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long BJBEGJDPAAP = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string PMBNJAHMLPL = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string PHPIDHEICNN = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool NIAKHCAOBDF;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool NPEAHJAANKL;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int NGLMOBNJJPI;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int MCNHPGJGFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private MFDFCBIJIAI JLDGKHBAFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool DNPODACIOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float HBOFCBEOIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float PBMKMMNNMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int MLOHDAJLBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int OHAAGPHOIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? GAGLAKKFLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? DEMDIMICBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long FOJBMPPFCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string HHLOBNGMEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long ENFGILIIKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> FDGKGENGCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private HDEAOCHPHLI NEINCPPEIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int BPNENHIPLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int KCHGIDCIDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float IBBLIEIOOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool CDOJANMIEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool FKKACALFIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private KHKCPKNLPCA OPBLLNMCOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private KHKCPKNLPCA ICJLFLDAADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private KHKCPKNLPCA IPLPPEDIFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> EFEJINBINOE;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DDINNCIJAMF;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string ENKCMNNFGMJ;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string FLDNAJOIPIM = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string GOLFCPDHBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string HPDEMFFOCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string JJHHNHMADOO;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KOKMFIHPBLP NAGLHLMAKFC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DB1650", Offset = "0x5DAFE50", VA = "0x185DB1650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int CCELOLGEEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DB1480", Offset = "0x5DAFC80", VA = "0x185DB1480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long ANGIMCOBFFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5DB3CE0", Offset = "0x5DB24E0", VA = "0x185DB3CE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DB3DE0", Offset = "0x5DB25E0", VA = "0x185DB3DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string FEPKNIOEAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5DB3C80", Offset = "0x5DB2480", VA = "0x185DB3C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string DPGBDCLIKFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5DB3CB0", Offset = "0x5DB24B0", VA = "0x185DB3CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string MGCMKAAOIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x761DA0", Offset = "0x7605A0", VA = "0x180761DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x762070", Offset = "0x760870", VA = "0x180762070")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? FIMNDOPHIAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x777D60", Offset = "0x776560", VA = "0x180777D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7649D0", Offset = "0x7631D0", VA = "0x1807649D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FMDNMPDEMOL? LFKPBBINNDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1E0", Offset = "0x9A99E0", VA = "0x1809AB1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7649E0", Offset = "0x7631E0", VA = "0x1807649E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool ONHPLBJGNPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xFC73C0", Offset = "0xFC5BC0", VA = "0x180FC73C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xFC5CC0", Offset = "0xFC44C0", VA = "0x180FC5CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool EIMKJCBOCEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5DB3B90", Offset = "0x5DB2390", VA = "0x185DB3B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> MJMGIPBKNEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5DB3AF0", Offset = "0x5DB22F0", VA = "0x185DB3AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5DB3D40", Offset = "0x5DB2540", VA = "0x185DB3D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFC60", Offset = "0x5DAE460", VA = "0x185DAFC60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0C80", Offset = "0x5DAF480", VA = "0x185DB0C80")]
		private void IHJKKONFDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3340", Offset = "0x5DB1B40", VA = "0x185DB3340")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2860", Offset = "0x5DB1060", VA = "0x185DB2860", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3630", Offset = "0x5DB1E30", VA = "0x185DB3630")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2A60", Offset = "0x5DB1260", VA = "0x185DB2A60")]
		public MLEPGEJLFCO PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1310", Offset = "0x5DAFB10", VA = "0x185DB1310")]
		[IteratorStateMachine(typeof(ONBOPDIHEGG))]
		public IEnumerator<KDCGDINMKGL> Initialize(AmplitudeAnalyticsEvent LIHNIJCDDMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3520", Offset = "0x5DB1D20", VA = "0x185DB3520")]
		public void UpdateLastAliveTime(float AJEJHMBOGME = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0320", Offset = "0x5DAEB20", VA = "0x185DB0320")]
		private MLEPGEJLFCO BPPMIIEMJIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DB00B0", Offset = "0x5DAE8B0", VA = "0x185DB00B0")]
		private MLEPGEJLFCO BNPDJKGEPEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2F60", Offset = "0x5DB1760", VA = "0x185DB2F60")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0BF0", Offset = "0x5DAF3F0", VA = "0x185DB0BF0")]
		[IteratorStateMachine(typeof(MACADBMPLED))]
		private IEnumerator GJCCHEFOIIA(AMPMBAOHAPE OEDFLDGFELO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DB38A0", Offset = "0x5DB20A0", VA = "0x185DB38A0")]
		[IteratorStateMachine(typeof(INNFPHAEHMM))]
		public IEnumerator WaitForFlush(float EIPFKPHACBC = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3400", Offset = "0x5DB1C00", VA = "0x185DB3400")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3350", Offset = "0x5DB1B50", VA = "0x185DB3350")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EGGBPIADIJM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0FA0", Offset = "0x5DAF7A0", VA = "0x185DB0FA0")]
		public static FPLBCJBFLOF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFAF0", Offset = "0x5DAE2F0", VA = "0x185DAFAF0")]
		public static PAODHBCCFHC AccountSelectionPostLoginEvent([NotNull] string FBLCGIAOHAE, string OBNMLMEFMMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0780", Offset = "0x5DAEF80", VA = "0x185DB0780")]
		public static PAODHBCCFHC Event([NotNull] string FBLCGIAOHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2AC0", Offset = "0x5DB12C0", VA = "0x185DB2AC0")]
		public static PAODHBCCFHC PreviousSessionEvent([NotNull] string FBLCGIAOHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1100", Offset = "0x5DAF900", VA = "0x185DB1100")]
		public static PAODHBCCFHC InitializeEvent(string OBNMLMEFMMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3080", Offset = "0x5DB1880", VA = "0x185DB3080")]
		public static PAODHBCCFHC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5DB03F0", Offset = "0x5DAEBF0", VA = "0x185DB03F0")]
		public static PAODHBCCFHC CreateOutOfSessionEvent(string FBLCGIAOHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1980", Offset = "0x5DB0180", VA = "0x185DB1980")]
		public static MLEPGEJLFCO LogOutOfSessionEvent(PAODHBCCFHC HLDOJENJBEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5DB16C0", Offset = "0x5DAFEC0", VA = "0x185DB16C0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent EDLNALFOMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1D20", Offset = "0x5DB0520", VA = "0x185DB1D20")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent EDLNALFOMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1E70", Offset = "0x5DB0670", VA = "0x185DB1E70")]
		public void LogSerializedEventAsync(Dictionary<string, object> NJPGKPPDGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1810", Offset = "0x5DB0010", VA = "0x185DB1810")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LLJIJJDCIGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2900", Offset = "0x5DB1100", VA = "0x185DB2900")]
		private void PCEEDGNOMMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2070", Offset = "0x5DB0870", VA = "0x185DB2070")]
		private void OCHJACIEPPH(Dictionary<string, object> MMDMJIGCAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0690", Offset = "0x5DAEE90", VA = "0x185DB0690")]
		private void EINIFDNLHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0A10", Offset = "0x5DAF210", VA = "0x185DB0A10")]
		private void GEHPLEPIOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0980", Offset = "0x5DAF180", VA = "0x185DB0980")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0900", Offset = "0x5DAF100", VA = "0x185DB0900")]
		[IteratorStateMachine(typeof(AHCKACNBKDL))]
		private IEnumerator<KDCGDINMKGL> FEMBGIKIBJA(float EIPFKPHACBC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB29E0", Offset = "0x5DB11E0", VA = "0x185DB29E0")]
		[IteratorStateMachine(typeof(ELBEOBDHINJ))]
		private IEnumerator<KDCGDINMKGL> PPALEAPHNMJ(float EIPFKPHACBC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5DB13A0", Offset = "0x5DAFBA0", VA = "0x185DB13A0")]
		[IteratorStateMachine(typeof(EOJKPEOIPKF))]
		private IEnumerator<KDCGDINMKGL> KMKNHKJGDJL(KHKCPKNLPCA EHFJHOENLBO, int? BEOHPDPACAN, string CACBKNFKNIA, string GLCEPNIAEPB, float EIPFKPHACBC, Action<int> DDDHOCCBNME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1F50", Offset = "0x5DB0750", VA = "0x185DB1F50")]
		private static void NMFFLGHJBCK(bool HJDDNJFGENL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5DB26B0", Offset = "0x5DB0EB0", VA = "0x185DB26B0")]
		private global::AGDEEHNAPKP<BMIHIEMEIGG<Dictionary<string, object>>> OOBBGFDMEAJ(string CACBKNFKNIA, string GLCEPNIAEPB, string LCCLCDEKFCB, string MALNFGLOENG, Dictionary<string, object> GLECGLEHKPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2360", Offset = "0x5DB0B60", VA = "0x185DB2360")]
		private global::AGDEEHNAPKP<BMIHIEMEIGG<List<Dictionary<string, object>>>> OOBBGFDMEAJ(string CACBKNFKNIA, string GLCEPNIAEPB, string LCCLCDEKFCB, string MALNFGLOENG, List<Dictionary<string, object>> GLECGLEHKPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x416AC80", Offset = "0x4169480", VA = "0x18416AC80")]
		private global::AGDEEHNAPKP<BMIHIEMEIGG<T>> NIBODMBFICJ<T>(string CACBKNFKNIA, string GLCEPNIAEPB, string MALNFGLOENG, T GLECGLEHKPG, Dictionary<string, object> CMPBFCCJKJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x416A940", Offset = "0x4169140", VA = "0x18416A940")]
		private global::AGDEEHNAPKP<BMIHIEMEIGG<T>> HADGLOFDCEL<T>(string CACBKNFKNIA, string GLCEPNIAEPB, string LCCLCDEKFCB, T GLECGLEHKPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2300", Offset = "0x5DB0B00", VA = "0x185DB2300")]
		private bool OGEBHAHELMP(float LOJOCJJCFJJ, float EIPFKPHACBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEDF0", Offset = "0x5DAD5F0", VA = "0x185DAEDF0")]
		private Dictionary<string, object> ADNCFFAJACN(string GLCEPNIAEPB, Dictionary<string, object> GLECGLEHKPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3980", Offset = "0x5DB2180", VA = "0x185DB3980")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFF50", Offset = "0x5DAE750", VA = "0x185DAFF50")]
		[CompilerGenerated]
		private long BHGEOCJGNMD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2350", Offset = "0x5DB0B50", VA = "0x185DB2350")]
		[CompilerGenerated]
		private void ONJNEOELCDD(int LMIPPENFGDK)
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
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8323D0", Offset = "0x830BD0", VA = "0x1808323D0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB42E0", Offset = "0x5DB2AE0", VA = "0x185DB42E0")]
		public static PAODHBCCFHC MFNJFAEBAIM(string LDFDMKAILBI, [NotNull] string GLIECKMCKEJ, long NGIAEOKLPGD, long NPPPJLBHJOH, string OBNMLMEFMMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3EC0", Offset = "0x5DB26C0", VA = "0x185DB3EC0")]
		public static PAODHBCCFHC KMMCMHDLBHE(string LDFDMKAILBI, [NotNull] string GLIECKMCKEJ, long NGIAEOKLPGD, long NPPPJLBHJOH, string OBNMLMEFMMP, long DLACGHFODFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB44F0", Offset = "0x5DB2CF0", VA = "0x185DB44F0")]
		private AmplitudeAnalyticsEvent(string LDFDMKAILBI, [NotNull] string GLIECKMCKEJ, long NGIAEOKLPGD, long NPPPJLBHJOH, string OBNMLMEFMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1085760", Offset = "0x1083F60", VA = "0x181085760")]
		public void IOAKNPAKLOE(long BOEAFCCHAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB43D0", Offset = "0x5DB2BD0", VA = "0x185DB43D0", Slot = "5")]
		public override void PDGOLDNDDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3E40", Offset = "0x5DB2640", VA = "0x185DB3E40", Slot = "6")]
		public override void JEJGJCDDHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3FC0", Offset = "0x5DB27C0", VA = "0x185DB3FC0", Slot = "4")]
		protected override Dictionary<string, object> MFCCIJHBBAL(Dictionary<string, object> EBJJEADABPK)
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

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5DB5630", Offset = "0x5DB3E30", VA = "0x185DB5630")]
			public void PJAMMDNKFOA(Dictionary<string, object> JFMFJFLAPJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x5DBAE10", Offset = "0x5DB9610", VA = "0x185DBAE10")]
			public void PJAMMDNKFOA(Dictionary<string, object> LIAJPMMCLJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x22E0A20", Offset = "0x22DF220", VA = "0x1822E0A20")]
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
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4C00", Offset = "0x5DB3400", VA = "0x185DB4C00")]
		public static FPLBCJBFLOF MFNJFAEBAIM(string LDFDMKAILBI, string OBNMLMEFMMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4D30", Offset = "0x5DB3530", VA = "0x185DB4D30")]
		protected AmplitudeAnalyticsIdentifyMessage(string LDFDMKAILBI, string OBNMLMEFMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4750", Offset = "0x5DB2F50", VA = "0x185DB4750")]
		public Dictionary<string, object> EDKDEMCCKDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB48C0", Offset = "0x5DB30C0", VA = "0x185DB48C0", Slot = "4")]
		protected virtual Dictionary<string, object> MFCCIJHBBAL(Dictionary<string, object> EBJJEADABPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB46B0", Offset = "0x5DB2EB0", VA = "0x185DB46B0")]
		protected void CADMHAOMDBP(string AGPLDPOAAIC, Dictionary<string, object> JOHJLCDGNKK, Dictionary<string, object> HFLNGCIGJPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4850", Offset = "0x5DB3050", VA = "0x185DB4850")]
		protected void JJFOENMHDAP(string AGPLDPOAAIC, string CCIMHDCKHOF, Dictionary<string, object> FOHJGKGDGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4CB0", Offset = "0x5DB34B0", VA = "0x185DB4CB0", Slot = "5")]
		public virtual void PDGOLDNDDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB47D0", Offset = "0x5DB2FD0", VA = "0x185DB47D0", Slot = "6")]
		public virtual void JEJGJCDDHNJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FPLBCJBFLOF : global::FNDDBJDMIDC<AmplitudeAnalyticsIdentifyMessage, FPLBCJBFLOF>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override FPLBCJBFLOF LLMPOGFBOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KHHMLJENKEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6400", Offset = "0x5DB4C00", VA = "0x185DB6400")]
	public FPLBCJBFLOF(AmplitudeAnalyticsIdentifyMessage NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6360", Offset = "0x5DB4B60", VA = "0x185DB6360", Slot = "4")]
	public override void JEJGJCDDHNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PAODHBCCFHC : global::FNDDBJDMIDC<AmplitudeAnalyticsEvent, PAODHBCCFHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool KDEDAIKFJDA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override PAODHBCCFHC LLMPOGFBOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public long OAELIMGIJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5DBA840", Offset = "0x5DB9040", VA = "0x185DBA840")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6610", Offset = "0x5DB4E10", VA = "0x185DB6610")]
	public PAODHBCCFHC(AmplitudeAnalyticsEvent NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "5")]
	public override AmplitudeAnalyticsEvent KHHMLJENKEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA860", Offset = "0x5DB9060", VA = "0x185DBA860", Slot = "4")]
	public override void JEJGJCDDHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAAA0", Offset = "0x5DB92A0", VA = "0x185DBAAA0")]
	public PAODHBCCFHC MMPEIDGCPIL(string MIGODNJAHNA, long[] CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DBABE0", Offset = "0x5DB93E0", VA = "0x185DBABE0")]
	public PAODHBCCFHC MMPEIDGCPIL(string MIGODNJAHNA, ulong[] CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x396B5B0", Offset = "0x3969DB0", VA = "0x18396B5B0")]
	public PAODHBCCFHC MMPEIDGCPIL<T>(string MIGODNJAHNA, T[] CCIMHDCKHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA990", Offset = "0x5DB9190", VA = "0x185DBA990")]
	public PAODHBCCFHC MMPEIDGCPIL(string MIGODNJAHNA, string[] CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x396B290", Offset = "0x3969A90", VA = "0x18396B290")]
	public PAODHBCCFHC MMPEIDGCPIL<T>(string MIGODNJAHNA, T CCIMHDCKHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA900", Offset = "0x5DB9100", VA = "0x185DBA900")]
	public PAODHBCCFHC MMPEIDGCPIL(string MIGODNJAHNA, long CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBA9A0", Offset = "0x5DB91A0", VA = "0x185DBA9A0")]
	public PAODHBCCFHC MMPEIDGCPIL(string MIGODNJAHNA, ulong CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAA30", Offset = "0x5DB9230", VA = "0x185DBAA30")]
	public PAODHBCCFHC MMPEIDGCPIL(string MIGODNJAHNA, string CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DBAD20", Offset = "0x5DB9520", VA = "0x185DBAD20")]
	private PAODHBCCFHC PILCLBKJOPL(string MIGODNJAHNA, object CCIMHDCKHOF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class INLPHPMHAJG : PAODHBCCFHC
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6610", Offset = "0x5DB4E10", VA = "0x185DB6610")]
	public INLPHPMHAJG(AmplitudeAnalyticsEvent NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6450", Offset = "0x5DB4C50", VA = "0x185DB6450", Slot = "4")]
	public override void JEJGJCDDHNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class FNDDBJDMIDC<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::FNDDBJDMIDC<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M NJAIIGFCHNG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract BLDR LLMPOGFBOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D630", Offset = "0x2B2BE30", VA = "0x182B2D630")]
	public FNDDBJDMIDC(M NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B850", Offset = "0x3D7A050", VA = "0x183D7B850")]
	public BLDR NFKCKBDNFIG(AmplitudeAnalyticsIdentifyMessage.DeviceInfo AFGCFHCLBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B890", Offset = "0x3D7A090", VA = "0x183D7B890")]
	public BLDR NHPNLBCCNKL(AmplitudeAnalyticsIdentifyMessage.RevenueData NPDGMPFPIMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B730", Offset = "0x3D79F30", VA = "0x183D7B730")]
	public BLDR GECPCBFDKPG(string MIGODNJAHNA, string CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3488110", Offset = "0x3486910", VA = "0x183488110")]
	public BLDR GECPCBFDKPG<T>(string MIGODNJAHNA, T CCIMHDCKHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B7A0", Offset = "0x3D79FA0", VA = "0x183D7B7A0")]
	public BLDR GECPCBFDKPG(string MIGODNJAHNA, long CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B680", Offset = "0x3D79E80", VA = "0x183D7B680")]
	public BLDR GECPCBFDKPG(string MIGODNJAHNA, ulong CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JEJGJCDDHNJ();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B560", Offset = "0x3D79D60", VA = "0x183D7B560")]
	internal static string BAHOLPBOHFH(string CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B590", Offset = "0x3D79D90", VA = "0x183D7B590")]
	private BLDR BNPEEENFOEO(string MIGODNJAHNA, object CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KHHMLJENKEO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class KEKIEOFOCLG
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string BAIGACEHMJA = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string LBPOPGEABMB = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string AGMLMELILME = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string LCNHBEPPCHB = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string JJNEIPOCKLG = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string KCKHCFPEJIC = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string OILKMFHNOEP = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string MHHKNOFJNOH = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string LFKMMKBIMGE = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string MKOCODMIOAJ = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string FBFENGLAMEB = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string JPPBNABAAMD = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string MJFOOAAJOJO = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string DMBDIDEDNBC = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string BPNCJJKDGEO = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string JIMDAEBMHDM = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string LEJPJHKJCFM = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string KBMJIIEEDNM = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string BBKBEFCGAKJ = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string FNALCKNLCNP = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string EHMNHHGLBJI = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string POEEKCPCKFN = "type";

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public KEKIEOFOCLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BHGDIICDKBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int LGIKILPJKLN = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int NLNMPJCBIMP = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int BLGKMIJAHNJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long NIKBNAMEEDO = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int FHIGACEFJLL = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int LCMNIGCHLGJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string PEPFKAGPAGN = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string CIKLHAPPKHF = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string APHLFOANHBK = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string FPBDOHJONII = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string PBMMMICBHBK = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string BIGNLEOOIKP = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string AMICEKMGNBF = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string CMCJJFMDECL = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string NLOBPAAEAAF = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string NKEFDCIEHAM = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string FFDKLPANAJN = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string JJOIKOMBACL = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string PPBFOKKGLNJ = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string FGPFNBDHILM = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string INKELCMMMAC = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string FFOKFPMIDDA = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string DDNAIPPNKNC = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string EEINFHFDCCF = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string HLOKHJKLKPG = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string PCMPBFHDHNO = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string GCILMKNHHPG = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string OOHALBGNIKL = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string JAIEPMOCNJB = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string PGKPKPAMDDB = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string IIGPFOABECH = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string LNPFIJHNBEA = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string JJNEIPOCKLG = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string BJIMIEFBGNI = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int AJDOAONJDFB = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JJJDIHNONLK;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5420", Offset = "0x5DB3C20", VA = "0x185DB5420")]
	internal static bool EEDHCBNBAFA(string AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BHGDIICDKBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MFDFCBIJIAI
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool FNGHFPEIMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string KBJAPICHDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string NJPCDFMEHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string IOLJNDKKDFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string BMOIKKLHFNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::AGDEEHNAPKP<LBNFCNLBLBM> OOBBGFDMEAJ(string CACBKNFKNIA, Dictionary<string, string> NMOAHOHAFPM, bool GGJGGPDEKJM = false);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::AGDEEHNAPKP<LBNFCNLBLBM> PAHBDCGFPCO(string CACBKNFKNIA, string EIJFLHBHNJD, string MLOOAHAKELD, string BPDJEAFONMM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LBNFCNLBLBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int JLMLKABBMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string ODAMJIFEBJK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x958000", Offset = "0x956800", VA = "0x180958000")]
	public LBNFCNLBLBM(int HFAEDGPPPCA, string OKHOEEGPBPB)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4DF0", Offset = "0x5DB35F0", VA = "0x185DB4DF0")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4F00", Offset = "0x5DB3700", VA = "0x185DB4F00")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
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
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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

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
public class DHGGEHAHAEB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string ODGBLDELEOO = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string AFFJKHIMGGB = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string ONPDJDBPGMH = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string OLDBNALPDNI = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string GCOPCMLFELH = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string AKGJNOIODHA = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string NFLJBPCFBJK = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long HNCOMBFJPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GDIKAPIKIMM IGAALBFBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool MMBNMOLKBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float DAINDPLNHBE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x16A5C00", Offset = "0x16A4800", VA = "0x1816A5C00")]
	public DHGGEHAHAEB(string HIKPIHBBCFC, float DAINDPLNHBE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CD51D0", Offset = "0x2CD3DD0", VA = "0x182CD51D0")]
	public void CCMOBDFHGBJ<T>(string GAHBHMKCAPG, T JHEBJPCMJGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x16A5860", Offset = "0x16A4460", VA = "0x1816A5860")]
	public void CCMOBDFHGBJ(string GAHBHMKCAPG, string JHEBJPCMJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x16A59E0", Offset = "0x16A45E0", VA = "0x1816A59E0")]
	public void EHBIFEHDDFN(string NLNAHJEJJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16A5B50", Offset = "0x16A4750", VA = "0x1816A5B50")]
	public void LDKMHJKAIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x16A58E0", Offset = "0x16A44E0", VA = "0x1816A58E0")]
	private void COGKDIAIJGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x16A5B00", Offset = "0x16A4700", VA = "0x1816A5B00")]
	private bool FDADMOCNMNP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DGGENGIHCNG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPHEJFPBCIA NFHIBICHHJH(string FDMPBFOGHKB, string OMNPHGMPDPP, [Optional] MJIPBCPDHFJ EPONKEFAAPO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EPHEJFPBCIA LBHGCMDIGFD(MJIPBCPDHFJ EPONKEFAAPO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DJNMGNLJJDH(string HNPLKHMDKKA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNFFBAGAGLC NINCIHDINDM(string LLBOAGNHICB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HNFFBAGAGLC LBLHOJFJEGC(string NEAPKOCCJHD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EPHEJFPBCIA PKBFNOAIPJI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CBJHKMFJHOC : DGGENGIHCNG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string CGPGHDNBNGF = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string ENIODFPABEP = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string DPAOBHGBKDM = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string BOHKDAPBKGL = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string CEDMGPKCAEL = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string APJOGJJACKN = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string PECHAMDMCGN = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string BOEKNKOCAON = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string GHIFABNIONK = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, BLHLONJLJIL> IPDJPOJDAHA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int CBKANLGDEPF = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool PDNNBAJOJFE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	[Preserve]
	public CBJHKMFJHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x16A4A00", Offset = "0x16A3600", VA = "0x1816A4A00")]
	[OCMGHBFFHBN(NPADJDIGCKA.Unity_BeforeSceneLoad)]
	private static void MGMPAONCHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x16A4B60", Offset = "0x16A3760", VA = "0x1816A4B60", Slot = "4")]
	public EPHEJFPBCIA NFHIBICHHJH(string FDMPBFOGHKB, string OMNPHGMPDPP, [Optional] MJIPBCPDHFJ EPONKEFAAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x16A5070", Offset = "0x16A3C70", VA = "0x1816A5070", Slot = "9")]
	public EPHEJFPBCIA PKBFNOAIPJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x16A45C0", Offset = "0x16A31C0", VA = "0x1816A45C0", Slot = "5")]
	public EPHEJFPBCIA LBHGCMDIGFD(MJIPBCPDHFJ EPONKEFAAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x16A3F60", Offset = "0x16A2B60", VA = "0x1816A3F60", Slot = "6")]
	public bool DJNMGNLJJDH(string HNPLKHMDKKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x16A4F60", Offset = "0x16A3B60", VA = "0x1816A4F60", Slot = "7")]
	public HNFFBAGAGLC NINCIHDINDM(string LLBOAGNHICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x16A4710", Offset = "0x16A3310", VA = "0x1816A4710", Slot = "8")]
	public HNFFBAGAGLC LBLHOJFJEGC(string NEAPKOCCJHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x16A4020", Offset = "0x16A2C20", VA = "0x1816A4020")]
	private FKEOOJPFJNF DNBFIMNCJMF(MJIPBCPDHFJ EPONKEFAAPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x16A4440", Offset = "0x16A3040", VA = "0x1816A4440")]
	private DMDDPLLOABD EACCAOJJMFP(string OMNPHGMPDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x16A4800", Offset = "0x16A3400", VA = "0x1816A4800")]
	private void MGLBGGJNLAE(string LLBOAGNHICB, HNFFBAGAGLC OGJKJDJKHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBB45B0", Offset = "0xBB31B0", VA = "0x180BB45B0")]
	[CompilerGenerated]
	private void FGAJDCIDLKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MJKJLNKJJCA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DHGGEHAHAEB KBJDHLJFEKL(string HIKPIHBBCFC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MJIPBCPDHFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DMPPHDMACMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BMGDDCFIICP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HOLKIDPJKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNKLFJKCKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? NKCHCEHAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? FMIDDANMKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int GCCAGGAPMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string EAOJKKGMMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string AOGOELAOHJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string PCPGAIPJPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string ODFIOJDJKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string INPFOJNHBCK
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
		public AmplitudeAnalyticsClient.Settings ODOJOAIOAGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MJGBPHLHDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x576EB0", Offset = "0x575AB0", VA = "0x180576EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum NNEGMMDHBBG
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum AEKNLOKBABA
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class LMPDEIJKEHM
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class NBJMADMAFMA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int AMPKNIJFGCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> PDCBLHAJIAP;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public NBJMADMAFMA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class FECDMBALJFG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
				public FECDMBALJFG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x16A5E80", Offset = "0x16A4A80", VA = "0x1816A5E80")]
				internal bool <GetBatch>b__0(NBJMADMAFMA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string KJENGODMOJH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string KKFOAHNFADI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<NBJMADMAFMA> AOLGENCGOOJ;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? HLKAILLLFCO
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x16A8250", Offset = "0x16A6E50", VA = "0x1816A8250")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? JLJKNPEMIDH
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x16A8410", Offset = "0x16A7010", VA = "0x1816A8410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x16A8960", Offset = "0x16A7560", VA = "0x1816A8960")]
			internal LMPDEIJKEHM(string PCPDMJFHNOP, string OMNPHGMPDPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x16A8610", Offset = "0x16A7210", VA = "0x1816A8610")]
			public int LJCPOALJAIP([Optional] int? NLNKIDNOJAA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x16A7C80", Offset = "0x16A6880", VA = "0x1816A7C80")]
			public List<Dictionary<string, object>> EEGBOLICKOK(int BJAJMMAPGFJ, int? NLNKIDNOJAA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x16A7BE0", Offset = "0x16A67E0", VA = "0x1816A7BE0")]
			public void EDEEEDCGBAG(AmplitudeAnalyticsIdentifyMessage KLDDDNGBABC, bool KMHKEOKFKPG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x16A7AE0", Offset = "0x16A66E0", VA = "0x1816A7AE0")]
			public void EDEEEDCGBAG(Dictionary<string, object> KLDDDNGBABC, bool KMHKEOKFKPG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x16A84C0", Offset = "0x16A70C0", VA = "0x1816A84C0")]
			public void LFGKABHKNCF(params Dictionary<string, object>[] JABJPPHMCHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x16A78C0", Offset = "0x16A64C0", VA = "0x1816A78C0")]
			public void DPGMNDGEFHF(List<Dictionary<string, object>> CHKOCNKBGDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x16A77B0", Offset = "0x16A63B0", VA = "0x1816A77B0")]
			private void AFBJIICBIFM(Dictionary<string, object> KLDDDNGBABC, bool KMHKEOKFKPG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x16A8770", Offset = "0x16A7370", VA = "0x1816A8770")]
			public void PMOAMIFENBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x16A7E80", Offset = "0x16A6A80", VA = "0x1816A7E80")]
			private void FJHEHEENJIJ([Optional] string OAOKLIPJEHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x16A82E0", Offset = "0x16A6EE0", VA = "0x1816A82E0")]
			private static string HJHHOFLKOAM(string JHEBJPCMJGD, string GMCMHIFODNN)
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
			[Cpp2IlInjected.Address(RVA = "0x16A8D30", Offset = "0x16A7930", VA = "0x1816A8D30")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct LMGPHKJAPGG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int JNACEKNOGGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string HIIBFNNKHCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T DJIHNDOINMG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class BLMEGJEKMDP : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IGHAECBNBLN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public BLMEGJEKMDP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x16A3820", Offset = "0x16A2420", VA = "0x1816A3820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x16A3F10", Offset = "0x16A2B10", VA = "0x1816A3F10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JKBEAALCLFD : IEnumerator<object>, IEnumerator, IDisposable
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
			public MCMONDMICNG quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public JKBEAALCLFD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x16A6C70", Offset = "0x16A5870", VA = "0x1816A6C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x16A6D60", Offset = "0x16A5960", VA = "0x1816A6D60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class LMJOOKKPNFF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public LMJOOKKPNFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x16A75F0", Offset = "0x16A61F0", VA = "0x1816A75F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x16A7760", Offset = "0x16A6360", VA = "0x1816A7760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IILHONEHHAF : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private IGHAECBNBLN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public IILHONEHHAF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x16A6530", Offset = "0x16A5130", VA = "0x1816A6530", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x16A6780", Offset = "0x16A5380", VA = "0x1816A6780", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FOFBLMBFNNA : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private IGHAECBNBLN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public FOFBLMBFNNA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x16A5EE0", Offset = "0x16A4AE0", VA = "0x1816A5EE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x16A6140", Offset = "0x16A4D40", VA = "0x1816A6140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class IMINBHGEGCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public LMPDEIJKEHM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public IMINBHGEGCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x16A67D0", Offset = "0x16A53D0", VA = "0x1816A67D0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x16A6870", Offset = "0x16A5470", VA = "0x1816A6870")]
			internal void <FlushFromCache>b__1(LMGPHKJAPGG<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class LEJDAANACMC : IEnumerator<IGHAECBNBLN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private IGHAECBNBLN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public LMPDEIJKEHM cache;

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
			private IMINBHGEGCI <>8__1;

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
			private IGHAECBNBLN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575850", VA = "0x180576C50")]
			[DebuggerHidden]
			public LEJDAANACMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16A6EE0", Offset = "0x16A5AE0", VA = "0x1816A6EE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x16A75A0", Offset = "0x16A61A0", VA = "0x1816A75A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NOJMOJAJOND<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
			public NOJMOJAJOND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x299AB30", Offset = "0x2999730", VA = "0x18299AB30")]
			internal LMGPHKJAPGG<T> <PostRudderStackJson>b__0(DDLIOHEAMMM postResponse)
			{
				return default(LMGPHKJAPGG<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HNIDEOJNNGE<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
			public HNIDEOJNNGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x299AB30", Offset = "0x2999730", VA = "0x18299AB30")]
			internal LMGPHKJAPGG<T> <PostAmplitudeJson>b__0(DDLIOHEAMMM postResponse)
			{
				return default(LMGPHKJAPGG<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CDNBFAJDLBM EOKGHPHDHAN;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string DPGCAHJKCNO = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string HBDGPKNDOEK = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string AJNEAAAKPOP = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string PHFNJCEKJAC = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string MAEHFNLCEMF = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int OLPBNLKMIPD = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int IPADDDKPABB = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int DGGMBDOPNGB = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float ABJNGNDMCIE = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long HILIPGNHMKJ = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string LLIFMIJIKFF = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string LMLFDLIPBMK = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool FAEELKDKFLN;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool CLKOOOJDIAA;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int KPPLICPHPKL;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int PGLIHIACNNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private KELHHOHCDJP DGMKBDNIALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool APFPMDOGJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float BHBJFLJNMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float ONOPEJAMLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int HNJFDIJKDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int PNHGIGEKFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? CFKKDBGFAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? OBDFMGLFEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long LIBKPHPOBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string KEBLKMHOOCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long GKCFLMLAEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> KJMJFKPHLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private AEKNLOKBABA NAPGNCOBOHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int PLJDHMCNMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int JBIBABHALIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float ALHNBIFAFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool LGPEGACPHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool FCKNINBJOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private LMPDEIJKEHM PGLPEPDCNBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LMPDEIJKEHM KAIPMOEIFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LMPDEIJKEHM CKJBDCKEDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JEOFONFCCAJ;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo CNFGOLLAHOI;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string BPBNBICDDIM;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string DHAMHLDFDNG = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string DLDCGNFKAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string HGDLELMACFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string FHHNBHNOFNI;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string ENMMPFKDCOP = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string JGDMPGANACF = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CDNBFAJDLBM KNHMCHHOLNK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x16A1330", Offset = "0x169FF30", VA = "0x1816A1330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int IJIPNFPOJGA
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x16A1700", Offset = "0x16A0300", VA = "0x1816A1700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long DPMIIPFPBMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x16A2900", Offset = "0x16A1500", VA = "0x1816A2900")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x16A2A80", Offset = "0x16A1680", VA = "0x1816A2A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string GLNDGPLELAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x16A28A0", Offset = "0x16A14A0", VA = "0x1816A28A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string IBMBKDPHMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x16A28D0", Offset = "0x16A14D0", VA = "0x1816A28D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string KGCFKMIECMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x59B360", Offset = "0x599F60", VA = "0x18059B360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x552850", Offset = "0x551450", VA = "0x180552850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? FMIDDANMKBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5527F0", Offset = "0x5513F0", VA = "0x1805527F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x16A2A60", Offset = "0x16A1660", VA = "0x1816A2A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NNEGMMDHBBG? LOPHNMFNFPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x634150", Offset = "0x632D50", VA = "0x180634150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x16A2A70", Offset = "0x16A1670", VA = "0x1816A2A70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool KKHCNMEIMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1141B40", Offset = "0x1140740", VA = "0x181141B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x169FA50", Offset = "0x169E650", VA = "0x18169FA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool HBJGMPHIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x16A27C0", Offset = "0x16A13C0", VA = "0x1816A27C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DKGPNDFBDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x16A2720", Offset = "0x16A1320", VA = "0x1816A2720")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x16A29C0", Offset = "0x16A15C0", VA = "0x1816A29C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x169E6A0", Offset = "0x169D2A0", VA = "0x18169E6A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x169EE30", Offset = "0x169DA30", VA = "0x18169EE30")]
		private void FBODGBAONLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x16A2140", Offset = "0x16A0D40", VA = "0x1816A2140")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x16A1660", Offset = "0x16A0260", VA = "0x1816A1660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x16A22C0", Offset = "0x16A0EC0", VA = "0x1816A22C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x16A1920", Offset = "0x16A0520", VA = "0x1816A1920")]
		public EPHEJFPBCIA PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x169F9C0", Offset = "0x169E5C0", VA = "0x18169F9C0")]
		[IteratorStateMachine(typeof(BLMEGJEKMDP))]
		public IEnumerator<IGHAECBNBLN> Initialize(AmplitudeAnalyticsEvent ANBBFIHMEJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x16A2210", Offset = "0x16A0E10", VA = "0x1816A2210")]
		public void UpdateLastAliveTime(float MGNFBGKNNLO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x16A1410", Offset = "0x16A0010", VA = "0x1816A1410")]
		private EPHEJFPBCIA NPJFPBLANPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x16A08A0", Offset = "0x169F4A0", VA = "0x1816A08A0")]
		private EPHEJFPBCIA LELNHCGFHDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x16A1DD0", Offset = "0x16A09D0", VA = "0x1816A1DD0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x169F220", Offset = "0x169DE20", VA = "0x18169F220")]
		[IteratorStateMachine(typeof(JKBEAALCLFD))]
		private IEnumerator GCILCNFEOPC(MCMONDMICNG KPAMFNCOKKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x16A2520", Offset = "0x16A1120", VA = "0x1816A2520")]
		[IteratorStateMachine(typeof(LMJOOKKPNFF))]
		public IEnumerator WaitForFlush(float HIHLHOIOIEF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x16A2150", Offset = "0x16A0D50", VA = "0x1816A2150")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x169F6C0", Offset = "0x169E2C0", VA = "0x18169F6C0")]
		public static NCCIEMGINGA Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x169E560", Offset = "0x169D160", VA = "0x18169E560")]
		public static GDIKAPIKIMM AccountSelectionPostLoginEvent([NotNull] string FGHHPFCEMLM, string CACPDOCBOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x169ECD0", Offset = "0x169D8D0", VA = "0x18169ECD0")]
		public static GDIKAPIKIMM Event([NotNull] string FGHHPFCEMLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x16A19A0", Offset = "0x16A05A0", VA = "0x1816A19A0")]
		public static GDIKAPIKIMM PreviousSessionEvent([NotNull] string FGHHPFCEMLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x169F800", Offset = "0x169E400", VA = "0x18169F800")]
		public static GDIKAPIKIMM InitializeEvent(string CACPDOCBOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x16A1EE0", Offset = "0x16A0AE0", VA = "0x1816A1EE0")]
		public static GDIKAPIKIMM StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x169E980", Offset = "0x169D580", VA = "0x18169E980")]
		public static GDIKAPIKIMM CreateOutOfSessionEvent(string FGHHPFCEMLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x16A0CD0", Offset = "0x169F8D0", VA = "0x1816A0CD0")]
		public static EPHEJFPBCIA LogOutOfSessionEvent(GDIKAPIKIMM PKJPJHGKGPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x16A0B20", Offset = "0x169F720", VA = "0x1816A0B20")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LELOABJLHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x16A1000", Offset = "0x169FC00", VA = "0x1816A1000")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LELOABJLHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x16A10D0", Offset = "0x169FCD0", VA = "0x1816A10D0")]
		public void LogSerializedEventAsync(Dictionary<string, object> EGJNJAAPEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x16A0BF0", Offset = "0x169F7F0", VA = "0x1816A0BF0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LNHGELBNIOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x16A1280", Offset = "0x169FE80", VA = "0x1816A1280")]
		private void NBKAGDGIJGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x169FB50", Offset = "0x169E750", VA = "0x18169FB50")]
		private void KCJIFJLOGBO(Dictionary<string, object> EJEAGJGGKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x169FA60", Offset = "0x169E660", VA = "0x18169FA60")]
		private void JPEKDAIBLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x16A14D0", Offset = "0x16A00D0", VA = "0x1816A14D0")]
		private void OIBLBCKECHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x169F190", Offset = "0x169DD90", VA = "0x18169F190")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x169E3F0", Offset = "0x169CFF0", VA = "0x18169E3F0")]
		[IteratorStateMachine(typeof(IILHONEHHAF))]
		private IEnumerator<IGHAECBNBLN> AFLPCDBFMBE(float HIHLHOIOIEF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x169EC50", Offset = "0x169D850", VA = "0x18169EC50")]
		[IteratorStateMachine(typeof(FOFBLMBFNNA))]
		private IEnumerator<IGHAECBNBLN> DIEJKIPOACK(float HIHLHOIOIEF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x16A11A0", Offset = "0x169FDA0", VA = "0x1816A11A0")]
		[IteratorStateMachine(typeof(LEJDAANACMC))]
		private IEnumerator<IGHAECBNBLN> MCDDNPMCBGM(LMPDEIJKEHM PHIGJGFEFCI, int? NLNKIDNOJAA, string MNFPOJEFGCL, string JBJNICGMOGN, float HIHLHOIOIEF, Action<int> NOCCGIDEFMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x169E470", Offset = "0x169D070", VA = "0x18169E470")]
		private static void AFMOAKHBMDP(bool AAHIGPHAAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x169F550", Offset = "0x169E150", VA = "0x18169F550")]
		private global::NHGODCKFGMA<LMGPHKJAPGG<Dictionary<string, object>>> GODNKCDGGNN(string MNFPOJEFGCL, string JBJNICGMOGN, string CMIGGHACMMJ, string KAKCLHHGFOA, Dictionary<string, object> DJIHNDOINMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x169F2B0", Offset = "0x169DEB0", VA = "0x18169F2B0")]
		private global::NHGODCKFGMA<LMGPHKJAPGG<List<Dictionary<string, object>>>> GODNKCDGGNN(string MNFPOJEFGCL, string JBJNICGMOGN, string CMIGGHACMMJ, string KAKCLHHGFOA, List<Dictionary<string, object>> DJIHNDOINMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x275D420", Offset = "0x275C020", VA = "0x18275D420")]
		private global::NHGODCKFGMA<LMGPHKJAPGG<T>> NHMFJLHMEFE<T>(string MNFPOJEFGCL, string JBJNICGMOGN, string KAKCLHHGFOA, T DJIHNDOINMG, Dictionary<string, object> IACBBFDLLDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x275D150", Offset = "0x275BD50", VA = "0x18275D150")]
		private global::NHGODCKFGMA<LMGPHKJAPGG<T>> FCPFHHFLCBM<T>(string MNFPOJEFGCL, string JBJNICGMOGN, string CMIGGHACMMJ, T DJIHNDOINMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16A0AD0", Offset = "0x169F6D0", VA = "0x1816A0AD0")]
		private bool LGMKKFAEHHF(float MOIMIPECGCE, float HIHLHOIOIEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x169FD80", Offset = "0x169E980", VA = "0x18169FD80")]
		private Dictionary<string, object> KJFADJBMMNL(string JBJNICGMOGN, Dictionary<string, object> DJIHNDOINMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x16A2600", Offset = "0x16A1200", VA = "0x1816A2600")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x169F030", Offset = "0x169DC30", VA = "0x18169F030")]
		[CompilerGenerated]
		private long FHAHEGPHHDA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x169EC40", Offset = "0x169D840", VA = "0x18169EC40")]
		[CompilerGenerated]
		private void DDDODNNLHAH(int JEBHHPLNLGB)
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
			[Cpp2IlInjected.Address(RVA = "0x57D2B0", Offset = "0x57BEB0", VA = "0x18057D2B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x16A2E80", Offset = "0x16A1A80", VA = "0x1816A2E80")]
		public static GDIKAPIKIMM JFONNKANKPC(string KPEOHEHDBEF, [NotNull] string BJEBFCDGDFN, long IKGNAIDOKKK, long NAAKDNJBMMB, string CACPDOCBOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x16A2D20", Offset = "0x16A1920", VA = "0x1816A2D20")]
		public static GDIKAPIKIMM BJCIEIPKIJH(string KPEOHEHDBEF, [NotNull] string BJEBFCDGDFN, long IKGNAIDOKKK, long NAAKDNJBMMB, string CACPDOCBOJO, long ENCEIGINAIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x16A3070", Offset = "0x16A1C70", VA = "0x1816A3070")]
		private AmplitudeAnalyticsEvent(string KPEOHEHDBEF, [NotNull] string BJEBFCDGDFN, long IKGNAIDOKKK, long NAAKDNJBMMB, string CACPDOCBOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xC259E0", Offset = "0xC245E0", VA = "0x180C259E0")]
		public void HHIPGDFMHPN(long LPJNPOJPEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x16A2F60", Offset = "0x16A1B60", VA = "0x1816A2F60", Slot = "5")]
		public override void MIDEKGGPNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x16A2E10", Offset = "0x16A1A10", VA = "0x1816A2E10", Slot = "6")]
		public override void JFNOGKCBGMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x16A2AE0", Offset = "0x16A16E0", VA = "0x1816A2AE0", Slot = "4")]
		protected override Dictionary<string, object> ALDCBAHFKME(Dictionary<string, object> NFDLIAHGNGB)
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
			[Cpp2IlInjected.Address(RVA = "0x16A5D60", Offset = "0x16A4960", VA = "0x1816A5D60")]
			public void IFGCPPLLCFE(Dictionary<string, object> JJJIKDLAAGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
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
			[Cpp2IlInjected.Address(RVA = "0x16A8C00", Offset = "0x16A7800", VA = "0x1816A8C00")]
			public void IFGCPPLLCFE(Dictionary<string, object> HPDBBBPFBFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x16A8D20", Offset = "0x16A7920", VA = "0x1816A8D20")]
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
			[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575D80", VA = "0x180577180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x16A35D0", Offset = "0x16A21D0", VA = "0x1816A35D0")]
		public static NCCIEMGINGA JFONNKANKPC(string KPEOHEHDBEF, string CACPDOCBOJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x16A3760", Offset = "0x16A2360", VA = "0x1816A3760")]
		protected AmplitudeAnalyticsIdentifyMessage(string KPEOHEHDBEF, string CACPDOCBOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x16A36F0", Offset = "0x16A22F0", VA = "0x1816A36F0")]
		public Dictionary<string, object> MJAFLLGKAGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x16A3210", Offset = "0x16A1E10", VA = "0x1816A3210", Slot = "4")]
		protected virtual Dictionary<string, object> ALDCBAHFKME(Dictionary<string, object> NFDLIAHGNGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x16A3450", Offset = "0x16A2050", VA = "0x1816A3450")]
		protected void BHFABIPDNFC(string GMCMHIFODNN, Dictionary<string, object> KNFBJPBLDPM, Dictionary<string, object> PIENGNMLAHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x16A34F0", Offset = "0x16A20F0", VA = "0x1816A34F0")]
		protected void DKPJFBGFJOA(string GMCMHIFODNN, string JHEBJPCMJGD, Dictionary<string, object> OCBJIMOOBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x16A3670", Offset = "0x16A2270", VA = "0x1816A3670", Slot = "5")]
		public virtual void MIDEKGGPNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x16A3560", Offset = "0x16A2160", VA = "0x1816A3560", Slot = "6")]
		public virtual void JFNOGKCBGMB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NCCIEMGINGA : global::GOLNBMNMGMN<AmplitudeAnalyticsIdentifyMessage, NCCIEMGINGA>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override NCCIEMGINGA AJHBGLMEBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x61FB10", Offset = "0x61E710", VA = "0x18061FB10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage OFLACAMOBOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x16A8BB0", Offset = "0x16A77B0", VA = "0x1816A8BB0")]
	public NCCIEMGINGA(AmplitudeAnalyticsIdentifyMessage MCDGHKDLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x16A8B20", Offset = "0x16A7720", VA = "0x1816A8B20", Slot = "4")]
	public override void JFNOGKCBGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GDIKAPIKIMM : global::GOLNBMNMGMN<AmplitudeAnalyticsEvent, GDIKAPIKIMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool HOFHIBOLOBG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override GDIKAPIKIMM AJHBGLMEBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x61FB10", Offset = "0x61E710", VA = "0x18061FB10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x16A6390", Offset = "0x16A4F90", VA = "0x1816A6390")]
	public GDIKAPIKIMM(AmplitudeAnalyticsEvent MCDGHKDLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x552080", VA = "0x180553480", Slot = "5")]
	public override AmplitudeAnalyticsEvent OFLACAMOBOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x16A62F0", Offset = "0x16A4EF0", VA = "0x1816A62F0", Slot = "4")]
	public override void JFNOGKCBGMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2761130", Offset = "0x275FD30", VA = "0x182761130")]
	public GDIKAPIKIMM CCMOBDFHGBJ<T>(string GAHBHMKCAPG, T[] JHEBJPCMJGD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x16A6270", Offset = "0x16A4E70", VA = "0x1816A6270")]
	public GDIKAPIKIMM CCMOBDFHGBJ(string GAHBHMKCAPG, string[] JHEBJPCMJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27610C0", Offset = "0x275FCC0", VA = "0x1827610C0")]
	public GDIKAPIKIMM CCMOBDFHGBJ<T>(string GAHBHMKCAPG, T JHEBJPCMJGD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x16A6280", Offset = "0x16A4E80", VA = "0x1816A6280")]
	public GDIKAPIKIMM CCMOBDFHGBJ(string GAHBHMKCAPG, string JHEBJPCMJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x16A6190", Offset = "0x16A4D90", VA = "0x1816A6190")]
	private GDIKAPIKIMM BFDLHEFECDO(string GAHBHMKCAPG, object JHEBJPCMJGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KFEDPPEINHM : GDIKAPIKIMM
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x16A6390", Offset = "0x16A4F90", VA = "0x1816A6390")]
	public KFEDPPEINHM(AmplitudeAnalyticsEvent MCDGHKDLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x16A6DB0", Offset = "0x16A59B0", VA = "0x1816A6DB0", Slot = "4")]
	public override void JFNOGKCBGMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class GOLNBMNMGMN<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::GOLNBMNMGMN<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M MCDGHKDLPFF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR AJHBGLMEBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x825910", Offset = "0x824510", VA = "0x180825910")]
	public GOLNBMNMGMN(M MCDGHKDLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x828BD0", Offset = "0x8277D0", VA = "0x180828BD0")]
	public BLDR MOGIMFIPCPA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ACEPKHFGMHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x828C40", Offset = "0x827840", VA = "0x180828C40")]
	public BLDR OPIHAFGPPEK(AmplitudeAnalyticsIdentifyMessage.RevenueData HNMMPDDNDGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x828C80", Offset = "0x827880", VA = "0x180828C80")]
	public BLDR PPJFELMEFMM(string GAHBHMKCAPG, string JHEBJPCMJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x28A1320", Offset = "0x289FF20", VA = "0x1828A1320")]
	public BLDR PPJFELMEFMM<T>(string GAHBHMKCAPG, T JHEBJPCMJGD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JFNOGKCBGMB();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x828C10", Offset = "0x827810", VA = "0x180828C10")]
	internal static string OBIKABPIKML(string JHEBJPCMJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x828AF0", Offset = "0x8276F0", VA = "0x180828AF0")]
	private BLDR JBBENBOHFCN(string GAHBHMKCAPG, object JHEBJPCMJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M OFLACAMOBOP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HHLEEPCIEJM
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string JPJHKCMPDEG = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string MHFGDGCAGFL = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string HJOBMOMPDPJ = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string OIEKPJCMEJK = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string ALGFMIKABJK = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string ABCGFJBOEDP = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string ELJKODCDGNK = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string BKCLEBPIFFA = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string LKAIDENCHPN = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string HPLHGLBPJMP = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string HJMOEAJCFPA = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string MBLEGIAONHH = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string EPJFPHIPMEI = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string FCLANMBKLDF = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string CFEKJLACIKA = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string CGGHNKAIBLN = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string EAPOBCKACHL = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string EDLGBDKOHBK = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string HFIDHCDKEFP = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string ODMADHBJCKF = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string MJLBCNHNPAD = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string BFLOIBFLFLO = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public HHLEEPCIEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HLFLLPGOAGC
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int IBFIFJMGJHJ = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int FBILKJLNLMH = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int FJIPKBJABNO = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long POKNMKFFGCC = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int KACDFJMDCKH = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int LKLFOCDPGON = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string IINDCALBMDJ = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string NCNNBDKKNLG = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string COLFEHOOPJD = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string MIEAOAEOJEK = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string FKPGJJKEIJJ = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string FCLAIIEGOCB = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string ENMJJOHHLKO = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string PKLCMFEFAIE = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string BOOKCIMOFEL = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string FBEOLKBLAJI = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string BCLKFGHCINB = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string MEFKCHDCELG = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string NPBFPECDDAO = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string FIEJDDCBFID = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string EJMCPKGFOHJ = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string DEPDKCINMAB = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string FJJOPLMOPAO = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string IBAEAHBOPGL = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string JCDGOPIODPH = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string BDBIMBPEDCI = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string OONCIBHENKL = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string APCNLCDHIEC = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string HLDEAFCKKIM = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string FKLGENMPNDJ = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string NFCOOBIBJBB = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string MEAPFOJHIGE = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string ALGFMIKABJK = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string JFEEHNLBFPK = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int OEPDJGBDKPC = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> KGMOECFLMKD;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x16A63E0", Offset = "0x16A4FE0", VA = "0x1816A63E0")]
	internal static bool OPCIBGEOMGK(string GMCMHIFODNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public HLFLLPGOAGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KELHHOHCDJP
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool BANMIONBKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string MDPPDBPHHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string DCECBNLEBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string BOPGELLPFCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string JFGDCAJMHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::NHGODCKFGMA<DDLIOHEAMMM> GODNKCDGGNN(string MNFPOJEFGCL, Dictionary<string, string> AKKMFPHLGLK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::NHGODCKFGMA<DDLIOHEAMMM> EGBICFHBCHB(string MNFPOJEFGCL, string KGACKMMFLFH, string FHNLADODLDP, string GCIDJHCDGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DDLIOHEAMMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int NICEOPIBEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string GJGNHAPFLIH;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x57F980", Offset = "0x57E580", VA = "0x18057F980")]
	public DDLIOHEAMMM(int JNACEKNOGGP, string HIIBFNNKHCP)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x16A5270", Offset = "0x16A3E70", VA = "0x1816A5270")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x16A5370", Offset = "0x16A3F70", VA = "0x1816A5370")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
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

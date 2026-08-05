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
public class KENMFNHHDIM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string PLGIFDMIJOD = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string DFCABKKPHPB = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string COKBDIJDFDH = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string IKHAAIEGLAE = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string BAHEOKCCFCO = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string GCCIBIACNAC = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string NFLCOKJENLK = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long KKPMBIJFGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GDHMIACPKHA ICFMLADKDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool DBFFOPBIDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float CGMMFDEDENE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5751A60", Offset = "0x5750660", VA = "0x185751A60")]
	public KENMFNHHDIM(string FAPNFLHIJNK, float CGMMFDEDENE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E5E0", Offset = "0x2E0D1E0", VA = "0x182E0E5E0")]
	public void EMBDEJJLICO<T>(string EAIGMDJHNBA, T PDMPLJICJLE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x57517E0", Offset = "0x57503E0", VA = "0x1857517E0")]
	public void EMBDEJJLICO(string EAIGMDJHNBA, string PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x57516C0", Offset = "0x57502C0", VA = "0x1857516C0")]
	public void APDMMFGNHHP(string OKHPBMADCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5751960", Offset = "0x5750560", VA = "0x185751960")]
	public void HBFIEOOILPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5751860", Offset = "0x5750460", VA = "0x185751860")]
	private void FPKGGMBJBLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5751A10", Offset = "0x5750610", VA = "0x185751A10")]
	private bool LDKOLNJHNPM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NOPDKOMDKKP
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IHEBICEMHFG CMEOLNMPNEL(string ECONDGLAIHK, string OEHEGHADODK, [Optional] CPLDGLIELGP CIGGEIHNCGP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IHEBICEMHFG MLCACJLNOPE(CPLDGLIELGP CIGGEIHNCGP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OHKHLIBNJBB(string PBAMHGBDNMH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LPBFJKPNAIO GKABGHCKGBE(string OOPLGALKMEG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LPBFJKPNAIO MNLNCEGFGEJ(string MJNAHPALLIH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHEBICEMHFG AEKGIOOIFAF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IHCAFIADOJJ : NOPDKOMDKKP
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string LCNDIJDELIA = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string PPDDDOIDMOL = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string CILIENLIKGH = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string MODOEPADNDP = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string HNPOEALGAJB = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string KLDEOPFDIJB = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string LNKDKJAHMCC = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string AKJLIACLLPA = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string LPEDIMNFOAL = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, CCLFDFLNPNG> HOLMIAPLGIF;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int PMKILHKEMAE = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool DBMKFPMNIAN;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	[Preserve]
	public IHCAFIADOJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x574EE20", Offset = "0x574DA20", VA = "0x18574EE20")]
	[CMANADLJIIG(PKJIHGJIELK.Unity_BeforeSceneLoad)]
	private static void CFKPKEIJBEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x574EF80", Offset = "0x574DB80", VA = "0x18574EF80", Slot = "4")]
	public IHEBICEMHFG CMEOLNMPNEL(string ECONDGLAIHK, string OEHEGHADODK, [Optional] CPLDGLIELGP CIGGEIHNCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x574ECE0", Offset = "0x574D8E0", VA = "0x18574ECE0", Slot = "9")]
	public IHEBICEMHFG AEKGIOOIFAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x574FAB0", Offset = "0x574E6B0", VA = "0x18574FAB0", Slot = "5")]
	public IHEBICEMHFG MLCACJLNOPE(CPLDGLIELGP CIGGEIHNCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x574FCF0", Offset = "0x574E8F0", VA = "0x18574FCF0", Slot = "6")]
	public bool OHKHLIBNJBB(string PBAMHGBDNMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x574F9A0", Offset = "0x574E5A0", VA = "0x18574F9A0", Slot = "7")]
	public LPBFJKPNAIO GKABGHCKGBE(string OOPLGALKMEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x574FC00", Offset = "0x574E800", VA = "0x18574FC00", Slot = "8")]
	public LPBFJKPNAIO MNLNCEGFGEJ(string MJNAHPALLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x574F380", Offset = "0x574DF80", VA = "0x18574F380")]
	private KHIMNDHCKOH EAPHIEKOLLC(CPLDGLIELGP CIGGEIHNCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x574FDB0", Offset = "0x574E9B0", VA = "0x18574FDB0")]
	private AOBBDKGPBNG OJILOEHFGPC(string OEHEGHADODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x574F7A0", Offset = "0x574E3A0", VA = "0x18574F7A0")]
	private void FHAPNLCDPGC(string OOPLGALKMEG, LPBFJKPNAIO IJELEBLONGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x841D90", Offset = "0x840990", VA = "0x180841D90")]
	[CompilerGenerated]
	private void HBFGDMAEILO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NFCHFFBHAJB
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KENMFNHHDIM IDIOINCADAD(string FAPNFLHIJNK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CPLDGLIELGP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NGMMLICPGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KAEDANLKECD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KALJPDFLLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AMHIJAMCLBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? MHJHBCCDACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? LBFEIBAFOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int KPDENFAAHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string MECJCEAFKCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string PMDBMIEKGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string MBOGLNDPMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string AGGLHFHBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string KDBKGHDIDBG
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
		public AmplitudeAnalyticsClient.Settings CBHFLFMCACL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ELDHFMKECEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5E4190", Offset = "0x5E2D90", VA = "0x1805E4190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum GENALLBJCEF
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum IIDLGHDAONF
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class KDFNNNDMHJF
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class NKLEIKOCPFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int JIHONCNDPEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> DCHFNFHGIKH;

				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
				public NKLEIKOCPFB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class INCFMABLFEO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
				public INCFMABLFEO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x5750350", Offset = "0x574EF50", VA = "0x185750350")]
				internal bool <GetBatch>b__0(NKLEIKOCPFB item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string KELBABEGMGB = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string BMKGDMDCJNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<NKLEIKOCPFB> OFEOFFOBDEK;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? BKKHCMHHMDL
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x57512C0", Offset = "0x574FEC0", VA = "0x1857512C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? ODMGCMHAKLL
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x5751350", Offset = "0x574FF50", VA = "0x185751350")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5751560", Offset = "0x5750160", VA = "0x185751560")]
			internal KDFNNNDMHJF(string FNBKPMLLAOE, string OEHEGHADODK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x5751400", Offset = "0x5750000", VA = "0x185751400")]
			public int OOMLIAPHNGI([Optional] int? KGKJEMAFDEO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5750780", Offset = "0x574F380", VA = "0x185750780")]
			public List<Dictionary<string, object>> BKFMNKJFKDG(int HNIICJDAGNJ, int? KGKJEMAFDEO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x5750DE0", Offset = "0x574F9E0", VA = "0x185750DE0")]
			public void IPBAILDIPBF(AmplitudeAnalyticsIdentifyMessage HLJJNKOAONN, bool BMFMMGFCBOK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5750E80", Offset = "0x574FA80", VA = "0x185750E80")]
			public void IPBAILDIPBF(Dictionary<string, object> HLJJNKOAONN, bool BMFMMGFCBOK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5751170", Offset = "0x574FD70", VA = "0x185751170")]
			public void JCMBLNJHOAP(params Dictionary<string, object>[] JHDNIAJEFPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5750980", Offset = "0x574F580", VA = "0x185750980")]
			public void CDAHDMLCLGF(List<Dictionary<string, object>> LOCOIKDFGPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5750CD0", Offset = "0x574F8D0", VA = "0x185750CD0")]
			private void HOKGFJGONNL(Dictionary<string, object> HLJJNKOAONN, bool BMFMMGFCBOK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5750F80", Offset = "0x574FB80", VA = "0x185750F80")]
			public void JCIICLEAMDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x57503B0", Offset = "0x574EFB0", VA = "0x1857503B0")]
			private void AOKLEPOBHGH([Optional] string GEHLOAJJFOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5750BA0", Offset = "0x574F7A0", VA = "0x185750BA0")]
			private static string FAJBMJKKKFH(string PDMPLJICJLE, string IHPCMBAPNMC)
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
			[Cpp2IlInjected.Address(RVA = "0x5752ED0", Offset = "0x5751AD0", VA = "0x185752ED0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private struct LNDEHLBJJBJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int FIGFMANJLJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string LNIKGKKGFIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T KIDBPFKDMOF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PKIMJJJAGMK : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private GGCFHHNCLAL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public PKIMJJJAGMK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5752690", Offset = "0x5751290", VA = "0x185752690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5752D60", Offset = "0x5751960", VA = "0x185752D60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HOFPKJFIDKK : IEnumerator<object>, IEnumerator, IDisposable
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
			public DLLPNBKFAHM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public HOFPKJFIDKK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x574EBA0", Offset = "0x574D7A0", VA = "0x18574EBA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x574EC90", Offset = "0x574D890", VA = "0x18574EC90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class EOFOEAHJPHN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public EOFOEAHJPHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x574E1A0", Offset = "0x574CDA0", VA = "0x18574E1A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x574E310", Offset = "0x574CF10", VA = "0x18574E310", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IICBDMDHCHA : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private GGCFHHNCLAL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public IICBDMDHCHA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x574FFF0", Offset = "0x574EBF0", VA = "0x18574FFF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5750220", Offset = "0x574EE20", VA = "0x185750220", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class KFJLJCGMIFP : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private GGCFHHNCLAL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public KFJLJCGMIFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x5751BC0", Offset = "0x57507C0", VA = "0x185751BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x5751E00", Offset = "0x5750A00", VA = "0x185751E00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class DGHFPODCONM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public KDFNNNDMHJF cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public DGHFPODCONM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x574DBE0", Offset = "0x574C7E0", VA = "0x18574DBE0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x574DC80", Offset = "0x574C880", VA = "0x18574DC80")]
			internal void <FlushFromCache>b__1(LNDEHLBJJBJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class PDGOCNIDHDO : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private GGCFHHNCLAL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public KDFNNNDMHJF cache;

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
			private DGHFPODCONM <>8__1;

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
			private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
			[DebuggerHidden]
			public PDGOCNIDHDO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5751F80", Offset = "0x5750B80", VA = "0x185751F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5752640", Offset = "0x5751240", VA = "0x185752640", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class CFIFLGKGODG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
			public CFIFLGKGODG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2446290", Offset = "0x2444E90", VA = "0x182446290")]
			internal LNDEHLBJJBJ<T> <PostRudderStackJson>b__0(MLPOCMJJDFB postResponse)
			{
				return default(LNDEHLBJJBJ<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DFCMHCFNJKG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
			public DFCMHCFNJKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2446290", Offset = "0x2444E90", VA = "0x182446290")]
			internal LNDEHLBJJBJ<T> <PostAmplitudeJson>b__0(MLPOCMJJDFB postResponse)
			{
				return default(LNDEHLBJJBJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private GIECEGNIGBG CFBENDIDFFO;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string NBHICPPLCHL = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string OGBKOJEBJGL = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string HIOBBAMIBJM = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string OGGIODAOICM = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string HGJPHKIMNLB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int OOILGBAOBMG = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int DHIJOCJNGJK = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int NFIHMHIECBB = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float CCHALBLDFOE = 60f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long IAKPOOPLHJH = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string EEKGJABKMJD = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string NPCNBPNKGJL = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool APDLLIDMMJB;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool GBDBEEFHLOO;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int HLFDDMKDHJI;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int AMCNEHIEAFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private JOMCONKMBKI KLBEIDKMEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool OONGFLPIJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float KEJGEFNOMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float LMMJIMHEJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int ENDKCECMFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int GHBNADCMPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? MBFHJNCMFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? CGHPAJBDOLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long GIEMEPFGDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string DIFOGKFLJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long IGGEKPHONAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> JOKLJIOHOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IIDLGHDAONF DLHPMJGKDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int DBOOCHCGDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int HAIMPCNCBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float FIBPAOKNLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool OMEBKIJKABB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool GJMIDPBPEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private KDFNNNDMHJF DILJHPMODPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private KDFNNNDMHJF IMGGGIFCDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private KDFNNNDMHJF EEOHJHMJION;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JKMJGKPPADE;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BAAMGABDEEI;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string IJNPABNHFHP;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string PDHCOMGFNEA = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string KAOOPDHPHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string NJJFKGPCOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string ODFPCJPINNP;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const string PENELFLCCEO = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const string GNFGOCJANNO = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private GIECEGNIGBG EJILOODPFNI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x574B9A0", Offset = "0x574A5A0", VA = "0x18574B9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int DCNDDOBFKNN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x57493A0", Offset = "0x5747FA0", VA = "0x1857493A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long AOJPJFCCMAE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x574CD40", Offset = "0x574B940", VA = "0x18574CD40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x574CE40", Offset = "0x574BA40", VA = "0x18574CE40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string OIBDPHOPEAM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x574CCE0", Offset = "0x574B8E0", VA = "0x18574CCE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string NJFKLGABCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x574CD10", Offset = "0x574B910", VA = "0x18574CD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string IIABFAHKDAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x608700", Offset = "0x607300", VA = "0x180608700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5F6260", Offset = "0x5F4E60", VA = "0x1805F6260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? LBFEIBAFOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x66D8F0", Offset = "0x66C4F0", VA = "0x18066D8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1037960", Offset = "0x1036560", VA = "0x181037960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public GENALLBJCEF? BLKLKAPBCPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x66FAA0", Offset = "0x66E6A0", VA = "0x18066FAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x213A5F0", Offset = "0x21391F0", VA = "0x18213A5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MBFNFMLBILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xBEE250", Offset = "0xBECE50", VA = "0x180BEE250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x195BEE0", Offset = "0x195AAE0", VA = "0x18195BEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool JFKKADFFGOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x574CC00", Offset = "0x574B800", VA = "0x18574CC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> BBKAMDCNJGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x574CB60", Offset = "0x574B760", VA = "0x18574CB60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x574CDA0", Offset = "0x574B9A0", VA = "0x18574CDA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5748AF0", Offset = "0x57476F0", VA = "0x185748AF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5749650", Offset = "0x5748250", VA = "0x185749650")]
		private void GBEJDMJJEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x574C580", Offset = "0x574B180", VA = "0x18574C580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x574BA90", Offset = "0x574A690", VA = "0x18574BA90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x574C700", Offset = "0x574B300", VA = "0x18574C700")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x574BD60", Offset = "0x574A960", VA = "0x18574BD60")]
		public IHEBICEMHFG PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x574AEC0", Offset = "0x5749AC0", VA = "0x18574AEC0")]
		[IteratorStateMachine(typeof(PKIMJJJAGMK))]
		public IEnumerator<GGCFHHNCLAL> Initialize(AmplitudeAnalyticsEvent BJPAKBJEMAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x574C650", Offset = "0x574B250", VA = "0x18574C650")]
		public void UpdateLastAliveTime(float KNGIDGOCLLP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5748DD0", Offset = "0x57479D0", VA = "0x185748DD0")]
		private IHEBICEMHFG BMOOLCPLHGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x574BB30", Offset = "0x574A730", VA = "0x18574BB30")]
		private IHEBICEMHFG PEOMAGBJDCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x574C210", Offset = "0x574AE10", VA = "0x18574C210")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x574AF50", Offset = "0x5749B50", VA = "0x18574AF50")]
		[IteratorStateMachine(typeof(HOFPKJFIDKK))]
		private IEnumerator JDGOANOJKPP(DLLPNBKFAHM NAKDJFELKKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x574C960", Offset = "0x574B560", VA = "0x18574C960")]
		[IteratorStateMachine(typeof(EOFOEAHJPHN))]
		public IEnumerator WaitForFlush(float CFAFKOMKLHB = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x574C590", Offset = "0x574B190", VA = "0x18574C590")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x574ABC0", Offset = "0x57497C0", VA = "0x18574ABC0")]
		public static IIMPDPPCAOD Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x57489B0", Offset = "0x57475B0", VA = "0x1857489B0")]
		public static GDHMIACPKHA AccountSelectionPostLoginEvent([NotNull] string IHHNLIGFMJI, string KBCFMLGLAHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5749150", Offset = "0x5747D50", VA = "0x185749150")]
		public static GDHMIACPKHA Event([NotNull] string IHHNLIGFMJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x574BDE0", Offset = "0x574A9E0", VA = "0x18574BDE0")]
		public static GDHMIACPKHA PreviousSessionEvent([NotNull] string IHHNLIGFMJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x574AD00", Offset = "0x5749900", VA = "0x18574AD00")]
		public static GDHMIACPKHA InitializeEvent(string KBCFMLGLAHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x574C320", Offset = "0x574AF20", VA = "0x18574C320")]
		public static GDHMIACPKHA StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5748E90", Offset = "0x5747A90", VA = "0x185748E90")]
		public static GDHMIACPKHA CreateOutOfSessionEvent(string IHHNLIGFMJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x574B2F0", Offset = "0x5749EF0", VA = "0x18574B2F0")]
		public static IHEBICEMHFG LogOutOfSessionEvent(GDHMIACPKHA FLHLHJMKHFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x574B140", Offset = "0x5749D40", VA = "0x18574B140")]
		public void LogEventAsync(AmplitudeAnalyticsEvent NBOKOIIHIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x574B620", Offset = "0x574A220", VA = "0x18574B620")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent NBOKOIIHIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x574B6F0", Offset = "0x574A2F0", VA = "0x18574B6F0")]
		public void LogSerializedEventAsync(Dictionary<string, object> LMOCIIBKHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x574B210", Offset = "0x5749E10", VA = "0x18574B210")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LPGMCNDFDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5749F10", Offset = "0x5748B10", VA = "0x185749F10")]
		private void GJHHNFNHDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x57498D0", Offset = "0x57484D0", VA = "0x1857498D0")]
		private void GFIBCDACEEE(Dictionary<string, object> OGFPOEEEHND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x57488C0", Offset = "0x57474C0", VA = "0x1857488C0")]
		private void APEEMKLMANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x574B810", Offset = "0x574A410", VA = "0x18574B810")]
		private void NJOIOBHKIBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x57495C0", Offset = "0x57481C0", VA = "0x1857495C0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5748840", Offset = "0x5747440", VA = "0x185748840")]
		[IteratorStateMachine(typeof(IICBDMDHCHA))]
		private IEnumerator<GGCFHHNCLAL> AKEKMCCBJCE(float CFAFKOMKLHB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5749850", Offset = "0x5748450", VA = "0x185749850")]
		[IteratorStateMachine(typeof(KFJLJCGMIFP))]
		private IEnumerator<GGCFHHNCLAL> GFHFJMBJENO(float CFAFKOMKLHB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x574AAE0", Offset = "0x57496E0", VA = "0x18574AAE0")]
		[IteratorStateMachine(typeof(PDGOCNIDHDO))]
		private IEnumerator<GGCFHHNCLAL> IIBFGDLHJAG(KDFNNNDMHJF EJBOOPKBJLP, int? KGKJEMAFDEO, string BCOBHDAINEE, string NKGEKJHKNIK, float CFAFKOMKLHB, Action<int> BCHPPGPFENI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x57492B0", Offset = "0x5747EB0", VA = "0x1857492B0")]
		private static void FBGECOPEJID(bool OOHDKEOBCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5749B00", Offset = "0x5748700", VA = "0x185749B00")]
		private global::OEKDNOIOMEB<LNDEHLBJJBJ<Dictionary<string, object>>> GJEDPKHEOHH(string BCOBHDAINEE, string NKGEKJHKNIK, string COPKJKADPAP, string GNCIBFDCBIP, Dictionary<string, object> KIDBPFKDMOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5749C70", Offset = "0x5748870", VA = "0x185749C70")]
		private global::OEKDNOIOMEB<LNDEHLBJJBJ<List<Dictionary<string, object>>>> GJEDPKHEOHH(string BCOBHDAINEE, string NKGEKJHKNIK, string COPKJKADPAP, string GNCIBFDCBIP, List<Dictionary<string, object>> KIDBPFKDMOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4450", Offset = "0x1DF3050", VA = "0x181DF4450")]
		private global::OEKDNOIOMEB<LNDEHLBJJBJ<T>> PFDLENDBEAE<T>(string BCOBHDAINEE, string NKGEKJHKNIK, string GNCIBFDCBIP, T KIDBPFKDMOF, Dictionary<string, object> JNODGLICEAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4180", Offset = "0x1DF2D80", VA = "0x181DF4180")]
		private global::OEKDNOIOMEB<LNDEHLBJJBJ<T>> DLKNHBCODCJ<T>(string BCOBHDAINEE, string NKGEKJHKNIK, string COPKJKADPAP, T KIDBPFKDMOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x574B7C0", Offset = "0x574A3C0", VA = "0x18574B7C0")]
		private bool MJDOKCBOHFH(float PJIFCMEMIJD, float CFAFKOMKLHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5749FC0", Offset = "0x5748BC0", VA = "0x185749FC0")]
		private Dictionary<string, object> GNGFFPAGBMJ(string NKGEKJHKNIK, Dictionary<string, object> KIDBPFKDMOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x574CA40", Offset = "0x574B640", VA = "0x18574CA40")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x574AFE0", Offset = "0x5749BE0", VA = "0x18574AFE0")]
		[CompilerGenerated]
		private long JMBAACCBIDG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x574BA80", Offset = "0x574A680", VA = "0x18574BA80")]
		[CompilerGenerated]
		private void OIAAOMHJIPH(int JFDLGIHJEFB)
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
			[Cpp2IlInjected.Address(RVA = "0x5EA620", Offset = "0x5E9220", VA = "0x1805EA620")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x574D350", Offset = "0x574BF50", VA = "0x18574D350")]
		public static GDHMIACPKHA NEKFKHFNPIG(string PGLJOAGFHIO, [NotNull] string CMIIFKJAGJF, long DEADNJJHECI, long KOFKLNEMOJL, string KBCFMLGLAHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x574D150", Offset = "0x574BD50", VA = "0x18574D150")]
		public static GDHMIACPKHA IGKPEFFMJPI(string PGLJOAGFHIO, [NotNull] string CMIIFKJAGJF, long DEADNJJHECI, long KOFKLNEMOJL, string KBCFMLGLAHB, long PDJADBEHHLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x574D430", Offset = "0x574C030", VA = "0x18574D430")]
		private AmplitudeAnalyticsEvent(string PGLJOAGFHIO, [NotNull] string CMIIFKJAGJF, long DEADNJJHECI, long KOFKLNEMOJL, string KBCFMLGLAHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x125B970", Offset = "0x125A570", VA = "0x18125B970")]
		public void MLKKMOPPJGM(long EPCCAKBPCPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x574D240", Offset = "0x574BE40", VA = "0x18574D240", Slot = "5")]
		public override void MMDHJOKNHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x574D0E0", Offset = "0x574BCE0", VA = "0x18574D0E0", Slot = "6")]
		public override void FLHBHADFOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x574CEA0", Offset = "0x574BAA0", VA = "0x18574CEA0", Slot = "4")]
		protected override Dictionary<string, object> AIHIJOJBPLF(Dictionary<string, object> PFILCLMFGLA)
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
			[Cpp2IlInjected.Address(RVA = "0x574E080", Offset = "0x574CC80", VA = "0x18574E080")]
			public void BPDJHMMAIGK(Dictionary<string, object> BEPANNICMJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5752DB0", Offset = "0x57519B0", VA = "0x185752DB0")]
			public void BPDJHMMAIGK(Dictionary<string, object> KFKAGNGKHFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x13215B0", Offset = "0x13201B0", VA = "0x1813215B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x574DA80", Offset = "0x574C680", VA = "0x18574DA80")]
		public static IIMPDPPCAOD NEKFKHFNPIG(string PGLJOAGFHIO, string KBCFMLGLAHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x574DB20", Offset = "0x574C720", VA = "0x18574DB20")]
		protected AmplitudeAnalyticsIdentifyMessage(string PGLJOAGFHIO, string KBCFMLGLAHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x574D8F0", Offset = "0x574C4F0", VA = "0x18574D8F0")]
		public Dictionary<string, object> GCLFIPKEAMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x574D5D0", Offset = "0x574C1D0", VA = "0x18574D5D0", Slot = "4")]
		protected virtual Dictionary<string, object> AIHIJOJBPLF(Dictionary<string, object> PFILCLMFGLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x574D960", Offset = "0x574C560", VA = "0x18574D960")]
		protected void HIPOBLAEKJK(string IHPCMBAPNMC, Dictionary<string, object> LBOPKIPFLIA, Dictionary<string, object> BIOKGDIJEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x574D810", Offset = "0x574C410", VA = "0x18574D810")]
		protected void BLIIHNKCOAK(string IHPCMBAPNMC, string PDMPLJICJLE, Dictionary<string, object> LHENAJIADMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x574DA00", Offset = "0x574C600", VA = "0x18574DA00", Slot = "5")]
		public virtual void MMDHJOKNHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x574D880", Offset = "0x574C480", VA = "0x18574D880", Slot = "6")]
		public virtual void FLHBHADFOJH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IIMPDPPCAOD : global::LPFEAKEOMHM<AmplitudeAnalyticsIdentifyMessage, IIMPDPPCAOD>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override IIMPDPPCAOD GFNLDLGKFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x699F60", Offset = "0x698B60", VA = "0x180699F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PBINGFAMGLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5750300", Offset = "0x574EF00", VA = "0x185750300")]
	public IIMPDPPCAOD(AmplitudeAnalyticsIdentifyMessage EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5750270", Offset = "0x574EE70", VA = "0x185750270", Slot = "4")]
	public override void FLHBHADFOJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class GDHMIACPKHA : global::LPFEAKEOMHM<AmplitudeAnalyticsEvent, GDHMIACPKHA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool CHBAJBEOGHN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override GDHMIACPKHA GFNLDLGKFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x699F60", Offset = "0x698B60", VA = "0x180699F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x574EB50", Offset = "0x574D750", VA = "0x18574EB50")]
	public GDHMIACPKHA(AmplitudeAnalyticsEvent EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0", Slot = "5")]
	public override AmplitudeAnalyticsEvent PBINGFAMGLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x574EAB0", Offset = "0x574D6B0", VA = "0x18574EAB0", Slot = "4")]
	public override void FLHBHADFOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2187B40", Offset = "0x2186740", VA = "0x182187B40")]
	public GDHMIACPKHA EMBDEJJLICO<T>(string EAIGMDJHNBA, T[] PDMPLJICJLE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x574EA30", Offset = "0x574D630", VA = "0x18574EA30")]
	public GDHMIACPKHA EMBDEJJLICO(string EAIGMDJHNBA, string[] PDMPLJICJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2187AD0", Offset = "0x21866D0", VA = "0x182187AD0")]
	public GDHMIACPKHA EMBDEJJLICO<T>(string EAIGMDJHNBA, T PDMPLJICJLE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x574EA40", Offset = "0x574D640", VA = "0x18574EA40")]
	public GDHMIACPKHA EMBDEJJLICO(string EAIGMDJHNBA, string PDMPLJICJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x574E950", Offset = "0x574D550", VA = "0x18574E950")]
	private GDHMIACPKHA EDDCPEJGGLP(string EAIGMDJHNBA, object PDMPLJICJLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NNNEGLOJEJJ : GDHMIACPKHA
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x574EB50", Offset = "0x574D750", VA = "0x18574EB50")]
	public NNNEGLOJEJJ(AmplitudeAnalyticsEvent EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5751E50", Offset = "0x5750A50", VA = "0x185751E50", Slot = "4")]
	public override void FLHBHADFOJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class LPFEAKEOMHM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::LPFEAKEOMHM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M EHGGIAFACBG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public abstract BLDR GFNLDLGKFJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A4C340", Offset = "0x2A4AF40", VA = "0x182A4C340")]
	public LPFEAKEOMHM(M EHGGIAFACBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x34EF2B0", Offset = "0x34EDEB0", VA = "0x1834EF2B0")]
	public BLDR HCOOIOHKFKA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo IEHJBDDLPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x34EF270", Offset = "0x34EDE70", VA = "0x1834EF270")]
	public BLDR GJOKNCIMAEB(AmplitudeAnalyticsIdentifyMessage.RevenueData NJKDNCFHHGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x34EF320", Offset = "0x34EDF20", VA = "0x1834EF320")]
	public BLDR POJPICOLCBD(string EAIGMDJHNBA, string PDMPLJICJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2392B30", Offset = "0x2391730", VA = "0x182392B30")]
	public BLDR POJPICOLCBD<T>(string EAIGMDJHNBA, T PDMPLJICJLE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FLHBHADFOJH();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x34EF2F0", Offset = "0x34EDEF0", VA = "0x1834EF2F0")]
	internal static string HNAADABGFMG(string PDMPLJICJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x34EF190", Offset = "0x34EDD90", VA = "0x1834EF190")]
	private BLDR BCAHOCAPELI(string EAIGMDJHNBA, object PDMPLJICJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PBINGFAMGLN();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ICGFAIAAJEI
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string EJKANFCGLAP = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string JPOHMCPNGOA = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string DIDCLFPCMGF = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string DDOBIKKBOEB = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string HFDMGGFIIIM = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string OIHHAABEGOA = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string JOPJOANHCGN = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string FAPCIHPJJEK = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string IJGPACNAGLC = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string DEDIKPKGPFH = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string FOFDALHEHDO = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string KNGKCEPKKHL = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string OEAKICKEHOO = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string EBKDDCMNLLD = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string OAMMJAHBIHC = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string BDDDMKIMKAM = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string ALOKCNBKEPH = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string CKJGPJDPHBL = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string FOPPHLHLCCN = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string PMNICFLIOFK = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string EOBOGCNDCDH = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string ENCIEKHCHBG = "type";

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public ICGFAIAAJEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AJHLCJAPGMP
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int CKMOLHMANPK = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int EFFDNJAJFKG = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int AACCNMGFFBL = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long PNIIDACLIAN = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int NBGBPJFPDKN = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int LKIGAJHDJGB = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string GCJBLEHJEHD = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string LBMCPIEPBGA = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string GCLBEOBLBJC = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string BKNKHFKILHO = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string ILNCKOPLEAN = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string CHMKHJHELKI = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string PHOOIDNNECH = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string AEHBELAFGON = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string BIHPNKOJMBI = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string ICLPBNBIAHN = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string GOBBHINOHLG = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string KHKABICJNKJ = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string ONAKKKNFNIA = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string KFKILFDBJGO = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string LCIAHAIICMA = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string LBABDFDIDDM = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string NLEKLGNBKDJ = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string PMOJNECMNAF = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string MAIIALADLFC = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string KIJCFNPFGAL = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string NHLCPCIJAPI = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string CGHDAJIMACL = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string FJAOCLPJFCD = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string MEEDCOBOGBD = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string MMKFEPGCGBI = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string JCKGLDLGHEM = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string HFDMGGFIIIM = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string KBGDOKKCGFG = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int OEFPOOCGGHB = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> EAMFBICHJFN;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x57486F0", Offset = "0x57472F0", VA = "0x1857486F0")]
	internal static bool DFCEIKDLKKE(string IHPCMBAPNMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public AJHLCJAPGMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JOMCONKMBKI
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool JNPIFBADBBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	string NABOMMFPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string JCHNCNJOPNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string MEDMNKDMFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string GHGIIJNFCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OEKDNOIOMEB<MLPOCMJJDFB> GJEDPKHEOHH(string BCOBHDAINEE, Dictionary<string, string> BBNCDCAJFIN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::OEKDNOIOMEB<MLPOCMJJDFB> FCDLEMBAINC(string BCOBHDAINEE, string MPPPMLBLLDH, string BPEEJPLLPAE, string MBHFEIKMJHC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MLPOCMJJDFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int HICILBOANMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string KBAGPEFDIDA;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCF0", Offset = "0x5EB8F0", VA = "0x1805ECCF0")]
	public MLPOCMJJDFB(int FIGFMANJLJE, string LNIKGKKGFIJ)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x574E690", Offset = "0x574D290", VA = "0x18574E690")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x574E360", Offset = "0x574CF60", VA = "0x18574E360")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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

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
public class EEPFFKBFLMP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const string ALGMBBDIHLH = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const string DLBAMEOGNLG = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const string KKDDGIFLGNO = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const string INBLGDGOBFJ = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const string MMCDKAFOFFM = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string NODAMMNFEGA = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const string HEFIOLFKIPB = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private long BGHCFNPFEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BCFJNDOAKIJ DPEJEMIOACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private bool JPOECBAFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private float BHOKLPHBGHB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D07170", Offset = "0x5D05F70", VA = "0x185D07170")]
	public EEPFFKBFLMP(string FAOFGPCLMGO, float BHOKLPHBGHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DEB160", Offset = "0x1DE9F60", VA = "0x181DEB160")]
	public void JAIJIIFFMPK<T>(string HLOAMKBCFBD, T IGJPNMBCJPK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D06F40", Offset = "0x5D05D40", VA = "0x185D06F40")]
	public void JAIJIIFFMPK(string HLOAMKBCFBD, string IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D06FC0", Offset = "0x5D05DC0", VA = "0x185D06FC0")]
	public void MJEICPIACCK(string FIIJEHOFFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D070B0", Offset = "0x5D05EB0", VA = "0x185D070B0")]
	public void NFHBHOPJOGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D06DD0", Offset = "0x5D05BD0", VA = "0x185D06DD0")]
	private void BIINJFPNFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D06EF0", Offset = "0x5D05CF0", VA = "0x185D06EF0")]
	private bool CIHIHHGKICI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EMDEJHMJNFH
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPIGAOPELEF ILMEFAAGLOH(string IHPLNIOJAGB, string ONLGPPKMDMB, [Optional] IJOJPEIOOBP FNLDHGOLBGO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPIGAOPELEF PGBLEOHFKLM(IJOJPEIOOBP FNLDHGOLBGO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NPIGAOPELEF FBBLIEEKLNB(IJOJPEIOOBP FNLDHGOLBGO, Dictionary<string, string> JLCPKJCNCFM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OOECJONHCIK(string HNEBPNGJGAC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FJLHKBJGGME OFIOBDGONOK(string ELCMBCFBDJK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FJLHKBJGGME CCGLIMJKMGH(string OOAPNOGLFAN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NPIGAOPELEF ONGNNLHJCDK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AAENFOFODNP : EMDEJHMJNFH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const string KLLHLFDENCC = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const string NFPMILOIPHG = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private const string NCMHPFHMFOD = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private const string GIJJCHCPDHH = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const string IMFNLMNICLI = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const string ACOOHOIGMEG = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string GEPIIALFIFE = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string MFDAIAJODIF = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string IADKHGKKMLM = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IReadOnlyDictionary<string, MMKDBIMFFMD> MJGJNFILHAO;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int GJKMLKPFDJI = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool AKOPDNBDFEC;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	[Preserve]
	public AAENFOFODNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF720", Offset = "0x5CFE520", VA = "0x185CFF720")]
	[IMCONJMNGLO(KJBNBKOGAAL.GameOnly)]
	private static void NMBGPMOHKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEB20", Offset = "0x5CFD920", VA = "0x185CFEB20", Slot = "4")]
	public NPIGAOPELEF ILMEFAAGLOH(string IHPLNIOJAGB, string ONLGPPKMDMB, [Optional] IJOJPEIOOBP FNLDHGOLBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF930", Offset = "0x5CFE730", VA = "0x185CFF930", Slot = "10")]
	public NPIGAOPELEF ONGNNLHJCDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFB70", Offset = "0x5CFE970", VA = "0x185CFFB70", Slot = "5")]
	public NPIGAOPELEF PGBLEOHFKLM(IJOJPEIOOBP FNLDHGOLBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE830", Offset = "0x5CFD630", VA = "0x185CFE830", Slot = "6")]
	public NPIGAOPELEF FBBLIEEKLNB(IJOJPEIOOBP FNLDHGOLBGO, Dictionary<string, string> JLCPKJCNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFAC0", Offset = "0x5CFE8C0", VA = "0x185CFFAC0", Slot = "7")]
	public bool OOECJONHCIK(string HNEBPNGJGAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF820", Offset = "0x5CFE620", VA = "0x185CFF820", Slot = "8")]
	public FJLHKBJGGME OFIOBDGONOK(string ELCMBCFBDJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE5A0", Offset = "0x5CFD3A0", VA = "0x185CFE5A0", Slot = "9")]
	public FJLHKBJGGME CCGLIMJKMGH(string OOAPNOGLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEFC0", Offset = "0x5CFDDC0", VA = "0x185CFEFC0")]
	private FNKOINICFOP LMOFDBABALA(IJOJPEIOOBP FNLDHGOLBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE690", Offset = "0x5CFD490", VA = "0x185CFE690")]
	private BNKEFDOAIAB EPJBEGNBEMP(string ONLGPPKMDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF4D0", Offset = "0x5CFE2D0", VA = "0x185CFF4D0")]
	private void MFIPIELKGAK(string ELCMBCFBDJK, FJLHKBJGGME HHBPPIPMCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xE6CD00", Offset = "0xE6BB00", VA = "0x180E6CD00")]
	[CompilerGenerated]
	private void ACKNHOLFGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FAEBKFDLDPE
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EEPFFKBFLMP AKMKBPOBLHO(string FAOFGPCLMGO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IJOJPEIOOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GGNNBEJNHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JNKCOPGFOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FIJJFCONFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ACCPEOMEHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool? KFMJCFEIJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? KDIGNJODILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int KABNIJGEHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string GLJFLJKOAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string FBPDGNEHNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string JPFMDGAMFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string GMLHJLNAFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string MJDEGBEGLNN
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
		public AmplitudeAnalyticsClient.Settings ILNDEOLIECB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OCHKMEDAEIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x65BD70", Offset = "0x65AB70", VA = "0x18065BD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum MLJJKECMLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private enum KCCMMOHFGLH
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		internal class FKIDGPFACLA
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private class LCJNGEPMKMK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				public int CKOOFKONDFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				public Dictionary<string, object> OIBAGHJOLFG;

				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
				public LCJNGEPMKMK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class GMIOKEHMIEE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
				public GMIOKEHMIEE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x5D08C20", Offset = "0x5D07A20", VA = "0x185D08C20")]
				internal bool <GetBatch>b__0(LCJNGEPMKMK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private const string GEMHKDFGIFJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private readonly string KCGMDGFIHOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private List<LCJNGEPMKMK> MNILPILGDCP;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int? GDMIEEFFFMK
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x5D07880", Offset = "0x5D06680", VA = "0x185D07880")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int? JJNEPHGLAJL
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x5D089D0", Offset = "0x5D077D0", VA = "0x185D089D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x5D08A90", Offset = "0x5D07890", VA = "0x185D08A90")]
			internal FKIDGPFACLA(string NFGPIKIIOCK, string ONLGPPKMDMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5D08840", Offset = "0x5D07640", VA = "0x185D08840")]
			public int NNBFLFPLMIC([Optional] int? CPAAMACALBM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5D075F0", Offset = "0x5D063F0", VA = "0x185D075F0")]
			public List<Dictionary<string, object>> CEAEACGGJFF(int OEDOGKAFLFO, int? CPAAMACALBM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5D07920", Offset = "0x5D06720", VA = "0x185D07920")]
			public void EBLELBIDADA(AmplitudeAnalyticsIdentifyMessage CCPIHKCBGHF, bool CNDACGGLJCB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5D079C0", Offset = "0x5D067C0", VA = "0x185D079C0")]
			public void EBLELBIDADA(Dictionary<string, object> CCPIHKCBGHF, bool CNDACGGLJCB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5D086B0", Offset = "0x5D074B0", VA = "0x185D086B0")]
			public void MNLCCIMIJNI(params Dictionary<string, object>[] NIFPBBIBNMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5D07C00", Offset = "0x5D06A00", VA = "0x185D07C00")]
			public void FHLMFFLMCOL(List<Dictionary<string, object>> ONMBEBBFIFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5D08300", Offset = "0x5D07100", VA = "0x185D08300")]
			private void HBEPAGBNPFE(Dictionary<string, object> CCPIHKCBGHF, bool CNDACGGLJCB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5D08440", Offset = "0x5D07240", VA = "0x185D08440")]
			public void KJIDCEFJBFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5D07E50", Offset = "0x5D06C50", VA = "0x185D07E50")]
			private void GIJLHNJNAAN([Optional] string BLPKMOHCJBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5D07AD0", Offset = "0x5D068D0", VA = "0x185D07AD0")]
			private static string FABPPLHNHBB(string IGJPNMBCJPK, string CCJNKBLKLDJ)
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
			[Cpp2IlInjected.Address(RVA = "0x5D0AA10", Offset = "0x5D09810", VA = "0x185D0AA10")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct MELIPEEEADL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int AAEJHIKNDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public string JPOJNLNNJOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public T LCLKMJEKKLN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NNMHABMLILF : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private BAGIJDLGAMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public NNMHABMLILF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5D099A0", Offset = "0x5D087A0", VA = "0x185D099A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5D09F90", Offset = "0x5D08D90", VA = "0x185D09F90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KANEBENIJED : IEnumerator<object>, IEnumerator, IDisposable
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
			public ENDBBJEPCAJ quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public KANEBENIJED(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5D09410", Offset = "0x5D08210", VA = "0x185D09410", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5D09500", Offset = "0x5D08300", VA = "0x185D09500", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class BJJEKFIMFIH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public BJJEKFIMFIH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5D06AA0", Offset = "0x5D058A0", VA = "0x185D06AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5D06C10", Offset = "0x5D05A10", VA = "0x185D06C10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class INCKKGEDGNC : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private BAGIJDLGAMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public INCKKGEDGNC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5D08C80", Offset = "0x5D07A80", VA = "0x185D08C80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5D08F20", Offset = "0x5D07D20", VA = "0x185D08F20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class FDJLKDNBMEE : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private BAGIJDLGAMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public FDJLKDNBMEE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x5D07310", Offset = "0x5D06110", VA = "0x185D07310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x5D075B0", Offset = "0x5D063B0", VA = "0x185D075B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class JHLGBAOBEHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public FKIDGPFACLA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public JHLGBAOBEHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x5D08F60", Offset = "0x5D07D60", VA = "0x185D08F60")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D09000", Offset = "0x5D07E00", VA = "0x185D09000")]
			internal void <FlushFromCache>b__1(MELIPEEEADL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class NOBHODNDGFC : IEnumerator<BAGIJDLGAMA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private BAGIJDLGAMA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public FKIDGPFACLA cache;

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
			private JHLGBAOBEHE <>8__1;

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
			private BAGIJDLGAMA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A9")]
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
			[DebuggerHidden]
			public NOBHODNDGFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5D09FD0", Offset = "0x5D08DD0", VA = "0x185D09FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x5D0A860", Offset = "0x5D09660", VA = "0x185D0A860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NAOEEGCDILA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
			public NAOEEGCDILA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1E8BD20", Offset = "0x1E8AB20", VA = "0x181E8BD20")]
			internal MELIPEEEADL<T> <PostRudderStackJson>b__0(PNCHFNOCHOG postResponse)
			{
				return default(MELIPEEEADL<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class MIEJHAAMMCG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xD5A370", Offset = "0xD59170", VA = "0x180D5A370")]
			public MIEJHAAMMCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1E8BD20", Offset = "0x1E8AB20", VA = "0x181E8BD20")]
			internal MELIPEEEADL<T> <PostAmplitudeJson>b__0(PNCHFNOCHOG postResponse)
			{
				return default(MELIPEEEADL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private NJPIIIJKOJL HOHOICKDPPN;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string BICFAGNKLJA = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string LDDAIKKHHDD = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string JABMOCCBJIK = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const int CNELBPKAGAP = 10;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int GGDDGHAPABF = 10;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const int HHAOOCJKHNH = 5;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const float GICELECANBC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const long CHFCFBDOMAI = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string MOOPDLGGAOL = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string OONNNBKPPMO = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static bool HODKNKNJLKI;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static bool NFINJAHHKFO;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static int OFHMKODJECO;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static int JDMMLIIACAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private HEGGOCELMBO HGPJECFDNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool NDJFIEJJEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float KMEMBNGCOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float JONOJKDIEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int OHCCGHDJILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private int NHFCAPNGDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int? HEIKOJAJCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int? EOPKLAIOHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private long EFBDCCCKFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private string CJBBIADBNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private long EAPKEPEDPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<string, object> ACKJPDPKOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private KCCMMOHFGLH LKIEAEOKDPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int HDBNAGGMMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int ADGCEJMJJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float NPMMBKPOONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool MICMEEOHAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool FGGKNHDJNFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private FKIDGPFACLA ILDNCNAPEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private FKIDGPFACLA LMFLKJKHHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private FKIDGPFACLA KMIPKEJDGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> DOGJMNFDDBK;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MIKMPFKJBHP;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static string MLAMHEIPFNE;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const string GJNJNFFNAPN = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly string IIFEIICCAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly string BGOENDHOJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly string MNIKNJPJJPI;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private NJPIIIJKOJL AIGNJJBPOMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5D02520", Offset = "0x5D01320", VA = "0x185D02520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int PANIDGAEKII
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5D02E30", Offset = "0x5D01C30", VA = "0x185D02E30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static long DFNMFLKDCMI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5D05370", Offset = "0x5D04170", VA = "0x185D05370")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5D05470", Offset = "0x5D04270", VA = "0x185D05470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static string NONPEPLICEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5D05310", Offset = "0x5D04110", VA = "0x185D05310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static string EGPFNGMAPKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5D05340", Offset = "0x5D04140", VA = "0x185D05340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string AGKPAKFFJEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x657080", Offset = "0x655E80", VA = "0x180657080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x678830", Offset = "0x677630", VA = "0x180678830")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int? KDIGNJODILJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x70B910", Offset = "0x70A710", VA = "0x18070B910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x17022F0", Offset = "0x17010F0", VA = "0x1817022F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MLJJKECMLCJ? EJCGNAEKEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x69EC00", Offset = "0x69DA00", VA = "0x18069EC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xC791F0", Offset = "0xC77FF0", VA = "0x180C791F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool IHKMKLOECEA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x16E98E0", Offset = "0x16E86E0", VA = "0x1816E98E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x16E89C0", Offset = "0x16E77C0", VA = "0x1816E89C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool GOJNCPPNEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5D05220", Offset = "0x5D04020", VA = "0x185D05220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JNOBFJENDFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5D05180", Offset = "0x5D03F80", VA = "0x185D05180")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5D053D0", Offset = "0x5D041D0", VA = "0x185D053D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D005F0", Offset = "0x5CFF3F0", VA = "0x185D005F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D039B0", Offset = "0x5D027B0", VA = "0x185D039B0")]
		private void MCMCIPPPPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5D049D0", Offset = "0x5D037D0", VA = "0x185D049D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D03FC0", Offset = "0x5D02DC0", VA = "0x185D03FC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D04CC0", Offset = "0x5D03AC0", VA = "0x185D04CC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D040F0", Offset = "0x5D02EF0", VA = "0x185D040F0")]
		public NPIGAOPELEF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D02910", Offset = "0x5D01710", VA = "0x185D02910")]
		[IteratorStateMachine(typeof(NNMHABMLILF))]
		public IEnumerator<BAGIJDLGAMA> Initialize(AmplitudeAnalyticsEvent DKIHJAOMOHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D04BB0", Offset = "0x5D039B0", VA = "0x185D04BB0")]
		public void UpdateLastAliveTime(float BBCCLHDKIDF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D02C80", Offset = "0x5D01A80", VA = "0x185D02C80")]
		private NPIGAOPELEF KJEONAGPLPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D03CD0", Offset = "0x5D02AD0", VA = "0x185D03CD0")]
		private NPIGAOPELEF MMAJDBLGEGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5D045F0", Offset = "0x5D033F0", VA = "0x185D045F0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D04060", Offset = "0x5D02E60", VA = "0x185D04060")]
		[IteratorStateMachine(typeof(KANEBENIJED))]
		private IEnumerator PFEEBPMJCPN(ENDBBJEPCAJ IEKLOOGHNMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5D04F30", Offset = "0x5D03D30", VA = "0x185D04F30")]
		[IteratorStateMachine(typeof(BJJEKFIMFIH))]
		public IEnumerator WaitForFlush(float AHJIFDNMDHL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5D04A90", Offset = "0x5D03890", VA = "0x185D04A90")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5D049E0", Offset = "0x5D037E0", VA = "0x185D049E0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EPNJJECKICP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D025A0", Offset = "0x5D013A0", VA = "0x185D025A0")]
		public static KEIGOMLHMME Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5D00480", Offset = "0x5CFF280", VA = "0x185D00480")]
		public static BCFJNDOAKIJ AccountSelectionPostLoginEvent([NotNull] string KECOIAENMIH, string MOHDDNKANPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5D01100", Offset = "0x5CFFF00", VA = "0x185D01100")]
		public static BCFJNDOAKIJ Event([NotNull] string KECOIAENMIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5D04150", Offset = "0x5D02F50", VA = "0x185D04150")]
		public static BCFJNDOAKIJ PreviousSessionEvent([NotNull] string KECOIAENMIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5D02700", Offset = "0x5D01500", VA = "0x185D02700")]
		public static BCFJNDOAKIJ InitializeEvent(string MOHDDNKANPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5D04710", Offset = "0x5D03510", VA = "0x185D04710")]
		public static BCFJNDOAKIJ StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D00960", Offset = "0x5CFF760", VA = "0x185D00960")]
		public static BCFJNDOAKIJ CreateOutOfSessionEvent(string KECOIAENMIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D032C0", Offset = "0x5D020C0", VA = "0x185D032C0")]
		public static NPIGAOPELEF LogOutOfSessionEvent(BCFJNDOAKIJ CEGEGPIGDEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5D03000", Offset = "0x5D01E00", VA = "0x185D03000")]
		public void LogEventAsync(AmplitudeAnalyticsEvent DDAIBIFADDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D03660", Offset = "0x5D02460", VA = "0x185D03660")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent DDAIBIFADDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D037B0", Offset = "0x5D025B0", VA = "0x185D037B0")]
		public void LogSerializedEventAsync(Dictionary<string, object> MKEPIPFDPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D03150", Offset = "0x5D01F50", VA = "0x185D03150")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HAAMOJEOBEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D02D50", Offset = "0x5D01B50", VA = "0x185D02D50")]
		private void LAHGJEGDEEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5D029F0", Offset = "0x5D017F0", VA = "0x185D029F0")]
		private void JPELMFAAOAA(Dictionary<string, object> JEGEKBCLIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D01310", Offset = "0x5D00110", VA = "0x185D01310")]
		private void GCECCKNNHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D02100", Offset = "0x5D00F00", VA = "0x185D02100")]
		private void GHNCOEJNOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D01280", Offset = "0x5D00080", VA = "0x185D01280")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5D03F40", Offset = "0x5D02D40", VA = "0x185D03F40")]
		[IteratorStateMachine(typeof(INCKKGEDGNC))]
		private IEnumerator<BAGIJDLGAMA> NJEFPMEMEEG(float AHJIFDNMDHL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5D008E0", Offset = "0x5CFF6E0", VA = "0x185D008E0")]
		[IteratorStateMachine(typeof(FDJLKDNBMEE))]
		private IEnumerator<BAGIJDLGAMA> BFEHCHBKGCJ(float AHJIFDNMDHL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5D022E0", Offset = "0x5D010E0", VA = "0x185D022E0")]
		[IteratorStateMachine(typeof(NOBHODNDGFC))]
		private IEnumerator<BAGIJDLGAMA> HHNNHPBNCOE(FKIDGPFACLA BGMEKLANEFA, int? CPAAMACALBM, string DKLBKIAJABA, string PLFNIMHNFCP, float AHJIFDNMDHL, Action<int> PMALNIADKCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5D03890", Offset = "0x5D02690", VA = "0x185D03890")]
		private static void MAMOIDHGDPC(bool NLEPJGFMBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5D00C00", Offset = "0x5CFFA00", VA = "0x185D00C00")]
		private global::DGCAEBAFOOK<MELIPEEEADL<Dictionary<string, object>>> ECIMPGHGIKN(string DKLBKIAJABA, string PLFNIMHNFCP, string JMIELHGIODH, string FFDGIJGIENK, Dictionary<string, object> LCLKMJEKKLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D00DB0", Offset = "0x5CFFBB0", VA = "0x185D00DB0")]
		private global::DGCAEBAFOOK<MELIPEEEADL<List<Dictionary<string, object>>>> ECIMPGHGIKN(string DKLBKIAJABA, string PLFNIMHNFCP, string JMIELHGIODH, string FFDGIJGIENK, List<Dictionary<string, object>> LCLKMJEKKLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1EED8D0", Offset = "0x1EEC6D0", VA = "0x181EED8D0")]
		private global::DGCAEBAFOOK<MELIPEEEADL<T>> JAJAMFLKLGP<T>(string DKLBKIAJABA, string PLFNIMHNFCP, string FFDGIJGIENK, T LCLKMJEKKLN, Dictionary<string, object> DJBEODOABDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1EED590", Offset = "0x1EEC390", VA = "0x181EED590")]
		private global::DGCAEBAFOOK<MELIPEEEADL<T>> AGEHJDGPCGA<T>(string DKLBKIAJABA, string PLFNIMHNFCP, string JMIELHGIODH, T LCLKMJEKKLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5D029A0", Offset = "0x5D017A0", VA = "0x185D029A0")]
		private bool JBPNLDIGLEH(float AEIJLDBDDCG, float AHJIFDNMDHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5D01400", Offset = "0x5D00200", VA = "0x185D01400")]
		private Dictionary<string, object> GGJFIFFGBCM(string PLFNIMHNFCP, Dictionary<string, object> LCLKMJEKKLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5D05010", Offset = "0x5D03E10", VA = "0x185D05010")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5D023C0", Offset = "0x5D011C0", VA = "0x185D023C0")]
		[CompilerGenerated]
		private long HLNJEGFAEDA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D02590", Offset = "0x5D01390", VA = "0x185D02590")]
		[CompilerGenerated]
		private void IGMAOAPONIJ(int BFDJLEBAKOH)
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
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D055F0", Offset = "0x5D043F0", VA = "0x185D055F0")]
		public static BCFJNDOAKIJ DAKLFHBAJIH(string JKGBPKEJAFA, [NotNull] string IDGLLMDCFMK, long CJKKHMEGJHI, long DNADNOCINDD, string MOHDDNKANPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D056E0", Offset = "0x5D044E0", VA = "0x185D056E0")]
		public static BCFJNDOAKIJ EBDCALBOOFD(string JKGBPKEJAFA, [NotNull] string IDGLLMDCFMK, long CJKKHMEGJHI, long DNADNOCINDD, string MOHDDNKANPM, long BIOPAFLMHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D05B80", Offset = "0x5D04980", VA = "0x185D05B80")]
		private AmplitudeAnalyticsEvent(string JKGBPKEJAFA, [NotNull] string IDGLLMDCFMK, long CJKKHMEGJHI, long DNADNOCINDD, string MOHDDNKANPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1CCAAB0", Offset = "0x1CC98B0", VA = "0x181CCAAB0")]
		public void BMBLALJAOOL(long KPHPBNKJHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5D054D0", Offset = "0x5D042D0", VA = "0x185D054D0", Slot = "5")]
		public override void CIBDCDKJHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D057E0", Offset = "0x5D045E0", VA = "0x185D057E0", Slot = "6")]
		public override void IHIIONNFPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D05860", Offset = "0x5D04660", VA = "0x185D05860", Slot = "4")]
		protected override Dictionary<string, object> MJOCNHHAJNK(Dictionary<string, object> ALJJLGGGNLP)
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
			[Cpp2IlInjected.Address(RVA = "0x5D06C50", Offset = "0x5D05A50", VA = "0x185D06C50")]
			public void IGNCEEHEAAJ(Dictionary<string, object> BCKFMMODKPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D0A8A0", Offset = "0x5D096A0", VA = "0x185D0A8A0")]
			public void IGNCEEHEAAJ(Dictionary<string, object> MBFGIGIGJGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xE7B5A0", Offset = "0xE7A3A0", VA = "0x180E7B5A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x660AE0", Offset = "0x65F8E0", VA = "0x180660AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5D05DC0", Offset = "0x5D04BC0", VA = "0x185D05DC0")]
		public static KEIGOMLHMME DAKLFHBAJIH(string JKGBPKEJAFA, string MOHDDNKANPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5D063C0", Offset = "0x5D051C0", VA = "0x185D063C0")]
		protected AmplitudeAnalyticsIdentifyMessage(string JKGBPKEJAFA, string MOHDDNKANPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5D062D0", Offset = "0x5D050D0", VA = "0x185D062D0")]
		public Dictionary<string, object> NHCJCEEIFNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D05F90", Offset = "0x5D04D90", VA = "0x185D05F90", Slot = "4")]
		protected virtual Dictionary<string, object> MJOCNHHAJNK(Dictionary<string, object> ALJJLGGGNLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D05EF0", Offset = "0x5D04CF0", VA = "0x185D05EF0")]
		protected void IPJNANCIDFI(string CCJNKBLKLDJ, Dictionary<string, object> GJOBDKNLJBM, Dictionary<string, object> JNOIHAMPKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D06350", Offset = "0x5D05150", VA = "0x185D06350")]
		protected void PBHJKDBKGBK(string CCJNKBLKLDJ, string IGJPNMBCJPK, Dictionary<string, object> IBHEDDBCHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D05D40", Offset = "0x5D04B40", VA = "0x185D05D40", Slot = "5")]
		public virtual void CIBDCDKJHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D05E70", Offset = "0x5D04C70", VA = "0x185D05E70", Slot = "6")]
		public virtual void IHIIONNFPDC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KEIGOMLHMME : global::OOGIIHIJJPG<AmplitudeAnalyticsIdentifyMessage, KEIGOMLHMME>
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override KEIGOMLHMME OLMKEKHGNGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage DOHMFDMCJAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D097A0", Offset = "0x5D085A0", VA = "0x185D097A0")]
	public KEIGOMLHMME(AmplitudeAnalyticsIdentifyMessage GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D09700", Offset = "0x5D08500", VA = "0x185D09700", Slot = "4")]
	public override void IHIIONNFPDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class BCFJNDOAKIJ : global::OOGIIHIJJPG<AmplitudeAnalyticsEvent, BCFJNDOAKIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool AFMCKGNHDNA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override BCFJNDOAKIJ OLMKEKHGNGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public long MANLMMFMGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D06570", Offset = "0x5D05370", VA = "0x185D06570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D06A50", Offset = "0x5D05850", VA = "0x185D06A50")]
	public BCFJNDOAKIJ(AmplitudeAnalyticsEvent GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "5")]
	public override AmplitudeAnalyticsEvent DOHMFDMCJAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D06590", Offset = "0x5D05390", VA = "0x185D06590", Slot = "4")]
	public override void IHIIONNFPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D06880", Offset = "0x5D05680", VA = "0x185D06880")]
	public BCFJNDOAKIJ JAIJIIFFMPK(string HLOAMKBCFBD, long[] IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D066B0", Offset = "0x5D054B0", VA = "0x185D066B0")]
	public BCFJNDOAKIJ JAIJIIFFMPK(string HLOAMKBCFBD, ulong[] IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2495CF0", Offset = "0x2494AF0", VA = "0x182495CF0")]
	public BCFJNDOAKIJ JAIJIIFFMPK<T>(string HLOAMKBCFBD, T[] IGJPNMBCJPK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D06630", Offset = "0x5D05430", VA = "0x185D06630")]
	public BCFJNDOAKIJ JAIJIIFFMPK(string HLOAMKBCFBD, string[] IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2495C80", Offset = "0x2494A80", VA = "0x182495C80")]
	public BCFJNDOAKIJ JAIJIIFFMPK<T>(string HLOAMKBCFBD, T IGJPNMBCJPK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D067F0", Offset = "0x5D055F0", VA = "0x185D067F0")]
	public BCFJNDOAKIJ JAIJIIFFMPK(string HLOAMKBCFBD, long IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D069C0", Offset = "0x5D057C0", VA = "0x185D069C0")]
	public BCFJNDOAKIJ JAIJIIFFMPK(string HLOAMKBCFBD, ulong IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D06640", Offset = "0x5D05440", VA = "0x185D06640")]
	public BCFJNDOAKIJ JAIJIIFFMPK(string HLOAMKBCFBD, string IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D06480", Offset = "0x5D05280", VA = "0x185D06480")]
	private BCFJNDOAKIJ CAFKFKEFICB(string HLOAMKBCFBD, object IGJPNMBCJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KBHLMNOEGFB : BCFJNDOAKIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D06A50", Offset = "0x5D05850", VA = "0x185D06A50")]
	public KBHLMNOEGFB(AmplitudeAnalyticsEvent GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D09540", Offset = "0x5D08340", VA = "0x185D09540", Slot = "4")]
	public override void IHIIONNFPDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class OOGIIHIJJPG<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::OOGIIHIJJPG<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	protected M GOJKMEMCPDE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public abstract BLDR OLMKEKHGNGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x166AFE0", Offset = "0x1669DE0", VA = "0x18166AFE0")]
	public OOGIIHIJJPG(M GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8C10", Offset = "0x2CC7A10", VA = "0x182CC8C10")]
	public BLDR NINDLGOMOFK(AmplitudeAnalyticsIdentifyMessage.DeviceInfo CELNIEDNAKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8BD0", Offset = "0x2CC79D0", VA = "0x182CC8BD0")]
	public BLDR JAHMBFCOKFK(AmplitudeAnalyticsIdentifyMessage.RevenueData IFFCJGJLPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8A70", Offset = "0x2CC7870", VA = "0x182CC8A70")]
	public BLDR CCLOEOCJELL(string HLOAMKBCFBD, string IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x26AF410", Offset = "0x26AE210", VA = "0x1826AF410")]
	public BLDR CCLOEOCJELL<T>(string HLOAMKBCFBD, T IGJPNMBCJPK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2CC89C0", Offset = "0x2CC77C0", VA = "0x182CC89C0")]
	public BLDR CCLOEOCJELL(string HLOAMKBCFBD, long IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8910", Offset = "0x2CC7710", VA = "0x182CC8910")]
	public BLDR CCLOEOCJELL(string HLOAMKBCFBD, ulong IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IHIIONNFPDC();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8C50", Offset = "0x2CC7A50", VA = "0x182CC8C50")]
	internal static string PKBJPENNLCE(string IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2CC8AE0", Offset = "0x2CC78E0", VA = "0x182CC8AE0")]
	private BLDR FNIAMPINEFB(string HLOAMKBCFBD, object IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M DOHMFDMCJAO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class OLNGCFIMANO
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const string ALGCPIOGALA = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public const string BHODAOBEJJF = "type";

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public const string APHBKGLBHJJ = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public const string GHJFPEBGBFJ = "track";

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public const string FJELBKIAHJN = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public const string CBIJEJNEHPJ = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public const string PHEGOMKDGOD = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public const string HMFIBEPEBOL = "event";

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public const string AGEBBDEEHPG = "version";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public const string GBBAJGNNPBB = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public const string KCEGMGBAOPH = "name";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public const string OLOJPHJMFGM = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public const string EDBLOCNAMLC = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public const string EMBGBOKGGKE = "context";

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public const string LOAJLAAALCM = "app";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public const string AMLIBOKFIAC = "os";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public const string ENFHJBOHLCJ = "device";

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public const string EJFACGNFHDH = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public const string PEBGDGCMGLE = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public const string DHBHBBBONGH = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public const string MBFFHJKHIEH = "model";

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public const string GENMJGHHNLA = "type";

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public OLNGCFIMANO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LHHHGEPJKFM
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public const int GAKOBPEEDLB = 2;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public const int CNCEECMCBLM = 100;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public const int JEALBNCIJEA = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public const long EKEHKHPNLIA = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public const int FINLNDIHHEI = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const int PFEIPMEOJGD = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string JDKELAKMFFH = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string OIDDJOLOALD = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string PJCFEPHNAGM = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string JPHJHIIAONN = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string JLOFNMOCKEN = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string AGGIHAKDPLO = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string LBLOLIOPOOP = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string HCLOHFMBKDP = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string JEDKJEJGBBD = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string CEODLEEJJFE = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string LNGACKNPBAJ = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string AMJDJAJNKJL = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string PODNOLONDMJ = "language";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string DKNBCEPDLLL = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string LBKGAMLCPNN = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string BNAMIIDGONK = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string FELHAIENGMF = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string CHEOBMCPJGP = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string PDOHGJFHGHB = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string FPLDHBKCMBF = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string FNMCFMBJMGB = "price";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string IEAABDONPKB = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string AAACLACOMBB = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const string DKEFDIINCEE = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const string FOOBMJEOFLK = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const string MBBKKKJIFBL = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const string FJELBKIAHJN = "user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string AJFHBLEHHDJ = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int DLEBIMCEBFG = 10;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> PFJOMJJMALA;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D097F0", Offset = "0x5D085F0", VA = "0x185D097F0")]
	internal static bool LEIMGNHFCDH(string CCJNKBLKLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public LHHHGEPJKFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HEGGOCELMBO
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool PLFCKIKIMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	string MAMIEFDPLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string JMEKNGLOBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	string JHLBPPFBCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string MMJCNDCEHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::DGCAEBAFOOK<PNCHFNOCHOG> ECIMPGHGIKN(string DKLBKIAJABA, Dictionary<string, string> JLLMKEHLCEP, bool GIBCPMCDGGP = false);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::DGCAEBAFOOK<PNCHFNOCHOG> FPMKMKKPIAL(string DKLBKIAJABA, string NKBPFECEJGE, string PMFJGJHCOHC, string ONKDFCIFKPE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PNCHFNOCHOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public readonly int PHGLMAPACMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string AOIKLIIJLMO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x66BAF0", Offset = "0x66A8F0", VA = "0x18066BAF0")]
	public PNCHFNOCHOG(int AAEJHIKNDCA, string JPOJNLNNJOG)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFE50", Offset = "0x5CFEC50", VA = "0x185CFFE50")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFF60", Offset = "0x5CFED60", VA = "0x185CFFF60")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
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
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
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

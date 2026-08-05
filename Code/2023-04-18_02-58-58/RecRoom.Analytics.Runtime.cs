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
using Microsoft.CodeAnalysis;
using Mono.Math;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62B47B0", Offset = "0x62B39B0", VA = "0x1862B47B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LFFKCMNFNAN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	HUDHotbarShortcut
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KCIMFOOCLPN
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string GCDCAJMDAMC = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string KNILMKKJGNN = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string DDAICONNEFC = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string NMFEOPOGDCN = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string ICOEGDOHAHD = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string ODLMOIPHFBP = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string LKNEFBENLBF = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long HOFDBLNOELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private DPKIGFPJMOG DMDDCGAMKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool PEEGPFGOBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float AKPLFIBLHPE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62B2AD0", Offset = "0x62B1CD0", VA = "0x1862B2AD0")]
	public KCIMFOOCLPN(string OMNDAJEKHJK, float AKPLFIBLHPE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x12F3D00", Offset = "0x12F2F00", VA = "0x1812F3D00")]
	public void ENEFMCGBLHP<T>(string IDBLFHOOMPH, T IPMIIEAGJKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62B2820", Offset = "0x62B1A20", VA = "0x1862B2820")]
	public void ENEFMCGBLHP(string IDBLFHOOMPH, string IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62B2730", Offset = "0x62B1930", VA = "0x1862B2730")]
	public void DAAPFEPIECH(string NEGMLLAJBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62B29C0", Offset = "0x62B1BC0", VA = "0x1862B29C0")]
	public void HFJPIEEGHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62B28A0", Offset = "0x62B1AA0", VA = "0x1862B28A0")]
	private void FKLDCCGHCMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62B2A80", Offset = "0x62B1C80", VA = "0x1862B2A80")]
	private bool KBLIHCHDPOF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FEIKFKAICHC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JBIKLHMKBFN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action EKJKOIEKGPN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LAHBDKNMNHN IHEKMEOIBOI(string GIBGIOPDHKG, string POKGLPGKPDD, [Optional] IPBHBFJGDME LPHIPOLKJOK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LAHBDKNMNHN DDMCKHEPFFK(IPBHBFJGDME LPHIPOLKJOK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LAHBDKNMNHN KFDKDDMLNIN(IPBHBFJGDME LPHIPOLKJOK, Dictionary<string, string> HHCEPMOBEMK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OAPIGDEMKLB(string NCOOOGHDJCN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "9")]
	HAIDJDDBCPP JKKEADIFFDL(string BJJDBMNFODL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JCHCNCODBEK LGMMCBIOLDP(string GFAMFLKGNLI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HAIDJDDBCPP PFAFGEAKGKN(string BAAMCLMNOKE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LAHBDKNMNHN EMADMGFINCK();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SerializedStatsigExperiment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public SerializedStatsigExperiment()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x62B5630", Offset = "0x62B4830", VA = "0x1862B5630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FLKKIGBNCCP : FEIKFKAICHC
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string OKEOKDAPOKC = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string EMLFOCJILAA = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string GAKMEHIFGJM = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string PBGBLCMBLIG = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string PKNENMHAOBK = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string JKNBDDCNEHD = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string CJNMGIFKODC = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string GKPJAHLOHFG = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string JJIHNGOMOGN = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string EPLEEJBOOKL = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string OHGNNNHEAFJ = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, LLBKILJKONJ> FMMHNEKHDMP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int CGJPPPJJEML = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool NKMDGDBNNAD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x707B80", Offset = "0x706D80", VA = "0x180707B80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JBIKLHMKBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x62B15B0", Offset = "0x62B07B0", VA = "0x1862B15B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62B1480", Offset = "0x62B0680", VA = "0x1862B1480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action EKJKOIEKGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x62B0590", Offset = "0x62AF790", VA = "0x1862B0590", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62B09E0", Offset = "0x62AFBE0", VA = "0x1862B09E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62B0B10", Offset = "0x62AFD10", VA = "0x1862B0B10", Slot = "8")]
	public LAHBDKNMNHN IHEKMEOIBOI(string GIBGIOPDHKG, string POKGLPGKPDD, [Optional] IPBHBFJGDME LPHIPOLKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62B0850", Offset = "0x62AFA50", VA = "0x1862B0850", Slot = "16")]
	public LAHBDKNMNHN EMADMGFINCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62B0630", Offset = "0x62AF830", VA = "0x1862B0630", Slot = "10")]
	public LAHBDKNMNHN DDMCKHEPFFK(IPBHBFJGDME LPHIPOLKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62B10D0", Offset = "0x62B02D0", VA = "0x1862B10D0", Slot = "11")]
	public LAHBDKNMNHN KFDKDDMLNIN(IPBHBFJGDME LPHIPOLKJOK, Dictionary<string, string> HHCEPMOBEMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62B1650", Offset = "0x62B0850", VA = "0x1862B1650", Slot = "12")]
	public bool OAPIGDEMKLB(string NCOOOGHDJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62B0FB0", Offset = "0x62B01B0", VA = "0x1862B0FB0", Slot = "13")]
	public HAIDJDDBCPP JKKEADIFFDL(string BJJDBMNFODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62B13C0", Offset = "0x62B05C0", VA = "0x1862B13C0", Slot = "14")]
	public JCHCNCODBEK LGMMCBIOLDP(string GFAMFLKGNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62B20E0", Offset = "0x62B12E0", VA = "0x1862B20E0", Slot = "15")]
	public HAIDJDDBCPP PFAFGEAKGKN(string BAAMCLMNOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62B1950", Offset = "0x62B0B50", VA = "0x1862B1950")]
	private PNCICDBPIAO OOHLDJFBLOI(IPBHBFJGDME LPHIPOLKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62B1F40", Offset = "0x62B1140", VA = "0x1862B1F40")]
	private GBIPGLEPNMD PCKALMMDFLD(string POKGLPGKPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62B1700", Offset = "0x62B0900", VA = "0x1862B1700")]
	private void OMHJLKOOMAH(string BJJDBMNFODL, HAIDJDDBCPP FPJKGKBOAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public FLKKIGBNCCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA88FC0", Offset = "0xA881C0", VA = "0x180A88FC0")]
	[CompilerGenerated]
	private void CABMAJBPOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62B1520", Offset = "0x62B0720", VA = "0x1862B1520")]
	[CompilerGenerated]
	private void LPINHKIBPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62B0A80", Offset = "0x62AFC80", VA = "0x1862B0A80")]
	[CompilerGenerated]
	private void GNLOGLAHPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LAKDHAPEION : FEIKFKAICHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private FEIKFKAICHC APANFNLDDAH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private FEIKFKAICHC DLGMOOCFLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62B3050", Offset = "0x62B2250", VA = "0x1862B3050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x62B3000", Offset = "0x62B2200", VA = "0x1862B3000", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action JBIKLHMKBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62B3790", Offset = "0x62B2990", VA = "0x1862B3790", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x62B36F0", Offset = "0x62B28F0", VA = "0x1862B36F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action EKJKOIEKGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62B2C70", Offset = "0x62B1E70", VA = "0x1862B2C70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x62B30C0", Offset = "0x62B22C0", VA = "0x1862B30C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	[Preserve]
	public LAKDHAPEION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62B2E10", Offset = "0x62B2010", VA = "0x1862B2E10")]
	[IOFOCEAPGPD(NPBJMIOJGOK.GameOnly)]
	private static void EDLMAOJJALF(MNALHHOLFGL FMPHDMAKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62B3160", Offset = "0x62B2360", VA = "0x1862B3160", Slot = "8")]
	public LAHBDKNMNHN IHEKMEOIBOI(string GIBGIOPDHKG, string POKGLPGKPDD, [Optional] IPBHBFJGDME LPHIPOLKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62B2D10", Offset = "0x62B1F10", VA = "0x1862B2D10", Slot = "10")]
	public LAHBDKNMNHN DDMCKHEPFFK(IPBHBFJGDME LPHIPOLKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x62B34E0", Offset = "0x62B26E0", VA = "0x1862B34E0", Slot = "11")]
	public LAHBDKNMNHN KFDKDDMLNIN(IPBHBFJGDME LPHIPOLKJOK, Dictionary<string, string> HHCEPMOBEMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x62B3830", Offset = "0x62B2A30", VA = "0x1862B3830", Slot = "12")]
	public bool OAPIGDEMKLB(string NCOOOGHDJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62B3440", Offset = "0x62B2640", VA = "0x1862B3440", Slot = "13")]
	public HAIDJDDBCPP JKKEADIFFDL(string BJJDBMNFODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62B35F0", Offset = "0x62B27F0", VA = "0x1862B35F0", Slot = "14")]
	public JCHCNCODBEK LGMMCBIOLDP(string GFAMFLKGNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62B38D0", Offset = "0x62B2AD0", VA = "0x1862B38D0", Slot = "15")]
	public HAIDJDDBCPP PFAFGEAKGKN(string BAAMCLMNOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62B2F00", Offset = "0x62B2100", VA = "0x1862B2F00", Slot = "16")]
	public LAHBDKNMNHN EMADMGFINCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x709050", Offset = "0x708250", VA = "0x180709050")]
	[CompilerGenerated]
	private void PKKIBGAJCJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7092C0", Offset = "0x7084C0", VA = "0x1807092C0")]
	[CompilerGenerated]
	private void OKLBNMINADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CDPDJIGIFDF : FEIKFKAICHC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KKKHNMGIFMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JBIKLHMKBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62AF0C0", Offset = "0x62AE2C0", VA = "0x1862AF0C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x62AF020", Offset = "0x62AE220", VA = "0x1862AF020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action EKJKOIEKGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x62AEC40", Offset = "0x62ADE40", VA = "0x1862AEC40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x62AEE20", Offset = "0x62AE020", VA = "0x1862AEE20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x62AEEC0", Offset = "0x62AE0C0", VA = "0x1862AEEC0", Slot = "8")]
	public LAHBDKNMNHN IHEKMEOIBOI(string GIBGIOPDHKG, string POKGLPGKPDD, [Optional] IPBHBFJGDME LPHIPOLKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x62AECE0", Offset = "0x62ADEE0", VA = "0x1862AECE0", Slot = "10")]
	public LAHBDKNMNHN DDMCKHEPFFK(IPBHBFJGDME LPHIPOLKJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF70", Offset = "0x62AE170", VA = "0x1862AEF70", Slot = "11")]
	public LAHBDKNMNHN KFDKDDMLNIN(IPBHBFJGDME LPHIPOLKJOK, Dictionary<string, string> HHCEPMOBEMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "12")]
	public bool OAPIGDEMKLB(string NCOOOGHDJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF60", Offset = "0x62AE160", VA = "0x1862AEF60", Slot = "13")]
	public HAIDJDDBCPP JKKEADIFFDL(string BJJDBMNFODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x62AF010", Offset = "0x62AE210", VA = "0x1862AF010", Slot = "14")]
	public JCHCNCODBEK LGMMCBIOLDP(string GFAMFLKGNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF60", Offset = "0x62AE160", VA = "0x1862AEF60", Slot = "15")]
	public HAIDJDDBCPP PFAFGEAKGKN(string BAAMCLMNOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x62AED80", Offset = "0x62ADF80", VA = "0x1862AED80", Slot = "16")]
	public LAHBDKNMNHN EMADMGFINCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CDPDJIGIFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MPJBCJDMBJE
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KCIMFOOCLPN BMIHHEHJKHJ(string OMNDAJEKHJK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DGGLIBBJAJI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	long MCLCFHNFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OELMKDJIGJJ(string DELCOFCGDFF, string IFIOGAELNFO, string ACHDBHFNFGF);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPOCFFGGOIO(string DELCOFCGDFF);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OPNNDCCMGMB(string DELCOFCGDFF, string DDBBBDCIFDO, string FPLIGDLDFCA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJAACLEJOEF(string IEACNHGAIIE, object BMLDHMCNJGA, object HHOAKPCJELI);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JFNEDFLCJGP(long GEJNOCNOOLP, bool OOAGDMOJDFJ = true);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long ENFOMEJJFNM();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IPBHBFJGDME
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool JHEADBEHIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool BDHACDJKOPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FFHMDGJNLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CKHKGOOOAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool? EFJKJFECICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int? JDONLFOPABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int CLNJMCJOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string JNCPNACLMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string OPKKCOFGEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string CDFFDBIOEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string BCNABBFCOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string OOKGHBPNEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string AAFLMANACNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double GFGJJLNGFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public AmplitudeAnalyticsClient.Settings NKBIBPCOKHA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool ANCMLHBNLOA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8297A0", Offset = "0x8289A0", VA = "0x1808297A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private enum GLMBNAEMBID
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal class BNKPPHMCLDB
		{
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private class PKGNEMNDHEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public int CKJOPIINALG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public Dictionary<string, object> JKMGAGOJPMK;

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
				public PKGNEMNDHEH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class JOJPEOEPJDM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
				public JOJPEOEPJDM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x62B26D0", Offset = "0x62B18D0", VA = "0x1862B26D0")]
				internal bool <GetBatch>b__0(PKGNEMNDHEH item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private const string JFFGBBKFGPJ = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly string KDENKOIEIEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<PKGNEMNDHEH> EKFLJHCKOAF;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? EIGAFJPAIBL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x62ADC70", Offset = "0x62ACE70", VA = "0x1862ADC70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public int? KIAKFHAOEJI
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x62AE310", Offset = "0x62AD510", VA = "0x1862AE310")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x62AEAB0", Offset = "0x62ADCB0", VA = "0x1862AEAB0")]
			internal BNKPPHMCLDB(string BLHNPCLPKCN, string POKGLPGKPDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x62AE7F0", Offset = "0x62AD9F0", VA = "0x1862AE7F0")]
			public int KBJGECBGLJI([Optional] int? HBDHFGDAFNB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x62AE560", Offset = "0x62AD760", VA = "0x1862AE560")]
			public List<Dictionary<string, object>> JDNNCHLEPMN(int CLAGKNCFDLC, int? HBDHFGDAFNB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x62ADAC0", Offset = "0x62ACCC0", VA = "0x1862ADAC0")]
			public void BGIOKDGDBMH(AmplitudeAnalyticsIdentifyMessage ICHBECDKHOJ, bool ANEHNIGBNHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x62ADB60", Offset = "0x62ACD60", VA = "0x1862ADB60")]
			public void BGIOKDGDBMH(Dictionary<string, object> ICHBECDKHOJ, bool ANEHNIGBNHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x62AE3D0", Offset = "0x62AD5D0", VA = "0x1862AE3D0")]
			public void IIFJEKNAIKA(params Dictionary<string, object>[] OADJPPHPINN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x62ADD10", Offset = "0x62ACF10", VA = "0x1862ADD10")]
			public void EOFMJBAAOPK(List<Dictionary<string, object>> GNMMBBCOLFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x62ADF60", Offset = "0x62AD160", VA = "0x1862ADF60")]
			private void GEHIOBCOGIL(Dictionary<string, object> ICHBECDKHOJ, bool ANEHNIGBNHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x62AE0A0", Offset = "0x62AD2A0", VA = "0x1862AE0A0")]
			public void GIMFOMFALBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x62AD610", Offset = "0x62AC810", VA = "0x1862AD610")]
			private void AMOHJBKCNAP([Optional] string MPEIFDEDOCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x62AE980", Offset = "0x62ADB80", VA = "0x1862AE980")]
			private static string MEIKOLOCDCG(string IPMIIEAGJKC, string FDAIMOMOHIG)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x62B5880", Offset = "0x62B4A80", VA = "0x1862B5880")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct MAPBOPAPLPD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int PDFNEIPHEDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string DPFNLINFEDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T CCKLGMMKMEN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class DGAEDMJDBOP : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public DGAEDMJDBOP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x62AF5F0", Offset = "0x62AE7F0", VA = "0x1862AF5F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x62AFBE0", Offset = "0x62AEDE0", VA = "0x1862AFBE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FCKHMNMGPJJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public DBIPHDIEBCM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public FCKHMNMGPJJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x62B0460", Offset = "0x62AF660", VA = "0x1862B0460", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x62B0550", Offset = "0x62AF750", VA = "0x1862B0550", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class ONIJIFBMKLO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public ONIJIFBMKLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x62B5150", Offset = "0x62B4350", VA = "0x1862B5150", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x62B52C0", Offset = "0x62B44C0", VA = "0x1862B52C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class CGMLLLBFGKA : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D8")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public CGMLLLBFGKA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x62AF160", Offset = "0x62AE360", VA = "0x1862AF160", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x62AF400", Offset = "0x62AE600", VA = "0x1862AF400", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JILPPLCABBF : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E1")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public JILPPLCABBF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x62B23F0", Offset = "0x62B15F0", VA = "0x1862B23F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x62B2690", Offset = "0x62B1890", VA = "0x1862B2690", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LBJNAEIAJOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public BNKPPHMCLDB cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public LBJNAEIAJOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x62B3970", Offset = "0x62B2B70", VA = "0x1862B3970")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x62B3CE0", Offset = "0x62B2EE0", VA = "0x1862B3CE0")]
			internal void <FlushFromCache>b__1(MAPBOPAPLPD<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class OJPNFMGMDGJ : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public BNKPPHMCLDB cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private LBJNAEIAJOK <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public OJPNFMGMDGJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x62B4840", Offset = "0x62B3A40", VA = "0x1862B4840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x62B5110", Offset = "0x62B4310", VA = "0x1862B5110", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class AEFCEPAKFCC<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
			public AEFCEPAKFCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x29DEC10", Offset = "0x29DDE10", VA = "0x1829DEC10")]
			internal MAPBOPAPLPD<T> <PostRudderStackJson>b__0(OINMKBPJOIN postResponse)
			{
				return default(MAPBOPAPLPD<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class COIINIBDDGG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
			public COIINIBDDGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x29DEC10", Offset = "0x29DDE10", VA = "0x1829DEC10")]
			internal MAPBOPAPLPD<T> <PostAmplitudeJson>b__0(OINMKBPJOIN postResponse)
			{
				return default(MAPBOPAPLPD<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private BHNJIBDJFAL NJPJBDDAEFH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string IBDPMGEMMHI = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string DFGICINMFBI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string NCCCLHBDIJJ = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int HKNPDCPCDAI = 15;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int DLLEPIJJBEI = 10;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int NGNIBJJODHC = 5;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const float LLLIEPCKJDA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const long HDIBPOBBOBO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string HKINFIPCHFC = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private const string JOHEIPGBKBL = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static bool EPDJDCDHLMP;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static bool ANKEJBLLGMO;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static int ICJJMIILIKC;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static int DOJBGBMELOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private FOMPBHDLPDO DMGEELAKLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool ODHHEJEHDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float CMFGJMBOBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private float IEAHEEADLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int JBBGDADJKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int PCHLMEHIFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int? GHEMNLANHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int? OGOPMPAAJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long GNIICMDMHLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private string HGLACAGBHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private long NCDHIIGKPEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Dictionary<string, object> EJKBHCLNNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private GLMBNAEMBID CPFILFNNKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int NONFAIHAENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int MFDJOJNBAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float HHGMCEINOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool JDEGJHOAABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool BDIDFMAHHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private BNKPPHMCLDB APOMKAILFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private BNKPPHMCLDB MJHKCIKEPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private BNKPPHMCLDB KNGHFFGBING;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CPBBJKAEPGO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BPLDOEGCMKL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static string GEBGAHGKGMG;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string ALKMMENHDNB = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string ALJKCIOKCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly string MNBHHADNNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string NJEOLDAFEGD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private BHNJIBDJFAL PGHHCPJJBHA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x62A7F60", Offset = "0x62A7160", VA = "0x1862A7F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private static int NDNPPHIMGEO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x62A8790", Offset = "0x62A7990", VA = "0x1862A8790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static long IEIMGINLDCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x62ABFD0", Offset = "0x62AB1D0", VA = "0x1862ABFD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x62AC0D0", Offset = "0x62AB2D0", VA = "0x1862AC0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string MBOFFIHOGJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x62ABF70", Offset = "0x62AB170", VA = "0x1862ABF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static string HEHGNJLGONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x62ABFA0", Offset = "0x62AB1A0", VA = "0x1862ABFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string BAADEALBCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x91EA40", Offset = "0x91DC40", VA = "0x18091EA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x91E590", Offset = "0x91D790", VA = "0x18091E590")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int? JDONLFOPABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA449E0", Offset = "0xA43BE0", VA = "0x180A449E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xFCF7D0", Offset = "0xFCE9D0", VA = "0x180FCF7D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool MDCNKLDEFFB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6FFAF0", Offset = "0x6FECF0", VA = "0x1806FFAF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x13F47E0", Offset = "0x13F39E0", VA = "0x1813F47E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static bool NBNGCLGPNLI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x62ABE80", Offset = "0x62AB080", VA = "0x1862ABE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> KFNNEIDHCPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x62ABDE0", Offset = "0x62AAFE0", VA = "0x1862ABDE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x62AC030", Offset = "0x62AB230", VA = "0x1862AC030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62A72C0", Offset = "0x62A64C0", VA = "0x1862A72C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x62A9700", Offset = "0x62A8900", VA = "0x1862A9700")]
		private void LNFIJNJKDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62AB630", Offset = "0x62AA830", VA = "0x1862AB630")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62AAB70", Offset = "0x62A9D70", VA = "0x1862AAB70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62AB920", Offset = "0x62AAB20", VA = "0x1862AB920")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62AAC90", Offset = "0x62A9E90", VA = "0x1862AAC90")]
		public LAHBDKNMNHN PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62A8700", Offset = "0x62A7900", VA = "0x1862A8700")]
		[IteratorStateMachine(typeof(DGAEDMJDBOP))]
		public IEnumerator<EGGPGCCKPCO> Initialize(AmplitudeAnalyticsEvent GFKMCIOFCFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62AB810", Offset = "0x62AAA10", VA = "0x1862AB810")]
		public void UpdateLastAliveTime(float OKBAJEAPIHG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62A75B0", Offset = "0x62A67B0", VA = "0x1862A75B0")]
		private LAHBDKNMNHN CEEAKOILGIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62A7AC0", Offset = "0x62A6CC0", VA = "0x1862A7AC0")]
		private LAHBDKNMNHN EFDHPENNFBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62AB1E0", Offset = "0x62AA3E0", VA = "0x1862AB1E0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62A7010", Offset = "0x62A6210", VA = "0x1862A7010")]
		[IteratorStateMachine(typeof(FCKHMNMGPJJ))]
		private IEnumerator AAOIDDKBJLL(DBIPHDIEBCM BPHPIPHKHAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62ABB90", Offset = "0x62AAD90", VA = "0x1862ABB90")]
		[IteratorStateMachine(typeof(ONIJIFBMKLO))]
		public IEnumerator WaitForFlush(float JHHEDLPJBLL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62AB6F0", Offset = "0x62AA8F0", VA = "0x1862AB6F0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62AB640", Offset = "0x62AA840", VA = "0x1862AB640")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime BBGNJMKOHPL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62A8350", Offset = "0x62A7550", VA = "0x1862A8350")]
		public static GHKEHLKBACK Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62A7120", Offset = "0x62A6320", VA = "0x1862A7120")]
		public static DPKIGFPJMOG AccountSelectionPostLoginEvent([NotNull] string LLHIGMFHDNP, string CHGADKLOPIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62A7D60", Offset = "0x62A6F60", VA = "0x1862A7D60")]
		public static DPKIGFPJMOG Event([NotNull] string LLHIGMFHDNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62AACF0", Offset = "0x62A9EF0", VA = "0x1862AACF0")]
		public static DPKIGFPJMOG PreviousSessionEvent([NotNull] string LLHIGMFHDNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x62A84B0", Offset = "0x62A76B0", VA = "0x1862A84B0")]
		public static DPKIGFPJMOG InitializeEvent(string CHGADKLOPIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x62AB340", Offset = "0x62AA540", VA = "0x1862AB340")]
		public static DPKIGFPJMOG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62A7680", Offset = "0x62A6880", VA = "0x1862A7680")]
		public static DPKIGFPJMOG CreateOutOfSessionEvent(string LLHIGMFHDNP, bool FJHAFKAHMDP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62A9CE0", Offset = "0x62A8EE0", VA = "0x1862A9CE0")]
		public static LAHBDKNMNHN LogOutOfSessionEvent(DPKIGFPJMOG BMMJDKDKMDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62A9A20", Offset = "0x62A8C20", VA = "0x1862A9A20")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MPHFJDGDKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62A9FF0", Offset = "0x62A91F0", VA = "0x1862A9FF0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MPHFJDGDKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x62AA140", Offset = "0x62A9340", VA = "0x1862AA140")]
		public void LogSerializedEventAsync(Dictionary<string, object> ABEOBJGNNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62A9B70", Offset = "0x62A8D70", VA = "0x1862A9B70")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage NIJBKKNFPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x62AAA90", Offset = "0x62A9C90", VA = "0x1862AAA90")]
		private void OEDKBGCKHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62AA620", Offset = "0x62A9820", VA = "0x1862AA620")]
		private void MIOFHIGPLMH(Dictionary<string, object> FBFLLMKFMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62A8060", Offset = "0x62A7260", VA = "0x1862A8060")]
		private void GHLDCEKDCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62AA8B0", Offset = "0x62A9AB0", VA = "0x1862AA8B0")]
		private void NFPLCFBLEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62A7FD0", Offset = "0x62A71D0", VA = "0x1862A7FD0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x62A70A0", Offset = "0x62A62A0", VA = "0x1862A70A0")]
		[IteratorStateMachine(typeof(CGMLLLBFGKA))]
		private IEnumerator<EGGPGCCKPCO> AMEAMPDLJPN(float JHHEDLPJBLL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x62AAC10", Offset = "0x62A9E10", VA = "0x1862AAC10")]
		[IteratorStateMachine(typeof(JILPPLCABBF))]
		private IEnumerator<EGGPGCCKPCO> PPOCFIHNKPP(float JHHEDLPJBLL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x62A8150", Offset = "0x62A7350", VA = "0x1862A8150")]
		[IteratorStateMachine(typeof(OJPNFMGMDGJ))]
		private IEnumerator<EGGPGCCKPCO> GKFBAOCABDG(BNKPPHMCLDB MGGAFPGBPKK, int? HBDHFGDAFNB, string PEDLJMJDBPA, string NKJKDKJGLPD, float JHHEDLPJBLL, Action<int> FENCDGJBLLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62A8230", Offset = "0x62A7430", VA = "0x1862A8230")]
		private static void HDNIMKGBECD(bool GCDOOKMMLBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x62AA220", Offset = "0x62A9420", VA = "0x1862AA220")]
		private global::NCOKFFGPIJM<MAPBOPAPLPD<Dictionary<string, object>>> MAJANJBIDMF(string PEDLJMJDBPA, string NKJKDKJGLPD, string ILHCGHHPKIG, string KEEOPPDGKEJ, Dictionary<string, object> CCKLGMMKMEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62AA350", Offset = "0x62A9550", VA = "0x1862AA350")]
		private global::NCOKFFGPIJM<MAPBOPAPLPD<List<Dictionary<string, object>>>> MAJANJBIDMF(string PEDLJMJDBPA, string NKJKDKJGLPD, string ILHCGHHPKIG, string KEEOPPDGKEJ, List<Dictionary<string, object>> CCKLGMMKMEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x278C720", Offset = "0x278B920", VA = "0x18278C720")]
		private global::NCOKFFGPIJM<MAPBOPAPLPD<T>> DCICAFHFAFL<T>(string PEDLJMJDBPA, string NKJKDKJGLPD, string KEEOPPDGKEJ, T CCKLGMMKMEN, Dictionary<string, object> DINEPGGFCAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x278C9B0", Offset = "0x278BBB0", VA = "0x18278C9B0")]
		private global::NCOKFFGPIJM<MAPBOPAPLPD<T>> IAJBOFLGEEH<T>(string PEDLJMJDBPA, string NKJKDKJGLPD, string ILHCGHHPKIG, T CCKLGMMKMEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62A8960", Offset = "0x62A7B60", VA = "0x1862A8960")]
		private bool JFLKLJGODGO(float HDGFHFCPNPD, float JHHEDLPJBLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x62A89C0", Offset = "0x62A7BC0", VA = "0x1862A89C0")]
		private Dictionary<string, object> LEKOCJCJLGK(string NKJKDKJGLPD, Dictionary<string, object> CCKLGMMKMEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62ABC70", Offset = "0x62AAE70", VA = "0x1862ABC70")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62A7960", Offset = "0x62A6B60", VA = "0x1862A7960")]
		[CompilerGenerated]
		private long DJECPOGPNBM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62A89B0", Offset = "0x62A7BB0", VA = "0x1862A89B0")]
		[CompilerGenerated]
		private void KHCNPDAENMC(int GCFMIKACGJE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x62ACD30", Offset = "0x62ABF30", VA = "0x1862ACD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x62ACDF0", Offset = "0x62ABFF0", VA = "0x1862ACDF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x62ACD90", Offset = "0x62ABF90", VA = "0x1862ACD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x62ACE60", Offset = "0x62AC060", VA = "0x1862ACE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x7118C0", Offset = "0x710AC0", VA = "0x1807118C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x62AC860", Offset = "0x62ABA60", VA = "0x1862AC860")]
		public static DPKIGFPJMOG GPGHDDABLEF(string EOGFAFNNICF, [NotNull] string ENKMDOKIHHM, long GEJNOCNOOLP, long KBECGKMBECC, string CHGADKLOPIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x62AC950", Offset = "0x62ABB50", VA = "0x1862AC950")]
		public static DPKIGFPJMOG IGNKDPOFKJC(string EOGFAFNNICF, [NotNull] string ENKMDOKIHHM, long GEJNOCNOOLP, long KBECGKMBECC, string CHGADKLOPIE, long DACEGLHIODB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x62ACB70", Offset = "0x62ABD70", VA = "0x1862ACB70")]
		private AmplitudeAnalyticsEvent(string EOGFAFNNICF, [NotNull] string ENKMDOKIHHM, long GEJNOCNOOLP, long KBECGKMBECC, string CHGADKLOPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x17679E0", Offset = "0x1766BE0", VA = "0x1817679E0")]
		public void KDHJIBFHEDP(long FLEOPNIECJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x62ACA50", Offset = "0x62ABC50", VA = "0x1862ACA50", Slot = "5")]
		public override void NDKDJCMIKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x62AC6B0", Offset = "0x62AB8B0", VA = "0x1862AC6B0", Slot = "6")]
		public override void CGLNEOMGMKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x62AC130", Offset = "0x62AB330", VA = "0x1862AC130", Slot = "4")]
		protected override Dictionary<string, object> BENDLDKOPBA(Dictionary<string, object> DKLFPEDBIID)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x62B02E0", Offset = "0x62AF4E0", VA = "0x1862B02E0")]
			public void DLDGFHGMKNO(Dictionary<string, object> IBAONPKBGMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x62B54C0", Offset = "0x62B46C0", VA = "0x1862B54C0")]
			public void DLDGFHGMKNO(Dictionary<string, object> LPDBEMHKHIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xA65890", Offset = "0xA64A90", VA = "0x180A65890")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x62AD310", Offset = "0x62AC510", VA = "0x1862AD310")]
		public static GHKEHLKBACK GPGHDDABLEF(string EOGFAFNNICF, string CHGADKLOPIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x62AD550", Offset = "0x62AC750", VA = "0x1862AD550")]
		protected AmplitudeAnalyticsIdentifyMessage(string EOGFAFNNICF, string CHGADKLOPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x62AD290", Offset = "0x62AC490", VA = "0x1862AD290")]
		public Dictionary<string, object> FPJHNDPIGDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62ACED0", Offset = "0x62AC0D0", VA = "0x1862ACED0", Slot = "4")]
		protected virtual Dictionary<string, object> BENDLDKOPBA(Dictionary<string, object> DKLFPEDBIID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62AD3C0", Offset = "0x62AC5C0", VA = "0x1862AD3C0")]
		protected void KLLPHNMOELE(string FDAIMOMOHIG, Dictionary<string, object> DLIAGAOBAGM, Dictionary<string, object> EPMEFICMAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62AD4E0", Offset = "0x62AC6E0", VA = "0x1862AD4E0")]
		protected void NGFEFNMHEMD(string FDAIMOMOHIG, string IPMIIEAGJKC, Dictionary<string, object> GFJINOOPPOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x62AD460", Offset = "0x62AC660", VA = "0x1862AD460", Slot = "5")]
		public virtual void NDKDJCMIKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62AD210", Offset = "0x62AC410", VA = "0x1862AD210", Slot = "6")]
		public virtual void CGLNEOMGMKL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GHKEHLKBACK : global::IMNFJENIKGG<AmplitudeAnalyticsIdentifyMessage, GHKEHLKBACK>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override GHKEHLKBACK FPLKFAILDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MDIFLHFJODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x62B23A0", Offset = "0x62B15A0", VA = "0x1862B23A0")]
	public GHKEHLKBACK(AmplitudeAnalyticsIdentifyMessage OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x62B2300", Offset = "0x62B1500", VA = "0x1862B2300", Slot = "4")]
	public override void CGLNEOMGMKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DPKIGFPJMOG : global::IMNFJENIKGG<AmplitudeAnalyticsEvent, DPKIGFPJMOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool GJECENDAJGL;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override DPKIGFPJMOG FPLKFAILDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public long IJGILLEOIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2CC7460", Offset = "0x2CC6660", VA = "0x182CC7460")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62B0290", Offset = "0x62AF490", VA = "0x1862B0290")]
	public DPKIGFPJMOG(AmplitudeAnalyticsEvent OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "5")]
	public override AmplitudeAnalyticsEvent MDIFLHFJODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62AFC20", Offset = "0x62AEE20", VA = "0x1862AFC20", Slot = "4")]
	public override void CGLNEOMGMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x62AFF90", Offset = "0x62AF190", VA = "0x1862AFF90")]
	public DPKIGFPJMOG ENEFMCGBLHP(string IDBLFHOOMPH, long[] IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x62AFE50", Offset = "0x62AF050", VA = "0x1862AFE50")]
	public DPKIGFPJMOG ENEFMCGBLHP(string IDBLFHOOMPH, ulong[] IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x1D181A0", Offset = "0x1D173A0", VA = "0x181D181A0")]
	public DPKIGFPJMOG ENEFMCGBLHP<T>(string IDBLFHOOMPH, T[] IPMIIEAGJKC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x62B00D0", Offset = "0x62AF2D0", VA = "0x1862B00D0")]
	public DPKIGFPJMOG ENEFMCGBLHP(string IDBLFHOOMPH, string[] IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1D18130", Offset = "0x1D17330", VA = "0x181D18130")]
	public DPKIGFPJMOG ENEFMCGBLHP<T>(string IDBLFHOOMPH, T IPMIIEAGJKC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x62AFD30", Offset = "0x62AEF30", VA = "0x1862AFD30")]
	public DPKIGFPJMOG ENEFMCGBLHP(string IDBLFHOOMPH, long IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62AFDC0", Offset = "0x62AEFC0", VA = "0x1862AFDC0")]
	public DPKIGFPJMOG ENEFMCGBLHP(string IDBLFHOOMPH, ulong IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x62AFCC0", Offset = "0x62AEEC0", VA = "0x1862AFCC0")]
	public DPKIGFPJMOG ENEFMCGBLHP(string IDBLFHOOMPH, string IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x62B00E0", Offset = "0x62AF2E0", VA = "0x1862B00E0")]
	public DPKIGFPJMOG GFMLLJANGOC(string IDBLFHOOMPH, object? IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x62B01F0", Offset = "0x62AF3F0", VA = "0x1862B01F0")]
	public DPKIGFPJMOG MFNADJDLMBE(string IDBLFHOOMPH, string IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x62B0100", Offset = "0x62AF300", VA = "0x1862B0100")]
	private DPKIGFPJMOG LMHLNHAPPFI(string IDBLFHOOMPH, object IPMIIEAGJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PPILICBPGFO : DPKIGFPJMOG
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x62B0290", Offset = "0x62AF490", VA = "0x1862B0290")]
	public PPILICBPGFO(AmplitudeAnalyticsEvent OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x62B5300", Offset = "0x62B4500", VA = "0x1862B5300", Slot = "4")]
	public override void CGLNEOMGMKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class IMNFJENIKGG<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::IMNFJENIKGG<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected M OFCFPGACNJB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public abstract BLDR FPLKFAILDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1B3B7F0", Offset = "0x1B3A9F0", VA = "0x181B3B7F0")]
	public IMNFJENIKGG(M OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F800", Offset = "0x1B3EA00", VA = "0x181B3F800")]
	public BLDR KAHHPFMCDAO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo DADNOKJFJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F4D0", Offset = "0x1B3E6D0", VA = "0x181B3F4D0")]
	public BLDR ALCEBBJCFKF(AmplitudeAnalyticsIdentifyMessage.RevenueData LIKIOIFADOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F510", Offset = "0x1B3E710", VA = "0x181B3F510")]
	public BLDR BJLDMPNEGEL(string IDBLFHOOMPH, string IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x147B070", Offset = "0x147A270", VA = "0x18147B070")]
	public BLDR BJLDMPNEGEL<T>(string IDBLFHOOMPH, T IPMIIEAGJKC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F630", Offset = "0x1B3E830", VA = "0x181B3F630")]
	public BLDR BJLDMPNEGEL(string IDBLFHOOMPH, long IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F580", Offset = "0x1B3E780", VA = "0x181B3F580")]
	public BLDR BJLDMPNEGEL(string IDBLFHOOMPH, ulong IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CGLNEOMGMKL();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F7D0", Offset = "0x1B3E9D0", VA = "0x181B3F7D0")]
	internal static string JEBMEHKKGFI(string IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F6E0", Offset = "0x1B3E8E0", VA = "0x181B3F6E0")]
	private BLDR FKMJBLAIJHG(string IDBLFHOOMPH, object IPMIIEAGJKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M MDIFLHFJODN();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NOHKDMDHOFE
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string GJBOBKGPCBH = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string JBNADLKFCMB = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string LJDGDBMAHNA = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string CFJFDKJGFPJ = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string OJDMMLDBLNO = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string BNPBDJGMDAI = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string PKOFGMPOIDF = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string OICGHCLAFFH = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string GHCGHAEPOCH = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string MFPNEFECFEM = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string BMLKILHGBHF = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string JFOIGBEJGIB = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string DGKMEKLFLMF = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string PFBJLHIECGJ = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string DPFHIMEOGKK = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string AEPJOAMGLMD = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string EOKDMACMAJJ = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string LJIEIPNEJCE = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string OEKEHNIAJJG = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string BKOGPPLHNBL = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string IGJPPFKPPDM = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string LGAFKFIFDAF = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string JONJALHHMIJ = "type";

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NOHKDMDHOFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class CKMNBDBCPAI
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int AINOJPFPHFC = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int KHEANLINHJO = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int DGDJNOEBNDC = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long GHKABJBCNMH = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int MOEKKFDFPIJ = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int DAGGKMKDFLF = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string KPBHOJKFCMP = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string KNOAPNLIPMG = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string DBHOIKNIOMP = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string LAMOJCMGAEA = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string BAPLLIDAGDO = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string NMDHNEHIPAH = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string GOBLNLJFAAF = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string PNCBNMFOPEB = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string HGAHMEHMGMA = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string EDHFNLMMDEL = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string COKBKOJKOAB = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string BAHINLABPAE = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string FKBLNMIHMID = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string CHEJNOLBJII = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string PKOFGMPOIDF = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string HCEHBGAJGOI = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string IBPDOKDNDMB = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string PAGGMDEFAGP = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string JDCPKOACPGN = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string ICKECEEHJAD = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string IJIEGFJGJFD = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string GMKPLJPHGGG = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string PEGJMBAHLHE = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string EEGJHNNDBGI = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string AFGHHCJLJFL = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string KJPJHKJDFOL = "productId";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string BOIGKAIHLAN = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string DMAJKNGGHJK = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string OJDMMLDBLNO = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const string PFDDKEKBIJB = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public const int JALOONEIGEJ = 10;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BJBCAAPJGKB;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x62AF440", Offset = "0x62AE640", VA = "0x1862AF440")]
	internal static bool AHFOEJLECEK(string FDAIMOMOHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public CKMNBDBCPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FOMPBHDLPDO
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool HCHKEEBPABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string NGLDJJJJIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string BMFDMHEOELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string BEGOCFBEGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string AMANMPHPNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::NCOKFFGPIJM<OINMKBPJOIN> MAJANJBIDMF(string PEDLJMJDBPA, Dictionary<string, string> KCMHHMICLDK, bool BCBEOCNFNGM = false);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::NCOKFFGPIJM<OINMKBPJOIN> KBECOPLKGHL(string PEDLJMJDBPA, string DPDHNAGGMCO, string AFGGJHIEOKG, string AMDCGEHGPNI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct OINMKBPJOIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly int LCPDPINGGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly string DGKGPKAOIBO;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x9DFCD0", Offset = "0x9DEED0", VA = "0x1809DFCD0")]
	public OINMKBPJOIN(int PDFNEIPHEDI, string DPFNLINFEDF)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x62B4180", Offset = "0x62B3380", VA = "0x1862B4180")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x62B4290", Offset = "0x62B3490", VA = "0x1862B4290")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
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

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
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
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
		[Cpp2IlInjected.Address(RVA = "0x613A400", Offset = "0x6139200", VA = "0x18613A400")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x922590", Offset = "0x921390", VA = "0x180922590")]
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
		[Cpp2IlInjected.Address(RVA = "0x11E9610", Offset = "0x11E8410", VA = "0x1811E9610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KLBFLOGDIEP
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
public class AGGHCCAKOAK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string CBFEOPNPIAH = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string IJLKIELLALK = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string JALFDNACFAM = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string JLILDMPHECP = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string NNDJHKKFAON = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string LIALLGHFKJM = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string NADHFIIDHOG = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long ELJJNJBHCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GFEFPFAIPCE BAOAFLAJAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool IKCBJAJKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float HGIAIJKONGD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x612E8A0", Offset = "0x612D6A0", VA = "0x18612E8A0")]
	public AGGHCCAKOAK(string NACMAFGGJMO, float HGIAIJKONGD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35FA8D0", Offset = "0x35F96D0", VA = "0x1835FA8D0")]
	public void GKEIPLCGNIC<T>(string FJONJLMIBBO, T DFEOJBAFBHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x612E500", Offset = "0x612D300", VA = "0x18612E500")]
	public void GKEIPLCGNIC(string FJONJLMIBBO, string DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x612E5D0", Offset = "0x612D3D0", VA = "0x18612E5D0")]
	public void JENLADGHEHI(string FCKAFNCLABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x612E6C0", Offset = "0x612D4C0", VA = "0x18612E6C0")]
	public void LHCBGADJLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x612E780", Offset = "0x612D580", VA = "0x18612E780")]
	private void LPCFMDCNPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x612E580", Offset = "0x612D380", VA = "0x18612E580")]
	private bool GKPDKBHLKKE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NDHKGDHBFMG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCBLCAIHLNA NAGCBALDEME(string CADNBNKFGAH, string DDLPBCKEOMK, [Optional] OFGPLEHKDFA MHLFMEJNMPJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCBLCAIHLNA GKCJCHCEHCM(OFGPLEHKDFA MHLFMEJNMPJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCBLCAIHLNA BCCCPMOLPHH(OFGPLEHKDFA MHLFMEJNMPJ, Dictionary<string, string> LPCBDKINPFD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INGBICEAFIG(string GDDAMFLEFDA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGNDKCNJNMD JDJNEDJJBDL(string BPHMCHJEOJN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EFBOIHOLCDF BDAOAGOEGLI(string NPBHOJNMALC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AGNDKCNJNMD FOIMEBLHNON(string MLCBCPCCCLJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CCBLCAIHLNA EBPLHGJNAPL();
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

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x613BDB0", Offset = "0x613ABB0", VA = "0x18613BDB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NFEIIJPDAJK : NDHKGDHBFMG
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string ANBDNGDMAEH = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string LDIPBHNKMLF = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string HLODDLINNEM = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string NPOHAPIOINI = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string CKCMFEFFKLC = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string CEJKIAOAOBE = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string BOGMHHGMCHH = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string KBCDFIEOIGD = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string JBALOHOHKLF = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string BHIFNEOOHIG = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string FDMPOJCIOBH = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, GBNJNMFDNJJ> HECPIOBGNFM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int KHAEGAGJCKL = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool AMPKEBPCAGM;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6139BE0", Offset = "0x61389E0", VA = "0x186139BE0", Slot = "4")]
	public CCBLCAIHLNA NAGCBALDEME(string CADNBNKFGAH, string DDLPBCKEOMK, [Optional] OFGPLEHKDFA MHLFMEJNMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6138E50", Offset = "0x6137C50", VA = "0x186138E50", Slot = "11")]
	public CCBLCAIHLNA EBPLHGJNAPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61390D0", Offset = "0x6137ED0", VA = "0x1861390D0", Slot = "5")]
	public CCBLCAIHLNA GKCJCHCEHCM(OFGPLEHKDFA MHLFMEJNMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6138AA0", Offset = "0x61378A0", VA = "0x186138AA0", Slot = "6")]
	public CCBLCAIHLNA BCCCPMOLPHH(OFGPLEHKDFA MHLFMEJNMPJ, Dictionary<string, string> LPCBDKINPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6139280", Offset = "0x6138080", VA = "0x186139280", Slot = "7")]
	public bool INGBICEAFIG(string GDDAMFLEFDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6139330", Offset = "0x6138130", VA = "0x186139330", Slot = "8")]
	public AGNDKCNJNMD JDJNEDJJBDL(string BPHMCHJEOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6138D90", Offset = "0x6137B90", VA = "0x186138D90", Slot = "9")]
	public EFBOIHOLCDF BDAOAGOEGLI(string NPBHOJNMALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6138FE0", Offset = "0x6137DE0", VA = "0x186138FE0", Slot = "10")]
	public AGNDKCNJNMD FOIMEBLHNON(string MLCBCPCCCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6139450", Offset = "0x6138250", VA = "0x186139450")]
	private MLLNKFKIMLM KLEMPLJBBOI(OFGPLEHKDFA MHLFMEJNMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6139A40", Offset = "0x6138840", VA = "0x186139A40")]
	private MBIHKJJAJAN LHAHDAFKPPM(string DDLPBCKEOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x613A080", Offset = "0x6138E80", VA = "0x18613A080")]
	private void OGJODMJFCOC(string BPHMCHJEOJN, AGNDKCNJNMD PJKPAHNPCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public NFEIIJPDAJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA66480", Offset = "0xA65280", VA = "0x180A66480")]
	[CompilerGenerated]
	private void OLCMMKBKDHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NAJCPOMMHGL : NDHKGDHBFMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private NDHKGDHBFMG AKNBMOEEBPL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private NDHKGDHBFMG MHHPNCOAAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6138930", Offset = "0x6137730", VA = "0x186138930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	[Preserve]
	public NAJCPOMMHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61389A0", Offset = "0x61377A0", VA = "0x1861389A0")]
	[EJICMPGFCBP(CIKEJIGJNLD.GameOnly)]
	private static void OKHPGGOCLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6138710", Offset = "0x6137510", VA = "0x186138710", Slot = "4")]
	public CCBLCAIHLNA NAGCBALDEME(string CADNBNKFGAH, string DDLPBCKEOMK, [Optional] OFGPLEHKDFA MHLFMEJNMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61384D0", Offset = "0x61372D0", VA = "0x1861384D0", Slot = "5")]
	public CCBLCAIHLNA GKCJCHCEHCM(OFGPLEHKDFA MHLFMEJNMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6138120", Offset = "0x6136F20", VA = "0x186138120", Slot = "6")]
	public CCBLCAIHLNA BCCCPMOLPHH(OFGPLEHKDFA MHLFMEJNMPJ, Dictionary<string, string> LPCBDKINPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61385D0", Offset = "0x61373D0", VA = "0x1861385D0", Slot = "7")]
	public bool INGBICEAFIG(string GDDAMFLEFDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6138670", Offset = "0x6137470", VA = "0x186138670", Slot = "8")]
	public AGNDKCNJNMD JDJNEDJJBDL(string BPHMCHJEOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6138230", Offset = "0x6137030", VA = "0x186138230", Slot = "9")]
	public EFBOIHOLCDF BDAOAGOEGLI(string NPBHOJNMALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6138430", Offset = "0x6137230", VA = "0x186138430", Slot = "10")]
	public AGNDKCNJNMD FOIMEBLHNON(string MLCBCPCCCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6138330", Offset = "0x6137130", VA = "0x186138330", Slot = "11")]
	public CCBLCAIHLNA EBPLHGJNAPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DEBACLLKBHO : NDHKGDHBFMG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61359A0", Offset = "0x61347A0", VA = "0x1861359A0", Slot = "4")]
	public CCBLCAIHLNA NAGCBALDEME(string CADNBNKFGAH, string DDLPBCKEOMK, [Optional] OFGPLEHKDFA MHLFMEJNMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6135900", Offset = "0x6134700", VA = "0x186135900", Slot = "5")]
	public CCBLCAIHLNA GKCJCHCEHCM(OFGPLEHKDFA MHLFMEJNMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61357A0", Offset = "0x61345A0", VA = "0x1861357A0", Slot = "6")]
	public CCBLCAIHLNA BCCCPMOLPHH(OFGPLEHKDFA MHLFMEJNMPJ, Dictionary<string, string> LPCBDKINPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "7")]
	public bool INGBICEAFIG(string GDDAMFLEFDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61358F0", Offset = "0x61346F0", VA = "0x1861358F0", Slot = "8")]
	public AGNDKCNJNMD JDJNEDJJBDL(string BPHMCHJEOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6135840", Offset = "0x6134640", VA = "0x186135840", Slot = "9")]
	public EFBOIHOLCDF BDAOAGOEGLI(string NPBHOJNMALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61358F0", Offset = "0x61346F0", VA = "0x1861358F0", Slot = "10")]
	public AGNDKCNJNMD FOIMEBLHNON(string MLCBCPCCCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6135850", Offset = "0x6134650", VA = "0x186135850", Slot = "11")]
	public CCBLCAIHLNA EBPLHGJNAPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public DEBACLLKBHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HGFHBKKDHIK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IsExperimentSegmentActive(string BPHMCHJEOJN, string JNBHCHJAJNB, bool NINMOABKHFN = true);
}
namespace RecRoom.Analytics.SplitTesting
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedSplitTestExperiment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public SerializedSplitTestExperiment()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedSplitTestExperimentSegment
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private string experimentSegment;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ExperimentSegment
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x613BD60", Offset = "0x613AB60", VA = "0x18613BD60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public SerializedSplitTestExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OAKBJDDECPI
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AGGHCCAKOAK ACEOEEMMIKO(string NACMAFGGJMO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KHPGLGLFLBN
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFFMJNEDPGK(string KPJEGNGKPOH, string GIMFKMDEAMO, string HMHELECNDDN);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AOOKGJABGDO(string KPJEGNGKPOH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPBDNDLNCKM(string KPJEGNGKPOH, string OEEJKCLOCBA, string IFDPOINNCBM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OFGPLEHKDFA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PCLDFHHADOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JJCGIMDNLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MHOKENMIBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GJAJPJIOGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool? FANBNDABKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int? APFOALOAPIB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int LHBKDMGKLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string LABJGNKPMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string PHFCACLGDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string PNLIJJOPEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string MNHEKIPCCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string LHODMDCGALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OGGJNDNFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	double NFODDFBLKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AmplitudeAnalyticsClient.Settings BHCLFAMJGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool KJEENELALPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x733990", Offset = "0x732790", VA = "0x180733990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum FAOMJOJPHAM
		{
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum CJMLAILOKKF
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class PIDKJEMGNNM
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			private class HNILKGINICL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int MKDMGLFAACB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public Dictionary<string, object> PPFJJLKMKDP;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
				public HNILKGINICL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000019")]
			[CompilerGenerated]
			private sealed class GDLCPDBKHNK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
				public GDLCPDBKHNK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x6135D70", Offset = "0x6134B70", VA = "0x186135D70")]
				internal bool <GetBatch>b__0(HNILKGINICL item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private const string AIOOLLGKEPI = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private readonly string JLGENJBOGCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private List<HNILKGINICL> KEBHLDCPDFP;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public int? HPOBJBKGNIB
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x613B480", Offset = "0x613A280", VA = "0x18613B480")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? OIONPKPNNOB
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x613A8E0", Offset = "0x61396E0", VA = "0x18613A8E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x613BA60", Offset = "0x613A860", VA = "0x18613BA60")]
			internal PIDKJEMGNNM(string HPKCCIAIFDF, string DDLPBCKEOMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x613A5C0", Offset = "0x61393C0", VA = "0x18613A5C0")]
			public int ACFAFIFHBMK([Optional] int? FJHGDJMGJEB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x613A9A0", Offset = "0x61397A0", VA = "0x18613A9A0")]
			public List<Dictionary<string, object>> HHAJKDLDKML(int JAKDBIDBDML, int? FJHGDJMGJEB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x613B630", Offset = "0x613A430", VA = "0x18613B630")]
			public void NPJBCEHNCBG(AmplitudeAnalyticsIdentifyMessage GKCPJCKCENH, bool PBAFNFJOEHG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x613B520", Offset = "0x613A320", VA = "0x18613B520")]
			public void NPJBCEHNCBG(Dictionary<string, object> GKCPJCKCENH, bool PBAFNFJOEHG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x613A750", Offset = "0x6139550", VA = "0x18613A750")]
			public void EHDCBAKECOM(params Dictionary<string, object>[] BMHBHCHEAHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x613B6D0", Offset = "0x613A4D0", VA = "0x18613B6D0")]
			public void OECMHIFOBDJ(List<Dictionary<string, object>> CGLPPPNCBJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x613B920", Offset = "0x613A720", VA = "0x18613B920")]
			private void PKACIEICBFA(Dictionary<string, object> GKCPJCKCENH, bool PBAFNFJOEHG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x613B210", Offset = "0x613A010", VA = "0x18613B210")]
			public void MBEHOFPGALK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x613AC30", Offset = "0x6139A30", VA = "0x18613AC30")]
			private void JELKANDMEIA([Optional] string HKKKPKNHAPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x613B0E0", Offset = "0x6139EE0", VA = "0x18613B0E0")]
			private static string LGJCHGHCHGH(string DFEOJBAFBHE, string PIIJMEAKDGO)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x613C000", Offset = "0x613AE00", VA = "0x18613C000")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct IGDDBCBCDBJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int IJKGIBNKDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string NAFIFJNCIJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public T MCIMLJAKGDJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KNPLDHNFKKL : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private ELOHAHHPMGF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
			[DebuggerHidden]
			public KNPLDHNFKKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6137AF0", Offset = "0x61368F0", VA = "0x186137AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x61380E0", Offset = "0x6136EE0", VA = "0x1861380E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class OJGILFBEDPB : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public HGIFEALIPIB quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
			[DebuggerHidden]
			public OJGILFBEDPB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x613A490", Offset = "0x6139290", VA = "0x18613A490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x613A580", Offset = "0x6139380", VA = "0x18613A580", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class GCENBJLKNEC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000BF")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
			[DebuggerHidden]
			public GCENBJLKNEC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6135BC0", Offset = "0x61349C0", VA = "0x186135BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6135D30", Offset = "0x6134B30", VA = "0x186135D30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class GHNGGOPMLDN : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private ELOHAHHPMGF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
			[DebuggerHidden]
			public GHNGGOPMLDN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x61364B0", Offset = "0x61352B0", VA = "0x1861364B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6136750", Offset = "0x6135550", VA = "0x186136750", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class BLEFNGHMFFF : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private ELOHAHHPMGF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
			[DebuggerHidden]
			public BLEFNGHMFFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6135010", Offset = "0x6133E10", VA = "0x186135010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x61352B0", Offset = "0x61340B0", VA = "0x1861352B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class CELFLNMHDOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public PIDKJEMGNNM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public CELFLNMHDOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x61352F0", Offset = "0x61340F0", VA = "0x1861352F0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6135390", Offset = "0x6134190", VA = "0x186135390")]
			internal void <FlushFromCache>b__1(IGDDBCBCDBJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class JCNKHBCBEAB : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private ELOHAHHPMGF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public PIDKJEMGNNM cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private CELFLNMHDOE <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D7")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
			[DebuggerHidden]
			public JCNKHBCBEAB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6136880", Offset = "0x6135680", VA = "0x186136880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6137110", Offset = "0x6135F10", VA = "0x186137110", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class EFPFECIBGJK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
			public EFPFECIBGJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3D830C0", Offset = "0x3D81EC0", VA = "0x183D830C0")]
			internal IGDDBCBCDBJ<T> <PostRudderStackJson>b__0(EHLICNPDIBO postResponse)
			{
				return default(IGDDBCBCDBJ<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class KHELGDFEPEF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
			public KHELGDFEPEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3D830C0", Offset = "0x3D81EC0", VA = "0x183D830C0")]
			internal IGDDBCBCDBJ<T> <PostAmplitudeJson>b__0(EHLICNPDIBO postResponse)
			{
				return default(IGDDBCBCDBJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private DCGCDOAFKJE CLOPLNDNKCF;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string MNDKHOGLJLO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string KCAGANMCDNF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string JIGDCDKMKID = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const int PKEEIENLKAK = 10;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const int PEFAFLJDAEF = 10;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const int NKNAKCDIENB = 5;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float OIEPMKLNBEM = 10f;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const long FMMCKIDNOKK = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string DGKHDLNHAKO = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const string IDHECOHFCIL = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static bool AOKCECNJBKN;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static bool CNMANDDBDMH;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static int FKMNMAGANDC;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static int HAEEMGDHPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FAGILGJPKBK PJDFMLLPKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool GPNNJPLDLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float HCGJBDCCPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float FAJACONLLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int KIDCCHLHPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int HAOMFCCJOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int? JILMNIFBOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int? GNADGGFOGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private long EOMBPHCKEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private string JADHPIGDNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long MMAMMJECGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Dictionary<string, object> AGOAFNKKLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private CJMLAILOKKF NJDIEPKEMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int PIBHFNLFNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int GBBEJJABNDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private float FKONPNCEMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool BFCECJFCMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool FKBCHEFBGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private PIDKJEMGNNM EDMEEMCBGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private PIDKJEMGNNM HOLPJBHKFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private PIDKJEMGNNM IGCKLKKBJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> PIOJEJPGJCL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DNDPANLOHKK;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static string LMIGNHIODAP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const string KCKABBBEILJ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly string FCFEIDJNFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string OHILHJBCAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string NNCIAMHGJJP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private DCGCDOAFKJE FAFJMLBLNJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x61326B0", Offset = "0x61314B0", VA = "0x1861326B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static int JONDBPHHPBH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6130700", Offset = "0x612F500", VA = "0x186130700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static long PBNMPPMNIJF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6133B40", Offset = "0x6132940", VA = "0x186133B40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6133C40", Offset = "0x6132A40", VA = "0x186133C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string CGOLBNLKFAH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6133AE0", Offset = "0x61328E0", VA = "0x186133AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string JIJNDBGOGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6133B10", Offset = "0x6132910", VA = "0x186133B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string AJHFGFKCPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x844790", Offset = "0x843590", VA = "0x180844790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8C3270", Offset = "0x8C2070", VA = "0x1808C3270")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int? APFOALOAPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x844780", Offset = "0x843580", VA = "0x180844780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8C5BF0", Offset = "0x8C49F0", VA = "0x1808C5BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public FAOMJOJPHAM? NIIEKBKAOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83D830", Offset = "0x83C630", VA = "0x18083D830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x878350", Offset = "0x877150", VA = "0x180878350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool JCFDFDAONFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x157FFB0", Offset = "0x157EDB0", VA = "0x18157FFB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1581380", Offset = "0x1580180", VA = "0x181581380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool GBGCNICFANM
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x61339F0", Offset = "0x61327F0", VA = "0x1861339F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> FGNGMLKEMOO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6133950", Offset = "0x6132750", VA = "0x186133950")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6133BA0", Offset = "0x61329A0", VA = "0x186133BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x612EBE0", Offset = "0x612D9E0", VA = "0x18612EBE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x61308D0", Offset = "0x612F6D0", VA = "0x1861308D0")]
		private void GHJALFJGIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x61331A0", Offset = "0x6131FA0", VA = "0x1861331A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6132610", Offset = "0x6131410", VA = "0x186132610", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6133490", Offset = "0x6132290", VA = "0x186133490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6132800", Offset = "0x6131600", VA = "0x186132800")]
		public CCBLCAIHLNA PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6131310", Offset = "0x6130110", VA = "0x186131310")]
		[IteratorStateMachine(typeof(KNPLDHNFKKL))]
		public IEnumerator<ELOHAHHPMGF> Initialize(AmplitudeAnalyticsEvent DDNLCJDKJDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6133380", Offset = "0x6132180", VA = "0x186133380")]
		public void UpdateLastAliveTime(float JOOCLGDKHDP = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6131E30", Offset = "0x6130C30", VA = "0x186131E30")]
		private CCBLCAIHLNA MPGCHHHBEGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6131F00", Offset = "0x6130D00", VA = "0x186131F00")]
		private CCBLCAIHLNA NFDJDNCKJKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6132D50", Offset = "0x6131B50", VA = "0x186132D50")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6131430", Offset = "0x6130230", VA = "0x186131430")]
		[IteratorStateMachine(typeof(OJGILFBEDPB))]
		private IEnumerator LGLIHNFPGHK(HGIFEALIPIB MLKAECKFMJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6133700", Offset = "0x6132500", VA = "0x186133700")]
		[IteratorStateMachine(typeof(GCENBJLKNEC))]
		public IEnumerator WaitForFlush(float NNEBMFOPCOF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6133260", Offset = "0x6132060", VA = "0x186133260")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x61331B0", Offset = "0x6131FB0", VA = "0x1861331B0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime MHEAKFKNGKB)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6130F60", Offset = "0x612FD60", VA = "0x186130F60")]
		public static ILILMAAEGNL Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x612EA40", Offset = "0x612D840", VA = "0x18612EA40")]
		public static GFEFPFAIPCE AccountSelectionPostLoginEvent([NotNull] string MNCNEGOPCNP, string CLCNBMFDDJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x612FF20", Offset = "0x612ED20", VA = "0x18612FF20")]
		public static GFEFPFAIPCE Event([NotNull] string MNCNEGOPCNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6132860", Offset = "0x6131660", VA = "0x186132860")]
		public static GFEFPFAIPCE PreviousSessionEvent([NotNull] string MNCNEGOPCNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61310C0", Offset = "0x612FEC0", VA = "0x1861310C0")]
		public static GFEFPFAIPCE InitializeEvent(string CLCNBMFDDJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6132EB0", Offset = "0x6131CB0", VA = "0x186132EB0")]
		public static GFEFPFAIPCE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x612FC50", Offset = "0x612EA50", VA = "0x18612FC50")]
		public static GFEFPFAIPCE CreateOutOfSessionEvent(string MNCNEGOPCNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6131780", Offset = "0x6130580", VA = "0x186131780")]
		public static CCBLCAIHLNA LogOutOfSessionEvent(GFEFPFAIPCE JGHBBPNMAAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61314C0", Offset = "0x61302C0", VA = "0x1861314C0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LIHPGNJGBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6131B20", Offset = "0x6130920", VA = "0x186131B20")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LIHPGNJGBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6131C70", Offset = "0x6130A70", VA = "0x186131C70")]
		public void LogSerializedEventAsync(Dictionary<string, object> LLAEMBCMFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6131610", Offset = "0x6130410", VA = "0x186131610")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage KHDGELODPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6132720", Offset = "0x6131520", VA = "0x186132720")]
		private void PNCPCDLBJKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6132380", Offset = "0x6131180", VA = "0x186132380")]
		private void OJNIFHIPJPJ(Dictionary<string, object> COEFDEGAPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6130D10", Offset = "0x612FB10", VA = "0x186130D10")]
		private void HKMIANPKGJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61321A0", Offset = "0x6130FA0", VA = "0x1861321A0")]
		private void NFFABHGPGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6130670", Offset = "0x612F470", VA = "0x186130670")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x612EED0", Offset = "0x612DCD0", VA = "0x18612EED0")]
		[IteratorStateMachine(typeof(GHNGGOPMLDN))]
		private IEnumerator<ELOHAHHPMGF> BAEIJOLOIAD(float NNEBMFOPCOF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61313B0", Offset = "0x61301B0", VA = "0x1861313B0")]
		[IteratorStateMachine(typeof(BLEFNGHMFFF))]
		private IEnumerator<ELOHAHHPMGF> KFBMJAJFJCI(float NNEBMFOPCOF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6131D50", Offset = "0x6130B50", VA = "0x186131D50")]
		[IteratorStateMachine(typeof(JCNKHBCBEAB))]
		private IEnumerator<ELOHAHHPMGF> MCENHOJMKGD(PIDKJEMGNNM KEJPIFGMADN, int? FJHGDJMGJEB, string AFMOAIJAGDB, string GIEHFBOGKHE, float NNEBMFOPCOF, Action<int> HGKPJJFIABK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6130BF0", Offset = "0x612F9F0", VA = "0x186130BF0")]
		private static void GKEEAHCODOK(bool EJMLPHOLGAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x61304C0", Offset = "0x612F2C0", VA = "0x1861304C0")]
		private global::MMBCCHGMCHN<IGDDBCBCDBJ<Dictionary<string, object>>> FJCPGDPJOBE(string AFMOAIJAGDB, string GIEHFBOGKHE, string PAMDBCMLGBG, string AJGEOLHCPNB, Dictionary<string, object> MCIMLJAKGDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6130170", Offset = "0x612EF70", VA = "0x186130170")]
		private global::MMBCCHGMCHN<IGDDBCBCDBJ<List<Dictionary<string, object>>>> FJCPGDPJOBE(string AFMOAIJAGDB, string GIEHFBOGKHE, string PAMDBCMLGBG, string AJGEOLHCPNB, List<Dictionary<string, object>> MCIMLJAKGDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x36098E0", Offset = "0x36086E0", VA = "0x1836098E0")]
		private global::MMBCCHGMCHN<IGDDBCBCDBJ<T>> CKBLPBDGBIH<T>(string AFMOAIJAGDB, string GIEHFBOGKHE, string AJGEOLHCPNB, T MCIMLJAKGDJ, Dictionary<string, object> MJMCKJOFLBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3609B70", Offset = "0x3608970", VA = "0x183609B70")]
		private global::MMBCCHGMCHN<IGDDBCBCDBJ<T>> IHKKDOGDIPL<T>(string AFMOAIJAGDB, string GIEHFBOGKHE, string PAMDBCMLGBG, T MCIMLJAKGDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6130120", Offset = "0x612EF20", VA = "0x186130120")]
		private bool FECFIMJDLIG(float EGGDGKGFLFK, float NNEBMFOPCOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x612EF50", Offset = "0x612DD50", VA = "0x18612EF50")]
		private Dictionary<string, object> BEIAIDIMHEH(string GIEHFBOGKHE, Dictionary<string, object> MCIMLJAKGDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x61337E0", Offset = "0x61325E0", VA = "0x1861337E0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6130E00", Offset = "0x612FC00", VA = "0x186130E00")]
		[CompilerGenerated]
		private long HKODIMLPLFC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x61313A0", Offset = "0x61301A0", VA = "0x1861313A0")]
		[CompilerGenerated]
		private void KDPJACLCKHI(int LOOPALMBACO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
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

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6134800", Offset = "0x6133600", VA = "0x186134800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6134860", Offset = "0x6133660", VA = "0x186134860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x77D700", Offset = "0x77C500", VA = "0x18077D700")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6133DA0", Offset = "0x6132BA0", VA = "0x186133DA0")]
		public static GFEFPFAIPCE HJNGNBALKKN(string IIJDDKBOPLN, [NotNull] string IOFJIFKFLFF, long FBAODODGKKE, long CGKGHNNPCJM, string CLCNBMFDDJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6133CA0", Offset = "0x6132AA0", VA = "0x186133CA0")]
		public static GFEFPFAIPCE EAHBFGINGCO(string IIJDDKBOPLN, [NotNull] string IOFJIFKFLFF, long FBAODODGKKE, long CGKGHNNPCJM, string CLCNBMFDDJF, long CFMBEBLLJKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6134640", Offset = "0x6133440", VA = "0x186134640")]
		private AmplitudeAnalyticsEvent(string IIJDDKBOPLN, [NotNull] string IOFJIFKFLFF, long FBAODODGKKE, long CGKGHNNPCJM, string CLCNBMFDDJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x116FB10", Offset = "0x116E910", VA = "0x18116FB10")]
		public void NMKMIKMIBOG(long GDNBEDEMDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6134520", Offset = "0x6133320", VA = "0x186134520", Slot = "5")]
		public override void PFGPGBFFJPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6133E90", Offset = "0x6132C90", VA = "0x186133E90", Slot = "6")]
		public override void IHNJGPJDJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6134030", Offset = "0x6132E30", VA = "0x186134030", Slot = "4")]
		protected override Dictionary<string, object> JCEFNIMCLEJ(Dictionary<string, object> GLKPBPJJBID)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
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

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6135A40", Offset = "0x6134840", VA = "0x186135A40")]
			public void PGEMOMICOPD(Dictionary<string, object> BGPAFFKANHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
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

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x613BBF0", Offset = "0x613A9F0", VA = "0x18613BBF0")]
			public void PGEMOMICOPD(Dictionary<string, object> FLJFJDJGMBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x268AED0", Offset = "0x2689CD0", VA = "0x18268AED0")]
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

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6134940", Offset = "0x6133740", VA = "0x186134940")]
		public static ILILMAAEGNL HJNGNBALKKN(string IIJDDKBOPLN, string CLCNBMFDDJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6134F50", Offset = "0x6133D50", VA = "0x186134F50")]
		protected AmplitudeAnalyticsIdentifyMessage(string IIJDDKBOPLN, string CLCNBMFDDJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6134A70", Offset = "0x6133870", VA = "0x186134A70")]
		public Dictionary<string, object> IIGDBGOONEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6134AF0", Offset = "0x61338F0", VA = "0x186134AF0", Slot = "4")]
		protected virtual Dictionary<string, object> JCEFNIMCLEJ(Dictionary<string, object> GLKPBPJJBID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6134E30", Offset = "0x6133C30", VA = "0x186134E30")]
		protected void MOOBLALHKBG(string PIIJMEAKDGO, Dictionary<string, object> ANIAMMONPAK, Dictionary<string, object> CLAIMHFDFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61348D0", Offset = "0x61336D0", VA = "0x1861348D0")]
		protected void FFHHONKCLIJ(string PIIJMEAKDGO, string DFEOJBAFBHE, Dictionary<string, object> JOFBGDIJCFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6134ED0", Offset = "0x6133CD0", VA = "0x186134ED0", Slot = "5")]
		public virtual void PFGPGBFFJPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x61349F0", Offset = "0x61337F0", VA = "0x1861349F0", Slot = "6")]
		public virtual void IHNJGPJDJBB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ILILMAAEGNL : global::DANPJEJGJDM<AmplitudeAnalyticsIdentifyMessage, ILILMAAEGNL>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public override ILILMAAEGNL DPHIPDIHNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CKHHAHJAOHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6136830", Offset = "0x6135630", VA = "0x186136830")]
	public ILILMAAEGNL(AmplitudeAnalyticsIdentifyMessage LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6136790", Offset = "0x6135590", VA = "0x186136790", Slot = "4")]
	public override void IHNJGPJDJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GFEFPFAIPCE : global::DANPJEJGJDM<AmplitudeAnalyticsEvent, GFEFPFAIPCE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool IHBEOFGHCBP;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public override GFEFPFAIPCE DPHIPDIHNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long CCAFCNHFBON
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6136350", Offset = "0x6135150", VA = "0x186136350")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6136460", Offset = "0x6135260", VA = "0x186136460")]
	public GFEFPFAIPCE(AmplitudeAnalyticsEvent LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CKHHAHJAOHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x61362B0", Offset = "0x61350B0", VA = "0x1861362B0", Slot = "4")]
	public override void IHNJGPJDJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6136170", Offset = "0x6134F70", VA = "0x186136170")]
	public GFEFPFAIPCE GKEIPLCGNIC(string FJONJLMIBBO, long[] DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6135F30", Offset = "0x6134D30", VA = "0x186135F30")]
	public GFEFPFAIPCE GKEIPLCGNIC(string FJONJLMIBBO, ulong[] DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D2D0", Offset = "0x3A1C0D0", VA = "0x183A1D2D0")]
	public GFEFPFAIPCE GKEIPLCGNIC<T>(string FJONJLMIBBO, T[] DFEOJBAFBHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6135E90", Offset = "0x6134C90", VA = "0x186135E90")]
	public GFEFPFAIPCE GKEIPLCGNIC(string FJONJLMIBBO, string[] DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3A1D260", Offset = "0x3A1C060", VA = "0x183A1D260")]
	public GFEFPFAIPCE GKEIPLCGNIC<T>(string FJONJLMIBBO, T DFEOJBAFBHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6135EA0", Offset = "0x6134CA0", VA = "0x186135EA0")]
	public GFEFPFAIPCE GKEIPLCGNIC(string FJONJLMIBBO, long DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x61360E0", Offset = "0x6134EE0", VA = "0x1861360E0")]
	public GFEFPFAIPCE GKEIPLCGNIC(string FJONJLMIBBO, ulong DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6136070", Offset = "0x6134E70", VA = "0x186136070")]
	public GFEFPFAIPCE GKEIPLCGNIC(string FJONJLMIBBO, string DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6135DD0", Offset = "0x6134BD0", VA = "0x186135DD0")]
	public GFEFPFAIPCE AMPPKFHDDEI(string FJONJLMIBBO, object? DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6135DF0", Offset = "0x6134BF0", VA = "0x186135DF0")]
	public GFEFPFAIPCE CCMBFKLFCLG(string FJONJLMIBBO, string DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6136370", Offset = "0x6135170", VA = "0x186136370")]
	private GFEFPFAIPCE NFKMIGAMLPG(string FJONJLMIBBO, object DFEOJBAFBHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JDCLDAIOGPG : GFEFPFAIPCE
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6136460", Offset = "0x6135260", VA = "0x186136460")]
	public JDCLDAIOGPG(AmplitudeAnalyticsEvent LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6137150", Offset = "0x6135F50", VA = "0x186137150", Slot = "4")]
	public override void IHNJGPJDJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class DANPJEJGJDM<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::DANPJEJGJDM<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected M LMLMHJKGDCH;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract BLDR DPHIPDIHNKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FB60", Offset = "0x2E6E960", VA = "0x182E6FB60")]
	public DANPJEJGJDM(M LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4046BE0", Offset = "0x40459E0", VA = "0x184046BE0")]
	public BLDR GNHHFDPDOBG(AmplitudeAnalyticsIdentifyMessage.DeviceInfo BGGAGNEOAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x40469D0", Offset = "0x40457D0", VA = "0x1840469D0")]
	public BLDR DGDGDPHMDCP(AmplitudeAnalyticsIdentifyMessage.RevenueData APPPJGCMCPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4046B70", Offset = "0x4045970", VA = "0x184046B70")]
	public BLDR DLPEJFDOFCJ(string FJONJLMIBBO, string DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2F609C0", Offset = "0x2F5F7C0", VA = "0x182F609C0")]
	public BLDR DLPEJFDOFCJ<T>(string FJONJLMIBBO, T DFEOJBAFBHE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4046AC0", Offset = "0x40458C0", VA = "0x184046AC0")]
	public BLDR DLPEJFDOFCJ(string FJONJLMIBBO, long DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4046A10", Offset = "0x4045810", VA = "0x184046A10")]
	public BLDR DLPEJFDOFCJ(string FJONJLMIBBO, ulong DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IHNJGPJDJBB();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4046C20", Offset = "0x4045A20", VA = "0x184046C20")]
	internal static string HPLOBAOFNHJ(string DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x40468E0", Offset = "0x40456E0", VA = "0x1840468E0")]
	private BLDR AGALGKAPOMM(string FJONJLMIBBO, object DFEOJBAFBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CKHHAHJAOHE();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FCIELBMFCBN
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string IBICDNFJEFL = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string MIGLKMNBCOF = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string DKJBILJCMPF = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string AGKBIAKCLDP = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string ENPJAMODFHE = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string DEFEJEDLMNN = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string GJINJPLLPFN = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string GDBPILKGNHC = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string HBDNKBANFFM = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string FLNJGAAANNA = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string JOGEOINOELB = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string DOFCEIOGHHJ = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string FOIAPKHCHEA = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string NHHINAFNGON = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string DCKEOBIFEFL = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string JABEFBKELPA = "os";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string LDJFGOKNOOL = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string ILPOEDOFOHP = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string NGMHCJCIGJB = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string BDMIFOCBDDE = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string HLPIJDICIFK = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string NCFEIOIJAIP = "type";

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public FCIELBMFCBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KMGKJBADIBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int JOCAKGBBCCE = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int DIIIEBJEMGC = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int GNAPIOGHHDC = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const long FFGDKOKJMEB = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int NGDFDMOCDII = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int GEHLMDGDNKC = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const string BJLKMGPDFKI = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string EEDAOGDAJGD = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string JOIOIDMPIBB = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string IKKMNKDKBGG = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string FDPCKDJIEFP = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string HIJKGGPNNOD = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string OEEIFFEDGIE = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string MIKPKIHNBCB = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string FCOIODNOPEI = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string APIJJBMOPGO = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string DMIMBMMLCDA = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string FDIPFBJDAOO = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string BCPDJLCAICE = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string AEGHCKEGEKA = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string MNKNFHGACHI = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string PIBLPCIKOHE = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string FHKCIAJAAME = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string FHEEICGOKOB = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string IIHGJFMOJBN = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string HFGDOGGMCMA = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string MPKNCFMLKBJ = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string DPLIMJNMHIB = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string BPFDAPBNFPM = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string HEEABOPNICM = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string PEEKEIODJJI = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string OBKBMJCCOLI = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string FDLCPPHHHEF = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string ENPJAMODFHE = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string AFMGHEOJNAF = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const int KDPHNIIGPCH = 10;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> APFOPGPJJOK;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6137940", Offset = "0x6136740", VA = "0x186137940")]
	internal static bool PIBEKKLGPBA(string PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KMGKJBADIBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FAGILGJPKBK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool LDPGLKPAMML
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string OOLPGANMNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string KBBDALLILMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string JKMBECIFOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string MEDDMHBFHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MMBCCHGMCHN<EHLICNPDIBO> FJCPGDPJOBE(string AFMOAIJAGDB, Dictionary<string, string> KEAMIAPBPGJ, bool GJDJAICMIEI = false);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::MMBCCHGMCHN<EHLICNPDIBO> FPHEMJKFBIM(string AFMOAIJAGDB, string GKABCBNBEPG, string KKCJGLDAJLL, string INDDPAIMMEG);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EHLICNPDIBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly int INDJJIKKPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string KHAICLCGPAH;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xB49000", Offset = "0xB47E00", VA = "0x180B49000")]
	public EHLICNPDIBO(int IJKGIBNKDNP, string NAFIFJNCIJD)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6137660", Offset = "0x6136460", VA = "0x186137660")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6137310", Offset = "0x6136110", VA = "0x186137310")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
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

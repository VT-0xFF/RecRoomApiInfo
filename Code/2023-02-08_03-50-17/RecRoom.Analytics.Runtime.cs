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
		[Cpp2IlInjected.Address(RVA = "0x6E1DB0", Offset = "0x6E0BB0", VA = "0x1806E1DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F267B0", Offset = "0x1F255B0", VA = "0x181F267B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FC0", Offset = "0x9F6DC0", VA = "0x1809F7FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x106BC90", Offset = "0x106AA90", VA = "0x18106BC90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GGCCFCLAKAA
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
public class OEMFDIDBKPE
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string PKCFDNJDNKF = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string PHBGNMLJEHH = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string FNLFFPCGLPJ = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string MPGCHEAMBFD = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string AOLBDJJEIDL = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string GNDNMHCABBC = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string EBCFIFMAAJJ = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long BGIAMCCPMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private LIMENHKFLIP EAGBDCFPECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool AHLHMHFGILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float CAJFEPJNKJF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F26BE0", Offset = "0x1F259E0", VA = "0x181F26BE0")]
	public OEMFDIDBKPE(string ENBNGOGNFHB, float CAJFEPJNKJF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3687DC0", Offset = "0x3686BC0", VA = "0x183687DC0")]
	public void EGBILJPJIHO<T>(string JHGILNGJHFB, T DPJGMDFEIDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1F26A20", Offset = "0x1F25820", VA = "0x181F26A20")]
	public void EGBILJPJIHO(string JHGILNGJHFB, string DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1F26AF0", Offset = "0x1F258F0", VA = "0x181F26AF0")]
	public void NGCBPAEEHEL(string LMJCLCBNILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1F26840", Offset = "0x1F25640", VA = "0x181F26840")]
	public void AKONJAAGCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1F26900", Offset = "0x1F25700", VA = "0x181F26900")]
	private void CEFJLLHDOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F26AA0", Offset = "0x1F258A0", VA = "0x181F26AA0")]
	private bool GONHNDACPAB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EFNPGJMKAFL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FFFHIGBANBM FKIENGHPLFJ(string BDKFHGBJGCD, string INEDFHEOMAO, [Optional] ELMPFIOAHAA KKDGJLFFIAB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FFFHIGBANBM KDDILELECDC(ELMPFIOAHAA KKDGJLFFIAB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FFFHIGBANBM BMJIHGIDDHJ(ELMPFIOAHAA KKDGJLFFIAB, Dictionary<string, string> FPNJMBBLPHG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JOPHGIIJBDO(string KHMGOHJPKPO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ACJEAEDKEIH BFNEPIFNDML(string MBCMPIMPJHN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AKAOMMGLLMG JAGKPPLFEIC(string AIMOHEOHJCN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ACJEAEDKEIH CDCIALKJHMA(string ELLNAKAIFLO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FFFHIGBANBM IEFGBHBMBHO();
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
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F27E80", Offset = "0x1F26C80", VA = "0x181F27E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GAHIBPEPJFD : EFNPGJMKAFL
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string MLCHBGGJKHB = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string EDBCIAKBPNN = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string GCLAJCFLDPO = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string MLJCPPAOECJ = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string PCBKLOBKJOG = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string CEBOOAFLGOJ = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string JHMDIBGJMLE = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string CNLIKBJNMGF = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string PAJEFFLHOMC = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string NMDEGEFFJID = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string DIMJBAHNKIK = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, ANPEABFKIKL> GOBFMNCKMEL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int BBJLEFHAEPB = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool IKNFMLFOBJC;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F21C90", Offset = "0x1F20A90", VA = "0x181F21C90", Slot = "4")]
	public FFFHIGBANBM FKIENGHPLFJ(string BDKFHGBJGCD, string INEDFHEOMAO, [Optional] ELMPFIOAHAA KKDGJLFFIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1F228C0", Offset = "0x1F216C0", VA = "0x181F228C0", Slot = "11")]
	public FFFHIGBANBM IEFGBHBMBHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F22BC0", Offset = "0x1F219C0", VA = "0x181F22BC0", Slot = "5")]
	public FFFHIGBANBM KDDILELECDC(ELMPFIOAHAA KKDGJLFFIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F21660", Offset = "0x1F20460", VA = "0x181F21660", Slot = "6")]
	public FFFHIGBANBM BMJIHGIDDHJ(ELMPFIOAHAA KKDGJLFFIAB, Dictionary<string, string> FPNJMBBLPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F22B10", Offset = "0x1F21910", VA = "0x181F22B10", Slot = "7")]
	public bool JOPHGIIJBDO(string KHMGOHJPKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F21540", Offset = "0x1F20340", VA = "0x181F21540", Slot = "8")]
	public ACJEAEDKEIH BFNEPIFNDML(string MBCMPIMPJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F22A50", Offset = "0x1F21850", VA = "0x181F22A50", Slot = "9")]
	public AKAOMMGLLMG JAGKPPLFEIC(string AIMOHEOHJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F21950", Offset = "0x1F20750", VA = "0x181F21950", Slot = "10")]
	public ACJEAEDKEIH CDCIALKJHMA(string ELLNAKAIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F222D0", Offset = "0x1F210D0", VA = "0x181F222D0")]
	private DGLPOIGDKDI HIAGJFJIBKO(ELMPFIOAHAA KKDGJLFFIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F22130", Offset = "0x1F20F30", VA = "0x181F22130")]
	private DPMOJLCGEGL HBKGHDKLIDD(string INEDFHEOMAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F21A40", Offset = "0x1F20840", VA = "0x181F21A40")]
	private void EFDJLENIOIA(string MBCMPIMPJHN, ACJEAEDKEIH MOEFJFNCLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public GAHIBPEPJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xE18930", Offset = "0xE17730", VA = "0x180E18930")]
	[CompilerGenerated]
	private void LEIEJHJEBJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GPDLABGEBLF : EFNPGJMKAFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private EFNPGJMKAFL LOPAIIDLJCN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private EFNPGJMKAFL LAMFILKLNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1F230F0", Offset = "0x1F21EF0", VA = "0x181F230F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	[Preserve]
	public GPDLABGEBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1F23720", Offset = "0x1F22520", VA = "0x181F23720")]
	[HPAMKJCLFIM(BFFNGLOENLB.GameOnly)]
	private static void MDMEGPCEMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1F23160", Offset = "0x1F21F60", VA = "0x181F23160", Slot = "4")]
	public FFFHIGBANBM FKIENGHPLFJ(string BDKFHGBJGCD, string INEDFHEOMAO, [Optional] ELMPFIOAHAA KKDGJLFFIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1F23620", Offset = "0x1F22420", VA = "0x181F23620", Slot = "5")]
	public FFFHIGBANBM KDDILELECDC(ELMPFIOAHAA KKDGJLFFIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1F22F40", Offset = "0x1F21D40", VA = "0x181F22F40", Slot = "6")]
	public FFFHIGBANBM BMJIHGIDDHJ(ELMPFIOAHAA KKDGJLFFIAB, Dictionary<string, string> FPNJMBBLPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F23580", Offset = "0x1F22380", VA = "0x181F23580", Slot = "7")]
	public bool JOPHGIIJBDO(string KHMGOHJPKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1F22EA0", Offset = "0x1F21CA0", VA = "0x181F22EA0", Slot = "8")]
	public ACJEAEDKEIH BFNEPIFNDML(string MBCMPIMPJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F23480", Offset = "0x1F22280", VA = "0x181F23480", Slot = "9")]
	public AKAOMMGLLMG JAGKPPLFEIC(string AIMOHEOHJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F23050", Offset = "0x1F21E50", VA = "0x181F23050", Slot = "10")]
	public ACJEAEDKEIH CDCIALKJHMA(string ELLNAKAIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F23380", Offset = "0x1F22180", VA = "0x181F23380", Slot = "11")]
	public FFFHIGBANBM IEFGBHBMBHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KJNCBKIJOPF : EFNPGJMKAFL
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1F25750", Offset = "0x1F24550", VA = "0x181F25750", Slot = "4")]
	public FFFHIGBANBM FKIENGHPLFJ(string BDKFHGBJGCD, string INEDFHEOMAO, [Optional] ELMPFIOAHAA KKDGJLFFIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F258A0", Offset = "0x1F246A0", VA = "0x181F258A0", Slot = "5")]
	public FFFHIGBANBM KDDILELECDC(ELMPFIOAHAA KKDGJLFFIAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1F256B0", Offset = "0x1F244B0", VA = "0x181F256B0", Slot = "6")]
	public FFFHIGBANBM BMJIHGIDDHJ(ELMPFIOAHAA KKDGJLFFIAB, Dictionary<string, string> FPNJMBBLPHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE0", Offset = "0x6E49E0", VA = "0x1806E5BE0", Slot = "7")]
	public bool JOPHGIIJBDO(string KHMGOHJPKPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1F256A0", Offset = "0x1F244A0", VA = "0x181F256A0", Slot = "8")]
	public ACJEAEDKEIH BFNEPIFNDML(string MBCMPIMPJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1F25890", Offset = "0x1F24690", VA = "0x181F25890", Slot = "9")]
	public AKAOMMGLLMG JAGKPPLFEIC(string AIMOHEOHJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F256A0", Offset = "0x1F244A0", VA = "0x181F256A0", Slot = "10")]
	public ACJEAEDKEIH CDCIALKJHMA(string ELLNAKAIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F257F0", Offset = "0x1F245F0", VA = "0x181F257F0", Slot = "11")]
	public FFFHIGBANBM IEFGBHBMBHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public KJNCBKIJOPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OPCAJHBKBDM
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IsExperimentSegmentActive(string MBCMPIMPJHN, string EMPGEHPNIAD, bool KGNMDIHGNMF = true);
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
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ExperimentSegment
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F27E30", Offset = "0x1F26C30", VA = "0x181F27E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public SerializedSplitTestExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IGPDOHAIGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEMFDIDBKPE ONKNIBHILNL(string ENBNGOGNFHB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OLAHOMLINBM
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MABIEDDKDHG(string IEGGGFEMEIG, string GGOIDKHPKLP, string FJBONOABJBO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHIJMLLHPMF(string IEGGGFEMEIG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBBBPFPGKGH(string IEGGGFEMEIG, string HHNBMLMAAAJ, string HMLPMKOFPHM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ELMPFIOAHAA
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool CABJKFGKDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HNLOFHLANFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MDIPJBDPGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool EBBOLKOPKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool? OBNGDLNNECH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int? EJIIKKNHCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int DNKLCCNBBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string HLJMNCPLILC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string MEBLNGNJHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string ANJHAGCHMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string LMKBGIOCLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string EGMOHFMHKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string EPFKJILECCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	double NKEBFCLKOAA
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
		public AmplitudeAnalyticsClient.Settings HBLJCKNCEAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ADKDDIAEFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x88A3B0", Offset = "0x8891B0", VA = "0x18088A3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum HAGBIPABFOA
		{
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			RudderStackOnly,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Both
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum FDMJPNEBHJI
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		internal class ILICEBPBAGP
		{
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			private class DBDLNMAIJPM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int DOGCALFMAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				public Dictionary<string, object> PCBHMKBCNFP;

				[Cpp2IlInjected.Token(Token = "0x60000A5")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public DBDLNMAIJPM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000019")]
			[CompilerGenerated]
			private sealed class DEFBNMLBNDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public DEFBNMLBNDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000A7")]
				[Cpp2IlInjected.Address(RVA = "0x1F20E70", Offset = "0x1F1FC70", VA = "0x181F20E70")]
				internal bool <GetBatch>b__0(DBDLNMAIJPM item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private const string GODOLIKPDML = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private readonly string PAEKKCIOLNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private List<DBDLNMAIJPM> KHFLIBOPOOB;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public int? LJIMLDDACLN
			{
				[Cpp2IlInjected.Token(Token = "0x6000099")]
				[Cpp2IlInjected.Address(RVA = "0x1F24780", Offset = "0x1F23580", VA = "0x181F24780")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? KMDDGELEOCC
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0x1F24D30", Offset = "0x1F23B30", VA = "0x181F24D30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1F25510", Offset = "0x1F24310", VA = "0x181F25510")]
			internal ILICEBPBAGP(string OGNLLNOOPMK, string INEDFHEOMAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1F24A70", Offset = "0x1F23870", VA = "0x181F24A70")]
			public int KNHEINPCMPO([Optional] int? AAGBGLNGBED)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1F24340", Offset = "0x1F23140", VA = "0x181F24340")]
			public List<Dictionary<string, object>> DLNKKLJPEFC(int HGDBOLNENMJ, int? AAGBGLNGBED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1F246E0", Offset = "0x1F234E0", VA = "0x181F246E0")]
			public void ENGNENIPBAN(AmplitudeAnalyticsIdentifyMessage LOPIEGGIDMF, bool EALOBMMKKOE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1F245D0", Offset = "0x1F233D0", VA = "0x181F245D0")]
			public void ENGNENIPBAN(Dictionary<string, object> LOPIEGGIDMF, bool EALOBMMKKOE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x1F241B0", Offset = "0x1F22FB0", VA = "0x181F241B0")]
			public void CNFPMIBEDDK(params Dictionary<string, object>[] OKJCBJAMAPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1F24820", Offset = "0x1F23620", VA = "0x181F24820")]
			public void KDNINIBBEHJ(List<Dictionary<string, object>> NIBFFDMCDJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1F24070", Offset = "0x1F22E70", VA = "0x181F24070")]
			private void CJGFMIGPDBP(Dictionary<string, object> LOPIEGGIDMF, bool EALOBMMKKOE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x1F252A0", Offset = "0x1F240A0", VA = "0x181F252A0")]
			public void PIJAPCBCGCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1F24DF0", Offset = "0x1F23BF0", VA = "0x181F24DF0")]
			private void OFELIOAMAEM([Optional] string CABKGFENIDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1F24C00", Offset = "0x1F23A00", VA = "0x181F24C00")]
			private static string MCDJMKFHJEO(string DPJGMDFEIDL, string CKMEBFKEHMO)
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
			[Cpp2IlInjected.Address(RVA = "0x1F280D0", Offset = "0x1F26ED0", VA = "0x181F280D0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct AJLNJEEKKFM<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int CAKOADPKJND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string PCKKFHOKFCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public T BHDOKIMAMFI;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class IKIDLKNPHFF : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private KDNIAKIKLPJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public IKIDLKNPHFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1F23A40", Offset = "0x1F22840", VA = "0x181F23A40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x1F24030", Offset = "0x1F22E30", VA = "0x181F24030", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class HPDBMLECPEI : IEnumerator<object>, IEnumerator, IDisposable
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
			public HNONHEFEGPD quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public HPDBMLECPEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1F23910", Offset = "0x1F22710", VA = "0x181F23910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x1F23A00", Offset = "0x1F22800", VA = "0x181F23A00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class NGLLOIIGIBN : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public NGLLOIIGIBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x1F26600", Offset = "0x1F25400", VA = "0x181F26600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1F26770", Offset = "0x1F25570", VA = "0x181F26770", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class ADJEFBNFENA : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private KDNIAKIKLPJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C3")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public ADJEFBNFENA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x1F1A5C0", Offset = "0x1F193C0", VA = "0x181F1A5C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x1F1A860", Offset = "0x1F19660", VA = "0x181F1A860", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class ELJEJEJDGMJ : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private KDNIAKIKLPJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CC")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public ELJEJEJDGMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1F21050", Offset = "0x1F1FE50", VA = "0x181F21050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1F212F0", Offset = "0x1F200F0", VA = "0x181F212F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class PENOENNICKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public ILICEBPBAGP cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public PENOENNICKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x1F27800", Offset = "0x1F26600", VA = "0x181F27800")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1F278A0", Offset = "0x1F266A0", VA = "0x181F278A0")]
			internal void <FlushFromCache>b__1(AJLNJEEKKFM<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class OIMEOGEJHGM : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private KDNIAKIKLPJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public ILICEBPBAGP cache;

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
			private PENOENNICKP <>8__1;

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
			private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public OIMEOGEJHGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1F26D80", Offset = "0x1F25B80", VA = "0x181F26D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1F27610", Offset = "0x1F26410", VA = "0x181F27610", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class ABPOODBECOF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
			public ABPOODBECOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x38CCCF0", Offset = "0x38CBAF0", VA = "0x1838CCCF0")]
			internal AJLNJEEKKFM<T> <PostRudderStackJson>b__0(MFBNHEFGLNE postResponse)
			{
				return default(AJLNJEEKKFM<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class BLNKFEMAFMB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
			public BLNKFEMAFMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x38CCCF0", Offset = "0x38CBAF0", VA = "0x1838CCCF0")]
			internal AJLNJEEKKFM<T> <PostAmplitudeJson>b__0(MFBNHEFGLNE postResponse)
			{
				return default(AJLNJEEKKFM<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private PNMPNMBAJNO FKINBNPIPNG;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string EPFAIBBIBAH = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string GIIAAJCDHHA = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string ANIJLPOKHJM = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const int FOODMFIIAOJ = 10;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const int FOJNGJPCAKM = 10;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const int FNFJONNDPNC = 5;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float BFGJBEIGEBF = 10f;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const long ALEOIMLOFLK = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const string EBCHFLDNECD = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const string JLHOFAHDGMK = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static bool BNOLDLPLDOG;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static bool KAJLFIDIGFC;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static int BFFCGDDAMPH;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static int BOJFAGDGLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EBEIDEOLGAC NJPEDCEFKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool CBNABHBCGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float MLKMEMEIAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float HIEJLLODJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int JDOENDPAGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private int JAADKBOAPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private int? BEIKEMBBBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int? MGCNMNELHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private long BBJBGIIGFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private string BLCDMBJPCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private long OFBJCPLAILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Dictionary<string, object> EFNMGBMAKII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private FDMJPNEBHJI IEPMHMNGEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int FIPLNOFIHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int IPDFHIPEGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private float EAFPAEFAFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool PAIFDLHLDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool IDDBDKNGKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private ILICEBPBAGP ABDCKFLELEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private ILICEBPBAGP ELJHGNHLMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private ILICEBPBAGP JKPMPOMPOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> AIAIHILMJML;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo GBMMAGBMLAD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static string CNEDPDIKOMG;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private const string AGPLKODHKCE = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly string JBBDPCHMANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly string IENEGFKKGOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string LHDHOEFAKGP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private PNMPNMBAJNO GJINKKIDMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1F1AFF0", Offset = "0x1F19DF0", VA = "0x181F1AFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static int BEGNNEIJAJO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1F1E060", Offset = "0x1F1CE60", VA = "0x181F1E060")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static long DAHFEEBDCMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1F1F9A0", Offset = "0x1F1E7A0", VA = "0x181F1F9A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1F1FAA0", Offset = "0x1F1E8A0", VA = "0x181F1FAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string EDGLKDEOEGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1F1F940", Offset = "0x1F1E740", VA = "0x181F1F940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string HPPPMAOBIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1F1F970", Offset = "0x1F1E770", VA = "0x181F1F970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string IEOEDFKHGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x75ED90", Offset = "0x75DB90", VA = "0x18075ED90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x764890", Offset = "0x763690", VA = "0x180764890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int? EJIIKKNHCFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7284E0", Offset = "0x7272E0", VA = "0x1807284E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x970A00", Offset = "0x96F800", VA = "0x180970A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public HAGBIPABFOA? FGEDPHGNEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82A080", Offset = "0x828E80", VA = "0x18082A080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x970A10", Offset = "0x96F810", VA = "0x180970A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool OJNCHICMNKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x77BF40", Offset = "0x77AD40", VA = "0x18077BF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x77B790", Offset = "0x77A590", VA = "0x18077B790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool OGOLCPMBHKK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1F1F850", Offset = "0x1F1E650", VA = "0x181F1F850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CFGFELCEMLC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1F1F7B0", Offset = "0x1F1E5B0", VA = "0x181F1F7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1F1FA00", Offset = "0x1F1E800", VA = "0x181F1FA00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1F1AB20", Offset = "0x1F19920", VA = "0x181F1AB20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C780", Offset = "0x1F1B580", VA = "0x181F1C780")]
		private void EHBEHJKANKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F000", Offset = "0x1F1DE00", VA = "0x181F1F000")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E3D0", Offset = "0x1F1D1D0", VA = "0x181F1E3D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F2F0", Offset = "0x1F1E0F0", VA = "0x181F1F2F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E660", Offset = "0x1F1D460", VA = "0x181F1E660")]
		public FFFHIGBANBM PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D4B0", Offset = "0x1F1C2B0", VA = "0x181F1D4B0")]
		[IteratorStateMachine(typeof(IKIDLKNPHFF))]
		public IEnumerator<KDNIAKIKLPJ> Initialize(AmplitudeAnalyticsEvent PIPICLJJCOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F1E0", Offset = "0x1F1DFE0", VA = "0x181F1F1E0")]
		public void UpdateLastAliveTime(float FAMHMKFHFGM = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B570", Offset = "0x1F1A370", VA = "0x181F1B570")]
		private FFFHIGBANBM CKLCOMKJMFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CD30", Offset = "0x1F1BB30", VA = "0x181F1CD30")]
		private FFFHIGBANBM HHJENGODEGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1F1EBB0", Offset = "0x1F1D9B0", VA = "0x181F1EBB0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E5D0", Offset = "0x1F1D3D0", VA = "0x181F1E5D0")]
		[IteratorStateMachine(typeof(HPDBMLECPEI))]
		private IEnumerator PICEBMGGOAC(HNONHEFEGPD LMEMMMEAIPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F560", Offset = "0x1F1E360", VA = "0x181F1F560")]
		[IteratorStateMachine(typeof(NGLLOIIGIBN))]
		public IEnumerator WaitForFlush(float FCLFNKIGFPE = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F0C0", Offset = "0x1F1DEC0", VA = "0x181F1F0C0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F010", Offset = "0x1F1DE10", VA = "0x181F1F010")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime CAKJEKBKLMM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D100", Offset = "0x1F1BF00", VA = "0x181F1D100")]
		public static HCEONGDFGBF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A980", Offset = "0x1F19780", VA = "0x181F1A980")]
		public static LIMENHKFLIP AccountSelectionPostLoginEvent([NotNull] string JPGCFKKKJKM, string CIAHIJOIMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CAA0", Offset = "0x1F1B8A0", VA = "0x181F1CAA0")]
		public static LIMENHKFLIP Event([NotNull] string JPGCFKKKJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E6C0", Offset = "0x1F1D4C0", VA = "0x181F1E6C0")]
		public static LIMENHKFLIP PreviousSessionEvent([NotNull] string JPGCFKKKJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D260", Offset = "0x1F1C060", VA = "0x181F1D260")]
		public static LIMENHKFLIP InitializeEvent(string CIAHIJOIMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1ED10", Offset = "0x1F1DB10", VA = "0x181F1ED10")]
		public static LIMENHKFLIP StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B640", Offset = "0x1F1A440", VA = "0x181F1B640")]
		public static LIMENHKFLIP CreateOutOfSessionEvent(string JPGCFKKKJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D800", Offset = "0x1F1C600", VA = "0x181F1D800")]
		public static FFFHIGBANBM LogOutOfSessionEvent(LIMENHKFLIP FLDIGFPKFPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D540", Offset = "0x1F1C340", VA = "0x181F1D540")]
		public void LogEventAsync(AmplitudeAnalyticsEvent BOCLCMPCAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F1DBA0", Offset = "0x1F1C9A0", VA = "0x181F1DBA0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent BOCLCMPCAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1F1DCF0", Offset = "0x1F1CAF0", VA = "0x181F1DCF0")]
		public void LogSerializedEventAsync(Dictionary<string, object> CLHLJNNIIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D690", Offset = "0x1F1C490", VA = "0x181F1D690")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LMHJOLAGENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F1D020", Offset = "0x1F1BE20", VA = "0x181F1D020")]
		private void IIAEHBAINKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F1DDD0", Offset = "0x1F1CBD0", VA = "0x181F1DDD0")]
		private void MLAIJBKNJNB(Dictionary<string, object> JCMJBHPHNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B990", Offset = "0x1F1A790", VA = "0x181F1B990")]
		private void DEOMKHMOIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1F1AE10", Offset = "0x1F19C10", VA = "0x181F1AE10")]
		private void BDPAJMHBNNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CCA0", Offset = "0x1F1BAA0", VA = "0x181F1CCA0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E230", Offset = "0x1F1D030", VA = "0x181F1E230")]
		[IteratorStateMachine(typeof(ADJEFBNFENA))]
		private IEnumerator<KDNIAKIKLPJ> NFABAAACABB(float FCLFNKIGFPE = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B910", Offset = "0x1F1A710", VA = "0x181F1B910")]
		[IteratorStateMachine(typeof(ELJEJEJDGMJ))]
		private IEnumerator<KDNIAKIKLPJ> DELFFGMIEJN(float FCLFNKIGFPE = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F1A8A0", Offset = "0x1F196A0", VA = "0x181F1A8A0")]
		[IteratorStateMachine(typeof(OIMEOGEJHGM))]
		private IEnumerator<KDNIAKIKLPJ> AKIMCJHOEGL(ILICEBPBAGP NEELKCPMANJ, int? AAGBGLNGBED, string KNJMLANMKCG, string MNLBNLEBBOA, float FCLFNKIGFPE, Action<int> LBMIBMKJCJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E2B0", Offset = "0x1F1D0B0", VA = "0x181F1E2B0")]
		private static void OEDCCELAACM(bool OLLLDCOLODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B3B0", Offset = "0x1F1A1B0", VA = "0x181F1B3B0")]
		private global::KOILDJEEFJD<AJLNJEEKKFM<Dictionary<string, object>>> CACJBFIEGML(string KNJMLANMKCG, string MNLBNLEBBOA, string ADGJBCKHHAG, string GJHNLLLCAFC, Dictionary<string, object> BHDOKIMAMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B060", Offset = "0x1F19E60", VA = "0x181F1B060")]
		private global::KOILDJEEFJD<AJLNJEEKKFM<List<Dictionary<string, object>>>> CACJBFIEGML(string KNJMLANMKCG, string MNLBNLEBBOA, string ADGJBCKHHAG, string GJHNLLLCAFC, List<Dictionary<string, object>> BHDOKIMAMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x431F350", Offset = "0x431E150", VA = "0x18431F350")]
		private global::KOILDJEEFJD<AJLNJEEKKFM<T>> DDOBJJMDPHE<T>(string KNJMLANMKCG, string MNLBNLEBBOA, string GJHNLLLCAFC, T BHDOKIMAMFI, Dictionary<string, object> PKMOEMNMJLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x431F5E0", Offset = "0x431E3E0", VA = "0x18431F5E0")]
		private global::KOILDJEEFJD<AJLNJEEKKFM<T>> ILNEFFOHELF<T>(string KNJMLANMKCG, string MNLBNLEBBOA, string ADGJBCKHHAG, T BHDOKIMAMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CFD0", Offset = "0x1F1BDD0", VA = "0x181F1CFD0")]
		private bool HMDBODFIBHL(float GIHCFFJEGLH, float FCLFNKIGFPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1F1BA80", Offset = "0x1F1A880", VA = "0x181F1BA80")]
		private Dictionary<string, object> EBCNLEAGOKC(string MNLBNLEBBOA, Dictionary<string, object> BHDOKIMAMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1F1F640", Offset = "0x1F1E440", VA = "0x181F1F640")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1F1E470", Offset = "0x1F1D270", VA = "0x181F1E470")]
		[CompilerGenerated]
		private long PAELCCPPGML()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B560", Offset = "0x1F1A360", VA = "0x181F1B560")]
		[CompilerGenerated]
		private void CAINKOFEEGL(int FPOKNEPCBKO)
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
			[Cpp2IlInjected.Address(RVA = "0x1F20660", Offset = "0x1F1F460", VA = "0x181F20660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1F206C0", Offset = "0x1F1F4C0", VA = "0x181F206C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6C5CB0", Offset = "0x6C4AB0", VA = "0x1806C5CB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FB00", Offset = "0x1F1E900", VA = "0x181F1FB00")]
		public static LIMENHKFLIP DIMOBFAICBM(string LLNMOPOJDNH, [NotNull] string KHACDPLAFAB, long CNJCINNNBGN, long AHHPMFDIJNO, string CIAHIJOIMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FBF0", Offset = "0x1F1E9F0", VA = "0x181F1FBF0")]
		public static LIMENHKFLIP EMADIHCJLGI(string LLNMOPOJDNH, [NotNull] string KHACDPLAFAB, long CNJCINNNBGN, long AHHPMFDIJNO, string CIAHIJOIMHO, long CDPCJPCLENF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1F204A0", Offset = "0x1F1F2A0", VA = "0x181F204A0")]
		private AmplitudeAnalyticsEvent(string LLNMOPOJDNH, [NotNull] string KHACDPLAFAB, long CNJCINNNBGN, long AHHPMFDIJNO, string CIAHIJOIMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x1012030", Offset = "0x1010E30", VA = "0x181012030")]
		public void CEPPAOOFFPA(long JDFBLPLJCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FCF0", Offset = "0x1F1EAF0", VA = "0x181F1FCF0", Slot = "5")]
		public override void GANGGOFFKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1F20300", Offset = "0x1F1F100", VA = "0x181F20300", Slot = "6")]
		public override void ILDPFJIGAJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FE10", Offset = "0x1F1EC10", VA = "0x181F1FE10", Slot = "4")]
		protected override Dictionary<string, object> IJPGKHNJNAC(Dictionary<string, object> MNAKKOHFAND)
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
			[Cpp2IlInjected.Address(RVA = "0x1F20ED0", Offset = "0x1F1FCD0", VA = "0x181F20ED0")]
			public void KNGHMOMGKAO(Dictionary<string, object> KLFPJBDIOCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
			[Cpp2IlInjected.Address(RVA = "0x1F27CB0", Offset = "0x1F26AB0", VA = "0x181F27CB0")]
			public void KNGHMOMGKAO(Dictionary<string, object> NHFLFHAOEFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1F27E20", Offset = "0x1F26C20", VA = "0x181F27E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1F207A0", Offset = "0x1F1F5A0", VA = "0x181F207A0")]
		public static HCEONGDFGBF DIMOBFAICBM(string LLNMOPOJDNH, string CIAHIJOIMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F20DB0", Offset = "0x1F1FBB0", VA = "0x181F20DB0")]
		protected AmplitudeAnalyticsIdentifyMessage(string LLNMOPOJDNH, string CIAHIJOIMHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F20D30", Offset = "0x1F1FB30", VA = "0x181F20D30")]
		public Dictionary<string, object> LHDFCBEJEPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F208D0", Offset = "0x1F1F6D0", VA = "0x181F208D0", Slot = "4")]
		protected virtual Dictionary<string, object> IJPGKHNJNAC(Dictionary<string, object> MNAKKOHFAND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1F20C90", Offset = "0x1F1FA90", VA = "0x181F20C90")]
		protected void IOKMIBJPGGC(string CKMEBFKEHMO, Dictionary<string, object> CIJJELDANIG, Dictionary<string, object> DPGJAJHDCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1F20730", Offset = "0x1F1F530", VA = "0x181F20730")]
		protected void APNFMNHHKKG(string CKMEBFKEHMO, string DPJGMDFEIDL, Dictionary<string, object> KHCLPFJGIID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1F20850", Offset = "0x1F1F650", VA = "0x181F20850", Slot = "5")]
		public virtual void GANGGOFFKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1F20C10", Offset = "0x1F1FA10", VA = "0x181F20C10", Slot = "6")]
		public virtual void ILDPFJIGAJF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HCEONGDFGBF : global::OBCPBKCFIFH<AmplitudeAnalyticsIdentifyMessage, HCEONGDFGBF>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public override HCEONGDFGBF GNAPOKNOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage PHEMGNMKAHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F238C0", Offset = "0x1F226C0", VA = "0x181F238C0")]
	public HCEONGDFGBF(AmplitudeAnalyticsIdentifyMessage IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F23820", Offset = "0x1F22620", VA = "0x181F23820", Slot = "4")]
	public override void ILDPFJIGAJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LIMENHKFLIP : global::OBCPBKCFIFH<AmplitudeAnalyticsEvent, LIMENHKFLIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool JHKBGLIFDJL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public override LIMENHKFLIP GNAPOKNOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x743E70", Offset = "0x742C70", VA = "0x180743E70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long FHIAHGNGEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1F259E0", Offset = "0x1F247E0", VA = "0x181F259E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1F214F0", Offset = "0x1F202F0", VA = "0x181F214F0")]
	public LIMENHKFLIP(AmplitudeAnalyticsEvent IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10", Slot = "5")]
	public override AmplitudeAnalyticsEvent PHEMGNMKAHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F25E20", Offset = "0x1F24C20", VA = "0x181F25E20", Slot = "4")]
	public override void ILDPFJIGAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F25A70", Offset = "0x1F24870", VA = "0x181F25A70")]
	public LIMENHKFLIP EGBILJPJIHO(string JHGILNGJHFB, long[] DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F25BC0", Offset = "0x1F249C0", VA = "0x181F25BC0")]
	public LIMENHKFLIP EGBILJPJIHO(string JHGILNGJHFB, ulong[] DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3C74D60", Offset = "0x3C73B60", VA = "0x183C74D60")]
	public LIMENHKFLIP EGBILJPJIHO<T>(string JHGILNGJHFB, T[] DPJGMDFEIDL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1F25BB0", Offset = "0x1F249B0", VA = "0x181F25BB0")]
	public LIMENHKFLIP EGBILJPJIHO(string JHGILNGJHFB, string[] DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3C74CF0", Offset = "0x3C73AF0", VA = "0x183C74CF0")]
	public LIMENHKFLIP EGBILJPJIHO<T>(string JHGILNGJHFB, T DPJGMDFEIDL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1F25D90", Offset = "0x1F24B90", VA = "0x181F25D90")]
	public LIMENHKFLIP EGBILJPJIHO(string JHGILNGJHFB, long DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1F25D00", Offset = "0x1F24B00", VA = "0x181F25D00")]
	public LIMENHKFLIP EGBILJPJIHO(string JHGILNGJHFB, ulong DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1F25A00", Offset = "0x1F24800", VA = "0x181F25A00")]
	public LIMENHKFLIP EGBILJPJIHO(string JHGILNGJHFB, string DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1F25EC0", Offset = "0x1F24CC0", VA = "0x181F25EC0")]
	public LIMENHKFLIP JGEFEOIGOEF(string JHGILNGJHFB, object? DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1F25940", Offset = "0x1F24740", VA = "0x181F25940")]
	public LIMENHKFLIP AAKJFOLGCMA(string JHGILNGJHFB, string DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1F25EE0", Offset = "0x1F24CE0", VA = "0x181F25EE0")]
	private LIMENHKFLIP MKNCKIJNJJL(string JHGILNGJHFB, object DPJGMDFEIDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EOOGAJPELJP : LIMENHKFLIP
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1F214F0", Offset = "0x1F202F0", VA = "0x181F214F0")]
	public EOOGAJPELJP(AmplitudeAnalyticsEvent IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1F21330", Offset = "0x1F20130", VA = "0x181F21330", Slot = "4")]
	public override void ILDPFJIGAJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public abstract class OBCPBKCFIFH<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::OBCPBKCFIFH<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected M IACFBMPPCKF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract BLDR GNAPOKNOHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2C161E0", Offset = "0x2C14FE0", VA = "0x182C161E0")]
	public OBCPBKCFIFH(M IACFBMPPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x43E61B0", Offset = "0x43E4FB0", VA = "0x1843E61B0")]
	public BLDR AJFOKNJKGEB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo DGNKFHBMPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x43E6220", Offset = "0x43E5020", VA = "0x1843E6220")]
	public BLDR GOOCDNEHPHH(AmplitudeAnalyticsIdentifyMessage.RevenueData OHBMCMOBJGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x43E6090", Offset = "0x43E4E90", VA = "0x1843E6090")]
	public BLDR AHKPAKHOKPC(string JHGILNGJHFB, string DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4128D40", Offset = "0x4127B40", VA = "0x184128D40")]
	public BLDR AHKPAKHOKPC<T>(string JHGILNGJHFB, T DPJGMDFEIDL) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x43E6100", Offset = "0x43E4F00", VA = "0x1843E6100")]
	public BLDR AHKPAKHOKPC(string JHGILNGJHFB, long DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x43E5FE0", Offset = "0x43E4DE0", VA = "0x1843E5FE0")]
	public BLDR AHKPAKHOKPC(string JHGILNGJHFB, ulong DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ILDPFJIGAJF();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x43E61F0", Offset = "0x43E4FF0", VA = "0x1843E61F0")]
	internal static string GOBMGMNGGBE(string DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x43E6260", Offset = "0x43E5060", VA = "0x1843E6260")]
	private BLDR LBFDBMNDFIG(string JHGILNGJHFB, object DPJGMDFEIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M PHEMGNMKAHH();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GJCEAOMOPOC
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string IIGLAMCFEML = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string JBIIPPEJPHL = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string FHALAMBGKGM = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string EDMKKKCKNKH = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string FMJKPJLJLGI = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string JFLKPJCOONL = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string CKLALPNIMCL = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string FNDAJHKDEPB = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string MGPDNLJECGF = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string ALOLALBBELG = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string KPNLCHGNMFP = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string JOHENPNPBJC = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string MGHFCACCDHN = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string GJOPJBNDMEK = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string JNLNGHGJPMO = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string IPGFBNMDEKI = "os";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string FBBHILCABPK = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string KLBGOHLPLKB = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string EKFGBNBNIEP = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string JMMBIMNKAND = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string ABNMOKHNNMP = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string ECJCHCPFLIB = "type";

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public GJCEAOMOPOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OLNPDEMLGBK
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int DAKAMPCLNDO = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int MBBKKLONPOP = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int KKHNPENIBDC = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const long HFOLFHPDNAH = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int CNNAKBGBEAD = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int JKPHELOFKOP = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const string IPFGOHIMPHP = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string ODFHHJGCEEM = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string OPEKFOJBGAL = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string POFIHHECMNP = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string NCKECAJGHBJ = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string NCJFPPEEPHE = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string HNEIAIBBOKA = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string GPIDECIPHEB = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string CKPJGGPAPNL = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string IGJGDLBNCJN = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string MNOMAALIFAN = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string NNJJGFGECBM = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string FGMDBGFKNLA = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string AOHLPDOFCIB = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string KAFHNFMKICK = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string BNNMMLOJCHI = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string GLNKHPBHOPK = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string AMMJAJBKNJP = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string CLICIILBDAK = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string AMHGPAKPLMK = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string GGLBJONLJHH = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string JBPBNKHMAMH = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string JCBMMMFEDHN = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string PHKFDPNCACJ = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string IFBOFMAAMAN = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string PKHCCNFAHOA = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string IFDEEFGLECM = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string FMJKPJLJLGI = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string JDFCPKFEGHE = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const int EPELMEAHMFD = 10;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> HFCKKLCPBOO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1F27650", Offset = "0x1F26450", VA = "0x181F27650")]
	internal static bool LDEOPAIKCAO(string CKMEBFKEHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public OLNPDEMLGBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface EBEIDEOLGAC
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool LBMKNMCFENK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string PHEKFPDOLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string APHBCAIIIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string IHBBAJEEIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string LFADFBPDOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::KOILDJEEFJD<MFBNHEFGLNE> CACJBFIEGML(string KNJMLANMKCG, Dictionary<string, string> KEGPKEJIILK, bool DBLHPCELAIF = false);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::KOILDJEEFJD<MFBNHEFGLNE> KCAOALJPPOH(string KNJMLANMKCG, string JFKDDPADODL, string PFFPPAJDGNJ, string MAJDIOCGDPB);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MFBNHEFGLNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly int BBIECHECJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string JLDACIONDJN;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xAEAD20", Offset = "0xAE9B20", VA = "0x180AEAD20")]
	public MFBNHEFGLNE(int CAKOADPKJND, string PCKKFHOKFCB)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1F26320", Offset = "0x1F25120", VA = "0x181F26320")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1F25FD0", Offset = "0x1F24DD0", VA = "0x181F25FD0")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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

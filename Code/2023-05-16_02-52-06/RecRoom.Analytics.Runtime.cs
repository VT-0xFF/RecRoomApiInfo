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
		[Cpp2IlInjected.Address(RVA = "0x741B40", Offset = "0x740940", VA = "0x180741B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x66E5E00", Offset = "0x66E4C00", VA = "0x1866E5E00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7DB60", Offset = "0xA7C960", VA = "0x180A7DB60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum HLKOEDKJGEE
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
public class NBGKPEKLOKD
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string APDKHFPOPHN = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string LGFHHCAICHD = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string BDGECADLHAC = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string FGPDKMOGELK = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string AOADICDFPOP = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string LAAPBBADAEA = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string DMGNALJBGAF = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long DGHIENPJMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private DIAMOIOPKGM JGHHEJPFHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool LHMIFHCGENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float GMOOJOCMFGH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66E5C60", Offset = "0x66E4A60", VA = "0x1866E5C60")]
	public NBGKPEKLOKD(string OGMEAGKNBJL, float GMOOJOCMFGH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x34845F0", Offset = "0x34833F0", VA = "0x1834845F0")]
	public void AFILGNNHJDN<T>(string FHINIKPHPFG, T MGFMONLLLPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66E58C0", Offset = "0x66E46C0", VA = "0x1866E58C0")]
	public void AFILGNNHJDN(string FHINIKPHPFG, string MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66E5B70", Offset = "0x66E4970", VA = "0x1866E5B70")]
	public void NFKONIIAAJC(string PIOLBOKAOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66E5990", Offset = "0x66E4790", VA = "0x1866E5990")]
	public void MPANBHCEEMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x66E5A50", Offset = "0x66E4850", VA = "0x1866E5A50")]
	private void MPECIKFPDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66E5940", Offset = "0x66E4740", VA = "0x1866E5940")]
	private bool COLGFIAIAFM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EGOMPDAPKMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PBGELHMIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OIONPPNDOCJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HBIALCOINKJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PONAFBMJJFC PGIHAENGDGO(string JIFFMBCAIKE, string BPFCILNBFMD, [Optional] PGKPKGKFGEN FHEDHFNJONA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PONAFBMJJFC ILECCKELBIP(PGKPKGKFGEN FHEDHFNJONA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PONAFBMJJFC KEKDJHNLFID(PGKPKGKFGEN FHEDHFNJONA, Dictionary<string, string> COHAPBKPCGF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BKKMECEFKKO(string HBFMPBIDNIH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AEOKPAIOCGM PMJKEKIDCAG(string FIJENMMLADA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FBFNMOGJNMI JMKDONACPME(string OBAKCOAGGGF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AEOKPAIOCGM NECEILNBCCE(string IFBNNCOADBI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PONAFBMJJFC MFLMMCLAICF();
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
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x741120", Offset = "0x73FF20", VA = "0x180741120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66E6190", Offset = "0x66E4F90", VA = "0x1866E6190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KDIJPHBJONM : EGOMPDAPKMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string DPDDHHEJPLC = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string JNOPHPOOCDC = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string LBEPLFLMILE = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string DKEBCEPEGFF = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string NEMJDNEDGDA = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string DNIMFOKFFOL = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string JCEDIHEEAOO = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string BCAPEFAEPFA = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string DLEJOPOEBIP = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string OEKIKBAFNFH = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string JAFDELJMIJD = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, FLLELDHONCN> KOEMIBFCNLI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int ICMEHKMEDJC = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool MIEDECLIBGK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PBGELHMIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x745880", Offset = "0x744680", VA = "0x180745880", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action OIONPPNDOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66E44E0", Offset = "0x66E32E0", VA = "0x1866E44E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x66E32A0", Offset = "0x66E20A0", VA = "0x1866E32A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HBIALCOINKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66E3200", Offset = "0x66E2000", VA = "0x1866E3200", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66E33D0", Offset = "0x66E21D0", VA = "0x1866E33D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x66E4580", Offset = "0x66E3380", VA = "0x1866E4580", Slot = "8")]
	public PONAFBMJJFC PGIHAENGDGO(string JIFFMBCAIKE, string BPFCILNBFMD, [Optional] PGKPKGKFGEN FHEDHFNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x66E41D0", Offset = "0x66E2FD0", VA = "0x1866E41D0", Slot = "16")]
	public PONAFBMJJFC MFLMMCLAICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66E3470", Offset = "0x66E2270", VA = "0x1866E3470", Slot = "10")]
	public PONAFBMJJFC ILECCKELBIP(PGKPKGKFGEN FHEDHFNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x66E38F0", Offset = "0x66E26F0", VA = "0x1866E38F0", Slot = "11")]
	public PONAFBMJJFC KEKDJHNLFID(PGKPKGKFGEN FHEDHFNJONA, Dictionary<string, string> COHAPBKPCGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x66E3150", Offset = "0x66E1F50", VA = "0x1866E3150", Slot = "12")]
	public bool BKKMECEFKKO(string HBFMPBIDNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x66E4C70", Offset = "0x66E3A70", VA = "0x1866E4C70", Slot = "13")]
	public AEOKPAIOCGM PMJKEKIDCAG(string FIJENMMLADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x66E3830", Offset = "0x66E2630", VA = "0x1866E3830", Slot = "14")]
	public FBFNMOGJNMI JMKDONACPME(string OBAKCOAGGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x66E43F0", Offset = "0x66E31F0", VA = "0x1866E43F0", Slot = "15")]
	public AEOKPAIOCGM NECEILNBCCE(string IFBNNCOADBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x66E3BE0", Offset = "0x66E29E0", VA = "0x1866E3BE0")]
	private LGODNFDINJJ KJGKMLEFDMD(PGKPKGKFGEN FHEDHFNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x66E3690", Offset = "0x66E2490", VA = "0x1866E3690")]
	private PBOFBFGBOPC JIFEIJBADGJ(string BPFCILNBFMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x66E4A20", Offset = "0x66E3820", VA = "0x1866E4A20")]
	private void PJFGDJGMLGO(string FIJENMMLADA, AEOKPAIOCGM GHGEODFGMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KDIJPHBJONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1355FE0", Offset = "0x1354DE0", VA = "0x181355FE0")]
	[CompilerGenerated]
	private void DNECPOOGJJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x66E4360", Offset = "0x66E3160", VA = "0x1866E4360")]
	[CompilerGenerated]
	private void MPAOFIHHDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x66E3340", Offset = "0x66E2140", VA = "0x1866E3340")]
	[CompilerGenerated]
	private void EEIEOPGKJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HIFHHAIDBED : EGOMPDAPKMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private EGOMPDAPKMJ GOEOPEKKIAL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private EGOMPDAPKMJ MMNMDBKGHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66E1D60", Offset = "0x66E0B60", VA = "0x1866E1D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PBGELHMIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x66E1EE0", Offset = "0x66E0CE0", VA = "0x1866E1EE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action OIONPPNDOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x66E20D0", Offset = "0x66E0ED0", VA = "0x1866E20D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x66E1930", Offset = "0x66E0730", VA = "0x1866E1930", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action HBIALCOINKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x66E1890", Offset = "0x66E0690", VA = "0x1866E1890", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x66E1AC0", Offset = "0x66E08C0", VA = "0x1866E1AC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	[Preserve]
	public HIFHHAIDBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x66E19D0", Offset = "0x66E07D0", VA = "0x1866E19D0")]
	[CFDOMFEMHNO(ANAFFCEINAM.GameOnly)]
	private static void EBMDLNEKODF(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66E2170", Offset = "0x66E0F70", VA = "0x1866E2170", Slot = "8")]
	public PONAFBMJJFC PGIHAENGDGO(string JIFFMBCAIKE, string BPFCILNBFMD, [Optional] PGKPKGKFGEN FHEDHFNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66E1B60", Offset = "0x66E0960", VA = "0x1866E1B60", Slot = "10")]
	public PONAFBMJJFC ILECCKELBIP(PGKPKGKFGEN FHEDHFNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x66E1DD0", Offset = "0x66E0BD0", VA = "0x1866E1DD0", Slot = "11")]
	public PONAFBMJJFC KEKDJHNLFID(PGKPKGKFGEN FHEDHFNJONA, Dictionary<string, string> COHAPBKPCGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66E17F0", Offset = "0x66E05F0", VA = "0x1866E17F0", Slot = "12")]
	public bool BKKMECEFKKO(string HBFMPBIDNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66E2450", Offset = "0x66E1250", VA = "0x1866E2450", Slot = "13")]
	public AEOKPAIOCGM PMJKEKIDCAG(string FIJENMMLADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x66E1C60", Offset = "0x66E0A60", VA = "0x1866E1C60", Slot = "14")]
	public FBFNMOGJNMI JMKDONACPME(string OBAKCOAGGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x66E2030", Offset = "0x66E0E30", VA = "0x1866E2030", Slot = "15")]
	public AEOKPAIOCGM NECEILNBCCE(string IFBNNCOADBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x66E1F30", Offset = "0x66E0D30", VA = "0x1866E1F30", Slot = "16")]
	public PONAFBMJJFC MFLMMCLAICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xFBC0C0", Offset = "0xFBAEC0", VA = "0x180FBC0C0")]
	[CompilerGenerated]
	private void EPKIAMEGMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x12C16E0", Offset = "0x12C04E0", VA = "0x1812C16E0")]
	[CompilerGenerated]
	private void JEFDGCGHHGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ANEJKAHJNFA : EGOMPDAPKMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PBGELHMIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action OIONPPNDOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x66D8230", Offset = "0x66D7030", VA = "0x1866D8230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x66D7EF0", Offset = "0x66D6CF0", VA = "0x1866D7EF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action HBIALCOINKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x66D7E50", Offset = "0x66D6C50", VA = "0x1866D7E50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x66D7F90", Offset = "0x66D6D90", VA = "0x1866D7F90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x66D82D0", Offset = "0x66D70D0", VA = "0x1866D82D0", Slot = "8")]
	public PONAFBMJJFC PGIHAENGDGO(string JIFFMBCAIKE, string BPFCILNBFMD, [Optional] PGKPKGKFGEN FHEDHFNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x66D8030", Offset = "0x66D6E30", VA = "0x1866D8030", Slot = "10")]
	public PONAFBMJJFC ILECCKELBIP(PGKPKGKFGEN FHEDHFNJONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x66D80E0", Offset = "0x66D6EE0", VA = "0x1866D80E0", Slot = "11")]
	public PONAFBMJJFC KEKDJHNLFID(PGKPKGKFGEN FHEDHFNJONA, Dictionary<string, string> COHAPBKPCGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "12")]
	public bool BKKMECEFKKO(string HBFMPBIDNIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x66D8220", Offset = "0x66D7020", VA = "0x1866D8220", Slot = "13")]
	public AEOKPAIOCGM PMJKEKIDCAG(string FIJENMMLADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x66D80D0", Offset = "0x66D6ED0", VA = "0x1866D80D0", Slot = "14")]
	public FBFNMOGJNMI JMKDONACPME(string OBAKCOAGGGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x66D8220", Offset = "0x66D7020", VA = "0x1866D8220", Slot = "15")]
	public AEOKPAIOCGM NECEILNBCCE(string IFBNNCOADBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x66D8180", Offset = "0x66D6F80", VA = "0x1866D8180", Slot = "16")]
	public PONAFBMJJFC MFLMMCLAICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public ANEJKAHJNFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BKHKEOGCBFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBGKPEKLOKD BBCBGBBAFHB(string OGMEAGKNBJL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EFNFILKIPAM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	long POMKGCKNMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	long EMDPPGBIHIK();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLELGLHDPIF(long GCAPDAABBOJ, bool APCPIANMKLN = true);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDHGEDNIOPJ(string IJBJKIBEJLN, string CNCKAJNNOGP, string FCNGFKBGDGL);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBOLNJCFDKB(string IJBJKIBEJLN);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEAJPOECDBM(string IJBJKIBEJLN, string KDGKBFGNPJG, string HBNNBGMIFAC);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPLPJBMPFHB(string FPIGGFIFINB, object MELOABKKIKC, object HEFFPFIJPGL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PGKPKGKFGEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NCEKBPMMFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool AAANBHGLKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FBPAOLOIFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KNKNAOEGOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool? IIFPPAMJKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int? ICBKPDEACNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int PCGNJIKMHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string LPCJKOELADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string ICBFFJJNNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string JMLGEJPNOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string OHECDBMFAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string NMOPDEKJHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string HFJMPOJCCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	double AKHAINENGIL
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
		public AmplitudeAnalyticsClient.Settings FDGFPJFDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool OPJEDCMMILI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B360", VA = "0x18075C560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private enum IGCPNBFNGOP
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal class HFIJNLEJEDC
		{
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private class MJEKGPDGILP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public int DOONEHLKOFP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public Dictionary<string, object> FLFOEKGMDPL;

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
				public MJEKGPDGILP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class PIHKOJACDMA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
				public PIHKOJACDMA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x66E5FC0", Offset = "0x66E4DC0", VA = "0x1866E5FC0")]
				internal bool <GetBatch>b__0(MJEKGPDGILP item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private const string ELIPFPKFAJF = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly string DIHIPMILEPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<MJEKGPDGILP> AHFFECILFGI;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? NHEGGNNHAGK
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x66E1410", Offset = "0x66E0210", VA = "0x1866E1410")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public int? FDPFAIEJFEJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000AD")]
				[Cpp2IlInjected.Address(RVA = "0x66E10E0", Offset = "0x66DFEE0", VA = "0x1866E10E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x66E1660", Offset = "0x66E0460", VA = "0x1866E1660")]
			internal HFIJNLEJEDC(string NOOPBAHBFNG, string BPFCILNBFMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x66E07D0", Offset = "0x66DF5D0", VA = "0x1866E07D0")]
			public int GFBANGBLDDP([Optional] int? JIFKMDEMPBI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x66E01C0", Offset = "0x66DEFC0", VA = "0x1866E01C0")]
			public List<Dictionary<string, object>> BELLIGAJDDA(int NNHPIABJONH, int? JIFKMDEMPBI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x66E14B0", Offset = "0x66E02B0", VA = "0x1866E14B0")]
			public void NFPBNKOCEBF(AmplitudeAnalyticsIdentifyMessage OJGAEOFIMPK, bool KEEHLMLCODM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x66E1550", Offset = "0x66E0350", VA = "0x1866E1550")]
			public void NFPBNKOCEBF(Dictionary<string, object> OJGAEOFIMPK, bool KEEHLMLCODM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x66E0F50", Offset = "0x66DFD50", VA = "0x1866E0F50")]
			public void JBDNBHLHOON(params Dictionary<string, object>[] GFAAJGOONNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x66E0580", Offset = "0x66DF380", VA = "0x1866E0580")]
			public void GEMNPIKBHOI(List<Dictionary<string, object>> FIHDEIEGAMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x66E0960", Offset = "0x66DF760", VA = "0x1866E0960")]
			private void GGAMNPILEFK(Dictionary<string, object> OJGAEOFIMPK, bool KEEHLMLCODM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x66E11A0", Offset = "0x66DFFA0", VA = "0x1866E11A0")]
			public void LDOEGMJJOLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x66E0AA0", Offset = "0x66DF8A0", VA = "0x1866E0AA0")]
			private void HHBHOMELPHO([Optional] string DGNEBPIKCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x66E0450", Offset = "0x66DF250", VA = "0x1866E0450")]
			private static string EOBJKDBLNJP(string MGFMONLLLPD, string JHANOPJHOLP)
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
			[Cpp2IlInjected.Address(RVA = "0x66E63E0", Offset = "0x66E51E0", VA = "0x1866E63E0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct LIACPHKFELP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int MALOCJKCLDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string BNMFCCOOKPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T NECJOKAMEGM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class JMGEMCEAJGN : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private OLKFKAFMJCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public JMGEMCEAJGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x66E24F0", Offset = "0x66E12F0", VA = "0x1866E24F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x66E2AE0", Offset = "0x66E18E0", VA = "0x1866E2AE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ONFFHLGCNNB : IEnumerator<object>, IEnumerator, IDisposable
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
			public OOJANPILAPP quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public ONFFHLGCNNB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x66E5E90", Offset = "0x66E4C90", VA = "0x1866E5E90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x66E5F80", Offset = "0x66E4D80", VA = "0x1866E5F80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class FCINNHNLDFO : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public FCINNHNLDFO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x66DFE60", Offset = "0x66DEC60", VA = "0x1866DFE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x66DFFD0", Offset = "0x66DEDD0", VA = "0x1866DFFD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class BAKJEPCEDNI : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private OLKFKAFMJCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public BAKJEPCEDNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x66DE970", Offset = "0x66DD770", VA = "0x1866DE970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x66DEC10", Offset = "0x66DDA10", VA = "0x1866DEC10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ADOAHMMDDDM : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private OLKFKAFMJCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public ADOAHMMDDDM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x66D7B70", Offset = "0x66D6970", VA = "0x1866D7B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x66D7E10", Offset = "0x66D6C10", VA = "0x1866D7E10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DKFNEJHBLNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public HFIJNLEJEDC cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public DKFNEJHBLNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x66DF4D0", Offset = "0x66DE2D0", VA = "0x1866DF4D0")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x66DF840", Offset = "0x66DE640", VA = "0x1866DF840")]
			internal void <FlushFromCache>b__1(LIACPHKFELP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MIPGFKMNMFC : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private OLKFKAFMJCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public HFIJNLEJEDC cache;

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
			private DKFNEJHBLNP <>8__1;

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
			private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public MIPGFKMNMFC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x66E4FB0", Offset = "0x66E3DB0", VA = "0x1866E4FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x66E5880", Offset = "0x66E4680", VA = "0x1866E5880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class AKJEPDNMNCP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
			public AKJEPDNMNCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x24E4A90", Offset = "0x24E3890", VA = "0x1824E4A90")]
			internal LIACPHKFELP<T> <PostRudderStackJson>b__0(IBNECGDBFLM postResponse)
			{
				return default(LIACPHKFELP<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class PBFLBAFBHAA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
			public PBFLBAFBHAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x24E4A90", Offset = "0x24E3890", VA = "0x1824E4A90")]
			internal LIACPHKFELP<T> <PostAmplitudeJson>b__0(IBNECGDBFLM postResponse)
			{
				return default(LIACPHKFELP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private BBALOPFJECE FFLOPMDLOMP;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string OBFGGKOLFEM = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string FFNNKCMBPDF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string MGLKMPKEIIE = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int PGFPLBOBMNP = 15;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int EOHFFHHPFFI = 10;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int INMPNNLKMEA = 5;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const float DGFKGKMJGDI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const long BCJAGGOLDMC = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string MAFHLNALDPI = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private const string KACJDELPEPO = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static bool EJEFNGDJAGA;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static bool OBPKDPOBNAE;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static int DFEFMIHHLCB;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static int LIPLFFGMNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private DBLEEIHGGIG CMOEELDNIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool PNLHHEGKJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float FBONNHBFIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private float PFPAMKKNCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int DOHAJCHJOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int APJDBLAJIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int? LFFBJCLPCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int? BECJLLKKKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long NJBDOLPGLAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private string LLMJIMKAOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private long KIDLHOJOOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Dictionary<string, object> COCKOBKEIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private IGCPNBFNGOP NENBGBCPGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int IAIAGHABFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int EJKNCAPDFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float BFLOHBLELFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool DNIEFIJKMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool HOIDKFBIEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private HFIJNLEJEDC FHBCAAIIBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private HFIJNLEJEDC KKLMEAJLNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private HFIJNLEJEDC HOPNAMBFFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> GLJAEPOAAHD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PLLPJACOGEP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static string PLJFFLPEILH;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string JIDPDDCOHHN = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string FLGJNJMNMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly string JDFDCJBEMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string NKOJEEAPCLN;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private BBALOPFJECE GEBJBFIJHFN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x66DAE30", Offset = "0x66D9C30", VA = "0x1866DAE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private static int MAGPICPHPLO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x66D9450", Offset = "0x66D8250", VA = "0x1866D9450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static long NHOCILJDDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x66DD330", Offset = "0x66DC130", VA = "0x1866DD330")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x66DD430", Offset = "0x66DC230", VA = "0x1866DD430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string MAACHDDIMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x66DD2D0", Offset = "0x66DC0D0", VA = "0x1866DD2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static string MOOFGDFLABL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x66DD300", Offset = "0x66DC100", VA = "0x1866DD300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string PLNJNDMKPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7578D0", Offset = "0x7566D0", VA = "0x1807578D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x778F50", Offset = "0x777D50", VA = "0x180778F50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int? ICBKPDEACNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x872940", Offset = "0x871740", VA = "0x180872940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1A83C50", Offset = "0x1A82A50", VA = "0x181A83C50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool HGKMKOBNLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8BB910", Offset = "0x8BA710", VA = "0x1808BB910")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8BBA10", Offset = "0x8BA810", VA = "0x1808BBA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static bool LKENMHONAIC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x66DD1E0", Offset = "0x66DBFE0", VA = "0x1866DD1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> HOIDDLJEPAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x66DD140", Offset = "0x66DBF40", VA = "0x1866DD140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x66DD390", Offset = "0x66DC190", VA = "0x1866DD390")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66D8510", Offset = "0x66D7310", VA = "0x1866D8510", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x66DB940", Offset = "0x66DA740", VA = "0x1866DB940")]
		private void MBCNGEKPBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66DC990", Offset = "0x66DB790", VA = "0x1866DC990")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x66DBF50", Offset = "0x66DAD50", VA = "0x1866DBF50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x66DCC80", Offset = "0x66DBA80", VA = "0x1866DCC80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x66DBFF0", Offset = "0x66DADF0", VA = "0x1866DBFF0")]
		public PONAFBMJJFC PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x66DA710", Offset = "0x66D9510", VA = "0x1866DA710")]
		[IteratorStateMachine(typeof(JMGEMCEAJGN))]
		public IEnumerator<OLKFKAFMJCO> Initialize(AmplitudeAnalyticsEvent AIOOJCGGPBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x66DCB70", Offset = "0x66DB970", VA = "0x1866DCB70")]
		public void UpdateLastAliveTime(float MCDLNHCIIJC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x66DBC60", Offset = "0x66DAA60", VA = "0x1866DBC60")]
		private PONAFBMJJFC NIPJBNOJBHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x66DAEA0", Offset = "0x66D9CA0", VA = "0x1866DAEA0")]
		private PONAFBMJJFC LOAIFFLIFGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x66DC540", Offset = "0x66DB340", VA = "0x1866DC540")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x66DACC0", Offset = "0x66D9AC0", VA = "0x1866DACC0")]
		[IteratorStateMachine(typeof(ONFFHLGCNNB))]
		private IEnumerator LFNJBLEKHPJ(OOJANPILAPP JEHPNKJBMAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x66DCEF0", Offset = "0x66DBCF0", VA = "0x1866DCEF0")]
		[IteratorStateMachine(typeof(FCINNHNLDFO))]
		public IEnumerator WaitForFlush(float OIPLOFODGGB = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x66DCA50", Offset = "0x66DB850", VA = "0x1866DCA50")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x66DC9A0", Offset = "0x66DB7A0", VA = "0x1866DC9A0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime FMJGBJAJLDN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x66DA360", Offset = "0x66D9160", VA = "0x1866DA360")]
		public static MGOAPECHJAL Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x66D8370", Offset = "0x66D7170", VA = "0x1866D8370")]
		public static DIAMOIOPKGM AccountSelectionPostLoginEvent([NotNull] string KMDPEBKOIAM, string BOHOPGEADIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x66D9130", Offset = "0x66D7F30", VA = "0x1866D9130")]
		public static DIAMOIOPKGM Event([NotNull] string KMDPEBKOIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x66DC050", Offset = "0x66DAE50", VA = "0x1866DC050")]
		public static DIAMOIOPKGM PreviousSessionEvent([NotNull] string KMDPEBKOIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66DA4C0", Offset = "0x66D92C0", VA = "0x1866DA4C0")]
		public static DIAMOIOPKGM InitializeEvent(string BOHOPGEADIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66DC6A0", Offset = "0x66DB4A0", VA = "0x1866DC6A0")]
		public static DIAMOIOPKGM StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66D89E0", Offset = "0x66D77E0", VA = "0x1866D89E0")]
		public static DIAMOIOPKGM CreateOutOfSessionEvent(string KMDPEBKOIAM, bool IJBEOBEJLDG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66DB400", Offset = "0x66DA200", VA = "0x1866DB400")]
		public static PONAFBMJJFC LogOutOfSessionEvent(DIAMOIOPKGM NHMDGBONODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66DB140", Offset = "0x66D9F40", VA = "0x1866DB140")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MMKIDNMDJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66DB710", Offset = "0x66DA510", VA = "0x1866DB710")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MMKIDNMDJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66DB860", Offset = "0x66DA660", VA = "0x1866DB860")]
		public void LogSerializedEventAsync(Dictionary<string, object> HDICAFPAOFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x66DB290", Offset = "0x66DA090", VA = "0x1866DB290")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GNAGEMAAHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x66DBD80", Offset = "0x66DAB80", VA = "0x1866DBD80")]
		private void OCEHNJLHFHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66D8CC0", Offset = "0x66D7AC0", VA = "0x1866D8CC0")]
		private void DCONFJHMKML(Dictionary<string, object> LOGNMBNKGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66DBE60", Offset = "0x66DAC60", VA = "0x1866DBE60")]
		private void OPLLJCHNJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x66D8F50", Offset = "0x66D7D50", VA = "0x1866D8F50")]
		private void DIHABKCBMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66D9340", Offset = "0x66D8140", VA = "0x1866D9340")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x66D93D0", Offset = "0x66D81D0", VA = "0x1866D93D0")]
		[IteratorStateMachine(typeof(BAKJEPCEDNI))]
		private IEnumerator<OLKFKAFMJCO> GBEKIBOICJN(float OIPLOFODGGB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x66D8960", Offset = "0x66D7760", VA = "0x1866D8960")]
		[IteratorStateMachine(typeof(ADOAHMMDDDM))]
		private IEnumerator<OLKFKAFMJCO> CAAODBCHLIG(float OIPLOFODGGB = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x66DAD50", Offset = "0x66D9B50", VA = "0x1866DAD50")]
		[IteratorStateMachine(typeof(MIPGFKMNMFC))]
		private IEnumerator<OLKFKAFMJCO> LILJEEPJMLD(HFIJNLEJEDC DPNMFCPMEOO, int? JIFKMDEMPBI, string PJJMOGBAPGK, string GGDNNAMAGBM, float OIPLOFODGGB, Action<int> KKPFHMKCDDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x66DABA0", Offset = "0x66D99A0", VA = "0x1866DABA0")]
		private static void LCFOHAGDAHH(bool FBODCJFMAAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x66DA7A0", Offset = "0x66D95A0", VA = "0x1866DA7A0")]
		private global::OOLBMJPBBIG<LIACPHKFELP<Dictionary<string, object>>> JEKJGFLKBPP(string PJJMOGBAPGK, string GGDNNAMAGBM, string HEDIHCGCDMN, string HCIJAJNACEN, Dictionary<string, object> NECJOKAMEGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x66DA8D0", Offset = "0x66D96D0", VA = "0x1866DA8D0")]
		private global::OOLBMJPBBIG<LIACPHKFELP<List<Dictionary<string, object>>>> JEKJGFLKBPP(string PJJMOGBAPGK, string GGDNNAMAGBM, string HEDIHCGCDMN, string HCIJAJNACEN, List<Dictionary<string, object>> NECJOKAMEGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x230CDD0", Offset = "0x230BBD0", VA = "0x18230CDD0")]
		private global::OOLBMJPBBIG<LIACPHKFELP<T>> GIEBFKKNOEE<T>(string PJJMOGBAPGK, string GGDNNAMAGBM, string HCIJAJNACEN, T NECJOKAMEGM, Dictionary<string, object> AECALANEABB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x230D060", Offset = "0x230BE60", VA = "0x18230D060")]
		private global::OOLBMJPBBIG<LIACPHKFELP<T>> NFBDHFFDKIN<T>(string PJJMOGBAPGK, string GGDNNAMAGBM, string HEDIHCGCDMN, T NECJOKAMEGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x66DBD30", Offset = "0x66DAB30", VA = "0x1866DBD30")]
		private bool NNMGDFACBPE(float OFBGFAMJLFM, float OIPLOFODGGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x66D9620", Offset = "0x66D8420", VA = "0x1866D9620")]
		private Dictionary<string, object> IALPAEDMDMG(string GGDNNAMAGBM, Dictionary<string, object> NECJOKAMEGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x66DCFD0", Offset = "0x66DBDD0", VA = "0x1866DCFD0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x66D8800", Offset = "0x66D7600", VA = "0x1866D8800")]
		[CompilerGenerated]
		private long BAEIIBNCDKI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x66D9330", Offset = "0x66D8130", VA = "0x1866D9330")]
		[CompilerGenerated]
		private void FOLLPENPIAF(int INPOLFHEDAH)
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
			[Cpp2IlInjected.Address(RVA = "0x66DE090", Offset = "0x66DCE90", VA = "0x1866DE090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x66DE150", Offset = "0x66DCF50", VA = "0x1866DE150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x66DE0F0", Offset = "0x66DCEF0", VA = "0x1866DE0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x66DE1C0", Offset = "0x66DCFC0", VA = "0x1866DE1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x757910", Offset = "0x756710", VA = "0x180757910")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x66DD490", Offset = "0x66DC290", VA = "0x1866DD490")]
		public static DIAMOIOPKGM CJALKNOJAHB(string HHCMOLFBCEB, [NotNull] string LFFGDPPFNAC, long GCAPDAABBOJ, long KOCPCNPPBMH, string BOHOPGEADIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x66DD580", Offset = "0x66DC380", VA = "0x1866DD580")]
		public static DIAMOIOPKGM FOAMPMFJFNC(string HHCMOLFBCEB, [NotNull] string LFFGDPPFNAC, long GCAPDAABBOJ, long KOCPCNPPBMH, string BOHOPGEADIM, long OPPGDCENAEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x66DDED0", Offset = "0x66DCCD0", VA = "0x1866DDED0")]
		private AmplitudeAnalyticsEvent(string HHCMOLFBCEB, [NotNull] string LFFGDPPFNAC, long GCAPDAABBOJ, long KOCPCNPPBMH, string BOHOPGEADIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xB4FE40", Offset = "0xB4EC40", VA = "0x180B4FE40")]
		public void MEMPGCJGOFM(long MBKDMNHHCNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x66DDDB0", Offset = "0x66DCBB0", VA = "0x1866DDDB0", Slot = "5")]
		public override void LDAHMLIEFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x66DD680", Offset = "0x66DC480", VA = "0x1866DD680", Slot = "6")]
		public override void IJNPHNCEPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x66DD830", Offset = "0x66DC630", VA = "0x1866DD830", Slot = "4")]
		protected override Dictionary<string, object> JPCBDGGEJLA(Dictionary<string, object> KPDLEAGFCHD)
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
			[Cpp2IlInjected.Address(RVA = "0x66DFCE0", Offset = "0x66DEAE0", VA = "0x1866DFCE0")]
			public void PABMNNPHNNI(Dictionary<string, object> NKAGKHCHPEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x66E6020", Offset = "0x66E4E20", VA = "0x1866E6020")]
			public void PABMNNPHNNI(Dictionary<string, object> NMNPHPJGJKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x15D6660", Offset = "0x15D5460", VA = "0x1815D6660")]
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
			[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7612C0", Offset = "0x7600C0", VA = "0x1807612C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x66DE2A0", Offset = "0x66DD0A0", VA = "0x1866DE2A0")]
		public static MGOAPECHJAL CJALKNOJAHB(string HHCMOLFBCEB, string BOHOPGEADIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x66DE8B0", Offset = "0x66DD6B0", VA = "0x1866DE8B0")]
		protected AmplitudeAnalyticsIdentifyMessage(string HHCMOLFBCEB, string BOHOPGEADIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x66DE3F0", Offset = "0x66DD1F0", VA = "0x1866DE3F0")]
		public Dictionary<string, object> HOLNLKDNFNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x66DE4F0", Offset = "0x66DD2F0", VA = "0x1866DE4F0", Slot = "4")]
		protected virtual Dictionary<string, object> JPCBDGGEJLA(Dictionary<string, object> KPDLEAGFCHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x66DE350", Offset = "0x66DD150", VA = "0x1866DE350")]
		protected void DKDJOMGPAMG(string JHANOPJHOLP, Dictionary<string, object> CIHEDHGMFMA, Dictionary<string, object> LEGOBELDMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x66DE230", Offset = "0x66DD030", VA = "0x1866DE230")]
		protected void BIDABNJPJCP(string JHANOPJHOLP, string MGFMONLLLPD, Dictionary<string, object> MIPMPMPNMGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66DE830", Offset = "0x66DD630", VA = "0x1866DE830", Slot = "5")]
		public virtual void LDAHMLIEFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x66DE470", Offset = "0x66DD270", VA = "0x1866DE470", Slot = "6")]
		public virtual void IJNPHNCEPDL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MGOAPECHJAL : global::FCFCLADLBAG<AmplitudeAnalyticsIdentifyMessage, MGOAPECHJAL>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override MGOAPECHJAL AKGJLNOHOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage FIHNDLMJEAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x66E4F60", Offset = "0x66E3D60", VA = "0x1866E4F60")]
	public MGOAPECHJAL(AmplitudeAnalyticsIdentifyMessage GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x66E4EC0", Offset = "0x66E3CC0", VA = "0x1866E4EC0", Slot = "4")]
	public override void IJNPHNCEPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DIAMOIOPKGM : global::FCFCLADLBAG<AmplitudeAnalyticsEvent, DIAMOIOPKGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private bool EJICJKKBJDB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public override DIAMOIOPKGM AKGJLNOHOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C69F0", Offset = "0x7C57F0", VA = "0x1807C69F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public long BOFILBODOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x39B8BA0", Offset = "0x39B79A0", VA = "0x1839B8BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x66DEE10", Offset = "0x66DDC10", VA = "0x1866DEE10")]
	public DIAMOIOPKGM(AmplitudeAnalyticsEvent GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x741AC0", Offset = "0x7408C0", VA = "0x180741AC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent FIHNDLMJEAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x66DF430", Offset = "0x66DE230", VA = "0x1866DF430", Slot = "4")]
	public override void IJNPHNCEPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x66DEE70", Offset = "0x66DDC70", VA = "0x1866DEE70")]
	public DIAMOIOPKGM AFILGNNHJDN(string FHINIKPHPFG, long[] MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x66DF0B0", Offset = "0x66DDEB0", VA = "0x1866DF0B0")]
	public DIAMOIOPKGM AFILGNNHJDN(string FHINIKPHPFG, ulong[] MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x209A5F0", Offset = "0x20993F0", VA = "0x18209A5F0")]
	public DIAMOIOPKGM AFILGNNHJDN<T>(string FHINIKPHPFG, T[] MGFMONLLLPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x66DEE60", Offset = "0x66DDC60", VA = "0x1866DEE60")]
	public DIAMOIOPKGM AFILGNNHJDN(string FHINIKPHPFG, string[] MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x209A580", Offset = "0x2099380", VA = "0x18209A580")]
	public DIAMOIOPKGM AFILGNNHJDN<T>(string FHINIKPHPFG, T MGFMONLLLPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x66DEFB0", Offset = "0x66DDDB0", VA = "0x1866DEFB0")]
	public DIAMOIOPKGM AFILGNNHJDN(string FHINIKPHPFG, long MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x66DF1F0", Offset = "0x66DDFF0", VA = "0x1866DF1F0")]
	public DIAMOIOPKGM AFILGNNHJDN(string FHINIKPHPFG, ulong MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x66DF040", Offset = "0x66DDE40", VA = "0x1866DF040")]
	public DIAMOIOPKGM AFILGNNHJDN(string FHINIKPHPFG, string MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x66DF410", Offset = "0x66DE210", VA = "0x1866DF410")]
	public DIAMOIOPKGM HMHLFCGBAMC(string FHINIKPHPFG, object? MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x66DF280", Offset = "0x66DE080", VA = "0x1866DF280")]
	public DIAMOIOPKGM EPEEAMLBAFJ(string FHINIKPHPFG, string MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x66DF320", Offset = "0x66DE120", VA = "0x1866DF320")]
	private DIAMOIOPKGM GPLAPFFDONE(string FHINIKPHPFG, object MGFMONLLLPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CBPOGGNMDOA : DIAMOIOPKGM
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x66DEE10", Offset = "0x66DDC10", VA = "0x1866DEE10")]
	public CBPOGGNMDOA(AmplitudeAnalyticsEvent GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x66DEC50", Offset = "0x66DDA50", VA = "0x1866DEC50", Slot = "4")]
	public override void IJNPHNCEPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class FCFCLADLBAG<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::FCFCLADLBAG<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected M GPAOLHFLBHD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public abstract BLDR AKGJLNOHOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1050770", Offset = "0x104F570", VA = "0x181050770")]
	public FCFCLADLBAG(M GPAOLHFLBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2A53B50", Offset = "0x2A52950", VA = "0x182A53B50")]
	public BLDR MDHIBGMBLIN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NFJCOFNCBLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2A53A20", Offset = "0x2A52820", VA = "0x182A53A20")]
	public BLDR KOIIKOHFGGK(AmplitudeAnalyticsIdentifyMessage.RevenueData GJLBBGCEKIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2A53900", Offset = "0x2A52700", VA = "0x182A53900")]
	public BLDR GIHKFPODDDK(string FHINIKPHPFG, string MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DB10", Offset = "0x2C7C910", VA = "0x182C7DB10")]
	public BLDR GIHKFPODDDK<T>(string FHINIKPHPFG, T MGFMONLLLPD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2A53850", Offset = "0x2A52650", VA = "0x182A53850")]
	public BLDR GIHKFPODDDK(string FHINIKPHPFG, long MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2A53970", Offset = "0x2A52770", VA = "0x182A53970")]
	public BLDR GIHKFPODDDK(string FHINIKPHPFG, ulong MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IJNPHNCEPDL();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A53820", Offset = "0x2A52620", VA = "0x182A53820")]
	internal static string DPFDIHAIGGO(string MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2A53A60", Offset = "0x2A52860", VA = "0x182A53A60")]
	private BLDR MAMBLPHPOPK(string FHINIKPHPFG, object MGFMONLLLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M FIHNDLMJEAD();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BDBLLHHIEHC
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string GKPNKKEHFBF = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string GPFMBKPOJJB = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string MEIOHAKANCC = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string MMCENIHIGCF = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string JDHJKFIHCEP = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string LLBNFDDHOBA = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string EGIFCMOMEIJ = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string FFOBJCHCEOO = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string ENNHKBOPBFG = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string EOJFDIAIAIN = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string ABCINBMAFGN = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string IMAOFAJHLAA = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string GJCMEBPMPIL = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string GBPCFNIECFE = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string JCJEBHJDAMI = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string EHGLMNJCFBD = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string EPINIIHJDHJ = "os";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string PBHOEBKHKNM = "device";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string EMBDJLMEIJN = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string NLEEKCKJJHB = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string OKGDKOFBHON = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const string GGFLHOOFNIN = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const string CBADLDOOKIO = "type";

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public BDBLLHHIEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FOAJGNNLNOJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int OBNDPDNALGN = 2;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const int NJEDJAIGPKB = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int LOILLFFHDOJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const long GICFOBHFFEG = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const int EGBKMHELBOB = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const int COHLIMHJGJH = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string JCOPLNEIHOI = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string JLNFAGFBHMM = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string GEBOHKIEHBN = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string OOAPPLEBOPP = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string FPEKDKBMLDH = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string DPPDDCIBLDB = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string HEIMDJLLJHG = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string ANAEGCFFBML = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string CKEHIBAGJHL = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string DICFHNGPCED = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string INFMJEPKDDK = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string NGBAPLEIOIM = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string DGLFHBEFBCF = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string BGJHPLPOGMH = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string EGIFCMOMEIJ = "stable_id";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string HBOPMMKINNI = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string BPJNGGEEJOI = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string PGLKCMDIAPO = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string MFENPJBABHH = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string GEFNNNMIHCH = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string KPNBNAGPGIH = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string OIEMDHCCLON = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string DLKMKCMIKGB = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string OECAMGIKEOK = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string CIDFKEANMGM = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string NDNCFFCEMEC = "productId";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string FAAHPPAAOFC = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const string ADFMEGNHKEG = "event_type";

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public const string JDHJKFIHCEP = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public const string GBKKDCJPLBH = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public const int IMHMKBKIIAN = 10;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> OEKGENLICOP;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x66E0010", Offset = "0x66DEE10", VA = "0x1866E0010")]
	internal static bool NCFJLCEEHMM(string JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public FOAJGNNLNOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DBLEEIHGGIG
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool NMLLJABGKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string CKOBNAHEOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string GCFFILPOGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string CIPMDDJEPAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string MIOIGOBLAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::OOLBMJPBBIG<IBNECGDBFLM> JEKJGFLKBPP(string PJJMOGBAPGK, Dictionary<string, string> ENHCMFPKFEC, bool MCOOHKGPILN = false);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::OOLBMJPBBIG<IBNECGDBFLM> FFEIJIKJPGA(string PJJMOGBAPGK, string CEMFCIFJBHO, string IJOHHBKOLJF, string JDEOCOIKJKB);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct IBNECGDBFLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly int IIKEMDDEJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly string IGIHIMGPODP;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x76C240", Offset = "0x76B040", VA = "0x18076C240")]
	public IBNECGDBFLM(int MALOCJKCLDN, string BNMFCCOOKPF)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x66E2E70", Offset = "0x66E1C70", VA = "0x1866E2E70")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x66E2B20", Offset = "0x66E1920", VA = "0x1866E2B20")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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

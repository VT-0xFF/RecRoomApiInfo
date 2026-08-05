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
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62995A0", Offset = "0x62985A0", VA = "0x1862995A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FA6F0", Offset = "0x6F96F0", VA = "0x1806FA6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x929620", Offset = "0x928620", VA = "0x180929620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KDFEOMINAGH
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
public class NFIDGPANHEB
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private const string LEEAFPLIDKL = "timed_flow";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private const string ODNNPDIALDN = "flowName";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const string IPOJNJOOHFB = "startedAt";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private const string OHLGOHGJJOG = "endedAt";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const string DEJAMNKLDBF = "durationInSeconds";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const string HAGFFONFEGC = "failure";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const string JHJJBCNPHAA = "failureMessage";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long NJKBGMKCOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IEGHJCIAJCN JNONGKNPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool JCFMBKJAOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private float MMHBLDHDAIK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6299400", Offset = "0x6298400", VA = "0x186299400")]
	public NFIDGPANHEB(string EOPKCKAAGKI, float MMHBLDHDAIK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2610980", Offset = "0x260F980", VA = "0x182610980")]
	public void GLKICEEPKDG<T>(string MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6299270", Offset = "0x6298270", VA = "0x186299270")]
	public void GLKICEEPKDG(string MLIELKFMALM, string KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6299180", Offset = "0x6298180", VA = "0x186299180")]
	public void COFNKDHFKIO(string BHDGMHBDDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62992F0", Offset = "0x62982F0", VA = "0x1862992F0")]
	public void KBGCMFNGGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6299060", Offset = "0x6298060", VA = "0x186299060")]
	private void CMEFOKBKHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62993B0", Offset = "0x62983B0", VA = "0x1862993B0")]
	private bool PJGDBPABABD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HHKOBIOAJAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LCLDHDEMAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FKFANDDHIJD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action HPEDCNEDFNM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LLEFGLIPMKI JHHOMPLGCBC(string EDFCANILEGA, string GHJMMHFPFLD, [Optional] BMKBKKKFPGM LLNDGAJEMEN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LLEFGLIPMKI JGMOMHJLLCJ(BMKBKKKFPGM LLNDGAJEMEN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LLEFGLIPMKI LMOHIJMFKBH(BMKBKKKFPGM LLNDGAJEMEN, Dictionary<string, string> DIIDCLKBADN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PCCNMJCBOCA(string CLGHJEOCFAD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GBFBAIMMGEP PLGLEDMAMOA(string GABKMFALOME);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CEEDGCKJFLK HKAOGPHEIDF(string PEFGAGJLFOE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GBFBAIMMGEP AKOOFJLDGFA(string GLJMNMKNGFK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LLEFGLIPMKI PKGIJLCJAMH();
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
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x629A010", Offset = "0x6299010", VA = "0x18629A010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HBEMOMALKKM : HHKOBIOAJAE
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private const string JOENJIDKOID = "GamePlatform";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const string DJOMKLCHJDN = "InteractionCategory";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const string JJOOJHMKFHJ = "JrActType";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private const string KKLFAIKBHIB = "IsDeveloper";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const string DHKPBGFCIDO = "IsModerator";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string KOCGAKLPHLJ = "IsMember";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const string NBGFNBBDADD = "DaysSinceJoiningBucket";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string CCEOIHMHFBM = "AccountCreationTimeAfterEpochMilliseconds";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const string MMDLBIKCBJD = "InGoodStanding";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const string NPIPLKALCND = "FriendCount";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const string CJLJGJGHKCJ = "LocaleName";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly IReadOnlyDictionary<string, PALMIDKPIOM> HMELAMOIELO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int JAFBFKDFBGH = 5000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool OKGDHNHAOEL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LCLDHDEMAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E3250", Offset = "0x6E2250", VA = "0x1806E3250", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FKFANDDHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6295B20", Offset = "0x6294B20", VA = "0x186295B20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6295240", Offset = "0x6294240", VA = "0x186295240", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action HPEDCNEDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6296570", Offset = "0x6295570", VA = "0x186296570", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62951A0", Offset = "0x62941A0", VA = "0x1862951A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6295EA0", Offset = "0x6294EA0", VA = "0x186295EA0", Slot = "8")]
	public LLEFGLIPMKI JHHOMPLGCBC(string EDFCANILEGA, string GHJMMHFPFLD, [Optional] BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6296A40", Offset = "0x6295A40", VA = "0x186296A40", Slot = "16")]
	public LLEFGLIPMKI PKGIJLCJAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6295C80", Offset = "0x6294C80", VA = "0x186295C80", Slot = "10")]
	public LLEFGLIPMKI JGMOMHJLLCJ(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6296610", Offset = "0x6295610", VA = "0x186296610", Slot = "11")]
	public LLEFGLIPMKI LMOHIJMFKBH(BMKBKKKFPGM LLNDGAJEMEN, Dictionary<string, string> DIIDCLKBADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6296990", Offset = "0x6295990", VA = "0x186296990", Slot = "12")]
	public bool PCCNMJCBOCA(string CLGHJEOCFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6296BD0", Offset = "0x6295BD0", VA = "0x186296BD0", Slot = "13")]
	public GBFBAIMMGEP PLGLEDMAMOA(string GABKMFALOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6295BC0", Offset = "0x6294BC0", VA = "0x186295BC0", Slot = "14")]
	public CEEDGCKJFLK HKAOGPHEIDF(string PEFGAGJLFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x62950B0", Offset = "0x62940B0", VA = "0x1862950B0", Slot = "15")]
	public GBFBAIMMGEP AKOOFJLDGFA(string GLJMNMKNGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6295530", Offset = "0x6294530", VA = "0x186295530")]
	private NPHCNBHPDGE FAKNAGKGPOP(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62963D0", Offset = "0x62953D0", VA = "0x1862963D0")]
	private ANEJKMPFFMF JNFEJJCNBDP(string GHJMMHFPFLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62952E0", Offset = "0x62942E0", VA = "0x1862952E0")]
	private void EOFNMPJMOHO(string GABKMFALOME, GBFBAIMMGEP GKCAFNKAINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HBEMOMALKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xFBD7F0", Offset = "0xFBC7F0", VA = "0x180FBD7F0")]
	[CompilerGenerated]
	private void FKIAHADNDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6296900", Offset = "0x6295900", VA = "0x186296900")]
	[CompilerGenerated]
	private void MGKEHAGLGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6296340", Offset = "0x6295340", VA = "0x186296340")]
	[CompilerGenerated]
	private void JKBHDPNNBAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DEPDJBBDBDA : HHKOBIOAJAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private HHKOBIOAJAE BCPMJCGDEEA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private HHKOBIOAJAE IPKNMKDFBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62939B0", Offset = "0x62929B0", VA = "0x1862939B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LCLDHDEMAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x62937D0", Offset = "0x62927D0", VA = "0x1862937D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action FKFANDDHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6293B60", Offset = "0x6292B60", VA = "0x186293B60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6293AC0", Offset = "0x6292AC0", VA = "0x186293AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action HPEDCNEDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62940E0", Offset = "0x62930E0", VA = "0x1862940E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6293A20", Offset = "0x6292A20", VA = "0x186293A20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	[Preserve]
	public DEPDJBBDBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62938C0", Offset = "0x62928C0", VA = "0x1862938C0")]
	[JDLBAGCFHIO(MEDANDNEHIF.GameOnly)]
	private static void BBHGKGEMGEL(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6293E00", Offset = "0x6292E00", VA = "0x186293E00", Slot = "8")]
	public LLEFGLIPMKI JHHOMPLGCBC(string EDFCANILEGA, string GHJMMHFPFLD, [Optional] BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6293D00", Offset = "0x6292D00", VA = "0x186293D00", Slot = "10")]
	public LLEFGLIPMKI JGMOMHJLLCJ(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6294180", Offset = "0x6293180", VA = "0x186294180", Slot = "11")]
	public LLEFGLIPMKI LMOHIJMFKBH(BMKBKKKFPGM LLNDGAJEMEN, Dictionary<string, string> DIIDCLKBADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6294290", Offset = "0x6293290", VA = "0x186294290", Slot = "12")]
	public bool PCCNMJCBOCA(string CLGHJEOCFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6294430", Offset = "0x6293430", VA = "0x186294430", Slot = "13")]
	public GBFBAIMMGEP PLGLEDMAMOA(string GABKMFALOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6293C00", Offset = "0x6292C00", VA = "0x186293C00", Slot = "14")]
	public CEEDGCKJFLK HKAOGPHEIDF(string PEFGAGJLFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6293820", Offset = "0x6292820", VA = "0x186293820", Slot = "15")]
	public GBFBAIMMGEP AKOOFJLDGFA(string GLJMNMKNGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6294330", Offset = "0x6293330", VA = "0x186294330", Slot = "16")]
	public LLEFGLIPMKI PKGIJLCJAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xFF2C70", Offset = "0xFF1C70", VA = "0x180FF2C70")]
	[CompilerGenerated]
	private void INOLHLMKCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1431220", Offset = "0x1430220", VA = "0x181431220")]
	[CompilerGenerated]
	private void DIKFINJCEHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KBEPBJBONLD : HHKOBIOAJAE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LCLDHDEMAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FKFANDDHIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6297EF0", Offset = "0x6296EF0", VA = "0x186297EF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6297E50", Offset = "0x6296E50", VA = "0x186297E50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action HPEDCNEDFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x62980E0", Offset = "0x62970E0", VA = "0x1862980E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6297DB0", Offset = "0x6296DB0", VA = "0x186297DB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6298040", Offset = "0x6297040", VA = "0x186298040", Slot = "8")]
	public LLEFGLIPMKI JHHOMPLGCBC(string EDFCANILEGA, string GHJMMHFPFLD, [Optional] BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6297FA0", Offset = "0x6296FA0", VA = "0x186297FA0", Slot = "10")]
	public LLEFGLIPMKI JGMOMHJLLCJ(BMKBKKKFPGM LLNDGAJEMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6298180", Offset = "0x6297180", VA = "0x186298180", Slot = "11")]
	public LLEFGLIPMKI LMOHIJMFKBH(BMKBKKKFPGM LLNDGAJEMEN, Dictionary<string, string> DIIDCLKBADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "12")]
	public bool PCCNMJCBOCA(string CLGHJEOCFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6297DA0", Offset = "0x6296DA0", VA = "0x186297DA0", Slot = "13")]
	public GBFBAIMMGEP PLGLEDMAMOA(string GABKMFALOME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6297F90", Offset = "0x6296F90", VA = "0x186297F90", Slot = "14")]
	public CEEDGCKJFLK HKAOGPHEIDF(string PEFGAGJLFOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6297DA0", Offset = "0x6296DA0", VA = "0x186297DA0", Slot = "15")]
	public GBFBAIMMGEP AKOOFJLDGFA(string GLJMNMKNGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6298220", Offset = "0x6297220", VA = "0x186298220", Slot = "16")]
	public LLEFGLIPMKI PKGIJLCJAMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public KBEPBJBONLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JGGIFDMEBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFIDGPANHEB AOHIMCPPBGK(string EOPKCKAAGKI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FKDAHMCHFPK
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKNJODJHDLJ(string MFEOJPNCOBA, string HBAKLKJCKFJ, string KHKMPGGKJAB);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOGLKFCIFIN(string MFEOJPNCOBA);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHIIOCMDCMN(string MFEOJPNCOBA, string MAMBPAHAODF, string IBEAGGPPDML);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGOBCHGMECP(string HBCALMLKPIA, object HCIFABFJCFJ, object HLBKABOABPF);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPNEKINGIHN(long MFINFKIHBFD, bool FJFKKDFGEMC = true);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BMKBKKKFPGM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool KKGKOCOKCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FKCEMEPLEKL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DKGJOIGEINP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NCKAELDGNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool? DOFIKMKDPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int? CIIIINGBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int LNOEJOACJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string PEHDEINMEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string APPICCIADOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string PAMNLHOLMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string HDPPAGPEFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string LBKBALOGJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string BBGLDEPOMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	double HHEMHHPCNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
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

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public AmplitudeAnalyticsClient.Settings GAAJDAHHPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool GHNJFKCNGGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6FA3D0", Offset = "0x6F93D0", VA = "0x1806FA3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private enum KAJGECMFOJM
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		internal class BHLFBOCEKAA
		{
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			private class OGMMMFOBJEA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public int IGGNJGEKFIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public Dictionary<string, object> OEGFCLDNDML;

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
				public OGMMMFOBJEA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000015")]
			[CompilerGenerated]
			private sealed class PBOIMHKPFBP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
				public PBOIMHKPFBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x6299630", Offset = "0x6298630", VA = "0x186299630")]
				internal bool <GetBatch>b__0(OGMMMFOBJEA item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private const string FAEEGACMGCG = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly string NEIBENCLOEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private List<OGMMMFOBJEA> IPGMMPLNLMP;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			public int? JJFHPIDGMHO
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x6292BD0", Offset = "0x6291BD0", VA = "0x186292BD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public int? DHAFIAMOHAE
			{
				[Cpp2IlInjected.Token(Token = "0x60000AB")]
				[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291880", VA = "0x186292880")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6293640", Offset = "0x6292640", VA = "0x186293640")]
			internal BHLFBOCEKAA(string MCBLGGNJOGF, string GHJMMHFPFLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x62921A0", Offset = "0x62911A0", VA = "0x1862921A0")]
			public int DGHPBLBIJGC([Optional] int? NEJBOHEBLAL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6292940", Offset = "0x6291940", VA = "0x186292940")]
			public List<Dictionary<string, object>> GNKBICFENAO(int KAFFBMLEIBH, int? NEJBOHEBLAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6292440", Offset = "0x6291440", VA = "0x186292440")]
			public void DPNDLNMPHAM(AmplitudeAnalyticsIdentifyMessage AELIHOPICED, bool EOMOILKFGLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6292330", Offset = "0x6291330", VA = "0x186292330")]
			public void DPNDLNMPHAM(Dictionary<string, object> AELIHOPICED, bool EOMOILKFGLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x62934B0", Offset = "0x62924B0", VA = "0x1862934B0")]
			public void PILNPLNCIDJ(params Dictionary<string, object>[] AJIANFHALFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6293260", Offset = "0x6292260", VA = "0x186293260")]
			public void NPAKKLIAEOL(List<Dictionary<string, object>> DKGEFMDANEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6292C70", Offset = "0x6291C70", VA = "0x186292C70")]
			private void LFEFHJDMPLF(Dictionary<string, object> AELIHOPICED, bool EOMOILKFGLB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x62924E0", Offset = "0x62914E0", VA = "0x1862924E0")]
			public void FDBMJOBPIIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6292DB0", Offset = "0x6291DB0", VA = "0x186292DB0")]
			private void LJJFOIMPPOD([Optional] string NKGBJHPHBAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6292750", Offset = "0x6291750", VA = "0x186292750")]
			private static string GJEFCHLPLKG(string KPPLMEOMNGF, string EBOIOCBODNI)
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

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x629A260", Offset = "0x6299260", VA = "0x18629A260")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct CDBEMIMIICL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int FBMFHOLJFAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public string CLNMDJOHJHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T LMNMDNBFHIK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class GLLIBCOBHOI : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C4")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public GLLIBCOBHOI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6294A80", Offset = "0x6293A80", VA = "0x186294A80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6295070", Offset = "0x6294070", VA = "0x186295070", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class ELEJOHJCBOE : IEnumerator<object>, IEnumerator, IDisposable
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
			public LCFGHKNEPEI quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public ELEJOHJCBOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x6294650", Offset = "0x6293650", VA = "0x186294650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6294740", Offset = "0x6293740", VA = "0x186294740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KKCJOGLCDAD : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public KKCJOGLCDAD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x62985A0", Offset = "0x62975A0", VA = "0x1862985A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6298710", Offset = "0x6297710", VA = "0x186298710", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class JBHPPIGJFGM : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public JBHPPIGJFGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x6297AC0", Offset = "0x6296AC0", VA = "0x186297AC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6297D60", Offset = "0x6296D60", VA = "0x186297D60", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KDGOFAGIEBO : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DF")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public KDGOFAGIEBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x62982C0", Offset = "0x62972C0", VA = "0x1862982C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6298560", Offset = "0x6297560", VA = "0x186298560", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class PJAOGKNNPMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public BHLFBOCEKAA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public PJAOGKNNPMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6299690", Offset = "0x6298690", VA = "0x186299690")]
			internal void <FlushFromCache>b__0(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6299A00", Offset = "0x6298A00", VA = "0x186299A00")]
			internal void <FlushFromCache>b__1(CDBEMIMIICL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class MLEBIKOFEPI : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public BHLFBOCEKAA cache;

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
			private PJAOGKNNPMM <>8__1;

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

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public MLEBIKOFEPI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6298750", Offset = "0x6297750", VA = "0x186298750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6299020", Offset = "0x6298020", VA = "0x186299020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class FOBDFOHOCEI<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
			public FOBDFOHOCEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x2902A50", Offset = "0x2901A50", VA = "0x182902A50")]
			internal CDBEMIMIICL<T> <PostRudderStackJson>b__0(LIDLFEOFMGL postResponse)
			{
				return default(CDBEMIMIICL<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class FHCCGLNLKBD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
			public FHCCGLNLKBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2902A50", Offset = "0x2901A50", VA = "0x182902A50")]
			internal CDBEMIMIICL<T> <PostAmplitudeJson>b__0(LIDLFEOFMGL postResponse)
			{
				return default(CDBEMIMIICL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private JNBJAPHOFAJ CHMKOKPMNPD;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string DLIAJKHLAHI = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string CJANGNCNDMJ = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string LDFCHKIDGLJ = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const int MGLOODPGOLJ = 15;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int IBICKOKPIGF = 10;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int AFPKLADAELN = 5;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const float ANGPECCGAPI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private const long HNGPMABKDMP = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string NLDCHLFBDIN = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private const string AOKJDFCFNBF = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static bool IFIMLEKDOLF;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static bool JDLGHEHGIDN;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static int PCAIOBJAJOK;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static int BHJPAGBBJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private HFEIMCJKHGH OIPPFMONBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool MIHAHOPNOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private float PCNLBGCAJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private float AEELKDKDFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private int FJDAKHAFEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int HIIIIOMBIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int? EOMPGMHPLLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int? PPMDOFFCPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long AOGJMFJCAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private string DLMEBIOFIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private long JNFCLDAHHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private Dictionary<string, object> KFHDKGNGICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private KAJGECMFOJM PLHNOKBINDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private int NMKGAAIHIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int LECCBHCGAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private float PHFCHFPIMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private bool FEPONCBGNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private bool MLKGJCMOINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private BHLFBOCEKAA COHFBEIOCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private BHLFBOCEKAA DIJGLPOOMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private BHLFBOCEKAA ABEKAOAENNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JLBMGFIMILH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo PONAGPFKKHE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static string DAADCPJNOJO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const string BHBANBLNPJF = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly string ENOPBCAAHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly string FLNALPOLFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly string BOBGBHMMDJD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JNBJAPHOFAJ BAGJGBDEJFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x628BF00", Offset = "0x628AF00", VA = "0x18628BF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private static int KKCFOPODCON
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x628F270", Offset = "0x628E270", VA = "0x18628F270")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static long HHKIMIDIJII
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6290B10", Offset = "0x628FB10", VA = "0x186290B10")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6290C10", Offset = "0x628FC10", VA = "0x186290C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static string ELKAOBHIFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6290AB0", Offset = "0x628FAB0", VA = "0x186290AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static string CNFFHHPNLAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6290AE0", Offset = "0x628FAE0", VA = "0x186290AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string FPJLDBHDLFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6F5740", Offset = "0x6F4740", VA = "0x1806F5740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x716DC0", Offset = "0x715DC0", VA = "0x180716DC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int? CIIIINGBNPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x80F840", Offset = "0x80E840", VA = "0x18080F840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x19FC8F0", Offset = "0x19FB8F0", VA = "0x1819FC8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NNJLBNKIMCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x858820", Offset = "0x857820", VA = "0x180858820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x858920", Offset = "0x857920", VA = "0x180858920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static bool JLAPJLECKJA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x62909C0", Offset = "0x628F9C0", VA = "0x1862909C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<bool> KLBCMEMBBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6290920", Offset = "0x628F920", VA = "0x186290920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6290B70", Offset = "0x628FB70", VA = "0x186290B70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x628C200", Offset = "0x628B200", VA = "0x18628C200", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x628D600", Offset = "0x628C600", VA = "0x18628D600")]
		private void JEAICNEAKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6290170", Offset = "0x628F170", VA = "0x186290170")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x628F630", Offset = "0x628E630", VA = "0x18628F630", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6290460", Offset = "0x628F460", VA = "0x186290460")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x628F7D0", Offset = "0x628E7D0", VA = "0x18628F7D0")]
		public LLEFGLIPMKI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x628D570", Offset = "0x628C570", VA = "0x18628D570")]
		[IteratorStateMachine(typeof(GLLIBCOBHOI))]
		public IEnumerator<FEEMOJCDGJP> Initialize(AmplitudeAnalyticsEvent LFBACKMGDIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6290350", Offset = "0x628F350", VA = "0x186290350")]
		public void UpdateLastAliveTime(float BOIHBMKHANN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x628F560", Offset = "0x628E560", VA = "0x18628F560")]
		private LLEFGLIPMKI OPNKDJHKENM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x628CB50", Offset = "0x628BB50", VA = "0x18628CB50")]
		private LLEFGLIPMKI FKGMBJLAHNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x628FD20", Offset = "0x628ED20", VA = "0x18628FD20")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x628C5D0", Offset = "0x628B5D0", VA = "0x18628C5D0")]
		[IteratorStateMachine(typeof(ELEJOHJCBOE))]
		private IEnumerator CCHONAGIHKG(LCFGHKNEPEI PKIDGKFJLMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62906D0", Offset = "0x628F6D0", VA = "0x1862906D0")]
		[IteratorStateMachine(typeof(KKCJOGLCDAD))]
		public IEnumerator WaitForFlush(float FAMGKJPNCKD = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6290230", Offset = "0x628F230", VA = "0x186290230")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6290180", Offset = "0x628F180", VA = "0x186290180")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime PPIFMHEDLGN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x628D1C0", Offset = "0x628C1C0", VA = "0x18628D1C0")]
		public static GIMAEFMKNHN Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x628C060", Offset = "0x628B060", VA = "0x18628C060")]
		public static IEGHJCIAJCN AccountSelectionPostLoginEvent([NotNull] string JKBNEEENKCO, string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x628C940", Offset = "0x628B940", VA = "0x18628C940")]
		public static IEGHJCIAJCN Event([NotNull] string JKBNEEENKCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x628F830", Offset = "0x628E830", VA = "0x18628F830")]
		public static IEGHJCIAJCN PreviousSessionEvent([NotNull] string JKBNEEENKCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x628D320", Offset = "0x628C320", VA = "0x18628D320")]
		public static IEGHJCIAJCN InitializeEvent(string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x628FE80", Offset = "0x628EE80", VA = "0x18628FE80")]
		public static IEGHJCIAJCN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x628C660", Offset = "0x628B660", VA = "0x18628C660")]
		public static IEGHJCIAJCN CreateOutOfSessionEvent(string JKBNEEENKCO, bool GMNGBKGNOFG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x628ED30", Offset = "0x628DD30", VA = "0x18628ED30")]
		public static LLEFGLIPMKI LogOutOfSessionEvent(IEGHJCIAJCN ONCOCGENLMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x628EA70", Offset = "0x628DA70", VA = "0x18628EA70")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FOCJFPDDOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x628F040", Offset = "0x628E040", VA = "0x18628F040")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FOCJFPDDOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x628F190", Offset = "0x628E190", VA = "0x18628F190")]
		public void LogSerializedEventAsync(Dictionary<string, object> KANPCFLGKEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x628EBC0", Offset = "0x628DBC0", VA = "0x18628EBC0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EEEBBLOPMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x628C4F0", Offset = "0x628B4F0", VA = "0x18628C4F0")]
		private void BKPFEIOBPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x628BB90", Offset = "0x628AB90", VA = "0x18628BB90")]
		private void ABANHKPDFOH(Dictionary<string, object> CHENOCAGDJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x628BF70", Offset = "0x628AF70", VA = "0x18628BF70")]
		private void APDECMNNAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x628CE80", Offset = "0x628BE80", VA = "0x18628CE80")]
		private void GGLBAGKDKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x628CDF0", Offset = "0x628BDF0", VA = "0x18628CDF0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x628F6D0", Offset = "0x628E6D0", VA = "0x18628F6D0")]
		[IteratorStateMachine(typeof(JBHPPIGJFGM))]
		private IEnumerator<FEEMOJCDGJP> PGIDDFKLIMF(float FAMGKJPNCKD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x628F750", Offset = "0x628E750", VA = "0x18628F750")]
		[IteratorStateMachine(typeof(KDGOFAGIEBO))]
		private IEnumerator<FEEMOJCDGJP> PMAHFOADIBL(float FAMGKJPNCKD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x628BE20", Offset = "0x628AE20", VA = "0x18628BE20")]
		[IteratorStateMachine(typeof(MLEBIKOFEPI))]
		private IEnumerator<FEEMOJCDGJP> AGBPIJKBFPH(BHLFBOCEKAA DAJPKNFIFBB, int? NEJBOHEBLAL, string JLEDGILHJAD, string LKFKOOKCPKH, float FAMGKJPNCKD, Action<int> FLEGJKGJGKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x628F440", Offset = "0x628E440", VA = "0x18628F440")]
		private static void ONFJGDHCIPM(bool MIFCLBGJBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x628E670", Offset = "0x628D670", VA = "0x18628E670")]
		private global::MLDKKGKEACN<CDBEMIMIICL<Dictionary<string, object>>> LJPKGDKBFAL(string JLEDGILHJAD, string LKFKOOKCPKH, string MKCBFKGFGDB, string DHNMIKKKHCL, Dictionary<string, object> LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x628E7A0", Offset = "0x628D7A0", VA = "0x18628E7A0")]
		private global::MLDKKGKEACN<CDBEMIMIICL<List<Dictionary<string, object>>>> LJPKGDKBFAL(string JLEDGILHJAD, string LKFKOOKCPKH, string MKCBFKGFGDB, string DHNMIKKKHCL, List<Dictionary<string, object>> LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x37D0790", Offset = "0x37CF790", VA = "0x1837D0790")]
		private global::MLDKKGKEACN<CDBEMIMIICL<T>> FLABLJANLEJ<T>(string JLEDGILHJAD, string LKFKOOKCPKH, string DHNMIKKKHCL, T LMNMDNBFHIK, Dictionary<string, object> GHBFCPCHCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x37D0A20", Offset = "0x37CFA20", VA = "0x1837D0A20")]
		private global::MLDKKGKEACN<CDBEMIMIICL<T>> NMEGNJNFKGI<T>(string JLEDGILHJAD, string LKFKOOKCPKH, string MKCBFKGFGDB, T LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x628D920", Offset = "0x628C920", VA = "0x18628D920")]
		private bool KNBFOIAOMLL(float ADFLOADHGMB, float FAMGKJPNCKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x628D970", Offset = "0x628C970", VA = "0x18628D970")]
		private Dictionary<string, object> LDCJNDCEPFG(string LKFKOOKCPKH, Dictionary<string, object> LMNMDNBFHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62907B0", Offset = "0x628F7B0", VA = "0x1862907B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x628D060", Offset = "0x628C060", VA = "0x18628D060")]
		[CompilerGenerated]
		private long IJJCNLFKAPN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x628CB40", Offset = "0x628BB40", VA = "0x18628CB40")]
		[CompilerGenerated]
		private void FDMOHIAPNNF(int HBBLFLEPMGB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x62917E0", Offset = "0x62907E0", VA = "0x1862917E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6291840", Offset = "0x6290840", VA = "0x186291840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6F5780", Offset = "0x6F4780", VA = "0x1806F5780")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6290C70", Offset = "0x628FC70", VA = "0x186290C70")]
		public static IEGHJCIAJCN BMDGCEOIEEG(string LFMBJAIIPEH, [NotNull] string JFCJMBGMPGA, long MFINFKIHBFD, long HFHONBKKAPE, string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6290F10", Offset = "0x628FF10", VA = "0x186290F10")]
		public static IEGHJCIAJCN GNALPPOHMCG(string LFMBJAIIPEH, [NotNull] string JFCJMBGMPGA, long MFINFKIHBFD, long HFHONBKKAPE, string NHKNPEOCEFN, long DOMMNCONNPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6291620", Offset = "0x6290620", VA = "0x186291620")]
		private AmplitudeAnalyticsEvent(string LFMBJAIIPEH, [NotNull] string JFCJMBGMPGA, long MFINFKIHBFD, long HFHONBKKAPE, string NHKNPEOCEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x91EFD0", Offset = "0x91DFD0", VA = "0x18091EFD0")]
		public void OIAKKBBCECF(long BFOFGLGBOKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6291500", Offset = "0x6290500", VA = "0x186291500", Slot = "5")]
		public override void NIAHKKJKGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6290D60", Offset = "0x628FD60", VA = "0x186290D60", Slot = "6")]
		public override void FBLOOOIBLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6291010", Offset = "0x6290010", VA = "0x186291010", Slot = "4")]
		protected override Dictionary<string, object> JAPOOBBOKEB(Dictionary<string, object> NAGKFCEIELD)
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
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x62944D0", Offset = "0x62934D0", VA = "0x1862944D0")]
			public void GPLCBJOPGPC(Dictionary<string, object> BFOMMKIPAIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6299EA0", Offset = "0x6298EA0", VA = "0x186299EA0")]
			public void GPLCBJOPGPC(Dictionary<string, object> DBJNFKDCLAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x13F85D0", Offset = "0x13F75D0", VA = "0x1813F85D0")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6291930", Offset = "0x6290930", VA = "0x186291930")]
		public static GIMAEFMKNHN BMDGCEOIEEG(string LFMBJAIIPEH, string NHKNPEOCEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6291F30", Offset = "0x6290F30", VA = "0x186291F30")]
		protected AmplitudeAnalyticsIdentifyMessage(string LFMBJAIIPEH, string NHKNPEOCEFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x62918B0", Offset = "0x62908B0", VA = "0x1862918B0")]
		public Dictionary<string, object> ABLLGKJDBLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6291A60", Offset = "0x6290A60", VA = "0x186291A60", Slot = "4")]
		protected virtual Dictionary<string, object> JAPOOBBOKEB(Dictionary<string, object> NAGKFCEIELD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6291E10", Offset = "0x6290E10", VA = "0x186291E10")]
		protected void MADEPHHLPOE(string EBOIOCBODNI, Dictionary<string, object> HECELBFBPAE, Dictionary<string, object> KEDJDOBMKEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6291DA0", Offset = "0x6290DA0", VA = "0x186291DA0")]
		protected void JEKKPGJLBEG(string EBOIOCBODNI, string KPPLMEOMNGF, Dictionary<string, object> INAFJIMICJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6291EB0", Offset = "0x6290EB0", VA = "0x186291EB0", Slot = "5")]
		public virtual void NIAHKKJKGBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62919E0", Offset = "0x62909E0", VA = "0x1862919E0", Slot = "6")]
		public virtual void FBLOOOIBLFB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GIMAEFMKNHN : global::LHLAMMNOOJD<AmplitudeAnalyticsIdentifyMessage, GIMAEFMKNHN>
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public override GIMAEFMKNHN DMOOBPCCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FCE20", VA = "0x1807FDE20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage KOFGCLOCOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6294A30", Offset = "0x6293A30", VA = "0x186294A30")]
	public GIMAEFMKNHN(AmplitudeAnalyticsIdentifyMessage GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6294990", Offset = "0x6293990", VA = "0x186294990", Slot = "4")]
	public override void FBLOOOIBLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class IEGHJCIAJCN : global::LHLAMMNOOJD<AmplitudeAnalyticsEvent, IEGHJCIAJCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private bool CKPDEIBIMKG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public override IEGHJCIAJCN DMOOBPCCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FCE20", VA = "0x1807FDE20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public long EDPIKKKIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x37453A0", Offset = "0x37443A0", VA = "0x1837453A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6294940", Offset = "0x6293940", VA = "0x186294940")]
	public IEGHJCIAJCN(AmplitudeAnalyticsEvent GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent KOFGCLOCOHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62974F0", Offset = "0x62964F0", VA = "0x1862974F0", Slot = "4")]
	public override void FBLOOOIBLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x62977F0", Offset = "0x62967F0", VA = "0x1862977F0")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, long[] KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x62976B0", Offset = "0x62966B0", VA = "0x1862976B0")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, ulong[] KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x22CB110", Offset = "0x22CA110", VA = "0x1822CB110")]
	public IEGHJCIAJCN GLKICEEPKDG<T>(string MLIELKFMALM, T[] KPPLMEOMNGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62979C0", Offset = "0x62969C0", VA = "0x1862979C0")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, string[] KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x22CB0A0", Offset = "0x22CA0A0", VA = "0x1822CB0A0")]
	public IEGHJCIAJCN GLKICEEPKDG<T>(string MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6297930", Offset = "0x6296930", VA = "0x186297930")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, long KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x62975B0", Offset = "0x62965B0", VA = "0x1862975B0")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, ulong KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6297640", Offset = "0x6296640", VA = "0x186297640")]
	public IEGHJCIAJCN GLKICEEPKDG(string MLIELKFMALM, string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6297590", Offset = "0x6296590", VA = "0x186297590")]
	public IEGHJCIAJCN GCENMFNAEBG(string MLIELKFMALM, object? KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6297450", Offset = "0x6296450", VA = "0x186297450")]
	public IEGHJCIAJCN EOBEBFJIDPO(string MLIELKFMALM, string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x62979D0", Offset = "0x62969D0", VA = "0x1862979D0")]
	private IEGHJCIAJCN PBJGKDPCCEL(string MLIELKFMALM, object KPPLMEOMNGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FEBPOBPPPNF : IEGHJCIAJCN
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6294940", Offset = "0x6293940", VA = "0x186294940")]
	public FEBPOBPPPNF(AmplitudeAnalyticsEvent GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6294780", Offset = "0x6293780", VA = "0x186294780", Slot = "4")]
	public override void FBLOOOIBLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class LHLAMMNOOJD<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : global::LHLAMMNOOJD<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected M GOMILMNIGIC;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public abstract BLDR DMOOBPCCDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x20293C0", Offset = "0x20283C0", VA = "0x1820293C0")]
	public LHLAMMNOOJD(M GOMILMNIGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2605C40", Offset = "0x2604C40", VA = "0x182605C40")]
	public BLDR HPOJBNOPBPJ(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ICFIIPJFFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2605940", Offset = "0x2604940", VA = "0x182605940")]
	public BLDR BJBGGFDLNDG(AmplitudeAnalyticsIdentifyMessage.RevenueData KLHIGGHGGAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2605B20", Offset = "0x2604B20", VA = "0x182605B20")]
	public BLDR DAACNBEOEOD(string MLIELKFMALM, string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2621A20", Offset = "0x2620A20", VA = "0x182621A20")]
	public BLDR DAACNBEOEOD<T>(string MLIELKFMALM, T KPPLMEOMNGF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2605A70", Offset = "0x2604A70", VA = "0x182605A70")]
	public BLDR DAACNBEOEOD(string MLIELKFMALM, long KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2605B90", Offset = "0x2604B90", VA = "0x182605B90")]
	public BLDR DAACNBEOEOD(string MLIELKFMALM, ulong KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FBLOOOIBLFB();

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2605C80", Offset = "0x2604C80", VA = "0x182605C80")]
	internal static string IJIFIFBHEFL(string KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2605980", Offset = "0x2604980", VA = "0x182605980")]
	private BLDR CGOAHEFMBLB(string MLIELKFMALM, object KPPLMEOMNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M KOFGCLOCOHF();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OAIGHHAOLHF
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public const string EKPKCDKFNCJ = "batch";

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public const string IFFGBGNPHGI = "type";

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public const string FJMEJJBEJPB = "identify";

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public const string IGFDICOIMCH = "track";

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public const string FMNKPLEHCFM = "userId";

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const string LCEACKBLPCF = "anonymousId";

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const string OGNILEHFMHH = "messageId";

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public const string DAHDPMPFBBJ = "event";

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public const string OFOLOPAOPPM = "version";

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public const string HDJJBDLDNNC = "locale";

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public const string OEIMMMNKKAO = "name";

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public const string AGGPHMKBOPD = "properties";

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public const string LBAIHDEOCCD = "traits";

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public const string OJPHPKMKEHE = "context";

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const string LGCNFMAACCA = "app";

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public const string HHLBHODKJJL = "os";

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public const string JJGKGKMDJHH = "device";

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public const string PLDADECIPHK = "originalTimestamp";

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public const string DJNHMEGIPOK = "brand";

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public const string EKOFLDAAPLP = "manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public const string GFLCAGNPHOM = "model";

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public const string FMGAKOLMFMN = "type";

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public OAIGHHAOLHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BDHBMPJAEDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public const int MEAPNICADKL = 2;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const int JACEKKLLKFH = 100;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public const int MECLHJMGNEP = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public const long OCEDLEPJGFN = 1800000L;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public const int IAOCMOPJHAI = 1024;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public const int HKEFHCABDHN = 1000;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public const string KJMJHEMHIIA = "amplitude_sequence_number";

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public const string DKEHBCODDAL = "amplitude_user_id";

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public const string EOCGIOIKEIB = "amplitude_last_time";

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public const string ELNHELCCKME = "initialize_analytics";

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public const string DMODPHMEGMH = "session_start";

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public const string DLOEGHIFMEM = "session_end";

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public const string BMKGKAHFLLN = "insert_id";

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public const string ILGKGOFMJMP = "event_time";

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public const string GLKEDPPFCDJ = "session_id";

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public const string PADJFPLIEBL = "session_tracking_data";

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public const string CLIGGMJKBAF = "user_properties";

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public const string NFCNDIJMJDI = "app_version";

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public const string JKFGLCCAKHO = "ip";

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public const string MAMPBDBAODH = "language";

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public const string OOLLCIFDHPP = "platform";

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public const string LCDOEMLDNIB = "os_name";

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public const string JIOODNODMMI = "os_version";

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public const string KJKEDEIOMBK = "device_brand";

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public const string JHINIHKLAKL = "device_manufacturer";

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public const string PLNBBLAINCK = "device_model";

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public const string ADCHGMJBKHL = "device_type";

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public const string ADDKHAJEDDD = "price";

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public const string LCJIALGIMHE = "quantity";

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public const string AHGFJHFAMAF = "revenue";

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public const string NINDGBGDDFE = "productId";

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public const string FGACDAPAJKP = "revenueType";

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public const string MDHAMIGPOCG = "event_type";

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public const string FMNKPLEHCFM = "user_id";

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public const string GLHPCAFAAMI = "event_properties";

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public const int BCPBONAIADI = 10;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> GEEHNCHANNK;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6291FF0", Offset = "0x6290FF0", VA = "0x186291FF0")]
	internal static bool OCAMBHIJLAI(string EBOIOCBODNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public BDHBMPJAEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HFEIMCJKHGH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool OJKDPOFOLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string OJKDIKJNKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string DEMEDBHHEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string JIEGGMPODJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string PEJAJIIKAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::MLDKKGKEACN<LIDLFEOFMGL> LJPKGDKBFAL(string JLEDGILHJAD, Dictionary<string, string> EIBLJDCOKAN, bool KMMHANFEIOL = false);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "6")]
	global::MLDKKGKEACN<LIDLFEOFMGL> MPJPKCJDBFN(string JLEDGILHJAD, string HAHECJIJMBJ, string FIBKGBBGEPM, string NAFMPBJOPMF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct LIDLFEOFMGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly int AGFNINAPMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string FEDHIKMHINN;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x70A0B0", Offset = "0x7090B0", VA = "0x18070A0B0")]
	public LIDLFEOFMGL(int FBMFHOLJFAJ, string CLNMDJOHJHK)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6296E20", Offset = "0x6295E20", VA = "0x186296E20")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6296F30", Offset = "0x6295F30", VA = "0x186296F30")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
